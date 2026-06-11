Public Class MainMenu

    Public Property CurrentUser As String
    Public Property CurrentRole As String

    Private Sub HighlightButton(activeBtn As Guna.UI2.WinForms.Guna2Button)
        For Each ctrl As Control In pnlSidebarPanel.Controls
            If TypeOf ctrl Is Guna.UI2.WinForms.Guna2Button Then
                Dim btn = DirectCast(ctrl, Guna.UI2.WinForms.Guna2Button)
                If btn Is Guna2Button2 Then Continue For
                btn.FillColor = Color.FromArgb(255, 107, 0)
                btn.ForeColor = Color.Black
            End If
        Next
        If activeBtn IsNot Nothing Then
            activeBtn.FillColor = Color.Gray
            activeBtn.ForeColor = Color.White
        End If
    End Sub

    Public Sub OpenModule(frm As Form, title As String, Optional activeBtn As Guna.UI2.WinForms.Guna2Button = Nothing)
        pnlContent.Controls.Clear()
        frm.TopLevel = False
        frm.FormBorderStyle = FormBorderStyle.None
        frm.Dock = DockStyle.Fill
        pnlContent.Controls.Add(frm)
        frm.Show()
        lblFormTitle.Text = title
        HighlightButton(activeBtn)
    End Sub

    Public Sub RefreshWelcomeLabel(displayName As String)
        lblWelcome.Text = "Welcome, " & displayName & " (" & CurrentRole & ")"
    End Sub

    Private Function GetWelcomeDisplayName() As String
        Try
            Dim p = ProfileCRUD.GetProfileByUsername(CurrentUser)
            If p IsNot Nothing AndAlso Not String.IsNullOrWhiteSpace(p.FullName) Then
                Return p.FullName
            End If
        Catch
        End Try
        Return CurrentUser
    End Function

    Private Sub OpenProfileModule()
        Dim pf As New ProfileFrm()
        pf.LoggedInUsername = CurrentUser
        OpenModule(pf, "My Profile", Nothing)
    End Sub

    Private Sub MainMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'UiThemeHelper.StylePrimaryButton(btnMyProfile)
        lblFormTitle.Text = "Dashboard"
        RefreshWelcomeLabel(GetWelcomeDisplayName())
        btnDashboardMmenu.Visible = False
        btnProductMgtMmenu.Visible = False
        btnCustomer_mgt.Visible = False
        btnStaffMgtMmenu.Visible = False
        btnSupplierManagement.Visible = False
        btnSalesPOSMmenu.Visible = False
        btnInventoryMgtMmenu.Visible = False
        btnReportsMmenu.Visible = False
        btnSettingMmenu.Visible = False
        btnLogoutMmenu.Visible = True
        btnMyProfile.Visible = True

        Select Case CurrentRole
            Case "Admin"
                btnDashboardMmenu.Visible = True
                btnProductMgtMmenu.Visible = True
                btnCustomer_mgt.Visible = True
                btnStaffMgtMmenu.Visible = True
                btnSupplierManagement.Visible = True
                btnSalesPOSMmenu.Visible = True
                btnInventoryMgtMmenu.Visible = True
                btnReportsMmenu.Visible = True
                btnSettingMmenu.Visible = True
            Case "Manager"
                btnDashboardMmenu.Visible = True
                btnProductMgtMmenu.Visible = True
                btnCustomer_mgt.Visible = True
                btnSupplierManagement.Visible = True
                btnSalesPOSMmenu.Visible = True
                btnInventoryMgtMmenu.Visible = True
                btnReportsMmenu.Visible = True
            Case "Cashier"
                btnDashboardMmenu.Visible = True
                btnCustomer_mgt.Visible = True
                btnSalesPOSMmenu.Visible = True
            Case Else
                btnDashboardMmenu.Visible = True
        End Select

        OpenModule(New Dashboard(), "Dashboard", btnDashboardMmenu)
    End Sub

    Private Sub btnMyProfile_Click(sender As Object, e As EventArgs) Handles btnMyProfile.Click
        OpenProfileModule()
    End Sub

    Private Sub btnDashboardMmenu_Click(sender As Object, e As EventArgs) Handles btnDashboardMmenu.Click
        OpenModule(New Dashboard(), "Dashboard", btnDashboardMmenu)
    End Sub

    Private Sub btnCustomer_mgt_Click(sender As Object, e As EventArgs) Handles btnCustomer_mgt.Click
        OpenModule(New AddCustomer(), "Customer Management", btnCustomer_mgt)
    End Sub

    Private Sub btnProductMgtMmenu_Click(sender As Object, e As EventArgs) Handles btnProductMgtMmenu.Click
        OpenModule(New ProductMgtFrm(), "Product Management", btnProductMgtMmenu)
    End Sub

    Private Sub btnStaffMgtMmenu_Click(sender As Object, e As EventArgs) Handles btnStaffMgtMmenu.Click
        OpenModule(New StaffMgtFrm(), "Staff Management", btnStaffMgtMmenu)
    End Sub

    Private Sub btnSalesPOSMmenu_Click(sender As Object, e As EventArgs) Handles btnSalesPOSMmenu.Click
        OpenModule(New SalesPOS(), "Sales (POS)", btnSalesPOSMmenu)
    End Sub

    Private Sub btnInventoryMgtMmenu_Click(sender As Object, e As EventArgs) Handles btnInventoryMgtMmenu.Click
        OpenModule(New InventoryMgtFrm(), "Inventory Management", btnInventoryMgtMmenu)
    End Sub

    Private Sub btnSupplierManagement_Click(sender As Object, e As EventArgs) Handles btnSupplierManagement.Click
        OpenModule(New AddSupplierMgt(), "Supplier Management", btnSupplierManagement)
    End Sub

    Private Sub btnReportsMmenu_Click(sender As Object, e As EventArgs) Handles btnReportsMmenu.Click
        OpenModule(New ReportsFrm(), "Reports", btnReportsMmenu)
    End Sub

    Private Sub btnSettingMmenu_Click(sender As Object, e As EventArgs) Handles btnSettingMmenu.Click
        OpenModule(New Settings(), "Settings", btnSettingMmenu)
    End Sub

    Private Sub btnLogoutMmenu_Click(sender As Object, e As EventArgs) Handles btnLogoutMmenu.Click
        If MessageBox.Show("Are you sure you want to log out?", "Confirm Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question) <> DialogResult.Yes Then Return
        Dim loginForm As New LoginFrm()
        loginForm.Show()
        Me.Close()
    End Sub

    Private Sub pnlContent_Paint(sender As Object, e As PaintEventArgs) Handles pnlContent.Paint

    End Sub
End Class
