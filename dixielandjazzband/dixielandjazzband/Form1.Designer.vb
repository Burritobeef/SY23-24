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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Title = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PriceControl1 = New dixielandjazzband.PriceControl()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 22.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(16, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 50)
        Me.Label1.TabIndex = 1
        '
        'Title
        '
        Me.Title.AutoSize = True
        Me.Title.Font = New System.Drawing.Font("Snap ITC", 25.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point)
        Me.Title.Location = New System.Drawing.Point(181, 22)
        Me.Title.Name = "Title"
        Me.Title.Size = New System.Drawing.Size(387, 55)
        Me.Title.TabIndex = 2
        Me.Title.Text = "Dixieland Jazz"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.PowderBlue
        Me.PictureBox1.Location = New System.Drawing.Point(29, 106)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(729, 332)
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'PriceControl1
        '
        Me.PriceControl1.BackColor = System.Drawing.Color.PowderBlue
        Me.PriceControl1.Increment = New Decimal(New Integer() {0, 0, 0, 0})
        Me.PriceControl1.Location = New System.Drawing.Point(245, 182)
        Me.PriceControl1.Name = "PriceControl1"
        Me.PriceControl1.Size = New System.Drawing.Size(218, 245)
        Me.PriceControl1.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.PowderBlue
        Me.Label2.Font = New System.Drawing.Font("Snap ITC", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(63, 301)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(176, 27)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Hours Rented:"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(248, 172)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(125, 27)
        Me.TextBox1.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.PowderBlue
        Me.Label3.Font = New System.Drawing.Font("Snap ITC", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(50, 172)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(189, 27)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Type Of Event:"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SlateGray
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PriceControl1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Title)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents Title As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PriceControl1 As PriceControl
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label3 As Label
End Class
