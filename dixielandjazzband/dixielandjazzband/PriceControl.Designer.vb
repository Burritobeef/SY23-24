<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PriceControl
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.AddOneButton = New System.Windows.Forms.Button()
        Me.TakeOneButton = New System.Windows.Forms.Button()
        Me.HourTextBox = New System.Windows.Forms.TextBox()
        Me.TotalLabel = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'AddOneButton
        '
        Me.AddOneButton.Font = New System.Drawing.Font("Snap ITC", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.AddOneButton.Location = New System.Drawing.Point(3, 28)
        Me.AddOneButton.Name = "AddOneButton"
        Me.AddOneButton.Size = New System.Drawing.Size(125, 40)
        Me.AddOneButton.TabIndex = 0
        Me.AddOneButton.Text = "Add 1 Hour"
        Me.AddOneButton.UseVisualStyleBackColor = True
        '
        'TakeOneButton
        '
        Me.TakeOneButton.Font = New System.Drawing.Font("Snap ITC", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TakeOneButton.Location = New System.Drawing.Point(3, 74)
        Me.TakeOneButton.Name = "TakeOneButton"
        Me.TakeOneButton.Size = New System.Drawing.Size(125, 35)
        Me.TakeOneButton.TabIndex = 1
        Me.TakeOneButton.Text = "Remove 1 Hour"
        Me.TakeOneButton.UseVisualStyleBackColor = True
        '
        'HourTextBox
        '
        Me.HourTextBox.Font = New System.Drawing.Font("Snap ITC", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.HourTextBox.Location = New System.Drawing.Point(3, 115)
        Me.HourTextBox.Name = "HourTextBox"
        Me.HourTextBox.ReadOnly = True
        Me.HourTextBox.Size = New System.Drawing.Size(125, 33)
        Me.HourTextBox.TabIndex = 3
        '
        'TotalLabel
        '
        Me.TotalLabel.AutoSize = True
        Me.TotalLabel.Font = New System.Drawing.Font("Snap ITC", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TotalLabel.Location = New System.Drawing.Point(223, 168)
        Me.TotalLabel.Name = "TotalLabel"
        Me.TotalLabel.Size = New System.Drawing.Size(87, 27)
        Me.TotalLabel.TabIndex = 4
        Me.TotalLabel.Text = "$0.00"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Snap ITC", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(3, 168)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(205, 27)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Estimated Total:"
        '
        'PriceControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PowderBlue
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TotalLabel)
        Me.Controls.Add(Me.HourTextBox)
        Me.Controls.Add(Me.TakeOneButton)
        Me.Controls.Add(Me.AddOneButton)
        Me.Name = "PriceControl"
        Me.Size = New System.Drawing.Size(623, 237)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents AddOneButton As Button
    Friend WithEvents TakeOneButton As Button
    Friend WithEvents HourTextBox As TextBox
    Friend WithEvents TotalLabel As Label
    Friend WithEvents Label1 As Label
End Class
