Imports MySql.Data.MySqlClient
Module CustomerCRUD

    Public Sub AddCustomer(cus_name As String, cus_phone As String, cus_email As String, cus_address As String, cus_pricetyre As String)
        Using conn As MySqlConnection = GetConnection()
            'conn.Open()
            Dim query As String = "INSERT INTO customers (cus_name, cus_phone, cus_email, cus_address, cus_pricetyre) 
                                   VALUES (@cus_name, @cus_phone, @cus_email, @cus_address, @cus_pricetyre)"
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@cus_name", cus_name)
                cmd.Parameters.AddWithValue("@cus_phone", cus_phone)
                cmd.Parameters.AddWithValue("@cus_email", cus_email)
                cmd.Parameters.AddWithValue("@cus_address", cus_address)
                cmd.Parameters.AddWithValue("@cus_pricetyre", cus_pricetyre)
                cmd.ExecuteNonQuery()
            End Using
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

    Public Sub UpdateCustomer(cus_id As Integer, cus_name As String, cus_phone As String, cus_email As String, cus_address As String, cus_pricetyre As String)
        Using conn As MySqlConnection = GetConnection()
            'conn.Open()
            Dim query As String = "UPDATE customers 
                               SET cus_name=@cus_name, cus_phone=@cus_phone, cus_email=@cus_email, cus_address=@cus_address, cus_pricetyre=@cus_pricetyre 
                               WHERE cus_id=@cus_id"
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@cus_id", cus_id)
                cmd.Parameters.AddWithValue("@cus_name", cus_name)
                cmd.Parameters.AddWithValue("@cus_phone", cus_phone)
                cmd.Parameters.AddWithValue("@cus_email", cus_email)
                cmd.Parameters.AddWithValue("@cus_address", cus_address)
                cmd.Parameters.AddWithValue("@cus_pricetyre", cus_pricetyre)
                cmd.ExecuteNonQuery()
            End Using
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
            'conn.Open()
            Dim query As String = "SELECT * FROM customers 
                               WHERE cus_name LIKE @keyword 
                               OR cus_phone LIKE @keyword 
                               OR cus_email LIKE @keyword 
                               OR cus_address LIKE @keyword 
                               OR cus_pricetyre LIKE @keyword"
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@keyword", "%" & keyword & "%")
                Using da As New MySqlDataAdapter(cmd)
                    da.Fill(dt)
                End Using
            End Using
        End Using
        Return dt
    End Function





End Module