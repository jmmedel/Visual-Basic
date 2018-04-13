Imports System.Reflection

Module GettingAsmInfo

    Sub Main()

        'AsmInfo()

        'ReflectTypes()

        'DynCode()
        CreateAssembly()

    End Sub

    Sub AsmInfo()

        'Infers System.Reflection.Assembly
        Dim asm = Assembly.ReflectionOnlyLoadFrom("People.dll")

        With asm
            'Gets the full assembly name with
            'version and culture
            Console.WriteLine("Assembly name:")
            Console.WriteLine(.FullName)
            'Gets whether the assembly is fully trusted
            Console.WriteLine("Is full-trust: {0}", .IsFullyTrusted)
            'Gets the assembly entry point. If empty, the
            'constructor is the entry point
            Console.WriteLine("The entry point method is: {0}", .EntryPoint)
            'Gets the .NET version that the
            'assembly was built upon
            Console.WriteLine("Image runtime version: {0}", .ImageRuntimeVersion)
            'Gets whether the assembly was loaded from
            'the GAC
            Console.WriteLine("Loaded from the GAC: {0}", .GlobalAssemblyCache)
            'Gets the assembly location
            Console.WriteLine("Assembly path: {0}", .Location)

            'Gets an array of modules loaded
            'by the assembly
            Console.WriteLine("Loaded modules: ")
            For Each item As System.Reflection.Module _
                In .GetLoadedModules
                Console.WriteLine("   {0}", item.Name)
            Next
        End With

        Console.ReadLine()
    End Sub
End Module
