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
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.lblTitle = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.splitMain = New System.Windows.Forms.SplitContainer()
        Me.grpCatalog = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.dgvCatalog = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.pnlCatalogSearch = New Guna.UI2.WinForms.Guna2Panel()
        Me.btnSearchItemPOS = New Guna.UI2.WinForms.Guna2Button()
        Me.txtSearchItemPOS = New Guna.UI2.WinForms.Guna2TextBox()
        Me.pnlCheckout = New Guna.UI2.WinForms.Guna2Panel()
        Me.grpCheckout = New Guna.UI2.WinForms.Guna2GroupBox()
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
        Me.lblTitle.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Bold)
        Me.lblTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblTitle.Location = New System.Drawing.Point(0, 0)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Padding = New System.Windows.Forms.Padding(12, 8, 0, 0)
        Me.lblTitle.Size = New System.Drawing.Size(1100, 40)
        Me.lblTitle.TabIndex = 1
        Me.lblTitle.Text = "Sales Point of Sale (POS)"
        '
        'splitMain
        '
        Me.splitMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.splitMain.Location = New System.Drawing.Point(0, 40)
        Me.splitMain.Name = "splitMain"
        '
        'splitMain.Panel1
        '
        Me.splitMain.Panel1.Controls.Add(Me.grpCatalog)
        '
        'splitMain.Panel2
        '
        Me.splitMain.Panel2.Controls.Add(Me.pnlCheckout)
        Me.splitMain.Size = New System.Drawing.Size(1100, 580)
        Me.splitMain.SplitterDistance = 480
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
        Me.grpCatalog.Name = "grpCatalog"
        Me.grpCatalog.Size = New System.Drawing.Size(480, 580)
        Me.grpCatalog.TabIndex = 0
        Me.grpCatalog.Text = "Product Catalog"
        '
        'dgvCatalog
        '
        Me.dgvCatalog.AllowUserToAddRows = False
        DataGridViewCellStyle10.BackColor = System.Drawing.Color.White
        Me.dgvCatalog.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle10
        DataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold)
        Me.dgvCatalog.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle11
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle12.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvCatalog.DefaultCellStyle = DataGridViewCellStyle12
        Me.dgvCatalog.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvCatalog.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvCatalog.Location = New System.Drawing.Point(0, 92)
        Me.dgvCatalog.Name = "dgvCatalog"
        Me.dgvCatalog.ReadOnly = True
        Me.dgvCatalog.RowHeadersVisible = False
        Me.dgvCatalog.Size = New System.Drawing.Size(480, 488)
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
        Me.pnlCatalogSearch.Name = "pnlCatalogSearch"
        Me.pnlCatalogSearch.Size = New System.Drawing.Size(480, 52)
        Me.pnlCatalogSearch.TabIndex = 1
        '
        'btnSearchItemPOS
        '
        Me.btnSearchItemPOS.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnSearchItemPOS.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnSearchItemPOS.ForeColor = System.Drawing.Color.White
        Me.btnSearchItemPOS.Location = New System.Drawing.Point(320, 10)
        Me.btnSearchItemPOS.Name = "btnSearchItemPOS"
        Me.btnSearchItemPOS.Size = New System.Drawing.Size(100, 32)
        Me.btnSearchItemPOS.TabIndex = 0
        Me.btnSearchItemPOS.Text = "Search"
        '
        'txtSearchItemPOS
        '
        Me.txtSearchItemPOS.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSearchItemPOS.DefaultText = ""
        Me.txtSearchItemPOS.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtSearchItemPOS.Location = New System.Drawing.Point(12, 10)
        Me.txtSearchItemPOS.Name = "txtSearchItemPOS"
        Me.txtSearchItemPOS.PlaceholderText = "Search code, brand, size..."
        Me.txtSearchItemPOS.SelectedText = ""
        Me.txtSearchItemPOS.Size = New System.Drawing.Size(300, 32)
        Me.txtSearchItemPOS.TabIndex = 1
        '
        'pnlCheckout
        '
        Me.pnlCheckout.Controls.Add(Me.grpCheckout)
        Me.pnlCheckout.Controls.Add(Me.grpCart)
        Me.pnlCheckout.Controls.Add(Me.grpCustomer)
        Me.pnlCheckout.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlCheckout.Location = New System.Drawing.Point(0, 0)
        Me.pnlCheckout.Name = "pnlCheckout"
        Me.pnlCheckout.Size = New System.Drawing.Size(616, 580)
        Me.pnlCheckout.TabIndex = 0
        '
        'grpCheckout
        '
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
        Me.grpCheckout.Location = New System.Drawing.Point(0, 400)
        Me.grpCheckout.Name = "grpCheckout"
        Me.grpCheckout.Size = New System.Drawing.Size(616, 180)
        Me.grpCheckout.TabIndex = 0
        Me.grpCheckout.Text = "Payment Summary"
        '
        'lblSubtotal
        '
        Me.lblSubtotal.BackColor = System.Drawing.Color.Transparent
        Me.lblSubtotal.ForeColor = System.Drawing.Color.White
        Me.lblSubtotal.Location = New System.Drawing.Point(16, 48)
        Me.lblSubtotal.Name = "lblSubtotal"
        Me.lblSubtotal.Size = New System.Drawing.Size(67, 15)
        Me.lblSubtotal.TabIndex = 0
        Me.lblSubtotal.Text = "Subtotal (Rs.)"
        '
        'txtSubtotal
        '
        Me.txtSubtotal.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSubtotal.DefaultText = ""
        Me.txtSubtotal.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtSubtotal.Location = New System.Drawing.Point(140, 44)
        Me.txtSubtotal.Name = "txtSubtotal"
        Me.txtSubtotal.PlaceholderText = ""
        Me.txtSubtotal.ReadOnly = True
        Me.txtSubtotal.SelectedText = ""
        Me.txtSubtotal.Size = New System.Drawing.Size(140, 32)
        Me.txtSubtotal.TabIndex = 1
        '
        'lblDiscount
        '
        Me.lblDiscount.BackColor = System.Drawing.Color.Transparent
        Me.lblDiscount.ForeColor = System.Drawing.Color.White
        Me.lblDiscount.Location = New System.Drawing.Point(300, 48)
        Me.lblDiscount.Name = "lblDiscount"
        Me.lblDiscount.Size = New System.Drawing.Size(70, 15)
        Me.lblDiscount.TabIndex = 2
        Me.lblDiscount.Text = "Discount (Rs.)"
        '
        'txtDiscount
        '
        Me.txtDiscount.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtDiscount.DefaultText = ""
        Me.txtDiscount.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtDiscount.Location = New System.Drawing.Point(420, 44)
        Me.txtDiscount.Name = "txtDiscount"
        Me.txtDiscount.PlaceholderText = ""
        Me.txtDiscount.SelectedText = ""
        Me.txtDiscount.Size = New System.Drawing.Size(100, 32)
        Me.txtDiscount.TabIndex = 3
        '
        'lblTotal
        '
        Me.lblTotal.BackColor = System.Drawing.Color.Transparent
        Me.lblTotal.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblTotal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblTotal.Location = New System.Drawing.Point(16, 96)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(89, 23)
        Me.lblTotal.TabIndex = 4
        Me.lblTotal.Text = "TOTAL (Rs.)"
        '
        'txtTotal
        '
        Me.txtTotal.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtTotal.DefaultText = ""
        Me.txtTotal.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txtTotal.Location = New System.Drawing.Point(200, 129)
        Me.txtTotal.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.PlaceholderText = ""
        Me.txtTotal.ReadOnly = True
        Me.txtTotal.SelectedText = ""
        Me.txtTotal.Size = New System.Drawing.Size(200, 36)
        Me.txtTotal.TabIndex = 5
        '
        'btnCompleteSale
        '
        Me.btnCompleteSale.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnCompleteSale.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnCompleteSale.ForeColor = System.Drawing.Color.White
        Me.btnCompleteSale.Location = New System.Drawing.Point(380, 88)
        Me.btnCompleteSale.Name = "btnCompleteSale"
        Me.btnCompleteSale.Size = New System.Drawing.Size(200, 44)
        Me.btnCompleteSale.TabIndex = 6
        Me.btnCompleteSale.Text = "Complete Sale"
        '
        'btnClearCart
        '
        Me.btnClearCart.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnClearCart.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnClearCart.ForeColor = System.Drawing.Color.White
        Me.btnClearCart.Location = New System.Drawing.Point(380, 40)
        Me.btnClearCart.Name = "btnClearCart"
        Me.btnClearCart.Size = New System.Drawing.Size(200, 40)
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
        Me.grpCart.Location = New System.Drawing.Point(0, 100)
        Me.grpCart.Name = "grpCart"
        Me.grpCart.Size = New System.Drawing.Size(616, 480)
        Me.grpCart.TabIndex = 1
        Me.grpCart.Text = "Shopping Cart"
        '
        'dgvCart
        '
        Me.dgvCart.AllowUserToAddRows = False
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.White
        Me.dgvCart.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle7
        Me.dgvCart.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvCart.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle8
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        DataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvCart.DefaultCellStyle = DataGridViewCellStyle9
        Me.dgvCart.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvCart.Location = New System.Drawing.Point(12, 72)
        Me.dgvCart.Name = "dgvCart"
        Me.dgvCart.RowHeadersVisible = False
        Me.dgvCart.Size = New System.Drawing.Size(896, 540)
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
        Me.btnAddToCart.Location = New System.Drawing.Point(130, 36)
        Me.btnAddToCart.Name = "btnAddToCart"
        Me.btnAddToCart.Size = New System.Drawing.Size(120, 32)
        Me.btnAddToCart.TabIndex = 1
        Me.btnAddToCart.Text = "Add to Cart"
        '
        'btnRemoveLine
        '
        Me.btnRemoveLine.FillColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.btnRemoveLine.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnRemoveLine.ForeColor = System.Drawing.Color.White
        Me.btnRemoveLine.Location = New System.Drawing.Point(260, 36)
        Me.btnRemoveLine.Name = "btnRemoveLine"
        Me.btnRemoveLine.Size = New System.Drawing.Size(120, 32)
        Me.btnRemoveLine.TabIndex = 2
        Me.btnRemoveLine.Text = "Remove Line"
        '
        'numQtyPOS
        '
        Me.numQtyPOS.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.numQtyPOS.DefaultText = "1"
        Me.numQtyPOS.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.numQtyPOS.Location = New System.Drawing.Point(56, 36)
        Me.numQtyPOS.Name = "numQtyPOS"
        Me.numQtyPOS.PlaceholderText = ""
        Me.numQtyPOS.SelectedText = ""
        Me.numQtyPOS.Size = New System.Drawing.Size(60, 32)
        Me.numQtyPOS.TabIndex = 3
        '
        'lblQtyPOS
        '
        Me.lblQtyPOS.AutoSize = False
        Me.lblQtyPOS.BackColor = System.Drawing.Color.Transparent
        Me.lblQtyPOS.ForeColor = System.Drawing.Color.Black
        Me.lblQtyPOS.Location = New System.Drawing.Point(12, 40)
        Me.lblQtyPOS.Name = "lblQtyPOS"
        Me.lblQtyPOS.Size = New System.Drawing.Size(22, 17)
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
        Me.grpCustomer.Name = "grpCustomer"
        Me.grpCustomer.Size = New System.Drawing.Size(616, 100)
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
        Me.cmbPayment.Location = New System.Drawing.Point(480, 36)
        Me.cmbPayment.Name = "cmbPayment"
        Me.cmbPayment.Size = New System.Drawing.Size(120, 36)
        Me.cmbPayment.TabIndex = 0
        '
        'lblPayment
        '
        Me.lblPayment.AutoSize = False
        Me.lblPayment.BackColor = System.Drawing.Color.Transparent
        Me.lblPayment.ForeColor = System.Drawing.Color.Black
        Me.lblPayment.Location = New System.Drawing.Point(400, 40)
        Me.lblPayment.Name = "lblPayment"
        Me.lblPayment.Size = New System.Drawing.Size(50, 17)
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
        Me.cmbCustomerPOS.Location = New System.Drawing.Point(100, 36)
        Me.cmbCustomerPOS.Name = "cmbCustomerPOS"
        Me.cmbCustomerPOS.Size = New System.Drawing.Size(280, 36)
        Me.cmbCustomerPOS.TabIndex = 2
        '
        'lblCustomerPOS
        '
        Me.lblCustomerPOS.AutoSize = False
        Me.lblCustomerPOS.BackColor = System.Drawing.Color.Transparent
        Me.lblCustomerPOS.ForeColor = System.Drawing.Color.Black
        Me.lblCustomerPOS.Location = New System.Drawing.Point(16, 40)
        Me.lblCustomerPOS.Name = "lblCustomerPOS"
        Me.lblCustomerPOS.Size = New System.Drawing.Size(55, 17)
        Me.lblCustomerPOS.TabIndex = 3
        Me.lblCustomerPOS.Text = "Customer"
        '
        'SalesPOS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1100, 620)
        Me.Controls.Add(Me.splitMain)
        Me.Controls.Add(Me.lblTitle)
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
        Me.grpCheckout.PerformLayout()
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
End Class
