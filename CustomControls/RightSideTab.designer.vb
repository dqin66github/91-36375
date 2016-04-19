<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RightSideTab
    Inherits System.Windows.Forms.TabControl

    'UserControl1 overrides dispose to clean up the component list.
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
        components = New System.ComponentModel.Container()
        Me.Alignment = TabAlignment.Right
        Me.DrawMode = TabDrawMode.OwnerDrawFixed
        Me.SizeMode = TabSizeMode.Fixed
        Me.ItemSize = New Size(25, 100)


        AddHandler Me.DrawItem, AddressOf MyDrawItem
        '   Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    End Sub
    Private Sub MyDrawItem(ByVal sender As Object, ByVal e As System.Windows.Forms.DrawItemEventArgs)
        Dim g As Graphics = e.Graphics
        Dim _TextBrush As Brush

        ' Get the item from the collection.
        Dim _TabPage As TabPage = Me.TabPages(e.Index)



        ' Get the real bounds for the tab rectangle.
        Dim _TabBounds As Rectangle = Me.GetTabRect(e.Index)

        If (e.Index < 15) Then

            If (e.State = DrawItemState.Selected) Then
                ' Draw a different background color, and don't paint a focus rectangle.
                _TextBrush = New System.Drawing.SolidBrush(e.ForeColor)  'New SolidBrush(Color.Red)
                g.FillRectangle(Brushes.LightBlue, e.Bounds)
            Else
                _TextBrush = New System.Drawing.SolidBrush(e.ForeColor)
                e.DrawBackground()
            End If

            ' Use our own font.
            Dim _TabFont As New Font("Microsoft Sans Serif", 8.25, FontStyle.Italic, GraphicsUnit.Point)

            ' Draw string. Center the text.
            Dim _StringFlags As New StringFormat()
            _StringFlags.Alignment = StringAlignment.Center
            _StringFlags.LineAlignment = StringAlignment.Center

            g.DrawString(_TabPage.Text, _TabFont, _TextBrush, _TabBounds, New StringFormat(_StringFlags))
        End If
#If False Then
        ' for easy edit
        If (e.Index < 2) Then
            Me.Location = New Point(12, 138)
            Me.Size = New Size(1045, 591)
        Else
            Me.Location = New Point(397, 138)
            Me.Size = New Size(660, 591)
        End If
#End If
    End Sub
End Class
