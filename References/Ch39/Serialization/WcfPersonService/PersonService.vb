' NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
Public Class PersonService
    Implements IPersonService

    Public Function GetPersonFullName(ByVal onePerson As Person) As String _
                    Implements IPersonService.GetPersonFullName

        Dim fullName As New Text.StringBuilder
        fullName.Append(onePerson.FirstName)
        fullName.Append(" ")
        fullName.Append(onePerson.LastName)
        Return fullName.ToString
    End Function
End Class
