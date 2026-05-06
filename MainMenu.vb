Imports System.Web.Configuration

Public Class MainMenu

    Private Sub HighlightButton(activeBtn As Guna.UI2.WinForms.Guna2Button)
        ' Reset all buttons in the sidebar back to default
        For Each ctrl As Control In pnlSidebarPanel.Controls
            If TypeOf ctrl Is Guna.UI2.WinForms.Guna2Button Then
                Dim btn = DirectCast(ctrl, Guna.UI2.WinForms.Guna2Button)
                btn.FillColor = Color.Orange   ' default color
                btn.ForeColor = Color.Black    ' default text color
            End If
        Next

        ' Highlight the active button
        activeBtn.FillColor = Color.Gray
        activeBtn.ForeColor = Color.White
    End Sub

    Private Sub btnCustomer_mgt_Click(sender As Object, e As EventArgs) Handles btnCustomer_mgt.Click
        LoadFormIntoPanel(New AddCustomer())
        HighlightButton(btnCustomer_mgt)   ' highlight this button
    End Sub
    Private Sub LoadFormIntoPanel(frm As Form)
        pnlContent.Controls.Clear()
        frm.TopLevel = False
        frm.FormBorderStyle = FormBorderStyle.None
        frm.Dock = DockStyle.Fill
        pnlContent.Controls.Add(frm)
        frm.Show()

        ' Update top panel label
        lblFormTitle.Text = "Customer Management"






    End Sub

    Private Sub btnDashboardMmenu_Click(sender As Object, e As EventArgs) Handles btnDashboardMmenu.Click
        HighlightButton(btnDashboardMmenu) ' highlight this button



        ' Update top panel label
        lblFormTitle.Text = "Dashboard"

    End Sub

    Private Sub btnProjectMgtMmenu_Click(sender As Object, e As EventArgs) Handles btnProjectMgtMmenu.Click

        HighlightButton(btnProjectMgtMmenu) ' highlight this button






        ' Update top panel label
        lblFormTitle.Text = "Product Management"

    End Sub

    Private Sub btnStaffMgtMmenu_Click(sender As Object, e As EventArgs) Handles btnStaffMgtMmenu.Click

        HighlightButton(btnStaffMgtMmenu) ' highlight this button

        ' Update top panel label
        lblFormTitle.Text = "Staff Management"

    End Sub

    Private Sub btnSalesPOSMmenu_Click(sender As Object, e As EventArgs) Handles btnSalesPOSMmenu.Click

        HighlightButton(btnSalesPOSMmenu) ' highlight this button

        ' Update top panel label
        lblFormTitle.Text = "Sales (POS)"
    End Sub

    Private Sub btnInventoryMgtMmenu_Click(sender As Object, e As EventArgs) Handles btnInventoryMgtMmenu.Click

        HighlightButton(btnInventoryMgtMmenu) ' highlight this button


        ' Update top panel label
        lblFormTitle.Text = "Inventory Management"
    End Sub
End Class