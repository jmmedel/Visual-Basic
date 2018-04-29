
'Following table shows all the comparison operators supported by VB.Net. Assume variable A holds 10 And variable B holds 20, Then

'Operator    Description	Example
'=	Checks if the values of two operands are equal Or Not; if yes, then condition becomes true.	(A = B) Is Not true.
'<>	Checks if the values of two operands are equal Or Not; if values are Not equal, then condition becomes true.	(A <> B) Is true.
'>	Checks if the value of left operand Is greater than the value of right operand; if yes, then condition becomes true.	(A > B) Is Not true.
'<	Checks if the value Of left operand Is less than the value Of right operand; If yes, then condition becomes True.	(A < B) Is True.
'>=	Checks if the value of left operand Is greater than Or equal to the value of right operand; if yes, then condition becomes true.	(A >= B) Is Not true.
'<=	Checks if the value of left operand Is less than Or equal to the value of right operand; if yes, then condition becomes true.	(A <= B) Is true.
'Try the following example To understand all the relational operators available In VB.Net:

Module Module1

    Sub Main()
        Dim a As Integer = 21
        Dim b As Integer = 10
        If (a = b) Then
            Console.WriteLine("Line 1 - a is equal to b")
        Else
            Console.WriteLine("Line 1 - a is not equal to b")
        End If
        If (a < b) Then
            Console.WriteLine("Line 2 - a is less than b")
        Else
            Console.WriteLine("Line 2 - a is not less than b")
        End If
        If (a > b) Then
            Console.WriteLine("Line 3 - a is greater than b")
        Else
            Console.WriteLine("Line 3 - a is not greater than b")
        End If
        ' Lets change value of a and b 
        a = 5
        b = 20
        If (a <= b) Then
            Console.WriteLine("Line 4 - a is either less than or equal to  b")
        End If
        If (b >= a) Then
            Console.WriteLine("Line 5 - b is either greater than  or equal to b")
        End If
        Console.ReadLine()
    End Sub

End Module




'When the above code Is compiled And executed, it produces the following result

'Line 1 - a Is Not equal to b
'Line 2 - a Is Not less than b
'Line 3 - a Is greater than b
'Line 4 - a Is either less than Or equal to b
'Line 5 - b Is either greater than Or equal to b
'Apart from the above, VB.Net provides three more comparison operators, which we will be Using In forthcoming chapters; however, we give a brief description here.

'Is Operator - It compares two object reference variables And determines if two object references refer to the same object without performing value comparisons. If object1 And object2 both refer to the exact same object instance, result Is True; otherwise, result Is False.

'IsNot Operator - It also compares two object reference variables And determines if two object references refer to different objects. If object1 And object2 both refer to the exact same object instance, result Is False; otherwise, result Is True.

'Like Operator - It compares a string against a pattern.
