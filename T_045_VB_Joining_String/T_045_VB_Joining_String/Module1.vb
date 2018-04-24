
'Joining Strings



Module Module1

    Sub Main()
        Dim strarray As String() = {"Down the way where the nights are gay",
                                  "And the sun shines daily on the mountain top",
                                   "I took a trip on a sailing ship",
                                  "And when I reached Jamaica",
                                  "I made a stop"}
        Dim str As String = String.Join(vbCrLf, strarray)
        Console.WriteLine(str)
        Console.ReadLine()

    End Sub

End Module

'When the above code Is compiled And executed, it produces the following result:

'Down the way where the nights are gay
'And the sun shines daily on the mountain top
'I took a trip On a sailing ship
'And when I reached Jamaica
'I made a Stop


