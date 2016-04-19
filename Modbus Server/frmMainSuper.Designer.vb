<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMainSuper
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
        Me.TimerUpdate = New System.Windows.Forms.Timer(Me.components)
        Me.CheckBoxResetPOR = New System.Windows.Forms.CheckBox()
        Me.CheckBoxResetBOR = New System.Windows.Forms.CheckBox()
        Me.ButtonUpdateInput3 = New System.Windows.Forms.Button()
        Me.CheckBoxResetIdle = New System.Windows.Forms.CheckBox()
        Me.TextBoxInput3 = New System.Windows.Forms.TextBox()
        Me.CheckBoxResetSleep = New System.Windows.Forms.CheckBox()
        Me.LabelValue15 = New System.Windows.Forms.Label()
        Me.CheckBoxResetWDT = New System.Windows.Forms.CheckBox()
        Me.LabelValue14 = New System.Windows.Forms.Label()
        Me.CheckBoxResetSoftware = New System.Windows.Forms.CheckBox()
        Me.LabelValue13 = New System.Windows.Forms.Label()
        Me.CheckBoxResetExt = New System.Windows.Forms.CheckBox()
        Me.LabelValue12 = New System.Windows.Forms.Label()
        Me.CheckBoxResetIllegal = New System.Windows.Forms.CheckBox()
        Me.LabelValue11 = New System.Windows.Forms.Label()
        Me.CheckBoxResetTrap = New System.Windows.Forms.CheckBox()
        Me.LabelRCON = New System.Windows.Forms.Label()
        Me.ButtonResetSlave = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.LabelScale = New System.Windows.Forms.Label()
        Me.LabelOffset = New System.Windows.Forms.Label()
        Me.LabelEEpromIndex = New System.Windows.Forms.Label()
        Me.ComboBoxEEpromRegister = New System.Windows.Forms.ComboBox()
        Me.TextBoxEEpromOffSet = New System.Windows.Forms.TextBox()
        Me.TextBoxEEpromScale = New System.Windows.Forms.TextBox()
        Me.ButtonWriteEEprom = New System.Windows.Forms.Button()
        Me.ButtonReadEEprom = New System.Windows.Forms.Button()
        Me.LabelValueDebugF = New System.Windows.Forms.Label()
        Me.LabelValueDebugE = New System.Windows.Forms.Label()
        Me.LabelValueDebugD = New System.Windows.Forms.Label()
        Me.LabelValueDebugC = New System.Windows.Forms.Label()
        Me.LabelValueDebugB = New System.Windows.Forms.Label()
        Me.LabelValueDebugA = New System.Windows.Forms.Label()
        Me.LabelValueDebug9 = New System.Windows.Forms.Label()
        Me.LabelValueDebug8 = New System.Windows.Forms.Label()
        Me.LabelValueDebug7 = New System.Windows.Forms.Label()
        Me.LabelValueDebug6 = New System.Windows.Forms.Label()
        Me.LabelValueDebug5 = New System.Windows.Forms.Label()
        Me.LabelValueDebug4 = New System.Windows.Forms.Label()
        Me.LabelValueDebug3 = New System.Windows.Forms.Label()
        Me.LabelValueDebug2 = New System.Windows.Forms.Label()
        Me.LabelValueDebug1 = New System.Windows.Forms.Label()
        Me.LabelValueDebug0 = New System.Windows.Forms.Label()
        Me.LabelValue10 = New System.Windows.Forms.Label()
        Me.LabelValue9 = New System.Windows.Forms.Label()
        Me.LabelFirmwareVerssion = New System.Windows.Forms.Label()
        Me.LabelValue8 = New System.Windows.Forms.Label()
        Me.LabelAgileInfo = New System.Windows.Forms.Label()
        Me.LabelValue7 = New System.Windows.Forms.Label()
        Me.LabelErrorReserved1 = New System.Windows.Forms.Label()
        Me.LabelValue6 = New System.Windows.Forms.Label()
        Me.LabelErrorReserved0 = New System.Windows.Forms.Label()
        Me.LabelValue5 = New System.Windows.Forms.Label()
        Me.LabelErrorSelfTestResultRegister = New System.Windows.Forms.Label()
        Me.LabelValue4 = New System.Windows.Forms.Label()
        Me.LabelErrorResetCount = New System.Windows.Forms.Label()
        Me.LabelValue3 = New System.Windows.Forms.Label()
        Me.LabelErrorScaleCount = New System.Windows.Forms.Label()
        Me.LabelValue2 = New System.Windows.Forms.Label()
        Me.LabelValue1 = New System.Windows.Forms.Label()
        Me.LabelErrorSPIBusCount = New System.Windows.Forms.Label()
        Me.ButtonUpdateInput2 = New System.Windows.Forms.Button()
        Me.LabelErrorI2CBusCount = New System.Windows.Forms.Label()
        Me.ButtonUpdateInput1 = New System.Windows.Forms.Button()
        Me.LabelDebugF = New System.Windows.Forms.Label()
        Me.LabelDebugE = New System.Windows.Forms.Label()
        Me.LabelDebugD = New System.Windows.Forms.Label()
        Me.LabelDebugC = New System.Windows.Forms.Label()
        Me.LabelDebugB = New System.Windows.Forms.Label()
        Me.LabelDebugA = New System.Windows.Forms.Label()
        Me.TextBoxInput1 = New System.Windows.Forms.TextBox()
        Me.LabelDebug9 = New System.Windows.Forms.Label()
        Me.TextBoxInput2 = New System.Windows.Forms.TextBox()
        Me.LabelDebug8 = New System.Windows.Forms.Label()
        Me.LabelDebug7 = New System.Windows.Forms.Label()
        Me.LabelDebug6 = New System.Windows.Forms.Label()
        Me.LabelDebug5 = New System.Windows.Forms.Label()
        Me.LabelDebug4 = New System.Windows.Forms.Label()
        Me.LabelDebug3 = New System.Windows.Forms.Label()
        Me.LabelDebug2 = New System.Windows.Forms.Label()
        Me.LabelDebug1 = New System.Windows.Forms.Label()
        Me.LabelDebug0 = New System.Windows.Forms.Label()
        Me.LabelCanTimeoutCount = New System.Windows.Forms.Label()
        Me.LabelCAnDataLogRXBufferOVerflowCount = New System.Windows.Forms.Label()
        Me.LabelCanRXBufferOverflowCount = New System.Windows.Forms.Label()
        Me.LabelCanTXBufOverflowCount = New System.Windows.Forms.Label()
        Me.LabelCanTX0Count = New System.Windows.Forms.Label()
        Me.LabelCanAddressErrorCount = New System.Windows.Forms.Label()
        Me.LabelCanInvalidIndexCount = New System.Windows.Forms.Label()
        Me.LabelCanUnknownIdentifierCount = New System.Windows.Forms.Label()
        Me.LabelCanISREnteredCount = New System.Windows.Forms.Label()
        Me.LabelCanRX1Filt2Count = New System.Windows.Forms.Label()
        Me.LabelCanRX0Filt1Count = New System.Windows.Forms.Label()
        Me.LabelCanRX0Filt0Count = New System.Windows.Forms.Label()
        Me.LabelCanTX2Count = New System.Windows.Forms.Label()
        Me.LabelCanTX1Count = New System.Windows.Forms.Label()
        Me.LabelCanErrorFlagCount = New System.Windows.Forms.Label()
        Me.LabelCanCXECReg = New System.Windows.Forms.Label()
        Me.CheckBoxFaultBitF = New System.Windows.Forms.CheckBox()
        Me.CheckBoxFaultBitE = New System.Windows.Forms.CheckBox()
        Me.CheckBoxFaultBitD = New System.Windows.Forms.CheckBox()
        Me.CheckBoxFaultBitC = New System.Windows.Forms.CheckBox()
        Me.CheckBoxFaultBitB = New System.Windows.Forms.CheckBox()
        Me.CheckBoxFaultBitA = New System.Windows.Forms.CheckBox()
        Me.CheckBoxFaultBit9 = New System.Windows.Forms.CheckBox()
        Me.CheckBoxFaultBit8 = New System.Windows.Forms.CheckBox()
        Me.CheckBoxFaultBit7 = New System.Windows.Forms.CheckBox()
        Me.CheckBoxFaultBit6 = New System.Windows.Forms.CheckBox()
        Me.CheckBoxFaultBit5 = New System.Windows.Forms.CheckBox()
        Me.CheckBoxFaultBit4 = New System.Windows.Forms.CheckBox()
        Me.CheckBoxFaultBit3 = New System.Windows.Forms.CheckBox()
        Me.CheckBoxFaultBit2 = New System.Windows.Forms.CheckBox()
        Me.CheckBoxFaultBit1 = New System.Windows.Forms.CheckBox()
        Me.CheckBoxFaultBit0 = New System.Windows.Forms.CheckBox()
        Me.cboIndex = New System.Windows.Forms.ComboBox()
        Me.LabelBoardStatus = New System.Windows.Forms.Label()
        Me.TextBoxInput4 = New System.Windows.Forms.TextBox()
        Me.TextBoxInput5 = New System.Windows.Forms.TextBox()
        Me.ButtonUpdateInput4 = New System.Windows.Forms.Button()
        Me.ButtonUpdateInput5 = New System.Windows.Forms.Button()
        Me.Splitter1 = New System.Windows.Forms.Splitter()
        Me.LabelDisplay8 = New System.Windows.Forms.Label()
        Me.LabelDisplay7 = New System.Windows.Forms.Label()
        Me.LabelDisplay6 = New System.Windows.Forms.Label()
        Me.LabelDisplay5 = New System.Windows.Forms.Label()
        Me.LabelDisplay4 = New System.Windows.Forms.Label()
        Me.LabelDisplay3 = New System.Windows.Forms.Label()
        Me.LabelDisplay2 = New System.Windows.Forms.Label()
        Me.LabelDisplay1 = New System.Windows.Forms.Label()
        Me.CheckBoxOperateEthernet = New System.Windows.Forms.CheckBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CheckBoxOperatePulseSync = New System.Windows.Forms.CheckBox()
        Me.CheckBoxOperateMagnetronCurrentMon = New System.Windows.Forms.CheckBox()
        Me.CheckBoxOperateGunDriver = New System.Windows.Forms.CheckBox()
        Me.CheckBoxOperateHtrMag = New System.Windows.Forms.CheckBox()
        Me.CheckBoxOperateCooling = New System.Windows.Forms.CheckBox()
        Me.CheckBoxOperateAFC = New System.Windows.Forms.CheckBox()
        Me.CheckBoxOperateIonPump = New System.Windows.Forms.CheckBox()
        Me.CheckBoxOperateHVLambda = New System.Windows.Forms.CheckBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.CheckBoxPulseSyncConnected = New System.Windows.Forms.CheckBox()
        Me.CheckBoxPulseCurrentMonitorConnected = New System.Windows.Forms.CheckBox()
        Me.CheckBoxGunDriverConnected = New System.Windows.Forms.CheckBox()
        Me.CheckBoxHtrMagConnected = New System.Windows.Forms.CheckBox()
        Me.CheckBoxCoolingConnected = New System.Windows.Forms.CheckBox()
        Me.CheckBoxAFCConnected = New System.Windows.Forms.CheckBox()
        Me.CheckBoxIonPumpConnected = New System.Windows.Forms.CheckBox()
        Me.CheckBoxHVLambdaConnected = New System.Windows.Forms.CheckBox()
        Me.LabelECBTime = New System.Windows.Forms.Label()
        Me.LabelComputerTime = New System.Windows.Forms.Label()
        Me.ButtonSetTime = New System.Windows.Forms.Button()
        Me.ButtonStopLog = New System.Windows.Forms.Button()
        Me.ButtonStartLog = New System.Windows.Forms.Button()
        Me.LabelECBState = New System.Windows.Forms.Label()
        Me.CheckBoxSyncBitF = New System.Windows.Forms.CheckBox()
        Me.ButtonToggleResetDebug = New System.Windows.Forms.Button()
        Me.CheckBoxSyncBit8 = New System.Windows.Forms.CheckBox()
        Me.CheckBoxSyncBit7 = New System.Windows.Forms.CheckBox()
        Me.CheckBoxSyncBit6 = New System.Windows.Forms.CheckBox()
        Me.ButtonTogglePulseSyncXray = New System.Windows.Forms.Button()
        Me.CheckBoxSyncBit5 = New System.Windows.Forms.CheckBox()
        Me.ButtonTogglePulseSyncHV = New System.Windows.Forms.Button()
        Me.CheckBoxSyncBit4 = New System.Windows.Forms.CheckBox()
        Me.ButtonToggleHighSpeedDataLogging = New System.Windows.Forms.Button()
        Me.CheckBoxSyncBit3 = New System.Windows.Forms.CheckBox()
        Me.LabelSyncMessageCntrlBits = New System.Windows.Forms.Label()
        Me.CheckBoxSyncBit2 = New System.Windows.Forms.CheckBox()
        Me.ButtonToggleCoolantFault = New System.Windows.Forms.Button()
        Me.CheckBoxSyncBit1 = New System.Windows.Forms.CheckBox()
        Me.CheckBoxSyncBit0 = New System.Windows.Forms.CheckBox()
        Me.ButtonToggleReset = New System.Windows.Forms.Button()
        Me.CheckBoxControlBit1 = New System.Windows.Forms.CheckBox()
        Me.CheckBoxControlBit0 = New System.Windows.Forms.CheckBox()
        Me.CheckBoxControlBit2 = New System.Windows.Forms.CheckBox()
        Me.CheckBoxControlBit3 = New System.Windows.Forms.CheckBox()
        Me.CheckBoxControlBit4 = New System.Windows.Forms.CheckBox()
        Me.CheckBoxControlBit5 = New System.Windows.Forms.CheckBox()
        Me.CheckBoxControlBit6 = New System.Windows.Forms.CheckBox()
        Me.CheckBoxControlBit7 = New System.Windows.Forms.CheckBox()
        Me.LabelGuiVersion = New System.Windows.Forms.Label()
        Me.LabelRangeInput1 = New System.Windows.Forms.Label()
        Me.LabelRangeInput2 = New System.Windows.Forms.Label()
        Me.LabelRangeInput3 = New System.Windows.Forms.Label()
        Me.LabelRangeInput4 = New System.Windows.Forms.Label()
        Me.LabelRangeInput5 = New System.Windows.Forms.Label()
        Me.ButtonReloadECBDefaults = New System.Windows.Forms.Button()
        Me.ButtonZeroOnTime = New System.Windows.Forms.Button()
        Me.ButtonZeroPulseCounters = New System.Windows.Forms.Button()
        Me.ButtonToggleMode = New System.Windows.Forms.Button()
        Me.CheckBoxLoggedBitF = New System.Windows.Forms.CheckBox()
        Me.CheckBoxLoggedBit0 = New System.Windows.Forms.CheckBox()
        Me.CheckBoxLoggedBit1 = New System.Windows.Forms.CheckBox()
        Me.CheckBoxLoggedBit2 = New System.Windows.Forms.CheckBox()
        Me.CheckBoxLoggedBit3 = New System.Windows.Forms.CheckBox()
        Me.CheckBoxLoggedBit4 = New System.Windows.Forms.CheckBox()
        Me.CheckBoxLoggedBit5 = New System.Windows.Forms.CheckBox()
        Me.CheckBoxLoggedBit6 = New System.Windows.Forms.CheckBox()
        Me.CheckBoxLoggedBit7 = New System.Windows.Forms.CheckBox()
        Me.CheckBoxLoggedBit8 = New System.Windows.Forms.CheckBox()
        Me.CheckBoxLoggedBit9 = New System.Windows.Forms.CheckBox()
        Me.CheckBoxLoggedBitA = New System.Windows.Forms.CheckBox()
        Me.CheckBoxLoggedBitB = New System.Windows.Forms.CheckBox()
        Me.CheckBoxLoggedBitC = New System.Windows.Forms.CheckBox()
        Me.CheckBoxLoggedBitD = New System.Windows.Forms.CheckBox()
        Me.CheckBoxLoggedBitE = New System.Windows.Forms.CheckBox()
        Me.ButtonSetRevSN = New System.Windows.Forms.Button()
        Me.ButtonSaveFactorySettings = New System.Windows.Forms.Button()
        Me.ButtonLoadFactorySettings = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TimerUpdate
        '
        Me.TimerUpdate.Interval = 500
        '
        'CheckBoxResetPOR
        '
        Me.CheckBoxResetPOR.AutoSize = True
        Me.CheckBoxResetPOR.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBoxResetPOR.Location = New System.Drawing.Point(816, 587)
        Me.CheckBoxResetPOR.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBoxResetPOR.Name = "CheckBoxResetPOR"
        Me.CheckBoxResetPOR.Size = New System.Drawing.Size(56, 20)
        Me.CheckBoxResetPOR.TabIndex = 276
        Me.CheckBoxResetPOR.Text = "POR"
        Me.CheckBoxResetPOR.UseVisualStyleBackColor = True
        '
        'CheckBoxResetBOR
        '
        Me.CheckBoxResetBOR.AutoSize = True
        Me.CheckBoxResetBOR.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBoxResetBOR.Location = New System.Drawing.Point(816, 567)
        Me.CheckBoxResetBOR.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBoxResetBOR.Name = "CheckBoxResetBOR"
        Me.CheckBoxResetBOR.Size = New System.Drawing.Size(56, 20)
        Me.CheckBoxResetBOR.TabIndex = 275
        Me.CheckBoxResetBOR.Text = "BOR"
        Me.CheckBoxResetBOR.UseVisualStyleBackColor = True
        '
        'ButtonUpdateInput3
        '
        Me.ButtonUpdateInput3.Location = New System.Drawing.Point(963, 61)
        Me.ButtonUpdateInput3.Name = "ButtonUpdateInput3"
        Me.ButtonUpdateInput3.Size = New System.Drawing.Size(100, 23)
        Me.ButtonUpdateInput3.TabIndex = 302
        Me.ButtonUpdateInput3.Text = "Update Input 3"
        Me.ButtonUpdateInput3.UseVisualStyleBackColor = True
        '
        'CheckBoxResetIdle
        '
        Me.CheckBoxResetIdle.AutoSize = True
        Me.CheckBoxResetIdle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBoxResetIdle.Location = New System.Drawing.Point(816, 547)
        Me.CheckBoxResetIdle.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBoxResetIdle.Name = "CheckBoxResetIdle"
        Me.CheckBoxResetIdle.Size = New System.Drawing.Size(49, 20)
        Me.CheckBoxResetIdle.TabIndex = 274
        Me.CheckBoxResetIdle.Text = "Idle"
        Me.CheckBoxResetIdle.UseVisualStyleBackColor = True
        '
        'TextBoxInput3
        '
        Me.TextBoxInput3.Location = New System.Drawing.Point(857, 64)
        Me.TextBoxInput3.MaxLength = 7
        Me.TextBoxInput3.Name = "TextBoxInput3"
        Me.TextBoxInput3.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxInput3.TabIndex = 301
        '
        'CheckBoxResetSleep
        '
        Me.CheckBoxResetSleep.AutoSize = True
        Me.CheckBoxResetSleep.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBoxResetSleep.Location = New System.Drawing.Point(816, 527)
        Me.CheckBoxResetSleep.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBoxResetSleep.Name = "CheckBoxResetSleep"
        Me.CheckBoxResetSleep.Size = New System.Drawing.Size(63, 20)
        Me.CheckBoxResetSleep.TabIndex = 273
        Me.CheckBoxResetSleep.Text = "Sleep"
        Me.CheckBoxResetSleep.UseVisualStyleBackColor = True
        '
        'LabelValue15
        '
        Me.LabelValue15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelValue15.Location = New System.Drawing.Point(651, 377)
        Me.LabelValue15.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.LabelValue15.Name = "LabelValue15"
        Me.LabelValue15.Size = New System.Drawing.Size(200, 16)
        Me.LabelValue15.TabIndex = 300
        Me.LabelValue15.Text = "Label Value 15"
        Me.LabelValue15.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CheckBoxResetWDT
        '
        Me.CheckBoxResetWDT.AutoSize = True
        Me.CheckBoxResetWDT.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBoxResetWDT.Location = New System.Drawing.Point(745, 607)
        Me.CheckBoxResetWDT.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBoxResetWDT.Name = "CheckBoxResetWDT"
        Me.CheckBoxResetWDT.Size = New System.Drawing.Size(59, 20)
        Me.CheckBoxResetWDT.TabIndex = 272
        Me.CheckBoxResetWDT.Text = "WDT"
        Me.CheckBoxResetWDT.UseVisualStyleBackColor = True
        '
        'LabelValue14
        '
        Me.LabelValue14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelValue14.Location = New System.Drawing.Point(651, 351)
        Me.LabelValue14.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.LabelValue14.Name = "LabelValue14"
        Me.LabelValue14.Size = New System.Drawing.Size(200, 16)
        Me.LabelValue14.TabIndex = 299
        Me.LabelValue14.Text = "Label Value 14"
        Me.LabelValue14.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CheckBoxResetSoftware
        '
        Me.CheckBoxResetSoftware.AutoSize = True
        Me.CheckBoxResetSoftware.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBoxResetSoftware.Location = New System.Drawing.Point(745, 587)
        Me.CheckBoxResetSoftware.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBoxResetSoftware.Name = "CheckBoxResetSoftware"
        Me.CheckBoxResetSoftware.Size = New System.Drawing.Size(49, 20)
        Me.CheckBoxResetSoftware.TabIndex = 271
        Me.CheckBoxResetSoftware.Text = "SW"
        Me.CheckBoxResetSoftware.UseVisualStyleBackColor = True
        '
        'LabelValue13
        '
        Me.LabelValue13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelValue13.Location = New System.Drawing.Point(651, 325)
        Me.LabelValue13.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.LabelValue13.Name = "LabelValue13"
        Me.LabelValue13.Size = New System.Drawing.Size(200, 16)
        Me.LabelValue13.TabIndex = 298
        Me.LabelValue13.Text = "Label Value 13"
        Me.LabelValue13.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CheckBoxResetExt
        '
        Me.CheckBoxResetExt.AutoSize = True
        Me.CheckBoxResetExt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBoxResetExt.Location = New System.Drawing.Point(745, 567)
        Me.CheckBoxResetExt.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBoxResetExt.Name = "CheckBoxResetExt"
        Me.CheckBoxResetExt.Size = New System.Drawing.Size(45, 20)
        Me.CheckBoxResetExt.TabIndex = 270
        Me.CheckBoxResetExt.Text = "Ext"
        Me.CheckBoxResetExt.UseVisualStyleBackColor = True
        '
        'LabelValue12
        '
        Me.LabelValue12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelValue12.Location = New System.Drawing.Point(651, 299)
        Me.LabelValue12.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.LabelValue12.Name = "LabelValue12"
        Me.LabelValue12.Size = New System.Drawing.Size(200, 16)
        Me.LabelValue12.TabIndex = 297
        Me.LabelValue12.Text = "Label Value 12"
        Me.LabelValue12.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CheckBoxResetIllegal
        '
        Me.CheckBoxResetIllegal.AutoSize = True
        Me.CheckBoxResetIllegal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBoxResetIllegal.Location = New System.Drawing.Point(745, 547)
        Me.CheckBoxResetIllegal.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBoxResetIllegal.Name = "CheckBoxResetIllegal"
        Me.CheckBoxResetIllegal.Size = New System.Drawing.Size(63, 20)
        Me.CheckBoxResetIllegal.TabIndex = 269
        Me.CheckBoxResetIllegal.Text = "Illegal"
        Me.CheckBoxResetIllegal.UseVisualStyleBackColor = True
        '
        'LabelValue11
        '
        Me.LabelValue11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelValue11.Location = New System.Drawing.Point(651, 273)
        Me.LabelValue11.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.LabelValue11.Name = "LabelValue11"
        Me.LabelValue11.Size = New System.Drawing.Size(200, 16)
        Me.LabelValue11.TabIndex = 277
        Me.LabelValue11.Text = "Label Value 11"
        Me.LabelValue11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CheckBoxResetTrap
        '
        Me.CheckBoxResetTrap.AutoSize = True
        Me.CheckBoxResetTrap.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBoxResetTrap.Location = New System.Drawing.Point(745, 527)
        Me.CheckBoxResetTrap.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBoxResetTrap.Name = "CheckBoxResetTrap"
        Me.CheckBoxResetTrap.Size = New System.Drawing.Size(56, 20)
        Me.CheckBoxResetTrap.TabIndex = 268
        Me.CheckBoxResetTrap.Text = "Trap"
        Me.CheckBoxResetTrap.UseVisualStyleBackColor = True
        '
        'LabelRCON
        '
        Me.LabelRCON.AutoSize = True
        Me.LabelRCON.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelRCON.Location = New System.Drawing.Point(297, 578)
        Me.LabelRCON.Name = "LabelRCON"
        Me.LabelRCON.Size = New System.Drawing.Size(71, 16)
        Me.LabelRCON.TabIndex = 267
        Me.LabelRCON.Text = "LabelError"
        '
        'ButtonResetSlave
        '
        Me.ButtonResetSlave.Location = New System.Drawing.Point(1046, 495)
        Me.ButtonResetSlave.Name = "ButtonResetSlave"
        Me.ButtonResetSlave.Size = New System.Drawing.Size(103, 23)
        Me.ButtonResetSlave.TabIndex = 266
        Me.ButtonResetSlave.Text = "Reset Slave"
        Me.ButtonResetSlave.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(1046, 466)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(103, 23)
        Me.Button1.TabIndex = 265
        Me.Button1.Text = "Reload Defaults"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'LabelScale
        '
        Me.LabelScale.AutoSize = True
        Me.LabelScale.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelScale.Location = New System.Drawing.Point(854, 470)
        Me.LabelScale.Name = "LabelScale"
        Me.LabelScale.Size = New System.Drawing.Size(72, 16)
        Me.LabelScale.TabIndex = 264
        Me.LabelScale.Text = "Scale/Rev"
        '
        'LabelOffset
        '
        Me.LabelOffset.AutoSize = True
        Me.LabelOffset.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelOffset.Location = New System.Drawing.Point(854, 499)
        Me.LabelOffset.Name = "LabelOffset"
        Me.LabelOffset.Size = New System.Drawing.Size(65, 16)
        Me.LabelOffset.TabIndex = 263
        Me.LabelOffset.Text = "Offset/SN"
        '
        'LabelEEpromIndex
        '
        Me.LabelEEpromIndex.AutoSize = True
        Me.LabelEEpromIndex.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelEEpromIndex.Location = New System.Drawing.Point(925, 434)
        Me.LabelEEpromIndex.Name = "LabelEEpromIndex"
        Me.LabelEEpromIndex.Size = New System.Drawing.Size(53, 16)
        Me.LabelEEpromIndex.TabIndex = 262
        Me.LabelEEpromIndex.Text = "Index = "
        '
        'ComboBoxEEpromRegister
        '
        Me.ComboBoxEEpromRegister.FormattingEnabled = True
        Me.ComboBoxEEpromRegister.Items.AddRange(New Object() {"ADC AN0 ", "ADC AN0 - External", "ADC AN1 ", "ADC AN1 - External", "ADC AN2 ", "ADC AN2 - External", "ADC AN3 ", "ADC AN3 - External", "ADC AN4 ", "ADC AN4 - External", "ADC AN5 ", "ADC AN5 - External", "ADC AN6 ", "ADC AN6 - External", "ADC AN7 ", "ADC AN7 - External", "ADC AN8 ", "ADC AN8 - External", "ADC AN9 ", "ADC AN9 - External", "ADC AN10 ", "ADC AN10 - External", "ADC AN11 ", "ADC AN11 - External", "ADC AN12 ", "ADC AN12 - External", "ADC AN13 ", "ADC AN13 - External", "ADC AN14 ", "ADC AN14 - External", "ADC AN15 ", "ADC AN15 - External", "DAC CH0", "DAC CH0 - External", "DAC CH1", "DAC CH1 - External", "DAC CH2", "DAC CH2 - External", "DAC CH3", "DAC CH3 - External", "DAC CH4", "DAC CH4 - External", "DAC CH5", "DAC CH5 - External", "DAC CH6", "DAC CH6 - External", "DAC CH7", "DAC CH7 - External"})
        Me.ComboBoxEEpromRegister.Location = New System.Drawing.Point(748, 429)
        Me.ComboBoxEEpromRegister.Name = "ComboBoxEEpromRegister"
        Me.ComboBoxEEpromRegister.Size = New System.Drawing.Size(171, 21)
        Me.ComboBoxEEpromRegister.TabIndex = 261
        Me.ComboBoxEEpromRegister.Text = "Select Register"
        '
        'TextBoxEEpromOffSet
        '
        Me.TextBoxEEpromOffSet.Location = New System.Drawing.Point(748, 495)
        Me.TextBoxEEpromOffSet.MaxLength = 7
        Me.TextBoxEEpromOffSet.Name = "TextBoxEEpromOffSet"
        Me.TextBoxEEpromOffSet.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxEEpromOffSet.TabIndex = 260
        '
        'TextBoxEEpromScale
        '
        Me.TextBoxEEpromScale.Location = New System.Drawing.Point(748, 466)
        Me.TextBoxEEpromScale.MaxLength = 7
        Me.TextBoxEEpromScale.Name = "TextBoxEEpromScale"
        Me.TextBoxEEpromScale.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxEEpromScale.TabIndex = 259
        '
        'ButtonWriteEEprom
        '
        Me.ButtonWriteEEprom.Location = New System.Drawing.Point(924, 495)
        Me.ButtonWriteEEprom.Name = "ButtonWriteEEprom"
        Me.ButtonWriteEEprom.Size = New System.Drawing.Size(103, 23)
        Me.ButtonWriteEEprom.TabIndex = 258
        Me.ButtonWriteEEprom.Text = "Write EEProm"
        Me.ButtonWriteEEprom.UseVisualStyleBackColor = True
        '
        'ButtonReadEEprom
        '
        Me.ButtonReadEEprom.Location = New System.Drawing.Point(924, 466)
        Me.ButtonReadEEprom.Name = "ButtonReadEEprom"
        Me.ButtonReadEEprom.Size = New System.Drawing.Size(103, 23)
        Me.ButtonReadEEprom.TabIndex = 257
        Me.ButtonReadEEprom.Text = "Read EEProm"
        Me.ButtonReadEEprom.UseVisualStyleBackColor = True
        '
        'LabelValueDebugF
        '
        Me.LabelValueDebugF.AutoSize = True
        Me.LabelValueDebugF.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelValueDebugF.Location = New System.Drawing.Point(1106, 386)
        Me.LabelValueDebugF.Margin = New System.Windows.Forms.Padding(0)
        Me.LabelValueDebugF.Name = "LabelValueDebugF"
        Me.LabelValueDebugF.Size = New System.Drawing.Size(84, 16)
        Me.LabelValueDebugF.TabIndex = 256
        Me.LabelValueDebugF.Text = "ValueDebug"
        '
        'LabelValueDebugE
        '
        Me.LabelValueDebugE.AutoSize = True
        Me.LabelValueDebugE.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelValueDebugE.Location = New System.Drawing.Point(1106, 370)
        Me.LabelValueDebugE.Margin = New System.Windows.Forms.Padding(0)
        Me.LabelValueDebugE.Name = "LabelValueDebugE"
        Me.LabelValueDebugE.Size = New System.Drawing.Size(84, 16)
        Me.LabelValueDebugE.TabIndex = 255
        Me.LabelValueDebugE.Text = "ValueDebug"
        '
        'LabelValueDebugD
        '
        Me.LabelValueDebugD.AutoSize = True
        Me.LabelValueDebugD.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelValueDebugD.Location = New System.Drawing.Point(1106, 354)
        Me.LabelValueDebugD.Margin = New System.Windows.Forms.Padding(0)
        Me.LabelValueDebugD.Name = "LabelValueDebugD"
        Me.LabelValueDebugD.Size = New System.Drawing.Size(84, 16)
        Me.LabelValueDebugD.TabIndex = 254
        Me.LabelValueDebugD.Text = "ValueDebug"
        '
        'LabelValueDebugC
        '
        Me.LabelValueDebugC.AutoSize = True
        Me.LabelValueDebugC.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelValueDebugC.Location = New System.Drawing.Point(1106, 338)
        Me.LabelValueDebugC.Margin = New System.Windows.Forms.Padding(0)
        Me.LabelValueDebugC.Name = "LabelValueDebugC"
        Me.LabelValueDebugC.Size = New System.Drawing.Size(84, 16)
        Me.LabelValueDebugC.TabIndex = 253
        Me.LabelValueDebugC.Text = "ValueDebug"
        '
        'LabelValueDebugB
        '
        Me.LabelValueDebugB.AutoSize = True
        Me.LabelValueDebugB.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelValueDebugB.Location = New System.Drawing.Point(1106, 322)
        Me.LabelValueDebugB.Margin = New System.Windows.Forms.Padding(0)
        Me.LabelValueDebugB.Name = "LabelValueDebugB"
        Me.LabelValueDebugB.Size = New System.Drawing.Size(84, 16)
        Me.LabelValueDebugB.TabIndex = 252
        Me.LabelValueDebugB.Text = "ValueDebug"
        '
        'LabelValueDebugA
        '
        Me.LabelValueDebugA.AutoSize = True
        Me.LabelValueDebugA.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelValueDebugA.Location = New System.Drawing.Point(1106, 306)
        Me.LabelValueDebugA.Margin = New System.Windows.Forms.Padding(0)
        Me.LabelValueDebugA.Name = "LabelValueDebugA"
        Me.LabelValueDebugA.Size = New System.Drawing.Size(84, 16)
        Me.LabelValueDebugA.TabIndex = 251
        Me.LabelValueDebugA.Text = "ValueDebug"
        '
        'LabelValueDebug9
        '
        Me.LabelValueDebug9.AutoSize = True
        Me.LabelValueDebug9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelValueDebug9.Location = New System.Drawing.Point(1106, 290)
        Me.LabelValueDebug9.Margin = New System.Windows.Forms.Padding(0)
        Me.LabelValueDebug9.Name = "LabelValueDebug9"
        Me.LabelValueDebug9.Size = New System.Drawing.Size(84, 16)
        Me.LabelValueDebug9.TabIndex = 250
        Me.LabelValueDebug9.Text = "ValueDebug"
        '
        'LabelValueDebug8
        '
        Me.LabelValueDebug8.AutoSize = True
        Me.LabelValueDebug8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelValueDebug8.Location = New System.Drawing.Point(1106, 274)
        Me.LabelValueDebug8.Margin = New System.Windows.Forms.Padding(0)
        Me.LabelValueDebug8.Name = "LabelValueDebug8"
        Me.LabelValueDebug8.Size = New System.Drawing.Size(84, 16)
        Me.LabelValueDebug8.TabIndex = 249
        Me.LabelValueDebug8.Text = "ValueDebug"
        '
        'LabelValueDebug7
        '
        Me.LabelValueDebug7.AutoSize = True
        Me.LabelValueDebug7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelValueDebug7.Location = New System.Drawing.Point(1106, 258)
        Me.LabelValueDebug7.Margin = New System.Windows.Forms.Padding(0)
        Me.LabelValueDebug7.Name = "LabelValueDebug7"
        Me.LabelValueDebug7.Size = New System.Drawing.Size(84, 16)
        Me.LabelValueDebug7.TabIndex = 248
        Me.LabelValueDebug7.Text = "ValueDebug"
        '
        'LabelValueDebug6
        '
        Me.LabelValueDebug6.AutoSize = True
        Me.LabelValueDebug6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelValueDebug6.Location = New System.Drawing.Point(1106, 242)
        Me.LabelValueDebug6.Margin = New System.Windows.Forms.Padding(0)
        Me.LabelValueDebug6.Name = "LabelValueDebug6"
        Me.LabelValueDebug6.Size = New System.Drawing.Size(84, 16)
        Me.LabelValueDebug6.TabIndex = 247
        Me.LabelValueDebug6.Text = "ValueDebug"
        '
        'LabelValueDebug5
        '
        Me.LabelValueDebug5.AutoSize = True
        Me.LabelValueDebug5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelValueDebug5.Location = New System.Drawing.Point(1106, 226)
        Me.LabelValueDebug5.Margin = New System.Windows.Forms.Padding(0)
        Me.LabelValueDebug5.Name = "LabelValueDebug5"
        Me.LabelValueDebug5.Size = New System.Drawing.Size(84, 16)
        Me.LabelValueDebug5.TabIndex = 246
        Me.LabelValueDebug5.Text = "ValueDebug"
        '
        'LabelValueDebug4
        '
        Me.LabelValueDebug4.AutoSize = True
        Me.LabelValueDebug4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelValueDebug4.Location = New System.Drawing.Point(1106, 210)
        Me.LabelValueDebug4.Margin = New System.Windows.Forms.Padding(0)
        Me.LabelValueDebug4.Name = "LabelValueDebug4"
        Me.LabelValueDebug4.Size = New System.Drawing.Size(84, 16)
        Me.LabelValueDebug4.TabIndex = 245
        Me.LabelValueDebug4.Text = "ValueDebug"
        '
        'LabelValueDebug3
        '
        Me.LabelValueDebug3.AutoSize = True
        Me.LabelValueDebug3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelValueDebug3.Location = New System.Drawing.Point(1106, 194)
        Me.LabelValueDebug3.Margin = New System.Windows.Forms.Padding(0)
        Me.LabelValueDebug3.Name = "LabelValueDebug3"
        Me.LabelValueDebug3.Size = New System.Drawing.Size(84, 16)
        Me.LabelValueDebug3.TabIndex = 244
        Me.LabelValueDebug3.Text = "ValueDebug"
        '
        'LabelValueDebug2
        '
        Me.LabelValueDebug2.AutoSize = True
        Me.LabelValueDebug2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelValueDebug2.Location = New System.Drawing.Point(1106, 178)
        Me.LabelValueDebug2.Margin = New System.Windows.Forms.Padding(0)
        Me.LabelValueDebug2.Name = "LabelValueDebug2"
        Me.LabelValueDebug2.Size = New System.Drawing.Size(84, 16)
        Me.LabelValueDebug2.TabIndex = 243
        Me.LabelValueDebug2.Text = "ValueDebug"
        '
        'LabelValueDebug1
        '
        Me.LabelValueDebug1.AutoSize = True
        Me.LabelValueDebug1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelValueDebug1.Location = New System.Drawing.Point(1106, 162)
        Me.LabelValueDebug1.Margin = New System.Windows.Forms.Padding(0)
        Me.LabelValueDebug1.Name = "LabelValueDebug1"
        Me.LabelValueDebug1.Size = New System.Drawing.Size(84, 16)
        Me.LabelValueDebug1.TabIndex = 242
        Me.LabelValueDebug1.Text = "ValueDebug"
        '
        'LabelValueDebug0
        '
        Me.LabelValueDebug0.AutoSize = True
        Me.LabelValueDebug0.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelValueDebug0.Location = New System.Drawing.Point(1106, 146)
        Me.LabelValueDebug0.Margin = New System.Windows.Forms.Padding(0)
        Me.LabelValueDebug0.Name = "LabelValueDebug0"
        Me.LabelValueDebug0.Size = New System.Drawing.Size(84, 16)
        Me.LabelValueDebug0.TabIndex = 241
        Me.LabelValueDebug0.Text = "ValueDebug"
        '
        'LabelValue10
        '
        Me.LabelValue10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelValue10.Location = New System.Drawing.Point(651, 247)
        Me.LabelValue10.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.LabelValue10.Name = "LabelValue10"
        Me.LabelValue10.Size = New System.Drawing.Size(200, 16)
        Me.LabelValue10.TabIndex = 234
        Me.LabelValue10.Text = "Label Value 10"
        Me.LabelValue10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LabelValue9
        '
        Me.LabelValue9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelValue9.Location = New System.Drawing.Point(651, 221)
        Me.LabelValue9.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.LabelValue9.Name = "LabelValue9"
        Me.LabelValue9.Size = New System.Drawing.Size(200, 16)
        Me.LabelValue9.TabIndex = 233
        Me.LabelValue9.Text = "Label Value 9"
        Me.LabelValue9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LabelFirmwareVerssion
        '
        Me.LabelFirmwareVerssion.AutoSize = True
        Me.LabelFirmwareVerssion.Location = New System.Drawing.Point(296, 64)
        Me.LabelFirmwareVerssion.Name = "LabelFirmwareVerssion"
        Me.LabelFirmwareVerssion.Size = New System.Drawing.Size(49, 13)
        Me.LabelFirmwareVerssion.TabIndex = 193
        Me.LabelFirmwareVerssion.Text = "Firmware"
        '
        'LabelValue8
        '
        Me.LabelValue8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelValue8.Location = New System.Drawing.Point(651, 195)
        Me.LabelValue8.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.LabelValue8.Name = "LabelValue8"
        Me.LabelValue8.Size = New System.Drawing.Size(200, 16)
        Me.LabelValue8.TabIndex = 232
        Me.LabelValue8.Text = "Label Value 8"
        Me.LabelValue8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LabelAgileInfo
        '
        Me.LabelAgileInfo.AutoSize = True
        Me.LabelAgileInfo.Location = New System.Drawing.Point(296, 49)
        Me.LabelAgileInfo.Name = "LabelAgileInfo"
        Me.LabelAgileInfo.Size = New System.Drawing.Size(51, 13)
        Me.LabelAgileInfo.TabIndex = 192
        Me.LabelAgileInfo.Text = "Agile Info"
        '
        'LabelValue7
        '
        Me.LabelValue7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelValue7.Location = New System.Drawing.Point(651, 169)
        Me.LabelValue7.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.LabelValue7.Name = "LabelValue7"
        Me.LabelValue7.Size = New System.Drawing.Size(200, 16)
        Me.LabelValue7.TabIndex = 231
        Me.LabelValue7.Text = "Label Value 7"
        Me.LabelValue7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LabelErrorReserved1
        '
        Me.LabelErrorReserved1.AutoSize = True
        Me.LabelErrorReserved1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelErrorReserved1.Location = New System.Drawing.Point(297, 562)
        Me.LabelErrorReserved1.Name = "LabelErrorReserved1"
        Me.LabelErrorReserved1.Size = New System.Drawing.Size(71, 16)
        Me.LabelErrorReserved1.TabIndex = 190
        Me.LabelErrorReserved1.Text = "LabelError"
        '
        'LabelValue6
        '
        Me.LabelValue6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelValue6.Location = New System.Drawing.Point(651, 143)
        Me.LabelValue6.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.LabelValue6.Name = "LabelValue6"
        Me.LabelValue6.Size = New System.Drawing.Size(200, 16)
        Me.LabelValue6.TabIndex = 230
        Me.LabelValue6.Text = "Label Value 6"
        Me.LabelValue6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LabelErrorReserved0
        '
        Me.LabelErrorReserved0.AutoSize = True
        Me.LabelErrorReserved0.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelErrorReserved0.Location = New System.Drawing.Point(297, 546)
        Me.LabelErrorReserved0.Name = "LabelErrorReserved0"
        Me.LabelErrorReserved0.Size = New System.Drawing.Size(71, 16)
        Me.LabelErrorReserved0.TabIndex = 189
        Me.LabelErrorReserved0.Text = "LabelError"
        '
        'LabelValue5
        '
        Me.LabelValue5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelValue5.Location = New System.Drawing.Point(651, 117)
        Me.LabelValue5.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.LabelValue5.Name = "LabelValue5"
        Me.LabelValue5.Size = New System.Drawing.Size(200, 16)
        Me.LabelValue5.TabIndex = 229
        Me.LabelValue5.Text = "Label Value 5"
        Me.LabelValue5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LabelErrorSelfTestResultRegister
        '
        Me.LabelErrorSelfTestResultRegister.AutoSize = True
        Me.LabelErrorSelfTestResultRegister.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelErrorSelfTestResultRegister.Location = New System.Drawing.Point(297, 530)
        Me.LabelErrorSelfTestResultRegister.Name = "LabelErrorSelfTestResultRegister"
        Me.LabelErrorSelfTestResultRegister.Size = New System.Drawing.Size(71, 16)
        Me.LabelErrorSelfTestResultRegister.TabIndex = 188
        Me.LabelErrorSelfTestResultRegister.Text = "LabelError"
        '
        'LabelValue4
        '
        Me.LabelValue4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelValue4.Location = New System.Drawing.Point(651, 91)
        Me.LabelValue4.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.LabelValue4.Name = "LabelValue4"
        Me.LabelValue4.Size = New System.Drawing.Size(200, 16)
        Me.LabelValue4.TabIndex = 228
        Me.LabelValue4.Text = "Label Value 4"
        Me.LabelValue4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LabelErrorResetCount
        '
        Me.LabelErrorResetCount.AutoSize = True
        Me.LabelErrorResetCount.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelErrorResetCount.Location = New System.Drawing.Point(297, 514)
        Me.LabelErrorResetCount.Name = "LabelErrorResetCount"
        Me.LabelErrorResetCount.Size = New System.Drawing.Size(71, 16)
        Me.LabelErrorResetCount.TabIndex = 187
        Me.LabelErrorResetCount.Text = "LabelError"
        '
        'LabelValue3
        '
        Me.LabelValue3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelValue3.Location = New System.Drawing.Point(651, 65)
        Me.LabelValue3.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.LabelValue3.Name = "LabelValue3"
        Me.LabelValue3.Size = New System.Drawing.Size(200, 16)
        Me.LabelValue3.TabIndex = 227
        Me.LabelValue3.Text = "Label Value 3"
        Me.LabelValue3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LabelErrorScaleCount
        '
        Me.LabelErrorScaleCount.AutoSize = True
        Me.LabelErrorScaleCount.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelErrorScaleCount.Location = New System.Drawing.Point(297, 498)
        Me.LabelErrorScaleCount.Name = "LabelErrorScaleCount"
        Me.LabelErrorScaleCount.Size = New System.Drawing.Size(71, 16)
        Me.LabelErrorScaleCount.TabIndex = 186
        Me.LabelErrorScaleCount.Text = "LabelError"
        '
        'LabelValue2
        '
        Me.LabelValue2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelValue2.Location = New System.Drawing.Point(651, 39)
        Me.LabelValue2.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.LabelValue2.Name = "LabelValue2"
        Me.LabelValue2.Size = New System.Drawing.Size(200, 16)
        Me.LabelValue2.TabIndex = 226
        Me.LabelValue2.Text = "Label Value 2"
        Me.LabelValue2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LabelValue1
        '
        Me.LabelValue1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelValue1.Location = New System.Drawing.Point(651, 13)
        Me.LabelValue1.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.LabelValue1.Name = "LabelValue1"
        Me.LabelValue1.Size = New System.Drawing.Size(200, 16)
        Me.LabelValue1.TabIndex = 222
        Me.LabelValue1.Text = "Label Value 1"
        Me.LabelValue1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LabelErrorSPIBusCount
        '
        Me.LabelErrorSPIBusCount.AutoSize = True
        Me.LabelErrorSPIBusCount.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelErrorSPIBusCount.Location = New System.Drawing.Point(297, 483)
        Me.LabelErrorSPIBusCount.Name = "LabelErrorSPIBusCount"
        Me.LabelErrorSPIBusCount.Size = New System.Drawing.Size(71, 16)
        Me.LabelErrorSPIBusCount.TabIndex = 184
        Me.LabelErrorSPIBusCount.Text = "LabelError"
        '
        'ButtonUpdateInput2
        '
        Me.ButtonUpdateInput2.Location = New System.Drawing.Point(963, 35)
        Me.ButtonUpdateInput2.Name = "ButtonUpdateInput2"
        Me.ButtonUpdateInput2.Size = New System.Drawing.Size(100, 23)
        Me.ButtonUpdateInput2.TabIndex = 225
        Me.ButtonUpdateInput2.Text = "Update Input 2"
        Me.ButtonUpdateInput2.UseVisualStyleBackColor = True
        '
        'LabelErrorI2CBusCount
        '
        Me.LabelErrorI2CBusCount.AutoSize = True
        Me.LabelErrorI2CBusCount.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelErrorI2CBusCount.Location = New System.Drawing.Point(297, 466)
        Me.LabelErrorI2CBusCount.Name = "LabelErrorI2CBusCount"
        Me.LabelErrorI2CBusCount.Size = New System.Drawing.Size(71, 16)
        Me.LabelErrorI2CBusCount.TabIndex = 183
        Me.LabelErrorI2CBusCount.Text = "LabelError"
        '
        'ButtonUpdateInput1
        '
        Me.ButtonUpdateInput1.Location = New System.Drawing.Point(963, 9)
        Me.ButtonUpdateInput1.Name = "ButtonUpdateInput1"
        Me.ButtonUpdateInput1.Size = New System.Drawing.Size(100, 23)
        Me.ButtonUpdateInput1.TabIndex = 224
        Me.ButtonUpdateInput1.Text = "Update Input 1"
        Me.ButtonUpdateInput1.UseVisualStyleBackColor = True
        '
        'LabelDebugF
        '
        Me.LabelDebugF.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelDebugF.Location = New System.Drawing.Point(864, 386)
        Me.LabelDebugF.Margin = New System.Windows.Forms.Padding(0)
        Me.LabelDebugF.Name = "LabelDebugF"
        Me.LabelDebugF.Size = New System.Drawing.Size(200, 16)
        Me.LabelDebugF.TabIndex = 182
        Me.LabelDebugF.Text = "lbldebug"
        Me.LabelDebugF.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LabelDebugE
        '
        Me.LabelDebugE.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelDebugE.Location = New System.Drawing.Point(864, 370)
        Me.LabelDebugE.Margin = New System.Windows.Forms.Padding(0)
        Me.LabelDebugE.Name = "LabelDebugE"
        Me.LabelDebugE.Size = New System.Drawing.Size(200, 16)
        Me.LabelDebugE.TabIndex = 181
        Me.LabelDebugE.Text = "lbldebug"
        Me.LabelDebugE.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LabelDebugD
        '
        Me.LabelDebugD.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelDebugD.Location = New System.Drawing.Point(864, 354)
        Me.LabelDebugD.Margin = New System.Windows.Forms.Padding(0)
        Me.LabelDebugD.Name = "LabelDebugD"
        Me.LabelDebugD.Size = New System.Drawing.Size(200, 16)
        Me.LabelDebugD.TabIndex = 180
        Me.LabelDebugD.Text = "lbldebug"
        Me.LabelDebugD.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LabelDebugC
        '
        Me.LabelDebugC.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelDebugC.Location = New System.Drawing.Point(864, 338)
        Me.LabelDebugC.Margin = New System.Windows.Forms.Padding(0)
        Me.LabelDebugC.Name = "LabelDebugC"
        Me.LabelDebugC.Size = New System.Drawing.Size(200, 16)
        Me.LabelDebugC.TabIndex = 179
        Me.LabelDebugC.Text = "lbldebug"
        Me.LabelDebugC.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LabelDebugB
        '
        Me.LabelDebugB.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelDebugB.Location = New System.Drawing.Point(864, 322)
        Me.LabelDebugB.Margin = New System.Windows.Forms.Padding(0)
        Me.LabelDebugB.Name = "LabelDebugB"
        Me.LabelDebugB.Size = New System.Drawing.Size(200, 16)
        Me.LabelDebugB.TabIndex = 178
        Me.LabelDebugB.Text = "lbldebug"
        Me.LabelDebugB.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LabelDebugA
        '
        Me.LabelDebugA.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelDebugA.Location = New System.Drawing.Point(864, 306)
        Me.LabelDebugA.Margin = New System.Windows.Forms.Padding(0)
        Me.LabelDebugA.Name = "LabelDebugA"
        Me.LabelDebugA.Size = New System.Drawing.Size(200, 16)
        Me.LabelDebugA.TabIndex = 177
        Me.LabelDebugA.Text = "lbldebug"
        Me.LabelDebugA.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TextBoxInput1
        '
        Me.TextBoxInput1.Location = New System.Drawing.Point(857, 12)
        Me.TextBoxInput1.MaxLength = 7
        Me.TextBoxInput1.Name = "TextBoxInput1"
        Me.TextBoxInput1.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxInput1.TabIndex = 206
        '
        'LabelDebug9
        '
        Me.LabelDebug9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelDebug9.Location = New System.Drawing.Point(864, 290)
        Me.LabelDebug9.Margin = New System.Windows.Forms.Padding(0)
        Me.LabelDebug9.Name = "LabelDebug9"
        Me.LabelDebug9.Size = New System.Drawing.Size(200, 16)
        Me.LabelDebug9.TabIndex = 176
        Me.LabelDebug9.Text = "lbldebug"
        Me.LabelDebug9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TextBoxInput2
        '
        Me.TextBoxInput2.Location = New System.Drawing.Point(857, 38)
        Me.TextBoxInput2.MaxLength = 7
        Me.TextBoxInput2.Name = "TextBoxInput2"
        Me.TextBoxInput2.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxInput2.TabIndex = 208
        '
        'LabelDebug8
        '
        Me.LabelDebug8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelDebug8.Location = New System.Drawing.Point(864, 274)
        Me.LabelDebug8.Margin = New System.Windows.Forms.Padding(0)
        Me.LabelDebug8.Name = "LabelDebug8"
        Me.LabelDebug8.Size = New System.Drawing.Size(200, 16)
        Me.LabelDebug8.TabIndex = 175
        Me.LabelDebug8.Text = "lbldebug"
        Me.LabelDebug8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LabelDebug7
        '
        Me.LabelDebug7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelDebug7.Location = New System.Drawing.Point(864, 258)
        Me.LabelDebug7.Margin = New System.Windows.Forms.Padding(0)
        Me.LabelDebug7.Name = "LabelDebug7"
        Me.LabelDebug7.Size = New System.Drawing.Size(200, 16)
        Me.LabelDebug7.TabIndex = 174
        Me.LabelDebug7.Text = "lbldebug"
        Me.LabelDebug7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LabelDebug6
        '
        Me.LabelDebug6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelDebug6.Location = New System.Drawing.Point(864, 242)
        Me.LabelDebug6.Margin = New System.Windows.Forms.Padding(0)
        Me.LabelDebug6.Name = "LabelDebug6"
        Me.LabelDebug6.Size = New System.Drawing.Size(200, 16)
        Me.LabelDebug6.TabIndex = 173
        Me.LabelDebug6.Text = "lbldebug"
        Me.LabelDebug6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LabelDebug5
        '
        Me.LabelDebug5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelDebug5.Location = New System.Drawing.Point(864, 226)
        Me.LabelDebug5.Margin = New System.Windows.Forms.Padding(0)
        Me.LabelDebug5.Name = "LabelDebug5"
        Me.LabelDebug5.Size = New System.Drawing.Size(200, 16)
        Me.LabelDebug5.TabIndex = 172
        Me.LabelDebug5.Text = "lbldebug"
        Me.LabelDebug5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LabelDebug4
        '
        Me.LabelDebug4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelDebug4.Location = New System.Drawing.Point(864, 210)
        Me.LabelDebug4.Margin = New System.Windows.Forms.Padding(0)
        Me.LabelDebug4.Name = "LabelDebug4"
        Me.LabelDebug4.Size = New System.Drawing.Size(200, 16)
        Me.LabelDebug4.TabIndex = 171
        Me.LabelDebug4.Text = "lbldebug"
        Me.LabelDebug4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LabelDebug3
        '
        Me.LabelDebug3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelDebug3.Location = New System.Drawing.Point(864, 194)
        Me.LabelDebug3.Margin = New System.Windows.Forms.Padding(0)
        Me.LabelDebug3.Name = "LabelDebug3"
        Me.LabelDebug3.Size = New System.Drawing.Size(200, 16)
        Me.LabelDebug3.TabIndex = 170
        Me.LabelDebug3.Text = "lbldebug"
        Me.LabelDebug3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LabelDebug2
        '
        Me.LabelDebug2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelDebug2.Location = New System.Drawing.Point(864, 178)
        Me.LabelDebug2.Margin = New System.Windows.Forms.Padding(0)
        Me.LabelDebug2.Name = "LabelDebug2"
        Me.LabelDebug2.Size = New System.Drawing.Size(200, 16)
        Me.LabelDebug2.TabIndex = 169
        Me.LabelDebug2.Text = "lbldebug"
        Me.LabelDebug2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LabelDebug1
        '
        Me.LabelDebug1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelDebug1.Location = New System.Drawing.Point(864, 162)
        Me.LabelDebug1.Margin = New System.Windows.Forms.Padding(0)
        Me.LabelDebug1.Name = "LabelDebug1"
        Me.LabelDebug1.Size = New System.Drawing.Size(200, 16)
        Me.LabelDebug1.TabIndex = 168
        Me.LabelDebug1.Text = "lbldebug"
        Me.LabelDebug1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LabelDebug0
        '
        Me.LabelDebug0.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelDebug0.Location = New System.Drawing.Point(864, 146)
        Me.LabelDebug0.Margin = New System.Windows.Forms.Padding(0)
        Me.LabelDebug0.Name = "LabelDebug0"
        Me.LabelDebug0.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.LabelDebug0.Size = New System.Drawing.Size(200, 16)
        Me.LabelDebug0.TabIndex = 167
        Me.LabelDebug0.Text = "lbldebug"
        Me.LabelDebug0.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LabelCanTimeoutCount
        '
        Me.LabelCanTimeoutCount.AutoSize = True
        Me.LabelCanTimeoutCount.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelCanTimeoutCount.Location = New System.Drawing.Point(480, 578)
        Me.LabelCanTimeoutCount.Name = "LabelCanTimeoutCount"
        Me.LabelCanTimeoutCount.Size = New System.Drawing.Size(66, 16)
        Me.LabelCanTimeoutCount.TabIndex = 166
        Me.LabelCanTimeoutCount.Text = "LabelCan"
        '
        'LabelCAnDataLogRXBufferOVerflowCount
        '
        Me.LabelCAnDataLogRXBufferOVerflowCount.AutoSize = True
        Me.LabelCAnDataLogRXBufferOVerflowCount.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelCAnDataLogRXBufferOVerflowCount.Location = New System.Drawing.Point(480, 562)
        Me.LabelCAnDataLogRXBufferOVerflowCount.Name = "LabelCAnDataLogRXBufferOVerflowCount"
        Me.LabelCAnDataLogRXBufferOVerflowCount.Size = New System.Drawing.Size(66, 16)
        Me.LabelCAnDataLogRXBufferOVerflowCount.TabIndex = 165
        Me.LabelCAnDataLogRXBufferOVerflowCount.Text = "LabelCan"
        '
        'LabelCanRXBufferOverflowCount
        '
        Me.LabelCanRXBufferOverflowCount.AutoSize = True
        Me.LabelCanRXBufferOverflowCount.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelCanRXBufferOverflowCount.Location = New System.Drawing.Point(480, 546)
        Me.LabelCanRXBufferOverflowCount.Name = "LabelCanRXBufferOverflowCount"
        Me.LabelCanRXBufferOverflowCount.Size = New System.Drawing.Size(66, 16)
        Me.LabelCanRXBufferOverflowCount.TabIndex = 164
        Me.LabelCanRXBufferOverflowCount.Text = "LabelCan"
        '
        'LabelCanTXBufOverflowCount
        '
        Me.LabelCanTXBufOverflowCount.AutoSize = True
        Me.LabelCanTXBufOverflowCount.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelCanTXBufOverflowCount.Location = New System.Drawing.Point(480, 530)
        Me.LabelCanTXBufOverflowCount.Name = "LabelCanTXBufOverflowCount"
        Me.LabelCanTXBufOverflowCount.Size = New System.Drawing.Size(66, 16)
        Me.LabelCanTXBufOverflowCount.TabIndex = 163
        Me.LabelCanTXBufOverflowCount.Text = "LabelCan"
        '
        'LabelCanTX0Count
        '
        Me.LabelCanTX0Count.AutoSize = True
        Me.LabelCanTX0Count.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelCanTX0Count.Location = New System.Drawing.Point(480, 514)
        Me.LabelCanTX0Count.Name = "LabelCanTX0Count"
        Me.LabelCanTX0Count.Size = New System.Drawing.Size(66, 16)
        Me.LabelCanTX0Count.TabIndex = 162
        Me.LabelCanTX0Count.Text = "LabelCan"
        '
        'LabelCanAddressErrorCount
        '
        Me.LabelCanAddressErrorCount.AutoSize = True
        Me.LabelCanAddressErrorCount.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelCanAddressErrorCount.Location = New System.Drawing.Point(480, 498)
        Me.LabelCanAddressErrorCount.Name = "LabelCanAddressErrorCount"
        Me.LabelCanAddressErrorCount.Size = New System.Drawing.Size(66, 16)
        Me.LabelCanAddressErrorCount.TabIndex = 161
        Me.LabelCanAddressErrorCount.Text = "LabelCan"
        '
        'LabelCanInvalidIndexCount
        '
        Me.LabelCanInvalidIndexCount.AutoSize = True
        Me.LabelCanInvalidIndexCount.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelCanInvalidIndexCount.Location = New System.Drawing.Point(480, 482)
        Me.LabelCanInvalidIndexCount.Name = "LabelCanInvalidIndexCount"
        Me.LabelCanInvalidIndexCount.Size = New System.Drawing.Size(66, 16)
        Me.LabelCanInvalidIndexCount.TabIndex = 160
        Me.LabelCanInvalidIndexCount.Text = "LabelCan"
        '
        'LabelCanUnknownIdentifierCount
        '
        Me.LabelCanUnknownIdentifierCount.AutoSize = True
        Me.LabelCanUnknownIdentifierCount.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelCanUnknownIdentifierCount.Location = New System.Drawing.Point(480, 466)
        Me.LabelCanUnknownIdentifierCount.Name = "LabelCanUnknownIdentifierCount"
        Me.LabelCanUnknownIdentifierCount.Size = New System.Drawing.Size(66, 16)
        Me.LabelCanUnknownIdentifierCount.TabIndex = 159
        Me.LabelCanUnknownIdentifierCount.Text = "LabelCan"
        '
        'LabelCanISREnteredCount
        '
        Me.LabelCanISREnteredCount.AutoSize = True
        Me.LabelCanISREnteredCount.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelCanISREnteredCount.Location = New System.Drawing.Point(480, 450)
        Me.LabelCanISREnteredCount.Name = "LabelCanISREnteredCount"
        Me.LabelCanISREnteredCount.Size = New System.Drawing.Size(66, 16)
        Me.LabelCanISREnteredCount.TabIndex = 158
        Me.LabelCanISREnteredCount.Text = "LabelCan"
        '
        'LabelCanRX1Filt2Count
        '
        Me.LabelCanRX1Filt2Count.AutoSize = True
        Me.LabelCanRX1Filt2Count.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelCanRX1Filt2Count.Location = New System.Drawing.Point(480, 434)
        Me.LabelCanRX1Filt2Count.Name = "LabelCanRX1Filt2Count"
        Me.LabelCanRX1Filt2Count.Size = New System.Drawing.Size(66, 16)
        Me.LabelCanRX1Filt2Count.TabIndex = 157
        Me.LabelCanRX1Filt2Count.Text = "LabelCan"
        '
        'LabelCanRX0Filt1Count
        '
        Me.LabelCanRX0Filt1Count.AutoSize = True
        Me.LabelCanRX0Filt1Count.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelCanRX0Filt1Count.Location = New System.Drawing.Point(480, 418)
        Me.LabelCanRX0Filt1Count.Name = "LabelCanRX0Filt1Count"
        Me.LabelCanRX0Filt1Count.Size = New System.Drawing.Size(66, 16)
        Me.LabelCanRX0Filt1Count.TabIndex = 156
        Me.LabelCanRX0Filt1Count.Text = "LabelCan"
        '
        'LabelCanRX0Filt0Count
        '
        Me.LabelCanRX0Filt0Count.AutoSize = True
        Me.LabelCanRX0Filt0Count.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelCanRX0Filt0Count.Location = New System.Drawing.Point(480, 402)
        Me.LabelCanRX0Filt0Count.Name = "LabelCanRX0Filt0Count"
        Me.LabelCanRX0Filt0Count.Size = New System.Drawing.Size(66, 16)
        Me.LabelCanRX0Filt0Count.TabIndex = 155
        Me.LabelCanRX0Filt0Count.Text = "LabelCan"
        '
        'LabelCanTX2Count
        '
        Me.LabelCanTX2Count.AutoSize = True
        Me.LabelCanTX2Count.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelCanTX2Count.Location = New System.Drawing.Point(480, 386)
        Me.LabelCanTX2Count.Name = "LabelCanTX2Count"
        Me.LabelCanTX2Count.Size = New System.Drawing.Size(66, 16)
        Me.LabelCanTX2Count.TabIndex = 154
        Me.LabelCanTX2Count.Text = "LabelCan"
        '
        'LabelCanTX1Count
        '
        Me.LabelCanTX1Count.AutoSize = True
        Me.LabelCanTX1Count.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelCanTX1Count.Location = New System.Drawing.Point(480, 370)
        Me.LabelCanTX1Count.Name = "LabelCanTX1Count"
        Me.LabelCanTX1Count.Size = New System.Drawing.Size(66, 16)
        Me.LabelCanTX1Count.TabIndex = 153
        Me.LabelCanTX1Count.Text = "LabelCan"
        '
        'LabelCanErrorFlagCount
        '
        Me.LabelCanErrorFlagCount.AutoSize = True
        Me.LabelCanErrorFlagCount.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelCanErrorFlagCount.Location = New System.Drawing.Point(480, 354)
        Me.LabelCanErrorFlagCount.Name = "LabelCanErrorFlagCount"
        Me.LabelCanErrorFlagCount.Size = New System.Drawing.Size(66, 16)
        Me.LabelCanErrorFlagCount.TabIndex = 152
        Me.LabelCanErrorFlagCount.Text = "LabelCan"
        '
        'LabelCanCXECReg
        '
        Me.LabelCanCXECReg.AutoSize = True
        Me.LabelCanCXECReg.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelCanCXECReg.Location = New System.Drawing.Point(480, 338)
        Me.LabelCanCXECReg.Name = "LabelCanCXECReg"
        Me.LabelCanCXECReg.Size = New System.Drawing.Size(66, 16)
        Me.LabelCanCXECReg.TabIndex = 151
        Me.LabelCanCXECReg.Text = "LabelCan"
        '
        'CheckBoxFaultBitF
        '
        Me.CheckBoxFaultBitF.AutoSize = True
        Me.CheckBoxFaultBitF.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBoxFaultBitF.Location = New System.Drawing.Point(483, 314)
        Me.CheckBoxFaultBitF.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBoxFaultBitF.Name = "CheckBoxFaultBitF"
        Me.CheckBoxFaultBitF.Size = New System.Drawing.Size(85, 20)
        Me.CheckBoxFaultBitF.TabIndex = 142
        Me.CheckBoxFaultBitF.Text = "Fault Bit F"
        Me.CheckBoxFaultBitF.UseVisualStyleBackColor = True
        '
        'CheckBoxFaultBitE
        '
        Me.CheckBoxFaultBitE.AutoSize = True
        Me.CheckBoxFaultBitE.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBoxFaultBitE.Location = New System.Drawing.Point(483, 294)
        Me.CheckBoxFaultBitE.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBoxFaultBitE.Name = "CheckBoxFaultBitE"
        Me.CheckBoxFaultBitE.Size = New System.Drawing.Size(86, 20)
        Me.CheckBoxFaultBitE.TabIndex = 141
        Me.CheckBoxFaultBitE.Text = "Fault Bit E"
        Me.CheckBoxFaultBitE.UseVisualStyleBackColor = True
        '
        'CheckBoxFaultBitD
        '
        Me.CheckBoxFaultBitD.AutoSize = True
        Me.CheckBoxFaultBitD.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBoxFaultBitD.Location = New System.Drawing.Point(483, 274)
        Me.CheckBoxFaultBitD.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBoxFaultBitD.Name = "CheckBoxFaultBitD"
        Me.CheckBoxFaultBitD.Size = New System.Drawing.Size(87, 20)
        Me.CheckBoxFaultBitD.TabIndex = 140
        Me.CheckBoxFaultBitD.Text = "Fault Bit D"
        Me.CheckBoxFaultBitD.UseVisualStyleBackColor = True
        '
        'CheckBoxFaultBitC
        '
        Me.CheckBoxFaultBitC.AutoSize = True
        Me.CheckBoxFaultBitC.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBoxFaultBitC.Location = New System.Drawing.Point(483, 254)
        Me.CheckBoxFaultBitC.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBoxFaultBitC.Name = "CheckBoxFaultBitC"
        Me.CheckBoxFaultBitC.Size = New System.Drawing.Size(86, 20)
        Me.CheckBoxFaultBitC.TabIndex = 139
        Me.CheckBoxFaultBitC.Text = "Fault Bit C"
        Me.CheckBoxFaultBitC.UseVisualStyleBackColor = True
        '
        'CheckBoxFaultBitB
        '
        Me.CheckBoxFaultBitB.AutoSize = True
        Me.CheckBoxFaultBitB.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBoxFaultBitB.Location = New System.Drawing.Point(483, 232)
        Me.CheckBoxFaultBitB.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBoxFaultBitB.Name = "CheckBoxFaultBitB"
        Me.CheckBoxFaultBitB.Size = New System.Drawing.Size(86, 20)
        Me.CheckBoxFaultBitB.TabIndex = 138
        Me.CheckBoxFaultBitB.Text = "Fault Bit B"
        Me.CheckBoxFaultBitB.UseVisualStyleBackColor = True
        '
        'CheckBoxFaultBitA
        '
        Me.CheckBoxFaultBitA.AutoSize = True
        Me.CheckBoxFaultBitA.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBoxFaultBitA.Location = New System.Drawing.Point(483, 212)
        Me.CheckBoxFaultBitA.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBoxFaultBitA.Name = "CheckBoxFaultBitA"
        Me.CheckBoxFaultBitA.Size = New System.Drawing.Size(86, 20)
        Me.CheckBoxFaultBitA.TabIndex = 137
        Me.CheckBoxFaultBitA.Text = "Fault Bit A"
        Me.CheckBoxFaultBitA.UseVisualStyleBackColor = True
        '
        'CheckBoxFaultBit9
        '
        Me.CheckBoxFaultBit9.AutoSize = True
        Me.CheckBoxFaultBit9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBoxFaultBit9.Location = New System.Drawing.Point(483, 192)
        Me.CheckBoxFaultBit9.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBoxFaultBit9.Name = "CheckBoxFaultBit9"
        Me.CheckBoxFaultBit9.Size = New System.Drawing.Size(84, 20)
        Me.CheckBoxFaultBit9.TabIndex = 136
        Me.CheckBoxFaultBit9.Text = "Fault Bit 9"
        Me.CheckBoxFaultBit9.UseVisualStyleBackColor = True
        '
        'CheckBoxFaultBit8
        '
        Me.CheckBoxFaultBit8.AutoSize = True
        Me.CheckBoxFaultBit8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBoxFaultBit8.Location = New System.Drawing.Point(483, 172)
        Me.CheckBoxFaultBit8.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBoxFaultBit8.Name = "CheckBoxFaultBit8"
        Me.CheckBoxFaultBit8.Size = New System.Drawing.Size(84, 20)
        Me.CheckBoxFaultBit8.TabIndex = 135
        Me.CheckBoxFaultBit8.Text = "Fault Bit 8"
        Me.CheckBoxFaultBit8.UseVisualStyleBackColor = True
        '
        'CheckBoxFaultBit7
        '
        Me.CheckBoxFaultBit7.AutoSize = True
        Me.CheckBoxFaultBit7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBoxFaultBit7.Location = New System.Drawing.Point(483, 152)
        Me.CheckBoxFaultBit7.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBoxFaultBit7.Name = "CheckBoxFaultBit7"
        Me.CheckBoxFaultBit7.Size = New System.Drawing.Size(84, 20)
        Me.CheckBoxFaultBit7.TabIndex = 134
        Me.CheckBoxFaultBit7.Text = "Fault Bit 7"
        Me.CheckBoxFaultBit7.UseVisualStyleBackColor = True
        '
        'CheckBoxFaultBit6
        '
        Me.CheckBoxFaultBit6.AutoSize = True
        Me.CheckBoxFaultBit6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBoxFaultBit6.Location = New System.Drawing.Point(483, 132)
        Me.CheckBoxFaultBit6.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBoxFaultBit6.Name = "CheckBoxFaultBit6"
        Me.CheckBoxFaultBit6.Size = New System.Drawing.Size(84, 20)
        Me.CheckBoxFaultBit6.TabIndex = 133
        Me.CheckBoxFaultBit6.Text = "Fault Bit 6"
        Me.CheckBoxFaultBit6.UseVisualStyleBackColor = True
        '
        'CheckBoxFaultBit5
        '
        Me.CheckBoxFaultBit5.AutoSize = True
        Me.CheckBoxFaultBit5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBoxFaultBit5.Location = New System.Drawing.Point(483, 112)
        Me.CheckBoxFaultBit5.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBoxFaultBit5.Name = "CheckBoxFaultBit5"
        Me.CheckBoxFaultBit5.Size = New System.Drawing.Size(84, 20)
        Me.CheckBoxFaultBit5.TabIndex = 132
        Me.CheckBoxFaultBit5.Text = "Fault Bit 5"
        Me.CheckBoxFaultBit5.UseVisualStyleBackColor = True
        '
        'CheckBoxFaultBit4
        '
        Me.CheckBoxFaultBit4.AutoSize = True
        Me.CheckBoxFaultBit4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBoxFaultBit4.Location = New System.Drawing.Point(483, 92)
        Me.CheckBoxFaultBit4.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBoxFaultBit4.Name = "CheckBoxFaultBit4"
        Me.CheckBoxFaultBit4.Size = New System.Drawing.Size(84, 20)
        Me.CheckBoxFaultBit4.TabIndex = 131
        Me.CheckBoxFaultBit4.Text = "Fault Bit 4"
        Me.CheckBoxFaultBit4.UseVisualStyleBackColor = True
        '
        'CheckBoxFaultBit3
        '
        Me.CheckBoxFaultBit3.AutoSize = True
        Me.CheckBoxFaultBit3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBoxFaultBit3.Location = New System.Drawing.Point(483, 70)
        Me.CheckBoxFaultBit3.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBoxFaultBit3.Name = "CheckBoxFaultBit3"
        Me.CheckBoxFaultBit3.Size = New System.Drawing.Size(84, 20)
        Me.CheckBoxFaultBit3.TabIndex = 130
        Me.CheckBoxFaultBit3.Text = "Fault Bit 3"
        Me.CheckBoxFaultBit3.UseVisualStyleBackColor = True
        '
        'CheckBoxFaultBit2
        '
        Me.CheckBoxFaultBit2.AutoSize = True
        Me.CheckBoxFaultBit2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBoxFaultBit2.Location = New System.Drawing.Point(483, 50)
        Me.CheckBoxFaultBit2.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBoxFaultBit2.Name = "CheckBoxFaultBit2"
        Me.CheckBoxFaultBit2.Size = New System.Drawing.Size(84, 20)
        Me.CheckBoxFaultBit2.TabIndex = 129
        Me.CheckBoxFaultBit2.Text = "Fault Bit 2"
        Me.CheckBoxFaultBit2.UseVisualStyleBackColor = True
        '
        'CheckBoxFaultBit1
        '
        Me.CheckBoxFaultBit1.AutoSize = True
        Me.CheckBoxFaultBit1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBoxFaultBit1.Location = New System.Drawing.Point(483, 30)
        Me.CheckBoxFaultBit1.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBoxFaultBit1.Name = "CheckBoxFaultBit1"
        Me.CheckBoxFaultBit1.Size = New System.Drawing.Size(84, 20)
        Me.CheckBoxFaultBit1.TabIndex = 128
        Me.CheckBoxFaultBit1.Text = "Fault Bit 1"
        Me.CheckBoxFaultBit1.UseVisualStyleBackColor = True
        '
        'CheckBoxFaultBit0
        '
        Me.CheckBoxFaultBit0.AutoSize = True
        Me.CheckBoxFaultBit0.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBoxFaultBit0.Location = New System.Drawing.Point(483, 10)
        Me.CheckBoxFaultBit0.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBoxFaultBit0.Name = "CheckBoxFaultBit0"
        Me.CheckBoxFaultBit0.Size = New System.Drawing.Size(84, 20)
        Me.CheckBoxFaultBit0.TabIndex = 127
        Me.CheckBoxFaultBit0.Text = "Fault Bit 0"
        Me.CheckBoxFaultBit0.UseVisualStyleBackColor = True
        '
        'cboIndex
        '
        Me.cboIndex.FormattingEnabled = True
        Me.cboIndex.Items.AddRange(New Object() {"MODBUS_WR_HVLAMBDA " & Global.Microsoft.VisualBasic.ChrW(9), "MODBUS_WR_ION_PUMP", "MODBUS_WR_AFC", "MODBUS_WR_COOLING", "MODBUS_WR_HTR_MAGNET", "MODBUS_WR_GUN_DRIVER", "MODBUS_WR_MAGNETRON_CURRENT", "MODBUS_WR_PULSE_SYNC", "MODBUS_WR_ETHERNET"})
        Me.cboIndex.Location = New System.Drawing.Point(296, 9)
        Me.cboIndex.Name = "cboIndex"
        Me.cboIndex.Size = New System.Drawing.Size(171, 21)
        Me.cboIndex.TabIndex = 2
        Me.cboIndex.Text = "MODBUS_WR_HVLAMBDA " & Global.Microsoft.VisualBasic.ChrW(9)
        '
        'LabelBoardStatus
        '
        Me.LabelBoardStatus.AutoSize = True
        Me.LabelBoardStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelBoardStatus.Location = New System.Drawing.Point(296, 33)
        Me.LabelBoardStatus.Name = "LabelBoardStatus"
        Me.LabelBoardStatus.Size = New System.Drawing.Size(115, 16)
        Me.LabelBoardStatus.TabIndex = 152
        Me.LabelBoardStatus.Text = "Connection Status"
        '
        'TextBoxInput4
        '
        Me.TextBoxInput4.Location = New System.Drawing.Point(857, 90)
        Me.TextBoxInput4.MaxLength = 7
        Me.TextBoxInput4.Name = "TextBoxInput4"
        Me.TextBoxInput4.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxInput4.TabIndex = 308
        '
        'TextBoxInput5
        '
        Me.TextBoxInput5.Location = New System.Drawing.Point(857, 116)
        Me.TextBoxInput5.MaxLength = 7
        Me.TextBoxInput5.Name = "TextBoxInput5"
        Me.TextBoxInput5.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxInput5.TabIndex = 309
        '
        'ButtonUpdateInput4
        '
        Me.ButtonUpdateInput4.Location = New System.Drawing.Point(963, 87)
        Me.ButtonUpdateInput4.Name = "ButtonUpdateInput4"
        Me.ButtonUpdateInput4.Size = New System.Drawing.Size(100, 23)
        Me.ButtonUpdateInput4.TabIndex = 310
        Me.ButtonUpdateInput4.Text = "Update Input 4"
        Me.ButtonUpdateInput4.UseVisualStyleBackColor = True
        '
        'ButtonUpdateInput5
        '
        Me.ButtonUpdateInput5.Location = New System.Drawing.Point(963, 113)
        Me.ButtonUpdateInput5.Name = "ButtonUpdateInput5"
        Me.ButtonUpdateInput5.Size = New System.Drawing.Size(100, 23)
        Me.ButtonUpdateInput5.TabIndex = 311
        Me.ButtonUpdateInput5.Text = "Update Input 5"
        Me.ButtonUpdateInput5.UseVisualStyleBackColor = True
        '
        'Splitter1
        '
        Me.Splitter1.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Splitter1.Location = New System.Drawing.Point(0, 0)
        Me.Splitter1.Name = "Splitter1"
        Me.Splitter1.Size = New System.Drawing.Size(288, 609)
        Me.Splitter1.TabIndex = 322
        Me.Splitter1.TabStop = False
        '
        'LabelDisplay8
        '
        Me.LabelDisplay8.AutoSize = True
        Me.LabelDisplay8.BackColor = System.Drawing.Color.LightSteelBlue
        Me.LabelDisplay8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelDisplay8.Location = New System.Drawing.Point(12, 147)
        Me.LabelDisplay8.Name = "LabelDisplay8"
        Me.LabelDisplay8.Size = New System.Drawing.Size(64, 16)
        Me.LabelDisplay8.TabIndex = 330
        Me.LabelDisplay8.Text = "Display 8"
        '
        'LabelDisplay7
        '
        Me.LabelDisplay7.AutoSize = True
        Me.LabelDisplay7.BackColor = System.Drawing.Color.LightSteelBlue
        Me.LabelDisplay7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelDisplay7.Location = New System.Drawing.Point(12, 131)
        Me.LabelDisplay7.Name = "LabelDisplay7"
        Me.LabelDisplay7.Size = New System.Drawing.Size(64, 16)
        Me.LabelDisplay7.TabIndex = 329
        Me.LabelDisplay7.Text = "Display 7"
        '
        'LabelDisplay6
        '
        Me.LabelDisplay6.AutoSize = True
        Me.LabelDisplay6.BackColor = System.Drawing.Color.LightSteelBlue
        Me.LabelDisplay6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelDisplay6.Location = New System.Drawing.Point(12, 115)
        Me.LabelDisplay6.Name = "LabelDisplay6"
        Me.LabelDisplay6.Size = New System.Drawing.Size(64, 16)
        Me.LabelDisplay6.TabIndex = 328
        Me.LabelDisplay6.Text = "Display 6"
        '
        'LabelDisplay5
        '
        Me.LabelDisplay5.AutoSize = True
        Me.LabelDisplay5.BackColor = System.Drawing.Color.LightSteelBlue
        Me.LabelDisplay5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelDisplay5.Location = New System.Drawing.Point(12, 99)
        Me.LabelDisplay5.Name = "LabelDisplay5"
        Me.LabelDisplay5.Size = New System.Drawing.Size(64, 16)
        Me.LabelDisplay5.TabIndex = 327
        Me.LabelDisplay5.Text = "Display 5"
        '
        'LabelDisplay4
        '
        Me.LabelDisplay4.AutoSize = True
        Me.LabelDisplay4.BackColor = System.Drawing.Color.LightSteelBlue
        Me.LabelDisplay4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelDisplay4.Location = New System.Drawing.Point(12, 83)
        Me.LabelDisplay4.Name = "LabelDisplay4"
        Me.LabelDisplay4.Size = New System.Drawing.Size(64, 16)
        Me.LabelDisplay4.TabIndex = 326
        Me.LabelDisplay4.Text = "Display 4"
        '
        'LabelDisplay3
        '
        Me.LabelDisplay3.AutoSize = True
        Me.LabelDisplay3.BackColor = System.Drawing.Color.LightSteelBlue
        Me.LabelDisplay3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelDisplay3.Location = New System.Drawing.Point(12, 67)
        Me.LabelDisplay3.Name = "LabelDisplay3"
        Me.LabelDisplay3.Size = New System.Drawing.Size(64, 16)
        Me.LabelDisplay3.TabIndex = 325
        Me.LabelDisplay3.Text = "Display 3"
        '
        'LabelDisplay2
        '
        Me.LabelDisplay2.AutoSize = True
        Me.LabelDisplay2.BackColor = System.Drawing.Color.LightSteelBlue
        Me.LabelDisplay2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelDisplay2.Location = New System.Drawing.Point(12, 51)
        Me.LabelDisplay2.Name = "LabelDisplay2"
        Me.LabelDisplay2.Size = New System.Drawing.Size(64, 16)
        Me.LabelDisplay2.TabIndex = 324
        Me.LabelDisplay2.Text = "Display 2"
        '
        'LabelDisplay1
        '
        Me.LabelDisplay1.AutoSize = True
        Me.LabelDisplay1.BackColor = System.Drawing.Color.LightSteelBlue
        Me.LabelDisplay1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelDisplay1.Location = New System.Drawing.Point(12, 35)
        Me.LabelDisplay1.Name = "LabelDisplay1"
        Me.LabelDisplay1.Size = New System.Drawing.Size(64, 16)
        Me.LabelDisplay1.TabIndex = 323
        Me.LabelDisplay1.Text = "Display 1"
        '
        'CheckBoxOperateEthernet
        '
        Me.CheckBoxOperateEthernet.AutoSize = True
        Me.CheckBoxOperateEthernet.BackColor = System.Drawing.Color.LightSteelBlue
        Me.CheckBoxOperateEthernet.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBoxOperateEthernet.Location = New System.Drawing.Point(148, 316)
        Me.CheckBoxOperateEthernet.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBoxOperateEthernet.Name = "CheckBoxOperateEthernet"
        Me.CheckBoxOperateEthernet.Size = New System.Drawing.Size(15, 14)
        Me.CheckBoxOperateEthernet.TabIndex = 358
        Me.CheckBoxOperateEthernet.UseVisualStyleBackColor = False
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(12, 314)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(57, 16)
        Me.Label13.TabIndex = 357
        Me.Label13.Text = "Ethernet"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(145, 169)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(32, 16)
        Me.Label12.TabIndex = 356
        Me.Label12.Text = "FLT"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(103, 169)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(32, 16)
        Me.Label2.TabIndex = 355
        Me.Label2.Text = "FLT"
        '
        'CheckBoxOperatePulseSync
        '
        Me.CheckBoxOperatePulseSync.AutoSize = True
        Me.CheckBoxOperatePulseSync.BackColor = System.Drawing.Color.LightSteelBlue
        Me.CheckBoxOperatePulseSync.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBoxOperatePulseSync.Location = New System.Drawing.Point(148, 300)
        Me.CheckBoxOperatePulseSync.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBoxOperatePulseSync.Name = "CheckBoxOperatePulseSync"
        Me.CheckBoxOperatePulseSync.Size = New System.Drawing.Size(15, 14)
        Me.CheckBoxOperatePulseSync.TabIndex = 354
        Me.CheckBoxOperatePulseSync.UseVisualStyleBackColor = False
        '
        'CheckBoxOperateMagnetronCurrentMon
        '
        Me.CheckBoxOperateMagnetronCurrentMon.AutoSize = True
        Me.CheckBoxOperateMagnetronCurrentMon.BackColor = System.Drawing.Color.LightSteelBlue
        Me.CheckBoxOperateMagnetronCurrentMon.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBoxOperateMagnetronCurrentMon.Location = New System.Drawing.Point(148, 284)
        Me.CheckBoxOperateMagnetronCurrentMon.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBoxOperateMagnetronCurrentMon.Name = "CheckBoxOperateMagnetronCurrentMon"
        Me.CheckBoxOperateMagnetronCurrentMon.Size = New System.Drawing.Size(15, 14)
        Me.CheckBoxOperateMagnetronCurrentMon.TabIndex = 353
        Me.CheckBoxOperateMagnetronCurrentMon.UseVisualStyleBackColor = False
        '
        'CheckBoxOperateGunDriver
        '
        Me.CheckBoxOperateGunDriver.AutoSize = True
        Me.CheckBoxOperateGunDriver.BackColor = System.Drawing.Color.LightSteelBlue
        Me.CheckBoxOperateGunDriver.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBoxOperateGunDriver.Location = New System.Drawing.Point(148, 268)
        Me.CheckBoxOperateGunDriver.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBoxOperateGunDriver.Name = "CheckBoxOperateGunDriver"
        Me.CheckBoxOperateGunDriver.Size = New System.Drawing.Size(15, 14)
        Me.CheckBoxOperateGunDriver.TabIndex = 352
        Me.CheckBoxOperateGunDriver.UseVisualStyleBackColor = False
        '
        'CheckBoxOperateHtrMag
        '
        Me.CheckBoxOperateHtrMag.AutoSize = True
        Me.CheckBoxOperateHtrMag.BackColor = System.Drawing.Color.LightSteelBlue
        Me.CheckBoxOperateHtrMag.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBoxOperateHtrMag.Location = New System.Drawing.Point(148, 252)
        Me.CheckBoxOperateHtrMag.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBoxOperateHtrMag.Name = "CheckBoxOperateHtrMag"
        Me.CheckBoxOperateHtrMag.Size = New System.Drawing.Size(15, 14)
        Me.CheckBoxOperateHtrMag.TabIndex = 351
        Me.CheckBoxOperateHtrMag.UseVisualStyleBackColor = False
        '
        'CheckBoxOperateCooling
        '
        Me.CheckBoxOperateCooling.AutoSize = True
        Me.CheckBoxOperateCooling.BackColor = System.Drawing.Color.LightSteelBlue
        Me.CheckBoxOperateCooling.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBoxOperateCooling.Location = New System.Drawing.Point(148, 236)
        Me.CheckBoxOperateCooling.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBoxOperateCooling.Name = "CheckBoxOperateCooling"
        Me.CheckBoxOperateCooling.Size = New System.Drawing.Size(15, 14)
        Me.CheckBoxOperateCooling.TabIndex = 350
        Me.CheckBoxOperateCooling.UseVisualStyleBackColor = False
        '
        'CheckBoxOperateAFC
        '
        Me.CheckBoxOperateAFC.AutoSize = True
        Me.CheckBoxOperateAFC.BackColor = System.Drawing.Color.LightSteelBlue
        Me.CheckBoxOperateAFC.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBoxOperateAFC.Location = New System.Drawing.Point(148, 220)
        Me.CheckBoxOperateAFC.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBoxOperateAFC.Name = "CheckBoxOperateAFC"
        Me.CheckBoxOperateAFC.Size = New System.Drawing.Size(15, 14)
        Me.CheckBoxOperateAFC.TabIndex = 349
        Me.CheckBoxOperateAFC.UseVisualStyleBackColor = False
        '
        'CheckBoxOperateIonPump
        '
        Me.CheckBoxOperateIonPump.AutoSize = True
        Me.CheckBoxOperateIonPump.BackColor = System.Drawing.Color.LightSteelBlue
        Me.CheckBoxOperateIonPump.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBoxOperateIonPump.Location = New System.Drawing.Point(148, 204)
        Me.CheckBoxOperateIonPump.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBoxOperateIonPump.Name = "CheckBoxOperateIonPump"
        Me.CheckBoxOperateIonPump.Size = New System.Drawing.Size(15, 14)
        Me.CheckBoxOperateIonPump.TabIndex = 348
        Me.CheckBoxOperateIonPump.UseVisualStyleBackColor = False
        '
        'CheckBoxOperateHVLambda
        '
        Me.CheckBoxOperateHVLambda.AutoSize = True
        Me.CheckBoxOperateHVLambda.BackColor = System.Drawing.Color.LightSteelBlue
        Me.CheckBoxOperateHVLambda.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBoxOperateHVLambda.Location = New System.Drawing.Point(148, 188)
        Me.CheckBoxOperateHVLambda.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBoxOperateHVLambda.Name = "CheckBoxOperateHVLambda"
        Me.CheckBoxOperateHVLambda.Size = New System.Drawing.Size(15, 14)
        Me.CheckBoxOperateHVLambda.TabIndex = 347
        Me.CheckBoxOperateHVLambda.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 298)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(75, 16)
        Me.Label4.TabIndex = 346
        Me.Label4.Text = "Pulse Sync"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(12, 282)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(48, 16)
        Me.Label5.TabIndex = 345
        Me.Label5.Text = "I Pulse"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(12, 266)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(56, 16)
        Me.Label6.TabIndex = 344
        Me.Label6.Text = "Gun Dvr"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(12, 250)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(56, 16)
        Me.Label7.TabIndex = 343
        Me.Label7.Text = "Htr/Mag"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(12, 234)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(54, 16)
        Me.Label8.TabIndex = 342
        Me.Label8.Text = "Cooling"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(12, 218)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(34, 16)
        Me.Label9.TabIndex = 341
        Me.Label9.Text = "AFC"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(12, 202)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(64, 16)
        Me.Label10.TabIndex = 340
        Me.Label10.Text = "Ion Pump"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(12, 186)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(80, 16)
        Me.Label11.TabIndex = 339
        Me.Label11.Text = "HV Lambda"
        '
        'CheckBoxPulseSyncConnected
        '
        Me.CheckBoxPulseSyncConnected.AutoSize = True
        Me.CheckBoxPulseSyncConnected.BackColor = System.Drawing.Color.LightSteelBlue
        Me.CheckBoxPulseSyncConnected.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBoxPulseSyncConnected.Location = New System.Drawing.Point(106, 300)
        Me.CheckBoxPulseSyncConnected.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBoxPulseSyncConnected.Name = "CheckBoxPulseSyncConnected"
        Me.CheckBoxPulseSyncConnected.Size = New System.Drawing.Size(15, 14)
        Me.CheckBoxPulseSyncConnected.TabIndex = 338
        Me.CheckBoxPulseSyncConnected.UseVisualStyleBackColor = False
        '
        'CheckBoxPulseCurrentMonitorConnected
        '
        Me.CheckBoxPulseCurrentMonitorConnected.AutoSize = True
        Me.CheckBoxPulseCurrentMonitorConnected.BackColor = System.Drawing.Color.LightSteelBlue
        Me.CheckBoxPulseCurrentMonitorConnected.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBoxPulseCurrentMonitorConnected.Location = New System.Drawing.Point(106, 284)
        Me.CheckBoxPulseCurrentMonitorConnected.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBoxPulseCurrentMonitorConnected.Name = "CheckBoxPulseCurrentMonitorConnected"
        Me.CheckBoxPulseCurrentMonitorConnected.Size = New System.Drawing.Size(15, 14)
        Me.CheckBoxPulseCurrentMonitorConnected.TabIndex = 337
        Me.CheckBoxPulseCurrentMonitorConnected.UseVisualStyleBackColor = False
        '
        'CheckBoxGunDriverConnected
        '
        Me.CheckBoxGunDriverConnected.AutoSize = True
        Me.CheckBoxGunDriverConnected.BackColor = System.Drawing.Color.LightSteelBlue
        Me.CheckBoxGunDriverConnected.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBoxGunDriverConnected.Location = New System.Drawing.Point(106, 268)
        Me.CheckBoxGunDriverConnected.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBoxGunDriverConnected.Name = "CheckBoxGunDriverConnected"
        Me.CheckBoxGunDriverConnected.Size = New System.Drawing.Size(15, 14)
        Me.CheckBoxGunDriverConnected.TabIndex = 336
        Me.CheckBoxGunDriverConnected.UseVisualStyleBackColor = False
        '
        'CheckBoxHtrMagConnected
        '
        Me.CheckBoxHtrMagConnected.AutoSize = True
        Me.CheckBoxHtrMagConnected.BackColor = System.Drawing.Color.LightSteelBlue
        Me.CheckBoxHtrMagConnected.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBoxHtrMagConnected.Location = New System.Drawing.Point(106, 252)
        Me.CheckBoxHtrMagConnected.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBoxHtrMagConnected.Name = "CheckBoxHtrMagConnected"
        Me.CheckBoxHtrMagConnected.Size = New System.Drawing.Size(15, 14)
        Me.CheckBoxHtrMagConnected.TabIndex = 335
        Me.CheckBoxHtrMagConnected.UseVisualStyleBackColor = False
        '
        'CheckBoxCoolingConnected
        '
        Me.CheckBoxCoolingConnected.AutoSize = True
        Me.CheckBoxCoolingConnected.BackColor = System.Drawing.Color.LightSteelBlue
        Me.CheckBoxCoolingConnected.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBoxCoolingConnected.Location = New System.Drawing.Point(106, 236)
        Me.CheckBoxCoolingConnected.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBoxCoolingConnected.Name = "CheckBoxCoolingConnected"
        Me.CheckBoxCoolingConnected.Size = New System.Drawing.Size(15, 14)
        Me.CheckBoxCoolingConnected.TabIndex = 334
        Me.CheckBoxCoolingConnected.UseVisualStyleBackColor = False
        '
        'CheckBoxAFCConnected
        '
        Me.CheckBoxAFCConnected.AutoSize = True
        Me.CheckBoxAFCConnected.BackColor = System.Drawing.Color.LightSteelBlue
        Me.CheckBoxAFCConnected.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBoxAFCConnected.Location = New System.Drawing.Point(106, 220)
        Me.CheckBoxAFCConnected.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBoxAFCConnected.Name = "CheckBoxAFCConnected"
        Me.CheckBoxAFCConnected.Size = New System.Drawing.Size(15, 14)
        Me.CheckBoxAFCConnected.TabIndex = 333
        Me.CheckBoxAFCConnected.UseVisualStyleBackColor = False
        '
        'CheckBoxIonPumpConnected
        '
        Me.CheckBoxIonPumpConnected.AutoSize = True
        Me.CheckBoxIonPumpConnected.BackColor = System.Drawing.Color.LightSteelBlue
        Me.CheckBoxIonPumpConnected.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBoxIonPumpConnected.Location = New System.Drawing.Point(106, 204)
        Me.CheckBoxIonPumpConnected.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBoxIonPumpConnected.Name = "CheckBoxIonPumpConnected"
        Me.CheckBoxIonPumpConnected.Size = New System.Drawing.Size(15, 14)
        Me.CheckBoxIonPumpConnected.TabIndex = 332
        Me.CheckBoxIonPumpConnected.UseVisualStyleBackColor = False
        '
        'CheckBoxHVLambdaConnected
        '
        Me.CheckBoxHVLambdaConnected.AutoSize = True
        Me.CheckBoxHVLambdaConnected.BackColor = System.Drawing.Color.LightSteelBlue
        Me.CheckBoxHVLambdaConnected.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBoxHVLambdaConnected.Location = New System.Drawing.Point(106, 188)
        Me.CheckBoxHVLambdaConnected.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBoxHVLambdaConnected.Name = "CheckBoxHVLambdaConnected"
        Me.CheckBoxHVLambdaConnected.Size = New System.Drawing.Size(15, 14)
        Me.CheckBoxHVLambdaConnected.TabIndex = 331
        Me.CheckBoxHVLambdaConnected.UseVisualStyleBackColor = False
        '
        'LabelECBTime
        '
        Me.LabelECBTime.AutoSize = True
        Me.LabelECBTime.BackColor = System.Drawing.Color.LightSteelBlue
        Me.LabelECBTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelECBTime.Location = New System.Drawing.Point(12, 343)
        Me.LabelECBTime.Margin = New System.Windows.Forms.Padding(3)
        Me.LabelECBTime.Name = "LabelECBTime"
        Me.LabelECBTime.Size = New System.Drawing.Size(69, 16)
        Me.LabelECBTime.TabIndex = 364
        Me.LabelECBTime.Text = "ECB Time"
        '
        'LabelComputerTime
        '
        Me.LabelComputerTime.AutoSize = True
        Me.LabelComputerTime.BackColor = System.Drawing.Color.LightSteelBlue
        Me.LabelComputerTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelComputerTime.Location = New System.Drawing.Point(12, 431)
        Me.LabelComputerTime.Margin = New System.Windows.Forms.Padding(3)
        Me.LabelComputerTime.Name = "LabelComputerTime"
        Me.LabelComputerTime.Size = New System.Drawing.Size(100, 16)
        Me.LabelComputerTime.TabIndex = 363
        Me.LabelComputerTime.Text = "Computer Time"
        '
        'ButtonSetTime
        '
        Me.ButtonSetTime.BackColor = System.Drawing.Color.Lavender
        Me.ButtonSetTime.FlatAppearance.BorderSize = 0
        Me.ButtonSetTime.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonSetTime.Location = New System.Drawing.Point(15, 373)
        Me.ButtonSetTime.Name = "ButtonSetTime"
        Me.ButtonSetTime.Size = New System.Drawing.Size(100, 23)
        Me.ButtonSetTime.TabIndex = 362
        Me.ButtonSetTime.Text = "SetTime"
        Me.ButtonSetTime.UseVisualStyleBackColor = False
        '
        'ButtonStopLog
        '
        Me.ButtonStopLog.BackColor = System.Drawing.Color.Lavender
        Me.ButtonStopLog.FlatAppearance.BorderSize = 0
        Me.ButtonStopLog.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonStopLog.Location = New System.Drawing.Point(148, 402)
        Me.ButtonStopLog.Name = "ButtonStopLog"
        Me.ButtonStopLog.Size = New System.Drawing.Size(122, 23)
        Me.ButtonStopLog.TabIndex = 361
        Me.ButtonStopLog.Text = "Stop Pulse Logging"
        Me.ButtonStopLog.UseVisualStyleBackColor = False
        '
        'ButtonStartLog
        '
        Me.ButtonStartLog.BackColor = System.Drawing.Color.Lavender
        Me.ButtonStartLog.FlatAppearance.BorderSize = 0
        Me.ButtonStartLog.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonStartLog.Location = New System.Drawing.Point(15, 402)
        Me.ButtonStartLog.Name = "ButtonStartLog"
        Me.ButtonStartLog.Size = New System.Drawing.Size(122, 23)
        Me.ButtonStartLog.TabIndex = 360
        Me.ButtonStartLog.Text = "Start Pulse Logging"
        Me.ButtonStartLog.UseVisualStyleBackColor = False
        '
        'LabelECBState
        '
        Me.LabelECBState.AutoSize = True
        Me.LabelECBState.BackColor = System.Drawing.Color.LightSteelBlue
        Me.LabelECBState.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelECBState.Location = New System.Drawing.Point(12, 9)
        Me.LabelECBState.Margin = New System.Windows.Forms.Padding(3)
        Me.LabelECBState.Name = "LabelECBState"
        Me.LabelECBState.Size = New System.Drawing.Size(69, 16)
        Me.LabelECBState.TabIndex = 359
        Me.LabelECBState.Text = "ECB State"
        '
        'CheckBoxSyncBitF
        '
        Me.CheckBoxSyncBitF.AutoSize = True
        Me.CheckBoxSyncBitF.BackColor = System.Drawing.Color.LightSteelBlue
        Me.CheckBoxSyncBitF.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBoxSyncBitF.Location = New System.Drawing.Point(167, 617)
        Me.CheckBoxSyncBitF.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBoxSyncBitF.Name = "CheckBoxSyncBitF"
        Me.CheckBoxSyncBitF.Size = New System.Drawing.Size(121, 20)
        Me.CheckBoxSyncBitF.TabIndex = 389
        Me.CheckBoxSyncBitF.Text = "Clear Debug Bit"
        Me.CheckBoxSyncBitF.UseVisualStyleBackColor = False
        '
        'ButtonToggleResetDebug
        '
        Me.ButtonToggleResetDebug.BackColor = System.Drawing.Color.Lavender
        Me.ButtonToggleResetDebug.FlatAppearance.BorderSize = 0
        Me.ButtonToggleResetDebug.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonToggleResetDebug.Location = New System.Drawing.Point(12, 616)
        Me.ButtonToggleResetDebug.Name = "ButtonToggleResetDebug"
        Me.ButtonToggleResetDebug.Size = New System.Drawing.Size(152, 23)
        Me.ButtonToggleResetDebug.TabIndex = 388
        Me.ButtonToggleResetDebug.Text = "Toggle Reset Debug"
        Me.ButtonToggleResetDebug.UseVisualStyleBackColor = False
        '
        'CheckBoxSyncBit8
        '
        Me.CheckBoxSyncBit8.AutoSize = True
        Me.CheckBoxSyncBit8.BackColor = System.Drawing.Color.LightSteelBlue
        Me.CheckBoxSyncBit8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBoxSyncBit8.Location = New System.Drawing.Point(41, 662)
        Me.CheckBoxSyncBit8.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBoxSyncBit8.Name = "CheckBoxSyncBit8"
        Me.CheckBoxSyncBit8.Size = New System.Drawing.Size(74, 20)
        Me.CheckBoxSyncBit8.TabIndex = 387
        Me.CheckBoxSyncBit8.Text = "Unused"
        Me.CheckBoxSyncBit8.UseVisualStyleBackColor = False
        '
        'CheckBoxSyncBit7
        '
        Me.CheckBoxSyncBit7.AutoSize = True
        Me.CheckBoxSyncBit7.BackColor = System.Drawing.Color.LightSteelBlue
        Me.CheckBoxSyncBit7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBoxSyncBit7.Location = New System.Drawing.Point(41, 646)
        Me.CheckBoxSyncBit7.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBoxSyncBit7.Name = "CheckBoxSyncBit7"
        Me.CheckBoxSyncBit7.Size = New System.Drawing.Size(88, 20)
        Me.CheckBoxSyncBit7.TabIndex = 386
        Me.CheckBoxSyncBit7.Text = "Gun Off Bit"
        Me.CheckBoxSyncBit7.UseVisualStyleBackColor = False
        '
        'CheckBoxSyncBit6
        '
        Me.CheckBoxSyncBit6.AutoSize = True
        Me.CheckBoxSyncBit6.BackColor = System.Drawing.Color.LightSteelBlue
        Me.CheckBoxSyncBit6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBoxSyncBit6.Location = New System.Drawing.Point(167, 662)
        Me.CheckBoxSyncBit6.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBoxSyncBit6.Name = "CheckBoxSyncBit6"
        Me.CheckBoxSyncBit6.Size = New System.Drawing.Size(74, 20)
        Me.CheckBoxSyncBit6.TabIndex = 385
        Me.CheckBoxSyncBit6.Text = "Unused"
        Me.CheckBoxSyncBit6.UseVisualStyleBackColor = False
        '
        'ButtonTogglePulseSyncXray
        '
        Me.ButtonTogglePulseSyncXray.BackColor = System.Drawing.Color.Lavender
        Me.ButtonTogglePulseSyncXray.FlatAppearance.BorderSize = 0
        Me.ButtonTogglePulseSyncXray.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonTogglePulseSyncXray.Location = New System.Drawing.Point(12, 558)
        Me.ButtonTogglePulseSyncXray.Name = "ButtonTogglePulseSyncXray"
        Me.ButtonTogglePulseSyncXray.Size = New System.Drawing.Size(152, 23)
        Me.ButtonTogglePulseSyncXray.TabIndex = 378
        Me.ButtonTogglePulseSyncXray.Text = "Toggle Pulse Sync XRAY bit"
        Me.ButtonTogglePulseSyncXray.UseVisualStyleBackColor = False
        '
        'CheckBoxSyncBit5
        '
        Me.CheckBoxSyncBit5.AutoSize = True
        Me.CheckBoxSyncBit5.BackColor = System.Drawing.Color.LightSteelBlue
        Me.CheckBoxSyncBit5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBoxSyncBit5.Location = New System.Drawing.Point(167, 646)
        Me.CheckBoxSyncBit5.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBoxSyncBit5.Name = "CheckBoxSyncBit5"
        Me.CheckBoxSyncBit5.Size = New System.Drawing.Size(74, 20)
        Me.CheckBoxSyncBit5.TabIndex = 384
        Me.CheckBoxSyncBit5.Text = "Unused"
        Me.CheckBoxSyncBit5.UseVisualStyleBackColor = False
        '
        'ButtonTogglePulseSyncHV
        '
        Me.ButtonTogglePulseSyncHV.BackColor = System.Drawing.Color.Lavender
        Me.ButtonTogglePulseSyncHV.FlatAppearance.BorderSize = 0
        Me.ButtonTogglePulseSyncHV.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonTogglePulseSyncHV.Location = New System.Drawing.Point(12, 527)
        Me.ButtonTogglePulseSyncHV.Name = "ButtonTogglePulseSyncHV"
        Me.ButtonTogglePulseSyncHV.Size = New System.Drawing.Size(152, 23)
        Me.ButtonTogglePulseSyncHV.TabIndex = 377
        Me.ButtonTogglePulseSyncHV.Text = "Toggle Pulse Sync HV bit"
        Me.ButtonTogglePulseSyncHV.UseVisualStyleBackColor = False
        '
        'CheckBoxSyncBit4
        '
        Me.CheckBoxSyncBit4.AutoSize = True
        Me.CheckBoxSyncBit4.BackColor = System.Drawing.Color.LightSteelBlue
        Me.CheckBoxSyncBit4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBoxSyncBit4.Location = New System.Drawing.Point(167, 588)
        Me.CheckBoxSyncBit4.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBoxSyncBit4.Name = "CheckBoxSyncBit4"
        Me.CheckBoxSyncBit4.Size = New System.Drawing.Size(100, 20)
        Me.CheckBoxSyncBit4.TabIndex = 383
        Me.CheckBoxSyncBit4.Text = "Cool FLT Bit"
        Me.CheckBoxSyncBit4.UseVisualStyleBackColor = False
        '
        'ButtonToggleHighSpeedDataLogging
        '
        Me.ButtonToggleHighSpeedDataLogging.BackColor = System.Drawing.Color.Lavender
        Me.ButtonToggleHighSpeedDataLogging.FlatAppearance.BorderSize = 0
        Me.ButtonToggleHighSpeedDataLogging.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonToggleHighSpeedDataLogging.Location = New System.Drawing.Point(12, 498)
        Me.ButtonToggleHighSpeedDataLogging.Name = "ButtonToggleHighSpeedDataLogging"
        Me.ButtonToggleHighSpeedDataLogging.Size = New System.Drawing.Size(152, 23)
        Me.ButtonToggleHighSpeedDataLogging.TabIndex = 376
        Me.ButtonToggleHighSpeedDataLogging.Text = "Toggle High Speed Logging"
        Me.ButtonToggleHighSpeedDataLogging.UseVisualStyleBackColor = False
        '
        'CheckBoxSyncBit3
        '
        Me.CheckBoxSyncBit3.AutoSize = True
        Me.CheckBoxSyncBit3.BackColor = System.Drawing.Color.LightSteelBlue
        Me.CheckBoxSyncBit3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBoxSyncBit3.Location = New System.Drawing.Point(167, 559)
        Me.CheckBoxSyncBit3.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBoxSyncBit3.Name = "CheckBoxSyncBit3"
        Me.CheckBoxSyncBit3.Size = New System.Drawing.Size(110, 20)
        Me.CheckBoxSyncBit3.TabIndex = 382
        Me.CheckBoxSyncBit3.Text = "XRAY OFF Bit"
        Me.CheckBoxSyncBit3.UseVisualStyleBackColor = False
        '
        'LabelSyncMessageCntrlBits
        '
        Me.LabelSyncMessageCntrlBits.AutoSize = True
        Me.LabelSyncMessageCntrlBits.BackColor = System.Drawing.Color.LightSteelBlue
        Me.LabelSyncMessageCntrlBits.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelSyncMessageCntrlBits.Location = New System.Drawing.Point(12, 450)
        Me.LabelSyncMessageCntrlBits.Name = "LabelSyncMessageCntrlBits"
        Me.LabelSyncMessageCntrlBits.Size = New System.Drawing.Size(152, 16)
        Me.LabelSyncMessageCntrlBits.TabIndex = 374
        Me.LabelSyncMessageCntrlBits.Text = "Sync Message Cntrl Bits"
        '
        'CheckBoxSyncBit2
        '
        Me.CheckBoxSyncBit2.AutoSize = True
        Me.CheckBoxSyncBit2.BackColor = System.Drawing.Color.LightSteelBlue
        Me.CheckBoxSyncBit2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBoxSyncBit2.Location = New System.Drawing.Point(167, 529)
        Me.CheckBoxSyncBit2.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBoxSyncBit2.Name = "CheckBoxSyncBit2"
        Me.CheckBoxSyncBit2.Size = New System.Drawing.Size(93, 20)
        Me.CheckBoxSyncBit2.TabIndex = 381
        Me.CheckBoxSyncBit2.Text = "HV OFF Bit"
        Me.CheckBoxSyncBit2.UseVisualStyleBackColor = False
        '
        'ButtonToggleCoolantFault
        '
        Me.ButtonToggleCoolantFault.BackColor = System.Drawing.Color.Lavender
        Me.ButtonToggleCoolantFault.FlatAppearance.BorderSize = 0
        Me.ButtonToggleCoolantFault.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonToggleCoolantFault.Location = New System.Drawing.Point(12, 587)
        Me.ButtonToggleCoolantFault.Name = "ButtonToggleCoolantFault"
        Me.ButtonToggleCoolantFault.Size = New System.Drawing.Size(152, 23)
        Me.ButtonToggleCoolantFault.TabIndex = 375
        Me.ButtonToggleCoolantFault.Text = "Toggle Coolant Fault Bit"
        Me.ButtonToggleCoolantFault.UseVisualStyleBackColor = False
        '
        'CheckBoxSyncBit1
        '
        Me.CheckBoxSyncBit1.AutoSize = True
        Me.CheckBoxSyncBit1.BackColor = System.Drawing.Color.LightSteelBlue
        Me.CheckBoxSyncBit1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBoxSyncBit1.Location = New System.Drawing.Point(167, 500)
        Me.CheckBoxSyncBit1.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBoxSyncBit1.Name = "CheckBoxSyncBit1"
        Me.CheckBoxSyncBit1.Size = New System.Drawing.Size(90, 20)
        Me.CheckBoxSyncBit1.TabIndex = 380
        Me.CheckBoxSyncBit1.Text = "HS Log Bit"
        Me.CheckBoxSyncBit1.UseVisualStyleBackColor = False
        '
        'CheckBoxSyncBit0
        '
        Me.CheckBoxSyncBit0.AutoSize = True
        Me.CheckBoxSyncBit0.BackColor = System.Drawing.Color.LightSteelBlue
        Me.CheckBoxSyncBit0.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBoxSyncBit0.Location = New System.Drawing.Point(167, 471)
        Me.CheckBoxSyncBit0.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBoxSyncBit0.Name = "CheckBoxSyncBit0"
        Me.CheckBoxSyncBit0.Size = New System.Drawing.Size(81, 20)
        Me.CheckBoxSyncBit0.TabIndex = 379
        Me.CheckBoxSyncBit0.Text = "Reset Bit"
        Me.CheckBoxSyncBit0.UseVisualStyleBackColor = False
        '
        'ButtonToggleReset
        '
        Me.ButtonToggleReset.BackColor = System.Drawing.Color.Lavender
        Me.ButtonToggleReset.FlatAppearance.BorderSize = 0
        Me.ButtonToggleReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonToggleReset.Location = New System.Drawing.Point(12, 469)
        Me.ButtonToggleReset.Name = "ButtonToggleReset"
        Me.ButtonToggleReset.Size = New System.Drawing.Size(152, 23)
        Me.ButtonToggleReset.TabIndex = 373
        Me.ButtonToggleReset.Text = "Toggle Reset Enable Bit"
        Me.ButtonToggleReset.UseVisualStyleBackColor = False
        '
        'CheckBoxControlBit1
        '
        Me.CheckBoxControlBit1.AutoSize = True
        Me.CheckBoxControlBit1.BackColor = System.Drawing.SystemColors.Control
        Me.CheckBoxControlBit1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBoxControlBit1.Location = New System.Drawing.Point(300, 277)
        Me.CheckBoxControlBit1.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBoxControlBit1.Name = "CheckBoxControlBit1"
        Me.CheckBoxControlBit1.Size = New System.Drawing.Size(116, 20)
        Me.CheckBoxControlBit1.TabIndex = 366
        Me.CheckBoxControlBit1.Text = "Not Configured"
        Me.CheckBoxControlBit1.UseVisualStyleBackColor = False
        '
        'CheckBoxControlBit0
        '
        Me.CheckBoxControlBit0.AutoSize = True
        Me.CheckBoxControlBit0.BackColor = System.Drawing.SystemColors.Control
        Me.CheckBoxControlBit0.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBoxControlBit0.Location = New System.Drawing.Point(299, 257)
        Me.CheckBoxControlBit0.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBoxControlBit0.Name = "CheckBoxControlBit0"
        Me.CheckBoxControlBit0.Size = New System.Drawing.Size(92, 20)
        Me.CheckBoxControlBit0.TabIndex = 365
        Me.CheckBoxControlBit0.Text = "Not Ready"
        Me.CheckBoxControlBit0.UseVisualStyleBackColor = False
        '
        'CheckBoxControlBit2
        '
        Me.CheckBoxControlBit2.AutoSize = True
        Me.CheckBoxControlBit2.BackColor = System.Drawing.SystemColors.Control
        Me.CheckBoxControlBit2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBoxControlBit2.Location = New System.Drawing.Point(300, 297)
        Me.CheckBoxControlBit2.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBoxControlBit2.Name = "CheckBoxControlBit2"
        Me.CheckBoxControlBit2.Size = New System.Drawing.Size(123, 20)
        Me.CheckBoxControlBit2.TabIndex = 367
        Me.CheckBoxControlBit2.Text = "Self Check Error"
        Me.CheckBoxControlBit2.UseVisualStyleBackColor = False
        '
        'CheckBoxControlBit3
        '
        Me.CheckBoxControlBit3.AutoSize = True
        Me.CheckBoxControlBit3.BackColor = System.Drawing.SystemColors.Control
        Me.CheckBoxControlBit3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBoxControlBit3.Location = New System.Drawing.Point(300, 317)
        Me.CheckBoxControlBit3.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBoxControlBit3.Name = "CheckBoxControlBit3"
        Me.CheckBoxControlBit3.Size = New System.Drawing.Size(74, 20)
        Me.CheckBoxControlBit3.TabIndex = 368
        Me.CheckBoxControlBit3.Text = "Unused"
        Me.CheckBoxControlBit3.UseVisualStyleBackColor = False
        '
        'CheckBoxControlBit4
        '
        Me.CheckBoxControlBit4.AutoSize = True
        Me.CheckBoxControlBit4.BackColor = System.Drawing.SystemColors.Control
        Me.CheckBoxControlBit4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBoxControlBit4.Location = New System.Drawing.Point(300, 339)
        Me.CheckBoxControlBit4.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBoxControlBit4.Name = "CheckBoxControlBit4"
        Me.CheckBoxControlBit4.Size = New System.Drawing.Size(74, 20)
        Me.CheckBoxControlBit4.TabIndex = 369
        Me.CheckBoxControlBit4.Text = "Unused"
        Me.CheckBoxControlBit4.UseVisualStyleBackColor = False
        '
        'CheckBoxControlBit5
        '
        Me.CheckBoxControlBit5.AutoSize = True
        Me.CheckBoxControlBit5.BackColor = System.Drawing.SystemColors.Control
        Me.CheckBoxControlBit5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBoxControlBit5.Location = New System.Drawing.Point(300, 359)
        Me.CheckBoxControlBit5.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBoxControlBit5.Name = "CheckBoxControlBit5"
        Me.CheckBoxControlBit5.Size = New System.Drawing.Size(74, 20)
        Me.CheckBoxControlBit5.TabIndex = 370
        Me.CheckBoxControlBit5.Text = "Unused"
        Me.CheckBoxControlBit5.UseVisualStyleBackColor = False
        '
        'CheckBoxControlBit6
        '
        Me.CheckBoxControlBit6.AutoSize = True
        Me.CheckBoxControlBit6.BackColor = System.Drawing.SystemColors.Control
        Me.CheckBoxControlBit6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBoxControlBit6.Location = New System.Drawing.Point(300, 379)
        Me.CheckBoxControlBit6.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBoxControlBit6.Name = "CheckBoxControlBit6"
        Me.CheckBoxControlBit6.Size = New System.Drawing.Size(74, 20)
        Me.CheckBoxControlBit6.TabIndex = 371
        Me.CheckBoxControlBit6.Text = "Unused"
        Me.CheckBoxControlBit6.UseVisualStyleBackColor = False
        '
        'CheckBoxControlBit7
        '
        Me.CheckBoxControlBit7.AutoSize = True
        Me.CheckBoxControlBit7.BackColor = System.Drawing.SystemColors.Control
        Me.CheckBoxControlBit7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBoxControlBit7.Location = New System.Drawing.Point(300, 399)
        Me.CheckBoxControlBit7.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBoxControlBit7.Name = "CheckBoxControlBit7"
        Me.CheckBoxControlBit7.Size = New System.Drawing.Size(74, 20)
        Me.CheckBoxControlBit7.TabIndex = 372
        Me.CheckBoxControlBit7.Text = "Unused"
        Me.CheckBoxControlBit7.UseVisualStyleBackColor = False
        '
        'LabelGuiVersion
        '
        Me.LabelGuiVersion.AutoSize = True
        Me.LabelGuiVersion.BackColor = System.Drawing.Color.LightSteelBlue
        Me.LabelGuiVersion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelGuiVersion.Location = New System.Drawing.Point(12, 330)
        Me.LabelGuiVersion.Name = "LabelGuiVersion"
        Me.LabelGuiVersion.Size = New System.Drawing.Size(78, 16)
        Me.LabelGuiVersion.TabIndex = 390
        Me.LabelGuiVersion.Text = "GUI version"
        '
        'LabelRangeInput1
        '
        Me.LabelRangeInput1.AutoSize = True
        Me.LabelRangeInput1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelRangeInput1.Location = New System.Drawing.Point(1066, 12)
        Me.LabelRangeInput1.Margin = New System.Windows.Forms.Padding(0)
        Me.LabelRangeInput1.Name = "LabelRangeInput1"
        Me.LabelRangeInput1.Size = New System.Drawing.Size(49, 16)
        Me.LabelRangeInput1.TabIndex = 391
        Me.LabelRangeInput1.Text = "Range"
        '
        'LabelRangeInput2
        '
        Me.LabelRangeInput2.AutoSize = True
        Me.LabelRangeInput2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelRangeInput2.Location = New System.Drawing.Point(1066, 39)
        Me.LabelRangeInput2.Margin = New System.Windows.Forms.Padding(0)
        Me.LabelRangeInput2.Name = "LabelRangeInput2"
        Me.LabelRangeInput2.Size = New System.Drawing.Size(49, 16)
        Me.LabelRangeInput2.TabIndex = 392
        Me.LabelRangeInput2.Text = "Range"
        '
        'LabelRangeInput3
        '
        Me.LabelRangeInput3.AutoSize = True
        Me.LabelRangeInput3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelRangeInput3.Location = New System.Drawing.Point(1066, 64)
        Me.LabelRangeInput3.Margin = New System.Windows.Forms.Padding(0)
        Me.LabelRangeInput3.Name = "LabelRangeInput3"
        Me.LabelRangeInput3.Size = New System.Drawing.Size(49, 16)
        Me.LabelRangeInput3.TabIndex = 393
        Me.LabelRangeInput3.Text = "Range"
        '
        'LabelRangeInput4
        '
        Me.LabelRangeInput4.AutoSize = True
        Me.LabelRangeInput4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelRangeInput4.Location = New System.Drawing.Point(1066, 91)
        Me.LabelRangeInput4.Margin = New System.Windows.Forms.Padding(0)
        Me.LabelRangeInput4.Name = "LabelRangeInput4"
        Me.LabelRangeInput4.Size = New System.Drawing.Size(49, 16)
        Me.LabelRangeInput4.TabIndex = 394
        Me.LabelRangeInput4.Text = "Range"
        '
        'LabelRangeInput5
        '
        Me.LabelRangeInput5.AutoSize = True
        Me.LabelRangeInput5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelRangeInput5.Location = New System.Drawing.Point(1066, 117)
        Me.LabelRangeInput5.Margin = New System.Windows.Forms.Padding(0)
        Me.LabelRangeInput5.Name = "LabelRangeInput5"
        Me.LabelRangeInput5.Size = New System.Drawing.Size(49, 16)
        Me.LabelRangeInput5.TabIndex = 395
        Me.LabelRangeInput5.Text = "Range"
        '
        'ButtonReloadECBDefaults
        '
        Me.ButtonReloadECBDefaults.BackColor = System.Drawing.Color.Lavender
        Me.ButtonReloadECBDefaults.FlatAppearance.BorderSize = 0
        Me.ButtonReloadECBDefaults.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonReloadECBDefaults.Location = New System.Drawing.Point(170, 373)
        Me.ButtonReloadECBDefaults.Name = "ButtonReloadECBDefaults"
        Me.ButtonReloadECBDefaults.Size = New System.Drawing.Size(100, 23)
        Me.ButtonReloadECBDefaults.TabIndex = 396
        Me.ButtonReloadECBDefaults.Text = "Reload Defaults"
        Me.ButtonReloadECBDefaults.UseVisualStyleBackColor = False
        '
        'ButtonZeroOnTime
        '
        Me.ButtonZeroOnTime.BackColor = System.Drawing.Color.Lavender
        Me.ButtonZeroOnTime.FlatAppearance.BorderSize = 0
        Me.ButtonZeroOnTime.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonZeroOnTime.Location = New System.Drawing.Point(12, 706)
        Me.ButtonZeroOnTime.Name = "ButtonZeroOnTime"
        Me.ButtonZeroOnTime.Size = New System.Drawing.Size(100, 23)
        Me.ButtonZeroOnTime.TabIndex = 397
        Me.ButtonZeroOnTime.Text = "Zero On Time"
        Me.ButtonZeroOnTime.UseVisualStyleBackColor = False
        '
        'ButtonZeroPulseCounters
        '
        Me.ButtonZeroPulseCounters.BackColor = System.Drawing.Color.Lavender
        Me.ButtonZeroPulseCounters.FlatAppearance.BorderSize = 0
        Me.ButtonZeroPulseCounters.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonZeroPulseCounters.Location = New System.Drawing.Point(167, 706)
        Me.ButtonZeroPulseCounters.Name = "ButtonZeroPulseCounters"
        Me.ButtonZeroPulseCounters.Size = New System.Drawing.Size(100, 23)
        Me.ButtonZeroPulseCounters.TabIndex = 398
        Me.ButtonZeroPulseCounters.Text = "Zero Pulse Count"
        Me.ButtonZeroPulseCounters.UseVisualStyleBackColor = False
        '
        'ButtonToggleMode
        '
        Me.ButtonToggleMode.BackColor = System.Drawing.Color.Lavender
        Me.ButtonToggleMode.FlatAppearance.BorderSize = 0
        Me.ButtonToggleMode.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonToggleMode.Location = New System.Drawing.Point(15, 367)
        Me.ButtonToggleMode.Name = "ButtonToggleMode"
        Me.ButtonToggleMode.Size = New System.Drawing.Size(100, 23)
        Me.ButtonToggleMode.TabIndex = 400
        Me.ButtonToggleMode.Text = "Advanced GUI"
        Me.ButtonToggleMode.UseVisualStyleBackColor = False
        '
        'CheckBoxLoggedBitF
        '
        Me.CheckBoxLoggedBitF.AutoSize = True
        Me.CheckBoxLoggedBitF.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBoxLoggedBitF.Location = New System.Drawing.Point(581, 314)
        Me.CheckBoxLoggedBitF.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBoxLoggedBitF.Name = "CheckBoxLoggedBitF"
        Me.CheckBoxLoggedBitF.Size = New System.Drawing.Size(92, 20)
        Me.CheckBoxLoggedBitF.TabIndex = 417
        Me.CheckBoxLoggedBitF.Text = "Logged Bit"
        Me.CheckBoxLoggedBitF.UseVisualStyleBackColor = True
        '
        'CheckBoxLoggedBit0
        '
        Me.CheckBoxLoggedBit0.AutoSize = True
        Me.CheckBoxLoggedBit0.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBoxLoggedBit0.Location = New System.Drawing.Point(581, 10)
        Me.CheckBoxLoggedBit0.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBoxLoggedBit0.Name = "CheckBoxLoggedBit0"
        Me.CheckBoxLoggedBit0.Size = New System.Drawing.Size(92, 20)
        Me.CheckBoxLoggedBit0.TabIndex = 402
        Me.CheckBoxLoggedBit0.Text = "Logged Bit"
        Me.CheckBoxLoggedBit0.UseVisualStyleBackColor = True
        '
        'CheckBoxLoggedBit1
        '
        Me.CheckBoxLoggedBit1.AutoSize = True
        Me.CheckBoxLoggedBit1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBoxLoggedBit1.Location = New System.Drawing.Point(581, 30)
        Me.CheckBoxLoggedBit1.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBoxLoggedBit1.Name = "CheckBoxLoggedBit1"
        Me.CheckBoxLoggedBit1.Size = New System.Drawing.Size(92, 20)
        Me.CheckBoxLoggedBit1.TabIndex = 403
        Me.CheckBoxLoggedBit1.Text = "Logged Bit"
        Me.CheckBoxLoggedBit1.UseVisualStyleBackColor = True
        '
        'CheckBoxLoggedBit2
        '
        Me.CheckBoxLoggedBit2.AutoSize = True
        Me.CheckBoxLoggedBit2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBoxLoggedBit2.Location = New System.Drawing.Point(581, 50)
        Me.CheckBoxLoggedBit2.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBoxLoggedBit2.Name = "CheckBoxLoggedBit2"
        Me.CheckBoxLoggedBit2.Size = New System.Drawing.Size(92, 20)
        Me.CheckBoxLoggedBit2.TabIndex = 404
        Me.CheckBoxLoggedBit2.Text = "Logged Bit"
        Me.CheckBoxLoggedBit2.UseVisualStyleBackColor = True
        '
        'CheckBoxLoggedBit3
        '
        Me.CheckBoxLoggedBit3.AutoSize = True
        Me.CheckBoxLoggedBit3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBoxLoggedBit3.Location = New System.Drawing.Point(581, 70)
        Me.CheckBoxLoggedBit3.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBoxLoggedBit3.Name = "CheckBoxLoggedBit3"
        Me.CheckBoxLoggedBit3.Size = New System.Drawing.Size(92, 20)
        Me.CheckBoxLoggedBit3.TabIndex = 405
        Me.CheckBoxLoggedBit3.Text = "Logged Bit"
        Me.CheckBoxLoggedBit3.UseVisualStyleBackColor = True
        '
        'CheckBoxLoggedBit4
        '
        Me.CheckBoxLoggedBit4.AutoSize = True
        Me.CheckBoxLoggedBit4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBoxLoggedBit4.Location = New System.Drawing.Point(581, 92)
        Me.CheckBoxLoggedBit4.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBoxLoggedBit4.Name = "CheckBoxLoggedBit4"
        Me.CheckBoxLoggedBit4.Size = New System.Drawing.Size(92, 20)
        Me.CheckBoxLoggedBit4.TabIndex = 406
        Me.CheckBoxLoggedBit4.Text = "Logged Bit"
        Me.CheckBoxLoggedBit4.UseVisualStyleBackColor = True
        '
        'CheckBoxLoggedBit5
        '
        Me.CheckBoxLoggedBit5.AutoSize = True
        Me.CheckBoxLoggedBit5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBoxLoggedBit5.Location = New System.Drawing.Point(581, 112)
        Me.CheckBoxLoggedBit5.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBoxLoggedBit5.Name = "CheckBoxLoggedBit5"
        Me.CheckBoxLoggedBit5.Size = New System.Drawing.Size(92, 20)
        Me.CheckBoxLoggedBit5.TabIndex = 407
        Me.CheckBoxLoggedBit5.Text = "Logged Bit"
        Me.CheckBoxLoggedBit5.UseVisualStyleBackColor = True
        '
        'CheckBoxLoggedBit6
        '
        Me.CheckBoxLoggedBit6.AutoSize = True
        Me.CheckBoxLoggedBit6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBoxLoggedBit6.Location = New System.Drawing.Point(581, 132)
        Me.CheckBoxLoggedBit6.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBoxLoggedBit6.Name = "CheckBoxLoggedBit6"
        Me.CheckBoxLoggedBit6.Size = New System.Drawing.Size(92, 20)
        Me.CheckBoxLoggedBit6.TabIndex = 408
        Me.CheckBoxLoggedBit6.Text = "Logged Bit"
        Me.CheckBoxLoggedBit6.UseVisualStyleBackColor = True
        '
        'CheckBoxLoggedBit7
        '
        Me.CheckBoxLoggedBit7.AutoSize = True
        Me.CheckBoxLoggedBit7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBoxLoggedBit7.Location = New System.Drawing.Point(581, 152)
        Me.CheckBoxLoggedBit7.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBoxLoggedBit7.Name = "CheckBoxLoggedBit7"
        Me.CheckBoxLoggedBit7.Size = New System.Drawing.Size(92, 20)
        Me.CheckBoxLoggedBit7.TabIndex = 409
        Me.CheckBoxLoggedBit7.Text = "Logged Bit"
        Me.CheckBoxLoggedBit7.UseVisualStyleBackColor = True
        '
        'CheckBoxLoggedBit8
        '
        Me.CheckBoxLoggedBit8.AutoSize = True
        Me.CheckBoxLoggedBit8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBoxLoggedBit8.Location = New System.Drawing.Point(581, 172)
        Me.CheckBoxLoggedBit8.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBoxLoggedBit8.Name = "CheckBoxLoggedBit8"
        Me.CheckBoxLoggedBit8.Size = New System.Drawing.Size(92, 20)
        Me.CheckBoxLoggedBit8.TabIndex = 410
        Me.CheckBoxLoggedBit8.Text = "Logged Bit"
        Me.CheckBoxLoggedBit8.UseVisualStyleBackColor = True
        '
        'CheckBoxLoggedBit9
        '
        Me.CheckBoxLoggedBit9.AutoSize = True
        Me.CheckBoxLoggedBit9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBoxLoggedBit9.Location = New System.Drawing.Point(581, 192)
        Me.CheckBoxLoggedBit9.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBoxLoggedBit9.Name = "CheckBoxLoggedBit9"
        Me.CheckBoxLoggedBit9.Size = New System.Drawing.Size(92, 20)
        Me.CheckBoxLoggedBit9.TabIndex = 411
        Me.CheckBoxLoggedBit9.Text = "Logged Bit"
        Me.CheckBoxLoggedBit9.UseVisualStyleBackColor = True
        '
        'CheckBoxLoggedBitA
        '
        Me.CheckBoxLoggedBitA.AutoSize = True
        Me.CheckBoxLoggedBitA.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBoxLoggedBitA.Location = New System.Drawing.Point(581, 212)
        Me.CheckBoxLoggedBitA.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBoxLoggedBitA.Name = "CheckBoxLoggedBitA"
        Me.CheckBoxLoggedBitA.Size = New System.Drawing.Size(92, 20)
        Me.CheckBoxLoggedBitA.TabIndex = 412
        Me.CheckBoxLoggedBitA.Text = "Logged Bit"
        Me.CheckBoxLoggedBitA.UseVisualStyleBackColor = True
        '
        'CheckBoxLoggedBitB
        '
        Me.CheckBoxLoggedBitB.AutoSize = True
        Me.CheckBoxLoggedBitB.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBoxLoggedBitB.Location = New System.Drawing.Point(581, 232)
        Me.CheckBoxLoggedBitB.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBoxLoggedBitB.Name = "CheckBoxLoggedBitB"
        Me.CheckBoxLoggedBitB.Size = New System.Drawing.Size(92, 20)
        Me.CheckBoxLoggedBitB.TabIndex = 413
        Me.CheckBoxLoggedBitB.Text = "Logged Bit"
        Me.CheckBoxLoggedBitB.UseVisualStyleBackColor = True
        '
        'CheckBoxLoggedBitC
        '
        Me.CheckBoxLoggedBitC.AutoSize = True
        Me.CheckBoxLoggedBitC.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBoxLoggedBitC.Location = New System.Drawing.Point(581, 254)
        Me.CheckBoxLoggedBitC.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBoxLoggedBitC.Name = "CheckBoxLoggedBitC"
        Me.CheckBoxLoggedBitC.Size = New System.Drawing.Size(92, 20)
        Me.CheckBoxLoggedBitC.TabIndex = 414
        Me.CheckBoxLoggedBitC.Text = "Logged Bit"
        Me.CheckBoxLoggedBitC.UseVisualStyleBackColor = True
        '
        'CheckBoxLoggedBitD
        '
        Me.CheckBoxLoggedBitD.AutoSize = True
        Me.CheckBoxLoggedBitD.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBoxLoggedBitD.Location = New System.Drawing.Point(581, 274)
        Me.CheckBoxLoggedBitD.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBoxLoggedBitD.Name = "CheckBoxLoggedBitD"
        Me.CheckBoxLoggedBitD.Size = New System.Drawing.Size(92, 20)
        Me.CheckBoxLoggedBitD.TabIndex = 415
        Me.CheckBoxLoggedBitD.Text = "Logged Bit"
        Me.CheckBoxLoggedBitD.UseVisualStyleBackColor = True
        '
        'CheckBoxLoggedBitE
        '
        Me.CheckBoxLoggedBitE.AutoSize = True
        Me.CheckBoxLoggedBitE.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBoxLoggedBitE.Location = New System.Drawing.Point(581, 294)
        Me.CheckBoxLoggedBitE.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBoxLoggedBitE.Name = "CheckBoxLoggedBitE"
        Me.CheckBoxLoggedBitE.Size = New System.Drawing.Size(92, 20)
        Me.CheckBoxLoggedBitE.TabIndex = 416
        Me.CheckBoxLoggedBitE.Text = "Logged Bit"
        Me.CheckBoxLoggedBitE.UseVisualStyleBackColor = True
        '
        'ButtonSetRevSN
        '
        Me.ButtonSetRevSN.Location = New System.Drawing.Point(924, 524)
        Me.ButtonSetRevSN.Name = "ButtonSetRevSN"
        Me.ButtonSetRevSN.Size = New System.Drawing.Size(103, 23)
        Me.ButtonSetRevSN.TabIndex = 418
        Me.ButtonSetRevSN.Text = "Set Rev/SN"
        Me.ButtonSetRevSN.UseVisualStyleBackColor = True
        '
        'ButtonSaveFactorySettings
        '
        Me.ButtonSaveFactorySettings.BackColor = System.Drawing.Color.Lavender
        Me.ButtonSaveFactorySettings.FlatAppearance.BorderSize = 0
        Me.ButtonSaveFactorySettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonSaveFactorySettings.Location = New System.Drawing.Point(172, 204)
        Me.ButtonSaveFactorySettings.Name = "ButtonSaveFactorySettings"
        Me.ButtonSaveFactorySettings.Size = New System.Drawing.Size(100, 23)
        Me.ButtonSaveFactorySettings.TabIndex = 420
        Me.ButtonSaveFactorySettings.Text = "Save Factory"
        Me.ButtonSaveFactorySettings.UseVisualStyleBackColor = False
        '
        'ButtonLoadFactorySettings
        '
        Me.ButtonLoadFactorySettings.BackColor = System.Drawing.Color.Lavender
        Me.ButtonLoadFactorySettings.FlatAppearance.BorderSize = 0
        Me.ButtonLoadFactorySettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonLoadFactorySettings.Location = New System.Drawing.Point(172, 236)
        Me.ButtonLoadFactorySettings.Name = "ButtonLoadFactorySettings"
        Me.ButtonLoadFactorySettings.Size = New System.Drawing.Size(100, 23)
        Me.ButtonLoadFactorySettings.TabIndex = 421
        Me.ButtonLoadFactorySettings.Text = "Load Factory"
        Me.ButtonLoadFactorySettings.UseVisualStyleBackColor = False
        '
        'frmMainSuper
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(1028, 609)
        Me.Controls.Add(Me.ButtonLoadFactorySettings)
        Me.Controls.Add(Me.ButtonSaveFactorySettings)
        Me.Controls.Add(Me.ButtonSetRevSN)
        Me.Controls.Add(Me.CheckBoxLoggedBitF)
        Me.Controls.Add(Me.CheckBoxLoggedBit0)
        Me.Controls.Add(Me.CheckBoxLoggedBit1)
        Me.Controls.Add(Me.CheckBoxLoggedBit2)
        Me.Controls.Add(Me.CheckBoxLoggedBit3)
        Me.Controls.Add(Me.CheckBoxLoggedBit4)
        Me.Controls.Add(Me.CheckBoxLoggedBit5)
        Me.Controls.Add(Me.CheckBoxLoggedBit6)
        Me.Controls.Add(Me.CheckBoxLoggedBit7)
        Me.Controls.Add(Me.CheckBoxLoggedBit8)
        Me.Controls.Add(Me.CheckBoxLoggedBit9)
        Me.Controls.Add(Me.CheckBoxLoggedBitA)
        Me.Controls.Add(Me.CheckBoxLoggedBitB)
        Me.Controls.Add(Me.CheckBoxLoggedBitC)
        Me.Controls.Add(Me.CheckBoxLoggedBitD)
        Me.Controls.Add(Me.CheckBoxLoggedBitE)
        Me.Controls.Add(Me.ButtonToggleMode)
        Me.Controls.Add(Me.ButtonZeroPulseCounters)
        Me.Controls.Add(Me.ButtonZeroOnTime)
        Me.Controls.Add(Me.ButtonReloadECBDefaults)
        Me.Controls.Add(Me.LabelRangeInput5)
        Me.Controls.Add(Me.LabelRangeInput4)
        Me.Controls.Add(Me.LabelRangeInput3)
        Me.Controls.Add(Me.LabelRangeInput2)
        Me.Controls.Add(Me.LabelRangeInput1)
        Me.Controls.Add(Me.LabelGuiVersion)
        Me.Controls.Add(Me.CheckBoxSyncBitF)
        Me.Controls.Add(Me.ButtonToggleResetDebug)
        Me.Controls.Add(Me.CheckBoxSyncBit8)
        Me.Controls.Add(Me.CheckBoxSyncBit7)
        Me.Controls.Add(Me.CheckBoxSyncBit6)
        Me.Controls.Add(Me.ButtonTogglePulseSyncXray)
        Me.Controls.Add(Me.CheckBoxSyncBit5)
        Me.Controls.Add(Me.ButtonTogglePulseSyncHV)
        Me.Controls.Add(Me.CheckBoxSyncBit4)
        Me.Controls.Add(Me.ButtonToggleHighSpeedDataLogging)
        Me.Controls.Add(Me.CheckBoxSyncBit3)
        Me.Controls.Add(Me.LabelSyncMessageCntrlBits)
        Me.Controls.Add(Me.CheckBoxSyncBit2)
        Me.Controls.Add(Me.ButtonToggleCoolantFault)
        Me.Controls.Add(Me.CheckBoxSyncBit1)
        Me.Controls.Add(Me.CheckBoxSyncBit0)
        Me.Controls.Add(Me.ButtonToggleReset)
        Me.Controls.Add(Me.CheckBoxControlBit1)
        Me.Controls.Add(Me.CheckBoxControlBit0)
        Me.Controls.Add(Me.CheckBoxControlBit2)
        Me.Controls.Add(Me.CheckBoxControlBit3)
        Me.Controls.Add(Me.CheckBoxControlBit4)
        Me.Controls.Add(Me.CheckBoxControlBit5)
        Me.Controls.Add(Me.CheckBoxControlBit6)
        Me.Controls.Add(Me.CheckBoxControlBit7)
        Me.Controls.Add(Me.LabelECBTime)
        Me.Controls.Add(Me.LabelComputerTime)
        Me.Controls.Add(Me.ButtonSetTime)
        Me.Controls.Add(Me.ButtonStopLog)
        Me.Controls.Add(Me.ButtonStartLog)
        Me.Controls.Add(Me.LabelECBState)
        Me.Controls.Add(Me.CheckBoxOperateEthernet)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.CheckBoxOperatePulseSync)
        Me.Controls.Add(Me.CheckBoxOperateMagnetronCurrentMon)
        Me.Controls.Add(Me.CheckBoxOperateGunDriver)
        Me.Controls.Add(Me.CheckBoxOperateHtrMag)
        Me.Controls.Add(Me.CheckBoxOperateCooling)
        Me.Controls.Add(Me.CheckBoxOperateAFC)
        Me.Controls.Add(Me.CheckBoxOperateIonPump)
        Me.Controls.Add(Me.CheckBoxOperateHVLambda)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.CheckBoxPulseSyncConnected)
        Me.Controls.Add(Me.CheckBoxPulseCurrentMonitorConnected)
        Me.Controls.Add(Me.CheckBoxGunDriverConnected)
        Me.Controls.Add(Me.CheckBoxHtrMagConnected)
        Me.Controls.Add(Me.CheckBoxCoolingConnected)
        Me.Controls.Add(Me.CheckBoxAFCConnected)
        Me.Controls.Add(Me.CheckBoxIonPumpConnected)
        Me.Controls.Add(Me.CheckBoxHVLambdaConnected)
        Me.Controls.Add(Me.LabelDisplay8)
        Me.Controls.Add(Me.LabelDisplay7)
        Me.Controls.Add(Me.LabelDisplay6)
        Me.Controls.Add(Me.LabelDisplay5)
        Me.Controls.Add(Me.LabelDisplay4)
        Me.Controls.Add(Me.LabelDisplay3)
        Me.Controls.Add(Me.LabelDisplay2)
        Me.Controls.Add(Me.LabelDisplay1)
        Me.Controls.Add(Me.ButtonUpdateInput5)
        Me.Controls.Add(Me.ButtonUpdateInput4)
        Me.Controls.Add(Me.TextBoxInput5)
        Me.Controls.Add(Me.TextBoxInput4)
        Me.Controls.Add(Me.LabelValue15)
        Me.Controls.Add(Me.LabelValue14)
        Me.Controls.Add(Me.LabelValue13)
        Me.Controls.Add(Me.LabelValue12)
        Me.Controls.Add(Me.LabelValue11)
        Me.Controls.Add(Me.LabelValue10)
        Me.Controls.Add(Me.LabelValue9)
        Me.Controls.Add(Me.LabelValue8)
        Me.Controls.Add(Me.LabelValue7)
        Me.Controls.Add(Me.ButtonUpdateInput3)
        Me.Controls.Add(Me.LabelValue6)
        Me.Controls.Add(Me.LabelValue5)
        Me.Controls.Add(Me.TextBoxInput3)
        Me.Controls.Add(Me.LabelValue4)
        Me.Controls.Add(Me.CheckBoxResetPOR)
        Me.Controls.Add(Me.LabelValue3)
        Me.Controls.Add(Me.LabelValue2)
        Me.Controls.Add(Me.CheckBoxResetBOR)
        Me.Controls.Add(Me.LabelValue1)
        Me.Controls.Add(Me.CheckBoxResetIdle)
        Me.Controls.Add(Me.LabelRCON)
        Me.Controls.Add(Me.CheckBoxResetSleep)
        Me.Controls.Add(Me.CheckBoxResetWDT)
        Me.Controls.Add(Me.LabelErrorReserved1)
        Me.Controls.Add(Me.CheckBoxResetSoftware)
        Me.Controls.Add(Me.ButtonUpdateInput2)
        Me.Controls.Add(Me.LabelErrorReserved0)
        Me.Controls.Add(Me.ButtonUpdateInput1)
        Me.Controls.Add(Me.TextBoxInput1)
        Me.Controls.Add(Me.CheckBoxResetExt)
        Me.Controls.Add(Me.TextBoxInput2)
        Me.Controls.Add(Me.LabelErrorSelfTestResultRegister)
        Me.Controls.Add(Me.LabelCanTimeoutCount)
        Me.Controls.Add(Me.LabelCAnDataLogRXBufferOVerflowCount)
        Me.Controls.Add(Me.LabelCanRXBufferOverflowCount)
        Me.Controls.Add(Me.LabelErrorResetCount)
        Me.Controls.Add(Me.LabelCanTXBufOverflowCount)
        Me.Controls.Add(Me.CheckBoxResetIllegal)
        Me.Controls.Add(Me.LabelCanTX0Count)
        Me.Controls.Add(Me.LabelCanAddressErrorCount)
        Me.Controls.Add(Me.LabelErrorScaleCount)
        Me.Controls.Add(Me.LabelCanInvalidIndexCount)
        Me.Controls.Add(Me.LabelCanUnknownIdentifierCount)
        Me.Controls.Add(Me.CheckBoxResetTrap)
        Me.Controls.Add(Me.LabelCanISREnteredCount)
        Me.Controls.Add(Me.LabelCanRX1Filt2Count)
        Me.Controls.Add(Me.LabelCanRX0Filt1Count)
        Me.Controls.Add(Me.LabelCanRX0Filt0Count)
        Me.Controls.Add(Me.LabelErrorSPIBusCount)
        Me.Controls.Add(Me.LabelCanTX2Count)
        Me.Controls.Add(Me.LabelCanTX1Count)
        Me.Controls.Add(Me.LabelValueDebugF)
        Me.Controls.Add(Me.LabelCanErrorFlagCount)
        Me.Controls.Add(Me.LabelErrorI2CBusCount)
        Me.Controls.Add(Me.LabelCanCXECReg)
        Me.Controls.Add(Me.ButtonResetSlave)
        Me.Controls.Add(Me.LabelFirmwareVerssion)
        Me.Controls.Add(Me.LabelValueDebugE)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.LabelAgileInfo)
        Me.Controls.Add(Me.LabelValueDebugD)
        Me.Controls.Add(Me.LabelValueDebugC)
        Me.Controls.Add(Me.LabelValueDebugB)
        Me.Controls.Add(Me.LabelScale)
        Me.Controls.Add(Me.LabelValueDebugA)
        Me.Controls.Add(Me.LabelValueDebug9)
        Me.Controls.Add(Me.LabelOffset)
        Me.Controls.Add(Me.LabelValueDebug8)
        Me.Controls.Add(Me.LabelValueDebug7)
        Me.Controls.Add(Me.LabelEEpromIndex)
        Me.Controls.Add(Me.LabelValueDebug6)
        Me.Controls.Add(Me.LabelValueDebug5)
        Me.Controls.Add(Me.ComboBoxEEpromRegister)
        Me.Controls.Add(Me.LabelValueDebug4)
        Me.Controls.Add(Me.LabelValueDebug3)
        Me.Controls.Add(Me.TextBoxEEpromOffSet)
        Me.Controls.Add(Me.LabelValueDebug2)
        Me.Controls.Add(Me.LabelValueDebug1)
        Me.Controls.Add(Me.TextBoxEEpromScale)
        Me.Controls.Add(Me.LabelValueDebug0)
        Me.Controls.Add(Me.ButtonWriteEEprom)
        Me.Controls.Add(Me.ButtonReadEEprom)
        Me.Controls.Add(Me.LabelBoardStatus)
        Me.Controls.Add(Me.LabelDebugF)
        Me.Controls.Add(Me.LabelDebugE)
        Me.Controls.Add(Me.LabelDebugD)
        Me.Controls.Add(Me.LabelDebugC)
        Me.Controls.Add(Me.cboIndex)
        Me.Controls.Add(Me.LabelDebugB)
        Me.Controls.Add(Me.LabelDebugA)
        Me.Controls.Add(Me.CheckBoxFaultBitF)
        Me.Controls.Add(Me.CheckBoxFaultBit0)
        Me.Controls.Add(Me.LabelDebug9)
        Me.Controls.Add(Me.CheckBoxFaultBit1)
        Me.Controls.Add(Me.CheckBoxFaultBit2)
        Me.Controls.Add(Me.LabelDebug8)
        Me.Controls.Add(Me.CheckBoxFaultBit3)
        Me.Controls.Add(Me.LabelDebug7)
        Me.Controls.Add(Me.CheckBoxFaultBit4)
        Me.Controls.Add(Me.LabelDebug6)
        Me.Controls.Add(Me.CheckBoxFaultBit5)
        Me.Controls.Add(Me.LabelDebug5)
        Me.Controls.Add(Me.CheckBoxFaultBit6)
        Me.Controls.Add(Me.LabelDebug4)
        Me.Controls.Add(Me.CheckBoxFaultBit7)
        Me.Controls.Add(Me.LabelDebug3)
        Me.Controls.Add(Me.CheckBoxFaultBit8)
        Me.Controls.Add(Me.LabelDebug2)
        Me.Controls.Add(Me.CheckBoxFaultBit9)
        Me.Controls.Add(Me.LabelDebug1)
        Me.Controls.Add(Me.CheckBoxFaultBitA)
        Me.Controls.Add(Me.LabelDebug0)
        Me.Controls.Add(Me.CheckBoxFaultBitB)
        Me.Controls.Add(Me.CheckBoxFaultBitC)
        Me.Controls.Add(Me.CheckBoxFaultBitD)
        Me.Controls.Add(Me.CheckBoxFaultBitE)
        Me.Controls.Add(Me.Splitter1)
        Me.Name = "frmMainSuper"
        Me.Text = "No Connection"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TimerUpdate As System.Windows.Forms.Timer
    Friend WithEvents cboIndex As System.Windows.Forms.ComboBox
    Friend WithEvents LabelErrorReserved1 As System.Windows.Forms.Label
    Friend WithEvents LabelErrorReserved0 As System.Windows.Forms.Label
    Friend WithEvents LabelErrorSelfTestResultRegister As System.Windows.Forms.Label
    Friend WithEvents LabelErrorResetCount As System.Windows.Forms.Label
    Friend WithEvents LabelErrorScaleCount As System.Windows.Forms.Label
    Friend WithEvents LabelErrorSPIBusCount As System.Windows.Forms.Label
    Friend WithEvents LabelErrorI2CBusCount As System.Windows.Forms.Label
    Friend WithEvents LabelDebugF As System.Windows.Forms.Label
    Friend WithEvents LabelDebugE As System.Windows.Forms.Label
    Friend WithEvents LabelDebugD As System.Windows.Forms.Label
    Friend WithEvents LabelDebugC As System.Windows.Forms.Label
    Friend WithEvents LabelDebugB As System.Windows.Forms.Label
    Friend WithEvents LabelDebugA As System.Windows.Forms.Label
    Friend WithEvents LabelDebug9 As System.Windows.Forms.Label
    Friend WithEvents LabelDebug8 As System.Windows.Forms.Label
    Friend WithEvents LabelDebug7 As System.Windows.Forms.Label
    Friend WithEvents LabelDebug6 As System.Windows.Forms.Label
    Friend WithEvents LabelDebug5 As System.Windows.Forms.Label
    Friend WithEvents LabelDebug4 As System.Windows.Forms.Label
    Friend WithEvents LabelDebug3 As System.Windows.Forms.Label
    Friend WithEvents LabelDebug2 As System.Windows.Forms.Label
    Friend WithEvents LabelDebug1 As System.Windows.Forms.Label
    Friend WithEvents LabelDebug0 As System.Windows.Forms.Label
    Friend WithEvents LabelCanTimeoutCount As System.Windows.Forms.Label
    Friend WithEvents LabelCAnDataLogRXBufferOVerflowCount As System.Windows.Forms.Label
    Friend WithEvents LabelCanRXBufferOverflowCount As System.Windows.Forms.Label
    Friend WithEvents LabelCanTXBufOverflowCount As System.Windows.Forms.Label
    Friend WithEvents LabelCanTX0Count As System.Windows.Forms.Label
    Friend WithEvents LabelCanAddressErrorCount As System.Windows.Forms.Label
    Friend WithEvents LabelCanInvalidIndexCount As System.Windows.Forms.Label
    Friend WithEvents LabelCanUnknownIdentifierCount As System.Windows.Forms.Label
    Friend WithEvents LabelCanISREnteredCount As System.Windows.Forms.Label
    Friend WithEvents LabelCanRX1Filt2Count As System.Windows.Forms.Label
    Friend WithEvents LabelCanRX0Filt1Count As System.Windows.Forms.Label
    Friend WithEvents LabelCanRX0Filt0Count As System.Windows.Forms.Label
    Friend WithEvents LabelCanTX2Count As System.Windows.Forms.Label
    Friend WithEvents LabelCanTX1Count As System.Windows.Forms.Label
    Friend WithEvents LabelCanErrorFlagCount As System.Windows.Forms.Label
    Friend WithEvents LabelCanCXECReg As System.Windows.Forms.Label
    Friend WithEvents CheckBoxFaultBitF As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxFaultBitE As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxFaultBitD As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxFaultBitC As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxFaultBitB As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxFaultBitA As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxFaultBit9 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxFaultBit8 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxFaultBit7 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxFaultBit6 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxFaultBit5 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxFaultBit4 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxFaultBit3 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxFaultBit2 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxFaultBit1 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxFaultBit0 As System.Windows.Forms.CheckBox
    Friend WithEvents LabelFirmwareVerssion As System.Windows.Forms.Label
    Friend WithEvents LabelAgileInfo As System.Windows.Forms.Label
    Friend WithEvents TextBoxInput2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxInput1 As System.Windows.Forms.TextBox
    Friend WithEvents ButtonUpdateInput1 As System.Windows.Forms.Button
    Friend WithEvents ButtonUpdateInput2 As System.Windows.Forms.Button
    Friend WithEvents LabelValue1 As System.Windows.Forms.Label
    Friend WithEvents LabelValue2 As System.Windows.Forms.Label
    Friend WithEvents LabelValue3 As System.Windows.Forms.Label
    Friend WithEvents LabelValue4 As System.Windows.Forms.Label
    Friend WithEvents LabelValue5 As System.Windows.Forms.Label
    Friend WithEvents LabelValue6 As System.Windows.Forms.Label
    Friend WithEvents LabelValue7 As System.Windows.Forms.Label
    Friend WithEvents LabelValue8 As System.Windows.Forms.Label
    Friend WithEvents LabelValue9 As System.Windows.Forms.Label
    Friend WithEvents LabelValue10 As System.Windows.Forms.Label
    Friend WithEvents LabelBoardStatus As System.Windows.Forms.Label
    Friend WithEvents LabelValueDebugF As System.Windows.Forms.Label
    Friend WithEvents LabelValueDebugE As System.Windows.Forms.Label
    Friend WithEvents LabelValueDebugD As System.Windows.Forms.Label
    Friend WithEvents LabelValueDebugC As System.Windows.Forms.Label
    Friend WithEvents LabelValueDebugB As System.Windows.Forms.Label
    Friend WithEvents LabelValueDebugA As System.Windows.Forms.Label
    Friend WithEvents LabelValueDebug9 As System.Windows.Forms.Label
    Friend WithEvents LabelValueDebug8 As System.Windows.Forms.Label
    Friend WithEvents LabelValueDebug7 As System.Windows.Forms.Label
    Friend WithEvents LabelValueDebug6 As System.Windows.Forms.Label
    Friend WithEvents LabelValueDebug5 As System.Windows.Forms.Label
    Friend WithEvents LabelValueDebug4 As System.Windows.Forms.Label
    Friend WithEvents LabelValueDebug3 As System.Windows.Forms.Label
    Friend WithEvents LabelValueDebug2 As System.Windows.Forms.Label
    Friend WithEvents LabelValueDebug1 As System.Windows.Forms.Label
    Friend WithEvents LabelValueDebug0 As System.Windows.Forms.Label
    Friend WithEvents TextBoxEEpromOffSet As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxEEpromScale As System.Windows.Forms.TextBox
    Friend WithEvents ButtonWriteEEprom As System.Windows.Forms.Button
    Friend WithEvents ButtonReadEEprom As System.Windows.Forms.Button
    Friend WithEvents ComboBoxEEpromRegister As System.Windows.Forms.ComboBox
    Friend WithEvents LabelEEpromIndex As System.Windows.Forms.Label
    Friend WithEvents LabelScale As System.Windows.Forms.Label
    Friend WithEvents LabelOffset As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ButtonResetSlave As System.Windows.Forms.Button
    Friend WithEvents LabelRCON As System.Windows.Forms.Label
    Friend WithEvents CheckBoxResetBOR As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxResetIdle As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxResetSleep As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxResetWDT As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxResetSoftware As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxResetExt As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxResetIllegal As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxResetTrap As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxResetPOR As System.Windows.Forms.CheckBox
    Friend WithEvents LabelValue11 As System.Windows.Forms.Label
    Friend WithEvents LabelValue12 As System.Windows.Forms.Label
    Friend WithEvents LabelValue13 As System.Windows.Forms.Label
    Friend WithEvents LabelValue14 As System.Windows.Forms.Label
    Friend WithEvents LabelValue15 As System.Windows.Forms.Label
    Friend WithEvents ButtonUpdateInput3 As System.Windows.Forms.Button
    Friend WithEvents TextBoxInput3 As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxInput4 As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxInput5 As System.Windows.Forms.TextBox
    Friend WithEvents ButtonUpdateInput4 As System.Windows.Forms.Button
    Friend WithEvents ButtonUpdateInput5 As System.Windows.Forms.Button
    Friend WithEvents Splitter1 As System.Windows.Forms.Splitter
    Friend WithEvents LabelDisplay8 As System.Windows.Forms.Label
    Friend WithEvents LabelDisplay7 As System.Windows.Forms.Label
    Friend WithEvents LabelDisplay6 As System.Windows.Forms.Label
    Friend WithEvents LabelDisplay5 As System.Windows.Forms.Label
    Friend WithEvents LabelDisplay4 As System.Windows.Forms.Label
    Friend WithEvents LabelDisplay3 As System.Windows.Forms.Label
    Friend WithEvents LabelDisplay2 As System.Windows.Forms.Label
    Friend WithEvents LabelDisplay1 As System.Windows.Forms.Label
    Friend WithEvents CheckBoxOperateEthernet As System.Windows.Forms.CheckBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents CheckBoxOperatePulseSync As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxOperateMagnetronCurrentMon As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxOperateGunDriver As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxOperateHtrMag As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxOperateCooling As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxOperateAFC As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxOperateIonPump As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxOperateHVLambda As System.Windows.Forms.CheckBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents CheckBoxPulseSyncConnected As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxPulseCurrentMonitorConnected As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxGunDriverConnected As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxHtrMagConnected As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxCoolingConnected As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxAFCConnected As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxIonPumpConnected As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxHVLambdaConnected As System.Windows.Forms.CheckBox
    Friend WithEvents LabelECBTime As System.Windows.Forms.Label
    Friend WithEvents LabelComputerTime As System.Windows.Forms.Label
    Friend WithEvents ButtonSetTime As System.Windows.Forms.Button
    Friend WithEvents ButtonStopLog As System.Windows.Forms.Button
    Friend WithEvents ButtonStartLog As System.Windows.Forms.Button
    Friend WithEvents LabelECBState As System.Windows.Forms.Label
    Friend WithEvents CheckBoxSyncBitF As System.Windows.Forms.CheckBox
    Friend WithEvents ButtonToggleResetDebug As System.Windows.Forms.Button
    Friend WithEvents CheckBoxSyncBit8 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxSyncBit7 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxSyncBit6 As System.Windows.Forms.CheckBox
    Friend WithEvents ButtonTogglePulseSyncXray As System.Windows.Forms.Button
    Friend WithEvents CheckBoxSyncBit5 As System.Windows.Forms.CheckBox
    Friend WithEvents ButtonTogglePulseSyncHV As System.Windows.Forms.Button
    Friend WithEvents CheckBoxSyncBit4 As System.Windows.Forms.CheckBox
    Friend WithEvents ButtonToggleHighSpeedDataLogging As System.Windows.Forms.Button
    Friend WithEvents CheckBoxSyncBit3 As System.Windows.Forms.CheckBox
    Friend WithEvents LabelSyncMessageCntrlBits As System.Windows.Forms.Label
    Friend WithEvents CheckBoxSyncBit2 As System.Windows.Forms.CheckBox
    Friend WithEvents ButtonToggleCoolantFault As System.Windows.Forms.Button
    Friend WithEvents CheckBoxSyncBit1 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxSyncBit0 As System.Windows.Forms.CheckBox
    Friend WithEvents ButtonToggleReset As System.Windows.Forms.Button
    Friend WithEvents CheckBoxControlBit1 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxControlBit0 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxControlBit2 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxControlBit3 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxControlBit4 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxControlBit5 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxControlBit6 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxControlBit7 As System.Windows.Forms.CheckBox
    Friend WithEvents LabelGuiVersion As System.Windows.Forms.Label
    Friend WithEvents LabelRangeInput1 As System.Windows.Forms.Label
    Friend WithEvents LabelRangeInput2 As System.Windows.Forms.Label
    Friend WithEvents LabelRangeInput3 As System.Windows.Forms.Label
    Friend WithEvents LabelRangeInput4 As System.Windows.Forms.Label
    Friend WithEvents LabelRangeInput5 As System.Windows.Forms.Label
    Friend WithEvents ButtonReloadECBDefaults As System.Windows.Forms.Button
    Friend WithEvents ButtonZeroOnTime As System.Windows.Forms.Button
    Friend WithEvents ButtonZeroPulseCounters As System.Windows.Forms.Button
    Friend WithEvents ButtonToggleMode As System.Windows.Forms.Button
    Friend WithEvents CheckBoxLoggedBitF As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxLoggedBit0 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxLoggedBit1 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxLoggedBit2 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxLoggedBit3 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxLoggedBit4 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxLoggedBit5 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxLoggedBit6 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxLoggedBit7 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxLoggedBit8 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxLoggedBit9 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxLoggedBitA As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxLoggedBitB As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxLoggedBitC As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxLoggedBitD As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxLoggedBitE As System.Windows.Forms.CheckBox
    Friend WithEvents ButtonSetRevSN As System.Windows.Forms.Button
    Friend WithEvents ButtonSaveFactorySettings As System.Windows.Forms.Button
    Friend WithEvents ButtonLoadFactorySettings As System.Windows.Forms.Button
End Class
