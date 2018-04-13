<Assembly: CLSCompliant(True)> 

<CLSCompliant(True)>
Public MustInherit Class Person

    <CLSCompliant(True)> Public Property FirstName As String
    <CLSCompliant(True)> Public Property LastName As String

    <CLSCompliant(True)> Public MustOverride Function FullName() As String

End Class
