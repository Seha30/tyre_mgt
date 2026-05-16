Imports MySql.Data.MySqlClient

Module SupplierCRUD

    Public Function LoadSuppliers() As DataTable
        Dim dt As New DataTable()
        Using conn As MySqlConnection = GetConnection()
            Using da As New MySqlDataAdapter("SELECT * FROM suppliers WHERE is_active=1 ORDER BY sup_name", conn)
                da.Fill(dt)
            End Using
        End Using
        Return dt
    End Function

    Public Function SearchSuppliers(keyword As String) As DataTable
        Dim dt As New DataTable()
        Using conn As MySqlConnection = GetConnection()
            Dim sql = "SELECT * FROM suppliers WHERE is_active=1 AND (sup_name LIKE @k OR sup_company LIKE @k OR sup_phone LIKE @k)"
            Using cmd As New MySqlCommand(sql, conn)
                cmd.Parameters.AddWithValue("@k", "%" & keyword & "%")
                Using da As New MySqlDataAdapter(cmd)
                    da.Fill(dt)
                End Using
            End Using
        End Using
        Return dt
    End Function

    Public Sub AddSupplier(name As String, company As String, phone As String, email As String, address As String)
        Using conn As MySqlConnection = GetConnection()
            Dim sql = "INSERT INTO suppliers (sup_name,sup_company,sup_phone,sup_email,sup_address) VALUES (@n,@c,@p,@e,@a)"
            Using cmd As New MySqlCommand(sql, conn)
                cmd.Parameters.AddWithValue("@n", name)
                cmd.Parameters.AddWithValue("@c", If(String.IsNullOrWhiteSpace(company), DBNull.Value, company))
                cmd.Parameters.AddWithValue("@p", phone)
                cmd.Parameters.AddWithValue("@e", If(String.IsNullOrWhiteSpace(email), DBNull.Value, email))
                cmd.Parameters.AddWithValue("@a", If(String.IsNullOrWhiteSpace(address), DBNull.Value, address))
                cmd.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    Public Sub UpdateSupplier(id As Integer, name As String, company As String, phone As String, email As String, address As String)
        Using conn As MySqlConnection = GetConnection()
            Dim sql = "UPDATE suppliers SET sup_name=@n,sup_company=@c,sup_phone=@p,sup_email=@e,sup_address=@a WHERE sup_id=@id"
            Using cmd As New MySqlCommand(sql, conn)
                cmd.Parameters.AddWithValue("@id", id)
                cmd.Parameters.AddWithValue("@n", name)
                cmd.Parameters.AddWithValue("@c", If(String.IsNullOrWhiteSpace(company), DBNull.Value, company))
                cmd.Parameters.AddWithValue("@p", phone)
                cmd.Parameters.AddWithValue("@e", If(String.IsNullOrWhiteSpace(email), DBNull.Value, email))
                cmd.Parameters.AddWithValue("@a", If(String.IsNullOrWhiteSpace(address), DBNull.Value, address))
                cmd.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    Public Sub DeleteSupplier(id As Integer)
        Using conn As MySqlConnection = GetConnection()
            Using cmd As New MySqlCommand("UPDATE suppliers SET is_active=0 WHERE sup_id=@id", conn)
                cmd.Parameters.AddWithValue("@id", id)
                cmd.ExecuteNonQuery()
            End Using
        End Using
    End Sub

End Module
