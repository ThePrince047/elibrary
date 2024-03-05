Imports System.Diagnostics
Public Class frmDashboard

    Public Sub showDetail(username As String)
        lblName.Text = username
    End Sub
    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles btnLogOut.Click
        MsgBox("Do You Want To Log Out ?", vbYesNo, vbInformation)
        If vbYes Then
            MsgBox("You Have Been Logged Out", vbInformation)
            frmlogin.Show()
            Me.Hide()
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

    Private Sub frmDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnBook1_Click(sender As Object, e As EventArgs) Handles btnBook1.Click
        Dim path As String = "D:\SYBCA\Hidden Hindu-2.pdf"
        Process.Start(path)
    End Sub

    Private Sub btnBook2_Click(sender As Object, e As EventArgs) Handles btnBook2.Click
        Dim path As String = "D:\SYBCA\how to win friends.pdf"
        Process.Start(path)
    End Sub

    Private Sub btnBook3_Click(sender As Object, e As EventArgs) Handles btnBook3.Click
        Dim path As String = "D:\SYBCA\people magnet.pdf"
        Process.Start(path)
    End Sub

    Private Sub btnBook4_Click(sender As Object, e As EventArgs) Handles btnBook4.Click
        Dim path As String = "D:\SYBCA\_OceanofPDF.com_The_Shadow_Girl_-_Ray_Cummings.pdf"
        Process.Start(path)
    End Sub



End Class
