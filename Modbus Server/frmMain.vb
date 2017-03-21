
Imports System
Imports System.IO
Imports CustomControls

Public Class frmMain

    Public Const TAB_LOCATION_X_LARGE As UInt16 = 12
    Public Const TAB_LOCATION_X_SMALL As UInt16 = 350
    Public Const TAB_LOCATION_Y As UInt16 = 138 '1
    Public Const TAB_SIZE_WIDTH_LARGE As UInt16 = 1000
    Public Const TAB_SIZE_WIDTH_SMALL As UInt16 = 680
    Public Const TAB_SIZE_HEIGHT As UInt16 = 650 '718 '580

    Public Const DISP_BUTTON_WIDTH = 220
    Public Const DISP_BUTTON_HEIGHT = 30
    Public Const DISP_BUTTON_HEIGHT_SELECT = 45

    Public Const ETM_CAN_ADDR_ETHERNET_BOARD = 14
    Public Const ETM_CAN_ADDR_ION_PUMP_BOARD = 1
    Public Const ETM_CAN_ADDR_MAGNETRON_CURRENT_BOARD = 2
    Public Const ETM_CAN_ADDR_PULSE_SYNC_BOARD = 3
    Public Const ETM_CAN_ADDR_HV_LAMBDA_BOARD = 4
    Public Const ETM_CAN_ADDR_AFC_CONTROL_BOARD = 5
    Public Const ETM_CAN_ADDR_COOLING_INTERFACE_BOARD = 6
    Public Const ETM_CAN_ADDR_HEATER_MAGNET_BOARD = 7
    Public Const ETM_CAN_ADDR_GUN_DRIVER_BOARD = 8

    Public Const REGISTER_HEATER_CURRENT_AT_STANDBY As UInt16 = &H0
    Public Const REGISTER_ELECTROMAGNET_CURRENT_HIGH_ENERGY As UInt16 = &H1
    Public Const REGISTER_ELECTROMAGNET_CURRENT_LOW_ENERGY As UInt16 = &HC
    Public Const REGISTER_HOME_POSITION As UInt16 = &H5
    Public Const REGISTER_AFC_OFFSET As UInt16 = &H9
    Public Const REGISTER_AFC_AFT_CONTROL_VOLTAGE_HIGH_ENERGY As UInt16 = &HA
    Public Const REGISTER_AFC_AFT_CONTROL_VOLTAGE_LOW_ENERGY As UInt16 = &HB

    Public Const REGISTER_HIGH_ENERGY_SET_POINT As UInt16 = &H10
    Public Const REGISTER_LOW_ENERGY_SET_POINT As UInt16 = &H11
    Public Const REGISTER_ECB_SYSTEM_SERIAL_NUMBER As UInt16 = &H1F

    Public Const REGISTER_GUN_DRIVER_HEATER_VOLTAGE As UInt16 = &H20
    Public Const REGISTER_GUN_DRIVER_HIGH_ENERGY_PULSE_TOP_VOLTAGE As UInt16 = &H21
    Public Const REGISTER_GUN_DRIVER_LOW_ENERGY_PULSE_TOP_VOLTAGE As UInt16 = &H22
    Public Const REGISTER_GUN_DRIVER_CATHODE_VOLTAGE As UInt16 = &H23

    Public Const REGISTER_PULSE_SYNC_GRID_PULSE_DELAY_HIGH_ENERGY_A_B As UInt16 = &H30
    Public Const REGISTER_PULSE_SYNC_GRID_PULSE_DELAY_HIGH_ENERGY_C_D As UInt16 = &H31
    Public Const REGISTER_PULSE_SYNC_RF_TRIGGER_AND_THYRATRON_PULSE_DELAY_HIGH_ENERGY As UInt16 = &H32
    Public Const REGISTER_PULSE_SYNC_GRID_PULSE_WIDTH_HIGH_ENERGY_A_B As UInt16 = &H34
    Public Const REGISTER_PULSE_SYNC_GRID_PULSE_WIDTH_HIGH_ENERGY_C_D As UInt16 = &H35
    Public Const REGISTER_PULSE_SYNC_AFC_AND_SPARE_PULSE_DELAY_HIGH_ENERGY As UInt16 = &H36
    Public Const REGISTER_PULSE_SYNC_GRID_PULSE_DELAY_LOW_ENERGY_A_B As UInt16 = &H38
    Public Const REGISTER_PULSE_SYNC_GRID_PULSE_DELAY_LOW_ENERGY_C_D As UInt16 = &H39
    Public Const REGISTER_PULSE_SYNC_RF_TRIGGER_AND_THYRATRON_PULSE_DELAY_LOW_ENERGY As UInt16 = &H3A
    Public Const REGISTER_PULSE_SYNC_GRID_PULSE_WIDTH_LOW_ENERGY_A_B As UInt16 = &H3C
    Public Const REGISTER_PULSE_SYNC_GRID_PULSE_WIDTH_LOW_ENERGY_C_D As UInt16 = &H3D
    Public Const REGISTER_PULSE_SYNC_AFC_AND_SPARE_PULSE_DELAY_LOW_ENERGY As UInt16 = &H3E
    Public Const REGISTER_CMD_AFC_SELECT_AFC_MODE As UInt16 = &H5202
    Public Const REGISTER_CMD_AFC_SELECT_MANUAL_MODE As UInt16 = &H5203
    Public Const REGISTER_CMD_AFC_MANUAL_TARGET_POSITION As UInt16 = &H5204

    Public Const REGISTER_CMD_COOLANT_INTERFACE_ALLOW_25_MORE_SF6_PULSES As UInt16 = &H6200
    Public Const REGISTER_CMD_COOLANT_INTERFACE_ALLOW_SF6_PULSES_WHEN_PRESSURE_BELOW_LIMIT As UInt16 = &H6201
    Public Const REGISTER_CMD_COOLANT_INTERFACE_SET_SF6_PULSES_IN_BOTTLE As UInt16 = &H6202

    Public Const REGISTER_CMD_ECB_RESET_FAULTS As UInt16 = &HE200

    Public Const REGISTER_SYSTEM_SET_TIME As UInt16 = &HE300
    Public Const REGISTER_SYSTEM_ENABLE_HIGH_SPEED_LOGGING As UInt16 = &HE301
    Public Const REGISTER_SYSTEM_DISABLE_HIGH_SPEED_LOGGING As UInt16 = &HE302
    Public Const REGISTER_SYSTEM_ECB_LOAD_FACTORY_SETTINGS_FROM_EEPROM_MIRROR_AND_REBOOT As UInt16 = &HE303
    ' reserved for future changes
    Public Const REGISTER_SYSTEM_ECB_MAGNETRON_CONDITIONING As UInt16 = &HE304


    Public Const REGISTER_ETM_ECB_RESET_ARC_AND_PULSE_COUNT As UInt16 = &HE400
    Public Const REGISTER_ETM_ECB_RESET_SECONDS_POWERED_HV_ON_XRAY_ON As UInt16 = &HE401
    Public Const REGISTER_ETM_ECB_SEND_SLAVE_RELOAD_EEPROM_WITH_DEFAULTS As UInt16 = &HE402
    Public Const REGISTER_ETM_ECB_LOAD_DEFAULT_SYSTEM_SETTINGS_AND_REBOOT As UInt16 = &HE403
    Public Const REGISTER_ETM_ECB_SAVE_FACTORY_SETTINGS_TO_EEPROM_MIRROR As UInt16 = &HE404


    Public Const REGISTER_DEBUG_TOGGLE_RESET_DEBUG As UInt16 = &HE500
    Public Const REGISTER_DEBUG_GUN_DRIVER_RESET_FPGA As UInt16 = &HE501
    Public Const REGISTER_DEBUG_RESET_MCU As UInt16 = &HE502
    Public Const REGISTER_DEBUG_TEST_PULSE_FAULT As UInt16 = &HE503




    Dim dispButtons() As CustomControls.ButtonSelected
    Dim dispLeds() As OvalLed
    Dim board_indexes() As UInt16


    Public EEProm_index As UInt16


    Public board_index As Byte

    Public access_level As Byte  ' 0: operator, 1: service, 2: developer mode
    Dim pwScreen As frmPassword
    Private show_cargo_settings As Boolean = True  ' for pulse sync screen

    Public pulse_log_enabled As Boolean
    Dim blank_string As String = "----"

    Public ion_pump_log_enabled As Boolean
    Public ion_pump_log_file_name As String

    Public form_hidden As Boolean
    Public hidden_wait_count As UInt16

    Private set_commands(SET_CMDS.LENGTH) As SET_COMMAND_STRUCTURE



    Private Sub frmMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            dispButtons = New ButtonSelected() {btnDispOverview, btnDispSysCPU, btnDispGunDriver, btnDispCoolSF6, btnDispPulseSync, btnDispHV, btnDispMagnetron, btnDispAFC, btnDispMagHtr, btnDispIonPump, btnDispService, btnDispServicePanel, btnDispDeveloperPanel}
            dispLeds = New OvalLed() {ledReadyCpu, ledReadyGunDriver, ledReadyCooling, ledReadyPulseSync, ledReadyHV, ledReadyMagnetron, ledReadyAfc, ledReadyMagnetHtr, ledReadyIonpump}
            board_indexes = New UInt16() {0,
                                        MODBUS_COMMANDS.MODBUS_WR_ETHERNET,
                                       MODBUS_COMMANDS.MODBUS_WR_GUN_DRIVER,
                                       MODBUS_COMMANDS.MODBUS_WR_COOLING,
                                       MODBUS_COMMANDS.MODBUS_WR_PULSE_SYNC,
                                       MODBUS_COMMANDS.MODBUS_WR_HVLAMBDA,
                                       MODBUS_COMMANDS.MODBUS_WR_MAGNETRON_CURRENT,
                                       MODBUS_COMMANDS.MODBUS_WR_AFC,
                                       MODBUS_COMMANDS.MODBUS_WR_HTR_MAGNET,
                                       MODBUS_COMMANDS.MODBUS_WR_ION_PUMP}
            Application.DoEvents()

            txtIonPumpLogInterval.Text = My.Settings.IonPumpLogInterval
 

            '     TextBoxIPAddress.Text = ServerSettings.txtIPAddr.Text
            '     ModBusPort = 502      'Modbus = 502 , Explicit Ethernet/IP = 44818 (TCP) , Implicit Ethernet/IP = 2222 (UDP)
            TimerUpdate.Enabled = True
#If False Then
            TabBoards.SelectedIndex = 0  ' set to overview

            TabBoards.Location = New Point(TAB_LOCATION_X_LARGE, TAB_LOCATION_Y)
            TabBoards.Size = New Size(TAB_SIZE_WIDTH_LARGE, TAB_SIZE_HEIGHT)
#Else
            Call btnDisp_Click(btnDispOverview, AcceptButton)
#End If

        Catch ex As Exception
            MessageBox.Show("Exception caught in FormMain.FormMainLoad  " + ex.ToString)
        End Try


        pwScreen = New frmPassword
        reset_access_level()



        '  Me.BackColor = Color.LightCoral
        '  Splitter1.BackColor = Color.Coral

        If (System.Deployment.Application.ApplicationDeployment.IsNetworkDeployed) Then
            Dim verDeployed As System.Version = My.Application.Deployment.CurrentVersion
            LabelGUIVersion.Text = "GUI Version " & verDeployed.ToString
        Else
            LabelGUIVersion.Text = "GUI Version 1.00"  '"GUI Version not Available in Debug Mode"
        End If

        LoadLogRegisterText()
        init_set_commands()
        ServerSettings.delete_older_dump_data_files()

        Me.Size = New System.Drawing.Size(1330, 760)

        DisplayMainPane(False) ' update controls first, then show

        DisplayBoardSpecificData(False)

        form_hidden = False
        hidden_wait_count = 10

    End Sub


    Private Sub frmMain_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        Try
            TimerUpdate.Enabled = False
            My.Settings.IonPumpLogInterval = Val(txtIonPumpLogInterval.Text)
            ServerSettings.Close()
        Catch ex As Exception
            MessageBox.Show("Exception caught in FormMain.FormClosed  " + ex.ToString)
        End Try

    End Sub

    Private Sub frmMain_Move(sender As Object, e As EventArgs) Handles MyBase.Move
        Me.CenterToScreen()
    End Sub



    Private Sub TimerUpdate_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimerUpdate.Tick
        Dim ivalue As Integer
        Static connected As Boolean = False
        Static admin_param_checked As Boolean = False
        Static last_log_time As DateTime

        TimerUpdate.Enabled = False

        Try
            Dim instances() As Process = Process.GetProcessesByName(Process.GetCurrentProcess.ProcessName)

            If (hidden_wait_count >= 10) Then
                If (instances.Length > 1) Then
                    form_hidden = Not form_hidden
                    Me.Visible = Not form_hidden
                    hidden_wait_count = 0
                End If
            Else
                hidden_wait_count = CUShort(hidden_wait_count + 1)
            End If
        Catch
            MsgBox(Err.Description)

        End Try



        ServerSettings.board_to_monitor = CByte(board_index)

        ivalue = ServerSettings.get_modbus_status()
#If DEMO_MODE = 0 Then
        If (ivalue <= 2) Then
            connected = False
            Me.Text = "2.5MeV Linac GUI(Linac Disconnected)"
           ' blank all display
            reset_access_level()
            DisplayMainPane(True)
            DisplayBoardSpecificData(True)

        Else
#End If
        connected = True
        ServerSettings.event_log_enabled = True
        Me.Text = "2.5MeV Linac GUI"
        '   Splitter1.BackColor = Color.LightSteelBlue


        ' ------------------------------------------------------------------------------------------------------------'
        ' Display System Data in the left pane
        DisplayMainPane(False)

        ' ------------------------------------------------------------------------------------------------------------'
        ' UDisplay the board specific data and buttons in the right plane
        '      DisplayBoardCommonElements(board_index)
        DisplayBoardSpecificData(False)
        '       DisplayDebugData()

        ' check ion pump logging
        If (access_level > 1) Then
            If (ion_pump_log_enabled) Then
                If (Now - last_log_time).TotalSeconds > Val(txtIonPumpLogInterval.Text) Then
                    lblIonEi.Text = Format(ServerSettings.ETMEthernetBoardLoggingData(MODBUS_COMMANDS.MODBUS_WR_ION_PUMP).log_data(2) / 1000, "0.000")
                    lblIonIi.Text = Format(ServerSettings.ETMEthernetBoardLoggingData(MODBUS_COMMANDS.MODBUS_WR_ION_PUMP).log_data(3) / 100, "0.00")
                    logIonPump(lblIonEi.Text + "," + lblIonIi.Text)
                    last_log_time = Now
                End If
            End If
        End If

#If DEMO_MODE = 0 Then
       End If ' connected
