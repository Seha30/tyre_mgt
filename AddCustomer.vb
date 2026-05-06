Public Class AddCustomer
    Private Sub AddCustomer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbCustomerType.Items.Add("Retail (normal price)")
        cmbCustomerType.Items.Add("Wholesale (wholesale price if set)")
        cmbCustomerType.Items.Add("Distributor (wholesale price if set)")

    End Sub




End Class