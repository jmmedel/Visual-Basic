
'VB.Net - Select Case Statement
'    A Select Case statement allows a variable to be tested for equality against a list of values. Each value Is called a case, And the variable being switched on Is checked for each select case.

'Syntax:
'The syntax For a Select Case statement In VB.Net Is As follows

'Select Case[ Case ] expression
'    [ Case expressionlist
'        [ statements ] ]
'    [ Case Else
'        [ elsestatements ] ]
'End Select
'Where,

'expression: Is an expression that must evaluate to any of the elementary data type in VB.Net, i.e., Boolean, Byte, Char, Date, Double, Decimal, Integer, Long, Object, SByte, Short, Single, String, UInteger, ULong, And UShort.

'expressionlist: List of expression clauses representing match values for expression. Multiple expression clauses are separated by commas.

'statements: statements following Case that run If the Select expression matches any clause In expressionlist.

'elsestatements: statements following Case Else that run If the Select expression does Not match any clause In the expressionlist Of any Of the Case statements.


Module Module1

    Sub Main()
        'local variable definition
        Dim grade As Char
        grade = "C"
        Select Case grade
            Case "A"
                Console.WriteLine("Excellent!")
            Case "B", "C"
                Console.WriteLine("Well done")
            Case "D"
                Console.WriteLine("You passed")
            Case "F"
                Console.WriteLine("Better try again")
            Case Else
                Console.WriteLine("Invalid grade")
        End Select
        Console.WriteLine("Your grade is  {0}", grade)
        Console.ReadLine()
    End Sub

End Module


'When the above code Is compiled And executed, it produces the following result:

'Well done
'Your grade Is C

