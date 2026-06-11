Public Class InventoryMgtFrm

    Private selectedItemId As Integer = -1

    Private Sub InventoryMgtFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'UiThemeHelper.StyleGroupBox(grpAdjust)
        'UiThemeHelper.StyleGroupBox(grpStock)
        'UiThemeHelper.StylePrimaryButton(btnApplyAdjustment)
        'UiThemeHelper.StylePrimaryButton(btnSearchStock)
        'UiThemeHelper.StylePrimaryButton(btnRefreshStock)
        'UiThemeHelper.ApplyGridTheme(dgvStock)
        cmbReason.Items.AddRange(New Object() {"Purchase", "Damage", "Return", "Correction", "Other"})
        cmbReason.SelectedIndex = 0
        LoadStock()
    End Sub

    Private Sub LoadStock()
        Try
            Dim dt = ItemCRUD.LoadItems()
            If chkLowStockOnly.Checked Then
                Dim filtered = dt.Clone()
                For Each row As DataRow In dt.Rows
                    If CInt(row("tracks_stock")) = 1 AndAlso CInt(row("quantity")) <= CInt(row("reorder_level")) Then
                        filtered.ImportRow(row)
                    End If
                Next
                dgvStock.DataSource = filtered
            Else
                dgvStock.DataSource = dt
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Inventory", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Sub dgvStock_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvStock.CellClick
        If e.RowIndex < 0 Then Return
        selectedItemId = CInt(dgvStock.Rows(e.RowIndex).Cells("item_id").Value)
        lblSelectedItem.Text = "Selected: " & dgvStock.Rows(e.RowIndex).Cells("item_code").Value.ToString() & " - " & dgvStock.Rows(e.RowIndex).Cells("item_name").Value.ToString()
    End Sub

    Private Sub btnSearchStock_Click(sender As Object, e As EventArgs) Handles btnSearchStock.Click
        dgvStock.DataSource = ItemCRUD.SearchItems(txtSearchStock.Text.Trim())
    End Sub

    Private Sub btnRefreshStock_Click(sender As Object, e As EventArgs) Handles btnRefreshStock.Click
        txtSearchStock.Clear()
        LoadStock()
    End Sub

    Private Sub chkLowStockOnly_CheckedChanged(sender As Object, e As EventArgs) Handles chkLowStockOnly.CheckedChanged
        LoadStock()
    End Sub

    Private Sub btnApplyAdjustment_Click(sender As Object, e As EventArgs) Handles btnApplyAdjustment.Click
        If selectedItemId < 0 Then
            MessageBox.Show("Select an item from the stock list.", "Inventory", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        Dim qty As Integer
        If Not Integer.TryParse(txtAdjQty.Text.Trim(), qty) OrElse qty = 0 Then
            MessageBox.Show("Enter adjustment quantity (+ receive, - remove).", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        MessageBox.Show("Adjustment recorded when stock_adjustments table is available.", "Inventory", MessageBoxButtons.OK, MessageBoxIcon.Information)
        LoadStock()
    End Sub


End Class
