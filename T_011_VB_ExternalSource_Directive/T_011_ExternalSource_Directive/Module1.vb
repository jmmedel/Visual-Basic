

'The #ExternalSource Directive
'This directive Is used For indicating a mapping between specific lines Of source code And text external To the source. It Is used only by the compiler And the debugger has no effect On code compilation.

'This directive allows including external code from an external code file into a source code file.

'Syntax for this directive Is:

'#ExternalSource( StringLiteral , IntLiteral )
'    [ LogicalLine ]
'#End ExternalSource
'The parameters Of #ExternalSource directive are the path Of external file, line number Of the first line, And the line where the Error occurred.

'Example

'The following code demonstrates a hypothetical use Of the directive


Module Module1

    Public Class ExternalSourceTester

        Sub TestExternalSource()

#ExternalSource ("c:\vbprogs\directives.vb", 5)
            Console.WriteLine("This is External Code. ")
#End ExternalSource

        End Sub
    End Class

    Sub Main()
        Dim t As New ExternalSourceTester()
        t.TestExternalSource()
        Console.WriteLine("In Main.")
        Console.ReadKey()

    End Sub

End Module


'When the above code Is compiled And executed, it produces the following result

'This Is External Code.
'In Main.
