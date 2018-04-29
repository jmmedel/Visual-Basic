

'VB.Net - GoTo Statement
'    The GoTo statement transfers control unconditionally to a specified line in a procedure.

'The syntax For the GoTo statement Is

'GoTo label


Module Module1

    Sub Main()
        ' local variable definition 
        Dim a As Integer = 10
Line1:
        Do
            If (a = 15) Then
                ' skip the iteration '
                a = a + 1
                GoTo Line1
            End If
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
'value of a: 16
'value of a: 17
'value of a: 18
'value of a: 19
