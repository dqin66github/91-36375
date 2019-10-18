<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPlot
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
        Dim ChartArea2 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend2 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series2 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.btnSaveGraph = New System.Windows.Forms.Button()
        Me.lblStopTime = New System.Windows.Forms.Label()
        Me.lblLineWidth = New System.Windows.Forms.Label()
        Me.lblStartTime = New System.Windows.Forms.Label()
        Me.label2 = New System.Windows.Forms.Label()
        Me.label4 = New System.Windows.Forms.Label()
        Me.label3 = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        Me.cbBoxType = New System.Windows.Forms.ComboBox()
        Me.saveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        CType(Me.chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'chart1
        '
        ChartArea2.AxisX.TitleFont = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ChartArea2.AxisY.TitleFont = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ChartArea2.Name = "ChartArea1"
        Me.chart1.ChartAreas.Add(ChartArea2)
        Me.chart1.Dock = System.Windows.Forms.DockStyle.Left
        Legend2.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Legend2.IsTextAutoFit = False
        Legend2.Name = "Legend1"
        Legend2.TitleFont = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chart1.Legends.Add(Legend2)
        Me.chart1.Location = New System.Drawing.Point(0, 0)
        Me.chart1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.chart1.Name = "chart1"
        Series2.BorderWidth = 2
        Series2.ChartArea = "ChartArea1"
        Series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine
        Series2.Legend = "Legend1"
        Series2.LegendText = "Reverse Power"
        Series2.Name = "Series1"
        Me.chart1.Series.Add(Series2)
        Me.chart1.Size = New System.Drawing.Size(940, 575)
        Me.chart1.TabIndex = 1
        Me.chart1.Text = "chart1"
        '
        'btnSaveGraph
        '
        Me.btnSaveGraph.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSaveGraph.Location = New System.Drawing.Point(978, 391)
        Me.btnSaveGraph.Name = "btnSaveGraph"
        Me.btnSaveGraph.Size = New System.Drawing.Size(209, 37)
        Me.btnSaveGraph.TabIndex = 17
        Me.btnSaveGraph.Text = "Save Graph"
        Me.btnSaveGraph.UseVisualStyleBackColor = True
        '
        'lblStopTime
        '
        Me.lblStopTime.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblStopTime.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStopTime.Location = New System.Drawing.Point(1081, 221)
        Me.lblStopTime.Name = "lblStopTime"
        Me.lblStopTime.Size = New System.Drawing.Size(93, 25)
        Me.lblStopTime.TabIndex = 13
        Me.lblStopTime.Visible = False
        '
        'lblLineWidth
        '
        Me.lblLineWidth.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblLineWidth.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLineWidth.Location = New System.Drawing.Point(979, 127)
        Me.lblLineWidth.Name = "lblLineWidth"
        Me.lblLineWidth.Size = New System.Drawing.Size(93, 25)
        Me.lblLineWidth.TabIndex = 14
        Me.lblLineWidth.Visible = False
        '
        'lblStartTime
        '
        Me.lblStartTime.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblStartTime.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStartTime.Location = New System.Drawing.Point(978, 221)
        Me.lblStartTime.Name = "lblStartTime"
        Me.lblStartTime.Size = New System.Drawing.Size(93, 25)
        Me.lblStartTime.TabIndex = 15
        Me.lblStartTime.Visible = False
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label2.Location = New System.Drawing.Point(976, 36)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(71, 17)
        Me.label2.TabIndex = 9
        Me.label2.Text = "Chart Type"
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label4.Location = New System.Drawing.Point(976, 105)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(95, 17)
        Me.label4.TabIndex = 10
        Me.label4.Text = "Plot Line Width"
        Me.label4.Visible = False
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label3.Location = New System.Drawing.Point(1078, 199)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(68, 17)
        Me.label3.TabIndex = 11
        Me.label3.Text = "Stop Point"
        Me.label3.Visible = False
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.Location = New System.Drawing.Point(975, 199)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(68, 17)
        Me.label1.TabIndex = 12
        Me.label1.Text = "Start Point"
        Me.label1.Visible = False
        '
        'cbBoxType
        '
        Me.cbBoxType.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbBoxType.FormattingEnabled = True
        Me.cbBoxType.Location = New System.Drawing.Point(979, 57)
        Me.cbBoxType.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cbBoxType.Name = "cbBoxType"
        Me.cbBoxType.Size = New System.Drawing.Size(201, 25)
        Me.cbBoxType.TabIndex = 8
        Me.cbBoxType.Text = "Choose chart type"
        '
        'frmPlot
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1243, 575)
        Me.Controls.Add(Me.btnSaveGraph)
        Me.Controls.Add(Me.lblStopTime)
        Me.Controls.Add(Me.lblLineWidth)
        Me.Controls.Add(Me.lblStartTime)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.label4)
        Me.Controls.Add(Me.label3)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.cbBoxType)
        Me.Controls.Add(Me.chart1)
        Me.Name = "frmPlot"
        Me.Text = "Reverse Power vs. AFC Position"
        CType(Me.chart1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents chart1 As System.Windows.Forms.DataVisualization.Charting.Chart
    Private WithEvents btnSaveGraph As System.Windows.Forms.Button
    Private WithEvents lblStopTime As System.Windows.Forms.Label
    Private WithEvents lblLineWidth As System.Windows.Forms.Label
    Private WithEvents lblStartTime As System.Windows.Forms.Label
    Private WithEvents label2 As System.Windows.Forms.Label
    Private WithEvents label4 As System.Windows.Forms.Label
    Private WithEvents label3 As System.Windows.Forms.Label
    Private WithEvents label1 As System.Windows.Forms.Label
    Private WithEvents cbBoxType As System.Windows.Forms.ComboBox
    Private WithEvents saveFileDialog1 As System.Windows.Forms.SaveFileDialog
End Class
