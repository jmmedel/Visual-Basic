
'VB.Net - For...Next Loop
'It repeats a group Of statements a specified number Of times And a Loop index counts the number Of Loop iterations As the Loop executes.

'The syntax For this Loop construct Is

'For counter [ As datatype ] = start To end [ Step step ]
'    [ statements ]
'    [ Continue For ]
'    [ statements ]
'    [ Exit For ]
'    [ statements ]
'Next [ counter ]


Module Module1

    Sub Main()
        Dim a As Byte
        ' for loop execution 
        For a = 10 To 20
            Console.WriteLine("value of a: {0}", a)
        Next
        Console.ReadLine()
    End Sub

End Module

'When the above code Is compiled And executed, it produces the following result

'value of a: 10
'value of a: 11
'value of a: 12
'value of a: 13
'value of a: 14
'value of a: 15
'value of a: 16
'value of a: 17
'value of a: 18
'value of a: 19
'value of a: 20
