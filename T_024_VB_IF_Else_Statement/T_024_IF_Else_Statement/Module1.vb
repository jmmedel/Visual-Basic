

'VB.Net -If...Then...Else Statement

'An If statement can be followed by an optional Else statement, which executes when the Boolean expression Is false.

'Syntax:
'The syntax Of an If...Then... Else statement In VB.Net Is As follows

'If (boolean_expression) Then
''statement(s) will execute if the Boolean expression is true 
'Else
''statement(s) will execute if the Boolean expression is false 
'End If
'If the Boolean expression evaluates To True, Then the If block Of code will be executed, otherwise Else block Of code will be executed.

Module Module1

    Sub Main()
        'local variable definition '
        Dim a As Integer = 100

        ' check the boolean condition using if statement 
        If (a < 20) Then
            ' if condition is true then print the following 
            Console.WriteLine("a is less than 20")
        Else
            ' if condition is false then print the following 
            Console.WriteLine("a is not less than 20")
        End If
        Console.WriteLine("value of a is : {0}", a)
        Console.ReadLine()
    End Sub


End Module

'When the above code Is compiled And executed, it produces the following result

'a Is Not less than 20
'value of a Is : 100
