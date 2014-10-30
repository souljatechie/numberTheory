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
        For a = 2 To 2000 Step 1
            primeCanidate = dbPrime(a)

            If primeCanidate > 0 Then
                Dim con As New SqlConnection
                Dim cmd As New SqlCommand
                Try
                    con.ConnectionString = "Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\burgesti\documents\visual studio 2010\Projects\WindowsApplication1\WindowsApplication1\PrimeDB.mdf;Integrated Security=True;User Instance=True"
                    con.Open()
                    cmd.Connection = con
                    cmd.CommandText = "INSERT INTO primeTable(ID) VALUES(" + primeCanidate.ToString + ")"
                    cmd.ExecuteNonQuery()
                    MessageBox.Show("added " + primeCanidate.ToString)
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

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click

    End Sub

    Private Sub NthFibonacciToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles NthFibonacciToolStripMenuItem.Click
        Dim a As BigInteger = 10
        fibRange(a)
    End Sub
End Class
