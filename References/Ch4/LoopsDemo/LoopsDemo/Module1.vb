Module Module1

    Sub Main()

        LoopWhileDemo()
        LoopUntilDemo()
        WhileEndWhileDemo()
        LoopUntilBottomDemo()
        LoopWhileBottomDemo()
        Console.ReadLine()

    End Sub

    Sub LoopWhileDemo()

        Dim max As Integer = 0

        Do While max < Integer.MaxValue
            max += 1
            'Do something else here
            If max = 7000000 Then Exit Do
        Loop

        Console.WriteLine("Done: " & max.ToString)
    End Sub

    Sub LoopUntilDemo()

        Dim max As Integer = 0
        Do Until max = Integer.MaxValue
            max += 1

            If max = 7000000 Then Exit Do
        Loop
        Console.WriteLine("Done: " & max.ToString)
    End Sub

    'Loop is executed at least once
    Sub LoopUntilBottomDemo()
        Dim max As Integer = 0
        Do
            max += 1
            If max = 7000000 Then Exit Do
        Loop Until max = Integer.MaxValue

        Console.WriteLine("Done: " & max.ToString)
    End Sub

    'Loop is executed at least once
    Sub LoopWhileBottomDemo()
        Dim max As Integer = 0
        Do
            max += 1
            If max = 7000000 Then Exit Do
        Loop While max < Integer.MaxValue
        Console.WriteLine("Done: " & max.ToString)
    End Sub

    Sub WhileEndWhileDemo()

        Dim max As Integer = 0

        While max < Integer.MaxValue
            max += 1

            If max = 7000000 Then Exit While
        End While

        Console.WriteLine("Done: " & max.ToString)
    End Sub
End Module