#End If
        TimerUpdate.Enabled = True


    End Sub


    Private Sub DisplayBoardCommonElements(ByVal selected_baord As Byte)
        'Convert.ToChar(ServerSettings.ETMEthernetBoardLoggingData(board_index).agile_rev_ascii) 


    End Sub

    Private Sub DisplayBoardSpecificData(ByVal bBlank_disp As Boolean)
        Dim uTemp As UShort
        Dim lTemp As ULong


        Select Case TabBoards.SelectedIndex
            Case 0 ' overview
                If (bBlank_disp) Then
                    lblCoolTemp.Text = blank_string
                    lblCabTemp.Text = blank_string
                    lblGdTemp.Text = blank_string
                    lblSF6Pressure.Text = blank_string

                    Meter.Value = 0
                    lblAutofillRemain1.Text = blank_string
                    btnReenableAutofill1.Enabled = False
                Else
                    lblCoolTemp.Text = ServerSettings.ETMEthernetBoardLoggingData(MODBUS_COMMANDS.MODBUS_WR_COOLING).log_data(9) / 10 - 272
                    lblCabTemp.Text = ServerSettings.ETMEthernetBoardLoggingData(MODBUS_COMMANDS.MODBUS_WR_COOLING).log_data(10) / 10 - 272
                    lblGdTemp.Text = Format(Convert.ToUInt16(ServerSettings.ETMEthernetBoardLoggingData(MODBUS_COMMANDS.MODBUS_WR_GUN_DRIVER).log_data(4)) * 0.01, "0.0")
                    lblSF6Pressure.Text = Format(ServerSettings.ETMEthernetBoardLoggingData(MODBUS_COMMANDS.MODBUS_WR_COOLING).log_data(11) / 100, "00.00")

                    uTemp = ServerSettings.ETMEthernetBoardLoggingData(MODBUS_COMMANDS.MODBUS_WR_COOLING).ecb_local_data(0)
                    Meter.MaxValue = IIf(uTemp < 700, 700, uTemp)
                    Meter.Value = ServerSettings.ETMEthernetBoardLoggingData(MODBUS_COMMANDS.MODBUS_WR_COOLING).log_data(14)
                    uTemp = ServerSettings.ETMEthernetBoardLoggingData(MODBUS_COMMANDS.MODBUS_WR_COOLING).log_data(12)
                    lblAutofillRemain1.Text = uTemp
                    btnReenableAutofill1.Enabled = IIf(uTemp = 0, True, False)

                End If
            Case 1 ' cpu
                If (bBlank_disp) Then
                    lblCpuPwrOnTime.Text = blank_string
                    lblCpuHvTime.Text = blank_string
                    lblCpuXrayTime.Text = blank_string
                    lblCpuMagnetronPwr.Text = blank_string
                    lblCpuWarmupThy.Text = blank_string
                    lblCpuWarmupMag.Text = blank_string
                    lblCpuWarmupGd.Text = blank_string

                    ledCpuXrayLogic.FillColor = Color.Red
                    '  ledCpuDriveup.FillColor = Color.Red
                    ledCpuReadyFault.FillColor = Color.Red
                    ledWCpuXrayDisabled.FillColor = Color.Transparent
                    ledWCpuDriveupTimeout.FillColor = Color.Transparent

                Else
                    lTemp = ServerSettings.ETMEthernetBoardLoggingData(MODBUS_COMMANDS.MODBUS_WR_ETHERNET).log_data(9) * 2 ^ 16 + ServerSettings.ETMEthernetBoardLoggingData(MODBUS_COMMANDS.MODBUS_WR_ETHERNET).log_data(8)
                    lblCpuPwrOnTime.Text = Format(Math.Truncate(lTemp / 3600), "#####0") + " : " + Format(Math.Truncate(lTemp / 60) Mod 60, "00") + " : " + Format(Math.Truncate(lTemp) Mod 60, "00")
                    lTemp = ServerSettings.ETMEthernetBoardLoggingData(MODBUS_COMMANDS.MODBUS_WR_ETHERNET).log_data(11) * 2 ^ 16 +
                                                       ServerSettings.ETMEthernetBoardLoggingData(MODBUS_COMMANDS.MODBUS_WR_ETHERNET).log_data(10)
                    lblCpuHvTime.Text = Format(Math.Truncate(lTemp / 3600), "#####0") + " : " + Format(Math.Truncate(lTemp / 60) Mod 60, "00") + " : " + Format(Math.Truncate(lTemp) Mod 60, "00")
                    lTemp = ServerSettings.ETMEthernetBoardLoggingData(MODBUS_COMMANDS.MODBUS_WR_ETHERNET).log_data(13) * 2 ^ 16 +
                                                         ServerSettings.ETMEthernetBoardLoggingData(MODBUS_COMMANDS.MODBUS_WR_ETHERNET).log_data(12)
                    lblCpuXrayTime.Text = Format(Math.Truncate(lTemp / 3600), "#####0") + " : " + Format(Math.Truncate(lTemp / 60) Mod 60, "00") + " : " + Format(Math.Truncate(lTemp) Mod 60, "00")
                    lblCpuMagnetronPwr.Text = Format(ServerSettings.ETMEthernetBoardLoggingData(MODBUS_COMMANDS.MODBUS_WR_ETHERNET).log_data(14) / 1000, "0.000")

                    Dim thyratron_warmup As UInt16 = ServerSettings.ETMEthernetBoardLoggingData(MODBUS_COMMANDS.MODBUS_WR_ETHERNET).log_data(4)
                    Dim magnetron_warmup As UInt16 = ServerSettings.ETMEthernetBoardLoggingData(MODBUS_COMMANDS.MODBUS_WR_ETHERNET).log_data(5)
                    Dim gun_warmup As UInt16 = ServerSettings.ETMEthernetBoardLoggingData(MODBUS_COMMANDS.MODBUS_WR_ETHERNET).log_data(6)

                    lblCpuWarmupThy.Text = Format(Math.Truncate(thyratron_warmup / 60), "00") & " : " & Format((thyratron_warmup Mod 60), "00")
                    lblCpuWarmupMag.Text = Format(Math.Truncate(magnetron_warmup / 60), "00") & " : " & Format((magnetron_warmup Mod 60), "00")
                    lblCpuWarmupGd.Text = Format(Math.Truncate(gun_warmup / 60), "00") & " : " & Format((gun_warmup Mod 60), "00")

                    Dim control_bits As UInt16 = ServerSettings.ETMEthernetBoardLoggingData(MODBUS_COMMANDS.MODBUS_WR_ETHERNET).control_notice_bits
                    Dim fault_bits As UInt16 = ServerSettings.ETMEthernetBoardLoggingData(MODBUS_COMMANDS.MODBUS_WR_ETHERNET).fault_bits
                    Dim logged_bits As UInt16 = ServerSettings.ETMEthernetBoardLoggingData(MODBUS_COMMANDS.MODBUS_WR_ETHERNET).logged_bits

                    ledCpuXrayLogic.FillColor = IIf(fault_bits And &H1, Color.Red, Color.LawnGreen)
                    '   ledCpuDriveup.FillColor = IIf(fault_bits And &H2, Color.Red, Color.LawnGreen)
                    ledCpuReadyFault.FillColor = IIf(fault_bits And &H4, Color.Red, Color.LawnGreen)
                    ledWCpuXrayDisabled.FillColor = IIf(logged_bits And &H1, Color.Black, Color.Transparent)
                    ledWCpuDriveupTimeout.FillColor = IIf(logged_bits And &H4, Color.Black, Color.Transparent)

                End If
            Case 2 ' gun driver
                If (bBlank_disp) Then
                    lblGdEk.Text = blank_string
                    lblGdIkp.Text = blank_string
                    lblGdEf.Text = blank_string
                    lblGdIf.Text = blank_string
                    lblGdEg.Text = blank_string
                    lblGdEc.Text = blank_string

                    btnGdEkset.Text = String.Format("{0,-19}", "Ek Set") & blank_string & " kV"
                    btnGdIfSet.Text = String.Format("{0,-22}", "If Set") & blank_string & " A"
                    btnGdEgsetCargo.Text = String.Format("{0,-15}", "Cargo Eg Set") & blank_string & " V"
                    btnGdEgsetCab.Text = String.Format("{0,-17}", "Cab Eg Set") & blank_string & " V"

                    btnGdEkset.Enabled = False
                    btnGdIfSet.Enabled = False
                    btnGdEgsetCargo.Enabled = False
                    btnGdEgsetCab.Enabled = False

                    ledGdFPGArev.FillColor = Color.Red
                    ledGdHVmon.FillColor = Color.Red
                    ledGdHtrMon.FillColor = Color.Red
                    ledGdHtrOC.FillColor = Color.Red
                    ledGdEgMon.FillColor = Color.Red
                    ledGdEcMon.FillColor = Color.Red
                    ledGdCAN.FillColor = Color.Red

                    ledGdArc.FillColor = Color.Red
                    ledGdOT.FillColor = Color.Red
                    ledGdGrid.FillColor = Color.Red
                    ledGdADCread.FillColor = Color.Red
                    ledGdSPIcomm.FillColor = Color.Red
                    ledGdHtrStartup.FillColor = Color.Red

                Else
                    lblGdEk.Text = Format(Convert.ToUInt16(ServerSettings.ETMEthernetBoardLoggingData(MODBUS_COMMANDS.MODBUS_WR_GUN_DRIVER).log_data(1)) * (-0.001), "0.00")
                    lblGdIkp.Text = Format(Convert.ToUInt16(ServerSettings.ETMEthernetBoardLoggingData(MODBUS_COMMANDS.MODBUS_WR_GUN_DRIVER).log_data(0)) * 0.1, "0.0")
                    lblGdEf.Text = Format(Convert.ToUInt16(ServerSettings.ETMEthernetBoardLoggingData(MODBUS_COMMANDS.MODBUS_WR_GUN_DRIVER).log_data(7)) * (-0.001), "0.00")
                    lblGdIf.Text = Format(Convert.ToUInt16(ServerSettings.ETMEthernetBoardLoggingData(MODBUS_COMMANDS.MODBUS_WR_GUN_DRIVER).log_data(6)) * 0.001, "0.00")
                    lblGdEg.Text = Format(Convert.ToInt16(ServerSettings.ETMEthernetBoardLoggingData(MODBUS_COMMANDS.MODBUS_WR_GUN_DRIVER).log_data(3)) * 0.01 - 80, "0.0")
                    lblGdEc.Text = Format(Convert.ToUInt16(ServerSettings.ETMEthernetBoardLoggingData(MODBUS_COMMANDS.MODBUS_WR_GUN_DRIVER).log_data(12)) * -0.01, "0.0")

                    btnGdEkset.Text = String.Format("{0,-19}", "Ek Set") & Format(get_ref_data(REGISTER_GUN_DRIVER_CATHODE_VOLTAGE) * (-0.001), "0.00 kV")
                    btnGdIfSet.Text = String.Format("{0,-22}", "If Set") & Format(get_ref_data(REGISTER_GUN_DRIVER_HEATER_VOLTAGE) * (0.001), "0.00 A")
                    btnGdEgsetCargo.Text = String.Format("{0,-15}", "Cargo Eg Set") & Format(get_ref_data(REGISTER_GUN_DRIVER_HIGH_ENERGY_PULSE_TOP_VOLTAGE) * 0.01 - 80, "0.0 V")
                    btnGdEgsetCab.Text = String.Format("{0,-17}", "Cab Eg Set") & Format(get_ref_data(REGISTER_GUN_DRIVER_LOW_ENERGY_PULSE_TOP_VOLTAGE) * 0.01 - 80, "0.0 V")

                    btnGdEkset.Enabled = IIf(access_level > 1, True, False)
                    btnGdIfSet.Enabled = IIf(access_level > 1, True, False)
                    btnGdEgsetCargo.Enabled = IIf(access_level > 0, True, False)
                    btnGdEgsetCab.Enabled = IIf(access_level > 0, True, False)


                    Dim fault_bits As UInt16 = ServerSettings.ETMEthernetBoardLoggingData(MODBUS_COMMANDS.MODBUS_WR_GUN_DRIVER).fault_bits

                    ledGdFPGArev.FillColor = IIf(fault_bits And &H1, Color.Red, Color.LawnGreen)
                    ledGdHVmon.FillColor = IIf(fault_bits And &H6, Color.Red, Color.LawnGreen)
                    ledGdHtrMon.FillColor = IIf(fault_bits And &H18, Color.Red, Color.LawnGreen)
                    ledGdHtrOC.FillColor = IIf(fault_bits And &H20, Color.Red, Color.LawnGreen)
                    ledGdEgMon.FillColor = IIf(fault_bits And &HC0, Color.Red, Color.LawnGreen) ' 8 and 4
                    ledGdEcMon.FillColor = IIf(fault_bits And &H100, Color.Red, Color.LawnGreen)
                    ledGdCAN.FillColor = IIf(fault_bits And &H800, Color.Red, Color.LawnGreen)


                    ledGdArc.FillColor = IIf(fault_bits And &H200, Color.Red, Color.LawnGreen)
                    ledGdOT.FillColor = IIf(fault_bits And &H400, Color.Red, Color.LawnGreen)
                    ledGdGrid.FillColor = IIf(fault_bits And &H1000, Color.Red, Color.LawnGreen)
                    ledGdADCread.FillColor = IIf(fault_bits And &H2000, Color.Red, Color.LawnGreen)
                    ledGdSPIcomm.FillColor = IIf(fault_bits And &H4000, Color.Red, Color.LawnGreen)
                    ledGdHtrStartup.FillColor = IIf(fault_bits And &H8000, Color.Red, Color.LawnGreen)

                End If
            Case 3 ' Cooling

                If (bBlank_disp) Then
                    lblCoolMagFlow.Text = blank_string
                    lblCoolLinacFlow.Text = blank_string
                    lblCoolCirFlow.Text = blank_string
                    lblCoolCoolTemp.Text = blank_string
                    lblCoolCabTemp.Text = blank_string
                    lblCoolSF6Press.Text = blank_string

                    btnCoolNewSF6bottle.Enabled = False
                    btnCoolSF6Override.Enabled = False
                    btnReenableAutofill2.Enabled = False
                    lblAutofillRemain2.Text = blank_string

                    ledCoolCAN.FillColor = Color.Red
                    ledCoolMagFlow.FillColor = Color.Red
                    ledCoolLinacFlow.FillColor = Color.Red
                    ledCoolCirFlow.FillColor = Color.Red
                    ledCoolCabTempSwitch.FillColor = Color.Red
                    ledCoolCabTemp.FillColor = Color.Red
                    ledCoolCoolTemp.FillColor = Color.Red
                    ledCoolSF6press.FillColor = Color.Red

                    ledWCoolTooCold.FillColor = Color.Transparent
                    ledWSF6TooLowToFill.FillColor = Color.Transparent
                    ledWSF6FillReq.FillColor = Color.Transparent
                    ledWNoSF6Pulses.FillColor = Color.Transparent
                    ledWSF6Filling.FillColor = Color.Transparent
                    ledWSF6RelayClosed.FillColor = Color.Transparent
                Else
                    lblCoolMagFlow.Text = Format(ServerSettings.ETMEthernetBoardLoggingData(MODBUS_COMMANDS.MODBUS_WR_COOLING).log_data(0) / 1000, "0.000")
                    lblCoolLinacFlow.Text = Format(ServerSettings.ETMEthernetBoardLoggingData(MODBUS_COMMANDS.MODBUS_WR_COOLING).log_data(1) / 1000, "0.000")
                    lblCoolCirFlow.Text = Format(ServerSettings.ETMEthernetBoardLoggingData(MODBUS_COMMANDS.MODBUS_WR_COOLING).log_data(2) / 1000, "0.000")
                    lblCoolCoolTemp.Text = ServerSettings.ETMEthernetBoardLoggingData(MODBUS_COMMANDS.MODBUS_WR_COOLING).log_data(9) / 10 - 272
                    lblCoolCabTemp.Text = ServerSettings.ETMEthernetBoardLoggingData(MODBUS_COMMANDS.MODBUS_WR_COOLING).log_data(10) / 10 - 272
                    lblCoolSF6Press.Text = Format(ServerSettings.ETMEthernetBoardLoggingData(MODBUS_COMMANDS.MODBUS_WR_COOLING).log_data(11) / 100, "00.00")

                    btnCoolNewSF6bottle.Enabled = (access_level > 0)
                    uTemp = ServerSettings.ETMEthernetBoardLoggingData(MODBUS_COMMANDS.MODBUS_WR_COOLING).log_data(12)
                    lblAutofillRemain2.Text = uTemp
                    btnReenableAutofill2.Enabled = IIf(uTemp = 0, True, False)

                    '    Dim control_bits As UInt16 = ServerSettings.ETMEthernetBoardLoggingData(board_index).control_notice_bits
                    Dim fault_bits As UInt16 = ServerSettings.ETMEthernetBoardLoggingData(MODBUS_COMMANDS.MODBUS_WR_COOLING).fault_bits
                    Dim logged_bits As UInt16 = ServerSettings.ETMEthernetBoardLoggingData(MODBUS_COMMANDS.MODBUS_WR_COOLING).logged_bits

                    ' only enable override when sf6 is too low to fill
                    btnCoolSF6Override.Enabled = IIf((access_level > 0) And (logged_bits And &H4), True, False)

                    ledCoolCAN.FillColor = IIf(fault_bits And &H1, Color.Red, Color.LawnGreen)
                    ledCoolMagFlow.FillColor = IIf(fault_bits And &H2, Color.Red, Color.LawnGreen)
                    ledCoolLinacFlow.FillColor = IIf(fault_bits And &H4, Color.Red, Color.LawnGreen)
                    ledCoolCirFlow.FillColor = IIf(fault_bits And &H8, Color.Red, Color.LawnGreen)
                    ledCoolCabTempSwitch.FillColor = IIf(fault_bits And &H80, Color.Red, Color.LawnGreen)
                    ledCoolCabTemp.FillColor = IIf(fault_bits And &H200, Color.Red, Color.LawnGreen)
                    ledCoolCoolTemp.FillColor = IIf(fault_bits And &H400, Color.Red, Color.LawnGreen)
                    ledCoolSF6press.FillColor = IIf(fault_bits And &H1000, Color.Red, Color.LawnGreen)

                    ledWCoolTooCold.FillColor = IIf(logged_bits And &H2, Color.Black, Color.Transparent)
                    ledWSF6TooLowToFill.FillColor = IIf(logged_bits And &H4, Color.Black, Color.Transparent)
                    ledWSF6FillReq.FillColor = IIf(logged_bits And &H8, Color.Black, Color.Transparent)
                    ledWNoSF6Pulses.FillColor = IIf(logged_bits And &H10, Color.Black, Color.Transparent)
                    ledWSF6Filling.FillColor = IIf(logged_bits And &H20, Color.Black, Color.Transparent)
                    ledWSF6RelayClosed.FillColor = IIf(logged_bits And &H1, Color.Black, Color.Transparent)
                End If
            Case 4 ' pulse sync

                Dim offset As Byte
                If (show_cargo_settings) Then
                    lblModeSettings.Text = "Cargo Mode Settings"
                    offset = 0
                Else
                    lblModeSettings.Text = "Cab Mode Settings"
                    offset = 8
                End If

                If (bBlank_disp) Then
                    btnPulseStartMax.Text = "Beam Max Start  " & blank_string
                    btnPulseStart2_3.Text = "Beam 2/3 Start  " & blank_string
                    btnPulseStart1_3.Text = "Beam 1/3 Start  " & blank_string
                    btnPulseStartMin.Text = "Beam Min Start  " & blank_string

                    btnPulseStopMax.Text = "Beam Max Stop  " & blank_string
                    btnPulseStop2_3.Text = "Beam 2/3 Stop  " & blank_string
                    btnPulseStop1_3.Text = "Beam 1/3 Stop  " & blank_string
                    btnPulseStopMin.Text = "Beam Min Stop  " & blank_string

                    btnPfnDelay.Text = "PFN Delay " & blank_string
                    btnAfcDelay.Text = "AFC Delay " & blank_string
                    btnPulseSampleDelay.Text = "MagI Sample Delay " & blank_string

                    For Each ctrl In TabPagePulseSync.Controls
                        If (ctrl.GetType = GetType(Button)) Then
                            Dim btn As Button = CType(ctrl, Button)
                            If (btn.Text <> "Change") Then
                                btn.Enabled = False
                            End If
                        End If
                    Next

                    ledPulseXrayTiming.FillColor = Color.Red
                    ledPulseCanFault.FillColor = Color.Red
                    ledPulseRFArc.FillColor = Color.Red
                    ledPulsePFNfan.FillColor = Color.Red
                    ledPulseTriggerStayedOn.FillColor = Color.Red
                    ledPulsePanel.FillColor = Color.Red
                    ledPulseKeylock.FillColor = Color.Red

                    ledWPulseCustomHVon.FillColor = Color.Transparent
                    ledWPulseCustomXrayOn.FillColor = Color.Transparent
                    ledWPulseLowOverride.FillColor = Color.Transparent
                    ledWPulseHighOverride.FillColor = Color.Transparent
                    ledWPulseTrigFault.FillColor = Color.Transparent

                Else
                    Dim enble_button As Boolean = access_level > 0
                    For Each ctrl In TabPagePulseSync.Controls
                        If (ctrl.GetType = GetType(Button)) Then
                            Dim btn As Button = CType(ctrl, Button)
                            If (btn.Text <> "Change") Then
                                btn.Enabled = enble_button
                            End If
                        End If
                    Next

                    btnPulseStartMin.Text = "Beam Min Start  " & (Math.Truncate(get_ref_data(REGISTER_PULSE_SYNC_GRID_PULSE_DELAY_HIGH_ENERGY_C_D + offset) / 256) * 20) & "ns"
                    btnPulseStart1_3.Text = "Beam 1/3 Start  " & ((get_ref_data(REGISTER_PULSE_SYNC_GRID_PULSE_DELAY_HIGH_ENERGY_C_D + offset) And &HFF) * 20) & "ns"
                    btnPulseStart2_3.Text = "Beam 2/3 Start  " & (Math.Truncate(get_ref_data(REGISTER_PULSE_SYNC_GRID_PULSE_DELAY_HIGH_ENERGY_A_B + offset) / 256) * 20) & "ns"
                    btnPulseStartMax.Text = "Beam Max Start  " & ((get_ref_data(REGISTER_PULSE_SYNC_GRID_PULSE_DELAY_HIGH_ENERGY_A_B + offset) And &HFF) * 20) & "ns"

                    btnPulseStopMin.Text = "Beam Min Stop  " & (Math.Truncate(get_ref_data(REGISTER_PULSE_SYNC_GRID_PULSE_WIDTH_HIGH_ENERGY_C_D + offset) / 256) * 20) & "ns"
                    btnPulseStop1_3.Text = "Beam 1/3 Stop  " & ((get_ref_data(REGISTER_PULSE_SYNC_GRID_PULSE_WIDTH_HIGH_ENERGY_C_D + offset) And &HFF) * 20) & "ns"
                    btnPulseStop2_3.Text = "Beam 2/3 Stop  " & (Math.Truncate(get_ref_data(REGISTER_PULSE_SYNC_GRID_PULSE_WIDTH_HIGH_ENERGY_A_B + offset) / 256) * 20) & "ns"
                    btnPulseStopMax.Text = "Beam Max Stop  " & ((get_ref_data(REGISTER_PULSE_SYNC_GRID_PULSE_WIDTH_HIGH_ENERGY_A_B + offset) And &HFF) * 20) & "ns"

                    btnPfnDelay.Text = "PFN Delay " & (Math.Truncate(get_ref_data(REGISTER_PULSE_SYNC_RF_TRIGGER_AND_THYRATRON_PULSE_DELAY_HIGH_ENERGY + offset) / 256) * 20) & "ns"
                    btnAfcDelay.Text = "AFC Delay " & (Math.Truncate(get_ref_data(REGISTER_PULSE_SYNC_AFC_AND_SPARE_PULSE_DELAY_HIGH_ENERGY + offset) / 256) * 20) & "ns"
                    btnPulseSampleDelay.Text = "MagI Sample Delay " & ((get_ref_data(REGISTER_PULSE_SYNC_AFC_AND_SPARE_PULSE_DELAY_HIGH_ENERGY + offset) And &HFF) * 20) & "ns"

                    '    Dim control_bits As UInt16 = ServerSettings.ETMEthernetBoardLoggingData(board_index).control_notice_bits
                    Dim fault_bits As UInt16 = ServerSettings.ETMEthernetBoardLoggingData(MODBUS_COMMANDS.MODBUS_WR_PULSE_SYNC).fault_bits
                    Dim logged_bits As UInt16 = ServerSettings.ETMEthernetBoardLoggingData(MODBUS_COMMANDS.MODBUS_WR_PULSE_SYNC).logged_bits

                    ledPulseXrayTiming.FillColor = IIf(fault_bits And &H1, Color.Red, Color.LawnGreen)
                    ledPulseCanFault.FillColor = IIf(fault_bits And &H2, Color.Red, Color.LawnGreen)
                    ledPulseRFArc.FillColor = IIf(fault_bits And &H4, Color.Red, Color.LawnGreen)
                    ledPulsePFNfan.FillColor = IIf(fault_bits And &H8, Color.Red, Color.LawnGreen)
                    ledPulseTriggerStayedOn.FillColor = IIf(fault_bits And &H10, Color.Red, Color.LawnGreen)
                    ledPulsePanel.FillColor = IIf(fault_bits And &H20, Color.Red, Color.LawnGreen)
                    ledPulseKeylock.FillColor = IIf(fault_bits And &H40, Color.Red, Color.LawnGreen)

                    ledWPulseCustomHVon.FillColor = IIf((logged_bits And &H1) = 0, Color.Black, Color.Transparent)
                    ledWPulseCustomXrayOn.FillColor = IIf((logged_bits And &H2) = 0, Color.Black, Color.Transparent)
                    ledWPulseLowOverride.FillColor = IIf(logged_bits And &H4, Color.Black, Color.Transparent)
                    ledWPulseHighOverride.FillColor = IIf(logged_bits And &H8, Color.Black, Color.Transparent)
                    ledWPulseTrigFault.FillColor = IIf(logged_bits And &H80, Color.Black, Color.Transparent)

                End If
            Case 5 ' hv


                If (bBlank_disp) Then
                    lblHVprePulseVolt.Text = blank_string
                    lblHVcurrent.Text = blank_string
                    btnHVsetCargo.Text = "Cargo V Set  " & blank_string & " kV"
                    btnHVsetCab.Text = "Cab V Set  " & blank_string & " kV"
                    btnHVsetCargo.Enabled = False
                    btnHVsetCab.Enabled = False

                    ledHVCanFault.FillColor = Color.Red

                    ledWHvPowerOff.FillColor = Color.Transparent
                    ledWHvHVoff.FillColor = Color.Transparent
                    ledWHvPhaseLoss.FillColor = Color.Transparent
                    ledWHvOT.FillColor = Color.Transparent
                    ledWHvIntlock.FillColor = Color.Transparent
                    ledWHvLoadFault.FillColor = Color.Transparent
                    ledWHvSumFault.FillColor = Color.Transparent

                    ledHVDriveup.FillColor = Color.Red
                Else
                    lblHVprePulseVolt.Text = Format(ServerSettings.ETMEthernetBoardLoggingData(MODBUS_COMMANDS.MODBUS_WR_HVLAMBDA).log_data(0) / 1000, "0.000")
                    lblHVcurrent.Text = ServerSettings.ETMEthernetBoardLoggingData(MODBUS_COMMANDS.MODBUS_WR_HVLAMBDA).log_data(5) / 1000

                    btnHVsetCargo.Text = "Cargo V Set  " & Format(get_ref_data(REGISTER_HIGH_ENERGY_SET_POINT) / 1000, "0.000") & " kV"
                    btnHVsetCab.Text = "Cab V Set  " & Format(get_ref_data(REGISTER_LOW_ENERGY_SET_POINT) / 1000, "0.000") & " kV"
                    btnHVsetCargo.Enabled = access_level > 0
                    btnHVsetCab.Enabled = access_level > 0

                    '    Dim control_bits As UInt16 = ServerSettings.ETMEthernetBoardLoggingData(board_index).control_notice_bits
                    Dim fault_bits As UInt16 = ServerSettings.ETMEthernetBoardLoggingData(MODBUS_COMMANDS.MODBUS_WR_HVLAMBDA).fault_bits
                    Dim logged_bits As UInt16 = ServerSettings.ETMEthernetBoardLoggingData(MODBUS_COMMANDS.MODBUS_WR_HVLAMBDA).logged_bits

                    ledHVCanFault.FillColor = IIf(fault_bits And &H1, Color.Red, Color.LawnGreen)

                    ledWHvPowerOff.FillColor = IIf(logged_bits And &H1, Color.Black, Color.Transparent)
                    ledWHvHVoff.FillColor = IIf(logged_bits And &H2, Color.Black, Color.Transparent)
                    ledWHvPhaseLoss.FillColor = IIf(logged_bits And &H4, Color.Black, Color.Transparent)
                    ledWHvOT.FillColor = IIf(logged_bits And &H8, Color.Black, Color.Transparent)
                    ledWHvIntlock.FillColor = IIf(logged_bits And &H10, Color.Black, Color.Transparent)
                    ledWHvLoadFault.FillColor = IIf(logged_bits And &H20, Color.Black, Color.Transparent)
                    ledWHvSumFault.FillColor = IIf(logged_bits And &H40, Color.Black, Color.Transparent)

                    fault_bits = ServerSettings.ETMEthernetBoardLoggingData(MODBUS_COMMANDS.MODBUS_WR_ETHERNET).fault_bits
                    ledHVDriveup.FillColor = IIf(fault_bits And &H2, Color.Red, Color.LawnGreen)
                End If
            Case 6 ' Magnetron current

                If (bBlank_disp) Then
                    lblCurrCargoScan.Text = blank_string
                    lblCurrCabScan.Text = blank_string
                    lblCurrPulsesPwrOn.Text = blank_string
                    lblCurrArcsPwrOn.Text = blank_string
                    lblCurrPulsesTotal.Text = blank_string
                    lblCurrArcsTotal.Text = blank_string
                    lblCurrPulsesOutOfRange.Text = blank_string

                    ledCurrCanFault.FillColor = Color.Red
                    ledCurrArcSlow.FillColor = Color.Red
                    ledCurrArcFast.FillColor = Color.Red
                    ledCurrArcCont.FillColor = Color.Red
                    ledCurrFalseTrig.FillColor = Color.Red
                    ledCurrLowPulseCurr.FillColor = Color.Red
                Else
                    lblCurrCargoScan.Text = Format(ServerSettings.ETMEthernetBoardLoggingData(MODBUS_COMMANDS.MODBUS_WR_MAGNETRON_CURRENT).log_data(0) / 100, "0.00")
                    lblCurrCabScan.Text = Format(ServerSettings.ETMEthernetBoardLoggingData(MODBUS_COMMANDS.MODBUS_WR_MAGNETRON_CURRENT).log_data(2) / 100, "0.00")
                    lblCurrPulsesPwrOn.Text = Format(ServerSettings.ETMEthernetBoardLoggingData(MODBUS_COMMANDS.MODBUS_WR_MAGNETRON_CURRENT).log_data(5) * 2 ^ 16 + ServerSettings.ETMEthernetBoardLoggingData(MODBUS_COMMANDS.MODBUS_WR_MAGNETRON_CURRENT).log_data(4), "###,###,###,##0")
                    lblCurrArcsPwrOn.Text = Format(ServerSettings.ETMEthernetBoardLoggingData(MODBUS_COMMANDS.MODBUS_WR_MAGNETRON_CURRENT).log_data(12), "###,###,###,##0") ' need info #12 only?
                    lblCurrPulsesTotal.Text = Format(ServerSettings.ETMEthernetBoardLoggingData(MODBUS_COMMANDS.MODBUS_WR_MAGNETRON_CURRENT).log_data(11) * 2 ^ 48 + ServerSettings.ETMEthernetBoardLoggingData(MODBUS_COMMANDS.MODBUS_WR_MAGNETRON_CURRENT).log_data(10) * 2 ^ 32 + ServerSettings.ETMEthernetBoardLoggingData(MODBUS_COMMANDS.MODBUS_WR_MAGNETRON_CURRENT).log_data(9) * 2 ^ 16 + ServerSettings.ETMEthernetBoardLoggingData(MODBUS_COMMANDS.MODBUS_WR_MAGNETRON_CURRENT).log_data(8), "###,###,###,##0")
                    lblCurrArcsTotal.Text = Format(ServerSettings.ETMEthernetBoardLoggingData(MODBUS_COMMANDS.MODBUS_WR_MAGNETRON_CURRENT).log_data(7) * 2 ^ 16 + ServerSettings.ETMEthernetBoardLoggingData(MODBUS_COMMANDS.MODBUS_WR_MAGNETRON_CURRENT).log_data(6), "###,###,###,##0")
                    lblCurrPulsesOutOfRange.Text = Format(ServerSettings.ETMEthernetBoardLoggingData(MODBUS_COMMANDS.MODBUS_WR_MAGNETRON_CURRENT).log_data(13), "###,###,###,##0")

                    '    Dim control_bits As UInt16 = ServerSettings.ETMEthernetBoardLoggingData(board_index).control_notice_bits
                    Dim fault_bits As UInt16 = ServerSettings.ETMEthernetBoardLoggingData(MODBUS_COMMANDS.MODBUS_WR_MAGNETRON_CURRENT).fault_bits
                    'Dim logged_bits As UInt16 = ServerSettings.ETMEthernetBoardLoggingData(board_index).logged_bits

                    ledCurrCanFault.FillColor = IIf(fault_bits And &H1, Color.Red, Color.LawnGreen)
                    ledCurrArcSlow.FillColor = IIf(fault_bits And &H2, Color.Red, Color.LawnGreen)
                    ledCurrArcFast.FillColor = IIf(fault_bits And &H4, Color.Red, Color.LawnGreen)
                    ledCurrArcCont.FillColor = IIf(fault_bits And &H8, Color.Red, Color.LawnGreen)
                    ledCurrFalseTrig.FillColor = IIf(fault_bits And &H10, Color.Red, Color.LawnGreen)
                    ledCurrLowPulseCurr.FillColor = IIf(fault_bits And &H20, Color.Red, Color.LawnGreen)

                End If
            Case 7 ' AFC

                If (bBlank_disp) Then
                    lblAfcHomePosition.Text = blank_string
                    lblAfcPhaseCtrlV.Text = blank_string
                    lblAfcFilteredError.Text = blank_string
                    lblAfcPreAsample.Text = blank_string
                    lblAfcPreBsample.Text = blank_string

                    btnAfcHomePosSet.Text = "Home Pos Set  " & blank_string
                    btnAfcCargoCtrlVSet.Text = "Cargo Ctrl V Set  " & blank_string & " V"
                    btnAfcCabCtrlVSet.Text = "Cab Ctrl V Set  " & blank_string & " V"
                    btnAfcManualMode.Text = "Manual Mode"
                    btnAfcManualPosition.Visible = False

                    For Each ctrl In TabPageAFC.Controls
                        If (ctrl.GetType = GetType(Button)) Then
                            ctrl.enabled = False
                        End If
                    Next

                    ledAfcCanFault.FillColor = Color.Red
                    ledWAfcManualMode.FillColor = Color.Transparent
                Else
                    Dim filtered_error As Long = CLng(ServerSettings.ETMEthernetBoardLoggingData(MODBUS_COMMANDS.MODBUS_WR_AFC).log_data(4))

                    If filtered_error > 2 ^ 15 Then
                        filtered_error -= 2 ^ 15
                        filtered_error = -filtered_error
                    End If
                    lblAfcHomePosition.Text = ServerSettings.ETMEthernetBoardLoggingData(MODBUS_COMMANDS.MODBUS_WR_AFC).log_data(11)
                    lblAfcPhaseCtrlV.Text = Format(ServerSettings.ETMEthernetBoardLoggingData(MODBUS_COMMANDS.MODBUS_WR_AFC).log_data(8) / 1000, "0.000")
                    lblAfcFilteredError.Text = filtered_error
                    lblAfcPreAsample.Text = ServerSettings.ETMEthernetBoardLoggingData(MODBUS_COMMANDS.MODBUS_WR_AFC).log_data(6)
                    lblAfcPreBsample.Text = ServerSettings.ETMEthernetBoardLoggingData(MODBUS_COMMANDS.MODBUS_WR_AFC).log_data(5)
                    lblAfcManualPosition.Text = get_ref_data(REGISTER_CMD_AFC_MANUAL_TARGET_POSITION)

                    Dim enble_button As Boolean = access_level > 0
                    For Each ctrl In TabPageAFC.Controls
                        If (ctrl.GetType = GetType(Button)) Then
                            ctrl.Enabled = enble_button
                        End If
                    Next

                    btnAfcHomePosSet.Text = "Home Pos Set  " & get_ref_data(REGISTER_HOME_POSITION)
                    btnAfcCargoCtrlVSet.Text = "Cargo Ctrl V Set  " & Format(get_ref_data(REGISTER_AFC_AFT_CONTROL_VOLTAGE_HIGH_ENERGY) / 1000, "0.000") & " V"
                    btnAfcCabCtrlVSet.Text = "Cab Ctrl V Set  " & Format(get_ref_data(REGISTER_AFC_AFT_CONTROL_VOLTAGE_LOW_ENERGY) / 1000, "0.000") & " V"
                    '     btnAfcManualPosition.Text = "Manual Pos  " & ServerSettings.ETMEthernetBoardLoggingData(MODBUS_COMMANDS.MODBUS_WR_AFC).log_data(2)

                    '    Dim control_bits As UInt16 = ServerSettings.ETMEthernetBoardLoggingData(board_index).control_notice_bits
                    Dim fault_bits As UInt16 = ServerSettings.ETMEthernetBoardLoggingData(MODBUS_COMMANDS.MODBUS_WR_AFC).fault_bits
                    Dim logged_bits As UInt16 = ServerSettings.ETMEthernetBoardLoggingData(MODBUS_COMMANDS.MODBUS_WR_AFC).logged_bits

                    btnAfcManualMode.Text = IIf(logged_bits And &H1, "AFC Mode", "Manual Mode")
                    ledAfcCanFault.FillColor = IIf(fault_bits And &H1, Color.Red, Color.LawnGreen)
                    ledWAfcManualMode.FillColor = IIf(logged_bits And &H1, Color.Black, Color.Transparent)
                    btnAfcManualPosition.Visible = (logged_bits And &H1) > 0

                End If
            Case 8 ' Magnet & heater

                If (bBlank_disp) Then
                    lblMagIm.Text = blank_string
                    lblMagEm.Text = blank_string
                    lblMagEf.Text = blank_string
                    lblMagIf.Text = blank_string

                    btnMagCargoIset.Enabled = False
                    btnMagCabIset.Enabled = False
                    btnMagIfSet.Enabled = False
                    btnMagCargoIset.Text = "Cargo Mag I Set  " & blank_string & " A"
                    btnMagCabIset.Text = "Cab Mag I Set  " & blank_string & " A"
                    btnMagIfSet.Text = "Heater I Set  " & blank_string & " A"

                    ledMagIfOCAbs.FillColor = Color.Red
                    ledMagIfOCRel.FillColor = Color.Red
                    ledMagIfUCRel.FillColor = Color.Red
                    ledMagEfUVRel.FillColor = Color.Red
                    ledMagImOCAbs.FillColor = Color.Red
                    ledMagImUCAbs.FillColor = Color.Red
                    ledMagEmUVAbs.FillColor = Color.Red
                    ledMagTempSW.FillColor = Color.Red
                    ledMagCoolFault.FillColor = Color.Red
                    ledMagCanFault.FillColor = Color.Red

                    ledWMagOK.FillColor = Color.Transparent
                    ledWMagHtrOK.FillColor = Color.Transparent
                    ledWMagEfOVLatch.FillColor = Color.Transparent
                    ledWMagOutRelayOpen.FillColor = Color.Transparent
                    ledWMagIfOCActive.FillColor = Color.Transparent
                    ledWMagOTActive.FillColor = Color.Transparent
                Else
                    lblMagIm.Text = Format(ServerSettings.ETMEthernetBoardLoggingData(MODBUS_COMMANDS.MODBUS_WR_HTR_MAGNET).log_data(1) / 1000, "0.00")
                    lblMagEm.Text = Format(ServerSettings.ETMEthernetBoardLoggingData(MODBUS_COMMANDS.MODBUS_WR_HTR_MAGNET).log_data(0) / 1000, "0.00")
                    lblMagEf.Text = Format(ServerSettings.ETMEthernetBoardLoggingData(MODBUS_COMMANDS.MODBUS_WR_HTR_MAGNET).log_data(2) / 1000, "0.00")
                    lblMagIf.Text = Format(ServerSettings.ETMEthernetBoardLoggingData(MODBUS_COMMANDS.MODBUS_WR_HTR_MAGNET).log_data(3) / 1000, "0.00")

                    btnMagCargoIset.Enabled = access_level > 0
                    btnMagCabIset.Enabled = access_level > 0
                    btnMagIfSet.Enabled = access_level > 0
                    btnMagCargoIset.Text = "Cargo Mag I Set  " & Format(get_ref_data(REGISTER_ELECTROMAGNET_CURRENT_HIGH_ENERGY) / 1000, "0.00") & " A"
                    btnMagCabIset.Text = "Cab Mag I Set  " & Format(get_ref_data(REGISTER_ELECTROMAGNET_CURRENT_LOW_ENERGY) / 1000, "0.00") & " A"
                    btnMagIfSet.Text = "Heater I Set  " & Format(get_ref_data(REGISTER_HEATER_CURRENT_AT_STANDBY) / 1000, "0.00") & " A"

                    '    Dim control_bits As UInt16 = ServerSettings.ETMEthernetBoardLoggingData(board_index).control_notice_bits
                    Dim fault_bits As UInt16 = ServerSettings.ETMEthernetBoardLoggingData(MODBUS_COMMANDS.MODBUS_WR_HTR_MAGNET).fault_bits
                    Dim logged_bits As UInt16 = ServerSettings.ETMEthernetBoardLoggingData(MODBUS_COMMANDS.MODBUS_WR_HTR_MAGNET).logged_bits

                    ledMagIfOCAbs.FillColor = IIf(fault_bits And &H1, Color.Red, Color.LawnGreen)
                    ledMagIfOCRel.FillColor = IIf(fault_bits And &H2, Color.Red, Color.LawnGreen)
                    ledMagIfUCRel.FillColor = IIf(fault_bits And &H4, Color.Red, Color.LawnGreen)
                    ledMagEfUVRel.FillColor = IIf(fault_bits And &H8, Color.Red, Color.LawnGreen)
                    ledMagImOCAbs.FillColor = IIf(fault_bits And &H10, Color.Red, Color.LawnGreen)
                    ledMagImUCAbs.FillColor = IIf(fault_bits And &H20, Color.Red, Color.LawnGreen)
                    ledMagEmUVAbs.FillColor = IIf(fault_bits And &H40, Color.Red, Color.LawnGreen)
                    ledMagTempSW.FillColor = IIf(fault_bits And &H200, Color.Red, Color.LawnGreen)
                    ledMagCoolFault.FillColor = IIf(fault_bits And &H80, Color.Red, Color.LawnGreen)
                    ledMagCanFault.FillColor = IIf(fault_bits And &H100, Color.Red, Color.LawnGreen)

                    ledWMagOK.FillColor = IIf(logged_bits And &H1, Color.Black, Color.Transparent)
                    ledWMagHtrOK.FillColor = IIf(logged_bits And &H2, Color.Black, Color.Transparent)
                    ledWMagEfOVLatch.FillColor = IIf(logged_bits And &H4, Color.Black, Color.Transparent)
                    ledWMagOutRelayOpen.FillColor = IIf(logged_bits And &H8, Color.Black, Color.Transparent)
                    ledWMagIfOCActive.FillColor = IIf(logged_bits And &H10, Color.Black, Color.Transparent)
                    ledWMagOTActive.FillColor = IIf(logged_bits And &H20, Color.Black, Color.Transparent)
                End If
            Case 9 ' Ion Pump
                If (bBlank_disp) Then
                    lblIonEi.Text = blank_string
                    lblIonIi.Text = blank_string
                    ledIonCanFault.FillColor = Color.Red
                    ledIonOC.FillColor = Color.Red
                    ledIonUV.FillColor = Color.Red
                Else
                    lblIonEi.Text = Format(ServerSettings.ETMEthernetBoardLoggingData(MODBUS_COMMANDS.MODBUS_WR_ION_PUMP).log_data(2) / 1000, "0.000")
                    lblIonIi.Text = Format(ServerSettings.ETMEthernetBoardLoggingData(MODBUS_COMMANDS.MODBUS_WR_ION_PUMP).log_data(3) / 100, "0.00")

                    '    Dim control_bits As UInt16 = ServerSettings.ETMEthernetBoardLoggingData(board_index).control_notice_bits
                    Dim fault_bits As UInt16 = ServerSettings.ETMEthernetBoardLoggingData(MODBUS_COMMANDS.MODBUS_WR_ION_PUMP).fault_bits
                    '    Dim logged_bits As UInt16 = ServerSettings.ETMEthernetBoardLoggingData(board_index).logged_bits

                    ledIonCanFault.FillColor = IIf(fault_bits And &H1, Color.Red, Color.LawnGreen)
                    ledIonOC.FillColor = IIf(fault_bits And &H2, Color.Red, Color.LawnGreen)
                    ledIonUV.FillColor = IIf(fault_bits And &H8, Color.Red, Color.LawnGreen)
                End If
            Case 10 ' service
                LabelComputerTime.Text = "Computer UTC = 20" & Format(DateTime.UtcNow, "yy/MM/dd HH:mm:ss")
                If (bBlank_disp) Then
                    ledServiceNormalMode.FillColor = Color.Black
                    ledServiceServMode.FillColor = Color.Transparent
                    ledServiceDevMode.FillColor = Color.Transparent

                    ledServicePulseLogActive.FillColor = Color.Transparent
                    '           ledServiceRestoreDefaults.FillColor = Color.Transparent

                    btnServiceModeChange.Enabled = False
                    btnServiceStartLog.Enabled = False
                    btnServiceSaveFactoryDefaults.Enabled = False
                    btnServiceReloadInitialDefaults.Enabled = False
                    btnServiceRestoreFactoryDefaults.Enabled = False
                    btnServiceResetLinacTime.Enabled = False

                    btnServiceModeChange.Text = IIf(access_level > 0, "Logout", "Change Mode")
                    btnServiceStartLog.Text = "Start Pulse Logging"

                    LabelECBTime.Text = "Linac UTC = --------"


                Else
                    ledServiceNormalMode.FillColor = IIf(access_level = 0, Color.Black, Color.Transparent)
                    ledServiceServMode.FillColor = IIf(access_level = 1, Color.Black, Color.Transparent)
                    ledServiceDevMode.FillColor = IIf(access_level = 2, Color.Black, Color.Transparent)

                    '   ledServicePulseLogActive.FillColor = Color.Transparent
                    '        ledServiceRestoreDefaults.FillColor = Color.Transparent


                    btnServiceModeChange.Enabled = True
                    btnServiceStartLog.Enabled = True
                    btnServiceSaveFactoryDefaults.Enabled = access_level > 0
                    btnServiceReloadInitialDefaults.Enabled = access_level > 0
                    btnServiceRestoreFactoryDefaults.Enabled = access_level > 0
                    btnServiceResetLinacTime.Enabled = access_level > 0

                    Dim time As UInt32
                    Dim year As Integer
                    Dim month As Integer
                    Dim day As Integer
                    Dim hour As Integer
                    Dim minute As Integer
                    Dim second As Integer

                    time = ServerSettings.ETMEthernetBoardLoggingData(MODBUS_COMMANDS.MODBUS_WR_ETHERNET).log_data(2) * 2 ^ 16
                    time += ServerSettings.ETMEthernetBoardLoggingData(MODBUS_COMMANDS.MODBUS_WR_ETHERNET).log_data(1)

                    year = CInt(Math.Truncate(time / Constants.YEAR_MULT))
                    time = CUInt(time Mod Constants.YEAR_MULT)
                    month = CInt(Math.Truncate(time / Constants.MONTH_MULT))
                    time = CUInt(time Mod Constants.MONTH_MULT)
                    day = CInt(Math.Truncate(time / Constants.DAY_MULT))
                    time = CUInt(time Mod Constants.DAY_MULT)
                    hour = CInt(Math.Truncate(time / Constants.HOUR_MULT))
                    time = CUInt(time Mod Constants.HOUR_MULT)
                    minute = CInt(Math.Truncate(time / Constants.MIN_MULT))
                    second = CInt(time Mod Constants.MIN_MULT)

                    LabelECBTime.Text = "Linac UTC = 20" & Format(year, "00") & "/" & Format(month, "00") & "/" & Format(day, "00") & " " & Format(hour, "00") & ":" & Format(minute, "00") & ":" & Format(second, "00")




                    btnServiceModeChange.Text = IIf(access_level > 0, "Logout", "Change Mode")
