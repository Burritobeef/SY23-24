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
        Me.Picplayer = New System.Windows.Forms.PictureBox()
        Me.Picair = New System.Windows.Forms.PictureBox()
        Me.picground = New System.Windows.Forms.PictureBox()
        Me.tmrGravity = New System.Windows.Forms.Timer(Me.components)
        Me.tmrRight = New System.Windows.Forms.Timer(Me.components)
        Me.tmrLeft = New System.Windows.Forms.Timer(Me.components)
        Me.tmrUp = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tmrGameLogic = New System.Windows.Forms.Timer(Me.components)
        Me.Mover1 = New platformergame.mover()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.Picplayer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Picair, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picground, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Picplayer
        '
        Me.Picplayer.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.Picplayer.Image = Global.platformergame.My.Resources.Resources.download__16_
        Me.Picplayer.Location = New System.Drawing.Point(7012, 0)
        Me.Picplayer.Name = "Picplayer"
        Me.Picplayer.Size = New System.Drawing.Size(63, 62)
        Me.Picplayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Picplayer.TabIndex = 0
        Me.Picplayer.TabStop = False
        '
        'Picair
        '
        Me.Picair.Location = New System.Drawing.Point(12, 12)
        Me.Picair.Name = "Picair"
        Me.Picair.Size = New System.Drawing.Size(776, 295)
        Me.Picair.TabIndex = 1
        Me.Picair.TabStop = False
        '
        'picground
        '
        Me.picground.Image = Global.platformergame.My.Resources.Resources.images__12_
        Me.picground.Location = New System.Drawing.Point(1, 376)
        Me.picground.Name = "picground"
        Me.picground.Size = New System.Drawing.Size(776, 62)
        Me.picground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picground.TabIndex = 2
        Me.picground.TabStop = False
        Me.picground.Tag = "platform"
        '
        'tmrGravity
        '
        '
        'tmrRight
        '
        '
        'tmrLeft
        '
        '
        'tmrUp
        '
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(191, 98)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 20)
        Me.Label1.TabIndex = 4
        '
        'tmrGameLogic
        '
        '
        'Mover1
        '
        Me.Mover1.BackColor = System.Drawing.Color.Transparent
        Me.Mover1.interval = 100
        Me.Mover1.Location = New System.Drawing.Point(118, 139)
        Me.Mover1.Name = "Mover1"
        Me.Mover1.Size = New System.Drawing.Size(575, 52)
        Me.Mover1.speed = 10
        Me.Mover1.sprite = Me.PictureBox1
        Me.Mover1.TabIndex = 5
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.PictureBox1.Location = New System.Drawing.Point(1941, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(125, 62)
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Mover1)
        Me.Controls.Add(Me.Picplayer)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.picground)
        Me.Controls.Add(Me.Picair)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.Picplayer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Picair, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picground, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Picplayer As PictureBox
    Friend WithEvents Picair As PictureBox
    Friend WithEvents picground As PictureBox
    Friend WithEvents tmrGravity As Timer
    Friend WithEvents tmrRight As Timer
    Friend WithEvents tmrLeft As Timer
    Friend WithEvents tmrUp As Timer
    Friend WithEvents Label1 As Label
    Friend WithEvents tmrGameLogic As Timer
    Friend WithEvents Mover1 As mover
    Friend WithEvents PictureBox1 As PictureBox
End Class
