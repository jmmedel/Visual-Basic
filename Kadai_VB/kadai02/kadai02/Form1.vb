Public Class Form1

    'button 1 add'

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim a, b As Integer
        a = TextBox1.Text
        b = TextBox2.Text
        Label4.Text = a + b
    End Sub

    'button 2 subtract'
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim a, b As Integer

        a = TextBox1.Text
        b = TextBox2.Text
        Label4.Text = a - b
    End Sub

    'button 3 devided'
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim a, b As Integer
        a = TextBox1.Text
        b = TextBox2.Text
        Label4.Text = a / b
    End Sub

    'button 4 multiply'
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim a, b As Integer
        a = TextBox1.Text
        b = TextBox2.Text
        Label4.Text = a * b
    End Sub



End Class
