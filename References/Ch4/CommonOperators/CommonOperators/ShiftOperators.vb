Module ShiftOperators

    Sub ShiftDemo()

        'Binary counterpart is
        '101000100
        Dim firstValue As Integer = 324

        'Returns 5184, which is
        '1010001000000
        Dim leftValue As Integer = firstValue << 4

        'Returns 20, which is
        '10100
        Dim rightValue As Integer = firstValue >> 4

        Console.WriteLine(rightValue)
    End Sub

End Module