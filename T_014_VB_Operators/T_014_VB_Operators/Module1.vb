

'VB.Net -Operators

'An Operator Is a symbol that tells the compiler to perform specific mathematical Or logical manipulations. VB.Net Is rich in built-in operators And provides following types of commonly used operators

'Arithmetic Operators

'Comparison Operators

'Logical/ Bitwise Operators

'Bit Shift Operators

'Assignment Operators

'Miscellaneous Operators

'This tutorial will explain the most commonly used operators.

'Arithmetic Operators
'Following table shows all the arithmetic operators supported by VB.Net. Assume variable A holds 2 And variable B holds 7, then

'Show Examples

'Operator    Description	Example
'^	Raises one operand to the power of another	B^A will give 49
'+	Adds two operands	A + B will give 9
'-	Subtracts second operand from the first	A - B will give -5
'*	Multiplies both operands	A * B will give 14
'/	Divides one operand by another And returns a floating point result	B / A will give 3.5
'\	Divides one operand by another And returns an integer result	B \ A will give 3
'Mod	Modulus Operator And remainder of after an integer division	B Mod A will give 1
'Comparison Operators
'Following table shows all the comparison operators supported by VB.Net. Assume variable A holds 10 And variable B holds 20, then

'Show Examples

'Operator    Description	Example
'=	Checks if the values of two operands are equal Or Not; if yes, then condition becomes true.	(A = B) Is Not true.
'<>	Checks if the values of two operands are equal Or Not; if values are Not equal, then condition becomes true.	(A <> B) Is true.
'>	Checks if the value of left operand Is greater than the value of right operand; if yes, then condition becomes true.	(A > B) Is Not true.
'<	Checks if the value Of left operand Is less than the value Of right operand; If yes, then condition becomes True.	(A < B) Is True.
'>=	Checks if the value of left operand Is greater than Or equal to the value of right operand; if yes, then condition becomes true.	(A >= B) Is Not true.
'<=	Checks if the value of left operand Is less than Or equal to the value of right operand; if yes, then condition becomes true.	(A <= B) Is true.
'Apart From the above, VB.Net provides three more comparison operators, which we will be using in forthcoming chapters; however, we give a brief description here.

'Is Operator - It compares two object reference variables And determines if two object references refer to the same object without performing value comparisons. If object1 And object2 both refer to the exact same object instance, result Is True; otherwise, result Is False.

'IsNot Operator - It also compares two object reference variables And determines if two object references refer to different objects. If object1 And object2 both refer to the exact same object instance, result Is False; otherwise, result Is True.

'Like Operator - It compares a string against a pattern.

'Logical/ Bitwise Operators
'Following table shows all the logical operators supported by VB.Net. Assume variable A holds Boolean value True And variable B holds Boolean value False, then

'Show Examples

'Operator    Description	Example
'And	It Is the logical as well as bitwise And operator. If both the operands are true, then condition becomes true. This operator does Not perform short-circuiting, i.e., it evaluates both the expressions.	(A And B) Is False.
'Or	It Is the logical as well as bitwise Or operator. If any of the two operands Is true, then condition becomes true. This operator does Not perform short-circuiting, i.e., it evaluates both the expressions.	(A Or B) Is True.
'Not	It Is the logical as well as bitwise Not operator. Use to reverses the logical state of its operand. If a condition Is true, then Logical Not operator will make false.	Not(A And B) Is True.
'Xor	It Is the logical as well as bitwise Logical Exclusive Or operator. It returns True if both expressions are True Or both expressions are False; otherwise it returns False. This operator does Not perform short-circuiting, it always evaluates both expressions And there Is no short-circuiting counterpart of this operator.	A Xor B Is True.
'AndAlso	It Is the logical And operator. It works only on Boolean data. It performs short-circuiting.	(A AndAlso B) Is False.
'OrElse	It Is the logical Or operator. It works only on Boolean data. It performs short-circuiting.	(A OrElse B) Is True.
'IsFalse It determines whether an expression Is False.	
'IsTrue  It determines whether an expression Is True.	
'Bit Shift Operators
'We have already discussed the bitwise operators. The bit shift operators perform the shift operations On binary values. Before coming into the bit shift operators, let us understand the bit operations.

'Bitwise Operators work On bits And perform bit-by-bit operations. The truth tables For &, |, And ^ are as follows

'p   q	p & q	p | q	p ^ q
'0   0	0	0	0
'0   1	0	1	1
'1   1	1	1	0
'1   0	0	1	1
'Assume If A = 60; And B = 13; now in binary format they will be as follows