#If DEMO_MODE = 0 Then
                    Dim Sync_data As UInt16 = ServerSettings.ETMEthernetBoardLoggingData(MODBUS_COMMANDS.MODBUS_WR_ETHERNET).log_data(7)
                    If (Sync_data And &H2) > 0 Then
                        btnServiceStartLog.Text = "Stop Pulse Logging"
                        ledServicePulseLogActive.FillColor = Color.Black
                    Else
                        btnServiceStartLog.Text = "Start Pulse Logging"
                        ledServicePulseLogActive.FillColor = Color.Transparent
#If False Then
                        If pulse_log_enabled Then
                            ServerSettings.ClosePulseLogFile()
                            btnServiceStartLog.Text = "Start Pulse Logging"
                            lblLogFileName.Text = "Log File Name: "
                            ToolTip1.SetToolTip(lblLogFileName, "")
                            pulse_log_enabled = False
                        End If
#End If
                    End If
#Else
                    If pulse_log_enabled Then
                        btnServiceStartLog.Text = "Stop Pulse Logging"
                        ledServicePulseLogActive.FillColor = Color.Black
                    Else
                        btnServiceStartLog.Text = "Start Pulse Logging"
                        ledServicePulseLogActive.FillColor = Color.Transparent
                    End If

#End If

                End If
            Case Else
                ' shouldn't happen

        End Select

        If (TabBoards.SelectedIndex >= 1 And TabBoards.SelectedIndex <= 9) And (access_level > 0) Then
            LabelAgileInfo.Text = "A" & ServerSettings.ETMEthernetBoardLoggingData(board_index).agile_number & "-" &
                Format(ServerSettings.ETMEthernetBoardLoggingData(board_index).agile_dash, "000") & "  Rev-" &
                Convert.ToChar(ServerSettings.ETMEthernetBoardLoggingData(board_index).agile_rev_ascii) & "  SN-" &
                ServerSettings.ETMEthernetBoardLoggingData(board_index).serial_number 'Dparker need to add in the first Char
            LabelFirmwareVerssion.Text = "Firmware Version " &
                ServerSettings.ETMEthernetBoardLoggingData(board_index).firmware_agile_rev & "." &
                ServerSettings.ETMEthernetBoardLoggingData(board_index).firmware_branch & "." &
                ServerSettings.ETMEthernetBoardLoggingData(board_index).firmware_branch_rev
            LabelAgileInfo.Visible = True
            LabelFirmwareVerssion.Visible = True
        Else
            LabelAgileInfo.Visible = False
            LabelFirmwareVerssion.Visible = False
        End If


    End Sub







    Private Sub DisplayMainPane(ByVal blanking As Boolean)

        ' Update the ECB State
        Dim ECBState As String = ""
        Dim ECBMode As String = ""
        Static flash_toggle As Boolean = True

        Dim show_reset_button As Boolean = False
        Dim state_label_color As Color = Color.FromArgb(0, 110, 199)
        Dim rad_panel_visible As Boolean = False

        Static bData_dumped As Boolean = False


        flash_toggle = Not flash_toggle

        If (blanking) Then

            LabelECBState.ForeColor = Color.Red
            LabelECBState.Text = "State: No Ethernet" '& blank_string & blank_string
            LabelECBState.Visible = flash_toggle

            lblScanMode.Text = "Mode: " & blank_string & blank_string
            btnResetFault.Visible = False
            lblDoseRate.Text = blank_string
            lblPulseFreq.Text = blank_string
            lblDoseCommand.Text = blank_string
            lblBeamDuration.Text = blank_string

            lblIonIi2.Text = blank_string

            For i = 1 To 9
                dispButtons(i).BackColor = Color.Yellow
                dispLeds(i - 1).Visible = False
            Next
            lblSN.Text = "System SN  H" & blank_string
            PanelRadLeft.Visible = False 'flash_toggle
            PanelRadRight.Visible = False ' flash_toggle

            lblAccessLevel.Text = "Access Level: Normal"
            lblNoTrigger.Visible = False

        Else

            Select Case ServerSettings.ETMEthernetBoardLoggingData(MODBUS_COMMANDS.MODBUS_WR_ETHERNET).log_data(0)
                Case &H10
                    ECBState = "Startup"
                Case &H12
                    ECBState = "Wait Personality"
                Case &H15
                    ECBState = "Wait For Init"
                Case &H20
                    ' Calculate the Max warmuptime remaining of the thyratron, magnetron, gun
                    Dim warmuptime As UInt16
                    warmuptime = ServerSettings.ETMEthernetBoardLoggingData(MODBUS_COMMANDS.MODBUS_WR_ETHERNET).log_data(4)
                    warmuptime = Math.Max(warmuptime, ServerSettings.ETMEthernetBoardLoggingData(MODBUS_COMMANDS.MODBUS_WR_ETHERNET).log_data(5))
                    warmuptime = Math.Max(warmuptime, ServerSettings.ETMEthernetBoardLoggingData(MODBUS_COMMANDS.MODBUS_WR_ETHERNET).log_data(6))
                    ECBState = "Warmup " & Math.Truncate(warmuptime / 60) & ":" & Format((warmuptime Mod 60), "00")
                Case &H30
                    ECBState = "Standby"
                Case &H40
                    ECBState = "Drive Up"
                    bData_dumped = False
                Case &H50
                    ECBState = "Ready"
                    bData_dumped = False
                Case &H60
                    ECBState = "X-Ray On"
                    state_label_color = Color.Red
                    rad_panel_visible = flash_toggle
                    If (bData_dumped = False) Then
                        ' check magetron current
                        If (ServerSettings.ETMEthernetBoardLoggingData(MODBUS_COMMANDS.MODBUS_WR_MAGNETRON_CURRENT).log_data(0) >= 5000 Or ServerSettings.ETMEthernetBoardLoggingData(MODBUS_COMMANDS.MODBUS_WR_MAGNETRON_CURRENT).log_data(2) >= 5000) Then
                            ServerSettings.dump_all_data()
                            bData_dumped = True
                        End If
                    End If
                Case &H80
                    ECBState = IIf(access_level > 0, "Fault Hold", "Fault")
                    state_label_color = Color.Red
                    show_reset_button = True
                Case &H86
                    ECBState = IIf(access_level > 0, "Fault Reset Hold", "Fault")
                    state_label_color = Color.Red
                Case &H8A
                    ECBState = IIf(access_level > 0, "Fault Latch Decision", "Fault")
                    state_label_color = Color.Red
                Case &H90
                    ECBState = "Fault Reset"
                Case &HA0
                    ECBState = "System Error"
                    state_label_color = Color.Red
                Case &HB0
                    ECBState = "Warmup Fault"
                    state_label_color = Color.Red
                Case &HC0
                    ECBState = IIf(access_level > 0, "Standby Fault", "Fault")
                    state_label_color = Color.Red
                Case Else
                    ECBState = "Unknown State"
                    state_label_color = Color.Red
            End Select

            btnResetFault.Visible = show_reset_button
            LabelECBState.Visible = True
            LabelECBState.ForeColor = state_label_color
            PanelRadLeft.Visible = rad_panel_visible
            PanelRadRight.Visible = rad_panel_visible


            LabelECBState.Text = "State: " & ECBState

            Dim logged_bits As UInt16 = ServerSettings.ETMEthernetBoardLoggingData(MODBUS_COMMANDS.MODBUS_WR_PULSE_SYNC).logged_bits
            Dim low_mode As Boolean = (logged_bits And &H4) > 0
            Dim high_mode As Boolean = (logged_bits And &H8) > 0

            If (low_mode Xor high_mode) Then
                ECBMode = IIf(low_mode, "Cab Scan", "Cargo Scan")
            Else
                ECBMode = "X-Ray Inhibit"
            End If
            lblScanMode.Text = "Mode: " & ECBMode

            ' Common Display Information
            ' dose rate
            ' pulse freq
            ' trigger duration
            ' beam duration


            ' Calculate the PRF
            Dim prf As UInt16
            prf = ServerSettings.ETMEthernetBoardLoggingData(MODBUS_COMMANDS.MODBUS_WR_PULSE_SYNC).log_data(3)
            If prf <> 0 Then
                ' If the PRF is 0, then no trigger data is sent from the pulse sync board, so the "more accurate value" will store the last trigger sent
                ' If the PRF is not Zero, then triggers are being sent so use the most recent value
                prf = ServerSettings.ETMEthernetBoardLoggingData(MODBUS_COMMANDS.MODBUS_WR_ETHERNET).log_data(3)
            End If

            Dim grid_width As UInt16 = ServerSettings.ETMEthernetBoardLoggingData(MODBUS_COMMANDS.MODBUS_WR_PULSE_SYNC).log_data(11)
            Try
                grid_width = (Math.Truncate(grid_width / 256) - Math.Truncate(grid_width Mod 256)) * 20
            Catch ex As Exception
                grid_width = 0
            End Try

#If False Then
            Dim trigger_width As UInt16 = ServerSettings.ETMEthernetBoardLoggingData(MODBUS_COMMANDS.MODBUS_WR_PULSE_SYNC).log_data(7)
            Try
                trigger_width = Math.Truncate(trigger_width / 256) * 1000
            Catch ex As Exception
                trigger_width = 0
            End Try
#End If

            Dim dose_rate As UInt16 = ServerSettings.ETMEthernetBoardLoggingData(MODBUS_COMMANDS.MODBUS_WR_ETHERNET).log_data(17)
            lblDoseRate.Text = dose_rate
            Dim dose_command As UInt16 = ServerSettings.ETMEthernetBoardLoggingData(MODBUS_COMMANDS.MODBUS_WR_PULSE_SYNC).log_data(7)
            lblDoseCommand.Text = Math.Truncate(dose_command / 256)
            lblBeamDuration.Text = grid_width

            If ((ServerSettings.ETMEthernetBoardLoggingData(MODBUS_COMMANDS.MODBUS_WR_PULSE_SYNC).logged_bits And &H80) > 0) Then
                lblNoTrigger.Location = lblPulseFreq.Location
                lblNoTrigger.BringToFront()
                lblNoTrigger.Visible = True
                lblPulseFreq.Text = "0.0"
            Else
                lblNoTrigger.Visible = False
                lblPulseFreq.Text = Format(prf / 10, "0.0")

            End If

            lblIonIi2.Text = Format(ServerSettings.ETMEthernetBoardLoggingData(MODBUS_COMMANDS.MODBUS_WR_ION_PUMP).log_data(3) / 100, "0.00")



            ' Update the connected Boards, fault status for the tabs

            Dim ConnectedBoards As UInt16 = ServerSettings.ETMEthernetBoardLoggingData(MODBUS_COMMANDS.MODBUS_WR_ETHERNET).log_data(16)

            Dim utemp As UInt16  ' driveup fault from ECB should make HV button red, not ECB
            utemp = ServerSettings.ETMEthernetBoardLoggingData(MODBUS_COMMANDS.MODBUS_WR_ETHERNET).fault_bits And &HFFFD
            btnDispSysCPU.BackColor = IIf(utemp > 0, Color.Red, Color.White)
            btnDispGunDriver.BackColor = IIf((ConnectedBoards And &H100) > 0, IIf(ServerSettings.ETMEthernetBoardLoggingData(MODBUS_COMMANDS.MODBUS_WR_GUN_DRIVER).fault_bits > 0, Color.Red, Color.White), Color.Yellow)
            btnDispCoolSF6.BackColor = IIf((ConnectedBoards And &H40) > 0, IIf(ServerSettings.ETMEthernetBoardLoggingData(MODBUS_COMMANDS.MODBUS_WR_COOLING).fault_bits > 0, Color.Red, Color.White), Color.Yellow)
            btnDispPulseSync.BackColor = IIf((ConnectedBoards And &H8) > 0, IIf(ServerSettings.ETMEthernetBoardLoggingData(MODBUS_COMMANDS.MODBUS_WR_PULSE_SYNC).fault_bits > 0, Color.Red, Color.White), Color.Yellow)
            utemp = (ServerSettings.ETMEthernetBoardLoggingData(MODBUS_COMMANDS.MODBUS_WR_ETHERNET).fault_bits And 2) Or (ServerSettings.ETMEthernetBoardLoggingData(MODBUS_COMMANDS.MODBUS_WR_HVLAMBDA).fault_bits)
            btnDispHV.BackColor = IIf((ConnectedBoards And &H10) > 0, IIf(utemp > 0, Color.Red, Color.White), Color.Yellow)
            btnDispMagnetron.BackColor = IIf((ConnectedBoards And &H4) > 0, IIf(ServerSettings.ETMEthernetBoardLoggingData(MODBUS_COMMANDS.MODBUS_WR_MAGNETRON_CURRENT).fault_bits > 0, Color.Red, Color.White), Color.Yellow)
            btnDispAFC.BackColor = IIf((ConnectedBoards And &H20) > 0, IIf(ServerSettings.ETMEthernetBoardLoggingData(MODBUS_COMMANDS.MODBUS_WR_AFC).fault_bits > 0, Color.Red, Color.White), Color.Yellow)
            btnDispMagHtr.BackColor = IIf((ConnectedBoards And &H80) > 0, IIf(ServerSettings.ETMEthernetBoardLoggingData(MODBUS_COMMANDS.MODBUS_WR_HTR_MAGNET).fault_bits > 0, Color.Red, Color.White), Color.Yellow)
            btnDispIonPump.BackColor = IIf((ConnectedBoards And &H2) > 0, IIf(ServerSettings.ETMEthernetBoardLoggingData(MODBUS_COMMANDS.MODBUS_WR_ION_PUMP).fault_bits > 0, Color.Red, Color.White), Color.Yellow)

            lblSN.Text = "System SN  H" & ServerSettings.ETMEthernetBoardLoggingData(MODBUS_COMMANDS.MODBUS_WR_ETHERNET).log_data(19).ToString("0000")

            For i = 1 To 9
                dispLeds(i - 1).FillColor = IIf((ServerSettings.ETMEthernetBoardLoggingData(board_indexes(i)).control_notice_bits And &H1) > 0, Color.Red, Color.LawnGreen)
            Next
            Select Case access_level
                Case 0
                    lblAccessLevel.Text = "Access Level: Normal"
                Case 1
                    lblAccessLevel.Text = "Access Level: Service"
                Case 2
                    lblAccessLevel.Text = "Access Level: Developer"
                Case Else

            End Select
        End If ' blanking

    End Sub


    Private Sub LoadLogRegisterText()
#If 0 Then


        ServerSettings.EventLogMessages.Add(&H10, "State - Entered State Startup")
        ServerSettings.EventLogMessages.Add(&H10, "	State - Entered State Startup	")
        ServerSettings.EventLogMessages.Add(&H11, "	State - Entered State Wait for Personality from Pulse Sync	")
        ServerSettings.EventLogMessages.Add(&H12, "	State - Entered State Personality Received	")
        ServerSettings.EventLogMessages.Add(&H13, "	Error - Personality not valid 6/4 MeV	")
        ServerSettings.EventLogMessages.Add(&H14, "	Error - Personality not valid 2.5 MeV	")
        ServerSettings.EventLogMessages.Add(&H15, "	State - Entered State Waiting for Initialization	")
        ServerSettings.EventLogMessages.Add(&H16, "	Notice - All Modules Configured	")
        ServerSettings.EventLogMessages.Add(&H17, "	State - Entered State warmup	")
        ServerSettings.EventLogMessages.Add(&H18, "	Notice - Warmup Done	")
        ServerSettings.EventLogMessages.Add(&H19, "	State - Entered State Standby	")
        ServerSettings.EventLogMessages.Add(&H1A, "	Input - HV ON	")
        ServerSettings.EventLogMessages.Add(&H1B, "	State - Entered State Drive Up	")
        ServerSettings.EventLogMessages.Add(&H1C, "	Notice - Drive up Complete	")
        ServerSettings.EventLogMessages.Add(&H1D, "	Input - HV OFF	")
        ServerSettings.EventLogMessages.Add(&H1E, "	Fault - Drive Up Timeout 	")
        ServerSettings.EventLogMessages.Add(&H1F, "	State - Entered State Ready	")
        ServerSettings.EventLogMessages.Add(&H20, "	Input - XRAY ON	")
        ServerSettings.EventLogMessages.Add(&H22, "	State - Entered State XRAY On	")
        ServerSettings.EventLogMessages.Add(&H23, "	Input - XRAY OFF	")
        ServerSettings.EventLogMessages.Add(&H25, "	State - Entered State Fault Hold	")
        ServerSettings.EventLogMessages.Add(&H27, "	State - Entered State Fault Reset	")
        ServerSettings.EventLogMessages.Add(&H28, "	State - Entered State HV Off Faults Clear	")
        ServerSettings.EventLogMessages.Add(&H29, "	State - Entered State System Fault	")

        ServerSettings.EventLogMessages.Add(&H1110, "	Status - Ion Pump Not Ready	")
        ServerSettings.EventLogMessages.Add(&H1111, "	Status - Ion Pump Read	")
        ServerSettings.EventLogMessages.Add(&H1112, "	Status - Ion Pump not Configured	")
        ServerSettings.EventLogMessages.Add(&H1113, "	Status - Ion Pump Configured	")
        ServerSettings.EventLogMessages.Add(&H1114, "	Fault - Ion Pump Connection Lost	")
        ServerSettings.EventLogMessages.Add(&H1115, "	Status - Ion Pump Connection Established	")
        ServerSettings.EventLogMessages.Add(&H1010, "	Fault - Ion Pump 1	")
        ServerSettings.EventLogMessages.Add(&H1011, "	Fault - Ion Pump 2	")
        ServerSettings.EventLogMessages.Add(&H1012, "	Fault - Ion Pump 3	")
        ServerSettings.EventLogMessages.Add(&H1013, "	Fault - Ion Pump 4	")
        ServerSettings.EventLogMessages.Add(&H1014, "	Fault - Ion Pump 5	")
        ServerSettings.EventLogMessages.Add(&H1015, "	Fault - Ion Pump 6	")
        ServerSettings.EventLogMessages.Add(&H1016, "	Fault - Ion Pump 7	")
        ServerSettings.EventLogMessages.Add(&H1017, "	Fault - Ion Pump 8	")
        ServerSettings.EventLogMessages.Add(&H1018, "	Fault - Ion Pump 9	")
        ServerSettings.EventLogMessages.Add(&H1019, "	Fault - Ion Pump 10	")
        ServerSettings.EventLogMessages.Add(&H101A, "	Fault - Ion Pump 11	")
        ServerSettings.EventLogMessages.Add(&H101B, "	Fault - Ion Pump 12	")
        ServerSettings.EventLogMessages.Add(&H101C, "	Fault - Ion Pump 13	")
        ServerSettings.EventLogMessages.Add(&H101D, "	Fault - Ion Pump 14	")
        ServerSettings.EventLogMessages.Add(&H101E, "	Fault - Ion Pump 15	")
        ServerSettings.EventLogMessages.Add(&H101F, "	Fault - Ion Pump 16	")

        ServerSettings.EventLogMessages.Add(&H1120, "	Status - Pulse Current Monitor Not Ready	")
        ServerSettings.EventLogMessages.Add(&H1121, "	Status - Pulse Current Monitor Read	")
        ServerSettings.EventLogMessages.Add(&H1122, "	Status - Pulse Current Monitor not Configured	")
        ServerSettings.EventLogMessages.Add(&H1123, "	Status - Pulse Current Monitor Configured	")
        ServerSettings.EventLogMessages.Add(&H1124, "	Fault - Pulse Current Monitor Connection Lost	")
        ServerSettings.EventLogMessages.Add(&H1125, "	Status - Pulse Current Monitor Connection Established	")
        ServerSettings.EventLogMessages.Add(&H1020, "	Fault - Pulse Current Monitor 1	")
        ServerSettings.EventLogMessages.Add(&H1021, "	Fault - Pulse Current Monitor 2	")
        ServerSettings.EventLogMessages.Add(&H1022, "	Fault - Pulse Current Monitor 3	")
        ServerSettings.EventLogMessages.Add(&H1023, "	Fault - Pulse Current Monitor 4	")
        ServerSettings.EventLogMessages.Add(&H1024, "	Fault - Pulse Current Monitor 5	")
        ServerSettings.EventLogMessages.Add(&H1025, "	Fault - Pulse Current Monitor 6	")
        ServerSettings.EventLogMessages.Add(&H1026, "	Fault - Pulse Current Monitor 7	")
        ServerSettings.EventLogMessages.Add(&H1027, "	Fault - Pulse Current Monitor 8	")
        ServerSettings.EventLogMessages.Add(&H1028, "	Fault - Pulse Current Monitor 9	")
        ServerSettings.EventLogMessages.Add(&H1029, "	Fault - Pulse Current Monitor 10	")
        ServerSettings.EventLogMessages.Add(&H102A, "	Fault - Pulse Current Monitor 11	")
        ServerSettings.EventLogMessages.Add(&H102B, "	Fault - Pulse Current Monitor 12	")
        ServerSettings.EventLogMessages.Add(&H102C, "	Fault - Pulse Current Monitor 13	")
        ServerSettings.EventLogMessages.Add(&H102D, "	Fault - Pulse Current Monitor 14	")
        ServerSettings.EventLogMessages.Add(&H102E, "	Fault - Pulse Current Monitor 15	")
        ServerSettings.EventLogMessages.Add(&H102F, "	Fault - Pulse Current Monitor 16	")

        ServerSettings.EventLogMessages.Add(&H1130, "	Status - Pulse Sync Not Ready	")
        ServerSettings.EventLogMessages.Add(&H1131, "	Status - Pulse Sync Read	")
        ServerSettings.EventLogMessages.Add(&H1132, "	Status - Pulse Sync not Configured	")
        ServerSettings.EventLogMessages.Add(&H1133, "	Status - Pulse Sync Configured	")
        ServerSettings.EventLogMessages.Add(&H1134, "	Fault - Pulse Sync Connection Lost	")
        ServerSettings.EventLogMessages.Add(&H1135, "	Status - Pulse Sync Connection Established	")
        ServerSettings.EventLogMessages.Add(&H1030, "	Fault - Pulse Sync 1	")
        ServerSettings.EventLogMessages.Add(&H1031, "	Fault - Pulse Sync 2	")
        ServerSettings.EventLogMessages.Add(&H1032, "	Fault - Pulse Sync 3	")
        ServerSettings.EventLogMessages.Add(&H1033, "	Fault - Pulse Sync 4	")
        ServerSettings.EventLogMessages.Add(&H1034, "	Fault - Pulse Sync 5	")
        ServerSettings.EventLogMessages.Add(&H1035, "	Fault - Pulse Sync 6	")
        ServerSettings.EventLogMessages.Add(&H1036, "	Fault - Pulse Sync 7	")
        ServerSettings.EventLogMessages.Add(&H1037, "	Fault - Pulse Sync 8	")
        ServerSettings.EventLogMessages.Add(&H1038, "	Fault - Pulse Sync 9	")
        ServerSettings.EventLogMessages.Add(&H1039, "	Fault - Pulse Sync 10	")
        ServerSettings.EventLogMessages.Add(&H103A, "	Fault - Pulse Sync 11	")
        ServerSettings.EventLogMessages.Add(&H103B, "	Fault - Pulse Sync 12	")
        ServerSettings.EventLogMessages.Add(&H103C, "	Fault - Pulse Sync 13	")
        ServerSettings.EventLogMessages.Add(&H103D, "	Fault - Pulse Sync 14	")
        ServerSettings.EventLogMessages.Add(&H103E, "	Fault - Pulse Sync 15	")
        ServerSettings.EventLogMessages.Add(&H103F, "	Fault - Pulse Sync 16	")

        ServerSettings.EventLogMessages.Add(&H1140, "	Status - HV Lambda Not Ready	")
        ServerSettings.EventLogMessages.Add(&H1141, "	Status - HV Lambda Read	")
        ServerSettings.EventLogMessages.Add(&H1142, "	Status - HV Lambda not Configured	")
        ServerSettings.EventLogMessages.Add(&H1143, "	Status - HV Lambda Configured	")
        ServerSettings.EventLogMessages.Add(&H1144, "	Fault - HV Lambda Connection Lost	")
        ServerSettings.EventLogMessages.Add(&H1145, "	Status - HV Lambda Connection Established	")
        ServerSettings.EventLogMessages.Add(&H1040, "	Fault - HV Lambda 1	")
        ServerSettings.EventLogMessages.Add(&H1041, "	Fault - HV Lambda 2	")
        ServerSettings.EventLogMessages.Add(&H1042, "	Fault - HV Lambda 3	")
        ServerSettings.EventLogMessages.Add(&H1043, "	Fault - HV Lambda 4	")
        ServerSettings.EventLogMessages.Add(&H1044, "	Fault - HV Lambda 5	")
        ServerSettings.EventLogMessages.Add(&H1045, "	Fault - HV Lambda 6	")
        ServerSettings.EventLogMessages.Add(&H1046, "	Fault - HV Lambda 7	")
        ServerSettings.EventLogMessages.Add(&H1047, "	Fault - HV Lambda 8	")
        ServerSettings.EventLogMessages.Add(&H1048, "	Fault - HV Lambda 9	")
        ServerSettings.EventLogMessages.Add(&H1049, "	Fault - HV Lambda 10	")
        ServerSettings.EventLogMessages.Add(&H104A, "	Fault - HV Lambda 11	")
        ServerSettings.EventLogMessages.Add(&H104B, "	Fault - HV Lambda 12	")
        ServerSettings.EventLogMessages.Add(&H104C, "	Fault - HV Lambda 13	")
        ServerSettings.EventLogMessages.Add(&H104D, "	Fault - HV Lambda 14	")
        ServerSettings.EventLogMessages.Add(&H104E, "	Fault - HV Lambda 15	")
        ServerSettings.EventLogMessages.Add(&H104F, "	Fault - HV Lambda 16	")

        ServerSettings.EventLogMessages.Add(&H1150, "	Status - AFC Not Ready	")
        ServerSettings.EventLogMessages.Add(&H1151, "	Status - AFC Read	")
        ServerSettings.EventLogMessages.Add(&H1152, "	Status - AFC not Configured	")
        ServerSettings.EventLogMessages.Add(&H1153, "	Status - AFC Configured	")
        ServerSettings.EventLogMessages.Add(&H1154, "	Fault - AFC Connection Lost	")
        ServerSettings.EventLogMessages.Add(&H1155, "	Status - AFC Connection Established	")
        ServerSettings.EventLogMessages.Add(&H1050, "	Fault - AFC 1	")
        ServerSettings.EventLogMessages.Add(&H1051, "	Fault - AFC 2	")
        ServerSettings.EventLogMessages.Add(&H1052, "	Fault - AFC 3	")
        ServerSettings.EventLogMessages.Add(&H1053, "	Fault - AFC 4	")
        ServerSettings.EventLogMessages.Add(&H1054, "	Fault - AFC 5	")
        ServerSettings.EventLogMessages.Add(&H1055, "	Fault - AFC 6	")
        ServerSettings.EventLogMessages.Add(&H1056, "	Fault - AFC 7	")
        ServerSettings.EventLogMessages.Add(&H1057, "	Fault - AFC 8	")
        ServerSettings.EventLogMessages.Add(&H1058, "	Fault - AFC 9	")
        ServerSettings.EventLogMessages.Add(&H1059, "	Fault - AFC 10	")
        ServerSettings.EventLogMessages.Add(&H105A, "	Fault - AFC 11	")
        ServerSettings.EventLogMessages.Add(&H105B, "	Fault - AFC 12	")
        ServerSettings.EventLogMessages.Add(&H105C, "	Fault - AFC 13	")
        ServerSettings.EventLogMessages.Add(&H105D, "	Fault - AFC 14	")
        ServerSettings.EventLogMessages.Add(&H105E, "	Fault - AFC 15	")
        ServerSettings.EventLogMessages.Add(&H105F, "	Fault - AFC 16	")

        ServerSettings.EventLogMessages.Add(&H1160, "	Status - Cooling Not Ready	")
        ServerSettings.EventLogMessages.Add(&H1161, "	Status - Cooling Read	")
        ServerSettings.EventLogMessages.Add(&H1162, "	Status - Cooling not Configured	")
        ServerSettings.EventLogMessages.Add(&H1163, "	Status - Cooling Configured	")
        ServerSettings.EventLogMessages.Add(&H1164, "	Fault - Cooling Connection Lost	")
        ServerSettings.EventLogMessages.Add(&H1165, "	Status - Cooling Connection Established	")
        ServerSettings.EventLogMessages.Add(&H1060, "	Fault - Cooling 1	")
        ServerSettings.EventLogMessages.Add(&H1061, "	Fault - Cooling 2	")
        ServerSettings.EventLogMessages.Add(&H1062, "	Fault - Cooling 3	")
        ServerSettings.EventLogMessages.Add(&H1063, "	Fault - Cooling 4	")
        ServerSettings.EventLogMessages.Add(&H1064, "	Fault - Cooling 5	")
        ServerSettings.EventLogMessages.Add(&H1065, "	Fault - Cooling 6	")
        ServerSettings.EventLogMessages.Add(&H1066, "	Fault - Cooling 7	")
        ServerSettings.EventLogMessages.Add(&H1067, "	Fault - Cooling 8	")
        ServerSettings.EventLogMessages.Add(&H1068, "	Fault - Cooling 9	")
        ServerSettings.EventLogMessages.Add(&H1069, "	Fault - Cooling 10	")
        ServerSettings.EventLogMessages.Add(&H106A, "	Fault - Cooling 11	")
        ServerSettings.EventLogMessages.Add(&H106B, "	Fault - Cooling 12	")
        ServerSettings.EventLogMessages.Add(&H106C, "	Fault - Cooling 13	")
        ServerSettings.EventLogMessages.Add(&H106D, "	Fault - Cooling 14	")
        ServerSettings.EventLogMessages.Add(&H106E, "	Fault - Cooling 15	")
        ServerSettings.EventLogMessages.Add(&H106F, "	Fault - Cooling 16	")

        ServerSettings.EventLogMessages.Add(&H1170, "	Status - Heater Magnet Interface Not Ready	")
        ServerSettings.EventLogMessages.Add(&H1171, "	Status - Heater Magnet Interface Read	")
        ServerSettings.EventLogMessages.Add(&H1172, "	Status - Heater Magnet Interface not Configured	")
        ServerSettings.EventLogMessages.Add(&H1173, "	Status - Heater Magnet Interface Configured	")
        ServerSettings.EventLogMessages.Add(&H1174, "	Fault - Heater Magnet Interface Connection Lost	")
        ServerSettings.EventLogMessages.Add(&H1175, "	Status - Heater Magnet Interface Connection Established	")
        ServerSettings.EventLogMessages.Add(&H1070, "	Fault - HTR-MAG Heater over current absolute	")
        ServerSettings.EventLogMessages.Add(&H1071, "	Fault - HTR-MAG Heater under current absolute	")
        ServerSettings.EventLogMessages.Add(&H1072, "	Fault - HTR-MAG Heater over current relative	")
        ServerSettings.EventLogMessages.Add(&H1073, "	Fault - HTR-MAG Heater under current relative	")
        ServerSettings.EventLogMessages.Add(&H1074, "	Fault - HTR-MAG Heater over voltage absolute	")
        ServerSettings.EventLogMessages.Add(&H1075, "	Fault - HTR-MAG Heater under voltage relative	")
        ServerSettings.EventLogMessages.Add(&H1076, "	Fault - HTR-MAG Magnet over current absolute	")
        ServerSettings.EventLogMessages.Add(&H1077, "	Fault - HTR-MAG Magnet under current absolute	")
        ServerSettings.EventLogMessages.Add(&H1078, "	Fault - HTR-MAG Magnet over current relative	")
        ServerSettings.EventLogMessages.Add(&H1079, "	Fault - HTR-MAG Magnet under current relative	")
        ServerSettings.EventLogMessages.Add(&H107A, "	Fault - HTR-MAG Magnet over voltage absolute	")
        ServerSettings.EventLogMessages.Add(&H107B, "	Fault - HTR-MAG Magnet under voltage relative	")
        ServerSettings.EventLogMessages.Add(&H107C, "	Fault - HTR-MAG Heater Hardware over voltage	")
        ServerSettings.EventLogMessages.Add(&H107D, "	Fault - HTR-MAG Hardware temperature switch	")
        ServerSettings.EventLogMessages.Add(&H107E, "	Fault - HTR-MAG coolant fault	")
        ServerSettings.EventLogMessages.Add(&H107F, "	Fault - HTR-MAG can fault	")

        ServerSettings.EventLogMessages.Add(&H1180, "	Status - Gun Driver Not Ready	")
        ServerSettings.EventLogMessages.Add(&H1181, "	Status - Gun Driver Read	")
        ServerSettings.EventLogMessages.Add(&H1182, "	Status - Gun Driver not Configured	")
        ServerSettings.EventLogMessages.Add(&H1183, "	Status - Gun Driver Configured	")
        ServerSettings.EventLogMessages.Add(&H1184, "	Fault - Gun Driver Connection Lost	")
        ServerSettings.EventLogMessages.Add(&H1185, "	Status - Gun Driver Connection Established	")
        ServerSettings.EventLogMessages.Add(&H1186, "	Fault - Gun Driver Heater Off	")
        ServerSettings.EventLogMessages.Add(&H1187, "	Status - Gun Driver Heater On	")
        ServerSettings.EventLogMessages.Add(&H1080, "	Fault - Gun Driver 1	")
        ServerSettings.EventLogMessages.Add(&H1081, "	Fault - Gun Driver 2	")
        ServerSettings.EventLogMessages.Add(&H1082, "	Fault - Gun Driver 3	")
        ServerSettings.EventLogMessages.Add(&H1083, "	Fault - Gun Driver 4	")
        ServerSettings.EventLogMessages.Add(&H1084, "	Fault - Gun Driver 5	")
        ServerSettings.EventLogMessages.Add(&H1085, "	Fault - Gun Driver 6	")
        ServerSettings.EventLogMessages.Add(&H1086, "	Fault - Gun Driver 7	")
        ServerSettings.EventLogMessages.Add(&H1087, "	Fault - Gun Driver 8	")
        ServerSettings.EventLogMessages.Add(&H1088, "	Fault - Gun Driver 9	")
        ServerSettings.EventLogMessages.Add(&H1089, "	Fault - Gun Driver 10	")
        ServerSettings.EventLogMessages.Add(&H108A, "	Fault - Gun Driver 11	")
        ServerSettings.EventLogMessages.Add(&H108B, "	Fault - Gun Driver 12	")
        ServerSettings.EventLogMessages.Add(&H108C, "	Fault - Gun Driver 13	")
        ServerSettings.EventLogMessages.Add(&H108D, "	Fault - Gun Driver 14	")
        ServerSettings.EventLogMessages.Add(&H108E, "	Fault - Gun Driver 15	")
        ServerSettings.EventLogMessages.Add(&H108F, "	Fault - Gun Driver 16	")

