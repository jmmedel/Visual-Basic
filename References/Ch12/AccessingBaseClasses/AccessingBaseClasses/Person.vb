Public Class Person

    Public Overridable Property FirstName As String
    Public Overridable Property LastName As String
    Public Overridable Property Age As Integer

    Public Overridable Function FullInformation() As String
        Dim info As New Text.StringBuilder

        info.Append("Name: ")
        info.Append(Me.FirstName)
        info.Append(" Last name: ")
        info.Append(Me.LastName)
        info.Append(" Age: ")
        info.Append(Me.Age.ToString)
        Return info.ToString
    End Function

    Public Sub New(ByVal firstName As String,
                   ByVal lastName As String,
                   ByVal age As Integer)

        Me.FirstName = firstName
        Me.LastName = lastName
        Me.Age = age
    End Sub
End Class