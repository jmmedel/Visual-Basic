Imports System.Threading

Module UsingThreadPool

    Sub QueueWork()

        ThreadPool.QueueUserWorkItem(New WaitCallback(AddressOf FirstWorkItem))
        ThreadPool.QueueUserWorkItem(New WaitCallback(AddressOf SecondWorkItem))
        ThreadPool.QueueUserWorkItem(New WaitCallback(Sub()
                                                          Console.WriteLine("Third work item")
                                                      End Sub))

        PoolInfo()
    End Sub

    Private Sub FirstWorkItem(ByVal state As Object)
        Console.WriteLine("First work item")
    End Sub
    Private Sub SecondWorkItem(ByVal state As Object)
        Console.WriteLine("Second work item")
    End Sub

    Sub PoolInfo()
        Dim workerThreads As Integer
        Dim completionPortThreads As Integer

        ThreadPool.GetAvailableThreads(workerThreads,
                                       completionPortThreads)
        Console.WriteLine("Available threads: {0}, async I/O: {1}",
                          workerThreads, completionPortThreads)

        Console.ReadLine()
    End Sub

    Private customers As New List(Of String)
    Private lockObject As New Object()

    Sub AddCustomer(ByVal customerName As String)

        SyncLock lockObject
            customers.Add(customerName)
        End SyncLock
    End Sub

    Sub AddMonitoredCustomer(ByVal customerName As String)
        Dim result As Boolean

        Try
            Monitor.Enter(lockObject, result)
            customers.Add(customerName)
        Catch ex As Exception
        Finally
            Monitor.Exit(lockObject)
        End Try
    End Sub

    Private rw As New ReaderWriterLockSlim

    Sub AddC(ByVal customerName As String)
        Try

            rw.EnterWriteLock()
            customers.Add(customerName)
        Catch ex As Exception
        Finally
            rw.ExitWriteLock()
        End Try
    End Sub

    Sub GetInformation()
        Try
            rw.EnterReadLock()
            Console.WriteLine(customers.Count.ToString)
        Catch ex As Exception
        Finally
            rw.ExitReadLock()
        End Try
    End Sub

End Module

