Module Module1
    Sub Main()
        'DoSomething is a method defined elsewhere
        DoSomething()
    End Sub
End Module

'The following is a representation of
'a class that works as modules.
'Class Program
'    Shared Sub Main()
'        DoSomething()
'    End Sub
'End Class

'From anywhere in your project you'll be able
'to reach the two objects
Module Declarations

    Friend myFirstField As String
    Friend Property myFirstProperty As Integer
End Module

Module Methods

    Friend Sub DoSomething()
        myFirstField = "A string"
        myFirstProperty = 0
    End Sub
End Module