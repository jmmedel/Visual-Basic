Imports System.Xml.Serialization

<XmlRoot("Contact")> Public Class Person
    <XmlIgnore()> Public Property FirstName As String
    Public Property LastName As String
    <XmlAttribute()> Public Property Age As Integer
End Class
