
'VB.Net -If...Then Statement

'It Is the simplest form Of control statement, frequently used in decision making And changing the control flow of the program execution. Syntax for if-then statement Is

'If condition Then
'[Statement(s)]
'End If
'Where, condition Is a Boolean Or relational condition And Statement(s) Is a simple Or compound statement. Example of an If-Then statement Is

'If (a <= 20) Then
'c = c + 1
'End If
'If the condition evaluates To True, Then the block Of code inside the If statement will be executed. If condition evaluates To False, Then the first Set Of code after the End Of the If statement (after the closing End If) will be executed.

Module Module1

    Sub Main()
        'local variable definition 
        Dim a As Integer = 10

        ' check the boolean condition using if statement 
        If (a < 20) Then
            ' if condition is true then print the following 
            Console.WriteLine("a is less than 20")
        End If
        Console.WriteLine("value of a is : {0}", a)
        Console.ReadLine()
    End Sub

End Module


'When the above code Is compiled And executed, it produces the following result

'a Is less than 20
'value of a Is : 10