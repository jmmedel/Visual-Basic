'IMPORTANT NOTE
'In order to ensure that the code works, also ensure that the Delete rule for the FK_Products_Categories key is set as Cascade.

'To accomplish this:
'1. open SQL Server Management Studio, then expand the Northwind database
'2. expand the Products table and then the Keys subfolder
'3. right-click the FK_Products_Categories key, then click Modify
'4. click the INSERT and UPDATE specifications node in the dialog and for both Delete and Update rules select Cascade

Imports DataSet.NorthwindDataSetTableAdapters

Module DataSet

    Dim WithEvents NWindDataSet As New NorthwindDataSet
    Dim WithEvents ProductsTblAdapter As New ProductsTableAdapter
    Dim WithEvents TblAdapterManager As New TableAdapterManager

    Sub Main()
        ProductsTblAdapter.Fill(NWindDataSet.Products)
        TblAdapterManager.ProductsTableAdapter = ProductsTblAdapter

        'Insert
        Dim row As NorthwindDataSet.ProductsRow = NWindDataSet.
                                                  Products.NewProductsRow
        row.ProductName = "Italian spaghetti"
        row.Discontinued = False

        NWindDataSet.Products.AddProductsRow(row)
        ProductsTblAdapter.Update(NWindDataSet.Products)

        'If you get a NullReferenceException in the following code,
        'maybe the "1" product ID no longer exists. Check this or change ID number

        'Update
        Dim getRow As NorthwindDataSet.ProductsRow
        getRow = NWindDataSet.Products.FindByProductID(1)

        getRow.Discontinued = True
        ProductsTblAdapter.Update(NWindDataSet.Products)

        'Delete
        Dim delRow As NorthwindDataSet.ProductsRow
        delRow = NWindDataSet.Products.FindByProductID(1)
        delRow.Delete()

        ProductsTblAdapter.Update(NWindDataSet.Products)
    End Sub

End Module