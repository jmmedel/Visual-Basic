Imports System.Random

Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim random As Integer = Int(10 * Rnd())
        Select Case random

            Case 0
                MsgBox("今日の運協　0　です")
            Case 1 To 3

                MsgBox("今日の運協　３０　です")
            Case 4 To 5
                MsgBox("今日の運協　５０　です")
            Case 6 To 7
                MsgBox("今日の運協　７０　です")


        End Select
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
