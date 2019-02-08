Imports System.IO
Imports System.Text

Public Class Form1
    Dim data(7) As String
    Dim Sr As New StreamReader("C:\KIC\2018\Visual Basic\VBkadai\0H02044 宮川美沙紀 kadai38\0H02044 宮川美沙紀 kadai38\bin\Debug\kadai38.txt", Encoding.GetEncoding("shift_jis"))
    Dim Buffer As String
    Dim rand As Random = New Random()



    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Buffer = Sr.ReadLine
        Dim j As Integer = 0
        Do Until Buffer Is Nothing
            data(j) = Buffer
            Buffer = Sr.ReadLine()
            j += 1
        Loop

        Dim i As Integer = rand.Next(0, 8)
        Label1.Text = data(i)
        Label1.Left = Me.Width
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Timer1.Enabled = True
        Button1.Enabled = False
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Timer1.Enabled = False
        Button1.Enabled = True
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If Label1.Left < -Label1.Width Then
            Dim i As Integer = rand.Next(0, 8)
            Label1.Text = data(i)
            Label1.Left = Me.Width
        End If
        Label1.Left = Label1.Left - 3
    End Sub
End Class
