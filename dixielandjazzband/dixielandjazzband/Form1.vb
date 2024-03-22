Public Class Form1
    Dim p As Integer
    Private Sub TabPage1_Click(sender As Object, e As EventArgs) Handles TabPage1.Click
        p = (BirthUpDown.Value * 30) + 100
    End Sub
    Private Sub TabPage2_Click(sender As Object, e As EventArgs) Handles TabPage2.Click
        p = (BirthUpDown.Value * 30) + 200
    End Sub
    Private Sub TabPage3_Click(sender As Object, e As EventArgs) Handles TabPage3.Click
        p = (BirthUpDown.Value * 30) + 300
    End Sub
    Private Sub TabPage4_Click(sender As Object, e As EventArgs) Handles TabPage4.Click
        p = (BirthUpDown.Value * 30) + 400
    End Sub
End Class
