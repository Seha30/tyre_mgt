<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ProductMgtFrm
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
        Me.txtItemId = New Guna.UI2.WinForms.Guna2TextBox()
        Me.numReorder = New Guna.UI2.WinForms.Guna2TextBox()
        Me.numQuantity = New Guna.UI2.WinForms.Guna2TextBox()
        Me.numWholesalePrice = New Guna.UI2.WinForms.Guna2TextBox()
        Me.numRetailPrice = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtTyreSize = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtBrand = New Guna.UI2.WinForms.Guna2TextBox()
        Me.cmbItemType = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.txtItemName = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtItemCode = New Guna.UI2.WinForms.Guna2TextBox()
        Me.lblReorder = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.lblQty = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.lblWholesale = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.lblRetail = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.lblSize = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.lblBrand = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.lblType = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.lblName = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.lblCode = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.pnlCrud = New Guna.UI2.WinForms.Guna2Panel()
        Me.btnClearProduct = New Guna.UI2.WinForms.Guna2Button()
        Me.btnDeleteProduct = New Guna.UI2.WinForms.Guna2Button()
        Me.btnUpdateProduct = New Guna.UI2.WinForms.Guna2Button()
        Me.btnAddProduct = New Guna.UI2.WinForms.Guna2Button()
        Me.grpList = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.dgvProducts = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.pnlSearch = New Guna.UI2.WinForms.Guna2Panel()
        Me.btnSearchProduct = New Guna.UI2.WinForms.Guna2Button()
        Me.txtSearchProduct = New Guna.UI2.WinForms.Guna2TextBox()
        Me.lblSearch = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.grpDetails.SuspendLayout()
        Me.pnlCrud.SuspendLayout()
        Me.grpList.SuspendLayout()
        CType(Me.dgvProducts, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlSearch.SuspendLayout()
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
        Me.lblTitle.Size = New System.Drawing.Size(295, 47)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Product Management"
        '
        'grpDetails
        '
        Me.grpDetails.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpDetails.Controls.Add(Me.txtItemId)
        Me.grpDetails.Controls.Add(Me.numRetailPrice)
        Me.grpDetails.Controls.Add(Me.txtTyreSize)
        Me.grpDetails.Controls.Add(Me.txtBrand)
        Me.grpDetails.Controls.Add(Me.cmbItemType)
        Me.grpDetails.Controls.Add(Me.txtItemName)
        Me.grpDetails.Controls.Add(Me.txtItemCode)
        Me.grpDetails.Controls.Add(Me.lblRetail)
        Me.grpDetails.Controls.Add(Me.lblSize)
        Me.grpDetails.Controls.Add(Me.lblBrand)
        Me.grpDetails.Controls.Add(Me.lblType)
        Me.grpDetails.Controls.Add(Me.lblName)
        Me.grpDetails.Controls.Add(Me.lblCode)
        Me.grpDetails.Controls.Add(Me.pnlCrud)
        Me.grpDetails.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.grpDetails.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold)
        Me.grpDetails.ForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.grpDetails.Location = New System.Drawing.Point(12, 52)
        Me.grpDetails.Name = "grpDetails"
        Me.grpDetails.Size = New System.Drawing.Size(1324, 261)
        Me.grpDetails.TabIndex = 1
        Me.grpDetails.Text = "Product / Service Details"
        '
        'txtItemId
        '
        Me.txtItemId.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtItemId.DefaultText = "ItemID"
        Me.txtItemId.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtItemId.Location = New System.Drawing.Point(16, 28)
        Me.txtItemId.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtItemId.Name = "txtItemId"
        Me.txtItemId.PlaceholderText = ""
        Me.txtItemId.ReadOnly = True
        Me.txtItemId.SelectedText = ""
        Me.txtItemId.Size = New System.Drawing.Size(72, 28)
        Me.txtItemId.TabIndex = 99
        Me.txtItemId.Visible = False
        '
        'numReorder
        '
        Me.numReorder.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.numReorder.DefaultText = ""
        Me.numReorder.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.numReorder.Location = New System.Drawing.Point(403, 175)
        Me.numReorder.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.numReorder.Name = "numReorder"
        Me.numReorder.PlaceholderText = "5"
        Me.numReorder.SelectedText = ""
        Me.numReorder.Size = New System.Drawing.Size(80, 32)
        Me.numReorder.TabIndex = 8
        '
        'numQuantity
        '
        Me.numQuantity.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.numQuantity.DefaultText = ""
        Me.numQuantity.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.numQuantity.Location = New System.Drawing.Point(232, 175)
        Me.numQuantity.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.numQuantity.Name = "numQuantity"
        Me.numQuantity.PlaceholderText = "0"
        Me.numQuantity.SelectedText = ""
        Me.numQuantity.Size = New System.Drawing.Size(80, 32)
        Me.numQuantity.TabIndex = 7
        '
        'numWholesalePrice
        '
        Me.numWholesalePrice.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.numWholesalePrice.DefaultText = ""
        Me.numWholesalePrice.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.numWholesalePrice.Location = New System.Drawing.Point(8, 175)
        Me.numWholesalePrice.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.numWholesalePrice.Name = "numWholesalePrice"
        Me.numWholesalePrice.PlaceholderText = "0.00"
        Me.numWholesalePrice.SelectedText = ""
        Me.numWholesalePrice.Size = New System.Drawing.Size(140, 32)
        Me.numWholesalePrice.TabIndex = 6
        '
        'numRetailPrice
        '
        Me.numRetailPrice.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.numRetailPrice.DefaultText = ""
        Me.numRetailPrice.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.numRetailPrice.Location = New System.Drawing.Point(504, 148)
        Me.numRetailPrice.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.numRetailPrice.Name = "numRetailPrice"
        Me.numRetailPrice.PlaceholderText = "0.00"
        Me.numRetailPrice.SelectedText = ""
        Me.numRetailPrice.Size = New System.Drawing.Size(140, 32)
        Me.numRetailPrice.TabIndex = 5
        '
        'txtTyreSize
        '
        Me.txtTyreSize.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtTyreSize.DefaultText = ""
        Me.txtTyreSize.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtTyreSize.Location = New System.Drawing.Point(260, 148)
        Me.txtTyreSize.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtTyreSize.Name = "txtTyreSize"
        Me.txtTyreSize.PlaceholderText = "195/65R15"
        Me.txtTyreSize.SelectedText = ""
        Me.txtTyreSize.Size = New System.Drawing.Size(220, 32)
        Me.txtTyreSize.TabIndex = 4
        '
        'txtBrand
        '
        Me.txtBrand.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtBrand.DefaultText = ""
        Me.txtBrand.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtBrand.Location = New System.Drawing.Point(16, 148)
        Me.txtBrand.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtBrand.Name = "txtBrand"
        Me.txtBrand.PlaceholderText = "Ceat, Michelin..."
        Me.txtBrand.SelectedText = ""
        Me.txtBrand.Size = New System.Drawing.Size(220, 32)
        Me.txtBrand.TabIndex = 3
        '
        'cmbItemType
        '
        Me.cmbItemType.BackColor = System.Drawing.Color.Transparent
        Me.cmbItemType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbItemType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbItemType.FocusedColor = System.Drawing.Color.Empty
        Me.cmbItemType.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cmbItemType.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cmbItemType.ItemHeight = 30
        Me.cmbItemType.Location = New System.Drawing.Point(504, 84)
        Me.cmbItemType.Name = "cmbItemType"
        Me.cmbItemType.Size = New System.Drawing.Size(140, 36)
        Me.cmbItemType.TabIndex = 2
        '
        'txtItemName
        '
        Me.txtItemName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtItemName.DefaultText = ""
        Me.txtItemName.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtItemName.Location = New System.Drawing.Point(260, 84)
        Me.txtItemName.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtItemName.Name = "txtItemName"
        Me.txtItemName.PlaceholderText = "Product name"
        Me.txtItemName.SelectedText = ""
        Me.txtItemName.Size = New System.Drawing.Size(220, 32)
        Me.txtItemName.TabIndex = 1
        '
        'txtItemCode
        '
        Me.txtItemCode.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtItemCode.DefaultText = ""
        Me.txtItemCode.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtItemCode.Location = New System.Drawing.Point(16, 84)
        Me.txtItemCode.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtItemCode.Name = "txtItemCode"
        Me.txtItemCode.PlaceholderText = "TYR-195-65-15"
        Me.txtItemCode.SelectedText = ""
        Me.txtItemCode.Size = New System.Drawing.Size(220, 32)
        Me.txtItemCode.TabIndex = 0
        '
        'lblReorder
        '
        Me.lblReorder.AutoSize = False
        Me.lblReorder.BackColor = System.Drawing.Color.Transparent
        Me.lblReorder.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblReorder.Location = New System.Drawing.Point(413, 136)
        Me.lblReorder.Name = "lblReorder"
        Me.lblReorder.Size = New System.Drawing.Size(102, 32)
        Me.lblReorder.TabIndex = 100
        Me.lblReorder.Text = "Reorder"
        '
        'lblQty
        '
        Me.lblQty.AutoSize = False
        Me.lblQty.BackColor = System.Drawing.Color.Transparent
        Me.lblQty.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblQty.Location = New System.Drawing.Point(232, 136)
        Me.lblQty.Name = "lblQty"
        Me.lblQty.Size = New System.Drawing.Size(80, 32)
        Me.lblQty.TabIndex = 101
        Me.lblQty.Text = "Qty"
        '
        'lblWholesale
        '
        Me.lblWholesale.AutoSize = False
        Me.lblWholesale.BackColor = System.Drawing.Color.Transparent
        Me.lblWholesale.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblWholesale.Location = New System.Drawing.Point(8, 136)
        Me.lblWholesale.Name = "lblWholesale"
        Me.lblWholesale.Size = New System.Drawing.Size(180, 32)
        Me.lblWholesale.TabIndex = 102
        Me.lblWholesale.Text = "Wholesale (Rs.)"
        '
        'lblRetail
        '
        Me.lblRetail.AutoSize = False
        Me.lblRetail.BackColor = System.Drawing.Color.Transparent
        Me.lblRetail.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblRetail.Location = New System.Drawing.Point(504, 126)
        Me.lblRetail.Name = "lblRetail"
        Me.lblRetail.Size = New System.Drawing.Size(93, 22)
        Me.lblRetail.TabIndex = 103
        Me.lblRetail.Text = "Retail (Rs.)"
        '
        'lblSize
        '
        Me.lblSize.AutoSize = False
        Me.lblSize.BackColor = System.Drawing.Color.Transparent
        Me.lblSize.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblSize.Location = New System.Drawing.Point(260, 126)
        Me.lblSize.Name = "lblSize"
        Me.lblSize.Size = New System.Drawing.Size(96, 22)
        Me.lblSize.TabIndex = 104
        Me.lblSize.Text = "Tyre Size"
        '
        'lblBrand
        '
        Me.lblBrand.AutoSize = False
        Me.lblBrand.BackColor = System.Drawing.Color.Transparent
        Me.lblBrand.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblBrand.Location = New System.Drawing.Point(16, 126)
        Me.lblBrand.Name = "lblBrand"
        Me.lblBrand.Size = New System.Drawing.Size(72, 22)
        Me.lblBrand.TabIndex = 105
        Me.lblBrand.Text = "Brand"
        '
        'lblType
        '
        Me.lblType.AutoSize = False
        Me.lblType.BackColor = System.Drawing.Color.Transparent
        Me.lblType.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblType.Location = New System.Drawing.Point(504, 56)
        Me.lblType.Name = "lblType"
        Me.lblType.Size = New System.Drawing.Size(68, 22)
        Me.lblType.TabIndex = 106
        Me.lblType.Text = "Type"
        '
        'lblName
        '
        Me.lblName.AutoSize = False
        Me.lblName.BackColor = System.Drawing.Color.Transparent
        Me.lblName.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblName.Location = New System.Drawing.Point(260, 56)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(107, 22)
        Me.lblName.TabIndex = 107
        Me.lblName.Text = "Item Name"
        '
        'lblCode
        '
        Me.lblCode.AutoSize = False
        Me.lblCode.BackColor = System.Drawing.Color.Transparent
        Me.lblCode.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblCode.Location = New System.Drawing.Point(16, 56)
        Me.lblCode.Name = "lblCode"
        Me.lblCode.Size = New System.Drawing.Size(129, 22)
        Me.lblCode.TabIndex = 108
        Me.lblCode.Text = "Item Code"
        '
        'pnlCrud
        '
        Me.pnlCrud.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlCrud.Controls.Add(Me.btnClearProduct)
        Me.pnlCrud.Controls.Add(Me.numReorder)
        Me.pnlCrud.Controls.Add(Me.btnDeleteProduct)
        Me.pnlCrud.Controls.Add(Me.numQuantity)
        Me.pnlCrud.Controls.Add(Me.btnUpdateProduct)
        Me.pnlCrud.Controls.Add(Me.numWholesalePrice)
        Me.pnlCrud.Controls.Add(Me.btnAddProduct)
        Me.pnlCrud.Controls.Add(Me.lblReorder)
        Me.pnlCrud.Controls.Add(Me.lblWholesale)
        Me.pnlCrud.Controls.Add(Me.lblQty)
        Me.pnlCrud.FillColor = System.Drawing.Color.Transparent
        Me.pnlCrud.Location = New System.Drawing.Point(716, 43)
        Me.pnlCrud.Name = "pnlCrud"
        Me.pnlCrud.Size = New System.Drawing.Size(592, 217)
        Me.pnlCrud.TabIndex = 20
        '
        'btnClearProduct
        '
        Me.btnClearProduct.BorderRadius = 12
        Me.btnClearProduct.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnClearProduct.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnClearProduct.ForeColor = System.Drawing.Color.Black
        Me.btnClearProduct.Location = New System.Drawing.Point(372, 83)
        Me.btnClearProduct.Name = "btnClearProduct"
        Me.btnClearProduct.Size = New System.Drawing.Size(170, 40)
        Me.btnClearProduct.TabIndex = 0
        Me.btnClearProduct.Text = "Clear"
        '
        'btnDeleteProduct
        '
        Me.btnDeleteProduct.BorderRadius = 12
        Me.btnDeleteProduct.FillColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.btnDeleteProduct.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnDeleteProduct.ForeColor = System.Drawing.Color.White
        Me.btnDeleteProduct.Location = New System.Drawing.Point(86, 83)
        Me.btnDeleteProduct.Name = "btnDeleteProduct"
        Me.btnDeleteProduct.Size = New System.Drawing.Size(170, 40)
        Me.btnDeleteProduct.TabIndex = 1
        Me.btnDeleteProduct.Text = "Delete"
        '
        'btnUpdateProduct
        '
        Me.btnUpdateProduct.BorderRadius = 12
        Me.btnUpdateProduct.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnUpdateProduct.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnUpdateProduct.ForeColor = System.Drawing.Color.White
        Me.btnUpdateProduct.Location = New System.Drawing.Point(372, 16)
        Me.btnUpdateProduct.Name = "btnUpdateProduct"
        Me.btnUpdateProduct.Size = New System.Drawing.Size(170, 40)
        Me.btnUpdateProduct.TabIndex = 2
        Me.btnUpdateProduct.Text = "Update"
        '
        'btnAddProduct
        '
        Me.btnAddProduct.BorderRadius = 12
        Me.btnAddProduct.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnAddProduct.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnAddProduct.ForeColor = System.Drawing.Color.White
        Me.btnAddProduct.Location = New System.Drawing.Point(86, 16)
        Me.btnAddProduct.Name = "btnAddProduct"
        Me.btnAddProduct.Size = New System.Drawing.Size(170, 40)
        Me.btnAddProduct.TabIndex = 3
        Me.btnAddProduct.Text = "Add"
        '
        'grpList
        '
        Me.grpList.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpList.Controls.Add(Me.dgvProducts)
        Me.grpList.Controls.Add(Me.pnlSearch)
        Me.grpList.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.grpList.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold)
        Me.grpList.ForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.grpList.Location = New System.Drawing.Point(12, 318)
        Me.grpList.Name = "grpList"
        Me.grpList.Size = New System.Drawing.Size(1324, 474)
        Me.grpList.TabIndex = 2
        Me.grpList.Text = "Product List"
        '
        'dgvProducts
        '
        Me.dgvProducts.AllowUserToAddRows = False
        Me.dgvProducts.AllowUserToDeleteRows = False
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.White
        Me.dgvProducts.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvProducts.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold)
        Me.dgvProducts.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.dgvProducts.ColumnHeadersHeight = 32
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvProducts.DefaultCellStyle = DataGridViewCellStyle6
        Me.dgvProducts.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvProducts.Location = New System.Drawing.Point(16, 100)
        Me.dgvProducts.Name = "dgvProducts"
        Me.dgvProducts.ReadOnly = True
        Me.dgvProducts.RowHeadersVisible = False
        Me.dgvProducts.RowHeadersWidth = 51
        Me.dgvProducts.Size = New System.Drawing.Size(1292, 358)
        Me.dgvProducts.TabIndex = 1
        Me.dgvProducts.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.dgvProducts.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.dgvProducts.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.dgvProducts.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.dgvProducts.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.dgvProducts.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.dgvProducts.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvProducts.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvProducts.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvProducts.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvProducts.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.dgvProducts.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvProducts.ThemeStyle.HeaderStyle.Height = 32
        Me.dgvProducts.ThemeStyle.ReadOnly = True
        Me.dgvProducts.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.dgvProducts.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvProducts.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold)
        Me.dgvProducts.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.dgvProducts.ThemeStyle.RowsStyle.Height = 22
        Me.dgvProducts.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvProducts.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'pnlSearch
        '
        Me.pnlSearch.Controls.Add(Me.btnSearchProduct)
        Me.pnlSearch.Controls.Add(Me.txtSearchProduct)
        Me.pnlSearch.Controls.Add(Me.lblSearch)
        Me.pnlSearch.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlSearch.FillColor = System.Drawing.Color.Transparent
        Me.pnlSearch.Location = New System.Drawing.Point(0, 40)
        Me.pnlSearch.Name = "pnlSearch"
        Me.pnlSearch.Size = New System.Drawing.Size(1324, 56)
        Me.pnlSearch.TabIndex = 0
        '
        'btnSearchProduct
        '
        Me.btnSearchProduct.BorderRadius = 10
        Me.btnSearchProduct.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnSearchProduct.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnSearchProduct.ForeColor = System.Drawing.Color.White
        Me.btnSearchProduct.Location = New System.Drawing.Point(500, 12)
        Me.btnSearchProduct.Name = "btnSearchProduct"
        Me.btnSearchProduct.Size = New System.Drawing.Size(120, 36)
        Me.btnSearchProduct.TabIndex = 0
        Me.btnSearchProduct.Text = "Search"
        '
        'txtSearchProduct
        '
        Me.txtSearchProduct.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSearchProduct.DefaultText = ""
        Me.txtSearchProduct.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtSearchProduct.Location = New System.Drawing.Point(82, 12)
        Me.txtSearchProduct.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtSearchProduct.Name = "txtSearchProduct"
        Me.txtSearchProduct.PlaceholderText = "Code, name, brand, size..."
        Me.txtSearchProduct.SelectedText = ""
        Me.txtSearchProduct.Size = New System.Drawing.Size(400, 36)
        Me.txtSearchProduct.TabIndex = 0
        '
        'lblSearch
        '
        Me.lblSearch.BackColor = System.Drawing.Color.Transparent
        Me.lblSearch.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblSearch.Location = New System.Drawing.Point(16, 16)
        Me.lblSearch.Name = "lblSearch"
        Me.lblSearch.Size = New System.Drawing.Size(49, 22)
        Me.lblSearch.TabIndex = 1
        Me.lblSearch.Text = "Search"
        '
        'ProductMgtFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1348, 808)
        Me.Controls.Add(Me.grpList)
        Me.Controls.Add(Me.grpDetails)
        Me.Controls.Add(Me.lblTitle)
        Me.Name = "ProductMgtFrm"
        Me.Text = "Product Management"
        Me.grpDetails.ResumeLayout(False)
        Me.pnlCrud.ResumeLayout(False)
        Me.grpList.ResumeLayout(False)
        CType(Me.dgvProducts, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlSearch.ResumeLayout(False)
        Me.pnlSearch.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitle As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents grpDetails As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents txtItemId As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents lblCode As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lblName As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lblType As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lblBrand As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lblSize As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lblRetail As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lblWholesale As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lblQty As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lblReorder As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents txtItemCode As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtItemName As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents cmbItemType As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents txtBrand As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtTyreSize As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents numRetailPrice As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents numWholesalePrice As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents numQuantity As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents numReorder As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents pnlCrud As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents btnAddProduct As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnUpdateProduct As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnDeleteProduct As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnClearProduct As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents grpList As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents pnlSearch As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents lblSearch As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents txtSearchProduct As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents btnSearchProduct As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents dgvProducts As Guna.UI2.WinForms.Guna2DataGridView
End Class
