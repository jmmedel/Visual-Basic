
'VB.Net - While... End While Loop

'It executes a series Of statements As Long As a given condition Is True.

'The syntax For this Loop construct Is

'While condition
'    [ statements ]
'    [ Continue While ]
'    [ statements ]
'    [ Exit While ]
'    [ statements ]
'End While
'Here, statement(s) may be a Single statement Or a block Of statements. The condition may be any expression, And True Is logical true. The loop iterates while the condition Is true.

'When the condition becomes false, program control passes to the line immediately following the loop.

'Here, key point Of the While Loop Is that the Loop might Not ever run. When the condition Is tested And the result Is False, the loop body will be skipped And the first statement after the while loop will be executed.

Module Module1

    Sub Main()
        Dim a As Integer = 10
        ' while loop execution '
        While a < 20
            Console.WriteLine("value of a: {0}", a)
            a = a + 1
        End While
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
