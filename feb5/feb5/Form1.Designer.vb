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
        Me.ClickerControl3 = New feb5.ClickerControl()
        Me.ClickerControl2 = New feb5.ClickerControl()
        Me.ClickerControl1 = New feb5.ClickerControl()
        Me.SuspendLayout()
        '
        'ClickerControl3
        '
        Me.ClickerControl3.BackColor = System.Drawing.SystemColors.ControlText
        Me.ClickerControl3.increment = 0
        Me.ClickerControl3.Location = New System.Drawing.Point(258, 25)
        Me.ClickerControl3.Name = "ClickerControl3"
        Me.ClickerControl3.Size = New System.Drawing.Size(213, 146)
        Me.ClickerControl3.TabIndex = 2
        '
        'ClickerControl2
        '
        Me.ClickerControl2.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.ClickerControl2.increment = 10
        Me.ClickerControl2.Location = New System.Drawing.Point(70, 228)
        Me.ClickerControl2.Name = "ClickerControl2"
        Me.ClickerControl2.Size = New System.Drawing.Size(210, 146)
        Me.ClickerControl2.TabIndex = 1
        '
        'ClickerControl1
        '
        Me.ClickerControl1.BackColor = System.Drawing.SystemColors.GrayText
        Me.ClickerControl1.increment = 0
        Me.ClickerControl1.Location = New System.Drawing.Point(12, 12)
        Me.ClickerControl1.Name = "ClickerControl1"
        Me.ClickerControl1.Size = New System.Drawing.Size(207, 149)
        Me.ClickerControl1.TabIndex = 0
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ClickerControl3)
        Me.Controls.Add(Me.ClickerControl2)
        Me.Controls.Add(Me.ClickerControl1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ClickerControl1 As ClickerControl
    Friend WithEvents ClickerControl2 As ClickerControl
    Friend WithEvents ClickerControl3 As ClickerControl
End Class
