
'Arithmetic Operators
'Following table shows all the arithmetic operators supported by VB.Net. Assume variable A holds 2 And variable B holds 7, Then:

'Show Examples

'Operator    Description	Example
'^	Raises one operand to the power of another	B^A will give 49
'+	Adds two operands	A + B will give 9
'-	Subtracts second operand from the first	A - B will give -5
'*	Multiplies both operands	A * B will give 14
'/	Divides one operand by another And returns a floating point result	B / A will give 3.5
'\	Divides one operand by another And returns an integer result	B \ A will give 3
'Mod	Modulus Operator And remainder of after an integer division	B Mod A will give 1



Module Module1

    Sub Main()
        Dim a As Integer = 21
        Dim b As Integer = 10
        Dim p As Integer = 2
        Dim c As Integer
        Dim d As Single
        c = a + b
        Console.WriteLine("Line 1 - Value of c is {0}", c)
        c = a - b
        Console.WriteLine("Line 2 - Value of c is {0}", c)
        c = a * b
        Console.WriteLine("Line 3 - Value of c is {0}", c)
        d = a / b
        Console.WriteLine("Line 4 - Value of d is {0}", d)
        c = a \ b
        Console.WriteLine("Line 5 - Value of c is {0}", c)
        c = a Mod b
        Console.WriteLine("Line 6 - Value of c is {0}", c)
        c = b ^ p
        Console.WriteLine("Line 7 - Value of c is {0}", c)
        Console.ReadLine()
    End Sub

End Module


'When the above code Is compiled And executed, it produces the following result

'Line 1 - Value of c Is 31
'Line 2 - Value of c Is 11
'Line 3 - Value of c Is 210
'Line 4 - Value of d Is 2.1
'Line 5 - Value of c Is 2
'Line 6 - Value of c Is 1
'Line 7 - Value of c Is 100
