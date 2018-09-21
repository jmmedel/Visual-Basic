Public Class Form1
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If TextBox1.Text <> "" Then

            Try
                Dim months As Integer = CInt(TextBox1.Text)
                If months >= 13 Then
                    MsgBox(" 1-12 だけ整数でお願いします")
                Else

                    Select Case months
                        Case 1
                            Label2.Text = "陰暦では 「睦月」です"
                            Label3.Text = "読み方は「むつき」です"

                        Case 2
                            Label2.Text = "陰暦では 「如月」です"
                            Label3.Text = "読み方は「きさらぎ」です"
                        Case 3
                            Label2.Text = "陰暦では 「弥生」です"
                            Label3.Text = "読み方は「やよい」です"
                        Case 4
                            Label2.Text = "陰暦では 「卯月」です"
                            Label3.Text = "読み方は「うづき」です"
                        Case 5
                            Label2.Text = "陰暦では 「皐月」です"
                            Label3.Text = "読み方は「さつき」です"
                        Case 6
                            Label2.Text = "陰暦では 「水無月」です"
                            Label3.Text = "読み方は「みなづき」です"
                        Case 7
                            Label2.Text = "陰暦では 「文月」です"
                            Label3.Text = "読み方は「ふみづき」です"
                        Case 8
                            Label2.Text = "陰暦では 「葉月」です"
                            Label3.Text = "読み方は「はづき」です"
                        Case 9
                            Label2.Text = "陰暦では 「長月」です"
                            Label3.Text = "読み方は「ながつき」です"
                        Case 10
                            Label2.Text = "陰暦では 「神無月」です"
                            Label3.Text = "読み方は「かんなづ」です"
                        Case 11
                            Label2.Text = "陰暦では 「霜月」です"
                            Label3.Text = "読み方は「しもっき」です"
                        Case 12
                            Label2.Text = "陰暦では 「師走」です"
                            Label3.Text = "読み方は「しわす」です"

                    End Select

                End If

            Catch ex As Exception
                MsgBox(" 1-12 だけ整数でお願いします")
            End Try


        End If

    End Sub
End Class
