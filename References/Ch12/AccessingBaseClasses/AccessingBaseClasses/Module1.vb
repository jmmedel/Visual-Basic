Module Module1
    Sub Main()

        Dim derived As New DerivedClassDemo

        'Invokes the member within the derived
        'class but as if it was not overridden
        Dim result As String = derived.DoSomething
    End Sub
End Module