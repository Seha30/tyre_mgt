Imports MySql.Data.MySqlClient

Module DashboardCRUD

    Public Function GetCustomerCount(conn As MySqlConnection) As Long
        Return ScalarLong(conn, "SELECT COUNT(*) FROM customers")
    End Function

    Public Function GetActiveProductCount(conn As MySqlConnection) As Long
        Try
            Return ScalarLong(conn, "SELECT COUNT(*) FROM items WHERE is_active=1")
        Catch ex As MySqlException
            If ex.Message.Contains("Unknown column") Then
                Return ScalarLong(conn, "SELECT COUNT(*) FROM items")
            End If
            Throw
        End Try
    End Function

    Public Function GetLowStockCount(conn As MySqlConnection) As Long
        Try
            Return ScalarLong(conn, "SELECT COUNT(*) FROM v_low_stock_items")
        Catch ex As MySqlException
            If ex.Message.Contains("Unknown column") OrElse ex.Message.Contains("doesn't exist") Then
                Return ScalarLong(conn,
                    "SELECT COUNT(*) FROM items " &
                    "WHERE tracks_stock=1 AND quantity<=reorder_level AND is_active=1")
            End If
            Throw
        End Try
    End Function

    Public Function GetTodaySalesTotal(conn As MySqlConnection) As Decimal
        Try
            Return ScalarDecimal(conn,
                "SELECT IFNULL(SUM(total_amount),0) FROM sales " &
                "WHERE DATE(sale_date)=CURDATE() AND status='Completed'")
        Catch ex As MySqlException
            If ex.Message.Contains("Unknown column") Then
                Return ScalarDecimal(conn,
                    "SELECT IFNULL(SUM(total_amount),0) FROM sales " &
                    "WHERE DATE(sale_date)=CURDATE()")
            End If
            Throw
        End Try
    End Function

    Public Function GetLowStockTable(conn As MySqlConnection) As DataTable
        Dim dt As New DataTable()
        Dim sqlView As String =
            "SELECT item_code AS Code, item_name AS Product, brand AS Brand, " &
            "tyre_size AS Size, quantity AS Qty, reorder_level AS Reorder " &
            "FROM v_low_stock_items ORDER BY quantity ASC LIMIT 50"
        Dim sqlTable As String =
            "SELECT item_code AS Code, item_name AS Product, brand AS Brand, " &
            "tyre_size AS Size, quantity AS Qty, reorder_level AS Reorder " &
            "FROM items " &
            "WHERE tracks_stock=1 AND quantity<=reorder_level AND is_active=1 " &
            "ORDER BY quantity ASC LIMIT 50"

        Try
            Using da As New MySqlDataAdapter(sqlView, conn)
                da.Fill(dt)
            End Using
        Catch ex As MySqlException
            If ex.Message.Contains("Unknown column") OrElse ex.Message.Contains("doesn't exist") Then
                dt = New DataTable()
                Using da As New MySqlDataAdapter(sqlTable, conn)
                    da.Fill(dt)
                End Using
            Else
                Throw
            End If
        End Try
        Return dt
    End Function

    Private Function ScalarLong(conn As MySqlConnection, sql As String) As Long
        Using cmd As New MySqlCommand(sql, conn)
            Dim result = cmd.ExecuteScalar()
            If result Is Nothing OrElse result Is DBNull.Value Then Return 0
            Return Convert.ToInt64(result)
        End Using
    End Function

    Private Function ScalarDecimal(conn As MySqlConnection, sql As String) As Decimal
        Using cmd As New MySqlCommand(sql, conn)
            Dim result = cmd.ExecuteScalar()
            If result Is Nothing OrElse result Is DBNull.Value Then Return 0D
            Return Convert.ToDecimal(result)
        End Using
    End Function

End Module
