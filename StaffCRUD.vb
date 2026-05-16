Imports MySql.Data.MySqlClient

Module StaffCRUD

    Public Function LoadStaff() As DataTable
        Dim dt As New DataTable()
        Using conn As MySqlConnection = GetConnection()
            Dim sql = "SELECT u.user_id, u.username, u.full_name, u.phone, r.role_name, u.is_active FROM users u JOIN roles r ON u.role_id=r.role_id ORDER BY u.username"
            Using da As New MySqlDataAdapter(sql, conn)
                da.Fill(dt)
            End Using
        End Using
        Return dt
    End Function

    Public Sub AddStaff(username As String, password As String, fullName As String, phone As String, roleName As String)
        Using conn As MySqlConnection = GetConnection()
            Dim roleId = GetRoleId(conn, roleName)
            Dim sql = "INSERT INTO users (username,password_hash,full_name,phone,role_id,is_active) VALUES (@u,@p,@f,@ph,@r,1)"
            Using cmd As New MySqlCommand(sql, conn)
                cmd.Parameters.AddWithValue("@u", username)
                cmd.Parameters.AddWithValue("@p", password)
                cmd.Parameters.AddWithValue("@f", fullName)
                cmd.Parameters.AddWithValue("@ph", If(String.IsNullOrWhiteSpace(phone), DBNull.Value, phone))
                cmd.Parameters.AddWithValue("@r", roleId)
                cmd.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    Public Sub UpdateStaff(userId As Integer, username As String, fullName As String, phone As String, roleName As String, isActive As Boolean, Optional newPassword As String = Nothing)
        Using conn As MySqlConnection = GetConnection()
            Dim roleId = GetRoleId(conn, roleName)
            Dim sql = "UPDATE users SET username=@u, full_name=@f, phone=@ph, role_id=@r, is_active=@a"
            If Not String.IsNullOrWhiteSpace(newPassword) Then sql &= ", password_hash=@p"
            sql &= " WHERE user_id=@id"
            Using cmd As New MySqlCommand(sql, conn)
                cmd.Parameters.AddWithValue("@id", userId)
                cmd.Parameters.AddWithValue("@u", username)
                cmd.Parameters.AddWithValue("@f", fullName)
                cmd.Parameters.AddWithValue("@ph", If(String.IsNullOrWhiteSpace(phone), DBNull.Value, phone))
                cmd.Parameters.AddWithValue("@r", roleId)
                cmd.Parameters.AddWithValue("@a", If(isActive, 1, 0))
                If Not String.IsNullOrWhiteSpace(newPassword) Then cmd.Parameters.AddWithValue("@p", newPassword)
                cmd.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    Private Function GetRoleId(conn As MySqlConnection, roleName As String) As Integer
        Using cmd As New MySqlCommand("SELECT role_id FROM roles WHERE role_name=@n", conn)
            cmd.Parameters.AddWithValue("@n", roleName)
            Return CInt(cmd.ExecuteScalar())
        End Using
    End Function

End Module
