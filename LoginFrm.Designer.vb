<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LoginFrm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.txtlogusername = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtlogpword = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.cmblogrole = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Guna2HtmlLabel2 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel3 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.SuspendLayout()
        '
        'btnLogin
        '
        Me.btnLogin.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogin.Location = New System.Drawing.Point(151, 302)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(75, 36)
        Me.btnLogin.TabIndex = 0
        Me.btnLogin.Text = "Login"
        Me.btnLogin.UseVisualStyleBackColor = True
        '
        'txtlogusername
        '
        Me.txtlogusername.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtlogusername.DefaultText = ""
        Me.txtlogusername.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtlogusername.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtlogusername.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtlogusername.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtlogusername.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtlogusername.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtlogusername.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtlogusername.Location = New System.Drawing.Point(129, 85)
        Me.txtlogusername.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtlogusername.Name = "txtlogusername"
        Me.txtlogusername.PlaceholderText = ""
        Me.txtlogusername.SelectedText = ""
        Me.txtlogusername.Size = New System.Drawing.Size(229, 48)
        Me.txtlogusername.TabIndex = 3
        '
        'txtlogpword
        '
        Me.txtlogpword.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtlogpword.DefaultText = ""
        Me.txtlogpword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtlogpword.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtlogpword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtlogpword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtlogpword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtlogpword.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtlogpword.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtlogpword.Location = New System.Drawing.Point(129, 162)
        Me.txtlogpword.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtlogpword.Name = "txtlogpword"
        Me.txtlogpword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtlogpword.PlaceholderText = ""
        Me.txtlogpword.SelectedText = ""
        Me.txtlogpword.Size = New System.Drawing.Size(229, 48)
        Me.txtlogpword.TabIndex = 3
        '
        'Guna2HtmlLabel1
        '
        Me.Guna2HtmlLabel1.AutoSize = False
        Me.Guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel1.Location = New System.Drawing.Point(19, 233)
        Me.Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Me.Guna2HtmlLabel1.Size = New System.Drawing.Size(57, 36)
        Me.Guna2HtmlLabel1.TabIndex = 4
        Me.Guna2HtmlLabel1.Text = "Role"
        '
        'cmblogrole
        '
        Me.cmblogrole.BackColor = System.Drawing.Color.Transparent
        Me.cmblogrole.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmblogrole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmblogrole.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmblogrole.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmblogrole.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cmblogrole.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cmblogrole.ItemHeight = 30
        Me.cmblogrole.Location = New System.Drawing.Point(129, 233)
        Me.cmblogrole.Name = "cmblogrole"
        Me.cmblogrole.Size = New System.Drawing.Size(229, 36)
        Me.cmblogrole.TabIndex = 5
        '
        'Guna2HtmlLabel2
        '
        Me.Guna2HtmlLabel2.AutoSize = False
        Me.Guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel2.Location = New System.Drawing.Point(19, 172)
        Me.Guna2HtmlLabel2.Name = "Guna2HtmlLabel2"
        Me.Guna2HtmlLabel2.Size = New System.Drawing.Size(104, 20)
        Me.Guna2HtmlLabel2.TabIndex = 6
        Me.Guna2HtmlLabel2.Text = "Password"
        '
        'Guna2HtmlLabel3
        '
        Me.Guna2HtmlLabel3.AutoSize = False
        Me.Guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel3.Location = New System.Drawing.Point(19, 100)
        Me.Guna2HtmlLabel3.Name = "Guna2HtmlLabel3"
        Me.Guna2HtmlLabel3.Size = New System.Drawing.Size(95, 33)
        Me.Guna2HtmlLabel3.TabIndex = 6
        Me.Guna2HtmlLabel3.Text = "Username"
        '
        'LoginFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(370, 450)
        Me.Controls.Add(Me.Guna2HtmlLabel3)
        Me.Controls.Add(Me.Guna2HtmlLabel2)
        Me.Controls.Add(Me.cmblogrole)
        Me.Controls.Add(Me.Guna2HtmlLabel1)
        Me.Controls.Add(Me.txtlogpword)
        Me.Controls.Add(Me.txtlogusername)
        Me.Controls.Add(Me.btnLogin)
        Me.Name = "LoginFrm"
        Me.Text = "LoginFrm"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnLogin As Button
    Friend WithEvents txtlogusername As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtlogpword As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents cmblogrole As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Guna2HtmlLabel2 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel3 As Guna.UI2.WinForms.Guna2HtmlLabel
End Class
