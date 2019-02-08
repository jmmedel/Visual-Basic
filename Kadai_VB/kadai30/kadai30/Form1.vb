Public Class Form1

    Private SetmyTime As New DateTimePicker
    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        DateTimePicker1.Format = DateTimePickerFormat.Time
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        SetmyTime.Format = DateTimePickerFormat.Time
        DateTimePicker1.Format = DateTimePickerFormat.Time
        SetmyTime = DateTimePicker1
        Timer1.Start()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Timer1.Stop()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        Me.DateTimePicker1.Value = Date.Now

        If (SetmyTime.Value <= DateTimePicker1.Value) Then

            Me.Label1.Text = "時間です"

        End If

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
