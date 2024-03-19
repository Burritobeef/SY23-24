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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Reelcontrol1 = New WinFormsApp1.reelcontrol()
        Me.Reelcontrol2 = New WinFormsApp1.reelcontrol()
        Me.Reelcontrol3 = New WinFormsApp1.reelcontrol()
        Me.Reelcontrol4 = New WinFormsApp1.reelcontrol()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(367, 313)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(94, 29)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ImageList1
        '
        Me.ImageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "images (12).jpg")
        Me.ImageList1.Images.SetKeyName(1, "images (33).jpg")
        Me.ImageList1.Images.SetKeyName(2, "images (13).jpg")
        '
        'Timer1
        '
        Me.Timer1.Interval = 250
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(591, 290)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(125, 62)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'Reelcontrol1
        '
        Me.Reelcontrol1.Location = New System.Drawing.Point(85, 38)
        Me.Reelcontrol1.Name = "Reelcontrol1"
        Me.Reelcontrol1.Size = New System.Drawing.Size(188, 188)
        Me.Reelcontrol1.TabIndex = 3
        '
        'Reelcontrol2
        '
        Me.Reelcontrol2.Location = New System.Drawing.Point(85, 38)
        Me.Reelcontrol2.Name = "Reelcontrol2"
        Me.Reelcontrol2.Size = New System.Drawing.Size(188, 188)
        Me.Reelcontrol2.TabIndex = 4
        '
        'Reelcontrol3
        '
        Me.Reelcontrol3.Location = New System.Drawing.Point(328, 38)
        Me.Reelcontrol3.Name = "Reelcontrol3"
        Me.Reelcontrol3.Size = New System.Drawing.Size(188, 188)
        Me.Reelcontrol3.TabIndex = 5
        '
        'Reelcontrol4
        '
        Me.Reelcontrol4.Location = New System.Drawing.Point(572, 47)
        Me.Reelcontrol4.Name = "Reelcontrol4"
        Me.Reelcontrol4.Size = New System.Drawing.Size(188, 188)
        Me.Reelcontrol4.TabIndex = 6
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Reelcontrol4)
        Me.Controls.Add(Me.Reelcontrol3)
        Me.Controls.Add(Me.Reelcontrol2)
        Me.Controls.Add(Me.Reelcontrol1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Button1 As Button
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents Timer1 As Timer
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Reelcontrol1 As reelcontrol
    Friend WithEvents Reelcontrol2 As reelcontrol
    Friend WithEvents Reelcontrol3 As reelcontrol
    Friend WithEvents Reelcontrol4 As reelcontrol
End Class
