Module Module1

    Sub Main()

        Dim currentDomain As AppDomain = AppDomain.CurrentDomain
        'Shows the AppDomain friendly name
        Console.WriteLine(currentDomain.FriendlyName)
        'Shows the AppDomain id within the process
        Console.WriteLine(currentDomain.Id)
        'Shows the working directory for the running
        'assembly within the AppDomain
        Console.WriteLine(currentDomain.BaseDirectory)
        'Returns True if the code is classified as
        'fully-trusted
        Console.WriteLine(currentDomain.IsFullyTrusted)

        Console.ReadLine()

        'Exexutes an assembly within the current app domain
        currentDomain.ExecuteAssembly("AnotherApp.exe")


        Dim secondDomain As AppDomain = AppDomain.
            CreateDomain("secondDomain")

        Try
            secondDomain.ExecuteAssembly("MyApp.exe")
        Catch ex As AppDomainUnloadedException
            Console.WriteLine("The AppDomain was already unloaded")
        Catch ex As Exception
        Finally
            Try
                AppDomain.Unload(secondDomain)
            Catch ex As CannotUnloadAppDomainException
                Console.Write("Unable to unload the AppDomain")
            End Try
        End Try


        Dim domainSetup As New AppDomainSetup
        With domainSetup
            'Sets the current directory for the AppDomain
            .ApplicationBase = Environment.CurrentDirectory
            'Sets the application name
            .ApplicationName = "App domain demo"
            'Allows assembly binding redirection
            .DisallowBindingRedirects = False
            'Disallows code download from assemblies
            'via http
            .DisallowCodeDownload = True
            'Assigns a config file to the new app domain,
            'in this case the app.config of the current domain
            .ConfigurationFile = AppDomain.CurrentDomain.
                                 SetupInformation.ConfigurationFile
        End With

        Dim thirdDomain As AppDomain = AppDomain.
            CreateDomain("thirdDomain", Nothing, domainSetup)

        thirdDomain.ExecuteAssembly("Something.exe")
        'AppDomain.Unload(thirdDomain)
    End Sub

End Module
