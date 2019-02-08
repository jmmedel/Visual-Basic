Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Left = Me.Width
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Timer1.Enabled Then
            Timer1.Enabled = False
            Button1.Text = "START"
        Else
            Timer1.Enabled = True
            Button1.Text = "STOP"
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If Label1.Left < -Label1.Width Then
            Label1.Left = Me.Width
        End If
        Label1.Left = Label1.Left - 3
    End Sub

End Class
