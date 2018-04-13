Imports System.Runtime.Serialization
Imports System.Security.Permissions

<Serializable()>
Public Class Person
    Implements ISerializable

    Public Overridable Property FirstName As String
    Public Overridable Property LastName As String
    Public Overridable Property Age As Integer

    <SecurityPermission(SecurityAction.Demand,
                        SerializationFormatter:=True)>
    Protected Sub GetObjectData(ByVal info As System.Runtime.Serialization.
                                           SerializationInfo,
                             ByVal context As System.Runtime.Serialization.
                                           StreamingContext) _
                             Implements System.Runtime.Serialization.ISerializable.
                                        GetObjectData

        info.AddValue("First name", Me.FirstName)
        info.AddValue("Last name", Me.LastName)
        info.AddValue("Age", Me.Age)
    End Sub

    'At deserialization time
    Protected Sub New(ByVal info As SerializationInfo,
                   ByVal context As StreamingContext)
        MyBase.New()
        Me.FirstName = info.GetString("First name")
        Me.LastName = info.GetString("Last name")
        Me.Age = info.GetInt32("Age")
    End Sub

    'Invoke this method before
    'serialization begins
    <OnSerializing()>
    Private Sub FirstMethod()

    End Sub

    'Invoke this method after
    'serialization completes
    <OnSerialized()>
    Private Sub SecondMethod()

    End Sub

    'Invoke this method before
    'deserialization begins
    <OnDeserializing()>
    Private Sub ThirdMethod()

    End Sub

    'Invoke this method after
    'deserialization completes
    <OnDeserialized()>
    Private Sub FourthMethod()

    End Sub
End Class
