Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim year As Integer
        Try

            year = TextBox1.Text
            If year Mod 100 = 0 Then
                year = year / 100
            ElseIf year <= 0 Then
                year = 0
            Else
                year = (year / 100) + 1
            End If


            Label2.Text = year & "世紀"

        Catch ex As Exception
            MsgBox("整数値を入力してくださいーー＞")
        End Try

    End Sub
End Class
