<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Calculator
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Calculator))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Button0 = New System.Windows.Forms.Button()
        Me.ButtonAdd = New System.Windows.Forms.Button()
        Me.ButtonSubtract = New System.Windows.Forms.Button()
        Me.ButtonMultiply = New System.Windows.Forms.Button()
        Me.ButtonDivide = New System.Windows.Forms.Button()
        Me.ResultBox = New System.Windows.Forms.TextBox()
        Me.ButtonEqual = New System.Windows.Forms.Button()
        Me.CalculatorTimer = New System.Windows.Forms.Timer(Me.components)
        Me.ButtonClear = New System.Windows.Forms.Button()
        Me.CalculatorTimer2 = New System.Windows.Forms.Timer(Me.components)
        Me.CalculatorTimer3 = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Button1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(12, 99)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Button2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(93, 99)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Gainsboro
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Button3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(174, 99)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "3"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Button4.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(12, 128)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 3
        Me.Button4.Text = "4"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Button5.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Location = New System.Drawing.Point(93, 128)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(75, 23)
        Me.Button5.TabIndex = 4
        Me.Button5.Text = "5"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Button6.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.Location = New System.Drawing.Point(174, 128)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(75, 23)
        Me.Button6.TabIndex = 5
        Me.Button6.Text = "6"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Button7.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button7.Location = New System.Drawing.Point(12, 157)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(75, 23)
        Me.Button7.TabIndex = 6
        Me.Button7.Text = "7"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Button8.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button8.Location = New System.Drawing.Point(93, 157)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(75, 23)
        Me.Button8.TabIndex = 7
        Me.Button8.Text = "8"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Button9
        '
        Me.Button9.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Button9.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button9.Location = New System.Drawing.Point(174, 157)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(75, 23)
        Me.Button9.TabIndex = 8
        Me.Button9.Text = "9"
        Me.Button9.UseVisualStyleBackColor = True
        '
        'Button0
        '
        Me.Button0.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Button0.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button0.Location = New System.Drawing.Point(12, 186)
        Me.Button0.Name = "Button0"
        Me.Button0.Size = New System.Drawing.Size(237, 23)
        Me.Button0.TabIndex = 9
        Me.Button0.Text = "0"
        Me.Button0.UseVisualStyleBackColor = True
        '
        'ButtonAdd
        '
        Me.ButtonAdd.BackColor = System.Drawing.Color.Gainsboro
        Me.ButtonAdd.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.ButtonAdd.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonAdd.Location = New System.Drawing.Point(255, 99)
        Me.ButtonAdd.Name = "ButtonAdd"
        Me.ButtonAdd.Size = New System.Drawing.Size(75, 18)
        Me.ButtonAdd.TabIndex = 11
        Me.ButtonAdd.Text = "+"
        Me.ButtonAdd.UseVisualStyleBackColor = False
        '
        'ButtonSubtract
        '
        Me.ButtonSubtract.BackColor = System.Drawing.Color.Gainsboro
        Me.ButtonSubtract.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.ButtonSubtract.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonSubtract.Location = New System.Drawing.Point(255, 123)
        Me.ButtonSubtract.Name = "ButtonSubtract"
        Me.ButtonSubtract.Size = New System.Drawing.Size(75, 23)
        Me.ButtonSubtract.TabIndex = 12
        Me.ButtonSubtract.Text = "-"
        Me.ButtonSubtract.UseVisualStyleBackColor = False
        '
        'ButtonMultiply
        '
        Me.ButtonMultiply.BackColor = System.Drawing.Color.Gainsboro
        Me.ButtonMultiply.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.ButtonMultiply.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonMultiply.Location = New System.Drawing.Point(255, 152)
        Me.ButtonMultiply.Name = "ButtonMultiply"
        Me.ButtonMultiply.Size = New System.Drawing.Size(75, 18)
        Me.ButtonMultiply.TabIndex = 13
        Me.ButtonMultiply.Text = "X"
        Me.ButtonMultiply.UseVisualStyleBackColor = False
        '
        'ButtonDivide
        '
        Me.ButtonDivide.BackColor = System.Drawing.Color.Gainsboro
        Me.ButtonDivide.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.ButtonDivide.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonDivide.Location = New System.Drawing.Point(255, 176)
        Me.ButtonDivide.Name = "ButtonDivide"
        Me.ButtonDivide.Size = New System.Drawing.Size(75, 16)
        Me.ButtonDivide.TabIndex = 14
        Me.ButtonDivide.Text = "÷"
        Me.ButtonDivide.UseVisualStyleBackColor = False
        '
        'ResultBox
        '
        Me.ResultBox.BackColor = System.Drawing.Color.Gainsboro
        Me.ResultBox.Font = New System.Drawing.Font("Lucida Console", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ResultBox.Location = New System.Drawing.Point(12, 39)
        Me.ResultBox.Name = "ResultBox"
        Me.ResultBox.Size = New System.Drawing.Size(323, 18)
        Me.ResultBox.TabIndex = 15
        Me.ResultBox.Text = "0"
        Me.ResultBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'ButtonEqual
        '
        Me.ButtonEqual.BackColor = System.Drawing.Color.Gainsboro
        Me.ButtonEqual.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.ButtonEqual.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonEqual.Location = New System.Drawing.Point(255, 195)
        Me.ButtonEqual.Name = "ButtonEqual"
        Me.ButtonEqual.Size = New System.Drawing.Size(75, 14)
        Me.ButtonEqual.TabIndex = 16
        Me.ButtonEqual.Text = "="
        Me.ButtonEqual.UseVisualStyleBackColor = False
        '
        'CalculatorTimer
        '
        Me.CalculatorTimer.Enabled = True
        '
        'ButtonClear
        '
        Me.ButtonClear.BackColor = System.Drawing.Color.Gainsboro
        Me.ButtonClear.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.ButtonClear.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonClear.Location = New System.Drawing.Point(255, 76)
        Me.ButtonClear.Name = "ButtonClear"
        Me.ButtonClear.Size = New System.Drawing.Size(75, 17)
        Me.ButtonClear.TabIndex = 17
        Me.ButtonClear.Text = "C"
        Me.ButtonClear.UseVisualStyleBackColor = False
        '
        'CalculatorTimer2
        '
        '
        'CalculatorTimer3
        '
        Me.CalculatorTimer3.Interval = 500
        '
        'Calculator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.ClientSize = New System.Drawing.Size(347, 218)
        Me.Controls.Add(Me.ButtonClear)
        Me.Controls.Add(Me.ButtonEqual)
        Me.Controls.Add(Me.ResultBox)
        Me.Controls.Add(Me.ButtonDivide)
        Me.Controls.Add(Me.ButtonMultiply)
        Me.Controls.Add(Me.ButtonSubtract)
        Me.Controls.Add(Me.ButtonAdd)
        Me.Controls.Add(Me.Button0)
        Me.Controls.Add(Me.Button9)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Calculator"
        Me.Text = "Calculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents Button9 As Button
    Friend WithEvents Button0 As Button
    Friend WithEvents ButtonAdd As Button
    Friend WithEvents ButtonSubtract As Button
    Friend WithEvents ButtonMultiply As Button
    Friend WithEvents ButtonDivide As Button
    Friend WithEvents ResultBox As TextBox
    Friend WithEvents ButtonEqual As Button
    Friend WithEvents CalculatorTimer As Timer
    Friend WithEvents ButtonClear As Button
    Friend WithEvents CalculatorTimer2 As Timer
    Friend WithEvents CalculatorTimer3 As Timer
End Class
