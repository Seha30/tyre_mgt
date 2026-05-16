Imports Guna.UI2.WinForms

''' <summary>Consistent S &amp; N Tyre Center form styling.</summary>
Public Module UiThemeHelper

    Public ReadOnly PrimaryOrange As Color = Color.FromArgb(255, 128, 0)
    Public ReadOnly LightPeach As Color = Color.FromArgb(255, 224, 192)
    Public ReadOnly DarkSidebar As Color = Color.FromArgb(30, 30, 30)
    Public ReadOnly FormBackground As Color = Color.FromArgb(248, 249, 250)
    Public ReadOnly GridHeader As Color = Color.FromArgb(255, 192, 128)

    Public Sub StylePrimaryButton(btn As Guna2Button)
        btn.BorderRadius = 12
        btn.FillColor = PrimaryOrange
        btn.ForeColor = Color.White
        btn.Font = New Font("Segoe UI Semibold", 9.0F, FontStyle.Bold)
    End Sub

    Public Sub StyleSecondaryButton(btn As Guna2Button)
        btn.BorderRadius = 12
        btn.FillColor = Color.FromArgb(255, 192, 128)
        btn.ForeColor = Color.Black
        btn.Font = New Font("Segoe UI Semibold", 9.0F, FontStyle.Bold)
    End Sub

    Public Sub StyleDangerButton(btn As Guna2Button)
        btn.BorderRadius = 12
        btn.FillColor = Color.FromArgb(220, 53, 69)
        btn.ForeColor = Color.White
        btn.Font = New Font("Segoe UI Semibold", 9.0F, FontStyle.Bold)
    End Sub

    Public Sub StyleGroupBox(grp As Guna2GroupBox)
        grp.FillColor = LightPeach
        grp.Font = New Font("Segoe UI Semibold", 10.0F, FontStyle.Bold)
        grp.ForeColor = Color.FromArgb(64, 64, 64)
    End Sub

    Public Sub ApplyGridTheme(dgv As Guna2DataGridView)
        dgv.ColumnHeadersDefaultCellStyle.BackColor = GridHeader
        dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black
        dgv.ColumnHeadersDefaultCellStyle.Font = New Font("Segoe UI Semibold", 9.0F, FontStyle.Bold)
        dgv.ColumnHeadersHeight = 32
        dgv.RowTemplate.Height = 28
        dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(255, 248, 240)
    End Sub

    Public Sub StyleTitleLabel(lbl As Guna2HtmlLabel, title As String)
        lbl.Text = title
        lbl.Font = New Font("Segoe UI", 16.0F, FontStyle.Bold)
        lbl.ForeColor = PrimaryOrange
        lbl.BackColor = Color.Transparent
    End Sub

End Module
