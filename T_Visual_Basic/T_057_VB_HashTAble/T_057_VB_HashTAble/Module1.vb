
'VB.Net -Hashtable
'    The Hashtable Class represents a collection Of key-And-value pairs that are organized based On the hash code Of the key. It uses the key To access the elements In the collection.

'A hashtable Is used When you need To access elements by Using key, And you can identify a useful key value. Each item In the hashtable has a key/value pair. The key Is used To access the items In the collection.

'Properties And Methods of the Hashtable Class
'The following table lists some Of the commonly used properties Of the Hashtable Class

'Property Description
'Count	Gets the number Of key-And-value pairs contained In the Hashtable.
'IsFixedSize	Gets a value indicating whether the Hashtable has a fixed size.
'IsReadOnly	Gets a value indicating whether the Hashtable Is read-only.
'Item	Gets Or sets the value associated With the specified key.
'Keys	Gets an ICollection containing the keys In the Hashtable.
'Values	Gets an ICollection containing the values In the Hashtable.
'The following table lists some Of the commonly used methods Of the Hashtable Class

'S.N  Method Name & Purpose
'1   
'Public Overridable Sub Add(key As Object, value As Object)

'    Adds an element with the specified key And value into the Hashtable.

'2   
'Public Overridable Sub Clear()

'    Removes all elements from the Hashtable.

'3   Public Overridable Function ContainsKey (key As Object) As Boolean
'Determines whether the Hashtable contains a specific key.

'4   Public Overridable Function ContainsValue (value As Object) As Boolean
'Determines whether the Hashtable contains a specific value.

'5   Public Overridable Sub Remove (key As Object)
'Removes the element with the specified key from the Hashtable.

'Example:
'    The following example demonstrates the concept:



Module Module1

    Sub Main()

        Dim ht As Hashtable = New Hashtable()
        Dim k As String
        ht.Add("001", "Zara Ali")
        ht.Add("002", "Abida Rehman")
        ht.Add("003", "Joe Holzner")
        ht.Add("004", "Mausam Benazir Nur")
        ht.Add("005", "M. Amlan")
        ht.Add("006", "M. Arif")
        ht.Add("007", "Ritesh Saikia")
        If (ht.ContainsValue("Nuha Ali")) Then
            Console.WriteLine("This student name is already in the list")
        Else
            ht.Add("008", "Nuha Ali")
        End If
        ' Get a collection of the keys. 
        Dim key As ICollection = ht.Keys
        For Each k In key
            Console.WriteLine(" {0} : {1}", k, ht(k))
        Next k
        Console.ReadKey()

    End Sub

End Module


'When the above code Is compiled And executed, it produces the following result

'006: M.Arif
'007: Ritesh Saikia
'008: Nuha Ali
'003: Joe Holzner
'002: Abida Rehman
'004: Mausam Banazir Nur
'001: Zara Ali
'005: M.Amlan
