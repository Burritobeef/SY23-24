﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.dollar = New System.Windows.Forms.Button()
        Me.Quarter = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CoinReturn = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.idtextbox = New System.Windows.Forms.TextBox()
        Me.ProductPictureBox = New System.Windows.Forms.PictureBox()
        Me.Productcontrol16 = New VendingMachine.productcontrol()
        Me.Productcontrol15 = New VendingMachine.productcontrol()
        Me.Productcontrol14 = New VendingMachine.productcontrol()
        Me.Productcontrol13 = New VendingMachine.productcontrol()
        Me.Productcontrol12 = New VendingMachine.productcontrol()
        Me.Productcontrol11 = New VendingMachine.productcontrol()
        Me.Productcontrol10 = New VendingMachine.productcontrol()
        Me.Productcontrol9 = New VendingMachine.productcontrol()
        Me.Productcontrol8 = New VendingMachine.productcontrol()
        Me.Productcontrol7 = New VendingMachine.productcontrol()
        Me.Productcontrol6 = New VendingMachine.productcontrol()
        Me.Productcontrol5 = New VendingMachine.productcontrol()
        Me.Productcontrol4 = New VendingMachine.productcontrol()
        Me.Productcontrol3 = New VendingMachine.productcontrol()
        Me.Productcontrol2 = New VendingMachine.productcontrol()
        Me.Productcontrol1 = New VendingMachine.productcontrol()
        Me.Quartercoin = New System.Windows.Forms.PictureBox()
        Me.dimecoin = New System.Windows.Forms.PictureBox()
        Me.nicklecoin = New System.Windows.Forms.PictureBox()
        Me.dollarbill = New System.Windows.Forms.PictureBox()
        Me.nickle = New System.Windows.Forms.Button()
        Me.dime = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        CType(Me.ProductPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Quartercoin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dimecoin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nicklecoin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dollarbill, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dollar
        '
        Me.dollar.Location = New System.Drawing.Point(71, 12)
        Me.dollar.Name = "dollar"
        Me.dollar.Size = New System.Drawing.Size(56, 23)
        Me.dollar.TabIndex = 0
        Me.dollar.Text = "dollar"
        Me.dollar.UseVisualStyleBackColor = True
        '
        'Quarter
        '
        Me.Quarter.Location = New System.Drawing.Point(424, 12)
        Me.Quarter.Name = "Quarter"
        Me.Quarter.Size = New System.Drawing.Size(56, 23)
        Me.Quarter.TabIndex = 1
        Me.Quarter.Text = "quarter"
        Me.Quarter.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(682, 296)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 16)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "$0.00"
        '
        'CoinReturn
        '
        Me.CoinReturn.Location = New System.Drawing.Point(664, 388)
        Me.CoinReturn.Name = "CoinReturn"
        Me.CoinReturn.Size = New System.Drawing.Size(92, 23)
        Me.CoinReturn.TabIndex = 9
        Me.CoinReturn.Text = "coin return"
        Me.CoinReturn.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(90, 502)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 30
        Me.Button1.Text = "Buy"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'idtextbox
        '
        Me.idtextbox.Location = New System.Drawing.Point(80, 531)
        Me.idtextbox.Name = "idtextbox"
        Me.idtextbox.Size = New System.Drawing.Size(100, 22)
        Me.idtextbox.TabIndex = 31
        '
        'ProductPictureBox
        '
        Me.ProductPictureBox.Location = New System.Drawing.Point(48, 581)
        Me.ProductPictureBox.Name = "ProductPictureBox"
        Me.ProductPictureBox.Size = New System.Drawing.Size(226, 169)
        Me.ProductPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ProductPictureBox.TabIndex = 32
        Me.ProductPictureBox.TabStop = False
        '
        'Productcontrol16
        '
        Me.Productcontrol16.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Productcontrol16.Location = New System.Drawing.Point(320, 641)
        Me.Productcontrol16.Name = "Productcontrol16"
        Me.Productcontrol16.productcount = 10
        Me.Productcontrol16.productid = "b7"
        Me.Productcontrol16.productpicture = Global.VendingMachine.My.Resources.Resources.images__9_
        Me.Productcontrol16.productprice = New Decimal(New Integer() {15, 0, 0, 65536})
        Me.Productcontrol16.Size = New System.Drawing.Size(146, 165)
        Me.Productcontrol16.TabIndex = 29
        '
        'Productcontrol15
        '
        Me.Productcontrol15.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Productcontrol15.Location = New System.Drawing.Point(485, 641)
        Me.Productcontrol15.Name = "Productcontrol15"
        Me.Productcontrol15.productcount = 10
        Me.Productcontrol15.productid = "b6"
        Me.Productcontrol15.productpicture = Global.VendingMachine.My.Resources.Resources.images__6_
        Me.Productcontrol15.productprice = New Decimal(New Integer() {2, 0, 0, 0})
        Me.Productcontrol15.Size = New System.Drawing.Size(146, 165)
        Me.Productcontrol15.TabIndex = 28
        '
        'Productcontrol14
        '
        Me.Productcontrol14.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Productcontrol14.Location = New System.Drawing.Point(653, 641)
        Me.Productcontrol14.Name = "Productcontrol14"
        Me.Productcontrol14.productcount = 10
        Me.Productcontrol14.productid = "b5"
        Me.Productcontrol14.productpicture = Global.VendingMachine.My.Resources.Resources.images__8_
        Me.Productcontrol14.productprice = New Decimal(New Integer() {15, 0, 0, 65536})
        Me.Productcontrol14.Size = New System.Drawing.Size(146, 165)
        Me.Productcontrol14.TabIndex = 27
        '
        'Productcontrol13
        '
        Me.Productcontrol13.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Productcontrol13.Location = New System.Drawing.Point(320, 489)
        Me.Productcontrol13.Name = "Productcontrol13"
        Me.Productcontrol13.productcount = 10
        Me.Productcontrol13.productid = "b6"
        Me.Productcontrol13.productpicture = Global.VendingMachine.My.Resources.Resources.images__5_
        Me.Productcontrol13.productprice = New Decimal(New Integer() {0, 0, 0, 0})
        Me.Productcontrol13.Size = New System.Drawing.Size(146, 155)
        Me.Productcontrol13.TabIndex = 26
        '
        'Productcontrol12
        '
        Me.Productcontrol12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Productcontrol12.Location = New System.Drawing.Point(485, 489)
        Me.Productcontrol12.Name = "Productcontrol12"
        Me.Productcontrol12.productcount = 10
        Me.Productcontrol12.productid = "a8"
        Me.Productcontrol12.productpicture = Global.VendingMachine.My.Resources.Resources.images__4_
        Me.Productcontrol12.productprice = New Decimal(New Integer() {15, 0, 0, 65536})
        Me.Productcontrol12.Size = New System.Drawing.Size(146, 155)
        Me.Productcontrol12.TabIndex = 25
        '
        'Productcontrol11
        '
        Me.Productcontrol11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Productcontrol11.Location = New System.Drawing.Point(655, 489)
        Me.Productcontrol11.Name = "Productcontrol11"
        Me.Productcontrol11.productcount = 10
        Me.Productcontrol11.productid = "a7"
        Me.Productcontrol11.productpicture = Global.VendingMachine.My.Resources.Resources.download__13_
        Me.Productcontrol11.productprice = New Decimal(New Integer() {15, 0, 0, 65536})
        Me.Productcontrol11.Size = New System.Drawing.Size(146, 155)
        Me.Productcontrol11.TabIndex = 24
        '
        'Productcontrol10
        '
        Me.Productcontrol10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Productcontrol10.Location = New System.Drawing.Point(972, 641)
        Me.Productcontrol10.Name = "Productcontrol10"
        Me.Productcontrol10.productcount = 10
        Me.Productcontrol10.productid = "a6"
        Me.Productcontrol10.productpicture = Global.VendingMachine.My.Resources.Resources.images__3_
        Me.Productcontrol10.productprice = New Decimal(New Integer() {15, 0, 0, 65536})
        Me.Productcontrol10.Size = New System.Drawing.Size(146, 154)
        Me.Productcontrol10.TabIndex = 23
        '
        'Productcontrol9
        '
        Me.Productcontrol9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Productcontrol9.Location = New System.Drawing.Point(820, 641)
        Me.Productcontrol9.Name = "Productcontrol9"
        Me.Productcontrol9.productcount = 10
        Me.Productcontrol9.productid = "b4"
        Me.Productcontrol9.productpicture = Global.VendingMachine.My.Resources.Resources.images__10_
        Me.Productcontrol9.productprice = New Decimal(New Integer() {2, 0, 0, 0})
        Me.Productcontrol9.Size = New System.Drawing.Size(146, 165)
        Me.Productcontrol9.TabIndex = 22
        '
        'Productcontrol8
        '
        Me.Productcontrol8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Productcontrol8.Location = New System.Drawing.Point(972, 489)
        Me.Productcontrol8.Name = "Productcontrol8"
        Me.Productcontrol8.productcount = 10
        Me.Productcontrol8.productid = "b3"
        Me.Productcontrol8.productpicture = Global.VendingMachine.My.Resources.Resources.images__2_
        Me.Productcontrol8.productprice = New Decimal(New Integer() {2, 0, 0, 0})
        Me.Productcontrol8.Size = New System.Drawing.Size(146, 155)
        Me.Productcontrol8.TabIndex = 21
        '
        'Productcontrol7
        '
        Me.Productcontrol7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Productcontrol7.Location = New System.Drawing.Point(820, 489)
        Me.Productcontrol7.Name = "Productcontrol7"
        Me.Productcontrol7.productcount = 10
        Me.Productcontrol7.productid = "a5"
        Me.Productcontrol7.productpicture = Global.VendingMachine.My.Resources.Resources.images__1_
        Me.Productcontrol7.productprice = New Decimal(New Integer() {15, 0, 0, 65536})
        Me.Productcontrol7.Size = New System.Drawing.Size(146, 155)
        Me.Productcontrol7.TabIndex = 20
        '
        'Productcontrol6
        '
        Me.Productcontrol6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Productcontrol6.Location = New System.Drawing.Point(972, 337)
        Me.Productcontrol6.Name = "Productcontrol6"
        Me.Productcontrol6.productcount = 10
        Me.Productcontrol6.productid = "b2"
        Me.Productcontrol6.productpicture = Global.VendingMachine.My.Resources.Resources.downloadg__12_
        Me.Productcontrol6.productprice = New Decimal(New Integer() {15, 0, 0, 65536})
        Me.Productcontrol6.Size = New System.Drawing.Size(146, 152)
        Me.Productcontrol6.TabIndex = 19
        '
        'Productcontrol5
        '
        Me.Productcontrol5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Productcontrol5.Location = New System.Drawing.Point(820, 337)
        Me.Productcontrol5.Name = "Productcontrol5"
        Me.Productcontrol5.productcount = 10
        Me.Productcontrol5.productid = "a4"
        Me.Productcontrol5.productpicture = Global.VendingMachine.My.Resources.Resources._04laiqybfera1
        Me.Productcontrol5.productprice = New Decimal(New Integer() {15, 0, 0, 65536})
        Me.Productcontrol5.Size = New System.Drawing.Size(146, 152)
        Me.Productcontrol5.TabIndex = 18
        '
        'Productcontrol4
        '
        Me.Productcontrol4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Productcontrol4.Location = New System.Drawing.Point(972, 172)
        Me.Productcontrol4.Name = "Productcontrol4"
        Me.Productcontrol4.productcount = 10
        Me.Productcontrol4.productid = "a3"
        Me.Productcontrol4.productpicture = Global.VendingMachine.My.Resources.Resources.download__12_6
        Me.Productcontrol4.productprice = New Decimal(New Integer() {15, 0, 0, 65536})
        Me.Productcontrol4.Size = New System.Drawing.Size(146, 159)
        Me.Productcontrol4.TabIndex = 17
        '
        'Productcontrol3
        '
        Me.Productcontrol3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Productcontrol3.Location = New System.Drawing.Point(972, 13)
        Me.Productcontrol3.Name = "Productcontrol3"
        Me.Productcontrol3.productcount = 10
        Me.Productcontrol3.productid = "b1"
        Me.Productcontrol3.productpicture = Global.VendingMachine.My.Resources.Resources.download__12_4
        Me.Productcontrol3.productprice = New Decimal(New Integer() {2, 0, 0, 0})
        Me.Productcontrol3.Size = New System.Drawing.Size(146, 153)
        Me.Productcontrol3.TabIndex = 16
        '
        'Productcontrol2
        '
        Me.Productcontrol2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Productcontrol2.Location = New System.Drawing.Point(820, 172)
        Me.Productcontrol2.Name = "Productcontrol2"
        Me.Productcontrol2.productcount = 10
        Me.Productcontrol2.productid = "a2"
        Me.Productcontrol2.productpicture = Global.VendingMachine.My.Resources.Resources.download__12_5
        Me.Productcontrol2.productprice = New Decimal(New Integer() {15, 0, 0, 65536})
        Me.Productcontrol2.Size = New System.Drawing.Size(146, 159)
        Me.Productcontrol2.TabIndex = 15
        '
        'Productcontrol1
        '
        Me.Productcontrol1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Productcontrol1.Location = New System.Drawing.Point(820, 13)
        Me.Productcontrol1.Name = "Productcontrol1"
        Me.Productcontrol1.productcount = 10
        Me.Productcontrol1.productid = "a1"
        Me.Productcontrol1.productpicture = Global.VendingMachine.My.Resources.Resources.download__12_3
        Me.Productcontrol1.productprice = New Decimal(New Integer() {15, 0, 0, 65536})
        Me.Productcontrol1.Size = New System.Drawing.Size(146, 166)
        Me.Productcontrol1.TabIndex = 14
        '
        'Quartercoin
        '
        Me.Quartercoin.Image = Global.VendingMachine.My.Resources.Resources.download__12_
        Me.Quartercoin.Location = New System.Drawing.Point(653, 41)
        Me.Quartercoin.Name = "Quartercoin"
        Me.Quartercoin.Size = New System.Drawing.Size(103, 81)
        Me.Quartercoin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Quartercoin.TabIndex = 13
        Me.Quartercoin.TabStop = False
        Me.Quartercoin.Visible = False
        '
        'dimecoin
        '
        Me.dimecoin.Image = Global.VendingMachine.My.Resources.Resources.download__12_1
        Me.dimecoin.Location = New System.Drawing.Point(674, 117)
        Me.dimecoin.Name = "dimecoin"
        Me.dimecoin.Size = New System.Drawing.Size(70, 49)
        Me.dimecoin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.dimecoin.TabIndex = 12
        Me.dimecoin.TabStop = False
        Me.dimecoin.Visible = False
        '
        'nicklecoin
        '
        Me.nicklecoin.Image = Global.VendingMachine.My.Resources.Resources.download__12_2
        Me.nicklecoin.Location = New System.Drawing.Point(655, 161)
        Me.nicklecoin.Name = "nicklecoin"
        Me.nicklecoin.Size = New System.Drawing.Size(101, 74)
        Me.nicklecoin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.nicklecoin.TabIndex = 11
        Me.nicklecoin.TabStop = False
        Me.nicklecoin.Visible = False
        '
        'dollarbill
        '
        Me.dollarbill.Image = Global.VendingMachine.My.Resources.Resources.US_one_dollar_bill__obverse__series_2009
        Me.dollarbill.Location = New System.Drawing.Point(664, 228)
        Me.dollarbill.Name = "dollarbill"
        Me.dollarbill.Size = New System.Drawing.Size(100, 50)
        Me.dollarbill.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.dollarbill.TabIndex = 10
        Me.dollarbill.TabStop = False
        Me.dollarbill.Visible = False
        '
        'nickle
        '
        Me.nickle.BackgroundImage = Global.VendingMachine.My.Resources.Resources.download__12_1
        Me.nickle.Location = New System.Drawing.Point(424, 241)
        Me.nickle.Name = "nickle"
        Me.nickle.Size = New System.Drawing.Size(56, 23)
        Me.nickle.TabIndex = 3
        Me.nickle.Text = "nickle"
        Me.nickle.UseVisualStyleBackColor = True
        '
        'dime
        '
        Me.dime.BackgroundImage = Global.VendingMachine.My.Resources.Resources.download__12_1
        Me.dime.Location = New System.Drawing.Point(71, 241)
        Me.dime.Name = "dime"
        Me.dime.Size = New System.Drawing.Size(56, 23)
        Me.dime.TabIndex = 2
        Me.dime.Text = "dime"
        Me.dime.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.VendingMachine.My.Resources.Resources.US_one_dollar_bill__obverse__series_2009
        Me.PictureBox1.Location = New System.Drawing.Point(48, 41)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(299, 181)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.VendingMachine.My.Resources.Resources.Jefferson_Nickel_Unc_Obv
        Me.PictureBox3.Location = New System.Drawing.Point(424, 270)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(154, 141)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 6
        Me.PictureBox3.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = Global.VendingMachine.My.Resources.Resources.download__12_2
        Me.PictureBox4.Location = New System.Drawing.Point(71, 270)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(146, 117)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox4.TabIndex = 7
        Me.PictureBox4.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.VendingMachine.My.Resources.Resources.download__12_
        Me.PictureBox2.Location = New System.Drawing.Point(424, 41)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(207, 194)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 5
        Me.PictureBox2.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1224, 859)
        Me.Controls.Add(Me.ProductPictureBox)
        Me.Controls.Add(Me.idtextbox)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Productcontrol16)
        Me.Controls.Add(Me.Productcontrol15)
        Me.Controls.Add(Me.Productcontrol14)
        Me.Controls.Add(Me.Productcontrol13)
        Me.Controls.Add(Me.Productcontrol12)
        Me.Controls.Add(Me.Productcontrol11)
        Me.Controls.Add(Me.Productcontrol10)
        Me.Controls.Add(Me.Productcontrol9)
        Me.Controls.Add(Me.Productcontrol8)
        Me.Controls.Add(Me.Productcontrol7)
        Me.Controls.Add(Me.Productcontrol6)
        Me.Controls.Add(Me.Productcontrol5)
        Me.Controls.Add(Me.Productcontrol4)
        Me.Controls.Add(Me.Productcontrol3)
        Me.Controls.Add(Me.Productcontrol2)
        Me.Controls.Add(Me.Productcontrol1)
        Me.Controls.Add(Me.Quartercoin)
        Me.Controls.Add(Me.dimecoin)
        Me.Controls.Add(Me.nicklecoin)
        Me.Controls.Add(Me.dollarbill)
        Me.Controls.Add(Me.CoinReturn)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.nickle)
        Me.Controls.Add(Me.dime)
        Me.Controls.Add(Me.Quarter)
        Me.Controls.Add(Me.dollar)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.ProductPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Quartercoin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dimecoin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nicklecoin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dollarbill, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dollar As Button
    Friend WithEvents Quarter As Button
    Friend WithEvents dime As Button
    Friend WithEvents nickle As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents CoinReturn As Button
    Friend WithEvents dollarbill As PictureBox
    Friend WithEvents nicklecoin As PictureBox
    Friend WithEvents dimecoin As PictureBox
    Friend WithEvents Quartercoin As PictureBox
    Friend WithEvents Productcontrol1 As productcontrol
    Friend WithEvents Productcontrol2 As productcontrol
    Friend WithEvents Productcontrol3 As productcontrol
    Friend WithEvents Productcontrol4 As productcontrol
    Friend WithEvents Productcontrol5 As productcontrol
    Friend WithEvents Productcontrol6 As productcontrol
    Friend WithEvents Productcontrol7 As productcontrol
    Friend WithEvents Productcontrol8 As productcontrol
    Friend WithEvents Productcontrol9 As productcontrol
    Friend WithEvents Productcontrol10 As productcontrol
    Friend WithEvents Productcontrol11 As productcontrol
    Friend WithEvents Productcontrol12 As productcontrol
    Friend WithEvents Productcontrol13 As productcontrol
    Friend WithEvents Productcontrol14 As productcontrol
    Friend WithEvents Productcontrol15 As productcontrol
    Friend WithEvents Productcontrol16 As productcontrol
    Friend WithEvents Button1 As Button
    Friend WithEvents idtextbox As TextBox
    Friend WithEvents ProductPictureBox As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
End Class
