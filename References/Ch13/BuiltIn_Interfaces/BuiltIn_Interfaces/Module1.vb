Module Module1

    Sub Main()

        'IEnumerable demo
        Dim c As New Contacts
        'Returns "Del Sole", "Green"
        For Each Cont As Contact In c
            Console.WriteLine(Cont.LastName)
        Next
        'End IEnumerable demo

        'IFormattable demo
        Dim p As New Person With {.FirstName = "Alessandro",
            .LastName = "Del Sole",
            .Email = "alessandro.delsole@visual-basic.it"}

        Debug.WriteLine("{0:G}", p)
        Debug.WriteLine("{0:L}", p)
        Debug.WriteLine("{0:F}", p)
        Debug.WriteLine("{0:LF}", p)
        'End IFormattable demo

        'IComparable demo
        Dim p1 As New Person3 With {.LastName = "Del Sole", .FirstName = "Alessandro"}
        Dim p2 As New Person3 With {.LastName = "Bianchi", .FirstName = "Roberto"}

        Console.WriteLine(p2.CompareTo(p1))
        'End IComparable demo

        Console.ReadLine()
    End Sub
End Module

'Interfaces as parameters
Public Class WorkWithLists
    Public Function Elaborate(ByVal items As IList) As Integer
        'Just for demo, returns 0 if the list contains something
        If items.Count > 0 Then
            Return 0
        Else
            'if not, adds a new object to the list
            Dim item As New Object
            items.Add(item)
            Return -1
        End If
    End Function
End Class
