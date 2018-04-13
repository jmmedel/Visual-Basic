Module Module1

    Sub Main()
        Using client As New Net.WebClient
            client.DownloadString("http://community.visual-basic.it/Alessandro/rss.aspx")
        End Using

        Console.ReadLine()

        Console.WriteLine("Enter a valid string:")
        Dim lineRead As String = Console.ReadLine()

        Dim result As Boolean = Test(lineRead)


        'Trace.Listeners.Clear()
        'Trace.Listeners.Add(New TextWriterTraceListener("C:\users\alessandro\desktop\TraceOutput.txt"))
        ''This will ensure the file is closed when
        ''the debugger shuts down
        'Trace.AutoFlush = True
        'Trace.WriteLineIf(result = True, "You entered a valid string")


        'Dim dl As New DelimitedListTraceListener("C:\users\alessandro\desktop\DelimitedTraceOutput.txt")
        'Trace.Listeners.Add(dl)
        'Trace.AutoFlush = True
        'Trace.WriteLine("Result")
        'Trace.WriteLineIf(result = True, "You entered a valid string")

        'Trace.Listeners.Clear()
        'Trace.Listeners.Add(New XmlWriterTraceListener("C:\users\alessandro\desktop\TraceOutput.xml"))
        ''This will ensure the file is closed when
        ''the debugger shuts down
        'Trace.AutoFlush = True
        'Trace.WriteLineIf(result = True, "You entered a valid string")

        'Trace.Listeners.Clear()
        'Trace.Listeners.Add(New EventSchemaTraceListener("C:\users\alessandro\desktop\Test.xsd",
        '                                                 "My listener",
        '                                                 32768,
        '                                                 TraceLogRetentionOption.LimitedCircularFiles,
        '                                                 65536, 10))
        ''This will ensure the file is closed when
        ''the debugger shuts down
        'Trace.AutoFlush = True
        'Trace.WriteLineIf(result = True, "You entered a valid string")

        'Trace.Listeners.Clear()
        'Trace.Listeners.Add(New EventLogTraceListener("Chapter 5 - Debugging VB 2015 Applications"))

        'This will ensure the file is closed when
        'the debugger shuts down
        'Trace.AutoFlush = True
        'Trace.WriteLineIf(result = True, "You entered a valid string")

        Console.WriteLine("Is a valid string: " & result.ToString)
        Console.ReadLine()
    End Sub

    Function Test(ByVal name As String) As Boolean
        If String.IsNullOrEmpty(name) = False Then
            Return True
        ElseIf name = ""
            Return False
        Else
            Return False
        End If
    End Function

    Sub DebuggerProxyDemo()
        Dim p As New List(Of Person)
        'Populates the list
        p.Add(New Person With {.FirstName = "Alessandro", .LastName = "Del Sole"})
        p.Add(New Person With {.FirstName = "MyFantasyName", .LastName = "MyFantasyLastName"})
    End Sub
End Module

Class DebuggerAttributesDemo

    'Forces the debugger to execute the code in run mode.
    'Stepping disallowed
    <DebuggerStepperBoundary()> Sub DoSomething()

    End Sub

    <DebuggerBrowsable(DebuggerBrowsableState.RootHidden)>
    Private ProcessesList As Process()

    Sub ShowProcesses()
        ProcessesList = Process.GetProcesses
    End Sub

End Class


<DebuggerTypeProxy(GetType(PersonProxy))>
Class Person
    Property FirstName As String
    Property LastName As String

End Class


Class PersonProxy

    Dim myProxy As Person

    Sub New(ByVal OnePerson As Person)
        myProxy = OnePerson
    End Sub

    ReadOnly Property Length As Integer
        Get
            Return String.Concat(myProxy.FirstName, " ", myProxy.LastName).Length
        End Get
    End Property

End Class