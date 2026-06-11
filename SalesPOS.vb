'Imports System.Data
'Imports MySql.Data.MySqlClient
'Imports System.Drawing.Printing

'Public Class SalesPOS

'    Private cart As DataTable
'    Private selectedItemId As Integer
'    Private selectedPrice As Decimal
'    Private selectedStock As Integer
'    Private selectedTracksStock As Boolean
'    Private invoiceToPrint As String = ""
'    Private WithEvents printDoc As New PrintDocument()

'    Private Sub SalesPOS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
'        lblTitle.Visible = False
'        splitMain.Panel2MinSize = 340
'        splitMain.Panel1MinSize = 300

'        StylePosControls()
'        InitCart()
'        LoadCatalog()
'        LoadCustomers()

'        cmbPayment.Items.Clear()
'        cmbPayment.Items.AddRange(New Object() {"Cash", "Card", "Bank Transfer", "Credit"})
'        cmbPayment.SelectedIndex = 0

'        txtDiscount.Text = "0"
'        RecalcTotals()
'        AdjustPosLayout()
'    End Sub

'    Private Sub SalesPOS_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
'        AdjustPosLayout()
'    End Sub

'    Private Sub StylePosControls()
'        btnSearchItemPOS.FillColor = Color.FromArgb(255, 128, 0)
'        btnSearchItemPOS.ForeColor = Color.White
'        btnAddToCart.FillColor = Color.FromArgb(255, 128, 0)
'        btnAddToCart.ForeColor = Color.White
'        btnRemoveLine.FillColor = Color.FromArgb(220, 53, 69)
'        btnRemoveLine.ForeColor = Color.White
'        btnCompleteSale.FillColor = Color.FromArgb(255, 128, 0)
'        btnCompleteSale.ForeColor = Color.White
'        btnClearCart.FillColor = Color.FromArgb(255, 192, 128)
'        btnClearCart.ForeColor = Color.Black

'        dgvCatalog.AutoGenerateColumns = True
'        dgvCatalog.ReadOnly = True
'        dgvCatalog.RowHeadersVisible = False
'        dgvCatalog.SelectionMode = DataGridViewSelectionMode.FullRowSelect
'        dgvCatalog.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(255, 128, 0)
'        dgvCatalog.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
'        dgvCatalog.EnableHeadersVisualStyles = False

'        dgvCart.AutoGenerateColumns = True
'        dgvCart.ReadOnly = True
'        dgvCart.RowHeadersVisible = False
'        dgvCart.SelectionMode = DataGridViewSelectionMode.FullRowSelect
'        dgvCart.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(255, 128, 0)
'        dgvCart.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
'        dgvCart.EnableHeadersVisualStyles = False
'    End Sub

'    Private Sub AdjustPosLayout()
'        If splitMain.Width <= splitMain.Panel1MinSize + splitMain.Panel2MinSize + splitMain.SplitterWidth Then Return

'        Dim preferredLeft = CInt(splitMain.Width * 0.56)
'        Dim maxLeft = splitMain.Width - splitMain.Panel2MinSize - splitMain.SplitterWidth
'        splitMain.SplitterDistance = Math.Max(splitMain.Panel1MinSize, Math.Min(preferredLeft, maxLeft))

'        LayoutCustomerRow()
'        LayoutCartArea()
'        LayoutCheckoutArea()
'    End Sub

'    Private Sub LayoutCustomerRow()
'        Dim w = grpCustomer.ClientSize.Width
'        If w <= 0 Then Return

'        Const pad As Integer = 16
'        Const top As Integer = 46
'        Const labelW As Integer = 78
'        Const payComboW As Integer = 130
'        Const payLabelW As Integer = 68

'        lblCustomerPOS.SetBounds(pad, top + 4, labelW, 22)
'        cmbPayment.SetBounds(w - pad - payComboW, top, payComboW, 36)
'        lblPayment.SetBounds(cmbPayment.Left - payLabelW - 6, top + 4, payLabelW, 22)
'        cmbCustomerPOS.SetBounds(pad + labelW + 6, top, lblPayment.Left - pad - labelW - 12, 36)
'    End Sub

'    Private Sub LayoutCartArea()
'        Dim w = grpCart.ClientSize.Width
'        Dim h = grpCart.ClientSize.Height
'        If w <= 0 OrElse h <= 0 Then Return

'        Const pad As Integer = 12
'        Const toolbarH As Integer = 44

'        lblQtyPOS.SetBounds(pad, 46, 36, 22)
'        numQtyPOS.SetBounds(pad + 40, 42, 56, 36)
'        btnAddToCart.SetBounds(pad + 104, 42, 118, 36)
'        btnRemoveLine.SetBounds(pad + 228, 42, 118, 36)
'        dgvCart.SetBounds(pad, 88, w - (pad * 2), h - 96)
'    End Sub

'    Private Sub LayoutCheckoutArea()
'        Dim w = grpCheckout.ClientSize.Width
'        If w <= 0 Then Return

'        Const pad As Integer = 16
'        Const row1 As Integer = 52
'        Const row2 As Integer = 112

'        lblSubtotal.SetBounds(pad, row1 + 4, 110, 22)
'        txtSubtotal.SetBounds(pad + 116, row1, 120, 36)

'        lblDiscount.SetBounds(pad + 250, row1 + 4, 100, 22)
'        txtDiscount.SetBounds(pad + 354, row1, 100, 36)

'        btnClearCart.SetBounds(w - pad - 150, row1 - 2, 150, 40)

'        lblTotal.SetBounds(pad, row2 + 6, 110, 28)
'        txtTotal.SetBounds(pad + 116, row2, 180, 40)
'        btnCompleteSale.SetBounds(w - pad - 180, row2, 180, 44)
'    End Sub

