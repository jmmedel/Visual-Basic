Module Module1

    Private progress As Progress(Of Integer)
    Private counter As Integer = 0

    Sub Main()
        Try
            progress = New Progress(Of Integer)
            AddHandler progress.ProgressChanged, Sub(sender, e)
                                                     Console.WriteLine("Download progress: " +
                                                                       CStr(e))
                                                 End Sub

            DownloadAllFeedsAsync(progress)

        Catch ex As Exception
            Console.WriteLine(ex.Message)
        Finally
            Console.ReadLine()
        End Try
    End Sub

    Private Async Sub DownloadAllFeedsAsync(currentProgress As IProgress(Of Integer))
        Dim client As New System.Net.WebClient

        Dim feeds As New List(Of Uri) From {New Uri("http://channel9.msdn.com/Tags/windows+8/RSS"),
                                            New Uri("http://channel9.msdn.com/Tags/windows+phone"),
                                            New Uri("http://channel9.msdn.com/Tags/visual+basic/RSS")}

        For Each URL In feeds
            Await client.DownloadStringTaskAsync(URL)
            counter += 1
            If currentProgress IsNot Nothing Then _
                currentProgress.Report(counter)
        Next
    End Sub
End Module

