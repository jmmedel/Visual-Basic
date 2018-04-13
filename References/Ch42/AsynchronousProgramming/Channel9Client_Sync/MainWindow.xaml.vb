Imports System.Net
Imports <xmlns:media="http://search.yahoo.com/mrss/">
Imports <xmlns:dc="http://purl.org/dc/elements/1.1/">
Class MainWindow
    Private Function QueryVideos() As IEnumerable(Of Video)
        Dim client As New WebClient

        Dim data = client.DownloadString(New Uri(Video.FeedUrl))

        Dim doc = XDocument.Parse(data)
        Dim query = From video In doc...<item>
                    Select New Video With {
                        .Title = video.<title>.Value,
                        .Speaker = video.<dc:creator>.Value,
                        .Url = video.<link>.Value,
                        .Thumbnail = video...<media:thumbnail>.FirstOrDefault?.@url,
                        .DateRecorded = String.Concat("Recorded on ", Date.Parse(video.<pubDate>.Value,
                            Globalization.CultureInfo.InvariantCulture).ToShortDateString)
            }

        Return query
    End Function

    Private Sub LoadVideos()
        Me.DataContext = QueryVideos()
    End Sub

    Private Sub MainWindow_Loaded(sender As Object, e As RoutedEventArgs) Handles Me.Loaded
        LoadVideos()
    End Sub

    Private Sub Border_MouseLeftButtonUp_1(sender As Object,
                                           e As MouseButtonEventArgs)
        Dim instance = CType(sender, Border)
        Process.Start(CStr(instance.Tag))
    End Sub
End Class
