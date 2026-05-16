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
        Dim cs2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Me.lblTitle = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.grpDetails = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.txtUserId = New Guna.UI2.WinForms.Guna2TextBox()
        Me.lblUsername = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.lblFullName = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.lblPassword = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.lblPhone = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.lblRole = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.txtUsername = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtFullName = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtPassword = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtStaffPhone = New Guna.UI2.WinForms.Guna2TextBox()
        Me.cmbRole = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.chkActive = New Guna.UI2.WinForms.Guna2CheckBox()
        Me.btnAddStaff = New Guna.UI2.WinForms.Guna2Button()
        Me.btnUpdateStaff = New Guna.UI2.WinForms.Guna2Button()
        Me.btnClearStaff = New Guna.UI2.WinForms.Guna2Button()
        Me.grpList = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.dgvStaff = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.grpDetails.SuspendLayout()
        Me.grpList.SuspendLayout()
        CType(Me.dgvStaff, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        Me.lblTitle.Dock = DockStyle.Top
        Me.lblTitle.Font = New Font("Segoe UI", 16.0!, FontStyle.Bold)
        Me.lblTitle.ForeColor = Color.FromArgb(255, 128, 0)
        Me.lblTitle.Padding = New Padding(12, 8, 0, 0)
        Me.lblTitle.Size = New Size(1100, 44)
        Me.lblTitle.Text = "Staff Management"
        '
        Me.grpDetails.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
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
        Me.grpDetails.FillColor = Color.FromArgb(255, 224, 192)
        Me.grpDetails.Font = New Font("Segoe UI Semibold", 10.0!, FontStyle.Bold)
        Me.grpDetails.Location = New Point(12, 52)
        Me.grpDetails.Size = New Size(1076, 200)
        Me.grpDetails.Text = "Staff Account"
        '
        Me.txtUserId.Visible = False
        Me.lblUsername.Location = New Point(16, 56) : Me.lblUsername.Text = "Username" : Me.lblUsername.Size = New Size(90, 22)
        Me.lblFullName.Location = New Point(260, 56) : Me.lblFullName.Text = "Full Name" : Me.lblFullName.Size = New Size(90, 22)
        Me.lblPassword.Location = New Point(504, 56) : Me.lblPassword.Text = "Password" : Me.lblPassword.Size = New Size(90, 22)
        Me.lblPhone.Location = New Point(16, 120) : Me.lblPhone.Text = "Phone" : Me.lblPhone.Size = New Size(90, 22)
        Me.lblRole.Location = New Point(260, 120) : Me.lblRole.Text = "Role" : Me.lblRole.Size = New Size(90, 22)
        Me.txtUsername.Location = New Point(16, 84) : Me.txtUsername.Size = New Size(220, 32)
        Me.txtFullName.Location = New Point(260, 84) : Me.txtFullName.Size = New Size(220, 32)
        Me.txtPassword.Location = New Point(504, 84) : Me.txtPassword.PasswordChar = ChrW(42) : Me.txtPassword.Size = New Size(220, 32)
        Me.txtStaffPhone.Location = New Point(16, 148) : Me.txtStaffPhone.Size = New Size(220, 32)
        Me.cmbRole.DropDownStyle = ComboBoxStyle.DropDownList
        Me.cmbRole.Location = New Point(260, 148) : Me.cmbRole.Size = New Size(220, 36)
        Me.chkActive.Location = New Point(504, 148) : Me.chkActive.AutoSize = True : Me.chkActive.Text = "Active account"
        Me.chkActive.Checked = True
        '
        Me.btnAddStaff.BorderRadius = 12 : Me.btnAddStaff.FillColor = Color.FromArgb(255, 128, 0) : Me.btnAddStaff.ForeColor = Color.White
        Me.btnAddStaff.Location = New Point(880, 56) : Me.btnAddStaff.Size = New Size(170, 40) : Me.btnAddStaff.Text = "Add Staff"
        Me.btnUpdateStaff.BorderRadius = 12 : Me.btnUpdateStaff.FillColor = Color.FromArgb(255, 128, 0) : Me.btnUpdateStaff.ForeColor = Color.White
        Me.btnUpdateStaff.Location = New Point(880, 108) : Me.btnUpdateStaff.Size = New Size(170, 40) : Me.btnUpdateStaff.Text = "Update"
        Me.btnClearStaff.BorderRadius = 12 : Me.btnClearStaff.FillColor = Color.FromArgb(255, 192, 128)
        Me.btnClearStaff.Location = New Point(880, 160) : Me.btnClearStaff.Size = New Size(170, 40) : Me.btnClearStaff.Text = "Clear"
        '
        Me.grpList.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Me.grpList.Controls.Add(Me.dgvStaff)
        Me.grpList.FillColor = Color.FromArgb(255, 224, 192)
        Me.grpList.Font = New Font("Segoe UI Semibold", 10.0!, FontStyle.Bold)
        Me.grpList.Location = New Point(12, 264)
        Me.grpList.Size = New Size(1076, 340)
        Me.grpList.Text = "Staff List"
        '
        Me.dgvStaff.AllowUserToAddRows = False
        Me.dgvStaff.ReadOnly = True
        Me.dgvStaff.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Me.dgvStaff.Location = New Point(16, 48)
        Me.dgvStaff.Size = New Size(1044, 276)
        cs2.BackColor = Color.FromArgb(255, 192, 128)
        Me.dgvStaff.ColumnHeadersDefaultCellStyle = cs2
        '
        Me.AutoScaleMode = AutoScaleMode.Font
        Me.BackColor = Color.FromArgb(248, 249, 250)
        Me.ClientSize = New Size(1100, 620)
        Me.Controls.Add(Me.grpList)
        Me.Controls.Add(Me.grpDetails)
        Me.Controls.Add(Me.lblTitle)
        Me.grpDetails.ResumeLayout(False)
        Me.grpList.ResumeLayout(False)
        CType(Me.dgvStaff, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
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
