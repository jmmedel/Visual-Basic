
'VB.Net - Do Loop
'    It repeats the enclosed block Of statements While a Boolean condition Is True Or until the condition becomes True. It could be terminated at any time With the Exit Do statement.

'The syntax For this Loop construct Is

'Do { While | Until } condition
'    [ statements ]
'    [ Continue Do ]
'    [ statements ]
'    [ Exit Do ]
'    [ statements ]
'Loop
'-Or-
'Do
'    [ statements ]
'    [ Continue Do ]
'    [ statements ]
'    [ Exit Do ]
'    [ statements ]
'Loop { While | Until } condition

Module Module1

    Sub Main()
        ' local variable definition 
        Dim a As Integer = 10
        'do loop execution 
        Do
            Console.WriteLine("value of a: {0}", a)
            a = a + 1
        Loop While (a < 20)
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
