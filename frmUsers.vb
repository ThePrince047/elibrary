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

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        Dim userId As String = InputBox("Enter the User ID to delete:", "Delete User")

        ' Check if the user canceled or provided an empty input
        If String.IsNullOrEmpty(userId) Then
            Return
        End If

        ' Perform the deletion
        Try
            ' Connect to the database
            Using con As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\VB.net Projects\bookseller.accdb")
                con.Open()
                ' Define the SQL query to delete the book
                Dim query As String = "DELETE FROM userTable WHERE userId = ?"
                ' Create and execute the command
                Using cmd As New OleDbCommand(query, con)
                    cmd.Parameters.AddWithValue("?", userId)
                    Dim rowsAffected As Integer = cmd.ExecuteNonQuery()
                    ' Check if any row was deleted
                    If rowsAffected > 0 Then
                        MessageBox.Show("User deleted successfully.")
                    Else
                        MessageBox.Show("No User found with the provided ID.")
                    End If
                End Using
            End Using

            ' Refresh the DataGridView
            Load_Data()
        Catch ex As Exception
            MessageBox.Show("Error deleting book: " & ex.Message)
        End Try
    End Sub

    Private Sub Load_Data()
        Try
            Dim con As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\VB.net Projects\bookseller.accdb")
            Dim Str As String = "select * from userTable"
            con.Open()
            Dim sda As New OleDbDataAdapter(Str, con)
            Dim ds As New DataSet
            sda.Fill(ds, "userTable")
            dgUser.DataSource = ds.Tables("userTable")
            con.Close()

        Catch ex As Exception

        End Try
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Load_Data()
    End Sub
End Class