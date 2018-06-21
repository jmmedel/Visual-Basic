

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim rows As Integer, i As Integer

        rows = 6
        For i = 1 To rows * 2 Step 2
            rows = rows - 1
            Text1.Text = Text1.Text & " " & "*" & vbCrLf
        Next

    End Sub
End Class
