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
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.WedUpDown = New System.Windows.Forms.NumericUpDown()
        Me.WedPrice = New System.Windows.Forms.Label()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.ParUpDown = New System.Windows.Forms.NumericUpDown()
        Me.ParPrice = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.FunUpDown = New System.Windows.Forms.NumericUpDown()
        Me.FunPrice = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Title = New System.Windows.Forms.Label()
        Me.PriceControl1 = New dixielandjazzband.PriceControl()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.WedUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        CType(Me.ParUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage4.SuspendLayout()
        CType(Me.FunUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Font = New System.Drawing.Font("Showcard Gothic", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point)
        Me.TabControl1.Location = New System.Drawing.Point(12, 72)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(776, 379)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.AccessibleName = "Birthday"
        Me.TabPage1.BackColor = System.Drawing.Color.PowderBlue
        Me.TabPage1.Controls.Add(Me.PriceControl1)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Font = New System.Drawing.Font("Showcard Gothic", 10.2!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point)
        Me.TabPage1.Location = New System.Drawing.Point(4, 27)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(768, 348)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Birthday"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(18, 144)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(135, 21)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Hours Rented"
        '
        'TabPage2
        '
        Me.TabPage2.AccessibleName = "Wedding"
        Me.TabPage2.BackColor = System.Drawing.Color.PowderBlue
        Me.TabPage2.Controls.Add(Me.Label4)
        Me.TabPage2.Controls.Add(Me.WedUpDown)
        Me.TabPage2.Controls.Add(Me.WedPrice)
        Me.TabPage2.Location = New System.Drawing.Point(4, 27)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(768, 348)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Wedding"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(46, 144)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(121, 18)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Hours Rented"
        '
        'WedUpDown
        '
        Me.WedUpDown.Location = New System.Drawing.Point(187, 142)
        Me.WedUpDown.Name = "WedUpDown"
        Me.WedUpDown.Size = New System.Drawing.Size(150, 26)
        Me.WedUpDown.TabIndex = 1
        '
        'WedPrice
        '
        Me.WedPrice.AutoSize = True
        Me.WedPrice.Location = New System.Drawing.Point(371, 144)
        Me.WedPrice.Name = "WedPrice"
        Me.WedPrice.Size = New System.Drawing.Size(59, 18)
        Me.WedPrice.TabIndex = 0
        Me.WedPrice.Text = "Label3"
        '
        'TabPage3
        '
        Me.TabPage3.AccessibleName = "Party"
        Me.TabPage3.BackColor = System.Drawing.Color.PowderBlue
        Me.TabPage3.Controls.Add(Me.ParUpDown)
        Me.TabPage3.Controls.Add(Me.ParPrice)
        Me.TabPage3.Controls.Add(Me.Label3)
        Me.TabPage3.Location = New System.Drawing.Point(4, 27)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(768, 348)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Party"
        '
        'ParUpDown
        '
        Me.ParUpDown.Location = New System.Drawing.Point(178, 128)
        Me.ParUpDown.Name = "ParUpDown"
        Me.ParUpDown.Size = New System.Drawing.Size(150, 26)
        Me.ParUpDown.TabIndex = 2
        '
        'ParPrice
        '
        Me.ParPrice.AutoSize = True
        Me.ParPrice.Location = New System.Drawing.Point(343, 130)
        Me.ParPrice.Name = "ParPrice"
        Me.ParPrice.Size = New System.Drawing.Size(60, 18)
        Me.ParPrice.TabIndex = 1
        Me.ParPrice.Text = "Label5"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(38, 128)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(121, 18)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Hours Rented"
        '
        'TabPage4
        '
        Me.TabPage4.AccessibleName = "Funeral"
        Me.TabPage4.BackColor = System.Drawing.Color.PowderBlue
        Me.TabPage4.Controls.Add(Me.FunUpDown)
        Me.TabPage4.Controls.Add(Me.FunPrice)
        Me.TabPage4.Controls.Add(Me.Label6)
        Me.TabPage4.Location = New System.Drawing.Point(4, 27)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Size = New System.Drawing.Size(768, 348)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Funeral"
        '
        'FunUpDown
        '
        Me.FunUpDown.Location = New System.Drawing.Point(189, 127)
        Me.FunUpDown.Name = "FunUpDown"
        Me.FunUpDown.Size = New System.Drawing.Size(150, 26)
        Me.FunUpDown.TabIndex = 2
        '
        'FunPrice
        '
        Me.FunPrice.AutoSize = True
        Me.FunPrice.Location = New System.Drawing.Point(363, 129)
        Me.FunPrice.Name = "FunPrice"
        Me.FunPrice.Size = New System.Drawing.Size(60, 18)
        Me.FunPrice.TabIndex = 1
        Me.FunPrice.Text = "Label7"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(66, 129)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(60, 18)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Label6"
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
        Me.Title.Location = New System.Drawing.Point(22, 9)
        Me.Title.Name = "Title"
        Me.Title.Size = New System.Drawing.Size(387, 55)
        Me.Title.TabIndex = 2
        Me.Title.Text = "Dixieland Jazz"
        '
        'PriceControl1
        '
        Me.PriceControl1.BackColor = System.Drawing.Color.PowderBlue
        Me.PriceControl1.Location = New System.Drawing.Point(160, 58)
        Me.PriceControl1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.PriceControl1.Name = "PriceControl1"
        'Me.PriceControl1.PriceControl = 1
        Me.PriceControl1.Size = New System.Drawing.Size(188, 188)
        Me.PriceControl1.TabIndex = 3
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SlateGray
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Title)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.WedUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        CType(Me.ParUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage4.PerformLayout()
        CType(Me.FunUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents Label2 As Label
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents Label1 As Label
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents Title As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents WedUpDown As NumericUpDown
    Friend WithEvents WedPrice As Label
    Friend WithEvents ParUpDown As NumericUpDown
    Friend WithEvents ParPrice As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents FunUpDown As NumericUpDown
    Friend WithEvents FunPrice As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents PriceControl1 As PriceControl
End Class
