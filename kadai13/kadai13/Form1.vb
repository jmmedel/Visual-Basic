Public Class Form1
    Dim total As Integer = 0
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If (TextBox1.Text <> "") Then
            Dim evennumber As Integer = TextBox1.Text

            total += evennumber
            Label2.Text = "愚数の合計は" & total & "です"
        Else
            MsgBox("Put a number")
        End If



    End Sub
End Class
