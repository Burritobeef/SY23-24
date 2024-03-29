﻿Imports System.Security.Cryptography
Public Class Form1
    Dim moveSpeed As Integer = 15
    Dim isJumping As Boolean
    Private Sub frm2DPlatformer_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyCode
            Case Keys.Right
                tmrRight.Start()
            Case Keys.Left
                tmrLeft.Start()
            Case Keys.Up
                tmrUp.Start()
                isJumping = True
        End Select
    End Sub

    Private Sub tmrRight_Tick(sender As Object, e As EventArgs) Handles tmrRight.Tick
        Picplayer.Left += moveSpeed
    End Sub

    Private Sub Form1_KeyUp(sender As Object, e As KeyEventArgs) Handles Me.KeyUp
        Select Case e.KeyCode
            Case Keys.Right
                tmrRight.Stop()
            Case Keys.Left
                tmrLeft.Stop()
            Case Keys.Up
                tmrUp.Stop()
                isJumping = False
        End Select
    End Sub

    Private Sub tmrLeft_Tick(sender As Object, e As EventArgs) Handles tmrLeft.Tick
        Picplayer.Left -= moveSpeed
    End Sub

    Private Sub tmrUp_Tick(sender As Object, e As EventArgs) Handles tmrUp.Tick
        Picplayer.Top -= moveSpeed
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tmrGameLogic.Start()
    End Sub

    Private Sub tmrGameLogic_Tick(sender As Object, e As EventArgs) Handles tmrGameLogic.Tick
        If Picplayer.Bounds.IntersectsWith(picground.Bounds) Then
            tmrGravity.Stop()
        Else
            If isJumping = False Then
                tmrGravity.Start()
            End If
        End If

        For Each b As Control In Me.Controls
            If TypeOf b Is PictureBox Then
                If b.Tag = "bound" Then
                    If Picplayer.Bounds.IntersectsWith(b.Bounds) Then
                        tmrGravity.Stop()
                    End If
                End If

                If b.Tag = "win" And Picplayer.Visible = True Then
                    If Picplayer.Bounds.IntersectsWith(b.Bounds) And b.Visible = True Then
                        Label1.Text = Label1.Text + 1
                        b.Visible = False
                    End If
                End If

                If Label1.Text = "6" Then
                    Picplayer.Visible = False
                    Picair.BackColor = Color.Green
                    Label1.Text = "YOU WIN!"
                End If

                If b.Tag = "lose" Then
                    If Picplayer.Bounds.IntersectsWith(b.Bounds) Then
                        Picplayer.Visible = False
                        Picair.BackColor = Color.Red
                        Label1.Text = "YOU LOSE!"
                    End If
                End If
            End If
        Next
    End Sub

    Private Sub tmrGravity_Tick(sender As Object, e As EventArgs) Handles tmrGravity.Tick
        Picplayer.Top += moveSpeed
    End Sub
End Class