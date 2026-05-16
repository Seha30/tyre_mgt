<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Settings
    Inherits System.Windows.Forms.Form

    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then components.Dispose()
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.lblTitle = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.grpShop = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.lblShopName = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.lblShopAddress = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.lblShopPhone = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.lblReorderDefault = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.txtShopName = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtShopAddress = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtShopPhone = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtReorderDefault = New Guna.UI2.WinForms.Guna2TextBox()
        Me.btnSaveSettings = New Guna.UI2.WinForms.Guna2Button()
        Me.grpShop.SuspendLayout()
        Me.SuspendLayout()
        '
        Me.lblTitle.Dock = DockStyle.Top
        Me.lblTitle.Font = New Font("Segoe UI", 16.0!, FontStyle.Bold)
        Me.lblTitle.ForeColor = Color.FromArgb(255, 128, 0)
        Me.lblTitle.Padding = New Padding(12, 8, 0, 0)
        Me.lblTitle.Size = New Size(1100, 44)
        Me.lblTitle.Text = "System Settings"
        '
        Me.grpShop.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        Me.grpShop.Controls.Add(Me.btnSaveSettings)
        Me.grpShop.Controls.Add(Me.txtReorderDefault)
        Me.grpShop.Controls.Add(Me.txtShopPhone)
        Me.grpShop.Controls.Add(Me.txtShopAddress)
        Me.grpShop.Controls.Add(Me.txtShopName)
        Me.grpShop.Controls.Add(Me.lblReorderDefault)
        Me.grpShop.Controls.Add(Me.lblShopPhone)
        Me.grpShop.Controls.Add(Me.lblShopAddress)
        Me.grpShop.Controls.Add(Me.lblShopName)
        Me.grpShop.FillColor = Color.FromArgb(255, 224, 192)
        Me.grpShop.Font = New Font("Segoe UI Semibold", 10.0!, FontStyle.Bold)
        Me.grpShop.Location = New Point(12, 56)
        Me.grpShop.Size = New Size(700, 280)
        Me.grpShop.Text = "Shop Profile"
        '
        Me.lblShopName.Location = New Point(20, 48) : Me.lblShopName.Text = "Shop Name" : Me.lblShopName.Size = New Size(120, 22)
        Me.lblShopAddress.Location = New Point(20, 100) : Me.lblShopAddress.Text = "Address" : Me.lblShopAddress.Size = New Size(120, 22)
        Me.lblShopPhone.Location = New Point(20, 180) : Me.lblShopPhone.Text = "Phone (10 digits)" : Me.lblShopPhone.Size = New Size(140, 22)
        Me.lblReorderDefault.Location = New Point(360, 180) : Me.lblReorderDefault.Text = "Default reorder level" : Me.lblReorderDefault.Size = New Size(160, 22)
        Me.txtShopName.Location = New Point(20, 72) : Me.txtShopName.Size = New Size(640, 32) : Me.txtShopName.Text = "S & N Tyre Center"
        Me.txtShopAddress.Location = New Point(20, 124) : Me.txtShopAddress.Size = New Size(640, 48) : Me.txtShopAddress.Text = "Piliyandala, Sri Lanka"
        Me.txtShopPhone.Location = New Point(20, 204) : Me.txtShopPhone.Size = New Size(200, 32)
        Me.txtReorderDefault.Location = New Point(360, 204) : Me.txtReorderDefault.Size = New Size(80, 32) : Me.txtReorderDefault.Text = "5"
        Me.btnSaveSettings.Location = New Point(500, 204) : Me.btnSaveSettings.Size = New Size(160, 40) : Me.btnSaveSettings.Text = "Save Settings"
        Me.btnSaveSettings.FillColor = Color.FromArgb(255, 128, 0) : Me.btnSaveSettings.ForeColor = Color.White
        '
        Me.AutoScaleMode = AutoScaleMode.Font
        Me.BackColor = Color.FromArgb(248, 249, 250)
        Me.ClientSize = New Size(1100, 620)
        Me.Controls.Add(Me.grpShop)
        Me.Controls.Add(Me.lblTitle)
        Me.grpShop.ResumeLayout(False)
        Me.ResumeLayout(False)
    End Sub

    Friend WithEvents lblTitle As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents grpShop As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents lblShopName As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lblShopAddress As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lblShopPhone As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lblReorderDefault As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents txtShopName As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtShopAddress As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtShopPhone As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtReorderDefault As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents btnSaveSettings As Guna.UI2.WinForms.Guna2Button
End Class
