
'VB.Net -Operators Precedence
'Operator precedence determines the grouping of terms in an expression. This affects how an expression Is evaluated. Certain operators have higher precedence than others; for example, the multiplication operator has higher precedence than the addition operator

'For example, x = 7 + 3 * 2; here, x Is assigned 13, Not 20 because operator * has higher precedence than +, so it first get multiplied with 3*2 And then adds into 7.

'Here, Operators With the highest precedence appear at the top Of the table, those With the lowest appear at the bottom. Within an expression, higher precedence operators will be evaluated first.

'Operator    Precedence
'Await   Highest
'Exponentiation(^)
'    Unary identity And negation(+, -)  
'Multiplication And floating - point division (*, /)	
'Integer division(\)    
'Modulus arithmetic(Mod)    
'Addition And subtraction(+, -) 
'Arithmetic bit shift (<<, >>)	
'All Comparison operators (=, <>, <, <=, >, >=, Is, IsNot, Like, TypeOf...Is)	
'Negation (Not)	
'Conjunction (And, AndAlso)	
'Inclusive disjunction (Or, OrElse)	
'Exclusive disjunction (Xor)	Lowest


Module Module1

    Sub Main()
        Dim a As Integer = 20
        Dim b As Integer = 10
        Dim c As Integer = 15
        Dim d As Integer = 5
        Dim e As Integer
        e = (a + b) * c / d      ' ( 30 * 15 ) / 5
        Console.WriteLine("Value of (a + b) * c / d is : {0}", e)
        e = ((a + b) * c) / d    ' (30 * 15 ) / 5
        Console.WriteLine("Value of ((a + b) * c) / d is  : {0}", e)
        e = (a + b) * (c / d)   ' (30) * (15/5)
        Console.WriteLine("Value of (a + b) * (c / d) is  : {0}", e)
        e = a + (b * c) / d     '  20 + (150/5)
        Console.WriteLine("Value of a + (b * c) / d is  : {0}", e)
        Console.ReadLine()
    End Sub

End Module


'When the above code Is compiled And executed, it produces the following result

'Value of (a + b) * c / d Is : 90
'Value of ((a + b) * c) / d Is  : 90
'Value of (a + b) * (c / d) Is  : 90
'Value of a + (b * c) / d Is  : 50

