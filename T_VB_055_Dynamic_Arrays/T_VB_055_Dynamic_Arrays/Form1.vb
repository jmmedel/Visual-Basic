Public Class Form1

    Private strSports() As String = {"baseball", "Baseketball", "Football"}

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        For Each Item As String In strSports
            ListBox1.Items.Add("[" & Item & "]")
        Next

        ReDim strSports(4)
        strSports(3) = "wakeboarding"
        strSports(4) = "soccer"

        For Each item As String In strSports
            ListBox2.Items.Add("[" & item & "]")
        Next

    End Sub


End Class
