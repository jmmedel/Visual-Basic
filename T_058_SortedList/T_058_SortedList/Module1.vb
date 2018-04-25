
'VB.Net -SortedList
'    The SortedList Class represents a collection Of key-And-value pairs that are sorted by the keys And are accessible by key And by index.

'A sorted list Is a combination Of an array And a hashtable. It contains a list Of items that can be accessed Using a key Or an index. If you access items Using an index, it Is an ArrayList, And If you access items Using a key, it Is a Hashtable. The collection Of items Is always sorted by the key value.

'Properties And Methods of the SortedList Class
'The following table lists some Of the commonly used properties Of the SortedList Class

'Property Description
'Capacity	Gets Or sets the capacity Of the SortedList.
'Count	Gets the number Of elements contained In the SortedList.
'IsFixedSize	Gets a value indicating whether the SortedList has a fixed size.
'IsReadOnly	Gets a value indicating whether the SortedList Is read-only.
'Item	Gets And sets the value associated With a specific key In the SortedList.
'Keys	Gets the keys In the SortedList.
'Values	Gets the values In the SortedList.
'The following table lists some Of the commonly used methods Of the SortedList Class

'S.N  Method Name & Purpose
'1   
'Public Overridable Sub Add(key As Object, value As Object)

'    Adds an element with the specified key And value into the SortedList.

'2   
'Public Overridable Sub Clear()

'    Removes all elements from the SortedList.

'3   
'Public Overridable Function ContainsKey(key As Object) As Boolean

'    Determines whether the SortedList contains a specific key.

'4   
'Public Overridable Function ContainsValue(value As Object) As Boolean

'    Determines whether the SortedList contains a specific value.

'5   
'Public Overridable Function GetByIndex(index As Integer) As Object

'    Gets the value at the specified index of the SortedList.

'6   
'Public Overridable Function GetKey(index As Integer) As Object

'    Gets the key at the specified index of the SortedList.

'7   
'Public Overridable Function GetKeyList() As IList

'    Gets the keys in the SortedList.

'8   
'Public Overridable Function GetValueList() As IList

'    Gets the values in the SortedList.

'9   
'Public Overridable Function IndexOfKey(key As Object) As Integer

'    Returns the zero-based index of the specified key in the SortedList.

'10  
'Public Overridable Function IndexOfValue(value As Object) As Integer

'    Returns the zero-based index of the first occurrence of the specified value in the SortedList.

'11  
'Public Overridable Sub Remove(key As Object)

'    Removes the element with the specified key from the SortedList.

'12  
'Public Overridable Sub RemoveAt(index As Integer)

'    Removes the element at the specified index of SortedList.

'13  
'Public Overridable Sub TrimToSize()

'    Sets the capacity to the actual number of elements in the SortedList.

'Example:
'    The following example demonstrates the concept:




Module Module1

    Sub Main()
        Dim sl As SortedList = New SortedList()
        sl.Add("001", "Zara Ali")
        sl.Add("002", "Abida Rehman")
        sl.Add("003", "Joe Holzner")
        sl.Add("004", "Mausam Benazir Nur")
        sl.Add("005", "M. Amlan")
        sl.Add("006", "M. Arif")
        sl.Add("007", "Ritesh Saikia")
        If (sl.ContainsValue("Nuha Ali")) Then
            Console.WriteLine("This student name is already in the list")
        Else
            sl.Add("008", "Nuha Ali")
        End If
        ' Get a collection of the keys. 
        Dim key As ICollection = sl.Keys
        Dim k As String
        For Each k In key
            Console.WriteLine(" {0} : {1}", k, sl(k))
        Next k
        Console.ReadKey()
    End Sub

End Module


'When the above code Is compiled And executed, it produces the following result

'001: Zara Ali
'002: Abida Rehman
'003: Joe Holzner
'004: Mausam Banazir Nur
'005: M.Amlan
'006: M.Arif
'007: Ritesh Saikia
'008: Nuha Ali
