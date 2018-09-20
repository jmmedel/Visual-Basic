Imports System.Threading
Imports System.Threading.Tasks



Public Class Form1



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        tmrTime.Enabled = True


    End Sub

    Private Sub tmrTime_Tick(sender As Object, e As EventArgs) Handles tmrTime.Tick
        Label1.Text = Val(Label1.Text) - 1
        If Label1.Text = 0 Then
            tmrTime.Enabled = False
            MsgBox("タイムアウトになりました")
        End If
    End Sub
End Class