#End If

        ServerSettings.EventLogMessages.Add(&H110, "State - Entered State Startup")
        ServerSettings.EventLogMessages.Add(&H112, "State - Entered State Wait for Personality from Pulse Sync")
        ServerSettings.EventLogMessages.Add(&H115, "State - Entered State Waiting for Initialization")
        ServerSettings.EventLogMessages.Add(&H120, "State - Entered State warmup")
        ServerSettings.EventLogMessages.Add(&H130, "State - Entered State Standby")
        ServerSettings.EventLogMessages.Add(&H140, "State - Entered State Drive Up")
        ServerSettings.EventLogMessages.Add(&H150, "State - Entered State Ready")
        ServerSettings.EventLogMessages.Add(&H160, "State - Entered State XRAY On")
        ServerSettings.EventLogMessages.Add(&H180, "State - Entered State Fault Hold")
        ServerSettings.EventLogMessages.Add(&H190, "State - Entered State Fault Reset")
        ServerSettings.EventLogMessages.Add(&H1A0, "State - Entered State System Fault")

        ServerSettings.EventLogMessages.Add(&H1, "Connection - Ion Pump Board Connection Lost")
        ServerSettings.EventLogMessages.Add(&H81, "Connection - Ion Pump Board Connection Established")
        ServerSettings.EventLogMessages.Add(&H2, "Connection - Pulse Current Board Connection Lost")
        ServerSettings.EventLogMessages.Add(&H82, "Connection - Pulse Current Board Connection Established")
        ServerSettings.EventLogMessages.Add(&H3, "Connection - PulseSync Board Connection Lost")
        ServerSettings.EventLogMessages.Add(&H83, "Connection - Pulse Sync Board Connection Established")
        ServerSettings.EventLogMessages.Add(&H4, "Connection - HV Interface Board Connection Lost")
        ServerSettings.EventLogMessages.Add(&H84, "Connection - HV Interface Board Connection Established")
        ServerSettings.EventLogMessages.Add(&H5, "Connection - AFC Board Connection Lost")
        ServerSettings.EventLogMessages.Add(&H85, "Connection - AFC Board Connection Established")
        ServerSettings.EventLogMessages.Add(&H6, "Connection - Cooling Interface Board Connection Lost")
        ServerSettings.EventLogMessages.Add(&H86, "Connection - Cooling Interface Board Connection Established")
        ServerSettings.EventLogMessages.Add(&H7, "Connection - Heater Magnet Board Connection Lost")
        ServerSettings.EventLogMessages.Add(&H87, "Connection - Heater Magnet Board Connection Established")
        ServerSettings.EventLogMessages.Add(&H8, "Connection - Gun Driver Connection Lost")
        ServerSettings.EventLogMessages.Add(&H88, "Connection - Gun Driver Connection Established")

        ServerSettings.EventLogMessages.Add(&H200, "State - Entered State Personality Received")
        ServerSettings.EventLogMessages.Add(&H201, "Error - Personality not valid")
        ServerSettings.EventLogMessages.Add(&H202, "Notice - All Modules Configured")
        ServerSettings.EventLogMessages.Add(&H203, "Notice - Warmup Done")
        ServerSettings.EventLogMessages.Add(&H204, "Notice - Drive up Complete")
        ServerSettings.EventLogMessages.Add(&H205, "Fault - Drive Up Timeout ")
        ServerSettings.EventLogMessages.Add(&H206, "State - Entered State HV Off Faults Clear")





        ServerSettings.EventLogMessages.Add(&HC100, "Control - Ion Pump Not Ready Bit Set")
        ServerSettings.EventLogMessages.Add(&HC108, "Control - Ion Pump Not Ready Bit Cleared")
        ServerSettings.EventLogMessages.Add(&HC101, "Control - Ion Pump Not Configured Bit Set")
        ServerSettings.EventLogMessages.Add(&HC109, "Control - Ion Pump Not Configured Bit Cleared")
        ServerSettings.EventLogMessages.Add(&HC102, "Control - Ion Pump Self Check Error Bit Set")
        ServerSettings.EventLogMessages.Add(&HC10A, "Control - Ion Pump Self Check Error Bit Cleared")
        ServerSettings.EventLogMessages.Add(&HC103, "Control - Ion Pump Control 3 Bit Set")
        ServerSettings.EventLogMessages.Add(&HC10B, "Control - Ion Pump Control 3 Bit Cleared")
        ServerSettings.EventLogMessages.Add(&HC104, "Control - Ion Pump Control 4 Bit Set")
        ServerSettings.EventLogMessages.Add(&HC10C, "Control - Ion Pump Control 4 Bit Cleared")
        ServerSettings.EventLogMessages.Add(&HC105, "Control - Ion Pump Control 5 Bit Set")
        ServerSettings.EventLogMessages.Add(&HC10D, "Control - Ion Pump Control 5 Bit Cleared")
        ServerSettings.EventLogMessages.Add(&HC106, "Control - Ion Pump Control 6 Bit Set")
        ServerSettings.EventLogMessages.Add(&HC10E, "Control - Ion Pump Control 6 Bit Cleared")
        ServerSettings.EventLogMessages.Add(&HC107, "Control - Ion Pump Control 7 Bit Set")
        ServerSettings.EventLogMessages.Add(&HC10F, "Control - Ion Pump Control 7 Bit Cleared")

        ServerSettings.EventLogMessages.Add(&HC110, "Notice - Ion Pump Notice 0")
        ServerSettings.EventLogMessages.Add(&HC111, "Notice - Ion Pump Notice 1")
        ServerSettings.EventLogMessages.Add(&HC112, "Notice - Ion Pump Notice 2")
        ServerSettings.EventLogMessages.Add(&HC113, "Notice - Ion Pump Notice 3")
        ServerSettings.EventLogMessages.Add(&HC114, "Notice - Ion Pump Notice 4")
        ServerSettings.EventLogMessages.Add(&HC115, "Notice - Ion Pump Notice 5")
        ServerSettings.EventLogMessages.Add(&HC116, "Notice - Ion Pump Notice 6")
        ServerSettings.EventLogMessages.Add(&HC117, "Notice - Ion Pump Notice 7")

        ServerSettings.EventLogMessages.Add(&HC120, "Fault - Ion Pump Fault 0 Bit Set")
        ServerSettings.EventLogMessages.Add(&HC130, "Fault - Ion Pump Fault 0 Bit Cleared")
        ServerSettings.EventLogMessages.Add(&HC121, "Fault - Ion Pump Fault 1 Bit Set")
        ServerSettings.EventLogMessages.Add(&HC131, "Fault - Ion Pump Fault 1 Bit Cleared")
        ServerSettings.EventLogMessages.Add(&HC122, "Fault - Ion Pump Fault 2 Bit Set")
        ServerSettings.EventLogMessages.Add(&HC132, "Fault - Ion Pump Fault 2 Bit Cleared")
        ServerSettings.EventLogMessages.Add(&HC123, "Fault - Ion Pump Fault 3 Bit Set")
        ServerSettings.EventLogMessages.Add(&HC133, "Fault - Ion Pump Fault 3 Bit Cleared")
        ServerSettings.EventLogMessages.Add(&HC124, "Fault - Ion Pump Fault 4 Bit Set")
        ServerSettings.EventLogMessages.Add(&HC134, "Fault - Ion Pump Fault 4 Bit Cleared")
        ServerSettings.EventLogMessages.Add(&HC125, "Fault - Ion Pump Fault 5 Bit Set")
        ServerSettings.EventLogMessages.Add(&HC135, "Fault - Ion Pump Fault 5 Bit Cleared")
        ServerSettings.EventLogMessages.Add(&HC126, "Fault - Ion Pump Fault 6 Bit Set")
        ServerSettings.EventLogMessages.Add(&HC136, "Fault - Ion Pump Fault 6 Bit Cleared")
        ServerSettings.EventLogMessages.Add(&HC127, "Fault - Ion Pump Fault 7 Bit Set")
        ServerSettings.EventLogMessages.Add(&HC137, "Fault - Ion Pump Fault 7 Bit Cleared")
        ServerSettings.EventLogMessages.Add(&HC128, "Fault - Ion Pump Fault 8 Bit Set")
        ServerSettings.EventLogMessages.Add(&HC138, "Fault - Ion Pump Fault 8 Bit Cleared")
        ServerSettings.EventLogMessages.Add(&HC129, "Fault - Ion Pump Fault 9 Bit Set")
        ServerSettings.EventLogMessages.Add(&HC139, "Fault - Ion Pump Fault 9 Bit Cleared")
        ServerSettings.EventLogMessages.Add(&HC12A, "Fault - Ion Pump Fault A Bit Set")
        ServerSettings.EventLogMessages.Add(&HC13A, "Fault - Ion Pump Fault A Bit Cleared")
        ServerSettings.EventLogMessages.Add(&HC12B, "Fault - Ion Pump Fault B Bit Set")
        ServerSettings.EventLogMessages.Add(&HC13B, "Fault - Ion Pump Fault B Bit Cleared")
        ServerSettings.EventLogMessages.Add(&HC12C, "Fault - Ion Pump Fault C Bit Set")
        ServerSettings.EventLogMessages.Add(&HC13C, "Fault - Ion Pump Fault C Bit Cleared")
        ServerSettings.EventLogMessages.Add(&HC12D, "Fault - Ion Pump Fault D Bit Set")
        ServerSettings.EventLogMessages.Add(&HC13D, "Fault - Ion Pump Fault D Bit Cleared")
        ServerSettings.EventLogMessages.Add(&HC12E, "Fault - Ion Pump Fault E Bit Set")
        ServerSettings.EventLogMessages.Add(&HC13E, "Fault - Ion Pump Fault E Bit Cleared")
        ServerSettings.EventLogMessages.Add(&HC12F, "Fault - Ion Pump Fault F Bit Set")
        ServerSettings.EventLogMessages.Add(&HC13F, "Fault - Ion Pump Fault F Bit Cleared")

        ServerSettings.EventLogMessages.Add(&HC140, "Log - Ion Pump Logged 0 Bit Set")
        ServerSettings.EventLogMessages.Add(&HC150, "Log - Ion Pump Logged 0 Bit Cleared")
        ServerSettings.EventLogMessages.Add(&HC141, "Log - Ion Pump Logged 1 Bit Set")
        ServerSettings.EventLogMessages.Add(&HC151, "Log - Ion Pump Logged 1 Bit Cleared")
        ServerSettings.EventLogMessages.Add(&HC142, "Log - Ion Pump Logged 2 Bit Set")
        ServerSettings.EventLogMessages.Add(&HC152, "Log - Ion Pump Logged 2 Bit Cleared")
        ServerSettings.EventLogMessages.Add(&HC143, "Log - Ion Pump Logged 3 Bit Set")
        ServerSettings.EventLogMessages.Add(&HC153, "Log - Ion Pump Logged 3 Bit Cleared")
        ServerSettings.EventLogMessages.Add(&HC144, "Log - Ion Pump Logged 4 Bit Set")
        ServerSettings.EventLogMessages.Add(&HC154, "Log - Ion Pump Logged 4 Bit Cleared")
        ServerSettings.EventLogMessages.Add(&HC145, "Log - Ion Pump Logged 5 Bit Set")
        ServerSettings.EventLogMessages.Add(&HC155, "Log - Ion Pump Logged 5 Bit Cleared")
        ServerSettings.EventLogMessages.Add(&HC146, "Log - Ion Pump Logged 6 Bit Set")
        ServerSettings.EventLogMessages.Add(&HC156, "Log - Ion Pump Logged 6 Bit Cleared")
        ServerSettings.EventLogMessages.Add(&HC147, "Log - Ion Pump Logged 7 Bit Set")
        ServerSettings.EventLogMessages.Add(&HC157, "Log - Ion Pump Logged 7 Bit Cleared")
        ServerSettings.EventLogMessages.Add(&HC148, "Log - Ion Pump Logged 8 Bit Set")
        ServerSettings.EventLogMessages.Add(&HC158, "Log - Ion Pump Logged 8 Bit Cleared")
        ServerSettings.EventLogMessages.Add(&HC149, "Log - Ion Pump Logged 9 Bit Set")
        ServerSettings.EventLogMessages.Add(&HC159, "Log - Ion Pump Logged 9 Bit Cleared")
        ServerSettings.EventLogMessages.Add(&HC14A, "Log - Ion Pump Logged A Bit Set")
        ServerSettings.EventLogMessages.Add(&HC15A, "Log - Ion Pump Logged A Bit Cleared")
        ServerSettings.EventLogMessages.Add(&HC14B, "Log - Ion Pump Logged B Bit Set")
        ServerSettings.EventLogMessages.Add(&HC15B, "Log - Ion Pump Logged B Bit Cleared")
        ServerSettings.EventLogMessages.Add(&HC14C, "Log - Ion Pump Logged C Bit Set")
        ServerSettings.EventLogMessages.Add(&HC15C, "Log - Ion Pump Logged C Bit Cleared")
        ServerSettings.EventLogMessages.Add(&HC14D, "Log - Ion Pump Logged D Bit Set")
        ServerSettings.EventLogMessages.Add(&HC15D, "Log - Ion Pump Logged D Bit Cleared")
        ServerSettings.EventLogMessages.Add(&HC14E, "Log - Ion Pump Logged E Bit Set")
        ServerSettings.EventLogMessages.Add(&HC15E, "Log - Ion Pump Logged E Bit Cleared")
        ServerSettings.EventLogMessages.Add(&HC14F, "Log - Ion Pump Logged F Bit Set")
        ServerSettings.EventLogMessages.Add(&HC15F, "Log - Ion Pump Logged F Bit Cleared")




        ServerSettings.EventLogMessages.Add(&HC200, "Control - Pulse Current Not Ready Bit Set")
        ServerSettings.EventLogMessages.Add(&HC208, "Control - Pulse Current Not Ready Bit Cleared")
        ServerSettings.EventLogMessages.Add(&HC201, "Control - Pulse Current Not Configured Bit Set")
        ServerSettings.EventLogMessages.Add(&HC209, "Control - Pulse Current Not Configured Bit Cleared")
        ServerSettings.EventLogMessages.Add(&HC202, "Control - Pulse Current Self Check Error Bit Set")
        ServerSettings.EventLogMessages.Add(&HC20A, "Control - Pulse Current Self Check Error Bit Cleared")
        ServerSettings.EventLogMessages.Add(&HC203, "Control - Pulse Current Control 3 Bit Set")
        ServerSettings.EventLogMessages.Add(&HC20B, "Control - Pulse Current Control 3 Bit Cleared")
        ServerSettings.EventLogMessages.Add(&HC204, "Control - Pulse Current Control 4 Bit Set")
        ServerSettings.EventLogMessages.Add(&HC20C, "Control - Pulse Current Control 4 Bit Cleared")
        ServerSettings.EventLogMessages.Add(&HC205, "Control - Pulse Current Control 5 Bit Set")
        ServerSettings.EventLogMessages.Add(&HC20D, "Control - Pulse Current Control 5 Bit Cleared")
        ServerSettings.EventLogMessages.Add(&HC206, "Control - Pulse Current Control 6 Bit Set")
        ServerSettings.EventLogMessages.Add(&HC20E, "Control - Pulse Current Control 6 Bit Cleared")
        ServerSettings.EventLogMessages.Add(&HC207, "Control - Pulse Current Control 7 Bit Set")
        ServerSettings.EventLogMessages.Add(&HC20F, "Control - Pulse Current Control 7 Bit Cleared")

        ServerSettings.EventLogMessages.Add(&HC210, "Notice - Pulse Current Notice 0")
        ServerSettings.EventLogMessages.Add(&HC211, "Notice - Pulse Current Notice 1")
        ServerSettings.EventLogMessages.Add(&HC212, "Notice - Pulse Current Notice 2")
        ServerSettings.EventLogMessages.Add(&HC213, "Notice - Pulse Current Notice 3")
        ServerSettings.EventLogMessages.Add(&HC214, "Notice - Pulse Current Notice 4")
        ServerSettings.EventLogMessages.Add(&HC215, "Notice - Pulse Current Notice 5")
        ServerSettings.EventLogMessages.Add(&HC216, "Notice - Pulse Current Notice 6")
        ServerSettings.EventLogMessages.Add(&HC217, "Notice - Pulse Current Notice 7")

        ServerSettings.EventLogMessages.Add(&HC220, "Fault - Pulse Current Fault 0 Bit Set")
        ServerSettings.EventLogMessages.Add(&HC230, "Fault - Pulse Current Fault 0 Bit Cleared")
        ServerSettings.EventLogMessages.Add(&HC221, "Fault - Pulse Current Fault 1 Bit Set")
        ServerSettings.EventLogMessages.Add(&HC231, "Fault - Pulse Current Fault 1 Bit Cleared")
        ServerSettings.EventLogMessages.Add(&HC222, "Fault - Pulse Current Fault 2 Bit Set")
        ServerSettings.EventLogMessages.Add(&HC232, "Fault - Pulse Current Fault 2 Bit Cleared")
        ServerSettings.EventLogMessages.Add(&HC223, "Fault - Pulse Current Fault 3 Bit Set")
        ServerSettings.EventLogMessages.Add(&HC233, "Fault - Pulse Current Fault 3 Bit Cleared")
        ServerSettings.EventLogMessages.Add(&HC224, "Fault - Pulse Current Fault 4 Bit Set")
        ServerSettings.EventLogMessages.Add(&HC234, "Fault - Pulse Current Fault 4 Bit Cleared")
        ServerSettings.EventLogMessages.Add(&HC225, "Fault - Pulse Current Fault 5 Bit Set")
        ServerSettings.EventLogMessages.Add(&HC235, "Fault - Pulse Current Fault 5 Bit Cleared")
        ServerSettings.EventLogMessages.Add(&HC226, "Fault - Pulse Current Fault 6 Bit Set")
        ServerSettings.EventLogMessages.Add(&HC236, "Fault - Pulse Current Fault 6 Bit Cleared")
        ServerSettings.EventLogMessages.Add(&HC227, "Fault - Pulse Current Fault 7 Bit Set")
        ServerSettings.EventLogMessages.Add(&HC237, "Fault - Pulse Current Fault 7 Bit Cleared")
        ServerSettings.EventLogMessages.Add(&HC228, "Fault - Pulse Current Fault 8 Bit Set")
        ServerSettings.EventLogMessages.Add(&HC238, "Fault - Pulse Current Fault 8 Bit Cleared")
        ServerSettings.EventLogMessages.Add(&HC229, "Fault - Pulse Current Fault 9 Bit Set")
        ServerSettings.EventLogMessages.Add(&HC239, "Fault - Pulse Current Fault 9 Bit Cleared")
        ServerSettings.EventLogMessages.Add(&HC22A, "Fault - Pulse Current Fault A Bit Set")
        ServerSettings.EventLogMessages.Add(&HC23A, "Fault - Pulse Current Fault A Bit Cleared")
        ServerSettings.EventLogMessages.Add(&HC22B, "Fault - Pulse Current Fault B Bit Set")
        ServerSettings.EventLogMessages.Add(&HC23B, "Fault - Pulse Current Fault B Bit Cleared")
        ServerSettings.EventLogMessages.Add(&HC22C, "Fault - Pulse Current Fault C Bit Set")
        ServerSettings.EventLogMessages.Add(&HC23C, "Fault - Pulse Current Fault C Bit Cleared")
        ServerSettings.EventLogMessages.Add(&HC22D, "Fault - Pulse Current Fault D Bit Set")
        ServerSettings.EventLogMessages.Add(&HC23D, "Fault - Pulse Current Fault D Bit Cleared")
        ServerSettings.EventLogMessages.Add(&HC22E, "Fault - Pulse Current Fault E Bit Set")
        ServerSettings.EventLogMessages.Add(&HC23E, "Fault - Pulse Current Fault E Bit Cleared")
        ServerSettings.EventLogMessages.Add(&HC22F, "Fault - Pulse Current Fault F Bit Set")
        ServerSettings.EventLogMessages.Add(&HC23F, "Fault - Pulse Current Fault F Bit Cleared")

        ServerSettings.EventLogMessages.Add(&HC240, "Log - Pulse Current Logged 0 Bit Set")
        ServerSettings.EventLogMessages.Add(&HC250, "Log - Pulse Current Logged 0 Bit Cleared")
        ServerSettings.EventLogMessages.Add(&HC241, "Log - Pulse Current Logged 1 Bit Set")
        ServerSettings.EventLogMessages.Add(&HC251, "Log - Pulse Current Logged 1 Bit Cleared")
        ServerSettings.EventLogMessages.Add(&HC242, "Log - Pulse Current Logged 2 Bit Set")
        ServerSettings.EventLogMessages.Add(&HC252, "Log - Pulse Current Logged 2 Bit Cleared")
        ServerSettings.EventLogMessages.Add(&HC243, "Log - Pulse Current Logged 3 Bit Set")
        ServerSettings.EventLogMessages.Add(&HC253, "Log - Pulse Current Logged 3 Bit Cleared")
        ServerSettings.EventLogMessages.Add(&HC244, "Log - Pulse Current Logged 4 Bit Set")
        ServerSettings.EventLogMessages.Add(&HC254, "Log - Pulse Current Logged 4 Bit Cleared")
        ServerSettings.EventLogMessages.Add(&HC245, "Log - Pulse Current Logged 5 Bit Set")
        ServerSettings.EventLogMessages.Add(&HC255, "Log - Pulse Current Logged 5 Bit Cleared")
        ServerSettings.EventLogMessages.Add(&HC246, "Log - Pulse Current Logged 6 Bit Set")
        ServerSettings.EventLogMessages.Add(&HC256, "Log - Pulse Current Logged 6 Bit Cleared")
        ServerSettings.EventLogMessages.Add(&HC247, "Log - Pulse Current Logged 7 Bit Set")
        ServerSettings.EventLogMessages.Add(&HC257, "Log - Pulse Current Logged 7 Bit Cleared")
        ServerSettings.EventLogMessages.Add(&HC248, "Log - Pulse Current Logged 8 Bit Set")
        ServerSettings.EventLogMessages.Add(&HC258, "Log - Pulse Current Logged 8 Bit Cleared")
        ServerSettings.EventLogMessages.Add(&HC249, "Log - Pulse Current Logged 9 Bit Set")
        ServerSettings.EventLogMessages.Add(&HC259, "Log - Pulse Current Logged 9 Bit Cleared")
        ServerSettings.EventLogMessages.Add(&HC24A, "Log - Pulse Current Logged A Bit Set")
        ServerSettings.EventLogMessages.Add(&HC25A, "Log - Pulse Current Logged A Bit Cleared")
        ServerSettings.EventLogMessages.Add(&HC24B, "Log - Pulse Current Logged B Bit Set")
        ServerSettings.EventLogMessages.Add(&HC25B, "Log - Pulse Current Logged B Bit Cleared")
        ServerSettings.EventLogMessages.Add(&HC24C, "Log - Pulse Current Logged C Bit Set")
        ServerSettings.EventLogMessages.Add(&HC25C, "Log - Pulse Current Logged C Bit Cleared")
        ServerSettings.EventLogMessages.Add(&HC24D, "Log - Pulse Current Logged D Bit Set")
        ServerSettings.EventLogMessages.Add(&HC25D, "Log - Pulse Current Logged D Bit Cleared")
        ServerSettings.EventLogMessages.Add(&HC24E, "Log - Pulse Current Logged E Bit Set")
        ServerSettings.EventLogMessages.Add(&HC25E, "Log - Pulse Current Logged E Bit Cleared")
        ServerSettings.EventLogMessages.Add(&HC24F, "Log - Pulse Current Logged F Bit Set")
        ServerSettings.EventLogMessages.Add(&HC25F, "Log - Pulse Current Logged F Bit Cleared")





        ServerSettings.EventLogMessages.Add(&HC300, "Control - Pulse Sync Not Ready Bit Set")
        ServerSettings.EventLogMessages.Add(&HC308, "Control - Pulse Sync Not Ready Bit Cleared")
        ServerSettings.EventLogMessages.Add(&HC301, "Control - Pulse Sync Not Configured Bit Set")
        ServerSettings.EventLogMessages.Add(&HC309, "Control - Pulse Sync Not Configured Bit Cleared")
        ServerSettings.EventLogMessages.Add(&HC302, "Control - Pulse Sync Self Check Error Bit Set")
        ServerSettings.EventLogMessages.Add(&HC30A, "Control - Pulse Sync Self Check Error Bit Cleared")
        ServerSettings.EventLogMessages.Add(&HC303, "Control - Pulse Sync Control 3 Bit Set")
        ServerSettings.EventLogMessages.Add(&HC30B, "Control - Pulse Sync Control 3 Bit Cleared")
        ServerSettings.EventLogMessages.Add(&HC304, "Control - Pulse Sync Control 4 Bit Set")
        ServerSettings.EventLogMessages.Add(&HC30C, "Control - Pulse Sync Control 4 Bit Cleared")
        ServerSettings.EventLogMessages.Add(&HC305, "Control - Pulse Sync Control 5 Bit Set")
        ServerSettings.EventLogMessages.Add(&HC30D, "Control - Pulse Sync Control 5 Bit Cleared")
        ServerSettings.EventLogMessages.Add(&HC306, "Control - Pulse Sync Control 6 Bit Set")
        ServerSettings.EventLogMessages.Add(&HC30E, "Control - Pulse Sync Control 6 Bit Cleared")
        ServerSettings.EventLogMessages.Add(&HC307, "Control - Pulse Sync Control 7 Bit Set")
        ServerSettings.EventLogMessages.Add(&HC30F, "Control - Pulse Sync Control 7 Bit Cleared")

        ServerSettings.EventLogMessages.Add(&HC310, "Notice - Pulse Sync Notice 0")
        ServerSettings.EventLogMessages.Add(&HC311, "Notice - Pulse Sync Notice 1")
        ServerSettings.EventLogMessages.Add(&HC312, "Notice - Pulse Sync Notice 2")
        ServerSettings.EventLogMessages.Add(&HC313, "Notice - Pulse Sync Notice 3")
        ServerSettings.EventLogMessages.Add(&HC314, "Notice - Pulse Sync Notice 4")
        ServerSettings.EventLogMessages.Add(&HC315, "Notice - Pulse Sync Notice 5")
        ServerSettings.EventLogMessages.Add(&HC316, "Notice - Pulse Sync Notice 6")
        ServerSettings.EventLogMessages.Add(&HC317, "Notice - Pulse Sync Notice 7")

        ServerSettings.EventLogMessages.Add(&HC320, "Fault - Pulse Sync Fault 0 Bit Set")
        ServerSettings.EventLogMessages.Add(&HC330, "Fault - Pulse Sync Fault 0 Bit Cleared")
        ServerSettings.EventLogMessages.Add(&HC321, "Fault - Pulse Sync Fault 1 Bit Set")
        ServerSettings.EventLogMessages.Add(&HC331, "Fault - Pulse Sync Fault 1 Bit Cleared")
        ServerSettings.EventLogMessages.Add(&HC322, "Fault - Pulse Sync Fault 2 Bit Set")
        ServerSettings.EventLogMessages.Add(&HC332, "Fault - Pulse Sync Fault 2 Bit Cleared")
        ServerSettings.EventLogMessages.Add(&HC323, "Fault - Pulse Sync Fault 3 Bit Set")
        ServerSettings.EventLogMessages.Add(&HC333, "Fault - Pulse Sync Fault 3 Bit Cleared")
        ServerSettings.EventLogMessages.Add(&HC324, "Fault - Pulse Sync Fault 4 Bit Set")
        ServerSettings.EventLogMessages.Add(&HC334, "Fault - Pulse Sync Fault 4 Bit Cleared")
        ServerSettings.EventLogMessages.Add(&HC325, "Fault - Pulse Sync Fault 5 Bit Set")
        ServerSettings.EventLogMessages.Add(&HC335, "Fault - Pulse Sync Fault 5 Bit Cleared")
        ServerSettings.EventLogMessages.Add(&HC326, "Fault - Pulse Sync Fault 6 Bit Set")
        ServerSettings.EventLogMessages.Add(&HC336, "Fault - Pulse Sync Fault 6 Bit Cleared")
        ServerSettings.EventLogMessages.Add(&HC327, "Fault - Pulse Sync Fault 7 Bit Set")
        ServerSettings.EventLogMessages.Add(&HC337, "Fault - Pulse Sync Fault 7 Bit Cleared")
        ServerSettings.EventLogMessages.Add(&HC328, "Fault - Pulse Sync Fault 8 Bit Set")
        ServerSettings.EventLogMessages.Add(&HC338, "Fault - Pulse Sync Fault 8 Bit Cleared")
        ServerSettings.EventLogMessages.Add(&HC329, "Fault - Pulse Sync Fault 9 Bit Set")
        ServerSettings.EventLogMessages.Add(&HC339, "Fault - Pulse Sync Fault 9 Bit Cleared")
        ServerSettings.EventLogMessages.Add(&HC32A, "Fault - Pulse Sync Fault A Bit Set")
        ServerSettings.EventLogMessages.Add(&HC33A, "Fault - Pulse Sync Fault A Bit Cleared")
        ServerSettings.EventLogMessages.Add(&HC32B, "Fault - Pulse Sync Fault B Bit Set")
        ServerSettings.EventLogMessages.Add(&HC33B, "Fault - Pulse Sync Fault B Bit Cleared")
        ServerSettings.EventLogMessages.Add(&HC32C, "Fault - Pulse Sync Fault C Bit Set")
        ServerSettings.EventLogMessages.Add(&HC33C, "Fault - Pulse Sync Fault C Bit Cleared")
        ServerSettings.EventLogMessages.Add(&HC32D, "Fault - Pulse Sync Fault D Bit Set")
        ServerSettings.EventLogMessages.Add(&HC33D, "Fault - Pulse Sync Fault D Bit Cleared")
        ServerSettings.EventLogMessages.Add(&HC32E, "Fault - Pulse Sync Fault E Bit Set")
        ServerSettings.EventLogMessages.Add(&HC33E, "Fault - Pulse Sync Fault E Bit Cleared")
        ServerSettings.EventLogMessages.Add(&HC32F, "Fault - Pulse Sync Fault F Bit Set")
        ServerSettings.EventLogMessages.Add(&HC33F, "Fault - Pulse Sync Fault F Bit Cleared")

        ServerSettings.EventLogMessages.Add(&HC340, "Log - Pulse Sync Logged 0 Bit Set")
        ServerSettings.EventLogMessages.Add(&HC350, "Log - Pulse Sync Logged 0 Bit Cleared")
        ServerSettings.EventLogMessages.Add(&HC341, "Log - Pulse Sync Logged 1 Bit Set")
        ServerSettings.EventLogMessages.Add(&HC351, "Log - Pulse Sync Logged 1 Bit Cleared")
        ServerSettings.EventLogMessages.Add(&HC342, "Log - Pulse Sync Logged 2 Bit Set")
        ServerSettings.EventLogMessages.Add(&HC352, "Log - Pulse Sync Logged 2 Bit Cleared")
        ServerSettings.EventLogMessages.Add(&HC343, "Log - Pulse Sync Logged 3 Bit Set")
        ServerSettings.EventLogMessages.Add(&HC353, "Log - Pulse Sync Logged 3 Bit Cleared")
        ServerSettings.EventLogMessages.Add(&HC344, "Log - Pulse Sync Logged 4 Bit Set")
        ServerSettings.EventLogMessages.Add(&HC354, "Log - Pulse Sync Logged 4 Bit Cleared")
        ServerSettings.EventLogMessages.Add(&HC345, "Log - Pulse Sync Logged 5 Bit Set")
        ServerSettings.EventLogMessages.Add(&HC355, "Log - Pulse Sync Logged 5 Bit Cleared")
        ServerSettings.EventLogMessages.Add(&HC346, "Log - Pulse Sync Logged 6 Bit Set")
        ServerSettings.EventLogMessages.Add(&HC356, "Log - Pulse Sync Logged 6 Bit Cleared")
        ServerSettings.EventLogMessages.Add(&HC347, "Log - Pulse Sync Logged 7 Bit Set")
        ServerSettings.EventLogMessages.Add(&HC357, "Log - Pulse Sync Logged 7 Bit Cleared")
        ServerSettings.EventLogMessages.Add(&HC348, "Log - Pulse Sync Logged 8 Bit Set")
        ServerSettings.EventLogMessages.Add(&HC358, "Log - Pulse Sync Logged 8 Bit Cleared")
        ServerSettings.EventLogMessages.Add(&HC349, "Log - Pulse Sync Logged 9 Bit Set")
        ServerSettings.EventLogMessages.Add(&HC359, "Log - Pulse Sync Logged 9 Bit Cleared")
        ServerSettings.EventLogMessages.Add(&HC34A, "Log - Pulse Sync Logged A Bit Set")
        ServerSettings.EventLogMessages.Add(&HC35A, "Log - Pulse Sync Logged A Bit Cleared")
        ServerSettings.EventLogMessages.Add(&HC34B, "Log - Pulse Sync Logged B Bit Set")
        ServerSettings.EventLogMessages.Add(&HC35B, "Log - Pulse Sync Logged B Bit Cleared")
        ServerSettings.EventLogMessages.Add(&HC34C, "Log - Pulse Sync Logged C Bit Set")
        ServerSettings.EventLogMessages.Add(&HC35C, "Log - Pulse Sync Logged C Bit Cleared")
        ServerSettings.EventLogMessages.Add(&HC34D, "Log - Pulse Sync Logged D Bit Set")
        ServerSettings.EventLogMessages.Add(&HC35D, "Log - Pulse Sync Logged D Bit Cleared")
        ServerSettings.EventLogMessages.Add(&HC34E, "Log - Pulse Sync Logged E Bit Set")
        ServerSettings.EventLogMessages.Add(&HC35E, "Log - Pulse Sync Logged E Bit Cleared")
        ServerSettings.EventLogMessages.Add(&HC34F, "Log - Pulse Sync Logged F Bit Set")
        ServerSettings.EventLogMessages.Add(&HC35F, "Log - Pulse Sync Logged F Bit Cleared")




        ServerSettings.EventLogMessages.Add(&HC400, "Control - HV Interface Not Ready Bit Set")
        ServerSettings.EventLogMessages.Add(&HC408, "Control - HV Interface Not Ready Bit Cleared")
        ServerSettings.EventLogMessages.Add(&HC401, "Control - HV Interface Not Configured Bit Set")
        ServerSettings.EventLogMessages.Add(&HC409, "Control - HV Interface Not Configured Bit Cleared")
        ServerSettings.EventLogMessages.Add(&HC402, "Control - HV Interface Self Check Error Bit Set")
        ServerSettings.EventLogMessages.Add(&HC40A, "Control - HV Interface Self Check Error Bit Cleared")
        ServerSettings.EventLogMessages.Add(&HC403, "Control - HV Interface Control 3 Bit Set")
        ServerSettings.EventLogMessages.Add(&HC40B, "Control - HV Interface Control 3 Bit Cleared")
        ServerSettings.EventLogMessages.Add(&HC404, "Control - HV Interface Control 4 Bit Set")
        ServerSettings.EventLogMessages.Add(&HC40C, "Control - HV Interface Control 4 Bit Cleared")
        ServerSettings.EventLogMessages.Add(&HC405, "Control - HV Interface Control 5 Bit Set")
        ServerSettings.EventLogMessages.Add(&HC40D, "Control - HV Interface Control 5 Bit Cleared")
        ServerSettings.EventLogMessages.Add(&HC406, "Control - HV Interface Control 6 Bit Set")
        ServerSettings.EventLogMessages.Add(&HC40E, "Control - HV Interface Control 6 Bit Cleared")
        ServerSettings.EventLogMessages.Add(&HC407, "Control - HV Interface Control 7 Bit Set")
        ServerSettings.EventLogMessages.Add(&HC40F, "Control - HV Interface Control 7 Bit Cleared")

        ServerSettings.EventLogMessages.Add(&HC410, "Notice - HV Interface Notice 0")
        ServerSettings.EventLogMessages.Add(&HC411, "Notice - HV Interface Notice 1")
        ServerSettings.EventLogMessages.Add(&HC412, "Notice - HV Interface Notice 2")
        ServerSettings.EventLogMessages.Add(&HC413, "Notice - HV Interface Notice 3")
        ServerSettings.EventLogMessages.Add(&HC414, "Notice - HV Interface Notice 4")
        ServerSettings.EventLogMessages.Add(&HC415, "Notice - HV Interface Notice 5")
        ServerSettings.EventLogMessages.Add(&HC416, "Notice - HV Interface Notice 6")
        ServerSettings.EventLogMessages.Add(&HC417, "Notice - HV Interface Notice 7")

        ServerSettings.EventLogMessages.Add(&HC420, "Fault - HV Interface Fault 0 Bit Set")
        ServerSettings.EventLogMessages.Add(&HC430, "Fault - HV Interface Fault 0 Bit Cleared")
        ServerSettings.EventLogMessages.Add(&HC421, "Fault - HV Interface Fault 1 Bit Set")
        ServerSettings.EventLogMessages.Add(&HC431, "Fault - HV Interface Fault 1 Bit Cleared")
        ServerSettings.EventLogMessages.Add(&HC422, "Fault - HV Interface Fault 2 Bit Set")
        ServerSettings.EventLogMessages.Add(&HC432, "Fault - HV Interface Fault 2 Bit Cleared")
        ServerSettings.EventLogMessages.Add(&HC423, "Fault - HV Interface Fault 3 Bit Set")
        ServerSettings.EventLogMessages.Add(&HC433, "Fault - HV Interface Fault 3 Bit Cleared")
        ServerSettings.EventLogMessages.Add(&HC424, "Fault - HV Interface Fault 4 Bit Set")
        ServerSettings.EventLogMessages.Add(&HC434, "Fault - HV Interface Fault 4 Bit Cleared")
        ServerSettings.EventLogMessages.Add(&HC425, "Fault - HV Interface Fault 5 Bit Set")
        ServerSettings.EventLogMessages.Add(&HC435, "Fault - HV Interface Fault 5 Bit Cleared")
        ServerSettings.EventLogMessages.Add(&HC426, "Fault - HV Interface Fault 6 Bit Set")
        ServerSettings.EventLogMessages.Add(&HC436, "Fault - HV Interface Fault 6 Bit Cleared")
        ServerSettings.EventLogMessages.Add(&HC427, "Fault - HV Interface Fault 7 Bit Set")
        ServerSettings.EventLogMessages.Add(&HC437, "Fault - HV Interface Fault 7 Bit Cleared")
        ServerSettings.EventLogMessages.Add(&HC428, "Fault - HV Interface Fault 8 Bit Set")
        ServerSettings.EventLogMessages.Add(&HC438, "Fault - HV Interface Fault 8 Bit Cleared")
        ServerSettings.EventLogMessages.Add(&HC429, "Fault - HV Interface Fault 9 Bit Set")
        ServerSettings.EventLogMessages.Add(&HC439, "Fault - HV Interface Fault 9 Bit Cleared")
        ServerSettings.EventLogMessages.Add(&HC42A, "Fault - HV Interface Fault A Bit Set")
        ServerSettings.EventLogMessages.Add(&HC43A, "Fault - HV Interface Fault A Bit Cleared")
        ServerSettings.EventLogMessages.Add(&HC42B, "Fault - HV Interface Fault B Bit Set")
        ServerSettings.EventLogMessages.Add(&HC43B, "Fault - HV Interface Fault B Bit Cleared")
        ServerSettings.EventLogMessages.Add(&HC42C, "Fault - HV Interface Fault C Bit Set")
        ServerSettings.EventLogMessages.Add(&HC43C, "Fault - HV Interface Fault C Bit Cleared")
        ServerSettings.EventLogMessages.Add(&HC42D, "Fault - HV Interface Fault D Bit Set")
        ServerSettings.EventLogMessages.Add(&HC43D, "Fault - HV Interface Fault D Bit Cleared")
        ServerSettings.EventLogMessages.Add(&HC42E, "Fault - HV Interface Fault E Bit Set")
        ServerSettings.EventLogMessages.Add(&HC43E, "Fault - HV Interface Fault E Bit Cleared")
        ServerSettings.EventLogMessages.Add(&HC42F, "Fault - HV Interface Fault F Bit Set")
        ServerSettings.EventLogMessages.Add(&HC43F, "Fault - HV Interface Fault F Bit Cleared")

        ServerSettings.EventLogMessages.Add(&HC440, "Log - HV Interface Logged 0 Bit Set")
        ServerSettings.EventLogMessages.Add(&HC450, "Log - HV Interface Logged 0 Bit Cleared")
        ServerSettings.EventLogMessages.Add(&HC441, "Log - HV Interface Logged 1 Bit Set")
        ServerSettings.EventLogMessages.Add(&HC451, "Log - HV Interface Logged 1 Bit Cleared")
        ServerSettings.EventLogMessages.Add(&HC442, "Log - HV Interface Logged 2 Bit Set")
        ServerSettings.EventLogMessages.Add(&HC452, "Log - HV Interface Logged 2 Bit Cleared")
        ServerSettings.EventLogMessages.Add(&HC443, "Log - HV Interface Logged 3 Bit Set")
        ServerSettings.EventLogMessages.Add(&HC453, "Log - HV Interface Logged 3 Bit Cleared")
        ServerSettings.EventLogMessages.Add(&HC444, "Log - HV Interface Logged 4 Bit Set")
        ServerSettings.EventLogMessages.Add(&HC454, "Log - HV Interface Logged 4 Bit Cleared")
        ServerSettings.EventLogMessages.Add(&HC445, "Log - HV Interface Logged 5 Bit Set")
        ServerSettings.EventLogMessages.Add(&HC455, "Log - HV Interface Logged 5 Bit Cleared")
        ServerSettings.EventLogMessages.Add(&HC446, "Log - HV Interface Logged 6 Bit Set")
        ServerSettings.EventLogMessages.Add(&HC456, "Log - HV Interface Logged 6 Bit Cleared")
        ServerSettings.EventLogMessages.Add(&HC447, "Log - HV Interface Logged 7 Bit Set")
        ServerSettings.EventLogMessages.Add(&HC457, "Log - HV Interface Logged 7 Bit Cleared")
        ServerSettings.EventLogMessages.Add(&HC448, "Log - HV Interface Logged 8 Bit Set")
        ServerSettings.EventLogMessages.Add(&HC458, "Log - HV Interface Logged 8 Bit Cleared")
        ServerSettings.EventLogMessages.Add(&HC449, "Log - HV Interface Logged 9 Bit Set")
        ServerSettings.EventLogMessages.Add(&HC459, "Log - HV Interface Logged 9 Bit Cleared")
        ServerSettings.EventLogMessages.Add(&HC44A, "Log - HV Interface Logged A Bit Set")
        ServerSettings.EventLogMessages.Add(&HC45A, "Log - HV Interface Logged A Bit Cleared")
        ServerSettings.EventLogMessages.Add(&HC44B, "Log - HV Interface Logged B Bit Set")
        ServerSettings.EventLogMessages.Add(&HC45B, "Log - HV Interface Logged B Bit Cleared")
        ServerSettings.EventLogMessages.Add(&HC44C, "Log - HV Interface Logged C Bit Set")
        ServerSettings.EventLogMessages.Add(&HC45C, "Log - HV Interface Logged C Bit Cleared")
        ServerSettings.EventLogMessages.Add(&HC44D, "Log - HV Interface Logged D Bit Set")
        ServerSettings.EventLogMessages.Add(&HC45D, "Log - HV Interface Logged D Bit Cleared")
        ServerSettings.EventLogMessages.Add(&HC44E, "Log - HV Interface Logged E Bit Set")
        ServerSettings.EventLogMessages.Add(&HC45E, "Log - HV Interface Logged E Bit Cleared")
        ServerSettings.EventLogMessages.Add(&HC44F, "Log - HV Interface Logged F Bit Set")
        ServerSettings.EventLogMessages.Add(&HC45F, "Log - HV Interface Logged F Bit Cleared")




        ServerSettings.EventLogMessages.Add(&HC500, "Control - AFC Not Ready Bit Set")
        ServerSettings.EventLogMessages.Add(&HC508, "Control - AFC Not Ready Bit Cleared")
        ServerSettings.EventLogMessages.Add(&HC501, "Control - AFC Not Configured Bit Set")
        ServerSettings.EventLogMessages.Add(&HC509, "Control - AFC Not Configured Bit Cleared")
        ServerSettings.EventLogMessages.Add(&HC502, "Control - AFC Self Check Error Bit Set")
        ServerSettings.EventLogMessages.Add(&HC50A, "Control - AFC Self Check Error Bit Cleared")
        ServerSettings.EventLogMessages.Add(&HC503, "Control - AFC Control 3 Bit Set")
        ServerSettings.EventLogMessages.Add(&HC50B, "Control - AFC Control 3 Bit Cleared")
        ServerSettings.EventLogMessages.Add(&HC504, "Control - AFC Control 4 Bit Set")
        ServerSettings.EventLogMessages.Add(&HC50C, "Control - AFC Control 4 Bit Cleared")
        ServerSettings.EventLogMessages.Add(&HC505, "Control - AFC Control 5 Bit Set")
        ServerSettings.EventLogMessages.Add(&HC50D, "Control - AFC Control 5 Bit Cleared")
        ServerSettings.EventLogMessages.Add(&HC506, "Control - AFC Control 6 Bit Set")
        ServerSettings.EventLogMessages.Add(&HC50E, "Control - AFC Control 6 Bit Cleared")
        ServerSettings.EventLogMessages.Add(&HC507, "Control - AFC Control 7 Bit Set")
        ServerSettings.EventLogMessages.Add(&HC50F, "Control - AFC Control 7 Bit Cleared")

        ServerSettings.EventLogMessages.Add(&HC510, "Notice - AFC Notice 0")
        ServerSettings.EventLogMessages.Add(&HC511, "Notice - AFC Notice 1")
        ServerSettings.EventLogMessages.Add(&HC512, "Notice - AFC Notice 2")
        ServerSettings.EventLogMessages.Add(&HC513, "Notice - AFC Notice 3")
        ServerSettings.EventLogMessages.Add(&HC514, "Notice - AFC Notice 4")
        ServerSettings.EventLogMessages.Add(&HC515, "Notice - AFC Notice 5")
        ServerSettings.EventLogMessages.Add(&HC516, "Notice - AFC Notice 6")
        ServerSettings.EventLogMessages.Add(&HC517, "Notice - AFC Notice 7")

        ServerSettings.EventLogMessages.Add(&HC520, "Fault - AFC Fault 0 Bit Set")
        ServerSettings.EventLogMessages.Add(&HC530, "Fault - AFC Fault 0 Bit Cleared")
        ServerSettings.EventLogMessages.Add(&HC521, "Fault - AFC Fault 1 Bit Set")
        ServerSettings.EventLogMessages.Add(&HC531, "Fault - AFC Fault 1 Bit Cleared")
        ServerSettings.EventLogMessages.Add(&HC522, "Fault - AFC Fault 2 Bit Set")
        ServerSettings.EventLogMessages.Add(&HC532, "Fault - AFC Fault 2 Bit Cleared")
        ServerSettings.EventLogMessages.Add(&HC523, "Fault - AFC Fault 3 Bit Set")
        ServerSettings.EventLogMessages.Add(&HC533, "Fault - AFC Fault 3 Bit Cleared")
        ServerSettings.EventLogMessages.Add(&HC524, "Fault - AFC Fault 4 Bit Set")
        ServerSettings.EventLogMessages.Add(&HC534, "Fault - AFC Fault 4 Bit Cleared")
        ServerSettings.EventLogMessages.Add(&HC525, "Fault - AFC Fault 5 Bit Set")
        ServerSettings.EventLogMessages.Add(&HC535, "Fault - AFC Fault 5 Bit Cleared")
        ServerSettings.EventLogMessages.Add(&HC526, "Fault - AFC Fault 6 Bit Set")
        ServerSettings.EventLogMessages.Add(&HC536, "Fault - AFC Fault 6 Bit Cleared")
        ServerSettings.EventLogMessages.Add(&HC527, "Fault - AFC Fault 7 Bit Set")
        ServerSettings.EventLogMessages.Add(&HC537, "Fault - AFC Fault 7 Bit Cleared")
        ServerSettings.EventLogMessages.Add(&HC528, "Fault - AFC Fault 8 Bit Set")
        ServerSettings.EventLogMessages.Add(&HC538, "Fault - AFC Fault 8 Bit Cleared")
        ServerSettings.EventLogMessages.Add(&HC529, "Fault - AFC Fault 9 Bit Set")
        ServerSettings.EventLogMessages.Add(&HC539, "Fault - AFC Fault 9 Bit Cleared")
        ServerSettings.EventLogMessages.Add(&HC52A, "Fault - AFC Fault A Bit Set")
        ServerSettings.EventLogMessages.Add(&HC53A, "Fault - AFC Fault A Bit Cleared")
        ServerSettings.EventLogMessages.Add(&HC52B, "Fault - AFC Fault B Bit Set")
        ServerSettings.EventLogMessages.Add(&HC53B, "Fault - AFC Fault B Bit Cleared")
        ServerSettings.EventLogMessages.Add(&HC52C, "Fault - AFC Fault C Bit Set")
        ServerSettings.EventLogMessages.Add(&HC53C, "Fault - AFC Fault C Bit Cleared")
        ServerSettings.EventLogMessages.Add(&HC52D, "Fault - AFC Fault D Bit Set")
        ServerSettings.EventLogMessages.Add(&HC53D, "Fault - AFC Fault D Bit Cleared")
        ServerSettings.EventLogMessages.Add(&HC52E, "Fault - AFC Fault E Bit Set")
        ServerSettings.EventLogMessages.Add(&HC53E, "Fault - AFC Fault E Bit Cleared")
        ServerSettings.EventLogMessages.Add(&HC52F, "Fault - AFC Fault F Bit Set")
        ServerSettings.EventLogMessages.Add(&HC53F, "Fault - AFC Fault F Bit Cleared")

        ServerSettings.EventLogMessages.Add(&HC540, "Log - AFC Logged 0 Bit Set")
        ServerSettings.EventLogMessages.Add(&HC550, "Log - AFC Logged 0 Bit Cleared")
        ServerSettings.EventLogMessages.Add(&HC541, "Log - AFC Logged 1 Bit Set")
        ServerSettings.EventLogMessages.Add(&HC551, "Log - AFC Logged 1 Bit Cleared")
        ServerSettings.EventLogMessages.Add(&HC542, "Log - AFC Logged 2 Bit Set")
        ServerSettings.EventLogMessages.Add(&HC552, "Log - AFC Logged 2 Bit Cleared")
        ServerSettings.EventLogMessages.Add(&HC543, "Log - AFC Logged 3 Bit Set")
        ServerSettings.EventLogMessages.Add(&HC553, "Log - AFC Logged 3 Bit Cleared")
        ServerSettings.EventLogMessages.Add(&HC544, "Log - AFC Logged 4 Bit Set")
        ServerSettings.EventLogMessages.Add(&HC554, "Log - AFC Logged 4 Bit Cleared")
        ServerSettings.EventLogMessages.Add(&HC545, "Log - AFC Logged 5 Bit Set")
        ServerSettings.EventLogMessages.Add(&HC555, "Log - AFC Logged 5 Bit Cleared")
        ServerSettings.EventLogMessages.Add(&HC546, "Log - AFC Logged 6 Bit Set")
        ServerSettings.EventLogMessages.Add(&HC556, "Log - AFC Logged 6 Bit Cleared")
        ServerSettings.EventLogMessages.Add(&HC547, "Log - AFC Logged 7 Bit Set")
        ServerSettings.EventLogMessages.Add(&HC557, "Log - AFC Logged 7 Bit Cleared")
        ServerSettings.EventLogMessages.Add(&HC548, "Log - AFC Logged 8 Bit Set")
        ServerSettings.EventLogMessages.Add(&HC558, "Log - AFC Logged 8 Bit Cleared")
        ServerSettings.EventLogMessages.Add(&HC549, "Log - AFC Logged 9 Bit Set")
        ServerSettings.EventLogMessages.Add(&HC559, "Log - AFC Logged 9 Bit Cleared")
        ServerSettings.EventLogMessages.Add(&HC54A, "Log - AFC Logged A Bit Set")
        ServerSettings.EventLogMessages.Add(&HC55A, "Log - AFC Logged A Bit Cleared")
        ServerSettings.EventLogMessages.Add(&HC54B, "Log - AFC Logged B Bit Set")
        ServerSettings.EventLogMessages.Add(&HC55B, "Log - AFC Logged B Bit Cleared")
        ServerSettings.EventLogMessages.Add(&HC54C, "Log - AFC Logged C Bit Set")
        ServerSettings.EventLogMessages.Add(&HC55C, "Log - AFC Logged C Bit Cleared")
        ServerSettings.EventLogMessages.Add(&HC54D, "Log - AFC Logged D Bit Set")
        ServerSettings.EventLogMessages.Add(&HC55D, "Log - AFC Logged D Bit Cleared")
        ServerSettings.EventLogMessages.Add(&HC54E, "Log - AFC Logged E Bit Set")
        ServerSettings.EventLogMessages.Add(&HC55E, "Log - AFC Logged E Bit Cleared")
        ServerSettings.EventLogMessages.Add(&HC54F, "Log - AFC Logged F Bit Set")
        ServerSettings.EventLogMessages.Add(&HC55F, "Log - AFC Logged F Bit Cleared")






        ServerSettings.EventLogMessages.Add(&HC600, "Control - Cooling Interfacce Not Ready Bit Set")
        ServerSettings.EventLogMessages.Add(&HC608, "Control - Cooling Interfacce Not Ready Bit Cleared")
        ServerSettings.EventLogMessages.Add(&HC601, "Control - Cooling Interfacce Not Configured Bit Set")
        ServerSettings.EventLogMessages.Add(&HC609, "Control - Cooling Interfacce Not Configured Bit Cleared")
        ServerSettings.EventLogMessages.Add(&HC602, "Control - Cooling Interfacce Self Check Error Bit Set")
        ServerSettings.EventLogMessages.Add(&HC60A, "Control - Cooling Interfacce Self Check Error Bit Cleared")
        ServerSettings.EventLogMessages.Add(&HC603, "Control - Cooling Interfacce Control 3 Bit Set")
        ServerSettings.EventLogMessages.Add(&HC60B, "Control - Cooling Interfacce Control 3 Bit Cleared")
        ServerSettings.EventLogMessages.Add(&HC604, "Control - Cooling Interfacce Control 4 Bit Set")
        ServerSettings.EventLogMessages.Add(&HC60C, "Control - Cooling Interfacce Control 4 Bit Cleared")
        ServerSettings.EventLogMessages.Add(&HC605, "Control - Cooling Interfacce Control 5 Bit Set")
        ServerSettings.EventLogMessages.Add(&HC60D, "Control - Cooling Interfacce Control 5 Bit Cleared")
        ServerSettings.EventLogMessages.Add(&HC606, "Control - Cooling Interfacce Control 6 Bit Set")
        ServerSettings.EventLogMessages.Add(&HC60E, "Control - Cooling Interfacce Control 6 Bit Cleared")
        ServerSettings.EventLogMessages.Add(&HC607, "Control - Cooling Interfacce Control 7 Bit Set")
        ServerSettings.EventLogMessages.Add(&HC60F, "Control - Cooling Interfacce Control 7 Bit Cleared")

        ServerSettings.EventLogMessages.Add(&HC610, "Notice - Cooling Interfacce Notice 0")
        ServerSettings.EventLogMessages.Add(&HC611, "Notice - Cooling Interfacce Notice 1")
        ServerSettings.EventLogMessages.Add(&HC612, "Notice - Cooling Interfacce Notice 2")
        ServerSettings.EventLogMessages.Add(&HC613, "Notice - Cooling Interfacce Notice 3")
        ServerSettings.EventLogMessages.Add(&HC614, "Notice - Cooling Interfacce Notice 4")
        ServerSettings.EventLogMessages.Add(&HC615, "Notice - Cooling Interfacce Notice 5")
        ServerSettings.EventLogMessages.Add(&HC616, "Notice - Cooling Interfacce Notice 6")
        ServerSettings.EventLogMessages.Add(&HC617, "Notice - Cooling Interfacce Notice 7")

        ServerSettings.EventLogMessages.Add(&HC620, "Fault - Cooling Interfacce Fault 0 Bit Set")
        ServerSettings.EventLogMessages.Add(&HC630, "Fault - Cooling Interfacce Fault 0 Bit Cleared")
        ServerSettings.EventLogMessages.Add(&HC621, "Fault - Cooling Interfacce Fault 1 Bit Set")
        ServerSettings.EventLogMessages.Add(&HC631, "Fault - Cooling Interfacce Fault 1 Bit Cleared")
        ServerSettings.EventLogMessages.Add(&HC622, "Fault - Cooling Interfacce Fault 2 Bit Set")
        ServerSettings.EventLogMessages.Add(&HC632, "Fault - Cooling Interfacce Fault 2 Bit Cleared")
        ServerSettings.EventLogMessages.Add(&HC623, "Fault - Cooling Interfacce Fault 3 Bit Set")
        ServerSettings.EventLogMessages.Add(&HC633, "Fault - Cooling Interfacce Fault 3 Bit Cleared")
        ServerSettings.EventLogMessages.Add(&HC624, "Fault - Cooling Interfacce Fault 4 Bit Set")
        ServerSettings.EventLogMessages.Add(&HC634, "Fault - Cooling Interfacce Fault 4 Bit Cleared")
        ServerSettings.EventLogMessages.Add(&HC625, "Fault - Cooling Interfacce Fault 5 Bit Set")
        ServerSettings.EventLogMessages.Add(&HC635, "Fault - Cooling Interfacce Fault 5 Bit Cleared")
        ServerSettings.EventLogMessages.Add(&HC626, "Fault - Cooling Interfacce Fault 6 Bit Set")
        ServerSettings.EventLogMessages.Add(&HC636, "Fault - Cooling Interfacce Fault 6 Bit Cleared")
        ServerSettings.EventLogMessages.Add(&HC627, "Fault - Cooling Interfacce Fault 7 Bit Set")
        ServerSettings.EventLogMessages.Add(&HC637, "Fault - Cooling Interfacce Fault 7 Bit Cleared")
        ServerSettings.EventLogMessages.Add(&HC628, "Fault - Cooling Interfacce Fault 8 Bit Set")
        ServerSettings.EventLogMessages.Add(&HC638, "Fault - Cooling Interfacce Fault 8 Bit Cleared")
        ServerSettings.EventLogMessages.Add(&HC629, "Fault - Cooling Interfacce Fault 9 Bit Set")
        ServerSettings.EventLogMessages.Add(&HC639, "Fault - Cooling Interfacce Fault 9 Bit Cleared")
        ServerSettings.EventLogMessages.Add(&HC62A, "Fault - Cooling Interfacce Fault A Bit Set")
        ServerSettings.EventLogMessages.Add(&HC63A, "Fault - Cooling Interfacce Fault A Bit Cleared")
        ServerSettings.EventLogMessages.Add(&HC62B, "Fault - Cooling Interfacce Fault B Bit Set")
        ServerSettings.EventLogMessages.Add(&HC63B, "Fault - Cooling Interfacce Fault B Bit Cleared")
        ServerSettings.EventLogMessages.Add(&HC62C, "Fault - Cooling Interfacce Fault C Bit Set")
        ServerSettings.EventLogMessages.Add(&HC63C, "Fault - Cooling Interfacce Fault C Bit Cleared")
        ServerSettings.EventLogMessages.Add(&HC62D, "Fault - Cooling Interfacce Fault D Bit Set")
        ServerSettings.EventLogMessages.Add(&HC63D, "Fault - Cooling Interfacce Fault D Bit Cleared")
        ServerSettings.EventLogMessages.Add(&HC62E, "Fault - Cooling Interfacce Fault E Bit Set")
        ServerSettings.EventLogMessages.Add(&HC63E, "Fault - Cooling Interfacce Fault E Bit Cleared")
        ServerSettings.EventLogMessages.Add(&HC62F, "Fault - Cooling Interfacce Fault F Bit Set")
        ServerSettings.EventLogMessages.Add(&HC63F, "Fault - Cooling Interfacce Fault F Bit Cleared")

        ServerSettings.EventLogMessages.Add(&HC640, "Log - Cooling Interfacce Logged 0 Bit Set")
        ServerSettings.EventLogMessages.Add(&HC650, "Log - Cooling Interfacce Logged 0 Bit Cleared")
        ServerSettings.EventLogMessages.Add(&HC641, "Log - Cooling Interfacce Logged 1 Bit Set")
        ServerSettings.EventLogMessages.Add(&HC651, "Log - Cooling Interfacce Logged 1 Bit Cleared")
        ServerSettings.EventLogMessages.Add(&HC642, "Log - Cooling Interfacce Logged 2 Bit Set")
        ServerSettings.EventLogMessages.Add(&HC652, "Log - Cooling Interfacce Logged 2 Bit Cleared")
        ServerSettings.EventLogMessages.Add(&HC643, "Log - Cooling Interfacce Logged 3 Bit Set")
        ServerSettings.EventLogMessages.Add(&HC653, "Log - Cooling Interfacce Logged 3 Bit Cleared")
        ServerSettings.EventLogMessages.Add(&HC644, "Log - Cooling Interfacce Logged 4 Bit Set")
        ServerSettings.EventLogMessages.Add(&HC654, "Log - Cooling Interfacce Logged 4 Bit Cleared")
        ServerSettings.EventLogMessages.Add(&HC645, "Log - Cooling Interfacce Logged 5 Bit Set")
        ServerSettings.EventLogMessages.Add(&HC655, "Log - Cooling Interfacce Logged 5 Bit Cleared")
        ServerSettings.EventLogMessages.Add(&HC646, "Log - Cooling Interfacce Logged 6 Bit Set")
        ServerSettings.EventLogMessages.Add(&HC656, "Log - Cooling Interfacce Logged 6 Bit Cleared")
        ServerSettings.EventLogMessages.Add(&HC647, "Log - Cooling Interfacce Logged 7 Bit Set")
        ServerSettings.EventLogMessages.Add(&HC657, "Log - Cooling Interfacce Logged 7 Bit Cleared")
        ServerSettings.EventLogMessages.Add(&HC648, "Log - Cooling Interfacce Logged 8 Bit Set")
        ServerSettings.EventLogMessages.Add(&HC658, "Log - Cooling Interfacce Logged 8 Bit Cleared")
        ServerSettings.EventLogMessages.Add(&HC649, "Log - Cooling Interfacce Logged 9 Bit Set")
        ServerSettings.EventLogMessages.Add(&HC659, "Log - Cooling Interfacce Logged 9 Bit Cleared")
        ServerSettings.EventLogMessages.Add(&HC64A, "Log - Cooling Interfacce Logged A Bit Set")
        ServerSettings.EventLogMessages.Add(&HC65A, "Log - Cooling Interfacce Logged A Bit Cleared")
        ServerSettings.EventLogMessages.Add(&HC64B, "Log - Cooling Interfacce Logged B Bit Set")
        ServerSettings.EventLogMessages.Add(&HC65B, "Log - Cooling Interfacce Logged B Bit Cleared")
        ServerSettings.EventLogMessages.Add(&HC64C, "Log - Cooling Interfacce Logged C Bit Set")
        ServerSettings.EventLogMessages.Add(&HC65C, "Log - Cooling Interfacce Logged C Bit Cleared")
        ServerSettings.EventLogMessages.Add(&HC64D, "Log - Cooling Interfacce Logged D Bit Set")
        ServerSettings.EventLogMessages.Add(&HC65D, "Log - Cooling Interfacce Logged D Bit Cleared")
        ServerSettings.EventLogMessages.Add(&HC64E, "Log - Cooling Interfacce Logged E Bit Set")
        ServerSettings.EventLogMessages.Add(&HC65E, "Log - Cooling Interfacce Logged E Bit Cleared")
        ServerSettings.EventLogMessages.Add(&HC64F, "Log - Cooling Interfacce Logged F Bit Set")
        ServerSettings.EventLogMessages.Add(&HC65F, "Log - Cooling Interfacce Logged F Bit Cleared")






        ServerSettings.EventLogMessages.Add(&HC700, "Control - Heater Magnet Not Ready Bit Set")
        ServerSettings.EventLogMessages.Add(&HC708, "Control - Heater Magnet Not Ready Bit Cleared")
        ServerSettings.EventLogMessages.Add(&HC701, "Control - Heater Magnet Not Configured Bit Set")
        ServerSettings.EventLogMessages.Add(&HC709, "Control - Heater Magnet Not Configured Bit Cleared")
        ServerSettings.EventLogMessages.Add(&HC702, "Control - Heater Magnet Self Check Error Bit Set")
        ServerSettings.EventLogMessages.Add(&HC70A, "Control - Heater Magnet Self Check Error Bit Cleared")
        ServerSettings.EventLogMessages.Add(&HC703, "Control - Heater Magnet Control 3 Bit Set")
        ServerSettings.EventLogMessages.Add(&HC70B, "Control - Heater Magnet Control 3 Bit Cleared")
        ServerSettings.EventLogMessages.Add(&HC704, "Control - Heater Magnet Control 4 Bit Set")
        ServerSettings.EventLogMessages.Add(&HC70C, "Control - Heater Magnet Control 4 Bit Cleared")
        ServerSettings.EventLogMessages.Add(&HC705, "Control - Heater Magnet Control 5 Bit Set")
        ServerSettings.EventLogMessages.Add(&HC70D, "Control - Heater Magnet Control 5 Bit Cleared")
        ServerSettings.EventLogMessages.Add(&HC706, "Control - Heater Magnet Control 6 Bit Set")
        ServerSettings.EventLogMessages.Add(&HC70E, "Control - Heater Magnet Control 6 Bit Cleared")
        ServerSettings.EventLogMessages.Add(&HC707, "Control - Heater Magnet Control 7 Bit Set")
        ServerSettings.EventLogMessages.Add(&HC70F, "Control - Heater Magnet Control 7 Bit Cleared")

        ServerSettings.EventLogMessages.Add(&HC710, "Notice - Heater Magnet Notice 0")
        ServerSettings.EventLogMessages.Add(&HC711, "Notice - Heater Magnet Notice 1")
        ServerSettings.EventLogMessages.Add(&HC712, "Notice - Heater Magnet Notice 2")
        ServerSettings.EventLogMessages.Add(&HC713, "Notice - Heater Magnet Notice 3")
        ServerSettings.EventLogMessages.Add(&HC714, "Notice - Heater Magnet Notice 4")
        ServerSettings.EventLogMessages.Add(&HC715, "Notice - Heater Magnet Notice 5")
        ServerSettings.EventLogMessages.Add(&HC716, "Notice - Heater Magnet Notice 6")
        ServerSettings.EventLogMessages.Add(&HC717, "Notice - Heater Magnet Notice 7")

        ServerSettings.EventLogMessages.Add(&HC720, "Fault - Heater Magnet Fault 0 Bit Set")
        ServerSettings.EventLogMessages.Add(&HC730, "Fault - Heater Magnet Fault 0 Bit Cleared")
        ServerSettings.EventLogMessages.Add(&HC721, "Fault - Heater Magnet Fault 1 Bit Set")
        ServerSettings.EventLogMessages.Add(&HC731, "Fault - Heater Magnet Fault 1 Bit Cleared")
        ServerSettings.EventLogMessages.Add(&HC722, "Fault - Heater Magnet Fault 2 Bit Set")
        ServerSettings.EventLogMessages.Add(&HC732, "Fault - Heater Magnet Fault 2 Bit Cleared")
        ServerSettings.EventLogMessages.Add(&HC723, "Fault - Heater Magnet Fault 3 Bit Set")
        ServerSettings.EventLogMessages.Add(&HC733, "Fault - Heater Magnet Fault 3 Bit Cleared")
        ServerSettings.EventLogMessages.Add(&HC724, "Fault - Heater Magnet Fault 4 Bit Set")
        ServerSettings.EventLogMessages.Add(&HC734, "Fault - Heater Magnet Fault 4 Bit Cleared")
        ServerSettings.EventLogMessages.Add(&HC725, "Fault - Heater Magnet Fault 5 Bit Set")
        ServerSettings.EventLogMessages.Add(&HC735, "Fault - Heater Magnet Fault 5 Bit Cleared")
        ServerSettings.EventLogMessages.Add(&HC726, "Fault - Heater Magnet Fault 6 Bit Set")
        ServerSettings.EventLogMessages.Add(&HC736, "Fault - Heater Magnet Fault 6 Bit Cleared")
        ServerSettings.EventLogMessages.Add(&HC727, "Fault - Heater Magnet Fault 7 Bit Set")
        ServerSettings.EventLogMessages.Add(&HC737, "Fault - Heater Magnet Fault 7 Bit Cleared")
        ServerSettings.EventLogMessages.Add(&HC728, "Fault - Heater Magnet Fault 8 Bit Set")
        ServerSettings.EventLogMessages.Add(&HC738, "Fault - Heater Magnet Fault 8 Bit Cleared")
        ServerSettings.EventLogMessages.Add(&HC729, "Fault - Heater Magnet Fault 9 Bit Set")
        ServerSettings.EventLogMessages.Add(&HC739, "Fault - Heater Magnet Fault 9 Bit Cleared")
        ServerSettings.EventLogMessages.Add(&HC72A, "Fault - Heater Magnet Fault A Bit Set")
        ServerSettings.EventLogMessages.Add(&HC73A, "Fault - Heater Magnet Fault A Bit Cleared")
        ServerSettings.EventLogMessages.Add(&HC72B, "Fault - Heater Magnet Fault B Bit Set")
        ServerSettings.EventLogMessages.Add(&HC73B, "Fault - Heater Magnet Fault B Bit Cleared")
        ServerSettings.EventLogMessages.Add(&HC72C, "Fault - Heater Magnet Fault C Bit Set")
        ServerSettings.EventLogMessages.Add(&HC73C, "Fault - Heater Magnet Fault C Bit Cleared")
        ServerSettings.EventLogMessages.Add(&HC72D, "Fault - Heater Magnet Fault D Bit Set")
        ServerSettings.EventLogMessages.Add(&HC73D, "Fault - Heater Magnet Fault D Bit Cleared")
        ServerSettings.EventLogMessages.Add(&HC72E, "Fault - Heater Magnet Fault E Bit Set")
        ServerSettings.EventLogMessages.Add(&HC73E, "Fault - Heater Magnet Fault E Bit Cleared")
        ServerSettings.EventLogMessages.Add(&HC72F, "Fault - Heater Magnet Fault F Bit Set")
        ServerSettings.EventLogMessages.Add(&HC73F, "Fault - Heater Magnet Fault F Bit Cleared")

        ServerSettings.EventLogMessages.Add(&HC740, "Log - Heater Magnet Logged 0 Bit Set")
        ServerSettings.EventLogMessages.Add(&HC750, "Log - Heater Magnet Logged 0 Bit Cleared")
        ServerSettings.EventLogMessages.Add(&HC741, "Log - Heater Magnet Logged 1 Bit Set")
        ServerSettings.EventLogMessages.Add(&HC751, "Log - Heater Magnet Logged 1 Bit Cleared")
        ServerSettings.EventLogMessages.Add(&HC742, "Log - Heater Magnet Logged 2 Bit Set")
        ServerSettings.EventLogMessages.Add(&HC752, "Log - Heater Magnet Logged 2 Bit Cleared")
        ServerSettings.EventLogMessages.Add(&HC743, "Log - Heater Magnet Logged 3 Bit Set")
        ServerSettings.EventLogMessages.Add(&HC753, "Log - Heater Magnet Logged 3 Bit Cleared")
        ServerSettings.EventLogMessages.Add(&HC744, "Log - Heater Magnet Logged 4 Bit Set")
        ServerSettings.EventLogMessages.Add(&HC754, "Log - Heater Magnet Logged 4 Bit Cleared")
        ServerSettings.EventLogMessages.Add(&HC745, "Log - Heater Magnet Logged 5 Bit Set")
        ServerSettings.EventLogMessages.Add(&HC755, "Log - Heater Magnet Logged 5 Bit Cleared")
        ServerSettings.EventLogMessages.Add(&HC746, "Log - Heater Magnet Logged 6 Bit Set")
        ServerSettings.EventLogMessages.Add(&HC756, "Log - Heater Magnet Logged 6 Bit Cleared")
        ServerSettings.EventLogMessages.Add(&HC747, "Log - Heater Magnet Logged 7 Bit Set")
        ServerSettings.EventLogMessages.Add(&HC757, "Log - Heater Magnet Logged 7 Bit Cleared")
        ServerSettings.EventLogMessages.Add(&HC748, "Log - Heater Magnet Logged 8 Bit Set")
        ServerSettings.EventLogMessages.Add(&HC758, "Log - Heater Magnet Logged 8 Bit Cleared")
        ServerSettings.EventLogMessages.Add(&HC749, "Log - Heater Magnet Logged 9 Bit Set")
        ServerSettings.EventLogMessages.Add(&HC759, "Log - Heater Magnet Logged 9 Bit Cleared")
        ServerSettings.EventLogMessages.Add(&HC74A, "Log - Heater Magnet Logged A Bit Set")
        ServerSettings.EventLogMessages.Add(&HC75A, "Log - Heater Magnet Logged A Bit Cleared")
        ServerSettings.EventLogMessages.Add(&HC74B, "Log - Heater Magnet Logged B Bit Set")
        ServerSettings.EventLogMessages.Add(&HC75B, "Log - Heater Magnet Logged B Bit Cleared")
        ServerSettings.EventLogMessages.Add(&HC74C, "Log - Heater Magnet Logged C Bit Set")
        ServerSettings.EventLogMessages.Add(&HC75C, "Log - Heater Magnet Logged C Bit Cleared")
        ServerSettings.EventLogMessages.Add(&HC74D, "Log - Heater Magnet Logged D Bit Set")
        ServerSettings.EventLogMessages.Add(&HC75D, "Log - Heater Magnet Logged D Bit Cleared")
        ServerSettings.EventLogMessages.Add(&HC74E, "Log - Heater Magnet Logged E Bit Set")
        ServerSettings.EventLogMessages.Add(&HC75E, "Log - Heater Magnet Logged E Bit Cleared")
        ServerSettings.EventLogMessages.Add(&HC74F, "Log - Heater Magnet Logged F Bit Set")
        ServerSettings.EventLogMessages.Add(&HC75F, "Log - Heater Magnet Logged F Bit Cleared")






        ServerSettings.EventLogMessages.Add(&HC800, "Control - Gun Driver Not Ready Bit Set")
        ServerSettings.EventLogMessages.Add(&HC808, "Control - Gun Driver Not Ready Bit Cleared")
        ServerSettings.EventLogMessages.Add(&HC801, "Control - Gun Driver Not Configured Bit Set")
        ServerSettings.EventLogMessages.Add(&HC809, "Control - Gun Driver Not Configured Bit Cleared")
        ServerSettings.EventLogMessages.Add(&HC802, "Control - Gun Driver Self Check Error Bit Set")
        ServerSettings.EventLogMessages.Add(&HC80A, "Control - Gun Driver Self Check Error Bit Cleared")
        ServerSettings.EventLogMessages.Add(&HC803, "Control - Gun Driver Control 3 Bit Set")
        ServerSettings.EventLogMessages.Add(&HC80B, "Control - Gun Driver Control 3 Bit Cleared")
        ServerSettings.EventLogMessages.Add(&HC804, "Control - Gun Driver Control 4 Bit Set")
        ServerSettings.EventLogMessages.Add(&HC80C, "Control - Gun Driver Control 4 Bit Cleared")
        ServerSettings.EventLogMessages.Add(&HC805, "Control - Gun Driver Control 5 Bit Set")
        ServerSettings.EventLogMessages.Add(&HC80D, "Control - Gun Driver Control 5 Bit Cleared")
        ServerSettings.EventLogMessages.Add(&HC806, "Control - Gun Driver Control 6 Bit Set")
        ServerSettings.EventLogMessages.Add(&HC80E, "Control - Gun Driver Control 6 Bit Cleared")
        ServerSettings.EventLogMessages.Add(&HC807, "Control - Gun Driver Control 7 Bit Set")
        ServerSettings.EventLogMessages.Add(&HC80F, "Control - Gun Driver Control 7 Bit Cleared")

        ServerSettings.EventLogMessages.Add(&HC810, "Notice - Gun Driver Notice 0")
        ServerSettings.EventLogMessages.Add(&HC811, "Notice - Gun Driver Notice 1")
        ServerSettings.EventLogMessages.Add(&HC812, "Notice - Gun Driver Notice 2")
        ServerSettings.EventLogMessages.Add(&HC813, "Notice - Gun Driver Notice 3")
        ServerSettings.EventLogMessages.Add(&HC814, "Notice - Gun Driver Notice 4")
        ServerSettings.EventLogMessages.Add(&HC815, "Notice - Gun Driver Notice 5")
        ServerSettings.EventLogMessages.Add(&HC816, "Notice - Gun Driver Notice 6")
        ServerSettings.EventLogMessages.Add(&HC817, "Notice - Gun Driver Notice 7")

        ServerSettings.EventLogMessages.Add(&HC820, "Fault - Gun Driver Fault 0 Bit Set")
        ServerSettings.EventLogMessages.Add(&HC830, "Fault - Gun Driver Fault 0 Bit Cleared")
        ServerSettings.EventLogMessages.Add(&HC821, "Fault - Gun Driver Fault 1 Bit Set")
        ServerSettings.EventLogMessages.Add(&HC831, "Fault - Gun Driver Fault 1 Bit Cleared")
        ServerSettings.EventLogMessages.Add(&HC822, "Fault - Gun Driver Fault 2 Bit Set")
        ServerSettings.EventLogMessages.Add(&HC832, "Fault - Gun Driver Fault 2 Bit Cleared")
        ServerSettings.EventLogMessages.Add(&HC823, "Fault - Gun Driver Fault 3 Bit Set")
        ServerSettings.EventLogMessages.Add(&HC833, "Fault - Gun Driver Fault 3 Bit Cleared")
        ServerSettings.EventLogMessages.Add(&HC824, "Fault - Gun Driver Fault 4 Bit Set")
        ServerSettings.EventLogMessages.Add(&HC834, "Fault - Gun Driver Fault 4 Bit Cleared")
        ServerSettings.EventLogMessages.Add(&HC825, "Fault - Gun Driver Fault 5 Bit Set")
        ServerSettings.EventLogMessages.Add(&HC835, "Fault - Gun Driver Fault 5 Bit Cleared")
        ServerSettings.EventLogMessages.Add(&HC826, "Fault - Gun Driver Fault 6 Bit Set")
        ServerSettings.EventLogMessages.Add(&HC836, "Fault - Gun Driver Fault 6 Bit Cleared")
        ServerSettings.EventLogMessages.Add(&HC827, "Fault - Gun Driver Fault 7 Bit Set")
        ServerSettings.EventLogMessages.Add(&HC837, "Fault - Gun Driver Fault 7 Bit Cleared")
        ServerSettings.EventLogMessages.Add(&HC828, "Fault - Gun Driver Fault 8 Bit Set")
        ServerSettings.EventLogMessages.Add(&HC838, "Fault - Gun Driver Fault 8 Bit Cleared")
        ServerSettings.EventLogMessages.Add(&HC829, "Fault - Gun Driver Fault 9 Bit Set")
        ServerSettings.EventLogMessages.Add(&HC839, "Fault - Gun Driver Fault 9 Bit Cleared")
        ServerSettings.EventLogMessages.Add(&HC82A, "Fault - Gun Driver Fault A Bit Set")
        ServerSettings.EventLogMessages.Add(&HC83A, "Fault - Gun Driver Fault A Bit Cleared")
        ServerSettings.EventLogMessages.Add(&HC82B, "Fault - Gun Driver Fault B Bit Set")
        ServerSettings.EventLogMessages.Add(&HC83B, "Fault - Gun Driver Fault B Bit Cleared")
        ServerSettings.EventLogMessages.Add(&HC82C, "Fault - Gun Driver Fault C Bit Set")
        ServerSettings.EventLogMessages.Add(&HC83C, "Fault - Gun Driver Fault C Bit Cleared")
        ServerSettings.EventLogMessages.Add(&HC82D, "Fault - Gun Driver Fault D Bit Set")
        ServerSettings.EventLogMessages.Add(&HC83D, "Fault - Gun Driver Fault D Bit Cleared")
        ServerSettings.EventLogMessages.Add(&HC82E, "Fault - Gun Driver Fault E Bit Set")
        ServerSettings.EventLogMessages.Add(&HC83E, "Fault - Gun Driver Fault E Bit Cleared")
        ServerSettings.EventLogMessages.Add(&HC82F, "Fault - Gun Driver Fault F Bit Set")
        ServerSettings.EventLogMessages.Add(&HC83F, "Fault - Gun Driver Fault F Bit Cleared")

        ServerSettings.EventLogMessages.Add(&HC840, "Log - Gun Driver Logged 0 Bit Set")
        ServerSettings.EventLogMessages.Add(&HC850, "Log - Gun Driver Logged 0 Bit Cleared")
        ServerSettings.EventLogMessages.Add(&HC841, "Log - Gun Driver Logged 1 Bit Set")
        ServerSettings.EventLogMessages.Add(&HC851, "Log - Gun Driver Logged 1 Bit Cleared")
        ServerSettings.EventLogMessages.Add(&HC842, "Log - Gun Driver Logged 2 Bit Set")
        ServerSettings.EventLogMessages.Add(&HC852, "Log - Gun Driver Logged 2 Bit Cleared")
        ServerSettings.EventLogMessages.Add(&HC843, "Log - Gun Driver Logged 3 Bit Set")
        ServerSettings.EventLogMessages.Add(&HC853, "Log - Gun Driver Logged 3 Bit Cleared")
        ServerSettings.EventLogMessages.Add(&HC844, "Log - Gun Driver Logged 4 Bit Set")
        ServerSettings.EventLogMessages.Add(&HC854, "Log - Gun Driver Logged 4 Bit Cleared")
        ServerSettings.EventLogMessages.Add(&HC845, "Log - Gun Driver Logged 5 Bit Set")
        ServerSettings.EventLogMessages.Add(&HC855, "Log - Gun Driver Logged 5 Bit Cleared")
        ServerSettings.EventLogMessages.Add(&HC846, "Log - Gun Driver Logged 6 Bit Set")
        ServerSettings.EventLogMessages.Add(&HC856, "Log - Gun Driver Logged 6 Bit Cleared")
        ServerSettings.EventLogMessages.Add(&HC847, "Log - Gun Driver Logged 7 Bit Set")
        ServerSettings.EventLogMessages.Add(&HC857, "Log - Gun Driver Logged 7 Bit Cleared")
        ServerSettings.EventLogMessages.Add(&HC848, "Log - Gun Driver Logged 8 Bit Set")
        ServerSettings.EventLogMessages.Add(&HC858, "Log - Gun Driver Logged 8 Bit Cleared")
        ServerSettings.EventLogMessages.Add(&HC849, "Log - Gun Driver Logged 9 Bit Set")
        ServerSettings.EventLogMessages.Add(&HC859, "Log - Gun Driver Logged 9 Bit Cleared")
        ServerSettings.EventLogMessages.Add(&HC84A, "Log - Gun Driver Logged A Bit Set")
        ServerSettings.EventLogMessages.Add(&HC85A, "Log - Gun Driver Logged A Bit Cleared")
        ServerSettings.EventLogMessages.Add(&HC84B, "Log - Gun Driver Logged B Bit Set")
        ServerSettings.EventLogMessages.Add(&HC85B, "Log - Gun Driver Logged B Bit Cleared")
        ServerSettings.EventLogMessages.Add(&HC84C, "Log - Gun Driver Logged C Bit Set")
        ServerSettings.EventLogMessages.Add(&HC85C, "Log - Gun Driver Logged C Bit Cleared")
        ServerSettings.EventLogMessages.Add(&HC84D, "Log - Gun Driver Logged D Bit Set")
        ServerSettings.EventLogMessages.Add(&HC85D, "Log - Gun Driver Logged D Bit Cleared")
        ServerSettings.EventLogMessages.Add(&HC84E, "Log - Gun Driver Logged E Bit Set")
        ServerSettings.EventLogMessages.Add(&HC85E, "Log - Gun Driver Logged E Bit Cleared")
        ServerSettings.EventLogMessages.Add(&HC84F, "Log - Gun Driver Logged F Bit Set")
        ServerSettings.EventLogMessages.Add(&HC85F, "Log - Gun Driver Logged F Bit Cleared")

    End Sub


    Private Sub DisplayDebugData()
