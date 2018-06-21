Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim i As Integer
        Label1.Alignment = 2
        Label1 = ""
        For i = 1 To 9 Step 2
            Text1 = Text1 & String(i, "*") & vbCrLf
        Next

    End Sub
End Class
