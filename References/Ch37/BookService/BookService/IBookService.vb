<ServiceContract()>
Public Interface IBookService

    <OperationContract()>
    Function ValidateBook(ByVal bookToValidate As Book) As String

End Interface

<DataContract()>
Public Class Book

    <DataMember()>
    Public Property Title As String

    <DataMember()>
    Public Property ISBN As String

    <DataMember()>
    Public Property Author As String

    <DataMember()>
    Public Property DatePublished As Date?
End Class