#If False Then
        LabelValueDebug0.Text = ServerSettings.ETMEthernetDebugData.debug_0
        LabelValueDebug1.Text = ServerSettings.ETMEthernetDebugData.debug_1
        LabelValueDebug2.Text = ServerSettings.ETMEthernetDebugData.debug_2
        LabelValueDebug3.Text = ServerSettings.ETMEthernetDebugData.debug_3
        LabelValueDebug4.Text = ServerSettings.ETMEthernetDebugData.debug_4
        LabelValueDebug5.Text = ServerSettings.ETMEthernetDebugData.debug_5
        LabelValueDebug6.Text = ServerSettings.ETMEthernetDebugData.debug_6
        LabelValueDebug7.Text = ServerSettings.ETMEthernetDebugData.debug_7
        LabelValueDebug8.Text = ServerSettings.ETMEthernetDebugData.debug_8
        LabelValueDebug9.Text = ServerSettings.ETMEthernetDebugData.debug_9
        LabelValueDebugA.Text = ServerSettings.ETMEthernetDebugData.debug_A
        LabelValueDebugB.Text = ServerSettings.ETMEthernetDebugData.debug_B
        LabelValueDebugC.Text = ServerSettings.ETMEthernetDebugData.debug_C
        LabelValueDebugD.Text = ServerSettings.ETMEthernetDebugData.debug_D
        LabelValueDebugE.Text = ServerSettings.ETMEthernetDebugData.debug_E
        LabelValueDebugF.Text = ServerSettings.ETMEthernetDebugData.debug_F


        LabelCanCXECReg.Text = "CXEC Register = 0x" & ServerSettings.ETMEthernetDebugData.CXEC_reg_max.ToString("x")
        LabelCanErrorFlagCount.Text = "Error Flag Cnt = " & ServerSettings.ETMEthernetDebugData.can_error_flag
        LabelCanTX1Count.Text = "TX1 Cnt = " & ServerSettings.ETMEthernetDebugData.can_tx_1
        LabelCanTX2Count.Text = "TX2 Cnt = " & ServerSettings.ETMEthernetDebugData.can_tx_2
        LabelCanRX0Filt0Count.Text = "RX0 Filt 0 Cnt = " & ServerSettings.ETMEthernetDebugData.can_rx_0_filt_0
        LabelCanRX0Filt1Count.Text = "RX0 Filt 1 Cnt = " & ServerSettings.ETMEthernetDebugData.can_rx_0_filt_1
        LabelCanRX1Filt2Count.Text = "RX1 Filt 2 Cnt = " & ServerSettings.ETMEthernetDebugData.can_rx_1_filt_2
        LabelCanISREnteredCount.Text = "CXINTF = 0x" & ServerSettings.ETMEthernetDebugData.CXINTF_max.ToString("X")
        LabelCanUnknownIdentifierCount.Text = "Unknown ID Cnt = " & ServerSettings.ETMEthernetDebugData.can_unknown_msg_id
        LabelCanInvalidIndexCount.Text = "Invalid Index Cnt = " & ServerSettings.ETMEthernetDebugData.can_invalid_index
        LabelCanAddressErrorCount.Text = "Address Error Cnt = " & ServerSettings.ETMEthernetDebugData.can_address_error
        LabelCanTX0Count.Text = "TX 0 Cnt = " & ServerSettings.ETMEthernetDebugData.can_tx_0
        LabelCanTXBufOverflowCount.Text = "TX Ovrfl Cnt = " & ServerSettings.ETMEthernetDebugData.can_tx_buf_overflow
        LabelCanRXBufferOverflowCount.Text = "RX Ovrfl Cnt = " & ServerSettings.ETMEthernetDebugData.can_rx_buf_overflow
        LabelCAnDataLogRXBufferOVerflowCount.Text = "Log RX Ovrfl Cnt = " & ServerSettings.ETMEthernetDebugData.can_rx_log_buf_overflow
        LabelCanTimeoutCount.Text = "Can Timeout Cnt = " & ServerSettings.ETMEthernetDebugData.can_timeout


        LabelErrorI2CBusCount.Text = "I2C Bus Errors = " & ServerSettings.ETMEthernetDebugData.i2c_bus_error_count
        LabelErrorSPIBusCount.Text = "SPI Bus Errors = " & ServerSettings.ETMEthernetDebugData.spi_bus_error_count
        'LabelErrorCanBusCount.Text = "Can Bus Errors = " & ServerSettings.ETMEthernetTXDataStructure(board_index).debug_data.can_bus_error_count
        LabelErrorScaleCount.Text = "Scale Errors = " & ServerSettings.ETMEthernetDebugData.scale_error_count
        LabelErrorResetCount.Text = "Reset Count = " & ServerSettings.ETMEthernetDebugData.reset_count
        LabelErrorSelfTestResultRegister.Text = "Self Test = 0x" & ServerSettings.ETMEthernetDebugData.self_test_results.ToString("x")
        LabelErrorReserved0.Text = ServerSettings.ETMEthernetBoardLoggingData(MODBUS_COMMANDS.MODBUS_WR_ETHERNET).log_data(16).ToString("x") '  "= 0x" & ServerSettings.ETMEthernetDebugData.reserved_0.ToString("x")
        LabelErrorReserved1.Text = "Can Ver = 0x" & ServerSettings.ETMEthernetDebugData.reserved_1.ToString("x")
        LabelRCON.Text = "RCON = " & ServerSettings.ETMEthernetDebugData.RCON_value.ToString("X")
