Imports OpenFileDialog

Public Class Form1
    Private Sub ButtonOpen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim FileDialog As New OpenFileDialog()


        FileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*"
        FileDialog.FilterIndex = 1


        If FileDialog.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            Try
                If OpenFileDialog.OpenFile() IsNot Nothing Then
                    TextBox1.Text = My.Computer.FileSystem.ReadAllText(OpenFileDialog.OpenFile().ToString())
                End If
            Catch Ex As Exception
                MsgBox("Cannot read file from disk. Original error: " & Ex.Message)
            Finally
                If OpenFileDialog.OpenFile() IsNot Nothing Then
                    OpenFileDialog.OpenFile().Close()
                End If
            End Try
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub
End Class
