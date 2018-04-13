Imports System.Runtime.CompilerServices
Module Module1

    Sub Main()
        'Using the new class from the extended namespace
        Dim txt As New System.Text.CustomStringBuilder("Starting string")
        Console.WriteLine(txt.Builder.ToString)

    End Sub

End Module

'Bring this namespace at the same
'level of the root namespace
Namespace Global.MyUtilities
    Public Class Utility1
        'Your implementation goes here...
    End Class
End Namespace


'Extend the System namespace with a custom extension method
Namespace Global.System

    'You can also use the following syntax:
    'Namespace Global
    '   Namespace System

    Public Module Extensions

        <Extension()>
        Public Function Parse(element As String) As String
            Return element + " is made of " + CStr(element.Length) + " characters"
        End Function

    End Module
End Namespace

'Extend the built-in System.Text namespace with a custom type
Namespace Global.System.Text

    Public Class CustomStringBuilder

        Private _builder As StringBuilder
        Public ReadOnly Property Builder As StringBuilder
            Get
                Return _builder
            End Get
        End Property

        'Storing the original string into a new string builder
        'This is just for demo
        Public Sub New(startString As String)
            Me._builder.AppendLine(startString)
        End Sub

    End Class
End Namespace
