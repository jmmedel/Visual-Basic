Imports System.Numerics

Module BigIntegerDemo

    Sub BigIntegerDemo()

        Dim sampleBigInteger As New BigInteger

        'Neither minimum nor maximum values
        sampleBigInteger = Byte.MinValue
        sampleBigInteger = Long.MaxValue

        'The constructor can receive arguments, Double is accepted
        Dim sampleBigInteger2 As New  _
                              BigInteger(123456.789)

        'Single is accepted but with explicit conversion
        Dim singleValue As Single = CSng(1234.56)
        Dim sampleBigInteger3 As New BigInteger
        sampleBigInteger3 = CType(singleValue, 
                            BigInteger)

        'Assumes an Imports System.Numerics directive
        'Sum
        Dim sum As BigInteger =
            BigInteger.Add(sampleBigInteger, sampleBigInteger2)

        'Subtract
        Dim subtraction As BigInteger =
            BigInteger.Subtract(sampleBigInteger, sampleBigInteger2)

        'Division
        Dim division As BigInteger =
            BigInteger.Divide(sampleBigInteger, sampleBigInteger3)

        'Multiplication
        Dim multiplication As BigInteger =
            BigInteger.Multiply(sampleBigInteger2, sampleBigInteger3)

        'Power
        Dim powerBI As BigInteger = BigInteger.Pow(sampleBigInteger2, 2)

        '10 base logarithm
        Dim log10 As Double = BigInteger.Log10(sampleBigInteger3)

        'natural base logarithm
        Dim natLog As Double = BigInteger.Log(sampleBigInteger, 2)
    End Sub

End Module
