Public Class Form1
    Dim p As Integer
    Private Sub TabPage1_Click(sender As Object, e As EventArgs) Handles TabPage1.Click
        p = 0
        p = (BirthUpDown.Value * 30) + 100
    End Sub
    Private Sub TabPage2_Click(sender As Object, e As EventArgs) Handles TabPage2.Click
        p = 0
        p = (WedUpDown.Value * 30) + 200
    End Sub
    Private Sub TabPage3_Click(sender As Object, e As EventArgs) Handles TabPage3.Click
        p = 0
        p = (ParUpDown.Value * 30) + 300
    End Sub
    Private Sub TabPage4_Click(sender As Object, e As EventArgs) Handles TabPage4.Click
        p = 0
        p = (FunUpDown.Value * 30) + 400
        FunPrice.Text = p
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FunPrice.Text = ("C2")
        ParPrice.Text = ("C2")
        WedPrice.Text = ("C2")
        BirthPrice.Text = ("C2")

    End Sub
End Class
