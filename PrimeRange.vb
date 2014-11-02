Imports System.Numerics


Public Class PrimeRange


    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles buttonGo.Click
        Dim a As BigInteger
        Dim b As BigInteger
        Dim primeCanidate As BigInteger


        a = BigInteger.Parse(startNum.Text)
        b = BigInteger.Parse(endNum.Text)
        primeBox.Clear()
        ProgressBar1.Maximum = b - a
        ProgressBar1.Value = 0
        Button1.Focus()
        For c = a To b Step 1

            primeCanidate = Prime(c)
            ProgressBar1.Increment(1)
            'If primeCanidate > 0 Then
            '    MessageBox.Show(primeCanidate.ToString + " is prime")
            'End If

        Next
    End Sub

    Private Sub PrimeRange_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        CenterToScreen()
    End Sub

    Private Sub SinglePrime_close() Handles Me.FormClosed
        Form1.Visible = True
    End Sub

    
    
    Private Sub Button1_Click_1(sender As System.Object, e As System.EventArgs) Handles Button1.Click

    End Sub
End Class