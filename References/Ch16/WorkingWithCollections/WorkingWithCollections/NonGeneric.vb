Imports System.Collections.Specialized

Module NonGeneric

    Sub ArrayListDemo()

        Dim mixedCollection As New ArrayList
        mixedCollection.Capacity = 10

        mixedCollection.Add(32)
        mixedCollection.Add("32")
        mixedCollection.Add("Alessandro")
        mixedCollection.Add(Date.Today)

        mixedCollection.TrimToSize()

        'Returns 2
        Dim index As Integer = mixedCollection.BinarySearch("Alessandro")


        'Removes the string "32"
        mixedCollection.RemoveAt(1)
        'Removes 32
        mixedCollection.Remove(32)

        Dim anArray() As String = {"First", "Second", "Third"}
        mixedCollection.AddRange(anArray)

        mixedCollection.Insert(3, "New item")
        mixedCollection.InsertRange(3, anArray)

        For Each item As Object In mixedCollection
            Console.WriteLine(item.ToString)
        Next

    End Sub

    Sub HashTableDemo()

        Dim ht As New Hashtable
        ht.Add("Alessandro", "Del Sole")
        ht.Add("A string", 32)
        ht.Add(3.14, New Person)

        'Number of items
        Console.WriteLine(ht.Count)

        'Checks if a key/value exists
        Dim checkKey As Boolean = ht.ContainsKey("A string")
        Dim checkValue As Boolean = ht.ContainsValue(32)

        'iterate items
        For Each item As DictionaryEntry In ht
            Console.WriteLine("{0} {1}", item.Key, item.Value)
        Next

        'iterate keys
        For Each key As Object In ht.Keys
            Console.WriteLine(key)
        Next

        'Removes an item based on the key
        ht.Remove("Alessandro")

        Dim od As New OrderedDictionary
        od.Add("a", 1)


    End Sub

    Sub QueueDemo()

        Dim q As New Queue
        q.Enqueue(1)
        q.Enqueue(2)

        Console.WriteLine(q.Dequeue)
        Console.WriteLine(q.Dequeue)

    End Sub

    Sub StackDemo()

        Dim s As New Stack

        s.Push(1)
        s.Push(2)

        'Returns 2 and leaves it in the collection
        Console.WriteLine(s.Peek)
        'Returns 2 and removes it
        Console.WriteLine(s.Pop)
        'Returns 1 and removes it
        Console.WriteLine(s.Pop)

    End Sub

    Sub BitArrayDemo()

        Dim byteArray() As Byte = New Byte() {1, 2, 3}
        'Length in zero base
        Dim ba As New BitArray(byteArray)

        For Each item As Object In ba
            Console.WriteLine(item.ToString)
        Next

    End Sub

    Sub BitVectorDemo()

        'Passing zero to the constructor
        'ensures that all bits are clear
        Dim bv As New BitVector32(0)

        Dim bitOne As Integer = BitVector32.CreateMask
        Dim bitTwo As Integer = BitVector32.CreateMask(bitOne)
        Dim bitThree As Integer = BitVector32.CreateMask(bitTwo)

        bv(bitOne) = True
        bv(bitTwo) = False
        bv(bitThree) = True

        'Returns 5 (the first bit + the second bit = the third bit)
        Debug.WriteLine(bv.Data)

        Debug.WriteLine(bv)
    End Sub



    Sub StringCollectionDemo()
        Dim stringDemo As New StringCollection

        stringDemo.Add("Alessandro")
        stringDemo.Add("Del Sole")

        'Returns True
        Dim containsString As Boolean = stringDemo.Contains("Del Sole")

        stringDemo.Remove("Alessandro")
    End Sub

    Sub StringDictionaryDemo()
        Dim stringDemo As New StringDictionary

        stringDemo.Add("Key1", "Value1")
        stringDemo.Add("Alessandro", "Del Sole")

        'Simple iteration
        For Each value As String In stringDemo.Values
            Console.WriteLine(value)
        Next
    End Sub

    Sub NameValueDemo()

        Dim nv As New NameValueCollection

        nv.Add("First string", "Second string")

        Dim item As String = nv(0)

    End Sub

    Sub SortedListDemo()

        Dim sl As New SortedList
        sl.Add("Del Sole", 2)
        sl.Add("Alessandro", 1)

        For Each item As String In sl.Keys
            Debug.WriteLine(item)
        Next

    End Sub
End Module
