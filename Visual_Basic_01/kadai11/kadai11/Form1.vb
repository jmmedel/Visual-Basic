Imports System.Random

Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim random As Integer = Int(10 * Rnd())
        Select Case random
            Case 0 To 2
                MsgBox("一番良い" & random)
            Case 3 To 5
                MsgBox("ふつう" & random)
            Case 6 To 8
                MsgBox("あんまり良くない" & random)


        End Select
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

End Class
