
'The If...Else If...Else Statement
'An If statement can be followed by an optional Else if...Else statement, which Is very useful to test various conditions using single If...Else If statement.

'When using If... Else If... Else statements, there are few points to keep in mind.

'An If can have zero Or one Else's and it must come after an Else If's.

'An If can have zero to many Else If's and they must come before the Else.

'Once an Else If succeeds, none Of the remaining Else If's or Else's will be tested.

'Syntax:
'The syntax Of an If...Else If...Else statement In VB.Net Is As follows

'If (boolean_expression 1)Then
'' Executes when the boolean expression 1 is true 
'ElseIf (boolean_expression 2)Then
'' Executes when the boolean expression 2 is true 
'ElseIf (boolean_expression 3)Then
'' Executes when the boolean expression 3 is true 
'Else
'' executes when the none of the above condition is true 
'End If



Module Module1

    Sub Main()
        'local variable definition '
        Dim a As Integer = 100
        ' check the boolean condition '
        If (a = 10) Then
            ' if condition is true then print the following '
            Console.WriteLine("Value of a is 10") '
        ElseIf (a = 20) Then
            'if else if condition is true '
            Console.WriteLine("Value of a is 20") '
        ElseIf (a = 30) Then
            'if else if condition is true  
            Console.WriteLine("Value of a is 30")
        Else
            'if none of the conditions is true 
            Console.WriteLine("None of the values is matching")
        End If
        Console.WriteLine("Exact value of a is: {0}", a)
        Console.ReadLine()
    End Sub

End Module


'When the above code Is compiled And executed, it produces the following result

'None of the values Is matching
'Exact value Of a Is: 100
