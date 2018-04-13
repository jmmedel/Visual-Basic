<CLSCompliant(True)>
Public Structure ClsCompliantStructure

    Public Shared Operator =(ByVal obj1 As CLSCompliantStructure,
                             ByVal obj2 As CLSCompliantStructure) As Boolean
        Return obj1.Equals(obj2)
    End Operator

    Public Shared Operator <>(ByVal obj1 As CLSCompliantStructure,
                              ByVal obj2 As CLSCompliantStructure) As Boolean
        Return Not obj1.Equals(obj2)
    End Operator

    Public Overrides Function Equals(ByVal obj As Object) As Boolean
        Return Object.Equals(Me, obj)
    End Function

    Public Overrides Function GetHashCode() As Integer
        Return Me.GetHashCode
    End Function
End Structure