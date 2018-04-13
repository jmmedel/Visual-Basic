Imports System.Threading.Tasks
Imports System.Threading
Imports System.Collections.Concurrent
Module ParallelLoops

    Sub ClassicForTest()
        For i = 0 To 15
            Console.WriteLine(i.ToString + GetThreadId())
            SimulateProcessing()
        Next
    End Sub

    Sub ParallelForTest()

        'The compiler infers ParallelLoopState
        'for the loopState identifier
        Parallel.For(0, 16, Sub(i, loopState)
                                Console.WriteLine(i.ToString + GetThreadId())
                                SimulateProcessing()

                                If loopState.IsExceptional Then
                                    'an exception occurred
                                End If

                                'Breaks the loop at the 10th iteration
                                If i = 10 Then
                                    loopState.Break()
                                End If
                            End Sub)
    End Sub

    Sub ClassicForEachTest()
        Dim allFiles = IO.Directory.
            EnumerateFiles("C:\users\alessandro\pictures")

        For Each fileName In allFiles
            Console.WriteLine(fileName + GetThreadId())
            SimulateProcessing()
        Next
    End Sub

    Sub ParallelForEachTest()

        Dim allFiles = IO.Directory.EnumerateFiles("C:\users\alessandro\pictures")
        Parallel.ForEach(Of String)(allFiles, Sub(fileName)
                                                  Console.WriteLine(fileName + GetThreadId())
                                                  SimulateProcessing()
                                              End Sub)

        'With no buffering
        'Parallel.ForEach(Of String)(Partitioner.Create(allFiles, EnumerablePartitionerOptions.None), Sub()
        '                                                                                                 Console.WriteLine(fileName + GetThreadId())
        '                                                                                                 SimulateProcessing()
        '                                                                                             End Sub)
    End Sub

    Private Sub SimulateProcessing()
        Threading.Thread.SpinWait(80000000)
    End Sub

    Private Function GetThreadId() As String
        Return " Thread ID: " + Thread.CurrentThread.
                                ManagedThreadId.ToString
    End Function


End Module
