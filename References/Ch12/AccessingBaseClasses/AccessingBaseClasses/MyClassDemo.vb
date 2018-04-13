Public Class BaseClassDemo

    Public Overridable ReadOnly Property Test As String
        Get
            Return "This is a test in the base class"
        End Get
    End Property

    Public Function DoSomething() As String
        Return MyClass.Test
    End Function

End Class

Public Class DerivedClassDemo
    Inherits BaseClassDemo

    Public Overrides ReadOnly Property Test As String
        Get
            Return "This is a test in the derived class"
        End Get
    End Property
End Class