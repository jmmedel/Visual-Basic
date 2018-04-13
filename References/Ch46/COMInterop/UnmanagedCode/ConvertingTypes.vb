Imports System.Runtime.InteropServices

Public Class Person

    <MarshalAs(UnmanagedType.LPStr)>
    Private _firstName As String
    <MarshalAs(UnmanagedType.SysInt)>
    Private _age As Integer

    Public Property FirstName As String
        Get
            Return _firstName
        End Get
        Set(ByVal value As String)
            _firstName = value
        End Set
    End Property

    Public Property Age As Integer
        Get
            Return _age
        End Get
        Set(ByVal value As Integer)
            _age = value
        End Set
    End Property

    Sub ConvertParameter(<MarshalAs(UnmanagedType.LPStr)> _
                              ByVal name As String)
    End Sub
End Class

<StructLayout(LayoutKind.Explicit)>
Public Structure COMRECT

    <FieldOffset(0)> Public Left As Integer
    <FieldOffset(4)> Public Top As Integer
    <FieldOffset(8)> Public Right As Integer
    <FieldOffset(12)> Public Bottom As Integer

    Shared Sub New()

    End Sub

    Public Sub New(ByVal left As Integer,
                   ByVal top As Integer,
                   ByVal right As Integer,
                   ByVal bottom As Integer)

        Me.Left = left
        Me.Top = top
        Me.Right = right
        Me.Bottom = bottom
    End Sub
End Structure

Public Structure Contact
    <VBFixedString(15)> Public LastName As String
    <VBFixedString(12)> Public Email As String
End Structure