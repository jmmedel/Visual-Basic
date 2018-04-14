Public Class Form1
    '83'
    Private q As New Queue

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        q.Enqueue(1)
        q.Enqueue(99)
        q.Enqueue(25)
        q.Enqueue(31)
        q.Enqueue(22)
        q.Dequeue()
        MsgBox(q.Dequeue().ToString())
        MsgBox(q.Peek().ToString())
    End Sub
End Class
