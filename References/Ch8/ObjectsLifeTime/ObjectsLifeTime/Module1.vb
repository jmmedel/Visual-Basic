Imports System.Threading

Module Module1

    Sub Main()

        Dim p As New Person
        p.FirstName = "Alessandro"
        p.LastName = "Del Sole"

        p = Nothing
        'Forces the garbage colletor
        'so that the object is effectively
        'cleaned up
        System.GC.Collect()


        'Using dp As New IO.StreamWriter("C:\TestFile.txt", False)
        'dp.WriteLine("This is a demo text")
        'End Using

        Dim combination As New ProperCleanup
        combination = Nothing
    End Sub

    Public resurrected As ResurrectionDemo

    Sub TestResurrection()
        Dim r As New ResurrectionDemo
        'This will invoke Finalize
        r = Nothing

    End Sub
End Module

Class Person
    Property FirstName As String
    Property LastName As String

    Sub New()

    End Sub
End Class

Class ResurrectionDemo

    Protected Overrides Sub Finalize()
        'The object is resurrected here
        resurrected = Me
        GC.ReRegisterForFinalize(Me)
    End Sub
End Class

Class DestructorDemo
    Sub New()
        GC.RegisterForFullGCNotification(10, 10)

    End Sub

    Protected Overrides Sub Finalize()
        'Write your code here for releasing
        'such as closing db connections,
        'closing network connections,
        'and other resources that VB cannot understand

        MyBase.Finalize() 'this is just the base implementation
    End Sub
End Class

Class tes
    Sub Main()
        Try
            'Registers for notification about gen2 (1st arg) and
            'large objects on the heap (2nd arg)
            GC.RegisterForFullGCNotification(10, 10)

            'Notifications are handled via a separate thread
            Dim thWaitForFullGC As New Thread(New  _
                                       ThreadStart(AddressOf WaitForFullGCProc))
            thWaitForFullGC.Start()

        Catch ex As InvalidOperationException

            'Probably concurrent GC is enabled
            Console.WriteLine(ex.Message)
        End Try
    End Sub

    Public Shared Sub WaitForFullGCProc()
        While True
            'Notification status
            Dim s As GCNotificationStatus

            'Register for an event advising
            'that a GC is imminent
            s = GC.WaitForFullGCApproach()

            If s = GCNotificationStatus.Succeeded Then
                'A garbage collection is imminent

            End If

            'Register for an event advising
            'that a GC was completed
            s = GC.WaitForFullGCComplete()
            If s = GCNotificationStatus.Succeeded Then

                'A garbage collection is completed
            End If
        End While
    End Sub
End Class
