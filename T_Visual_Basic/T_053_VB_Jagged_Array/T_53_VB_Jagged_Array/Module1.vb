

'Jagged Array
'A Jagged array Is an array Of arrays. The follwoing code shows declaring a jagged array named scores Of Integers

'Dim scores As Integer()() = New Integer(5)() {}
'The following example illustrates Using a jagged array


Module Module1

    Sub Main()

        'a jagged array of 5 array of integers
        Dim a As Integer()() = New Integer(4)() {}
        a(0) = New Integer() {0, 0}
        a(1) = New Integer() {1, 2}
        a(2) = New Integer() {2, 4}
        a(3) = New Integer() {3, 6}
        a(4) = New Integer() {4, 8}
        Dim i, j As Integer
        ' output each array element's value 
        For i = 0 To 4
            For j = 0 To 1
                Console.WriteLine("a[{0},{1}] = {2}", i, j, a(i)(j))
            Next j
        Next i
        Console.ReadKey()

    End Sub

End Module



'When the above code Is compiled And executed, it produces the following result

'a[0][0]: 0
'a[0][1]: 0
'a[1][0]: 1
'a[1][1]: 2
'a[2][0]: 2
'a[2][1]: 4
'a[3][0]: 3
'a[3][1]: 6
'a[4][0]: 4
'a[4][1]: 8
