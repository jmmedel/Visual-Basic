Module Module1

    Sub Main()
        'The original person
        Dim firstPerson As New Person
        firstPerson.FirstName = "Alessandro"
        firstPerson.LastName = "Del Sole"

        'Defines a work for the above person
        Dim randomJob As New Job
        randomJob.CompanyName = "Del Sole Ltd."
        randomJob.Position = "CEO"

        'Assignment of the new job
        firstPerson.Work = randomJob

        'Gets a shallow copy of the firstPerson object
        Dim secondPerson As Person = CType(firstPerson.Clone, Person)

        'Shows information for firstPerson
        Console.WriteLine("{0} {1}, {2} {3}", firstPerson.FirstName,
                                              firstPerson.LastName,
                                              firstPerson.Work.CompanyName,
                                              firstPerson.Work.Position)


        'Check if they are the same instances

        'returns False, 2 different instances:
        Console.WriteLine(firstPerson.FirstName Is secondPerson.FirstName)

        'returns True (still same instance of Job!):
        Console.WriteLine(firstPerson.Work Is secondPerson.Work)
        Console.ReadLine()

    End Sub

End Module

Class Person
    Implements ICloneable

    Property FirstName As String
    Property LastName As String
    Property Work As Job

    Public Function Clone() As Object Implements System.ICloneable.Clone

        Dim tempPerson As Person = CType(Me.MemberwiseClone, Person)

        tempPerson.Work = CType(Me.Work.Clone, Job)

        Return tempPerson

    End Function
End Class

Class Job
    Implements ICloneable

    Property CompanyName As String
    Property Position As String

    Public Function Clone() As Object Implements System.ICloneable.Clone
        Return Me.MemberwiseClone
    End Function
End Class