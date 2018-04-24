
'VB.Net -Directives
'    The VB.Net compiler directives give instructions To the compiler To preprocess the information before actual compilation starts.

'All these directives begin With #, And only white-space characters may appear before a directive On a line. These directives are Not statements.

'VB.Net compiler does Not have a separate preprocessor; however, the directives are processed As If there was one. In VB.Net, the compiler directives are used To help In conditional compilation. Unlike C And C++ directives, they are Not used to create macros.

'Compiler Directives In VB.Net
'VB.Net provides the following set of compiler directives

'The #Const Directive

'The #ExternalSource Directive

'The #If...Then...#Else Directives

'The #Region Directive

'The #Const Directive
'This directive defines conditional compiler constants. Syntax For this directive Is

'#Const constname = expression
'Where,

'constname: specifies the name Of the constant. Required.

'expression: it Is either a literal, Or other conditional compiler constant, Or a combination including any Or all arithmetic Or logical operators except Is.

'For example,

'#Const state = "WEST BENGAL"



Module Module1

#Const age = True
    Sub Main()
#If age Then
        Console.WriteLine("You are welcome to the Robotics Club")
#End If
        Console.ReadKey()
    End Sub

End Module
