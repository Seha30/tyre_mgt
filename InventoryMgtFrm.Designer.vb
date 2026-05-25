<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class InventoryMgtFrm
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
        Me.lblTitle = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.grpAdjust = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.btnApplyAdjustment = New Guna.UI2.WinForms.Guna2Button()
        Me.lblSelectedItem = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.txtAdjRemarks = New Guna.UI2.WinForms.Guna2TextBox()
        Me.lblRemarks = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.txtAdjQty = New Guna.UI2.WinForms.Guna2TextBox()
        Me.lblAdjQty = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.cmbReason = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.lblReason = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.chkLowStockOnly = New Guna.UI2.WinForms.Guna2CheckBox()
        Me.grpStock = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.dgvStock = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.btnRefreshStock = New Guna.UI2.WinForms.Guna2Button()
        Me.btnSearchStock = New Guna.UI2.WinForms.Guna2Button()
        Me.txtSearchStock = New Guna.UI2.WinForms.Guna2TextBox()
        Me.grpAdjust.SuspendLayout()
        Me.grpStock.SuspendLayout()
        CType(Me.dgvStock, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.lblTitle.Text = "Inventory Management"
        '
        'grpAdjust
        '
        Me.grpAdjust.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpAdjust.Controls.Add(Me.btnApplyAdjustment)
        Me.grpAdjust.Controls.Add(Me.lblSelectedItem)
        Me.grpAdjust.Controls.Add(Me.txtAdjRemarks)
        Me.grpAdjust.Controls.Add(Me.lblRemarks)
        Me.grpAdjust.Controls.Add(Me.txtAdjQty)
        Me.grpAdjust.Controls.Add(Me.lblAdjQty)
        Me.grpAdjust.Controls.Add(Me.cmbReason)
        Me.grpAdjust.Controls.Add(Me.lblReason)
        Me.grpAdjust.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.grpAdjust.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold)
        Me.grpAdjust.ForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.grpAdjust.Location = New System.Drawing.Point(12, 52)
        Me.grpAdjust.Name = "grpAdjust"
        Me.grpAdjust.Size = New System.Drawing.Size(1076, 120)
        Me.grpAdjust.TabIndex = 1
        Me.grpAdjust.Text = "Stock Adjustment"
        '
        'btnApplyAdjustment
        '
        Me.btnApplyAdjustment.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnApplyAdjustment.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnApplyAdjustment.ForeColor = System.Drawing.Color.White
        Me.btnApplyAdjustment.Location = New System.Drawing.Point(900, 44)
        Me.btnApplyAdjustment.Name = "btnApplyAdjustment"
        Me.btnApplyAdjustment.Size = New System.Drawing.Size(150, 40)
        Me.btnApplyAdjustment.TabIndex = 0
        Me.btnApplyAdjustment.Text = "Apply Adjustment"
        '
        'lblSelectedItem
        '
        Me.lblSelectedItem.AutoSize = False
        Me.lblSelectedItem.BackColor = System.Drawing.Color.Transparent
        Me.lblSelectedItem.Location = New System.Drawing.Point(16, 88)
        Me.lblSelectedItem.Name = "lblSelectedItem"
        Me.lblSelectedItem.Size = New System.Drawing.Size(418, 29)
        Me.lblSelectedItem.TabIndex = 1
        Me.lblSelectedItem.Text = "Selected: (click a row below)"
        '
        'txtAdjRemarks
        '
        Me.txtAdjRemarks.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtAdjRemarks.DefaultText = ""
        Me.txtAdjRemarks.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtAdjRemarks.Location = New System.Drawing.Point(588, 44)
        Me.txtAdjRemarks.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtAdjRemarks.Name = "txtAdjRemarks"
        Me.txtAdjRemarks.PlaceholderText = ""
        Me.txtAdjRemarks.SelectedText = ""
        Me.txtAdjRemarks.Size = New System.Drawing.Size(280, 32)
        Me.txtAdjRemarks.TabIndex = 2
        '
        'lblRemarks
        '
        Me.lblRemarks.AutoSize = False
        Me.lblRemarks.BackColor = System.Drawing.Color.Transparent
        Me.lblRemarks.ForeColor = System.Drawing.Color.Black
        Me.lblRemarks.Location = New System.Drawing.Point(495, 48)
        Me.lblRemarks.Name = "lblRemarks"
        Me.lblRemarks.Size = New System.Drawing.Size(87, 36)
        Me.lblRemarks.TabIndex = 3
        Me.lblRemarks.Text = "Remarks"
        '
        'txtAdjQty
        '
        Me.txtAdjQty.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtAdjQty.DefaultText = ""
        Me.txtAdjQty.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtAdjQty.Location = New System.Drawing.Point(390, 44)
        Me.txtAdjQty.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtAdjQty.Name = "txtAdjQty"
        Me.txtAdjQty.PlaceholderText = ""
        Me.txtAdjQty.SelectedText = ""
        Me.txtAdjQty.Size = New System.Drawing.Size(80, 32)
        Me.txtAdjQty.TabIndex = 4
        '
        'lblAdjQty
        '
        Me.lblAdjQty.AutoSize = False
        Me.lblAdjQty.BackColor = System.Drawing.Color.Transparent
        Me.lblAdjQty.ForeColor = System.Drawing.Color.Black
        Me.lblAdjQty.Location = New System.Drawing.Point(275, 48)
        Me.lblAdjQty.Name = "lblAdjQty"
        Me.lblAdjQty.Size = New System.Drawing.Size(126, 36)
        Me.lblAdjQty.TabIndex = 5
        Me.lblAdjQty.Text = "Qty (+/-)"
        '
        'cmbReason
        '
        Me.cmbReason.BackColor = System.Drawing.Color.Transparent
        Me.cmbReason.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbReason.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbReason.FocusedColor = System.Drawing.Color.Empty
        Me.cmbReason.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cmbReason.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cmbReason.ItemHeight = 30
        Me.cmbReason.Location = New System.Drawing.Point(90, 44)
        Me.cmbReason.Name = "cmbReason"
        Me.cmbReason.Size = New System.Drawing.Size(140, 36)
        Me.cmbReason.TabIndex = 6
        '
        'lblReason
        '
        Me.lblReason.AutoSize = False
        Me.lblReason.BackColor = System.Drawing.Color.Transparent
        Me.lblReason.ForeColor = System.Drawing.Color.Black
        Me.lblReason.Location = New System.Drawing.Point(3, 48)
        Me.lblReason.Name = "lblReason"
        Me.lblReason.Size = New System.Drawing.Size(81, 28)
        Me.lblReason.TabIndex = 7
        Me.lblReason.Text = "Reason"
        '
        'chkLowStockOnly
        '
        Me.chkLowStockOnly.CheckedState.BorderRadius = 0
        Me.chkLowStockOnly.CheckedState.BorderThickness = 0
        Me.chkLowStockOnly.Location = New System.Drawing.Point(620, 52)
        Me.chkLowStockOnly.Name = "chkLowStockOnly"
        Me.chkLowStockOnly.Size = New System.Drawing.Size(104, 24)
        Me.chkLowStockOnly.TabIndex = 1
        Me.chkLowStockOnly.Text = "Show low stock only"
        Me.chkLowStockOnly.UncheckedState.BorderRadius = 0
        Me.chkLowStockOnly.UncheckedState.BorderThickness = 0
        '
        'grpStock
        '
        Me.grpStock.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpStock.Controls.Add(Me.dgvStock)
        Me.grpStock.Controls.Add(Me.chkLowStockOnly)
        Me.grpStock.Controls.Add(Me.btnRefreshStock)
        Me.grpStock.Controls.Add(Me.btnSearchStock)
        Me.grpStock.Controls.Add(Me.txtSearchStock)
        Me.grpStock.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.grpStock.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold)
        Me.grpStock.ForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.grpStock.Location = New System.Drawing.Point(12, 184)
        Me.grpStock.Name = "grpStock"
        Me.grpStock.Size = New System.Drawing.Size(1076, 420)
        Me.grpStock.TabIndex = 0
        Me.grpStock.Text = "Current Stock Levels"
        '
        'dgvStock
        '
        Me.dgvStock.AllowUserToAddRows = False
        DataGridViewCellStyle13.BackColor = System.Drawing.Color.White
        Me.dgvStock.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle13
        Me.dgvStock.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        DataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        DataGridViewCellStyle14.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold)
        Me.dgvStock.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle14
        Me.dgvStock.ColumnHeadersHeight = 29
        DataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle15.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle15.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle15.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvStock.DefaultCellStyle = DataGridViewCellStyle15
        Me.dgvStock.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvStock.Location = New System.Drawing.Point(16, 96)
        Me.dgvStock.Name = "dgvStock"
        Me.dgvStock.ReadOnly = True
        Me.dgvStock.RowHeadersVisible = False
        Me.dgvStock.RowHeadersWidth = 51
        Me.dgvStock.Size = New System.Drawing.Size(1044, 308)
        Me.dgvStock.TabIndex = 0
        Me.dgvStock.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.dgvStock.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.dgvStock.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.dgvStock.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.dgvStock.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.dgvStock.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.dgvStock.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvStock.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvStock.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvStock.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvStock.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.dgvStock.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvStock.ThemeStyle.HeaderStyle.Height = 29
        Me.dgvStock.ThemeStyle.ReadOnly = True
        Me.dgvStock.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.dgvStock.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvStock.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold)
        Me.dgvStock.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.dgvStock.ThemeStyle.RowsStyle.Height = 22
        Me.dgvStock.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvStock.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'btnRefreshStock
        '
        Me.btnRefreshStock.FillColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.btnRefreshStock.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnRefreshStock.ForeColor = System.Drawing.Color.White
        Me.btnRefreshStock.Location = New System.Drawing.Point(500, 48)
        Me.btnRefreshStock.Name = "btnRefreshStock"
        Me.btnRefreshStock.Size = New System.Drawing.Size(100, 36)
        Me.btnRefreshStock.TabIndex = 2
        Me.btnRefreshStock.Text = "Refresh"
        '
        'btnSearchStock
        '
        Me.btnSearchStock.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnSearchStock.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnSearchStock.ForeColor = System.Drawing.Color.White
        Me.btnSearchStock.Location = New System.Drawing.Point(390, 48)
        Me.btnSearchStock.Name = "btnSearchStock"
        Me.btnSearchStock.Size = New System.Drawing.Size(100, 36)
        Me.btnSearchStock.TabIndex = 3
        Me.btnSearchStock.Text = "Search"
        '
        'txtSearchStock
        '
        Me.txtSearchStock.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSearchStock.DefaultText = ""
        Me.txtSearchStock.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtSearchStock.Location = New System.Drawing.Point(16, 48)
        Me.txtSearchStock.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtSearchStock.Name = "txtSearchStock"
        Me.txtSearchStock.PlaceholderText = "Search stock..."
        Me.txtSearchStock.SelectedText = ""
        Me.txtSearchStock.Size = New System.Drawing.Size(360, 36)
        Me.txtSearchStock.TabIndex = 4
        '
        'InventoryMgtFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1100, 620)
        Me.Controls.Add(Me.grpStock)
        Me.Controls.Add(Me.grpAdjust)
        Me.Controls.Add(Me.lblTitle)
        Me.Name = "InventoryMgtFrm"
        Me.grpAdjust.ResumeLayout(False)
        Me.grpStock.ResumeLayout(False)
        CType(Me.dgvStock, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitle As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents grpAdjust As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents lblReason As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents cmbReason As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents lblAdjQty As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents txtAdjQty As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents lblRemarks As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents txtAdjRemarks As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents lblSelectedItem As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents btnApplyAdjustment As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents grpStock As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents txtSearchStock As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents btnSearchStock As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnRefreshStock As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents chkLowStockOnly As Guna.UI2.WinForms.Guna2CheckBox
    Friend WithEvents dgvStock As Guna.UI2.WinForms.Guna2DataGridView
End Class
