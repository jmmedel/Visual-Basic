'Properties of the String Class
'The String class has the following two properties

'S.N  Property Name & Description
'1   
'Chars

'Gets the Char Object at a specified position In the current String Object.

'2   
'Length

'Gets the number Of characters In the current String Object.

'Methods of the String Class
'The String class has numerous methods that help you in working with the string objects. The following table provides some of the most commonly used methods

'S.N  Method Name & Description
'1   
'Public Shared Function Compare(strA As String, strB As String) As Integer

'    Compares two specified string objects And returns an integer that indicates their relative position in the sort order.

'2   
'Public Shared Function Compare(strA As String, strB As String, ignoreCase As Boolean) As Integer

'    Compares two specified String objects And returns an Integer that indicates their relative position In the sort order. However, it ignores case if the Boolean parameter Is true.

'3   
'Public Shared Function Concat(str0 As String, str1 As String) As String

'    Concatenates two string objects.

'4   
'Public Shared Function Concat(str0 As String, str1 As String, str2 As String) As String

'    Concatenates three string objects.

'5   
'Public Shared Function Concat(str0 As String, str1 As String, str2 As String, str3 As String) As String

'    Concatenates four string objects.

'6   
'Public Function Contains(value As String) As Boolean

'    Returns a value indicating whether the specified string object occurs within this string.

'7   
'Public Shared Function Copy(str As String) As String

'    Creates a New String object with the same value as the specified string.

'8   
'pPublic Sub() CopyTo(sourceIndex As Integer, destination As Char(), destinationIndex As Integer, count As Integer )

'Copies a specified number of characters from a specified position of the string object to a specified position in an array of Unicode characters.

'9   
'Public Function EndsWith(value As String) As Boolean

'    Determines whether the end of the string object matches the specified string.

'10  
'Public Function Equals(value As String) As Boolean

'    Determines whether the current string object And the specified string object have the same value.

'11  
'Public Shared Function Equals(a As String, b As String) As Boolean

'    Determines whether two specified string objects have the same value.

'12  
'Public Shared Function Format(format As String, arg0 As Object) As String

'    Replaces one Or more format items in a specified string with the string representation of a specified object.

'13  
'Public Function IndexOf(value As Char) As Integer

'    Returns the zero-based index of the first occurrence of the specified Unicode character in the current string.

'14  
'Public Function IndexOf(value As String) As Integer

'    Returns the zero-based index of the first occurrence of the specified string in this instance.

'15  
'Public Function IndexOf(value As Char, startIndex As Integer) As Integer

'    Returns the zero-based index Of the first occurrence Of the specified Unicode character In this String, starting search at the specified character position.

'16  
'Public Function IndexOf(value As String, startIndex As Integer) As Integer

'    Returns the zero-based index Of the first occurrence Of the specified String In this instance, starting search at the specified character position.

'17  
'Public Function IndexOfAny(anyOf As Char()) As Integer

'    Returns the zero-based index of the first occurrence in this instance of any character in a specified array of Unicode characters.

'18  
'Public Function IndexOfAny(anyOf As Char(), startIndex As Integer) As Integer

'    Returns the zero-based index Of the first occurrence In this instance Of any character In a specified array Of Unicode characters, starting search at the specified character position.

'19  
'Public Function Insert(startIndex As Integer, value As String) As String

'    Returns a New string in which a specified string Is inserted at a specified index position in the current string object.

'20  
'Public Shared Function IsNullOrEmpty(value As String) As Boolean

'    Indicates whether the specified string Is null Or an Empty string.

'21  
'Public Shared Function Join(separator As String, ParamArray value As String()) As String

'    Concatenates all the elements Of a String array, using the specified separator between each element.

'22  
'Public Shared Function Join(separator As String, value As String(), startIndex As Integer, count As Integer) As String

'    Concatenates the specified elements Of a String array, using the specified separator between each element.

'23  
'Public Function LastIndexOf(value As Char) As Integer

'    Returns the zero-based index position of the last occurrence of the specified Unicode character within the current string object.

'24  
'Public Function LastIndexOf(value As String) As Integer

'    Returns the zero-based index position of the last occurrence of a specified string within the current string object.

'25  
'Public Function Remove(startIndex As Integer) As String

'    Removes all the characters In the current instance, beginning at a specified position And continuing through the last position, And returns the string.

'26  
'Public Function Remove(startIndex As Integer, count As Integer) As String

'    Removes the specified number of characters in the current string beginning at a specified position And returns the string.

'27  
'Public Function Replace(oldChar As Char, newChar As Char) As String

'    Replaces all occurrences of a specified Unicode character in the current string object with the specified Unicode character And returns the New string.

'28  
'Public Function Replace(oldValue As String, newValue As String) As String

'    Replaces all occurrences of a specified string in the current string object with the specified string And returns the New string.

'29  
'Public Function Split(ParamArray separator As Char()) As String()

'    Returns a String array that contains the substrings In the current String Object, delimited by elements of a specified Unicode character array.

'30  
'Public Function Split(separator As Char(), count As Integer) As String()

'    Returns a String array that contains the substrings In the current String Object, delimited by elements of a specified Unicode character array. The int parameter specifies the maximum number of substrings to return.

'31  
'Public Function StartsWith(value As String) As Boolean

'    Determines whether the beginning of this string instance matches the specified string.

'32  
'Public Function ToCharArray() As Char()

'    Returns a Unicode character array with all the characters in the current string object.

'33  
'Public Function ToCharArray(startIndex As Integer, length As Integer) As Char()

'    Returns a Unicode character array With all the characters In the current String Object, starting from the specified index And up to the specified length.

'34  
'Public Function ToLower() As String

'    Returns a copy of this string converted to lowercase.

'35  
'Public Function ToUpper() As String

'    Returns a copy of this string converted to uppercase.

'36  
'Public Function Trim() As String

'    Removes all leading And trailing white-space characters from the current String object.

'the above list Of methods Is Not exhaustive, please visit MSDN library for the complete list of methods And String class constructors.


'Examples:
'The following example demonstrates some Of the methods mentioned above:

'Comparing Strings

Module Module1

    Sub Main()
        Dim str1, str2 As String
        str1 = "This is test"
        str2 = "This is text"
        If (String.Compare(str1, str2) = 0) Then
            Console.WriteLine(str1 + " and " + str2 +
                            " are equal.")
        Else
            Console.WriteLine(str1 + " and " + str2 +
                            " are not equal.")
        End If
        Console.ReadLine()
    End Sub

End Module


'When the above code Is compiled And executed, it produces the following result

'This Is test And This Is text are Not equal.