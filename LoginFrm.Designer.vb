<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LoginFrm
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
        Me.pnlBrand = New Guna.UI2.WinForms.Guna2Panel()
        Me.lblBrandSubtitle = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.lblBrandTitle = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.pnlLoginCard = New Guna.UI2.WinForms.Guna2Panel()
        Me.lblFooter = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.btnLogin = New Guna.UI2.WinForms.Guna2Button()
        Me.txtlogpword = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtlogusername = New Guna.UI2.WinForms.Guna2TextBox()
        Me.lblPassword = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.lblUsername = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.lblLoginTitle = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.pnlBrand.SuspendLayout()
        Me.pnlLoginCard.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlBrand
        '
        Me.pnlBrand.Controls.Add(Me.lblBrandSubtitle)
        Me.pnlBrand.Controls.Add(Me.lblBrandTitle)
        Me.pnlBrand.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlBrand.FillColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.pnlBrand.Location = New System.Drawing.Point(0, 0)
        Me.pnlBrand.Name = "pnlBrand"
        Me.pnlBrand.Size = New System.Drawing.Size(506, 553)
        Me.pnlBrand.TabIndex = 0
        '
        'lblBrandSubtitle
        '
        Me.lblBrandSubtitle.AutoSize = False
        Me.lblBrandSubtitle.BackColor = System.Drawing.Color.Transparent
        Me.lblBrandSubtitle.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.lblBrandSubtitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblBrandSubtitle.Location = New System.Drawing.Point(27, 237)
        Me.lblBrandSubtitle.Name = "lblBrandSubtitle"
        Me.lblBrandSubtitle.Size = New System.Drawing.Size(451, 74)
        Me.lblBrandSubtitle.TabIndex = 1
        Me.lblBrandSubtitle.Text = "Inventory & Service Management" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Piliyandala • Tyres • POS • Stock"
        '
        'lblBrandTitle
        '
        Me.lblBrandTitle.AutoSize = False
        Me.lblBrandTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblBrandTitle.Font = New System.Drawing.Font("Segoe UI", 22.0!, System.Drawing.FontStyle.Bold)
        Me.lblBrandTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblBrandTitle.Location = New System.Drawing.Point(27, 114)
        Me.lblBrandTitle.Name = "lblBrandTitle"
        Me.lblBrandTitle.Size = New System.Drawing.Size(451, 159)
        Me.lblBrandTitle.TabIndex = 0
        Me.lblBrandTitle.Text = "S & N Tyre Center"
        Me.lblBrandTitle.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        '
        'pnlLoginCard
        '
        Me.pnlLoginCard.AllowDrop = True
        Me.pnlLoginCard.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlLoginCard.BackColor = System.Drawing.Color.Transparent
        Me.pnlLoginCard.BorderRadius = 16
        Me.pnlLoginCard.Controls.Add(Me.lblFooter)
        Me.pnlLoginCard.Controls.Add(Me.btnLogin)
        Me.pnlLoginCard.Controls.Add(Me.txtlogpword)
        Me.pnlLoginCard.Controls.Add(Me.txtlogusername)
        Me.pnlLoginCard.Controls.Add(Me.lblPassword)
        Me.pnlLoginCard.Controls.Add(Me.lblUsername)
        Me.pnlLoginCard.Controls.Add(Me.lblLoginTitle)
        Me.pnlLoginCard.FillColor = System.Drawing.Color.White
        Me.pnlLoginCard.Location = New System.Drawing.Point(528, 59)
        Me.pnlLoginCard.Name = "pnlLoginCard"
        Me.pnlLoginCard.ShadowDecoration.Enabled = True
        Me.pnlLoginCard.Size = New System.Drawing.Size(497, 425)
        Me.pnlLoginCard.TabIndex = 1
        '
        'lblFooter
        '
        Me.lblFooter.AutoSize = False
        Me.lblFooter.BackColor = System.Drawing.Color.Transparent
        Me.lblFooter.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.lblFooter.ForeColor = System.Drawing.Color.Gray
        Me.lblFooter.Location = New System.Drawing.Point(121, 339)
        Me.lblFooter.Name = "lblFooter"
        Me.lblFooter.Size = New System.Drawing.Size(245, 22)
        Me.lblFooter.TabIndex = 6
        Me.lblFooter.Text = "H.M.S.Thathsiluni"
        Me.lblFooter.TextAlignment = System.Drawing.ContentAlignment.TopCenter
        '
        'btnLogin
        '
        Me.btnLogin.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnLogin.BorderRadius = 12
        Me.btnLogin.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnLogin.Font = New System.Drawing.Font("Segoe UI Semibold", 11.0!, System.Drawing.FontStyle.Bold)
        Me.btnLogin.ForeColor = System.Drawing.Color.White
        Me.btnLogin.Location = New System.Drawing.Point(32, 270)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(433, 48)
        Me.btnLogin.TabIndex = 5
        Me.btnLogin.Text = "Sign In"
        '
        'txtlogpword
        '
        Me.txtlogpword.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtlogpword.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtlogpword.DefaultText = ""
        Me.txtlogpword.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtlogpword.Location = New System.Drawing.Point(32, 204)
        Me.txtlogpword.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtlogpword.Name = "txtlogpword"
        Me.txtlogpword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtlogpword.PlaceholderText = "Enter password"
        Me.txtlogpword.SelectedText = ""
        Me.txtlogpword.Size = New System.Drawing.Size(433, 40)
        Me.txtlogpword.TabIndex = 4
        '
        'txtlogusername
        '
        Me.txtlogusername.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtlogusername.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtlogusername.DefaultText = ""
        Me.txtlogusername.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtlogusername.Location = New System.Drawing.Point(32, 114)
        Me.txtlogusername.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtlogusername.Name = "txtlogusername"
        Me.txtlogusername.PlaceholderText = "Enter username"
        Me.txtlogusername.SelectedText = ""
        Me.txtlogusername.Size = New System.Drawing.Size(433, 40)
        Me.txtlogusername.TabIndex = 3
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = False
        Me.lblPassword.BackColor = System.Drawing.Color.Transparent
        Me.lblPassword.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.lblPassword.Location = New System.Drawing.Point(32, 178)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(111, 23)
        Me.lblPassword.TabIndex = 2
        Me.lblPassword.Text = "Password"
        '
        'lblUsername
        '
        Me.lblUsername.AutoSize = False
        Me.lblUsername.BackColor = System.Drawing.Color.Transparent
        Me.lblUsername.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.lblUsername.Location = New System.Drawing.Point(32, 88)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(111, 23)
        Me.lblUsername.TabIndex = 1
        Me.lblUsername.Text = "Username"
        '
        'lblLoginTitle
        '
        Me.lblLoginTitle.AutoSize = False
        Me.lblLoginTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblLoginTitle.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Bold)
        Me.lblLoginTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblLoginTitle.Location = New System.Drawing.Point(32, 28)
        Me.lblLoginTitle.Name = "lblLoginTitle"
        Me.lblLoginTitle.Size = New System.Drawing.Size(244, 54)
        Me.lblLoginTitle.TabIndex = 0
        Me.lblLoginTitle.Text = "Staff Login"
        '
        'LoginFrm
        '
        Me.AcceptButton = Me.btnLogin
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1037, 553)
        Me.Controls.Add(Me.pnlLoginCard)
        Me.Controls.Add(Me.pnlBrand)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "LoginFrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "S & N Tyre Center - Login"
        Me.pnlBrand.ResumeLayout(False)
        Me.pnlLoginCard.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlBrand As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents lblBrandTitle As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lblBrandSubtitle As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents pnlLoginCard As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents lblLoginTitle As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lblUsername As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lblPassword As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents txtlogusername As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtlogpword As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents btnLogin As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents lblFooter As Guna.UI2.WinForms.Guna2HtmlLabel
End Class
