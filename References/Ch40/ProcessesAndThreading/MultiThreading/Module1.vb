Imports System.Threading

Module Module1

    Sub Main()

        simpleThread()
        threadWithParameters("Parameterized thread demonstration")
        lambdaThread()

        QueueWork()

        Console.ReadLine()
    End Sub


    Private Sub simpleThread()
        Dim newThread As New Thread(New ThreadStart(AddressOf _
                                                    executeSimpleThread))
        newThread.Start()
    End Sub

    Private Sub executeSimpleThread()
        Console.WriteLine("Running a separate thread")
    End Sub


    Private Sub threadWithParameters(ByVal parameter As Object)
        Dim newThread As New Thread(New  _
                                    ParameterizedThreadStart(AddressOf _
                                    executeThreadWithParameters))
        newThread.Start(parameter)
    End Sub

    Private Sub executeThreadWithParameters(ByVal anArgument As Object)
        Dim aString = CType(anArgument, String)
        Console.WriteLine(aString)
    End Sub

    Private Sub lambdaThread()
        Dim newThread As New Thread(New ThreadStart(Sub()
                                                        Console.WriteLine("Thread with lambda")
                                                    End Sub))
        newThread.Start()
    End Sub
End Module
