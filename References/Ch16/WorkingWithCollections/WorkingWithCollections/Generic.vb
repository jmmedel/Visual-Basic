'The SortedSet collection requires that objects implement IComparable

Imports System.Collections.ObjectModel

Module Generic

    Sub Main()

        'BitArrayDemo()
        'BitVectorDemo()
        'SortedListDemo()

        'ArrayListDemo()
        'QueueDemo()
        'StackDemo()
        'ListDemo()
        'DictionaryDemo()
        'SortedDictionaryDemo()
        'ReadOnlyCollectionDemo()
        'CollectionInitializersDemo()
        'ObservableCollectionDemo()
        'LinkedListDemo()
        NullDictCheckDemo()
        Console.ReadLine()
    End Sub


    Sub ListDemo()

        Dim person1 As New Person With {.FirstName = "Alessandro",
                                        .LastName = "Del Sole",
                                        .Age = 32}
        Dim person2 As New Person With {.FirstName = "XXXXX",
                                        .LastName = "ZZZZZZZZ",
                                        .Age = 44}
        Dim person3 As New Person With {.FirstName = "YYYYY",
                                        .LastName = "DDDDDDDD",
                                        .Age = 18}

        Dim personList As New List(Of Person)
        personList.Add(person1)
        personList.Add(person2)
        personList.Add(person3)


        'Returns the index for Person2
        Dim specificPersonIndex As Integer = personList.IndexOf(person2)

        'Removes person3
        personList.Remove(person3)
        For Each p In personList
            Console.WriteLine(p.LastName)
        Next

        'Returns a unique Person whose LastName
        'property is Del Sole
        Dim specificPerson = personList.Single(Function(p) _
                                               p.LastName = "Del Sole")

        'Returns a new List(Of Person) storing
        'all Person instances whose LastName starts
        'with "D"
        Dim specificPeople = personList.FindAll(Function(p) _
                                              p.LastName.StartsWith("D"))

        personList.Clear()
        personList = Nothing
    End Sub

    Sub CollectionInitializersDemo()

        'With primitive types
        Dim listOfIntegers As New List(Of Integer) From {1, 2, 3, 4}

        listOfIntegers.Add(1)
        listOfIntegers.Add(2)
        listOfIntegers.Add(3)
        listOfIntegers.Add(4)

        'With custom types
        Dim person1 As New Person With {.FirstName = "Alessandro",
                                        .LastName = "Del Sole",
                                        .Age = 35}
        Dim person2 As New Person With {.FirstName = "XXXXX",
                                        .LastName = "ZZZZZZZZ",
                                        .Age = 44}
        Dim person3 As New Person With {.FirstName = "YYYYY",
                                        .LastName = "DDDDDDDD",
                                        .Age = 18}

        Dim people As New List(Of Person) From {person1,
                                                person2,
                                                person3}
    End Sub

    Sub ReadOnlyCollectionDemo()
        Dim person1 As New Person With {.FirstName = "Alessandro",
                                        .LastName = "Del Sole",
                                        .Age = 35}
        Dim person2 As New Person With {.FirstName = "XXXXX",
                                        .LastName = "ZZZZZZZZ",
                                        .Age = 44}
        Dim person3 As New Person With {.FirstName = "YYYYY",
                                        .LastName = "DDDDDDDD",
                                        .Age = 18}

        Dim people As New List(Of Person) From {person1, person2, person3}

        Dim readonlyPeople As New ReadOnlyCollection(Of Person)(people)

        'Same as above
        Dim readonly2 As ReadOnlyCollection(Of Person) = people.AsReadOnly
    End Sub


    Sub DictionaryDemo()

        Dim peopleDictionary As New Dictionary(Of String, Integer)
        peopleDictionary.Add("Alessandro", 35)
        peopleDictionary.Add("Stephen", 27)
        peopleDictionary.Add("Rod", 44)

        For Each item As KeyValuePair(Of String, Integer) In peopleDictionary
            Debug.WriteLine(item.Key & " of age " & item.Value.ToString)
        Next

    End Sub

    Sub SortedDictionaryDemo()
        Dim peopleDictionary As New SortedDictionary(Of String, Integer)

        peopleDictionary.Add("Alessandro", 35)
        peopleDictionary.Add("Stephen", 27)
        peopleDictionary.Add("Rod", 44)

        For Each item As KeyValuePair(Of String, Integer) In peopleDictionary
            Debug.WriteLine(item.Key & " of age " & item.Value.ToString)
        Next

    End Sub

    Sub ObservableCollectionDemo()

        Dim people As New ObservableCollection(Of Person)
        AddHandler people.CollectionChanged,
                   AddressOf CollectionChangedEventHandler

        Dim person1 As New Person With {.FirstName = "Alessandro",
                                        .LastName = "Del Sole",
                                        .Age = 32}
        Dim person2 As New Person With {.FirstName = "XXXXX",
                                        .LastName = "ZZZZZZZZ",
                                        .Age = 44}
        Dim person3 As New Person With {.FirstName = "YYYYY",
                                        .LastName = "DDDDDDDD",
                                        .Age = 18}

        people.Add(person1)
        people.Add(person2)
        people.Add(person3)
        people.Remove(person1)

        Console.ReadLine()
    End Sub

    Sub LinkedListDemo()
        Dim person1 As New Person With {.FirstName = "Alessandro",
                                        .LastName = "Del Sole",
                                        .Age = 32}
        Dim person2 As New Person With {.FirstName = "XXXXX",
                                        .LastName = "ZZZZZZZZ",
                                        .Age = 44}
        Dim person3 As New Person With {.FirstName = "YYYYY",
                                        .LastName = "DDDDDDDD",
                                        .Age = 18}

        'Creates a new LinkedList
        Dim linkedPeople As New LinkedList(Of Person)

        'Creates a series of nodes
        Dim node1 As New LinkedListNode(Of Person)(person1)
        Dim node2 As New LinkedListNode(Of Person)(person2)
        Dim node3 As New LinkedListNode(Of Person)(person3)

        'The first item in the collection
        linkedPeople.AddFirst(node1)

        'The last one
        linkedPeople.AddLast(node3)

        'Add a new item before the last one and after
        'the first one
        linkedPeople.AddBefore(node3, node2)

        'Removes the last item
        linkedPeople.RemoveLast()
        'Gets the instance of the last item
        '(person2 in this case)
        Dim lastPerson As Person = linkedPeople.Last.Value

        'Determines if person1 is within the collection
        Dim isPerson1Available As Boolean = linkedPeople.Contains(person1)


        Dim peopleEnumerator As LinkedList(Of Person).
            Enumerator = linkedPeople.GetEnumerator

        Do While peopleEnumerator.MoveNext
            'Current is a property that is of type T
            '(Person in this example)
            Console.WriteLine(peopleEnumerator.Current.LastName)
        Loop

    End Sub

    Private Sub CollectionChangedEventHandler(ByVal sender As Object,
                               ByVal e As Specialized.
                               NotifyCollectionChangedEventArgs)

        Select Case e.Action
            Case Is = Specialized.NotifyCollectionChangedAction.Add
                Debug.WriteLine("Added the following items:")
                For Each item As Person In e.NewItems
                    Debug.WriteLine(item.LastName)
                Next
            Case Is = Specialized.NotifyCollectionChangedAction.Remove
                Debug.WriteLine("Removed or moved the following items:")
                For Each item As Person In e.OldItems
                    Debug.WriteLine(item.LastName)
                Next
        End Select
    End Sub
End Module