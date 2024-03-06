Public Class frmAddBook
    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        If tbBookName.Text = "" Or tbAuthor.Text = "" Or tbGenre.Text = "" Then
            MessageBox.Show("Please fill all the fields")
            Exit Sub
        End If
        ' Get the data from the textboxes
        Dim name As String = tbBookName.Text
        Dim author As String = tbAuthor.Text
        Dim genre As String = tbGenre.Text

        ' Create an instance of the frmBooks form
        Dim frmBook As New frmBooks()

        ' Call the ShowAdd method to pass data to frmBooks
        frmBook.ShowAdd(name, author, genre)
        MessageBox.Show("Book Added Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ' Show other forms or hide the current form
        Me.Hide()
    End Sub
End Class
