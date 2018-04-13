
Namespace My

    'This class allows you to handle specific events on the settings class:
    ' The SettingChanging event is raised before a setting's value is changed.
    ' The PropertyChanged event is raised after a setting's value is changed.
    ' The SettingsLoaded event is raised after the setting values are loaded.
    ' The SettingsSaving event is raised before the setting values are saved.
    Partial Friend NotInheritable Class MySettings

        Private Sub MySettings_SettingChanging(ByVal sender As Object,
                                               ByVal e As System.Configuration.
                                               SettingChangingEventArgs) _
                                               Handles Me.SettingChanging
            Console.WriteLine("About to change the settings values")
            'Waits for one second
            System.Threading.Thread.Sleep(1000)
        End Sub



        Private Sub MySettings_SettingsSaving(ByVal sender As Object,
                                              ByVal e As System.ComponentModel.CancelEventArgs) _
                                              Handles Me.SettingsSaving

            If My.Settings.ValidationTest Is Nothing Then
                Throw New NullReferenceException("Cannot save a null string")
                e.Cancel = True
            End If
        End Sub
    End Class
End Namespace