'A = 11 1100

'B = 0 1101

'-----------------

'A&B = 0 1100

'A|B = 0011 1101

'A^ B = 11 0001

'~A  = 1100 0011

'We have seen that the Bitwise operators supported by VB.Net are And, Or, Xor And Not .The Bit shift operators are >> And << For left shift And right shift, respectively.

'Assume that the variable A holds 60 And variable B holds 13, then

'Show Examples

'Operator    Description	Example
'And	Bitwise And Operator copies a bit to the result if it exists in both operands.	(A And B) will give 12, which Is 0000 1100
'Or	Binary Or Operator copies a bit if it exists in either operand.	(A Or B) will give 61, which Is 0011 1101
'Xor	Binary Xor Operator copies the bit if it Is set in one operand but Not both.	(A Xor B) will give 49, which Is 0011 0001
'Not	Binary Ones Complement Operator Is unary And has the effect of 'flipping' bits.	(Not A ) will give -61, which is 1100 0011 in 2's complement form due to a signed binary number.
'<<	Binary Left Shift Operator. The left operands value Is moved left by the number of bits specified by the right operand.	A << 2 will give 240, which Is 1111 0000
'>>	Binary Right Shift Operator. The left operands value Is moved right by the number of bits specified by the right operand.	A >> 2 will give 15, which Is 0000 1111
'Assignment Operators
'There are following assignment operators supported by VB.Net

'Show Examples

'Operator    Description	Example
'=	Simple assignment operator, Assigns values from right side operands to left side operand	C = A + B will assign value of A + B into C
'+=	Add And assignment operator, It adds right operand to the left operand And assigns the result to left operand	C += A Is equivalent to C = C + A
'-=	Subtract And assignment operator, It subtracts right operand from the left operand And assigns the result to left operand	C -= A Is equivalent to C = C - A
'*=	Multiply And assignment operator, It multiplies right operand with the left operand And assigns the result to left operand	C *= A Is equivalent to C = C * A
'/=	Divide And assignment operator, It divides left operand with the right operand And assigns the result to left operand (floating point division)	C /= A Is equivalent to C = C / A
'\=	Divide And assignment operator, It divides left operand with the right operand And assigns the result to left operand (Integer division)	C \= A Is equivalent to C = C \A
'^=	Exponentiation And assignment operator. It raises the left operand to the power of the right operand And assigns the result to left operand.	C^=A Is equivalent to C = C ^ A
'<<=	Left shift And assignment operator	C <<= 2 Is same as C = C << 2
'>>=	Right shift And assignment operator	C >>= 2 Is same as C = C >> 2
'&=	Concatenates a String expression to a String variable Or property And assigns the result to the variable Or property.	
'Str1 &= Str2 Is same As

'Str1 = Str1 & Str2

'    Miscellaneous Operators
'There are few other important operators supported by VB.Net.

'Show Examples

'Operator    Description	Example
'AddressOf	Returns the address of a procedure.	
'AddHandler Button1.Click,
'AddressOf Button1_Click
'    Await   It Is applied to an operand in an asynchronous method Or lambda expression to suspend execution of the method until the awaited task completes.	

'Dim result As Res
'= Await AsyncMethodThatReturnsResult()
'Await AsyncMethod()
'GetType It returns a Type object for the specified type. The Type object provides information about the type such as its properties, methods, And events.	
'MsgBox(GetType(Integer).ToString())
'Function Expression()	It declares the parameters And code that define a Function lambda expression.	
'Dim add5 = Function(num As
' Integer) num + 5
''prints 10
'Console.WriteLine(add5(5))
'               If It Then uses Short-circuit evaluation To conditionally Return one Of two values. The If Operator can be called With three arguments Or With two arguments.	
'Dim num = 5
'                   Console.WriteLine(If(num >= 0,
'                   "Positive", "Negative"))
'                   Operators Precedence in VB.Net
'Operator precedence determines the grouping of terms in an expression. This affects how an expression Is evaluated. Certain operators have higher precedence than others; for example, the multiplication operator has higher precedence than the addition operator

'For example, x = 7 + 3 * 2; here, x Is assigned 13, Not 20 because operator * has higher precedence than +, so it first gets multiplied with 3*2 And then adds into 7.

'Here, Operators With the highest precedence appear at the top Of the table, those With the lowest appear at the bottom. Within an expression, higher precedence operators will be evaluated first.

'Show Examples

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

    End Sub

End Module
