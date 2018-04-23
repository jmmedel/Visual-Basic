Public Class Form1

    Private mystack As New Stack

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mystack.Push(1)
        mystack.Push(21)
        mystack.Push(31)
        mystack.Pop()
        MsgBox(mystack.Pop().ToString())
        MsgBox(mystack.Peek().ToString())
    End Sub





End Class
