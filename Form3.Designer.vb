<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Me.NumberTheoryDataSet = New WindowsApplication1.NumberTheoryDataSet()
        Me.PrimeTableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PrimeTableTableAdapter = New WindowsApplication1.NumberTheoryDataSetTableAdapters.primeTableTableAdapter()
        Me.TableAdapterManager = New WindowsApplication1.NumberTheoryDataSetTableAdapters.TableAdapterManager()
        Me.PrimeTableDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.NumberTheoryDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrimeTableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrimeTableDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NumberTheoryDataSet
        '
        Me.NumberTheoryDataSet.DataSetName = "NumberTheoryDataSet"
        Me.NumberTheoryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PrimeTableBindingSource
        '
        Me.PrimeTableBindingSource.DataMember = "primeTable"
        Me.PrimeTableBindingSource.DataSource = Me.NumberTheoryDataSet
        '
        'PrimeTableTableAdapter
        '
        Me.PrimeTableTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.primeTableTableAdapter = Me.PrimeTableTableAdapter
        Me.TableAdapterManager.UpdateOrder = WindowsApplication1.NumberTheoryDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'PrimeTableDataGridView
        '
        Me.PrimeTableDataGridView.AutoGenerateColumns = False
        Me.PrimeTableDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PrimeTableDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2})
        Me.PrimeTableDataGridView.DataSource = Me.PrimeTableBindingSource
        Me.PrimeTableDataGridView.Location = New System.Drawing.Point(96, 98)
        Me.PrimeTableDataGridView.Name = "PrimeTableDataGridView"
        Me.PrimeTableDataGridView.Size = New System.Drawing.Size(421, 220)
        Me.PrimeTableDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Position"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Position"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "PrimeNumber"
        Me.DataGridViewTextBoxColumn2.HeaderText = "PrimeNumber"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(184, 22)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(230, 20)
        Me.TextBox1.TabIndex = 2
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(242, 48)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(564, 349)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.PrimeTableDataGridView)
        Me.Name = "Form3"
        Me.Text = "Form3"
        CType(Me.NumberTheoryDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrimeTableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrimeTableDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents NumberTheoryDataSet As WindowsApplication1.NumberTheoryDataSet
    Friend WithEvents PrimeTableBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PrimeTableTableAdapter As WindowsApplication1.NumberTheoryDataSetTableAdapters.primeTableTableAdapter
    Friend WithEvents TableAdapterManager As WindowsApplication1.NumberTheoryDataSetTableAdapters.TableAdapterManager
    Friend WithEvents PrimeTableDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
