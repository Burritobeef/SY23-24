<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.button1 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Reelcontrol1 = New slotmachine.ReelControl()
        Me.Reelcontrol2 = New slotmachine.ReelControl()
        Me.Reelcontrol3 = New slotmachine.ReelControl()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'button1
        '
        Me.button1.Location = New System.Drawing.Point(99, 45)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(94, 29)
        Me.button1.TabIndex = 0
        Me.button1.Text = "spin"
        Me.button1.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(330, 326)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(125, 27)
        Me.TextBox1.TabIndex = 1
        '
        'Reelcontrol1
        '
        Me.Reelcontrol1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Reelcontrol1.Location = New System.Drawing.Point(116, 102)
        Me.Reelcontrol1.Name = "Reelcontrol1"
        Me.Reelcontrol1.Size = New System.Drawing.Size(188, 188)
        Me.Reelcontrol1.TabIndex = 2
        '
        'Reelcontrol2
        '
        Me.Reelcontrol2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Reelcontrol2.Location = New System.Drawing.Point(330, 102)
        Me.Reelcontrol2.Name = "Reelcontrol2"
        Me.Reelcontrol2.Size = New System.Drawing.Size(188, 188)
        Me.Reelcontrol2.TabIndex = 3
        '
        'Reelcontrol3
        '
        Me.Reelcontrol3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Reelcontrol3.Location = New System.Drawing.Point(561, 102)
        Me.Reelcontrol3.Name = "Reelcontrol3"
        Me.Reelcontrol3.Size = New System.Drawing.Size(188, 188)
        Me.Reelcontrol3.TabIndex = 4
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(350, 359)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(94, 29)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "add dolla"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'ImageList1
        '
        Me.ImageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "images (33).jpg")
        Me.ImageList1.Images.SetKeyName(1, "images (13).jpg")
        Me.ImageList1.Images.SetKeyName(2, "images (12).jpg")
        '
        'Timer1
        '
        Me.Timer1.Interval = 250
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Reelcontrol3)
        Me.Controls.Add(Me.Reelcontrol2)
        Me.Controls.Add(Me.Reelcontrol1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.button1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents button1 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Reelcontrol1 As reelcontrol
    Friend WithEvents Reelcontrol2 As reelcontrol
    Friend WithEvents Reelcontrol3 As reelcontrol
    Friend WithEvents Button2 As Button
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents Timer1 As Timer
End Class
