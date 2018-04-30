Imports System.Drawing.Printing
Imports System.IO
Public Class Form1
    Private Sub OpenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenToolStripMenuItem.Click
        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            Using StreamReader As New StreamReader(OpenFileDialog1.FileName)
                Try
                    RichTextBox1.Rtf = StreamReader.ReadToEnd()
                Catch ex As Exception
                    MessageBox.Show(ex.Message, "Info:", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End Try
            End Using
        End If
        'using replaces try/catch/finally
    End Sub

    Private Sub SaveAsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveAsToolStripMenuItem.Click
        If SaveFileDialog1.ShowDialog() = DialogResult.OK Then
            Try
                RichTextBox1.SaveFile(SaveFileDialog1.FileName)
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Info:", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Try
        End If
    End Sub

    Private Sub StyleAndSizeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StyleAndSizeToolStripMenuItem.Click
        FontDialog1.ShowDialog()
        RichTextBox1.Font = FontDialog1.Font
    End Sub

    Private Sub ColorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ColorToolStripMenuItem.Click
        ColorDialog1.ShowDialog()
        RichTextBox1.ForeColor = ColorDialog1.Color
    End Sub

    Private Sub PrintToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PrintToolStripMenuItem.Click
        If PrintDialog1.ShowDialog() = DialogResult.OK Then
            PrintDocument1.Print()
        End If
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Using b As New SolidBrush(ColorDialog1.Color), f = FontDialog1.Font, g = e.Graphics
            g.DrawString(RichTextBox1.Text, f, b, 20, 20)
        End Using
    End Sub

    Private Sub PrintPreviewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PrintPreviewToolStripMenuItem.Click
        PrintPreviewDialog1.Document = PrintDocument1
        PrintPreviewDialog1.ShowDialog()
    End Sub
End Class
