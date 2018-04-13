Imports System.Net, System.Net.Http

Imports <xmlns:media="http://search.yahoo.com/mrss/">
Imports <xmlns:dc="http://purl.org/dc/elements/1.1/">
Imports System.Threading
Class MainWindow

    Private tokenSource As CancellationTokenSource

    Private Sub CancelButton_Click(sender As Object, e As RoutedEventArgs) _
        Handles CancelButton.Click
        'If Me.tokenSource IsNot Nothing Then
        '    Me.tokenSource.Cancel()
        'End If
        Me.tokenSource?.Cancel()
    End Sub

    'The following implementation does not support cancellation
    'but demonstrates how easy it is working with Async

    Private Async Function QueryVideosAsync() As _
            Task(Of IEnumerable(Of Video))
        Dim client As New WebClient

        Dim data = Await client.DownloadStringTaskAsync(New Uri(Video.
                                                                FeedUrl))

        Dim doc = XDocument.Parse(data)

        Dim query = From video In doc...<item>
                    Select New Video With {
                        .Title = video.<title>.Value,
                        .Speaker = video.<dc:creator>.Value,
                        .Url = video.<link>.Value,
                        .Thumbnail = video...<media:thumbnail>.
                        FirstOrDefault?.@url,
                        .DateRecorded = String.Concat("Recorded on ",
                        Date.Parse(video.<pubDate>.Value,
                            Globalization.CultureInfo.InvariantCulture).
                        ToShortDateString)}

        Return query
    End Function


    'The following implementation with HttpClient supports Cancellation
    Private Async Function QueryVideosAsync(token As CancellationToken) As _
            Task(Of IEnumerable(Of Video))
        Try
            Dim client As New HttpClient

            'Get the feed content as an HttpResponseMessage
            Dim data = Await client.GetAsync(New Uri(Video.FeedUrl), token)

            'Parse the content into a String
            Dim actualData = Await data.Content.ReadAsStringAsync

            Dim doc = XDocument.Parse(actualData)

            Dim query = From video In doc...<item>
                        Select New Video With {
                        .Title = video.<title>.Value,
                        .Speaker = video.<dc:creator>.Value,
                        .Url = video.<link>.Value,
                        .Thumbnail = video...<media:thumbnail>.
                            FirstOrDefault?.@url,
                        .DateRecorded = String.Concat("Recorded on ",
                            Date.Parse(video.<pubDate>.Value,
                            Globalization.CultureInfo.InvariantCulture).
                            ToShortDateString)}

            Return query
        Catch ex As OperationCanceledException
            MessageBox.Show("Operation was canceled by the user.")
            Return Nothing
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Return Nothing
        End Try
    End Function

    Private Async Function LoadVideosAsync() As Task
        Me.tokenSource = New CancellationTokenSource

        Me.DataContext = Await QueryVideosAsync(Me.tokenSource.Token)
    End Function


    Private Async Sub MainWindow_Loaded(sender As Object,
                                        e As RoutedEventArgs) Handles Me.Loaded
        Await LoadVideosAsync()
    End Sub



    Private Sub Border_MouseLeftButtonUp_1(sender As Object, e As MouseButtonEventArgs)
        Dim instance = CType(sender, Border)
        Process.Start(CStr(instance.Tag))
    End Sub

End Class
