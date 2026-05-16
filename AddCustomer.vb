Imports Microsoft.VisualBasic.ApplicationServices

Public Class AddCustomer
    Private Sub AddCustomer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UiThemeHelper.StyleGroupBox(Guna2GroupBox1)
        UiThemeHelper.StyleGroupBox(Guna2GroupBox2)
        UiThemeHelper.StylePrimaryButton(btnAddCustomerCusfrm)
        UiThemeHelper.StylePrimaryButton(btnUpdateCustomerCusfrm)
        UiThemeHelper.StylePrimaryButton(btnSearchCustomer)
        UiThemeHelper.StyleDangerButton(btnDeleteCustomerCusfrm)
        UiThemeHelper.ApplyGridTheme(dgvCustomers)
        cmbcustomerType.Items.Clear()
        cmbcustomerType.Items.AddRange(New Object() {"Retail", "Wholesale", "Distributor"})
        Guna2GroupBox1.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        Guna2GroupBox2.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        dgvCustomers.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
    End Sub

    Private Sub btnAddCustomerCusfrm_Click(sender As Object, e As EventArgs) Handles btnAddCustomerCusfrm.Click
        Dim v = ValidationHelper.ValidateCustomer(txtcustomerName.Text, txtcustomerPhone.Text, txtcustomerEmail.Text, txtcustomerAddress.Text, cmbcustomerType.Text)
        If Not ValidationHelper.ShowIfInvalid(v) Then Return

        Try
            CustomerCRUD.AddCustomer(txtcustomerName.Text,
                                     txtcustomerPhone.Text,
                                     txtcustomerEmail.Text,
                                     txtcustomerAddress.Text,
                                     cmbcustomerType.Text)

            MessageBox.Show("Customer added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ' Refresh grid
            dgvCustomers.DataSource = CustomerCRUD.LoadCustomers()
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub AddCustomerFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvCustomers.DataSource = CustomerCRUD.LoadCustomers()
    End Sub

    Private Sub btnUpdateCustomerCusfrm_Click(sender As Object, e As EventArgs) Handles btnUpdateCustomerCusfrm.Click
        ' Collect values from form
        Dim cusName As String = txtcustomerName.Text
        Dim cusPhone As String = txtcustomerPhone.Text
        Dim cusEmail As String = txtcustomerEmail.Text
        Dim cusAddress As String = txtcustomerAddress.Text
        Dim cusPriceType As String = cmbcustomerType.Text

        ' --- Validation ---
        If String.IsNullOrWhiteSpace(cusName) OrElse
           String.IsNullOrWhiteSpace(cusPhone) OrElse
           String.IsNullOrWhiteSpace(cusEmail) OrElse
           String.IsNullOrWhiteSpace(cusAddress) OrElse
           String.IsNullOrWhiteSpace(cusPriceType) Then

            MessageBox.Show("Please fill all the fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Try
            ' Get the selected customer ID from hidden textbox or grid
            Dim cus_id As Integer = Convert.ToInt32(txtCustomerID.Text)

            ' Call update method in CustomerCRUD with all required parameters
            CustomerCRUD.UpdateCustomer(cus_id,
                                        cusName,
                                        cusPhone,
                                        cusEmail,
                                        cusAddress,
                                        cusPriceType)

            MessageBox.Show("Customer updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ' Refresh grid
            dgvCustomers.DataSource = CustomerCRUD.LoadCustomers()

            ' Clear fields
            txtCustomerID.Text = ""
            txtcustomerName.Text = ""
            txtcustomerPhone.Text = ""
            txtcustomerEmail.Text = ""
            txtcustomerAddress.Text = ""
            cmbcustomerType.Text = ""
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub dgvCustomers_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCustomers.CellContentClick

        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = dgvCustomers.Rows(e.RowIndex)
            txtCustomerID.Text = row.Cells("cus_id").Value.ToString()
            txtcustomerName.Text = row.Cells("cus_name").Value.ToString()
            txtcustomerPhone.Text = row.Cells("cus_phone").Value.ToString()
            txtcustomerEmail.Text = row.Cells("cus_email").Value.ToString()
            txtcustomerAddress.Text = row.Cells("cus_address").Value.ToString()
            If dgvCustomers.Columns.Contains("price_category") Then
                cmbcustomerType.Text = row.Cells("price_category").Value.ToString()
            Else
                Dim pt = row.Cells("cus_pricetyre").Value.ToString()
                If pt.Contains("Wholesale") Then
                    cmbcustomerType.Text = "Wholesale"
                ElseIf pt.Contains("Distributor") Then
                    cmbcustomerType.Text = "Distributor"
                Else
                    cmbcustomerType.Text = "Retail"
                End If
            End If
        End If

    End Sub

    Private Sub btnDeleteCustomerCusfrm_Click(sender As Object, e As EventArgs) Handles btnDeleteCustomerCusfrm.Click

        Dim cus_id As Integer = Convert.ToInt32(txtCustomerID.Text)
        If MessageBox.Show("Are you sure you want to delete this customer?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            CustomerCRUD.DeleteCustomer(cus_id)
            MessageBox.Show("Customer deleted successfully!")
            dgvCustomers.DataSource = CustomerCRUD.LoadCustomers()
        End If
    End Sub



    Private Sub txtsearchcustomer_TextChanged(sender As Object, e As EventArgs) Handles txtsearchcustomer.TextChanged
        dgvCustomers.DataSource = CustomerCRUD.SearchCustomers(txtsearchcustomer.Text.Trim())
    End Sub

    Private Sub btnSearchCustomer_Click(sender As Object, e As EventArgs) Handles btnSearchCustomer.Click
        Dim keyword As String = txtsearchcustomer.Text.Trim()

        If keyword = "" Then
            ' If empty, reload all customers
            dgvCustomers.DataSource = CustomerCRUD.LoadCustomers()
        Else
            dgvCustomers.DataSource = CustomerCRUD.SearchCustomers(keyword)
        End If
    End Sub
End Class