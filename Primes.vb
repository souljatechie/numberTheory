'Imports System.Numerics
'Module Primes

'    Function Prime(ByVal singleNumber As BigInteger) As BigInteger
'        Dim sqrt As BigInteger = Math.Sqrt(singleNumber)
'        Dim a As BigInteger
'        If SinglePrime.Visible = True Then
'            MessageBox.Show("I will now start dividing " + singleNumber.ToString + " by all numbers up to " + sqrt.ToString)
'            For a = 2 To sqrt Step 1
'                SinglePrime.Label2.Visible = True
'                SinglePrime.Label2.Text = ("Dividing " + singleNumber.ToString + " by " + a.ToString)
'                SinglePrime.Label2.Update()

'                If singleNumber Mod a = 0 Then
'                    Exit Function
'                End If
'            Next
'        End If
'        If PrimeRange.Visible = True Then
'            For a = 2 To sqrt Step 1
'                'PrimeRange.ProgressBar1.Increment(1)
'                PrimeRange.Label3.Visible = True
'                PrimeRange.Label3.Text = ("Dividing " + singleNumber.ToString + " by " + a.ToString)
'                PrimeRange.Label3.Update()
'                If singleNumber Mod a = 0 Then
'                    Exit Function
'                End If
'            Next
'            PrimeRange.primeBox.AppendText(singleNumber.ToString + ", ")
'            PrimeRange.primeBox.Select(PrimeRange.primeBox.TextLength, 0)
'            PrimeRange.primeBox.ScrollToCaret()
'        End If
'        Return singleNumber
'    End Function

'    Function dbPrime(ByVal singleNumber As BigInteger) As BigInteger
'        Dim a As BigInteger
'        Dim sqrt As BigInteger = Math.Sqrt(singleNumber)

'        For a = 2 To sqrt Step 1
'            'PrimeRange.ProgressBar1.Increment(1)
'            'PrimeRange.Label3.Visible = True
'            'PrimeRange.Label3.Text = ("Dividing " + singleNumber.ToString + " by " + a.ToString)
'            'PrimeRange.Label3.Update()

'            If singleNumber Mod a = 0 Then
'                Exit Function
'            End If
'        Next
'        Return singleNumber
'    End Function


'End Module
