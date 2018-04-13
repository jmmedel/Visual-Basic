Imports System.Net
Imports System.Threading
Imports <xmlns:media="http://search.yahoo.com/mrss/">
Imports <xmlns:dc="http://purl.org/dc/elements/1.1/">
Class MainWindow
    Private cancellationToken As CancellationTokenSource

    Private Sub QueryVideos(cancellationToken As CancellationToken,
                            listOfVideos As Action(Of IEnumerable(Of Video),
                                                   Exception))
        Dim client As New WebClient
        cancellationToken.Register(Sub() _
                                       client.CancelAsync())

        AddHandler client.DownloadStringCompleted, Sub(sender, e)
                                                       If e.Error IsNot Nothing Then
                                                           listOfVideos(Nothing, e.Error)
                                                           Return
                                                       End If
                                                       If e.Cancelled Then
                                                           listOfVideos(Nothing, New TaskCanceledException)
                                                       End If

                                                       Dim doc = XDocument.Parse(e.Result)
                                                       Dim query = From video In doc...<item>
                                                                   Select New Video With {
                                                                    .Title = video.<title>.Value,
                                                                    .Speaker = video.<dc:creator>.Value,
                                                                    .Url = video.<link>.Value,
                                                                    .Thumbnail = video...<media:thumbnail>.FirstOrDefault?.@url,
                                                                    .DateRecorded = String.Concat("Recorded on ", Date.Parse(video.<pubDate>.Value,
                                                                        Globalization.CultureInfo.InvariantCulture).ToShortDateString)
                                                        }

                                                       listOfVideos(query, Nothing)
                                                   End Sub

        Try
            client.DownloadStringAsync(New Uri(Video.FeedUrl))
        Catch ex As Exception
            listOfVideos(Nothing, ex)
        End Try
    End Sub



    Private Sub LoadVideos()
        Me.cancellationToken = New CancellationTokenSource

        Dim action As Action(Of IEnumerable(Of Video), Exception) = Nothing
        action =
            Sub(videos, ex)
                If ex IsNot Nothing Then
                    Me.cancellationToken = Nothing
                    If (TypeOf ex Is TaskCanceledException OrElse
                        (TypeOf ex Is WebException AndAlso CType(ex, WebException).Status = WebExceptionStatus.RequestCanceled)) Then
                        'statusText.Text = "Cancelled"
                        MessageBox.Show("Operation was canceled by the user")

                        Return
                    Else
                        Throw ex
                    End If
                End If

                'statusText.Text = String.Format("Searching...  {0} Titles", imageCount)
                If (videos.Any) Then
                    Me.DataContext = videos
                    'imageCount += movies.Length
                    QueryVideos(Me.cancellationToken.Token, action)
                Else
                    'statusText.Text = String.Format("{0} Titles", imageCount)
                End If
            End Sub

        QueryVideos(Me.cancellationToken.Token, action)
    End Sub

    Private Sub MainWindow_Loaded(sender As Object, e As RoutedEventArgs) Handles Me.Loaded
        LoadVideos()
    End Sub

    Private Sub CancelButton_Click(sender As Object, e As RoutedEventArgs) Handles CancelButton.Click
        If Me.cancellationToken IsNot Nothing Then
            Me.cancellationToken.Cancel()
        End If
    End Sub
End Class
