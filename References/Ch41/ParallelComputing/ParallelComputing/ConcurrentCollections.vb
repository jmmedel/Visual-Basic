Imports System.Collections.Concurrent

Module ConcurrentCollections

    Sub BlockingCollectionDemo()

        Dim bc As New BlockingCollection(Of String)

        bc.Add("First")
        bc.Add("Second")
        bc.Add("Third")
        bc.Add("Fourth")

        'Marks the collection as complete
        bc.CompleteAdding()

        'Returns an exception
        'bc.Add("Fifth")

        'Removes an item from the collection (FIFO)
        Dim result = bc.Take()
        Console.WriteLine(result)


        Dim collection1 As New BlockingCollection(Of String)
        Dim collection2 As New BlockingCollection(Of String)

        Dim colls(1) As BlockingCollection(Of String)
        colls(0) = collection1
        colls(1) = collection2

        BlockingCollection(Of String).AddToAny(colls, "anItem")
    End Sub

    Sub ConcurrentQueueDemo()
        'Creating an instance
        Dim cq As New ConcurrentQueue(Of Integer)

        'Adding items
        cq.Enqueue(1)
        cq.Enqueue(2)

        'Removing an item from the queue
        Dim item As Integer
        cq.TryDequeue(item)
        Console.WriteLine(item)

        'Returns "1":
        Console.WriteLine(cq.Count)
        Console.ReadLine()
    End Sub

    Sub ConcurrentStackDemo()
        'Creating an instance
        Dim cs As New ConcurrentStack(Of Integer)

        'Adding an item
        cs.Push(1)
        'Adding an array
        cs.PushRange(New Integer() {10, 5, 10, 20})


        Dim items() As Integer = New Integer(3) {}

        'Removing an array
        cs.TryPopRange(items, 0, 4)

        'Iterating the array
        Array.ForEach(Of Integer)(items, Sub(i)
                                             Console.WriteLine(i)
                                         End Sub)

        'Removing an item
        Dim anItem As Integer
        cs.TryPop(anItem)
        Console.WriteLine(anItem)
    End Sub

    Sub ConcurrentBagDemo()
        'Creating an instance
        Dim cb As New ConcurrentBag(Of String)

        'Adding some items
        cb.Add("String one")
        cb.Add("String two")
        cb.Add("String three")

        'Showing items count
        Console.WriteLine(cb.Count)

        'Listing items in the collection
        For Each item In cb
            Console.WriteLine(item)
        Next

        'Removing an item
        Dim anItem As String = String.Empty
        cb.TryTake(anItem)
        Console.WriteLine(anItem)
    End Sub

    Sub ConcurrentDictionaryDemo()
        'Where String is for names and Integer for ages
        Dim cd As New ConcurrentDictionary(Of String, Integer)

        Dim result As Boolean

        'Adding some items
        result = cd.TryAdd("Alessandro", 35)
        result = cd.TryAdd("Nadia", 31)
        result = cd.TryAdd("Robert", 38)

        'Removing an item
        result = cd.TryRemove("Nadia", 31)

        'Getting a value for the specified key
        Dim value As Integer
        result = cd.TryGetValue("Alessandro", value)

        Console.WriteLine(value)
    End Sub
End Module
