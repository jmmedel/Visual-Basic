Module Module1

    Sub Main()
        Dim onePerson As New Person
        onePerson.FirstName = "Alessandro"
        onePerson.LastName = "Del Sole"

        Dim country As String = onePerson?.Address?.Country

        'Replaces:
        'If onePerson IsNot Nothing Then
        '    If onePerson.Address IsNot Nothing Then
        '        If onePerson.Address.Country IsNot Nothing Then
        '            Dim country1 As String = onePerson.Address.Country
        '        End If
        '    End If
        'End If

        'and:
        ''check if onePerson is null. If so, create a new one
        'Dim newPerson = If(onePerson Is Nothing, New Person With {.FirstName = "Alessandro",
        '    .LastName = "Del Sole"}, onePerson)

        ''Assuming you do some work with newPerson here...

        ''Check if Address if null. If so, assign a string
        'Dim country2 As String = If(newPerson.Address Is Nothing, "Country is missing",
        '    newPerson.Address.Country)

        If onePerson?.Address?.City?.StartsWith("C") Then
            Dim city As String = onePerson.Address.City
        End If

    End Sub
End Module

Public Class Person
    Public Property FirstName As String
    Public Property LastName As String
    Public Property Address As PhysicalAddress
End Class

Public Class PhysicalAddress
    Public Property Country As String
    Public Property ZipCode As String
    Public Property City As String
End Class