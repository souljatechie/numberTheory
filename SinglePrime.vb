Imports System.Numerics
Public Class SinglePrime

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim a As BigInteger
        Dim primeCanidate As BigInteger

        a = BigInteger.Parse(singleNum.Text)

        primeCanidate = Prime(a)

        If primeCanidate > 0 Then
            MessageBox.Show(primeCanidate.ToString + " is prime")
        End If
        If primeCanidate = 0 Then
            MessageBox.Show(a.ToString + " is not prime " + "test")
        End If
    End Sub

    'Private Sub SinglePrimeToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles SinglePrimeToolStripMenuItem.Click
    '    Form1.Visible = False
    'End Sub

    Private Sub SinglePrime_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        CenterToScreen()
        Label2.Visible = False
    End Sub

    Private Sub SinglePrime_close() Handles Me.FormClosed
        Form1.Visible = True
    End Sub
End Class
