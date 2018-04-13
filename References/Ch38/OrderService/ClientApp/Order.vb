Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema

Partial Public Class Order
    Public Property OrderID As Integer

    <StringLength(5)>
    Public Property CustomerID As String

    Public Property EmployeeID As Integer?

    Public Property OrderDate As DateTimeOffset?

    Public Property RequiredDate As DateTimeOffset?

    Public Property ShippedDate As DateTimeOffset?

    Public Property ShipVia As Integer?

    <Column(TypeName:="money")>
    Public Property Freight As Decimal?

    <StringLength(40)>
    Public Property ShipName As String

    <StringLength(60)>
    Public Property ShipAddress As String

    <StringLength(15)>
    Public Property ShipCity As String

    <StringLength(15)>
    Public Property ShipRegion As String

    <StringLength(10)>
    Public Property ShipPostalCode As String

    <StringLength(15)>
    Public Property ShipCountry As String

    Public Overridable Property Customer As Customer
End Class
