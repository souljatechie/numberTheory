Imports System.Numerics
Imports System.Data
Imports System.Data.SqlClient

Public Class Form1

    Private Sub SinglePrimeToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles SinglePrimeToolStripMenuItem.Click
        SinglePrime.Visible = True
        Visible = False

    End Sub

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        CenterToScreen()
        MessageBox.Show("*************************** Disclaimer ***************************" + Environment.NewLine + Environment.NewLine + "                  This program is still in early alpha stages" +
                       Environment.NewLine + Environment.NewLine + "*************************** Disclaimer ***************************")
    End Sub

    Private Sub Form1_close() Handles Me.FormClosed
        MessageBox.Show("bye")
    End Sub

    Private Sub PrimeRangeToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles PrimeRangeToolStripMenuItem.Click
        PrimeRange.Visible = True
        Visible = False
    End Sub

    Private Sub Label1_Click(sender As System.Object, e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button1_Click_1(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim a As BigInteger
        Dim b As BigInteger
        Dim primeCanidate As BigInteger
        ProgressBar1.Maximum = 20000
        For a = 2 To 20000 Step 1

            primeCanidate = dbPrime(a)
            ProgressBar1.Increment(1)
            If primeCanidate > 0 Then
                Dim con As New SqlConnection
                Dim cmd As New SqlCommand
                Try
                    con.ConnectionString = "Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\burgesti\documents\visual studio 2010\Projects\WindowsApplication1\WindowsApplication1\PrimeDB.mdf;Integrated Security=True;User Instance=True"
                    con.Open()
                    cmd.Connection = con
                    cmd.CommandText = "INSERT INTO primeTable(ID) VALUES(" + primeCanidate.ToString + ")"
                    cmd.ExecuteNonQuery()
                    'MessageBox.Show("added " + primeCanidate.ToString)
                Catch ex As Exception
                    If ex.Message.Contains("Cannot insert duplicate key") = False Then
                        MessageBox.Show("Error while updating record on table..." & ex.Message, "Update Records")
                    End If
                Finally

                    con.Close()
                End Try
            End If
        Next
        MessageBox.Show("database is populated")
    End Sub

    Private Sub DatabaseToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles DatabaseToolStripMenuItem.Click
        Form2.Visible = True
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub NthFibonacciToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles NthFibonacciToolStripMenuItem.Click

        'fibRange(a)
        Dim fibNthForm As New PrimeRange
        Dim a As BigInteger
        Dim b As BigInteger
        Dim primeCanidate As BigInteger
        Dim startNum As String
        Dim endNum As String

       

        fibNthForm.Visible = True
        startNum = fibNthForm.startNum.Text
        endNum = fibNthForm.endNum.Text
        Stop

        While startNum IsNot Nothing And endNum IsNot Nothing
            a = BigInteger.Parse(fibNthForm.startNum.Text)
            b = BigInteger.Parse(fibNthForm.endNum.Text)
            fibNthForm.primeBox.Clear()
            fibNthForm.ProgressBar1.Maximum = b - a
            fibNthForm.ProgressBar1.Value = 0
            fibNthForm.Button1.Focus()
            For c = a To b Step 1

                primeCanidate = Prime(c)
                fibNthForm.ProgressBar1.Increment(1)
                'If primeCanidate > 0 Then
                '    MessageBox.Show(primeCanidate.ToString + " is prime")
                'End If

            Next
        End While
        
    End Sub
End Class
