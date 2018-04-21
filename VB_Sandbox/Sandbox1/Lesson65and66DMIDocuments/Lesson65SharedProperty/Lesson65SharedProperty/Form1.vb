Public Class Form1
    Private Sub NewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewToolStripMenuItem.Click
        Dim form2 = New Form2()
        form2.MdiParent = Me
        form2.Show()
    End Sub

    Private Sub ArrangeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ArrangeToolStripMenuItem.Click
        LayoutMdi(MdiLayout.Cascade)
    End Sub
End Class
