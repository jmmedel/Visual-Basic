
'The Array Class
'The Array Class Is the base Class For all the arrays In VB.Net. It Is defined In the System Namespace. The Array Class provides various properties And methods To work With arrays.

'Properties of the Array Class
'The following table provides some Of the most commonly used properties Of the Array Class

'S.N  Property Name & Description
'1   
'IsFixedSize

'Gets a value indicating whether the Array has a fixed size.

'2   
'IsReadOnly

'Gets a value indicating whether the Array Is read-only.

'3   
'Length

'Gets a 32-bit Integer that represents the total number Of elements In all the dimensions Of the Array.

'4   
'LongLength

'Gets a 64-bit Integer that represents the total number Of elements In all the dimensions Of the Array.

'5   
'Rank

'Gets the rank (number Of dimensions) Of the Array.

'Methods of the Array Class
'The following table provides some Of the most commonly used methods Of the Array Class

'S.N  Method Name & Description
'1   
'Public Shared Sub Clear(array As Array, index As Integer, length As Integer)

'    Sets a range Of elements In the Array To zero, to false, Or to null, depending on the element type.

'2   
'Public Shared Sub Copy(sourceArray As Array, destinationArray As Array, length As Integer)

'    Copies a range of elements from an Array starting at the first element And pastes them into another Array starting at the first element. The length Is specified as a 32-bit integer.

'3   
'Public Sub CopyTo(array As Array, index As Integer)

'    Copies all the elements of the current one-dimensional Array to the specified one-dimensional Array starting at the specified destination Array index. The index Is specified as a 32-bit integer.

'4   
'Public Function GetLength(dimension As Integer) As Integer

'    Gets a 32-bit integer that represents the number of elements in the specified dimension of the Array.

'5   
'Public Function GetLongLength(dimension As Integer) As Long

'    Gets a 64-bit integer that represents the number of elements in the specified dimension of the Array.

'6   
'Public Function GetLowerBound(dimension As Integer) As Integer

'    Gets the lower bound of the specified dimension in the Array.

'7   
'Public Function GetType() As Type

'    Gets the Type of the current instance (Inherited from Object).

'8   
'Public Function GetUpperBound(dimension As Integer) As Integer

'    Gets the upper bound of the specified dimension in the Array.

'9   
'Public Function GetValue(index As Integer) As Object

'    Gets the value at the specified position in the one-dimensional Array. The index Is specified as a 32-bit integer.

'10  
'Public Shared Function IndexOf(array As Array, value As Object) As Integer

'    Searches for the specified object And returns the index of the first occurrence within the entire one-dimensional Array.

'11  
'Public Shared Sub Reverse(array As Array)

'    Reverses the sequence of the elements in the entire one-dimensional Array.

'12  
'Public Sub SetValue(value As Object, index As Integer)

'    Sets a value to the element at the specified position in the one-dimensional Array. The index Is specified as a 32-bit integer.

'13  
'Public Shared Sub Sort(array As Array)

'    Sorts the elements in an entire one-dimensional Array using the IComparable implementation of each element of the Array.

'14  
'Public Overridable Function ToString() As String

'    Returns a string that represents the current object (Inherited from Object).

'For complete list of Array class properties And methods, please consult Microsoft documentation.

'Example
'The following program demonstrates use Of some Of the methods Of the Array Class


Module Module1

    Sub Main()
        Dim list As Integer() = {34, 72, 13, 44, 25, 30, 10}
        Dim temp As Integer() = list
        Dim i As Integer
        Console.Write("Original Array: ")
        For Each i In list
            Console.Write("{0} ", i)
        Next i
        Console.WriteLine()
        ' reverse the array
        Array.Reverse(temp)
        Console.Write("Reversed Array: ")
        For Each i In temp
            Console.Write("{0} ", i)
        Next i
        Console.WriteLine()
        'sort the array
        Array.Sort(list)
        Console.Write("Sorted Array: ")
        For Each i In list
            Console.Write("{0} ", i)
        Next i
        Console.WriteLine()
        Console.ReadKey()
    End Sub

End Module


'When the above code Is compiled And executed, it produces the following result:

'Original Array :  34 72 13 44 25 30 10
'Reversed Array :  10 30 25 44 13 72 34
'Sorted Array :  10 13 25 30 34 44 72
