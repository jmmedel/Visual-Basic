Imports System.Reflection
Module DynamicCode

    Sub DynCode()
        Dim asm = Assembly.LoadFrom("People.dll")

        'Gets the type definition
        Dim personType = asm.GetType("People.Person")

        'Gets the LastName property definition
        Dim lastNameProperty As PropertyInfo = personType.
                                               GetProperty("LastName")
        'Gets a reference to the property setter
        Dim lastNamePropSet As MethodInfo = lastNameProperty.
                                            GetSetMethod

        Dim firstNameProperty As PropertyInfo = personType.
                                                GetProperty("FirstName")
        Dim firstNamePropSet As MethodInfo = firstNameProperty.
                                             GetSetMethod

        Dim ageProperty As PropertyInfo = personType.GetProperty("Age")
        Dim agePropSet As MethodInfo = ageProperty.GetSetMethod

        'Creates an instance of the Person class
        Dim newPerson As Object = _
            Activator.CreateInstance(personType)

        'Each method is invoked upon the new type instance
        lastNamePropSet.Invoke(newPerson, New Object() {"Del Sole"})
        firstNamePropSet.Invoke(newPerson, New Object() {"Alessandro"})
        agePropSet.Invoke(newPerson, New Object() {35})

        'Gets the BuildFullName method from the Person class
        Dim buildFullNameMethod = personType.GetMethod("BuildFullName")

        'The method returns String but Invoke returns Object, so
        'a conversion is required
        Dim result As String = CStr(buildFullNameMethod.
                               Invoke(newPerson, Nothing))

        Console.WriteLine(result)
        Console.ReadLine()
    End Sub
End Module
