<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SinglePrime
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.PrimeNumbersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SinglePrimeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrimeRangeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FibonacciNumbersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NthFibonacciToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FibsUpnToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.singleNum = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PrimeNumbersToolStripMenuItem, Me.FibonacciNumbersToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(318, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'PrimeNumbersToolStripMenuItem
        '
        Me.PrimeNumbersToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SinglePrimeToolStripMenuItem, Me.PrimeRangeToolStripMenuItem})
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
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(76, 104)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(125, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'singleNum
        '
        Me.singleNum.Location = New System.Drawing.Point(32, 66)
        Me.singleNum.Name = "singleNum"
        Me.singleNum.Size = New System.Drawing.Size(254, 20)
        Me.singleNum.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(301, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Please enter a whole number greater than 2 to test its primality:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Label2.Location = New System.Drawing.Point(0, 139)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(24, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "text"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'SinglePrime
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(318, 152)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.singleNum)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "SinglePrime"
        Me.Text = "Single Prime Test"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents PrimeNumbersToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FibonacciNumbersToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents singleNum As System.Windows.Forms.TextBox
    Friend WithEvents SinglePrimeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PrimeRangeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NthFibonacciToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FibsUpnToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label

End Class
