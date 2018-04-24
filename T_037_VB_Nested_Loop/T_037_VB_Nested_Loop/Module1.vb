
'VB.Net -Nested Loops
'VB.Net allows using one loop inside another loop. Following section shows few examples to illustrate the concept.

'Syntax:
'The syntax For a nested For Loop statement In VB.Net Is As follows

'For counter1 [ As datatype1 ] = start1 To end1 [ Step step1 ]
'    For counter2 [ As datatype2 ] = start2 To end2 [ Step step2 ]
'    ...
'    Next [ counter2 ]
'Next [ counter 1]
'The syntax For a nested While Loop statement In VB.Net Is As follows

'While condition1
'While condition2
'...
'    End While
'End While
'The syntax For a nested Do...While Loop statement In VB.Net Is As follows

'Do { While | Until } condition1
'    Do { While | Until } condition2
'    ...
'    Loop
'Loop
'A final note On Loop nesting Is that you can put any type Of Loop inside Of any other type Of Loop. For example, a For Loop can be inside a While Loop Or vice versa.

Module Module1

    Sub Main()
        ' local variable definition 
        Dim i, j As Integer
        For i = 2 To 100
            For j = 2 To i
                ' if factor found, not prime
                If ((i Mod j) = 0) Then
                    Exit For
                End If
            Next j
            If (j > (i \ j)) Then
                Console.WriteLine("{0} is prime", i)
            End If
        Next i
        Console.ReadLine()
    End Sub

End Module
