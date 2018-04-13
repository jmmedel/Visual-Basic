Module BitwiseOperators

    Sub BitwiseDemo()
        Dim result As Integer = 152 And 312
        Dim result2 As Integer = 152 Or 312
        Dim result3 As Integer = 152 Xor 312
        Dim result4 As Integer = Not 312

        Console.WriteLine(result4)
    End Sub
End Module