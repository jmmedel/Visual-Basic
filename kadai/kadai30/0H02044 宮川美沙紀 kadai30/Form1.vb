Public Class Form1
    Dim flg As Boolean = True
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If Now >= DateTimePicker1.Value Then
            Label1.Text = "時間です！"

            Button2.Enabled = True
        Else
            Button1.Enabled = False
            Button2.Enabled = False
        End If

        If flg = True Then
            Me.Text = ""
            flg = False
        Else
            Me.Text = "アラーム動作中"
            flg = True
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        DateTimePicker1.Enabled = False
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If Timer1.Enabled Then
            DateTimePicker1.Enabled = True
            Button1.Enabled = True
            Timer1.Enabled = False
            Button2.Text = "STSRT"
            Label1.Text = ""
            Me.Text = "アラーム"
        Else
            Timer1.Enabled = True
            Button2.Text = "STOP"

        End If
    End Sub
End Class
