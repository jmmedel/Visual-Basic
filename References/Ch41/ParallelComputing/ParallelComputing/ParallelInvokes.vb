Imports System.Threading.Tasks
Imports System.Threading

Module ParallelInvokes

    Dim angle As Double = 150
    Dim sineResult As Double
    Dim cosineResult As Double
    Dim tangentResult As Double

    Sub InvokeDemo()

        Parallel.Invoke(Sub()
                            Console.WriteLine(Thread.CurrentThread.
                                              ManagedThreadId)
                            Dim radians As Double = angle * Math.PI / 180
                            sineResult = Math.Sin(radians)
                        End Sub,
                        Sub()
                            Console.WriteLine(Thread.CurrentThread.
                                              ManagedThreadId)
                            Dim radians As Double = angle * Math.PI / 180
                            cosineResult = Math.Cos(radians)
                        End Sub,
                        Sub()
                            Console.WriteLine(Thread.CurrentThread.
                                              ManagedThreadId)
                            Dim radians As Double = angle * Math.PI / 180
                            tangentResult = Math.Tan(radians)
                        End Sub)

        Console.WriteLine(sineResult)
        Console.WriteLine(cosineResult)
        Console.WriteLine(tangentResult)
        Console.ReadLine()
    End Sub
End Module