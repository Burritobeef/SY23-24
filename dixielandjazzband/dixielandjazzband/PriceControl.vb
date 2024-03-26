Imports System.Reflection.Emit
Imports System.Windows.Forms.ComponentModel.Com2Interop
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports Accessibility

Public Class PriceControl
    Dim C As New Price
    Public Property Increment As Decimal
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

    Private Sub PriceControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PriceTextBox.Text = Increment.ToString("c2")
    End Sub
End Class
