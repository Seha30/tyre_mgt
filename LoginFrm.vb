Imports MySql.Data.MySqlClient

Public Class LoginFrm
    Dim conn As New MySqlConnection("server=localhost;userid=root;password=;database=inventory")

    Private Sub LoginFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmblogrole.Items.Add("Admin")
        cmblogrole.Items.Add("Manager")
        cmblogrole.Items.Add("Cashier")
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim username As String = txtlogusername.Text.Trim()
        Dim password As String = txtlogpword.Text.Trim()
        Dim role As String = cmblogrole.Text.Trim()

        ' ✅ Validation checks
        If String.IsNullOrEmpty(username) Then
            MessageBox.Show("Username cannot be empty!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtlogusername.Focus()
            Exit Sub
        End If

        If String.IsNullOrEmpty(password) Then
            MessageBox.Show("Password cannot be empty!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtlogpword.Focus()
            Exit Sub
        End If

        If password.Length < 4 Then
            MessageBox.Show("Password must be at least 4 characters long!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtlogpword.Focus()
            Exit Sub
        End If

        If String.IsNullOrEmpty(role) Then
            MessageBox.Show("Please select a role!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            cmblogrole.Focus()
            Exit Sub
        End If

        ' ✅ Database check
        Try
            conn.Open()
            Dim cmd As New MySqlCommand("SELECT * FROM staff WHERE s_name=@user AND s_password=@pass AND s_role=@role", conn)
            cmd.Parameters.AddWithValue("@user", username)
            cmd.Parameters.AddWithValue("@pass", password)
            cmd.Parameters.AddWithValue("@role", role)

            Dim reader As MySqlDataReader = cmd.ExecuteReader()
            If reader.Read() Then
                MessageBox.Show("Login Successful!", "Welcome", MessageBoxButtons.OK, MessageBoxIcon.Information)

                ' ✅ Step 3: Pass session info to MainMenu
                Dim frm As New MainMenu()
                frm.CurrentUser = username
                frm.CurrentRole = role
                frm.Show()

                Me.Hide()




            Else
                MessageBox.Show("Invalid Username, Password, or Role!", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
            conn.Close()
        Catch ex As Exception
            MessageBox.Show("Database Error: " & ex.Message)
        End Try

        ' ✅ Clear fields after attempt
        txtlogusername.Clear()
        txtlogpword.Clear()
        cmblogrole.SelectedIndex = -1
    End Sub
End Class




























'Public Class LoginFrm

'    Private Sub LoginFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
'        cmbrole.Items.Add("Admin")
'        cmbrole.Items.Add("Manager")
'        cmbrole.Items.Add("Cashier")


'        'LoadClientDataToGrid()
'    End Sub

'    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
'        Dim username As String = txtaddusername.Text
'        Dim password As String = txtaddpword.Text
'        Dim role As String = cmbrole.Text

'        'AddUser(username, password, role)
'        'txtaddusername.Text = ""   < -- this is the same as Clear() method
'        txtaddusername.Clear()
'        txtaddpword.Clear()
'        ' cmbrole.Clear()

'    End Sub
'End Class