﻿Public Class splashscreen
    Private Sub splashscreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ProgressBar1.Value += 3
        lb_percent.Text = ProgressBar1.Value & "%"
        If ProgressBar1.Value = 100 Then
            frmlogin.Show()
            Me.Hide()
            Timer1.Stop()
            Timer2.Start()
        End If

    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Timer2.Stop()
    End Sub

End Class