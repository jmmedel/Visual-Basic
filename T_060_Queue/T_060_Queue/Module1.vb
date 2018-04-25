

'VB.Net -Queue
'    t represents a first-In, first-out collection Of Object. It Is used When you need a first-In, first-out access Of items. When you add an item In the list, it Is called enqueue, And When you remove an item, it Is called deque

'Properties And Methods of the Queue Class
'The following table lists some Of the commonly used properties Of the Queue Class

'Property Description
'Count	Gets the number Of elements contained In the Queue.
'The following table lists some Of the commonly used methods Of the Queue Class

'S.N  Method Name & Purpose
'1   
'Public Overridable Sub Clear()

'    Removes all elements from the Queue.

'2   
'Public Overridable Function Contains(obj As Object) As Boolean

'    Determines whether an element Is in the Queue.

'3   
'Public Overridable Function Dequeue() As Object

'    Removes And returns the object at the beginning of the Queue.

'4   
'Public Overridable Sub Enqueue(obj As Object)

'    Adds an object to the end of the Queue.

'5   
'Public Overridable Function ToArray() As Object()

'    Copies the Queue to a New array.

'6   
'Public Overridable Sub TrimToSize()

'    Sets the capacity to the actual number of elements in the Queue.

'Example:
'    The following example demonstrates use of Queue:



Module Module1

    Sub Main()
        Dim q As Queue = New Queue()
        q.Enqueue("A")
        q.Enqueue("M")
        q.Enqueue("G")
        q.Enqueue("W")
        Console.WriteLine("Current queue: ")
        Dim c As Char
        For Each c In q
            Console.Write(c + " ")
        Next c
        Console.WriteLine()
        q.Enqueue("V")
        q.Enqueue("H")
        Console.WriteLine("Current queue: ")
        For Each c In q
            Console.Write(c + " ")
        Next c
        Console.WriteLine()
        Console.WriteLine("Removing some values ")
        Dim ch As Char
        ch = q.Dequeue()
        Console.WriteLine("The removed value: {0}", ch)
        ch = q.Dequeue()
        Console.WriteLine("The removed value: {0}", ch)
        Console.ReadKey()
    End Sub

End Module


'When the above code Is compiled And executed, it produces the following result:

'Current queue: 
'A M G W 
'Current queue: 
'A M G W V H 
'Removing some values
'The removed value: A
'The removed value: M
