Imports System.Drawing.Drawing2D
Imports System.Math
Public Class BlueRect
    Inherits System.Windows.Forms.UserControl

#Region "Variables and Enumerations"
    Private PrivateBorderWidth As Single = 7

    Private privateBorderColor As System.Drawing.Color = Color.Blue

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
    Public Property MyBorderWidth() As Single
        Get
            Return PrivateBorderWidth
        End Get
        Set(ByVal value As Single)
            If (value <= 0.001) Then
                value = 0.001
            ElseIf (value > (Width / 2)) Then
                value = (Width / 2)
            End If
            PrivateBorderWidth = value
            Me.Invalidate()
        End Set
    End Property

 
#End Region

#Region "Drawing Functions"
    Protected Overrides Sub OnPaint(ByVal e As System.Windows.Forms.PaintEventArgs)

        '   Dim rect As System.Drawing.Rectangle = e.ClipRectangle
        Dim g As Graphics = e.Graphics
        Dim mainPen As New Pen(privateBorderColor)
        Dim mySolidBrush As New SolidBrush(Color.Transparent)

        Me.SetStyle(ControlStyles.OptimizedDoubleBuffer Or ControlStyles.UserPaint Or ControlStyles.AllPaintingInWmPaint, True)
        ' Draw Main Lines.
        mainPen.Width = PrivateBorderWidth

        g.SmoothingMode = SmoothingMode.AntiAlias
        '     g.DrawRectangle(mainPen, mainPen.Width, mainPen.Width, Me.Width - 2 * mainPen.Width, Me.Height - 2 * mainPen.Width)
        '     g.FillRectangle(mySolidBrush, mainPen.Width + 1, mainPen.Width + 1, Width - mainPen.Width * 2 - 2, Height - mainPen.Width * 2 - 2)
        g.DrawRectangle(mainPen, mainPen.Width / 2, mainPen.Width / 2, Me.Width - mainPen.Width - 1, Me.Height - mainPen.Width - 1)
        g.FillRectangle(mySolidBrush, mainPen.Width, mainPen.Width, Width - mainPen.Width * 2 - 1, Height - mainPen.Width * 2 - 1)
        '      g.DrawLine(mainPen, 0, 0, 0, CInt(Me.Height * 0.9))
        '      g.DrawLine(mainPen, 0, 0, CInt(width * 0.99), 0)
        '      g.DrawLine(mainPen, CInt(width * 0.99), 0, CInt(width * 0.99), CInt(Me.Height * 0.9))

        '     mainPen.Width = PrivateScaleWidth
        '     g.DrawArc(mainPen, 0, CInt(width * TopSpaceWidthRatio), width, width, PrivateArcStart, PrivateArcRange)
#If False Then
        For i = 0 To PrivateMarkCount * 2
            angle = (PrivateArcStart - 180 + i * PrivateArcRange / 2 / PrivateMarkCount) * PI / 180
            If (i Mod 2) > 0 Then ' minor scale
                x0 = width / 2 - (width / 2 + PrivateMarkLen / 2) * Cos(angle)
                y0 = width / 2 + width * TopSpaceWidthRatio - (width / 2 + PrivateMarkLen / 2) * Sin(angle)
            Else
                x0 = width / 2 - (width / 2 + PrivateMarkLen) * Cos(angle)
                y0 = width / 2 + width * TopSpaceWidthRatio - (width / 2 + PrivateMarkLen) * Sin(angle)
            End If
            x1 = width / 2 - width / 2 * Cos(angle)
            y1 = width / 2 + width * TopSpaceWidthRatio - width / 2 * Sin(angle)
            g.DrawLine(mainPen, x0, y0, x1, y1)
        Next


        '    g.DrawLine(mainPen, rect.Width - 1, CInt(rect.Height / 2 - beadDiameter / 2), rect.Width - 1, CInt(rect.Height / 2 + beadDiameter / 2))
        mainPen.Width = PrivateScaleWidth * 3
        mainPen.Color = privatePointerColor
        angle = (PrivateArcStart - 180 + CSng(PrivateValue) * CSng(PrivateArcRange) / MaxValue) * PI / 180
        x1 = width / 2 - width / 2 * Cos(angle)
        y1 = width / 2 + width * TopSpaceWidthRatio - width / 2 * Sin(angle)
        '   x0 = width / 2
        y0 = width / 2 + width * TopSpaceWidthRatio
        If (y0 > (Me.Height * 0.9)) Then y0 = Me.Height * 0.9
        x0 = x1 - (y1 - y0) / Tan(angle)
        Dim points As Point() = {New Point(x0 - 3, y0), New Point(x0 + 3, y0), New Point(x1, y1)}
        Dim path As New GraphicsPath
        Dim mySolidBrush As New SolidBrush(PointerColor)
        path.AddLines(points)

        g.FillPath(mySolidBrush, path)

        mySolidBrush.Dispose()
        path.Dispose()
#End If
        mainPen.Dispose()
        mySolidBrush.Dispose()
    End Sub


#End Region



End Class