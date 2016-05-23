<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ServerSettings
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
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtIPAddr = New System.Windows.Forms.TextBox()
        Me.btnConnect = New System.Windows.Forms.Button()
        Me.lblConnectStatus = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TimerUpdate = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(41, 49)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Server IP Address"
        '
        'txtIPAddr
        '
        Me.txtIPAddr.Location = New System.Drawing.Point(44, 65)
        Me.txtIPAddr.Name = "txtIPAddr"
        Me.txtIPAddr.Size = New System.Drawing.Size(100, 20)
        Me.txtIPAddr.TabIndex = 1
        Me.txtIPAddr.Text = "192.168.0.15"
        '
        'btnConnect
        '
        Me.btnConnect.Location = New System.Drawing.Point(234, 62)
        Me.btnConnect.Name = "btnConnect"
        Me.btnConnect.Size = New System.Drawing.Size(75, 23)
        Me.btnConnect.TabIndex = 2
        Me.btnConnect.Text = "Connect"
        Me.btnConnect.UseVisualStyleBackColor = True
        '
        'lblConnectStatus
        '
        Me.lblConnectStatus.AutoSize = True
        Me.lblConnectStatus.Location = New System.Drawing.Point(84, 121)
        Me.lblConnectStatus.Name = "lblConnectStatus"
        Me.lblConnectStatus.Size = New System.Drawing.Size(24, 13)
        Me.lblConnectStatus.TabIndex = 3
        Me.lblConnectStatus.Text = "Idle"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(41, 121)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Status: "
        '
        'TimerUpdate
        '
        Me.TimerUpdate.Enabled = True
        Me.TimerUpdate.Interval = 500
        '
        'ServerSettings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(377, 176)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblConnectStatus)
        Me.Controls.Add(Me.btnConnect)
        Me.Controls.Add(Me.txtIPAddr)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ServerSettings"
        Me.Text = "Server Settings (Modbus Port 502)"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtIPAddr As System.Windows.Forms.TextBox
    Friend WithEvents btnConnect As System.Windows.Forms.Button
    Friend WithEvents lblConnectStatus As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TimerUpdate As System.Windows.Forms.Timer

End Class
