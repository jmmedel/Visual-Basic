

'VB.Net -Functions
'    A procedure Is a group Of statements that together perform a task When called. After the procedure Is executed, the control returns To the statement calling the procedure. VB.Net has two types Of procedures

'Functions

'Sub procedures() Or Subs

'Functions return a value, whereas Subs do Not return a value.

'Defining a Function
'The Function() statement Is used To Declare the name, parameter And the body of a function. The syntax for the Function statement Is

'[Modifiers] Function() FunctionName [(ParameterList)] As ReturnType
'    [Statements]
'    End Function
'    Where,

'Modifiers: specify the access level of the function; possible values are: Public, Private, Protected, Friend, Protected Friend and information regarding overloading, overriding, sharing, and shadowing.

'FunctionName: indicates the name of the function

'ParameterList: specifies the list of the parameters

'ReturnType: specifies the data type of the variable the function returns

'Example
'    Following code snippet shows a function FindMax that takes two integer values And returns the larger of the two.


'Function FindMax(ByVal num1 As Integer, ByVal num2 As Integer) As Integer
'    ' local variable declaration */
'    Dim result As Integer
'    If (num1 > num2) Then
'        result = num1
'    Else
'        result = num2
'    End If
'    FindMax = result
'End Function


Module Module1

    Sub Main()

        FindMax(1, 6)
        Console.ReadLine()
    End Sub
    Function FindMax(ByVal num1 As Integer, ByVal num2 As Integer) As Integer
        ' local variable declaration */
        Dim result As Integer
        If (num1 > num2) Then
            result = num1
        Else
            result = num2
        End If
        FindMax = result
        Console.WriteLine(num1, num2)
    End Function



End Module
