


'VB.Net -ArrayList
'    It represents an ordered collection Of an Object that can be indexed individually. It Is basically an alternative To an array. However, unlike array, you can add And remove items from a list at a specified position Using an index And the array resizes itself automatically. It also allows dynamic memory allocation, adding, searching And sorting items In the list.

'Properties And Methods of the ArrayList Class
'The following table lists some Of the commonly used properties Of the ArrayList Class

'Property Description
'Capacity	Gets Or sets the number Of elements that the ArrayList can contain.
'Count	Gets the number Of elements actually contained In the ArrayList.
'IsFixedSize	Gets a value indicating whether the ArrayList has a fixed size.
'IsReadOnly	Gets a value indicating whether the ArrayList Is read-only.
'Item	Gets Or sets the element at the specified index.
'The following table lists some Of the commonly used methods Of the ArrayList Class

'S.N.Method Name & Purpose
'1   
'Public Overridable Function Add(value As Object) As Integer

'    Adds an object to the end of the ArrayList.

'2   
'Public Overridable Sub AddRange(c As ICollection)

'    Adds the elements of an ICollection to the end of the ArrayList.

'3   
'Public Overridable Sub Clear()

'    Removes all elements from the ArrayList.

'4   
'Public Overridable Function Contains(item As Object) As Boolean

'    Determines whether an element Is in the ArrayList.

'5   
'Public Overridable Function GetRange(index As Integer, count As Integer) As ArrayList

'    Returns an ArrayList, which represents a subset of the elements in the source ArrayList.

'6   
'Public Overridable Function IndexOf(value As Object) As Integer


'    Returns the zero-based index of the first occurrence of a value in the ArrayList Or in a portion of it.
'7   
'Public Overridable Sub Insert(index As Integer, value As Object)

'    Inserts an element into the ArrayList at the specified index.

'8   
'Public Overridable Sub InsertRange(index As Integer, c As ICollection)

'    Inserts the elements of a collection into the ArrayList at the specified index.

'9   
'Public Overridable Sub Remove(obj As Object)

'    Removes the first occurrence of a specific object from the ArrayList.

'10  
'Public Overridable Sub RemoveAt(index As Integer)

'    Removes the element at the specified index of the ArrayList.

'11  
'Public Overridable Sub RemoveRange(index As Integer, count As Integer)

'    Removes a range of elements from the ArrayList.

'12  
'Public Overridable Sub Reverse()

'    Reverses the order of the elements in the ArrayList.

'13  
'Public Overridable Sub SetRange(index As Integer, c As ICollection)

'    Copies the elements of a collection over a range of elements in the ArrayList.

'14  
'Public Overridable Sub Sort()
'    Sorts the elements in the ArrayList.

'15  
'Public Overridable Sub TrimToSize()

'    Sets the capacity to the actual number of elements in the ArrayList.




Module Module1

    Sub Main()

        Dim al As ArrayList = New ArrayList()
        Dim i As Integer
        Console.WriteLine("Adding some numbers:")
        al.Add(45)
        al.Add(78)
        al.Add(33)
        al.Add(56)
        al.Add(12)
        al.Add(23)
        al.Add(9)
        Console.WriteLine("Capacity: {0} ", al.Capacity)
        Console.WriteLine("Count: {0}", al.Count)
        Console.Write("Content: ")
        For Each i In al
            Console.Write("{0} ", i)
        Next i
        Console.WriteLine()
        Console.Write("Sorted Content: ")
        al.Sort()
        For Each i In al
            Console.Write("{0} ", i)
        Next i
        Console.WriteLine()
        Console.ReadKey()


    End Sub

End Module


'When the above code Is compiled And executed, it produces the following result:

'Adding some numbers
'Capacity: 8
'Count: 7
'Content: 45 78 33 56 12 23 9
'Content: 9 12 23 33 45 56 78    
