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
        Dim csH As DataGridViewCellStyle = New DataGridViewCellStyle()
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
        Me.lblDiscount = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.lblTotal = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.txtSubtotal = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtDiscount = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtTotal = New Guna.UI2.WinForms.Guna2TextBox()
        Me.btnCompleteSale = New Guna.UI2.WinForms.Guna2Button()
        Me.btnClearCart = New Guna.UI2.WinForms.Guna2Button()
        Me.btnRemoveLine = New Guna.UI2.WinForms.Guna2Button()
        Me.btnAddToCart = New Guna.UI2.WinForms.Guna2Button()
        Me.numQtyPOS = New Guna.UI2.WinForms.Guna2TextBox()
        Me.lblQtyPOS = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.grpCart = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.dgvCart = New Guna.UI2.WinForms.Guna2DataGridView()
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
        Me.lblTitle.Dock = DockStyle.Top
        Me.lblTitle.Font = New Font("Segoe UI", 16.0!, FontStyle.Bold)
        Me.lblTitle.ForeColor = Color.FromArgb(255, 128, 0)
        Me.lblTitle.Padding = New Padding(12, 8, 0, 0)
        Me.lblTitle.Size = New Size(1100, 44)
        Me.lblTitle.Text = "Sales Point of Sale (POS)"
        '
        Me.splitMain.Dock = DockStyle.Fill
        Me.splitMain.Location = New Point(0, 44)
        Me.splitMain.Name = "splitMain"
        '
        Me.splitMain.Panel1.Controls.Add(Me.grpCatalog)
        Me.splitMain.Panel2.Controls.Add(Me.pnlCheckout)
        Me.splitMain.Size = New Size(1100, 576)
        Me.splitMain.SplitterDistance = 480
        '
        Me.grpCatalog.Dock = DockStyle.Fill
        Me.grpCatalog.Controls.Add(Me.dgvCatalog)
        Me.grpCatalog.Controls.Add(Me.pnlCatalogSearch)
        Me.grpCatalog.FillColor = Color.FromArgb(255, 224, 192)
        Me.grpCatalog.Font = New Font("Segoe UI Semibold", 10.0!, FontStyle.Bold)
        Me.grpCatalog.Text = "Product Catalog"
        '
        Me.pnlCatalogSearch.Dock = DockStyle.Top
        Me.pnlCatalogSearch.Controls.Add(Me.btnSearchItemPOS)
        Me.pnlCatalogSearch.Controls.Add(Me.txtSearchItemPOS)
        Me.pnlCatalogSearch.Height = 52
        Me.txtSearchItemPOS.Location = New Point(12, 10)
        Me.txtSearchItemPOS.PlaceholderText = "Search code, brand, size..."
        Me.txtSearchItemPOS.Size = New Size(300, 32)
        Me.btnSearchItemPOS.Location = New Point(320, 10)
        Me.btnSearchItemPOS.Size = New Size(100, 32)
        Me.btnSearchItemPOS.Text = "Search"
        Me.btnSearchItemPOS.FillColor = Color.FromArgb(255, 128, 0)
        Me.btnSearchItemPOS.ForeColor = Color.White
        '
        Me.dgvCatalog.Dock = DockStyle.Fill
        Me.dgvCatalog.ReadOnly = True
        Me.dgvCatalog.AllowUserToAddRows = False
        csH.BackColor = Color.FromArgb(255, 192, 128)
        Me.dgvCatalog.ColumnHeadersDefaultCellStyle = csH
        '
        Me.pnlCheckout.Dock = DockStyle.Fill
        Me.pnlCheckout.Controls.Add(Me.grpCheckout)
        Me.pnlCheckout.Controls.Add(Me.grpCart)
        Me.pnlCheckout.Controls.Add(Me.grpCustomer)
        '
        Me.grpCustomer.Dock = DockStyle.Top
        Me.grpCustomer.Height = 100
        Me.grpCustomer.FillColor = Color.FromArgb(255, 224, 192)
        Me.grpCustomer.Text = "Customer & Payment"
        Me.lblCustomerPOS.Location = New Point(16, 40) : Me.lblCustomerPOS.Text = "Customer" : Me.lblCustomerPOS.Size = New Size(80, 22)
        Me.cmbCustomerPOS.Location = New Point(100, 36) : Me.cmbCustomerPOS.Size = New Size(280, 36)
        Me.lblPayment.Location = New Point(400, 40) : Me.lblPayment.Text = "Payment" : Me.lblPayment.Size = New Size(80, 22)
        Me.cmbPayment.Location = New Point(480, 36) : Me.cmbPayment.Size = New Size(120, 36)
        Me.grpCustomer.Controls.Add(Me.cmbPayment)
        Me.grpCustomer.Controls.Add(Me.lblPayment)
        Me.grpCustomer.Controls.Add(Me.cmbCustomerPOS)
        Me.grpCustomer.Controls.Add(Me.lblCustomerPOS)
        '
        Me.grpCart.Dock = DockStyle.Fill
        Me.grpCart.FillColor = Color.FromArgb(255, 224, 192)
        Me.grpCart.Text = "Shopping Cart"
        Me.grpCart.Controls.Add(Me.dgvCart)
        Me.grpCart.Controls.Add(Me.btnAddToCart)
        Me.grpCart.Controls.Add(Me.btnRemoveLine)
        Me.grpCart.Controls.Add(Me.numQtyPOS)
        Me.grpCart.Controls.Add(Me.lblQtyPOS)
        Me.dgvCart.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Me.dgvCart.Location = New Point(12, 72)
        Me.dgvCart.Size = New Size(580, 260)
        Me.lblQtyPOS.Location = New Point(12, 40) : Me.lblQtyPOS.Text = "Qty" : Me.lblQtyPOS.Size = New Size(40, 22)
        Me.numQtyPOS.Location = New Point(56, 36) : Me.numQtyPOS.Text = "1" : Me.numQtyPOS.Size = New Size(60, 32)
        Me.btnAddToCart.Location = New Point(130, 36) : Me.btnAddToCart.Size = New Size(120, 32) : Me.btnAddToCart.Text = "Add to Cart"
        Me.btnAddToCart.FillColor = Color.FromArgb(255, 128, 0) : Me.btnAddToCart.ForeColor = Color.White
        Me.btnRemoveLine.Location = New Point(260, 36) : Me.btnRemoveLine.Size = New Size(120, 32) : Me.btnRemoveLine.Text = "Remove Line"
        Me.btnRemoveLine.FillColor = Color.FromArgb(220, 53, 69) : Me.btnRemoveLine.ForeColor = Color.White
        Me.dgvCart.AllowUserToAddRows = False
        '
        Me.grpCheckout.Dock = DockStyle.Bottom
        Me.grpCheckout.Height = 180
        Me.grpCheckout.FillColor = Color.FromArgb(30, 30, 30)
        Me.grpCheckout.ForeColor = Color.White
        Me.grpCheckout.Text = "Payment Summary"
        Me.lblSubtotal.Location = New Point(16, 48) : Me.lblSubtotal.Text = "Subtotal (Rs.)" : Me.lblSubtotal.ForeColor = Color.White
        Me.txtSubtotal.Location = New Point(140, 44) : Me.txtSubtotal.ReadOnly = True : Me.txtSubtotal.Size = New Size(140, 32)
        Me.lblDiscount.Location = New Point(300, 48) : Me.lblDiscount.Text = "Discount (Rs.)" : Me.lblDiscount.ForeColor = Color.White
        Me.txtDiscount.Location = New Point(420, 44) : Me.txtDiscount.Size = New Size(100, 32)
        Me.lblTotal.Location = New Point(16, 96) : Me.lblTotal.Text = "TOTAL (Rs.)" : Me.lblTotal.Font = New Font("Segoe UI", 12.0!, FontStyle.Bold) : Me.lblTotal.ForeColor = Color.FromArgb(255, 128, 0)
        Me.txtTotal.Location = New Point(140, 92) : Me.txtTotal.ReadOnly = True : Me.txtTotal.Font = New Font("Segoe UI", 12.0!, FontStyle.Bold) : Me.txtTotal.Size = New Size(200, 36)
        Me.btnCompleteSale.Location = New Point(380, 88) : Me.btnCompleteSale.Size = New Size(200, 44) : Me.btnCompleteSale.Text = "Complete Sale"
        Me.btnCompleteSale.FillColor = Color.FromArgb(255, 128, 0) : Me.btnCompleteSale.ForeColor = Color.White
        Me.btnClearCart.Location = New Point(380, 40) : Me.btnClearCart.Size = New Size(200, 40) : Me.btnClearCart.Text = "Clear Cart"
        Me.btnClearCart.FillColor = Color.FromArgb(255, 192, 128)
        Me.grpCheckout.Controls.AddRange(New Control() {Me.lblSubtotal, Me.txtSubtotal, Me.lblDiscount, Me.txtDiscount, Me.lblTotal, Me.txtTotal, Me.btnCompleteSale, Me.btnClearCart})
        '
        Me.AutoScaleMode = AutoScaleMode.Font
        Me.BackColor = Color.FromArgb(248, 249, 250)
        Me.ClientSize = New Size(1100, 620)
        Me.Controls.Add(Me.splitMain)
        Me.Controls.Add(Me.lblTitle)
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
