

'Getting a Substring


Module Module1

    Sub Main()
        Dim str As String
        str = "Last night I dreamt of San Pedro"
        Console.WriteLine(str)
        Dim substr As String = str.Substring(23)
        Console.WriteLine(substr)
        Console.ReadLine()
    End Sub

End Module

'When the above code Is compiled And executed, it produces the following result:

'Last night I dreamt Of San Pedro
'San Pedro.