#End If

    End Sub



















#If False Then ' eeprom related

    Private Sub ComboBoxEEpromRegister_SelectedIndexChanged(sender As System.Object, e As System.EventArgs)
        Dim command_index As UInt16
        If board_index = MODBUS_COMMANDS.MODBUS_WR_ETHERNET Then
            command_index = ETM_CAN_ADDR_ETHERNET_BOARD
            selected_board_index = ETM_CAN_ADDR_ETHERNET_BOARD
        ElseIf board_index = MODBUS_COMMANDS.MODBUS_WR_ION_PUMP Then
            command_index = ETM_CAN_ADDR_ION_PUMP_BOARD
            selected_board_index = ETM_CAN_ADDR_ION_PUMP_BOARD
        ElseIf board_index = MODBUS_COMMANDS.MODBUS_WR_MAGNETRON_CURRENT Then
            command_index = ETM_CAN_ADDR_MAGNETRON_CURRENT_BOARD
            selected_board_index = ETM_CAN_ADDR_MAGNETRON_CURRENT_BOARD
        ElseIf board_index = MODBUS_COMMANDS.MODBUS_WR_PULSE_SYNC Then
            command_index = ETM_CAN_ADDR_PULSE_SYNC_BOARD
            selected_board_index = ETM_CAN_ADDR_PULSE_SYNC_BOARD
        ElseIf board_index = MODBUS_COMMANDS.MODBUS_WR_HVLAMBDA Then
            command_index = ETM_CAN_ADDR_HV_LAMBDA_BOARD
            selected_board_index = ETM_CAN_ADDR_HV_LAMBDA_BOARD
        ElseIf board_index = MODBUS_COMMANDS.MODBUS_WR_AFC Then
            command_index = ETM_CAN_ADDR_AFC_CONTROL_BOARD
            selected_board_index = ETM_CAN_ADDR_AFC_CONTROL_BOARD
        ElseIf board_index = MODBUS_COMMANDS.MODBUS_WR_COOLING Then
            command_index = ETM_CAN_ADDR_COOLING_INTERFACE_BOARD
            selected_board_index = ETM_CAN_ADDR_COOLING_INTERFACE_BOARD
        ElseIf board_index = MODBUS_COMMANDS.MODBUS_WR_HTR_MAGNET Then
            command_index = ETM_CAN_ADDR_HEATER_MAGNET_BOARD
            selected_board_index = ETM_CAN_ADDR_HEATER_MAGNET_BOARD
        ElseIf board_index = MODBUS_COMMANDS.MODBUS_WR_GUN_DRIVER Then
            command_index = ETM_CAN_ADDR_GUN_DRIVER_BOARD
            selected_board_index = ETM_CAN_ADDR_GUN_DRIVER_BOARD
        End If

        EEProm_index = ComboBoxEEpromRegister.SelectedIndex * 2
        command_index = command_index * 2 ^ 12
        EEProm_index = command_index + EEProm_index + &H100
        LabelEEpromIndex.Text = "Index = " & EEProm_index.ToString("x")
    End Sub

    Private Sub ButtonReadEEprom_Click(sender As System.Object, e As System.EventArgs)
        Dim offset As Double
        TextBoxEEpromScale.Text = Math.Round((ServerSettings.ETMEthernetCalStructure(EEProm_index).scale / 2 ^ 15), 5)
        offset = ServerSettings.ETMEthernetCalStructure(EEProm_index).offset
        If offset > 32767 Then
            offset = offset - 2 ^ 16
        End If
        TextBoxEEpromOffSet.Text = offset
        ServerSettings.put_modbus_commands((&H800 + EEProm_index), 0, 0, 0)
    End Sub


    Private Sub ButtonWriteEEprom_Click(sender As System.Object, e As System.EventArgs)
        Dim eeprom_scale_float As Double
        Dim eeprom_offset_float As Double
        Dim eeprom_scale As UInt16
        Dim eeprom_offset As UInt16

        eeprom_scale_float = TextBoxEEpromScale.Text
        eeprom_scale_float = eeprom_scale_float * 2 ^ 15
        If eeprom_scale_float < 0 Then
            eeprom_scale_float = 0
        End If
        If eeprom_scale_float > 65535 Then
            eeprom_scale_float = 65535
        End If

        eeprom_offset_float = TextBoxEEpromOffSet.Text
        If eeprom_offset_float > 32767 Then
            eeprom_offset_float = 32767
        End If
        If eeprom_offset_float < -32768 Then
            eeprom_offset_float = -32768
        End If
        If eeprom_offset_float < 0 Then
            eeprom_offset_float = eeprom_offset_float + 2 ^ 16
        End If


        eeprom_scale = CUShort(eeprom_scale_float)
        eeprom_offset = CUShort(eeprom_offset_float)


        'eeprom_scale = eeprom_scale_float
        'eeprom_offset = eeprom_offset_float
        ServerSettings.put_modbus_commands(EEProm_index, 0, eeprom_scale, eeprom_offset)
    End Sub
