Imports System.Data.OleDb
Imports System.Data

Public Class frmBooks



    Private Sub frmBooks_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'CurrentDB.bookTable' table. You can move, or remove it, as needed.
        Me.BookTableTableAdapter1.Fill(Me.CurrentDB.bookTable)
        datagridshow()
    End Sub

    Private Sub datagridshow()
        Dim con As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\VB.net Projects\bookseller.accdb")
        con.Open()
        Dim da As New OleDbDataAdapter("SELECT * FROM bookTable", con)
        Dim dt As New DataTable
        da.Fill(dt)
        dgBooks.DataSource = dt
        con.Close()
    End Sub

    Private Sub btnInsertBook_Click(sender As Object, e As EventArgs) Handles btnInsertBook.Click
        frmAddBook.Show()
    End Sub

    Public Sub ShowAdd(bookName As String, author As String, genre As String)
        Try
            Using con As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\VB.net Projects\bookseller.accdb")
                con.Open()
                Dim query As String = "INSERT INTO bookTable ([bookName], [authorName], [genre]) VALUES (?, ?, ?)"
                Using cmd As New OleDbCommand(query, con)
                    cmd.Parameters.AddWithValue("?", bookName)
                    cmd.Parameters.AddWithValue("?", author)
                    cmd.Parameters.AddWithValue("?", genre)
                    cmd.ExecuteNonQuery()
                End Using
            End Using
            ' Refresh the DataGridView
            Load_Data()
        Catch ex As Exception
            MessageBox.Show("Error inserting data: " & ex.Message)
        End Try
    End Sub



    Private Sub Load_Data()
        Try
            Dim con As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\VB.net Projects\bookseller.accdb")
            Dim Str As String = "select * from bookTable"
            con.Open()
            Dim sda As New OleDbDataAdapter(Str, con)
            Dim ds As New DataSet
            sda.Fill(ds, "bookTable")
            dgBooks.DataSource = ds.Tables("bookTable")
            con.Close()

        Catch ex As Exception

        End Try
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Load_Data()
    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        Dim bookId As String = InputBox("Enter the Book ID to delete:", "Delete Book")

        ' Check if the user canceled or provided an empty input
        If String.IsNullOrEmpty(bookId) Then
            Return
        End If

        ' Perform the deletion
        Try
            ' Connect to the database
            Using con As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\VB.net Projects\bookseller.accdb")
                con.Open()
                ' Define the SQL query to delete the book
                Dim query As String = "DELETE FROM bookTable WHERE bookId = ?"
                ' Create and execute the command
                Using cmd As New OleDbCommand(query, con)
                    cmd.Parameters.AddWithValue("?", bookId)
                    Dim rowsAffected As Integer = cmd.ExecuteNonQuery()
                    ' Check if any row was deleted
                    If rowsAffected > 0 Then
                        MessageBox.Show("Book deleted successfully.")
                    Else
                        MessageBox.Show("No book found with the provided ID.")
                    End If
                End Using
            End Using

            ' Refresh the DataGridView
            Load_Data()
        Catch ex As Exception
            MessageBox.Show("Error deleting book: " & ex.Message)
        End Try
    End Sub
End Class