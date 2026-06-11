Imports MySql.Data.MySqlClient

''' <summary>Logged-in user's own profile (read/update).</summary>
Public Class UserProfile
    Public Property UserId As Integer
    Public Property Username As String
    Public Property FullName As String
    Public Property Phone As String
    Public Property RoleName As String
    Public Property CreatedAt As DateTime?
End Class

Module ProfileCRUD

    Public Function GetProfileByUsername(username As String) As UserProfile
        Using conn As MySqlConnection = GetConnection()
            Try
                Return LoadProfile(conn, username, useFullSchema:=True)
            Catch ex As MySqlException
                If ex.Message.Contains("Unknown column") Then
                    Return LoadProfile(conn, username, useFullSchema:=False)
                End If
                Throw
            End Try
        End Using
    End Function

    Private Function LoadProfile(conn As MySqlConnection, username As String, useFullSchema As Boolean) As UserProfile
        Dim sql As String
        If useFullSchema Then
            sql = "SELECT u.user_id, u.username, u.full_name, u.phone, r.role_name, u.created_at " &
                  "FROM users u JOIN roles r ON u.role_id=r.role_id " &
                  "WHERE LOWER(u.username)=LOWER(@user) LIMIT 1"
        Else
            sql = "SELECT u.user_id, u.username, u.username AS full_name, NULL AS phone, r.role_name, NULL AS created_at " &
                  "FROM users u JOIN roles r ON u.role_id=r.role_id " &
                  "WHERE LOWER(u.username)=LOWER(@user) LIMIT 1"
        End If

        Using cmd As New MySqlCommand(sql, conn)
            cmd.Parameters.AddWithValue("@user", username)
            Using reader = cmd.ExecuteReader()
                If Not reader.Read() Then Return Nothing
                Dim p As New UserProfile With {
                    .UserId = CInt(reader("user_id")),
                    .Username = reader("username").ToString(),
                    .FullName = If(reader("full_name") Is DBNull.Value, reader("username").ToString(), reader("full_name").ToString()),
                    .Phone = If(reader("phone") Is DBNull.Value, "", reader("phone").ToString()),
                    .RoleName = reader("role_name").ToString()
                }
                If Not reader("created_at") Is DBNull.Value Then
                    p.CreatedAt = CDate(reader("created_at"))
                End If
                Return p
            End Using
        End Using
    End Function

    Public Function VerifyPassword(username As String, password As String) As Boolean
        Using conn As MySqlConnection = GetConnection()
            If CheckPassword(conn, username, password, "password_hash") Then Return True
            Return CheckPassword(conn, username, password, "password")
        End Using
    End Function

    Private Function CheckPassword(conn As MySqlConnection, username As String, password As String, col As String) As Boolean
        Try
            Dim sql = "SELECT COUNT(*) FROM users WHERE LOWER(username)=LOWER(@user) AND " & col & "=@pass"
            Using cmd As New MySqlCommand(sql, conn)
                cmd.Parameters.AddWithValue("@user", username)
                cmd.Parameters.AddWithValue("@pass", password)
                Return Convert.ToInt32(cmd.ExecuteScalar()) > 0
            End Using
        Catch ex As MySqlException
            If ex.Message.Contains("Unknown column") Then Return False
            Throw
        End Try
    End Function

    Public Sub UpdateProfile(userId As Integer, fullName As String, phone As String, Optional newPassword As String = Nothing)
        Using conn As MySqlConnection = GetConnection()
            Try
                Dim sql = "UPDATE users SET full_name=@f, phone=@ph"
                If Not String.IsNullOrWhiteSpace(newPassword) Then sql &= ", password_hash=@p"
                sql &= " WHERE user_id=@id"
                Using cmd As New MySqlCommand(sql, conn)
                    cmd.Parameters.AddWithValue("@id", userId)
                    cmd.Parameters.AddWithValue("@f", fullName.Trim())
                    cmd.Parameters.AddWithValue("@ph", If(String.IsNullOrWhiteSpace(phone), DBNull.Value, phone.Trim()))
                    If Not String.IsNullOrWhiteSpace(newPassword) Then cmd.Parameters.AddWithValue("@p", newPassword)
                    cmd.ExecuteNonQuery()
                End Using
            Catch ex As MySqlException
                If ex.Message.Contains("Unknown column") AndAlso Not String.IsNullOrWhiteSpace(newPassword) Then
                    Using cmd As New MySqlCommand("UPDATE users SET password=@p WHERE user_id=@id", conn)
                        cmd.Parameters.AddWithValue("@id", userId)
                        cmd.Parameters.AddWithValue("@p", newPassword)
                        cmd.ExecuteNonQuery()
                    End Using
                ElseIf ex.Message.Contains("Unknown column") Then
                    ' Legacy schema without full_name — skip profile fields
                Else
                    Throw
                End If
            End Try
        End Using
    End Sub

End Module
