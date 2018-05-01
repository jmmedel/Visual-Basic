
'VB.Net -Statements
'    A statement Is a complete instruction In Visual Basic programs. It may contain keywords, operators, variables, literal values, constants And expressions.

'Statements could be categorized As:

'Declaration statements - these are the statements where you name a variable, constant, Or procedure, And can also specify a data type.

'Executable statements - these are the statements, which initiate actions. These statements can Call a method Or Function, Loop Or branch through blocks Of code Or assign values Or expression To a variable Or constant. In the last Case, it Is called an Assignment statement.

'Declaration Statements
'The declaration statements are used To name And define procedures, variables, properties, arrays, And constants. When you Declare a programming element, you can also define its data type, access level, And scope.

'The programming elements you may Declare include variables, constants, enumerations, classes, structures, modules, interfaces, procedures, procedure parameters, Function returns, external procedure references, operators, properties, events, And delegates.

'Following are the declaration statements In VB.Net

'S.N  Statements And Description	Example
'1   
'Dim Statement

'Declares And allocates storage space for one Or more variables.

'Dim number As Integer
'Dim quantity As Integer = 100
'Dim message As String = "Hello!"
'2   Const Statement 
'Declares And defines one Or more constants.	
'Const maximum As Long = 1000
'Const naturalLogBase As Object
'= CDec(2.7182818284)
'3   Enum Statement 
'Declares an enumeration And defines the values Of its members.	
'Enum CoffeeMugSize
'    Jumbo
'    ExtraLarge
'    Large
'    Medium
'    Small
'End Enum
'4   
'Class Statement

'Declares the name Of a Class And introduces the definition Of the variables, properties, events, And procedures that the Class comprises.

'Class Box
'        Public length As Double
'        Public breadth As Double
'        Public height As Double
'    End Class
'5   
'Structure Statement

'Declares the name Of a Structure And introduces the definition Of the variables, properties, events, And procedures that the Structure comprises.

'Structure Box
'            Public length As Double
'            Public breadth As Double
'            Public height As Double
'        End Structure
'6   
'Module Statement

'Declares the name Of a Module And introduces the definition Of the variables, properties, events, And procedures that the Module comprises.

'Public Module myModule
'                Sub Main()
'                    Dim user As String =
'                    InputBox("What is your name?")
'                    MsgBox("User name is" & user)
'                End Sub
'            End Module
'7   
'Interface Statement


'Declares the name Of an Interface And introduces the definitions Of the members that the Interface comprises.
'Public Interface MyInterface
'                    Sub doSomething()
'                End Interface
'8   
'Function Statement()

'Declares the name, parameters, And code that define a Function procedure.

'Function myFunction()
'(ByVal n As Integer) As Double 
'    Return 5.87 * n
'                End Function
'9   
'Sub Statement()

'Declares the name, parameters, And code that define a Sub procedure.

'Sub mySub(ByVal s As String)
'                Return
'                End Sub
'10  
'Declare Statement()

'Declares a reference To a procedure implemented In an external file.

'Declare Function getUserName()
'Lib "advapi32.dll" 
'Alias "GetUserNameA" 
'(
'  ByVal lpBuffer As String, 
'  ByRef nSize As Integer) As Integer 
'11  
'Operator Statement

'Declares the Operator symbol, operands, And code that define an Operator procedure On a Class Or Structure.

'Public Shared Operator +
'(ByVal x As obj, ByVal y As obj) As obj
'        Dim r As New obj
'                 implemention code For r = x + y
'                Return r
'                End Operator
'12  
'Property Statement

'Declares the name Of a Property, And the Property procedures used To store And retrieve the value Of the Property.

'ReadOnly Property quote() As String
'                Get
'                Return quoteString
'                End Get
'                End Property
'13  
'Event Statement()

'Declares a user-defined Event.

'Public Event Finished()
'14  
'Delegate Statement()

'Used to declare a delegate.

'Delegate Function MathOperator(
'    ByVal x As Double,
'    ByVal y As Double
') As Double


'Executable Statements
'An executable statement performs an action. Statements calling a procedure, branching To another place In the code, looping through several statements, Or evaluating an expression are executable statements. An assignment statement Is a special Case Of an executable statement.

'Example
'The following example demonstrates a decision making statement

Module Module1

    Sub Main()
        'local variable definition '
        Dim a As Integer = 10

        ' check the boolean condition using if statement '
        If (a < 20) Then
            ' if condition is true then print the following '
            Console.WriteLine("a is less than 20")
        End If
        Console.WriteLine("value of a is : {0}", a)
        Console.ReadLine()
    End Sub


End Module
