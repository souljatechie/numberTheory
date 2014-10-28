Public Class Form2

    Private Sub Form2_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'PrimeDBDataSet.primeTable' table. You can move, or remove it, as needed.
        Me.PrimeTableTableAdapter.Fill(Me.PrimeDBDataSet.primeTable)

    End Sub
End Class