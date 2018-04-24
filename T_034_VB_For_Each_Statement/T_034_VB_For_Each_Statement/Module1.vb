
'VB.Net - Each...Next Loop
'    It repeats a group Of statements For Each element In a collection. This Loop Is used For accessing And manipulating all elements In an array Or a VB.Net collection.

'The syntax For this Loop construct Is

'For Each element [ As datatype ] In group
'    [ statements ]
'    [ Continue For ]
'    [ statements ]
'    [ Exit For ]
'    [ statements ]
'Next [ element ]


Module Module1

    Sub Main()
        Dim anArray() As Integer = {1, 3, 5, 7, 9}
        Dim arrayItem As Integer
        'displaying the values
        For Each arrayItem In anArray
            Console.WriteLine(arrayItem)
        Next
        Console.ReadLine()
    End Sub


End Module
