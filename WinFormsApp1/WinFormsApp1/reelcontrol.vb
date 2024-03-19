Imports System.Threading

Public Class reelcontrol

    Sub spin()
        Dim rand As New Random
        Dim r As Integer
        r = rand.Next(3)
        PictureBox1.Image = ImageList1.Images(r)
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        spin()
    End Sub
End Class