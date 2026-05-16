Imports MySql.Data.MySqlClient

Public Class Dashboard

    Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UiThemeHelper.StylePrimaryButton(btnRefreshDashboard)
        UiThemeHelper.StylePrimaryButton(btnQuickPOS)
        UiThemeHelper.StyleSecondaryButton(btnQuickReports)
        UiThemeHelper.ApplyGridTheme(dgvLowStock)
        LoadDashboardData()
    End Sub

    Public Sub LoadDashboardData()
        Try
            Using conn As MySqlConnection = GetConnection()
                lblCustomersVal.Text = Scalar(conn, "SELECT COUNT(*) FROM customers").ToString()
                Try
                    lblProductsVal.Text = Scalar(conn, "SELECT COUNT(*) FROM items WHERE is_active=1").ToString()
                    lblLowStockVal.Text = Scalar(conn, "SELECT COUNT(*) FROM items WHERE tracks_stock=1 AND quantity<=reorder_level AND is_active=1").ToString()
                    lblTodaySalesVal.Text = "Rs. " & Format(ScalarDec(conn, "SELECT IFNULL(SUM(total_amount),0) FROM sales WHERE DATE(sale_date)=CURDATE() AND status='Completed'"), "#,##0.00")
                    LoadLowStockGrid(conn)
                Catch
                    lblProductsVal.Text = "—"
                    lblLowStockVal.Text = "—"
                    lblTodaySalesVal.Text = "Rs. 0.00"
                End Try
            End Using
        Catch
            lblCustomersVal.Text = ScalarSafe("SELECT COUNT(*) FROM customers")
        End Try
    End Sub

    Private Function ScalarSafe(sql As String) As String
        Try
            Using conn As MySqlConnection = GetConnection()
                Return Scalar(conn, sql).ToString()
            End Using
        Catch
            Return "0"
        End Try
    End Function

    Private Function Scalar(conn As MySqlConnection, sql As String) As Long
        Using cmd As New MySqlCommand(sql, conn)
            Return Convert.ToInt64(cmd.ExecuteScalar())
        End Using
    End Function

    Private Function ScalarDec(conn As MySqlConnection, sql As String) As Decimal
        Using cmd As New MySqlCommand(sql, conn)
            Return Convert.ToDecimal(cmd.ExecuteScalar())
        End Using
    End Function

    Private Sub LoadLowStockGrid(conn As MySqlConnection)
        Dim sql As String = "SELECT item_code AS Code, item_name AS Product, brand AS Brand, tyre_size AS Size, quantity AS Qty, reorder_level AS Reorder FROM items WHERE tracks_stock=1 AND quantity<=reorder_level AND is_active=1 ORDER BY quantity LIMIT 50"
        Using da As New MySqlDataAdapter(sql, conn)
            Dim dt As New DataTable()
            da.Fill(dt)
            dgvLowStock.DataSource = dt
        End Using
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
