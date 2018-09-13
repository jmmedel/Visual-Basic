Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try

            Dim score1 As Integer = TextBox1.Text
            Dim score2 As Integer = TextBox2.Text
            Dim score3 As Integer = TextBox3.Text
            Dim total As Integer = score1 + score2 + score3

            If score1 And score2 And score3 >= 30 Then

                If total >= 65 Then
                    Label4.Text = "合格"
                Else
                    Label4.Text = "不合格"
                End If
            End If

        Catch ex As Exception
            MsgBox("値整数のみ")
        End Try
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

End Class
