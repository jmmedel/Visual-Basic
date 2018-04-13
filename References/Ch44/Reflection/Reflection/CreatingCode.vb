Imports System.Reflection
Imports System.Reflection.Emit

Module CreatingCode

    Sub CreateAssembly()

        'Creates assembly name and properties
        Dim asmName As New AssemblyName("People2")
        asmName.Version = New Version("1.0.0")
        asmName.CultureInfo = New Globalization.CultureInfo("en-US")

        'Gets the current application domain
        Dim currentAppDomain As AppDomain = AppDomain.CurrentDomain

        'Creates a new in-memory assembly in the current application domain
        'providing execution and saving capabilities
        Dim asmBuilder As AssemblyBuilder = currentAppDomain.
                                            DefineDynamicAssembly(asmName,
                                            AssemblyBuilderAccess.RunAndSave)

        'Creates a module for containing types
        Dim modBuilder As ModuleBuilder = _
            asmBuilder.DefineDynamicModule("PersonModule",
                                           "People2.dll")

        'Creates a type, specifically a Public Class
        Dim tyBuilder As TypeBuilder = _
            modBuilder.DefineType("Person",
                                  TypeAttributes.Public _
                                  Or TypeAttributes.Class)
        'Defines a default empty constructor
        Dim ctorBuilder As ConstructorBuilder = _
            tyBuilder.DefineDefaultConstructor(MethodAttributes.Public)

        'Defines a field for storing a property value
        Dim fldBuilder As FieldBuilder = _
            tyBuilder.DefineField("_lastName",
                                  GetType(String),
                                  FieldAttributes.Private)

        'Defines a property of type String
        Dim propBuilder As PropertyBuilder = _
            tyBuilder.DefineProperty("LastName",
                                     PropertyAttributes.None, GetType(String),
                                     Type.EmptyTypes)

        'Defines a series of attributes for both getter and setter
        Dim propMethodAttributes As MethodAttributes = _
            MethodAttributes.Public Or
            MethodAttributes.SpecialName Or
            MethodAttributes.HideBySig

        'Defines the getter method for the property
        Dim propGetMethod As MethodBuilder = _
            tyBuilder.DefineMethod("get_LastName",
                                   propMethodAttributes,
                                   GetType(String),
                                   Type.EmptyTypes)

        'Generates IL code for returning the field value
        Dim propGetMethodIL As ILGenerator = propGetMethod.GetILGenerator
        propGetMethodIL.Emit(OpCodes.Ldarg_0)
        propGetMethodIL.Emit(OpCodes.Ldfld, fldBuilder)
        propGetMethodIL.Emit(OpCodes.Ret)

        'Defines the setter method for the property
        Dim propSetMethod As MethodBuilder = _
            tyBuilder.DefineMethod("set_LastName",
                                   propMethodAttributes,
                                   GetType(String),
                                   Type.EmptyTypes)

        'Generates the IL code for setting the field value
        Dim propSetMethodIL As ILGenerator = propSetMethod.GetILGenerator
        propSetMethodIL.Emit(OpCodes.Ldarg_0)
        propSetMethodIL.Emit(OpCodes.Ldarg_1)
        propSetMethodIL.Emit(OpCodes.Stfld, fldBuilder)
        propSetMethodIL.Emit(OpCodes.Ret)

        'Assigns getter and setter to the property
        propBuilder.SetGetMethod(propGetMethod)
        propBuilder.SetSetMethod(propSetMethod)

        'Defines a public method that returns String
        Dim methBuilder As MethodBuilder = _
            tyBuilder.DefineMethod("BuildFullName",
                                   MethodAttributes.Public,
                                   GetType(String),
                                   Type.EmptyTypes)

        'Method body cannot be empty, so just return
        Dim methodILGen As ILGenerator = methBuilder.GetILGenerator
        methodILGen.EmitWriteLine("Method implementation needed")
        methodILGen.Emit(OpCodes.Ret)

        'Creates an instance of the type
        Dim pers As Type = tyBuilder.CreateType

        'Enumerates members for demo purposes
        For Each member In pers.GetMembers
            Console.WriteLine("Member name: {0}", member.Name)
        Next

        'Saves the assembly to disk
        asmBuilder.Save("People2.dll")
        Console.ReadLine()
    End Sub
End Module
