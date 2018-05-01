

'VB.Net -Miscellaneous Operators
'There are few other important operators supported by VB.Net.

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



Module Module1

    Sub Main()
        Dim a As Integer = 21
        Console.WriteLine(GetType(Integer).ToString())
        Console.WriteLine(GetType(Double).ToString())
        Console.WriteLine(GetType(String).ToString())
        Dim multiplywith5 = Function(num As Integer) num * 5
        Console.WriteLine(multiplywith5(5))
        Console.WriteLine(If(a >= 0, "Positive", "Negative"))
        Console.ReadLine()
    End Sub


End Module

'When the above code Is compiled And executed, it produces the following result

'System.Int32
'System.Double
'System.String
'25
'Positive
