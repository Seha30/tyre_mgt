Public Class Settings

    Private Sub Settings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'UiThemeHelper.StyleGroupBox(grpShop)
        'UiThemeHelper.StylePrimaryButton(btnSaveSettings)
    End Sub

    Private Sub btnSaveSettings_Click(sender As Object, e As EventArgs) Handles btnSaveSettings.Click
        Dim v = ValidationHelper.RequireText(txtShopName.Text, "Shop name", 150)
        If Not ValidationHelper.ShowIfInvalid(v) Then Return
        v = ValidationHelper.ValidatePhone(txtShopPhone.Text, "Shop phone")
        If Not ValidationHelper.ShowIfInvalid(v) Then Return
        MessageBox.Show("Settings saved (connect to shop_settings table when database is ready).", "Settings", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

End Class
