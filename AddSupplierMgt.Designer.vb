<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AddSupplierMgt
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
        Dim cs1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim cs2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Me.lblTitle = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.grpDetails = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.txtSupId = New Guna.UI2.WinForms.Guna2TextBox()
        Me.lblSupName = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.lblCompany = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.lblPhone = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.lblEmail = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.lblAddress = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.txtSupName = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtCompany = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtSupPhone = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtSupEmail = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtSupAddress = New Guna.UI2.WinForms.Guna2TextBox()
        Me.btnAddSup = New Guna.UI2.WinForms.Guna2Button()
        Me.btnUpdateSup = New Guna.UI2.WinForms.Guna2Button()
        Me.btnDeleteSup = New Guna.UI2.WinForms.Guna2Button()
        Me.btnClearSup = New Guna.UI2.WinForms.Guna2Button()
        Me.grpList = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.dgvSuppliers = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.txtSearchSup = New Guna.UI2.WinForms.Guna2TextBox()
        Me.btnSearchSup = New Guna.UI2.WinForms.Guna2Button()
        Me.grpDetails.SuspendLayout()
        Me.grpList.SuspendLayout()
        CType(Me.dgvSuppliers, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        Me.lblTitle.Dock = DockStyle.Top
        Me.lblTitle.Font = New Font("Segoe UI", 16.0!, FontStyle.Bold)
        Me.lblTitle.ForeColor = Color.FromArgb(255, 128, 0)
        Me.lblTitle.Location = New Point(0, 0)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Padding = New Padding(12, 8, 0, 0)
        Me.lblTitle.Size = New Size(1100, 44)
        Me.lblTitle.Text = "Supplier Management"
        '
        Me.grpDetails.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        Me.grpDetails.Controls.Add(Me.txtSupId)
        Me.grpDetails.Controls.Add(Me.btnClearSup)
        Me.grpDetails.Controls.Add(Me.btnDeleteSup)
        Me.grpDetails.Controls.Add(Me.btnUpdateSup)
        Me.grpDetails.Controls.Add(Me.btnAddSup)
        Me.grpDetails.Controls.Add(Me.txtSupAddress)
        Me.grpDetails.Controls.Add(Me.txtSupEmail)
        Me.grpDetails.Controls.Add(Me.txtSupPhone)
        Me.grpDetails.Controls.Add(Me.txtCompany)
        Me.grpDetails.Controls.Add(Me.txtSupName)
        Me.grpDetails.Controls.Add(Me.lblAddress)
        Me.grpDetails.Controls.Add(Me.lblEmail)
        Me.grpDetails.Controls.Add(Me.lblPhone)
        Me.grpDetails.Controls.Add(Me.lblCompany)
        Me.grpDetails.Controls.Add(Me.lblSupName)
        Me.grpDetails.FillColor = Color.FromArgb(255, 224, 192)
        Me.grpDetails.Font = New Font("Segoe UI Semibold", 10.0!, FontStyle.Bold)
        Me.grpDetails.Location = New Point(12, 52)
        Me.grpDetails.Size = New Size(1076, 200)
        Me.grpDetails.TabIndex = 1
        Me.grpDetails.Text = "Supplier Details"
        '
        Me.txtSupId.Visible = False
        Me.txtSupId.Location = New Point(16, 36)
        Me.txtSupId.Size = New Size(40, 28)
        '
        Me.lblSupName.Location = New Point(16, 56) : Me.lblSupName.Size = New Size(100, 22) : Me.lblSupName.Text = "Contact Name"
        Me.lblCompany.Location = New Point(280, 56) : Me.lblCompany.Size = New Size(100, 22) : Me.lblCompany.Text = "Company"
        Me.lblPhone.Location = New Point(544, 56) : Me.lblPhone.Size = New Size(80, 22) : Me.lblPhone.Text = "Phone"
        Me.lblEmail.Location = New Point(16, 120) : Me.lblEmail.Size = New Size(80, 22) : Me.lblEmail.Text = "Email"
        Me.lblAddress.Location = New Point(280, 120) : Me.lblAddress.Size = New Size(80, 22) : Me.lblAddress.Text = "Address"
        '
        Me.txtSupName.Location = New Point(16, 84) : Me.txtSupName.Size = New Size(240, 32)
        Me.txtCompany.Location = New Point(280, 84) : Me.txtCompany.Size = New Size(240, 32)
        Me.txtSupPhone.Location = New Point(544, 84) : Me.txtSupPhone.Size = New Size(160, 32)
        Me.txtSupEmail.Location = New Point(16, 148) : Me.txtSupEmail.Size = New Size(240, 32)
        Me.txtSupAddress.Location = New Point(280, 148) : Me.txtSupAddress.Size = New Size(560, 32)
        '
        Me.btnAddSup.BorderRadius = 12 : Me.btnAddSup.FillColor = Color.FromArgb(255, 128, 0) : Me.btnAddSup.ForeColor = Color.White
        Me.btnAddSup.Location = New Point(880, 56) : Me.btnAddSup.Size = New Size(170, 40) : Me.btnAddSup.Text = "Add"
        Me.btnUpdateSup.BorderRadius = 12 : Me.btnUpdateSup.FillColor = Color.FromArgb(255, 128, 0) : Me.btnUpdateSup.ForeColor = Color.White
        Me.btnUpdateSup.Location = New Point(880, 104) : Me.btnUpdateSup.Size = New Size(170, 40) : Me.btnUpdateSup.Text = "Update"
        Me.btnDeleteSup.BorderRadius = 12 : Me.btnDeleteSup.FillColor = Color.FromArgb(220, 53, 69) : Me.btnDeleteSup.ForeColor = Color.White
        Me.btnDeleteSup.Location = New Point(880, 152) : Me.btnDeleteSup.Size = New Size(82, 40) : Me.btnDeleteSup.Text = "Delete"
        Me.btnClearSup.BorderRadius = 12 : Me.btnClearSup.FillColor = Color.FromArgb(255, 192, 128)
        Me.btnClearSup.Location = New Point(968, 152) : Me.btnClearSup.Size = New Size(82, 40) : Me.btnClearSup.Text = "Clear"
        '
        Me.grpList.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Me.grpList.Controls.Add(Me.dgvSuppliers)
        Me.grpList.Controls.Add(Me.btnSearchSup)
        Me.grpList.Controls.Add(Me.txtSearchSup)
        Me.grpList.FillColor = Color.FromArgb(255, 224, 192)
        Me.grpList.Font = New Font("Segoe UI Semibold", 10.0!, FontStyle.Bold)
        Me.grpList.Location = New Point(12, 264)
        Me.grpList.Size = New Size(1076, 340)
        Me.grpList.Text = "Supplier List"
        '
        Me.txtSearchSup.Location = New Point(16, 48) : Me.txtSearchSup.PlaceholderText = "Search supplier..." : Me.txtSearchSup.Size = New Size(400, 36)
        Me.btnSearchSup.Location = New Point(430, 48) : Me.btnSearchSup.Size = New Size(120, 36) : Me.btnSearchSup.Text = "Search"
        Me.btnSearchSup.FillColor = Color.FromArgb(255, 128, 0) : Me.btnSearchSup.ForeColor = Color.White
        '
        Me.dgvSuppliers.AllowUserToAddRows = False
        Me.dgvSuppliers.ReadOnly = True
        Me.dgvSuppliers.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Me.dgvSuppliers.Location = New Point(16, 96)
        Me.dgvSuppliers.Size = New Size(1044, 228)
        cs2.BackColor = Color.FromArgb(255, 192, 128)
        Me.dgvSuppliers.ColumnHeadersDefaultCellStyle = cs2
        '
        Me.AutoScaleMode = AutoScaleMode.Font
        Me.BackColor = Color.FromArgb(248, 249, 250)
        Me.ClientSize = New Size(1100, 620)
        Me.Controls.Add(Me.grpList)
        Me.Controls.Add(Me.grpDetails)
        Me.Controls.Add(Me.lblTitle)
        Me.Name = "AddSupplierMgt"
        Me.grpDetails.ResumeLayout(False)
        Me.grpList.ResumeLayout(False)
        CType(Me.dgvSuppliers, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
    End Sub

    Friend WithEvents lblTitle As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents grpDetails As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents txtSupId As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents lblSupName As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lblCompany As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lblPhone As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lblEmail As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lblAddress As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents txtSupName As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtCompany As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtSupPhone As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtSupEmail As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtSupAddress As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents btnAddSup As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnUpdateSup As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnDeleteSup As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnClearSup As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents grpList As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents dgvSuppliers As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents txtSearchSup As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents btnSearchSup As Guna.UI2.WinForms.Guna2Button
End Class
