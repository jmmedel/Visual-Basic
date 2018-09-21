Public Class Form1



    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click

        If TextBox1.Text <> "" Then

            Try
                Dim number As Integer = CInt(TextBox1.Text)

                If number < 0 Then
                    TextBox2.AppendText("-")
                End If


                Select Case number
                    Case number <= 999
                        TextBox2.AppendText("九")
                    Case number >= 800

                    Case number >= 700

                    Case number >= 600

                    Case number >= 500

                    Case number >= 400

                    Case number >= 300

                    Case number >= 200

                    Case number >= 100

                    Case number >= 90

                    Case number >= 80

                    Case number >= 70

                    Case number >= 60

                    Case number >= 50

                    Case number >= 40

                    Case number >= 30

                    Case number >= 20

                    Case number >= 10

                    Case number >= 10

                    Case number >= 10
                    Case number >= 10
                    Case number >= 10
                    Case number >= 10
                    Case number >= 10
                    Case number >= 10
                    Case number >= 10
                    Case number >= 10

                    Case number >= 10

                End Select

            Catch ex As Exception
                MsgBox("整数値を入力してください")
            End Try


        End If





    End Sub
End Class
