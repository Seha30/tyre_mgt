Imports MySql.Data.MySqlClient

Module ItemCRUD

    Public Function LoadItems() As DataTable
        Dim dt As New DataTable()
        Using conn As MySqlConnection = GetConnection()
            Using da As New MySqlDataAdapter("SELECT * FROM items WHERE is_active=1 ORDER BY item_name", conn)
                da.Fill(dt)
            End Using
        End Using
        Return dt
    End Function

    Public Function SearchItems(keyword As String) As DataTable
        Dim dt As New DataTable()
        Using conn As MySqlConnection = GetConnection()
            Dim sql As String = "SELECT * FROM items WHERE is_active=1 AND (item_code LIKE @k OR item_name LIKE @k OR brand LIKE @k OR tyre_size LIKE @k OR item_type LIKE @k)"
            Using cmd As New MySqlCommand(sql, conn)
                cmd.Parameters.AddWithValue("@k", "%" & keyword & "%")
                Using da As New MySqlDataAdapter(cmd)
                    da.Fill(dt)
                End Using
            End Using
        End Using
        Return dt
    End Function

    Public Sub AddItem(code As String, name As String, itemType As String, brand As String, size As String, retail As Decimal, wholesale As Decimal, qty As Integer, reorder As Integer)
        Dim tracks As Integer = If(itemType = "Service", 0, 1)
        If itemType = "Service" Then qty = 0
        Using conn As MySqlConnection = GetConnection()
            Dim sql As String = "INSERT INTO items (item_code,item_name,item_type,brand,tyre_size,retail_price,wholesale_price,quantity,reorder_level,tracks_stock) VALUES (@c,@n,@t,@b,@s,@r,@w,@q,@o,@tr)"
            Using cmd As New MySqlCommand(sql, conn)
                cmd.Parameters.AddWithValue("@c", code)
                cmd.Parameters.AddWithValue("@n", name)
                cmd.Parameters.AddWithValue("@t", itemType)
                cmd.Parameters.AddWithValue("@b", If(String.IsNullOrWhiteSpace(brand), DBNull.Value, brand))
                cmd.Parameters.AddWithValue("@s", If(String.IsNullOrWhiteSpace(size), DBNull.Value, size))
                cmd.Parameters.AddWithValue("@r", retail)
                cmd.Parameters.AddWithValue("@w", wholesale)
                cmd.Parameters.AddWithValue("@q", qty)
                cmd.Parameters.AddWithValue("@o", reorder)
                cmd.Parameters.AddWithValue("@tr", tracks)
                cmd.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    Public Sub UpdateItem(id As Integer, code As String, name As String, itemType As String, brand As String, size As String, retail As Decimal, wholesale As Decimal, qty As Integer, reorder As Integer)
        Dim tracks As Integer = If(itemType = "Service", 0, 1)
        If itemType = "Service" Then qty = 0
        Using conn As MySqlConnection = GetConnection()
            Dim sql As String = "UPDATE items SET item_code=@c, item_name=@n, item_type=@t, brand=@b, tyre_size=@s, retail_price=@r, wholesale_price=@w, quantity=@q, reorder_level=@o, tracks_stock=@tr WHERE item_id=@id"
            Using cmd As New MySqlCommand(sql, conn)
                cmd.Parameters.AddWithValue("@id", id)
                cmd.Parameters.AddWithValue("@c", code)
                cmd.Parameters.AddWithValue("@n", name)
                cmd.Parameters.AddWithValue("@t", itemType)
                cmd.Parameters.AddWithValue("@b", If(String.IsNullOrWhiteSpace(brand), DBNull.Value, brand))
                cmd.Parameters.AddWithValue("@s", If(String.IsNullOrWhiteSpace(size), DBNull.Value, size))
                cmd.Parameters.AddWithValue("@r", retail)
                cmd.Parameters.AddWithValue("@w", wholesale)
                cmd.Parameters.AddWithValue("@q", qty)
                cmd.Parameters.AddWithValue("@o", reorder)
                cmd.Parameters.AddWithValue("@tr", tracks)
                cmd.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    Public Sub DeleteItem(id As Integer)
        Using conn As MySqlConnection = GetConnection()
            Using cmd As New MySqlCommand("UPDATE items SET is_active=0 WHERE item_id=@id", conn)
                cmd.Parameters.AddWithValue("@id", id)
                cmd.ExecuteNonQuery()
            End Using
        End Using
    End Sub

End Module
