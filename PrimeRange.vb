Imports System.Numerics


Public Class PrimeRange


    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles buttonGo.Click
        Dim a As BigInteger
        Dim b As BigInteger
        Dim c As BigInteger
        Dim primeCanidate As BigInteger
        Dim sqrt As BigInteger
        Dim counter As Integer = 0
        Dim divisor As BigInteger

        a = BigInteger.Parse(startNum.Text)
        b = BigInteger.Parse(endNum.Text)
        primeBox.Clear()
        ProgressBar1.Maximum = b - a
        ProgressBar1.Value = 0
        'Button1.Focus()
        c = PrimeDbCheck(b)
        If c > 0 Then
            For primeCanidate = a To c Step 1
                sqrt = Math.Sqrt(primeCanidate)
                'primeCanidate = Form3.Prime(c)
                ProgressBar1.Increment(1)
                'If primeCanidate > 0 Then
                '    MessageBox.Show(primeCanidate.ToString + " is prime")
                'End If

                For c = 0 To sqrt Step 1
                    divisor = NumberTheoryDataSet.primeTable(c).PrimeNumber
                    counter = counter + 1
                    'PrimeRange.ProgressBar1.Increment(1)
                    Label3.Visible = True
                    Label3.Text = ("Dividing " + primeCanidate.ToString + " by " + divisor.ToString)
                    Label3.Update()
                    If divisor > sqrt Then
                        Exit For
                    End If
                    If primeCanidate Mod divisor = 0 Then
                        counter = 0
                        Exit For
                    End If
                Next
                If counter > 0 Then
                    primeBox.AppendText(primeCanidate.ToString + ", ")
                    primeBox.Select(primeBox.TextLength, 0)
                    primeBox.ScrollToCaret()
                End If


            Next
        Else
            MessageBox.Show(b.ToString + " is in the database")
            'primeCanidate = -1
            Dim rowCount As Integer
            Dim rowA As BigInteger = 0
            Dim rowB As BigInteger = 0

            rowCount = Me.NumberTheoryDataSet.primeTable.Rows.Count - 1

            For c = 0 To rowCount Step 1
                If a >= Me.NumberTheoryDataSet.primeTable(c).PrimeNumber Then
                    '    rowA = c
                    '    For d = 0 To rowCount Step 1
                    'If a = Me.NumberTheoryDataSet.primeTable(c).PrimeNumber Then
                    rowA = c
                    'MessageBox.Show("rowB is " + rowB.ToString)

                End If
                '    Next

                'End If
                If b = Me.NumberTheoryDataSet.primeTable(c).PrimeNumber Then
                    rowB = c
                    'MessageBox.Show("rowB is " + rowB.ToString)

                End If
            Next

            MessageBox.Show("rowA is " + rowA.ToString + " and rowB is " + rowB.ToString)
            'If rowA = 0 Then
            '    For c = 0 To rowCount Step 1
            '        If a > c Then
            '            then 
            '        End If
            '    Next
            'End If
            ProgressBar1.Maximum = rowB - rowA
            ProgressBar1.Value = 0
            For c = rowA To rowB Step 1
                ProgressBar1.Increment(1)
                primeCanidate = Me.NumberTheoryDataSet.primeTable(c).PrimeNumber
                primeBox.AppendText(primeCanidate.ToString + ", ")
                primeBox.Select(primeBox.TextLength, 0)
                primeBox.ScrollToCaret()
            Next
        End If

    End Sub
    Public Function PrimeDbCheck(ByVal singleNumber As BigInteger) As BigInteger
        Dim rowCount As Integer
        rowCount = Me.NumberTheoryDataSet.primeTable.Rows.Count - 1
        For a = 0 To rowCount Step 1
            If singleNumber = Me.NumberTheoryDataSet.primeTable(a).PrimeNumber Then
                'MessageBox.Show(singleNumber.ToString + " is in the database, and is in row " + a.ToString)
                PrimeDbCheck = 0
                Exit Function
            End If

        Next
        MessageBox.Show(rowCount)
        MessageBox.Show(singleNumber.ToString + " is not in the database. starting the test")
        Return singleNumber
    End Function
    Private Sub PrimeRange_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'NumberTheoryDataSet.primeTable' table. You can move, or remove it, as needed.
        Me.PrimeTableTableAdapter.Fill(Me.NumberTheoryDataSet.primeTable)
        CenterToScreen()
    End Sub

    Private Sub SinglePrime_close() Handles Me.FormClosed
        Form1.Visible = True
    End Sub

    
    
    Private Sub Button1_Click_1(sender As System.Object, e As System.EventArgs) Handles Button1.Click

    End Sub

    
    
End Class