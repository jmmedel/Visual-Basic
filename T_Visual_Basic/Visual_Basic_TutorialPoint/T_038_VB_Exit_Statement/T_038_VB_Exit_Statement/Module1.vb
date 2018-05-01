


'VB.Net - Exit Statement
'    The Exit statement transfers the control from a procedure Or block immediately to the statement following the procedure call Or the block definition. It terminates the loop, procedure, try block Or the select block from where it Is called.

'If you are Using nested loops (i.e., one Loop inside another Loop), the Exit statement will Stop the execution Of the innermost Loop And start executing the Next line Of code after the block.

'Syntax:
'The syntax For the Exit statement Is

'Exit { Do | For | Function | Property | Select | Sub | Try | While }


Module Module1

    Sub Main()
        ' local variable definition 
        Dim a As Integer = 10
        ' while loop execution '
        While (a < 20)
            Console.WriteLine("value of a: {0}", a)
            a = a + 1
            If (a > 15) Then
                'terminate the loop using exit statement 
                Exit While
            End If
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

