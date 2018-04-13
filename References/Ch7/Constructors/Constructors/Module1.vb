Module Module1

    Sub Main()

        'First syntax
        'Dim aContact As Contact
        'aContact = New Contact

        'Second syntax
        'Dim aContact As New Contact


    End Sub

End Module
Public Class Contact

    Public Property FirstName As String
    Public Property LastName As String
    Public Property Email As String
    Public Property Address As String

    Public Sub New()
        Me.FirstName = "Assigned later"
        Me.LastName = "Assigned later"
        Me.Email = "Assigned later"
        Me.Address = "Assigned later"
    End Sub

#Region "Overloading"
    Public Sub New(ByVal surName As String)
        If String.IsNullOrEmpty(surName) Then _
            Throw New ArgumentException("surName")

        Me.LastName = surName

        'Will be assigned later
        Me.FirstName = ""
        Me.Email = ""
        Me.Address = ""
    End Sub

    Public Sub New(ByVal name As String,
                   ByVal surName As String,
                   ByVal emailAddress As String,
                   ByVal homeAddress As String)

        If surName = "" Then _
            Throw New ArgumentException("surName")
        Me.FirstName = name
        Me.LastName = surName
        Me.Email = emailAddress
        Me.Address = homeAddress
    End Sub
#End Region

End Class

#Region "Nested invocations"
Public Class NestedInvocations

    Public Property FirstName As String
    Public Property LastName As String
    Public Property Email As String
    Public Property Address As String
    Public Property ContactID As Integer

    Public Sub New(ByVal LastName As String)
        Me.New()
        Me.LastName = LastName
    End Sub

    Public Sub New(ByVal ContactID As Integer)
        Me.New()
        Me.ContactID = ContactID
    End Sub

    Private Sub New()
        'Replace with your 
        'initialization code
        Me.ContactID = 0
        Me.LastName = "Del Sole"
    End Sub


    Public Sub New(ByVal LastName As String, ByVal Email As String)
        Me.LastName = LastName
        Me.Email = Email
    End Sub
End Class
#End Region

#Region "Object initializers"

Public Class ObjectInitializersDemo

    Public Property FirstName As String
    Public Property LastName As String
    Public Property Email As String
    Public Property Address As String

    Dim aContact As New ObjectInitializersDemo With {.LastName = "Del Sole",
    .FirstName = "Alessandro",
    .Email = "alessandro.delsole@visual-basic.it",
    .Address = "5Th street"}



End Class



#End Region
