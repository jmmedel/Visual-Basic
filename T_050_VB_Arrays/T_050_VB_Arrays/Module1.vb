
'VB.Net -Arrays
'    An array stores a fixed-size sequential collection Of elements Of the same type. An array Is used To store a collection Of data, but it Is often more useful To think Of an array As a collection Of variables Of the same type.

'All arrays consist Of contiguous memory locations. The lowest address corresponds To the first element And the highest address To the last element.

'Arrays in VB.Net
'Creating Arrays In VB.Net
'To declare an array in VB.Net, you use the Dim statement. For example,

'Dim intData(30)   ' an array of 31 elements
'Dim strData(20) As String   ' an array of 21 strings
'Dim twoDarray(10, 20) As Integer    'a two dimensional array of integers
'Dim ranges(10, 100)	 'a two dimensional array
'You can also initialize the array elements While declaring the array. For example,

'Dim intData() As Integer = {12, 16, 20, 24, 28, 32}
'Dim names() As String = {"Karthik", "Sandhya",
'"Shivangi", "Ashwitha", "Somnath"}
'Dim miscData() As Object = {"Hello World", 12D, 16UI, "A"c}
'The elements In an array can be stored And accessed by Using the index Of the array. The following program demonstrates this

Module Module1

    Sub Main()

        Dim n(10) As Integer  ' n is an array of 11 integers '
        Dim i, j As Integer
        ' initialize elements of array n '         
        For i = 0 To 10
            n(i) = i + 100 ' set element at location i to i + 100 
        Next i
        ' output each array element's value '
        For j = 0 To 10
            Console.WriteLine("Element({0}) = {1}", j, n(j))
        Next j
        Console.ReadKey()

    End Sub

End Module