'    Private Sub InitCart()
'        cart = New DataTable()
'        cart.Columns.Add("item_id", GetType(Integer))
'        cart.Columns.Add("item_name", GetType(String))
'        cart.Columns.Add("qty", GetType(Integer))
'        cart.Columns.Add("unit_price", GetType(Decimal))
'        cart.Columns.Add("line_total", GetType(Decimal))
'        dgvCart.DataSource = cart
'    End Sub

'    Private Sub LoadCatalog()
'        Try
'            dgvCatalog.DataSource = ItemCRUD.LoadItems()
'            FormatCatalogGrid()
'        Catch ex As Exception
'            MessageBox.Show("Catalog load error: " & ex.Message, "POS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
'        End Try
'    End Sub

'    Private Sub FormatCatalogGrid()
'        If dgvCatalog.Columns.Count = 0 Then Return

'        Dim showCols = New HashSet(Of String)(StringComparer.OrdinalIgnoreCase) From {
'            "item_code", "item_name", "item_type", "brand", "tyre_size", "quantity", "retail_price", "wholesale_price"
'        }

'        For Each col As DataGridViewColumn In dgvCatalog.Columns
'            col.Visible = showCols.Contains(col.Name)
'        Next

'        SetHeader(dgvCatalog, "item_code", "Code")
'        SetHeader(dgvCatalog, "item_name", "Product")
'        SetHeader(dgvCatalog, "item_type", "Type")
'        SetHeader(dgvCatalog, "brand", "Brand")
'        SetHeader(dgvCatalog, "tyre_size", "Size")
'        SetHeader(dgvCatalog, "quantity", "Stock")
'        SetHeader(dgvCatalog, "retail_price", "Retail")
'        SetHeader(dgvCatalog, "wholesale_price", "Wholesale")

'        dgvCatalog.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
'    End Sub

'    Private Sub FormatCartGrid()
'        If dgvCart.Columns.Count = 0 Then Return

'        If dgvCart.Columns.Contains("item_id") Then dgvCart.Columns("item_id").Visible = False
'        SetHeader(dgvCart, "item_name", "Product")
'        SetHeader(dgvCart, "qty", "Qty")
'        SetHeader(dgvCart, "unit_price", "Price")
'        SetHeader(dgvCart, "line_total", "Total")
'        dgvCart.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
'    End Sub

'    Private Sub SetHeader(grid As DataGridView, columnName As String, header As String)
'        If grid.Columns.Contains(columnName) Then grid.Columns(columnName).HeaderText = header
'    End Sub

'    Private Sub LoadCustomers()
'        cmbCustomerPOS.Items.Clear()
'        cmbCustomerPOS.Items.Add(New ComboItem("Walk-in Customer", 0, "Retail"))

'        Try
'            For Each row As DataRow In CustomerCRUD.LoadCustomers().Rows
'                Dim customerName As String = row("cus_name").ToString()
'                If customerName.Equals("Walk-in Customer", StringComparison.OrdinalIgnoreCase) Then Continue For

'                Dim cat As String = "Retail"
'                If row.Table.Columns.Contains("price_category") Then
'                    cat = row("price_category").ToString()
'                ElseIf row.Table.Columns.Contains("cus_pricetyre") Then
'                    cat = row("cus_pricetyre").ToString()
'                End If

'                If cat.Contains("Wholesale") Then cat = "Wholesale"
'                If cat.Contains("Distributor") Then cat = "Distributor"
'                If cat.Contains("Retail") OrElse cat = "" Then cat = "Retail"

'                cmbCustomerPOS.Items.Add(New ComboItem(customerName, CInt(row("cus_id")), cat))
'            Next
'        Catch ex As Exception
'            MessageBox.Show("Customer load error: " & ex.Message, "POS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
'        End Try

'        cmbCustomerPOS.DisplayMember = "Text"
'        If cmbCustomerPOS.Items.Count > 0 Then cmbCustomerPOS.SelectedIndex = 0
'    End Sub

'    Private Sub btnSearchItemPOS_Click(sender As Object, e As EventArgs) Handles btnSearchItemPOS.Click
'        Try
'            dgvCatalog.DataSource = ItemCRUD.SearchItems(txtSearchItemPOS.Text.Trim())
'            FormatCatalogGrid()
'        Catch ex As Exception
'            MessageBox.Show("Search error: " & ex.Message, "POS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
'        End Try
'    End Sub

'    Private Sub dgvCatalog_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCatalog.CellClick
'        If e.RowIndex < 0 Then Return

'        Dim r = dgvCatalog.Rows(e.RowIndex)
'        selectedItemId = CInt(r.Cells("item_id").Value)
'        selectedStock = CInt(r.Cells("quantity").Value)
'        selectedTracksStock = (r.Cells("tracks_stock").Value.ToString() = "1")

'        If GetCustomerCategory() = "Retail" Then
'            selectedPrice = CDec(r.Cells("retail_price").Value)
'        Else
'            selectedPrice = CDec(r.Cells("wholesale_price").Value)
'        End If

'        If selectedPrice <= 0 Then selectedPrice = CDec(r.Cells("retail_price").Value)
'    End Sub

'    Private Function GetCustomerCategory() As String
'        If cmbCustomerPOS.SelectedItem Is Nothing Then Return "Retail"
'        Return DirectCast(cmbCustomerPOS.SelectedItem, ComboItem).Category
'    End Function

'    Private Sub btnAddToCart_Click(sender As Object, e As EventArgs) Handles btnAddToCart.Click
'        If selectedItemId = 0 Then
'            MessageBox.Show("Select a product from the catalog.", "POS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
'            Return
'        End If

