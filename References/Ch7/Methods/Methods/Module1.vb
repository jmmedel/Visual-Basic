Module Module1

    Sub Main()
        Dim result = TestingValue(1)

        Console.ReadLine()
    End Sub

    Sub DoSomething()
        If IO.File.Exists("C:\SomeFile.txt") = False Then
            Throw New IO.FileNotFoundException
        Else
            Console.WriteLine("The file exists")
        End If

    End Sub

    Function DoSomethingElse() As Boolean

        Dim result As Boolean = IO.File.Exists("C:\SomeFile.txt")
        Return result
    End Function

End Module

Public Class Person

    Public Sub DoSomething()

    End Sub
End Class

#Region "ByVal - ByRef"

Module ByValByRefDemo

    Dim testInt As Integer = 10

    'Creates a copy of the original value(testInt)
    'and does not change it. Returns 10
    Sub ByValTest(ByVal anInt As Integer)
        anInt = 20
        Console.WriteLine(testInt)
    End Sub

    'Gets the reference of the original value (testInt)
    'and changes it. Returns 20
    Sub ByRefTest(ByRef anInt As Integer)
        anInt = 20
        Console.WriteLine(testInt)
    End Sub

    Dim testString As String = "Visual Basic 2015"
    Sub ByValStringTest(ByVal aString As String)
        aString = "Visual Basic 2015 Unleashed"
        Console.WriteLine(testString)
    End Sub

    Sub ByRefStringTest(ByRef aString As String)
        aString = "Visual Basic 2015 Unleashed"
        Console.WriteLine(testString)
    End Sub

    Sub RunTest()
        ByValTest(testInt)
        ByRefTest(testInt)
        ByValStringTest(testString)
        ByRefStringTest(testString)
        Console.ReadLine()
    End Sub

End Module

#End Region

#Region "Optional arguments"

Module TestOptionalArgs

    'Returns the full name of a person
    Function FullName(ByVal FirstName As String,
                     Optional ByVal LastName As String = "",
                     Optional ByVal Title As String = "") As String

        'Assumes that the optional Title parameter 
        'was not passed by comparing the default value
        If Title = "" Then Title = "Mr."

        Dim result As New System.Text.StringBuilder
        result.Append(Title)
        result.Append(LastName)
        result.Append(FirstName)

        Return result.ToString
    End Function

    Sub NullableDemo(ByVal firstArgument As String,
                     Optional ByVal secondArgument As _
                     Nullable(Of Integer) = Nothing)

        If secondArgument Is Nothing Then
            'We can assume that the 
            'optional argument was not supplied
        End If
    End Sub

    Sub RunTest()
        Console.WriteLine(FullName("Alessandro"))
    End Sub

End Module

#End Region

#Region "ParamArray"

Module ParamArrayDemo

    Sub ParamArrayTest(ByVal ParamArray names() As String)
        'Each item in the array is an
        'argument that you can manipulate
        'as you need
        For Each name As String In names
            Console.WriteLine(name)
        Next
    End Sub

    Sub RunTest()
        ParamArrayTest("Alessandro", "Del Sole", "Visual Basic 2015 Unleashed")
        Dim args() As String = {"Alessandro", "Del Sole",
                                "Visual Basic 2015 Unleashed"}
        ParamArrayTest(args)

        'Won't be compiled
        'ParamArrayTest("Alessandro", "Del Sole", "Visual Basic 2015 Unleashed")
    End Sub
End Module
#End Region

#Region "Overloading"
Class OverloadingDemo

    'Overloading properties
    Property Test(ByVal age As Integer) As Integer
        Get

        End Get
        Set(ByVal value As Integer)

        End Set
    End Property
    Property Test(ByVal name As String) As String
        Get

        End Get
        Set(ByVal value As String)

        End Set
    End Property

    'Overloading methods
    Private Function ReturnFullName(ByVal firstName As String,
                                    ByVal lastName As String) As String
        Return firstName & " " & lastName
    End Function

    Private Function ReturnFullName(ByVal firstName As String,
                                    ByVal lastName As String,
                                    ByVal Age As Integer) As String
        Return firstName & " " & lastName & " of age " & Age.ToString
    End Function

    Private Function ReturnFullName(ByVal title As String,
                                    ByVal firstName As String,
                                    ByVal lastName As String) As String
        Return title & " " & firstName & " " & lastName
    End Function

    Private Function ReturnFullName(ByVal title As String,
                                    ByVal firstName As String,
                                    ByVal lastName As String,
                                    ByVal Age As Integer) As String
        Return title & " " & firstName & " " & lastName &
               " of age " & Age.ToString
    End Function


    Public Sub CoercionDemo(ByVal anArgument As Double)
        Debug.WriteLine("Floating point")
    End Sub

    Public Sub CoercionDemo(ByVal anArgument As Integer)
        Debug.WriteLine("Integer")
    End Sub

    'Optional parameters overload allowed:
    Sub MyMethod(x As Integer)
    End Sub

    Sub MyMethod(x As Integer, Optional y As Integer = 0)
    End Sub

End Class
#End Region

#Region "Overload resolution"
Class OverloadResolution
    Sub Demo()
        Dim x As New List(Of Integer)
        x.Add(1)
        x.Add(2)
        x.Add(3)
        Calculate(x.AsEnumerable)
    End Sub

    Sub Calculate(Of T)(x As T)
        'Perform your calculation here
    End Sub

    'This is invoked by the Demo method because it is the one where the generic parameter is more deeply nested

    Sub Calculate(Of T)(x As IEnumerable(Of T))
        'Perform your calculation here
    End Sub

End Class
#End Region

#Region "Exit from methods"

Module ExitFromMethods

    Sub TestingValues(ByVal anInteger As Integer)
        If anInteger > 10 Then
            Exit Sub
        ElseIf anInteger < 10 Then
            Do Until anInteger = 10
                anInteger += 1
            Loop
            Exit Sub
        End If
    End Sub

    Function TestingValue(ByVal anInteger As Integer) As Boolean

        Dim result As Boolean

        If anInteger < 10 Then
            Do Until anInteger = 10
                anInteger += 1
            Loop
            result = True
            'Returns False
        ElseIf anInteger = 10 Then
            Exit Function
        Else
            result = False
        End If
        Return result
    End Function

End Module
#End Region