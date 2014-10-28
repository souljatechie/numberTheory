<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.PrimeNumbersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SinglePrimeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrimeRangeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FibonacciNumbersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NthFibonacciToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FibsUpnToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.DatabaseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PrimeNumbersToolStripMenuItem, Me.FibonacciNumbersToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(414, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'PrimeNumbersToolStripMenuItem
        '
        Me.PrimeNumbersToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SinglePrimeToolStripMenuItem, Me.PrimeRangeToolStripMenuItem, Me.DatabaseToolStripMenuItem})
        Me.PrimeNumbersToolStripMenuItem.Name = "PrimeNumbersToolStripMenuItem"
        Me.PrimeNumbersToolStripMenuItem.Size = New System.Drawing.Size(102, 20)
        Me.PrimeNumbersToolStripMenuItem.Text = "Prime Numbers"
        '
        'SinglePrimeToolStripMenuItem
        '
        Me.SinglePrimeToolStripMenuItem.Name = "SinglePrimeToolStripMenuItem"
        Me.SinglePrimeToolStripMenuItem.Size = New System.Drawing.Size(141, 22)
        Me.SinglePrimeToolStripMenuItem.Text = "Single Prime"
        '
        'PrimeRangeToolStripMenuItem
        '
        Me.PrimeRangeToolStripMenuItem.Name = "PrimeRangeToolStripMenuItem"
        Me.PrimeRangeToolStripMenuItem.Size = New System.Drawing.Size(141, 22)
        Me.PrimeRangeToolStripMenuItem.Text = "Prime Range"
        '
        'FibonacciNumbersToolStripMenuItem
        '
        Me.FibonacciNumbersToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NthFibonacciToolStripMenuItem, Me.FibsUpnToolStripMenuItem})
        Me.FibonacciNumbersToolStripMenuItem.Name = "FibonacciNumbersToolStripMenuItem"
        Me.FibonacciNumbersToolStripMenuItem.Size = New System.Drawing.Size(122, 20)
        Me.FibonacciNumbersToolStripMenuItem.Text = "Fibonacci Numbers"
        '
        'NthFibonacciToolStripMenuItem
        '
        Me.NthFibonacciToolStripMenuItem.Name = "NthFibonacciToolStripMenuItem"
        Me.NthFibonacciToolStripMenuItem.Size = New System.Drawing.Size(154, 22)
        Me.NthFibonacciToolStripMenuItem.Text = "(n)th Fibonacci"
        '
        'FibsUpnToolStripMenuItem
        '
        Me.FibsUpnToolStripMenuItem.Name = "FibsUpnToolStripMenuItem"
        Me.FibsUpnToolStripMenuItem.Size = New System.Drawing.Size(154, 22)
        Me.FibsUpnToolStripMenuItem.Text = "Fibs up (n)"
        '
        'Label1
        '
        Me.Label1.AllowDrop = True
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 41)
        Me.Label1.MaximumSize = New System.Drawing.Size(400, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(397, 52)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = resources.GetString("Label1.Text")
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(15, 115)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(177, 41)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Populate Prime Database"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(218, 115)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(184, 41)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "Populate Fibinnaci Database"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'DatabaseToolStripMenuItem
        '
        Me.DatabaseToolStripMenuItem.Name = "DatabaseToolStripMenuItem"
        Me.DatabaseToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.DatabaseToolStripMenuItem.Text = "Database"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(414, 176)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Number Theory Tester (sort of)"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents PrimeNumbersToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FibonacciNumbersToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SinglePrimeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PrimeRangeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NthFibonacciToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FibsUpnToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents DatabaseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
