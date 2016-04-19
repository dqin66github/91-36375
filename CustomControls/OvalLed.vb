Imports System.Drawing.Drawing2D
Imports System.Math
Public Class OvalLed
    Inherits System.Windows.Forms.UserControl

#Region "Variables and Enumerations"
    Private PrivateBorderWidth As Integer = 1

    Private privateBorderColor As System.Drawing.Color = Color.White
    Private privateFillColor As System.Drawing.Color = Color.Red

#End Region

#Region "Control Properties"
    ' The color property of the beads.
    Public Property MyBorderColor() As System.Drawing.Color
        Get
            Return privateBorderColor
        End Get
        Set(ByVal value As System.Drawing.Color)
            privateBorderColor = value
            Me.Invalidate()
        End Set
    End Property
    ' The color property of the beads.
    Public Property MyBorderWidth() As Integer
        Get
            Return PrivateBorderWidth
        End Get
        Set(ByVal value As Integer)
            If (value <= 1) Then
                value = 1
            ElseIf (value > 10) Then
                value = 10
            End If
            PrivateBorderWidth = value
            Me.Invalidate()
        End Set
    End Property

    Public Property FillColor() As System.Drawing.Color
        Get
            Return privateFillColor
        End Get
        Set(ByVal value As System.Drawing.Color)
            privateFillColor = value
            Me.Invalidate()
        End Set
    End Property
 
#End Region

#Region "Drawing Functions"
    Protected Overrides Sub OnPaint(ByVal e As System.Windows.Forms.PaintEventArgs)

        Dim rect As System.Drawing.Rectangle = e.ClipRectangle
        Dim g As Graphics = e.Graphics
        Dim mainPen As New Pen(privateBorderColor)
        Dim mySolidBrush As New SolidBrush(privateFillColor)

        Me.SetStyle(ControlStyles.OptimizedDoubleBuffer Or ControlStyles.UserPaint Or ControlStyles.AllPaintingInWmPaint, True)
        ' Draw Main Lines.
        mainPen.Width = PrivateBorderWidth
        mainPen.Color = privateBorderColor

        g.SmoothingMode = SmoothingMode.AntiAlias
        '    g.DrawArc(mainPen, 0, 0, Me.Width - 1, Me.Height - 1, 0, 360)
        g.DrawEllipse(mainPen, mainPen.Width / 2, mainPen.Width / 2, Width - mainPen.Width - 1, Height - mainPen.Width - 1)
        '   g.DrawEllipse(mainPen, 0, 0, Width - mainPen.Width * 2, Height - mainPen.Width * 2)
        g.FillEllipse(mySolidBrush, mainPen.Width, mainPen.Width, Width - mainPen.Width * 2 - 1, Height - mainPen.Width * 2 - 1)
        mainPen.Dispose()
        mySolidBrush.Dispose()
    End Sub


#End Region



End Class