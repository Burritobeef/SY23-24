Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class PriceControl
    Dim C As New Price
    Public Property Increment As Integer = 1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles AddOneButton.Click
        C.Increment = Increment
        C.Add()
        PriceTextBox.Text = C.Price
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        C.Clear()
        PriceTextBox.Text = C.Price
    End Sub

    Private Sub TakeOneButton_Click(sender As Object, e As EventArgs) Handles TakeOneButton.Click
        C.Increment = Increment
        C.Remove()
        PriceTextBox.Text = C.Price
    End Sub
End Class
