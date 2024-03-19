Imports System.Reflection.Emit

Public Class Form1
    Dim dollars As Integer

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles spinButton.Click
        If dollars >= 1 Then
            dollars -= 1
            Label1.Text = dollars.ToString("c2")
            Reelcontrol1.Spin()
            Reelcontrol2.Spin()
            Reelcontrol3.Spin()
            r1Label.Text = Reelcontrol1.itemValue
            r2Label.Text = Reelcontrol2.itemValue
            r3Label.Text = Reelcontrol3.itemValue
        End If

        If Reelcontrol1.itemValue = Reelcontrol2.itemValue And
            Reelcontrol2.itemValue = Reelcontrol3.itemValue Then
            Label2.Text = "WIN"
        Else
            Label2.Text = "LOSE"
        End If
    End Sub

    Private Sub doButton_Click(sender As Object, e As EventArgs) Handles doButton.Click
        dollars += 1
        Label1.Text = dollars.ToString("c2")
    End Sub

    Private Sub Reelcontrol6_Load(sender As Object, e As EventArgs) Handles Reelcontrol6.Load

    End Sub
End Class