Module Module1

    Sub Main()

        Dim collection As New List(Of String) From {"Alessandro",
                                                    "Del Sole",
                                                    "alessandro.delsole@visual-basic.it"}

        collection.ForEach(Sub(element) Console.WriteLine(element))

        ' "collection" has the same previous implementation
        collection.ForEach(Sub(element)
                               Try
                                   If String.IsNullOrEmpty(element) = False Then
                                       Console.WriteLine(element)
                                   Else
                                       Console.
                                       WriteLine("Cannot print empty strings")
                                   End If
                               Catch ex As Exception

                               End Try
                           End Sub)

        Console.ReadLine()
    End Sub

End Module