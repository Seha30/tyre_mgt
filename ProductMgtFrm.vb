Public Class ProductMgtFrm

    Private Sub ProductMgtFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UiThemeHelper.StyleGroupBox(grpDetails)
        UiThemeHelper.StyleGroupBox(grpList)
        UiThemeHelper.StylePrimaryButton(btnAddProduct)
        UiThemeHelper.StylePrimaryButton(btnUpdateProduct)
        UiThemeHelper.StylePrimaryButton(btnSearchProduct)
        UiThemeHelper.StyleDangerButton(btnDeleteProduct)
        UiThemeHelper.StyleSecondaryButton(btnClearProduct)
        UiThemeHelper.ApplyGridTheme(dgvProducts)
        cmbItemType.Items.Clear()
        cmbItemType.Items.AddRange(New Object() {"Tyre", "Tube", "Service", "Accessory"})
        cmbItemType.SelectedIndex = 0
        LoadProducts()
    End Sub

    Private Sub LoadProducts()
        Try
            dgvProducts.DataSource = ItemCRUD.LoadItems()
        Catch ex As Exception
            dgvProducts.DataSource = Nothing
        End Try
    End Sub

    Private Sub ClearForm()
        txtItemId.Clear()
        txtItemCode.Clear()
        txtItemName.Clear()
        txtBrand.Clear()
        txtTyreSize.Clear()
        numRetailPrice.Clear()
        numWholesalePrice.Clear()
        numQuantity.Clear()
        numReorder.Text = "5"
        cmbItemType.SelectedIndex = 0
    End Sub

    Private Function ParseDec(tb As Guna.UI2.WinForms.Guna2TextBox) As Decimal
        Dim d As Decimal
        Decimal.TryParse(tb.Text.Trim(), d)
        Return d
    End Function

    Private Function ParseInt(tb As Guna.UI2.WinForms.Guna2TextBox) As Integer
        Dim i As Integer
        Integer.TryParse(tb.Text.Trim(), i)
        Return i
    End Function

    Private Sub btnAddProduct_Click(sender As Object, e As EventArgs) Handles btnAddProduct.Click
        Dim v = ValidationHelper.ValidateItem(txtItemName.Text, cmbItemType.Text, ParseDec(numRetailPrice), ParseDec(numWholesalePrice), ParseInt(numQuantity), ParseInt(numReorder))
        If Not ValidationHelper.ShowIfInvalid(v) Then Return
        v = ValidationHelper.ValidateItemCode(txtItemCode.Text)
        If Not ValidationHelper.ShowIfInvalid(v) Then Return
        Try
            ItemCRUD.AddItem(txtItemCode.Text.Trim(), txtItemName.Text.Trim(), cmbItemType.Text, txtBrand.Text.Trim(), txtTyreSize.Text.Trim(), ParseDec(numRetailPrice), ParseDec(numWholesalePrice), ParseInt(numQuantity), ParseInt(numReorder))
            MessageBox.Show("Product added.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ClearForm()
            LoadProducts()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnUpdateProduct_Click(sender As Object, e As EventArgs) Handles btnUpdateProduct.Click
        If String.IsNullOrWhiteSpace(txtItemId.Text) Then
            MessageBox.Show("Select a product from the list.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        Dim v = ValidationHelper.ValidateItem(txtItemName.Text, cmbItemType.Text, ParseDec(numRetailPrice), ParseDec(numWholesalePrice), ParseInt(numQuantity), ParseInt(numReorder))
        If Not ValidationHelper.ShowIfInvalid(v) Then Return
        Try
            ItemCRUD.UpdateItem(CInt(txtItemId.Text), txtItemCode.Text.Trim(), txtItemName.Text.Trim(), cmbItemType.Text, txtBrand.Text.Trim(), txtTyreSize.Text.Trim(), ParseDec(numRetailPrice), ParseDec(numWholesalePrice), ParseInt(numQuantity), ParseInt(numReorder))
            MessageBox.Show("Product updated.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            LoadProducts()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnDeleteProduct_Click(sender As Object, e As EventArgs) Handles btnDeleteProduct.Click
        If String.IsNullOrWhiteSpace(txtItemId.Text) Then Return
        If MessageBox.Show("Delete this product?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) <> DialogResult.Yes Then Return
        Try
            ItemCRUD.DeleteItem(CInt(txtItemId.Text))
            ClearForm()
            LoadProducts()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnClearProduct_Click(sender As Object, e As EventArgs) Handles btnClearProduct.Click
        ClearForm()
    End Sub

    Private Sub btnSearchProduct_Click(sender As Object, e As EventArgs) Handles btnSearchProduct.Click
        dgvProducts.DataSource = ItemCRUD.SearchItems(txtSearchProduct.Text.Trim())
    End Sub

    Private Sub txtSearchProduct_TextChanged(sender As Object, e As EventArgs) Handles txtSearchProduct.TextChanged
        If txtSearchProduct.Text.Trim() = "" Then LoadProducts()
    End Sub

    Private Sub dgvProducts_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvProducts.CellClick
        If e.RowIndex < 0 Then Return
        Dim r = dgvProducts.Rows(e.RowIndex)
        txtItemId.Text = CellVal(r, "item_id")
        txtItemCode.Text = CellVal(r, "item_code")
        txtItemName.Text = CellVal(r, "item_name")
        cmbItemType.Text = CellVal(r, "item_type")
        txtBrand.Text = CellVal(r, "brand")
        txtTyreSize.Text = CellVal(r, "tyre_size")
        numRetailPrice.Text = CellVal(r, "retail_price")
        numWholesalePrice.Text = CellVal(r, "wholesale_price")
        numQuantity.Text = CellVal(r, "quantity")
        numReorder.Text = CellVal(r, "reorder_level")
    End Sub

    Private Function CellVal(r As DataGridViewRow, col As String) As String
        If dgvProducts.Columns.Contains(col) AndAlso r.Cells(col).Value IsNot Nothing Then
            Return r.Cells(col).Value.ToString()
        End If
        Return ""
    End Function

End Class
