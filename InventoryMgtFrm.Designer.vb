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
        Dim cs2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Me.lblTitle = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.grpAdjust = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.cmbReason = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.lblReason = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.lblAdjQty = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.txtAdjQty = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtAdjRemarks = New Guna.UI2.WinForms.Guna2TextBox()
        Me.lblRemarks = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.lblSelectedItem = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.btnApplyAdjustment = New Guna.UI2.WinForms.Guna2Button()
        Me.chkLowStockOnly = New Guna.UI2.WinForms.Guna2CheckBox()
        Me.grpStock = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.dgvStock = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.txtSearchStock = New Guna.UI2.WinForms.Guna2TextBox()
        Me.btnSearchStock = New Guna.UI2.WinForms.Guna2Button()
        Me.btnRefreshStock = New Guna.UI2.WinForms.Guna2Button()
        Me.grpAdjust.SuspendLayout()
        Me.grpStock.SuspendLayout()
        CType(Me.dgvStock, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        Me.lblTitle.Dock = DockStyle.Top
        Me.lblTitle.Font = New Font("Segoe UI", 16.0!, FontStyle.Bold)
        Me.lblTitle.ForeColor = Color.FromArgb(255, 128, 0)
        Me.lblTitle.Padding = New Padding(12, 8, 0, 0)
        Me.lblTitle.Size = New Size(1100, 44)
        Me.lblTitle.Text = "Inventory Management"
        '
        Me.grpAdjust.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        Me.grpAdjust.Controls.Add(Me.btnApplyAdjustment)
        Me.grpAdjust.Controls.Add(Me.lblSelectedItem)
        Me.grpAdjust.Controls.Add(Me.txtAdjRemarks)
        Me.grpAdjust.Controls.Add(Me.lblRemarks)
        Me.grpAdjust.Controls.Add(Me.txtAdjQty)
        Me.grpAdjust.Controls.Add(Me.lblAdjQty)
        Me.grpAdjust.Controls.Add(Me.cmbReason)
        Me.grpAdjust.Controls.Add(Me.lblReason)
        Me.grpAdjust.FillColor = Color.FromArgb(255, 224, 192)
        Me.grpAdjust.Font = New Font("Segoe UI Semibold", 10.0!, FontStyle.Bold)
        Me.grpAdjust.Location = New Point(12, 52)
        Me.grpAdjust.Size = New Size(1076, 120)
        Me.grpAdjust.Text = "Stock Adjustment"
        '
        Me.lblReason.Location = New Point(16, 48) : Me.lblReason.Text = "Reason" : Me.lblReason.Size = New Size(70, 22)
        Me.cmbReason.DropDownStyle = ComboBoxStyle.DropDownList
        Me.cmbReason.Location = New Point(90, 44) : Me.cmbReason.Size = New Size(140, 36)
        Me.lblAdjQty.Location = New Point(250, 48) : Me.lblAdjQty.Text = "Qty (+/-)" : Me.lblAdjQty.Size = New Size(70, 22)
        Me.txtAdjQty.Location = New Point(330, 44) : Me.txtAdjQty.Size = New Size(80, 32)
        Me.lblRemarks.Location = New Point(430, 48) : Me.lblRemarks.Text = "Remarks" : Me.lblRemarks.Size = New Size(70, 22)
        Me.txtAdjRemarks.Location = New Point(500, 44) : Me.txtAdjRemarks.Size = New Size(280, 32)
        Me.lblSelectedItem.Location = New Point(16, 88) : Me.lblSelectedItem.Text = "Selected: (click a row below)" : Me.lblSelectedItem.Size = New Size(500, 22)
        Me.btnApplyAdjustment.Location = New Point(900, 44) : Me.btnApplyAdjustment.Size = New Size(150, 40)
        Me.btnApplyAdjustment.Text = "Apply Adjustment"
        Me.btnApplyAdjustment.FillColor = Color.FromArgb(255, 128, 0) : Me.btnApplyAdjustment.ForeColor = Color.White
        '
        Me.grpStock.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Me.grpStock.Controls.Add(Me.dgvStock)
        Me.grpStock.Controls.Add(Me.chkLowStockOnly)
        Me.grpStock.Controls.Add(Me.btnRefreshStock)
        Me.grpStock.Controls.Add(Me.btnSearchStock)
        Me.grpStock.Controls.Add(Me.txtSearchStock)
        Me.grpStock.FillColor = Color.FromArgb(255, 224, 192)
        Me.grpStock.Font = New Font("Segoe UI Semibold", 10.0!, FontStyle.Bold)
        Me.grpStock.Location = New Point(12, 184)
        Me.grpStock.Size = New Size(1076, 420)
        Me.grpStock.Text = "Current Stock Levels"
        '
        Me.txtSearchStock.Location = New Point(16, 48) : Me.txtSearchStock.PlaceholderText = "Search stock..." : Me.txtSearchStock.Size = New Size(360, 36)
        Me.btnSearchStock.Location = New Point(390, 48) : Me.btnSearchStock.Size = New Size(100, 36) : Me.btnSearchStock.Text = "Search"
        Me.btnSearchStock.FillColor = Color.FromArgb(255, 128, 0) : Me.btnSearchStock.ForeColor = Color.White
        Me.btnRefreshStock.Location = New Point(500, 48) : Me.btnRefreshStock.Size = New Size(100, 36) : Me.btnRefreshStock.Text = "Refresh"
        Me.btnRefreshStock.FillColor = Color.FromArgb(30, 30, 30) : Me.btnRefreshStock.ForeColor = Color.White
        Me.chkLowStockOnly.Location = New Point(620, 52) : Me.chkLowStockOnly.Text = "Show low stock only"
        Me.dgvStock.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Me.dgvStock.Location = New Point(16, 96)
        Me.dgvStock.Size = New Size(1044, 308)
        Me.dgvStock.ReadOnly = True
        Me.dgvStock.AllowUserToAddRows = False
        cs2.BackColor = Color.FromArgb(255, 192, 128)
        Me.dgvStock.ColumnHeadersDefaultCellStyle = cs2
        '
        Me.AutoScaleMode = AutoScaleMode.Font
        Me.BackColor = Color.FromArgb(248, 249, 250)
        Me.ClientSize = New Size(1100, 620)
        Me.Controls.Add(Me.grpStock)
        Me.Controls.Add(Me.grpAdjust)
        Me.Controls.Add(Me.lblTitle)
        Me.grpAdjust.ResumeLayout(False)
        Me.grpStock.ResumeLayout(False)
        CType(Me.dgvStock, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
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
