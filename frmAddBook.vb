Public Class frmAddBook
    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        If tbBookName.Text = "" Or tbAuthor.Text = "" Or tbGenre.Text = "" Then
            MessageBox.Show("Please fill all the fields")
            Exit Sub
        End If
        Dim name As String = tbBookName.Text
        Dim author As String = tbAuthor.Text
        Dim genre As String = tbGenre.Text

        Dim frmBook As New frmBooks()
        frmBook.ShowAdd(name, author, genre)
        MessageBox.Show("Book Added Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        tbBookName.Text = ""
        tbAuthor.Text = ""
        tbGenre.Text = ""
        Me.Hide()
    End Sub
End Class
