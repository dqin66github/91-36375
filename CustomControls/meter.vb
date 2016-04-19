Imports System.Drawing.Drawing2D
Imports System.Math
Public Class meter
    Inherits System.Windows.Forms.UserControl

#Region "Variables and Enumerations"
    Private PrivateMaxValue As Integer = 700
    Private PrivateValue As Integer = 0

    Private PrivateMarkCount As Integer = 4
    Private PrivateMarkLen As Integer = 5

    Private PrivateScaleWidth As Single = 1
    Private PrivateArcStart As Integer = 210
    Private PrivateArcRange As Integer = 120

    Private PrivateHeightWidthRatio As Single = 0.6
    Private PrivateTopspaceWidthRatio As Single = 0.18

    Private privateScaleColor As System.Drawing.Color = Color.White
    Private privatePointerColor As System.Drawing.Color = Color.Red

    Private totalBeads As Integer = 10
    Private totalScore As Integer = 0
    Private beadDiameter As Integer = CInt(Me.Width / (totalBeads + 2))
    Private isClickable As Boolean = True
    Private hasOutline As Boolean = True

#End Region

#Region "Control Properties"

    ' The height/width ratio
    Public Property HeightWidthRatio() As Single
        Get
            Return PrivateHeightWidthRatio
        End Get
        Set(ByVal value As Single)
            If value > 1 Then
                PrivateHeightWidthRatio = 1
            ElseIf value < 0.5 Then
                PrivateHeightWidthRatio = 0.5
            Else
                PrivateHeightWidthRatio = value
            End If
            Me.Invalidate()
        End Set
    End Property
    ' The topspace/width ratio
    Public Property TopSpaceWidthRatio() As Single
        Get
            Return PrivateTopspaceWidthRatio
        End Get
        Set(ByVal value As Single)
            If value > 0.5 Then
                PrivateTopspaceWidthRatio = 0.5
            ElseIf value < 0.1 Then
                PrivateTopspaceWidthRatio = 0.1
            Else
                PrivateTopspaceWidthRatio = value
            End If
            Me.Invalidate()
        End Set
    End Property
    ' The color property of the beads.
    Public Property ScaleColor() As System.Drawing.Color
        Get
            Return privateScaleColor
        End Get
        Set(ByVal value As System.Drawing.Color)
            privateScaleColor = value
            Me.Invalidate()
        End Set
    End Property
    ' The color property of the beads.
    Public Property ScaleWidth() As Single
        Get
            Return PrivateScaleWidth
        End Get
        Set(ByVal value As Single)
            If (value <= 1) Then
                value = 1
            ElseIf (value > 10) Then
                value = 10
            End If
            PrivateScaleWidth = value
            Me.Invalidate()
        End Set
    End Property

    Public Property PointerColor() As System.Drawing.Color
        Get
            Return privatePointerColor
        End Get
        Set(ByVal value As System.Drawing.Color)
            privatePointerColor = value
            Me.Invalidate()
        End Set
    End Property
    ' The number of beads on the control.
    Public Property MarkCount() As Integer
        Get
            Return PrivateMarkCount
        End Get
        Set(ByVal value As Integer)
            If value > 0 Then
                PrivateMarkCount = value
            Else
                PrivateMarkCount = 4
            End If
             Me.Invalidate()
        End Set
    End Property

    ' The score displayed by the control.
    Public Property MaxValue() As Integer
        Get
            Return PrivateMaxValue
        End Get
        Set(ByVal value As Integer)
            If value >= 0 Then
                PrivateMaxValue = value
            Else
                PrivateMaxValue = 0
            End If
            Me.Invalidate()
        End Set
    End Property
    ' The value displayed by the control.
    Public Property Value() As Integer
        Get
            Return PrivateValue
        End Get
        Set(ByVal value As Integer)
            If value >= 0 Then
                If value < PrivateMaxValue Then
                    PrivateValue = value
                Else
                    PrivateValue = PrivateMaxValue
                End If
            Else
                PrivateValue = 0
            End If
            Me.Invalidate()
        End Set
    End Property

#End Region

#Region "Drawing Functions"
    Protected Overrides Sub OnPaint(ByVal e As System.Windows.Forms.PaintEventArgs)

        Dim rect As System.Drawing.Rectangle = e.ClipRectangle
        Dim g As Graphics = e.Graphics
        Dim mainPen As New Pen(privateScaleColor)
        Dim width As Integer
        Dim x0 As Integer, y0 As Integer, x1 As Integer, y1 As Integer, angle As Double

        Me.SetStyle(ControlStyles.OptimizedDoubleBuffer Or ControlStyles.UserPaint Or ControlStyles.AllPaintingInWmPaint, True)
        ' Draw Main Lines.
        mainPen.Width = CSng(System.Math.Ceiling(rect.Width / 100))
        Me.Height = Me.Width * HeightWidthRatio
        If (rect.Width > 10 And rect.Height > 10) Then
            width = rect.Width
        Else
            width = 10
        End If

        g.SmoothingMode = SmoothingMode.AntiAlias
        g.DrawLine(mainPen, 0, 0, 0, CInt(Me.Height * 0.9))
        g.DrawLine(mainPen, 0, 0, CInt(width * 0.99), 0)
        g.DrawLine(mainPen, CInt(width * 0.99), 0, CInt(width * 0.99), CInt(Me.Height * 0.9))

        mainPen.Width = PrivateScaleWidth
        g.DrawArc(mainPen, 0, CInt(width * TopSpaceWidthRatio), width, width, PrivateArcStart, PrivateArcRange)

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
        mainPen.Dispose()
    End Sub

  
#End Region



End Class