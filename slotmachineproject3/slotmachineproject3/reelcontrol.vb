Imports System.Threading

Public Class ReelControl
    Public Event SpinStop()
    Public Property itemValue As Integer
    Public Property spinTime As Integer = 5

    Dim rand As New Random
    Public Sub Spin()
        Timer1.Enabled = True
        Timer2.Enabled = True
    End Sub
    Private Sub ReelControl_Load(sender As Object, e As EventArgs)
        Timer2.Interval = spinTime
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim r As Integer
        r = rand.Next(ImageList1.Images.Count)
        PictureBox1.Image = ImageList1.Images(r)
        itemValue = r
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Timer1.Enabled = False
        Timer2.Enabled = False
    End Sub

    Friend WithEvents PictureBox1 As PictureBox

    Private Sub InitializeComponent()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(13, 16)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(125, 62)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'ReelControl
        '
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "ReelControl"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
End Class
