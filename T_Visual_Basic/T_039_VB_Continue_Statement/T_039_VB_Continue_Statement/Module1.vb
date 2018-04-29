

'VB.Net - Continue Statement
'    The Continue statement causes the loop to skip the remainder of its body And immediately retest its condition prior to reiterating. It works somewhat Like the Exit statement. Instead of forcing termination, it forces the Next iteration Of the Loop To take place, skipping any code in between.

'For the For...Next loop, Continue statement causes the conditional test And increment portions of the loop To execute.For the While And Do...While loops, Continue statement causes the program control To pass To the conditional tests.

'Syntax:
'The syntax For a Continue statement Is As follows

'Continue { Do | For | While }


Module Module1

    Sub Main()
        ' local variable definition 
        Dim a As Integer = 10
        Do
            If (a = 15) Then
                ' skip the iteration '
                a = a + 1
                Continue Do
            End If
            Console.WriteLine("value of a: {0}", a)
            a = a + 1
        Loop While (a < 20)
        Console.ReadLine()
    End Sub

End Module
