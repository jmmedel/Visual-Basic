Imports System.Threading.Tasks
Imports System.Threading

Module Tasks

    Sub Main()
        'BarrierDemo()
        'CreateTasks()
        'ExceptionDemo()
        CancellationDemo()
        Console.ReadLine()
        Dim sw As New Stopwatch
        sw.Start()
        'This comment will be replaced by
        'the method executing the loop
        'ClassicForTest()
        'ParallelForTest()
        'ClassicForEachTest()
        'ParallelForEachTest()
        sw.Stop()
        Console.WriteLine("Elapsed: {0}", sw.Elapsed)
        Console.ReadLine()
    End Sub

    Sub CreateTasks()

        Dim simpleTask As New Task(Sub()
                                       'Do your work here...
                                   End Sub)

        simpleTask.Start()

        Dim simpleTask2 = Task.Run(Sub()
                                       'Do your work here...
                                   End Sub)
        simpleTask.Wait(1000)
        If simpleTask.IsCompleted Then
            'completed
        Else
            'timeout
        End If

        Dim taskA = Task.Factory.StartNew(Sub() Console.WriteLine("Task A"))
        Dim taskB = Task.Factory.StartNew(Sub() Console.WriteLine("Task B"))
        Dim taskC = Task.Factory.StartNew(Sub() Console.WriteLine("Task C"))
    End Sub

#Region "Cancellation"
    Sub CancellationDemo()
        Dim tokenSource As New CancellationTokenSource()
        Dim token As CancellationToken = tokenSource.Token
        Dim tokenSource1 As New CancellationTokenSource(TimeSpan.FromSeconds(5))
        Dim aTask = Task.Factory.StartNew(Sub() DoSomething(token))

        'Dim aTask = Task.Factory.StartNew(Sub() DoSomething(token), token)

        Thread.Sleep(1000)

        tokenSource.Cancel()

        Try
            aTask.Wait()
        Catch ex As AggregateException
            'Handle concurrent exceptions here...
            Console.WriteLine(ex.InnerExceptions?.FirstOrDefault.Message)
        Catch ex As Exception

        End Try

        Console.WriteLine(aTask.Status)
    End Sub

    Sub DoSomething(cancelToken As CancellationToken)

        For i As Integer = 0 To 1000
            cancelToken.ThrowIfCancellationRequested()

            'Simulates some work
            Thread.Sleep(10000)
        Next

    End Sub

#End Region

#Region "Exception handling"

    Sub ExceptionDemo()

        Dim aTask = Task.Run(Sub()
                                 'this file does not exist, throw an exception
                                 Dim file1 =
                                 My.Computer.FileSystem.ReadAllText("C:\MyFile.txt")
                             End Sub)
        Dim bTask = Task.Run(Sub()
                                 'this file does not exist, throw an exception
                                 Dim file2 =
                                 My.Computer.FileSystem.ReadAllText("C:\MyFile2.txt")
                             End Sub)
        Try
            Task.WaitAll(aTask, bTask)
        Catch ex As AggregateException
            For Each fault In ex.Flatten.InnerExceptions
                If TypeOf (fault) Is InvalidOperationException Then
                    'Handle the exception here..
                ElseIf TypeOf (fault) Is NullReferenceException Then
                    'Handle the exception here..
                ElseIf TypeOf (fault) Is IO.FileNotFoundException Then
                    'Handle the exception here..
                End If
            Next
        Catch ex As Exception

        End Try

    End Sub

#End Region

#Region "Tasks that return a value"

    Sub CreateTasksWithValue()

        Dim taskWithResult = Task(Of Double).
            Factory.StartNew(Function()
                                 Dim radians As Double _
                                     = 120 * Math.PI / 180
                                 Dim tan As Double = _
                                     Math.Tan(radians)
                                 Return tan
                             End Function)

        Console.WriteLine(taskWithResult.Result)
    End Sub

    Private Function CalcTan(ByVal angle As Double) As Double

        Dim tangentResult As Double

        Dim t = Task(Of Double).Factory.
            StartNew(Function()
                         Dim radians As Double = angle * Math.PI / 180
                         tangentResult = Math.Tan(radians)
                         Return tangentResult
                     End Function)
        Return t.Result
    End Function

#End Region

#Region "Task scheduler interaction"
    Private Sub TaskSchedulerInteractionDemo()

        Console.WriteLine("The maximum concurrency level is {0}",
                          TaskScheduler.Current.MaximumConcurrencyLevel)

    End Sub
#End Region


#Region "Barrier"

    Sub BarrierDemo()
        ' Create a barrier with three participants
        ' The Sub lambda provides an action that will be taken
        ' at the end of the phase
        Dim myBarrier As New Barrier(3,
                                   Sub(b)
                                       Console.
                                       WriteLine("Barrier has been " & _
                                                 "reached (phase number: {0})",
                                                         b.CurrentPhaseNumber)
                                   End Sub)

        ' This is the sample work made by all participant tasks
        Dim myAction As Action =
            Sub()
                For i = 1 To 3
                    Dim threadId As Integer = Thread.CurrentThread.ManagedThreadId
                    Console.WriteLine("Thread {0} before wait.", threadId)

                    'Waits for other tasks to arrive at this same point:
                    myBarrier.SignalAndWait()
                    Console.WriteLine("Thread {0} after wait.", threadId)
                Next
            End Sub

        ' Starts three tasks, representing the three participants
        Parallel.Invoke(myAction, myAction, myAction)

        ' Once done, disposes the Barrier.
        myBarrier.Dispose()
    End Sub

#End Region
End Module