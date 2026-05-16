<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Dashboard
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
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Me.lblTitle = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.pnlStats = New Guna.UI2.WinForms.Guna2Panel()
        Me.cardLowStock = New Guna.UI2.WinForms.Guna2Panel()
        Me.lblLowStockVal = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.lblLowStockCap = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.cardTodaySales = New Guna.UI2.WinForms.Guna2Panel()
        Me.lblTodaySalesVal = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.lblTodaySalesCap = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.cardProducts = New Guna.UI2.WinForms.Guna2Panel()
        Me.lblProductsVal = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.lblProductsCap = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.cardCustomers = New Guna.UI2.WinForms.Guna2Panel()
        Me.lblCustomersVal = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.lblCustomersCap = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.grpLowStock = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.dgvLowStock = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.btnRefreshDashboard = New Guna.UI2.WinForms.Guna2Button()
        Me.grpQuickActions = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.btnQuickPOS = New Guna.UI2.WinForms.Guna2Button()
        Me.btnQuickProducts = New Guna.UI2.WinForms.Guna2Button()
        Me.btnQuickReports = New Guna.UI2.WinForms.Guna2Button()
        Me.pnlStats.SuspendLayout()
        Me.cardLowStock.SuspendLayout()
        Me.cardTodaySales.SuspendLayout()
        Me.cardProducts.SuspendLayout()
        Me.cardCustomers.SuspendLayout()
        Me.grpLowStock.SuspendLayout()
        CType(Me.dgvLowStock, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpQuickActions.SuspendLayout()
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
        Me.lblTitle.Size = New System.Drawing.Size(1100, 48)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Dashboard Overview"
        '
        'pnlStats
        '
        Me.pnlStats.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlStats.Controls.Add(Me.cardLowStock)
        Me.pnlStats.Controls.Add(Me.cardTodaySales)
        Me.pnlStats.Controls.Add(Me.cardProducts)
        Me.pnlStats.Controls.Add(Me.cardCustomers)
        Me.pnlStats.FillColor = System.Drawing.Color.Transparent
        Me.pnlStats.Location = New System.Drawing.Point(12, 56)
        Me.pnlStats.Name = "pnlStats"
        Me.pnlStats.Size = New System.Drawing.Size(1076, 110)
        Me.pnlStats.TabIndex = 1
        '
        'cardLowStock
        '
        Me.cardLowStock.BorderRadius = 12
        Me.cardLowStock.Controls.Add(Me.lblLowStockVal)
        Me.cardLowStock.Controls.Add(Me.lblLowStockCap)
        Me.cardLowStock.FillColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.cardLowStock.Location = New System.Drawing.Point(810, 8)
        Me.cardLowStock.Name = "cardLowStock"
        Me.cardLowStock.Size = New System.Drawing.Size(250, 94)
        Me.cardLowStock.TabIndex = 3
        '
        'lblLowStockVal
        '
        Me.lblLowStockVal.BackColor = System.Drawing.Color.Transparent
        Me.lblLowStockVal.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Bold)
        Me.lblLowStockVal.ForeColor = System.Drawing.Color.White
        Me.lblLowStockVal.Location = New System.Drawing.Point(16, 12)
        Me.lblLowStockVal.Name = "lblLowStockVal"
        Me.lblLowStockVal.Size = New System.Drawing.Size(80, 40)
        Me.lblLowStockVal.TabIndex = 0
        Me.lblLowStockVal.Text = "0"
        '
        'lblLowStockCap
        '
        Me.lblLowStockCap.BackColor = System.Drawing.Color.Transparent
        Me.lblLowStockCap.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblLowStockCap.ForeColor = System.Drawing.Color.White
        Me.lblLowStockCap.Location = New System.Drawing.Point(16, 52)
        Me.lblLowStockCap.Name = "lblLowStockCap"
        Me.lblLowStockCap.Size = New System.Drawing.Size(220, 32)
        Me.lblLowStockCap.TabIndex = 1
        Me.lblLowStockCap.Text = "Low Stock Items"
        '
        'cardTodaySales
        '
        Me.cardTodaySales.BorderRadius = 12
        Me.cardTodaySales.Controls.Add(Me.lblTodaySalesVal)
        Me.cardTodaySales.Controls.Add(Me.lblTodaySalesCap)
        Me.cardTodaySales.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cardTodaySales.Location = New System.Drawing.Point(544, 8)
        Me.cardTodaySales.Name = "cardTodaySales"
        Me.cardTodaySales.Size = New System.Drawing.Size(250, 94)
        Me.cardTodaySales.TabIndex = 2
        '
        'lblTodaySalesVal
        '
        Me.lblTodaySalesVal.BackColor = System.Drawing.Color.Transparent
        Me.lblTodaySalesVal.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Bold)
        Me.lblTodaySalesVal.ForeColor = System.Drawing.Color.White
        Me.lblTodaySalesVal.Location = New System.Drawing.Point(16, 12)
        Me.lblTodaySalesVal.Name = "lblTodaySalesVal"
        Me.lblTodaySalesVal.Size = New System.Drawing.Size(220, 40)
        Me.lblTodaySalesVal.TabIndex = 0
        Me.lblTodaySalesVal.Text = "Rs. 0.00"
        '
        'lblTodaySalesCap
        '
        Me.lblTodaySalesCap.BackColor = System.Drawing.Color.Transparent
        Me.lblTodaySalesCap.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblTodaySalesCap.ForeColor = System.Drawing.Color.White
        Me.lblTodaySalesCap.Location = New System.Drawing.Point(16, 52)
        Me.lblTodaySalesCap.Name = "lblTodaySalesCap"
        Me.lblTodaySalesCap.Size = New System.Drawing.Size(220, 32)
        Me.lblTodaySalesCap.TabIndex = 1
        Me.lblTodaySalesCap.Text = "Today's Sales"
        '
        'cardProducts
        '
        Me.cardProducts.BorderRadius = 12
        Me.cardProducts.Controls.Add(Me.lblProductsVal)
        Me.cardProducts.Controls.Add(Me.lblProductsCap)
        Me.cardProducts.FillColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.cardProducts.Location = New System.Drawing.Point(278, 8)
        Me.cardProducts.Name = "cardProducts"
        Me.cardProducts.Size = New System.Drawing.Size(250, 94)
        Me.cardProducts.TabIndex = 1
        '
        'lblProductsVal
        '
        Me.lblProductsVal.BackColor = System.Drawing.Color.Transparent
        Me.lblProductsVal.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Bold)
        Me.lblProductsVal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblProductsVal.Location = New System.Drawing.Point(16, 12)
        Me.lblProductsVal.Name = "lblProductsVal"
        Me.lblProductsVal.Size = New System.Drawing.Size(80, 40)
        Me.lblProductsVal.TabIndex = 0
        Me.lblProductsVal.Text = "0"
        '
        'lblProductsCap
        '
        Me.lblProductsCap.BackColor = System.Drawing.Color.Transparent
        Me.lblProductsCap.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblProductsCap.ForeColor = System.Drawing.Color.White
        Me.lblProductsCap.Location = New System.Drawing.Point(16, 52)
        Me.lblProductsCap.Name = "lblProductsCap"
        Me.lblProductsCap.Size = New System.Drawing.Size(220, 32)
        Me.lblProductsCap.TabIndex = 1
        Me.lblProductsCap.Text = "Active Products"
        '
        'cardCustomers
        '
        Me.cardCustomers.BorderRadius = 12
        Me.cardCustomers.Controls.Add(Me.lblCustomersVal)
        Me.cardCustomers.Controls.Add(Me.lblCustomersCap)
        Me.cardCustomers.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cardCustomers.Location = New System.Drawing.Point(12, 8)
        Me.cardCustomers.Name = "cardCustomers"
        Me.cardCustomers.Size = New System.Drawing.Size(250, 94)
        Me.cardCustomers.TabIndex = 0
        '
        'lblCustomersVal
        '
        Me.lblCustomersVal.BackColor = System.Drawing.Color.Transparent
        Me.lblCustomersVal.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Bold)
        Me.lblCustomersVal.ForeColor = System.Drawing.Color.Black
        Me.lblCustomersVal.Location = New System.Drawing.Point(16, 12)
        Me.lblCustomersVal.Name = "lblCustomersVal"
        Me.lblCustomersVal.Size = New System.Drawing.Size(80, 40)
        Me.lblCustomersVal.TabIndex = 0
        Me.lblCustomersVal.Text = "0"
        '
        'lblCustomersCap
        '
        Me.lblCustomersCap.BackColor = System.Drawing.Color.Transparent
        Me.lblCustomersCap.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblCustomersCap.ForeColor = System.Drawing.Color.Black
        Me.lblCustomersCap.Location = New System.Drawing.Point(16, 52)
        Me.lblCustomersCap.Name = "lblCustomersCap"
        Me.lblCustomersCap.Size = New System.Drawing.Size(220, 32)
        Me.lblCustomersCap.TabIndex = 1
        Me.lblCustomersCap.Text = "Registered Customers"
        '
        'grpLowStock
        '
        Me.grpLowStock.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpLowStock.Controls.Add(Me.dgvLowStock)
        Me.grpLowStock.Controls.Add(Me.btnRefreshDashboard)
        Me.grpLowStock.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.grpLowStock.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold)
        Me.grpLowStock.Location = New System.Drawing.Point(12, 180)
        Me.grpLowStock.Name = "grpLowStock"
        Me.grpLowStock.Size = New System.Drawing.Size(700, 420)
        Me.grpLowStock.TabIndex = 2
        Me.grpLowStock.Text = "Low Stock Alert"
        '
        'dgvLowStock
        '
        Me.dgvLowStock.AllowUserToAddRows = False
        Me.dgvLowStock.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.dgvLowStock.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvLowStock.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, FontStyle.Bold)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        Me.dgvLowStock.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvLowStock.ColumnHeadersHeight = 32
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.dgvLowStock.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvLowStock.Location = New System.Drawing.Point(16, 72)
        Me.dgvLowStock.Name = "dgvLowStock"
        Me.dgvLowStock.ReadOnly = True
        Me.dgvLowStock.RowHeadersVisible = False
        Me.dgvLowStock.Size = New System.Drawing.Size(668, 332)
        Me.dgvLowStock.TabIndex = 1
        '
        'btnRefreshDashboard
        '
        Me.btnRefreshDashboard.BorderRadius = 10
        Me.btnRefreshDashboard.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnRefreshDashboard.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, FontStyle.Bold)
        Me.btnRefreshDashboard.ForeColor = System.Drawing.Color.White
        Me.btnRefreshDashboard.Location = New System.Drawing.Point(16, 32)
        Me.btnRefreshDashboard.Name = "btnRefreshDashboard"
        Me.btnRefreshDashboard.Size = New System.Drawing.Size(140, 36)
        Me.btnRefreshDashboard.TabIndex = 0
        Me.btnRefreshDashboard.Text = "Refresh"
        '
        'grpQuickActions
        '
        Me.grpQuickActions.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpQuickActions.Controls.Add(Me.btnQuickReports)
        Me.grpQuickActions.Controls.Add(Me.btnQuickProducts)
        Me.grpQuickActions.Controls.Add(Me.btnQuickPOS)
        Me.grpQuickActions.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.grpQuickActions.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, FontStyle.Bold)
        Me.grpQuickActions.Location = New System.Drawing.Point(728, 180)
        Me.grpQuickActions.Name = "grpQuickActions"
        Me.grpQuickActions.Size = New System.Drawing.Size(360, 420)
        Me.grpQuickActions.TabIndex = 3
        Me.grpQuickActions.Text = "Quick Actions"
        '
        'btnQuickPOS
        '
        Me.btnQuickPOS.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnQuickPOS.BorderRadius = 12
        Me.btnQuickPOS.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnQuickPOS.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, FontStyle.Bold)
        Me.btnQuickPOS.ForeColor = System.Drawing.Color.White
        Me.btnQuickPOS.Location = New System.Drawing.Point(24, 48)
        Me.btnQuickPOS.Name = "btnQuickPOS"
        Me.btnQuickPOS.Size = New System.Drawing.Size(312, 48)
        Me.btnQuickPOS.TabIndex = 0
        Me.btnQuickPOS.Text = "Open Sales (POS)"
        '
        'btnQuickProducts
        '
        Me.btnQuickProducts.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnQuickProducts.BorderRadius = 12
        Me.btnQuickProducts.FillColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.btnQuickProducts.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, FontStyle.Bold)
        Me.btnQuickProducts.ForeColor = System.Drawing.Color.White
        Me.btnQuickProducts.Location = New System.Drawing.Point(24, 112)
        Me.btnQuickProducts.Name = "btnQuickProducts"
        Me.btnQuickProducts.Size = New System.Drawing.Size(312, 48)
        Me.btnQuickProducts.TabIndex = 1
        Me.btnQuickProducts.Text = "Manage Products"
        '
        'btnQuickReports
        '
        Me.btnQuickReports.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnQuickReports.BorderRadius = 12
        Me.btnQuickReports.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnQuickReports.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, FontStyle.Bold)
        Me.btnQuickReports.ForeColor = System.Drawing.Color.Black
        Me.btnQuickReports.Location = New System.Drawing.Point(24, 176)
        Me.btnQuickReports.Name = "btnQuickReports"
        Me.btnQuickReports.Size = New System.Drawing.Size(312, 48)
        Me.btnQuickReports.TabIndex = 2
        Me.btnQuickReports.Text = "View Reports"
        '
        'Dashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1100, 620)
        Me.Controls.Add(Me.grpQuickActions)
        Me.Controls.Add(Me.grpLowStock)
        Me.Controls.Add(Me.pnlStats)
        Me.Controls.Add(Me.lblTitle)
        Me.Name = "Dashboard"
        Me.Text = "Dashboard"
        Me.pnlStats.ResumeLayout(False)
        Me.cardLowStock.ResumeLayout(False)
        Me.cardTodaySales.ResumeLayout(False)
        Me.cardProducts.ResumeLayout(False)
        Me.cardCustomers.ResumeLayout(False)
        Me.grpLowStock.ResumeLayout(False)
        CType(Me.dgvLowStock, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpQuickActions.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblTitle As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents pnlStats As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents cardCustomers As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents lblCustomersVal As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lblCustomersCap As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents cardProducts As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents lblProductsVal As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lblProductsCap As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents cardTodaySales As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents lblTodaySalesVal As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lblTodaySalesCap As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents cardLowStock As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents lblLowStockVal As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lblLowStockCap As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents grpLowStock As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents dgvLowStock As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents btnRefreshDashboard As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents grpQuickActions As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents btnQuickPOS As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnQuickProducts As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnQuickReports As Guna.UI2.WinForms.Guna2Button
End Class
