<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.PrimesDataSet1 = New WindowsApplication1.PrimesDataSet()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.PrimesDataSet1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PrimeDBDataSet = New WindowsApplication1.PrimeDBDataSet()
        Me.PrimeTableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PrimeTableTableAdapter = New WindowsApplication1.PrimeDBDataSetTableAdapters.primeTableTableAdapter()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.PrimesDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrimesDataSet1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrimeDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrimeTableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PrimesDataSet1
        '
        Me.PrimesDataSet1.DataSetName = "PrimesDataSet"
        Me.PrimesDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.PrimeTableBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(22, 12)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(377, 172)
        Me.DataGridView1.TabIndex = 0
        '
        'PrimesDataSet1BindingSource
        '
        Me.PrimesDataSet1BindingSource.DataSource = Me.PrimesDataSet1
        Me.PrimesDataSet1BindingSource.Position = 0
        '
        'PrimeDBDataSet
        '
        Me.PrimeDBDataSet.DataSetName = "PrimeDBDataSet"
        Me.PrimeDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PrimeTableBindingSource
        '
        Me.PrimeTableBindingSource.DataMember = "primeTable"
        Me.PrimeTableBindingSource.DataSource = Me.PrimeDBDataSet
        '
        'PrimeTableTableAdapter
        '
        Me.PrimeTableTableAdapter.ClearBeforeFill = True
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(452, 262)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Form2"
        Me.Text = "Form2"
        CType(Me.PrimesDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrimesDataSet1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrimeDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrimeTableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PrimesDataSet1 As WindowsApplication1.PrimesDataSet
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents PrimesDataSet1BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PrimeDBDataSet As WindowsApplication1.PrimeDBDataSet
    Friend WithEvents PrimeTableBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PrimeTableTableAdapter As WindowsApplication1.PrimeDBDataSetTableAdapters.primeTableTableAdapter
    Friend WithEvents IDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
