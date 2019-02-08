Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Timer1.Enabled Then
            Timer1.Enabled = False
            Button1.Text = "開 始"

        Else
            Timer1.Enabled = True
            Button1.Text = "停 止"
        End If

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label1.Text = Label1.Text - 1

        If Label1.Text = 0 Then
            Timer1.Enabled = False
            Button1.Text = "リセット"
            MsgBox("タイムアウトになりました")
            Button1.Text = "開 始"
            Label1.Text = "10"
        End If
    End Sub
End Class
