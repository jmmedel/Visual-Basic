Module Module1

    Sub Main()
        Console.WriteLine("Normal for loop")

        For index = 1 To 10
            Console.WriteLine(index)
        Next
        Console.WriteLine()
        Console.WriteLine("For loop that exits before its finished")
        For index = 1 To 23
            Console.WriteLine(index)
            If index = 4 Then
                'Exit to the loop '
                Exit For
            End If
        Next
        Console.ReadLine()
    End Sub

End Module
