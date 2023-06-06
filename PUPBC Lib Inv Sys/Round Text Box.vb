﻿Imports System
Imports System.Drawing
Imports System.Runtime.InteropServices
Imports System.ComponentModel

Public Class Round_Text_Box
    Inherits TextBox
    <DllImport("gdi32.dll", EntryPoint:="CreateRoundRectRgn")>
    Private Shared Function CreateRoundRectRgn(ByVal nleftRect As Integer, ByVal nTop As Integer, ByVal nRightRect As Integer, ByVal nBottomRect As Integer, ByVal nHeightRect As Integer, ByVal nWidhtRect As Integer) As IntPtr
    End Function
    Protected Overrides Sub OnCreateControl()
        MyBase.OnCreateControl()
        Me.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(2, 3, Me.Width, Me.Height, 15, 15))
    End Sub
    Protected Overrides Sub OnResize(e As EventArgs)
        MyBase.OnResize(e)
        Me.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(2, 3, Me.Width, Me.Height, 15, 15))
    End Sub
End Class
