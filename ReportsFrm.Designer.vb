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
        Dim cs2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Me.lblTitle = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.grpFilters = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.dtpTo = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.dtpFrom = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.lblTo = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.lblFrom = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.cmbReportType = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.lblReportType = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.btnGenerateReport = New Guna.UI2.WinForms.Guna2Button()
        Me.btnExportReport = New Guna.UI2.WinForms.Guna2Button()
        Me.grpResults = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.dgvReport = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.lblSummary = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.grpFilters.SuspendLayout()
        Me.grpResults.SuspendLayout()
        CType(Me.dgvReport, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        Me.lblTitle.Dock = DockStyle.Top
        Me.lblTitle.Font = New Font("Segoe UI", 16.0!, FontStyle.Bold)
        Me.lblTitle.ForeColor = Color.FromArgb(255, 128, 0)
        Me.lblTitle.Padding = New Padding(12, 8, 0, 0)
        Me.lblTitle.Size = New Size(1100, 44)
        Me.lblTitle.Text = "Reports"
        '
        Me.grpFilters.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        Me.grpFilters.Controls.Add(Me.btnExportReport)
        Me.grpFilters.Controls.Add(Me.btnGenerateReport)
        Me.grpFilters.Controls.Add(Me.dtpTo)
        Me.grpFilters.Controls.Add(Me.dtpFrom)
        Me.grpFilters.Controls.Add(Me.lblTo)
        Me.grpFilters.Controls.Add(Me.lblFrom)
        Me.grpFilters.Controls.Add(Me.cmbReportType)
        Me.grpFilters.Controls.Add(Me.lblReportType)
        Me.grpFilters.FillColor = Color.FromArgb(255, 224, 192)
        Me.grpFilters.Font = New Font("Segoe UI Semibold", 10.0!, FontStyle.Bold)
        Me.grpFilters.Location = New Point(12, 52)
        Me.grpFilters.Size = New Size(1076, 100)
        Me.grpFilters.Text = "Report Filters"
        '
        Me.lblReportType.Location = New Point(16, 48) : Me.lblReportType.Text = "Report" : Me.lblReportType.Size = New Size(60, 22)
        Me.cmbReportType.DropDownStyle = ComboBoxStyle.DropDownList
        Me.cmbReportType.Location = New Point(80, 44) : Me.cmbReportType.Size = New Size(220, 36)
        Me.lblFrom.Location = New Point(320, 48) : Me.lblFrom.Text = "From" : Me.lblFrom.Size = New Size(50, 22)
        Me.dtpFrom.Location = New Point(370, 44) : Me.dtpFrom.Size = New Size(150, 36)
        Me.lblTo.Location = New Point(540, 48) : Me.lblTo.Text = "To" : Me.lblTo.Size = New Size(40, 22)
        Me.dtpTo.Location = New Point(580, 44) : Me.dtpTo.Size = New Size(150, 36)
        Me.btnGenerateReport.Location = New Point(760, 44) : Me.btnGenerateReport.Size = New Size(140, 36)
        Me.btnGenerateReport.Text = "Generate"
        Me.btnGenerateReport.FillColor = Color.FromArgb(255, 128, 0) : Me.btnGenerateReport.ForeColor = Color.White
        Me.btnExportReport.Location = New Point(910, 44) : Me.btnExportReport.Size = New Size(140, 36)
        Me.btnExportReport.Text = "Export CSV"
        Me.btnExportReport.FillColor = Color.FromArgb(30, 30, 30) : Me.btnExportReport.ForeColor = Color.White
        '
        Me.grpResults.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Me.grpResults.Controls.Add(Me.dgvReport)
        Me.grpResults.Controls.Add(Me.lblSummary)
        Me.grpResults.FillColor = Color.FromArgb(255, 224, 192)
        Me.grpResults.Font = New Font("Segoe UI Semibold", 10.0!, FontStyle.Bold)
        Me.grpResults.Location = New Point(12, 164)
        Me.grpResults.Size = New Size(1076, 440)
        Me.grpResults.Text = "Report Output"
        '
        Me.lblSummary.Dock = DockStyle.Bottom
        Me.lblSummary.Font = New Font("Segoe UI Semibold", 10.0!, FontStyle.Bold)
        Me.lblSummary.Height = 36
        Me.lblSummary.Padding = New Padding(12, 8, 0, 0)
        Me.lblSummary.Text = "Summary: —"
        '
        Me.dgvReport.Dock = DockStyle.Fill
        Me.dgvReport.ReadOnly = True
        Me.dgvReport.AllowUserToAddRows = False
        cs2.BackColor = Color.FromArgb(255, 192, 128)
        Me.dgvReport.ColumnHeadersDefaultCellStyle = cs2
        '
        Me.AutoScaleMode = AutoScaleMode.Font
        Me.BackColor = Color.FromArgb(248, 249, 250)
        Me.ClientSize = New Size(1100, 620)
        Me.Controls.Add(Me.grpResults)
        Me.Controls.Add(Me.grpFilters)
        Me.Controls.Add(Me.lblTitle)
        Me.grpFilters.ResumeLayout(False)
        Me.grpResults.ResumeLayout(False)
        CType(Me.dgvReport, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
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
