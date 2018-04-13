Imports System.Text

Public Enum Genders
    Male = 0
    Female = 1
End Enum

Public Interface IPerson
    Property FirstName As String
    Property LastName As String
    Property Age As Integer
    Property Gender As Genders

    Function BuildFullName() As String

    Event InstanceCreated()
End Interface

Public Class Person
    Implements IPerson

    Public Property FirstName As String Implements IPerson.FirstName
    Public Property Gender As Genders Implements IPerson.Gender
    Public Property LastName As String Implements IPerson.LastName
    Public Property Age As Integer Implements IPerson.Age
    Public Event InstanceCreated() Implements IPerson.InstanceCreated

    Public Overridable Function BuildFullName() As String _
                       Implements IPerson.BuildFullName

        Dim fullName As New StringBuilder
        fullName.Append(LastName)
        fullName.Append(" ")
        fullName.Append(FirstName)
        fullName.Append(", ")
        fullName.Append(Gender.ToString)
        fullName.Append(", of age ")
        fullName.Append(Age.ToString)

        Return fullName.ToString
    End Function
End Class



