
'VB.Net -Sub() Procedures
'    As we mentioned in the previous chapter, Sub procedures are procedures that do Not return any value. We have been using the Sub procedure Main in all our examples. We have been writing console applications so far in these tutorials. When these applications start, the control goes to the Main Sub procedure, And it in turn, runs any other statements constituting the body of the program.

'Defining Sub Procedures()
'    The Sub() statement Is used To Declare the name, parameter And the body of a sub procedure. The syntax for the Sub statement Is

'[Modifiers] Sub() SubName [(ParameterList)] 
'    [Statements]
'End Sub
'Where,

'Modifiers: specify the access level Of the procedure; possible values are: Public, Private, Protected, Friend, Protected Friend And information regarding overloading, overriding, sharing, And shadowing.

'SubName: indicates the name Of the Sub

'ParameterList: specifies the list Of the parameters

'Example
'The following example demonstrates a Sub procedure CalculatePay that takes two parameters hours And wages And displays the total pay Of an employee


Module Module1

    Sub CalculatePay(ByRef hours As Double, ByRef wage As Decimal)
        'local variable declaration
        Dim pay As Double
        pay = hours * wage
        Console.WriteLine("Total Pay: {0:C}", pay)
    End Sub
    Sub Main()
        'calling the CalculatePay Sub Procedure
        CalculatePay(25, 10)
        CalculatePay(40, 20)
        CalculatePay(30, 27.5)
        Console.ReadLine()
    End Sub

End Module


'When the above code Is compiled And executed, it produces the following result:

'Total Pay :  $250.00
'Total Pay :  $800.00
'Total Pay :  $825.00