Imports System.Drawing.Drawing2D
Imports System.Math
Public Class ButtonSelected
    Private IsSelected As Boolean

    Property ShowBoardSelected() As Boolean
        Get
            Return IsSelected
        End Get
        Set(ByVal value As Boolean)
            IsSelected = value
            If value = True Then
                '  Me.FlatStyle = Windows.Forms.FlatStyle.Popup
                Me.Font = New Font(Me.Font.FontFamily, 16, FontStyle.Bold)
                Me.ForeColor = Color.FromArgb(0, 110, 199)
                '  Me.Size = New Size(200, 40)
            Else
                '  Me.FlatStyle = Windows.Forms.FlatStyle.Flat
                Me.Font = New Font(Me.Font.FontFamily, 10, FontStyle.Bold)
                Me.ForeColor = Color.Black
                '  Me.Size = New Size(190, 30)
            End If
            RecreateHandle()
        End Set
    End Property
    Protected Overrides Sub OnPaint(ByVal e As System.Windows.Forms.PaintEventArgs)
        MyBase.OnPaint(e)
        If (IsSelected) Then
            Dim rect As New Rectangle(5, 5, Me.Width - 10, Me.Height - 10)
            '    Dim rect As New Rectangle(0, 0, Me.Width, Me.Height)
            Dim g As Graphics = e.Graphics
            '    Dim mypen As New Pen(Me.FlatAppearance.BorderColor, Me.FlatAppearance.BorderSize * 3)
            Dim mypen As New Pen(Color.LawnGreen, 5)
            '   Dim rect As System.Drawing.Rectangle = e.ClipRectangle



            g.SmoothingMode = SmoothingMode.AntiAlias
            '  g.DrawLine(mypen, 0, 0, 0, Me.Height)  ' erase left border

            e.Graphics.DrawRectangle(mypen, rect)

            '     g.DrawRectangle(mainPen, mainPen.Width, mainPen.Width, Me.Width - 2 * mainPen.Width, Me.Height - 2 * mainPen.Width)
            '     g.FillRectangle(mySolidBrush, mainPen.Width + 1, mainPen.Width + 1, Width - mainPen.Width * 2 - 2, Height - mainPen.Width * 2 - 2)
            ' g.DrawRectangle(mainPen, mainPen.Width / 2, mainPen.Width / 2, Me.Width - mainPen.Width - 1, Me.Height - mainPen.Width - 1)
            '  g.FillRectangle(mySolidBrush, mainPen.Width, mainPen.Width, Width - mainPen.Width * 2 - 1, Height - mainPen.Width * 2 - 1)
            '      g.DrawLine(mainPen, 0, 0, CInt(width * 0.99), 0)
            '      g.DrawLine(mainPen, CInt(width * 0.99), 0, CInt(width * 0.99), CInt(Me.Height * 0.9))

            '     mainPen.Width = PrivateScaleWidth
            '     g.DrawArc(mainPen, 0, CInt(width * TopSpaceWidthRatio), width, width, PrivateArcStart, PrivateArcRange)


            mypen.Dispose()
            ' mySolidBrush.Dispose()
        End If
    End Sub
End Class
