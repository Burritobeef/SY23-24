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
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.spinButton = New System.Windows.Forms.Button()
        Me.Reelcontrol4 = New slotmachineproject3.ReelControl()
        Me.Reelcontrol5 = New slotmachineproject3.ReelControl()
        Me.Reelcontrol6 = New slotmachineproject3.ReelControl()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.R1label = New System.Windows.Forms.Label()
        Me.r2Label = New System.Windows.Forms.Label()
        Me.r3Label = New System.Windows.Forms.Label()
        Me.doButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
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
        'spinButton
        '
        Me.spinButton.Location = New System.Drawing.Point(161, 327)
        Me.spinButton.Name = "spinButton"
        Me.spinButton.Size = New System.Drawing.Size(94, 29)
        Me.spinButton.TabIndex = 0
        Me.spinButton.Text = "Button1"
        Me.spinButton.UseVisualStyleBackColor = True
        '
        'Reelcontrol4
        '
        Me.Reelcontrol4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Reelcontrol4.Location = New System.Drawing.Point(35, 68)
        Me.Reelcontrol4.Name = "Reelcontrol4"
        Me.Reelcontrol4.Size = New System.Drawing.Size(188, 188)
        Me.Reelcontrol4.TabIndex = 1
        '
        'Reelcontrol5
        '
        Me.Reelcontrol5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Reelcontrol5.Location = New System.Drawing.Point(327, 68)
        Me.Reelcontrol5.Name = "Reelcontrol5"
        Me.Reelcontrol5.Size = New System.Drawing.Size(188, 188)
        Me.Reelcontrol5.TabIndex = 2
        '
        'Reelcontrol6
        '
        Me.Reelcontrol6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Reelcontrol6.Location = New System.Drawing.Point(570, 68)
        Me.Reelcontrol6.Name = "Reelcontrol6"
        Me.Reelcontrol6.Size = New System.Drawing.Size(188, 188)
        Me.Reelcontrol6.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(437, 362)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 20)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Label1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(528, 353)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 20)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Label2"
        '
        'R1label
        '
        Me.R1label.AutoSize = True
        Me.R1label.Location = New System.Drawing.Point(128, 270)
        Me.R1label.Name = "R1label"
        Me.R1label.Size = New System.Drawing.Size(53, 20)
        Me.R1label.TabIndex = 6
        Me.R1label.Text = "Label3"
        '
        'r2Label
        '
        Me.r2Label.AutoSize = True
        Me.r2Label.Location = New System.Drawing.Point(407, 292)
        Me.r2Label.Name = "r2Label"
        Me.r2Label.Size = New System.Drawing.Size(53, 20)
        Me.r2Label.TabIndex = 7
        Me.r2Label.Text = "Label4"
        '
        'r3Label
        '
        Me.r3Label.AutoSize = True
        Me.r3Label.Location = New System.Drawing.Point(600, 279)
        Me.r3Label.Name = "r3Label"
        Me.r3Label.Size = New System.Drawing.Size(53, 20)
        Me.r3Label.TabIndex = 8
        Me.r3Label.Text = "Label5"
        '
        'doButton
        '
        Me.doButton.Location = New System.Drawing.Point(160, 370)
        Me.doButton.Name = "doButton"
        Me.doButton.Size = New System.Drawing.Size(94, 29)
        Me.doButton.TabIndex = 9
        Me.doButton.Text = "Button1"
        Me.doButton.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.doButton)
        Me.Controls.Add(Me.r3Label)
        Me.Controls.Add(Me.r2Label)
        Me.Controls.Add(Me.R1label)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Reelcontrol6)
        Me.Controls.Add(Me.Reelcontrol5)
        Me.Controls.Add(Me.Reelcontrol4)
        Me.Controls.Add(Me.spinButton)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Timer2 As Timer
    Friend WithEvents spinButton As Button
    Friend WithEvents Reelcontrol1 As reelcontrol
    Friend WithEvents Reelcontrol2 As reelcontrol
    Friend WithEvents Reelcontrol3 As ReelControl
    Friend WithEvents Reelcontrol4 As ReelControl
    Friend WithEvents Reelcontrol5 As ReelControl
    Friend WithEvents Reelcontrol6 As ReelControl
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents R1label As Label
    Friend WithEvents r2Label As Label
    Friend WithEvents r3Label As Label
    Friend WithEvents doButton As Button
End Class
