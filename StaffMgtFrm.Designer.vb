<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class StaffMgtFrm
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.lblTitle = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.grpDetails = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.txtUserId = New Guna.UI2.WinForms.Guna2TextBox()
        Me.chkActive = New Guna.UI2.WinForms.Guna2CheckBox()
        Me.btnClearStaff = New Guna.UI2.WinForms.Guna2Button()
        Me.btnUpdateStaff = New Guna.UI2.WinForms.Guna2Button()
        Me.btnAddStaff = New Guna.UI2.WinForms.Guna2Button()
        Me.cmbRole = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.txtStaffPhone = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtPassword = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtFullName = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtUsername = New Guna.UI2.WinForms.Guna2TextBox()
        Me.lblRole = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.lblPhone = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.lblPassword = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.lblFullName = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.lblUsername = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.grpList = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.dgvStaff = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.grpDetails.SuspendLayout()
        Me.grpList.SuspendLayout()
        CType(Me.dgvStaff, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.lblTitle.TabIndex = 2
        Me.lblTitle.Text = "Staff Management"
        '
        'grpDetails
        '
        Me.grpDetails.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpDetails.Controls.Add(Me.txtUserId)
        Me.grpDetails.Controls.Add(Me.chkActive)
        Me.grpDetails.Controls.Add(Me.btnClearStaff)
        Me.grpDetails.Controls.Add(Me.btnUpdateStaff)
        Me.grpDetails.Controls.Add(Me.btnAddStaff)
        Me.grpDetails.Controls.Add(Me.cmbRole)
        Me.grpDetails.Controls.Add(Me.txtStaffPhone)
        Me.grpDetails.Controls.Add(Me.txtPassword)
        Me.grpDetails.Controls.Add(Me.txtFullName)
        Me.grpDetails.Controls.Add(Me.txtUsername)
        Me.grpDetails.Controls.Add(Me.lblRole)
        Me.grpDetails.Controls.Add(Me.lblPhone)
        Me.grpDetails.Controls.Add(Me.lblPassword)
        Me.grpDetails.Controls.Add(Me.lblFullName)
        Me.grpDetails.Controls.Add(Me.lblUsername)
        Me.grpDetails.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.grpDetails.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold)
        Me.grpDetails.ForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.grpDetails.Location = New System.Drawing.Point(12, 52)
        Me.grpDetails.Name = "grpDetails"
        Me.grpDetails.Size = New System.Drawing.Size(1076, 263)
        Me.grpDetails.TabIndex = 1
        Me.grpDetails.Text = "Staff Account"
        '
        'txtUserId
        '
        Me.txtUserId.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtUserId.DefaultText = "userid"
        Me.txtUserId.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtUserId.Location = New System.Drawing.Point(7, 31)
        Me.txtUserId.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtUserId.Name = "txtUserId"
        Me.txtUserId.PlaceholderText = ""
        Me.txtUserId.ReadOnly = True
        Me.txtUserId.SelectedText = ""
        Me.txtUserId.Size = New System.Drawing.Size(229, 29)
        Me.txtUserId.TabIndex = 0
        Me.txtUserId.Visible = False
        '
        'chkActive
        '
        Me.chkActive.AutoSize = True
        Me.chkActive.Checked = True
        Me.chkActive.CheckedState.BorderRadius = 0
        Me.chkActive.CheckedState.BorderThickness = 0
        Me.chkActive.CheckMarkColor = System.Drawing.Color.Tomato
        Me.chkActive.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkActive.ForeColor = System.Drawing.Color.Black
        Me.chkActive.Location = New System.Drawing.Point(513, 168)
        Me.chkActive.Name = "chkActive"
        Me.chkActive.Size = New System.Drawing.Size(145, 27)
        Me.chkActive.TabIndex = 1
        Me.chkActive.Text = "Active account"
        Me.chkActive.UncheckedState.BorderRadius = 0
        Me.chkActive.UncheckedState.BorderThickness = 0
        '
        'btnClearStaff
        '
        Me.btnClearStaff.BorderRadius = 12
        Me.btnClearStaff.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnClearStaff.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnClearStaff.ForeColor = System.Drawing.Color.White
        Me.btnClearStaff.Location = New System.Drawing.Point(880, 160)
        Me.btnClearStaff.Name = "btnClearStaff"
        Me.btnClearStaff.Size = New System.Drawing.Size(170, 40)
        Me.btnClearStaff.TabIndex = 2
        Me.btnClearStaff.Text = "Clear"
        '
        'btnUpdateStaff
        '
        Me.btnUpdateStaff.BorderRadius = 12
        Me.btnUpdateStaff.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnUpdateStaff.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnUpdateStaff.ForeColor = System.Drawing.Color.White
        Me.btnUpdateStaff.Location = New System.Drawing.Point(880, 108)
        Me.btnUpdateStaff.Name = "btnUpdateStaff"
        Me.btnUpdateStaff.Size = New System.Drawing.Size(170, 40)
        Me.btnUpdateStaff.TabIndex = 3
        Me.btnUpdateStaff.Text = "Update"
        '
        'btnAddStaff
        '
        Me.btnAddStaff.BorderRadius = 12
        Me.btnAddStaff.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnAddStaff.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnAddStaff.ForeColor = System.Drawing.Color.White
        Me.btnAddStaff.Location = New System.Drawing.Point(880, 56)
        Me.btnAddStaff.Name = "btnAddStaff"
        Me.btnAddStaff.Size = New System.Drawing.Size(170, 40)
        Me.btnAddStaff.TabIndex = 4
        Me.btnAddStaff.Text = "Add Staff"
        '
        'cmbRole
        '
        Me.cmbRole.BackColor = System.Drawing.Color.Transparent
        Me.cmbRole.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbRole.FocusedColor = System.Drawing.Color.Empty
        Me.cmbRole.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cmbRole.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cmbRole.ItemHeight = 30
        Me.cmbRole.Location = New System.Drawing.Point(260, 164)
        Me.cmbRole.Name = "cmbRole"
        Me.cmbRole.Size = New System.Drawing.Size(220, 36)
        Me.cmbRole.TabIndex = 5
        '
        'txtStaffPhone
        '
        Me.txtStaffPhone.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtStaffPhone.DefaultText = ""
        Me.txtStaffPhone.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtStaffPhone.Location = New System.Drawing.Point(16, 168)
        Me.txtStaffPhone.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtStaffPhone.Name = "txtStaffPhone"
        Me.txtStaffPhone.PlaceholderText = ""
        Me.txtStaffPhone.SelectedText = ""
        Me.txtStaffPhone.Size = New System.Drawing.Size(220, 32)
        Me.txtStaffPhone.TabIndex = 6
        '
        'txtPassword
        '
        Me.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPassword.DefaultText = ""
        Me.txtPassword.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtPassword.Location = New System.Drawing.Point(513, 97)
        Me.txtPassword.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.PlaceholderText = ""
        Me.txtPassword.SelectedText = ""
        Me.txtPassword.Size = New System.Drawing.Size(220, 32)
        Me.txtPassword.TabIndex = 7
        '
        'txtFullName
        '
        Me.txtFullName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtFullName.DefaultText = ""
        Me.txtFullName.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtFullName.Location = New System.Drawing.Point(260, 97)
        Me.txtFullName.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtFullName.Name = "txtFullName"
        Me.txtFullName.PlaceholderText = ""
        Me.txtFullName.SelectedText = ""
        Me.txtFullName.Size = New System.Drawing.Size(220, 32)
        Me.txtFullName.TabIndex = 8
        '
        'txtUsername
        '
        Me.txtUsername.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtUsername.DefaultText = ""
        Me.txtUsername.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtUsername.Location = New System.Drawing.Point(16, 97)
        Me.txtUsername.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.PlaceholderText = ""
        Me.txtUsername.SelectedText = ""
        Me.txtUsername.Size = New System.Drawing.Size(220, 32)
        Me.txtUsername.TabIndex = 9
        '
        'lblRole
        '
        Me.lblRole.AutoSize = False
        Me.lblRole.BackColor = System.Drawing.Color.Transparent
        Me.lblRole.ForeColor = System.Drawing.Color.Black
        Me.lblRole.Location = New System.Drawing.Point(260, 136)
        Me.lblRole.Name = "lblRole"
        Me.lblRole.Size = New System.Drawing.Size(106, 22)
        Me.lblRole.TabIndex = 10
        Me.lblRole.Text = "Role"
        '
        'lblPhone
        '
        Me.lblPhone.AutoSize = False
        Me.lblPhone.BackColor = System.Drawing.Color.Transparent
        Me.lblPhone.ForeColor = System.Drawing.Color.Black
        Me.lblPhone.Location = New System.Drawing.Point(16, 136)
        Me.lblPhone.Name = "lblPhone"
        Me.lblPhone.Size = New System.Drawing.Size(106, 32)
        Me.lblPhone.TabIndex = 11
        Me.lblPhone.Text = "Phone"
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = False
        Me.lblPassword.BackColor = System.Drawing.Color.Transparent
        Me.lblPassword.ForeColor = System.Drawing.Color.Black
        Me.lblPassword.Location = New System.Drawing.Point(513, 56)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(145, 34)
        Me.lblPassword.TabIndex = 12
        Me.lblPassword.Text = "Password"
        '
        'lblFullName
        '
        Me.lblFullName.AutoSize = False
        Me.lblFullName.BackColor = System.Drawing.Color.Transparent
        Me.lblFullName.ForeColor = System.Drawing.Color.Black
        Me.lblFullName.Location = New System.Drawing.Point(260, 56)
        Me.lblFullName.Name = "lblFullName"
        Me.lblFullName.Size = New System.Drawing.Size(130, 34)
        Me.lblFullName.TabIndex = 13
        Me.lblFullName.Text = "Full Name"
        '
        'lblUsername
        '
        Me.lblUsername.AutoSize = False
        Me.lblUsername.BackColor = System.Drawing.Color.Transparent
        Me.lblUsername.ForeColor = System.Drawing.Color.Black
        Me.lblUsername.Location = New System.Drawing.Point(16, 56)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(131, 34)
        Me.lblUsername.TabIndex = 14
        Me.lblUsername.Text = "Username"
        '
        'grpList
        '
        Me.grpList.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpList.Controls.Add(Me.dgvStaff)
        Me.grpList.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.grpList.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold)
        Me.grpList.ForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.grpList.Location = New System.Drawing.Point(12, 321)
        Me.grpList.Name = "grpList"
        Me.grpList.Size = New System.Drawing.Size(1076, 424)
        Me.grpList.TabIndex = 0
        Me.grpList.Text = "Staff List"
        '
        'dgvStaff
        '
        Me.dgvStaff.AllowUserToAddRows = False
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.White
        Me.dgvStaff.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvStaff.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold)
        Me.dgvStaff.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.dgvStaff.ColumnHeadersHeight = 29
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvStaff.DefaultCellStyle = DataGridViewCellStyle6
        Me.dgvStaff.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvStaff.Location = New System.Drawing.Point(16, 48)
        Me.dgvStaff.Name = "dgvStaff"
        Me.dgvStaff.ReadOnly = True
        Me.dgvStaff.RowHeadersVisible = False
        Me.dgvStaff.RowHeadersWidth = 51
        Me.dgvStaff.Size = New System.Drawing.Size(1044, 360)
        Me.dgvStaff.TabIndex = 0
        Me.dgvStaff.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.dgvStaff.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.dgvStaff.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.dgvStaff.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.dgvStaff.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.dgvStaff.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.dgvStaff.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvStaff.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvStaff.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvStaff.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvStaff.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.dgvStaff.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvStaff.ThemeStyle.HeaderStyle.Height = 29
        Me.dgvStaff.ThemeStyle.ReadOnly = True
        Me.dgvStaff.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.dgvStaff.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvStaff.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold)
        Me.dgvStaff.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.dgvStaff.ThemeStyle.RowsStyle.Height = 22
        Me.dgvStaff.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvStaff.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'StaffMgtFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1100, 761)
        Me.Controls.Add(Me.grpList)
        Me.Controls.Add(Me.grpDetails)
        Me.Controls.Add(Me.lblTitle)
        Me.Name = "StaffMgtFrm"
        Me.grpDetails.ResumeLayout(False)
        Me.grpDetails.PerformLayout()
        Me.grpList.ResumeLayout(False)
        CType(Me.dgvStaff, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitle As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents grpDetails As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents txtUserId As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents lblUsername As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lblFullName As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lblPassword As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lblPhone As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lblRole As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents txtUsername As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtFullName As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtPassword As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtStaffPhone As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents cmbRole As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents chkActive As Guna.UI2.WinForms.Guna2CheckBox
    Friend WithEvents btnAddStaff As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnUpdateStaff As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnClearStaff As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents grpList As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents dgvStaff As Guna.UI2.WinForms.Guna2DataGridView
End Class
