
'Multi-Dimensional Arrays
'VB.Net allows multidimensional arrays. Multidimensional arrays are also called rectangular arrays.

'You can Declare a 2-dimensional array Of strings As

'Dim twoDStringArray(10, 20) As String
'Or, a 3-dimensional array of Integer variables

'Dim threeDIntArray(10, 10, 10) As Integer
'The following program demonstrates creating And Using a 2-dimensional array


Module Module1

    Sub Main()

        ' an array with 5 rows and 2 columns
        Dim a(,) As Integer = {{0, 0}, {1, 2}, {2, 4}, {3, 6}, {4, 8}}
        Dim i, j As Integer
        ' output each array element's value '
        For i = 0 To 4
            For j = 0 To 1
                Console.WriteLine("a[{0},{1}] = {2}", i, j, a(i, j))
            Next j
        Next i
        Console.ReadKey()

    End Sub

End Module


'When the above code Is compiled And executed, it produces the following result

'a[0,0]: 0
'a[0,1]: 0
'a[1,0]: 1
'a[1,1]: 2
'a[2,0]: 2
'a[2,1]: 4
'a[3,0]: 3
'a[3,1]: 6
'a[4,0]: 4
'a[4,1]: 8


