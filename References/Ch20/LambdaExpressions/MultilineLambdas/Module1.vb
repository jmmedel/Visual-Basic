Module Module1

    Sub Main()

        Console.WriteLine("Enter a number:")
        Dim number = CDbl(Console.ReadLine)

        Dim result = Function(n As Double)
                         If n < 0 Then
                             Return 0
                         Else
                             Return n + 1
                         End If
                     End Function

        Console.WriteLine(result(number))

        Dim processes = Process.GetProcesses.
                        Where(Function(p)
                                  Try
                                      'Returns True
                                      p.ProcessName.ToLowerInvariant.
                                      StartsWith("e")
                                      Return True
                                  Catch ex As Exception
                                      Return False
                                  End Try
                              End Function)

        Console.ReadLine()

    End Sub

End Module
