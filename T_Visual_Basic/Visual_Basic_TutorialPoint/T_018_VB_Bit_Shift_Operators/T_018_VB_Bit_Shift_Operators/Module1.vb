
'VB.Net -Bit Shift Operators

'Assume that the variable A holds 60 And variable B holds 13, Then

'Operator    Description	Example
'And	Bitwise And Operator copies a bit to the result if it exists in both operands.	(A And B) will give 12, which Is 0000 1100
'Or	Binary Or Operator copies a bit if it exists in either operand.	(A Or B) will give 61, which Is 0011 1101
'Xor	Binary Xor Operator copies the bit if it Is set in one operand but Not both.	(A Xor B) will give 49, which Is 0011 0001
'Not	Binary Ones Complement Operator Is unary And has the effect of 'flipping' bits.	(Not A ) will give -61, which is 1100 0011 in 2's complement form due to a signed binary number.
'<<	Binary Left Shift Operator. The left operand's value is moved left by the number of bits specified by the right operand.	A << 2 will give 240, which is 1111 0000
'>>	Binary Right Shift Operator. The left operand's value is moved right by the number of bits specified by the right operand.	A >> 2 will give 15, which is 0000 1111
'Try the following example To understand all the bitwise operators available In VB.Net:


Module Module1

    Sub Main()
        Dim a As Integer = 60       ' 60 = 0011 1100   
        Dim b As Integer = 13       ' 13 = 0000 1101
        Dim c As Integer = 0
        c = a And b       ' 12 = 0000 1100 
        Console.WriteLine("Line 1 - Value of c is {0}", c)
        c = a Or b       ' 61 = 0011 1101 
        Console.WriteLine("Line 2 - Value of c is {0}", c)
        c = a Xor b       ' 49 = 0011 0001 
        Console.WriteLine("Line 3 - Value of c is {0}", c)
        c = Not a          ' -61 = 1100 0011 
        Console.WriteLine("Line 4 - Value of c is {0}", c)
        c = a << 2     ' 240 = 1111 0000 
        Console.WriteLine("Line 5 - Value of c is {0}", c)
        c = a >> 2    ' 15 = 0000 1111 
        Console.WriteLine("Line 6 - Value of c is {0}", c)
        Console.ReadLine()
    End Sub

End Module

'When the above code Is compiled And executed, it produces the following result

'Line 1 - Value of c Is 12
'Line 2 - Value of c Is 61
'Line 3 - Value of c Is 49
'Line 4 - Value of c Is -61
'Line 5 - Value of c Is 240
'Line 6 - Value of c Is 15

