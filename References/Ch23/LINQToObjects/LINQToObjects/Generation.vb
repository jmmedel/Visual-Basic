Module Generation

    Sub RangeDemo()

        'The sequence will contain 100 numbers
        'The first number is 40
        Dim numbers = Enumerable.Range(40, 100)

        Dim query = From num In numbers
                    Where num Mod 2 = 1
                    Select num
    End Sub

    Sub RepeatDemo()
        Dim stringSequence = Enumerable.Repeat(Of Boolean)(True, 10)
    End Sub

End Module
