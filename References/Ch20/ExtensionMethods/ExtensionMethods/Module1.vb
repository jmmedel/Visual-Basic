Module Module1

    Sub CheckString()
        Dim email As String = "Alessandro.delsole@visual-basic.it"
        If email.IsValidEMail Then
            Console.WriteLine("Valid address")
        Else
            Console.WriteLine("Invalid address")
        End If
    End Sub

    Sub Main()

        Dim processList As List(Of Process) = Process.GetProcesses.ToList
        Dim processEnumerable As IEnumerable(Of Process) =
                                 Process.GetProcesses.AsEnumerable
        Filter()
        Console.ReadLine()

    End Sub

    Sub Filter()
        'A real app example would use
        'a lambda expression instead of a delegate
        Dim filteredProcessList = Process.GetProcesses.Where(AddressOf EvaluateProcess)

        For Each proc In filteredProcessList
            Console.WriteLine(proc.ProcessName)
        Next
    End Sub

    Private Function EvaluateProcess(ByVal p As Process) As Boolean
        If p.ProcessName.ToLowerInvariant.StartsWith("e") Then
            Return True
        Else
            Return False
        End If
    End Function
End Module