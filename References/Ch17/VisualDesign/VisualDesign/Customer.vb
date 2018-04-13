Public Class Customer
    Inherits Person

    Public Property CustomerID As Integer
        Get
            Return Nothing
        End Get
        Set(value As Integer)
        End Set
    End Property

    Public Property CompanyName As String
        Get
            Return Nothing
        End Get
        Set(value As String)
        End Set
    End Property

    Public Overrides Function FullName() As String
        Return String.Format("Customer {0} is {1}",
                             Me.CustomerID,
                             Me.CompanyName)

    End Function
End Class
