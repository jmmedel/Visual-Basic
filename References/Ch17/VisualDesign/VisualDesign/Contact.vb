Public Class Contact
    Inherits Person

    Public Property Age As Integer
        Get
            Return Nothing
        End Get
        Set(value As Integer)
        End Set
    End Property

    Public Property Email As String
        Get
            Return Nothing
        End Get
        Set(value As String)
        End Set
    End Property

    Public Overrides Function FullName() As String
        Return String.Format("{0} {1}, of age: {2}",
                            Me.LastName,
                            Me.FirstName,
                            Me.Age.ToString)

    End Function
End Class
