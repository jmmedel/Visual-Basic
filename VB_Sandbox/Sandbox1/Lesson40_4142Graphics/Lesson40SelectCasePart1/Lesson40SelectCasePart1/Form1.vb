Public Class Form1
    Dim g As Graphics
    Dim p As Pen
    Dim v As Integer
    Dim c As Color = Color.Red
    Private Sub TrackBar1_Scroll(sender As Object, e As EventArgs) Handles TrackBar1.Scroll
        ToolTip1.SetToolTip(TrackBar1, TrackBar1.Value)
        g = Graphics.FromHwnd(Handle)
        p = New Pen(c, 5)
        v = TrackBar1.Value
        Select Case ComboBox1.SelectedItem
            Case "Circle"
                g.Clear(BackColor)
                g.DrawEllipse(p, 100, 100, v, v)
            Case "Square"
                g.Clear(BackColor)
                g.DrawRectangle(p, 100, 100, v, v)
        End Select
        g.Dispose()
        g = Nothing
        p.Dispose()
        p = Nothing
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        g = Graphics.FromHwnd(Handle)
        p = New Pen(c, 5)
        Select Case ComboBox1.SelectedItem
            Case "Circle"
                g.Clear(BackColor)
                g.DrawEllipse(p, 100, 100, v, v)
            Case "Square"
                g.Clear(BackColor)
                g.DrawRectangle(p, 100, 100, v, v)
        End Select
        g.Dispose()
        g = Nothing
        p.Dispose()
        p = Nothing
    End Sub
End Class
