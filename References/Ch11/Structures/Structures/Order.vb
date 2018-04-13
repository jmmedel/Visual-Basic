Imports System.Runtime.InteropServices


Public Structure Order

    Private Shared orderCount As Integer
    Public Property OrderID As Integer
    Public Property OrderDate As Date
    Public Property ShippedDate As Date
    Public Property CustomerID As Integer
    Public Property EmployeeID As Integer
    Public Property OrderDescription As String

    Public Sub New(ByVal Id As Integer,
                   ByVal OrderDate As Date,
                   ByVal ShippedDate As Date,
                   ByVal CustomerId As Integer,
                   ByVal EmployeeId As Integer)

        Me.OrderID = Id
        Me.OrderDate = OrderDate
        Me.ShippedDate = ShippedDate
        Me.CustomerID = CustomerId
        Me.EmployeeID = EmployeeId

        orderCount += 1
    End Sub

    Public Shared Function Count() As Integer
        Return orderCount
    End Function
End Structure

'Requires
'Imports System.Runtime.InteropServices
<StructLayout(LayoutKind.Auto)>
Public Structure VariousMembers
    Public Property anInteger As Integer
    Public Property aByte As Byte
    Public Property aShort As Short
End Structure