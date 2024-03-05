Imports System.Data.OleDb
Imports System.Data

Public Class frmBooks
    Private Sub frmBooks_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'CurrentDB.bookTable' table. You can move, or remove it, as needed.
        Me.BookTableTableAdapter1.Fill(Me.CurrentDB.bookTable)
        datagridshow()
    End Sub

    Private Sub datagridshow()
        Dim con As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\VB Projects\elibrary\bookseller.accdb")
        con.Open()
        Dim da As New OleDbDataAdapter("SELECT * FROM bookTable", con)
        Dim dt As New DataTable
        da.Fill(dt)
        dgBooks.DataSource = dt
        con.Close()
    End Sub
End Class