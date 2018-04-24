
'VB.Net -Assignment Operators
'There are following assignment operators supported by VB.Net

'Operator    Description	Example
'=	Simple assignment operator, Assigns values from right side operands to left side operand	C = A + B will assign value of A + B into C
'+=	Add And assignment operator, It adds right operand to the left operand And assigns the result to left operand	C += A Is equivalent to C = C + A
'-=	Subtract And assignment operator, It subtracts right operand from the left operand And assigns the result to left operand	C -= A Is equivalent to C = C - A
'*=	Multiply And assignment operator, It multiplies right operand with the left operand And assigns the result to left operand	C *= A Is equivalent to C = C * A
'/=	Divide And assignment operator, It divides left operand with the right operand And assigns the result to left operand (floating point division)	C /= A Is equivalent to C = C / A
'\=	Divide And assignment operator, It divides left operand with the right operand And assigns the result to left operand (Integer division)	C \= A Is equivalent to C = C \A
'^=	Exponentiation And assignment operator. It raises the left operand to the power of the right operand And assigns the result to left operand	C^=A Is equivalent to C = C ^ A
'<<=	Left shift And assignment operator	C <<= 2 Is same as C = C << 2
'>>=	Right shift And assignment operator	C >>= 2 Is same as C = C >> 2
'&=	Concatenates a String expression to a String variable Or property And assigns the result to the variable Or property.

Module Module1

    Sub Main()
        Dim a As Integer = 21
        Dim pow As Integer = 2
        Dim str1 As String = "Hello! "
        Dim str2 As String = "VB Programmers"
        Dim c As Integer
        c = a
        Console.WriteLine("Line 1 - =  Operator Example, _
	  Value of c = {0}", c)
        c += a
        Console.WriteLine("Line 2 - +=  Operator Example, _
	  Value of c = {0}", c)
        c -= a
        Console.WriteLine("Line 3 - -=  Operator Example, _
	  Value of c = {0}", c)
        c *= a
        Console.WriteLine("Line 4 - *=  Operator Example, _
	  Value of c = {0}", c)
        c /= a
        Console.WriteLine("Line 5 - /=  Operator Example, _
	  Value of c = {0}", c)
        c = 20
        c ^= pow
        Console.WriteLine("Line 6 - ^=  Operator Example, _
	  Value of c = {0}", c)
        c <<= 2
        Console.WriteLine("Line 7 - <<=  Operator Example,_
	  Value of c = {0}", c)
        c >>= 2
        Console.WriteLine("Line 8 - >>=  Operator Example,_
	  Value of c = {0}", c)
        str1 &= str2
        Console.WriteLine("Line 9 - &=  Operator Example,_
	  Value of str1 = {0}", str1)
        Console.ReadLine()
    End Sub


End Module


'When the above code is compiled and executed, it produces the following result:

'Line 1 - =  Operator Example, Value of c = 21
'Line 2 - += Operator Example, Value of c = 42
'Line 3 - -= Operator Example, Value of c = 21
'Line 4 - *= Operator Example, Value of c = 441
'Line 5 - /= Operator Example, Value of c = 21
'Line 6 - ^= Operator Example, Value of c = 400
'Line 7 - <<= Operator Example, Value of c = 1600
'Line 8 - >>= Operator Example, Value of c = 400
'Line 9 - &= Operator Example, Value of str1 = Hello! VB Programmers
