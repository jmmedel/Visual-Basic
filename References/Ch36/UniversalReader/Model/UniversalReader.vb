Imports System.Net.Http
Imports System.Runtime.Serialization
Imports Newtonsoft.Json
Imports Windows.Networking.Connectivity
Imports Windows.Storage
Imports Windows.Storage.Streams
Imports <xmlns:media="http://search.yahoo.com/mrss/">
Imports <xmlns:dc="http://purl.org/dc/elements/1.1/">

Public Class UniversalReader
    Private Shared client As HttpClient

    Public Shared Async Function RefreshFeedAsync() As _
        Task(Of ObservableCollection(Of FeedItem))

        'Get the current Internet profile. 
        'Return Nothing if not connected
        Dim internetConnectionProfile As ConnectionProfile =
            NetworkInformation.GetInternetConnectionProfile

        'If not connected...
        If internetConnectionProfile Is Nothing Then
            Return Nothing
        End If

        Try
            'Get the current app's local folder
            Dim localFolder As StorageFolder =
                ApplicationData.Current.LocalFolder
            'Get the instance of the data file
            Dim fileInstance As StorageFile =
                Await localFolder.GetFileAsync("FeedData.bin")

            'Delete the file
            If fileInstance IsNot Nothing Then _
               Await fileInstance.DeleteAsync
        Catch
            'File not found, just ignore
        End Try

        'Download the RSS feed content
        client = New HttpClient()
        Dim fullFeed = Await client.
                       GetStringAsync(FeedItem.FeedUrl)

        'Convert to XDocument
        Dim doc = XDocument.Parse(fullFeed)

        Dim query = From item In doc...<item>
                    Let videos = item...<media:content>.
            Where(Function(vid) vid.@url.ToLower.
            Contains("mp4"))
                    Let videoDate =
                        Date.Parse(item.<pubDate>.Value,
                        Globalization.CultureInfo.
                        InvariantCulture).ToString
                    Select New FeedItem With {
                        .Title = item.<title>.Value,
                        .Speaker = item.<dc:creator>.Value,
                        .Url = item.<link>.Value,
                        .Thumbnail = item...<media:thumbnail>.
                        LastOrDefault?.@url,
                        .Video = videos.
                        LastOrDefault?.@url,
                        .DateRecorded = $"Recorded on {videoDate}"}

        Dim result As New _
                ObservableCollection(Of FeedItem)(query)

        'Serialize the collection
        Await SaveFeedAsync(result)
        Return result
    End Function

    Public Shared Async Function SaveFeedAsync(feedData As _
                                               ObservableCollection(Of FeedItem)) As Task
        Try
            'Serialize the data into a in-memory stream
            Dim sessionData = JsonConvert.SerializeObject(feedData)

            'Create a data file
            Dim folder As StorageFolder =
                ApplicationData.Current.LocalFolder
            Dim newFile = Await folder.
                CreateFileAsync("FeedData.bin",
                                CreationCollisionOption.ReplaceExisting)

            'Write the serialized object into the file
            Await FileIO.WriteTextAsync(newFile, sessionData)

        Catch ex As HttpRequestException
            'handle connection exceptions here...
        Catch ex As Exception
            'handle exceptions here...
            Debug.WriteLine(ex.Message)
        End Try
    End Function

    Public Shared Async Function LoadFeedAsync() As _
        Task(Of ObservableCollection(Of FeedItem))

        Try
            Dim file = Await ApplicationData.
                       Current.LocalFolder.GetFileAsync("FeedData.bin")

            Dim data = JsonConvert.DeserializeObject(Of ObservableCollection(Of FeedItem)) _
                (Await FileIO.ReadTextAsync(file))

            Return data
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Public Shared Async Function GetFeedAsync() As _
            Task(Of ObservableCollection(Of FeedItem))

        Dim data = Await LoadFeedAsync()
        'No existing feed data
        If data Is Nothing Then

            'Download the RSS feed from the Internet
            Dim result = Await RefreshFeedAsync()
            If result IsNot Nothing Then
                'Return the downloaded feed
                Return result
            Else
                'Encountered problems, return Nothing
                Return Nothing
            End If
        Else
            'Existing feed data
            Return data
        End If
    End Function

End Class

