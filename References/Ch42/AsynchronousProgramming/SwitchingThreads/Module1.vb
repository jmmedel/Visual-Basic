Imports System.Threading

Module Module1

    Sub Main()
        RunIntensiveWorkAsync()
        Console.ReadLine()
    End Sub

    Private cancellationToken As CancellationTokenSource

    Private Async Sub RunIntensiveWorkAsync()
        cancellationToken = New CancellationTokenSource
        'This runs on the UI thread
        Console.WriteLine("Starting...")

        Try
            'This runs on a Thread Pool thread
            Dim result As Integer = Await Task.Run(Function()
                                                       Dim workResult As Integer =
                                                        SimulateIntensiveWork(cancellationToken.Token)
                                                       Return workResult
                                                   End Function)
            'This runs again on the UI thread
            Console.WriteLine("Finished")
        Catch ex As OperationCanceledException
            Console.WriteLine("Canceled by the user.")
        Catch ex As Exception

        End Try
        Console.ReadLine()
    End Sub

    Private Async Function SimulateIntensiveWorkAsync() As Task(Of Integer)
        Dim delay As Integer = 1000
        Await Task.Delay(delay)
        Return delay
    End Function

    Private Function SimulateIntensiveWork() As Integer
        Dim delay As Integer = 5000
        Threading.Thread.Sleep(delay)
        Return delay
    End Function

    Private Function SimulateIntensiveWork(token As CancellationToken) _
             As Integer
        Dim delay As Integer = 5000
        Threading.Thread.Sleep(delay)

        token.ThrowIfCancellationRequested()

        Return delay
    End Function

End Module
