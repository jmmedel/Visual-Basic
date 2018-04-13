Imports System.Reflection
Imports People

Module ReflectingTypes

    Sub ReflectTypes()

        Dim asm = Assembly.LoadFrom("People.dll")

        Console.WriteLine("Enumerating types:")
        For Each t In asm.GetTypes
            Console.WriteLine("Type name: " + t.ToString)

            Console.WriteLine(" Constructors:")
            For Each constructor In t.GetConstructors
                Console.WriteLine("     " + constructor.ToString)
            Next

            Console.WriteLine(" Methods:")
            For Each method In t.GetMethods
                Console.WriteLine("     " + method.ToString)
            Next

            Console.WriteLine(" Properties:")
            For Each [property] In t.GetProperties
                Console.WriteLine("     " + [property].ToString)
            Next

            Console.WriteLine(" Fields:")
            For Each field In t.GetFields

                Console.WriteLine("     " + field.ToString)
            Next

            Console.WriteLine(" Events:")
            For Each [event] In t.GetEvents
                Console.WriteLine("     " + [event].ToString)
            Next
        Next
        Console.ReadLine()

        Dim myType As Type = (New People.Person).GetType

        Console.WriteLine(" Methods:")
        For Each method In myType.GetMethods
            Console.WriteLine("     " + method.ToString)
        Next

        Console.WriteLine(" Properties:")
        For Each [property] In myType.GetProperties
            Console.WriteLine("     " + [property].ToString)
        Next

        Console.WriteLine(" Fields:")
        For Each field In myType.GetFields
            Console.WriteLine("     " + field.ToString)
        Next

        Console.WriteLine(" Events:")
        For Each [event] In myType.GetEvents
            Console.WriteLine("     " + [event].ToString)
        Next
        Console.ReadLine()
    End Sub
End Module
