Public Class frmAdminPortal

    Public Sub showDetail(username As String)
        lblName.Text = username
    End Sub

    Private Sub btnAccount_Click(sender As Object, e As EventArgs) Handles btnAccount.Click
        Dim result As DialogResult
        result = MessageBox.Show("Do You Want To Log Out ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information)

        If result = DialogResult.Yes Then
            MessageBox.Show("You Have Been Logged Out", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            frmlogin.Show()
            Me.Hide()
        Else
            MessageBox.Show("You Have Cancelled", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
    Sub childform(ByVal panel As Form)
        pnlMain.Controls.Clear()
        panel.TopLevel = False
        panel.FormBorderStyle = FormBorderStyle.None
        panel.Dock = DockStyle.Fill
        pnlMain.Controls.Add(panel)
        panel.Show()
    End Sub

    Private Sub frmAdminPortal_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnTest_Click(sender As Object, e As EventArgs) Handles btnTest.Click
        childform(frmUsers)
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        childform(frmBooks)
    End Sub
End Class