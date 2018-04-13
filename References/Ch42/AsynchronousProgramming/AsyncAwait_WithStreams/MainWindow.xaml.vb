Imports System.IO
Imports System.Text

Class MainWindow

    Private Async Sub ReadTextButton_Click(sender As Object,
                                           e As RoutedEventArgs) _
                                           Handles ReadTextButton.Click
        Using reader As New StreamReader("TextFile1.txt")
            Me.ReadTextBox.Text = Await reader.ReadToEndAsync
        End Using

    End Sub

    Private Async Sub CopyButton_Click(sender As Object,
                                       e As RoutedEventArgs) _
                                       Handles CopyButton.Click
        If Me.SourceTextBox.Text = "" Then
            MessageBox.Show("Please specify the source folder")
            Exit Sub
        End If

        If Me.DestinationTextBox.Text = "" Then
            MessageBox.Show("Please specify the target folder")
            Exit Sub
        End If

        For Each fileName As String In Directory.
            EnumerateFiles(Me.SourceTextBox.Text)

            Using SourceStream As FileStream = File.Open(fileName, FileMode.Open)
                Using DestinationStream As FileStream =
                    File.Create(String.Concat(Me.DestinationTextBox.Text,
                                              fileName.
                                              Substring(fileName.LastIndexOf("\"c))))
                    Await SourceStream.CopyToAsync(DestinationStream)
                    Me.StatusTextBox.Text = "Copied " + DestinationStream.Name
                End Using
            End Using
        Next

    End Sub

    Private Async Sub WriteButton_Click(sender As Object,
                                  e As RoutedEventArgs) Handles WriteButton.Click
        Dim uniencoding As UnicodeEncoding = New UnicodeEncoding()
        Dim filename As String =
            "c:\temp\AsyncWriteDemo.txt"

        Dim result As Byte() = uniencoding.GetBytes("Demo for Async I/O")

        Using SourceStream As FileStream = File.Open(filename, FileMode.OpenOrCreate)
            SourceStream.Seek(0, SeekOrigin.End)
            Await SourceStream.WriteAsync(result, 0, result.Length)
        End Using

    End Sub
End Class