#End If




    Private Sub ButtonSetTime_Click(sender As System.Object, e As System.EventArgs)
        Dim time_high_word As UInt16
        Dim time_low_word As UInt16
        Dim time_now As Date = DateTime.UtcNow
        Dim time_seconds As UInt32

        time_seconds = (time_now.Year Mod 100) * Constants.YEAR_MULT
        time_seconds += (time_now.Month) * Constants.MONTH_MULT
        time_seconds += (time_now.Day) * Constants.DAY_MULT
        time_seconds += (time_now.Hour) * Constants.HOUR_MULT
        time_seconds += (time_now.Minute) * Constants.MIN_MULT
        time_seconds += (time_now.Second)

        time_high_word = CUShort(time_seconds >> 16)
        time_low_word = CUShort(time_seconds And &HFFFF)
        'LabelTimeSet.Text = Format(time_now, "yy MM dd HH mm ss")
        'LabelTimeSet2.Text = time_seconds
        Try
            ServerSettings.put_modbus_commands(REGISTER_SYSTEM_SET_TIME, time_high_word, time_low_word, 0)
        Catch ex As Exception
            MsgBox("Date Time Type conversion failed")

        End Try
    End Sub









    Private Sub btnDisp_Click(sender As Object, e As EventArgs) Handles btnDispOverview.Click, btnDispSysCPU.Click, btnDispService.Click, btnDispPulseSync.Click, btnDispMagnetron.Click, btnDispMagHtr.Click, btnDispIonPump.Click, btnDispHV.Click, btnDispGunDriver.Click, btnDispCoolSF6.Click, btnDispAFC.Click, btnDispDeveloperPanel.Click, btnDispServicePanel.Click
        Dim btn_select As CustomControls.ButtonSelected
        Dim index As Int16
        Dim normal_size As Size = New Size(DISP_BUTTON_WIDTH, DISP_BUTTON_HEIGHT)
        Dim select_size As Size = New Size(DISP_BUTTON_WIDTH, DISP_BUTTON_HEIGHT_SELECT)
        Dim command_indexes() As UInt16 = {0, ETM_CAN_ADDR_ETHERNET_BOARD,
                                           ETM_CAN_ADDR_GUN_DRIVER_BOARD,
                                           ETM_CAN_ADDR_COOLING_INTERFACE_BOARD,
                                           ETM_CAN_ADDR_PULSE_SYNC_BOARD,
                                           ETM_CAN_ADDR_HV_LAMBDA_BOARD,
                                           ETM_CAN_ADDR_MAGNETRON_CURRENT_BOARD,
                                           ETM_CAN_ADDR_AFC_CONTROL_BOARD,
                                           ETM_CAN_ADDR_HEATER_MAGNET_BOARD,
                                           ETM_CAN_ADDR_ION_PUMP_BOARD}

        btn_select = sender
        index = btn_select.Tag
        For i = 0 To (dispButtons.Length - 1)
            dispButtons(i).ShowBoardSelected = False
            If (i <= index) Then
                dispButtons(i).Location = New Point(0, DISP_BUTTON_HEIGHT * i)
                If (i < index) Then
                    dispButtons(i).Size = normal_size
                Else
                    dispButtons(i).Size = select_size
                    dispButtons(i).ShowBoardSelected = True
                End If
            Else ' tag > index
                dispButtons(i).Location = New Point(0, DISP_BUTTON_HEIGHT * (i - index - 1) + dispButtons(index).Location.Y + dispButtons(index).Size.Height)
                dispButtons(i).Size = normal_size
            End If
            If (i > 0 And i <= 9) Then
                dispLeds(i - 1).Location = New Point(226, dispButtons(i).Location.Y + (dispButtons(i).Height - 20) / 2)
            End If

        Next


        If (btn_select.Tag < dispButtons.Length) Then
            TabBoards.SelectedIndex = btn_select.Tag
            If (btn_select.Tag <= 9) Then
                board_index = board_indexes(btn_select.Tag)
                EEProm_index = (command_indexes(btn_select.Tag) << 12) + &H100
            Else
                board_index = 0
                EEProm_index = 0
            End If
        End If

        TabBoards.Location = New Point(TAB_LOCATION_X_SMALL, TAB_LOCATION_Y)
        TabBoards.Size = New Size(TAB_SIZE_WIDTH_SMALL, TAB_SIZE_HEIGHT)







    End Sub






    Private Sub btnReenableAutofill_Click(sender As Object, e As EventArgs) Handles btnReenableAutofill1.Click, btnReenableAutofill2.Click
        ServerSettings.put_modbus_commands(REGISTER_CMD_COOLANT_INTERFACE_ALLOW_25_MORE_SF6_PULSES, 0, 0, 0)
    End Sub

    Private Sub btnResetFault_Click(sender As Object, e As EventArgs) Handles btnResetFault.Click
        ServerSettings.put_modbus_commands(REGISTER_CMD_ECB_RESET_FAULTS, 0, 0, 0)
    End Sub

    Private Sub btnChangeSettingMode_Click(sender As Object, e As EventArgs) Handles btnChangeSettingMode.Click
        show_cargo_settings = Not show_cargo_settings
    End Sub

    Private Sub btnGdEkset_Click(sender As Object, e As EventArgs) Handles btnGdEkset.Click
        Dim input_data As Double
        Dim data_valid = get_set_data("Set Ek", "Gun Driver", -20, -6, "kV", input_data)

        If data_valid Then
            Dim program_word As UInt16 = input_data * -1000
            ServerSettings.put_modbus_commands(REGISTER_GUN_DRIVER_CATHODE_VOLTAGE, program_word, 0, 0)
        End If

    End Sub

    Function get_set_data(ByVal prompt As String, ByVal title As String, ByVal min As Double, ByVal max As Double, ByVal unit As String, ByRef data As Double) As Boolean
        ' return true if got valid data
        Dim strvalue As String
        Dim prompt_range As String

        If (max < 0 And min < 0) Then
            prompt_range = prompt & " ( " & max & " " & unit & "  to  " & min & " " & unit & " )"
        Else
            prompt_range = prompt & " ( " & min & " " & unit & "  to  " & max & " " & unit & " )"
        End If
        strvalue = InputBox(prompt_range, title)
        Dim dval As Double

        get_set_data = False
        Try
            If (strvalue <> "") Then
                dval = CDbl(strvalue)
                If (dval > max Or dval < min) Then
                    MsgBox("Input data is out of range, data discarded", MsgBoxStyle.Exclamation)
                Else
                    data = dval
                    get_set_data = True
                End If
            End If
        Catch
            MsgBox("Invalid input, data discarded", MsgBoxStyle.Exclamation)
        End Try

    End Function
    Private Sub btnGdEgsetCargo_Click(sender As Object, e As EventArgs) Handles btnGdEgsetCargo.Click
        Dim input_data As Double
        Dim data_valid = get_set_data("Set Eg for Cargo Mode", "Gun Driver", -80, 140, "V", input_data)

        If data_valid Then
            Dim program_word As UInt16 = (input_data + 80) * 100
            ServerSettings.put_modbus_commands(REGISTER_GUN_DRIVER_HIGH_ENERGY_PULSE_TOP_VOLTAGE, program_word, 0, 0)
        End If
    End Sub

    Private Sub btnGdEgsetCab_Click(sender As Object, e As EventArgs) Handles btnGdEgsetCab.Click
        Dim input_data As Double
        Dim data_valid = get_set_data("Set Eg for Cab Mode", "Gun Driver", -80, 140, "V", input_data)

        If data_valid Then
            Dim program_word As UInt16 = (input_data + 80) * 100
            ServerSettings.put_modbus_commands(REGISTER_GUN_DRIVER_LOW_ENERGY_PULSE_TOP_VOLTAGE, program_word, 0, 0)
        End If

    End Sub

    Private Sub btnGdIfSet_Click(sender As Object, e As EventArgs) Handles btnGdIfSet.Click
        Dim input_data As Double
        Dim data_valid = get_set_data("Set If", "Gun Driver", 0, 1.6, "A", input_data)

        If data_valid Then
            Dim program_word As UInt16 = input_data * 1000
            ServerSettings.put_modbus_commands(REGISTER_GUN_DRIVER_HEATER_VOLTAGE, program_word, 0, 0)
        End If

    End Sub

    Private Sub btnCoolNewSF6bottle_Click(sender As Object, e As EventArgs) Handles btnCoolNewSF6bottle.Click
        Dim response As MsgBoxResult = MsgBox("Set New Bottle?", MsgBoxStyle.OkCancel)

        If (response = MsgBoxResult.Ok) Then
            ServerSettings.put_modbus_commands(REGISTER_CMD_COOLANT_INTERFACE_SET_SF6_PULSES_IN_BOTTLE, 0, 0, 0)
        End If
#If False Then
        Dim input_data As Double
        Dim data_valid = get_set_data("Set Bottle Pulses", "Cooling and SF6", 0, 1000, "", input_data)

        If data_valid Then
            Dim program_word As UInt16 = input_data
            ServerSettings.put_modbus_commands(REGISTER_CMD_COOLANT_INTERFACE_SET_SF6_PULSES_IN_BOTTLE, program_word, 0, 0)
        End If
#End If
    End Sub

    Private Sub btnCoolSF6Override_Click(sender As Object, e As EventArgs) Handles btnCoolSF6Override.Click
        Dim response As MsgBoxResult = MsgBox("Set Override Pulses?", MsgBoxStyle.OkCancel)

        If (response = MsgBoxResult.Ok) Then
            ServerSettings.put_modbus_commands(REGISTER_CMD_COOLANT_INTERFACE_ALLOW_SF6_PULSES_WHEN_PRESSURE_BELOW_LIMIT, 5, 0, 0)
        End If

#If False Then
        Dim input_data As Double
        Dim data_valid = get_set_data("Set Override Pulses", "Cooling and SF6", 0, 5, "", input_data)

        If data_valid Then
            Dim program_word As UInt16 = input_data
            ServerSettings.put_modbus_commands(REGISTER_CMD_COOLANT_INTERFACE_ALLOW_SF6_PULSES_WHEN_PRESSURE_BELOW_LIMIT, program_word, 0, 0)
        End If
#End If
    End Sub

    Private Sub btnPulseSettings_Click(sender As Object, e As EventArgs) Handles btnPulseStartMax.Click, btnPulseStopMin.Click, btnPulseStopMax.Click, btnPulseStop2_3.Click, btnPulseStop1_3.Click, btnPulseStartMin.Click, btnPulseStart2_3.Click, btnPulseStart1_3.Click, btnPulseSampleDelay.Click, btnPfnDelay.Click, btnAfcDelay.Click
        Dim btn As Button = CType(sender, Button)
        Dim program_word As UInt16
        Dim data_offset As UInt16 = IIf(show_cargo_settings, 0, 8)
        Dim command_offset As UInt16 = IIf(show_cargo_settings, 0, 8)
        Dim input_data As Double
        Dim data_valid As Boolean
        Dim title As String = IIf(show_cargo_settings, "Cargo Mode Settings", "Cab Mode Settings")

        Select Case btn.Tag
            Case 0 To 1 ' start	max
                data_valid = get_set_data(IIf(btn.Tag = 0, "Set Beam Max Start", "Set Beam 2/3 Start"), title, 0, 255 * 20, "ns", input_data)

                If data_valid Then
                    input_data = input_data / 20
                    program_word = ServerSettings.ETMEthernetBoardLoggingData(MODBUS_COMMANDS.MODBUS_WR_PULSE_SYNC).ecb_local_data(data_offset)
                    If (btn.Tag = 0) Then
                        program_word = program_word And &HFF00
                        program_word = program_word Or (input_data And &HFF)
                    Else
                        program_word = program_word And &HFF
                        program_word = program_word Or ((input_data << 8) And &HFF00)
                    End If
                    ServerSettings.put_modbus_commands(REGISTER_PULSE_SYNC_GRID_PULSE_DELAY_HIGH_ENERGY_A_B + command_offset, program_word, 0, 0)
                End If

            Case 2 To 3 ' start min
                data_valid = get_set_data(IIf(btn.Tag = 2, "Set Beam 1/3 Start", "Set Beam Min Start"), title, 0, 255 * 20, "ns", input_data)

                If data_valid Then
                    input_data = input_data / 20
                    program_word = ServerSettings.ETMEthernetBoardLoggingData(MODBUS_COMMANDS.MODBUS_WR_PULSE_SYNC).ecb_local_data(data_offset + 1)
                    If (btn.Tag = 2) Then
                        program_word = program_word And &HFF00
                        program_word = program_word Or (input_data And &HFF)
                    Else
                        program_word = program_word And &HFF
                        program_word = program_word Or ((input_data << 8) And &HFF00)
                    End If
                    ServerSettings.put_modbus_commands(REGISTER_PULSE_SYNC_GRID_PULSE_DELAY_HIGH_ENERGY_C_D + command_offset, program_word, 0, 0)
                End If

            Case 4 To 5 ' stop max
                data_valid = get_set_data(IIf(btn.Tag = 0, "Set Beam Max Stop", "Set Beam 2/3 Stop"), title, 0, 255 * 20, "ns", input_data)

                If data_valid Then
                    input_data = input_data / 20
                    program_word = ServerSettings.ETMEthernetBoardLoggingData(MODBUS_COMMANDS.MODBUS_WR_PULSE_SYNC).ecb_local_data(data_offset + 4)
                    If (btn.Tag = 4) Then
                        program_word = program_word And &HFF00
                        program_word = program_word Or (input_data And &HFF)
                    Else
                        program_word = program_word And &HFF
                        program_word = program_word Or ((input_data << 8) And &HFF00)
                    End If
                    ServerSettings.put_modbus_commands(REGISTER_PULSE_SYNC_GRID_PULSE_WIDTH_HIGH_ENERGY_A_B + command_offset, program_word, 0, 0)
                End If
            Case 6 To 7 ' stop min
                data_valid = get_set_data(IIf(btn.Tag = 6, "Set Beam 1/3 Stop", "Set Beam Min Stop"), title, 0, 255 * 20, "ns", input_data)

                If data_valid Then
                    input_data = input_data / 20
                    program_word = ServerSettings.ETMEthernetBoardLoggingData(MODBUS_COMMANDS.MODBUS_WR_PULSE_SYNC).ecb_local_data(data_offset + 5)
                    If (btn.Tag = 6) Then
                        program_word = program_word And &HFF00
                        program_word = program_word Or (input_data And &HFF)
                    Else
                        program_word = program_word And &HFF
                        program_word = program_word Or ((input_data << 8) And &HFF00)
                    End If
                    ServerSettings.put_modbus_commands(REGISTER_PULSE_SYNC_GRID_PULSE_WIDTH_HIGH_ENERGY_C_D + command_offset, program_word, 0, 0)
                End If
            Case 8 ' pfn delay
                data_valid = get_set_data("Set PFN Delay", title, 0, 255 * 20, "ns", input_data)

                If data_valid Then
                    input_data = input_data / 20
                    program_word = ServerSettings.ETMEthernetBoardLoggingData(MODBUS_COMMANDS.MODBUS_WR_PULSE_SYNC).ecb_local_data(data_offset + 2)
                    program_word = program_word And &HFF
                    program_word = program_word Or ((input_data << 8) And &HFF00)
                    ServerSettings.put_modbus_commands(REGISTER_PULSE_SYNC_RF_TRIGGER_AND_THYRATRON_PULSE_DELAY_HIGH_ENERGY + command_offset, program_word, 0, 0)
                End If

            Case 9 ' afc delay
                data_valid = get_set_data("Set AFC Delay", title, 0, 255 * 20, "ns", input_data)

                If data_valid Then
                    input_data = input_data / 20
                    program_word = ServerSettings.ETMEthernetBoardLoggingData(MODBUS_COMMANDS.MODBUS_WR_PULSE_SYNC).ecb_local_data(data_offset + 6)
                    program_word = program_word And &HFF
                    program_word = program_word Or ((input_data << 8) And &HFF00)
                    ServerSettings.put_modbus_commands(REGISTER_PULSE_SYNC_AFC_AND_SPARE_PULSE_DELAY_HIGH_ENERGY + command_offset, program_word, 0, 0)
                End If
            Case 10 ' Mag I sample delay
                data_valid = get_set_data("MagI Sample Delay", title, 0, 255 * 20, "ns", input_data)

                If data_valid Then
                    input_data = input_data / 20
                    program_word = ServerSettings.ETMEthernetBoardLoggingData(MODBUS_COMMANDS.MODBUS_WR_PULSE_SYNC).ecb_local_data(data_offset + 6)
                    program_word = program_word And &HFF00
                    program_word = program_word Or (input_data And &HFF)
                    ServerSettings.put_modbus_commands(REGISTER_PULSE_SYNC_AFC_AND_SPARE_PULSE_DELAY_HIGH_ENERGY + command_offset, program_word, 0, 0)
                End If


        End Select


    End Sub

    Private Sub btnHVsetCargo_Click(sender As Object, e As EventArgs) Handles btnHVsetCargo.Click
        Dim input_data As Double
        Dim data_valid = get_set_data("Set Voltage for Cargo Mode", "HV Power Supply", 6, 17, "kV", input_data)

        If data_valid Then
            Dim program_word As UInt16 = input_data * 1000
            ServerSettings.put_modbus_commands(REGISTER_HIGH_ENERGY_SET_POINT, program_word, 0, 0)
        End If

    End Sub

    Private Sub btnHVsetCab_Click(sender As Object, e As EventArgs) Handles btnHVsetCab.Click
        Dim input_data As Double
        Dim data_valid = get_set_data("Set Voltage for Cab Mode", "HV Power Supply", 6, 17, "kV", input_data)

        If data_valid Then
            Dim program_word As UInt16 = input_data * 1000
            ServerSettings.put_modbus_commands(REGISTER_LOW_ENERGY_SET_POINT, program_word, 0, 0)
        End If

    End Sub

    Private Sub btnAfcHomePosSet_Click(sender As Object, e As EventArgs) Handles btnAfcHomePosSet.Click
        Dim input_data As Double
        Dim data_valid = get_set_data("Set Home Position", "AFC", 6400, 51200, "", input_data)

        If data_valid Then
            Dim program_word As UInt16 = input_data
            ServerSettings.put_modbus_commands(REGISTER_HOME_POSITION, program_word, 0, 0)
        End If

    End Sub

    Private Sub btnAfcCargoCtrlVSet_Click(sender As Object, e As EventArgs) Handles btnAfcCargoCtrlVSet.Click
        Dim input_data As Double
        Dim data_valid = get_set_data("Set Control Voltage for Cargo Mode", "AFC", 1, 10, "V", input_data)

        If data_valid Then
            Dim program_word As UInt16 = input_data * 1000
            ServerSettings.put_modbus_commands(REGISTER_AFC_AFT_CONTROL_VOLTAGE_HIGH_ENERGY, program_word, 0, 0)
        End If

    End Sub

    Private Sub btnAfcCabCtrlVSet_Click(sender As Object, e As EventArgs) Handles btnAfcCabCtrlVSet.Click
        Dim input_data As Double
        Dim data_valid = get_set_data("Set Control Voltage for Cab Mode", "AFC", 1, 10, "V", input_data)

        If data_valid Then
            Dim program_word As UInt16 = input_data * 1000
            ServerSettings.put_modbus_commands(REGISTER_AFC_AFT_CONTROL_VOLTAGE_LOW_ENERGY, program_word, 0, 0)
        End If

    End Sub

    Private Sub btnAfcManualMode_Click(sender As Object, e As EventArgs) Handles btnAfcManualMode.Click
        If (ServerSettings.ETMEthernetBoardLoggingData(MODBUS_COMMANDS.MODBUS_WR_AFC).logged_bits And &H1) > 0 Then
            ServerSettings.put_modbus_commands(REGISTER_CMD_AFC_SELECT_AFC_MODE, 0, 0, 0)
        Else
            ServerSettings.put_modbus_commands(REGISTER_CMD_AFC_SELECT_MANUAL_MODE, 0, 0, 0)
        End If

    End Sub

    Private Sub btnAfcManualPosition_Click(sender As Object, e As EventArgs) Handles btnAfcManualPosition.Click
        Dim input_data As Double
        Dim data_valid = get_set_data("Set Manual Position", "AFC", 0, 64000, "", input_data)

        If data_valid Then
            Dim program_word As UInt16 = input_data
            ServerSettings.put_modbus_commands(REGISTER_CMD_AFC_MANUAL_TARGET_POSITION, program_word, 0, 0)
        End If

    End Sub

    Private Sub btnMagCargoIset_Click(sender As Object, e As EventArgs) Handles btnMagCargoIset.Click
        Dim input_data As Double
        Dim data_valid = get_set_data("Set Magnet Current for Cargo Mode", "Magnet and Heater", 8, 21, "A", input_data)

        If data_valid Then
            Dim program_word As UInt16 = input_data * 1000
            ServerSettings.put_modbus_commands(REGISTER_ELECTROMAGNET_CURRENT_HIGH_ENERGY, program_word, 0, 0)
        End If

    End Sub

    Private Sub btnMagCabIset_Click(sender As Object, e As EventArgs) Handles btnMagCabIset.Click
        Dim input_data As Double
        Dim data_valid = get_set_data("Set Magnet Current for Cab Mode", "Magnet and Heater", 8, 21, "A", input_data)

        If data_valid Then
            Dim program_word As UInt16 = input_data * 1000
            ServerSettings.put_modbus_commands(REGISTER_ELECTROMAGNET_CURRENT_LOW_ENERGY, program_word, 0, 0)
        End If


    End Sub

    Private Sub btnMagIfSet_Click(sender As Object, e As EventArgs) Handles btnMagIfSet.Click
        Dim input_data As Double
        Dim data_valid = get_set_data("Set Heater Current", "Magnet and Heater", 0, 10, "A", input_data)

        If data_valid Then
            Dim program_word As UInt16 = input_data * 1000
            ServerSettings.put_modbus_commands(REGISTER_HEATER_CURRENT_AT_STANDBY, program_word, 0, 0)
        End If

    End Sub

    Private Sub btnServiceRestoreFactoryDefaults_Click(sender As Object, e As EventArgs) Handles btnServiceRestoreFactoryDefaults.Click
        Dim response As MsgBoxResult = MsgBox("Restore Factory Default Settings?", MsgBoxStyle.OkCancel)

        If (response = MsgBoxResult.Ok) Then
            ServerSettings.put_modbus_commands(REGISTER_SYSTEM_ECB_LOAD_FACTORY_SETTINGS_FROM_EEPROM_MIRROR_AND_REBOOT, 0, 0, 0)
        End If

    End Sub

    Private Sub btnServiceStartLog_Click(sender As Object, e As EventArgs) Handles btnServiceStartLog.Click
        Dim filename As String, length As Byte = 50
        If (btnServiceStartLog.Text = "Start Pulse Logging") Then
            ServerSettings.put_modbus_commands(REGISTER_SYSTEM_ENABLE_HIGH_SPEED_LOGGING, 0, 0, 0)
            ServerSettings.OpenPulseLogFile()
            filename = ServerSettings.pulse_log_file_path
