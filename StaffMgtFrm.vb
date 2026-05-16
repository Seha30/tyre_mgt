Public Class StaffMgtFrm

    Private Sub StaffMgtFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UiThemeHelper.StyleGroupBox(grpDetails)
        UiThemeHelper.StyleGroupBox(grpList)
        UiThemeHelper.StylePrimaryButton(btnAddStaff)
        UiThemeHelper.StylePrimaryButton(btnUpdateStaff)
        UiThemeHelper.StyleSecondaryButton(btnClearStaff)
        UiThemeHelper.ApplyGridTheme(dgvStaff)
        cmbRole.Items.AddRange(New Object() {"Admin", "Manager", "Cashier"})
        cmbRole.SelectedIndex = 2
        LoadGrid()
    End Sub

    Private Sub LoadGrid()
        Try
            dgvStaff.DataSource = StaffCRUD.LoadStaff()
        Catch ex As Exception
            MessageBox.Show("Run database\01_schema.sql first. " & ex.Message, "Database", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Sub btnAddStaff_Click(sender As Object, e As EventArgs) Handles btnAddStaff.Click
        Dim v = ValidationHelper.ValidateLogin(txtUsername.Text, txtPassword.Text)
        If Not ValidationHelper.ShowIfInvalid(v) Then Return
        v = ValidationHelper.RequireText(txtFullName.Text, "Full name", 100)
        If Not ValidationHelper.ShowIfInvalid(v) Then Return
        Try
            StaffCRUD.AddStaff(txtUsername.Text.Trim(), txtPassword.Text, txtFullName.Text.Trim(), txtStaffPhone.Text.Trim(), cmbRole.Text)
            MessageBox.Show("Staff account created.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtPassword.Clear()
            LoadGrid()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnUpdateStaff_Click(sender As Object, e As EventArgs) Handles btnUpdateStaff.Click
        If String.IsNullOrWhiteSpace(txtUserId.Text) Then Return
        Try
            StaffCRUD.UpdateStaff(CInt(txtUserId.Text), txtUsername.Text.Trim(), txtFullName.Text.Trim(), txtStaffPhone.Text.Trim(), cmbRole.Text, chkActive.Checked, txtPassword.Text)
            MessageBox.Show("Staff updated.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            LoadGrid()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnClearStaff_Click(sender As Object, e As EventArgs) Handles btnClearStaff.Click
        txtUserId.Clear()
        txtUsername.Clear()
        txtFullName.Clear()
        txtPassword.Clear()
        txtStaffPhone.Clear()
        chkActive.Checked = True
    End Sub

    Private Sub dgvStaff_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvStaff.CellClick
        If e.RowIndex < 0 Then Return
        Dim r = dgvStaff.Rows(e.RowIndex)
        txtUserId.Text = Cell(r, "user_id")
        txtUsername.Text = Cell(r, "username")
        txtFullName.Text = Cell(r, "full_name")
        txtStaffPhone.Text = Cell(r, "phone")
        cmbRole.Text = Cell(r, "role_name")
        chkActive.Checked = (Cell(r, "is_active") = "1")
        txtPassword.Clear()
    End Sub

    Private Function Cell(r As DataGridViewRow, c As String) As String
        If dgvStaff.Columns.Contains(c) AndAlso r.Cells(c).Value IsNot Nothing Then Return r.Cells(c).Value.ToString()
        Return ""
    End Function

End Class
