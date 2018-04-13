Module Module1

    Sub Main()

        Dim nc As New Test.NestedClass

    End Sub

End Module

'Declaring classes
Public Class Test

    'Nested classes could also
    'be marked as Private
    Friend Class NestedClass

    End Class
End Class
