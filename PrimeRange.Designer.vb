<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PrimeRange
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
        Me.buttonGo = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.startNum = New System.Windows.Forms.TextBox()
        Me.endNum = New System.Windows.Forms.TextBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.PrimesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SinglePrimeTestToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrimeRangeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FibonacciNumbersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.primeBox = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'buttonGo
        '
        Me.buttonGo.Location = New System.Drawing.Point(133, 108)
        Me.buttonGo.Name = "buttonGo"
        Me.buttonGo.Size = New System.Drawing.Size(153, 23)
        Me.buttonGo.TabIndex = 0
        Me.buttonGo.Text = "Go!"
        Me.buttonGo.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(307, 70)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(23, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "To:"
        '
        'startNum
        '
        Me.startNum.Location = New System.Drawing.Point(143, 67)
        Me.startNum.Name = "startNum"
        Me.startNum.Size = New System.Drawing.Size(158, 20)
        Me.startNum.TabIndex = 2
        '
        'endNum
        '
        Me.endNum.Location = New System.Drawing.Point(336, 67)
        Me.endNum.Name = "endNum"
        Me.endNum.Size = New System.Drawing.Size(191, 20)
        Me.endNum.TabIndex = 3
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PrimesToolStripMenuItem, Me.FibonacciNumbersToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(627, 24)
        Me.MenuStrip1.TabIndex = 4
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'PrimesToolStripMenuItem
        '
        Me.PrimesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SinglePrimeTestToolStripMenuItem, Me.PrimeRangeToolStripMenuItem})
        Me.PrimesToolStripMenuItem.Name = "PrimesToolStripMenuItem"
        Me.PrimesToolStripMenuItem.Size = New System.Drawing.Size(102, 20)
        Me.PrimesToolStripMenuItem.Text = "Prime Numbers"
        '
        'SinglePrimeTestToolStripMenuItem
        '
        Me.SinglePrimeTestToolStripMenuItem.Name = "SinglePrimeTestToolStripMenuItem"
        Me.SinglePrimeTestToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
        Me.SinglePrimeTestToolStripMenuItem.Text = "Single Prime Test"
        '
        'PrimeRangeToolStripMenuItem
        '
        Me.PrimeRangeToolStripMenuItem.Name = "PrimeRangeToolStripMenuItem"
        Me.PrimeRangeToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
        Me.PrimeRangeToolStripMenuItem.Text = "Prime Range"
        '
        'FibonacciNumbersToolStripMenuItem
        '
        Me.FibonacciNumbersToolStripMenuItem.Name = "FibonacciNumbersToolStripMenuItem"
        Me.FibonacciNumbersToolStripMenuItem.Size = New System.Drawing.Size(122, 20)
        Me.FibonacciNumbersToolStripMenuItem.Text = "Fibonacci Numbers"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(104, 70)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(33, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "From:"
        '
        'primeBox
        '
        Me.primeBox.Location = New System.Drawing.Point(12, 137)
        Me.primeBox.Multiline = True
        Me.primeBox.Name = "primeBox"
        Me.primeBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.primeBox.Size = New System.Drawing.Size(602, 200)
        Me.primeBox.TabIndex = 6
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(336, 108)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(153, 23)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Stop!"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(12, 38)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(602, 23)
        Me.ProgressBar1.TabIndex = 9
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Label3.Location = New System.Drawing.Point(0, 351)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(24, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "text"
        Me.Label3.Visible = False
        '
        'PrimeRange
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(627, 364)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.primeBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.endNum)
        Me.Controls.Add(Me.startNum)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.buttonGo)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "PrimeRange"
        Me.Text = "Prime Range Test"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents buttonGo As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents startNum As System.Windows.Forms.TextBox
    Friend WithEvents endNum As System.Windows.Forms.TextBox
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents PrimesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SinglePrimeTestToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PrimeRangeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FibonacciNumbersToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents primeBox As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
