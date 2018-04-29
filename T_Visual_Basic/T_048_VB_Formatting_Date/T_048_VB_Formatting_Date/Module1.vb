
'Formatting Date
'A Date literal should be enclosed within hash signs (# #), And specified in the format M/d/yyyy, for example #12/16/2012#. Otherwise, your code may change depending on the locale in which your application Is running.

'For example, you specified Date literal of #2/6/2012# for the date February 6, 2012. It Is alright for the locale that uses mm/dd/yyyy format. However, in a locale that uses dd/mm/yyyy format, your literal would compile To June 2, 2012. If a locale uses another format say, yyyy/mm/dd, the literal would be invalid And cause a compiler Error.

'To convert a Date literal to the format of your locale Or to a custom format, use the Format function of String class, specifying either a predefined Or user-defined date format.

'The following example demonstrates this.


Module Module1

    Sub Main()
        Console.WriteLine("India Wins Freedom: ")
        Dim independenceDay As New Date(1947, 8, 15, 0, 0, 0)
        ' Use format specifiers to control the date display.
        Console.WriteLine(" Format 'd:' " & independenceDay.ToString("d"))
        Console.WriteLine(" Format 'D:' " & independenceDay.ToString("D"))
        Console.WriteLine(" Format 't:' " & independenceDay.ToString("t"))
        Console.WriteLine(" Format 'T:' " & independenceDay.ToString("T"))
        Console.WriteLine(" Format 'f:' " & independenceDay.ToString("f"))
        Console.WriteLine(" Format 'F:' " & independenceDay.ToString("F"))
        Console.WriteLine(" Format 'g:' " & independenceDay.ToString("g"))
        Console.WriteLine(" Format 'G:' " & independenceDay.ToString("G"))
        Console.WriteLine(" Format 'M:' " & independenceDay.ToString("M"))
        Console.WriteLine(" Format 'R:' " & independenceDay.ToString("R"))
        Console.WriteLine(" Format 'y:' " & independenceDay.ToString("y"))
        Console.ReadKey()
    End Sub

End Module


'When the above code Is compiled And executed, it produces the following result:

'India Wins Freedom
'Format 'd:' 8/15/1947
'Format 'D:' Friday, August 15, 1947
'Format 't:' 12:00 AM
'Format 'T:' 12:00:00 AM
'Format 'f:' Friday, August 15, 1947 12:00 AM
'Format 'F:' Friday, August 15, 1947 12:00:00 AM
'Format 'g:' 8/15/1947 12:00 AM
'Format 'G:' 8/15/1947 12:00:00 AM
'Format 'M:' 8/15/1947 August 15
'Format 'R:' Fri, 15 August 1947 00:00:00 GMT
'Format 'y:' August, 1947