'        Dim qty As Integer
'        If Not Integer.TryParse(numQtyPOS.Text, qty) OrElse qty <= 0 Then
'            MessageBox.Show("Enter valid quantity.", "POS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
'            Return
'        End If

'        If selectedTracksStock AndAlso qty > selectedStock Then
'            MessageBox.Show("Not enough stock available.", "POS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
'            Return
'        End If

'        Dim name = dgvCatalog.CurrentRow.Cells("item_name").Value.ToString()
'        cart.Rows.Add(selectedItemId, name, qty, selectedPrice, qty * selectedPrice)
'        FormatCartGrid()
'        RecalcTotals()
'    End Sub

'    Private Sub btnRemoveLine_Click(sender As Object, e As EventArgs) Handles btnRemoveLine.Click
'        If dgvCart.CurrentRow Is Nothing Then Return
'        cart.Rows.RemoveAt(dgvCart.CurrentRow.Index)
'        RecalcTotals()
'    End Sub

'    Private Sub btnClearCart_Click(sender As Object, e As EventArgs) Handles btnClearCart.Click
'        cart.Rows.Clear()
'        txtDiscount.Text = "0"
'        RecalcTotals()
'    End Sub

'    Private Sub RecalcTotals()
'        If cart Is Nothing Then Exit Sub

'        Dim subtotal As Decimal = 0
'        For Each row As DataRow In cart.Rows
'            subtotal += CDec(row("line_total"))
'        Next

'        Dim discount As Decimal = 0
'        Decimal.TryParse(txtDiscount.Text, discount)
'        If discount > subtotal Then discount = subtotal
'        If discount < 0 Then discount = 0

'        txtSubtotal.Text = subtotal.ToString("N2")
'        txtTotal.Text = (subtotal - discount).ToString("N2")
'    End Sub

'    Private Sub txtDiscount_TextChanged(sender As Object, e As EventArgs) Handles txtDiscount.TextChanged
'        RecalcTotals()
'    End Sub

'    Private Sub btnCompleteSale_Click(sender As Object, e As EventArgs) Handles btnCompleteSale.Click
'        If cart.Rows.Count = 0 Then
'            MessageBox.Show("Cart is empty.", "POS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
'            Return
'        End If

'        Dim subtotal As Decimal = 0
'        Decimal.TryParse(txtSubtotal.Text, subtotal)

'        Dim discount As Decimal = 0
'        Decimal.TryParse(txtDiscount.Text, discount)

'        Dim totalAmount As Decimal = 0
'        Decimal.TryParse(txtTotal.Text, totalAmount)

'        If discount < 0 OrElse discount > subtotal OrElse totalAmount < 0 Then
'            MessageBox.Show("Invalid discount or total amount.", "POS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
'            Return
'        End If

'        Dim customer = DirectCast(cmbCustomerPOS.SelectedItem, ComboItem)
'        Dim invoiceNo As String = "INV-" & DateTime.Now.ToString("yyyyMMddHHmmss")

'        Using conn As MySqlConnection = GetConnection()
'            If conn.State <> ConnectionState.Open Then
'                MessageBox.Show("Database connection failed.", "POS", MessageBoxButtons.OK, MessageBoxIcon.Error)
'                Return
'            End If

'            Dim trans = conn.BeginTransaction()
'            Try
'                Dim saleSql =
'                    "INSERT INTO sales " &
'                    "(invoice_no, sale_date, cus_id, user_id, subtotal, discount_amount, discount_pct, total_amount, payment_method, notes, status) " &
'                    "VALUES (@invoice_no, NOW(), @cus_id, @user_id, @subtotal, @discount_amount, @discount_pct, @total_amount, @payment_method, @notes, 'Completed'); " &
'                    "SELECT LAST_INSERT_ID();"

'                Using saleCmd As New MySqlCommand(saleSql, conn, trans)
'                    saleCmd.Parameters.AddWithValue("@invoice_no", invoiceNo)
'                    If customer.Id = 0 Then
'                        saleCmd.Parameters.AddWithValue("@cus_id", DBNull.Value)
'                    Else
'                        saleCmd.Parameters.AddWithValue("@cus_id", customer.Id)
'                    End If
'                    saleCmd.Parameters.AddWithValue("@user_id", 1)
'                    saleCmd.Parameters.AddWithValue("@subtotal", subtotal)
'                    saleCmd.Parameters.AddWithValue("@discount_amount", discount)
'                    saleCmd.Parameters.AddWithValue("@discount_pct", 0)
'                    saleCmd.Parameters.AddWithValue("@total_amount", totalAmount)
'                    saleCmd.Parameters.AddWithValue("@payment_method", cmbPayment.Text)
'                    saleCmd.Parameters.AddWithValue("@notes", "")

'                    Dim saleId = Convert.ToInt32(saleCmd.ExecuteScalar())

'                    For Each row As DataRow In cart.Rows
'                        Using detailCmd As New MySqlCommand(
'                            "INSERT INTO sale_items (sale_id, item_id, qty, unit_price, line_total) " &
'                            "VALUES (@sale_id, @item_id, @qty, @unit_price, @line_total)", conn, trans)
'                            detailCmd.Parameters.AddWithValue("@sale_id", saleId)
'                            detailCmd.Parameters.AddWithValue("@item_id", row("item_id"))
'                            detailCmd.Parameters.AddWithValue("@qty", row("qty"))
'                            detailCmd.Parameters.AddWithValue("@unit_price", row("unit_price"))
'                            detailCmd.Parameters.AddWithValue("@line_total", row("line_total"))
'                            detailCmd.ExecuteNonQuery()







'                        End Using
'                    Next
'                End Using

'                trans.Commit()

'                MessageBox.Show("Sale completed successfully." & vbCrLf & "Invoice No: " & invoiceNo,
'                                "POS", MessageBoxButtons.OK, MessageBoxIcon.Information)

