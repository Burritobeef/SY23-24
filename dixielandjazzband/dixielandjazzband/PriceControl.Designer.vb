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
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.PriceTextBox = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'AddOneButton
        '
        Me.AddOneButton.Location = New System.Drawing.Point(3, 3)
        Me.AddOneButton.Name = "AddOneButton"
        Me.AddOneButton.Size = New System.Drawing.Size(125, 29)
        Me.AddOneButton.TabIndex = 0
        Me.AddOneButton.Text = "Add 1 Hour"
        Me.AddOneButton.UseVisualStyleBackColor = True
        '
        'TakeOneButton
        '
        Me.TakeOneButton.Location = New System.Drawing.Point(3, 38)
        Me.TakeOneButton.Name = "TakeOneButton"
        Me.TakeOneButton.Size = New System.Drawing.Size(125, 29)
        Me.TakeOneButton.TabIndex = 1
        Me.TakeOneButton.Text = "Remove 1 Hour"
        Me.TakeOneButton.UseVisualStyleBackColor = True
        '
        'ClearButton
        '
        Me.ClearButton.Location = New System.Drawing.Point(3, 106)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(125, 29)
        Me.ClearButton.TabIndex = 2
        Me.ClearButton.Text = "Clear"
        Me.ClearButton.UseVisualStyleBackColor = True
        '
        'PriceTextBox
        '
        Me.PriceTextBox.Location = New System.Drawing.Point(3, 73)
        Me.PriceTextBox.Name = "PriceTextBox"
        Me.PriceTextBox.ReadOnly = True
        Me.PriceTextBox.Size = New System.Drawing.Size(125, 27)
        Me.PriceTextBox.TabIndex = 3
        '
        'PriceControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PowderBlue
        Me.Controls.Add(Me.PriceTextBox)
        Me.Controls.Add(Me.ClearButton)
        Me.Controls.Add(Me.TakeOneButton)
        Me.Controls.Add(Me.AddOneButton)
        Me.Name = "PriceControl"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents AddOneButton As Button
    Friend WithEvents TakeOneButton As Button
    Friend WithEvents ClearButton As Button
    Friend WithEvents PriceTextBox As TextBox
End Class
