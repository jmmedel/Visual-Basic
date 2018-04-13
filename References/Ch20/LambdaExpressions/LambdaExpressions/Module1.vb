
Imports System.Runtime.CompilerServices
Imports System.Text.RegularExpressions


Module Module1

    Sub Main()
        GenerateStrings()
        Dim f = Function(x As Double, y As Double) x * y

        'Returns 12
        Console.WriteLine(f(3, 4))


        Dim processes = Process.GetProcesses.
                        OrderBy(Function(p) p.ProcessName).
                        Where(Function(p) p.ProcessName.ToLowerInvariant.StartsWith("e"))

        Console.ReadLine()
    End Sub

    Sub GenerateStrings()
        Dim myList As New List(Of String) From {"Alessandro", "Antonio", "Diego", "Renato"}
    End Sub
End Module

Module TestLambda

    Sub ComplexEvaluation()
        Dim checkString As Func(Of String, Boolean) = Function(s) s.IsValidEMail
        Console.WriteLine(checkString("alessandro.delsole@visual-basic.it"))
    End Sub

End Module

<Extension()> Module Extensions

    <Extension()> Public Function IsValidEMail(ByVal EMailAddress As String) _
              As Boolean
        Dim validateMail As String = _
        "^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.)" & _
        "|(([\w-]+\.)+))([a-zA-z]{2,4}|[0-9]{1,3})(\]?)$"

        Return Regex.IsMatch(EMailAddress, _
                              validateMail)

    End Function
End Module