Imports System.Globalization
Imports System.Net
Imports Microsoft.Win32

Imports System.Reflection
Imports System.Resources


Module Module1
    Sub Main()

        'MyComputerDemo()
        'UserSettingsDemo()
        'MyUserInformation()
        'MyApplicationInfo()
        Console.ReadLine()

    End Sub

    'Returns the specified resource of type String
    'usage:
    'Dim myRes As String = GetResourceByName("TestString")
    Function GetResourceByName(ByVal resourceName As String) As String
        'An example for [Application Name].[Resource File] is the current app:
        'MyNamespace.Resources.resx
        Dim rm As New ResourceManager("[Application Name].[Resource File]",
                                      Assembly.GetExecutingAssembly)

        Return rm.GetString(resourceName)
    End Function

    Sub MyApplicationInfo()

        'Assembly information
        Console.WriteLine("Assembly name: {0}",
                          My.Application.Info.AssemblyName)
        Console.WriteLine("Assembly version: {0}",
                          My.Application.Info.Version)
        Console.WriteLine("Company name: {0}",
                          My.Application.Info.CompanyName)
        'Returns the directory where the application is running from
        Console.WriteLine("Running from: {0}",
                          My.Application.Info.DirectoryPath)

        Console.WriteLine("References:")
        For Each item In My.Application.Info.LoadedAssemblies
            Console.WriteLine(item)
        Next

        'Deployment and environment information
        If My.Application.IsNetworkDeployed = True Then
            Console.WriteLine("Application deployed to a network via ClickOnce")

            Console.WriteLine("Current deployment version: {0}", My.Application.Deployment.CurrentVersion)
            Console.WriteLine("The application runs from: {0}", My.Application.Deployment.ActivationUri)
            Console.WriteLine("Is first time run: {0}", My.Application.Deployment.IsFirstRun)

            My.Application.Deployment.CheckForUpdate()
        End If

        Dim PathEnvironmentVariable As String = My.Application.
                                                GetEnvironmentVariable("PATH")

        'My.Application.Log.WriteEntry("Demonstrating My.Application.Log",
        '                              TraceEventType.Information)

        'Try

        'Catch ex As Exception
        '    My.Application.Log.WriteException(ex)
        'End Try

        'For Each argument As String In My.Application.CommandLineArgs
        '    Console.WriteLine(argument)
        'Next

        'Working with cultures

        Dim culture As CultureInfo = My.Application.Culture
        Debug.WriteLine("Current culture: {0}", culture.Name)

        Dim UICulture As CultureInfo = My.Application.UICulture
        Debug.WriteLine("Current UI culture: {0}", UICulture.Name)

        My.Application.ChangeCulture("it-IT")
        My.Application.ChangeUICulture("it-IT")

        Debug.WriteLine("New settings: {0}, {1}", My.Application.Culture.Name,
                          My.Application.UICulture.Name)

        For Each c In CultureInfo.GetCultures(CultureTypes.AllCultures)
            Console.WriteLine(c.Name)
        Next
    End Sub

    Sub MyUserInformation()
        My.User.InitializeWithWindowsUser()
        Console.WriteLine("Current user is: {0}", My.User.Name)
        Console.WriteLine("User is authenticated: {0}", My.User.IsAuthenticated)
        Console.WriteLine("Is an Administrator: {0}", My.User.IsInRole("MACHINENAME\Administrators"))
        Console.WriteLine(My.User.CurrentPrincipal.Identity.AuthenticationType.ToString)
    End Sub

    Sub UserSettingsDemo()

        If My.Settings.IsFirstTimeRun = True Then
            Console.WriteLine("The application is running for the first time")
            My.Settings.IsFirstTimeRun = False
            My.Settings.Save()
        Else
            Console.WriteLine("The application is already familiar with your system!")
        End If

    End Sub

    Sub MyResourcesDemo()
        Console.WriteLine(My.Resources.TestString)

        'For another demo look at the Windows Form available within the project
    End Sub

    Sub MyComputerDemo()

        'AUDIO

        'My.Computer.Audio.Play("C:\MySound.Wav", AudioPlayMode.BackgroundLoop)
        'Other code...
        'My.Computer.Audio.Stop()

        'My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Exclamation)


        'KEYBOARD
        'All Boolean values
        'Console.WriteLine(My.Computer.Keyboard.AltKeyDown)
        'Console.WriteLine(My.Computer.Keyboard.CtrlKeyDown)
        'Console.WriteLine(My.Computer.Keyboard.ShiftKeyDown)
        'Console.WriteLine(My.Computer.Keyboard.CapsLock)
        'Console.WriteLine(My.Computer.Keyboard.NumLock)
        'Console.WriteLine(My.Computer.Keyboard.ScrollLock)

        'CLIPBOARD
        'My.Computer.Clipboard.Clear()
        'My.Computer.Clipboard.SetText("This is some text")

        'If My.Computer.Clipboard.ContainsText Then
        '    Console.WriteLine(My.Computer.Clipboard.GetText)
        'End If


        'NETWORK
        'If My.Computer.Network.IsAvailable Then
        '    Try

        '        '2000 is the timeout
        '        Dim available As Boolean = My.Computer.
        '                                   Network.
        '                                   Ping("http://community.visual-basic.it/AlessandroEnglish",
        '                                   2000)

        '        My.Computer.Network.DownloadFile("http://www.visual-basic.it/scarica.asp?ID=1016",
        '                                         "C:\WpfDemo.zip",
        '                                         "MyUserName",
        '                                         "MyPassword")

        '    Catch ex As WebException

        '    Catch ex As Exception

        '    End Try
        'End If

        'COMPUTER INFO
        Console.WriteLine("Computer name {0}: ", My.Computer.Name)
        Console.WriteLine("Total physical memory {0}: ",
                          My.Computer.Info.TotalPhysicalMemory)
        Console.WriteLine("Available physical memory {0}: ",
                          My.Computer.Info.AvailablePhysicalMemory)
        Console.WriteLine("Operating system full name {0}: ",
                          My.Computer.Info.OSFullName)
        Console.WriteLine("Operating system version: {0}",
                          My.Computer.Info.OSVersion)
        Console.WriteLine("Installed User Interface culture: {0}",
                          My.Computer.Info.InstalledUICulture.Name)

        Console.WriteLine("GMT Time for local machine: {0}",
                          My.Computer.Clock.GmtTime.ToString)

        Console.WriteLine("Screen resolution: {0} x {1}",
                                  My.Computer.Screen.Bounds.Width,
                                  My.Computer.Screen.Bounds.Height)
        Console.WriteLine("Bits per pixel: {0}",
                                  My.Computer.Screen.BitsPerPixel)
        Console.WriteLine("Working area: {0} x {1}",
                                  My.Computer.Screen.WorkingArea.Width,
                                  My.Computer.Screen.WorkingArea.Height)

        Console.WriteLine("Mouse buttons are swapped: {0}",
                                  My.Computer.Mouse.ButtonsSwapped.ToString)
        Console.WriteLine("Mouse has wheel: {0}",
                          My.Computer.Mouse.WheelExists.ToString)


        'FILE SYSTEM
        'My.Computer.FileSystem.CopyDirectory("C:\Source", "C:\Target")
        'My.Computer.FileSystem.CreateDirectory("C:\Temp")
        'Dim currentDir As String = My.Computer.FileSystem.CurrentDirectory

        'Returns MyFile.txt
        Dim parsedString As String =
            My.Computer.FileSystem.GetName("C:\Temp\MyFile.txt")

        For Each item As String In My.Computer.FileSystem.GetFiles("C:\")
            'Do something here
        Next

        'Read the content of a text file
        'Dim content As String = My.Computer.FileSystem.ReadAllText("C:\ADocument.txt")

        'Creates a new text file
        'My.Computer.FileSystem.WriteAllText("C:\ADocument.txt", "File content",
        'append:=False)

        'Gets My Pictures path
        Dim picturesFolder As String = My.Computer.FileSystem.SpecialDirectories.MyPictures

        'REGISTRY
        Dim regKey As RegistryKey = My.Computer.Registry.
                                    CurrentUser.CreateSubKey("Software\DelSole\MyApplication",
                                    RegistryKeyPermissionCheck.ReadWriteSubTree,
                                    RegistryOptions.None)

        'Value-name, actual value
        regKey.SetValue("MyValue", 1)
        'Returns "1"
        Dim value As String = CStr(My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\DelSole\MyApplication",
                                                                 "MyValue", Nothing))
        Console.WriteLine(value)
        'Returns DWORD
        Dim valueKind As RegistryValueKind = regKey.GetValueKind("MyValue")

        If valueKind = RegistryValueKind.DWord Then
            Dim value2 As Integer = CInt(My.Computer.
                                            Registry.GetValue("HKEY_CURRENT_USER\Software\DelSole\MyApplication",
                                                              "MyValue", Nothing))
            Console.WriteLine(value2)
        End If

        regKey.DeleteValue("MyValue")
        regKey.Close()
        My.Computer.Registry.
            CurrentUser.DeleteSubKey("Software\DelSole\MyApplication",
            True)
    End Sub
End Module