Imports System.Numerics
Public Class Form3

    Private Sub PrimeTableBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.PrimeTableBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.NumberTheoryDataSet)

    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'NumberTheoryDataSet.primeTable' table. You can move, or remove it, as needed.
        Me.PrimeTableTableAdapter.Fill(Me.NumberTheoryDataSet.primeTable)
        MessageBox.Show("divisor is now " + NumberTheoryDataSet.primeTable(255).PrimeNumber.ToString)
    End Sub

    Public Function Prime(ByVal singleNumber As BigInteger) As BigInteger
        Me.PrimeTableTableAdapter.Fill(Me.NumberTheoryDataSet.primeTable)
        Dim sqrt As BigInteger = Math.Sqrt(singleNumber)
        Dim a As BigInteger
        Dim divisor As BigInteger = 0
        'b = NumberTheoryDataSet.primeTable(1).PrimeNumber
        'If SinglePrime.Visible = True Then
        'MessageBox.Show("I will now start dividing " + singleNumber.ToString + " by all prime numbers up to " + sqrt.ToString)
        For a = 0 To sqrt Step 1
            divisor = NumberTheoryDataSet.primeTable(a).PrimeNumber
            ' MessageBox.Show("divisor is now " + NumberTheoryDataSet.primeTable(a).PrimeNumber.ToString)
            If divisor > sqrt Then
                a = sqrt
            End If
            SinglePrime.Label2.Visible = True
            SinglePrime.Label2.Text = ("Dividing " + singleNumber.ToString + " by " + divisor.ToString)
            SinglePrime.Label2.Update()

            If singleNumber Mod divisor = 0 Then

                Exit Function
            End If
        Next
        'End if
        If PrimeRange.Visible = True Then
            For a = 2 To sqrt Step 1
                'PrimeRange.ProgressBar1.Increment(1)
                PrimeRange.Label3.Visible = True
                PrimeRange.Label3.Text = ("Dividing " + singleNumber.ToString + " by " + a.ToString)
                PrimeRange.Label3.Update()
                If singleNumber Mod a = 0 Then
                    Exit Function
                End If
            Next
            PrimeRange.primeBox.AppendText(singleNumber.ToString + ", ")
            PrimeRange.primeBox.Select(PrimeRange.primeBox.TextLength, 0)
            PrimeRange.primeBox.ScrollToCaret()
        End If
        Return singleNumber
    End Function

    Public Function dbPrime(ByVal singleNumber As BigInteger) As BigInteger
        Me.PrimeTableTableAdapter.Fill(Me.NumberTheoryDataSet.primeTable)
        Dim sqrt As BigInteger = Math.Sqrt(singleNumber)
        Dim a As BigInteger
        Dim divisor As BigInteger = 0

        For a = 0 To sqrt Step 1
            'PrimeRange.ProgressBar1.Increment(1)
            'PrimeRange.Label3.Visible = True
            'PrimeRange.Label3.Text = ("Dividing " + singleNumber.ToString + " by " + a.ToString)
            'PrimeRange.Label3.Update()
            divisor = NumberTheoryDataSet.primeTable(a).PrimeNumber
            ' MessageBox.Show("divisor is now " + NumberTheoryDataSet.primeTable(a).PrimeNumber.ToString)
            If divisor > sqrt Then
                a = sqrt
            End If
            If singleNumber Mod divisor = 0 Then
                Exit Function
            End If
        Next
        Return singleNumber
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox1.Text = NumberTheoryDataSet.primeTable(255).PrimeNumber.ToString
        Dim netest As BigInteger
        netest = NumberTheoryDataSet.primeTable(255).PrimeNumber
        MessageBox.Show("netest is set to " + netest.ToString)
    End Sub
End Class