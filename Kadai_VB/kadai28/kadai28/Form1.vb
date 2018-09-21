
Public Class Form1



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        tmrTime.Enabled = True


    End Sub

    Private Sub tmrTime_Tick(sender As Object, e As EventArgs) Handles tmrTime.Tick
        Label1.Text = Val(Label1.Text) - 1
        Button1.Visible = False
        Button2.Visible = True
        If Label1.Text = 0 Then
            tmrTime.Enabled = False
            MsgBox("タイムアウトになりました")
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        tmrTime.Enabled = False
        Button1.Visible = True
        Button2.Visible = False
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Button2.Visible = False
    End Sub
End Class
