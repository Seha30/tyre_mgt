<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ReportsFrm
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.lblTitle = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.grpFilters = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.btnExportReport = New Guna.UI2.WinForms.Guna2Button()
        Me.btnGenerateReport = New Guna.UI2.WinForms.Guna2Button()
        Me.dtpTo = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.dtpFrom = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.lblTo = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.lblFrom = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.cmbReportType = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.lblReportType = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.grpResults = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.dgvReport = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.lblSummary = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.grpFilters.SuspendLayout()
        Me.grpResults.SuspendLayout()
        CType(Me.dgvReport, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.lblTitle.Text = "Reports"
        '
        'grpFilters
        '
        Me.grpFilters.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpFilters.Controls.Add(Me.btnExportReport)
        Me.grpFilters.Controls.Add(Me.btnGenerateReport)
        Me.grpFilters.Controls.Add(Me.dtpTo)
        Me.grpFilters.Controls.Add(Me.dtpFrom)
        Me.grpFilters.Controls.Add(Me.lblTo)
        Me.grpFilters.Controls.Add(Me.lblFrom)
        Me.grpFilters.Controls.Add(Me.cmbReportType)
        Me.grpFilters.Controls.Add(Me.lblReportType)
        Me.grpFilters.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.grpFilters.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold)
        Me.grpFilters.ForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.grpFilters.Location = New System.Drawing.Point(12, 52)
        Me.grpFilters.Name = "grpFilters"
        Me.grpFilters.Size = New System.Drawing.Size(1076, 155)
        Me.grpFilters.TabIndex = 1
        Me.grpFilters.Text = "Report Filters"
        '
        'btnExportReport
        '
        Me.btnExportReport.FillColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.btnExportReport.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnExportReport.ForeColor = System.Drawing.Color.White
        Me.btnExportReport.Location = New System.Drawing.Point(556, 116)
        Me.btnExportReport.Name = "btnExportReport"
        Me.btnExportReport.Size = New System.Drawing.Size(140, 36)
        Me.btnExportReport.TabIndex = 0
        Me.btnExportReport.Text = "Export CSV"
        '
        'btnGenerateReport
        '
        Me.btnGenerateReport.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnGenerateReport.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnGenerateReport.ForeColor = System.Drawing.Color.White
        Me.btnGenerateReport.Location = New System.Drawing.Point(356, 116)
        Me.btnGenerateReport.Name = "btnGenerateReport"
        Me.btnGenerateReport.Size = New System.Drawing.Size(140, 36)
        Me.btnGenerateReport.TabIndex = 1
        Me.btnGenerateReport.Text = "Generate"
        '
        'dtpTo
        '
        Me.dtpTo.Checked = True
        Me.dtpTo.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.dtpTo.ForeColor = System.Drawing.Color.Black
        Me.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        Me.dtpTo.Location = New System.Drawing.Point(834, 52)
        Me.dtpTo.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.dtpTo.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.dtpTo.Name = "dtpTo"
        Me.dtpTo.Size = New System.Drawing.Size(215, 36)
        Me.dtpTo.TabIndex = 2
        Me.dtpTo.Value = New Date(2026, 5, 23, 20, 8, 8, 695)
        '
        'dtpFrom
        '
        Me.dtpFrom.Checked = True
        Me.dtpFrom.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.dtpFrom.ForeColor = System.Drawing.Color.Black
        Me.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        Me.dtpFrom.Location = New System.Drawing.Point(504, 52)
        Me.dtpFrom.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.dtpFrom.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.dtpFrom.Name = "dtpFrom"
        Me.dtpFrom.Size = New System.Drawing.Size(192, 36)
        Me.dtpFrom.TabIndex = 3
        Me.dtpFrom.Value = New Date(2026, 5, 23, 20, 8, 8, 806)
        '
        'lblTo
        '
        Me.lblTo.AutoSize = False
        Me.lblTo.BackColor = System.Drawing.Color.Transparent
        Me.lblTo.ForeColor = System.Drawing.Color.Black
        Me.lblTo.Location = New System.Drawing.Point(790, 48)
        Me.lblTo.Name = "lblTo"
        Me.lblTo.Size = New System.Drawing.Size(55, 32)
        Me.lblTo.TabIndex = 4
        Me.lblTo.Text = "To"
        '
        'lblFrom
        '
        Me.lblFrom.AutoSize = False
        Me.lblFrom.BackColor = System.Drawing.Color.Transparent
        Me.lblFrom.ForeColor = System.Drawing.Color.Black
        Me.lblFrom.Location = New System.Drawing.Point(421, 52)
        Me.lblFrom.Name = "lblFrom"
        Me.lblFrom.Size = New System.Drawing.Size(89, 28)
        Me.lblFrom.TabIndex = 5
        Me.lblFrom.Text = "From"
        '
        'cmbReportType
        '
        Me.cmbReportType.BackColor = System.Drawing.Color.Transparent
        Me.cmbReportType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbReportType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbReportType.FocusedColor = System.Drawing.Color.Empty
        Me.cmbReportType.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cmbReportType.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cmbReportType.ItemHeight = 30
        Me.cmbReportType.Location = New System.Drawing.Point(105, 48)
        Me.cmbReportType.Name = "cmbReportType"
        Me.cmbReportType.Size = New System.Drawing.Size(292, 36)
        Me.cmbReportType.TabIndex = 6
        '
        'lblReportType
        '
        Me.lblReportType.AutoSize = False
        Me.lblReportType.BackColor = System.Drawing.Color.Transparent
        Me.lblReportType.ForeColor = System.Drawing.Color.Black
        Me.lblReportType.Location = New System.Drawing.Point(15, 48)
        Me.lblReportType.Name = "lblReportType"
        Me.lblReportType.Size = New System.Drawing.Size(73, 32)
        Me.lblReportType.TabIndex = 7
        Me.lblReportType.Text = "Report"
        '
        'grpResults
        '
        Me.grpResults.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpResults.Controls.Add(Me.dgvReport)
        Me.grpResults.Controls.Add(Me.lblSummary)
        Me.grpResults.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.grpResults.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold)
        Me.grpResults.ForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.grpResults.Location = New System.Drawing.Point(12, 213)
        Me.grpResults.Name = "grpResults"
        Me.grpResults.Size = New System.Drawing.Size(1076, 391)
        Me.grpResults.TabIndex = 0
        Me.grpResults.Text = "Report Output"
        '
        'dgvReport
        '
        Me.dgvReport.AllowUserToAddRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.dgvReport.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold)
        Me.dgvReport.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvReport.ColumnHeadersHeight = 29
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvReport.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvReport.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvReport.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvReport.Location = New System.Drawing.Point(0, 40)
        Me.dgvReport.Name = "dgvReport"
        Me.dgvReport.ReadOnly = True
        Me.dgvReport.RowHeadersVisible = False
        Me.dgvReport.RowHeadersWidth = 51
        Me.dgvReport.Size = New System.Drawing.Size(1076, 318)
        Me.dgvReport.TabIndex = 0
        Me.dgvReport.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.dgvReport.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.dgvReport.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.dgvReport.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.dgvReport.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.dgvReport.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.dgvReport.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvReport.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvReport.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvReport.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvReport.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.dgvReport.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvReport.ThemeStyle.HeaderStyle.Height = 29
        Me.dgvReport.ThemeStyle.ReadOnly = True
        Me.dgvReport.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.dgvReport.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvReport.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold)
        Me.dgvReport.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.dgvReport.ThemeStyle.RowsStyle.Height = 22
        Me.dgvReport.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvReport.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'lblSummary
        '
        Me.lblSummary.BackColor = System.Drawing.Color.Transparent
        Me.lblSummary.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lblSummary.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblSummary.Location = New System.Drawing.Point(0, 358)
        Me.lblSummary.Name = "lblSummary"
        Me.lblSummary.Padding = New System.Windows.Forms.Padding(12, 8, 0, 0)
        Me.lblSummary.Size = New System.Drawing.Size(1076, 33)
        Me.lblSummary.TabIndex = 1
        Me.lblSummary.Text = "Summary: —"
        '
        'ReportsFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1100, 620)
        Me.Controls.Add(Me.grpResults)
        Me.Controls.Add(Me.grpFilters)
        Me.Controls.Add(Me.lblTitle)
        Me.Name = "ReportsFrm"
        Me.grpFilters.ResumeLayout(False)
        Me.grpResults.ResumeLayout(False)
        Me.grpResults.PerformLayout()
        CType(Me.dgvReport, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitle As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents grpFilters As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents lblReportType As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents cmbReportType As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents lblFrom As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lblTo As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents dtpFrom As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents dtpTo As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents btnGenerateReport As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnExportReport As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents grpResults As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents dgvReport As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents lblSummary As Guna.UI2.WinForms.Guna2HtmlLabel
End Class
