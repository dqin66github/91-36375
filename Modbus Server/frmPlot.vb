Option Explicit On
Option Strict On
Imports System.Windows.Forms.DataVisualization.Charting
Imports System.IO

Public Class frmPlot

    Public Const MAX_POINTS = 50000
    Public start_point As Integer = 0
    Public stop_point As Integer = 0
    Private pixels As Byte = 2

    Private xvalue(MAX_POINTS) As Double
    Private yvalue(MAX_POINTS) As Double
    Private total_points As Integer = 0


    Private Sub btnSaveGraph_Click(sender As Object, e As EventArgs) Handles btnSaveGraph.Click
        saveFileDialog1.Filter = "JPeg Image|*.jpg|Bitmap Image|*.bmp|Gif Image|*.gif"
        saveFileDialog1.Title = "Save graph"
        saveFileDialog1.ShowDialog()

        ' If the file name is not an empty string open it for saving.  
        If (saveFileDialog1.FileName <> "") Then
            Select Case saveFileDialog1.FilterIndex
                Case 1
                    chart1.SaveImage(saveFileDialog1.FileName, ChartImageFormat.Jpeg)
                Case 2
                    chart1.SaveImage(saveFileDialog1.FileName, ChartImageFormat.Bmp)
                Case 3
                    chart1.SaveImage(saveFileDialog1.FileName, ChartImageFormat.Gif)
                Case Else

            End Select
        End If
    End Sub
    Private Sub plots_refresh()
        Dim k As Integer
        chart1.ChartAreas("ChartArea1").AxisY2.Enabled = AxisEnabled.False
        chart1.ChartAreas("ChartArea1").AxisX.Title = "AFC Position"

        chart1.Series(0).Points.Clear()
        chart1.Series(0).YAxisType = AxisType.Primary

        If (stop_point > start_point) Then
            For k = start_point To CInt(stop_point - 1)
                chart1.Series(0).Points.AddXY(xvalue(k), yvalue(k))
            Next
        End If

    End Sub

    Private Sub frmPlot_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        cbBoxType.Items.Add(SeriesChartType.FastLine)
        cbBoxType.Items.Add(SeriesChartType.Line)
        cbBoxType.Items.Add(SeriesChartType.FastPoint)
        cbBoxType.Items.Add(SeriesChartType.Point)

        cbBoxType.SelectedIndex = My.Settings.Plot_line_type  ' refresh line style

        pixels = My.Settings.Plot_line_pixels
        lblLineWidth.Text = pixels.ToString()

        chart1.Series(0).BorderWidth = pixels

        chart1.Series(0).Points.Clear()

        total_points = 0
        start_point = 0
        stop_point = 0
        Call plots_refresh()

    End Sub

    Private Sub lblStartTime_Click(sender As Object, e As EventArgs) Handles lblStartTime.Click

    End Sub

    Private Sub cbBoxType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbBoxType.SelectedIndexChanged
        chart1.Series(0).ChartType = CType(cbBoxType.SelectedItem, SeriesChartType)
    End Sub
    Public Sub addDataPoint(x As Double, y As Double)
        If (total_points < MAX_POINTS) Then
            xvalue(total_points) = x
            yvalue(total_points) = y

            total_points = total_points + 1
            stop_point = total_points
            Call plots_refresh()
        End If

    End Sub


    Public Sub addDataArray(x() As Integer, y() As Integer, len As Integer)
        Dim i As Integer
        For i = 0 To (len - 1)
            xvalue(i) = x(i)
            yvalue(i) = y(i)
        Next i

        start_point = 0
        total_points = len
        stop_point = len
        Call plots_refresh()

    End Sub

End Class