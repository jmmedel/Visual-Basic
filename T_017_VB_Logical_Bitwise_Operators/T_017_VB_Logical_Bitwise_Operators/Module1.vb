
'VB.Net -Logical / Bitwise Operators
'Following table shows all the logical operators supported by VB.Net. Assume variable A holds Boolean value True And variable B holds Boolean value False, Then

'Operator    Description	Example
'And	It Is the logical as well as bitwise And operator. If both the operands are true, then condition becomes true. This operator does Not perform short-circuiting, i.e., it evaluates both the expressions.	(A And B) Is False.
'Or	It Is the logical as well as bitwise Or operator. If any of the two operands Is true, then condition becomes true. This operator does Not perform short-circuiting, i.e., it evaluates both the expressions.	(A Or B) Is True.
'Not	It Is the logical as well as bitwise Not operator. Used to reverse the logical state of its operand. If a condition Is true, then Logical Not operator will make false.	Not(A And B) Is True.
'Xor	It Is the logical as well as bitwise Logical Exclusive Or operator. It returns False if both expressions are True Or both expressions are False; otherwise, it returns True. This operator does Not perform short-circuiting, it always evaluates both expressions And there Is no short-circuiting counterpart of this operator	A Xor B Is True.
'AndAlso	It Is the logical And operator. It works only on Boolean data. It performs short-circuiting.	(A AndAlso B) Is False.
'OrElse	It Is the logical Or operator. It works only on Boolean data. It performs short-circuiting.	(A OrElse B) Is True.
'IsFalse It determines whether an expression Is False.	
'IsTrue  It determines whether an expression Is True.	
'Try the following example To understand all the logical/bitwise operators available In VB.Net


Module Module1

    Sub Main()
        Dim a As Boolean = True
        Dim b As Boolean = True
        Dim c As Integer = 5
        Dim d As Integer = 20
        'logical And, Or and Xor Checking
        If (a And b) Then
            Console.WriteLine("Line 1 - Condition is true")
        End If
        If (a Or b) Then
            Console.WriteLine("Line 2 - Condition is true")
        End If
        If (a Xor b) Then
            Console.WriteLine("Line 3 - Condition is true")
        End If
        'bitwise And, Or and Xor Checking
        If (c And d) Then
            Console.WriteLine("Line 4 - Condition is true")
        End If
        If (c Or d) Then
            Console.WriteLine("Line 5 - Condition is true")
        End If
        If (c Or d) Then
            Console.WriteLine("Line 6 - Condition is true")
        End If
        'Only logical operators
        If (a AndAlso b) Then
            Console.WriteLine("Line 7 - Condition is true")
        End If
        If (a OrElse b) Then
            Console.WriteLine("Line 8 - Condition is true")
        End If

        ' lets change the value of  a and b 
        a = False
        b = True
        If (a And b) Then
            Console.WriteLine("Line 9 - Condition is true")
        Else
            Console.WriteLine("Line 9 - Condition is not true")
        End If
        If (Not (a And b)) Then
            Console.WriteLine("Line 10 - Condition is true")
        End If
        Console.ReadLine()
    End Sub


End Module


'When the above code Is compiled And executed, it produces the following result

'Line 1 - Condition Is True
'Line 2 - Condition Is True
'Line 3 - Condition Is True
'Line 4 - Condition Is True
'Line 5 - Condition Is True
'Line 6 - Condition Is True
'Line 7 - Condition Is True
'Line 8 - Condition Is True
'Line 9 - Condition Is Not True
'Line 10 - Condition Is True


