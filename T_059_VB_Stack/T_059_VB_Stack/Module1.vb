
'VB.Net -Stack
'It represents a last-In, first-out collection Of objects. It Is used When you need a last-In, first-out access Of items. When you add an item In the list, it Is called pushing the item, And When you remove it, it Is called popping the item.

'Properties And Methods of the Stack Class
'The following table lists some Of the commonly used properties Of the Stack Class

'Property Description
'Count	Gets the number Of elements contained In the Stack.
'The following table lists some Of the commonly used methods Of the Stack Class

'S.N  Method Name & Purpose
'1   
'Public Overridable Sub Clear()

'    Removes all elements from the Stack.

'2   
'Public Overridable Function Contains(obj As Object) As Boolean

'    Determines whether an element Is in the Stack.

'3   
'Public Overridable Function Peek() As Object

'    Returns the object at the top of the Stack without removing it.

'4   
'Public Overridable Function Pop() As Object

'    Removes And returns the object at the top of the Stack.

'5   
'Public Overridable Sub Push(obj As Object)

'    Inserts an object at the top of the Stack.

'6   
'Public Overridable Function ToArray() As Object()

'    Copies the Stack to a New array.

'Example:
'    The following example demonstrates use of Stack:


Module Module1

    Sub Main()
        Dim st As Stack = New Stack()
        st.Push("A")
        st.Push("M")
        st.Push("G")
        st.Push("W")
        Console.WriteLine("Current stack: ")
        Dim c As Char
        For Each c In st
            Console.Write(c + " ")
        Next c
        Console.WriteLine()
        st.Push("V")
        st.Push("H")
        Console.WriteLine("The next poppable value in stack: {0}", st.Peek())
        Console.WriteLine("Current stack: ")
        For Each c In st
            Console.Write(c + " ")
        Next c
        Console.WriteLine()
        Console.WriteLine("Removing values ")
        st.Pop()
        st.Pop()
        st.Pop()
        Console.WriteLine("Current stack: ")
        For Each c In st
            Console.Write(c + " ")
        Next c
        Console.ReadKey()
    End Sub

End Module



'When the above code Is compiled And executed, it produces the following result:

'Current stack: 
'W G M A
'The next poppable value in stack: H
'Current stack: 
'H V W G M A
'Removing values
'Current stack: 
'G M A