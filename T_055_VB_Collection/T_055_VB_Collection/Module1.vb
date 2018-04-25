
'VB.Net -Collections

'Collection classes are specialized classes For data storage And retrieval. These classes provide support For stacks, queues, lists, And hash tables. Most collection classes implement the same interfaces.

'Collection classes serve various purposes, such As allocating memory dynamically To elements And accessing a list Of items On the basis Of an index, etc. These classes create collections Of objects Of the Object Class, which Is the base Class For all data types In VB.Net.

'Various Collection Classes And Their Usage
'The following are the various commonly used classes Of the System.Collection Namespace. Click the following links To check their details.

'Class Description And Useage
'ArrayList

'It represents ordered collection Of an Object that can be indexed individually.

'It Is basically an alternative to an array. However, unlike array, you can add And remove items from a list at a specified position using an index And the array resizes itself automatically. It also allows dynamic memory allocation, add, search And sort items in the list.

'Hashtable

'It uses a key To access the elements In the collection.

'A hash table Is used When you need To access elements by Using key, And you can identify a useful key value. Each item In the hash table has a key/value pair. The key Is used To access the items In the collection.

'SortedList

'It uses a key As well As an index To access the items In a list.

'A sorted list Is a combination Of an array And a hash table. It contains a list Of items that can be accessed Using a key Or an index. If you access items Using an index, it Is an ArrayList, And If you access items Using a key, it Is a Hashtable. The collection Of items Is always sorted by the key value.

'Stack

'It represents a last-In, first out collection Of Object.

'It Is used when you need a last-in, first-out access of items. When you add an item in the list, it Is called pushing the item, And when you remove it, it Is called popping the item.
'Queue

'It represents a first-In, first out collection Of Object.
'It Is used when you need a first-in, first-out access of items. When you add an item in the list, it Is called enqueue, And when you remove an item, it Is called deque.

'BitArray

'It represents an array Of the binary representation Using the values 1 And 0.

'It Is used when you need to store the bits but do Not know the number of bits in advance. You can access items from the BitArray collection by using an integer index, which starts from zero.


Module Module1

    Sub Main()

    End Sub

End Module
