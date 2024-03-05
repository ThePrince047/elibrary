Imports System.Data.OleDb
Imports System.Data
Imports Microsoft.VisualBasic.ApplicationServices


Public Class frmUsers
    Private Sub frmUsers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'CurrentDB.userTable' table. You can move, or remove it, as needed.
        Me.UserTableTableAdapter1.Fill(Me.CurrentDB.userTable)
        datagridshow()
    End Sub

    Private Sub datagridshow()
        Dim con As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\VB.net Projects\bookseller.accdb")
        con.Open()
        Dim da As New OleDbDataAdapter("SELECT * FROM userTable", con)
        Dim dt As New DataTable
        da.Fill(dt)
        dgUser.DataSource = dt
        con.Close()
    End Sub

End Class