Imports MySql.Data.MySqlClient
Module CustomerCRUD

    Public Sub AddCustomer(cus_name As String, cus_phone As String, cus_email As String, cus_address As String, priceCategory As String)
        Using conn As MySqlConnection = GetConnection()
            Dim query As String = "INSERT INTO customers (cus_name, cus_phone, cus_email, cus_address, price_category) 
                                   VALUES (@cus_name, @cus_phone, @cus_email, @cus_address, @cat)"
            Try
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@cus_name", cus_name)
                    cmd.Parameters.AddWithValue("@cus_phone", cus_phone)
                    cmd.Parameters.AddWithValue("@cus_email", If(String.IsNullOrWhiteSpace(cus_email), DBNull.Value, cus_email))
                    cmd.Parameters.AddWithValue("@cus_address", cus_address)
                    cmd.Parameters.AddWithValue("@cat", priceCategory)
                    cmd.ExecuteNonQuery()
                End Using
            Catch
                query = "INSERT INTO customers (cus_name, cus_phone, cus_email, cus_address, cus_pricetyre) VALUES (@cus_name, @cus_phone, @cus_email, @cus_address, @cat)"
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@cus_name", cus_name)
                    cmd.Parameters.AddWithValue("@cus_phone", cus_phone)
                    cmd.Parameters.AddWithValue("@cus_email", cus_email)
                    cmd.Parameters.AddWithValue("@cus_address", cus_address)
                    cmd.Parameters.AddWithValue("@cat", priceCategory)
                    cmd.ExecuteNonQuery()
                End Using
            End Try
        End Using
    End Sub

    Public Function LoadCustomers() As DataTable
        Dim dt As New DataTable()
        Using conn As MySqlConnection = GetConnection()
            ' conn.Open()
            Dim query As String = "SELECT * FROM customers"
            Using da As New MySqlDataAdapter(query, conn)
                da.Fill(dt)
            End Using
        End Using
        Return dt
    End Function

    Public Sub UpdateCustomer(cus_id As Integer, cus_name As String, cus_phone As String, cus_email As String, cus_address As String, priceCategory As String)
        Using conn As MySqlConnection = GetConnection()
            Dim query As String = "UPDATE customers SET cus_name=@cus_name, cus_phone=@cus_phone, cus_email=@cus_email, cus_address=@cus_address, price_category=@cat WHERE cus_id=@cus_id"
            Try
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@cus_id", cus_id)
                    cmd.Parameters.AddWithValue("@cus_name", cus_name)
                    cmd.Parameters.AddWithValue("@cus_phone", cus_phone)
                    cmd.Parameters.AddWithValue("@cus_email", If(String.IsNullOrWhiteSpace(cus_email), DBNull.Value, cus_email))
                    cmd.Parameters.AddWithValue("@cus_address", cus_address)
                    cmd.Parameters.AddWithValue("@cat", priceCategory)
                    cmd.ExecuteNonQuery()
                End Using
            Catch
                query = "UPDATE customers SET cus_name=@cus_name, cus_phone=@cus_phone, cus_email=@cus_email, cus_address=@cus_address, cus_pricetyre=@cat WHERE cus_id=@cus_id"
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@cus_id", cus_id)
                    cmd.Parameters.AddWithValue("@cus_name", cus_name)
                    cmd.Parameters.AddWithValue("@cus_phone", cus_phone)
                    cmd.Parameters.AddWithValue("@cus_email", cus_email)
                    cmd.Parameters.AddWithValue("@cus_address", cus_address)
                    cmd.Parameters.AddWithValue("@cat", priceCategory)
                    cmd.ExecuteNonQuery()
                End Using
            End Try
        End Using
    End Sub

    Public Sub DeleteCustomer(cus_id As Integer)
        Using conn As MySqlConnection = GetConnection()
            ' conn.Open()
            Dim query As String = "DELETE FROM customers WHERE cus_id=@cus_id"
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@cus_id", cus_id)
                cmd.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    Public Function SearchCustomers(keyword As String) As DataTable
        Dim dt As New DataTable()
        Using conn As MySqlConnection = GetConnection()
            Try
                FillCustomerSearch(conn, dt, keyword, "price_category")
            Catch ex As MySqlException
                If ex.Message.Contains("Unknown column") Then
                    dt.Clear()
                    FillCustomerSearch(conn, dt, keyword, "cus_pricetyre")
                Else
                    Throw
                End If
            End Try
        End Using
        Return dt
    End Function

    Private Sub FillCustomerSearch(conn As MySqlConnection, dt As DataTable, keyword As String, priceColumn As String)
        Dim query As String = "SELECT * FROM customers " &
            "WHERE cus_name LIKE @keyword " &
            "OR cus_phone LIKE @keyword " &
            "OR cus_email LIKE @keyword " &
            "OR cus_address LIKE @keyword " &
            "OR " & priceColumn & " LIKE @keyword"
        Using cmd As New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@keyword", "%" & keyword & "%")
            Using da As New MySqlDataAdapter(cmd)
                da.Fill(dt)
            End Using
        End Using
    End Sub





End Module