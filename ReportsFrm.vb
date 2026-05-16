Imports System.IO
Imports System.Linq
Imports MySql.Data.MySqlClient

Public Class ReportsFrm

    Private Sub ReportsFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UiThemeHelper.StyleGroupBox(grpFilters)
        UiThemeHelper.StyleGroupBox(grpResults)
        UiThemeHelper.StylePrimaryButton(btnGenerateReport)
        UiThemeHelper.StylePrimaryButton(btnExportReport)
        UiThemeHelper.ApplyGridTheme(dgvReport)
        cmbReportType.Items.AddRange(New Object() {
            "Daily Sales Summary",
            "Low Stock Items",
            "Product Inventory List",
            "Customer List"
        })
        cmbReportType.SelectedIndex = 0
        dtpFrom.Value = Date.Today.AddDays(-30)
        dtpTo.Value = Date.Today
    End Sub

    Private Sub btnGenerateReport_Click(sender As Object, e As EventArgs) Handles btnGenerateReport.Click
        Try
            Using conn As MySqlConnection = GetConnection()
                Select Case cmbReportType.SelectedIndex
                    Case 0
                        Dim sql = "SELECT DATE(sale_date) AS SaleDate, COUNT(*) AS Invoices, SUM(total_amount) AS Revenue FROM sales WHERE status='Completed' AND DATE(sale_date) BETWEEN @f AND @t GROUP BY DATE(sale_date)"
                        dgvReport.DataSource = QueryTable(conn, sql)
                        lblSummary.Text = "Summary: sales report " & dtpFrom.Value.ToShortDateString() & " – " & dtpTo.Value.ToShortDateString()
                    Case 1
                        dgvReport.DataSource = QueryTable(conn, "SELECT item_code, item_name, brand, tyre_size, quantity, reorder_level FROM items WHERE tracks_stock=1 AND quantity<=reorder_level AND is_active=1")
                        lblSummary.Text = "Summary: low stock items"
                    Case 2
                        dgvReport.DataSource = ItemCRUD.LoadItems()
                        lblSummary.Text = "Summary: full product list"
                    Case 3
                        dgvReport.DataSource = CustomerCRUD.LoadCustomers()
                        lblSummary.Text = "Summary: customer list"
                End Select
            End Using
        Catch ex As Exception
            MessageBox.Show("Run database scripts first or adjust query. " & ex.Message, "Reports", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Function QueryTable(conn As MySqlConnection, sql As String) As DataTable
        Using cmd As New MySqlCommand(sql, conn)
            cmd.Parameters.AddWithValue("@f", dtpFrom.Value.Date)
            cmd.Parameters.AddWithValue("@t", dtpTo.Value.Date)
            Using da As New MySqlDataAdapter(cmd)
                Dim dt As New DataTable()
                da.Fill(dt)
                Return dt
            End Using
        End Using
    End Function

    Private Sub btnExportReport_Click(sender As Object, e As EventArgs) Handles btnExportReport.Click
        If dgvReport.Rows.Count = 0 Then
            MessageBox.Show("Generate a report first.", "Export", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If
        Using sfd As New SaveFileDialog()
            sfd.Filter = "CSV files|*.csv"
            sfd.FileName = "report_" & Date.Now.ToString("yyyyMMdd") & ".csv"
            If sfd.ShowDialog() <> DialogResult.OK Then Return
            Using w As New StreamWriter(sfd.FileName)
                Dim headers = dgvReport.Columns.Cast(Of DataGridViewColumn)().Select(Function(c) c.HeaderText)
                w.WriteLine(String.Join(",", headers))
                For Each row As DataGridViewRow In dgvReport.Rows
                    If row.IsNewRow Then Continue For
                    Dim cells = row.Cells.Cast(Of DataGridViewCell)().Select(Function(c) """" & c.Value.ToString().Replace("""", """""") & """")
                    w.WriteLine(String.Join(",", cells))
                Next
            End Using
            MessageBox.Show("Exported to " & sfd.FileName, "Export", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Using
    End Sub

End Class
