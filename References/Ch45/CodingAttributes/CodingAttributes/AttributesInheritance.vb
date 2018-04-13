<AttributeUsage(AttributeTargets.Class Or AttributeTargets.Method,
                Inherited:=False)>
Public Class FirstAttribute
    Inherits Attribute

    'Implement your code here..
End Class

<AttributeUsage(AttributeTargets.Class Or AttributeTargets.Method)>
Public Class SecondAttribute
    Inherits Attribute

    'Implement your code here..
End Class

Public Class Person2

    Public Property LastName As String
    Public Property FirstName As String

    'The base class takes both attributes
    <First(), Second()> Public Overridable Function FullName() As String
        Return String.Concat(LastName, " ", FirstName)
    End Function

End Class

Public Class Contact
    Inherits Person2

    'This derived class takes only the Second attribute
    'because First is marked as Inherited:=False
    Public Overrides Function FullName() As String
        Return MyBase.FullName()
    End Function
End Class