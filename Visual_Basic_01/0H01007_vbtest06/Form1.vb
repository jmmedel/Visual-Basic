Public Class Form1
    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Me.Close()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        TextBox1.Clear()
        TextBox2.Clear()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Try
            Dim firstNum As Integer = CInt(TextBox1.Text)
            Dim secondNum As Integer = CInt(TextBox2.Text)
            Dim total = firstNum + secondNum

            MsgBox("計算答えた" & total & "です")
        Catch ex As Exception
            MsgBox("整数だけ")
        End Try


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Try
            Dim firstNum As Integer = CInt(TextBox1.Text)
            Dim secondNum As Integer = CInt(TextBox2.Text)
            Dim total = firstNum - secondNum

            MsgBox("計算答えた" & total & "です")
        Catch ex As Exception
            MsgBox("整数だけ")
        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        Try
            Dim firstNum As Integer = CInt(TextBox1.Text)
            Dim secondNum As Integer = CInt(TextBox2.Text)
            Dim total = firstNum * secondNum

            MsgBox("計算答えた" & total & "です")
        Catch ex As Exception
            MsgBox("整数だけ")
        End Try
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        Try
            Dim firstNum As Integer = CInt(TextBox1.Text)
            Dim secondNum As Integer = CInt(TextBox2.Text)
            Dim total = firstNum / secondNum

            MsgBox("計算答えた" & total & "です")
        Catch ex As Exception
            MsgBox("整数だけ")
        End Try
    End Sub
End Class
