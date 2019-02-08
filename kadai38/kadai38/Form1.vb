Imports System.IO
Imports System.Text


Public Class Form1

    Dim data(7) As String
    Dim Sr As New StreamReader(My.Resources.Resource1.kadai38.ToString, Encoding.GetEncoding("shift_jis"))
    Dim Buffer As String
    Dim rand As Random = New Random()


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Buffer = SR.ReadLine
        Dim j As Integer = 0
        Do Until Buffer Is Nothing
            Data(j) = Buffer
            Buffer = SR.ReadLine()
            j += 1
        Loop

        Dim i As Integer = rand.Next(0, 8)
        Label1.Text = Data(i)
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
            Label1.Text = Data(i)
            Label1.Left = Me.Width
        End If
        Label1.Left = Label1.Left - 3
    End Sub

End Class
