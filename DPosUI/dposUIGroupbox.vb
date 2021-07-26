Imports System.Windows.Forms
Imports System.Drawing
Public Class dposUIGroupbox
    Inherits GroupBox

    Public zBorderColor As Color
    Public zBorderThickness As Integer

    Sub New()
        MyBase.New

        Me.BorderColor = Color.Black
        Me.BorderThickness = 2
    End Sub

    Public Property BorderColor As Color
        Get
            Return zBorderColor
        End Get
        Set(value As Color)
            zBorderColor = value
        End Set
    End Property

    Public Property BorderThickness As Integer
        Get
            Return zBorderThickness
        End Get
        Set(value As Integer)
            zBorderThickness = value
        End Set
    End Property

    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        Dim tSize As Size = TextRenderer.MeasureText(Me.Text, Me.Font)
        Dim borderRect As Rectangle = e.ClipRectangle

        If Me.Text = "" Then
            borderRect.Y = (borderRect.Y + (Me.BorderThickness * 2))
        Else
            borderRect.Y = (borderRect.Y + (tSize.Height / 2))
        End If


        borderRect.X = (borderRect.X + Me.BorderThickness)

        If Me.Text = "" Then
            borderRect.Height = (borderRect.Height - (Me.BorderThickness * 4))
        Else
            borderRect.Height = (borderRect.Height - (tSize.Height / 2) - (Me.BorderThickness * 2))
        End If

        borderRect.Width = borderRect.Width - (Me.BorderThickness * 2)

        Dim myPen As Pen = New Pen(Me.BorderColor, Me.BorderThickness)
        e.Graphics.DrawRectangle(myPen, borderRect)

        If Me.Text <> "" Then
            Dim textRect As Rectangle = e.ClipRectangle
            textRect.X = (textRect.X + 6)
            textRect.Width = tSize.Width
            textRect.Height = tSize.Height
            e.Graphics.FillRectangle(New SolidBrush(Me.BackColor), textRect)
            e.Graphics.DrawString(Me.Text, Me.Font, New SolidBrush(Me.ForeColor), textRect)
        End If

    End Sub

End Class
