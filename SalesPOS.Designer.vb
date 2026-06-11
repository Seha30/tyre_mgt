<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SalesPOS
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
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle17 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle18 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.lblTitle = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.splitMain = New System.Windows.Forms.SplitContainer()
        Me.grpCatalog = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.dgvCatalog = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.pnlCatalogSearch = New Guna.UI2.WinForms.Guna2Panel()
        Me.btnSearchItemPOS = New Guna.UI2.WinForms.Guna2Button()
        Me.txtSearchItemPOS = New Guna.UI2.WinForms.Guna2TextBox()
        Me.pnlCheckout = New Guna.UI2.WinForms.Guna2Panel()
        Me.grpCheckout = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.btnGenerateInvoce = New Guna.UI2.WinForms.Guna2Button()
        Me.lblSubtotal = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.txtSubtotal = New Guna.UI2.WinForms.Guna2TextBox()
        Me.lblDiscount = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.txtDiscount = New Guna.UI2.WinForms.Guna2TextBox()
        Me.lblTotal = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.txtTotal = New Guna.UI2.WinForms.Guna2TextBox()
        Me.btnCompleteSale = New Guna.UI2.WinForms.Guna2Button()
        Me.btnClearCart = New Guna.UI2.WinForms.Guna2Button()
        Me.grpCart = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.dgvCart = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.btnAddToCart = New Guna.UI2.WinForms.Guna2Button()
        Me.btnRemoveLine = New Guna.UI2.WinForms.Guna2Button()
        Me.numQtyPOS = New Guna.UI2.WinForms.Guna2TextBox()
        Me.lblQtyPOS = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.grpCustomer = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.cmbPayment = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.lblPayment = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.cmbCustomerPOS = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.lblCustomerPOS = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.btnInvoicePrint = New Guna.UI2.WinForms.Guna2Button()
        CType(Me.splitMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.splitMain.Panel1.SuspendLayout()
        Me.splitMain.Panel2.SuspendLayout()
        Me.splitMain.SuspendLayout()
        Me.grpCatalog.SuspendLayout()
        CType(Me.dgvCatalog, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlCatalogSearch.SuspendLayout()
        Me.pnlCheckout.SuspendLayout()
        Me.grpCheckout.SuspendLayout()
        Me.grpCart.SuspendLayout()
        CType(Me.dgvCart, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpCustomer.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblTitle.Location = New System.Drawing.Point(0, 0)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(155, 18)
        Me.lblTitle.TabIndex = 1
        Me.lblTitle.Text = "Sales Point of Sale (POS)"
        Me.lblTitle.Visible = False
        '
        'splitMain
        '
        Me.splitMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.splitMain.Location = New System.Drawing.Point(0, 0)
        Me.splitMain.Margin = New System.Windows.Forms.Padding(4)
        Me.splitMain.Name = "splitMain"
        '
        'splitMain.Panel1
        '
        Me.splitMain.Panel1.Controls.Add(Me.grpCatalog)
        Me.splitMain.Panel1MinSize = 300
        '
        'splitMain.Panel2
        '
        Me.splitMain.Panel2.Controls.Add(Me.pnlCheckout)
        Me.splitMain.Panel2MinSize = 340
        Me.splitMain.Size = New System.Drawing.Size(1122, 738)
        Me.splitMain.SplitterDistance = 320
        Me.splitMain.SplitterWidth = 5
        Me.splitMain.TabIndex = 0
        '
        'grpCatalog
        '
        Me.grpCatalog.Controls.Add(Me.dgvCatalog)
        Me.grpCatalog.Controls.Add(Me.pnlCatalogSearch)
        Me.grpCatalog.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grpCatalog.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.grpCatalog.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold)
        Me.grpCatalog.ForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.grpCatalog.Location = New System.Drawing.Point(0, 0)
        Me.grpCatalog.Margin = New System.Windows.Forms.Padding(4)
        Me.grpCatalog.Name = "grpCatalog"
        Me.grpCatalog.Size = New System.Drawing.Size(320, 738)
        Me.grpCatalog.TabIndex = 0
        Me.grpCatalog.Text = "Product Catalog"
        '
        'dgvCatalog
        '
        Me.dgvCatalog.AllowUserToAddRows = False
        DataGridViewCellStyle13.BackColor = System.Drawing.Color.White
        Me.dgvCatalog.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle13
        DataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        DataGridViewCellStyle14.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold)
        Me.dgvCatalog.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle14
        DataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle15.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle15.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle15.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvCatalog.DefaultCellStyle = DataGridViewCellStyle15
        Me.dgvCatalog.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvCatalog.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvCatalog.Location = New System.Drawing.Point(0, 104)
        Me.dgvCatalog.Margin = New System.Windows.Forms.Padding(4)
        Me.dgvCatalog.Name = "dgvCatalog"
        Me.dgvCatalog.ReadOnly = True
        Me.dgvCatalog.RowHeadersVisible = False
        Me.dgvCatalog.RowHeadersWidth = 51
        Me.dgvCatalog.Size = New System.Drawing.Size(320, 634)
        Me.dgvCatalog.TabIndex = 0
        Me.dgvCatalog.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.dgvCatalog.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.dgvCatalog.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.dgvCatalog.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.dgvCatalog.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.dgvCatalog.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.dgvCatalog.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvCatalog.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvCatalog.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvCatalog.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvCatalog.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.dgvCatalog.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvCatalog.ThemeStyle.HeaderStyle.Height = 23
        Me.dgvCatalog.ThemeStyle.ReadOnly = True
        Me.dgvCatalog.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.dgvCatalog.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvCatalog.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold)
        Me.dgvCatalog.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.dgvCatalog.ThemeStyle.RowsStyle.Height = 22
        Me.dgvCatalog.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvCatalog.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'pnlCatalogSearch
        '
        Me.pnlCatalogSearch.Controls.Add(Me.btnSearchItemPOS)
        Me.pnlCatalogSearch.Controls.Add(Me.txtSearchItemPOS)
        Me.pnlCatalogSearch.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlCatalogSearch.Location = New System.Drawing.Point(0, 40)
        Me.pnlCatalogSearch.Margin = New System.Windows.Forms.Padding(4)
        Me.pnlCatalogSearch.Name = "pnlCatalogSearch"
        Me.pnlCatalogSearch.Size = New System.Drawing.Size(320, 64)
        Me.pnlCatalogSearch.TabIndex = 1
        '
        'btnSearchItemPOS
        '
        Me.btnSearchItemPOS.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnSearchItemPOS.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnSearchItemPOS.ForeColor = System.Drawing.Color.White
        Me.btnSearchItemPOS.Location = New System.Drawing.Point(427, 12)
        Me.btnSearchItemPOS.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSearchItemPOS.Name = "btnSearchItemPOS"
        Me.btnSearchItemPOS.Size = New System.Drawing.Size(133, 39)
        Me.btnSearchItemPOS.TabIndex = 0
        Me.btnSearchItemPOS.Text = "Search"
        '
        'txtSearchItemPOS
        '
        Me.txtSearchItemPOS.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSearchItemPOS.DefaultText = ""
        Me.txtSearchItemPOS.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtSearchItemPOS.Location = New System.Drawing.Point(16, 12)
        Me.txtSearchItemPOS.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtSearchItemPOS.Name = "txtSearchItemPOS"
        Me.txtSearchItemPOS.PlaceholderText = "Search code, brand, size..."
        Me.txtSearchItemPOS.SelectedText = ""
        Me.txtSearchItemPOS.Size = New System.Drawing.Size(400, 39)
        Me.txtSearchItemPOS.TabIndex = 1
        '
        'pnlCheckout
        '
        Me.pnlCheckout.Controls.Add(Me.grpCheckout)
        Me.pnlCheckout.Controls.Add(Me.grpCart)
        Me.pnlCheckout.Controls.Add(Me.grpCustomer)
        Me.pnlCheckout.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlCheckout.Location = New System.Drawing.Point(0, 0)
        Me.pnlCheckout.Margin = New System.Windows.Forms.Padding(4)
        Me.pnlCheckout.Name = "pnlCheckout"
        Me.pnlCheckout.Size = New System.Drawing.Size(797, 738)
        Me.pnlCheckout.TabIndex = 0
        '
        'grpCheckout
        '
        Me.grpCheckout.Controls.Add(Me.btnInvoicePrint)
        Me.grpCheckout.Controls.Add(Me.btnGenerateInvoce)
        Me.grpCheckout.Controls.Add(Me.lblSubtotal)
        Me.grpCheckout.Controls.Add(Me.txtSubtotal)
        Me.grpCheckout.Controls.Add(Me.lblDiscount)
        Me.grpCheckout.Controls.Add(Me.txtDiscount)
        Me.grpCheckout.Controls.Add(Me.lblTotal)
        Me.grpCheckout.Controls.Add(Me.txtTotal)
        Me.grpCheckout.Controls.Add(Me.btnCompleteSale)
        Me.grpCheckout.Controls.Add(Me.btnClearCart)
        Me.grpCheckout.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.grpCheckout.FillColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.grpCheckout.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.grpCheckout.ForeColor = System.Drawing.Color.White
        Me.grpCheckout.Location = New System.Drawing.Point(0, 391)
        Me.grpCheckout.Margin = New System.Windows.Forms.Padding(4)
        Me.grpCheckout.Name = "grpCheckout"
        Me.grpCheckout.Size = New System.Drawing.Size(797, 347)
        Me.grpCheckout.TabIndex = 0
        Me.grpCheckout.Text = "Payment Summary"
        '
        'btnGenerateInvoce
        '
        Me.btnGenerateInvoce.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnGenerateInvoce.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnGenerateInvoce.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnGenerateInvoce.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnGenerateInvoce.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnGenerateInvoce.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGenerateInvoce.ForeColor = System.Drawing.Color.White
        Me.btnGenerateInvoce.Location = New System.Drawing.Point(187, 236)
        Me.btnGenerateInvoce.Name = "btnGenerateInvoce"
        Me.btnGenerateInvoce.Size = New System.Drawing.Size(267, 54)
        Me.btnGenerateInvoce.TabIndex = 8
        Me.btnGenerateInvoce.Text = "Invoice Generate"
        '
        'lblSubtotal
        '
        Me.lblSubtotal.AutoSize = False
        Me.lblSubtotal.BackColor = System.Drawing.Color.Transparent
        Me.lblSubtotal.ForeColor = System.Drawing.Color.White
        Me.lblSubtotal.Location = New System.Drawing.Point(21, 54)
        Me.lblSubtotal.Margin = New System.Windows.Forms.Padding(4)
        Me.lblSubtotal.Name = "lblSubtotal"
        Me.lblSubtotal.Size = New System.Drawing.Size(134, 23)
        Me.lblSubtotal.TabIndex = 0
        Me.lblSubtotal.Text = "Subtotal (Rs.)"
        '
        'txtSubtotal
        '
        Me.txtSubtotal.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSubtotal.DefaultText = ""
        Me.txtSubtotal.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtSubtotal.Location = New System.Drawing.Point(187, 54)
        Me.txtSubtotal.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtSubtotal.Name = "txtSubtotal"
        Me.txtSubtotal.PlaceholderText = ""
        Me.txtSubtotal.ReadOnly = True
        Me.txtSubtotal.SelectedText = ""
        Me.txtSubtotal.Size = New System.Drawing.Size(187, 39)
        Me.txtSubtotal.TabIndex = 1
        '
        'lblDiscount
        '
        Me.lblDiscount.AutoSize = False
        Me.lblDiscount.BackColor = System.Drawing.Color.Transparent
        Me.lblDiscount.ForeColor = System.Drawing.Color.White
        Me.lblDiscount.Location = New System.Drawing.Point(400, 59)
        Me.lblDiscount.Margin = New System.Windows.Forms.Padding(4)
        Me.lblDiscount.Name = "lblDiscount"
        Me.lblDiscount.Size = New System.Drawing.Size(86, 34)
        Me.lblDiscount.TabIndex = 2
        Me.lblDiscount.Text = "Discount (Rs.)"
        '
        'txtDiscount
        '
        Me.txtDiscount.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtDiscount.DefaultText = ""
        Me.txtDiscount.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtDiscount.Location = New System.Drawing.Point(507, 59)
        Me.txtDiscount.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtDiscount.Name = "txtDiscount"
        Me.txtDiscount.PlaceholderText = ""
        Me.txtDiscount.SelectedText = ""
        Me.txtDiscount.Size = New System.Drawing.Size(133, 39)
        Me.txtDiscount.TabIndex = 3
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = False
        Me.lblTotal.BackColor = System.Drawing.Color.Transparent
        Me.lblTotal.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblTotal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblTotal.Location = New System.Drawing.Point(21, 118)
        Me.lblTotal.Margin = New System.Windows.Forms.Padding(4)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(147, 44)
        Me.lblTotal.TabIndex = 4
        Me.lblTotal.Text = "TOTAL (Rs.)"
        '
        'txtTotal
        '
        Me.txtTotal.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtTotal.DefaultText = ""
        Me.txtTotal.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txtTotal.Location = New System.Drawing.Point(187, 118)
        Me.txtTotal.Margin = New System.Windows.Forms.Padding(5)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.PlaceholderText = ""
        Me.txtTotal.ReadOnly = True
        Me.txtTotal.SelectedText = ""
        Me.txtTotal.Size = New System.Drawing.Size(267, 44)
        Me.txtTotal.TabIndex = 5
        '
        'btnCompleteSale
        '
        Me.btnCompleteSale.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnCompleteSale.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCompleteSale.ForeColor = System.Drawing.Color.White
        Me.btnCompleteSale.Location = New System.Drawing.Point(501, 175)
        Me.btnCompleteSale.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCompleteSale.Name = "btnCompleteSale"
        Me.btnCompleteSale.Size = New System.Drawing.Size(267, 54)
        Me.btnCompleteSale.TabIndex = 6
        Me.btnCompleteSale.Text = "Complete Sale"
        '
        'btnClearCart
        '
        Me.btnClearCart.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnClearCart.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnClearCart.ForeColor = System.Drawing.Color.White
        Me.btnClearCart.Location = New System.Drawing.Point(187, 180)
        Me.btnClearCart.Margin = New System.Windows.Forms.Padding(4)
        Me.btnClearCart.Name = "btnClearCart"
        Me.btnClearCart.Size = New System.Drawing.Size(267, 49)
        Me.btnClearCart.TabIndex = 7
        Me.btnClearCart.Text = "Clear Cart"
        '
        'grpCart
        '
        Me.grpCart.Controls.Add(Me.dgvCart)
        Me.grpCart.Controls.Add(Me.btnAddToCart)
        Me.grpCart.Controls.Add(Me.btnRemoveLine)
        Me.grpCart.Controls.Add(Me.numQtyPOS)
        Me.grpCart.Controls.Add(Me.lblQtyPOS)
        Me.grpCart.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grpCart.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.grpCart.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.grpCart.ForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.grpCart.Location = New System.Drawing.Point(0, 96)
        Me.grpCart.Margin = New System.Windows.Forms.Padding(4)
        Me.grpCart.Name = "grpCart"
        Me.grpCart.Size = New System.Drawing.Size(797, 642)
        Me.grpCart.TabIndex = 1
        Me.grpCart.Text = "Shopping Cart"
        '
        'dgvCart
        '
        Me.dgvCart.AllowUserToAddRows = False
        DataGridViewCellStyle16.BackColor = System.Drawing.Color.White
        Me.dgvCart.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle16
        Me.dgvCart.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        DataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle17.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle17.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        DataGridViewCellStyle17.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvCart.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle17
        DataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle18.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle18.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        DataGridViewCellStyle18.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvCart.DefaultCellStyle = DataGridViewCellStyle18
        Me.dgvCart.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvCart.Location = New System.Drawing.Point(4, 91)
        Me.dgvCart.Margin = New System.Windows.Forms.Padding(4)
        Me.dgvCart.Name = "dgvCart"
        Me.dgvCart.RowHeadersVisible = False
        Me.dgvCart.RowHeadersWidth = 51
        Me.dgvCart.Size = New System.Drawing.Size(920, 703)
        Me.dgvCart.TabIndex = 0
        Me.dgvCart.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.dgvCart.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.dgvCart.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.dgvCart.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.dgvCart.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.dgvCart.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.dgvCart.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvCart.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvCart.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvCart.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.dgvCart.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.dgvCart.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvCart.ThemeStyle.HeaderStyle.Height = 23
        Me.dgvCart.ThemeStyle.ReadOnly = False
        Me.dgvCart.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.dgvCart.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvCart.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.dgvCart.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.dgvCart.ThemeStyle.RowsStyle.Height = 22
        Me.dgvCart.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvCart.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'btnAddToCart
        '
        Me.btnAddToCart.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnAddToCart.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnAddToCart.ForeColor = System.Drawing.Color.White
        Me.btnAddToCart.Location = New System.Drawing.Point(173, 44)
        Me.btnAddToCart.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAddToCart.Name = "btnAddToCart"
        Me.btnAddToCart.Size = New System.Drawing.Size(160, 39)
        Me.btnAddToCart.TabIndex = 1
        Me.btnAddToCart.Text = "Add to Cart"
        '
        'btnRemoveLine
        '
        Me.btnRemoveLine.FillColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.btnRemoveLine.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnRemoveLine.ForeColor = System.Drawing.Color.White
        Me.btnRemoveLine.Location = New System.Drawing.Point(347, 44)
        Me.btnRemoveLine.Margin = New System.Windows.Forms.Padding(4)
        Me.btnRemoveLine.Name = "btnRemoveLine"
        Me.btnRemoveLine.Size = New System.Drawing.Size(160, 39)
        Me.btnRemoveLine.TabIndex = 2
        Me.btnRemoveLine.Text = "Remove Line"
        '
        'numQtyPOS
        '
        Me.numQtyPOS.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.numQtyPOS.DefaultText = "1"
        Me.numQtyPOS.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.numQtyPOS.Location = New System.Drawing.Point(75, 44)
        Me.numQtyPOS.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.numQtyPOS.Name = "numQtyPOS"
        Me.numQtyPOS.PlaceholderText = ""
        Me.numQtyPOS.SelectedText = ""
        Me.numQtyPOS.Size = New System.Drawing.Size(80, 39)
        Me.numQtyPOS.TabIndex = 3
        '
        'lblQtyPOS
        '
        Me.lblQtyPOS.AutoSize = False
        Me.lblQtyPOS.BackColor = System.Drawing.Color.Transparent
        Me.lblQtyPOS.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQtyPOS.ForeColor = System.Drawing.Color.Black
        Me.lblQtyPOS.Location = New System.Drawing.Point(16, 49)
        Me.lblQtyPOS.Margin = New System.Windows.Forms.Padding(4)
        Me.lblQtyPOS.Name = "lblQtyPOS"
        Me.lblQtyPOS.Size = New System.Drawing.Size(29, 21)
        Me.lblQtyPOS.TabIndex = 4
        Me.lblQtyPOS.Text = "Qty"
        '
        'grpCustomer
        '
        Me.grpCustomer.Controls.Add(Me.cmbPayment)
        Me.grpCustomer.Controls.Add(Me.lblPayment)
        Me.grpCustomer.Controls.Add(Me.cmbCustomerPOS)
        Me.grpCustomer.Controls.Add(Me.lblCustomerPOS)
        Me.grpCustomer.Dock = System.Windows.Forms.DockStyle.Top
        Me.grpCustomer.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.grpCustomer.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.grpCustomer.ForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.grpCustomer.Location = New System.Drawing.Point(0, 0)
        Me.grpCustomer.Margin = New System.Windows.Forms.Padding(4)
        Me.grpCustomer.Name = "grpCustomer"
        Me.grpCustomer.Size = New System.Drawing.Size(797, 96)
        Me.grpCustomer.TabIndex = 2
        Me.grpCustomer.Text = "Customer & Payment"
        '
        'cmbPayment
        '
        Me.cmbPayment.BackColor = System.Drawing.Color.Transparent
        Me.cmbPayment.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbPayment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPayment.FocusedColor = System.Drawing.Color.Empty
        Me.cmbPayment.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cmbPayment.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cmbPayment.ItemHeight = 30
        Me.cmbPayment.Location = New System.Drawing.Point(640, 44)
        Me.cmbPayment.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbPayment.Name = "cmbPayment"
        Me.cmbPayment.Size = New System.Drawing.Size(159, 36)
        Me.cmbPayment.TabIndex = 0
        '
        'lblPayment
        '
        Me.lblPayment.AutoSize = False
        Me.lblPayment.BackColor = System.Drawing.Color.Transparent
        Me.lblPayment.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPayment.ForeColor = System.Drawing.Color.Black
        Me.lblPayment.Location = New System.Drawing.Point(533, 49)
        Me.lblPayment.Margin = New System.Windows.Forms.Padding(4)
        Me.lblPayment.Name = "lblPayment"
        Me.lblPayment.Size = New System.Drawing.Size(160, 70)
        Me.lblPayment.TabIndex = 1
        Me.lblPayment.Text = "Payment"
        '
        'cmbCustomerPOS
        '
        Me.cmbCustomerPOS.BackColor = System.Drawing.Color.Transparent
        Me.cmbCustomerPOS.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbCustomerPOS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCustomerPOS.FocusedColor = System.Drawing.Color.Empty
        Me.cmbCustomerPOS.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cmbCustomerPOS.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cmbCustomerPOS.ItemHeight = 30
        Me.cmbCustomerPOS.Location = New System.Drawing.Point(173, 44)
        Me.cmbCustomerPOS.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbCustomerPOS.Name = "cmbCustomerPOS"
        Me.cmbCustomerPOS.Size = New System.Drawing.Size(352, 36)
        Me.cmbCustomerPOS.TabIndex = 2
        '
        'lblCustomerPOS
        '
        Me.lblCustomerPOS.AutoSize = False
        Me.lblCustomerPOS.BackColor = System.Drawing.Color.Transparent
        Me.lblCustomerPOS.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCustomerPOS.ForeColor = System.Drawing.Color.Black
        Me.lblCustomerPOS.Location = New System.Drawing.Point(21, 49)
        Me.lblCustomerPOS.Margin = New System.Windows.Forms.Padding(4)
        Me.lblCustomerPOS.Name = "lblCustomerPOS"
        Me.lblCustomerPOS.Size = New System.Drawing.Size(134, 74)
        Me.lblCustomerPOS.TabIndex = 3
        Me.lblCustomerPOS.Text = "Customer"
        '
        'btnInvoicePrint
        '
        Me.btnInvoicePrint.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnInvoicePrint.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnInvoicePrint.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnInvoicePrint.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnInvoicePrint.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnInvoicePrint.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInvoicePrint.ForeColor = System.Drawing.Color.White
        Me.btnInvoicePrint.Location = New System.Drawing.Point(501, 236)
        Me.btnInvoicePrint.Name = "btnInvoicePrint"
        Me.btnInvoicePrint.Size = New System.Drawing.Size(267, 54)
        Me.btnInvoicePrint.TabIndex = 9
        Me.btnInvoicePrint.Text = "Print Invoice"
        '
        'SalesPOS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1122, 738)
        Me.Controls.Add(Me.splitMain)
        Me.Controls.Add(Me.lblTitle)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "SalesPOS"
        Me.splitMain.Panel1.ResumeLayout(False)
        Me.splitMain.Panel2.ResumeLayout(False)
        CType(Me.splitMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.splitMain.ResumeLayout(False)
        Me.grpCatalog.ResumeLayout(False)
        CType(Me.dgvCatalog, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlCatalogSearch.ResumeLayout(False)
        Me.pnlCheckout.ResumeLayout(False)
        Me.grpCheckout.ResumeLayout(False)
        Me.grpCart.ResumeLayout(False)
        CType(Me.dgvCart, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpCustomer.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitle As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents splitMain As SplitContainer
    Friend WithEvents grpCatalog As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents pnlCatalogSearch As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents txtSearchItemPOS As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents btnSearchItemPOS As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents dgvCatalog As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents pnlCheckout As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents grpCustomer As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents lblCustomerPOS As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents cmbCustomerPOS As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents lblPayment As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents cmbPayment As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents grpCart As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents dgvCart As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents lblQtyPOS As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents numQtyPOS As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents btnAddToCart As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnRemoveLine As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents grpCheckout As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents lblSubtotal As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lblDiscount As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lblTotal As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents txtSubtotal As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtDiscount As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtTotal As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents btnCompleteSale As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnClearCart As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnGenerateInvoce As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnInvoicePrint As Guna.UI2.WinForms.Guna2Button
End Class
