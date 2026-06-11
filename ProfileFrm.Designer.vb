<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ProfileFrm
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
        Me.pnlHeader = New Guna.UI2.WinForms.Guna2Panel()
        Me.lblProfileRole = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.lblProfileName = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.lblInitials = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.grpAccount = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.txtMemberSince = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtPhone = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtFullName = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtUsername = New Guna.UI2.WinForms.Guna2TextBox()
        Me.lblMemberSince = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.lblPhone = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.lblFullName = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.lblUsername = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.grpPassword = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.txtConfirmPassword = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtNewPassword = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtCurrentPassword = New Guna.UI2.WinForms.Guna2TextBox()
        Me.lblConfirmPwd = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.lblNewPwd = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.lblCurrentPwd = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.btnSaveProfile = New Guna.UI2.WinForms.Guna2Button()
        Me.btnClearProfile = New Guna.UI2.WinForms.Guna2Button()
        Me.pnlHeader.SuspendLayout()
        Me.grpAccount.SuspendLayout()
        Me.grpPassword.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblTitle.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Bold)
        Me.lblTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblTitle.Location = New System.Drawing.Point(0, 0)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Padding = New System.Windows.Forms.Padding(12, 8, 0, 0)
        Me.lblTitle.Size = New System.Drawing.Size(1100, 47)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "My Profile"
        '
        'pnlHeader
        '
        Me.pnlHeader.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlHeader.BorderRadius = 16
        Me.pnlHeader.Controls.Add(Me.lblProfileRole)
        Me.pnlHeader.Controls.Add(Me.lblProfileName)
        Me.pnlHeader.Controls.Add(Me.lblInitials)
        Me.pnlHeader.FillColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.pnlHeader.Location = New System.Drawing.Point(12, 52)
        Me.pnlHeader.Name = "pnlHeader"
        Me.pnlHeader.Size = New System.Drawing.Size(1076, 100)
        Me.pnlHeader.TabIndex = 1
        '
        'lblProfileRole
        '
        Me.lblProfileRole.BackColor = System.Drawing.Color.Transparent
        Me.lblProfileRole.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.lblProfileRole.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lblProfileRole.Location = New System.Drawing.Point(104, 56)
        Me.lblProfileRole.Name = "lblProfileRole"
        Me.lblProfileRole.Size = New System.Drawing.Size(53, 25)
        Me.lblProfileRole.TabIndex = 2
        Me.lblProfileRole.Text = "Admin"
        '
        'lblProfileName
        '
        Me.lblProfileName.BackColor = System.Drawing.Color.Transparent
        Me.lblProfileName.Font = New System.Drawing.Font("Segoe UI Semibold", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lblProfileName.ForeColor = System.Drawing.Color.White
        Me.lblProfileName.Location = New System.Drawing.Point(104, 24)
        Me.lblProfileName.Name = "lblProfileName"
        Me.lblProfileName.Size = New System.Drawing.Size(108, 33)
        Me.lblProfileName.TabIndex = 1
        Me.lblProfileName.Text = "Full Name"
        '
        'lblInitials
        '
        Me.lblInitials.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblInitials.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold)
        Me.lblInitials.ForeColor = System.Drawing.Color.White
        Me.lblInitials.Location = New System.Drawing.Point(24, 20)
        Me.lblInitials.Name = "lblInitials"
        Me.lblInitials.Size = New System.Drawing.Size(46, 43)
        Me.lblInitials.TabIndex = 0
        Me.lblInitials.Text = "AD"
        Me.lblInitials.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        '
        'grpAccount
        '
        Me.grpAccount.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpAccount.Controls.Add(Me.txtMemberSince)
        Me.grpAccount.Controls.Add(Me.txtPhone)
        Me.grpAccount.Controls.Add(Me.txtFullName)
        Me.grpAccount.Controls.Add(Me.txtUsername)
        Me.grpAccount.Controls.Add(Me.lblMemberSince)
        Me.grpAccount.Controls.Add(Me.lblPhone)
        Me.grpAccount.Controls.Add(Me.lblFullName)
        Me.grpAccount.Controls.Add(Me.lblUsername)
        Me.grpAccount.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.grpAccount.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold)
        Me.grpAccount.ForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.grpAccount.Location = New System.Drawing.Point(12, 168)
        Me.grpAccount.Name = "grpAccount"
        Me.grpAccount.Size = New System.Drawing.Size(530, 316)
        Me.grpAccount.TabIndex = 2
        Me.grpAccount.Text = "Account Information"
        '
        'txtMemberSince
        '
        Me.txtMemberSince.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtMemberSince.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtMemberSince.DefaultText = ""
        Me.txtMemberSince.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtMemberSince.Location = New System.Drawing.Point(20, 252)
        Me.txtMemberSince.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtMemberSince.Name = "txtMemberSince"
        Me.txtMemberSince.PlaceholderText = ""
        Me.txtMemberSince.ReadOnly = True
        Me.txtMemberSince.SelectedText = ""
        Me.txtMemberSince.Size = New System.Drawing.Size(490, 32)
        Me.txtMemberSince.TabIndex = 3
        '
        'txtPhone
        '
        Me.txtPhone.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtPhone.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPhone.DefaultText = ""
        Me.txtPhone.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtPhone.Location = New System.Drawing.Point(20, 192)
        Me.txtPhone.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.PlaceholderText = "10-digit mobile number"
        Me.txtPhone.SelectedText = ""
        Me.txtPhone.Size = New System.Drawing.Size(490, 32)
        Me.txtPhone.TabIndex = 2
        '
        'txtFullName
        '
        Me.txtFullName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtFullName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtFullName.DefaultText = ""
        Me.txtFullName.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtFullName.Location = New System.Drawing.Point(20, 132)
        Me.txtFullName.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtFullName.Name = "txtFullName"
        Me.txtFullName.PlaceholderText = "Your display name"
        Me.txtFullName.SelectedText = ""
        Me.txtFullName.Size = New System.Drawing.Size(490, 32)
        Me.txtFullName.TabIndex = 1
        '
        'txtUsername
        '
        Me.txtUsername.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtUsername.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtUsername.DefaultText = ""
        Me.txtUsername.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtUsername.Location = New System.Drawing.Point(20, 72)
        Me.txtUsername.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.PlaceholderText = ""
        Me.txtUsername.ReadOnly = True
        Me.txtUsername.SelectedText = ""
        Me.txtUsername.Size = New System.Drawing.Size(490, 32)
        Me.txtUsername.TabIndex = 0
        '
        'lblMemberSince
        '
        Me.lblMemberSince.BackColor = System.Drawing.Color.Transparent
        Me.lblMemberSince.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblMemberSince.Location = New System.Drawing.Point(20, 228)
        Me.lblMemberSince.Name = "lblMemberSince"
        Me.lblMemberSince.Size = New System.Drawing.Size(101, 22)
        Me.lblMemberSince.TabIndex = 4
        Me.lblMemberSince.Text = "Member Since"
        '
        'lblPhone
        '
        Me.lblPhone.BackColor = System.Drawing.Color.Transparent
        Me.lblPhone.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblPhone.Location = New System.Drawing.Point(20, 168)
        Me.lblPhone.Name = "lblPhone"
        Me.lblPhone.Size = New System.Drawing.Size(47, 22)
        Me.lblPhone.TabIndex = 5
        Me.lblPhone.Text = "Phone"
        '
        'lblFullName
        '
        Me.lblFullName.BackColor = System.Drawing.Color.Transparent
        Me.lblFullName.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblFullName.Location = New System.Drawing.Point(20, 108)
        Me.lblFullName.Name = "lblFullName"
        Me.lblFullName.Size = New System.Drawing.Size(73, 22)
        Me.lblFullName.TabIndex = 6
        Me.lblFullName.Text = "Full Name"
        '
        'lblUsername
        '
        Me.lblUsername.BackColor = System.Drawing.Color.Transparent
        Me.lblUsername.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblUsername.Location = New System.Drawing.Point(20, 48)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(72, 22)
        Me.lblUsername.TabIndex = 7
        Me.lblUsername.Text = "Username"
        '
        'grpPassword
        '
        Me.grpPassword.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpPassword.Controls.Add(Me.txtConfirmPassword)
        Me.grpPassword.Controls.Add(Me.txtNewPassword)
        Me.grpPassword.Controls.Add(Me.txtCurrentPassword)
        Me.grpPassword.Controls.Add(Me.lblConfirmPwd)
        Me.grpPassword.Controls.Add(Me.lblNewPwd)
        Me.grpPassword.Controls.Add(Me.lblCurrentPwd)
        Me.grpPassword.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.grpPassword.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold)
        Me.grpPassword.ForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.grpPassword.Location = New System.Drawing.Point(548, 168)
        Me.grpPassword.Name = "grpPassword"
        Me.grpPassword.Size = New System.Drawing.Size(540, 316)
        Me.grpPassword.TabIndex = 3
        Me.grpPassword.Text = "Change Password"
        '
        'txtConfirmPassword
        '
        Me.txtConfirmPassword.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtConfirmPassword.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtConfirmPassword.DefaultText = ""
        Me.txtConfirmPassword.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtConfirmPassword.Location = New System.Drawing.Point(20, 232)
        Me.txtConfirmPassword.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtConfirmPassword.Name = "txtConfirmPassword"
        Me.txtConfirmPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtConfirmPassword.PlaceholderText = ""
        Me.txtConfirmPassword.SelectedText = ""
        Me.txtConfirmPassword.Size = New System.Drawing.Size(500, 32)
        Me.txtConfirmPassword.TabIndex = 2
        '
        'txtNewPassword
        '
        Me.txtNewPassword.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNewPassword.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtNewPassword.DefaultText = ""
        Me.txtNewPassword.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtNewPassword.Location = New System.Drawing.Point(20, 152)
        Me.txtNewPassword.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtNewPassword.Name = "txtNewPassword"
        Me.txtNewPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtNewPassword.PlaceholderText = "Min. 4 characters"
        Me.txtNewPassword.SelectedText = ""
        Me.txtNewPassword.Size = New System.Drawing.Size(500, 32)
        Me.txtNewPassword.TabIndex = 1
        '
        'txtCurrentPassword
        '
        Me.txtCurrentPassword.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCurrentPassword.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCurrentPassword.DefaultText = ""
        Me.txtCurrentPassword.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtCurrentPassword.Location = New System.Drawing.Point(20, 72)
        Me.txtCurrentPassword.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtCurrentPassword.Name = "txtCurrentPassword"
        Me.txtCurrentPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtCurrentPassword.PlaceholderText = "Required to change password"
        Me.txtCurrentPassword.SelectedText = ""
        Me.txtCurrentPassword.Size = New System.Drawing.Size(500, 32)
        Me.txtCurrentPassword.TabIndex = 0
        '
        'lblConfirmPwd
        '
        Me.lblConfirmPwd.BackColor = System.Drawing.Color.Transparent
        Me.lblConfirmPwd.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblConfirmPwd.Location = New System.Drawing.Point(20, 208)
        Me.lblConfirmPwd.Name = "lblConfirmPwd"
        Me.lblConfirmPwd.Size = New System.Drawing.Size(126, 22)
        Me.lblConfirmPwd.TabIndex = 3
        Me.lblConfirmPwd.Text = "Confirm Password"
        '
        'lblNewPwd
        '
        Me.lblNewPwd.BackColor = System.Drawing.Color.Transparent
        Me.lblNewPwd.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblNewPwd.Location = New System.Drawing.Point(20, 128)
        Me.lblNewPwd.Name = "lblNewPwd"
        Me.lblNewPwd.Size = New System.Drawing.Size(102, 22)
        Me.lblNewPwd.TabIndex = 4
        Me.lblNewPwd.Text = "New Password"
        '
        'lblCurrentPwd
        '
        Me.lblCurrentPwd.BackColor = System.Drawing.Color.Transparent
        Me.lblCurrentPwd.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblCurrentPwd.Location = New System.Drawing.Point(20, 48)
        Me.lblCurrentPwd.Name = "lblCurrentPwd"
        Me.lblCurrentPwd.Size = New System.Drawing.Size(123, 22)
        Me.lblCurrentPwd.TabIndex = 5
        Me.lblCurrentPwd.Text = "Current Password"
        '
        'btnSaveProfile
        '
        Me.btnSaveProfile.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSaveProfile.BorderRadius = 12
        Me.btnSaveProfile.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnSaveProfile.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnSaveProfile.ForeColor = System.Drawing.Color.White
        Me.btnSaveProfile.Location = New System.Drawing.Point(850, 514)
        Me.btnSaveProfile.Name = "btnSaveProfile"
        Me.btnSaveProfile.Size = New System.Drawing.Size(160, 44)
        Me.btnSaveProfile.TabIndex = 4
        Me.btnSaveProfile.Text = "Save Profile"
        '
        'btnClearProfile
        '
        Me.btnClearProfile.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClearProfile.BorderRadius = 12
        Me.btnClearProfile.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnClearProfile.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnClearProfile.ForeColor = System.Drawing.Color.Black
        Me.btnClearProfile.Location = New System.Drawing.Point(631, 514)
        Me.btnClearProfile.Name = "btnClearProfile"
        Me.btnClearProfile.Size = New System.Drawing.Size(160, 44)
        Me.btnClearProfile.TabIndex = 5
        Me.btnClearProfile.Text = "Clear Password"
        '
        'ProfileFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1100, 620)
        Me.Controls.Add(Me.btnClearProfile)
        Me.Controls.Add(Me.btnSaveProfile)
        Me.Controls.Add(Me.grpPassword)
        Me.Controls.Add(Me.grpAccount)
        Me.Controls.Add(Me.pnlHeader)
        Me.Controls.Add(Me.lblTitle)
        Me.Name = "ProfileFrm"
        Me.Text = "My Profile"
        Me.pnlHeader.ResumeLayout(False)
        Me.pnlHeader.PerformLayout()
        Me.grpAccount.ResumeLayout(False)
        Me.grpAccount.PerformLayout()
        Me.grpPassword.ResumeLayout(False)
        Me.grpPassword.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitle As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents pnlHeader As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents lblInitials As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lblProfileName As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lblProfileRole As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents grpAccount As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents lblUsername As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lblFullName As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lblPhone As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lblMemberSince As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents txtUsername As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtFullName As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtPhone As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtMemberSince As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents grpPassword As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents lblCurrentPwd As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lblNewPwd As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lblConfirmPwd As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents txtCurrentPassword As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtNewPassword As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtConfirmPassword As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents btnSaveProfile As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnClearProfile As Guna.UI2.WinForms.Guna2Button
End Class
