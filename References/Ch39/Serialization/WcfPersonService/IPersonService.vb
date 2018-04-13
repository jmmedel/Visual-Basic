<ServiceContract()>
Public Interface IPersonService

    <OperationContract()>
Function GetPersonFullName(ByVal onePerson As Person) As String
End Interface

<DataContract()>
Public Class Person

    <DataMember()>
    Public Property FirstName As String

    <DataMember()>
    Public Property LastName As String
End Class
