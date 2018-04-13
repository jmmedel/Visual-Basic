Public Class Contact
    Inherits Person

    Public Shadows Property Title As Titles

    Public Shared Shadows Property Counter As Integer
    Public Shared Shadows Property Counter(ByVal maximum As Integer) As Integer
        Get

        End Get
        Set(ByVal value As Integer)
        End Set
    End Property

    Public Sub New()
        Person.Counter = 0
    End Sub
End Class

Public Enum Titles
    Dr
    Mr
    Mrs
End Enum