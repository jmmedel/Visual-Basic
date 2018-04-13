'This setting is provided by Visual Studio as a default
'so you won't need to add such directive except if you
'set Option Infer Off in the compiler options
Option Infer On
Module Module1
    Sub Main()
        'The compiler infers String
        Dim oneString = "Hello Visual Basic 2015!"

        'The compiler infers Integer
        Dim oneInt = 324

        'The compiler infers Double
        Dim oneDbl = 123.456

        'The compiler infers Boolean
        Dim oneBool = True


        Dim p As New Person With {.FirstName = "Alessandro",
                                  .LastName = "Del Sole"}
        'The compiler infers Person
        Dim onePerson = p
    End Sub
End Module