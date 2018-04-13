Namespace Test

    Public Class Person
        Property FirstName As String
        Property LastName As String
    End Class

    Class Employee
        Inherits Person

        Property EmployeeID As Integer
    End Class

    Public Class Customer
        Inherits Person

        Public Property CompanyName As String

        Public Overrides Function ToString() As String
            Return CompanyName
        End Function

    End Class

    Module Module1

        Sub DoSomething()
            Dim myEmployee As New Employee

            myEmployee.FirstName = "Alessandro"
            myEmployee.LastName = "Del Sole"
            myEmployee.EmployeeID = 1234
        End Sub

        Sub Main()
            DoSomething()
        End Sub
    End Module

    Interface ITest
        Sub TakeATest()
    End Interface

    Structure SomeValues
        Property FirstValue As Boolean
        Property SecondValue As Integer

        Sub DoSomething()
            'Demonstrating how structures can expose methods
        End Sub
    End Structure

    <CLSCompliant(True)> Class Test
#Region "Private members"
        Private firstItem As String
        Private secondItem As Integer
#End Region
    End Class
End Namespace
