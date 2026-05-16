Imports System.Data
Imports MySql.Data.MySqlClient

Public Class SalesPOS

    Private cart As DataTable
    Private selectedItemId As Integer
    Private selectedPrice As Decimal
    Private selectedStock As Integer
    Private selectedTracksStock As Boolean

    Private Sub SalesPOS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UiThemeHelper.ApplyGridTheme(dgvCatalog)
        UiThemeHelper.ApplyGridTheme(dgvCart)
        UiThemeHelper.StylePrimaryButton(btnAddToCart)
        UiThemeHelper.StylePrimaryButton(btnCompleteSale)
        UiThemeHelper.StylePrimaryButton(btnSearchItemPOS)
        UiThemeHelper.StyleDangerButton(btnRemoveLine)
        UiThemeHelper.StyleSecondaryButton(btnClearCart)
        InitCart()
        LoadCatalog()
        LoadCustomers()
        cmbPayment.Items.AddRange(New Object() {"Cash", "Card", "Bank Transfer", "Credit"})
        cmbPayment.SelectedIndex = 0
        RecalcTotals()
    End Sub

    Private Sub InitCart()
        cart = New DataTable()
        cart.Columns.Add("item_id", GetType(Integer))
        cart.Columns.Add("item_name", GetType(String))
        cart.Columns.Add("qty", GetType(Integer))
        cart.Columns.Add("unit_price", GetType(Decimal))
        cart.Columns.Add("line_total", GetType(Decimal))
        dgvCart.DataSource = cart
    End Sub

    Private Sub LoadCatalog()
        Try
            dgvCatalog.DataSource = ItemCRUD.LoadItems()
        Catch
        End Try
    End Sub

    Private Sub LoadCustomers()
        cmbCustomerPOS.Items.Clear()
        cmbCustomerPOS.Items.Add(New ComboItem("Walk-in Customer", 0, "Retail"))
        Try
            For Each row As DataRow In CustomerCRUD.LoadCustomers().Rows
                Dim cat = If(row.Table.Columns.Contains("price_category"), row("price_category").ToString(), row("cus_pricetyre").ToString())
                If cat.Contains("Wholesale") Then cat = "Wholesale"
                If cat.Contains("Distributor") Then cat = "Distributor"
                If cat.Contains("Retail") OrElse cat = "" Then cat = "Retail"
                cmbCustomerPOS.Items.Add(New ComboItem(row("cus_name").ToString(), CInt(row("cus_id")), cat))
            Next
        Catch
        End Try
        cmbCustomerPOS.DisplayMember = "Text"
        cmbCustomerPOS.SelectedIndex = 0
    End Sub

    Private Sub btnSearchItemPOS_Click(sender As Object, e As EventArgs) Handles btnSearchItemPOS.Click
        dgvCatalog.DataSource = ItemCRUD.SearchItems(txtSearchItemPOS.Text.Trim())
    End Sub

    Private Sub dgvCatalog_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCatalog.CellClick
        If e.RowIndex < 0 Then Return
        Dim r = dgvCatalog.Rows(e.RowIndex)
        selectedItemId = CInt(r.Cells("item_id").Value)
        selectedStock = CInt(r.Cells("quantity").Value)
        selectedTracksStock = (r.Cells("tracks_stock").Value.ToString() = "1")
        Dim cat = GetCustomerCategory()
        selectedPrice = If(cat = "Retail", CDec(r.Cells("retail_price").Value), CDec(r.Cells("wholesale_price").Value))
        If selectedPrice <= 0 Then selectedPrice = CDec(r.Cells("retail_price").Value)
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
        Dim v = ValidationHelper.ValidateSaleLine(qty, selectedPrice, selectedStock, selectedTracksStock)
        If Not ValidationHelper.ShowIfInvalid(v) Then Return
        Dim name = dgvCatalog.CurrentRow.Cells("item_name").Value.ToString()
        cart.Rows.Add(selectedItemId, name, qty, selectedPrice, qty * selectedPrice)
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
        Dim subtotal As Decimal = 0
        For Each row As DataRow In cart.Rows
            subtotal += CDec(row("line_total"))
        Next
        Dim disc As Decimal = 0
        Decimal.TryParse(txtDiscount.Text, disc)
        If disc > subtotal Then disc = subtotal
        txtSubtotal.Text = subtotal.ToString("N2")
        txtTotal.Text = (subtotal - disc).ToString("N2")
    End Sub

    Private Sub txtDiscount_TextChanged(sender As Object, e As EventArgs) Handles txtDiscount.TextChanged
        RecalcTotals()
    End Sub

    Private Sub btnCompleteSale_Click(sender As Object, e As EventArgs) Handles btnCompleteSale.Click
        If cart.Rows.Count = 0 Then
            MessageBox.Show("Cart is empty.", "POS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        MessageBox.Show("Sale saved when sales tables exist in database. Cart total: Rs. " & txtTotal.Text, "POS Demo", MessageBoxButtons.OK, MessageBoxIcon.Information)
        btnClearCart.PerformClick()
    End Sub

    Private Class ComboItem
        Public Property Text As String
        Public Property Id As Integer
        Public Property Category As String
        Public Sub New(t As String, id As Integer, cat As String)
            Text = t : Me.Id = id : Category = cat
        End Sub
        Public Overrides Function ToString() As String
            Return Text
        End Function
    End Class

End Class
