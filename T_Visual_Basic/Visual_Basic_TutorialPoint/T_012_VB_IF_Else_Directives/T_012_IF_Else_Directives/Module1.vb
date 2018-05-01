

''The #If...Then...#Else Directives
''This directive conditionally compiles selected blocks Of Visual Basic code.

''Syntax for this directive Is

''#If expression Then
''   statements
''[ #ElseIf expression Then
''   [ statements ]
''...
''#ElseIf expression Then
''   [ statements ] ]
''[ #Else
''   [ statements ] ]
''#End If

'For example,

'#Const TargetOS = "Linux"
'#If TargetOS = "Windows 7" Then
'   ' Windows 7 specific code
'#ElseIf TargetOS = "WinXP" Then
'   ' Windows XP specific code
'#Else
'   ' Code for other OS
'#End If


Module Module1

#Const classCode = 8

    Sub Main()
#If classCode = 7 Then
        Console.WriteLine("Exam Questions for Class VII")
#ElseIf classCode = 8 Then
        Console.WriteLine("Exam Questions for Class VIII")
#Else
        Console.WriteLine("Exam Questions for Higher Classes")
#End If
        Console.ReadKey()

    End Sub

End Module
