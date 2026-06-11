Public Class ProfileFrm

    Public Property LoggedInUsername As String

    Private profile As UserProfile

    Private Sub ProfileFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'UiThemeHelper.StyleGroupBox(grpAccount)
        'UiThemeHelper.StyleGroupBox(grpPassword)
        'UiThemeHelper.StylePrimaryButton(btnSaveProfile)
        'UiThemeHelper.StyleSecondaryButton(btnClearProfile)
        LoadProfileData()
    End Sub

    Private Sub LoadProfileData()
        If String.IsNullOrWhiteSpace(LoggedInUsername) Then
            MessageBox.Show("No user session found.", "Profile", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        profile = ProfileCRUD.GetProfileByUsername(LoggedInUsername)
        If profile Is Nothing Then
            MessageBox.Show("Could not load profile.", "Profile", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        txtUsername.Text = profile.Username
        txtFullName.Text = profile.FullName
        txtPhone.Text = profile.Phone
        txtMemberSince.Text = If(profile.CreatedAt.HasValue, profile.CreatedAt.Value.ToString("dd MMM yyyy"), "—")

        lblProfileName.Text = profile.FullName
        lblProfileRole.Text = profile.RoleName
        lblInitials.Text = GetInitials(profile.FullName)
    End Sub

    Private Function GetInitials(name As String) As String
        Dim parts = name.Trim().Split({" "c}, StringSplitOptions.RemoveEmptyEntries)
        If parts.Length = 0 Then Return "?"
        If parts.Length = 1 Then Return parts(0).Substring(0, Math.Min(2, parts(0).Length)).ToUpper()
        Return (parts(0)(0).ToString() & parts(parts.Length - 1)(0).ToString()).ToUpper()
    End Function

    Private Sub btnSaveProfile_Click(sender As Object, e As EventArgs) Handles btnSaveProfile.Click
        If profile Is Nothing Then Return

        Dim v = ValidationHelper.RequireText(txtFullName.Text, "Full name", 100)
        If Not ValidationHelper.ShowIfInvalid(v) Then Return

        If Not String.IsNullOrWhiteSpace(txtPhone.Text) Then
            v = ValidationHelper.ValidatePhone(txtPhone.Text)
            If Not ValidationHelper.ShowIfInvalid(v) Then Return
        End If

        Dim newPwd As String = Nothing
        Dim changingPassword = Not String.IsNullOrWhiteSpace(txtNewPassword.Text) OrElse
                               Not String.IsNullOrWhiteSpace(txtConfirmPassword.Text) OrElse
                               Not String.IsNullOrWhiteSpace(txtCurrentPassword.Text)

        If changingPassword Then
            If String.IsNullOrWhiteSpace(txtCurrentPassword.Text) Then
                MessageBox.Show("Enter your current password to set a new one.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If
            If Not ProfileCRUD.VerifyPassword(profile.Username, txtCurrentPassword.Text) Then
                MessageBox.Show("Current password is incorrect.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If
            v = ValidationHelper.ValidateLogin(profile.Username, txtNewPassword.Text)
            If Not ValidationHelper.ShowIfInvalid(v) Then Return
            If txtNewPassword.Text <> txtConfirmPassword.Text Then
                MessageBox.Show("New password and confirmation do not match.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If
            newPwd = txtNewPassword.Text
        End If

        Try
            ProfileCRUD.UpdateProfile(profile.UserId, txtFullName.Text.Trim(), txtPhone.Text.Trim(), newPwd)
            MessageBox.Show("Profile updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ClearPasswordFields()
            LoadProfileData()
            UpdateMainMenuWelcome()
        Catch ex As Exception
            MessageBox.Show("Error saving profile: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub UpdateMainMenuWelcome()
        Dim p = Me.Parent
        While p IsNot Nothing
            If TypeOf p Is MainMenu Then
                Dim main = DirectCast(p, MainMenu)
                main.CurrentUser = profile.Username
                main.RefreshWelcomeLabel(txtFullName.Text.Trim())
                Exit While
            End If
            p = p.Parent
        End While
    End Sub

    Private Sub btnClearProfile_Click(sender As Object, e As EventArgs) Handles btnClearProfile.Click
        ClearPasswordFields()
    End Sub

    Private Sub ClearPasswordFields()
        txtCurrentPassword.Clear()
        txtNewPassword.Clear()
        txtConfirmPassword.Clear()
    End Sub

    Private Sub pnlHeader_Paint(sender As Object, e As PaintEventArgs) Handles pnlHeader.Paint

    End Sub
End Class