'                btnClearCart.PerformClick()
'                LoadCatalog()
'                RefreshDashboardIfOpen()

'            Catch ex As Exception
'                trans.Rollback()
'                MessageBox.Show("Sale failed: " & ex.Message, "POS", MessageBoxButtons.OK, MessageBoxIcon.Error)
'            End Try
'        End Using
'    End Sub

'    Private Sub RefreshDashboardIfOpen()
'        Dim p = Me.Parent
'        While p IsNot Nothing
'            If TypeOf p Is MainMenu Then
'                For Each ctrl As Control In DirectCast(p, MainMenu).Controls
'                    FindDashboardAndRefresh(ctrl)
'                Next
'                Exit While
'            End If
'            p = p.Parent
'        End While
'    End Sub

'    Private Sub FindDashboardAndRefresh(ctrl As Control)
'        If TypeOf ctrl Is Dashboard Then
'            DirectCast(ctrl, Dashboard).LoadDashboardData()
'        End If
'        For Each child As Control In ctrl.Controls
'            FindDashboardAndRefresh(child)
'        Next
'    End Sub

'    Private Class ComboItem
'        Public Property Text As String
'        Public Property Id As Integer
'        Public Property Category As String

'        Public Sub New(t As String, id As Integer, cat As String)
'            Text = t
'            Me.Id = id
'            Category = cat
'        End Sub

'        Public Overrides Function ToString() As String
'            Return Text
'        End Function
'    End Class




'    Private Sub btnGenerateInvoce_Click(sender As Object, e As EventArgs) Handles btnGenerateInvoce.Click

'        If cart.Rows.Count = 0 Then
'            MessageBox.Show("Cart is empty. Add items before generating invoice.", "Invoice",
'                        MessageBoxButtons.OK, MessageBoxIcon.Warning)
'            Return
'        End If

'        Dim shopName As String = "SN Tyres"
'        Dim shopPhone As String = ""
'        Dim shopAddress As String = ""

'        Try
'            Using conn As MySqlConnection = GetConnection()
'                Dim sql As String = "SELECT shop_name, shop_phone, shop_address FROM shop_settings WHERE id = 1"

'                Using cmd As New MySqlCommand(sql, conn)
'                    Using reader = cmd.ExecuteReader()
'                        If reader.Read() Then
'                            shopName = reader("shop_name").ToString()
'                            shopPhone = reader("shop_phone").ToString()
'                            shopAddress = reader("shop_address").ToString()
'                        End If
'                    End Using
'                End Using
'            End Using
'        Catch ex As Exception
'            MessageBox.Show("Could not load shop settings: " & ex.Message, "Invoice",
'                        MessageBoxButtons.OK, MessageBoxIcon.Warning)
'        End Try

'        Dim invoiceText As String = ""
'        invoiceText &= "==============================" & vbCrLf
'        invoiceText &= "        " & shopName & vbCrLf
'        invoiceText &= "==============================" & vbCrLf

'        If shopAddress <> "" Then
'            invoiceText &= "Address: " & shopAddress & vbCrLf
'        End If

'        If shopPhone <> "" Then
'            invoiceText &= "Phone: " & shopPhone & vbCrLf
'        End If

'        invoiceText &= "------------------------------" & vbCrLf
'        invoiceText &= "        SALES INVOICE" & vbCrLf
'        invoiceText &= "------------------------------" & vbCrLf
'        invoiceText &= "Date: " & DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") & vbCrLf
'        invoiceText &= "Customer: " & cmbCustomerPOS.Text & vbCrLf
'        invoiceText &= "Payment: " & cmbPayment.Text & vbCrLf
'        invoiceText &= "------------------------------" & vbCrLf

'        For Each row As DataRow In cart.Rows
'            invoiceText &= row("item_name").ToString() & vbCrLf
'            invoiceText &= "Qty: " & row("qty").ToString() &
'                       "  Price: " & CDec(row("unit_price")).ToString("N2") &
'                       "  Total: " & CDec(row("line_total")).ToString("N2") & vbCrLf
'            invoiceText &= "------------------------------" & vbCrLf
'        Next

'        invoiceText &= "Subtotal: Rs. " & txtSubtotal.Text & vbCrLf
'        invoiceText &= "Discount: Rs. " & txtDiscount.Text & vbCrLf
'        invoiceText &= "TOTAL: Rs. " & txtTotal.Text & vbCrLf

'        MessageBox.Show(invoiceText, "Invoice Preview", MessageBoxButtons.OK, MessageBoxIcon.Information)
'    End Sub

'    Private Sub btnInvoicePrint_Click(sender As Object, e As EventArgs) Handles btnInvoicePrint.Click

'        If cart.Rows.Count = 0 Then
'            MessageBox.Show("Cart is empty. Add items before printing invoice.", "Print Invoice",
'                        MessageBoxButtons.OK, MessageBoxIcon.Warning)
'            Return
'        End If

'        Try
'            invoiceToPrint = BuildInvoiceText()

'            Dim preview As New PrintPreviewDialog()
'            preview.Document = printDoc
'            preview.Width = 900
'            preview.Height = 700
'            preview.ShowDialog()

'        Catch ex As Exception
'            MessageBox.Show("Print invoice failed: " & ex.Message, "Print Invoice",
'                        MessageBoxButtons.OK, MessageBoxIcon.Error)
'        End Try
'    End Sub


'End Class
Imports System.Data
Imports MySql.Data.MySqlClient
Imports System.Drawing.Printing

