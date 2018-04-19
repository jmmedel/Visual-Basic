Public Class Form1
    Dim t As ToolTip = New ToolTip()

    Private Sub TrackBar1_Scroll(sender As Object, e As EventArgs) Handles TrackBar1.Scroll
        t.SetToolTip(TrackBar1, TrackBar1.Value.ToString())
    End Sub

    Private Sub TrackBar1_Paint(sender As Object, e As PaintEventArgs) Handles TrackBar1.Paint

    End Sub
End Class



'Public Class Form2

'End Class