Imports MySql.Data.MySqlClient

Public Class Dashboard

    Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        StyleDashboard()
        LoadDashboardData()
    End Sub

    Private Sub Dashboard_VisibleChanged(sender As Object, e As EventArgs) Handles MyBase.VisibleChanged
        If Me.Visible Then LoadDashboardData()
    End Sub

    Private Sub StyleDashboard()
        btnRefreshDashboard.FillColor = Color.FromArgb(255, 128, 0)
        btnRefreshDashboard.ForeColor = Color.White
        btnQuickPOS.FillColor = Color.FromArgb(255, 128, 0)
        btnQuickPOS.ForeColor = Color.White
        btnQuickProducts.FillColor = Color.FromArgb(30, 30, 30)
        btnQuickProducts.ForeColor = Color.White
        btnQuickReports.FillColor = Color.FromArgb(255, 224, 192)
        btnQuickReports.ForeColor = Color.Black

        dgvLowStock.AutoGenerateColumns = True
        dgvLowStock.ReadOnly = True
        dgvLowStock.RowHeadersVisible = False
        dgvLowStock.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvLowStock.BackgroundColor = Color.White
        dgvLowStock.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(255, 128, 0)
        dgvLowStock.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
        dgvLowStock.EnableHeadersVisualStyles = False
    End Sub

    Public Sub LoadDashboardData()
        Try
            Using conn As MySqlConnection = GetConnection()
                If conn.State <> ConnectionState.Open Then
                    lblCustomersVal.Text = "—"
                    lblProductsVal.Text = "—"
                    lblLowStockVal.Text = "—"
                    lblTodaySalesVal.Text = "Rs. 0.00"
                    dgvLowStock.DataSource = Nothing
                    Return
                End If

                lblCustomersVal.Text = DashboardCRUD.GetCustomerCount(conn).ToString()
                lblProductsVal.Text = DashboardCRUD.GetActiveProductCount(conn).ToString()
                lblLowStockVal.Text = DashboardCRUD.GetLowStockCount(conn).ToString()

                Dim todaySales = DashboardCRUD.GetTodaySalesTotal(conn)
                lblTodaySalesVal.Text = "Rs. " & Format(todaySales, "#,##0.00")

                dgvLowStock.DataSource = DashboardCRUD.GetLowStockTable(conn)
                If dgvLowStock.Columns.Count > 0 Then
                    dgvLowStock.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.DisplayedCells)
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("Dashboard load error: " & ex.Message, "Dashboard", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Sub btnRefreshDashboard_Click(sender As Object, e As EventArgs) Handles btnRefreshDashboard.Click
        LoadDashboardData()
    End Sub

    Private Function GetMainMenu() As MainMenu
        Dim p = Me.Parent
        While p IsNot Nothing
            If TypeOf p Is MainMenu Then Return DirectCast(p, MainMenu)
            p = p.Parent
        End While
        Return Nothing
    End Function

    Private Sub btnQuickPOS_Click(sender As Object, e As EventArgs) Handles btnQuickPOS.Click
        GetMainMenu()?.OpenModule(New SalesPOS(), "Sales (POS)", Nothing)
    End Sub

    Private Sub btnQuickProducts_Click(sender As Object, e As EventArgs) Handles btnQuickProducts.Click
        GetMainMenu()?.OpenModule(New ProductMgtFrm(), "Product Management", Nothing)
    End Sub

    Private Sub btnQuickReports_Click(sender As Object, e As EventArgs) Handles btnQuickReports.Click
        GetMainMenu()?.OpenModule(New ReportsFrm(), "Reports", Nothing)
    End Sub


End Class
