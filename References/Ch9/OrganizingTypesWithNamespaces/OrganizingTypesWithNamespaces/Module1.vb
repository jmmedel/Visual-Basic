Module Module1

    Sub Main()
    End Sub

End Module

'Fare nested namespace con People.Personal e People.Work
Namespace People

    Public Interface IContactable
        ReadOnly Property HasEmailAddress As Boolean
    End Interface

    Public MustInherit Class Person
        Public Property FirstName As String
        Public Property LastName As String

        Public Overrides Function ToString() As String
            Return FirstName & " " & LastName
        End Function
    End Class

    Public Enum PersonType
        Work = 0
        Personal = 1
    End Enum

    Module GlobalDeclarations
        Public Data As Object
    End Module

    Public Structure PersonInformation
        Public Property PersonCategory As PersonType
        Public Property HasEmailAddress As Boolean
    End Structure
    'Namespace Work
    '    '....
    'End Namespace

    'Namespace Personal
    '    '...
    'End Namespace
End Namespace

Namespace People.Work
    Public Class Employee
        Inherits Person

        Public Property Title As String

        Public Overrides Function ToString() As String
            Return Me.Title & " " & Me.FirstName & " " & Me.LastName
        End Function
    End Class

    Public Class Customer
        Inherits Person

        Public Property CompanyName As String
        Public Overrides Function ToString() As String
            Return Me.LastName & " from " & Me.CompanyName
        End Function
    End Class
End Namespace

Namespace People.Personal
    Public Class Contact
        Inherits Person
        Implements IContactable

        Public Property EmailAddress As String

        Public Overrides Function ToString() As String
            Return MyBase.ToString()
        End Function

        Public ReadOnly Property HasEmailAddress As Boolean _
                        Implements IContactable.HasEmailAddress
            Get
                If String.IsNullOrEmpty(Me.EmailAddress) Then
                    Return False
                Else
                    Return True
                End If
            End Get
        End Property
    End Class
End Namespace

Namespace People.Personal.Family

End Namespace

Namespace MyFriends

    'Will not conflict with People.Person
    Public Class Person
        Public Property FirstName As String
        Public Property LastName As String

        Public Overrides Function ToString() As String
            Return FirstName & " " & LastName
        End Function
    End Class

End Namespace