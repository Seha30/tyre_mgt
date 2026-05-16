Public Class AddSupplierMgt

    Private Sub AddSupplierMgt_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UiThemeHelper.StyleGroupBox(grpDetails)
        UiThemeHelper.StyleGroupBox(grpList)
        UiThemeHelper.StylePrimaryButton(btnAddSup)
        UiThemeHelper.StylePrimaryButton(btnUpdateSup)
        UiThemeHelper.StylePrimaryButton(btnSearchSup)
        UiThemeHelper.StyleDangerButton(btnDeleteSup)
        UiThemeHelper.StyleSecondaryButton(btnClearSup)
        UiThemeHelper.ApplyGridTheme(dgvSuppliers)
        LoadGrid()
    End Sub

    Private Sub LoadGrid()
        Try
            dgvSuppliers.DataSource = SupplierCRUD.LoadSuppliers()
        Catch
        End Try
    End Sub

    Private Sub ClearForm()
        txtSupId.Clear()
        txtSupName.Clear()
        txtCompany.Clear()
        txtSupPhone.Clear()
        txtSupEmail.Clear()
        txtSupAddress.Clear()
    End Sub

    Private Sub btnAddSup_Click(sender As Object, e As EventArgs) Handles btnAddSup.Click
        Dim v = ValidationHelper.RequireText(txtSupName.Text, "Supplier name", 100)
        If Not ValidationHelper.ShowIfInvalid(v) Then Return
        v = ValidationHelper.ValidatePhone(txtSupPhone.Text)
        If Not ValidationHelper.ShowIfInvalid(v) Then Return
        v = ValidationHelper.ValidateEmail(txtSupEmail.Text)
        If Not ValidationHelper.ShowIfInvalid(v) Then Return
        Try
            SupplierCRUD.AddSupplier(txtSupName.Text.Trim(), txtCompany.Text.Trim(), txtSupPhone.Text.Trim(), txtSupEmail.Text.Trim(), txtSupAddress.Text.Trim())
            MessageBox.Show("Supplier added.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ClearForm()
            LoadGrid()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnUpdateSup_Click(sender As Object, e As EventArgs) Handles btnUpdateSup.Click
        If String.IsNullOrWhiteSpace(txtSupId.Text) Then Return
        Try
            SupplierCRUD.UpdateSupplier(CInt(txtSupId.Text), txtSupName.Text.Trim(), txtCompany.Text.Trim(), txtSupPhone.Text.Trim(), txtSupEmail.Text.Trim(), txtSupAddress.Text.Trim())
            MessageBox.Show("Supplier updated.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            LoadGrid()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnDeleteSup_Click(sender As Object, e As EventArgs) Handles btnDeleteSup.Click
        If String.IsNullOrWhiteSpace(txtSupId.Text) Then Return
        If MessageBox.Show("Delete supplier?", "Confirm", MessageBoxButtons.YesNo) <> DialogResult.Yes Then Return
        SupplierCRUD.DeleteSupplier(CInt(txtSupId.Text))
        ClearForm()
        LoadGrid()
    End Sub

    Private Sub btnClearSup_Click(sender As Object, e As EventArgs) Handles btnClearSup.Click
        ClearForm()
    End Sub

    Private Sub btnSearchSup_Click(sender As Object, e As EventArgs) Handles btnSearchSup.Click
        dgvSuppliers.DataSource = SupplierCRUD.SearchSuppliers(txtSearchSup.Text.Trim())
    End Sub

    Private Sub dgvSuppliers_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSuppliers.CellClick
        If e.RowIndex < 0 Then Return
        Dim r = dgvSuppliers.Rows(e.RowIndex)
        txtSupId.Text = SafeCell(r, "sup_id")
        txtSupName.Text = SafeCell(r, "sup_name")
        txtCompany.Text = SafeCell(r, "sup_company")
        txtSupPhone.Text = SafeCell(r, "sup_phone")
        txtSupEmail.Text = SafeCell(r, "sup_email")
        txtSupAddress.Text = SafeCell(r, "sup_address")
    End Sub

    Private Function SafeCell(r As DataGridViewRow, col As String) As String
        If dgvSuppliers.Columns.Contains(col) AndAlso r.Cells(col).Value IsNot Nothing Then Return r.Cells(col).Value.ToString()
        Return ""
    End Function

End Class