Public Class SalesPOS

    Private cart As DataTable
    Private selectedItemId As Integer
    Private selectedPrice As Decimal
    Private selectedStock As Integer
    Private selectedTracksStock As Boolean

    Private invoiceToPrint As String = ""
    Private WithEvents printDoc As New PrintDocument()

    Private Sub SalesPOS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblTitle.Visible = False
        splitMain.Panel2MinSize = 340
        splitMain.Panel1MinSize = 300

        StylePosControls()
        InitCart()
        LoadCatalog()
        LoadCustomers()

        cmbPayment.Items.Clear()
        cmbPayment.Items.AddRange(New Object() {"Cash", "Card", "Bank Transfer", "Credit"})
        cmbPayment.SelectedIndex = 0

        txtDiscount.Text = "0"
        RecalcTotals()
        AdjustPosLayout()
    End Sub

    Private Sub SalesPOS_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        AdjustPosLayout()
    End Sub

    Private Sub StylePosControls()
        btnSearchItemPOS.FillColor = Color.FromArgb(255, 128, 0)
        btnSearchItemPOS.ForeColor = Color.White
        btnAddToCart.FillColor = Color.FromArgb(255, 128, 0)
        btnAddToCart.ForeColor = Color.White
        btnRemoveLine.FillColor = Color.FromArgb(220, 53, 69)
        btnRemoveLine.ForeColor = Color.White
        btnCompleteSale.FillColor = Color.FromArgb(255, 128, 0)
        btnCompleteSale.ForeColor = Color.White
        btnClearCart.FillColor = Color.FromArgb(255, 192, 128)
        btnClearCart.ForeColor = Color.Black
        btnGenerateInvoce.FillColor = Color.FromArgb(255, 128, 0)
        btnGenerateInvoce.ForeColor = Color.White
        btnInvoicePrint.FillColor = Color.FromArgb(255, 128, 0)
        btnInvoicePrint.ForeColor = Color.White

        dgvCatalog.AutoGenerateColumns = True
        dgvCatalog.ReadOnly = True
        dgvCatalog.RowHeadersVisible = False
        dgvCatalog.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvCatalog.EnableHeadersVisualStyles = False

        dgvCart.AutoGenerateColumns = True
        dgvCart.ReadOnly = True
        dgvCart.RowHeadersVisible = False
        dgvCart.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvCart.EnableHeadersVisualStyles = False
    End Sub

    Private Sub AdjustPosLayout()
        If splitMain.Width <= splitMain.Panel1MinSize + splitMain.Panel2MinSize + splitMain.SplitterWidth Then Return

        Dim preferredLeft = CInt(splitMain.Width * 0.56)
        Dim maxLeft = splitMain.Width - splitMain.Panel2MinSize - splitMain.SplitterWidth
        splitMain.SplitterDistance = Math.Max(splitMain.Panel1MinSize, Math.Min(preferredLeft, maxLeft))

        LayoutCustomerRow()
        LayoutCartArea()
        LayoutCheckoutArea()
    End Sub

    Private Sub LayoutCustomerRow()
        Dim w = grpCustomer.ClientSize.Width
        If w <= 0 Then Return

        Const pad As Integer = 16
        Const top As Integer = 46
        Const labelW As Integer = 78
        Const payComboW As Integer = 130
        Const payLabelW As Integer = 68

        lblCustomerPOS.SetBounds(pad, top + 4, labelW, 22)
        cmbPayment.SetBounds(w - pad - payComboW, top, payComboW, 36)
        lblPayment.SetBounds(cmbPayment.Left - payLabelW - 6, top + 4, payLabelW, 22)
        cmbCustomerPOS.SetBounds(pad + labelW + 6, top, lblPayment.Left - pad - labelW - 12, 36)
    End Sub

    Private Sub LayoutCartArea()
        Dim w = grpCart.ClientSize.Width
        Dim h = grpCart.ClientSize.Height
        If w <= 0 OrElse h <= 0 Then Return

        Const pad As Integer = 12

        lblQtyPOS.SetBounds(pad, 46, 36, 22)
        numQtyPOS.SetBounds(pad + 40, 42, 56, 36)
        btnAddToCart.SetBounds(pad + 104, 42, 118, 36)
        btnRemoveLine.SetBounds(pad + 228, 42, 118, 36)
        dgvCart.SetBounds(pad, 88, w - (pad * 2), h - 96)
    End Sub

    Private Sub LayoutCheckoutArea()
        Dim w = grpCheckout.ClientSize.Width
        If w <= 0 Then Return

        Const pad As Integer = 16
        Const row1 As Integer = 52
        Const row2 As Integer = 112

        lblSubtotal.SetBounds(pad, row1 + 4, 110, 22)
        txtSubtotal.SetBounds(pad + 116, row1, 120, 36)

        lblDiscount.SetBounds(pad + 250, row1 + 4, 100, 22)
        txtDiscount.SetBounds(pad + 354, row1, 100, 36)

        lblTotal.SetBounds(pad, row2 + 6, 110, 28)
        txtTotal.SetBounds(pad + 116, row2, 180, 40)

        btnClearCart.SetBounds(pad + 116, row2 + 56, 180, 44)
        btnGenerateInvoce.SetBounds(pad + 116, row2 + 110, 180, 44)

        btnCompleteSale.SetBounds(w - pad - 180, row2 + 56, 180, 44)
        btnInvoicePrint.SetBounds(w - pad - 180, row2 + 110, 180, 44)
    End Sub

    Private Sub InitCart()
        cart = New DataTable()
        cart.Columns.Add("item_id", GetType(Integer))
        cart.Columns.Add("item_name", GetType(String))
        cart.Columns.Add("qty", GetType(Integer))
        cart.Columns.Add("unit_price", GetType(Decimal))
        cart.Columns.Add("line_total", GetType(Decimal))
        dgvCart.DataSource = cart
        FormatCartGrid()
    End Sub

    Private Sub LoadCatalog()
        Try
            dgvCatalog.DataSource = ItemCRUD.LoadItems()
            FormatCatalogGrid()
        Catch ex As Exception
            MessageBox.Show("Catalog load error: " & ex.Message, "POS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Sub FormatCatalogGrid()
        If dgvCatalog.Columns.Count = 0 Then Return

        Dim showCols = New HashSet(Of String)(StringComparer.OrdinalIgnoreCase) From {
            "item_id", "item_code", "item_name", "item_type", "brand", "tyre_size",
            "quantity", "retail_price", "wholesale_price", "tracks_stock"
        }

        For Each col As DataGridViewColumn In dgvCatalog.Columns
            col.Visible = showCols.Contains(col.Name)
        Next

        If dgvCatalog.Columns.Contains("item_id") Then dgvCatalog.Columns("item_id").Visible = False
        If dgvCatalog.Columns.Contains("tracks_stock") Then dgvCatalog.Columns("tracks_stock").Visible = False

        SetHeader(dgvCatalog, "item_code", "Code")
        SetHeader(dgvCatalog, "item_name", "Product")
        SetHeader(dgvCatalog, "item_type", "Type")
        SetHeader(dgvCatalog, "brand", "Brand")
        SetHeader(dgvCatalog, "tyre_size", "Size")
        SetHeader(dgvCatalog, "quantity", "Stock")
        SetHeader(dgvCatalog, "retail_price", "Retail")
        SetHeader(dgvCatalog, "wholesale_price", "Wholesale")

        dgvCatalog.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
    End Sub

    Private Sub FormatCartGrid()
        If dgvCart.Columns.Count = 0 Then Return

        If dgvCart.Columns.Contains("item_id") Then dgvCart.Columns("item_id").Visible = False
        SetHeader(dgvCart, "item_name", "Product")
        SetHeader(dgvCart, "qty", "Qty")
        SetHeader(dgvCart, "unit_price", "Price")
        SetHeader(dgvCart, "line_total", "Total")

        dgvCart.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
    End Sub

    Private Sub SetHeader(grid As DataGridView, columnName As String, header As String)
        If grid.Columns.Contains(columnName) Then
            grid.Columns(columnName).HeaderText = header
        End If
    End Sub

    Private Sub LoadCustomers()
        cmbCustomerPOS.Items.Clear()
        cmbCustomerPOS.Items.Add(New ComboItem("Walk-in Customer", 0, "Retail"))

        Try
            For Each row As DataRow In CustomerCRUD.LoadCustomers().Rows
                Dim customerName As String = row("cus_name").ToString()

                If customerName.Equals("Walk-in Customer", StringComparison.OrdinalIgnoreCase) Then Continue For

                Dim cat As String = "Retail"

                If row.Table.Columns.Contains("price_category") Then
                    cat = row("price_category").ToString()
                ElseIf row.Table.Columns.Contains("cus_pricetyre") Then
                    cat = row("cus_pricetyre").ToString()
                End If

                If cat.Contains("Wholesale") Then cat = "Wholesale"
                If cat.Contains("Distributor") Then cat = "Distributor"
                If cat.Contains("Retail") OrElse cat = "" Then cat = "Retail"

                cmbCustomerPOS.Items.Add(New ComboItem(customerName, CInt(row("cus_id")), cat))
            Next

        Catch ex As Exception
            MessageBox.Show("Customer load error: " & ex.Message, "POS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try

        cmbCustomerPOS.DisplayMember = "Text"

        If cmbCustomerPOS.Items.Count > 0 Then
            cmbCustomerPOS.SelectedIndex = 0
        End If
    End Sub

    Private Sub btnSearchItemPOS_Click(sender As Object, e As EventArgs) Handles btnSearchItemPOS.Click
        Try
            dgvCatalog.DataSource = ItemCRUD.SearchItems(txtSearchItemPOS.Text.Trim())
            FormatCatalogGrid()
        Catch ex As Exception
            MessageBox.Show("Search error: " & ex.Message, "POS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Sub dgvCatalog_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCatalog.CellClick
        If e.RowIndex < 0 Then Return

        Dim r = dgvCatalog.Rows(e.RowIndex)

        selectedItemId = CInt(r.Cells("item_id").Value)
        selectedStock = CInt(r.Cells("quantity").Value)
        selectedTracksStock = (r.Cells("tracks_stock").Value.ToString() = "1")

        If GetCustomerCategory() = "Retail" Then
            selectedPrice = CDec(r.Cells("retail_price").Value)
        Else
            selectedPrice = CDec(r.Cells("wholesale_price").Value)
        End If

        If selectedPrice <= 0 Then
            selectedPrice = CDec(r.Cells("retail_price").Value)
        End If
    End Sub

    Private Function GetCustomerCategory() As String
        If cmbCustomerPOS.SelectedItem Is Nothing Then Return "Retail"
        Return DirectCast(cmbCustomerPOS.SelectedItem, ComboItem).Category
    End Function

    Private Sub btnAddToCart_Click(sender As Object, e As EventArgs) Handles btnAddToCart.Click
        If selectedItemId = 0 Then
            MessageBox.Show("Select a product from the catalog.", "POS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim qty As Integer

        If Not Integer.TryParse(numQtyPOS.Text, qty) OrElse qty <= 0 Then
            MessageBox.Show("Enter valid quantity.", "POS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If selectedTracksStock AndAlso qty > selectedStock Then
            MessageBox.Show("Not enough stock available.", "POS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        For Each row As DataRow In cart.Rows
            If CInt(row("item_id")) = selectedItemId Then
                Dim newQty As Integer = CInt(row("qty")) + qty

                If selectedTracksStock AndAlso newQty > selectedStock Then
                    MessageBox.Show("Not enough stock available.", "POS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Return
                End If

                row("qty") = newQty
                row("line_total") = newQty * CDec(row("unit_price"))
                RecalcTotals()
                Return
            End If
        Next

        Dim name As String = dgvCatalog.CurrentRow.Cells("item_name").Value.ToString()
        cart.Rows.Add(selectedItemId, name, qty, selectedPrice, qty * selectedPrice)

        FormatCartGrid()
        RecalcTotals()
    End Sub

    Private Sub btnRemoveLine_Click(sender As Object, e As EventArgs) Handles btnRemoveLine.Click
        If dgvCart.CurrentRow Is Nothing Then Return

        cart.Rows.RemoveAt(dgvCart.CurrentRow.Index)
        RecalcTotals()
    End Sub

    Private Sub btnClearCart_Click(sender As Object, e As EventArgs) Handles btnClearCart.Click
        cart.Rows.Clear()
        txtDiscount.Text = "0"
        RecalcTotals()
    End Sub

    Private Sub RecalcTotals()
        If cart Is Nothing Then Exit Sub

        Dim subtotal As Decimal = 0

        For Each row As DataRow In cart.Rows
            subtotal += CDec(row("line_total"))
        Next

        Dim discount As Decimal = 0
        Decimal.TryParse(txtDiscount.Text, discount)

        If discount > subtotal Then discount = subtotal
        If discount < 0 Then discount = 0

        txtSubtotal.Text = subtotal.ToString("N2")
        txtTotal.Text = (subtotal - discount).ToString("N2")
    End Sub

    Private Sub txtDiscount_TextChanged(sender As Object, e As EventArgs) Handles txtDiscount.TextChanged
        RecalcTotals()
    End Sub

    Private Function GetInvoicePrefix() As String
        Dim invoicePrefix As String = "INV"

        Try
            Using conn As MySqlConnection = GetConnection()
                Dim sql As String = "SELECT invoice_prefix FROM shop_settings WHERE setting_id = 1"

                Using cmd As New MySqlCommand(sql, conn)
                    Dim result = cmd.ExecuteScalar()

                    If result IsNot Nothing AndAlso result IsNot DBNull.Value Then
                        invoicePrefix = result.ToString()
                    End If
                End Using
            End Using
        Catch
        End Try

        Return invoicePrefix
    End Function

    Private Sub btnCompleteSale_Click(sender As Object, e As EventArgs) Handles btnCompleteSale.Click
        If cart.Rows.Count = 0 Then
            MessageBox.Show("Cart is empty.", "POS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim subtotal As Decimal = 0
        Decimal.TryParse(txtSubtotal.Text, subtotal)

        Dim discount As Decimal = 0
        Decimal.TryParse(txtDiscount.Text, discount)

        Dim totalAmount As Decimal = 0
        Decimal.TryParse(txtTotal.Text, totalAmount)

        If discount < 0 OrElse discount > subtotal OrElse totalAmount < 0 Then
            MessageBox.Show("Invalid discount or total amount.", "POS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim customer = DirectCast(cmbCustomerPOS.SelectedItem, ComboItem)
        Dim invoiceNo As String = GetInvoicePrefix() & "-" & DateTime.Now.ToString("yyyyMMddHHmmss")

        Using conn As MySqlConnection = GetConnection()

            If conn.State <> ConnectionState.Open Then
                MessageBox.Show("Database connection failed.", "POS", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            Dim trans = conn.BeginTransaction()

            Try
                Dim saleSql As String =
                    "INSERT INTO sales " &
                    "(invoice_no, sale_date, cus_id, user_id, subtotal, discount_amount, discount_pct, total_amount, payment_method, notes, status) " &
                    "VALUES (@invoice_no, NOW(), @cus_id, @user_id, @subtotal, @discount_amount, @discount_pct, @total_amount, @payment_method, @notes, 'Completed'); " &
                    "SELECT LAST_INSERT_ID();"

                Dim saleId As Integer

                Using saleCmd As New MySqlCommand(saleSql, conn, trans)
                    saleCmd.Parameters.AddWithValue("@invoice_no", invoiceNo)

                    If customer.Id = 0 Then
                        saleCmd.Parameters.AddWithValue("@cus_id", DBNull.Value)
                    Else
                        saleCmd.Parameters.AddWithValue("@cus_id", customer.Id)
                    End If

                    saleCmd.Parameters.AddWithValue("@user_id", 1)
                    saleCmd.Parameters.AddWithValue("@subtotal", subtotal)
                    saleCmd.Parameters.AddWithValue("@discount_amount", discount)
                    saleCmd.Parameters.AddWithValue("@discount_pct", 0)
                    saleCmd.Parameters.AddWithValue("@total_amount", totalAmount)
                    saleCmd.Parameters.AddWithValue("@payment_method", cmbPayment.Text)
                    saleCmd.Parameters.AddWithValue("@notes", "")

                    saleId = Convert.ToInt32(saleCmd.ExecuteScalar())
                End Using

                For Each row As DataRow In cart.Rows

                    Using detailCmd As New MySqlCommand(
                        "INSERT INTO sale_items (sale_id, item_id, qty, unit_price, line_total) " &
                        "VALUES (@sale_id, @item_id, @qty, @unit_price, @line_total)", conn, trans)

                        detailCmd.Parameters.AddWithValue("@sale_id", saleId)
                        detailCmd.Parameters.AddWithValue("@item_id", row("item_id"))
                        detailCmd.Parameters.AddWithValue("@qty", row("qty"))
                        detailCmd.Parameters.AddWithValue("@unit_price", row("unit_price"))
                        detailCmd.Parameters.AddWithValue("@line_total", row("line_total"))
                        detailCmd.ExecuteNonQuery()
                    End Using

                    Using stockCmd As New MySqlCommand(
                        "UPDATE items SET quantity = quantity - @qty, updated_at = NOW() " &
                        "WHERE item_id = @item_id AND tracks_stock = 1", conn, trans)

                        stockCmd.Parameters.AddWithValue("@qty", row("qty"))
                        stockCmd.Parameters.AddWithValue("@item_id", row("item_id"))
                        stockCmd.ExecuteNonQuery()
                    End Using

                Next

                trans.Commit()

                MessageBox.Show("Sale completed successfully." & vbCrLf &
                                "Invoice No: " & invoiceNo,
                                "POS",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information)

                btnClearCart.PerformClick()
                LoadCatalog()
                RefreshDashboardIfOpen()

            Catch ex As Exception
                trans.Rollback()

                MessageBox.Show("Sale failed: " & ex.Message,
                                "POS",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error)
            End Try
        End Using
    End Sub

    Private Function BuildInvoiceText() As String
        Dim shopName As String = "S & N Tyre Center"
        Dim shopPhone As String = ""
        Dim shopAddress As String = ""
        Dim invoicePrefix As String = "INV"

        Try
            Using conn As MySqlConnection = GetConnection()
                Dim sql As String =
                    "SELECT shop_name, shop_phone, shop_address, invoice_prefix " &
                    "FROM shop_settings WHERE setting_id = 1"

                Using cmd As New MySqlCommand(sql, conn)
                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        If reader.Read() Then
                            shopName = reader("shop_name").ToString()
                            shopPhone = reader("shop_phone").ToString()
                            shopAddress = reader("shop_address").ToString()
                            invoicePrefix = reader("invoice_prefix").ToString()
                        End If
                    End Using
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Could not load shop settings: " & ex.Message,
                            "Invoice",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning)
        End Try

        Dim invoiceNo As String = invoicePrefix & "-" & DateTime.Now.ToString("yyyyMMddHHmmss")

        Dim txt As String = ""

        txt &= "========================================" & vbCrLf
        txt &= "      " & shopName & vbCrLf
        txt &= "========================================" & vbCrLf
        txt &= "Address : " & shopAddress & vbCrLf
        txt &= "Phone   : " & shopPhone & vbCrLf
        txt &= vbCrLf
        txt &= "Invoice No : " & invoiceNo & vbCrLf
        txt &= "Date       : " & DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") & vbCrLf
        txt &= "Customer   : " & cmbCustomerPOS.Text & vbCrLf
        txt &= "Payment    : " & cmbPayment.Text & vbCrLf
        txt &= vbCrLf
        txt &= "----------------------------------------" & vbCrLf

        For Each row As DataRow In cart.Rows
            txt &= row("item_name").ToString() & vbCrLf
            txt &= "Qty: " & row("qty").ToString() &
                   "  Price: Rs." & CDec(row("unit_price")).ToString("N2") &
                   "  Total: Rs." & CDec(row("line_total")).ToString("N2") & vbCrLf
            txt &= "----------------------------------------" & vbCrLf
        Next

        txt &= "Subtotal : Rs. " & txtSubtotal.Text & vbCrLf
        txt &= "Discount : Rs. " & txtDiscount.Text & vbCrLf
        txt &= "TOTAL    : Rs. " & txtTotal.Text & vbCrLf
        txt &= vbCrLf
        txt &= "Thank You For Your Purchase"

        Return txt
    End Function

    Private Sub btnGenerateInvoce_Click(sender As Object, e As EventArgs) Handles btnGenerateInvoce.Click
        If cart.Rows.Count = 0 Then
            MessageBox.Show("Cart is empty. Add items before generating invoice.",
                            "Invoice",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning)
            Return
        End If

        MessageBox.Show(BuildInvoiceText(),
                        "Invoice Preview",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information)
    End Sub

    Private Sub btnInvoicePrint_Click(sender As Object, e As EventArgs) Handles btnInvoicePrint.Click
        If cart.Rows.Count = 0 Then
            MessageBox.Show("Cart is empty. Add items before printing invoice.",
                            "Print Invoice",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning)
            Return
        End If

        Try
            invoiceToPrint = BuildInvoiceText()

            Dim preview As New PrintPreviewDialog()
            preview.Document = printDoc
            preview.Width = 900
            preview.Height = 700
            preview.ShowDialog()

        Catch ex As Exception
            MessageBox.Show("Print invoice failed: " & ex.Message,
                            "Print Invoice",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub printDoc_PrintPage(sender As Object,
                                   e As PrintPageEventArgs) Handles printDoc.PrintPage

        Dim f As New Font("Consolas", 10)

        e.Graphics.DrawString(invoiceToPrint,
                              f,
                              Brushes.Black,
                              20,
                              20)
    End Sub

    Private Sub RefreshDashboardIfOpen()
        Dim p = Me.Parent

        While p IsNot Nothing
            If TypeOf p Is MainMenu Then
                For Each ctrl As Control In DirectCast(p, MainMenu).Controls
                    FindDashboardAndRefresh(ctrl)
                Next

                Exit While
            End If

            p = p.Parent
        End While
    End Sub

    Private Sub FindDashboardAndRefresh(ctrl As Control)
        If TypeOf ctrl Is Dashboard Then
            DirectCast(ctrl, Dashboard).LoadDashboardData()
        End If

        For Each child As Control In ctrl.Controls
            FindDashboardAndRefresh(child)
        Next
    End Sub

    Private Class ComboItem
        Public Property Text As String
        Public Property Id As Integer
        Public Property Category As String

        Public Sub New(t As String, id As Integer, cat As String)
            Text = t
            Me.Id = id
            Category = cat
        End Sub

        Public Overrides Function ToString() As String
            Return Text
        End Function
    End Class

End Class