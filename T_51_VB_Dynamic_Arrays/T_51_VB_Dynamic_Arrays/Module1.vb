
'Dynamic Arrays
'Dynamic arrays are arrays that can be dimensioned And re-dimensioned As par the need Of the program. You can Declare a dynamic array Using the ReDim statement.

'Syntax for ReDim statement

'ReDim [Preserve] arrayname(subscripts)
'Where,

'The Preserve keyword helps To preserve the data In an existing array, When you resize it.

'arrayname Is the name of the array to re-dimension.

'subscripts specifies the New dimension.

Module Module1

    Sub Main()
        Dim marks() As Integer
        ReDim marks(2)
        marks(0) = 85
        marks(1) = 75
        marks(2) = 90
        ReDim Preserve marks(10)
        marks(3) = 80
        marks(4) = 76
        marks(5) = 92
        marks(6) = 99
        marks(7) = 79
        marks(8) = 75
        For i = 0 To 10
            Console.WriteLine(i & vbTab & marks(i))
        Next i
        Console.ReadKey()
    End Sub

End Module



'When the above code Is compiled And executed, it produces the following result

'0   85
'1   75
'2   90
'3   80
'4   76
'5   92
'6   99
'7   79
'8   75
'9   0
'10  0

