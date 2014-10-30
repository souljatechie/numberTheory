Imports System.Numerics
Module fibonacci

    Function fibRange(ByVal number As BigInteger) As BigInteger
        Dim a As BigInteger = 0
        Dim b As BigInteger = 1
        Dim c As BigInteger
        Dim sum As BigInteger = 1
        Dim counter As BigInteger = 1


        While counter < number
            MessageBox.Show("Fib(" + counter.ToString + ") is " + a.ToString)
            c = a + b
            a = b
            b = c
            counter = counter + 1
        End While

        Return number
    End Function


End Module
