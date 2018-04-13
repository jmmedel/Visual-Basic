Imports System.Runtime.Serialization

<Serializable()>
Public Class Person
    Implements IDeserializationCallback


    Public Property FirstName As String
    Public Property LastName As String

    <NonSerialized()> Private _age As Integer
    Public Property Age As Integer
        Get
            Return _age
        End Get
        Set(ByVal value As Integer)
            _age = value
        End Set
    End Property

    <OptionalField(VersionAdded:=2)> Private _address As String
    Public Property Address As String

        Get
            Return _address
        End Get
        Set(ByVal value As String)
            _address = value
        End Set
    End Property

    Public Sub OnDeserialization(ByVal sender As Object) Implements _
               System.Runtime.Serialization.IDeserializationCallback.
               OnDeserialization
        'Specify the new age
        Me.Age = 37
    End Sub
End Class
