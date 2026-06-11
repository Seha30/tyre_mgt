Imports MySql.Data.MySqlClient

Public Class LoginFrm

    Private Sub LoginFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' UiThemeHelper.StylePrimaryButton(btnLogin)
        txtlogusername.Focus()
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim username As String = txtlogusername.Text.Trim()
        Dim password As String = txtlogpword.Text.Trim()

        Dim v = ValidationHelper.ValidateLogin(username, password)
        If Not ValidationHelper.ShowIfInvalid(v) Then Return

        Try
            Using conn As MySqlConnection = GetConnection()
                Dim role As String = TryLogin(conn, username, password, "password_hash")
                If role Is Nothing Then
                    role = TryLogin(conn, username, password, "password")
                End If
                If role IsNot Nothing Then
                    OpenMain(username, role)
                    Me.Hide()
                    Return
                End If
            End Using
            MessageBox.Show("Invalid username or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            MessageBox.Show("Database error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ''' <summary>Login using password_hash (new schema) or password (old schema).</summary>
    Private Function TryLogin(conn As MySqlConnection, username As String, password As String, passwordColumn As String) As String
        Try
            Dim query As String = "SELECT r.role_name FROM users u " &
                "JOIN roles r ON u.role_id = r.role_id " &
                "WHERE LOWER(u.username)=LOWER(@user) AND u." & passwordColumn & "=@pass"
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@user", username)
                cmd.Parameters.AddWithValue("@pass", password)
                Dim result = cmd.ExecuteScalar()
                If result IsNot Nothing AndAlso result IsNot DBNull.Value Then
                    Return result.ToString()
                End If
            End Using
        Catch ex As MySqlException
            ' Unknown column = wrong schema column name; ignore and try other column
            If Not ex.Message.Contains("Unknown column") Then Throw
        End Try
        Return Nothing
    End Function

    Private Sub OpenMain(username As String, role As String)
        Dim frm As New MainMenu()
        frm.CurrentUser = username
        Select Case role
            Case "Admin" : frm.CurrentRole = "Admin"
            Case "Manager" : frm.CurrentRole = "Manager"
            Case "Cashier" : frm.CurrentRole = "Cashier"
            Case Else
                MessageBox.Show("Role not recognized.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
        End Select
        frm.Show()
    End Sub


End Class
