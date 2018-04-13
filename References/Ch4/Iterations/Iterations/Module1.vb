Module Module1

    Sub Main()

        ForNextDemo()
        ForEachDemo()
        Console.ReadLine()
    End Sub

End Module

Module Iterations

    Sub ForNextDemo()

        For i As Integer = 1 To 10
            Console.WriteLine("This action has been repeated {0} times", i)
        Next

        For i As Integer = 1 To 10 Step 2
            Console.WriteLine("Current value is {0}", i)
        Next

        For i As Integer = 1 To 10
            Console.WriteLine("Current value is {0}", i)
            If i = 4 Then Exit For
        Next

        For i As Integer = 1 To 10
            If i = 4 Then  'Ignore the 4 value
                i += 1 'Increments to 5
                Continue For  'Continues from next value, that is 6
            End If
            Console.WriteLine("Current value is  {0}", i)
        Next
    End Sub

    Sub ForEachDemo()

        'A collection of Process objects
        Dim procList As List(Of Process) = Process.GetProcesses.ToList

        For Each proc As Process In procList
            Console.WriteLine(proc.ProcessName)
            Console.WriteLine("     " & proc.Id)
        Next

        'A collection of Person objects
        Dim people As New List(Of Person)
        people.Add(New Person With {.FirstName = "Alessandro", .LastName = "Del Sole"})
        people.Add(New Person With {.FirstName = "My Fantasy Name", .LastName = "My Fantasy Lastname"})

        For Each p As Person In people
            p.LastName = "Dr. " & p.LastName
            Console.WriteLine(p.LastName)
        Next
    End Sub

End Module