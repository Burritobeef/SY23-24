Public Class Form1
    Dim WithEvents cs As New coinslot
    Private Sub nickle_Click(sender As Object, e As EventArgs) Handles nickle.Click
        cs.insertnickle()
        Label1.Text = cs.total.ToString("c2")
    End Sub

    Private Sub dime_Click(sender As Object, e As EventArgs) Handles dime.Click
        cs.insertdime()
        Label1.Text = cs.total.ToString("c2")
    End Sub

    Private Sub Quarter_Click(sender As Object, e As EventArgs) Handles Quarter.Click
        cs.insertquarter()
        Label1.Text = cs.total.ToString("c2")
    End Sub

    Private Sub dollar_Click(sender As Object, e As EventArgs) Handles dollar.Click
        cs.insertdollar()
        Label1.Text = cs.total.ToString("c2")
    End Sub
    Private Sub CoinReturn_Click(sender As Object, e As EventArgs) Handles CoinReturn.Click
        cs.coinReturn()
        Label1.Text = cs.total.ToString("c2")
    End Sub

    Private Sub cs_coinreturnevent(D As Integer, q As Integer, di As Integer, n As Integer) Handles cs.coinreturnevent
        If D > 0 Then
            dollarbill.Visible = True
        Else
            dollarbill.Visible = False
        End If
        If n > 0 Then
            nicklecoin.Visible = True
        Else
            nicklecoin.Visible = False
        End If
        If di > 0 Then
            dimecoin.Visible = True
        Else
            dimecoin.Visible = False
        End If
        If q > 0 Then
            Quartercoin.Visible = True
        Else
            Quartercoin.Visible = False
        End If
    End Sub

    Private Sub Productcontrol5_Load(sender As Object, e As EventArgs) Handles Productcontrol5.Load

    End Sub

    Private Sub Productcontrol3_Load(sender As Object, e As EventArgs) Handles Productcontrol3.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Select Case idtextbox.Text
            Case Productcontrol1.productid
                cs.buy(Productcontrol1)
            Case Productcontrol2.productid
                cs.buy(Productcontrol2)
            Case Productcontrol3.productid
                cs.buy(Productcontrol3)
            Case Productcontrol4.productid
                cs.buy(Productcontrol4)
            Case Productcontrol5.productid
                cs.buy(Productcontrol5)
            Case Productcontrol6.productid
                cs.buy(Productcontrol6)
            Case Productcontrol7.productid
                cs.buy(Productcontrol7)
            Case Productcontrol8.productid
                cs.buy(Productcontrol8)
            Case Productcontrol9.productid
                cs.buy(Productcontrol9)
            Case Productcontrol10.productid
                cs.buy(Productcontrol10)
            Case Productcontrol11.productid
                cs.buy(Productcontrol11)
            Case Productcontrol12.productid
                cs.buy(Productcontrol12)
            Case Productcontrol13.productid
                cs.buy(Productcontrol13)
            Case Productcontrol14.productid
                cs.buy(Productcontrol14)
            Case Productcontrol15.productid
                cs.buy(Productcontrol15)
            Case Productcontrol16.productid
                cs.buy(Productcontrol16)
            Case 2

            Case Else

        End Select
        Label1.Text = cs.total.ToString("c2")
    End Sub
    Private Sub cs_buyevent(p As Image) Handles cs.buyevent
        ProductPictureBox.Image = p
    End Sub
End Class

