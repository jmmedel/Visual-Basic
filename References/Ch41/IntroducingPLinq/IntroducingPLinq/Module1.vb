Imports System.Threading

Module Module1

    Sub Main()

        'ClassicLinqQuery()
        PLinqQuery()

        'HandlingExceptions()

        'Tasks.Task.Factory.StartNew(Sub()
        '                                DoCancel(cs)
        '                            End Sub)

    End Sub



    Private Sub ClassicLinqQuery()
        Dim range = Enumerable.Range(0, 1000)

        Dim query = From num In range
                    Where (IsOdd(num))
                    Select num

        'Measuring performance
        Dim sw As Stopwatch = Stopwatch.StartNew

        'Linq query is executed when invoking Count
        Console.WriteLine("Total odd numbers: " + query.Count.ToString)
        sw.Stop()
        Console.WriteLine(sw.ElapsedMilliseconds.ToString)
        Console.ReadLine()
    End Sub


    Private Sub PLinqQuery()
        Dim range = Enumerable.Range(0, 1000)

        'Just add "AsParallel"
        Dim query = From num In range.AsParallel
                    Where (IsOdd(num))
                    Select num

        'Un contatore
        Dim sw As Stopwatch = Stopwatch.StartNew


        'Linq query is executed when invoking Count
        Console.WriteLine("Total odd numbers: " + query.Count.ToString)
        sw.Stop()
        Console.WriteLine(sw.ElapsedMilliseconds.ToString)

        For Each number In query
            Debug.WriteLine(number)
        Next

        Console.ReadLine()

    End Sub


    'Checks if a number is odd
    Private Function IsOdd(ByVal number As Integer) As Boolean
        'Simulate an intensive work
        Thread.SpinWait(1000000)
        Return (number Mod 2) <> 0
    End Function

    Private Sub PreserveOrder()
        Dim range = Enumerable.Range(0, 1000)

        Dim query = From num In range.AsParallel.AsOrdered
                    Where (IsOdd(num))
                    Select num

        Dim query2 = range.AsParallel.Except(query.AsParallel)
    End Sub

    Private Sub HandlingExceptions()

        Dim strings As New List(Of String) From {"Test", Nothing, Nothing, "Test"}

        'Just add "AsParallel"
        Try
            Dim query = strings.AsParallel.
                        Where(Function(s) s.StartsWith("T")).
                        Select(Function(s) s)
            For Each item In query
                Console.WriteLine(item)
            Next

        Catch ex As AggregateException

            For Each problem In ex.InnerExceptions
                Console.WriteLine(problem.ToString)
            Next

        Catch ex As Exception

        Finally
            Console.ReadLine()
        End Try
    End Sub

    Private Sub MergeOptions()
        Dim processes = Process.GetProcesses.
                        AsParallel.WithMergeOptions( _
                        ParallelMergeOptions.FullyBuffered)
    End Sub

    Private Sub ForcingParallelism()
        Dim processes = Process.GetProcesses.AsParallel.WithExecutionMode(ParallelExecutionMode.ForceParallelism)
    End Sub

    Private Sub NumberOfTasks()

        Dim processes = Process.GetProcesses.AsParallel.WithDegreeOfParallelism(3)

    End Sub

    Dim cs As New CancellationTokenSource

    Private Sub DoCancel(ByVal cs As CancellationTokenSource)
        'Ensures that query is cancelled when executing
        Thread.Sleep(500)
        cs.Cancel()
    End Sub

    Private Sub CancellationDemo()
        Try

            Dim processes = Process.GetProcesses.
                            AsParallel.WithCancellation(cs.Token)

        Catch ex As OperationCanceledException
            Console.WriteLine(ex.Message)
        Catch ex As Exception

        End Try
    End Sub


    Private Sub ParallelEnumerableDemo()

        Dim setOfNumbers = ParallelEnumerable.Range(0, 100)

        Dim result = From num In setOfNumbers
                     Select num

    End Sub

End Module
