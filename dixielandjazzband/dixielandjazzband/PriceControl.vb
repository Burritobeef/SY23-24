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
        HourTextBox.Text = C.Price
        TotalLabel.Text = C.total.ToString("c2")
    End Sub


    Private Sub TakeOneButton_Click(sender As Object, e As EventArgs) Handles TakeOneButton.Click
        C.Increment = Increment
        C.Remove()
        HourTextBox.Text = C.Price
        TotalLabel.Text = C.total.ToString("c2")
    End Sub

End Class
