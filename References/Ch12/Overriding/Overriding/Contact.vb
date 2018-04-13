Public Class Contact
    Inherits Person

    Public Property Email As String

    'Demonstrates how you can override a custom
    'member that is not inherited from
    'System.Object
    Public Overrides Function FullName() As String
        'A simplified implementation
        'with no validation
        Dim result As New Text.StringBuilder
        result.Append(Me.FirstName)
        result.Append(" ")
        result.Append(Me.LastName)
        result.Append(", Email:")
        result.Append(Me.Email)

        Return result.ToString
    End Function

    Public Overloads Function FullName(ByVal Age As Integer) As String
        Return MyBase.FullName & " of age: " & Age.ToString
    End Function


    'Demonstrates how you can override
    'a member inherited from System.Object
    'according to the context of your custom class
    Public Overrides Function ToString() As String
        Dim result As New Text.StringBuilder
        result.Append(Me.FirstName)
        result.Append(" ")
        result.Append(Me.LastName)
        result.Append(", Email:")
        result.Append(Me.Email)

        Return result.ToString
    End Function
End Class