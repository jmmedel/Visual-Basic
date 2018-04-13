Public Class Contacts
    Inherits Person

    Public Overrides Function FullName() As String
        Return MyBase.LastName + " " + MyBase.FirstName
    End Function
End Class
