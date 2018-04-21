Public Class Form1
    Dim pos = 0
    Private Sub btnForward_Click(sender As Object, e As EventArgs) Handles btnForward.Click
        Dim g = Graphics.FromHwnd(Me.Handle)
        If pos < ImageList1.Images.Count Then
            ImageList1.Draw(g, New Point(10, 10), pos)
            pos += 1
        End If
        g.Dispose()
    End Sub
End Class
