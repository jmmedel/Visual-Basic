Public Class Person

    Public Property FirstName As String
    Public Property LastName As String
    Public Property Age As Integer

    Public Overrides Function ToString() As String
        Return String.Concat(FirstName, " ", LastName)
    End Function

    Public Sub New(ByVal Name As String, ByVal SurName As String, ByVal Age As Integer)
        Me.FirstName = Name
        Me.LastName = SurName
        Me.Age = Age
    End Sub

End Class