<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AddCustomer
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.btnAddCustomerCusfrm = New Guna.UI2.WinForms.Guna2Button()
        Me.btnDeleteCustomerCusfrm = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel2 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel3 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel4 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel6 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.cmbcustomerType = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.txtcustomerPhone = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtcustomerEmail = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtcustomerName = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2GroupBox1 = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.txtCustomerID = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtcustomerAddress = New Guna.UI2.WinForms.Guna2TextBox()
        Me.btnUpdateCustomerCusfrm = New Guna.UI2.WinForms.Guna2Button()
        Me.txtsearchcustomer = New Guna.UI2.WinForms.Guna2TextBox()
        Me.btnSearchCustomer = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2GroupBox2 = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.dgvCustomers = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.Guna2GroupBox1.SuspendLayout()
        Me.Guna2GroupBox2.SuspendLayout()
        CType(Me.dgvCustomers, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnAddCustomerCusfrm
        '
        Me.btnAddCustomerCusfrm.BorderRadius = 15
        Me.btnAddCustomerCusfrm.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnAddCustomerCusfrm.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnAddCustomerCusfrm.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnAddCustomerCusfrm.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnAddCustomerCusfrm.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnAddCustomerCusfrm.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddCustomerCusfrm.ForeColor = System.Drawing.Color.White
        Me.btnAddCustomerCusfrm.Location = New System.Drawing.Point(787, 76)
        Me.btnAddCustomerCusfrm.Name = "btnAddCustomerCusfrm"
        Me.btnAddCustomerCusfrm.Size = New System.Drawing.Size(135, 45)
        Me.btnAddCustomerCusfrm.TabIndex = 6
        Me.btnAddCustomerCusfrm.Text = "Add New Customer"
        '
        'btnDeleteCustomerCusfrm
        '
        Me.btnDeleteCustomerCusfrm.BorderRadius = 15
        Me.btnDeleteCustomerCusfrm.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnDeleteCustomerCusfrm.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnDeleteCustomerCusfrm.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnDeleteCustomerCusfrm.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnDeleteCustomerCusfrm.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnDeleteCustomerCusfrm.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDeleteCustomerCusfrm.ForeColor = System.Drawing.Color.Black
        Me.btnDeleteCustomerCusfrm.Location = New System.Drawing.Point(787, 213)
        Me.btnDeleteCustomerCusfrm.Name = "btnDeleteCustomerCusfrm"
        Me.btnDeleteCustomerCusfrm.Size = New System.Drawing.Size(135, 45)
        Me.btnDeleteCustomerCusfrm.TabIndex = 7
        Me.btnDeleteCustomerCusfrm.Text = "Delete Customer"
        '
        'Guna2HtmlLabel1
        '
        Me.Guna2HtmlLabel1.AutoSize = False
        Me.Guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel1.Font = New System.Drawing.Font("Segoe UI Semibold", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel1.ForeColor = System.Drawing.Color.Black
        Me.Guna2HtmlLabel1.Location = New System.Drawing.Point(26, 76)
        Me.Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Me.Guna2HtmlLabel1.Size = New System.Drawing.Size(83, 30)
        Me.Guna2HtmlLabel1.TabIndex = 1
        Me.Guna2HtmlLabel1.Text = "Name" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Guna2HtmlLabel2
        '
        Me.Guna2HtmlLabel2.AutoSize = False
        Me.Guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel2.Font = New System.Drawing.Font("Segoe UI Semibold", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel2.ForeColor = System.Drawing.Color.Black
        Me.Guna2HtmlLabel2.Location = New System.Drawing.Point(26, 147)
        Me.Guna2HtmlLabel2.Name = "Guna2HtmlLabel2"
        Me.Guna2HtmlLabel2.Size = New System.Drawing.Size(94, 29)
        Me.Guna2HtmlLabel2.TabIndex = 1
        Me.Guna2HtmlLabel2.Text = "Phone"
        '
        'Guna2HtmlLabel3
        '
        Me.Guna2HtmlLabel3.AutoSize = False
        Me.Guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel3.Font = New System.Drawing.Font("Segoe UI Semibold", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel3.ForeColor = System.Drawing.Color.Black
        Me.Guna2HtmlLabel3.Location = New System.Drawing.Point(23, 220)
        Me.Guna2HtmlLabel3.Name = "Guna2HtmlLabel3"
        Me.Guna2HtmlLabel3.Size = New System.Drawing.Size(81, 38)
        Me.Guna2HtmlLabel3.TabIndex = 1
        Me.Guna2HtmlLabel3.Text = "Email"
        '
        'Guna2HtmlLabel4
        '
        Me.Guna2HtmlLabel4.AutoSize = False
        Me.Guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel4.Font = New System.Drawing.Font("Segoe UI Semibold", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel4.ForeColor = System.Drawing.Color.Black
        Me.Guna2HtmlLabel4.Location = New System.Drawing.Point(387, 185)
        Me.Guna2HtmlLabel4.Name = "Guna2HtmlLabel4"
        Me.Guna2HtmlLabel4.Size = New System.Drawing.Size(172, 30)
        Me.Guna2HtmlLabel4.TabIndex = 1
        Me.Guna2HtmlLabel4.Text = "Price Type"
        '
        'Guna2HtmlLabel6
        '
        Me.Guna2HtmlLabel6.AutoSize = False
        Me.Guna2HtmlLabel6.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel6.Font = New System.Drawing.Font("Segoe UI Semibold", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel6.ForeColor = System.Drawing.Color.Black
        Me.Guna2HtmlLabel6.Location = New System.Drawing.Point(387, 57)
        Me.Guna2HtmlLabel6.Name = "Guna2HtmlLabel6"
        Me.Guna2HtmlLabel6.Size = New System.Drawing.Size(172, 29)
        Me.Guna2HtmlLabel6.TabIndex = 1
        Me.Guna2HtmlLabel6.Text = "Address"
        '
        'cmbcustomerType
        '
        Me.cmbcustomerType.BackColor = System.Drawing.Color.Transparent
        Me.cmbcustomerType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbcustomerType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbcustomerType.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbcustomerType.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbcustomerType.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cmbcustomerType.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cmbcustomerType.ItemHeight = 30
        Me.cmbcustomerType.Location = New System.Drawing.Point(377, 233)
        Me.cmbcustomerType.Name = "cmbcustomerType"
        Me.cmbcustomerType.Size = New System.Drawing.Size(352, 36)
        Me.cmbcustomerType.TabIndex = 3
        '
        'txtcustomerPhone
        '
        Me.txtcustomerPhone.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtcustomerPhone.DefaultText = ""
        Me.txtcustomerPhone.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtcustomerPhone.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtcustomerPhone.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtcustomerPhone.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtcustomerPhone.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtcustomerPhone.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtcustomerPhone.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtcustomerPhone.Location = New System.Drawing.Point(23, 183)
        Me.txtcustomerPhone.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtcustomerPhone.Name = "txtcustomerPhone"
        Me.txtcustomerPhone.PlaceholderText = ""
        Me.txtcustomerPhone.SelectedText = ""
        Me.txtcustomerPhone.Size = New System.Drawing.Size(300, 32)
        Me.txtcustomerPhone.TabIndex = 2
        '
        'txtcustomerEmail
        '
        Me.txtcustomerEmail.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtcustomerEmail.DefaultText = ""
        Me.txtcustomerEmail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtcustomerEmail.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtcustomerEmail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtcustomerEmail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtcustomerEmail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtcustomerEmail.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtcustomerEmail.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtcustomerEmail.Location = New System.Drawing.Point(26, 263)
        Me.txtcustomerEmail.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtcustomerEmail.Name = "txtcustomerEmail"
        Me.txtcustomerEmail.PlaceholderText = ""
        Me.txtcustomerEmail.SelectedText = ""
        Me.txtcustomerEmail.Size = New System.Drawing.Size(297, 27)
        Me.txtcustomerEmail.TabIndex = 3
        '
        'txtcustomerName
        '
        Me.txtcustomerName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtcustomerName.DefaultText = ""
        Me.txtcustomerName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtcustomerName.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtcustomerName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtcustomerName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtcustomerName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtcustomerName.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtcustomerName.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtcustomerName.Location = New System.Drawing.Point(26, 113)
        Me.txtcustomerName.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtcustomerName.Name = "txtcustomerName"
        Me.txtcustomerName.PlaceholderText = ""
        Me.txtcustomerName.SelectedText = ""
        Me.txtcustomerName.Size = New System.Drawing.Size(297, 28)
        Me.txtcustomerName.TabIndex = 1
        '
        'Guna2GroupBox1
        '
        Me.Guna2GroupBox1.BackColor = System.Drawing.Color.White
        Me.Guna2GroupBox1.Controls.Add(Me.txtCustomerID)
        Me.Guna2GroupBox1.Controls.Add(Me.txtcustomerAddress)
        Me.Guna2GroupBox1.Controls.Add(Me.txtcustomerEmail)
        Me.Guna2GroupBox1.Controls.Add(Me.Guna2HtmlLabel4)
        Me.Guna2GroupBox1.Controls.Add(Me.cmbcustomerType)
        Me.Guna2GroupBox1.Controls.Add(Me.txtcustomerName)
        Me.Guna2GroupBox1.Controls.Add(Me.Guna2HtmlLabel6)
        Me.Guna2GroupBox1.Controls.Add(Me.Guna2HtmlLabel3)
        Me.Guna2GroupBox1.Controls.Add(Me.txtcustomerPhone)
        Me.Guna2GroupBox1.Controls.Add(Me.Guna2HtmlLabel2)
        Me.Guna2GroupBox1.Controls.Add(Me.btnDeleteCustomerCusfrm)
        Me.Guna2GroupBox1.Controls.Add(Me.Guna2HtmlLabel1)
        Me.Guna2GroupBox1.Controls.Add(Me.btnUpdateCustomerCusfrm)
        Me.Guna2GroupBox1.Controls.Add(Me.btnAddCustomerCusfrm)
        Me.Guna2GroupBox1.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Guna2GroupBox1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2GroupBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.Guna2GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.Guna2GroupBox1.Name = "Guna2GroupBox1"
        Me.Guna2GroupBox1.Size = New System.Drawing.Size(943, 315)
        Me.Guna2GroupBox1.TabIndex = 8
        Me.Guna2GroupBox1.Text = "Customer Details"
        '
        'txtCustomerID
        '
        Me.txtCustomerID.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCustomerID.DefaultText = "customerid"
        Me.txtCustomerID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtCustomerID.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtCustomerID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtCustomerID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtCustomerID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtCustomerID.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtCustomerID.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtCustomerID.Location = New System.Drawing.Point(23, 44)
        Me.txtCustomerID.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtCustomerID.Name = "txtCustomerID"
        Me.txtCustomerID.PlaceholderText = ""
        Me.txtCustomerID.ReadOnly = True
        Me.txtCustomerID.SelectedText = ""
        Me.txtCustomerID.Size = New System.Drawing.Size(229, 33)
        Me.txtCustomerID.TabIndex = 9
        Me.txtCustomerID.Visible = False
        '
        'txtcustomerAddress
        '
        Me.txtcustomerAddress.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtcustomerAddress.DefaultText = ""
        Me.txtcustomerAddress.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtcustomerAddress.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtcustomerAddress.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtcustomerAddress.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtcustomerAddress.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtcustomerAddress.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtcustomerAddress.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtcustomerAddress.Location = New System.Drawing.Point(377, 97)
        Me.txtcustomerAddress.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtcustomerAddress.Name = "txtcustomerAddress"
        Me.txtcustomerAddress.PlaceholderText = ""
        Me.txtcustomerAddress.SelectedText = ""
        Me.txtcustomerAddress.Size = New System.Drawing.Size(364, 79)
        Me.txtcustomerAddress.TabIndex = 8
        '
        'btnUpdateCustomerCusfrm
        '
        Me.btnUpdateCustomerCusfrm.BorderRadius = 15
        Me.btnUpdateCustomerCusfrm.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnUpdateCustomerCusfrm.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnUpdateCustomerCusfrm.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnUpdateCustomerCusfrm.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnUpdateCustomerCusfrm.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnUpdateCustomerCusfrm.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdateCustomerCusfrm.ForeColor = System.Drawing.Color.White
        Me.btnUpdateCustomerCusfrm.Location = New System.Drawing.Point(787, 147)
        Me.btnUpdateCustomerCusfrm.Name = "btnUpdateCustomerCusfrm"
        Me.btnUpdateCustomerCusfrm.Size = New System.Drawing.Size(135, 45)
        Me.btnUpdateCustomerCusfrm.TabIndex = 6
        Me.btnUpdateCustomerCusfrm.Text = "UpdateCustomer"
        '
        'txtsearchcustomer
        '
        Me.txtsearchcustomer.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtsearchcustomer.DefaultText = "Search here....."
        Me.txtsearchcustomer.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtsearchcustomer.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtsearchcustomer.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtsearchcustomer.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtsearchcustomer.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtsearchcustomer.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtsearchcustomer.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtsearchcustomer.Location = New System.Drawing.Point(43, 58)
        Me.txtsearchcustomer.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtsearchcustomer.Name = "txtsearchcustomer"
        Me.txtsearchcustomer.PlaceholderText = ""
        Me.txtsearchcustomer.SelectedText = ""
        Me.txtsearchcustomer.Size = New System.Drawing.Size(349, 48)
        Me.txtsearchcustomer.TabIndex = 10
        '
        'btnSearchCustomer
        '
        Me.btnSearchCustomer.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnSearchCustomer.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnSearchCustomer.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnSearchCustomer.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnSearchCustomer.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnSearchCustomer.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnSearchCustomer.ForeColor = System.Drawing.Color.White
        Me.btnSearchCustomer.Location = New System.Drawing.Point(462, 58)
        Me.btnSearchCustomer.Name = "btnSearchCustomer"
        Me.btnSearchCustomer.Size = New System.Drawing.Size(180, 45)
        Me.btnSearchCustomer.TabIndex = 11
        Me.btnSearchCustomer.Text = "Search Customer"
        '
        'Guna2GroupBox2
        '
        Me.Guna2GroupBox2.BorderThickness = 0
        Me.Guna2GroupBox2.Controls.Add(Me.dgvCustomers)
        Me.Guna2GroupBox2.Controls.Add(Me.txtsearchcustomer)
        Me.Guna2GroupBox2.Controls.Add(Me.btnSearchCustomer)
        Me.Guna2GroupBox2.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Guna2GroupBox2.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2GroupBox2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.Guna2GroupBox2.Location = New System.Drawing.Point(12, 406)
        Me.Guna2GroupBox2.Name = "Guna2GroupBox2"
        Me.Guna2GroupBox2.Size = New System.Drawing.Size(943, 310)
        Me.Guna2GroupBox2.TabIndex = 12
        Me.Guna2GroupBox2.Text = "Customer History"
        '
        'dgvCustomers
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.dgvCustomers.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvCustomers.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvCustomers.ColumnHeadersHeight = 25
        Me.dgvCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvCustomers.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvCustomers.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvCustomers.Location = New System.Drawing.Point(26, 113)
        Me.dgvCustomers.Name = "dgvCustomers"
        Me.dgvCustomers.RowHeadersVisible = False
        Me.dgvCustomers.RowHeadersWidth = 51
        Me.dgvCustomers.RowTemplate.Height = 24
        Me.dgvCustomers.Size = New System.Drawing.Size(896, 184)
        Me.dgvCustomers.TabIndex = 12
        Me.dgvCustomers.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.dgvCustomers.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.dgvCustomers.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.dgvCustomers.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.dgvCustomers.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.dgvCustomers.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.dgvCustomers.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvCustomers.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvCustomers.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvCustomers.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvCustomers.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.dgvCustomers.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.dgvCustomers.ThemeStyle.HeaderStyle.Height = 25
        Me.dgvCustomers.ThemeStyle.ReadOnly = False
        Me.dgvCustomers.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.dgvCustomers.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvCustomers.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvCustomers.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.dgvCustomers.ThemeStyle.RowsStyle.Height = 24
        Me.dgvCustomers.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvCustomers.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'AddCustomer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1369, 898)
        Me.Controls.Add(Me.Guna2GroupBox2)
        Me.Controls.Add(Me.Guna2GroupBox1)
        Me.Name = "AddCustomer"
        Me.Text = "AddCustomer"
        Me.Guna2GroupBox1.ResumeLayout(False)
        Me.Guna2GroupBox2.ResumeLayout(False)
        CType(Me.dgvCustomers, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnAddCustomerCusfrm As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnDeleteCustomerCusfrm As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel2 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel3 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel4 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel6 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents cmbcustomerType As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents txtcustomerPhone As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtcustomerEmail As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtcustomerName As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2GroupBox1 As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents txtcustomerAddress As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtsearchcustomer As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents btnSearchCustomer As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2GroupBox2 As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents dgvCustomers As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents btnUpdateCustomerCusfrm As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents txtCustomerID As Guna.UI2.WinForms.Guna2TextBox
End Class
