Module Module1

    Sub Main()
        'DownloadAllFeedsAsync()
        'DownloadFeedsAsync()
        WhenAnyRedundancyAsync()
        Console.ReadLine()
    End Sub

    'Demonstrates Task.WhenAll
    Private Async Sub DownloadAllFeedsAsync()
        Dim feeds As New List(Of Uri) From {New Uri("http://channel9.msdn.com/Tags/windows+8/RSS"),
                                            New Uri("http://channel9.msdn.com/Tags/windows+phone"),
                                            New Uri("http://channel9.msdn.com/Tags/visual+basic/RSS")}

        'This task completes when all of the requests complete
        Dim feedCompleted As IEnumerable(Of String) = Await Task.WhenAll(From feed In feeds
                                                                         Select New System.Net.WebClient().
                                                                         DownloadStringTaskAsync(feed))

        'Additional work here...
    End Sub


    'Demonstrates Task.WhenAny
    Private Async Sub DownloadFeedsAsync()
        Dim feeds As New List(Of Uri) From {New Uri("http://channel9.msdn.com/Tags/windows+8/RSS"),
                                            New Uri("http://channel9.msdn.com/Tags/windows+phone"),
                                            New Uri("http://channel9.msdn.com/Tags/visual+basic/RSS")}

        'This task completes when any of the requests complete
        Dim feedCompleted As Task(Of String) = Await Task.WhenAny(From feed In feeds
                                                                  Select New System.Net.WebClient().
                                                                  DownloadStringTaskAsync(feed))

        'Additional work here...
    End Sub

    Public Async Sub WhenAnyRedundancyAsync()

        Dim messages As New List(Of Task(Of String)) From
            {
                GetMessage1Async(),
                GetMessage2Async(),
                GetMessage3Async()
            }
        Dim message = Await Task.WhenAny(messages)
        Console.WriteLine(message.Result)
        Console.ReadLine()
    End Sub


    Public Async Function GetMessage1Async() As Task(Of String)
        Await Task.Delay(700)
        Return "Hi VB guys!"
    End Function


    Public Async Function GetMessage2Async() As Task(Of String)
        Await Task.Delay(600)
        Return "Hi C# guys!"
    End Function


    Public Async Function GetMessage3Async() As Task(Of String)
        Await Task.Delay(500)
        Return "Hi F# guys!"
    End Function
End Module