#If True Then
            ToolTip1.SetToolTip(lblLogFileName, filename)
            If (Len(filename) > length) Then
                filename = filename.Substring(Len(filename) - length, length)
                Dim pos As Byte = InStr(filename, "\")
                If (pos > 0) Then
                    filename = "..." & filename.Substring(pos - 1, Len(filename) - pos + 1)
                End If
            End If
#End If

            lblLogFileName.Text = "Log File Name: " & filename
            btnServiceStartLog.Text = "Stop Pulse Logging"
            pulse_log_enabled = True
        Else
            pulse_log_enabled = False
            ServerSettings.ClosePulseLogFile()
            ServerSettings.put_modbus_commands(REGISTER_SYSTEM_DISABLE_HIGH_SPEED_LOGGING, 0, 0, 0)
            btnServiceStartLog.Text = "Start Pulse Logging"
            '  lblLogFileName.Text = "Log File Name: "
            '   ToolTip1.SetToolTip(lblLogFileName, "")

        End If
    End Sub

    Private Sub reset_access_level()
        access_level = 0 ' logout
        lblIonIi2Title.Visible = False
        lblIonIi2.Visible = False
        lblIonIi2Unit.Visible = False
        BlueRectMain.Location = New Point(28, 410)  'New Point(28, 398)
        btnDispServicePanel.Visible = False
        btnDispDeveloperPanel.Visible = False
        LabelAgileInfo.Visible = False
        LabelFirmwareVerssion.Visible = False

        lblDoseRate.Visible = False
        lblDoseRateTitle.Visible = False
        lblDoseRateUnit.Visible = False

        PanelArcCounts.Visible = False
        BlueRectMagnetron.Height = 180 '168
        PanelMagnetronLeds.Location = New Point(PanelMagnetronLeds.Location.X, 280)


        panelIonPumpLogger.Visible = False
        ion_pump_log_enabled = False
        btnIonPumpLog.Text = "Start Ion Pump Logging"

        For i = 1 To 9
            dispLeds(i - 1).Visible = False
        Next

    End Sub
    Private Sub btnServiceModeChange_Click(sender As Object, e As EventArgs) Handles btnServiceModeChange.Click
        If (access_level > 0) Then
            reset_access_level()
        Else
            pwScreen.ShowDialog()
            access_level = pwScreen.access_level
            If (access_level > 0) Then
                lblIonIi2Title.Visible = True
                lblIonIi2.Visible = True
                lblIonIi2Unit.Visible = True
                BlueRectMain.Location = New Point(28, 410)
                btnDispServicePanel.Visible = True
                btnDispDeveloperPanel.Visible = IIf(access_level > 1, True, False)

                LabelAgileInfo.Visible = True
                LabelFirmwareVerssion.Visible = True
                PanelArcCounts.Visible = True
                BlueRectMagnetron.Height = 258
                PanelMagnetronLeds.Location = New Point(PanelMagnetronLeds.Location.X, 374)

                For i = 1 To 9
                    dispLeds(i - 1).Visible = True
                Next

                If (access_level > 1) Then
                    lblDoseRate.Visible = True
                    lblDoseRateTitle.Visible = True
                    lblDoseRateUnit.Visible = True

                    panelIonPumpLogger.Visible = True
                End If
            End If
        End If


    End Sub



    Private Sub btnServiceResetLinacTime_Click(sender As Object, e As EventArgs) Handles btnServiceResetLinacTime.Click
        Dim response As MsgBoxResult = MsgBox("Reset Linac Time?", MsgBoxStyle.OkCancel)

        If (response = MsgBoxResult.Ok) Then
            Call ButtonSetTime_Click(sender, e)
        End If
    End Sub

    Private Sub btnServiceSaveFactoryDefaults_Click(sender As Object, e As EventArgs) Handles btnServiceSaveFactoryDefaults.Click
        Dim response As MsgBoxResult = MsgBox("Save Factory Default Settings?", MsgBoxStyle.OkCancel)

        If (response = MsgBoxResult.Ok) Then
            ServerSettings.put_modbus_commands(REGISTER_ETM_ECB_SAVE_FACTORY_SETTINGS_TO_EEPROM_MIRROR, 0, 0, 0)
        End If

    End Sub

    Private Sub btnServiceReloadInitialDefaults_Click(sender As Object, e As EventArgs) Handles btnServiceReloadInitialDefaults.Click

        Dim response As MsgBoxResult = MsgBox("Reload Initialization Settings?", MsgBoxStyle.OkCancel)

        If (response = MsgBoxResult.Ok) Then
            ServerSettings.put_modbus_commands(REGISTER_ETM_ECB_LOAD_DEFAULT_SYSTEM_SETTINGS_AND_REBOOT, 0, 0, 0)
        End If

    End Sub

    Private Sub lblSN_Click(sender As Object, e As EventArgs) Handles lblSN.Click
        If (access_level > 1) Then
            Dim input_data As Double
            Dim data_valid = get_set_data("Set System Serial Number", lblSystem.Text, 1, 65535, "", input_data)

            If data_valid Then
                Dim serial_num As UInt16 = input_data
                ServerSettings.put_modbus_commands(REGISTER_ECB_SYSTEM_SERIAL_NUMBER, serial_num, serial_num, serial_num)
            End If
        End If
    End Sub
    Function get_set_rev(ByVal prompt As String, ByVal title As String, ByRef data As Double) As Boolean
        ' return true if got valid data
        Dim strvalue As String

        strvalue = InputBox(prompt, title)

        get_set_rev = False
        Try
            If (strvalue <> "") Then
                Select Case strvalue.Length
                    Case 1
                        data = Asc(strvalue(0))
                        get_set_rev = True
                    Case 2
                        data = (Asc(strvalue(0)) << 8) + Asc(strvalue(1))
                        get_set_rev = True
                    Case Else
                        MsgBox("The maximum revision length is 2", MsgBoxStyle.Exclamation)
                End Select

            End If
        Catch
            MsgBox("Invalid input, data discarded", MsgBoxStyle.Exclamation)
        End Try

    End Function
    Private Sub LabelAgileInfo_Click(sender As Object, e As EventArgs) Handles LabelAgileInfo.Click
        Dim serial_num As UInt16, rev_num As UInt16
        Dim data_valid As Boolean
        Dim input_data As Double
        Dim buttons() As CustomControls.ButtonSelected = {btnDispOverview, btnDispSysCPU, btnDispGunDriver, btnDispCoolSF6, btnDispPulseSync, btnDispHV,
                                                          btnDispMagnetron, btnDispAFC, btnDispMagHtr, btnDispIonPump}

        If (access_level > 1) Then
            data_valid = get_set_data("Input Serial Number", buttons(TabBoards.SelectedIndex).Text, 1, 65535, "", input_data)
            If data_valid Then
                serial_num = input_data
                data_valid = get_set_rev("Input Revision Number", buttons(TabBoards.SelectedIndex).Text, input_data)
                If data_valid Then
                    rev_num = input_data
                    '      ServerSettings.put_modbus_commands(index, 0, rev, serial_num)
                    Dim index As UInt16 = (EEProm_index And &HFF00) + &H80
                    ServerSettings.put_modbus_commands(index, 0, rev_num, serial_num)
                End If
            End If
        End If

    End Sub




    Private Sub btnIPaddress_Click(sender As Object, e As EventArgs) Handles btnIPaddress.Click
        Dim IPAddr As String = InputBox("Input IP Address", lblSystem.Text, ServerSettings.txtIPAddr.Text)
        If (IPAddr <> "") Then
            If (ServerSettings.isValidIPaddress(IPAddr)) Then
                ServerSettings.changeIPaddress(IPAddr)
            Else
                MsgBox("Invalid IP Address")
            End If

        End If
    End Sub

    Private Sub btnZeroOnTime_Click(sender As Object, e As EventArgs) Handles btnZeroOnTime.Click
        ServerSettings.put_modbus_commands(REGISTER_ETM_ECB_RESET_SECONDS_POWERED_HV_ON_XRAY_ON, 0, 0, 0)
    End Sub

    Private Sub btnZeroPulseCounters_Click(sender As Object, e As EventArgs) Handles btnZeroArcPulseCounters.Click
        ServerSettings.put_modbus_commands(REGISTER_ETM_ECB_RESET_ARC_AND_PULSE_COUNT, 0, 0, 0)
    End Sub



    Private Sub btnClearDebugData_Click(sender As Object, e As EventArgs) Handles btnClearDebugData.Click
        ServerSettings.put_modbus_commands(REGISTER_DEBUG_TOGGLE_RESET_DEBUG, 0, 0, 0)
    End Sub

#Region "Ion Pump Logging Related"
    Private Sub createIonPumpLogFilename()
        Dim file_path As String = System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
        Dim log_path As String = Path.Combine(file_path, Constants.DIR_LOG & "\" & Constants.DIR_IONPUMP)

        If (Directory.Exists(log_path) = False) Then
            Directory.CreateDirectory(log_path)
        End If
        ion_pump_log_file_name = Path.Combine(log_path, "H" & ServerSettings.ETMEthernetBoardLoggingData(MODBUS_COMMANDS.MODBUS_WR_ETHERNET).log_data(19).ToString("0000") & "_IonPumpLog_" + DateTime.UtcNow.ToString("yyyy_MM_dd_HH_mm") + ".csv")
    End Sub

    Private Sub logIonPump(item As String)
        Dim line As String = DateTime.UtcNow.ToString("yyyy/MM/dd,HH:mm:ss") + "," + item
        Dim sw As StreamWriter

        Try
            sw = File.AppendText(ion_pump_log_file_name)
            sw.WriteLine(line)
            sw.Close()
        Catch
            ' create a new file
            Try
                createIonPumpLogFilename()
                sw = File.AppendText(ion_pump_log_file_name)
                sw.WriteLine(line)
                sw.Close()
            Catch
                MessageBox.Show("Can't write to file " + ion_pump_log_file_name, "Ion Pump Data Logging", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Finally
            End Try
        End Try

    End Sub
    Private Sub btnIonPumpLog_Click(sender As Object, e As EventArgs) Handles btnIonPumpLog.Click
        Dim filename As String, length As Byte = 50
        If (btnIonPumpLog.Text.Contains("Start Ion Pump")) Then
            createIonPumpLogFilename()
            logIonPump("Ei, Ii")
#If True Then
            ToolTip1.SetToolTip(lblIonPumpLogName, ion_pump_log_file_name)
            If (Len(ion_pump_log_file_name) > length) Then
                filename = ion_pump_log_file_name.Substring(Len(ion_pump_log_file_name) - length, length)
                Dim pos As Byte = InStr(filename, "\")
                If (pos > 0) Then
                    filename = "..." & filename.Substring(pos - 1, Len(filename) - pos + 1)
                End If
            Else
                filename = ion_pump_log_file_name
            End If
#End If
            lblIonPumpLogName.Text = "Log File Name: " & filename
            btnIonPumpLog.Text = "Stop Ion Pump Logging"
            ion_pump_log_enabled = True
        Else
            ion_pump_log_enabled = False
            btnIonPumpLog.Text = "Start Ion Pump Logging"

        End If

    End Sub



#End Region




    Private Sub btnMagnetronConditioning_Click(sender As Object, e As EventArgs) Handles btnMagnetronConditioning.Click
        Dim response As MsgBoxResult = MsgBox("Do Magnetron Conditioning ?", MsgBoxStyle.OkCancel)

        If (response = MsgBoxResult.Ok) Then
            ServerSettings.put_modbus_commands(REGISTER_SYSTEM_ECB_MAGNETRON_CONDITIONING, 0, 0, 0)
        End If
    End Sub

    Private Sub btnSaveAllParams_Click(sender As Object, e As EventArgs) Handles btnSaveAllParams.Click
        Dim file_path As String = System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
        Dim param_path As String = Path.Combine(file_path, Constants.DIR_LOG & "\" & Constants.DIR_PARAM)
        Dim uValue As UInt16, iCrc As Int16
        Dim strValue As String

        If (Directory.Exists(param_path) = False) Then
            Directory.CreateDirectory(param_path)
        End If


#If True Then
        Dim filename As String = "H" & ServerSettings.ETMEthernetBoardLoggingData(MODBUS_COMMANDS.MODBUS_WR_ETHERNET).log_data(19).ToString("0000") & "_param_" & DateTime.UtcNow.ToString("yyyy_MM_dd_HH_mm_ss") & ".log"

        Dim filepath As String = Path.Combine(param_path, filename)

        Using sw As StreamWriter = New StreamWriter(filepath)
            For i = 0 To (SET_CMDS.LENGTH - 1)
                uValue = get_ref_data(set_commands(i).command_index)
                strValue = set_commands(i).command_index & "," & uValue
                iCrc = c_crc16(strValue, strValue.Length)
                strValue = strValue & "," & iCrc
                sw.WriteLine(strValue)
            Next
        End Using
        MessageBox.Show("Parameters are saved in " & filepath & ".")


#Else
        Directory.SetCurrentDirectory(param_path)
        Dim saveFileDialog1 As New SaveFileDialog()

        saveFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*"
        saveFileDialog1.FilterIndex = 2
        saveFileDialog1.RestoreDirectory = True
        saveFileDialog1.Title = "Select file to save parameters"

        If saveFileDialog1.ShowDialog() = DialogResult.OK Then
            Using sw As StreamWriter = New StreamWriter(saveFileDialog1.FileName)
                For i = 0 To (SET_CMDS.LENGTH - 1)
                    uValue = get_ref_data(set_commands(i).command_index)
                    strValue = set_commands(i).command_index & "," & uValue
                    iCrc = c_crc16(strValue, strValue.Length)
                    strValue = strValue & "," & iCrc
                    sw.WriteLine(strValue)
                Next
            End Using
            MessageBox.Show("Parameters are saved in " & saveFileDialog1.FileName & ".")
        End If
#End If
    End Sub

    Private Sub btnLoadParameters_Click(sender As Object, e As EventArgs) Handles btnLoadParameters.Click
        Dim file_path As String = System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
        Dim param_path As String = Path.Combine(file_path, Constants.DIR_LOG & "\" & Constants.DIR_PARAM)
        Dim setValues(SET_CMDS.LENGTH) As UInt16
        Dim uValue As UInt16, iCrc As Int16, iCrcFile As Int16, bValidData As Boolean = True
        Dim split() As String

        Dim response As MsgBoxResult = MsgBox("Save the current parameters first?", MsgBoxStyle.YesNo)

        If (response = MsgBoxResult.Yes) Then
            btnSaveAllParams_Click(sender, e)
        End If

        If (Directory.Exists(param_path) = False) Then
            Directory.CreateDirectory(param_path)
        End If

        Dim openFileDialog1 As New OpenFileDialog()


        '   openFileDialog1.Title 
        openFileDialog1.InitialDirectory = param_path
        openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*"
        openFileDialog1.FilterIndex = 2
        openFileDialog1.RestoreDirectory = True
        openFileDialog1.Title = "Select file to load parameters"

        If openFileDialog1.ShowDialog() = DialogResult.OK Then
            Try
                Using sr As StreamReader = New StreamReader(openFileDialog1.FileName)
                    Dim line As String
                    For i = 0 To (SET_CMDS.LENGTH - 1)
                        line = sr.ReadLine  ' line contains command index, command data, crc
                        split = line.Split(",")
                        line = split(0) & "," & split(1)
                        iCrc = c_crc16(line, line.Length)
                        iCrcFile = Convert.ToInt16(split(2))
                        uValue = Convert.ToUInt16(split(0))
                        If (iCrc = iCrcFile And uValue = set_commands(i).command_index) Then
                            setValues(i) = Convert.ToUInt16(split(1))
                        Else
                            bValidData = False
                            MessageBox.Show("File Corrupted! ")
                            Exit For
                        End If
                    Next
                End Using

            Catch Ex As Exception
                bValidData = False
                MessageBox.Show("File access error! " & Ex.Message)
            Finally
                If (bValidData) Then
                    ' data is valid, send ethernet commands
                    response = MsgBox("File is ok, restore the parameters?", MsgBoxStyle.OkCancel)

                    If (response = MsgBoxResult.Ok) Then
                        For i = 0 To (SET_CMDS.SET_CMD_AFC_SELECT_AFC_MODE - 1)
                            If (setValues(i) <= set_commands(i).max And setValues(i) >= set_commands(i).min) Then
                                ServerSettings.put_modbus_commands(set_commands(i).command_index, setValues(i), 0, 0)
                            End If
                        Next
                        If setValues(SET_CMDS.SET_CMD_AFC_SELECT_MANUAL_MODE) > 0 Then
                            ServerSettings.put_modbus_commands(set_commands(SET_CMDS.SET_CMD_AFC_SELECT_MANUAL_MODE).command_index, 0, 0, 0)
                        Else
                            ServerSettings.put_modbus_commands(set_commands(SET_CMDS.SET_CMD_AFC_SELECT_AFC_MODE).command_index, 0, 0, 0)
                        End If
                        MessageBox.Show("Parameters are restored.")
                    End If
                End If
            End Try
        End If
    End Sub
    Function get_ref_data(index As UInt16) As UInt16
        Dim uRetData As UInt16, offset As UInt16 = 0
        Select Case (index)
            ' gun driver
            Case REGISTER_GUN_DRIVER_CATHODE_VOLTAGE
                uRetData = ServerSettings.ETMEthernetBoardLoggingData(MODBUS_COMMANDS.MODBUS_WR_GUN_DRIVER).log_data(8)
            Case REGISTER_GUN_DRIVER_HEATER_VOLTAGE
                uRetData = ServerSettings.ETMEthernetBoardLoggingData(MODBUS_COMMANDS.MODBUS_WR_GUN_DRIVER).log_data(9)
            Case REGISTER_GUN_DRIVER_HIGH_ENERGY_PULSE_TOP_VOLTAGE
                uRetData = ServerSettings.ETMEthernetBoardLoggingData(MODBUS_COMMANDS.MODBUS_WR_GUN_DRIVER).ecb_local_data(0)
            Case REGISTER_GUN_DRIVER_LOW_ENERGY_PULSE_TOP_VOLTAGE
                uRetData = ServerSettings.ETMEthernetBoardLoggingData(MODBUS_COMMANDS.MODBUS_WR_GUN_DRIVER).ecb_local_data(1)
                ' pulse sync
            Case REGISTER_PULSE_SYNC_GRID_PULSE_DELAY_HIGH_ENERGY_A_B, REGISTER_PULSE_SYNC_GRID_PULSE_DELAY_LOW_ENERGY_A_B
                offset = IIf(index = REGISTER_PULSE_SYNC_GRID_PULSE_DELAY_HIGH_ENERGY_A_B, 0, 8)
                uRetData = ServerSettings.ETMEthernetBoardLoggingData(MODBUS_COMMANDS.MODBUS_WR_PULSE_SYNC).ecb_local_data(offset)
            Case REGISTER_PULSE_SYNC_GRID_PULSE_DELAY_HIGH_ENERGY_C_D, REGISTER_PULSE_SYNC_GRID_PULSE_DELAY_LOW_ENERGY_C_D
                offset = IIf(index = REGISTER_PULSE_SYNC_GRID_PULSE_DELAY_HIGH_ENERGY_C_D, 0, 8)
                uRetData = ServerSettings.ETMEthernetBoardLoggingData(MODBUS_COMMANDS.MODBUS_WR_PULSE_SYNC).ecb_local_data(offset + 1)
            Case REGISTER_PULSE_SYNC_GRID_PULSE_WIDTH_HIGH_ENERGY_A_B, REGISTER_PULSE_SYNC_GRID_PULSE_WIDTH_LOW_ENERGY_A_B
                offset = IIf(index = REGISTER_PULSE_SYNC_GRID_PULSE_WIDTH_HIGH_ENERGY_A_B, 0, 8)
                uRetData = ServerSettings.ETMEthernetBoardLoggingData(MODBUS_COMMANDS.MODBUS_WR_PULSE_SYNC).ecb_local_data(offset + 4)
            Case REGISTER_PULSE_SYNC_GRID_PULSE_WIDTH_HIGH_ENERGY_C_D, REGISTER_PULSE_SYNC_GRID_PULSE_WIDTH_LOW_ENERGY_C_D
                offset = IIf(index = REGISTER_PULSE_SYNC_GRID_PULSE_WIDTH_HIGH_ENERGY_C_D, 0, 8)
                uRetData = ServerSettings.ETMEthernetBoardLoggingData(MODBUS_COMMANDS.MODBUS_WR_PULSE_SYNC).ecb_local_data(offset + 5)
            Case REGISTER_PULSE_SYNC_RF_TRIGGER_AND_THYRATRON_PULSE_DELAY_HIGH_ENERGY, REGISTER_PULSE_SYNC_RF_TRIGGER_AND_THYRATRON_PULSE_DELAY_LOW_ENERGY
                offset = IIf(index = REGISTER_PULSE_SYNC_RF_TRIGGER_AND_THYRATRON_PULSE_DELAY_HIGH_ENERGY, 0, 8)
                uRetData = ServerSettings.ETMEthernetBoardLoggingData(MODBUS_COMMANDS.MODBUS_WR_PULSE_SYNC).ecb_local_data(offset + 2)
            Case REGISTER_PULSE_SYNC_AFC_AND_SPARE_PULSE_DELAY_HIGH_ENERGY, REGISTER_PULSE_SYNC_AFC_AND_SPARE_PULSE_DELAY_LOW_ENERGY
                offset = IIf(index = REGISTER_PULSE_SYNC_AFC_AND_SPARE_PULSE_DELAY_HIGH_ENERGY, 0, 8)
                uRetData = ServerSettings.ETMEthernetBoardLoggingData(MODBUS_COMMANDS.MODBUS_WR_PULSE_SYNC).ecb_local_data(offset + 6)

                ' hv 
            Case REGISTER_HIGH_ENERGY_SET_POINT
                uRetData = ServerSettings.ETMEthernetBoardLoggingData(MODBUS_COMMANDS.MODBUS_WR_HVLAMBDA).log_data(2)
            Case REGISTER_LOW_ENERGY_SET_POINT
                uRetData = ServerSettings.ETMEthernetBoardLoggingData(MODBUS_COMMANDS.MODBUS_WR_HVLAMBDA).log_data(1)

                ' afc
            Case REGISTER_HOME_POSITION
                uRetData = ServerSettings.ETMEthernetBoardLoggingData(MODBUS_COMMANDS.MODBUS_WR_AFC).ecb_local_data(0)
            Case REGISTER_AFC_AFT_CONTROL_VOLTAGE_HIGH_ENERGY
                uRetData = ServerSettings.ETMEthernetBoardLoggingData(MODBUS_COMMANDS.MODBUS_WR_AFC).ecb_local_data(1)
            Case REGISTER_AFC_AFT_CONTROL_VOLTAGE_LOW_ENERGY
                uRetData = ServerSettings.ETMEthernetBoardLoggingData(MODBUS_COMMANDS.MODBUS_WR_AFC).ecb_local_data(2)
            Case REGISTER_CMD_AFC_SELECT_AFC_MODE
                uRetData = IIF((ServerSettings.ETMEthernetBoardLoggingData(MODBUS_COMMANDS.MODBUS_WR_AFC).logged_bits And &H1) > 0, 0, 1)
            Case REGISTER_CMD_AFC_SELECT_MANUAL_MODE
                uRetData = (ServerSettings.ETMEthernetBoardLoggingData(MODBUS_COMMANDS.MODBUS_WR_AFC).logged_bits And &H1)
            Case REGISTER_CMD_AFC_MANUAL_TARGET_POSITION
                uRetData = ServerSettings.ETMEthernetBoardLoggingData(MODBUS_COMMANDS.MODBUS_WR_AFC).log_data(2)

                ' magnet and heater
            Case REGISTER_ELECTROMAGNET_CURRENT_HIGH_ENERGY
                uRetData = ServerSettings.ETMEthernetBoardLoggingData(MODBUS_COMMANDS.MODBUS_WR_HTR_MAGNET).ecb_local_data(2)
            Case REGISTER_ELECTROMAGNET_CURRENT_LOW_ENERGY
                uRetData = ServerSettings.ETMEthernetBoardLoggingData(MODBUS_COMMANDS.MODBUS_WR_HTR_MAGNET).ecb_local_data(3)
            Case REGISTER_HEATER_CURRENT_AT_STANDBY
                uRetData = ServerSettings.ETMEthernetBoardLoggingData(MODBUS_COMMANDS.MODBUS_WR_HTR_MAGNET).ecb_local_data(0)

            Case Else
                uRetData = 0

        End Select

        get_ref_data = uRetData

    End Function

    Function c_crc16(ByVal outstring As String, ByVal length As Integer) As Int16
        Dim crc As Long
        Dim i, j As Integer
        crc = 0
        For i = 1 To length
            crc = crc Xor (Asc(Mid$(outstring, i, 1)) * 256)
            For j = 0 To 7
                If (crc And 32768) Then
                    crc = (CLng((CDbl(crc) * 2)) And 65535) Xor &H1021
                Else
                    crc = (CLng((CDbl(crc) * 2)) And 65535)
                End If
            Next j
        Next i
        If (crc < 2 ^ 15) Then
            c_crc16 = crc
        Else
            c_crc16 = crc - 2 ^ 16
        End If

    End Function

    Sub init_set_commands()
        set_commands(SET_CMDS.SET_GUN_DRIVER_CATHODE_VOLTAGE) = New SET_COMMAND_STRUCTURE(REGISTER_GUN_DRIVER_CATHODE_VOLTAGE, 20000, 6000)
        set_commands(SET_CMDS.SET_GUN_DRIVER_HEATER_VOLTAGE) = New SET_COMMAND_STRUCTURE(REGISTER_GUN_DRIVER_HEATER_VOLTAGE, 1600, 0)
        set_commands(SET_CMDS.SET_GUN_DRIVER_HIGH_ENERGY_PULSE_TOP_VOLTAGE) = New SET_COMMAND_STRUCTURE(REGISTER_GUN_DRIVER_HIGH_ENERGY_PULSE_TOP_VOLTAGE, 22000, 0)
        set_commands(SET_CMDS.SET_GUN_DRIVER_LOW_ENERGY_PULSE_TOP_VOLTAGE) = New SET_COMMAND_STRUCTURE(REGISTER_GUN_DRIVER_LOW_ENERGY_PULSE_TOP_VOLTAGE, 22000, 0)

        set_commands(SET_CMDS.SET_PULSE_SYNC_GRID_PULSE_DELAY_HIGH_ENERGY_A_B) = New SET_COMMAND_STRUCTURE(REGISTER_PULSE_SYNC_GRID_PULSE_DELAY_HIGH_ENERGY_A_B, 65535, 0)
        set_commands(SET_CMDS.SET_PULSE_SYNC_GRID_PULSE_DELAY_LOW_ENERGY_A_B) = New SET_COMMAND_STRUCTURE(REGISTER_PULSE_SYNC_GRID_PULSE_DELAY_LOW_ENERGY_A_B, 65535, 0)
        set_commands(SET_CMDS.SET_PULSE_SYNC_GRID_PULSE_DELAY_HIGH_ENERGY_C_D) = New SET_COMMAND_STRUCTURE(REGISTER_PULSE_SYNC_GRID_PULSE_DELAY_HIGH_ENERGY_C_D, 65535, 0)
        set_commands(SET_CMDS.SET_PULSE_SYNC_GRID_PULSE_DELAY_LOW_ENERGY_C_D) = New SET_COMMAND_STRUCTURE(REGISTER_PULSE_SYNC_GRID_PULSE_DELAY_LOW_ENERGY_C_D, 65535, 0)
        set_commands(SET_CMDS.SET_PULSE_SYNC_GRID_PULSE_WIDTH_HIGH_ENERGY_A_B) = New SET_COMMAND_STRUCTURE(REGISTER_PULSE_SYNC_GRID_PULSE_WIDTH_HIGH_ENERGY_A_B, 65535, 0)
        set_commands(SET_CMDS.SET_PULSE_SYNC_GRID_PULSE_WIDTH_LOW_ENERGY_A_B) = New SET_COMMAND_STRUCTURE(REGISTER_PULSE_SYNC_GRID_PULSE_WIDTH_LOW_ENERGY_A_B, 65535, 0)
        set_commands(SET_CMDS.SET_PULSE_SYNC_GRID_PULSE_WIDTH_HIGH_ENERGY_C_D) = New SET_COMMAND_STRUCTURE(REGISTER_PULSE_SYNC_GRID_PULSE_WIDTH_HIGH_ENERGY_C_D, 65535, 0)
        set_commands(SET_CMDS.SET_PULSE_SYNC_GRID_PULSE_WIDTH_LOW_ENERGY_C_D) = New SET_COMMAND_STRUCTURE(REGISTER_PULSE_SYNC_GRID_PULSE_WIDTH_LOW_ENERGY_C_D, 65535, 0)
        set_commands(SET_CMDS.SET_PULSE_SYNC_RF_TRIGGER_AND_THYRATRON_PULSE_DELAY_HIGH_ENERGY) = New SET_COMMAND_STRUCTURE(REGISTER_PULSE_SYNC_RF_TRIGGER_AND_THYRATRON_PULSE_DELAY_HIGH_ENERGY, 65535, 0)
        set_commands(SET_CMDS.SET_PULSE_SYNC_RF_TRIGGER_AND_THYRATRON_PULSE_DELAY_LOW_ENERGY) = New SET_COMMAND_STRUCTURE(REGISTER_PULSE_SYNC_RF_TRIGGER_AND_THYRATRON_PULSE_DELAY_LOW_ENERGY, 65535, 0)
        set_commands(SET_CMDS.SET_PULSE_SYNC_AFC_AND_SPARE_PULSE_DELAY_HIGH_ENERGY) = New SET_COMMAND_STRUCTURE(REGISTER_PULSE_SYNC_AFC_AND_SPARE_PULSE_DELAY_HIGH_ENERGY, 65535, 0)
        set_commands(SET_CMDS.SET_PULSE_SYNC_AFC_AND_SPARE_PULSE_DELAY_LOW_ENERGY) = New SET_COMMAND_STRUCTURE(REGISTER_PULSE_SYNC_AFC_AND_SPARE_PULSE_DELAY_LOW_ENERGY, 65535, 0)

        set_commands(SET_CMDS.SET_HIGH_ENERGY_SET_POINT) = New SET_COMMAND_STRUCTURE(REGISTER_HIGH_ENERGY_SET_POINT, 17000, 6000)
        set_commands(SET_CMDS.SET_LOW_ENERGY_SET_POINT) = New SET_COMMAND_STRUCTURE(REGISTER_LOW_ENERGY_SET_POINT, 17000, 6000)

        set_commands(SET_CMDS.SET_HOME_POSITION) = New SET_COMMAND_STRUCTURE(REGISTER_HOME_POSITION, 51200, 6400)
        set_commands(SET_CMDS.SET_AFC_AFT_CONTROL_VOLTAGE_HIGH_ENERGY) = New SET_COMMAND_STRUCTURE(REGISTER_AFC_AFT_CONTROL_VOLTAGE_HIGH_ENERGY, 10000, 1000)
        set_commands(SET_CMDS.SET_AFC_AFT_CONTROL_VOLTAGE_LOW_ENERGY) = New SET_COMMAND_STRUCTURE(REGISTER_AFC_AFT_CONTROL_VOLTAGE_LOW_ENERGY, 10000, 1000)
        set_commands(SET_CMDS.SET_CMD_AFC_SELECT_AFC_MODE) = New SET_COMMAND_STRUCTURE(REGISTER_CMD_AFC_SELECT_AFC_MODE, 1, 0)
        set_commands(SET_CMDS.SET_CMD_AFC_SELECT_MANUAL_MODE) = New SET_COMMAND_STRUCTURE(REGISTER_CMD_AFC_SELECT_MANUAL_MODE, 1, 0)
        set_commands(SET_CMDS.SET_CMD_AFC_MANUAL_TARGET_POSITION) = New SET_COMMAND_STRUCTURE(REGISTER_CMD_AFC_MANUAL_TARGET_POSITION, 64000, 0)

        set_commands(SET_CMDS.SET_ELECTROMAGNET_CURRENT_HIGH_ENERGY) = New SET_COMMAND_STRUCTURE(REGISTER_ELECTROMAGNET_CURRENT_HIGH_ENERGY, 21000, 8000)
        set_commands(SET_CMDS.SET_ELECTROMAGNET_CURRENT_LOW_ENERGY) = New SET_COMMAND_STRUCTURE(REGISTER_ELECTROMAGNET_CURRENT_LOW_ENERGY, 21000, 8000)
        set_commands(SET_CMDS.SET_HEATER_CURRENT_AT_STANDBY) = New SET_COMMAND_STRUCTURE(REGISTER_HEATER_CURRENT_AT_STANDBY, 10000, 0)

    End Sub

    Private Sub btnDumpData_Click(sender As Object, e As EventArgs) Handles btnDumpData.Click
        ' test data dump function
#If False Then
        ServerSettings.ETMEthernetBoardLoggingData(1).fault_bits = &HFF
        ServerSettings.ETMEthernetBoardLoggingData(2).fault_bits = &HAA
        ServerSettings.ETMEthernetBoardLoggingData(3).fault_bits = &H77
        ServerSettings.ETMEthernetBoardLoggingData(MODBUS_COMMANDS.MODBUS_WR_ETHERNET).log_data(9) = 200
#End If
        ServerSettings.dump_all_data()
    End Sub

    Private Sub btnRestoreData_Click(sender As Object, e As EventArgs) Handles btnRestoreData.Click
        ServerSettings.restore_dumped_data()

    End Sub
End Class