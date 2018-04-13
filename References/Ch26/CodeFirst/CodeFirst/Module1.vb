Imports System.Data.Entity

Module Module1

    Sub Main()
        'Recreate the database only in case of changes
        'between the model and the database schema
        Database.SetInitializer(New DropCreateDatabaseIfModelChanges(Of BookStore))

        'Always recreate the database
        Database.SetInitializer(New DropCreateDatabaseAlways(Of BookStore))

        Using db As New BookStore
            Dim _author As New Author With {.FirstName = "Alessandro",
                                            .LastName = "Del Sole"}
            db.Authors.Add(_author)

            Dim LSBook As New Book With {.Title = "Visual Basic LightSwitch Unleashed",
                                        .Author = _author,
                                        .ISBN = "978-0672335532",
                                        .Price = 31.49D}
            db.Books.Add(LSBook)

            Dim VB2012Book As New Book With {.Title = "Visual Basic" _
                                        + " 2012 Unleashed",
                                        .Author = _author,
                                        .ISBN = " 978-0672336317",
                                        .Price = 31.49D}
            db.Books.Add(VB2012Book)

            db.SaveChanges()

            Dim authorInstance = db.Authors.
                Single(Function(a) a.LastName = "Del Sole")
            Console.WriteLine(authorInstance.FirstName + " " + authorInstance.LastName)

            For Each item In authorInstance.Books
                Console.WriteLine("    published ""{0}"", ISBN: {1}",
                                  item.Title,
                                  item.ISBN)
            Next

        End Using
        Console.ReadLine()
    End Sub


End Module
