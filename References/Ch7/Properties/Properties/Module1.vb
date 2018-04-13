Module Module1

    Sub Main()
        Dim t As New TestDataAccess

        t(2) = "Visual Basic 2015 Unleashed"

        Console.WriteLine(t(1))
        Console.WriteLine(t(2))

        Console.ReadLine()
    End Sub

End Module

#Region "Auto-implemented properties"
Public Class Person

    'This is what you had to do in VB 2008:
    'Private _firstName As String

    'Public Property FirstName As String
    '    Get
    '        Return _firstName
    '    End Get
    '    Set(ByVal value As String)
    '        _firstName = value
    '    End Set
    'End Property

    'Now take a look at how simple it is in VB 2010 and later:
    Public Property FirstName As String
    Public Property LastName As String
End Class
#End Region

#Region "Read-only and write-only properties"
Public Class Person2

    Public Property FirstName As String
    Public Property LastName As String

    Public ReadOnly Property FullName As String
        Get
            Return Me.FirstName & " " & Me.LastName
        End Get
    End Property

    Public ReadOnly Property DateOfBirth As Date

    Public Sub New(firstName As String, lastName As String, dateOfBirth As Date)
        Me.FirstName = firstName
        Me.LastName = lastName

        Me.DateOfBirth = dateOfBirth
    End Sub

    Private _fictitiousCounter As Integer

    Public WriteOnly Property FictitiousCounter As Integer
        Set(ByVal value As Integer)
            _fictitiousCounter = value
        End Set
    End Property
End Class

#End Region

#Region "Explicit getters and setters"
'Demonstrates how you can still
'implement explicit getters and setters
Public Class Woman

    Private Const Prefix As String = "Mrs."

    Private _firstName As String
    Public Property FirstName As String
        Get
            Return Prefix & Me._firstName
        End Get
        Set(ByVal value As String)
            Me._firstName = value
        End Set
    End Property
End Class

#End Region

#Region "Exposing custom reference types"

Public Class Customer
    Public Property CompanyName As String
    Public Property ContactName As String
End Class

Public Class Order
    Public Property CustomerInstance As Customer
    Public Property OrderID As Integer
End Class

#End Region

#Region "Accessing properties"

Class AccessingPropertiesDemo

    Sub AccessDemo()
        Dim p As New Person

        'Properties assignment (write)
        p.FirstName = "Alessandro"
        p.LastName = "Del Sole"

        'Properties reading
        If p.LastName.ToLower = "del sole" Then
            Console.WriteLine(p.LastName)
        End If

    End Sub

End Class

#End Region

#Region "Default properties"

Public Class TestDataAccess

    Private listOfNames() As String =
        {"Alessandro", "Del Sole", "VB 2015 Unleashed"}

    Default Public Property GetName(ByVal index As Integer) As String
        Get
            Return listOfNames(index)
        End Get
        Set(ByVal value As String)
            listOfNames(index) = value
        End Set
    End Property

End Class
#End Region
