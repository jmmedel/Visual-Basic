Imports System.Security
Imports System.Security.Policy
Imports System.Reflection

<Assembly: SecurityRules(Security.SecurityRuleSet.Level2)> 
<Assembly: SecurityTransparent()> 

Module Module1
    Sub Main()
        Dim ev As New Evidence()
        ev.AddHostEvidence(New Zone(SecurityZone.Intranet))

        Dim permSet As PermissionSet = SecurityManager.GetStandardSandbox(ev)

        Dim ads As New AppDomainSetup()
        ads.ApplicationBase = "C:\MyApps"

        Dim hostEvidence As New Evidence()
        Dim sandbox As AppDomain = AppDomain.
            CreateDomain("Sandboxed Domain", hostEvidence, ads,
                         permSet, Nothing)

        sandbox.ExecuteAssemblyByName("ExternalApp")
    End Sub
End Module
