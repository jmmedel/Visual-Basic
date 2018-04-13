Imports System.Net

Module Module1

    Sub Main()


    End Sub

    Private Sub Download()
        Dim client As New WebClient
        AddHandler client.DownloadStringCompleted,
                   AddressOf client_DownloadStringCompleted

        AddHandler client.DownloadProgressChanged,
                   AddressOf client_DownloadProgressChanged

        client.DownloadStringAsync(New Uri("http://msdn.microsoft.com"))
    End Sub

    Private Sub client_DownloadStringCompleted(sender As Object,
                                               e As DownloadStringCompletedEventArgs)
        If e.Error Is Nothing Then
            Console.WriteLine(XDocument.Parse(e.Result).ToString)
            Console.WriteLine("Done")
        End If
    End Sub

    Private Sub client_DownloadProgressChanged(sender As Object,
                                               e As DownloadProgressChangedEventArgs)
        Console.WriteLine(e.ProgressPercentage)
        'Use e.BytesReceived for the number of bytes received in progress      
        'Use e.TotalBytesToReceive to get the total bytes to be downloaded
    End Sub

    Private Sub DownloadWithLambda()
        Dim client As New WebClient
        AddHandler client.DownloadStringCompleted,
                   Sub(sender, e)
                       If e.Error Is Nothing Then
                           Console.WriteLine(XDocument.
                                             Parse(e.Result).
                                             ToString)
                       End If
                   End Sub

        client.DownloadStringAsync(New Uri("http://msdn.microsoft.com"))
    End Sub
End Module