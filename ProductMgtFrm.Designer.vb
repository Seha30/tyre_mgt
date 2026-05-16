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
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Me.lblTitle = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.grpDetails = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.txtItemId = New Guna.UI2.WinForms.Guna2TextBox()
        Me.lblCode = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.lblName = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.lblType = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.lblBrand = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.lblSize = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.lblRetail = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.lblWholesale = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.lblQty = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.lblReorder = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.txtItemCode = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtItemName = New Guna.UI2.WinForms.Guna2TextBox()
        Me.cmbItemType = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.txtBrand = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtTyreSize = New Guna.UI2.WinForms.Guna2TextBox()
        Me.numRetailPrice = New Guna.UI2.WinForms.Guna2TextBox()
        Me.numWholesalePrice = New Guna.UI2.WinForms.Guna2TextBox()
        Me.numQuantity = New Guna.UI2.WinForms.Guna2TextBox()
        Me.numReorder = New Guna.UI2.WinForms.Guna2TextBox()
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
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 16.0!, FontStyle.Bold)
        Me.lblTitle.ForeColor = System.Drawing.Color.FromArgb(255, 128, 0)
        Me.lblTitle.Location = New System.Drawing.Point(0, 0)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Padding = New System.Windows.Forms.Padding(12, 8, 0, 0)
        Me.lblTitle.Size = New System.Drawing.Size(1100, 44)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Product Management"
        '
        'grpDetails
        '
        Me.grpDetails.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpDetails.Controls.Add(Me.txtItemId)
        Me.grpDetails.Controls.Add(Me.numReorder)
        Me.grpDetails.Controls.Add(Me.numQuantity)
        Me.grpDetails.Controls.Add(Me.numWholesalePrice)
        Me.grpDetails.Controls.Add(Me.numRetailPrice)
        Me.grpDetails.Controls.Add(Me.txtTyreSize)
        Me.grpDetails.Controls.Add(Me.txtBrand)
        Me.grpDetails.Controls.Add(Me.cmbItemType)
        Me.grpDetails.Controls.Add(Me.txtItemName)
        Me.grpDetails.Controls.Add(Me.txtItemCode)
        Me.grpDetails.Controls.Add(Me.lblReorder)
        Me.grpDetails.Controls.Add(Me.lblQty)
        Me.grpDetails.Controls.Add(Me.lblWholesale)
        Me.grpDetails.Controls.Add(Me.lblRetail)
        Me.grpDetails.Controls.Add(Me.lblSize)
        Me.grpDetails.Controls.Add(Me.lblBrand)
        Me.grpDetails.Controls.Add(Me.lblType)
        Me.grpDetails.Controls.Add(Me.lblName)
        Me.grpDetails.Controls.Add(Me.lblCode)
        Me.grpDetails.Controls.Add(Me.pnlCrud)
        Me.grpDetails.FillColor = System.Drawing.Color.FromArgb(255, 224, 192)
        Me.grpDetails.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, FontStyle.Bold)
        Me.grpDetails.Location = New System.Drawing.Point(12, 52)
        Me.grpDetails.Name = "grpDetails"
        Me.grpDetails.Size = New System.Drawing.Size(1076, 220)
        Me.grpDetails.TabIndex = 1
        Me.grpDetails.Text = "Product / Service Details"
        '
        'txtItemId
        '
        Me.txtItemId.Location = New System.Drawing.Point(16, 28)
        Me.txtItemId.Name = "txtItemId"
        Me.txtItemId.Size = New System.Drawing.Size(40, 28)
        Me.txtItemId.TabIndex = 99
        Me.txtItemId.Visible = False
        '
        'lblCode
        '
        Me.lblCode.BackColor = System.Drawing.Color.Transparent
        Me.lblCode.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, FontStyle.Bold)
        Me.lblCode.Location = New System.Drawing.Point(16, 56)
        Me.lblCode.Name = "lblCode"
        Me.lblCode.Size = New System.Drawing.Size(90, 22)
        Me.lblCode.Text = "Item Code"
        '
        'lblName
        '
        Me.lblName.BackColor = System.Drawing.Color.Transparent
        Me.lblName.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, FontStyle.Bold)
        Me.lblName.Location = New System.Drawing.Point(260, 56)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(90, 22)
        Me.lblName.Text = "Item Name"
        '
        'lblType
        '
        Me.lblType.BackColor = System.Drawing.Color.Transparent
        Me.lblType.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, FontStyle.Bold)
        Me.lblType.Location = New System.Drawing.Point(504, 56)
        Me.lblType.Name = "lblType"
        Me.lblType.Size = New System.Drawing.Size(90, 22)
        Me.lblType.Text = "Type"
        '
        'lblBrand
        '
        Me.lblBrand.BackColor = System.Drawing.Color.Transparent
        Me.lblBrand.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, FontStyle.Bold)
        Me.lblBrand.Location = New System.Drawing.Point(16, 120)
        Me.lblBrand.Name = "lblBrand"
        Me.lblBrand.Size = New System.Drawing.Size(90, 22)
        Me.lblBrand.Text = "Brand"
        '
        'lblSize
        '
        Me.lblSize.BackColor = System.Drawing.Color.Transparent
        Me.lblSize.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, FontStyle.Bold)
        Me.lblSize.Location = New System.Drawing.Point(260, 120)
        Me.lblSize.Name = "lblSize"
        Me.lblSize.Size = New System.Drawing.Size(90, 22)
        Me.lblSize.Text = "Tyre Size"
        '
        'lblRetail
        '
        Me.lblRetail.BackColor = System.Drawing.Color.Transparent
        Me.lblRetail.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, FontStyle.Bold)
        Me.lblRetail.Location = New System.Drawing.Point(504, 120)
        Me.lblRetail.Name = "lblRetail"
        Me.lblRetail.Size = New System.Drawing.Size(100, 22)
        Me.lblRetail.Text = "Retail (Rs.)"
        '
        'lblWholesale
        '
        Me.lblWholesale.BackColor = System.Drawing.Color.Transparent
        Me.lblWholesale.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, FontStyle.Bold)
        Me.lblWholesale.Location = New System.Drawing.Point(660, 120)
        Me.lblWholesale.Name = "lblWholesale"
        Me.lblWholesale.Size = New System.Drawing.Size(110, 22)
        Me.lblWholesale.Text = "Wholesale (Rs.)"
        '
        'lblQty
        '
        Me.lblQty.BackColor = System.Drawing.Color.Transparent
        Me.lblQty.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, FontStyle.Bold)
        Me.lblQty.Location = New System.Drawing.Point(816, 120)
        Me.lblQty.Name = "lblQty"
        Me.lblQty.Size = New System.Drawing.Size(70, 22)
        Me.lblQty.Text = "Qty"
        '
        'lblReorder
        '
        Me.lblReorder.BackColor = System.Drawing.Color.Transparent
        Me.lblReorder.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, FontStyle.Bold)
        Me.lblReorder.Location = New System.Drawing.Point(916, 120)
        Me.lblReorder.Name = "lblReorder"
        Me.lblReorder.Size = New System.Drawing.Size(80, 22)
        Me.lblReorder.Text = "Reorder"
        '
        'txtItemCode
        '
        Me.txtItemCode.Location = New System.Drawing.Point(16, 84)
        Me.txtItemCode.Name = "txtItemCode"
        Me.txtItemCode.PlaceholderText = "TYR-195-65-15"
        Me.txtItemCode.Size = New System.Drawing.Size(220, 32)
        Me.txtItemCode.TabIndex = 0
        '
        'txtItemName
        '
        Me.txtItemName.Location = New System.Drawing.Point(260, 84)
        Me.txtItemName.Name = "txtItemName"
        Me.txtItemName.PlaceholderText = "Product name"
        Me.txtItemName.Size = New System.Drawing.Size(220, 32)
        Me.txtItemName.TabIndex = 1
        '
        'cmbItemType
        '
        Me.cmbItemType.BackColor = System.Drawing.Color.Transparent
        Me.cmbItemType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbItemType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbItemType.ItemHeight = 30
        Me.cmbItemType.Location = New System.Drawing.Point(504, 84)
        Me.cmbItemType.Name = "cmbItemType"
        Me.cmbItemType.Size = New System.Drawing.Size(140, 36)
        Me.cmbItemType.TabIndex = 2
        '
        'txtBrand
        '
        Me.txtBrand.Location = New System.Drawing.Point(16, 148)
        Me.txtBrand.Name = "txtBrand"
        Me.txtBrand.PlaceholderText = "Ceat, Michelin..."
        Me.txtBrand.Size = New System.Drawing.Size(220, 32)
        Me.txtBrand.TabIndex = 3
        '
        'txtTyreSize
        '
        Me.txtTyreSize.Location = New System.Drawing.Point(260, 148)
        Me.txtTyreSize.Name = "txtTyreSize"
        Me.txtTyreSize.PlaceholderText = "195/65R15"
        Me.txtTyreSize.Size = New System.Drawing.Size(220, 32)
        Me.txtTyreSize.TabIndex = 4
        '
        'numRetailPrice
        '
        Me.numRetailPrice.Location = New System.Drawing.Point(504, 148)
        Me.numRetailPrice.Name = "numRetailPrice"
        Me.numRetailPrice.PlaceholderText = "0.00"
        Me.numRetailPrice.Size = New System.Drawing.Size(140, 32)
        Me.numRetailPrice.TabIndex = 5
        '
        'numWholesalePrice
        '
        Me.numWholesalePrice.Location = New System.Drawing.Point(660, 148)
        Me.numWholesalePrice.Name = "numWholesalePrice"
        Me.numWholesalePrice.PlaceholderText = "0.00"
        Me.numWholesalePrice.Size = New System.Drawing.Size(140, 32)
        Me.numWholesalePrice.TabIndex = 6
        '
        'numQuantity
        '
        Me.numQuantity.Location = New System.Drawing.Point(816, 148)
        Me.numQuantity.Name = "numQuantity"
        Me.numQuantity.PlaceholderText = "0"
        Me.numQuantity.Size = New System.Drawing.Size(80, 32)
        Me.numQuantity.TabIndex = 7
        '
        'numReorder
        '
        Me.numReorder.Location = New System.Drawing.Point(916, 148)
        Me.numReorder.Name = "numReorder"
        Me.numReorder.PlaceholderText = "5"
        Me.numReorder.Size = New System.Drawing.Size(80, 32)
        Me.numReorder.TabIndex = 8
        '
        'pnlCrud
        '
        Me.pnlCrud.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlCrud.Controls.Add(Me.btnClearProduct)
        Me.pnlCrud.Controls.Add(Me.btnDeleteProduct)
        Me.pnlCrud.Controls.Add(Me.btnUpdateProduct)
        Me.pnlCrud.Controls.Add(Me.btnAddProduct)
        Me.pnlCrud.FillColor = System.Drawing.Color.Transparent
        Me.pnlCrud.Location = New System.Drawing.Point(680, 40)
        Me.pnlCrud.Name = "pnlCrud"
        Me.pnlCrud.Size = New System.Drawing.Size(380, 200)
        Me.pnlCrud.TabIndex = 20
        '
        'btnAddProduct
        '
        Me.btnAddProduct.BorderRadius = 12
        Me.btnAddProduct.FillColor = System.Drawing.Color.FromArgb(255, 128, 0)
        Me.btnAddProduct.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, FontStyle.Bold)
        Me.btnAddProduct.ForeColor = System.Drawing.Color.White
        Me.btnAddProduct.Location = New System.Drawing.Point(8, 16)
        Me.btnAddProduct.Name = "btnAddProduct"
        Me.btnAddProduct.Size = New System.Drawing.Size(170, 40)
        Me.btnAddProduct.Text = "Add"
        '
        'btnUpdateProduct
        '
        Me.btnUpdateProduct.BorderRadius = 12
        Me.btnUpdateProduct.FillColor = System.Drawing.Color.FromArgb(255, 128, 0)
        Me.btnUpdateProduct.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, FontStyle.Bold)
        Me.btnUpdateProduct.ForeColor = System.Drawing.Color.White
        Me.btnUpdateProduct.Location = New System.Drawing.Point(192, 16)
        Me.btnUpdateProduct.Name = "btnUpdateProduct"
        Me.btnUpdateProduct.Size = New System.Drawing.Size(170, 40)
        Me.btnUpdateProduct.Text = "Update"
        '
        'btnDeleteProduct
        '
        Me.btnDeleteProduct.BorderRadius = 12
        Me.btnDeleteProduct.FillColor = System.Drawing.Color.FromArgb(220, 53, 69)
        Me.btnDeleteProduct.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, FontStyle.Bold)
        Me.btnDeleteProduct.ForeColor = System.Drawing.Color.White
        Me.btnDeleteProduct.Location = New System.Drawing.Point(8, 68)
        Me.btnDeleteProduct.Name = "btnDeleteProduct"
        Me.btnDeleteProduct.Size = New System.Drawing.Size(170, 40)
        Me.btnDeleteProduct.Text = "Delete"
        '
        'btnClearProduct
        '
        Me.btnClearProduct.BorderRadius = 12
        Me.btnClearProduct.FillColor = System.Drawing.Color.FromArgb(255, 192, 128)
        Me.btnClearProduct.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, FontStyle.Bold)
        Me.btnClearProduct.ForeColor = System.Drawing.Color.Black
        Me.btnClearProduct.Location = New System.Drawing.Point(192, 68)
        Me.btnClearProduct.Name = "btnClearProduct"
        Me.btnClearProduct.Size = New System.Drawing.Size(170, 40)
        Me.btnClearProduct.Text = "Clear"
        '
        'grpList
        '
        Me.grpList.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpList.Controls.Add(Me.dgvProducts)
        Me.grpList.Controls.Add(Me.pnlSearch)
        Me.grpList.FillColor = System.Drawing.Color.FromArgb(255, 224, 192)
        Me.grpList.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, FontStyle.Bold)
        Me.grpList.Location = New System.Drawing.Point(12, 284)
        Me.grpList.Name = "grpList"
        Me.grpList.Size = New System.Drawing.Size(1076, 320)
        Me.grpList.TabIndex = 2
        Me.grpList.Text = "Product List"
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
        Me.pnlSearch.Size = New System.Drawing.Size(1076, 56)
        Me.pnlSearch.TabIndex = 0
        '
        'lblSearch
        '
        Me.lblSearch.BackColor = System.Drawing.Color.Transparent
        Me.lblSearch.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, FontStyle.Bold)
        Me.lblSearch.Location = New System.Drawing.Point(16, 16)
        Me.lblSearch.Name = "lblSearch"
        Me.lblSearch.Size = New System.Drawing.Size(60, 22)
        Me.lblSearch.Text = "Search"
        '
        'txtSearchProduct
        '
        Me.txtSearchProduct.Location = New System.Drawing.Point(82, 12)
        Me.txtSearchProduct.Name = "txtSearchProduct"
        Me.txtSearchProduct.PlaceholderText = "Code, name, brand, size..."
        Me.txtSearchProduct.Size = New System.Drawing.Size(400, 36)
        Me.txtSearchProduct.TabIndex = 0
        '
        'btnSearchProduct
        '
        Me.btnSearchProduct.BorderRadius = 10
        Me.btnSearchProduct.FillColor = System.Drawing.Color.FromArgb(255, 128, 0)
        Me.btnSearchProduct.ForeColor = System.Drawing.Color.White
        Me.btnSearchProduct.Location = New System.Drawing.Point(500, 12)
        Me.btnSearchProduct.Name = "btnSearchProduct"
        Me.btnSearchProduct.Size = New System.Drawing.Size(120, 36)
        Me.btnSearchProduct.Text = "Search"
        '
        'dgvProducts
        '
        Me.dgvProducts.AllowUserToAddRows = False
        Me.dgvProducts.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.dgvProducts.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvProducts.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(255, 192, 128)
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, FontStyle.Bold)
        Me.dgvProducts.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvProducts.ColumnHeadersHeight = 32
        Me.dgvProducts.Location = New System.Drawing.Point(16, 100)
        Me.dgvProducts.Name = "dgvProducts"
        Me.dgvProducts.ReadOnly = True
        Me.dgvProducts.RowHeadersVisible = False
        Me.dgvProducts.Size = New System.Drawing.Size(1044, 204)
        Me.dgvProducts.TabIndex = 1
        '
        'ProductMgtFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(248, 249, 250)
        Me.ClientSize = New System.Drawing.Size(1100, 620)
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
        Me.ResumeLayout(False)

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
