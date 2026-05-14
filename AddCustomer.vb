Public Class AddCustomer
    Private Sub AddCustomer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbcustomerType.Items.Add("Retail (normal price)")
        cmbcustomerType.Items.Add("Wholesale (wholesale price if set)")
        cmbcustomerType.Items.Add("Distributor (wholesale price if set)")

    End Sub

    Private Sub btnAddCustomerCusfrm_Click(sender As Object, e As EventArgs) Handles btnAddCustomerCusfrm.Click
        ' --- Validation checks ---
        If String.IsNullOrWhiteSpace(txtcustomerName.Text) Then
            MessageBox.Show("Customer name is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtcustomerName.Focus()
            Exit Sub
        End If

        If String.IsNullOrWhiteSpace(txtcustomerPhone.Text) OrElse txtcustomerPhone.Text.Length <> 10 OrElse Not IsNumeric(txtcustomerPhone.Text) Then
            MessageBox.Show("Phone number must be 10 digits.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtcustomerPhone.Focus()
            Exit Sub
        End If

        If String.IsNullOrWhiteSpace(txtcustomerEmail.Text) OrElse Not txtcustomerEmail.Text.Contains("@") Then
            MessageBox.Show("Please enter a valid email address.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtcustomerEmail.Focus()
            Exit Sub
        End If

        If String.IsNullOrWhiteSpace(txtcustomerAddress.Text) Then
            MessageBox.Show("Address is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtcustomerAddress.Focus()
            Exit Sub
        End If

        If String.IsNullOrWhiteSpace(cmbcustomerType.Text) Then
            MessageBox.Show("Please select a customer type.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            cmbcustomerType.Focus()
            Exit Sub
        End If
        ' --- If all validations pass, save customer ---

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
End Class