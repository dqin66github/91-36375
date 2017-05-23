<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.TimerUpdate = New System.Windows.Forms.Timer(Me.components)
        Me.LabelAgileInfo = New System.Windows.Forms.Label()
        Me.LabelFirmwareVersion = New System.Windows.Forms.Label()
        Me.panelDispButtons = New System.Windows.Forms.Panel()
        Me.btnDispAFC = New CustomControls.ButtonSelected()
        Me.btnDispCoolSF6 = New CustomControls.ButtonSelected()
        Me.btnDispDeveloperPanel = New CustomControls.ButtonSelected()
        Me.btnDispServicePanel = New CustomControls.ButtonSelected()
        Me.ledReadyIonpump = New CustomControls.OvalLed()
        Me.btnDispService = New CustomControls.ButtonSelected()
        Me.btnDispMagnetron = New CustomControls.ButtonSelected()
        Me.ledReadyMagnetHtr = New CustomControls.OvalLed()
        Me.btnDispGunDriver = New CustomControls.ButtonSelected()
        Me.btnDispIonPump = New CustomControls.ButtonSelected()
        Me.ledReadyAfc = New CustomControls.OvalLed()
        Me.btnDispHV = New CustomControls.ButtonSelected()
        Me.btnDispSysCPU = New CustomControls.ButtonSelected()
        Me.ledReadyMagnetron = New CustomControls.OvalLed()
        Me.btnDispMagHtr = New CustomControls.ButtonSelected()
        Me.btnDispPulseSync = New CustomControls.ButtonSelected()
        Me.ledReadyHV = New CustomControls.OvalLed()
        Me.btnDispOverview = New CustomControls.ButtonSelected()
        Me.ledReadyCpu = New CustomControls.OvalLed()
        Me.ledReadyPulseSync = New CustomControls.OvalLed()
        Me.ledReadyGunDriver = New CustomControls.OvalLed()
        Me.ledReadyCooling = New CustomControls.OvalLed()
        Me.PictureBoxLogo = New System.Windows.Forms.PictureBox()
        Me.lblSystem = New System.Windows.Forms.Label()
        Me.LabelECBState = New System.Windows.Forms.Label()
        Me.lblSN = New System.Windows.Forms.Label()
        Me.btnResetFault = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lblGUIVersionAgile = New System.Windows.Forms.Label()
        Me.lblAccessLevel = New System.Windows.Forms.Label()
        Me.PanelRadLeft = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label106 = New System.Windows.Forms.Label()
        Me.Label108 = New System.Windows.Forms.Label()
        Me.PanelRadRight = New System.Windows.Forms.Panel()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Label128 = New System.Windows.Forms.Label()
        Me.Label129 = New System.Windows.Forms.Label()
        Me.lblScanMode = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.lblDoseRateUnit = New System.Windows.Forms.Label()
        Me.lblDoseRate = New System.Windows.Forms.Label()
        Me.lblPulseFreq = New System.Windows.Forms.Label()
        Me.lblDoseCommand = New System.Windows.Forms.Label()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.lblBeamDuration = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.lblDoseRateTitle = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.lblIonIi2Unit = New System.Windows.Forms.Label()
        Me.lblIonIi2Title = New System.Windows.Forms.Label()
        Me.lblIonIi2 = New System.Windows.Forms.Label()
        Me.lblNoTrigger = New System.Windows.Forms.Label()
        Me.lblShowDumpData = New System.Windows.Forms.Label()
        Me.TabBoards = New CustomControls.RightSideTab()
        Me.TabPageOverview = New System.Windows.Forms.TabPage()
        Me.Label283 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label277 = New System.Windows.Forms.Label()
        Me.Label173 = New System.Windows.Forms.Label()
        Me.Label276 = New System.Windows.Forms.Label()
        Me.Label240 = New System.Windows.Forms.Label()
        Me.Label279 = New System.Windows.Forms.Label()
        Me.Label272 = New System.Windows.Forms.Label()
        Me.lblCoolTemp = New System.Windows.Forms.Label()
        Me.lblCabTemp = New System.Windows.Forms.Label()
        Me.lblGdTemp = New System.Windows.Forms.Label()
        Me.lblSF6Pressure = New System.Windows.Forms.Label()
        Me.lblAutofillRemain1 = New System.Windows.Forms.Label()
        Me.Label123 = New System.Windows.Forms.Label()
        Me.Label213 = New System.Windows.Forms.Label()
        Me.btnReenableAutofill1 = New System.Windows.Forms.Button()
        Me.Label134 = New System.Windows.Forms.Label()
        Me.Label159 = New System.Windows.Forms.Label()
        Me.Label180 = New System.Windows.Forms.Label()
        Me.Meter = New CustomControls.meter()
        Me.BlueRect15 = New CustomControls.BlueRect()
        Me.TabPageCPU = New System.Windows.Forms.TabPage()
        Me.ledWCpuXrayDisabled = New CustomControls.OvalLed()
        Me.ledWCpuDriveupTimeout = New CustomControls.OvalLed()
        Me.ledCpuReadyFault = New CustomControls.OvalLed()
        Me.Label50 = New System.Windows.Forms.Label()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.ledCpuXrayLogic = New CustomControls.OvalLed()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.Label119 = New System.Windows.Forms.Label()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.Label57 = New System.Windows.Forms.Label()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.Label51 = New System.Windows.Forms.Label()
        Me.Label40 = New System.Windows.Forms.Label()
        Me.lblCpuWarmupThy = New System.Windows.Forms.Label()
        Me.Label41 = New System.Windows.Forms.Label()
        Me.lblCpuWarmupMag = New System.Windows.Forms.Label()
        Me.lblCpuPwrOnTime = New System.Windows.Forms.Label()
        Me.lblCpuHvTime = New System.Windows.Forms.Label()
        Me.Label52 = New System.Windows.Forms.Label()
        Me.lblCpuMagnetronPwr = New System.Windows.Forms.Label()
        Me.lblCpuWarmupGd = New System.Windows.Forms.Label()
        Me.Label43 = New System.Windows.Forms.Label()
        Me.lblCpuXrayTime = New System.Windows.Forms.Label()
        Me.BlueRect7 = New CustomControls.BlueRect()
        Me.TabPageGunDriver = New System.Windows.Forms.TabPage()
        Me.btnGdEgsetCab = New System.Windows.Forms.Button()
        Me.btnGdEgsetCargo = New System.Windows.Forms.Button()
        Me.btnGdIfSet = New System.Windows.Forms.Button()
        Me.btnGdEkset = New System.Windows.Forms.Button()
        Me.Label65 = New System.Windows.Forms.Label()
        Me.ledGdHtrStartup = New CustomControls.OvalLed()
        Me.ledGdCAN = New CustomControls.OvalLed()
        Me.ledGdADCread = New CustomControls.OvalLed()
        Me.ledGdEgMon = New CustomControls.OvalLed()
        Me.ledGdArc = New CustomControls.OvalLed()
        Me.ledGdHVmon = New CustomControls.OvalLed()
        Me.ledGdSPIcomm = New CustomControls.OvalLed()
        Me.ledGdEcMon = New CustomControls.OvalLed()
        Me.ledGdOT = New CustomControls.OvalLed()
        Me.ledGdHtrMon = New CustomControls.OvalLed()
        Me.ledGdGrid = New CustomControls.OvalLed()
        Me.ledGdHtrOC = New CustomControls.OvalLed()
        Me.Label104 = New System.Windows.Forms.Label()
        Me.ledGdFPGArev = New CustomControls.OvalLed()
        Me.Label96 = New System.Windows.Forms.Label()
        Me.Label102 = New System.Windows.Forms.Label()
        Me.Label101 = New System.Windows.Forms.Label()
        Me.Label95 = New System.Windows.Forms.Label()
        Me.Label100 = New System.Windows.Forms.Label()
        Me.Label94 = New System.Windows.Forms.Label()
        Me.Label99 = New System.Windows.Forms.Label()
        Me.Label91 = New System.Windows.Forms.Label()
        Me.Label98 = New System.Windows.Forms.Label()
        Me.Label93 = New System.Windows.Forms.Label()
        Me.Label90 = New System.Windows.Forms.Label()
        Me.Label61 = New System.Windows.Forms.Label()
        Me.Label89 = New System.Windows.Forms.Label()
        Me.Label86 = New System.Windows.Forms.Label()
        Me.Label83 = New System.Windows.Forms.Label()
        Me.Label80 = New System.Windows.Forms.Label()
        Me.Label77 = New System.Windows.Forms.Label()
        Me.Label62 = New System.Windows.Forms.Label()
        Me.Label88 = New System.Windows.Forms.Label()
        Me.lblGdEc = New System.Windows.Forms.Label()
        Me.Label85 = New System.Windows.Forms.Label()
        Me.lblGdEg = New System.Windows.Forms.Label()
        Me.Label82 = New System.Windows.Forms.Label()
        Me.lblGdIf = New System.Windows.Forms.Label()
        Me.Label79 = New System.Windows.Forms.Label()
        Me.lblGdEf = New System.Windows.Forms.Label()
        Me.Label76 = New System.Windows.Forms.Label()
        Me.lblGdIkp = New System.Windows.Forms.Label()
        Me.Label63 = New System.Windows.Forms.Label()
        Me.lblGdEk = New System.Windows.Forms.Label()
        Me.BlueRect4 = New CustomControls.BlueRect()
        Me.TabPageCooling = New System.Windows.Forms.TabPage()
        Me.lblAutofillRemain2 = New System.Windows.Forms.Label()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.btnReenableAutofill2 = New System.Windows.Forms.Button()
        Me.btnCoolNewSF6bottle = New System.Windows.Forms.Button()
        Me.btnCoolSF6Override = New System.Windows.Forms.Button()
        Me.ledWSF6RelayClosed = New CustomControls.OvalLed()
        Me.ledWNoSF6Pulses = New CustomControls.OvalLed()
        Me.ledCoolCabTemp = New CustomControls.OvalLed()
        Me.ledCoolCabTempSwitch = New CustomControls.OvalLed()
        Me.ledCoolCirFlow = New CustomControls.OvalLed()
        Me.ledWSF6TooLowToFill = New CustomControls.OvalLed()
        Me.ledCoolMagFlow = New CustomControls.OvalLed()
        Me.ledWSF6Filling = New CustomControls.OvalLed()
        Me.ledWSF6FillReq = New CustomControls.OvalLed()
        Me.ledCoolSF6press = New CustomControls.OvalLed()
        Me.ledCoolLinacFlow = New CustomControls.OvalLed()
        Me.ledWCoolTooCold = New CustomControls.OvalLed()
        Me.ledCoolCoolTemp = New CustomControls.OvalLed()
        Me.Label145 = New System.Windows.Forms.Label()
        Me.Label111 = New System.Windows.Forms.Label()
        Me.ledCoolCAN = New CustomControls.OvalLed()
        Me.Label110 = New System.Windows.Forms.Label()
        Me.Label113 = New System.Windows.Forms.Label()
        Me.Label109 = New System.Windows.Forms.Label()
        Me.Label114 = New System.Windows.Forms.Label()
        Me.Label115 = New System.Windows.Forms.Label()
        Me.Label116 = New System.Windows.Forms.Label()
        Me.Label118 = New System.Windows.Forms.Label()
        Me.Label120 = New System.Windows.Forms.Label()
        Me.LabelCoolLinacFlo = New System.Windows.Forms.Label()
        Me.Label124 = New System.Windows.Forms.Label()
        Me.Label125 = New System.Windows.Forms.Label()
        Me.Label126 = New System.Windows.Forms.Label()
        Me.Label156 = New System.Windows.Forms.Label()
        Me.Label155 = New System.Windows.Forms.Label()
        Me.Label154 = New System.Windows.Forms.Label()
        Me.Label130 = New System.Windows.Forms.Label()
        Me.Label131 = New System.Windows.Forms.Label()
        Me.Label132 = New System.Windows.Forms.Label()
        Me.Label147 = New System.Windows.Forms.Label()
        Me.Label148 = New System.Windows.Forms.Label()
        Me.Label146 = New System.Windows.Forms.Label()
        Me.lblCoolCabTemp = New System.Windows.Forms.Label()
        Me.lblCoolCoolTemp = New System.Windows.Forms.Label()
        Me.Label139 = New System.Windows.Forms.Label()
        Me.lblCoolSF6Press = New System.Windows.Forms.Label()
        Me.lblCoolCirFlow = New System.Windows.Forms.Label()
        Me.Label141 = New System.Windows.Forms.Label()
        Me.lblCoolLinacFlow = New System.Windows.Forms.Label()
        Me.Label143 = New System.Windows.Forms.Label()
        Me.lblCoolMagFlow = New System.Windows.Forms.Label()
        Me.Label66 = New System.Windows.Forms.Label()
        Me.BlueRect6 = New CustomControls.BlueRect()
        Me.TabPagePulseSync = New System.Windows.Forms.TabPage()
        Me.btnPulseSampleDelay = New System.Windows.Forms.Button()
        Me.btnPfnDelay = New System.Windows.Forms.Button()
        Me.btnAfcDelay = New System.Windows.Forms.Button()
        Me.btnPulseStopMin = New System.Windows.Forms.Button()
        Me.btnPulseStartMin = New System.Windows.Forms.Button()
        Me.btnPulseStop1_3 = New System.Windows.Forms.Button()
        Me.btnPulseStart1_3 = New System.Windows.Forms.Button()
        Me.btnPulseStop2_3 = New System.Windows.Forms.Button()
        Me.btnPulseStart2_3 = New System.Windows.Forms.Button()
        Me.btnPulseStopMax = New System.Windows.Forms.Button()
        Me.btnChangeSettingMode = New System.Windows.Forms.Button()
        Me.btnPulseStartMax = New System.Windows.Forms.Button()
        Me.ledWPulseLowOverride = New CustomControls.OvalLed()
        Me.ledWPulseTrigFault = New CustomControls.OvalLed()
        Me.ledPulseCanFault = New CustomControls.OvalLed()
        Me.ledWPulseCustomHVon = New CustomControls.OvalLed()
        Me.ledPulseKeylock = New CustomControls.OvalLed()
        Me.ledPulseTriggerStayedOn = New CustomControls.OvalLed()
        Me.ledPulsePFNfan = New CustomControls.OvalLed()
        Me.ledWPulseCustomXrayOn = New CustomControls.OvalLed()
        Me.ledPulseXrayTiming = New CustomControls.OvalLed()
        Me.ledWPulseHighOverride = New CustomControls.OvalLed()
        Me.ledPulseRFArc = New CustomControls.OvalLed()
        Me.ledPulsePanel = New CustomControls.OvalLed()
        Me.Label162 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label165 = New System.Windows.Forms.Label()
        Me.Label167 = New System.Windows.Forms.Label()
        Me.Label168 = New System.Windows.Forms.Label()
        Me.Label169 = New System.Windows.Forms.Label()
        Me.Label170 = New System.Windows.Forms.Label()
        Me.Label171 = New System.Windows.Forms.Label()
        Me.Label172 = New System.Windows.Forms.Label()
        Me.Label174 = New System.Windows.Forms.Label()
        Me.Label175 = New System.Windows.Forms.Label()
        Me.Label176 = New System.Windows.Forms.Label()
        Me.lblModeSettings = New System.Windows.Forms.Label()
        Me.Label67 = New System.Windows.Forms.Label()
        Me.BlueRect5 = New CustomControls.BlueRect()
        Me.TabPageHVsupply = New System.Windows.Forms.TabPage()
        Me.ledHVDriveup = New CustomControls.OvalLed()
        Me.btnHVsetCab = New System.Windows.Forms.Button()
        Me.btnHVsetCargo = New System.Windows.Forms.Button()
        Me.ledWHvOT = New CustomControls.OvalLed()
        Me.ledWHvLoadFault = New CustomControls.OvalLed()
        Me.ledWHvHVoff = New CustomControls.OvalLed()
        Me.ledWHvSumFault = New CustomControls.OvalLed()
        Me.ledWHvPhaseLoss = New CustomControls.OvalLed()
        Me.ledWHvIntlock = New CustomControls.OvalLed()
        Me.ledWHvPowerOff = New CustomControls.OvalLed()
        Me.ledHVCanFault = New CustomControls.OvalLed()
        Me.Label158 = New System.Windows.Forms.Label()
        Me.Label163 = New System.Windows.Forms.Label()
        Me.Label164 = New System.Windows.Forms.Label()
        Me.Label177 = New System.Windows.Forms.Label()
        Me.Label178 = New System.Windows.Forms.Label()
        Me.Label179 = New System.Windows.Forms.Label()
        Me.Label181 = New System.Windows.Forms.Label()
        Me.Label182 = New System.Windows.Forms.Label()
        Me.Label183 = New System.Windows.Forms.Label()
        Me.Label198 = New System.Windows.Forms.Label()
        Me.Label199 = New System.Windows.Forms.Label()
        Me.Label208 = New System.Windows.Forms.Label()
        Me.lblHVcurrent = New System.Windows.Forms.Label()
        Me.Label210 = New System.Windows.Forms.Label()
        Me.lblHVprePulseVolt = New System.Windows.Forms.Label()
        Me.Label68 = New System.Windows.Forms.Label()
        Me.BlueRect9 = New CustomControls.BlueRect()
        Me.TabPageMagnetron = New System.Windows.Forms.TabPage()
        Me.PanelMagnetronLeds = New System.Windows.Forms.Panel()
        Me.ledCurrArcCont = New CustomControls.OvalLed()
        Me.ledCurrArcSlow = New CustomControls.OvalLed()
        Me.ledCurrArcFast = New CustomControls.OvalLed()
        Me.ledCurrLowPulseCurr = New CustomControls.OvalLed()
        Me.ledCurrFalseTrig = New CustomControls.OvalLed()
        Me.ledCurrCanFault = New CustomControls.OvalLed()
        Me.Label197 = New System.Windows.Forms.Label()
        Me.Label206 = New System.Windows.Forms.Label()
        Me.Label103 = New System.Windows.Forms.Label()
        Me.Label212 = New System.Windows.Forms.Label()
        Me.Label214 = New System.Windows.Forms.Label()
        Me.Label215 = New System.Windows.Forms.Label()
        Me.PanelArcCounts = New System.Windows.Forms.Panel()
        Me.Label230 = New System.Windows.Forms.Label()
        Me.lblCurrArcsPwrOn = New System.Windows.Forms.Label()
        Me.lblCurrArcsTotal = New System.Windows.Forms.Label()
        Me.Label226 = New System.Windows.Forms.Label()
        Me.lblCurrPulsesOutOfRange = New System.Windows.Forms.Label()
        Me.Label97 = New System.Windows.Forms.Label()
        Me.Label216 = New System.Windows.Forms.Label()
        Me.Label217 = New System.Windows.Forms.Label()
        Me.Label222 = New System.Windows.Forms.Label()
        Me.lblCurrCabScan = New System.Windows.Forms.Label()
        Me.Label224 = New System.Windows.Forms.Label()
        Me.lblCurrCargoScan = New System.Windows.Forms.Label()
        Me.Label228 = New System.Windows.Forms.Label()
        Me.lblCurrPulsesTotal = New System.Windows.Forms.Label()
        Me.Label232 = New System.Windows.Forms.Label()
        Me.lblCurrPulsesPwrOn = New System.Windows.Forms.Label()
        Me.Label69 = New System.Windows.Forms.Label()
        Me.BlueRectMagnetron = New CustomControls.BlueRect()
        Me.TabPageAFC = New System.Windows.Forms.TabPage()
        Me.btnAfcManualPosition = New System.Windows.Forms.Button()
        Me.btnAfcManualMode = New System.Windows.Forms.Button()
        Me.btnAfcHomePosSet = New System.Windows.Forms.Button()
        Me.btnAfcCabCtrlVSet = New System.Windows.Forms.Button()
        Me.btnAfcCargoCtrlVSet = New System.Windows.Forms.Button()
        Me.ledWAfcManualMode = New CustomControls.OvalLed()
        Me.ledAfcCanFault = New CustomControls.OvalLed()
        Me.Label221 = New System.Windows.Forms.Label()
        Me.Label234 = New System.Windows.Forms.Label()
        Me.Label239 = New System.Windows.Forms.Label()
        Me.Label241 = New System.Windows.Forms.Label()
        Me.lblAfcPreAsample = New System.Windows.Forms.Label()
        Me.Label161 = New System.Windows.Forms.Label()
        Me.lblAfcPreBsample = New System.Windows.Forms.Label()
        Me.Label243 = New System.Windows.Forms.Label()
        Me.lblAfcFilteredError = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblAfcManualPosition = New System.Windows.Forms.Label()
        Me.Label249 = New System.Windows.Forms.Label()
        Me.lblAfcHomePosition = New System.Windows.Forms.Label()
        Me.Label251 = New System.Windows.Forms.Label()
        Me.lblAfcPhaseCtrlV = New System.Windows.Forms.Label()
        Me.Label70 = New System.Windows.Forms.Label()
        Me.BlueRect11 = New CustomControls.BlueRect()
        Me.TabPageMagnetrHtr = New System.Windows.Forms.TabPage()
        Me.btnMagIfSet = New System.Windows.Forms.Button()
        Me.btnMagCabIset = New System.Windows.Forms.Button()
        Me.btnMagCargoIset = New System.Windows.Forms.Button()
        Me.ledMagCanFault = New CustomControls.OvalLed()
        Me.ledMagImUCAbs = New CustomControls.OvalLed()
        Me.ledMagEmUVAbs = New CustomControls.OvalLed()
        Me.ledMagTempSW = New CustomControls.OvalLed()
        Me.ledMagEfUVRel = New CustomControls.OvalLed()
        Me.ledWMagHtrOK = New CustomControls.OvalLed()
        Me.ledMagIfOCRel = New CustomControls.OvalLed()
        Me.ledMagCoolFault = New CustomControls.OvalLed()
        Me.ledMagImOCAbs = New CustomControls.OvalLed()
        Me.ledWMagOTActive = New CustomControls.OvalLed()
        Me.ledWMagIfOCActive = New CustomControls.OvalLed()
        Me.ledWMagEfOVLatch = New CustomControls.OvalLed()
        Me.ledMagIfUCRel = New CustomControls.OvalLed()
        Me.ledWMagOutRelayOpen = New CustomControls.OvalLed()
        Me.ledWMagOK = New CustomControls.OvalLed()
        Me.Label201 = New System.Windows.Forms.Label()
        Me.ledMagIfOCAbs = New CustomControls.OvalLed()
        Me.Label202 = New System.Windows.Forms.Label()
        Me.Label203 = New System.Windows.Forms.Label()
        Me.Label207 = New System.Windows.Forms.Label()
        Me.Label218 = New System.Windows.Forms.Label()
        Me.Label219 = New System.Windows.Forms.Label()
        Me.Label117 = New System.Windows.Forms.Label()
        Me.Label112 = New System.Windows.Forms.Label()
        Me.Label220 = New System.Windows.Forms.Label()
        Me.Label235 = New System.Windows.Forms.Label()
        Me.Label236 = New System.Windows.Forms.Label()
        Me.Label237 = New System.Windows.Forms.Label()
        Me.Label238 = New System.Windows.Forms.Label()
        Me.Label245 = New System.Windows.Forms.Label()
        Me.Label246 = New System.Windows.Forms.Label()
        Me.Label253 = New System.Windows.Forms.Label()
        Me.Label256 = New System.Windows.Forms.Label()
        Me.Label257 = New System.Windows.Forms.Label()
        Me.Label258 = New System.Windows.Forms.Label()
        Me.Label259 = New System.Windows.Forms.Label()
        Me.Label264 = New System.Windows.Forms.Label()
        Me.lblMagIf = New System.Windows.Forms.Label()
        Me.Label266 = New System.Windows.Forms.Label()
        Me.lblMagEf = New System.Windows.Forms.Label()
        Me.Label268 = New System.Windows.Forms.Label()
        Me.lblMagEm = New System.Windows.Forms.Label()
        Me.Label270 = New System.Windows.Forms.Label()
        Me.lblMagIm = New System.Windows.Forms.Label()
        Me.Label71 = New System.Windows.Forms.Label()
        Me.BlueRect13 = New CustomControls.BlueRect()
        Me.TabPageIonPump = New System.Windows.Forms.TabPage()
        Me.panelIonPumpLogger = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtIonPumpLogInterval = New System.Windows.Forms.TextBox()
        Me.lblIonPumpLogName = New System.Windows.Forms.Label()
        Me.btnIonPumpLog = New System.Windows.Forms.Button()
        Me.ledIonUV = New CustomControls.OvalLed()
        Me.ledIonOC = New CustomControls.OvalLed()
        Me.ledIonCanFault = New CustomControls.OvalLed()
        Me.Label262 = New System.Windows.Forms.Label()
        Me.Label280 = New System.Windows.Forms.Label()
        Me.Label281 = New System.Windows.Forms.Label()
        Me.Label284 = New System.Windows.Forms.Label()
        Me.Label285 = New System.Windows.Forms.Label()
        Me.Label290 = New System.Windows.Forms.Label()
        Me.Label292 = New System.Windows.Forms.Label()
        Me.lblIonEi = New System.Windows.Forms.Label()
        Me.lblIonIi = New System.Windows.Forms.Label()
        Me.Label72 = New System.Windows.Forms.Label()
        Me.BlueRect12 = New CustomControls.BlueRect()
        Me.TabPageService = New System.Windows.Forms.TabPage()
        Me.lblLogFileName = New System.Windows.Forms.Label()
        Me.btnServiceModeChange = New System.Windows.Forms.Button()
        Me.btnServiceResetLinacTime = New System.Windows.Forms.Button()
        Me.btnIPaddress = New System.Windows.Forms.Button()
        Me.LabelComputerTime = New System.Windows.Forms.Label()
        Me.LabelECBTime = New System.Windows.Forms.Label()
        Me.btnServiceStartLog = New System.Windows.Forms.Button()
        Me.ledServiceNormalMode = New CustomControls.OvalLed()
        Me.ledServiceDevMode = New CustomControls.OvalLed()
        Me.ledServicePulseLogActive = New CustomControls.OvalLed()
        Me.ledServiceServMode = New CustomControls.OvalLed()
        Me.Label122 = New System.Windows.Forms.Label()
        Me.Label255 = New System.Windows.Forms.Label()
        Me.Label286 = New System.Windows.Forms.Label()
        Me.Label254 = New System.Windows.Forms.Label()
        Me.Label74 = New System.Windows.Forms.Label()
        Me.BlueRect1 = New CustomControls.BlueRect()
        Me.BlueRect14 = New CustomControls.BlueRect()
        Me.BlueRect2 = New CustomControls.BlueRect()
        Me.TabPageServicePanel = New System.Windows.Forms.TabPage()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btnLoadParameters = New System.Windows.Forms.Button()
        Me.BlueRect3 = New CustomControls.BlueRect()
        Me.btnSaveAllParams = New System.Windows.Forms.Button()
        Me.btnServiceRestoreFactoryDefaults = New System.Windows.Forms.Button()
        Me.btnMagnetronConditioning = New System.Windows.Forms.Button()
        Me.btnZeroArcPulseCounters = New System.Windows.Forms.Button()
        Me.tabPageDeveloper = New System.Windows.Forms.TabPage()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.LabelGUIVersionDeploy = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.btnZeroOnTime = New System.Windows.Forms.Button()
        Me.btnRestoreData = New System.Windows.Forms.Button()
        Me.btnServiceReloadInitialDefaults = New System.Windows.Forms.Button()
        Me.btnClearDebugData = New System.Windows.Forms.Button()
        Me.BlueRect17 = New CustomControls.BlueRect()
        Me.btnServiceSaveFactoryDefaults = New System.Windows.Forms.Button()
        Me.btnDumpData = New System.Windows.Forms.Button()
        Me.BlueRectMain = New CustomControls.BlueRect()
        Me.panelDispButtons.SuspendLayout()
        CType(Me.PictureBoxLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.PanelRadLeft.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelRadRight.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabBoards.SuspendLayout()
        Me.TabPageOverview.SuspendLayout()
        Me.TabPageCPU.SuspendLayout()
        Me.TabPageGunDriver.SuspendLayout()
        Me.TabPageCooling.SuspendLayout()
        Me.TabPagePulseSync.SuspendLayout()
        Me.TabPageHVsupply.SuspendLayout()
        Me.TabPageMagnetron.SuspendLayout()
        Me.PanelMagnetronLeds.SuspendLayout()
        Me.PanelArcCounts.SuspendLayout()
        Me.TabPageAFC.SuspendLayout()
        Me.TabPageMagnetrHtr.SuspendLayout()
        Me.TabPageIonPump.SuspendLayout()
        Me.panelIonPumpLogger.SuspendLayout()
        Me.TabPageService.SuspendLayout()
        Me.TabPageServicePanel.SuspendLayout()
        Me.tabPageDeveloper.SuspendLayout()
        Me.SuspendLayout()
        '
        'TimerUpdate
        '
        Me.TimerUpdate.Interval = 500
        '
        'LabelAgileInfo
        '
        Me.LabelAgileInfo.AutoSize = True
        Me.LabelAgileInfo.BackColor = System.Drawing.Color.White
        Me.LabelAgileInfo.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelAgileInfo.ForeColor = System.Drawing.Color.Black
        Me.LabelAgileInfo.Location = New System.Drawing.Point(697, 437)
        Me.LabelAgileInfo.Name = "LabelAgileInfo"
        Me.LabelAgileInfo.Size = New System.Drawing.Size(149, 13)
        Me.LabelAgileInfo.TabIndex = 1
        Me.LabelAgileInfo.Text = "A12345-000 rev 000 SN 6789"
        Me.LabelAgileInfo.Visible = False
        '
        'LabelFirmwareVersion
        '
        Me.LabelFirmwareVersion.AutoSize = True
        Me.LabelFirmwareVersion.BackColor = System.Drawing.Color.White
        Me.LabelFirmwareVersion.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelFirmwareVersion.ForeColor = System.Drawing.Color.Black
        Me.LabelFirmwareVersion.Location = New System.Drawing.Point(697, 463)
        Me.LabelFirmwareVersion.Name = "LabelFirmwareVersion"
        Me.LabelFirmwareVersion.Size = New System.Drawing.Size(144, 13)
        Me.LabelFirmwareVersion.TabIndex = 1
        Me.LabelFirmwareVersion.Text = "Firmware Version  12.11.20"
        Me.LabelFirmwareVersion.Visible = False
        '
        'panelDispButtons
        '
        Me.panelDispButtons.BackColor = System.Drawing.Color.White
        Me.panelDispButtons.Controls.Add(Me.btnDispAFC)
        Me.panelDispButtons.Controls.Add(Me.btnDispCoolSF6)
        Me.panelDispButtons.Controls.Add(Me.btnDispDeveloperPanel)
        Me.panelDispButtons.Controls.Add(Me.btnDispServicePanel)
        Me.panelDispButtons.Controls.Add(Me.ledReadyIonpump)
        Me.panelDispButtons.Controls.Add(Me.btnDispService)
        Me.panelDispButtons.Controls.Add(Me.btnDispMagnetron)
        Me.panelDispButtons.Controls.Add(Me.ledReadyMagnetHtr)
        Me.panelDispButtons.Controls.Add(Me.btnDispGunDriver)
        Me.panelDispButtons.Controls.Add(Me.btnDispIonPump)
        Me.panelDispButtons.Controls.Add(Me.ledReadyAfc)
        Me.panelDispButtons.Controls.Add(Me.btnDispHV)
        Me.panelDispButtons.Controls.Add(Me.btnDispSysCPU)
        Me.panelDispButtons.Controls.Add(Me.ledReadyMagnetron)
        Me.panelDispButtons.Controls.Add(Me.btnDispMagHtr)
        Me.panelDispButtons.Controls.Add(Me.btnDispPulseSync)
        Me.panelDispButtons.Controls.Add(Me.ledReadyHV)
        Me.panelDispButtons.Controls.Add(Me.btnDispOverview)
        Me.panelDispButtons.Controls.Add(Me.ledReadyCpu)
        Me.panelDispButtons.Controls.Add(Me.ledReadyPulseSync)
        Me.panelDispButtons.Controls.Add(Me.ledReadyGunDriver)
        Me.panelDispButtons.Controls.Add(Me.ledReadyCooling)
        Me.panelDispButtons.ForeColor = System.Drawing.Color.Black
        Me.panelDispButtons.Location = New System.Drawing.Point(1036, 138)
        Me.panelDispButtons.Name = "panelDispButtons"
        Me.panelDispButtons.Size = New System.Drawing.Size(252, 412)
        Me.panelDispButtons.TabIndex = 5
        '
        'btnDispAFC
        '
        Me.btnDispAFC.BackColor = System.Drawing.Color.White
        Me.btnDispAFC.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnDispAFC.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDispAFC.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnDispAFC.ForeColor = System.Drawing.Color.Black
        Me.btnDispAFC.Location = New System.Drawing.Point(0, 230)
        Me.btnDispAFC.Name = "btnDispAFC"
        Me.btnDispAFC.ShowBoardSelected = False
        Me.btnDispAFC.Size = New System.Drawing.Size(220, 30)
        Me.btnDispAFC.TabIndex = 4
        Me.btnDispAFC.Tag = "7"
        Me.btnDispAFC.Text = "AFC"
        Me.btnDispAFC.UseVisualStyleBackColor = False
        '
        'btnDispCoolSF6
        '
        Me.btnDispCoolSF6.BackColor = System.Drawing.Color.White
        Me.btnDispCoolSF6.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnDispCoolSF6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDispCoolSF6.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnDispCoolSF6.ForeColor = System.Drawing.Color.Black
        Me.btnDispCoolSF6.Location = New System.Drawing.Point(0, 110)
        Me.btnDispCoolSF6.Name = "btnDispCoolSF6"
        Me.btnDispCoolSF6.ShowBoardSelected = False
        Me.btnDispCoolSF6.Size = New System.Drawing.Size(220, 30)
        Me.btnDispCoolSF6.TabIndex = 4
        Me.btnDispCoolSF6.Tag = "3"
        Me.btnDispCoolSF6.Text = "Cooling/SF6"
        Me.btnDispCoolSF6.UseVisualStyleBackColor = False
        '
        'btnDispDeveloperPanel
        '
        Me.btnDispDeveloperPanel.BackColor = System.Drawing.Color.White
        Me.btnDispDeveloperPanel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnDispDeveloperPanel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDispDeveloperPanel.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnDispDeveloperPanel.ForeColor = System.Drawing.Color.Black
        Me.btnDispDeveloperPanel.Location = New System.Drawing.Point(0, 380)
        Me.btnDispDeveloperPanel.Name = "btnDispDeveloperPanel"
        Me.btnDispDeveloperPanel.ShowBoardSelected = False
        Me.btnDispDeveloperPanel.Size = New System.Drawing.Size(220, 30)
        Me.btnDispDeveloperPanel.TabIndex = 4
        Me.btnDispDeveloperPanel.Tag = "12"
        Me.btnDispDeveloperPanel.Text = "Developer Panel"
        Me.btnDispDeveloperPanel.UseVisualStyleBackColor = False
        Me.btnDispDeveloperPanel.Visible = False
        '
        'btnDispServicePanel
        '
        Me.btnDispServicePanel.BackColor = System.Drawing.Color.White
        Me.btnDispServicePanel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnDispServicePanel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDispServicePanel.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnDispServicePanel.ForeColor = System.Drawing.Color.Black
        Me.btnDispServicePanel.Location = New System.Drawing.Point(0, 350)
        Me.btnDispServicePanel.Name = "btnDispServicePanel"
        Me.btnDispServicePanel.ShowBoardSelected = False
        Me.btnDispServicePanel.Size = New System.Drawing.Size(220, 30)
        Me.btnDispServicePanel.TabIndex = 4
        Me.btnDispServicePanel.Tag = "11"
        Me.btnDispServicePanel.Text = "Service Panel"
        Me.btnDispServicePanel.UseVisualStyleBackColor = False
        Me.btnDispServicePanel.Visible = False
        '
        'ledReadyIonpump
        '
        Me.ledReadyIonpump.FillColor = System.Drawing.Color.LawnGreen
        Me.ledReadyIonpump.ForeColor = System.Drawing.SystemColors.Control
        Me.ledReadyIonpump.Location = New System.Drawing.Point(226, 292)
        Me.ledReadyIonpump.MyBorderColor = System.Drawing.Color.Black
        Me.ledReadyIonpump.MyBorderWidth = 2
        Me.ledReadyIonpump.Name = "ledReadyIonpump"
        Me.ledReadyIonpump.Size = New System.Drawing.Size(18, 20)
        Me.ledReadyIonpump.TabIndex = 101
        Me.ledReadyIonpump.Visible = False
        '
        'btnDispService
        '
        Me.btnDispService.BackColor = System.Drawing.Color.White
        Me.btnDispService.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnDispService.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDispService.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnDispService.ForeColor = System.Drawing.Color.Black
        Me.btnDispService.Location = New System.Drawing.Point(0, 320)
        Me.btnDispService.Name = "btnDispService"
        Me.btnDispService.ShowBoardSelected = False
        Me.btnDispService.Size = New System.Drawing.Size(220, 30)
        Me.btnDispService.TabIndex = 4
        Me.btnDispService.Tag = "10"
        Me.btnDispService.Text = "Service Tools"
        Me.btnDispService.UseVisualStyleBackColor = False
        '
        'btnDispMagnetron
        '
        Me.btnDispMagnetron.BackColor = System.Drawing.Color.White
        Me.btnDispMagnetron.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnDispMagnetron.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDispMagnetron.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnDispMagnetron.ForeColor = System.Drawing.Color.Black
        Me.btnDispMagnetron.Location = New System.Drawing.Point(0, 200)
        Me.btnDispMagnetron.Name = "btnDispMagnetron"
        Me.btnDispMagnetron.ShowBoardSelected = False
        Me.btnDispMagnetron.Size = New System.Drawing.Size(220, 30)
        Me.btnDispMagnetron.TabIndex = 4
        Me.btnDispMagnetron.Tag = "6"
        Me.btnDispMagnetron.Text = "Magnetron Current"
        Me.btnDispMagnetron.UseVisualStyleBackColor = False
        '
        'ledReadyMagnetHtr
        '
        Me.ledReadyMagnetHtr.FillColor = System.Drawing.Color.LawnGreen
        Me.ledReadyMagnetHtr.ForeColor = System.Drawing.SystemColors.Control
        Me.ledReadyMagnetHtr.Location = New System.Drawing.Point(226, 263)
        Me.ledReadyMagnetHtr.MyBorderColor = System.Drawing.Color.Black
        Me.ledReadyMagnetHtr.MyBorderWidth = 2
        Me.ledReadyMagnetHtr.Name = "ledReadyMagnetHtr"
        Me.ledReadyMagnetHtr.Size = New System.Drawing.Size(18, 20)
        Me.ledReadyMagnetHtr.TabIndex = 101
        Me.ledReadyMagnetHtr.Visible = False
        '
        'btnDispGunDriver
        '
        Me.btnDispGunDriver.BackColor = System.Drawing.Color.White
        Me.btnDispGunDriver.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnDispGunDriver.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDispGunDriver.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnDispGunDriver.ForeColor = System.Drawing.Color.Black
        Me.btnDispGunDriver.Location = New System.Drawing.Point(0, 80)
        Me.btnDispGunDriver.Name = "btnDispGunDriver"
        Me.btnDispGunDriver.ShowBoardSelected = False
        Me.btnDispGunDriver.Size = New System.Drawing.Size(220, 30)
        Me.btnDispGunDriver.TabIndex = 4
        Me.btnDispGunDriver.Tag = "2"
        Me.btnDispGunDriver.Text = "Gun Driver"
        Me.btnDispGunDriver.UseVisualStyleBackColor = False
        '
        'btnDispIonPump
        '
        Me.btnDispIonPump.BackColor = System.Drawing.Color.White
        Me.btnDispIonPump.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnDispIonPump.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDispIonPump.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnDispIonPump.ForeColor = System.Drawing.Color.Black
        Me.btnDispIonPump.Location = New System.Drawing.Point(0, 290)
        Me.btnDispIonPump.Name = "btnDispIonPump"
        Me.btnDispIonPump.ShowBoardSelected = False
        Me.btnDispIonPump.Size = New System.Drawing.Size(220, 30)
        Me.btnDispIonPump.TabIndex = 4
        Me.btnDispIonPump.Tag = "9"
        Me.btnDispIonPump.Text = "Ion Pump"
        Me.btnDispIonPump.UseVisualStyleBackColor = False
        '
        'ledReadyAfc
        '
        Me.ledReadyAfc.FillColor = System.Drawing.Color.LawnGreen
        Me.ledReadyAfc.ForeColor = System.Drawing.SystemColors.Control
        Me.ledReadyAfc.Location = New System.Drawing.Point(226, 234)
        Me.ledReadyAfc.MyBorderColor = System.Drawing.Color.Black
        Me.ledReadyAfc.MyBorderWidth = 2
        Me.ledReadyAfc.Name = "ledReadyAfc"
        Me.ledReadyAfc.Size = New System.Drawing.Size(18, 20)
        Me.ledReadyAfc.TabIndex = 101
        Me.ledReadyAfc.Visible = False
        '
        'btnDispHV
        '
        Me.btnDispHV.BackColor = System.Drawing.Color.White
        Me.btnDispHV.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnDispHV.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDispHV.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnDispHV.ForeColor = System.Drawing.Color.Black
        Me.btnDispHV.Location = New System.Drawing.Point(0, 170)
        Me.btnDispHV.Name = "btnDispHV"
        Me.btnDispHV.ShowBoardSelected = False
        Me.btnDispHV.Size = New System.Drawing.Size(220, 30)
        Me.btnDispHV.TabIndex = 4
        Me.btnDispHV.Tag = "5"
        Me.btnDispHV.Text = "HV Power Supply"
        Me.btnDispHV.UseVisualStyleBackColor = False
        '
        'btnDispSysCPU
        '
        Me.btnDispSysCPU.BackColor = System.Drawing.Color.White
        Me.btnDispSysCPU.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnDispSysCPU.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDispSysCPU.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnDispSysCPU.ForeColor = System.Drawing.Color.Black
        Me.btnDispSysCPU.Location = New System.Drawing.Point(0, 50)
        Me.btnDispSysCPU.Name = "btnDispSysCPU"
        Me.btnDispSysCPU.ShowBoardSelected = False
        Me.btnDispSysCPU.Size = New System.Drawing.Size(220, 30)
        Me.btnDispSysCPU.TabIndex = 4
        Me.btnDispSysCPU.Tag = "1"
        Me.btnDispSysCPU.Text = "System CPU"
        Me.btnDispSysCPU.UseVisualStyleBackColor = False
        '
        'ledReadyMagnetron
        '
        Me.ledReadyMagnetron.FillColor = System.Drawing.Color.LawnGreen
        Me.ledReadyMagnetron.ForeColor = System.Drawing.SystemColors.Control
        Me.ledReadyMagnetron.Location = New System.Drawing.Point(226, 205)
        Me.ledReadyMagnetron.MyBorderColor = System.Drawing.Color.Black
        Me.ledReadyMagnetron.MyBorderWidth = 2
        Me.ledReadyMagnetron.Name = "ledReadyMagnetron"
        Me.ledReadyMagnetron.Size = New System.Drawing.Size(18, 20)
        Me.ledReadyMagnetron.TabIndex = 101
        Me.ledReadyMagnetron.Visible = False
        '
        'btnDispMagHtr
        '
        Me.btnDispMagHtr.BackColor = System.Drawing.Color.White
        Me.btnDispMagHtr.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnDispMagHtr.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDispMagHtr.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnDispMagHtr.ForeColor = System.Drawing.Color.Black
        Me.btnDispMagHtr.Location = New System.Drawing.Point(0, 260)
        Me.btnDispMagHtr.Name = "btnDispMagHtr"
        Me.btnDispMagHtr.ShowBoardSelected = False
        Me.btnDispMagHtr.Size = New System.Drawing.Size(220, 30)
        Me.btnDispMagHtr.TabIndex = 4
        Me.btnDispMagHtr.Tag = "8"
        Me.btnDispMagHtr.Text = "Magnet/Heater"
        Me.btnDispMagHtr.UseVisualStyleBackColor = False
        '
        'btnDispPulseSync
        '
        Me.btnDispPulseSync.BackColor = System.Drawing.Color.White
        Me.btnDispPulseSync.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnDispPulseSync.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDispPulseSync.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnDispPulseSync.ForeColor = System.Drawing.Color.Black
        Me.btnDispPulseSync.Location = New System.Drawing.Point(0, 140)
        Me.btnDispPulseSync.Name = "btnDispPulseSync"
        Me.btnDispPulseSync.ShowBoardSelected = False
        Me.btnDispPulseSync.Size = New System.Drawing.Size(220, 30)
        Me.btnDispPulseSync.TabIndex = 4
        Me.btnDispPulseSync.Tag = "4"
        Me.btnDispPulseSync.Text = "Pulse Sync"
        Me.btnDispPulseSync.UseVisualStyleBackColor = False
        '
        'ledReadyHV
        '
        Me.ledReadyHV.FillColor = System.Drawing.Color.LawnGreen
        Me.ledReadyHV.ForeColor = System.Drawing.SystemColors.Control
        Me.ledReadyHV.Location = New System.Drawing.Point(226, 176)
        Me.ledReadyHV.MyBorderColor = System.Drawing.Color.Black
        Me.ledReadyHV.MyBorderWidth = 2
        Me.ledReadyHV.Name = "ledReadyHV"
        Me.ledReadyHV.Size = New System.Drawing.Size(18, 20)
        Me.ledReadyHV.TabIndex = 101
        Me.ledReadyHV.Visible = False
        '
        'btnDispOverview
        '
        Me.btnDispOverview.BackColor = System.Drawing.Color.White
        Me.btnDispOverview.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnDispOverview.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDispOverview.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Bold)
        Me.btnDispOverview.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.btnDispOverview.Location = New System.Drawing.Point(0, 0)
        Me.btnDispOverview.Name = "btnDispOverview"
        Me.btnDispOverview.ShowBoardSelected = True
        Me.btnDispOverview.Size = New System.Drawing.Size(220, 50)
        Me.btnDispOverview.TabIndex = 4
        Me.btnDispOverview.Tag = "0"
        Me.btnDispOverview.Text = "System Overview"
        Me.btnDispOverview.UseVisualStyleBackColor = False
        '
        'ledReadyCpu
        '
        Me.ledReadyCpu.FillColor = System.Drawing.Color.LawnGreen
        Me.ledReadyCpu.ForeColor = System.Drawing.SystemColors.Control
        Me.ledReadyCpu.Location = New System.Drawing.Point(226, 60)
        Me.ledReadyCpu.MyBorderColor = System.Drawing.Color.Black
        Me.ledReadyCpu.MyBorderWidth = 2
        Me.ledReadyCpu.Name = "ledReadyCpu"
        Me.ledReadyCpu.Size = New System.Drawing.Size(18, 20)
        Me.ledReadyCpu.TabIndex = 101
        Me.ledReadyCpu.Visible = False
        '
        'ledReadyPulseSync
        '
        Me.ledReadyPulseSync.FillColor = System.Drawing.Color.LawnGreen
        Me.ledReadyPulseSync.ForeColor = System.Drawing.SystemColors.Control
        Me.ledReadyPulseSync.Location = New System.Drawing.Point(226, 147)
        Me.ledReadyPulseSync.MyBorderColor = System.Drawing.Color.Black
        Me.ledReadyPulseSync.MyBorderWidth = 2
        Me.ledReadyPulseSync.Name = "ledReadyPulseSync"
        Me.ledReadyPulseSync.Size = New System.Drawing.Size(18, 20)
        Me.ledReadyPulseSync.TabIndex = 101
        Me.ledReadyPulseSync.Visible = False
        '
        'ledReadyGunDriver
        '
        Me.ledReadyGunDriver.FillColor = System.Drawing.Color.LawnGreen
        Me.ledReadyGunDriver.ForeColor = System.Drawing.SystemColors.Control
        Me.ledReadyGunDriver.Location = New System.Drawing.Point(226, 89)
        Me.ledReadyGunDriver.MyBorderColor = System.Drawing.Color.Black
        Me.ledReadyGunDriver.MyBorderWidth = 2
        Me.ledReadyGunDriver.Name = "ledReadyGunDriver"
        Me.ledReadyGunDriver.Size = New System.Drawing.Size(18, 20)
        Me.ledReadyGunDriver.TabIndex = 101
        Me.ledReadyGunDriver.Visible = False
        '
        'ledReadyCooling
        '
        Me.ledReadyCooling.FillColor = System.Drawing.Color.LawnGreen
        Me.ledReadyCooling.ForeColor = System.Drawing.SystemColors.Control
        Me.ledReadyCooling.Location = New System.Drawing.Point(226, 118)
        Me.ledReadyCooling.MyBorderColor = System.Drawing.Color.Black
        Me.ledReadyCooling.MyBorderWidth = 2
        Me.ledReadyCooling.Name = "ledReadyCooling"
        Me.ledReadyCooling.Size = New System.Drawing.Size(18, 20)
        Me.ledReadyCooling.TabIndex = 101
        Me.ledReadyCooling.Visible = False
        '
        'PictureBoxLogo
        '
        Me.PictureBoxLogo.BackColor = System.Drawing.Color.White
        Me.PictureBoxLogo.Image = CType(resources.GetObject("PictureBoxLogo.Image"), System.Drawing.Image)
        Me.PictureBoxLogo.InitialImage = CType(resources.GetObject("PictureBoxLogo.InitialImage"), System.Drawing.Image)
        Me.PictureBoxLogo.Location = New System.Drawing.Point(28, 42)
        Me.PictureBoxLogo.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBoxLogo.Name = "PictureBoxLogo"
        Me.PictureBoxLogo.Size = New System.Drawing.Size(281, 85)
        Me.PictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBoxLogo.TabIndex = 31
        Me.PictureBoxLogo.TabStop = False
        '
        'lblSystem
        '
        Me.lblSystem.AutoSize = True
        Me.lblSystem.BackColor = System.Drawing.Color.White
        Me.lblSystem.Font = New System.Drawing.Font("Segoe UI", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSystem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.lblSystem.Location = New System.Drawing.Point(479, 49)
        Me.lblSystem.Name = "lblSystem"
        Me.lblSystem.Size = New System.Drawing.Size(422, 54)
        Me.lblSystem.TabIndex = 3
        Me.lblSystem.Text = "2.5MeV Linac System"
        Me.lblSystem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabelECBState
        '
        Me.LabelECBState.AutoSize = True
        Me.LabelECBState.BackColor = System.Drawing.Color.White
        Me.LabelECBState.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelECBState.ForeColor = System.Drawing.Color.Red
        Me.LabelECBState.Location = New System.Drawing.Point(35, 210)
        Me.LabelECBState.Name = "LabelECBState"
        Me.LabelECBState.Size = New System.Drawing.Size(255, 32)
        Me.LabelECBState.TabIndex = 1
        Me.LabelECBState.Text = "State: Warmup 10:05"
        '
        'lblSN
        '
        Me.lblSN.AutoSize = True
        Me.lblSN.BackColor = System.Drawing.Color.White
        Me.lblSN.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSN.ForeColor = System.Drawing.Color.Black
        Me.lblSN.Location = New System.Drawing.Point(697, 492)
        Me.lblSN.Name = "lblSN"
        Me.lblSN.Size = New System.Drawing.Size(141, 21)
        Me.lblSN.TabIndex = 1
        Me.lblSN.Text = "System SN  H6699"
        '
        'btnResetFault
        '
        Me.btnResetFault.BackColor = System.Drawing.Color.Blue
        Me.btnResetFault.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnResetFault.ForeColor = System.Drawing.Color.Blue
        Me.btnResetFault.Location = New System.Drawing.Point(189, 249)
        Me.btnResetFault.Name = "btnResetFault"
        Me.btnResetFault.Size = New System.Drawing.Size(103, 40)
        Me.btnResetFault.TabIndex = 104
        Me.btnResetFault.Tag = "1"
        Me.btnResetFault.Text = "RESET"
        Me.btnResetFault.UseVisualStyleBackColor = True
        Me.btnResetFault.Visible = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.lblGUIVersionAgile)
        Me.Panel2.Controls.Add(Me.lblSN)
        Me.Panel2.Controls.Add(Me.LabelFirmwareVersion)
        Me.Panel2.Controls.Add(Me.LabelAgileInfo)
        Me.Panel2.Location = New System.Drawing.Point(350, 138)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(947, 652)
        Me.Panel2.TabIndex = 105
        '
        'lblGUIVersionAgile
        '
        Me.lblGUIVersionAgile.AutoSize = True
        Me.lblGUIVersionAgile.BackColor = System.Drawing.Color.White
        Me.lblGUIVersionAgile.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGUIVersionAgile.ForeColor = System.Drawing.Color.Black
        Me.lblGUIVersionAgile.Location = New System.Drawing.Point(697, 533)
        Me.lblGUIVersionAgile.Name = "lblGUIVersionAgile"
        Me.lblGUIVersionAgile.Size = New System.Drawing.Size(115, 21)
        Me.lblGUIVersionAgile.TabIndex = 101
        Me.lblGUIVersionAgile.Text = "GUI Version 02"
        '
        'lblAccessLevel
        '
        Me.lblAccessLevel.AutoSize = True
        Me.lblAccessLevel.BackColor = System.Drawing.Color.White
        Me.lblAccessLevel.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAccessLevel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.lblAccessLevel.Location = New System.Drawing.Point(35, 627)
        Me.lblAccessLevel.Name = "lblAccessLevel"
        Me.lblAccessLevel.Size = New System.Drawing.Size(197, 25)
        Me.lblAccessLevel.TabIndex = 3
        Me.lblAccessLevel.Text = "Access Level:  Service"
        Me.lblAccessLevel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PanelRadLeft
        '
        Me.PanelRadLeft.BackColor = System.Drawing.Color.White
        Me.PanelRadLeft.Controls.Add(Me.PictureBox2)
        Me.PanelRadLeft.Controls.Add(Me.Label106)
        Me.PanelRadLeft.Controls.Add(Me.Label108)
        Me.PanelRadLeft.ForeColor = System.Drawing.Color.White
        Me.PanelRadLeft.Location = New System.Drawing.Point(372, 22)
        Me.PanelRadLeft.Name = "PanelRadLeft"
        Me.PanelRadLeft.Size = New System.Drawing.Size(96, 110)
        Me.PanelRadLeft.TabIndex = 30
        Me.PanelRadLeft.Visible = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.WindowsApplication1.My.Resources.Resources.__FINAL__Radiation_Mono_256
        Me.PictureBox2.Location = New System.Drawing.Point(16, 27)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(59, 59)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 29
        Me.PictureBox2.TabStop = False
        '
        'Label106
        '
        Me.Label106.AutoSize = True
        Me.Label106.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label106.ForeColor = System.Drawing.Color.Red
        Me.Label106.Location = New System.Drawing.Point(13, 84)
        Me.Label106.Name = "Label106"
        Me.Label106.Size = New System.Drawing.Size(64, 21)
        Me.Label106.TabIndex = 30
        Me.Label106.Text = "Hazard"
        '
        'Label108
        '
        Me.Label108.AutoSize = True
        Me.Label108.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label108.ForeColor = System.Drawing.Color.Red
        Me.Label108.Location = New System.Drawing.Point(3, 6)
        Me.Label108.Name = "Label108"
        Me.Label108.Size = New System.Drawing.Size(84, 21)
        Me.Label108.TabIndex = 30
        Me.Label108.Text = "Radiation"
        '
        'PanelRadRight
        '
        Me.PanelRadRight.BackColor = System.Drawing.Color.White
        Me.PanelRadRight.Controls.Add(Me.PictureBox3)
        Me.PanelRadRight.Controls.Add(Me.Label128)
        Me.PanelRadRight.Controls.Add(Me.Label129)
        Me.PanelRadRight.ForeColor = System.Drawing.Color.White
        Me.PanelRadRight.Location = New System.Drawing.Point(907, 22)
        Me.PanelRadRight.Name = "PanelRadRight"
        Me.PanelRadRight.Size = New System.Drawing.Size(96, 110)
        Me.PanelRadRight.TabIndex = 30
        Me.PanelRadRight.Visible = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.WindowsApplication1.My.Resources.Resources.__FINAL__Radiation_Mono_256
        Me.PictureBox3.Location = New System.Drawing.Point(16, 27)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(59, 59)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 29
        Me.PictureBox3.TabStop = False
        '
        'Label128
        '
        Me.Label128.AutoSize = True
        Me.Label128.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label128.ForeColor = System.Drawing.Color.Red
        Me.Label128.Location = New System.Drawing.Point(13, 84)
        Me.Label128.Name = "Label128"
        Me.Label128.Size = New System.Drawing.Size(64, 21)
        Me.Label128.TabIndex = 30
        Me.Label128.Text = "Hazard"
        '
        'Label129
        '
        Me.Label129.AutoSize = True
        Me.Label129.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label129.ForeColor = System.Drawing.Color.Red
        Me.Label129.Location = New System.Drawing.Point(3, 6)
        Me.Label129.Name = "Label129"
        Me.Label129.Size = New System.Drawing.Size(84, 21)
        Me.Label129.TabIndex = 30
        Me.Label129.Text = "Radiation"
        '
        'lblScanMode
        '
        Me.lblScanMode.AutoSize = True
        Me.lblScanMode.BackColor = System.Drawing.Color.White
        Me.lblScanMode.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblScanMode.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.lblScanMode.Location = New System.Drawing.Point(35, 303)
        Me.lblScanMode.Name = "lblScanMode"
        Me.lblScanMode.Size = New System.Drawing.Size(198, 32)
        Me.lblScanMode.TabIndex = 1
        Me.lblScanMode.Text = "Mode: Cab Scan"
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.BackColor = System.Drawing.Color.White
        Me.Label29.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.ForeColor = System.Drawing.Color.Black
        Me.Label29.Location = New System.Drawing.Point(245, 522)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(27, 21)
        Me.Label29.TabIndex = 34
        Me.Label29.Text = "ns"
        '
        'lblDoseRateUnit
        '
        Me.lblDoseRateUnit.AutoSize = True
        Me.lblDoseRateUnit.BackColor = System.Drawing.Color.White
        Me.lblDoseRateUnit.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDoseRateUnit.ForeColor = System.Drawing.Color.Black
        Me.lblDoseRateUnit.Location = New System.Drawing.Point(245, 432)
        Me.lblDoseRateUnit.Name = "lblDoseRateUnit"
        Me.lblDoseRateUnit.Size = New System.Drawing.Size(67, 21)
        Me.lblDoseRateUnit.TabIndex = 34
        Me.lblDoseRateUnit.Text = "Gy/min"
        Me.lblDoseRateUnit.Visible = False
        '
        'lblDoseRate
        '
        Me.lblDoseRate.BackColor = System.Drawing.Color.White
        Me.lblDoseRate.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDoseRate.ForeColor = System.Drawing.Color.Black
        Me.lblDoseRate.Location = New System.Drawing.Point(181, 432)
        Me.lblDoseRate.Name = "lblDoseRate"
        Me.lblDoseRate.Size = New System.Drawing.Size(58, 20)
        Me.lblDoseRate.TabIndex = 37
        Me.lblDoseRate.Text = "0"
        Me.lblDoseRate.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblDoseRate.Visible = False
        '
        'lblPulseFreq
        '
        Me.lblPulseFreq.BackColor = System.Drawing.Color.White
        Me.lblPulseFreq.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPulseFreq.ForeColor = System.Drawing.Color.Black
        Me.lblPulseFreq.Location = New System.Drawing.Point(181, 462)
        Me.lblPulseFreq.Name = "lblPulseFreq"
        Me.lblPulseFreq.Size = New System.Drawing.Size(58, 20)
        Me.lblPulseFreq.TabIndex = 37
        Me.lblPulseFreq.Text = "0"
        Me.lblPulseFreq.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblDoseCommand
        '
        Me.lblDoseCommand.BackColor = System.Drawing.Color.White
        Me.lblDoseCommand.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDoseCommand.ForeColor = System.Drawing.Color.Black
        Me.lblDoseCommand.Location = New System.Drawing.Point(181, 492)
        Me.lblDoseCommand.Name = "lblDoseCommand"
        Me.lblDoseCommand.Size = New System.Drawing.Size(58, 20)
        Me.lblDoseCommand.TabIndex = 37
        Me.lblDoseCommand.Text = "0"
        Me.lblDoseCommand.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.BackColor = System.Drawing.Color.White
        Me.Label32.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.ForeColor = System.Drawing.Color.Black
        Me.Label32.Location = New System.Drawing.Point(245, 462)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(30, 21)
        Me.Label32.TabIndex = 34
        Me.Label32.Text = "Hz"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.BackColor = System.Drawing.Color.White
        Me.Label19.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.Black
        Me.Label19.Location = New System.Drawing.Point(41, 522)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(125, 21)
        Me.Label19.TabIndex = 40
        Me.Label19.Text = "Beam Duration"
        '
        'lblBeamDuration
        '
        Me.lblBeamDuration.BackColor = System.Drawing.Color.White
        Me.lblBeamDuration.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBeamDuration.ForeColor = System.Drawing.Color.Black
        Me.lblBeamDuration.Location = New System.Drawing.Point(181, 522)
        Me.lblBeamDuration.Name = "lblBeamDuration"
        Me.lblBeamDuration.Size = New System.Drawing.Size(58, 20)
        Me.lblBeamDuration.TabIndex = 37
        Me.lblBeamDuration.Text = "0"
        Me.lblBeamDuration.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.BackColor = System.Drawing.Color.White
        Me.Label22.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.Black
        Me.Label22.Location = New System.Drawing.Point(41, 492)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(131, 21)
        Me.Label22.TabIndex = 40
        Me.Label22.Text = "Dose Command"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.BackColor = System.Drawing.Color.White
        Me.Label23.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ForeColor = System.Drawing.Color.Black
        Me.Label23.Location = New System.Drawing.Point(41, 462)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(134, 21)
        Me.Label23.TabIndex = 40
        Me.Label23.Text = "Pulse Frequency"
        '
        'lblDoseRateTitle
        '
        Me.lblDoseRateTitle.AutoSize = True
        Me.lblDoseRateTitle.BackColor = System.Drawing.Color.White
        Me.lblDoseRateTitle.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDoseRateTitle.ForeColor = System.Drawing.Color.Black
        Me.lblDoseRateTitle.Location = New System.Drawing.Point(41, 432)
        Me.lblDoseRateTitle.Name = "lblDoseRateTitle"
        Me.lblDoseRateTitle.Size = New System.Drawing.Size(86, 21)
        Me.lblDoseRateTitle.TabIndex = 40
        Me.lblDoseRateTitle.Text = "Dose Rate"
        Me.lblDoseRateTitle.Visible = False
        '
        'lblIonIi2Unit
        '
        Me.lblIonIi2Unit.AutoSize = True
        Me.lblIonIi2Unit.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIonIi2Unit.ForeColor = System.Drawing.Color.Black
        Me.lblIonIi2Unit.Location = New System.Drawing.Point(245, 552)
        Me.lblIonIi2Unit.Name = "lblIonIi2Unit"
        Me.lblIonIi2Unit.Size = New System.Drawing.Size(31, 21)
        Me.lblIonIi2Unit.TabIndex = 164
        Me.lblIonIi2Unit.Text = "uA"
        Me.lblIonIi2Unit.Visible = False
        '
        'lblIonIi2Title
        '
        Me.lblIonIi2Title.AutoSize = True
        Me.lblIonIi2Title.BackColor = System.Drawing.Color.White
        Me.lblIonIi2Title.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIonIi2Title.ForeColor = System.Drawing.Color.Black
        Me.lblIonIi2Title.Location = New System.Drawing.Point(41, 552)
        Me.lblIonIi2Title.Name = "lblIonIi2Title"
        Me.lblIonIi2Title.Size = New System.Drawing.Size(145, 21)
        Me.lblIonIi2Title.TabIndex = 40
        Me.lblIonIi2Title.Text = "Ion Pump Current"
        Me.lblIonIi2Title.Visible = False
        '
        'lblIonIi2
        '
        Me.lblIonIi2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIonIi2.ForeColor = System.Drawing.Color.Black
        Me.lblIonIi2.Location = New System.Drawing.Point(185, 552)
        Me.lblIonIi2.Name = "lblIonIi2"
        Me.lblIonIi2.Size = New System.Drawing.Size(54, 20)
        Me.lblIonIi2.TabIndex = 170
        Me.lblIonIi2.Text = "0"
        Me.lblIonIi2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblIonIi2.Visible = False
        '
        'lblNoTrigger
        '
        Me.lblNoTrigger.BackColor = System.Drawing.Color.White
        Me.lblNoTrigger.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNoTrigger.ForeColor = System.Drawing.Color.Black
        Me.lblNoTrigger.Location = New System.Drawing.Point(174, 356)
        Me.lblNoTrigger.Name = "lblNoTrigger"
        Me.lblNoTrigger.Size = New System.Drawing.Size(116, 22)
        Me.lblNoTrigger.TabIndex = 37
        Me.lblNoTrigger.Text = "No Trigger"
        Me.lblNoTrigger.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblShowDumpData
        '
        Me.lblShowDumpData.AutoSize = True
        Me.lblShowDumpData.BackColor = System.Drawing.Color.White
        Me.lblShowDumpData.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblShowDumpData.ForeColor = System.Drawing.Color.Red
        Me.lblShowDumpData.Location = New System.Drawing.Point(35, 161)
        Me.lblShowDumpData.Name = "lblShowDumpData"
        Me.lblShowDumpData.Size = New System.Drawing.Size(291, 32)
        Me.lblShowDumpData.TabIndex = 1
        Me.lblShowDumpData.Text = "Show Dump Data Active"
        Me.lblShowDumpData.Visible = False
        '
        'TabBoards
        '
        Me.TabBoards.Alignment = System.Windows.Forms.TabAlignment.Right
        Me.TabBoards.Controls.Add(Me.TabPageOverview)
        Me.TabBoards.Controls.Add(Me.TabPageCPU)
        Me.TabBoards.Controls.Add(Me.TabPageGunDriver)
        Me.TabBoards.Controls.Add(Me.TabPageCooling)
        Me.TabBoards.Controls.Add(Me.TabPagePulseSync)
        Me.TabBoards.Controls.Add(Me.TabPageHVsupply)
        Me.TabBoards.Controls.Add(Me.TabPageMagnetron)
        Me.TabBoards.Controls.Add(Me.TabPageAFC)
        Me.TabBoards.Controls.Add(Me.TabPageMagnetrHtr)
        Me.TabBoards.Controls.Add(Me.TabPageIonPump)
        Me.TabBoards.Controls.Add(Me.TabPageService)
        Me.TabBoards.Controls.Add(Me.TabPageServicePanel)
        Me.TabBoards.Controls.Add(Me.tabPageDeveloper)
        Me.TabBoards.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed
        Me.TabBoards.ItemSize = New System.Drawing.Size(20, 100)
        Me.TabBoards.Location = New System.Drawing.Point(350, 138)
        Me.TabBoards.Multiline = True
        Me.TabBoards.Name = "TabBoards"
        Me.TabBoards.SelectedIndex = 0
        Me.TabBoards.SimpleMode = True
        Me.TabBoards.SimpleModeInDesign = False
        Me.TabBoards.Size = New System.Drawing.Size(680, 580)
        Me.TabBoards.SizeMode = System.Windows.Forms.TabSizeMode.Fixed
        Me.TabBoards.TabIndex = 3
        '
        'TabPageOverview
        '
        Me.TabPageOverview.BackColor = System.Drawing.SystemColors.Control
        Me.TabPageOverview.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TabPageOverview.Controls.Add(Me.Label283)
        Me.TabPageOverview.Controls.Add(Me.Label4)
        Me.TabPageOverview.Controls.Add(Me.Label277)
        Me.TabPageOverview.Controls.Add(Me.Label173)
        Me.TabPageOverview.Controls.Add(Me.Label276)
        Me.TabPageOverview.Controls.Add(Me.Label240)
        Me.TabPageOverview.Controls.Add(Me.Label279)
        Me.TabPageOverview.Controls.Add(Me.Label272)
        Me.TabPageOverview.Controls.Add(Me.lblCoolTemp)
        Me.TabPageOverview.Controls.Add(Me.lblCabTemp)
        Me.TabPageOverview.Controls.Add(Me.lblGdTemp)
        Me.TabPageOverview.Controls.Add(Me.lblSF6Pressure)
        Me.TabPageOverview.Controls.Add(Me.lblAutofillRemain1)
        Me.TabPageOverview.Controls.Add(Me.Label123)
        Me.TabPageOverview.Controls.Add(Me.Label213)
        Me.TabPageOverview.Controls.Add(Me.btnReenableAutofill1)
        Me.TabPageOverview.Controls.Add(Me.Label134)
        Me.TabPageOverview.Controls.Add(Me.Label159)
        Me.TabPageOverview.Controls.Add(Me.Label180)
        Me.TabPageOverview.Controls.Add(Me.Meter)
        Me.TabPageOverview.Controls.Add(Me.BlueRect15)
        Me.TabPageOverview.ForeColor = System.Drawing.Color.White
        Me.TabPageOverview.Location = New System.Drawing.Point(0, 0)
        Me.TabPageOverview.Name = "TabPageOverview"
        Me.TabPageOverview.Size = New System.Drawing.Size(680, 580)
        Me.TabPageOverview.TabIndex = 11
        Me.TabPageOverview.Text = "TabPage1"
        '
        'Label283
        '
        Me.Label283.AutoSize = True
        Me.Label283.BackColor = System.Drawing.SystemColors.Control
        Me.Label283.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label283.ForeColor = System.Drawing.Color.Black
        Me.Label283.Location = New System.Drawing.Point(461, 219)
        Me.Label283.Name = "Label283"
        Me.Label283.Size = New System.Drawing.Size(32, 21)
        Me.Label283.TabIndex = 101
        Me.Label283.Text = "psi"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.SystemColors.Control
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(194, 129)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(117, 21)
        Me.Label4.TabIndex = 111
        Me.Label4.Text = "Coolant Temp"
        '
        'Label277
        '
        Me.Label277.AutoSize = True
        Me.Label277.BackColor = System.Drawing.SystemColors.Control
        Me.Label277.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label277.ForeColor = System.Drawing.Color.Black
        Me.Label277.Location = New System.Drawing.Point(194, 159)
        Me.Label277.Name = "Label277"
        Me.Label277.Size = New System.Drawing.Size(116, 21)
        Me.Label277.TabIndex = 112
        Me.Label277.Text = "Cabinet Temp"
        '
        'Label173
        '
        Me.Label173.AutoSize = True
        Me.Label173.BackColor = System.Drawing.SystemColors.Control
        Me.Label173.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label173.ForeColor = System.Drawing.Color.Black
        Me.Label173.Location = New System.Drawing.Point(461, 189)
        Me.Label173.Name = "Label173"
        Me.Label173.Size = New System.Drawing.Size(20, 21)
        Me.Label173.TabIndex = 102
        Me.Label173.Text = "C"
        '
        'Label276
        '
        Me.Label276.AutoSize = True
        Me.Label276.BackColor = System.Drawing.SystemColors.Control
        Me.Label276.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label276.ForeColor = System.Drawing.Color.Black
        Me.Label276.Location = New System.Drawing.Point(194, 189)
        Me.Label276.Name = "Label276"
        Me.Label276.Size = New System.Drawing.Size(139, 21)
        Me.Label276.TabIndex = 109
        Me.Label276.Text = "Gun Driver Temp"
        '
        'Label240
        '
        Me.Label240.AutoSize = True
        Me.Label240.BackColor = System.Drawing.SystemColors.Control
        Me.Label240.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label240.ForeColor = System.Drawing.Color.Black
        Me.Label240.Location = New System.Drawing.Point(461, 129)
        Me.Label240.Name = "Label240"
        Me.Label240.Size = New System.Drawing.Size(20, 21)
        Me.Label240.TabIndex = 103
        Me.Label240.Text = "C"
        '
        'Label279
        '
        Me.Label279.AutoSize = True
        Me.Label279.BackColor = System.Drawing.SystemColors.Control
        Me.Label279.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label279.ForeColor = System.Drawing.Color.Black
        Me.Label279.Location = New System.Drawing.Point(194, 219)
        Me.Label279.Name = "Label279"
        Me.Label279.Size = New System.Drawing.Size(104, 21)
        Me.Label279.TabIndex = 110
        Me.Label279.Text = "SF6 Pressure"
        '
        'Label272
        '
        Me.Label272.AutoSize = True
        Me.Label272.BackColor = System.Drawing.SystemColors.Control
        Me.Label272.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label272.ForeColor = System.Drawing.Color.Black
        Me.Label272.Location = New System.Drawing.Point(461, 159)
        Me.Label272.Name = "Label272"
        Me.Label272.Size = New System.Drawing.Size(20, 21)
        Me.Label272.TabIndex = 104
        Me.Label272.Text = "C"
        '
        'lblCoolTemp
        '
        Me.lblCoolTemp.BackColor = System.Drawing.SystemColors.Control
        Me.lblCoolTemp.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCoolTemp.ForeColor = System.Drawing.Color.Black
        Me.lblCoolTemp.Location = New System.Drawing.Point(366, 129)
        Me.lblCoolTemp.Name = "lblCoolTemp"
        Me.lblCoolTemp.Size = New System.Drawing.Size(87, 20)
        Me.lblCoolTemp.TabIndex = 108
        Me.lblCoolTemp.Text = "30.0"
        Me.lblCoolTemp.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblCabTemp
        '
        Me.lblCabTemp.BackColor = System.Drawing.SystemColors.Control
        Me.lblCabTemp.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCabTemp.ForeColor = System.Drawing.Color.Black
        Me.lblCabTemp.Location = New System.Drawing.Point(367, 159)
        Me.lblCabTemp.Name = "lblCabTemp"
        Me.lblCabTemp.Size = New System.Drawing.Size(87, 20)
        Me.lblCabTemp.TabIndex = 105
        Me.lblCabTemp.Text = "30.0"
        Me.lblCabTemp.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblGdTemp
        '
        Me.lblGdTemp.BackColor = System.Drawing.SystemColors.Control
        Me.lblGdTemp.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGdTemp.ForeColor = System.Drawing.Color.Black
        Me.lblGdTemp.Location = New System.Drawing.Point(367, 189)
        Me.lblGdTemp.Name = "lblGdTemp"
        Me.lblGdTemp.Size = New System.Drawing.Size(87, 20)
        Me.lblGdTemp.TabIndex = 106
        Me.lblGdTemp.Text = "30.0"
        Me.lblGdTemp.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblSF6Pressure
        '
        Me.lblSF6Pressure.BackColor = System.Drawing.SystemColors.Control
        Me.lblSF6Pressure.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSF6Pressure.ForeColor = System.Drawing.Color.Black
        Me.lblSF6Pressure.Location = New System.Drawing.Point(367, 219)
        Me.lblSF6Pressure.Name = "lblSF6Pressure"
        Me.lblSF6Pressure.Size = New System.Drawing.Size(87, 20)
        Me.lblSF6Pressure.TabIndex = 107
        Me.lblSF6Pressure.Text = "40.0"
        Me.lblSF6Pressure.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblAutofillRemain1
        '
        Me.lblAutofillRemain1.AutoSize = True
        Me.lblAutofillRemain1.BackColor = System.Drawing.SystemColors.Control
        Me.lblAutofillRemain1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAutofillRemain1.ForeColor = System.Drawing.Color.Black
        Me.lblAutofillRemain1.Location = New System.Drawing.Point(551, 427)
        Me.lblAutofillRemain1.Name = "lblAutofillRemain1"
        Me.lblAutofillRemain1.Size = New System.Drawing.Size(37, 21)
        Me.lblAutofillRemain1.TabIndex = 99
        Me.lblAutofillRemain1.Text = "200"
        '
        'Label123
        '
        Me.Label123.AutoSize = True
        Me.Label123.BackColor = System.Drawing.SystemColors.Control
        Me.Label123.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label123.ForeColor = System.Drawing.Color.Black
        Me.Label123.Location = New System.Drawing.Point(386, 427)
        Me.Label123.Name = "Label123"
        Me.Label123.Size = New System.Drawing.Size(163, 21)
        Me.Label123.TabIndex = 99
        Me.Label123.Text = "Autofill Remaining: "
        '
        'Label213
        '
        Me.Label213.AutoSize = True
        Me.Label213.BackColor = System.Drawing.SystemColors.Control
        Me.Label213.Font = New System.Drawing.Font("Segoe UI Semibold", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label213.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.Label213.Location = New System.Drawing.Point(210, 11)
        Me.Label213.Name = "Label213"
        Me.Label213.Size = New System.Drawing.Size(267, 45)
        Me.Label213.TabIndex = 92
        Me.Label213.Text = "System Overview"
        '
        'btnReenableAutofill1
        '
        Me.btnReenableAutofill1.BackColor = System.Drawing.Color.Blue
        Me.btnReenableAutofill1.Enabled = False
        Me.btnReenableAutofill1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReenableAutofill1.ForeColor = System.Drawing.Color.Blue
        Me.btnReenableAutofill1.Location = New System.Drawing.Point(390, 465)
        Me.btnReenableAutofill1.Name = "btnReenableAutofill1"
        Me.btnReenableAutofill1.Size = New System.Drawing.Size(190, 34)
        Me.btnReenableAutofill1.TabIndex = 88
        Me.btnReenableAutofill1.Tag = "1"
        Me.btnReenableAutofill1.Text = "Re-enable Autofill"
        Me.btnReenableAutofill1.UseVisualStyleBackColor = True
        '
        'Label134
        '
        Me.Label134.AutoSize = True
        Me.Label134.BackColor = System.Drawing.SystemColors.Control
        Me.Label134.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label134.ForeColor = System.Drawing.Color.Black
        Me.Label134.Location = New System.Drawing.Point(287, 485)
        Me.Label134.Name = "Label134"
        Me.Label134.Size = New System.Drawing.Size(13, 13)
        Me.Label134.TabIndex = 83
        Me.Label134.Text = "F"
        '
        'Label159
        '
        Me.Label159.AutoSize = True
        Me.Label159.BackColor = System.Drawing.SystemColors.Control
        Me.Label159.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label159.ForeColor = System.Drawing.Color.Black
        Me.Label159.Location = New System.Drawing.Point(120, 485)
        Me.Label159.Name = "Label159"
        Me.Label159.Size = New System.Drawing.Size(13, 13)
        Me.Label159.TabIndex = 84
        Me.Label159.Text = "E"
        '
        'Label180
        '
        Me.Label180.AutoSize = True
        Me.Label180.BackColor = System.Drawing.SystemColors.Control
        Me.Label180.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label180.ForeColor = System.Drawing.Color.Black
        Me.Label180.Location = New System.Drawing.Point(171, 395)
        Me.Label180.Name = "Label180"
        Me.Label180.Size = New System.Drawing.Size(80, 21)
        Me.Label180.TabIndex = 86
        Me.Label180.Text = "SF6 Level"
        '
        'Meter
        '
        Me.Meter.BackColor = System.Drawing.SystemColors.Control
        Me.Meter.ForeColor = System.Drawing.Color.Black
        Me.Meter.HeightWidthRatio = 0.6!
        Me.Meter.Location = New System.Drawing.Point(110, 389)
        Me.Meter.MarkCount = 4
        Me.Meter.MaxValue = 700
        Me.Meter.Name = "Meter"
        Me.Meter.PointerColor = System.Drawing.Color.Red
        Me.Meter.ScaleColor = System.Drawing.Color.Black
        Me.Meter.ScaleWidth = 1.0!
        Me.Meter.Size = New System.Drawing.Size(200, 120)
        Me.Meter.TabIndex = 82
        Me.Meter.TopSpaceWidthRatio = 0.18!
        Me.Meter.Value = 200
        '
        'BlueRect15
        '
        Me.BlueRect15.Enabled = False
        Me.BlueRect15.Location = New System.Drawing.Point(72, 70)
        Me.BlueRect15.MyBorderColor = System.Drawing.Color.Black
        Me.BlueRect15.MyBorderWidth = 0.001!
        Me.BlueRect15.Name = "BlueRect15"
        Me.BlueRect15.Size = New System.Drawing.Size(536, 239)
        Me.BlueRect15.TabIndex = 113
        '
        'TabPageCPU
        '
        Me.TabPageCPU.BackColor = System.Drawing.SystemColors.Control
        Me.TabPageCPU.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TabPageCPU.Controls.Add(Me.ledWCpuXrayDisabled)
        Me.TabPageCPU.Controls.Add(Me.ledWCpuDriveupTimeout)
        Me.TabPageCPU.Controls.Add(Me.ledCpuReadyFault)
        Me.TabPageCPU.Controls.Add(Me.Label50)
        Me.TabPageCPU.Controls.Add(Me.Label35)
        Me.TabPageCPU.Controls.Add(Me.ledCpuXrayLogic)
        Me.TabPageCPU.Controls.Add(Me.Label38)
        Me.TabPageCPU.Controls.Add(Me.Label119)
        Me.TabPageCPU.Controls.Add(Me.Label33)
        Me.TabPageCPU.Controls.Add(Me.Label34)
        Me.TabPageCPU.Controls.Add(Me.Label57)
        Me.TabPageCPU.Controls.Add(Me.Label39)
        Me.TabPageCPU.Controls.Add(Me.Label51)
        Me.TabPageCPU.Controls.Add(Me.Label40)
        Me.TabPageCPU.Controls.Add(Me.lblCpuWarmupThy)
        Me.TabPageCPU.Controls.Add(Me.Label41)
        Me.TabPageCPU.Controls.Add(Me.lblCpuWarmupMag)
        Me.TabPageCPU.Controls.Add(Me.lblCpuPwrOnTime)
        Me.TabPageCPU.Controls.Add(Me.lblCpuHvTime)
        Me.TabPageCPU.Controls.Add(Me.Label52)
        Me.TabPageCPU.Controls.Add(Me.lblCpuMagnetronPwr)
        Me.TabPageCPU.Controls.Add(Me.lblCpuWarmupGd)
        Me.TabPageCPU.Controls.Add(Me.Label43)
        Me.TabPageCPU.Controls.Add(Me.lblCpuXrayTime)
        Me.TabPageCPU.Controls.Add(Me.BlueRect7)
        Me.TabPageCPU.ForeColor = System.Drawing.Color.Black
        Me.TabPageCPU.Location = New System.Drawing.Point(0, 0)
        Me.TabPageCPU.Name = "TabPageCPU"
        Me.TabPageCPU.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageCPU.Size = New System.Drawing.Size(680, 580)
        Me.TabPageCPU.TabIndex = 1
        Me.TabPageCPU.Text = "TabPage2"
        '
        'ledWCpuXrayDisabled
        '
        Me.ledWCpuXrayDisabled.FillColor = System.Drawing.SystemColors.Control
        Me.ledWCpuXrayDisabled.ForeColor = System.Drawing.Color.Black
        Me.ledWCpuXrayDisabled.Location = New System.Drawing.Point(373, 360)
        Me.ledWCpuXrayDisabled.MyBorderColor = System.Drawing.Color.Black
        Me.ledWCpuXrayDisabled.MyBorderWidth = 2
        Me.ledWCpuXrayDisabled.Name = "ledWCpuXrayDisabled"
        Me.ledWCpuXrayDisabled.Size = New System.Drawing.Size(18, 20)
        Me.ledWCpuXrayDisabled.TabIndex = 33
        '
        'ledWCpuDriveupTimeout
        '
        Me.ledWCpuDriveupTimeout.FillColor = System.Drawing.SystemColors.Control
        Me.ledWCpuDriveupTimeout.ForeColor = System.Drawing.Color.White
        Me.ledWCpuDriveupTimeout.Location = New System.Drawing.Point(373, 391)
        Me.ledWCpuDriveupTimeout.MyBorderColor = System.Drawing.Color.Black
        Me.ledWCpuDriveupTimeout.MyBorderWidth = 2
        Me.ledWCpuDriveupTimeout.Name = "ledWCpuDriveupTimeout"
        Me.ledWCpuDriveupTimeout.Size = New System.Drawing.Size(18, 20)
        Me.ledWCpuDriveupTimeout.TabIndex = 33
        '
        'ledCpuReadyFault
        '
        Me.ledCpuReadyFault.FillColor = System.Drawing.Color.LawnGreen
        Me.ledCpuReadyFault.ForeColor = System.Drawing.Color.White
        Me.ledCpuReadyFault.Location = New System.Drawing.Point(137, 392)
        Me.ledCpuReadyFault.MyBorderColor = System.Drawing.Color.Black
        Me.ledCpuReadyFault.MyBorderWidth = 2
        Me.ledCpuReadyFault.Name = "ledCpuReadyFault"
        Me.ledCpuReadyFault.Size = New System.Drawing.Size(18, 20)
        Me.ledCpuReadyFault.TabIndex = 33
        '
        'Label50
        '
        Me.Label50.AutoSize = True
        Me.Label50.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label50.ForeColor = System.Drawing.Color.Black
        Me.Label50.Location = New System.Drawing.Point(543, 87)
        Me.Label50.Name = "Label50"
        Me.Label50.Size = New System.Drawing.Size(35, 21)
        Me.Label50.TabIndex = 34
        Me.Label50.Text = "kW"
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label35.ForeColor = System.Drawing.Color.Black
        Me.Label35.Location = New System.Drawing.Point(397, 360)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(125, 21)
        Me.Label35.TabIndex = 32
        Me.Label35.Text = "X-Ray Disabled"
        '
        'ledCpuXrayLogic
        '
        Me.ledCpuXrayLogic.FillColor = System.Drawing.Color.LawnGreen
        Me.ledCpuXrayLogic.ForeColor = System.Drawing.Color.White
        Me.ledCpuXrayLogic.Location = New System.Drawing.Point(137, 360)
        Me.ledCpuXrayLogic.MyBorderColor = System.Drawing.Color.Black
        Me.ledCpuXrayLogic.MyBorderWidth = 2
        Me.ledCpuXrayLogic.Name = "ledCpuXrayLogic"
        Me.ledCpuXrayLogic.Size = New System.Drawing.Size(18, 20)
        Me.ledCpuXrayLogic.TabIndex = 33
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label38.ForeColor = System.Drawing.Color.Black
        Me.Label38.Location = New System.Drawing.Point(397, 391)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(145, 21)
        Me.Label38.TabIndex = 32
        Me.Label38.Text = "Drive Up Timeout"
        '
        'Label119
        '
        Me.Label119.AutoSize = True
        Me.Label119.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label119.ForeColor = System.Drawing.Color.Black
        Me.Label119.Location = New System.Drawing.Point(161, 391)
        Me.Label119.Name = "Label119"
        Me.Label119.Size = New System.Drawing.Size(99, 21)
        Me.Label119.TabIndex = 32
        Me.Label119.Text = "Ready Fault"
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label33.ForeColor = System.Drawing.Color.Black
        Me.Label33.Location = New System.Drawing.Point(161, 360)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(99, 21)
        Me.Label33.TabIndex = 32
        Me.Label33.Text = "X-Ray Logic"
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.BackColor = System.Drawing.SystemColors.Control
        Me.Label34.Font = New System.Drawing.Font("Segoe UI Semibold", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label34.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.Label34.Location = New System.Drawing.Point(242, 11)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(195, 45)
        Me.Label34.TabIndex = 1
        Me.Label34.Text = "System CPU"
        '
        'Label57
        '
        Me.Label57.AutoSize = True
        Me.Label57.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label57.ForeColor = System.Drawing.Color.Black
        Me.Label57.Location = New System.Drawing.Point(112, 187)
        Me.Label57.Name = "Label57"
        Me.Label57.Size = New System.Drawing.Size(242, 21)
        Me.Label57.TabIndex = 40
        Me.Label57.Text = "Thyratron Warmup Remaining"
        '
        'Label39
        '
        Me.Label39.AutoSize = True
        Me.Label39.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label39.ForeColor = System.Drawing.Color.Black
        Me.Label39.Location = New System.Drawing.Point(112, 112)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(126, 21)
        Me.Label39.TabIndex = 40
        Me.Label39.Text = "Power On Time"
        '
        'Label51
        '
        Me.Label51.AutoSize = True
        Me.Label51.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label51.ForeColor = System.Drawing.Color.Black
        Me.Label51.Location = New System.Drawing.Point(112, 237)
        Me.Label51.Name = "Label51"
        Me.Label51.Size = New System.Drawing.Size(249, 21)
        Me.Label51.TabIndex = 40
        Me.Label51.Text = "Gun Driver Warmup Remaining"
        '
        'Label40
        '
        Me.Label40.AutoSize = True
        Me.Label40.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label40.ForeColor = System.Drawing.Color.Black
        Me.Label40.Location = New System.Drawing.Point(112, 87)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(147, 21)
        Me.Label40.TabIndex = 40
        Me.Label40.Text = "Magnetron Power"
        '
        'lblCpuWarmupThy
        '
        Me.lblCpuWarmupThy.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCpuWarmupThy.ForeColor = System.Drawing.Color.Black
        Me.lblCpuWarmupThy.Location = New System.Drawing.Point(406, 188)
        Me.lblCpuWarmupThy.Name = "lblCpuWarmupThy"
        Me.lblCpuWarmupThy.Size = New System.Drawing.Size(131, 20)
        Me.lblCpuWarmupThy.TabIndex = 37
        Me.lblCpuWarmupThy.Text = "0"
        Me.lblCpuWarmupThy.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label41
        '
        Me.Label41.AutoSize = True
        Me.Label41.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label41.ForeColor = System.Drawing.Color.Black
        Me.Label41.Location = New System.Drawing.Point(112, 162)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(122, 21)
        Me.Label41.TabIndex = 40
        Me.Label41.Text = "X-Ray On Time"
        '
        'lblCpuWarmupMag
        '
        Me.lblCpuWarmupMag.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCpuWarmupMag.ForeColor = System.Drawing.Color.Black
        Me.lblCpuWarmupMag.Location = New System.Drawing.Point(406, 214)
        Me.lblCpuWarmupMag.Name = "lblCpuWarmupMag"
        Me.lblCpuWarmupMag.Size = New System.Drawing.Size(131, 20)
        Me.lblCpuWarmupMag.TabIndex = 37
        Me.lblCpuWarmupMag.Text = "0"
        Me.lblCpuWarmupMag.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblCpuPwrOnTime
        '
        Me.lblCpuPwrOnTime.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCpuPwrOnTime.ForeColor = System.Drawing.Color.Black
        Me.lblCpuPwrOnTime.Location = New System.Drawing.Point(282, 113)
        Me.lblCpuPwrOnTime.Name = "lblCpuPwrOnTime"
        Me.lblCpuPwrOnTime.Size = New System.Drawing.Size(255, 20)
        Me.lblCpuPwrOnTime.TabIndex = 37
        Me.lblCpuPwrOnTime.Text = "0"
        Me.lblCpuPwrOnTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblCpuHvTime
        '
        Me.lblCpuHvTime.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCpuHvTime.ForeColor = System.Drawing.Color.Black
        Me.lblCpuHvTime.Location = New System.Drawing.Point(282, 138)
        Me.lblCpuHvTime.Name = "lblCpuHvTime"
        Me.lblCpuHvTime.Size = New System.Drawing.Size(255, 20)
        Me.lblCpuHvTime.TabIndex = 37
        Me.lblCpuHvTime.Text = "0"
        Me.lblCpuHvTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label52
        '
        Me.Label52.AutoSize = True
        Me.Label52.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label52.ForeColor = System.Drawing.Color.Black
        Me.Label52.Location = New System.Drawing.Point(112, 212)
        Me.Label52.Name = "Label52"
        Me.Label52.Size = New System.Drawing.Size(252, 21)
        Me.Label52.TabIndex = 40
        Me.Label52.Text = "Magnetron Warmup Remaining"
        '
        'lblCpuMagnetronPwr
        '
        Me.lblCpuMagnetronPwr.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCpuMagnetronPwr.ForeColor = System.Drawing.Color.Black
        Me.lblCpuMagnetronPwr.Location = New System.Drawing.Point(406, 88)
        Me.lblCpuMagnetronPwr.Name = "lblCpuMagnetronPwr"
        Me.lblCpuMagnetronPwr.Size = New System.Drawing.Size(131, 20)
        Me.lblCpuMagnetronPwr.TabIndex = 37
        Me.lblCpuMagnetronPwr.Text = "0"
        Me.lblCpuMagnetronPwr.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblCpuWarmupGd
        '
        Me.lblCpuWarmupGd.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCpuWarmupGd.ForeColor = System.Drawing.Color.Black
        Me.lblCpuWarmupGd.Location = New System.Drawing.Point(406, 240)
        Me.lblCpuWarmupGd.Name = "lblCpuWarmupGd"
        Me.lblCpuWarmupGd.Size = New System.Drawing.Size(131, 20)
        Me.lblCpuWarmupGd.TabIndex = 37
        Me.lblCpuWarmupGd.Text = "0"
        Me.lblCpuWarmupGd.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label43
        '
        Me.Label43.AutoSize = True
        Me.Label43.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label43.ForeColor = System.Drawing.Color.Black
        Me.Label43.Location = New System.Drawing.Point(112, 137)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(101, 21)
        Me.Label43.TabIndex = 40
        Me.Label43.Text = "HV On Time"
        '
        'lblCpuXrayTime
        '
        Me.lblCpuXrayTime.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCpuXrayTime.ForeColor = System.Drawing.Color.Black
        Me.lblCpuXrayTime.Location = New System.Drawing.Point(282, 163)
        Me.lblCpuXrayTime.Name = "lblCpuXrayTime"
        Me.lblCpuXrayTime.Size = New System.Drawing.Size(255, 20)
        Me.lblCpuXrayTime.TabIndex = 37
        Me.lblCpuXrayTime.Text = "0"
        Me.lblCpuXrayTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'BlueRect7
        '
        Me.BlueRect7.Enabled = False
        Me.BlueRect7.Location = New System.Drawing.Point(53, 60)
        Me.BlueRect7.MyBorderColor = System.Drawing.Color.Black
        Me.BlueRect7.MyBorderWidth = 0.001!
        Me.BlueRect7.Name = "BlueRect7"
        Me.BlueRect7.Size = New System.Drawing.Size(569, 232)
        Me.BlueRect7.TabIndex = 106
        '
        'TabPageGunDriver
        '
        Me.TabPageGunDriver.BackColor = System.Drawing.SystemColors.Control
        Me.TabPageGunDriver.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TabPageGunDriver.Controls.Add(Me.btnGdEgsetCab)
        Me.TabPageGunDriver.Controls.Add(Me.btnGdEgsetCargo)
        Me.TabPageGunDriver.Controls.Add(Me.btnGdIfSet)
        Me.TabPageGunDriver.Controls.Add(Me.btnGdEkset)
        Me.TabPageGunDriver.Controls.Add(Me.Label65)
        Me.TabPageGunDriver.Controls.Add(Me.ledGdHtrStartup)
        Me.TabPageGunDriver.Controls.Add(Me.ledGdCAN)
        Me.TabPageGunDriver.Controls.Add(Me.ledGdADCread)
        Me.TabPageGunDriver.Controls.Add(Me.ledGdEgMon)
        Me.TabPageGunDriver.Controls.Add(Me.ledGdArc)
        Me.TabPageGunDriver.Controls.Add(Me.ledGdHVmon)
        Me.TabPageGunDriver.Controls.Add(Me.ledGdSPIcomm)
        Me.TabPageGunDriver.Controls.Add(Me.ledGdEcMon)
        Me.TabPageGunDriver.Controls.Add(Me.ledGdOT)
        Me.TabPageGunDriver.Controls.Add(Me.ledGdHtrMon)
        Me.TabPageGunDriver.Controls.Add(Me.ledGdGrid)
        Me.TabPageGunDriver.Controls.Add(Me.ledGdHtrOC)
        Me.TabPageGunDriver.Controls.Add(Me.Label104)
        Me.TabPageGunDriver.Controls.Add(Me.ledGdFPGArev)
        Me.TabPageGunDriver.Controls.Add(Me.Label96)
        Me.TabPageGunDriver.Controls.Add(Me.Label102)
        Me.TabPageGunDriver.Controls.Add(Me.Label101)
        Me.TabPageGunDriver.Controls.Add(Me.Label95)
        Me.TabPageGunDriver.Controls.Add(Me.Label100)
        Me.TabPageGunDriver.Controls.Add(Me.Label94)
        Me.TabPageGunDriver.Controls.Add(Me.Label99)
        Me.TabPageGunDriver.Controls.Add(Me.Label91)
        Me.TabPageGunDriver.Controls.Add(Me.Label98)
        Me.TabPageGunDriver.Controls.Add(Me.Label93)
        Me.TabPageGunDriver.Controls.Add(Me.Label90)
        Me.TabPageGunDriver.Controls.Add(Me.Label61)
        Me.TabPageGunDriver.Controls.Add(Me.Label89)
        Me.TabPageGunDriver.Controls.Add(Me.Label86)
        Me.TabPageGunDriver.Controls.Add(Me.Label83)
        Me.TabPageGunDriver.Controls.Add(Me.Label80)
        Me.TabPageGunDriver.Controls.Add(Me.Label77)
        Me.TabPageGunDriver.Controls.Add(Me.Label62)
        Me.TabPageGunDriver.Controls.Add(Me.Label88)
        Me.TabPageGunDriver.Controls.Add(Me.lblGdEc)
        Me.TabPageGunDriver.Controls.Add(Me.Label85)
        Me.TabPageGunDriver.Controls.Add(Me.lblGdEg)
        Me.TabPageGunDriver.Controls.Add(Me.Label82)
        Me.TabPageGunDriver.Controls.Add(Me.lblGdIf)
        Me.TabPageGunDriver.Controls.Add(Me.Label79)
        Me.TabPageGunDriver.Controls.Add(Me.lblGdEf)
        Me.TabPageGunDriver.Controls.Add(Me.Label76)
        Me.TabPageGunDriver.Controls.Add(Me.lblGdIkp)
        Me.TabPageGunDriver.Controls.Add(Me.Label63)
        Me.TabPageGunDriver.Controls.Add(Me.lblGdEk)
        Me.TabPageGunDriver.Controls.Add(Me.BlueRect4)
        Me.TabPageGunDriver.ForeColor = System.Drawing.Color.White
        Me.TabPageGunDriver.Location = New System.Drawing.Point(0, 0)
        Me.TabPageGunDriver.Name = "TabPageGunDriver"
        Me.TabPageGunDriver.Size = New System.Drawing.Size(680, 580)
        Me.TabPageGunDriver.TabIndex = 2
        Me.TabPageGunDriver.Text = "TabPage1"
        '
        'btnGdEgsetCab
        '
        Me.btnGdEgsetCab.BackColor = System.Drawing.Color.Blue
        Me.btnGdEgsetCab.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGdEgsetCab.ForeColor = System.Drawing.Color.Blue
        Me.btnGdEgsetCab.Location = New System.Drawing.Point(384, 223)
        Me.btnGdEgsetCab.Name = "btnGdEgsetCab"
        Me.btnGdEgsetCab.Size = New System.Drawing.Size(220, 34)
        Me.btnGdEgsetCab.TabIndex = 79
        Me.btnGdEgsetCab.Tag = "1"
        Me.btnGdEgsetCab.Text = "Cab Eg Set        0.0V"
        Me.btnGdEgsetCab.UseVisualStyleBackColor = True
        '
        'btnGdEgsetCargo
        '
        Me.btnGdEgsetCargo.BackColor = System.Drawing.Color.Blue
        Me.btnGdEgsetCargo.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGdEgsetCargo.ForeColor = System.Drawing.Color.Blue
        Me.btnGdEgsetCargo.Location = New System.Drawing.Point(384, 178)
        Me.btnGdEgsetCargo.Name = "btnGdEgsetCargo"
        Me.btnGdEgsetCargo.Size = New System.Drawing.Size(220, 34)
        Me.btnGdEgsetCargo.TabIndex = 79
        Me.btnGdEgsetCargo.Tag = "1"
        Me.btnGdEgsetCargo.Text = "Cargo Eg Set     0.0V"
        Me.btnGdEgsetCargo.UseVisualStyleBackColor = True
        '
        'btnGdIfSet
        '
        Me.btnGdIfSet.BackColor = System.Drawing.Color.Blue
        Me.btnGdIfSet.Enabled = False
        Me.btnGdIfSet.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGdIfSet.ForeColor = System.Drawing.Color.Blue
        Me.btnGdIfSet.Location = New System.Drawing.Point(384, 133)
        Me.btnGdIfSet.Name = "btnGdIfSet"
        Me.btnGdIfSet.Size = New System.Drawing.Size(220, 34)
        Me.btnGdIfSet.TabIndex = 79
        Me.btnGdIfSet.Tag = "1"
        Me.btnGdIfSet.Text = "If Set           0.00A"
        Me.btnGdIfSet.UseVisualStyleBackColor = True
        '
        'btnGdEkset
        '
        Me.btnGdEkset.BackColor = System.Drawing.Color.Blue
        Me.btnGdEkset.Enabled = False
        Me.btnGdEkset.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGdEkset.ForeColor = System.Drawing.Color.Blue
        Me.btnGdEkset.Location = New System.Drawing.Point(384, 88)
        Me.btnGdEkset.Name = "btnGdEkset"
        Me.btnGdEkset.Size = New System.Drawing.Size(220, 34)
        Me.btnGdEkset.TabIndex = 79
        Me.btnGdEkset.Tag = "1"
        Me.btnGdEkset.Text = "Ek Set         0.00kV"
        Me.btnGdEkset.UseVisualStyleBackColor = True
        '
        'Label65
        '
        Me.Label65.AutoSize = True
        Me.Label65.BackColor = System.Drawing.SystemColors.Control
        Me.Label65.Font = New System.Drawing.Font("Segoe UI Semibold", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label65.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.Label65.Location = New System.Drawing.Point(251, 11)
        Me.Label65.Name = "Label65"
        Me.Label65.Size = New System.Drawing.Size(177, 45)
        Me.Label65.TabIndex = 46
        Me.Label65.Text = "Gun Driver"
        '
        'ledGdHtrStartup
        '
        Me.ledGdHtrStartup.FillColor = System.Drawing.Color.LawnGreen
        Me.ledGdHtrStartup.ForeColor = System.Drawing.Color.Black
        Me.ledGdHtrStartup.Location = New System.Drawing.Point(384, 449)
        Me.ledGdHtrStartup.MyBorderColor = System.Drawing.Color.Black
        Me.ledGdHtrStartup.MyBorderWidth = 2
        Me.ledGdHtrStartup.Name = "ledGdHtrStartup"
        Me.ledGdHtrStartup.Size = New System.Drawing.Size(18, 20)
        Me.ledGdHtrStartup.TabIndex = 42
        '
        'ledGdCAN
        '
        Me.ledGdCAN.FillColor = System.Drawing.Color.LawnGreen
        Me.ledGdCAN.ForeColor = System.Drawing.Color.Black
        Me.ledGdCAN.Location = New System.Drawing.Point(123, 474)
        Me.ledGdCAN.MyBorderColor = System.Drawing.Color.Black
        Me.ledGdCAN.MyBorderWidth = 2
        Me.ledGdCAN.Name = "ledGdCAN"
        Me.ledGdCAN.Size = New System.Drawing.Size(18, 20)
        Me.ledGdCAN.TabIndex = 42
        '
        'ledGdADCread
        '
        Me.ledGdADCread.FillColor = System.Drawing.Color.LawnGreen
        Me.ledGdADCread.ForeColor = System.Drawing.Color.Black
        Me.ledGdADCread.Location = New System.Drawing.Point(384, 399)
        Me.ledGdADCread.MyBorderColor = System.Drawing.Color.Black
        Me.ledGdADCread.MyBorderWidth = 2
        Me.ledGdADCread.Name = "ledGdADCread"
        Me.ledGdADCread.Size = New System.Drawing.Size(18, 20)
        Me.ledGdADCread.TabIndex = 42
        '
        'ledGdEgMon
        '
        Me.ledGdEgMon.FillColor = System.Drawing.Color.LawnGreen
        Me.ledGdEgMon.ForeColor = System.Drawing.Color.Black
        Me.ledGdEgMon.Location = New System.Drawing.Point(123, 424)
        Me.ledGdEgMon.MyBorderColor = System.Drawing.Color.Black
        Me.ledGdEgMon.MyBorderWidth = 2
        Me.ledGdEgMon.Name = "ledGdEgMon"
        Me.ledGdEgMon.Size = New System.Drawing.Size(18, 20)
        Me.ledGdEgMon.TabIndex = 42
        '
        'ledGdArc
        '
        Me.ledGdArc.FillColor = System.Drawing.Color.LawnGreen
        Me.ledGdArc.ForeColor = System.Drawing.Color.Black
        Me.ledGdArc.Location = New System.Drawing.Point(384, 324)
        Me.ledGdArc.MyBorderColor = System.Drawing.Color.Black
        Me.ledGdArc.MyBorderWidth = 2
        Me.ledGdArc.Name = "ledGdArc"
        Me.ledGdArc.Size = New System.Drawing.Size(18, 20)
        Me.ledGdArc.TabIndex = 42
        '
        'ledGdHVmon
        '
        Me.ledGdHVmon.FillColor = System.Drawing.Color.LawnGreen
        Me.ledGdHVmon.ForeColor = System.Drawing.Color.Black
        Me.ledGdHVmon.Location = New System.Drawing.Point(123, 349)
        Me.ledGdHVmon.MyBorderColor = System.Drawing.Color.Black
        Me.ledGdHVmon.MyBorderWidth = 2
        Me.ledGdHVmon.Name = "ledGdHVmon"
        Me.ledGdHVmon.Size = New System.Drawing.Size(18, 20)
        Me.ledGdHVmon.TabIndex = 42
        '
        'ledGdSPIcomm
        '
        Me.ledGdSPIcomm.FillColor = System.Drawing.Color.LawnGreen
        Me.ledGdSPIcomm.ForeColor = System.Drawing.Color.Black
        Me.ledGdSPIcomm.Location = New System.Drawing.Point(384, 424)
        Me.ledGdSPIcomm.MyBorderColor = System.Drawing.Color.Black
        Me.ledGdSPIcomm.MyBorderWidth = 2
        Me.ledGdSPIcomm.Name = "ledGdSPIcomm"
        Me.ledGdSPIcomm.Size = New System.Drawing.Size(18, 20)
        Me.ledGdSPIcomm.TabIndex = 42
        '
        'ledGdEcMon
        '
        Me.ledGdEcMon.FillColor = System.Drawing.Color.LawnGreen
        Me.ledGdEcMon.ForeColor = System.Drawing.Color.Black
        Me.ledGdEcMon.Location = New System.Drawing.Point(123, 449)
        Me.ledGdEcMon.MyBorderColor = System.Drawing.Color.Black
        Me.ledGdEcMon.MyBorderWidth = 2
        Me.ledGdEcMon.Name = "ledGdEcMon"
        Me.ledGdEcMon.Size = New System.Drawing.Size(18, 20)
        Me.ledGdEcMon.TabIndex = 42
        '
        'ledGdOT
        '
        Me.ledGdOT.FillColor = System.Drawing.Color.LawnGreen
        Me.ledGdOT.ForeColor = System.Drawing.Color.Black
        Me.ledGdOT.Location = New System.Drawing.Point(384, 349)
        Me.ledGdOT.MyBorderColor = System.Drawing.Color.Black
        Me.ledGdOT.MyBorderWidth = 2
        Me.ledGdOT.Name = "ledGdOT"
        Me.ledGdOT.Size = New System.Drawing.Size(18, 20)
        Me.ledGdOT.TabIndex = 42
        '
        'ledGdHtrMon
        '
        Me.ledGdHtrMon.FillColor = System.Drawing.Color.Red
        Me.ledGdHtrMon.ForeColor = System.Drawing.Color.Black
        Me.ledGdHtrMon.Location = New System.Drawing.Point(123, 374)
        Me.ledGdHtrMon.MyBorderColor = System.Drawing.Color.Black
        Me.ledGdHtrMon.MyBorderWidth = 2
        Me.ledGdHtrMon.Name = "ledGdHtrMon"
        Me.ledGdHtrMon.Size = New System.Drawing.Size(18, 20)
        Me.ledGdHtrMon.TabIndex = 42
        '
        'ledGdGrid
        '
        Me.ledGdGrid.FillColor = System.Drawing.Color.LawnGreen
        Me.ledGdGrid.ForeColor = System.Drawing.Color.Black
        Me.ledGdGrid.Location = New System.Drawing.Point(384, 374)
        Me.ledGdGrid.MyBorderColor = System.Drawing.Color.Black
        Me.ledGdGrid.MyBorderWidth = 2
        Me.ledGdGrid.Name = "ledGdGrid"
        Me.ledGdGrid.Size = New System.Drawing.Size(18, 20)
        Me.ledGdGrid.TabIndex = 42
        '
        'ledGdHtrOC
        '
        Me.ledGdHtrOC.FillColor = System.Drawing.Color.LawnGreen
        Me.ledGdHtrOC.ForeColor = System.Drawing.Color.Black
        Me.ledGdHtrOC.Location = New System.Drawing.Point(123, 399)
        Me.ledGdHtrOC.MyBorderColor = System.Drawing.Color.Black
        Me.ledGdHtrOC.MyBorderWidth = 2
        Me.ledGdHtrOC.Name = "ledGdHtrOC"
        Me.ledGdHtrOC.Size = New System.Drawing.Size(18, 20)
        Me.ledGdHtrOC.TabIndex = 42
        '
        'Label104
        '
        Me.Label104.AutoSize = True
        Me.Label104.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label104.ForeColor = System.Drawing.Color.Black
        Me.Label104.Location = New System.Drawing.Point(408, 449)
        Me.Label104.Name = "Label104"
        Me.Label104.Size = New System.Drawing.Size(152, 21)
        Me.Label104.TabIndex = 41
        Me.Label104.Text = "Heater Startup Fail"
        '
        'ledGdFPGArev
        '
        Me.ledGdFPGArev.FillColor = System.Drawing.Color.LawnGreen
        Me.ledGdFPGArev.ForeColor = System.Drawing.Color.Black
        Me.ledGdFPGArev.Location = New System.Drawing.Point(123, 324)
        Me.ledGdFPGArev.MyBorderColor = System.Drawing.Color.Black
        Me.ledGdFPGArev.MyBorderWidth = 2
        Me.ledGdFPGArev.Name = "ledGdFPGArev"
        Me.ledGdFPGArev.Size = New System.Drawing.Size(18, 20)
        Me.ledGdFPGArev.TabIndex = 42
        '
        'Label96
        '
        Me.Label96.AutoSize = True
        Me.Label96.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label96.ForeColor = System.Drawing.Color.Black
        Me.Label96.Location = New System.Drawing.Point(147, 474)
        Me.Label96.Name = "Label96"
        Me.Label96.Size = New System.Drawing.Size(86, 21)
        Me.Label96.TabIndex = 41
        Me.Label96.Text = "CAN Fault"
        '
        'Label102
        '
        Me.Label102.AutoSize = True
        Me.Label102.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label102.ForeColor = System.Drawing.Color.Black
        Me.Label102.Location = New System.Drawing.Point(408, 424)
        Me.Label102.Name = "Label102"
        Me.Label102.Size = New System.Drawing.Size(130, 21)
        Me.Label102.TabIndex = 41
        Me.Label102.Text = "SPI Comm Fault"
        '
        'Label101
        '
        Me.Label101.AutoSize = True
        Me.Label101.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label101.ForeColor = System.Drawing.Color.Black
        Me.Label101.Location = New System.Drawing.Point(408, 399)
        Me.Label101.Name = "Label101"
        Me.Label101.Size = New System.Drawing.Size(116, 21)
        Me.Label101.TabIndex = 41
        Me.Label101.Text = "ADC Read Fail"
        '
        'Label95
        '
        Me.Label95.AutoSize = True
        Me.Label95.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label95.ForeColor = System.Drawing.Color.Black
        Me.Label95.Location = New System.Drawing.Point(147, 449)
        Me.Label95.Name = "Label95"
        Me.Label95.Size = New System.Drawing.Size(133, 21)
        Me.Label95.TabIndex = 41
        Me.Label95.Text = "Bias Vmon Fault"
        '
        'Label100
        '
        Me.Label100.AutoSize = True
        Me.Label100.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label100.ForeColor = System.Drawing.Color.Black
        Me.Label100.Location = New System.Drawing.Point(408, 349)
        Me.Label100.Name = "Label100"
        Me.Label100.Size = New System.Drawing.Size(93, 21)
        Me.Label100.TabIndex = 41
        Me.Label100.Text = "Over Temp"
        '
        'Label94
        '
        Me.Label94.AutoSize = True
        Me.Label94.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label94.ForeColor = System.Drawing.Color.Black
        Me.Label94.Location = New System.Drawing.Point(147, 424)
        Me.Label94.Name = "Label94"
        Me.Label94.Size = New System.Drawing.Size(131, 21)
        Me.Label94.TabIndex = 41
        Me.Label94.Text = "Top Vmon Fault"
        '
        'Label99
        '
        Me.Label99.AutoSize = True
        Me.Label99.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label99.ForeColor = System.Drawing.Color.Black
        Me.Label99.Location = New System.Drawing.Point(408, 374)
        Me.Label99.Name = "Label99"
        Me.Label99.Size = New System.Drawing.Size(84, 21)
        Me.Label99.TabIndex = 41
        Me.Label99.Text = "Grid Fault"
        '
        'Label91
        '
        Me.Label91.AutoSize = True
        Me.Label91.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label91.ForeColor = System.Drawing.Color.Black
        Me.Label91.Location = New System.Drawing.Point(147, 374)
        Me.Label91.Name = "Label91"
        Me.Label91.Size = New System.Drawing.Size(153, 21)
        Me.Label91.TabIndex = 41
        Me.Label91.Text = "Heater Vmon Fault"
        '
        'Label98
        '
        Me.Label98.AutoSize = True
        Me.Label98.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label98.ForeColor = System.Drawing.Color.Black
        Me.Label98.Location = New System.Drawing.Point(408, 324)
        Me.Label98.Name = "Label98"
        Me.Label98.Size = New System.Drawing.Size(77, 21)
        Me.Label98.TabIndex = 41
        Me.Label98.Text = "Arc Fault"
        '
        'Label93
        '
        Me.Label93.AutoSize = True
        Me.Label93.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label93.ForeColor = System.Drawing.Color.Black
        Me.Label93.Location = New System.Drawing.Point(147, 399)
        Me.Label93.Name = "Label93"
        Me.Label93.Size = New System.Drawing.Size(121, 21)
        Me.Label93.TabIndex = 41
        Me.Label93.Text = "Heater OC ABS"
        '
        'Label90
        '
        Me.Label90.AutoSize = True
        Me.Label90.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label90.ForeColor = System.Drawing.Color.Black
        Me.Label90.Location = New System.Drawing.Point(147, 349)
        Me.Label90.Name = "Label90"
        Me.Label90.Size = New System.Drawing.Size(125, 21)
        Me.Label90.TabIndex = 41
        Me.Label90.Text = "HV Vmon Fault"
        '
        'Label61
        '
        Me.Label61.AutoSize = True
        Me.Label61.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label61.ForeColor = System.Drawing.Color.Black
        Me.Label61.Location = New System.Drawing.Point(147, 324)
        Me.Label61.Name = "Label61"
        Me.Label61.Size = New System.Drawing.Size(124, 21)
        Me.Label61.TabIndex = 41
        Me.Label61.Text = "FPGA Rev Fault"
        '
        'Label89
        '
        Me.Label89.AutoSize = True
        Me.Label89.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label89.ForeColor = System.Drawing.Color.Black
        Me.Label89.Location = New System.Drawing.Point(276, 238)
        Me.Label89.Name = "Label89"
        Me.Label89.Size = New System.Drawing.Size(21, 21)
        Me.Label89.TabIndex = 43
        Me.Label89.Text = "V"
        '
        'Label86
        '
        Me.Label86.AutoSize = True
        Me.Label86.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label86.ForeColor = System.Drawing.Color.Black
        Me.Label86.Location = New System.Drawing.Point(276, 208)
        Me.Label86.Name = "Label86"
        Me.Label86.Size = New System.Drawing.Size(21, 21)
        Me.Label86.TabIndex = 43
        Me.Label86.Text = "V"
        '
        'Label83
        '
        Me.Label83.AutoSize = True
        Me.Label83.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label83.ForeColor = System.Drawing.Color.Black
        Me.Label83.Location = New System.Drawing.Point(276, 178)
        Me.Label83.Name = "Label83"
        Me.Label83.Size = New System.Drawing.Size(21, 21)
        Me.Label83.TabIndex = 43
        Me.Label83.Text = "A"
        '
        'Label80
        '
        Me.Label80.AutoSize = True
        Me.Label80.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label80.ForeColor = System.Drawing.Color.Black
        Me.Label80.Location = New System.Drawing.Point(276, 148)
        Me.Label80.Name = "Label80"
        Me.Label80.Size = New System.Drawing.Size(21, 21)
        Me.Label80.TabIndex = 43
        Me.Label80.Text = "V"
        '
        'Label77
        '
        Me.Label77.AutoSize = True
        Me.Label77.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label77.ForeColor = System.Drawing.Color.Black
        Me.Label77.Location = New System.Drawing.Point(276, 118)
        Me.Label77.Name = "Label77"
        Me.Label77.Size = New System.Drawing.Size(36, 21)
        Me.Label77.TabIndex = 43
        Me.Label77.Text = "mA"
        '
        'Label62
        '
        Me.Label62.AutoSize = True
        Me.Label62.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label62.ForeColor = System.Drawing.Color.Black
        Me.Label62.Location = New System.Drawing.Point(276, 88)
        Me.Label62.Name = "Label62"
        Me.Label62.Size = New System.Drawing.Size(30, 21)
        Me.Label62.TabIndex = 43
        Me.Label62.Text = "kV"
        '
        'Label88
        '
        Me.Label88.AutoSize = True
        Me.Label88.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label88.ForeColor = System.Drawing.Color.Black
        Me.Label88.Location = New System.Drawing.Point(107, 238)
        Me.Label88.Name = "Label88"
        Me.Label88.Size = New System.Drawing.Size(27, 21)
        Me.Label88.TabIndex = 45
        Me.Label88.Text = "Ec"
        '
        'lblGdEc
        '
        Me.lblGdEc.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGdEc.ForeColor = System.Drawing.Color.Black
        Me.lblGdEc.Location = New System.Drawing.Point(176, 238)
        Me.lblGdEc.Name = "lblGdEc"
        Me.lblGdEc.Size = New System.Drawing.Size(94, 20)
        Me.lblGdEc.TabIndex = 44
        Me.lblGdEc.Text = "0"
        Me.lblGdEc.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label85
        '
        Me.Label85.AutoSize = True
        Me.Label85.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label85.ForeColor = System.Drawing.Color.Black
        Me.Label85.Location = New System.Drawing.Point(107, 208)
        Me.Label85.Name = "Label85"
        Me.Label85.Size = New System.Drawing.Size(29, 21)
        Me.Label85.TabIndex = 45
        Me.Label85.Text = "Eg"
        '
        'lblGdEg
        '
        Me.lblGdEg.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGdEg.ForeColor = System.Drawing.Color.Black
        Me.lblGdEg.Location = New System.Drawing.Point(176, 208)
        Me.lblGdEg.Name = "lblGdEg"
        Me.lblGdEg.Size = New System.Drawing.Size(94, 20)
        Me.lblGdEg.TabIndex = 44
        Me.lblGdEg.Text = "0"
        Me.lblGdEg.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label82
        '
        Me.Label82.AutoSize = True
        Me.Label82.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label82.ForeColor = System.Drawing.Color.Black
        Me.Label82.Location = New System.Drawing.Point(107, 178)
        Me.Label82.Name = "Label82"
        Me.Label82.Size = New System.Drawing.Size(21, 21)
        Me.Label82.TabIndex = 45
        Me.Label82.Text = "If"
        '
        'lblGdIf
        '
        Me.lblGdIf.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGdIf.ForeColor = System.Drawing.Color.Black
        Me.lblGdIf.Location = New System.Drawing.Point(176, 178)
        Me.lblGdIf.Name = "lblGdIf"
        Me.lblGdIf.Size = New System.Drawing.Size(94, 20)
        Me.lblGdIf.TabIndex = 44
        Me.lblGdIf.Text = "0"
        Me.lblGdIf.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label79
        '
        Me.Label79.AutoSize = True
        Me.Label79.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label79.ForeColor = System.Drawing.Color.Black
        Me.Label79.Location = New System.Drawing.Point(107, 148)
        Me.Label79.Name = "Label79"
        Me.Label79.Size = New System.Drawing.Size(25, 21)
        Me.Label79.TabIndex = 45
        Me.Label79.Text = "Ef"
        '
        'lblGdEf
        '
        Me.lblGdEf.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGdEf.ForeColor = System.Drawing.Color.Black
        Me.lblGdEf.Location = New System.Drawing.Point(176, 148)
        Me.lblGdEf.Name = "lblGdEf"
        Me.lblGdEf.Size = New System.Drawing.Size(94, 20)
        Me.lblGdEf.TabIndex = 44
        Me.lblGdEf.Text = "0"
        Me.lblGdEf.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label76
        '
        Me.Label76.AutoSize = True
        Me.Label76.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label76.ForeColor = System.Drawing.Color.Black
        Me.Label76.Location = New System.Drawing.Point(107, 118)
        Me.Label76.Name = "Label76"
        Me.Label76.Size = New System.Drawing.Size(34, 21)
        Me.Label76.TabIndex = 45
        Me.Label76.Text = "Ikp"
        '
        'lblGdIkp
        '
        Me.lblGdIkp.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGdIkp.ForeColor = System.Drawing.Color.Black
        Me.lblGdIkp.Location = New System.Drawing.Point(176, 118)
        Me.lblGdIkp.Name = "lblGdIkp"
        Me.lblGdIkp.Size = New System.Drawing.Size(94, 20)
        Me.lblGdIkp.TabIndex = 44
        Me.lblGdIkp.Text = "0"
        Me.lblGdIkp.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label63
        '
        Me.Label63.AutoSize = True
        Me.Label63.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label63.ForeColor = System.Drawing.Color.Black
        Me.Label63.Location = New System.Drawing.Point(107, 88)
        Me.Label63.Name = "Label63"
        Me.Label63.Size = New System.Drawing.Size(28, 21)
        Me.Label63.TabIndex = 45
        Me.Label63.Text = "Ek"
        '
        'lblGdEk
        '
        Me.lblGdEk.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGdEk.ForeColor = System.Drawing.Color.Black
        Me.lblGdEk.Location = New System.Drawing.Point(176, 88)
        Me.lblGdEk.Name = "lblGdEk"
        Me.lblGdEk.Size = New System.Drawing.Size(94, 20)
        Me.lblGdEk.TabIndex = 44
        Me.lblGdEk.Text = "0"
        Me.lblGdEk.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'BlueRect4
        '
        Me.BlueRect4.Enabled = False
        Me.BlueRect4.Location = New System.Drawing.Point(32, 60)
        Me.BlueRect4.MyBorderColor = System.Drawing.Color.Black
        Me.BlueRect4.MyBorderWidth = 0.001!
        Me.BlueRect4.Name = "BlueRect4"
        Me.BlueRect4.Size = New System.Drawing.Size(617, 228)
        Me.BlueRect4.TabIndex = 80
        '
        'TabPageCooling
        '
        Me.TabPageCooling.BackColor = System.Drawing.SystemColors.Control
        Me.TabPageCooling.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TabPageCooling.Controls.Add(Me.lblAutofillRemain2)
        Me.TabPageCooling.Controls.Add(Me.Label37)
        Me.TabPageCooling.Controls.Add(Me.btnReenableAutofill2)
        Me.TabPageCooling.Controls.Add(Me.btnCoolNewSF6bottle)
        Me.TabPageCooling.Controls.Add(Me.btnCoolSF6Override)
        Me.TabPageCooling.Controls.Add(Me.ledWSF6RelayClosed)
        Me.TabPageCooling.Controls.Add(Me.ledWNoSF6Pulses)
        Me.TabPageCooling.Controls.Add(Me.ledCoolCabTemp)
        Me.TabPageCooling.Controls.Add(Me.ledCoolCabTempSwitch)
        Me.TabPageCooling.Controls.Add(Me.ledCoolCirFlow)
        Me.TabPageCooling.Controls.Add(Me.ledWSF6TooLowToFill)
        Me.TabPageCooling.Controls.Add(Me.ledCoolMagFlow)
        Me.TabPageCooling.Controls.Add(Me.ledWSF6Filling)
        Me.TabPageCooling.Controls.Add(Me.ledWSF6FillReq)
        Me.TabPageCooling.Controls.Add(Me.ledCoolSF6press)
        Me.TabPageCooling.Controls.Add(Me.ledCoolLinacFlow)
        Me.TabPageCooling.Controls.Add(Me.ledWCoolTooCold)
        Me.TabPageCooling.Controls.Add(Me.ledCoolCoolTemp)
        Me.TabPageCooling.Controls.Add(Me.Label145)
        Me.TabPageCooling.Controls.Add(Me.Label111)
        Me.TabPageCooling.Controls.Add(Me.ledCoolCAN)
        Me.TabPageCooling.Controls.Add(Me.Label110)
        Me.TabPageCooling.Controls.Add(Me.Label113)
        Me.TabPageCooling.Controls.Add(Me.Label109)
        Me.TabPageCooling.Controls.Add(Me.Label114)
        Me.TabPageCooling.Controls.Add(Me.Label115)
        Me.TabPageCooling.Controls.Add(Me.Label116)
        Me.TabPageCooling.Controls.Add(Me.Label118)
        Me.TabPageCooling.Controls.Add(Me.Label120)
        Me.TabPageCooling.Controls.Add(Me.LabelCoolLinacFlo)
        Me.TabPageCooling.Controls.Add(Me.Label124)
        Me.TabPageCooling.Controls.Add(Me.Label125)
        Me.TabPageCooling.Controls.Add(Me.Label126)
        Me.TabPageCooling.Controls.Add(Me.Label156)
        Me.TabPageCooling.Controls.Add(Me.Label155)
        Me.TabPageCooling.Controls.Add(Me.Label154)
        Me.TabPageCooling.Controls.Add(Me.Label130)
        Me.TabPageCooling.Controls.Add(Me.Label131)
        Me.TabPageCooling.Controls.Add(Me.Label132)
        Me.TabPageCooling.Controls.Add(Me.Label147)
        Me.TabPageCooling.Controls.Add(Me.Label148)
        Me.TabPageCooling.Controls.Add(Me.Label146)
        Me.TabPageCooling.Controls.Add(Me.lblCoolCabTemp)
        Me.TabPageCooling.Controls.Add(Me.lblCoolCoolTemp)
        Me.TabPageCooling.Controls.Add(Me.Label139)
        Me.TabPageCooling.Controls.Add(Me.lblCoolSF6Press)
        Me.TabPageCooling.Controls.Add(Me.lblCoolCirFlow)
        Me.TabPageCooling.Controls.Add(Me.Label141)
        Me.TabPageCooling.Controls.Add(Me.lblCoolLinacFlow)
        Me.TabPageCooling.Controls.Add(Me.Label143)
        Me.TabPageCooling.Controls.Add(Me.lblCoolMagFlow)
        Me.TabPageCooling.Controls.Add(Me.Label66)
        Me.TabPageCooling.Controls.Add(Me.BlueRect6)
        Me.TabPageCooling.ForeColor = System.Drawing.Color.Black
        Me.TabPageCooling.Location = New System.Drawing.Point(0, 0)
        Me.TabPageCooling.Name = "TabPageCooling"
        Me.TabPageCooling.Size = New System.Drawing.Size(680, 580)
        Me.TabPageCooling.TabIndex = 3
        Me.TabPageCooling.Text = "TabPage2"
        '
        'lblAutofillRemain2
        '
        Me.lblAutofillRemain2.AutoSize = True
        Me.lblAutofillRemain2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAutofillRemain2.ForeColor = System.Drawing.Color.Black
        Me.lblAutofillRemain2.Location = New System.Drawing.Point(556, 115)
        Me.lblAutofillRemain2.Name = "lblAutofillRemain2"
        Me.lblAutofillRemain2.Size = New System.Drawing.Size(37, 21)
        Me.lblAutofillRemain2.TabIndex = 138
        Me.lblAutofillRemain2.Text = "200"
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label37.ForeColor = System.Drawing.Color.Black
        Me.Label37.Location = New System.Drawing.Point(388, 115)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(159, 21)
        Me.Label37.TabIndex = 138
        Me.Label37.Text = "Autofill Remaining:"
        '
        'btnReenableAutofill2
        '
        Me.btnReenableAutofill2.BackColor = System.Drawing.Color.Blue
        Me.btnReenableAutofill2.Enabled = False
        Me.btnReenableAutofill2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReenableAutofill2.ForeColor = System.Drawing.Color.Blue
        Me.btnReenableAutofill2.Location = New System.Drawing.Point(388, 145)
        Me.btnReenableAutofill2.Name = "btnReenableAutofill2"
        Me.btnReenableAutofill2.Size = New System.Drawing.Size(190, 34)
        Me.btnReenableAutofill2.TabIndex = 137
        Me.btnReenableAutofill2.Tag = "1"
        Me.btnReenableAutofill2.Text = "Re-enable Autofill"
        Me.btnReenableAutofill2.UseVisualStyleBackColor = True
        '
        'btnCoolNewSF6bottle
        '
        Me.btnCoolNewSF6bottle.BackColor = System.Drawing.Color.Blue
        Me.btnCoolNewSF6bottle.Enabled = False
        Me.btnCoolNewSF6bottle.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCoolNewSF6bottle.ForeColor = System.Drawing.Color.Blue
        Me.btnCoolNewSF6bottle.Location = New System.Drawing.Point(388, 222)
        Me.btnCoolNewSF6bottle.Name = "btnCoolNewSF6bottle"
        Me.btnCoolNewSF6bottle.Size = New System.Drawing.Size(190, 34)
        Me.btnCoolNewSF6bottle.TabIndex = 135
        Me.btnCoolNewSF6bottle.Tag = "1"
        Me.btnCoolNewSF6bottle.Text = "New SF6 Bottle"
        Me.btnCoolNewSF6bottle.UseVisualStyleBackColor = True
        '
        'btnCoolSF6Override
        '
        Me.btnCoolSF6Override.BackColor = System.Drawing.Color.Blue
        Me.btnCoolSF6Override.Enabled = False
        Me.btnCoolSF6Override.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCoolSF6Override.ForeColor = System.Drawing.Color.Blue
        Me.btnCoolSF6Override.Location = New System.Drawing.Point(570, 342)
        Me.btnCoolSF6Override.Name = "btnCoolSF6Override"
        Me.btnCoolSF6Override.Size = New System.Drawing.Size(92, 33)
        Me.btnCoolSF6Override.TabIndex = 134
        Me.btnCoolSF6Override.Tag = "1"
        Me.btnCoolSF6Override.Text = "Override"
        Me.btnCoolSF6Override.UseVisualStyleBackColor = True
        '
        'ledWSF6RelayClosed
        '
        Me.ledWSF6RelayClosed.FillColor = System.Drawing.SystemColors.Control
        Me.ledWSF6RelayClosed.ForeColor = System.Drawing.Color.Black
        Me.ledWSF6RelayClosed.Location = New System.Drawing.Point(373, 452)
        Me.ledWSF6RelayClosed.MyBorderColor = System.Drawing.Color.Black
        Me.ledWSF6RelayClosed.MyBorderWidth = 2
        Me.ledWSF6RelayClosed.Name = "ledWSF6RelayClosed"
        Me.ledWSF6RelayClosed.Size = New System.Drawing.Size(18, 20)
        Me.ledWSF6RelayClosed.TabIndex = 102
        '
        'ledWNoSF6Pulses
        '
        Me.ledWNoSF6Pulses.FillColor = System.Drawing.SystemColors.Control
        Me.ledWNoSF6Pulses.ForeColor = System.Drawing.Color.Black
        Me.ledWNoSF6Pulses.Location = New System.Drawing.Point(373, 400)
        Me.ledWNoSF6Pulses.MyBorderColor = System.Drawing.Color.Black
        Me.ledWNoSF6Pulses.MyBorderWidth = 2
        Me.ledWNoSF6Pulses.Name = "ledWNoSF6Pulses"
        Me.ledWNoSF6Pulses.Size = New System.Drawing.Size(18, 20)
        Me.ledWNoSF6Pulses.TabIndex = 102
        '
        'ledCoolCabTemp
        '
        Me.ledCoolCabTemp.FillColor = System.Drawing.Color.LawnGreen
        Me.ledCoolCabTemp.ForeColor = System.Drawing.Color.White
        Me.ledCoolCabTemp.Location = New System.Drawing.Point(112, 452)
        Me.ledCoolCabTemp.MyBorderColor = System.Drawing.Color.Black
        Me.ledCoolCabTemp.MyBorderWidth = 2
        Me.ledCoolCabTemp.Name = "ledCoolCabTemp"
        Me.ledCoolCabTemp.Size = New System.Drawing.Size(18, 20)
        Me.ledCoolCabTemp.TabIndex = 103
        '
        'ledCoolCabTempSwitch
        '
        Me.ledCoolCabTempSwitch.FillColor = System.Drawing.Color.LawnGreen
        Me.ledCoolCabTempSwitch.ForeColor = System.Drawing.Color.White
        Me.ledCoolCabTempSwitch.Location = New System.Drawing.Point(112, 426)
        Me.ledCoolCabTempSwitch.MyBorderColor = System.Drawing.Color.Black
        Me.ledCoolCabTempSwitch.MyBorderWidth = 2
        Me.ledCoolCabTempSwitch.Name = "ledCoolCabTempSwitch"
        Me.ledCoolCabTempSwitch.Size = New System.Drawing.Size(18, 20)
        Me.ledCoolCabTempSwitch.TabIndex = 103
        '
        'ledCoolCirFlow
        '
        Me.ledCoolCirFlow.FillColor = System.Drawing.Color.LawnGreen
        Me.ledCoolCirFlow.ForeColor = System.Drawing.Color.White
        Me.ledCoolCirFlow.Location = New System.Drawing.Point(112, 400)
        Me.ledCoolCirFlow.MyBorderColor = System.Drawing.Color.Black
        Me.ledCoolCirFlow.MyBorderWidth = 2
        Me.ledCoolCirFlow.Name = "ledCoolCirFlow"
        Me.ledCoolCirFlow.Size = New System.Drawing.Size(18, 20)
        Me.ledCoolCirFlow.TabIndex = 109
        '
        'ledWSF6TooLowToFill
        '
        Me.ledWSF6TooLowToFill.FillColor = System.Drawing.SystemColors.Control
        Me.ledWSF6TooLowToFill.ForeColor = System.Drawing.Color.Black
        Me.ledWSF6TooLowToFill.Location = New System.Drawing.Point(373, 348)
        Me.ledWSF6TooLowToFill.MyBorderColor = System.Drawing.Color.Black
        Me.ledWSF6TooLowToFill.MyBorderWidth = 2
        Me.ledWSF6TooLowToFill.Name = "ledWSF6TooLowToFill"
        Me.ledWSF6TooLowToFill.Size = New System.Drawing.Size(18, 20)
        Me.ledWSF6TooLowToFill.TabIndex = 106
        '
        'ledCoolMagFlow
        '
        Me.ledCoolMagFlow.FillColor = System.Drawing.Color.LawnGreen
        Me.ledCoolMagFlow.ForeColor = System.Drawing.Color.White
        Me.ledCoolMagFlow.Location = New System.Drawing.Point(112, 348)
        Me.ledCoolMagFlow.MyBorderColor = System.Drawing.Color.Black
        Me.ledCoolMagFlow.MyBorderWidth = 2
        Me.ledCoolMagFlow.Name = "ledCoolMagFlow"
        Me.ledCoolMagFlow.Size = New System.Drawing.Size(18, 20)
        Me.ledCoolMagFlow.TabIndex = 114
        '
        'ledWSF6Filling
        '
        Me.ledWSF6Filling.FillColor = System.Drawing.SystemColors.Control
        Me.ledWSF6Filling.ForeColor = System.Drawing.Color.Black
        Me.ledWSF6Filling.Location = New System.Drawing.Point(373, 426)
        Me.ledWSF6Filling.MyBorderColor = System.Drawing.Color.Black
        Me.ledWSF6Filling.MyBorderWidth = 2
        Me.ledWSF6Filling.Name = "ledWSF6Filling"
        Me.ledWSF6Filling.Size = New System.Drawing.Size(18, 20)
        Me.ledWSF6Filling.TabIndex = 110
        '
        'ledWSF6FillReq
        '
        Me.ledWSF6FillReq.FillColor = System.Drawing.SystemColors.Control
        Me.ledWSF6FillReq.ForeColor = System.Drawing.Color.Black
        Me.ledWSF6FillReq.Location = New System.Drawing.Point(373, 374)
        Me.ledWSF6FillReq.MyBorderColor = System.Drawing.Color.Black
        Me.ledWSF6FillReq.MyBorderWidth = 2
        Me.ledWSF6FillReq.Name = "ledWSF6FillReq"
        Me.ledWSF6FillReq.Size = New System.Drawing.Size(18, 20)
        Me.ledWSF6FillReq.TabIndex = 110
        '
        'ledCoolSF6press
        '
        Me.ledCoolSF6press.FillColor = System.Drawing.Color.LawnGreen
        Me.ledCoolSF6press.ForeColor = System.Drawing.Color.White
        Me.ledCoolSF6press.Location = New System.Drawing.Point(112, 504)
        Me.ledCoolSF6press.MyBorderColor = System.Drawing.Color.Black
        Me.ledCoolSF6press.MyBorderWidth = 2
        Me.ledCoolSF6press.Name = "ledCoolSF6press"
        Me.ledCoolSF6press.Size = New System.Drawing.Size(18, 20)
        Me.ledCoolSF6press.TabIndex = 112
        '
        'ledCoolLinacFlow
        '
        Me.ledCoolLinacFlow.FillColor = System.Drawing.Color.Red
        Me.ledCoolLinacFlow.ForeColor = System.Drawing.Color.White
        Me.ledCoolLinacFlow.Location = New System.Drawing.Point(112, 374)
        Me.ledCoolLinacFlow.MyBorderColor = System.Drawing.Color.Black
        Me.ledCoolLinacFlow.MyBorderWidth = 2
        Me.ledCoolLinacFlow.Name = "ledCoolLinacFlow"
        Me.ledCoolLinacFlow.Size = New System.Drawing.Size(18, 20)
        Me.ledCoolLinacFlow.TabIndex = 113
        '
        'ledWCoolTooCold
        '
        Me.ledWCoolTooCold.FillColor = System.Drawing.Color.Black
        Me.ledWCoolTooCold.ForeColor = System.Drawing.Color.Black
        Me.ledWCoolTooCold.Location = New System.Drawing.Point(373, 322)
        Me.ledWCoolTooCold.MyBorderColor = System.Drawing.Color.Black
        Me.ledWCoolTooCold.MyBorderWidth = 2
        Me.ledWCoolTooCold.Name = "ledWCoolTooCold"
        Me.ledWCoolTooCold.Size = New System.Drawing.Size(18, 20)
        Me.ledWCoolTooCold.TabIndex = 101
        '
        'ledCoolCoolTemp
        '
        Me.ledCoolCoolTemp.FillColor = System.Drawing.Color.LawnGreen
        Me.ledCoolCoolTemp.ForeColor = System.Drawing.Color.White
        Me.ledCoolCoolTemp.Location = New System.Drawing.Point(112, 478)
        Me.ledCoolCoolTemp.MyBorderColor = System.Drawing.Color.Black
        Me.ledCoolCoolTemp.MyBorderWidth = 2
        Me.ledCoolCoolTemp.Name = "ledCoolCoolTemp"
        Me.ledCoolCoolTemp.Size = New System.Drawing.Size(18, 20)
        Me.ledCoolCoolTemp.TabIndex = 99
        '
        'Label145
        '
        Me.Label145.AutoSize = True
        Me.Label145.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label145.ForeColor = System.Drawing.Color.Black
        Me.Label145.Location = New System.Drawing.Point(397, 426)
        Me.Label145.Name = "Label145"
        Me.Label145.Size = New System.Drawing.Size(88, 21)
        Me.Label145.TabIndex = 92
        Me.Label145.Text = "SF6 Filling"
        '
        'Label111
        '
        Me.Label111.AutoSize = True
        Me.Label111.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label111.ForeColor = System.Drawing.Color.Black
        Me.Label111.Location = New System.Drawing.Point(397, 374)
        Me.Label111.Name = "Label111"
        Me.Label111.Size = New System.Drawing.Size(136, 21)
        Me.Label111.TabIndex = 92
        Me.Label111.Text = "SF6 Fill Required"
        '
        'ledCoolCAN
        '
        Me.ledCoolCAN.FillColor = System.Drawing.Color.LawnGreen
        Me.ledCoolCAN.ForeColor = System.Drawing.Color.Black
        Me.ledCoolCAN.Location = New System.Drawing.Point(112, 322)
        Me.ledCoolCAN.MyBorderColor = System.Drawing.Color.Black
        Me.ledCoolCAN.MyBorderWidth = 2
        Me.ledCoolCAN.Name = "ledCoolCAN"
        Me.ledCoolCAN.Size = New System.Drawing.Size(18, 20)
        Me.ledCoolCAN.TabIndex = 100
        '
        'Label110
        '
        Me.Label110.AutoSize = True
        Me.Label110.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label110.ForeColor = System.Drawing.Color.Black
        Me.Label110.Location = New System.Drawing.Point(136, 452)
        Me.Label110.Name = "Label110"
        Me.Label110.Size = New System.Drawing.Size(156, 21)
        Me.Label110.TabIndex = 85
        Me.Label110.Text = "Cabinet Over Temp"
        '
        'Label113
        '
        Me.Label113.AutoSize = True
        Me.Label113.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label113.ForeColor = System.Drawing.Color.Black
        Me.Label113.Location = New System.Drawing.Point(136, 426)
        Me.Label113.Name = "Label113"
        Me.Label113.Size = New System.Drawing.Size(171, 21)
        Me.Label113.TabIndex = 85
        Me.Label113.Text = "Cabinet Temp Switch"
        '
        'Label109
        '
        Me.Label109.AutoSize = True
        Me.Label109.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label109.ForeColor = System.Drawing.Color.Black
        Me.Label109.Location = New System.Drawing.Point(397, 400)
        Me.Label109.Name = "Label109"
        Me.Label109.Size = New System.Drawing.Size(191, 21)
        Me.Label109.TabIndex = 86
        Me.Label109.Text = "No SF6 Pulses Available"
        '
        'Label114
        '
        Me.Label114.AutoSize = True
        Me.Label114.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label114.ForeColor = System.Drawing.Color.Black
        Me.Label114.Location = New System.Drawing.Point(397, 348)
        Me.Label114.Name = "Label114"
        Me.Label114.Size = New System.Drawing.Size(154, 21)
        Me.Label114.TabIndex = 86
        Me.Label114.Text = "SF6 Too Low To Fill"
        '
        'Label115
        '
        Me.Label115.AutoSize = True
        Me.Label115.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label115.ForeColor = System.Drawing.Color.Black
        Me.Label115.Location = New System.Drawing.Point(134, 400)
        Me.Label115.Name = "Label115"
        Me.Label115.Size = New System.Drawing.Size(125, 21)
        Me.Label115.TabIndex = 87
        Me.Label115.Text = "Circulator Flow"
        '
        'Label116
        '
        Me.Label116.AutoSize = True
        Me.Label116.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label116.ForeColor = System.Drawing.Color.Black
        Me.Label116.Location = New System.Drawing.Point(398, 322)
        Me.Label116.Name = "Label116"
        Me.Label116.Size = New System.Drawing.Size(142, 21)
        Me.Label116.TabIndex = 83
        Me.Label116.Text = "Coolant Too Cold"
        '
        'Label118
        '
        Me.Label118.AutoSize = True
        Me.Label118.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label118.ForeColor = System.Drawing.Color.Black
        Me.Label118.Location = New System.Drawing.Point(136, 504)
        Me.Label118.Name = "Label118"
        Me.Label118.Size = New System.Drawing.Size(104, 21)
        Me.Label118.TabIndex = 89
        Me.Label118.Text = "SF6 Pressure"
        '
        'Label120
        '
        Me.Label120.AutoSize = True
        Me.Label120.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label120.ForeColor = System.Drawing.Color.Black
        Me.Label120.Location = New System.Drawing.Point(398, 452)
        Me.Label120.Name = "Label120"
        Me.Label120.Size = New System.Drawing.Size(135, 21)
        Me.Label120.TabIndex = 98
        Me.Label120.Text = "SF6 Relay closed"
        '
        'LabelCoolLinacFlo
        '
        Me.LabelCoolLinacFlo.AutoSize = True
        Me.LabelCoolLinacFlo.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelCoolLinacFlo.ForeColor = System.Drawing.Color.Black
        Me.LabelCoolLinacFlo.Location = New System.Drawing.Point(134, 374)
        Me.LabelCoolLinacFlo.Name = "LabelCoolLinacFlo"
        Me.LabelCoolLinacFlo.Size = New System.Drawing.Size(90, 21)
        Me.LabelCoolLinacFlo.TabIndex = 91
        Me.LabelCoolLinacFlo.Text = "Linac Flow"
        '
        'Label124
        '
        Me.Label124.AutoSize = True
        Me.Label124.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label124.ForeColor = System.Drawing.Color.Black
        Me.Label124.Location = New System.Drawing.Point(136, 478)
        Me.Label124.Name = "Label124"
        Me.Label124.Size = New System.Drawing.Size(157, 21)
        Me.Label124.TabIndex = 95
        Me.Label124.Text = "Coolant Over Temp"
        '
        'Label125
        '
        Me.Label125.AutoSize = True
        Me.Label125.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label125.ForeColor = System.Drawing.Color.Black
        Me.Label125.Location = New System.Drawing.Point(134, 348)
        Me.Label125.Name = "Label125"
        Me.Label125.Size = New System.Drawing.Size(135, 21)
        Me.Label125.TabIndex = 96
        Me.Label125.Text = "Magnetron Flow"
        '
        'Label126
        '
        Me.Label126.AutoSize = True
        Me.Label126.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label126.ForeColor = System.Drawing.Color.Black
        Me.Label126.Location = New System.Drawing.Point(134, 322)
        Me.Label126.Name = "Label126"
        Me.Label126.Size = New System.Drawing.Size(86, 21)
        Me.Label126.TabIndex = 97
        Me.Label126.Text = "CAN Fault"
        '
        'Label156
        '
        Me.Label156.AutoSize = True
        Me.Label156.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label156.ForeColor = System.Drawing.Color.Black
        Me.Label156.Location = New System.Drawing.Point(277, 205)
        Me.Label156.Name = "Label156"
        Me.Label156.Size = New System.Drawing.Size(20, 21)
        Me.Label156.TabIndex = 117
        Me.Label156.Text = "C"
        '
        'Label155
        '
        Me.Label155.AutoSize = True
        Me.Label155.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label155.ForeColor = System.Drawing.Color.Black
        Me.Label155.Location = New System.Drawing.Point(277, 175)
        Me.Label155.Name = "Label155"
        Me.Label155.Size = New System.Drawing.Size(20, 21)
        Me.Label155.TabIndex = 118
        Me.Label155.Text = "C"
        '
        'Label154
        '
        Me.Label154.AutoSize = True
        Me.Label154.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label154.ForeColor = System.Drawing.Color.Black
        Me.Label154.Location = New System.Drawing.Point(277, 235)
        Me.Label154.Name = "Label154"
        Me.Label154.Size = New System.Drawing.Size(34, 21)
        Me.Label154.TabIndex = 119
        Me.Label154.Text = "PSI"
        '
        'Label130
        '
        Me.Label130.AutoSize = True
        Me.Label130.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label130.ForeColor = System.Drawing.Color.Black
        Me.Label130.Location = New System.Drawing.Point(277, 145)
        Me.Label130.Name = "Label130"
        Me.Label130.Size = New System.Drawing.Size(43, 21)
        Me.Label130.TabIndex = 119
        Me.Label130.Text = "LPM"
        '
        'Label131
        '
        Me.Label131.AutoSize = True
        Me.Label131.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label131.ForeColor = System.Drawing.Color.Black
        Me.Label131.Location = New System.Drawing.Point(277, 115)
        Me.Label131.Name = "Label131"
        Me.Label131.Size = New System.Drawing.Size(43, 21)
        Me.Label131.TabIndex = 120
        Me.Label131.Text = "LPM"
        '
        'Label132
        '
        Me.Label132.AutoSize = True
        Me.Label132.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label132.ForeColor = System.Drawing.Color.Black
        Me.Label132.Location = New System.Drawing.Point(277, 85)
        Me.Label132.Name = "Label132"
        Me.Label132.Size = New System.Drawing.Size(43, 21)
        Me.Label132.TabIndex = 115
        Me.Label132.Text = "LPM"
        '
        'Label147
        '
        Me.Label147.AutoSize = True
        Me.Label147.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label147.ForeColor = System.Drawing.Color.Black
        Me.Label147.Location = New System.Drawing.Point(70, 175)
        Me.Label147.Name = "Label147"
        Me.Label147.Size = New System.Drawing.Size(117, 21)
        Me.Label147.TabIndex = 128
        Me.Label147.Text = "Coolant Temp"
        '
        'Label148
        '
        Me.Label148.AutoSize = True
        Me.Label148.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label148.ForeColor = System.Drawing.Color.Black
        Me.Label148.Location = New System.Drawing.Point(70, 205)
        Me.Label148.Name = "Label148"
        Me.Label148.Size = New System.Drawing.Size(116, 21)
        Me.Label148.TabIndex = 128
        Me.Label148.Text = "Cabinet Temp"
        '
        'Label146
        '
        Me.Label146.AutoSize = True
        Me.Label146.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label146.ForeColor = System.Drawing.Color.Black
        Me.Label146.Location = New System.Drawing.Point(70, 235)
        Me.Label146.Name = "Label146"
        Me.Label146.Size = New System.Drawing.Size(104, 21)
        Me.Label146.TabIndex = 128
        Me.Label146.Text = "SF6 Pressure"
        '
        'lblCoolCabTemp
        '
        Me.lblCoolCabTemp.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCoolCabTemp.ForeColor = System.Drawing.Color.Black
        Me.lblCoolCabTemp.Location = New System.Drawing.Point(211, 205)
        Me.lblCoolCabTemp.Name = "lblCoolCabTemp"
        Me.lblCoolCabTemp.Size = New System.Drawing.Size(60, 20)
        Me.lblCoolCabTemp.TabIndex = 124
        Me.lblCoolCabTemp.Text = "0"
        Me.lblCoolCabTemp.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblCoolCoolTemp
        '
        Me.lblCoolCoolTemp.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCoolCoolTemp.ForeColor = System.Drawing.Color.Black
        Me.lblCoolCoolTemp.Location = New System.Drawing.Point(211, 175)
        Me.lblCoolCoolTemp.Name = "lblCoolCoolTemp"
        Me.lblCoolCoolTemp.Size = New System.Drawing.Size(60, 20)
        Me.lblCoolCoolTemp.TabIndex = 121
        Me.lblCoolCoolTemp.Text = "0"
        Me.lblCoolCoolTemp.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label139
        '
        Me.Label139.AutoSize = True
        Me.Label139.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label139.ForeColor = System.Drawing.Color.Black
        Me.Label139.Location = New System.Drawing.Point(70, 145)
        Me.Label139.Name = "Label139"
        Me.Label139.Size = New System.Drawing.Size(125, 21)
        Me.Label139.TabIndex = 131
        Me.Label139.Text = "Circulator Flow"
        '
        'lblCoolSF6Press
        '
        Me.lblCoolSF6Press.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCoolSF6Press.ForeColor = System.Drawing.Color.Black
        Me.lblCoolSF6Press.Location = New System.Drawing.Point(211, 235)
        Me.lblCoolSF6Press.Name = "lblCoolSF6Press"
        Me.lblCoolSF6Press.Size = New System.Drawing.Size(60, 20)
        Me.lblCoolSF6Press.TabIndex = 122
        Me.lblCoolSF6Press.Text = "0"
        Me.lblCoolSF6Press.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblCoolCirFlow
        '
        Me.lblCoolCirFlow.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCoolCirFlow.ForeColor = System.Drawing.Color.Black
        Me.lblCoolCirFlow.Location = New System.Drawing.Point(211, 145)
        Me.lblCoolCirFlow.Name = "lblCoolCirFlow"
        Me.lblCoolCirFlow.Size = New System.Drawing.Size(60, 20)
        Me.lblCoolCirFlow.TabIndex = 122
        Me.lblCoolCirFlow.Text = "0"
        Me.lblCoolCirFlow.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label141
        '
        Me.Label141.AutoSize = True
        Me.Label141.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label141.ForeColor = System.Drawing.Color.Black
        Me.Label141.Location = New System.Drawing.Point(70, 115)
        Me.Label141.Name = "Label141"
        Me.Label141.Size = New System.Drawing.Size(90, 21)
        Me.Label141.TabIndex = 132
        Me.Label141.Text = "Linac Flow"
        '
        'lblCoolLinacFlow
        '
        Me.lblCoolLinacFlow.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCoolLinacFlow.ForeColor = System.Drawing.Color.Black
        Me.lblCoolLinacFlow.Location = New System.Drawing.Point(211, 115)
        Me.lblCoolLinacFlow.Name = "lblCoolLinacFlow"
        Me.lblCoolLinacFlow.Size = New System.Drawing.Size(60, 20)
        Me.lblCoolLinacFlow.TabIndex = 123
        Me.lblCoolLinacFlow.Text = "0"
        Me.lblCoolLinacFlow.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label143
        '
        Me.Label143.AutoSize = True
        Me.Label143.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label143.ForeColor = System.Drawing.Color.Black
        Me.Label143.Location = New System.Drawing.Point(70, 85)
        Me.Label143.Name = "Label143"
        Me.Label143.Size = New System.Drawing.Size(135, 21)
        Me.Label143.TabIndex = 130
        Me.Label143.Text = "Magnetron Flow"
        '
        'lblCoolMagFlow
        '
        Me.lblCoolMagFlow.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCoolMagFlow.ForeColor = System.Drawing.Color.Black
        Me.lblCoolMagFlow.Location = New System.Drawing.Point(211, 85)
        Me.lblCoolMagFlow.Name = "lblCoolMagFlow"
        Me.lblCoolMagFlow.Size = New System.Drawing.Size(60, 20)
        Me.lblCoolMagFlow.TabIndex = 125
        Me.lblCoolMagFlow.Text = "0"
        Me.lblCoolMagFlow.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label66
        '
        Me.Label66.AutoSize = True
        Me.Label66.BackColor = System.Drawing.SystemColors.Control
        Me.Label66.Font = New System.Drawing.Font("Segoe UI Semibold", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label66.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.Label66.Location = New System.Drawing.Point(242, 11)
        Me.Label66.Name = "Label66"
        Me.Label66.Size = New System.Drawing.Size(196, 45)
        Me.Label66.TabIndex = 2
        Me.Label66.Text = "Cooling/SF6"
        '
        'BlueRect6
        '
        Me.BlueRect6.Enabled = False
        Me.BlueRect6.Location = New System.Drawing.Point(38, 60)
        Me.BlueRect6.MyBorderColor = System.Drawing.Color.Black
        Me.BlueRect6.MyBorderWidth = 0.001!
        Me.BlueRect6.Name = "BlueRect6"
        Me.BlueRect6.Size = New System.Drawing.Size(605, 228)
        Me.BlueRect6.TabIndex = 106
        '
        'TabPagePulseSync
        '
        Me.TabPagePulseSync.BackColor = System.Drawing.SystemColors.Control
        Me.TabPagePulseSync.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TabPagePulseSync.Controls.Add(Me.btnPulseSampleDelay)
        Me.TabPagePulseSync.Controls.Add(Me.btnPfnDelay)
        Me.TabPagePulseSync.Controls.Add(Me.btnAfcDelay)
        Me.TabPagePulseSync.Controls.Add(Me.btnPulseStopMin)
        Me.TabPagePulseSync.Controls.Add(Me.btnPulseStartMin)
        Me.TabPagePulseSync.Controls.Add(Me.btnPulseStop1_3)
        Me.TabPagePulseSync.Controls.Add(Me.btnPulseStart1_3)
        Me.TabPagePulseSync.Controls.Add(Me.btnPulseStop2_3)
        Me.TabPagePulseSync.Controls.Add(Me.btnPulseStart2_3)
        Me.TabPagePulseSync.Controls.Add(Me.btnPulseStopMax)
        Me.TabPagePulseSync.Controls.Add(Me.btnChangeSettingMode)
        Me.TabPagePulseSync.Controls.Add(Me.btnPulseStartMax)
        Me.TabPagePulseSync.Controls.Add(Me.ledWPulseLowOverride)
        Me.TabPagePulseSync.Controls.Add(Me.ledWPulseTrigFault)
        Me.TabPagePulseSync.Controls.Add(Me.ledPulseCanFault)
        Me.TabPagePulseSync.Controls.Add(Me.ledWPulseCustomHVon)
        Me.TabPagePulseSync.Controls.Add(Me.ledPulseKeylock)
        Me.TabPagePulseSync.Controls.Add(Me.ledPulseTriggerStayedOn)
        Me.TabPagePulseSync.Controls.Add(Me.ledPulsePFNfan)
        Me.TabPagePulseSync.Controls.Add(Me.ledWPulseCustomXrayOn)
        Me.TabPagePulseSync.Controls.Add(Me.ledPulseXrayTiming)
        Me.TabPagePulseSync.Controls.Add(Me.ledWPulseHighOverride)
        Me.TabPagePulseSync.Controls.Add(Me.ledPulseRFArc)
        Me.TabPagePulseSync.Controls.Add(Me.ledPulsePanel)
        Me.TabPagePulseSync.Controls.Add(Me.Label162)
        Me.TabPagePulseSync.Controls.Add(Me.Label1)
        Me.TabPagePulseSync.Controls.Add(Me.Label165)
        Me.TabPagePulseSync.Controls.Add(Me.Label167)
        Me.TabPagePulseSync.Controls.Add(Me.Label168)
        Me.TabPagePulseSync.Controls.Add(Me.Label169)
        Me.TabPagePulseSync.Controls.Add(Me.Label170)
        Me.TabPagePulseSync.Controls.Add(Me.Label171)
        Me.TabPagePulseSync.Controls.Add(Me.Label172)
        Me.TabPagePulseSync.Controls.Add(Me.Label174)
        Me.TabPagePulseSync.Controls.Add(Me.Label175)
        Me.TabPagePulseSync.Controls.Add(Me.Label176)
        Me.TabPagePulseSync.Controls.Add(Me.lblModeSettings)
        Me.TabPagePulseSync.Controls.Add(Me.Label67)
        Me.TabPagePulseSync.Controls.Add(Me.BlueRect5)
        Me.TabPagePulseSync.ForeColor = System.Drawing.Color.Blue
        Me.TabPagePulseSync.Location = New System.Drawing.Point(0, 0)
        Me.TabPagePulseSync.Name = "TabPagePulseSync"
        Me.TabPagePulseSync.Size = New System.Drawing.Size(680, 580)
        Me.TabPagePulseSync.TabIndex = 4
        Me.TabPagePulseSync.Text = "TabPage3"
        '
        'btnPulseSampleDelay
        '
        Me.btnPulseSampleDelay.BackColor = System.Drawing.Color.Blue
        Me.btnPulseSampleDelay.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPulseSampleDelay.Location = New System.Drawing.Point(369, 266)
        Me.btnPulseSampleDelay.Name = "btnPulseSampleDelay"
        Me.btnPulseSampleDelay.Size = New System.Drawing.Size(232, 30)
        Me.btnPulseSampleDelay.TabIndex = 135
        Me.btnPulseSampleDelay.Tag = "10"
        Me.btnPulseSampleDelay.Text = "Mag I Sample Delay   5"
        Me.btnPulseSampleDelay.UseVisualStyleBackColor = True
        '
        'btnPfnDelay
        '
        Me.btnPfnDelay.BackColor = System.Drawing.Color.Blue
        Me.btnPfnDelay.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPfnDelay.Location = New System.Drawing.Point(84, 266)
        Me.btnPfnDelay.Name = "btnPfnDelay"
        Me.btnPfnDelay.Size = New System.Drawing.Size(232, 30)
        Me.btnPfnDelay.TabIndex = 135
        Me.btnPfnDelay.Tag = "8"
        Me.btnPfnDelay.Text = "PFN Delay     20"
        Me.btnPfnDelay.UseVisualStyleBackColor = True
        '
        'btnAfcDelay
        '
        Me.btnAfcDelay.BackColor = System.Drawing.Color.Blue
        Me.btnAfcDelay.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAfcDelay.Location = New System.Drawing.Point(84, 301)
        Me.btnAfcDelay.Name = "btnAfcDelay"
        Me.btnAfcDelay.Size = New System.Drawing.Size(232, 30)
        Me.btnAfcDelay.TabIndex = 134
        Me.btnAfcDelay.Tag = "9"
        Me.btnAfcDelay.Text = "AFC Delay   10"
        Me.btnAfcDelay.UseVisualStyleBackColor = True
        '
        'btnPulseStopMin
        '
        Me.btnPulseStopMin.BackColor = System.Drawing.Color.Blue
        Me.btnPulseStopMin.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPulseStopMin.Location = New System.Drawing.Point(369, 231)
        Me.btnPulseStopMin.Name = "btnPulseStopMin"
        Me.btnPulseStopMin.Size = New System.Drawing.Size(232, 30)
        Me.btnPulseStopMin.TabIndex = 133
        Me.btnPulseStopMin.Tag = "7"
        Me.btnPulseStopMin.Text = "Beam Min Stop     2050"
        Me.btnPulseStopMin.UseVisualStyleBackColor = True
        '
        'btnPulseStartMin
        '
        Me.btnPulseStartMin.BackColor = System.Drawing.Color.Blue
        Me.btnPulseStartMin.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPulseStartMin.Location = New System.Drawing.Point(84, 231)
        Me.btnPulseStartMin.Name = "btnPulseStartMin"
        Me.btnPulseStartMin.Size = New System.Drawing.Size(232, 30)
        Me.btnPulseStartMin.TabIndex = 133
        Me.btnPulseStartMin.Tag = "3"
        Me.btnPulseStartMin.Text = "Beam Min Start     2025"
        Me.btnPulseStartMin.UseVisualStyleBackColor = True
        '
        'btnPulseStop1_3
        '
        Me.btnPulseStop1_3.BackColor = System.Drawing.Color.Blue
        Me.btnPulseStop1_3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPulseStop1_3.Location = New System.Drawing.Point(369, 196)
        Me.btnPulseStop1_3.Name = "btnPulseStop1_3"
        Me.btnPulseStop1_3.Size = New System.Drawing.Size(232, 30)
        Me.btnPulseStop1_3.TabIndex = 133
        Me.btnPulseStop1_3.Tag = "6"
        Me.btnPulseStop1_3.Text = "Beam 1/3  Stop     2050"
        Me.btnPulseStop1_3.UseVisualStyleBackColor = True
        '
        'btnPulseStart1_3
        '
        Me.btnPulseStart1_3.BackColor = System.Drawing.Color.Blue
        Me.btnPulseStart1_3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPulseStart1_3.Location = New System.Drawing.Point(84, 196)
        Me.btnPulseStart1_3.Name = "btnPulseStart1_3"
        Me.btnPulseStart1_3.Size = New System.Drawing.Size(232, 30)
        Me.btnPulseStart1_3.TabIndex = 133
        Me.btnPulseStart1_3.Tag = "2"
        Me.btnPulseStart1_3.Text = "Beam 1/3  Start     2025"
        Me.btnPulseStart1_3.UseVisualStyleBackColor = True
        '
        'btnPulseStop2_3
        '
        Me.btnPulseStop2_3.BackColor = System.Drawing.Color.Blue
        Me.btnPulseStop2_3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPulseStop2_3.Location = New System.Drawing.Point(369, 161)
        Me.btnPulseStop2_3.Name = "btnPulseStop2_3"
        Me.btnPulseStop2_3.Size = New System.Drawing.Size(232, 30)
        Me.btnPulseStop2_3.TabIndex = 133
        Me.btnPulseStop2_3.Tag = "5"
        Me.btnPulseStop2_3.Text = "Beam 2/3  Stop      2050"
        Me.btnPulseStop2_3.UseVisualStyleBackColor = True
        '
        'btnPulseStart2_3
        '
        Me.btnPulseStart2_3.BackColor = System.Drawing.Color.Blue
        Me.btnPulseStart2_3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPulseStart2_3.Location = New System.Drawing.Point(84, 161)
        Me.btnPulseStart2_3.Name = "btnPulseStart2_3"
        Me.btnPulseStart2_3.Size = New System.Drawing.Size(232, 30)
        Me.btnPulseStart2_3.TabIndex = 133
        Me.btnPulseStart2_3.Tag = "1"
        Me.btnPulseStart2_3.Text = "Beam 2/3  Start     2025"
        Me.btnPulseStart2_3.UseVisualStyleBackColor = True
        '
        'btnPulseStopMax
        '
        Me.btnPulseStopMax.BackColor = System.Drawing.Color.Blue
        Me.btnPulseStopMax.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPulseStopMax.Location = New System.Drawing.Point(369, 126)
        Me.btnPulseStopMax.Name = "btnPulseStopMax"
        Me.btnPulseStopMax.Size = New System.Drawing.Size(232, 30)
        Me.btnPulseStopMax.TabIndex = 133
        Me.btnPulseStopMax.Tag = "4"
        Me.btnPulseStopMax.Text = "Beam Max Stop     2050"
        Me.btnPulseStopMax.UseVisualStyleBackColor = True
        '
        'btnChangeSettingMode
        '
        Me.btnChangeSettingMode.BackColor = System.Drawing.Color.Blue
        Me.btnChangeSettingMode.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnChangeSettingMode.Location = New System.Drawing.Point(481, 77)
        Me.btnChangeSettingMode.Name = "btnChangeSettingMode"
        Me.btnChangeSettingMode.Size = New System.Drawing.Size(84, 30)
        Me.btnChangeSettingMode.TabIndex = 133
        Me.btnChangeSettingMode.Tag = "1"
        Me.btnChangeSettingMode.Text = "Change"
        Me.btnChangeSettingMode.UseVisualStyleBackColor = True
        '
        'btnPulseStartMax
        '
        Me.btnPulseStartMax.BackColor = System.Drawing.Color.Blue
        Me.btnPulseStartMax.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPulseStartMax.Location = New System.Drawing.Point(84, 126)
        Me.btnPulseStartMax.Name = "btnPulseStartMax"
        Me.btnPulseStartMax.Size = New System.Drawing.Size(232, 30)
        Me.btnPulseStartMax.TabIndex = 133
        Me.btnPulseStartMax.Tag = "0"
        Me.btnPulseStartMax.Text = "Beam Max Start     2025"
        Me.btnPulseStartMax.UseVisualStyleBackColor = True
        '
        'ledWPulseLowOverride
        '
        Me.ledWPulseLowOverride.FillColor = System.Drawing.SystemColors.Control
        Me.ledWPulseLowOverride.ForeColor = System.Drawing.Color.Black
        Me.ledWPulseLowOverride.Location = New System.Drawing.Point(356, 430)
        Me.ledWPulseLowOverride.MyBorderColor = System.Drawing.Color.Black
        Me.ledWPulseLowOverride.MyBorderWidth = 2
        Me.ledWPulseLowOverride.Name = "ledWPulseLowOverride"
        Me.ledWPulseLowOverride.Size = New System.Drawing.Size(18, 20)
        Me.ledWPulseLowOverride.TabIndex = 104
        '
        'ledWPulseTrigFault
        '
        Me.ledWPulseTrigFault.FillColor = System.Drawing.Color.Black
        Me.ledWPulseTrigFault.ForeColor = System.Drawing.Color.White
        Me.ledWPulseTrigFault.Location = New System.Drawing.Point(356, 482)
        Me.ledWPulseTrigFault.MyBorderColor = System.Drawing.Color.Black
        Me.ledWPulseTrigFault.MyBorderWidth = 2
        Me.ledWPulseTrigFault.Name = "ledWPulseTrigFault"
        Me.ledWPulseTrigFault.Size = New System.Drawing.Size(18, 20)
        Me.ledWPulseTrigFault.TabIndex = 109
        '
        'ledPulseCanFault
        '
        Me.ledPulseCanFault.FillColor = System.Drawing.Color.LawnGreen
        Me.ledPulseCanFault.ForeColor = System.Drawing.Color.White
        Me.ledPulseCanFault.Location = New System.Drawing.Point(132, 404)
        Me.ledPulseCanFault.MyBorderColor = System.Drawing.Color.Black
        Me.ledPulseCanFault.MyBorderWidth = 2
        Me.ledPulseCanFault.Name = "ledPulseCanFault"
        Me.ledPulseCanFault.Size = New System.Drawing.Size(18, 20)
        Me.ledPulseCanFault.TabIndex = 107
        '
        'ledWPulseCustomHVon
        '
        Me.ledWPulseCustomHVon.FillColor = System.Drawing.Color.Black
        Me.ledWPulseCustomHVon.ForeColor = System.Drawing.Color.White
        Me.ledWPulseCustomHVon.Location = New System.Drawing.Point(356, 378)
        Me.ledWPulseCustomHVon.MyBorderColor = System.Drawing.Color.Black
        Me.ledWPulseCustomHVon.MyBorderWidth = 2
        Me.ledWPulseCustomHVon.Name = "ledWPulseCustomHVon"
        Me.ledWPulseCustomHVon.Size = New System.Drawing.Size(18, 20)
        Me.ledWPulseCustomHVon.TabIndex = 108
        '
        'ledPulseKeylock
        '
        Me.ledPulseKeylock.FillColor = System.Drawing.Color.Red
        Me.ledPulseKeylock.ForeColor = System.Drawing.Color.White
        Me.ledPulseKeylock.Location = New System.Drawing.Point(132, 532)
        Me.ledPulseKeylock.MyBorderColor = System.Drawing.Color.Black
        Me.ledPulseKeylock.MyBorderWidth = 2
        Me.ledPulseKeylock.Name = "ledPulseKeylock"
        Me.ledPulseKeylock.Size = New System.Drawing.Size(18, 20)
        Me.ledPulseKeylock.TabIndex = 114
        '
        'ledPulseTriggerStayedOn
        '
        Me.ledPulseTriggerStayedOn.FillColor = System.Drawing.Color.LawnGreen
        Me.ledPulseTriggerStayedOn.ForeColor = System.Drawing.Color.White
        Me.ledPulseTriggerStayedOn.Location = New System.Drawing.Point(132, 482)
        Me.ledPulseTriggerStayedOn.MyBorderColor = System.Drawing.Color.Black
        Me.ledPulseTriggerStayedOn.MyBorderWidth = 2
        Me.ledPulseTriggerStayedOn.Name = "ledPulseTriggerStayedOn"
        Me.ledPulseTriggerStayedOn.Size = New System.Drawing.Size(18, 20)
        Me.ledPulseTriggerStayedOn.TabIndex = 111
        '
        'ledPulsePFNfan
        '
        Me.ledPulsePFNfan.FillColor = System.Drawing.Color.LawnGreen
        Me.ledPulsePFNfan.ForeColor = System.Drawing.Color.White
        Me.ledPulsePFNfan.Location = New System.Drawing.Point(132, 456)
        Me.ledPulsePFNfan.MyBorderColor = System.Drawing.Color.Black
        Me.ledPulsePFNfan.MyBorderWidth = 2
        Me.ledPulsePFNfan.Name = "ledPulsePFNfan"
        Me.ledPulsePFNfan.Size = New System.Drawing.Size(18, 20)
        Me.ledPulsePFNfan.TabIndex = 111
        '
        'ledWPulseCustomXrayOn
        '
        Me.ledWPulseCustomXrayOn.FillColor = System.Drawing.Color.Black
        Me.ledWPulseCustomXrayOn.ForeColor = System.Drawing.Color.White
        Me.ledWPulseCustomXrayOn.Location = New System.Drawing.Point(356, 404)
        Me.ledWPulseCustomXrayOn.MyBorderColor = System.Drawing.Color.Black
        Me.ledWPulseCustomXrayOn.MyBorderWidth = 2
        Me.ledWPulseCustomXrayOn.Name = "ledWPulseCustomXrayOn"
        Me.ledWPulseCustomXrayOn.Size = New System.Drawing.Size(18, 20)
        Me.ledWPulseCustomXrayOn.TabIndex = 112
        '
        'ledPulseXrayTiming
        '
        Me.ledPulseXrayTiming.FillColor = System.Drawing.Color.Red
        Me.ledPulseXrayTiming.ForeColor = System.Drawing.Color.White
        Me.ledPulseXrayTiming.Location = New System.Drawing.Point(132, 378)
        Me.ledPulseXrayTiming.MyBorderColor = System.Drawing.Color.Black
        Me.ledPulseXrayTiming.MyBorderWidth = 2
        Me.ledPulseXrayTiming.Name = "ledPulseXrayTiming"
        Me.ledPulseXrayTiming.Size = New System.Drawing.Size(18, 20)
        Me.ledPulseXrayTiming.TabIndex = 113
        '
        'ledWPulseHighOverride
        '
        Me.ledWPulseHighOverride.FillColor = System.Drawing.Color.Black
        Me.ledWPulseHighOverride.ForeColor = System.Drawing.Color.White
        Me.ledWPulseHighOverride.Location = New System.Drawing.Point(356, 456)
        Me.ledWPulseHighOverride.MyBorderColor = System.Drawing.Color.Black
        Me.ledWPulseHighOverride.MyBorderWidth = 2
        Me.ledWPulseHighOverride.Name = "ledWPulseHighOverride"
        Me.ledWPulseHighOverride.Size = New System.Drawing.Size(18, 20)
        Me.ledWPulseHighOverride.TabIndex = 101
        '
        'ledPulseRFArc
        '
        Me.ledPulseRFArc.FillColor = System.Drawing.Color.LawnGreen
        Me.ledPulseRFArc.ForeColor = System.Drawing.Color.White
        Me.ledPulseRFArc.Location = New System.Drawing.Point(132, 430)
        Me.ledPulseRFArc.MyBorderColor = System.Drawing.Color.Black
        Me.ledPulseRFArc.MyBorderWidth = 2
        Me.ledPulseRFArc.Name = "ledPulseRFArc"
        Me.ledPulseRFArc.Size = New System.Drawing.Size(18, 20)
        Me.ledPulseRFArc.TabIndex = 99
        '
        'ledPulsePanel
        '
        Me.ledPulsePanel.FillColor = System.Drawing.Color.LawnGreen
        Me.ledPulsePanel.ForeColor = System.Drawing.Color.White
        Me.ledPulsePanel.Location = New System.Drawing.Point(132, 508)
        Me.ledPulsePanel.MyBorderColor = System.Drawing.Color.Black
        Me.ledPulsePanel.MyBorderWidth = 2
        Me.ledPulsePanel.Name = "ledPulsePanel"
        Me.ledPulsePanel.Size = New System.Drawing.Size(18, 20)
        Me.ledPulsePanel.TabIndex = 100
        '
        'Label162
        '
        Me.Label162.AutoSize = True
        Me.Label162.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label162.ForeColor = System.Drawing.Color.Black
        Me.Label162.Location = New System.Drawing.Point(380, 430)
        Me.Label162.Name = "Label162"
        Me.Label162.Size = New System.Drawing.Size(79, 21)
        Me.Label162.TabIndex = 84
        Me.Label162.Text = "Cab Scan"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(156, 481)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(147, 21)
        Me.Label1.TabIndex = 88
        Me.Label1.Text = "Trigger Stayed On"
        '
        'Label165
        '
        Me.Label165.AutoSize = True
        Me.Label165.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label165.ForeColor = System.Drawing.Color.Black
        Me.Label165.Location = New System.Drawing.Point(380, 482)
        Me.Label165.Name = "Label165"
        Me.Label165.Size = New System.Drawing.Size(107, 21)
        Me.Label165.TabIndex = 87
        Me.Label165.Text = "Trigger Fault"
        '
        'Label167
        '
        Me.Label167.AutoSize = True
        Me.Label167.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label167.ForeColor = System.Drawing.Color.Black
        Me.Label167.Location = New System.Drawing.Point(156, 456)
        Me.Label167.Name = "Label167"
        Me.Label167.Size = New System.Drawing.Size(72, 21)
        Me.Label167.TabIndex = 88
        Me.Label167.Text = "PFN Fan"
        '
        'Label168
        '
        Me.Label168.AutoSize = True
        Me.Label168.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label168.ForeColor = System.Drawing.Color.Black
        Me.Label168.Location = New System.Drawing.Point(380, 404)
        Me.Label168.Name = "Label168"
        Me.Label168.Size = New System.Drawing.Size(157, 21)
        Me.Label168.TabIndex = 89
        Me.Label168.Text = "Customer X-Ray On"
        '
        'Label169
        '
        Me.Label169.AutoSize = True
        Me.Label169.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label169.ForeColor = System.Drawing.Color.Black
        Me.Label169.Location = New System.Drawing.Point(156, 404)
        Me.Label169.Name = "Label169"
        Me.Label169.Size = New System.Drawing.Size(86, 21)
        Me.Label169.TabIndex = 90
        Me.Label169.Text = "CAN Fault"
        '
        'Label170
        '
        Me.Label170.AutoSize = True
        Me.Label170.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label170.ForeColor = System.Drawing.Color.Black
        Me.Label170.Location = New System.Drawing.Point(380, 456)
        Me.Label170.Name = "Label170"
        Me.Label170.Size = New System.Drawing.Size(95, 21)
        Me.Label170.TabIndex = 98
        Me.Label170.Text = "Cargo Scan"
        '
        'Label171
        '
        Me.Label171.AutoSize = True
        Me.Label171.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label171.ForeColor = System.Drawing.Color.Black
        Me.Label171.Location = New System.Drawing.Point(156, 378)
        Me.Label171.Name = "Label171"
        Me.Label171.Size = New System.Drawing.Size(112, 21)
        Me.Label171.TabIndex = 91
        Me.Label171.Text = "X-Ray Timing"
        '
        'Label172
        '
        Me.Label172.AutoSize = True
        Me.Label172.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label172.ForeColor = System.Drawing.Color.Black
        Me.Label172.Location = New System.Drawing.Point(380, 378)
        Me.Label172.Name = "Label172"
        Me.Label172.Size = New System.Drawing.Size(136, 21)
        Me.Label172.TabIndex = 93
        Me.Label172.Text = "Customer HV On"
        '
        'Label174
        '
        Me.Label174.AutoSize = True
        Me.Label174.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label174.ForeColor = System.Drawing.Color.Black
        Me.Label174.Location = New System.Drawing.Point(156, 430)
        Me.Label174.Name = "Label174"
        Me.Label174.Size = New System.Drawing.Size(57, 21)
        Me.Label174.TabIndex = 95
        Me.Label174.Text = "RF Arc"
        '
        'Label175
        '
        Me.Label175.AutoSize = True
        Me.Label175.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label175.ForeColor = System.Drawing.Color.Black
        Me.Label175.Location = New System.Drawing.Point(156, 531)
        Me.Label175.Name = "Label175"
        Me.Label175.Size = New System.Drawing.Size(125, 21)
        Me.Label175.TabIndex = 96
        Me.Label175.Text = "Keylock Switch"
        '
        'Label176
        '
        Me.Label176.AutoSize = True
        Me.Label176.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label176.ForeColor = System.Drawing.Color.Black
        Me.Label176.Location = New System.Drawing.Point(156, 507)
        Me.Label176.Name = "Label176"
        Me.Label176.Size = New System.Drawing.Size(108, 21)
        Me.Label176.TabIndex = 97
        Me.Label176.Text = "Panel Switch"
        '
        'lblModeSettings
        '
        Me.lblModeSettings.BackColor = System.Drawing.SystemColors.Control
        Me.lblModeSettings.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblModeSettings.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.lblModeSettings.Location = New System.Drawing.Point(232, 77)
        Me.lblModeSettings.Name = "lblModeSettings"
        Me.lblModeSettings.Size = New System.Drawing.Size(216, 30)
        Me.lblModeSettings.TabIndex = 2
        Me.lblModeSettings.Text = "Cargo Mode Settings"
        Me.lblModeSettings.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label67
        '
        Me.Label67.AutoSize = True
        Me.Label67.BackColor = System.Drawing.SystemColors.Control
        Me.Label67.Font = New System.Drawing.Font("Segoe UI Semibold", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label67.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.Label67.Location = New System.Drawing.Point(253, 11)
        Me.Label67.Name = "Label67"
        Me.Label67.Size = New System.Drawing.Size(173, 45)
        Me.Label67.TabIndex = 2
        Me.Label67.Text = "Pulse Sync"
        '
        'BlueRect5
        '
        Me.BlueRect5.Enabled = False
        Me.BlueRect5.Location = New System.Drawing.Point(38, 60)
        Me.BlueRect5.MyBorderColor = System.Drawing.Color.Black
        Me.BlueRect5.MyBorderWidth = 0.001!
        Me.BlueRect5.Name = "BlueRect5"
        Me.BlueRect5.Size = New System.Drawing.Size(606, 300)
        Me.BlueRect5.TabIndex = 106
        '
        'TabPageHVsupply
        '
        Me.TabPageHVsupply.BackColor = System.Drawing.SystemColors.Control
        Me.TabPageHVsupply.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TabPageHVsupply.Controls.Add(Me.ledHVDriveup)
        Me.TabPageHVsupply.Controls.Add(Me.btnHVsetCab)
        Me.TabPageHVsupply.Controls.Add(Me.btnHVsetCargo)
        Me.TabPageHVsupply.Controls.Add(Me.ledWHvOT)
        Me.TabPageHVsupply.Controls.Add(Me.ledWHvLoadFault)
        Me.TabPageHVsupply.Controls.Add(Me.ledWHvHVoff)
        Me.TabPageHVsupply.Controls.Add(Me.ledWHvSumFault)
        Me.TabPageHVsupply.Controls.Add(Me.ledWHvPhaseLoss)
        Me.TabPageHVsupply.Controls.Add(Me.ledWHvIntlock)
        Me.TabPageHVsupply.Controls.Add(Me.ledWHvPowerOff)
        Me.TabPageHVsupply.Controls.Add(Me.ledHVCanFault)
        Me.TabPageHVsupply.Controls.Add(Me.Label158)
        Me.TabPageHVsupply.Controls.Add(Me.Label163)
        Me.TabPageHVsupply.Controls.Add(Me.Label164)
        Me.TabPageHVsupply.Controls.Add(Me.Label177)
        Me.TabPageHVsupply.Controls.Add(Me.Label178)
        Me.TabPageHVsupply.Controls.Add(Me.Label179)
        Me.TabPageHVsupply.Controls.Add(Me.Label181)
        Me.TabPageHVsupply.Controls.Add(Me.Label182)
        Me.TabPageHVsupply.Controls.Add(Me.Label183)
        Me.TabPageHVsupply.Controls.Add(Me.Label198)
        Me.TabPageHVsupply.Controls.Add(Me.Label199)
        Me.TabPageHVsupply.Controls.Add(Me.Label208)
        Me.TabPageHVsupply.Controls.Add(Me.lblHVcurrent)
        Me.TabPageHVsupply.Controls.Add(Me.Label210)
        Me.TabPageHVsupply.Controls.Add(Me.lblHVprePulseVolt)
        Me.TabPageHVsupply.Controls.Add(Me.Label68)
        Me.TabPageHVsupply.Controls.Add(Me.BlueRect9)
        Me.TabPageHVsupply.ForeColor = System.Drawing.Color.Black
        Me.TabPageHVsupply.Location = New System.Drawing.Point(0, 0)
        Me.TabPageHVsupply.Name = "TabPageHVsupply"
        Me.TabPageHVsupply.Size = New System.Drawing.Size(680, 580)
        Me.TabPageHVsupply.TabIndex = 5
        Me.TabPageHVsupply.Text = "TabPage4"
        '
        'ledHVDriveup
        '
        Me.ledHVDriveup.FillColor = System.Drawing.Color.LawnGreen
        Me.ledHVDriveup.ForeColor = System.Drawing.Color.White
        Me.ledHVDriveup.Location = New System.Drawing.Point(137, 317)
        Me.ledHVDriveup.MyBorderColor = System.Drawing.Color.Black
        Me.ledHVDriveup.MyBorderWidth = 2
        Me.ledHVDriveup.Name = "ledHVDriveup"
        Me.ledHVDriveup.Size = New System.Drawing.Size(18, 20)
        Me.ledHVDriveup.TabIndex = 124
        '
        'btnHVsetCab
        '
        Me.btnHVsetCab.BackColor = System.Drawing.Color.Blue
        Me.btnHVsetCab.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHVsetCab.ForeColor = System.Drawing.Color.Blue
        Me.btnHVsetCab.Location = New System.Drawing.Point(374, 145)
        Me.btnHVsetCab.Name = "btnHVsetCab"
        Me.btnHVsetCab.Size = New System.Drawing.Size(238, 33)
        Me.btnHVsetCab.TabIndex = 122
        Me.btnHVsetCab.Tag = "1"
        Me.btnHVsetCab.Text = "Cab V Set       0.000 kV"
        Me.btnHVsetCab.UseVisualStyleBackColor = True
        '
        'btnHVsetCargo
        '
        Me.btnHVsetCargo.BackColor = System.Drawing.Color.Blue
        Me.btnHVsetCargo.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHVsetCargo.ForeColor = System.Drawing.Color.Blue
        Me.btnHVsetCargo.Location = New System.Drawing.Point(374, 91)
        Me.btnHVsetCargo.Name = "btnHVsetCargo"
        Me.btnHVsetCargo.Size = New System.Drawing.Size(238, 33)
        Me.btnHVsetCargo.TabIndex = 122
        Me.btnHVsetCargo.Tag = "1"
        Me.btnHVsetCargo.Text = "Cargo V Set     0.000 kV"
        Me.btnHVsetCargo.UseVisualStyleBackColor = True
        '
        'ledWHvOT
        '
        Me.ledWHvOT.FillColor = System.Drawing.SystemColors.Control
        Me.ledWHvOT.ForeColor = System.Drawing.Color.Black
        Me.ledWHvOT.Location = New System.Drawing.Point(374, 375)
        Me.ledWHvOT.MyBorderColor = System.Drawing.Color.Black
        Me.ledWHvOT.MyBorderWidth = 2
        Me.ledWHvOT.Name = "ledWHvOT"
        Me.ledWHvOT.Size = New System.Drawing.Size(18, 20)
        Me.ledWHvOT.TabIndex = 93
        '
        'ledWHvLoadFault
        '
        Me.ledWHvLoadFault.FillColor = System.Drawing.SystemColors.Control
        Me.ledWHvLoadFault.ForeColor = System.Drawing.Color.Black
        Me.ledWHvLoadFault.Location = New System.Drawing.Point(374, 433)
        Me.ledWHvLoadFault.MyBorderColor = System.Drawing.Color.Black
        Me.ledWHvLoadFault.MyBorderWidth = 2
        Me.ledWHvLoadFault.Name = "ledWHvLoadFault"
        Me.ledWHvLoadFault.Size = New System.Drawing.Size(18, 20)
        Me.ledWHvLoadFault.TabIndex = 98
        '
        'ledWHvHVoff
        '
        Me.ledWHvHVoff.FillColor = System.Drawing.SystemColors.Control
        Me.ledWHvHVoff.ForeColor = System.Drawing.Color.Black
        Me.ledWHvHVoff.Location = New System.Drawing.Point(374, 317)
        Me.ledWHvHVoff.MyBorderColor = System.Drawing.Color.Black
        Me.ledWHvHVoff.MyBorderWidth = 2
        Me.ledWHvHVoff.Name = "ledWHvHVoff"
        Me.ledWHvHVoff.Size = New System.Drawing.Size(18, 20)
        Me.ledWHvHVoff.TabIndex = 97
        '
        'ledWHvSumFault
        '
        Me.ledWHvSumFault.FillColor = System.Drawing.Color.Black
        Me.ledWHvSumFault.ForeColor = System.Drawing.Color.White
        Me.ledWHvSumFault.Location = New System.Drawing.Point(374, 462)
        Me.ledWHvSumFault.MyBorderColor = System.Drawing.Color.Black
        Me.ledWHvSumFault.MyBorderWidth = 2
        Me.ledWHvSumFault.Name = "ledWHvSumFault"
        Me.ledWHvSumFault.Size = New System.Drawing.Size(18, 20)
        Me.ledWHvSumFault.TabIndex = 103
        '
        'ledWHvPhaseLoss
        '
        Me.ledWHvPhaseLoss.FillColor = System.Drawing.SystemColors.Control
        Me.ledWHvPhaseLoss.ForeColor = System.Drawing.Color.Black
        Me.ledWHvPhaseLoss.Location = New System.Drawing.Point(374, 346)
        Me.ledWHvPhaseLoss.MyBorderColor = System.Drawing.Color.Black
        Me.ledWHvPhaseLoss.MyBorderWidth = 2
        Me.ledWHvPhaseLoss.Name = "ledWHvPhaseLoss"
        Me.ledWHvPhaseLoss.Size = New System.Drawing.Size(18, 20)
        Me.ledWHvPhaseLoss.TabIndex = 99
        '
        'ledWHvIntlock
        '
        Me.ledWHvIntlock.FillColor = System.Drawing.SystemColors.Control
        Me.ledWHvIntlock.ForeColor = System.Drawing.Color.Black
        Me.ledWHvIntlock.Location = New System.Drawing.Point(374, 404)
        Me.ledWHvIntlock.MyBorderColor = System.Drawing.Color.Black
        Me.ledWHvIntlock.MyBorderWidth = 2
        Me.ledWHvIntlock.Name = "ledWHvIntlock"
        Me.ledWHvIntlock.Size = New System.Drawing.Size(18, 20)
        Me.ledWHvIntlock.TabIndex = 95
        '
        'ledWHvPowerOff
        '
        Me.ledWHvPowerOff.FillColor = System.Drawing.SystemColors.Control
        Me.ledWHvPowerOff.ForeColor = System.Drawing.Color.White
        Me.ledWHvPowerOff.Location = New System.Drawing.Point(374, 288)
        Me.ledWHvPowerOff.MyBorderColor = System.Drawing.Color.Black
        Me.ledWHvPowerOff.MyBorderWidth = 2
        Me.ledWHvPowerOff.Name = "ledWHvPowerOff"
        Me.ledWHvPowerOff.Size = New System.Drawing.Size(18, 20)
        Me.ledWHvPowerOff.TabIndex = 102
        '
        'ledHVCanFault
        '
        Me.ledHVCanFault.FillColor = System.Drawing.Color.LawnGreen
        Me.ledHVCanFault.ForeColor = System.Drawing.Color.White
        Me.ledHVCanFault.Location = New System.Drawing.Point(137, 288)
        Me.ledHVCanFault.MyBorderColor = System.Drawing.Color.Black
        Me.ledHVCanFault.MyBorderWidth = 2
        Me.ledHVCanFault.Name = "ledHVCanFault"
        Me.ledHVCanFault.Size = New System.Drawing.Size(18, 20)
        Me.ledHVCanFault.TabIndex = 101
        '
        'Label158
        '
        Me.Label158.AutoSize = True
        Me.Label158.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label158.ForeColor = System.Drawing.Color.Black
        Me.Label158.Location = New System.Drawing.Point(398, 375)
        Me.Label158.Name = "Label158"
        Me.Label158.Size = New System.Drawing.Size(93, 21)
        Me.Label158.TabIndex = 90
        Me.Label158.Text = "Over Temp"
        '
        'Label163
        '
        Me.Label163.AutoSize = True
        Me.Label163.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label163.ForeColor = System.Drawing.Color.Black
        Me.Label163.Location = New System.Drawing.Point(398, 346)
        Me.Label163.Name = "Label163"
        Me.Label163.Size = New System.Drawing.Size(91, 21)
        Me.Label163.TabIndex = 88
        Me.Label163.Text = "Phase Loss"
        '
        'Label164
        '
        Me.Label164.AutoSize = True
        Me.Label164.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label164.ForeColor = System.Drawing.Color.Black
        Me.Label164.Location = New System.Drawing.Point(398, 433)
        Me.Label164.Name = "Label164"
        Me.Label164.Size = New System.Drawing.Size(89, 21)
        Me.Label164.TabIndex = 87
        Me.Label164.Text = "Load Fault"
        '
        'Label177
        '
        Me.Label177.AutoSize = True
        Me.Label177.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label177.ForeColor = System.Drawing.Color.Black
        Me.Label177.Location = New System.Drawing.Point(398, 404)
        Me.Label177.Name = "Label177"
        Me.Label177.Size = New System.Drawing.Size(78, 21)
        Me.Label177.TabIndex = 86
        Me.Label177.Text = "Interlock"
        '
        'Label178
        '
        Me.Label178.AutoSize = True
        Me.Label178.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label178.ForeColor = System.Drawing.Color.Black
        Me.Label178.Location = New System.Drawing.Point(161, 317)
        Me.Label178.Name = "Label178"
        Me.Label178.Size = New System.Drawing.Size(119, 21)
        Me.Label178.TabIndex = 85
        Me.Label178.Text = "Drive Up Fault"
        '
        'Label179
        '
        Me.Label179.AutoSize = True
        Me.Label179.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label179.ForeColor = System.Drawing.Color.Black
        Me.Label179.Location = New System.Drawing.Point(398, 317)
        Me.Label179.Name = "Label179"
        Me.Label179.Size = New System.Drawing.Size(61, 21)
        Me.Label179.TabIndex = 80
        Me.Label179.Text = "HV Off"
        '
        'Label181
        '
        Me.Label181.AutoSize = True
        Me.Label181.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label181.ForeColor = System.Drawing.Color.Black
        Me.Label181.Location = New System.Drawing.Point(398, 288)
        Me.Label181.Name = "Label181"
        Me.Label181.Size = New System.Drawing.Size(86, 21)
        Me.Label181.TabIndex = 83
        Me.Label181.Text = "Power Off"
        '
        'Label182
        '
        Me.Label182.AutoSize = True
        Me.Label182.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label182.ForeColor = System.Drawing.Color.Black
        Me.Label182.Location = New System.Drawing.Point(398, 462)
        Me.Label182.Name = "Label182"
        Me.Label182.Size = New System.Drawing.Size(86, 21)
        Me.Label182.TabIndex = 82
        Me.Label182.Text = "Sum Fault"
        '
        'Label183
        '
        Me.Label183.AutoSize = True
        Me.Label183.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label183.ForeColor = System.Drawing.Color.Black
        Me.Label183.Location = New System.Drawing.Point(161, 288)
        Me.Label183.Name = "Label183"
        Me.Label183.Size = New System.Drawing.Size(86, 21)
        Me.Label183.TabIndex = 81
        Me.Label183.Text = "CAN Fault"
        '
        'Label198
        '
        Me.Label198.AutoSize = True
        Me.Label198.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label198.ForeColor = System.Drawing.Color.Black
        Me.Label198.Location = New System.Drawing.Point(296, 151)
        Me.Label198.Name = "Label198"
        Me.Label198.Size = New System.Drawing.Size(21, 21)
        Me.Label198.TabIndex = 106
        Me.Label198.Text = "A"
        '
        'Label199
        '
        Me.Label199.AutoSize = True
        Me.Label199.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label199.ForeColor = System.Drawing.Color.Black
        Me.Label199.Location = New System.Drawing.Point(296, 104)
        Me.Label199.Name = "Label199"
        Me.Label199.Size = New System.Drawing.Size(30, 21)
        Me.Label199.TabIndex = 105
        Me.Label199.Text = "kV"
        '
        'Label208
        '
        Me.Label208.AutoSize = True
        Me.Label208.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label208.ForeColor = System.Drawing.Color.Black
        Me.Label208.Location = New System.Drawing.Point(65, 151)
        Me.Label208.Name = "Label208"
        Me.Label208.Size = New System.Drawing.Size(67, 21)
        Me.Label208.TabIndex = 121
        Me.Label208.Text = "Current"
        '
        'lblHVcurrent
        '
        Me.lblHVcurrent.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHVcurrent.ForeColor = System.Drawing.Color.Black
        Me.lblHVcurrent.Location = New System.Drawing.Point(200, 151)
        Me.lblHVcurrent.Name = "lblHVcurrent"
        Me.lblHVcurrent.Size = New System.Drawing.Size(90, 20)
        Me.lblHVcurrent.TabIndex = 112
        Me.lblHVcurrent.Text = "0"
        Me.lblHVcurrent.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label210
        '
        Me.Label210.AutoSize = True
        Me.Label210.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label210.ForeColor = System.Drawing.Color.Black
        Me.Label210.Location = New System.Drawing.Point(65, 104)
        Me.Label210.Name = "Label210"
        Me.Label210.Size = New System.Drawing.Size(140, 21)
        Me.Label210.TabIndex = 119
        Me.Label210.Text = "PrePulse Voltage"
        '
        'lblHVprePulseVolt
        '
        Me.lblHVprePulseVolt.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHVprePulseVolt.ForeColor = System.Drawing.Color.Black
        Me.lblHVprePulseVolt.Location = New System.Drawing.Point(204, 104)
        Me.lblHVprePulseVolt.Name = "lblHVprePulseVolt"
        Me.lblHVprePulseVolt.Size = New System.Drawing.Size(86, 20)
        Me.lblHVprePulseVolt.TabIndex = 114
        Me.lblHVprePulseVolt.Text = "0"
        Me.lblHVprePulseVolt.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label68
        '
        Me.Label68.AutoSize = True
        Me.Label68.BackColor = System.Drawing.SystemColors.Control
        Me.Label68.Font = New System.Drawing.Font("Segoe UI Semibold", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label68.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.Label68.Location = New System.Drawing.Point(204, 11)
        Me.Label68.Name = "Label68"
        Me.Label68.Size = New System.Drawing.Size(272, 45)
        Me.Label68.TabIndex = 2
        Me.Label68.Text = "HV Power Supply"
        '
        'BlueRect9
        '
        Me.BlueRect9.Enabled = False
        Me.BlueRect9.Location = New System.Drawing.Point(33, 60)
        Me.BlueRect9.MyBorderColor = System.Drawing.Color.Black
        Me.BlueRect9.MyBorderWidth = 0.001!
        Me.BlueRect9.Name = "BlueRect9"
        Me.BlueRect9.Size = New System.Drawing.Size(611, 179)
        Me.BlueRect9.TabIndex = 80
        '
        'TabPageMagnetron
        '
        Me.TabPageMagnetron.BackColor = System.Drawing.SystemColors.Control
        Me.TabPageMagnetron.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TabPageMagnetron.Controls.Add(Me.PanelMagnetronLeds)
        Me.TabPageMagnetron.Controls.Add(Me.PanelArcCounts)
        Me.TabPageMagnetron.Controls.Add(Me.Label216)
        Me.TabPageMagnetron.Controls.Add(Me.Label217)
        Me.TabPageMagnetron.Controls.Add(Me.Label222)
        Me.TabPageMagnetron.Controls.Add(Me.lblCurrCabScan)
        Me.TabPageMagnetron.Controls.Add(Me.Label224)
        Me.TabPageMagnetron.Controls.Add(Me.lblCurrCargoScan)
        Me.TabPageMagnetron.Controls.Add(Me.Label228)
        Me.TabPageMagnetron.Controls.Add(Me.lblCurrPulsesTotal)
        Me.TabPageMagnetron.Controls.Add(Me.Label232)
        Me.TabPageMagnetron.Controls.Add(Me.lblCurrPulsesPwrOn)
        Me.TabPageMagnetron.Controls.Add(Me.Label69)
        Me.TabPageMagnetron.Controls.Add(Me.BlueRectMagnetron)
        Me.TabPageMagnetron.ForeColor = System.Drawing.Color.Black
        Me.TabPageMagnetron.Location = New System.Drawing.Point(0, 0)
        Me.TabPageMagnetron.Name = "TabPageMagnetron"
        Me.TabPageMagnetron.Size = New System.Drawing.Size(680, 580)
        Me.TabPageMagnetron.TabIndex = 6
        Me.TabPageMagnetron.Text = "TabPage5"
        '
        'PanelMagnetronLeds
        '
        Me.PanelMagnetronLeds.Controls.Add(Me.ledCurrArcCont)
        Me.PanelMagnetronLeds.Controls.Add(Me.ledCurrArcSlow)
        Me.PanelMagnetronLeds.Controls.Add(Me.ledCurrArcFast)
        Me.PanelMagnetronLeds.Controls.Add(Me.ledCurrLowPulseCurr)
        Me.PanelMagnetronLeds.Controls.Add(Me.ledCurrFalseTrig)
        Me.PanelMagnetronLeds.Controls.Add(Me.ledCurrCanFault)
        Me.PanelMagnetronLeds.Controls.Add(Me.Label197)
        Me.PanelMagnetronLeds.Controls.Add(Me.Label206)
        Me.PanelMagnetronLeds.Controls.Add(Me.Label103)
        Me.PanelMagnetronLeds.Controls.Add(Me.Label212)
        Me.PanelMagnetronLeds.Controls.Add(Me.Label214)
        Me.PanelMagnetronLeds.Controls.Add(Me.Label215)
        Me.PanelMagnetronLeds.Location = New System.Drawing.Point(72, 359)
        Me.PanelMagnetronLeds.Name = "PanelMagnetronLeds"
        Me.PanelMagnetronLeds.Size = New System.Drawing.Size(549, 152)
        Me.PanelMagnetronLeds.TabIndex = 123
        '
        'ledCurrArcCont
        '
        Me.ledCurrArcCont.FillColor = System.Drawing.Color.LawnGreen
        Me.ledCurrArcCont.ForeColor = System.Drawing.SystemColors.Control
        Me.ledCurrArcCont.Location = New System.Drawing.Point(308, 15)
        Me.ledCurrArcCont.MyBorderColor = System.Drawing.Color.Black
        Me.ledCurrArcCont.MyBorderWidth = 2
        Me.ledCurrArcCont.Name = "ledCurrArcCont"
        Me.ledCurrArcCont.Size = New System.Drawing.Size(18, 20)
        Me.ledCurrArcCont.TabIndex = 94
        '
        'ledCurrArcSlow
        '
        Me.ledCurrArcSlow.FillColor = System.Drawing.Color.LawnGreen
        Me.ledCurrArcSlow.ForeColor = System.Drawing.SystemColors.Control
        Me.ledCurrArcSlow.Location = New System.Drawing.Point(104, 54)
        Me.ledCurrArcSlow.MyBorderColor = System.Drawing.Color.Black
        Me.ledCurrArcSlow.MyBorderWidth = 2
        Me.ledCurrArcSlow.Name = "ledCurrArcSlow"
        Me.ledCurrArcSlow.Size = New System.Drawing.Size(18, 20)
        Me.ledCurrArcSlow.TabIndex = 103
        '
        'ledCurrArcFast
        '
        Me.ledCurrArcFast.FillColor = System.Drawing.Color.Red
        Me.ledCurrArcFast.ForeColor = System.Drawing.SystemColors.Control
        Me.ledCurrArcFast.Location = New System.Drawing.Point(104, 93)
        Me.ledCurrArcFast.MyBorderColor = System.Drawing.Color.Black
        Me.ledCurrArcFast.MyBorderWidth = 2
        Me.ledCurrArcFast.Name = "ledCurrArcFast"
        Me.ledCurrArcFast.Size = New System.Drawing.Size(18, 20)
        Me.ledCurrArcFast.TabIndex = 100
        '
        'ledCurrLowPulseCurr
        '
        Me.ledCurrLowPulseCurr.FillColor = System.Drawing.Color.LawnGreen
        Me.ledCurrLowPulseCurr.ForeColor = System.Drawing.SystemColors.Control
        Me.ledCurrLowPulseCurr.Location = New System.Drawing.Point(308, 93)
        Me.ledCurrLowPulseCurr.MyBorderColor = System.Drawing.Color.Black
        Me.ledCurrLowPulseCurr.MyBorderWidth = 2
        Me.ledCurrLowPulseCurr.Name = "ledCurrLowPulseCurr"
        Me.ledCurrLowPulseCurr.Size = New System.Drawing.Size(18, 20)
        Me.ledCurrLowPulseCurr.TabIndex = 92
        '
        'ledCurrFalseTrig
        '
        Me.ledCurrFalseTrig.FillColor = System.Drawing.Color.LawnGreen
        Me.ledCurrFalseTrig.ForeColor = System.Drawing.SystemColors.Control
        Me.ledCurrFalseTrig.Location = New System.Drawing.Point(308, 54)
        Me.ledCurrFalseTrig.MyBorderColor = System.Drawing.Color.Black
        Me.ledCurrFalseTrig.MyBorderWidth = 2
        Me.ledCurrFalseTrig.Name = "ledCurrFalseTrig"
        Me.ledCurrFalseTrig.Size = New System.Drawing.Size(18, 20)
        Me.ledCurrFalseTrig.TabIndex = 92
        '
        'ledCurrCanFault
        '
        Me.ledCurrCanFault.FillColor = System.Drawing.Color.LawnGreen
        Me.ledCurrCanFault.ForeColor = System.Drawing.SystemColors.Control
        Me.ledCurrCanFault.Location = New System.Drawing.Point(104, 15)
        Me.ledCurrCanFault.MyBorderColor = System.Drawing.Color.Black
        Me.ledCurrCanFault.MyBorderWidth = 2
        Me.ledCurrCanFault.Name = "ledCurrCanFault"
        Me.ledCurrCanFault.Size = New System.Drawing.Size(18, 20)
        Me.ledCurrCanFault.TabIndex = 101
        '
        'Label197
        '
        Me.Label197.AutoSize = True
        Me.Label197.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label197.ForeColor = System.Drawing.Color.Black
        Me.Label197.Location = New System.Drawing.Point(332, 15)
        Me.Label197.Name = "Label197"
        Me.Label197.Size = New System.Drawing.Size(75, 21)
        Me.Label197.TabIndex = 91
        Me.Label197.Text = "Arc Cont"
        '
        'Label206
        '
        Me.Label206.AutoSize = True
        Me.Label206.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label206.ForeColor = System.Drawing.Color.Black
        Me.Label206.Location = New System.Drawing.Point(128, 93)
        Me.Label206.Name = "Label206"
        Me.Label206.Size = New System.Drawing.Size(69, 21)
        Me.Label206.TabIndex = 85
        Me.Label206.Text = "Arc Fast"
        '
        'Label103
        '
        Me.Label103.AutoSize = True
        Me.Label103.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label103.ForeColor = System.Drawing.Color.Black
        Me.Label103.Location = New System.Drawing.Point(332, 93)
        Me.Label103.Name = "Label103"
        Me.Label103.Size = New System.Drawing.Size(147, 21)
        Me.Label103.TabIndex = 84
        Me.Label103.Text = "Low Pulse Current"
        '
        'Label212
        '
        Me.Label212.AutoSize = True
        Me.Label212.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label212.ForeColor = System.Drawing.Color.Black
        Me.Label212.Location = New System.Drawing.Point(332, 54)
        Me.Label212.Name = "Label212"
        Me.Label212.Size = New System.Drawing.Size(107, 21)
        Me.Label212.TabIndex = 84
        Me.Label212.Text = "False Trigger"
        '
        'Label214
        '
        Me.Label214.AutoSize = True
        Me.Label214.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label214.ForeColor = System.Drawing.Color.Black
        Me.Label214.Location = New System.Drawing.Point(128, 54)
        Me.Label214.Name = "Label214"
        Me.Label214.Size = New System.Drawing.Size(76, 21)
        Me.Label214.TabIndex = 82
        Me.Label214.Text = "Arc Slow"
        '
        'Label215
        '
        Me.Label215.AutoSize = True
        Me.Label215.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label215.ForeColor = System.Drawing.Color.Black
        Me.Label215.Location = New System.Drawing.Point(128, 15)
        Me.Label215.Name = "Label215"
        Me.Label215.Size = New System.Drawing.Size(86, 21)
        Me.Label215.TabIndex = 81
        Me.Label215.Text = "CAN Fault"
        '
        'PanelArcCounts
        '
        Me.PanelArcCounts.Controls.Add(Me.Label230)
        Me.PanelArcCounts.Controls.Add(Me.lblCurrArcsPwrOn)
        Me.PanelArcCounts.Controls.Add(Me.lblCurrArcsTotal)
        Me.PanelArcCounts.Controls.Add(Me.Label226)
        Me.PanelArcCounts.Controls.Add(Me.lblCurrPulsesOutOfRange)
        Me.PanelArcCounts.Controls.Add(Me.Label97)
        Me.PanelArcCounts.Location = New System.Drawing.Point(140, 207)
        Me.PanelArcCounts.Name = "PanelArcCounts"
        Me.PanelArcCounts.Size = New System.Drawing.Size(405, 94)
        Me.PanelArcCounts.TabIndex = 122
        '
        'Label230
        '
        Me.Label230.AutoSize = True
        Me.Label230.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label230.ForeColor = System.Drawing.Color.Black
        Me.Label230.Location = New System.Drawing.Point(21, 1)
        Me.Label230.Name = "Label230"
        Me.Label230.Size = New System.Drawing.Size(165, 21)
        Me.Label230.TabIndex = 121
        Me.Label230.Text = "Arcs Since Power On"
        '
        'lblCurrArcsPwrOn
        '
        Me.lblCurrArcsPwrOn.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCurrArcsPwrOn.ForeColor = System.Drawing.Color.Black
        Me.lblCurrArcsPwrOn.Location = New System.Drawing.Point(220, 1)
        Me.lblCurrArcsPwrOn.Name = "lblCurrArcsPwrOn"
        Me.lblCurrArcsPwrOn.Size = New System.Drawing.Size(136, 20)
        Me.lblCurrArcsPwrOn.TabIndex = 112
        Me.lblCurrArcsPwrOn.Text = "0"
        Me.lblCurrArcsPwrOn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblCurrArcsTotal
        '
        Me.lblCurrArcsTotal.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCurrArcsTotal.ForeColor = System.Drawing.Color.Black
        Me.lblCurrArcsTotal.Location = New System.Drawing.Point(220, 31)
        Me.lblCurrArcsTotal.Name = "lblCurrArcsTotal"
        Me.lblCurrArcsTotal.Size = New System.Drawing.Size(136, 20)
        Me.lblCurrArcsTotal.TabIndex = 110
        Me.lblCurrArcsTotal.Text = "0"
        Me.lblCurrArcsTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label226
        '
        Me.Label226.AutoSize = True
        Me.Label226.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label226.ForeColor = System.Drawing.Color.Black
        Me.Label226.Location = New System.Drawing.Point(21, 31)
        Me.Label226.Name = "Label226"
        Me.Label226.Size = New System.Drawing.Size(85, 21)
        Me.Label226.TabIndex = 118
        Me.Label226.Text = "Arcs Total"
        '
        'lblCurrPulsesOutOfRange
        '
        Me.lblCurrPulsesOutOfRange.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCurrPulsesOutOfRange.ForeColor = System.Drawing.Color.Black
        Me.lblCurrPulsesOutOfRange.Location = New System.Drawing.Point(220, 61)
        Me.lblCurrPulsesOutOfRange.Name = "lblCurrPulsesOutOfRange"
        Me.lblCurrPulsesOutOfRange.Size = New System.Drawing.Size(136, 20)
        Me.lblCurrPulsesOutOfRange.TabIndex = 115
        Me.lblCurrPulsesOutOfRange.Text = "0"
        Me.lblCurrPulsesOutOfRange.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label97
        '
        Me.Label97.AutoSize = True
        Me.Label97.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label97.ForeColor = System.Drawing.Color.Black
        Me.Label97.Location = New System.Drawing.Point(21, 61)
        Me.Label97.Name = "Label97"
        Me.Label97.Size = New System.Drawing.Size(164, 21)
        Me.Label97.TabIndex = 117
        Me.Label97.Text = "Pulses Out Of Range"
        '
        'Label216
        '
        Me.Label216.AutoSize = True
        Me.Label216.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label216.ForeColor = System.Drawing.Color.Black
        Me.Label216.Location = New System.Drawing.Point(502, 118)
        Me.Label216.Name = "Label216"
        Me.Label216.Size = New System.Drawing.Size(21, 21)
        Me.Label216.TabIndex = 108
        Me.Label216.Text = "A"
        '
        'Label217
        '
        Me.Label217.AutoSize = True
        Me.Label217.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label217.ForeColor = System.Drawing.Color.Black
        Me.Label217.Location = New System.Drawing.Point(502, 88)
        Me.Label217.Name = "Label217"
        Me.Label217.Size = New System.Drawing.Size(21, 21)
        Me.Label217.TabIndex = 104
        Me.Label217.Text = "A"
        '
        'Label222
        '
        Me.Label222.AutoSize = True
        Me.Label222.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label222.ForeColor = System.Drawing.Color.Black
        Me.Label222.Location = New System.Drawing.Point(161, 118)
        Me.Label222.Name = "Label222"
        Me.Label222.Size = New System.Drawing.Size(140, 21)
        Me.Label222.TabIndex = 117
        Me.Label222.Text = "Cab Scan Current"
        '
        'lblCurrCabScan
        '
        Me.lblCurrCabScan.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCurrCabScan.ForeColor = System.Drawing.Color.Black
        Me.lblCurrCabScan.Location = New System.Drawing.Point(360, 118)
        Me.lblCurrCabScan.Name = "lblCurrCabScan"
        Me.lblCurrCabScan.Size = New System.Drawing.Size(136, 20)
        Me.lblCurrCabScan.TabIndex = 115
        Me.lblCurrCabScan.Text = "0"
        Me.lblCurrCabScan.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label224
        '
        Me.Label224.AutoSize = True
        Me.Label224.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label224.ForeColor = System.Drawing.Color.Black
        Me.Label224.Location = New System.Drawing.Point(161, 88)
        Me.Label224.Name = "Label224"
        Me.Label224.Size = New System.Drawing.Size(156, 21)
        Me.Label224.TabIndex = 116
        Me.Label224.Text = "Cargo Scan Current"
        '
        'lblCurrCargoScan
        '
        Me.lblCurrCargoScan.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCurrCargoScan.ForeColor = System.Drawing.Color.Black
        Me.lblCurrCargoScan.Location = New System.Drawing.Point(360, 88)
        Me.lblCurrCargoScan.Name = "lblCurrCargoScan"
        Me.lblCurrCargoScan.Size = New System.Drawing.Size(136, 20)
        Me.lblCurrCargoScan.TabIndex = 113
        Me.lblCurrCargoScan.Text = "0"
        Me.lblCurrCargoScan.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label228
        '
        Me.Label228.AutoSize = True
        Me.Label228.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label228.ForeColor = System.Drawing.Color.Black
        Me.Label228.Location = New System.Drawing.Point(161, 178)
        Me.Label228.Name = "Label228"
        Me.Label228.Size = New System.Drawing.Size(94, 21)
        Me.Label228.TabIndex = 120
        Me.Label228.Text = "Pulse Total"
        '
        'lblCurrPulsesTotal
        '
        Me.lblCurrPulsesTotal.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCurrPulsesTotal.ForeColor = System.Drawing.Color.Black
        Me.lblCurrPulsesTotal.Location = New System.Drawing.Point(360, 178)
        Me.lblCurrPulsesTotal.Name = "lblCurrPulsesTotal"
        Me.lblCurrPulsesTotal.Size = New System.Drawing.Size(136, 20)
        Me.lblCurrPulsesTotal.TabIndex = 111
        Me.lblCurrPulsesTotal.Text = "0"
        Me.lblCurrPulsesTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label232
        '
        Me.Label232.AutoSize = True
        Me.Label232.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label232.ForeColor = System.Drawing.Color.Black
        Me.Label232.Location = New System.Drawing.Point(161, 148)
        Me.Label232.Name = "Label232"
        Me.Label232.Size = New System.Drawing.Size(181, 21)
        Me.Label232.TabIndex = 119
        Me.Label232.Text = "Pulses Since Power On"
        '
        'lblCurrPulsesPwrOn
        '
        Me.lblCurrPulsesPwrOn.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCurrPulsesPwrOn.ForeColor = System.Drawing.Color.Black
        Me.lblCurrPulsesPwrOn.Location = New System.Drawing.Point(360, 148)
        Me.lblCurrPulsesPwrOn.Name = "lblCurrPulsesPwrOn"
        Me.lblCurrPulsesPwrOn.Size = New System.Drawing.Size(136, 20)
        Me.lblCurrPulsesPwrOn.TabIndex = 114
        Me.lblCurrPulsesPwrOn.Text = "0"
        Me.lblCurrPulsesPwrOn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label69
        '
        Me.Label69.AutoSize = True
        Me.Label69.BackColor = System.Drawing.SystemColors.Control
        Me.Label69.Font = New System.Drawing.Font("Segoe UI Semibold", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label69.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.Label69.Location = New System.Drawing.Point(188, 11)
        Me.Label69.Name = "Label69"
        Me.Label69.Size = New System.Drawing.Size(304, 45)
        Me.Label69.TabIndex = 2
        Me.Label69.Text = "Magnetron Current"
        '
        'BlueRectMagnetron
        '
        Me.BlueRectMagnetron.Enabled = False
        Me.BlueRectMagnetron.Location = New System.Drawing.Point(61, 60)
        Me.BlueRectMagnetron.MyBorderColor = System.Drawing.Color.Black
        Me.BlueRectMagnetron.MyBorderWidth = 0.001!
        Me.BlueRectMagnetron.Name = "BlueRectMagnetron"
        Me.BlueRectMagnetron.Size = New System.Drawing.Size(561, 258)
        Me.BlueRectMagnetron.TabIndex = 80
        '
        'TabPageAFC
        '
        Me.TabPageAFC.BackColor = System.Drawing.SystemColors.Control
        Me.TabPageAFC.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TabPageAFC.Controls.Add(Me.btnAfcManualPosition)
        Me.TabPageAFC.Controls.Add(Me.btnAfcManualMode)
        Me.TabPageAFC.Controls.Add(Me.btnAfcHomePosSet)
        Me.TabPageAFC.Controls.Add(Me.btnAfcCabCtrlVSet)
        Me.TabPageAFC.Controls.Add(Me.btnAfcCargoCtrlVSet)
        Me.TabPageAFC.Controls.Add(Me.ledWAfcManualMode)
        Me.TabPageAFC.Controls.Add(Me.ledAfcCanFault)
        Me.TabPageAFC.Controls.Add(Me.Label221)
        Me.TabPageAFC.Controls.Add(Me.Label234)
        Me.TabPageAFC.Controls.Add(Me.Label239)
        Me.TabPageAFC.Controls.Add(Me.Label241)
        Me.TabPageAFC.Controls.Add(Me.lblAfcPreAsample)
        Me.TabPageAFC.Controls.Add(Me.Label161)
        Me.TabPageAFC.Controls.Add(Me.lblAfcPreBsample)
        Me.TabPageAFC.Controls.Add(Me.Label243)
        Me.TabPageAFC.Controls.Add(Me.lblAfcFilteredError)
        Me.TabPageAFC.Controls.Add(Me.Label5)
        Me.TabPageAFC.Controls.Add(Me.lblAfcManualPosition)
        Me.TabPageAFC.Controls.Add(Me.Label249)
        Me.TabPageAFC.Controls.Add(Me.lblAfcHomePosition)
        Me.TabPageAFC.Controls.Add(Me.Label251)
        Me.TabPageAFC.Controls.Add(Me.lblAfcPhaseCtrlV)
        Me.TabPageAFC.Controls.Add(Me.Label70)
        Me.TabPageAFC.Controls.Add(Me.BlueRect11)
        Me.TabPageAFC.ForeColor = System.Drawing.Color.Black
        Me.TabPageAFC.Location = New System.Drawing.Point(0, 0)
        Me.TabPageAFC.Name = "TabPageAFC"
        Me.TabPageAFC.Size = New System.Drawing.Size(680, 580)
        Me.TabPageAFC.TabIndex = 7
        Me.TabPageAFC.Text = "TabPage6"
        '
        'btnAfcManualPosition
        '
        Me.btnAfcManualPosition.BackColor = System.Drawing.Color.Blue
        Me.btnAfcManualPosition.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAfcManualPosition.ForeColor = System.Drawing.Color.Blue
        Me.btnAfcManualPosition.Location = New System.Drawing.Point(370, 276)
        Me.btnAfcManualPosition.Name = "btnAfcManualPosition"
        Me.btnAfcManualPosition.Size = New System.Drawing.Size(236, 33)
        Me.btnAfcManualPosition.TabIndex = 124
        Me.btnAfcManualPosition.Tag = "1"
        Me.btnAfcManualPosition.Text = "Manual Position"
        Me.btnAfcManualPosition.UseVisualStyleBackColor = True
        '
        'btnAfcManualMode
        '
        Me.btnAfcManualMode.BackColor = System.Drawing.Color.Blue
        Me.btnAfcManualMode.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAfcManualMode.ForeColor = System.Drawing.Color.Blue
        Me.btnAfcManualMode.Location = New System.Drawing.Point(370, 237)
        Me.btnAfcManualMode.Name = "btnAfcManualMode"
        Me.btnAfcManualMode.Size = New System.Drawing.Size(236, 33)
        Me.btnAfcManualMode.TabIndex = 124
        Me.btnAfcManualMode.Tag = "1"
        Me.btnAfcManualMode.Text = "Manual Mode"
        Me.btnAfcManualMode.UseVisualStyleBackColor = True
        '
        'btnAfcHomePosSet
        '
        Me.btnAfcHomePosSet.BackColor = System.Drawing.Color.Blue
        Me.btnAfcHomePosSet.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAfcHomePosSet.ForeColor = System.Drawing.Color.Blue
        Me.btnAfcHomePosSet.Location = New System.Drawing.Point(370, 180)
        Me.btnAfcHomePosSet.Name = "btnAfcHomePosSet"
        Me.btnAfcHomePosSet.Size = New System.Drawing.Size(236, 33)
        Me.btnAfcHomePosSet.TabIndex = 123
        Me.btnAfcHomePosSet.Tag = "1"
        Me.btnAfcHomePosSet.Text = "Home Pos Set  6500"
        Me.btnAfcHomePosSet.UseVisualStyleBackColor = True
        '
        'btnAfcCabCtrlVSet
        '
        Me.btnAfcCabCtrlVSet.BackColor = System.Drawing.Color.Blue
        Me.btnAfcCabCtrlVSet.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAfcCabCtrlVSet.ForeColor = System.Drawing.Color.Blue
        Me.btnAfcCabCtrlVSet.Location = New System.Drawing.Point(370, 141)
        Me.btnAfcCabCtrlVSet.Name = "btnAfcCabCtrlVSet"
        Me.btnAfcCabCtrlVSet.Size = New System.Drawing.Size(236, 33)
        Me.btnAfcCabCtrlVSet.TabIndex = 122
        Me.btnAfcCabCtrlVSet.Tag = "1"
        Me.btnAfcCabCtrlVSet.Text = "Cab Ctrl V Set      5V"
        Me.btnAfcCabCtrlVSet.UseVisualStyleBackColor = True
        '
        'btnAfcCargoCtrlVSet
        '
        Me.btnAfcCargoCtrlVSet.BackColor = System.Drawing.Color.Blue
        Me.btnAfcCargoCtrlVSet.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAfcCargoCtrlVSet.ForeColor = System.Drawing.Color.Blue
        Me.btnAfcCargoCtrlVSet.Location = New System.Drawing.Point(370, 102)
        Me.btnAfcCargoCtrlVSet.Name = "btnAfcCargoCtrlVSet"
        Me.btnAfcCargoCtrlVSet.Size = New System.Drawing.Size(236, 33)
        Me.btnAfcCargoCtrlVSet.TabIndex = 122
        Me.btnAfcCargoCtrlVSet.Tag = "1"
        Me.btnAfcCargoCtrlVSet.Text = "Cargo Ctrl V Set   5V"
        Me.btnAfcCargoCtrlVSet.UseVisualStyleBackColor = True
        '
        'ledWAfcManualMode
        '
        Me.ledWAfcManualMode.FillColor = System.Drawing.SystemColors.Control
        Me.ledWAfcManualMode.ForeColor = System.Drawing.SystemColors.Control
        Me.ledWAfcManualMode.Location = New System.Drawing.Point(400, 438)
        Me.ledWAfcManualMode.MyBorderColor = System.Drawing.Color.Black
        Me.ledWAfcManualMode.MyBorderWidth = 2
        Me.ledWAfcManualMode.Name = "ledWAfcManualMode"
        Me.ledWAfcManualMode.Size = New System.Drawing.Size(18, 20)
        Me.ledWAfcManualMode.TabIndex = 103
        '
        'ledAfcCanFault
        '
        Me.ledAfcCanFault.FillColor = System.Drawing.Color.LawnGreen
        Me.ledAfcCanFault.ForeColor = System.Drawing.SystemColors.Control
        Me.ledAfcCanFault.Location = New System.Drawing.Point(98, 438)
        Me.ledAfcCanFault.MyBorderColor = System.Drawing.Color.Black
        Me.ledAfcCanFault.MyBorderWidth = 2
        Me.ledAfcCanFault.Name = "ledAfcCanFault"
        Me.ledAfcCanFault.Size = New System.Drawing.Size(18, 20)
        Me.ledAfcCanFault.TabIndex = 101
        '
        'Label221
        '
        Me.Label221.AutoSize = True
        Me.Label221.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label221.ForeColor = System.Drawing.Color.Black
        Me.Label221.Location = New System.Drawing.Point(424, 438)
        Me.Label221.Name = "Label221"
        Me.Label221.Size = New System.Drawing.Size(116, 21)
        Me.Label221.TabIndex = 82
        Me.Label221.Text = "Manual Mode"
        '
        'Label234
        '
        Me.Label234.AutoSize = True
        Me.Label234.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label234.ForeColor = System.Drawing.Color.Black
        Me.Label234.Location = New System.Drawing.Point(122, 438)
        Me.Label234.Name = "Label234"
        Me.Label234.Size = New System.Drawing.Size(86, 21)
        Me.Label234.TabIndex = 81
        Me.Label234.Text = "CAN Fault"
        '
        'Label239
        '
        Me.Label239.AutoSize = True
        Me.Label239.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label239.ForeColor = System.Drawing.Color.Black
        Me.Label239.Location = New System.Drawing.Point(317, 108)
        Me.Label239.Name = "Label239"
        Me.Label239.Size = New System.Drawing.Size(21, 21)
        Me.Label239.TabIndex = 106
        Me.Label239.Text = "V"
        '
        'Label241
        '
        Me.Label241.AutoSize = True
        Me.Label241.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label241.ForeColor = System.Drawing.Color.Black
        Me.Label241.Location = New System.Drawing.Point(67, 258)
        Me.Label241.Name = "Label241"
        Me.Label241.Size = New System.Drawing.Size(152, 21)
        Me.Label241.TabIndex = 117
        Me.Label241.Text = "Previous A Sample"
        '
        'lblAfcPreAsample
        '
        Me.lblAfcPreAsample.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAfcPreAsample.ForeColor = System.Drawing.Color.Black
        Me.lblAfcPreAsample.Location = New System.Drawing.Point(225, 258)
        Me.lblAfcPreAsample.Name = "lblAfcPreAsample"
        Me.lblAfcPreAsample.Size = New System.Drawing.Size(86, 20)
        Me.lblAfcPreAsample.TabIndex = 115
        Me.lblAfcPreAsample.Text = "0"
        Me.lblAfcPreAsample.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label161
        '
        Me.Label161.AutoSize = True
        Me.Label161.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label161.ForeColor = System.Drawing.Color.Black
        Me.Label161.Location = New System.Drawing.Point(67, 288)
        Me.Label161.Name = "Label161"
        Me.Label161.Size = New System.Drawing.Size(151, 21)
        Me.Label161.TabIndex = 116
        Me.Label161.Text = "Previous B Sample"
        '
        'lblAfcPreBsample
        '
        Me.lblAfcPreBsample.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAfcPreBsample.ForeColor = System.Drawing.Color.Black
        Me.lblAfcPreBsample.Location = New System.Drawing.Point(225, 288)
        Me.lblAfcPreBsample.Name = "lblAfcPreBsample"
        Me.lblAfcPreBsample.Size = New System.Drawing.Size(86, 20)
        Me.lblAfcPreBsample.TabIndex = 113
        Me.lblAfcPreBsample.Text = "0"
        Me.lblAfcPreBsample.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label243
        '
        Me.Label243.AutoSize = True
        Me.Label243.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label243.ForeColor = System.Drawing.Color.Black
        Me.Label243.Location = New System.Drawing.Point(67, 228)
        Me.Label243.Name = "Label243"
        Me.Label243.Size = New System.Drawing.Size(109, 21)
        Me.Label243.TabIndex = 116
        Me.Label243.Text = "Filtered Error"
        '
        'lblAfcFilteredError
        '
        Me.lblAfcFilteredError.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAfcFilteredError.ForeColor = System.Drawing.Color.Black
        Me.lblAfcFilteredError.Location = New System.Drawing.Point(213, 228)
        Me.lblAfcFilteredError.Name = "lblAfcFilteredError"
        Me.lblAfcFilteredError.Size = New System.Drawing.Size(98, 20)
        Me.lblAfcFilteredError.TabIndex = 113
        Me.lblAfcFilteredError.Text = "0"
        Me.lblAfcFilteredError.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(67, 168)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(134, 21)
        Me.Label5.TabIndex = 121
        Me.Label5.Text = "Current Position"
        '
        'lblAfcManualPosition
        '
        Me.lblAfcManualPosition.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAfcManualPosition.ForeColor = System.Drawing.Color.Black
        Me.lblAfcManualPosition.Location = New System.Drawing.Point(209, 169)
        Me.lblAfcManualPosition.Name = "lblAfcManualPosition"
        Me.lblAfcManualPosition.Size = New System.Drawing.Size(102, 20)
        Me.lblAfcManualPosition.TabIndex = 112
        Me.lblAfcManualPosition.Text = "0"
        Me.lblAfcManualPosition.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label249
        '
        Me.Label249.AutoSize = True
        Me.Label249.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label249.ForeColor = System.Drawing.Color.Black
        Me.Label249.Location = New System.Drawing.Point(67, 138)
        Me.Label249.Name = "Label249"
        Me.Label249.Size = New System.Drawing.Size(123, 21)
        Me.Label249.TabIndex = 121
        Me.Label249.Text = "Home Position"
        '
        'lblAfcHomePosition
        '
        Me.lblAfcHomePosition.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAfcHomePosition.ForeColor = System.Drawing.Color.Black
        Me.lblAfcHomePosition.Location = New System.Drawing.Point(209, 139)
        Me.lblAfcHomePosition.Name = "lblAfcHomePosition"
        Me.lblAfcHomePosition.Size = New System.Drawing.Size(102, 20)
        Me.lblAfcHomePosition.TabIndex = 112
        Me.lblAfcHomePosition.Text = "0"
        Me.lblAfcHomePosition.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label251
        '
        Me.Label251.AutoSize = True
        Me.Label251.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label251.ForeColor = System.Drawing.Color.Black
        Me.Label251.Location = New System.Drawing.Point(67, 108)
        Me.Label251.Name = "Label251"
        Me.Label251.Size = New System.Drawing.Size(180, 21)
        Me.Label251.TabIndex = 119
        Me.Label251.Text = "Phase Control Voltage"
        '
        'lblAfcPhaseCtrlV
        '
        Me.lblAfcPhaseCtrlV.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAfcPhaseCtrlV.ForeColor = System.Drawing.Color.Black
        Me.lblAfcPhaseCtrlV.Location = New System.Drawing.Point(247, 109)
        Me.lblAfcPhaseCtrlV.Name = "lblAfcPhaseCtrlV"
        Me.lblAfcPhaseCtrlV.Size = New System.Drawing.Size(64, 20)
        Me.lblAfcPhaseCtrlV.TabIndex = 114
        Me.lblAfcPhaseCtrlV.Text = "0"
        Me.lblAfcPhaseCtrlV.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label70
        '
        Me.Label70.AutoSize = True
        Me.Label70.BackColor = System.Drawing.SystemColors.Control
        Me.Label70.Font = New System.Drawing.Font("Segoe UI Semibold", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label70.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.Label70.Location = New System.Drawing.Point(298, 11)
        Me.Label70.Name = "Label70"
        Me.Label70.Size = New System.Drawing.Size(77, 45)
        Me.Label70.TabIndex = 2
        Me.Label70.Text = "AFC"
        '
        'BlueRect11
        '
        Me.BlueRect11.Enabled = False
        Me.BlueRect11.Location = New System.Drawing.Point(39, 60)
        Me.BlueRect11.MyBorderColor = System.Drawing.Color.Black
        Me.BlueRect11.MyBorderWidth = 0.001!
        Me.BlueRect11.Name = "BlueRect11"
        Me.BlueRect11.Size = New System.Drawing.Size(598, 296)
        Me.BlueRect11.TabIndex = 80
        '
        'TabPageMagnetrHtr
        '
        Me.TabPageMagnetrHtr.BackColor = System.Drawing.SystemColors.Control
        Me.TabPageMagnetrHtr.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TabPageMagnetrHtr.Controls.Add(Me.btnMagIfSet)
        Me.TabPageMagnetrHtr.Controls.Add(Me.btnMagCabIset)
        Me.TabPageMagnetrHtr.Controls.Add(Me.btnMagCargoIset)
        Me.TabPageMagnetrHtr.Controls.Add(Me.ledMagCanFault)
        Me.TabPageMagnetrHtr.Controls.Add(Me.ledMagImUCAbs)
        Me.TabPageMagnetrHtr.Controls.Add(Me.ledMagEmUVAbs)
        Me.TabPageMagnetrHtr.Controls.Add(Me.ledMagTempSW)
        Me.TabPageMagnetrHtr.Controls.Add(Me.ledMagEfUVRel)
        Me.TabPageMagnetrHtr.Controls.Add(Me.ledWMagHtrOK)
        Me.TabPageMagnetrHtr.Controls.Add(Me.ledMagIfOCRel)
        Me.TabPageMagnetrHtr.Controls.Add(Me.ledMagCoolFault)
        Me.TabPageMagnetrHtr.Controls.Add(Me.ledMagImOCAbs)
        Me.TabPageMagnetrHtr.Controls.Add(Me.ledWMagOTActive)
        Me.TabPageMagnetrHtr.Controls.Add(Me.ledWMagIfOCActive)
        Me.TabPageMagnetrHtr.Controls.Add(Me.ledWMagEfOVLatch)
        Me.TabPageMagnetrHtr.Controls.Add(Me.ledMagIfUCRel)
        Me.TabPageMagnetrHtr.Controls.Add(Me.ledWMagOutRelayOpen)
        Me.TabPageMagnetrHtr.Controls.Add(Me.ledWMagOK)
        Me.TabPageMagnetrHtr.Controls.Add(Me.Label201)
        Me.TabPageMagnetrHtr.Controls.Add(Me.ledMagIfOCAbs)
        Me.TabPageMagnetrHtr.Controls.Add(Me.Label202)
        Me.TabPageMagnetrHtr.Controls.Add(Me.Label203)
        Me.TabPageMagnetrHtr.Controls.Add(Me.Label207)
        Me.TabPageMagnetrHtr.Controls.Add(Me.Label218)
        Me.TabPageMagnetrHtr.Controls.Add(Me.Label219)
        Me.TabPageMagnetrHtr.Controls.Add(Me.Label117)
        Me.TabPageMagnetrHtr.Controls.Add(Me.Label112)
        Me.TabPageMagnetrHtr.Controls.Add(Me.Label220)
        Me.TabPageMagnetrHtr.Controls.Add(Me.Label235)
        Me.TabPageMagnetrHtr.Controls.Add(Me.Label236)
        Me.TabPageMagnetrHtr.Controls.Add(Me.Label237)
        Me.TabPageMagnetrHtr.Controls.Add(Me.Label238)
        Me.TabPageMagnetrHtr.Controls.Add(Me.Label245)
        Me.TabPageMagnetrHtr.Controls.Add(Me.Label246)
        Me.TabPageMagnetrHtr.Controls.Add(Me.Label253)
        Me.TabPageMagnetrHtr.Controls.Add(Me.Label256)
        Me.TabPageMagnetrHtr.Controls.Add(Me.Label257)
        Me.TabPageMagnetrHtr.Controls.Add(Me.Label258)
        Me.TabPageMagnetrHtr.Controls.Add(Me.Label259)
        Me.TabPageMagnetrHtr.Controls.Add(Me.Label264)
        Me.TabPageMagnetrHtr.Controls.Add(Me.lblMagIf)
        Me.TabPageMagnetrHtr.Controls.Add(Me.Label266)
        Me.TabPageMagnetrHtr.Controls.Add(Me.lblMagEf)
        Me.TabPageMagnetrHtr.Controls.Add(Me.Label268)
        Me.TabPageMagnetrHtr.Controls.Add(Me.lblMagEm)
        Me.TabPageMagnetrHtr.Controls.Add(Me.Label270)
        Me.TabPageMagnetrHtr.Controls.Add(Me.lblMagIm)
        Me.TabPageMagnetrHtr.Controls.Add(Me.Label71)
        Me.TabPageMagnetrHtr.Controls.Add(Me.BlueRect13)
        Me.TabPageMagnetrHtr.ForeColor = System.Drawing.Color.Black
        Me.TabPageMagnetrHtr.Location = New System.Drawing.Point(0, 0)
        Me.TabPageMagnetrHtr.Name = "TabPageMagnetrHtr"
        Me.TabPageMagnetrHtr.Size = New System.Drawing.Size(680, 580)
        Me.TabPageMagnetrHtr.TabIndex = 8
        Me.TabPageMagnetrHtr.Text = "TabPage7"
        '
        'btnMagIfSet
        '
        Me.btnMagIfSet.BackColor = System.Drawing.Color.Blue
        Me.btnMagIfSet.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMagIfSet.ForeColor = System.Drawing.Color.Blue
        Me.btnMagIfSet.Location = New System.Drawing.Point(379, 176)
        Me.btnMagIfSet.Name = "btnMagIfSet"
        Me.btnMagIfSet.Size = New System.Drawing.Size(222, 33)
        Me.btnMagIfSet.TabIndex = 131
        Me.btnMagIfSet.Tag = "1"
        Me.btnMagIfSet.Text = "Heater I Set  6A"
        Me.btnMagIfSet.UseVisualStyleBackColor = True
        '
        'btnMagCabIset
        '
        Me.btnMagCabIset.BackColor = System.Drawing.Color.Blue
        Me.btnMagCabIset.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMagCabIset.ForeColor = System.Drawing.Color.Blue
        Me.btnMagCabIset.Location = New System.Drawing.Point(379, 134)
        Me.btnMagCabIset.Name = "btnMagCabIset"
        Me.btnMagCabIset.Size = New System.Drawing.Size(222, 33)
        Me.btnMagCabIset.TabIndex = 130
        Me.btnMagCabIset.Tag = "1"
        Me.btnMagCabIset.Text = "Cab Mag I Set     10A"
        Me.btnMagCabIset.UseVisualStyleBackColor = True
        '
        'btnMagCargoIset
        '
        Me.btnMagCargoIset.BackColor = System.Drawing.Color.Blue
        Me.btnMagCargoIset.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMagCargoIset.ForeColor = System.Drawing.Color.Blue
        Me.btnMagCargoIset.Location = New System.Drawing.Point(379, 92)
        Me.btnMagCargoIset.Name = "btnMagCargoIset"
        Me.btnMagCargoIset.Size = New System.Drawing.Size(222, 33)
        Me.btnMagCargoIset.TabIndex = 130
        Me.btnMagCargoIset.Tag = "1"
        Me.btnMagCargoIset.Text = "Cargo Mag I Set   12A"
        Me.btnMagCargoIset.UseVisualStyleBackColor = True
        '
        'ledMagCanFault
        '
        Me.ledMagCanFault.FillColor = System.Drawing.Color.LawnGreen
        Me.ledMagCanFault.ForeColor = System.Drawing.SystemColors.Control
        Me.ledMagCanFault.Location = New System.Drawing.Point(113, 511)
        Me.ledMagCanFault.MyBorderColor = System.Drawing.Color.Black
        Me.ledMagCanFault.MyBorderWidth = 2
        Me.ledMagCanFault.Name = "ledMagCanFault"
        Me.ledMagCanFault.Size = New System.Drawing.Size(18, 20)
        Me.ledMagCanFault.TabIndex = 97
        '
        'ledMagImUCAbs
        '
        Me.ledMagImUCAbs.FillColor = System.Drawing.Color.LawnGreen
        Me.ledMagImUCAbs.ForeColor = System.Drawing.SystemColors.Control
        Me.ledMagImUCAbs.Location = New System.Drawing.Point(113, 407)
        Me.ledMagImUCAbs.MyBorderColor = System.Drawing.Color.Black
        Me.ledMagImUCAbs.MyBorderWidth = 2
        Me.ledMagImUCAbs.Name = "ledMagImUCAbs"
        Me.ledMagImUCAbs.Size = New System.Drawing.Size(18, 20)
        Me.ledMagImUCAbs.TabIndex = 98
        '
        'ledMagEmUVAbs
        '
        Me.ledMagEmUVAbs.FillColor = System.Drawing.Color.LawnGreen
        Me.ledMagEmUVAbs.ForeColor = System.Drawing.SystemColors.Control
        Me.ledMagEmUVAbs.Location = New System.Drawing.Point(113, 433)
        Me.ledMagEmUVAbs.MyBorderColor = System.Drawing.Color.Black
        Me.ledMagEmUVAbs.MyBorderWidth = 2
        Me.ledMagEmUVAbs.Name = "ledMagEmUVAbs"
        Me.ledMagEmUVAbs.Size = New System.Drawing.Size(18, 20)
        Me.ledMagEmUVAbs.TabIndex = 99
        '
        'ledMagTempSW
        '
        Me.ledMagTempSW.FillColor = System.Drawing.Color.LawnGreen
        Me.ledMagTempSW.ForeColor = System.Drawing.SystemColors.Control
        Me.ledMagTempSW.Location = New System.Drawing.Point(113, 459)
        Me.ledMagTempSW.MyBorderColor = System.Drawing.Color.Black
        Me.ledMagTempSW.MyBorderWidth = 2
        Me.ledMagTempSW.Name = "ledMagTempSW"
        Me.ledMagTempSW.Size = New System.Drawing.Size(18, 20)
        Me.ledMagTempSW.TabIndex = 104
        '
        'ledMagEfUVRel
        '
        Me.ledMagEfUVRel.FillColor = System.Drawing.Color.LawnGreen
        Me.ledMagEfUVRel.ForeColor = System.Drawing.SystemColors.Control
        Me.ledMagEfUVRel.Location = New System.Drawing.Point(113, 355)
        Me.ledMagEfUVRel.MyBorderColor = System.Drawing.Color.Black
        Me.ledMagEfUVRel.MyBorderWidth = 2
        Me.ledMagEfUVRel.Name = "ledMagEfUVRel"
        Me.ledMagEfUVRel.Size = New System.Drawing.Size(18, 20)
        Me.ledMagEfUVRel.TabIndex = 102
        '
        'ledWMagHtrOK
        '
        Me.ledWMagHtrOK.FillColor = System.Drawing.Color.Black
        Me.ledWMagHtrOK.ForeColor = System.Drawing.SystemColors.Control
        Me.ledWMagHtrOK.Location = New System.Drawing.Point(373, 303)
        Me.ledWMagHtrOK.MyBorderColor = System.Drawing.Color.Black
        Me.ledWMagHtrOK.MyBorderWidth = 2
        Me.ledWMagHtrOK.Name = "ledWMagHtrOK"
        Me.ledWMagHtrOK.Size = New System.Drawing.Size(18, 20)
        Me.ledWMagHtrOK.TabIndex = 103
        '
        'ledMagIfOCRel
        '
        Me.ledMagIfOCRel.FillColor = System.Drawing.Color.LawnGreen
        Me.ledMagIfOCRel.ForeColor = System.Drawing.SystemColors.Control
        Me.ledMagIfOCRel.Location = New System.Drawing.Point(113, 303)
        Me.ledMagIfOCRel.MyBorderColor = System.Drawing.Color.Black
        Me.ledMagIfOCRel.MyBorderWidth = 2
        Me.ledMagIfOCRel.Name = "ledMagIfOCRel"
        Me.ledMagIfOCRel.Size = New System.Drawing.Size(18, 20)
        Me.ledMagIfOCRel.TabIndex = 111
        '
        'ledMagCoolFault
        '
        Me.ledMagCoolFault.FillColor = System.Drawing.Color.LawnGreen
        Me.ledMagCoolFault.ForeColor = System.Drawing.SystemColors.Control
        Me.ledMagCoolFault.Location = New System.Drawing.Point(113, 485)
        Me.ledMagCoolFault.MyBorderColor = System.Drawing.Color.Black
        Me.ledMagCoolFault.MyBorderWidth = 2
        Me.ledMagCoolFault.Name = "ledMagCoolFault"
        Me.ledMagCoolFault.Size = New System.Drawing.Size(18, 20)
        Me.ledMagCoolFault.TabIndex = 105
        '
        'ledMagImOCAbs
        '
        Me.ledMagImOCAbs.FillColor = System.Drawing.Color.LawnGreen
        Me.ledMagImOCAbs.ForeColor = System.Drawing.SystemColors.Control
        Me.ledMagImOCAbs.Location = New System.Drawing.Point(113, 381)
        Me.ledMagImOCAbs.MyBorderColor = System.Drawing.Color.Black
        Me.ledMagImOCAbs.MyBorderWidth = 2
        Me.ledMagImOCAbs.Name = "ledMagImOCAbs"
        Me.ledMagImOCAbs.Size = New System.Drawing.Size(18, 20)
        Me.ledMagImOCAbs.TabIndex = 106
        '
        'ledWMagOTActive
        '
        Me.ledWMagOTActive.FillColor = System.Drawing.SystemColors.Control
        Me.ledWMagOTActive.ForeColor = System.Drawing.SystemColors.Control
        Me.ledWMagOTActive.Location = New System.Drawing.Point(373, 407)
        Me.ledWMagOTActive.MyBorderColor = System.Drawing.Color.Black
        Me.ledWMagOTActive.MyBorderWidth = 2
        Me.ledWMagOTActive.Name = "ledWMagOTActive"
        Me.ledWMagOTActive.Size = New System.Drawing.Size(18, 20)
        Me.ledWMagOTActive.TabIndex = 107
        '
        'ledWMagIfOCActive
        '
        Me.ledWMagIfOCActive.FillColor = System.Drawing.SystemColors.Control
        Me.ledWMagIfOCActive.ForeColor = System.Drawing.SystemColors.Control
        Me.ledWMagIfOCActive.Location = New System.Drawing.Point(373, 381)
        Me.ledWMagIfOCActive.MyBorderColor = System.Drawing.Color.Black
        Me.ledWMagIfOCActive.MyBorderWidth = 2
        Me.ledWMagIfOCActive.Name = "ledWMagIfOCActive"
        Me.ledWMagIfOCActive.Size = New System.Drawing.Size(18, 20)
        Me.ledWMagIfOCActive.TabIndex = 107
        '
        'ledWMagEfOVLatch
        '
        Me.ledWMagEfOVLatch.FillColor = System.Drawing.SystemColors.Control
        Me.ledWMagEfOVLatch.ForeColor = System.Drawing.SystemColors.Control
        Me.ledWMagEfOVLatch.Location = New System.Drawing.Point(373, 329)
        Me.ledWMagEfOVLatch.MyBorderColor = System.Drawing.Color.Black
        Me.ledWMagEfOVLatch.MyBorderWidth = 2
        Me.ledWMagEfOVLatch.Name = "ledWMagEfOVLatch"
        Me.ledWMagEfOVLatch.Size = New System.Drawing.Size(18, 20)
        Me.ledWMagEfOVLatch.TabIndex = 107
        '
        'ledMagIfUCRel
        '
        Me.ledMagIfUCRel.FillColor = System.Drawing.Color.Red
        Me.ledMagIfUCRel.ForeColor = System.Drawing.SystemColors.Control
        Me.ledMagIfUCRel.Location = New System.Drawing.Point(113, 329)
        Me.ledMagIfUCRel.MyBorderColor = System.Drawing.Color.Black
        Me.ledMagIfUCRel.MyBorderWidth = 2
        Me.ledMagIfUCRel.Name = "ledMagIfUCRel"
        Me.ledMagIfUCRel.Size = New System.Drawing.Size(18, 20)
        Me.ledMagIfUCRel.TabIndex = 109
        '
        'ledWMagOutRelayOpen
        '
        Me.ledWMagOutRelayOpen.FillColor = System.Drawing.SystemColors.Control
        Me.ledWMagOutRelayOpen.ForeColor = System.Drawing.SystemColors.Control
        Me.ledWMagOutRelayOpen.Location = New System.Drawing.Point(373, 355)
        Me.ledWMagOutRelayOpen.MyBorderColor = System.Drawing.Color.Black
        Me.ledWMagOutRelayOpen.MyBorderWidth = 2
        Me.ledWMagOutRelayOpen.Name = "ledWMagOutRelayOpen"
        Me.ledWMagOutRelayOpen.Size = New System.Drawing.Size(18, 20)
        Me.ledWMagOutRelayOpen.TabIndex = 101
        '
        'ledWMagOK
        '
        Me.ledWMagOK.FillColor = System.Drawing.Color.Black
        Me.ledWMagOK.ForeColor = System.Drawing.SystemColors.Control
        Me.ledWMagOK.Location = New System.Drawing.Point(373, 277)
        Me.ledWMagOK.MyBorderColor = System.Drawing.Color.Black
        Me.ledWMagOK.MyBorderWidth = 2
        Me.ledWMagOK.Name = "ledWMagOK"
        Me.ledWMagOK.Size = New System.Drawing.Size(18, 20)
        Me.ledWMagOK.TabIndex = 110
        '
        'Label201
        '
        Me.Label201.AutoSize = True
        Me.Label201.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label201.ForeColor = System.Drawing.Color.Black
        Me.Label201.Location = New System.Drawing.Point(137, 511)
        Me.Label201.Name = "Label201"
        Me.Label201.Size = New System.Drawing.Size(86, 21)
        Me.Label201.TabIndex = 94
        Me.Label201.Text = "CAN Fault"
        '
        'ledMagIfOCAbs
        '
        Me.ledMagIfOCAbs.FillColor = System.Drawing.Color.LawnGreen
        Me.ledMagIfOCAbs.ForeColor = System.Drawing.SystemColors.Control
        Me.ledMagIfOCAbs.Location = New System.Drawing.Point(113, 277)
        Me.ledMagIfOCAbs.MyBorderColor = System.Drawing.Color.Black
        Me.ledMagIfOCAbs.MyBorderWidth = 2
        Me.ledMagIfOCAbs.Name = "ledMagIfOCAbs"
        Me.ledMagIfOCAbs.Size = New System.Drawing.Size(18, 20)
        Me.ledMagIfOCAbs.TabIndex = 108
        '
        'Label202
        '
        Me.Label202.AutoSize = True
        Me.Label202.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label202.ForeColor = System.Drawing.Color.Black
        Me.Label202.Location = New System.Drawing.Point(137, 433)
        Me.Label202.Name = "Label202"
        Me.Label202.Size = New System.Drawing.Size(130, 21)
        Me.Label202.TabIndex = 95
        Me.Label202.Text = "Magnet UV ABS"
        '
        'Label203
        '
        Me.Label203.AutoSize = True
        Me.Label203.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label203.ForeColor = System.Drawing.Color.Black
        Me.Label203.Location = New System.Drawing.Point(137, 407)
        Me.Label203.Name = "Label203"
        Me.Label203.Size = New System.Drawing.Size(129, 21)
        Me.Label203.TabIndex = 93
        Me.Label203.Text = "Magnet UC ABS"
        '
        'Label207
        '
        Me.Label207.AutoSize = True
        Me.Label207.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label207.ForeColor = System.Drawing.Color.Black
        Me.Label207.Location = New System.Drawing.Point(137, 485)
        Me.Label207.Name = "Label207"
        Me.Label207.Size = New System.Drawing.Size(112, 21)
        Me.Label207.TabIndex = 92
        Me.Label207.Text = "Coolant Fault"
        '
        'Label218
        '
        Me.Label218.AutoSize = True
        Me.Label218.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label218.ForeColor = System.Drawing.Color.Black
        Me.Label218.Location = New System.Drawing.Point(137, 459)
        Me.Label218.Name = "Label218"
        Me.Label218.Size = New System.Drawing.Size(108, 21)
        Me.Label218.TabIndex = 90
        Me.Label218.Text = "Temp Switch"
        '
        'Label219
        '
        Me.Label219.AutoSize = True
        Me.Label219.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label219.ForeColor = System.Drawing.Color.Black
        Me.Label219.Location = New System.Drawing.Point(137, 381)
        Me.Label219.Name = "Label219"
        Me.Label219.Size = New System.Drawing.Size(129, 21)
        Me.Label219.TabIndex = 89
        Me.Label219.Text = "Magnet OC ABS"
        '
        'Label117
        '
        Me.Label117.AutoSize = True
        Me.Label117.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label117.ForeColor = System.Drawing.Color.Black
        Me.Label117.Location = New System.Drawing.Point(397, 407)
        Me.Label117.Name = "Label117"
        Me.Label117.Size = New System.Drawing.Size(145, 21)
        Me.Label117.TabIndex = 80
        Me.Label117.Text = "Over Temp Active"
        '
        'Label112
        '
        Me.Label112.AutoSize = True
        Me.Label112.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label112.ForeColor = System.Drawing.Color.Black
        Me.Label112.Location = New System.Drawing.Point(397, 381)
        Me.Label112.Name = "Label112"
        Me.Label112.Size = New System.Drawing.Size(139, 21)
        Me.Label112.TabIndex = 80
        Me.Label112.Text = "Heater OC Active"
        '
        'Label220
        '
        Me.Label220.AutoSize = True
        Me.Label220.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label220.ForeColor = System.Drawing.Color.Black
        Me.Label220.Location = New System.Drawing.Point(397, 329)
        Me.Label220.Name = "Label220"
        Me.Label220.Size = New System.Drawing.Size(133, 21)
        Me.Label220.TabIndex = 80
        Me.Label220.Text = "Heater OV Latch"
        '
        'Label235
        '
        Me.Label235.AutoSize = True
        Me.Label235.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label235.ForeColor = System.Drawing.Color.Black
        Me.Label235.Location = New System.Drawing.Point(137, 355)
        Me.Label235.Name = "Label235"
        Me.Label235.Size = New System.Drawing.Size(119, 21)
        Me.Label235.TabIndex = 88
        Me.Label235.Text = "Heater UV REL"
        '
        'Label236
        '
        Me.Label236.AutoSize = True
        Me.Label236.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label236.ForeColor = System.Drawing.Color.Black
        Me.Label236.Location = New System.Drawing.Point(397, 355)
        Me.Label236.Name = "Label236"
        Me.Label236.Size = New System.Drawing.Size(155, 21)
        Me.Label236.TabIndex = 87
        Me.Label236.Text = "Output Relay Open"
        '
        'Label237
        '
        Me.Label237.AutoSize = True
        Me.Label237.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label237.ForeColor = System.Drawing.Color.Black
        Me.Label237.Location = New System.Drawing.Point(137, 329)
        Me.Label237.Name = "Label237"
        Me.Label237.Size = New System.Drawing.Size(118, 21)
        Me.Label237.TabIndex = 86
        Me.Label237.Text = "Heater UC REL"
        '
        'Label238
        '
        Me.Label238.AutoSize = True
        Me.Label238.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label238.ForeColor = System.Drawing.Color.Black
        Me.Label238.Location = New System.Drawing.Point(397, 303)
        Me.Label238.Name = "Label238"
        Me.Label238.Size = New System.Drawing.Size(87, 21)
        Me.Label238.TabIndex = 85
        Me.Label238.Text = "Heater OK"
        '
        'Label245
        '
        Me.Label245.AutoSize = True
        Me.Label245.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label245.ForeColor = System.Drawing.Color.Black
        Me.Label245.Location = New System.Drawing.Point(397, 277)
        Me.Label245.Name = "Label245"
        Me.Label245.Size = New System.Drawing.Size(95, 21)
        Me.Label245.TabIndex = 83
        Me.Label245.Text = "Magnet OK"
        '
        'Label246
        '
        Me.Label246.AutoSize = True
        Me.Label246.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label246.ForeColor = System.Drawing.Color.Black
        Me.Label246.Location = New System.Drawing.Point(137, 303)
        Me.Label246.Name = "Label246"
        Me.Label246.Size = New System.Drawing.Size(118, 21)
        Me.Label246.TabIndex = 82
        Me.Label246.Text = "Heater OC REL"
        '
        'Label253
        '
        Me.Label253.AutoSize = True
        Me.Label253.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label253.ForeColor = System.Drawing.Color.Black
        Me.Label253.Location = New System.Drawing.Point(137, 277)
        Me.Label253.Name = "Label253"
        Me.Label253.Size = New System.Drawing.Size(121, 21)
        Me.Label253.TabIndex = 81
        Me.Label253.Text = "Heater OC ABS"
        '
        'Label256
        '
        Me.Label256.AutoSize = True
        Me.Label256.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label256.ForeColor = System.Drawing.Color.Black
        Me.Label256.Location = New System.Drawing.Point(305, 188)
        Me.Label256.Name = "Label256"
        Me.Label256.Size = New System.Drawing.Size(21, 21)
        Me.Label256.TabIndex = 117
        Me.Label256.Text = "A"
        '
        'Label257
        '
        Me.Label257.AutoSize = True
        Me.Label257.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label257.ForeColor = System.Drawing.Color.Black
        Me.Label257.Location = New System.Drawing.Point(305, 158)
        Me.Label257.Name = "Label257"
        Me.Label257.Size = New System.Drawing.Size(21, 21)
        Me.Label257.TabIndex = 114
        Me.Label257.Text = "V"
        '
        'Label258
        '
        Me.Label258.AutoSize = True
        Me.Label258.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label258.ForeColor = System.Drawing.Color.Black
        Me.Label258.Location = New System.Drawing.Point(305, 128)
        Me.Label258.Name = "Label258"
        Me.Label258.Size = New System.Drawing.Size(21, 21)
        Me.Label258.TabIndex = 112
        Me.Label258.Text = "V"
        '
        'Label259
        '
        Me.Label259.AutoSize = True
        Me.Label259.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label259.ForeColor = System.Drawing.Color.Black
        Me.Label259.Location = New System.Drawing.Point(305, 98)
        Me.Label259.Name = "Label259"
        Me.Label259.Size = New System.Drawing.Size(21, 21)
        Me.Label259.TabIndex = 113
        Me.Label259.Text = "A"
        '
        'Label264
        '
        Me.Label264.AutoSize = True
        Me.Label264.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label264.ForeColor = System.Drawing.Color.Black
        Me.Label264.Location = New System.Drawing.Point(82, 188)
        Me.Label264.Name = "Label264"
        Me.Label264.Size = New System.Drawing.Size(122, 21)
        Me.Label264.TabIndex = 126
        Me.Label264.Text = "Heater Current"
        '
        'lblMagIf
        '
        Me.lblMagIf.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMagIf.ForeColor = System.Drawing.Color.Black
        Me.lblMagIf.Location = New System.Drawing.Point(225, 188)
        Me.lblMagIf.Name = "lblMagIf"
        Me.lblMagIf.Size = New System.Drawing.Size(74, 20)
        Me.lblMagIf.TabIndex = 119
        Me.lblMagIf.Text = "0"
        Me.lblMagIf.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label266
        '
        Me.Label266.AutoSize = True
        Me.Label266.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label266.ForeColor = System.Drawing.Color.Black
        Me.Label266.Location = New System.Drawing.Point(82, 158)
        Me.Label266.Name = "Label266"
        Me.Label266.Size = New System.Drawing.Size(125, 21)
        Me.Label266.TabIndex = 128
        Me.Label266.Text = "Heater Voltage"
        '
        'lblMagEf
        '
        Me.lblMagEf.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMagEf.ForeColor = System.Drawing.Color.Black
        Me.lblMagEf.Location = New System.Drawing.Point(225, 158)
        Me.lblMagEf.Name = "lblMagEf"
        Me.lblMagEf.Size = New System.Drawing.Size(74, 20)
        Me.lblMagEf.TabIndex = 118
        Me.lblMagEf.Text = "0"
        Me.lblMagEf.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label268
        '
        Me.Label268.AutoSize = True
        Me.Label268.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label268.ForeColor = System.Drawing.Color.Black
        Me.Label268.Location = New System.Drawing.Point(82, 128)
        Me.Label268.Name = "Label268"
        Me.Label268.Size = New System.Drawing.Size(133, 21)
        Me.Label268.TabIndex = 129
        Me.Label268.Text = "Magnet Voltage"
        '
        'lblMagEm
        '
        Me.lblMagEm.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMagEm.ForeColor = System.Drawing.Color.Black
        Me.lblMagEm.Location = New System.Drawing.Point(225, 128)
        Me.lblMagEm.Name = "lblMagEm"
        Me.lblMagEm.Size = New System.Drawing.Size(74, 20)
        Me.lblMagEm.TabIndex = 120
        Me.lblMagEm.Text = "0"
        Me.lblMagEm.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label270
        '
        Me.Label270.AutoSize = True
        Me.Label270.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label270.ForeColor = System.Drawing.Color.Black
        Me.Label270.Location = New System.Drawing.Point(82, 98)
        Me.Label270.Name = "Label270"
        Me.Label270.Size = New System.Drawing.Size(130, 21)
        Me.Label270.TabIndex = 127
        Me.Label270.Text = "Magnet Current"
        '
        'lblMagIm
        '
        Me.lblMagIm.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMagIm.ForeColor = System.Drawing.Color.Black
        Me.lblMagIm.Location = New System.Drawing.Point(225, 98)
        Me.lblMagIm.Name = "lblMagIm"
        Me.lblMagIm.Size = New System.Drawing.Size(74, 20)
        Me.lblMagIm.TabIndex = 122
        Me.lblMagIm.Text = "0"
        Me.lblMagIm.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label71
        '
        Me.Label71.AutoSize = True
        Me.Label71.BackColor = System.Drawing.SystemColors.Control
        Me.Label71.Font = New System.Drawing.Font("Segoe UI Semibold", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label71.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.Label71.Location = New System.Drawing.Point(217, 11)
        Me.Label71.Name = "Label71"
        Me.Label71.Size = New System.Drawing.Size(246, 45)
        Me.Label71.TabIndex = 2
        Me.Label71.Text = "Magnet/Heater"
        '
        'BlueRect13
        '
        Me.BlueRect13.Enabled = False
        Me.BlueRect13.Location = New System.Drawing.Point(36, 60)
        Me.BlueRect13.MyBorderColor = System.Drawing.Color.Black
        Me.BlueRect13.MyBorderWidth = 0.001!
        Me.BlueRect13.Name = "BlueRect13"
        Me.BlueRect13.Size = New System.Drawing.Size(602, 183)
        Me.BlueRect13.TabIndex = 80
        '
        'TabPageIonPump
        '
        Me.TabPageIonPump.BackColor = System.Drawing.SystemColors.Control
        Me.TabPageIonPump.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TabPageIonPump.Controls.Add(Me.panelIonPumpLogger)
        Me.TabPageIonPump.Controls.Add(Me.ledIonUV)
        Me.TabPageIonPump.Controls.Add(Me.ledIonOC)
        Me.TabPageIonPump.Controls.Add(Me.ledIonCanFault)
        Me.TabPageIonPump.Controls.Add(Me.Label262)
        Me.TabPageIonPump.Controls.Add(Me.Label280)
        Me.TabPageIonPump.Controls.Add(Me.Label281)
        Me.TabPageIonPump.Controls.Add(Me.Label284)
        Me.TabPageIonPump.Controls.Add(Me.Label285)
        Me.TabPageIonPump.Controls.Add(Me.Label290)
        Me.TabPageIonPump.Controls.Add(Me.Label292)
        Me.TabPageIonPump.Controls.Add(Me.lblIonEi)
        Me.TabPageIonPump.Controls.Add(Me.lblIonIi)
        Me.TabPageIonPump.Controls.Add(Me.Label72)
        Me.TabPageIonPump.Controls.Add(Me.BlueRect12)
        Me.TabPageIonPump.ForeColor = System.Drawing.Color.Black
        Me.TabPageIonPump.Location = New System.Drawing.Point(0, 0)
        Me.TabPageIonPump.Name = "TabPageIonPump"
        Me.TabPageIonPump.Size = New System.Drawing.Size(680, 580)
        Me.TabPageIonPump.TabIndex = 9
        Me.TabPageIonPump.Text = "TabPage8"
        '
        'panelIonPumpLogger
        '
        Me.panelIonPumpLogger.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panelIonPumpLogger.Controls.Add(Me.Label6)
        Me.panelIonPumpLogger.Controls.Add(Me.txtIonPumpLogInterval)
        Me.panelIonPumpLogger.Controls.Add(Me.lblIonPumpLogName)
        Me.panelIonPumpLogger.Controls.Add(Me.btnIonPumpLog)
        Me.panelIonPumpLogger.Location = New System.Drawing.Point(50, 448)
        Me.panelIonPumpLogger.Name = "panelIonPumpLogger"
        Me.panelIonPumpLogger.Size = New System.Drawing.Size(572, 113)
        Me.panelIonPumpLogger.TabIndex = 176
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(30, 15)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(92, 13)
        Me.Label6.TabIndex = 417
        Me.Label6.Text = "Log Interval (sec)"
        '
        'txtIonPumpLogInterval
        '
        Me.txtIonPumpLogInterval.Location = New System.Drawing.Point(33, 31)
        Me.txtIonPumpLogInterval.Name = "txtIonPumpLogInterval"
        Me.txtIonPumpLogInterval.Size = New System.Drawing.Size(100, 22)
        Me.txtIonPumpLogInterval.TabIndex = 416
        '
        'lblIonPumpLogName
        '
        Me.lblIonPumpLogName.AutoSize = True
        Me.lblIonPumpLogName.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIonPumpLogName.ForeColor = System.Drawing.Color.Black
        Me.lblIonPumpLogName.Location = New System.Drawing.Point(29, 74)
        Me.lblIonPumpLogName.Name = "lblIonPumpLogName"
        Me.lblIonPumpLogName.Size = New System.Drawing.Size(110, 21)
        Me.lblIonPumpLogName.TabIndex = 415
        Me.lblIonPumpLogName.Text = "Log File Name"
        '
        'btnIonPumpLog
        '
        Me.btnIonPumpLog.BackColor = System.Drawing.Color.Blue
        Me.btnIonPumpLog.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnIonPumpLog.ForeColor = System.Drawing.Color.Blue
        Me.btnIonPumpLog.Location = New System.Drawing.Point(292, 22)
        Me.btnIonPumpLog.Name = "btnIonPumpLog"
        Me.btnIonPumpLog.Size = New System.Drawing.Size(222, 33)
        Me.btnIonPumpLog.TabIndex = 414
        Me.btnIonPumpLog.Tag = "1"
        Me.btnIonPumpLog.Text = "Start Ion Pump Logging"
        Me.btnIonPumpLog.UseVisualStyleBackColor = True
        '
        'ledIonUV
        '
        Me.ledIonUV.FillColor = System.Drawing.Color.LawnGreen
        Me.ledIonUV.ForeColor = System.Drawing.Color.White
        Me.ledIonUV.Location = New System.Drawing.Point(343, 389)
        Me.ledIonUV.MyBorderColor = System.Drawing.Color.Black
        Me.ledIonUV.MyBorderWidth = 2
        Me.ledIonUV.Name = "ledIonUV"
        Me.ledIonUV.Size = New System.Drawing.Size(18, 20)
        Me.ledIonUV.TabIndex = 152
        '
        'ledIonOC
        '
        Me.ledIonOC.FillColor = System.Drawing.Color.LawnGreen
        Me.ledIonOC.ForeColor = System.Drawing.Color.White
        Me.ledIonOC.Location = New System.Drawing.Point(343, 355)
        Me.ledIonOC.MyBorderColor = System.Drawing.Color.Black
        Me.ledIonOC.MyBorderWidth = 2
        Me.ledIonOC.Name = "ledIonOC"
        Me.ledIonOC.Size = New System.Drawing.Size(18, 20)
        Me.ledIonOC.TabIndex = 163
        '
        'ledIonCanFault
        '
        Me.ledIonCanFault.FillColor = System.Drawing.Color.LawnGreen
        Me.ledIonCanFault.ForeColor = System.Drawing.Color.White
        Me.ledIonCanFault.Location = New System.Drawing.Point(115, 355)
        Me.ledIonCanFault.MyBorderColor = System.Drawing.Color.Black
        Me.ledIonCanFault.MyBorderWidth = 2
        Me.ledIonCanFault.Name = "ledIonCanFault"
        Me.ledIonCanFault.Size = New System.Drawing.Size(18, 20)
        Me.ledIonCanFault.TabIndex = 160
        '
        'Label262
        '
        Me.Label262.AutoSize = True
        Me.Label262.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label262.ForeColor = System.Drawing.Color.Black
        Me.Label262.Location = New System.Drawing.Point(367, 389)
        Me.Label262.Name = "Label262"
        Me.Label262.Size = New System.Drawing.Size(199, 21)
        Me.Label262.TabIndex = 143
        Me.Label262.Text = "Ion Pump Under Voltage"
        '
        'Label280
        '
        Me.Label280.AutoSize = True
        Me.Label280.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label280.ForeColor = System.Drawing.Color.Black
        Me.Label280.Location = New System.Drawing.Point(367, 355)
        Me.Label280.Name = "Label280"
        Me.Label280.Size = New System.Drawing.Size(185, 21)
        Me.Label280.TabIndex = 134
        Me.Label280.Text = "Ion Pump Over Current"
        '
        'Label281
        '
        Me.Label281.AutoSize = True
        Me.Label281.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label281.ForeColor = System.Drawing.Color.Black
        Me.Label281.Location = New System.Drawing.Point(139, 355)
        Me.Label281.Name = "Label281"
        Me.Label281.Size = New System.Drawing.Size(86, 21)
        Me.Label281.TabIndex = 133
        Me.Label281.Text = "CAN Fault"
        '
        'Label284
        '
        Me.Label284.AutoSize = True
        Me.Label284.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label284.ForeColor = System.Drawing.Color.Black
        Me.Label284.Location = New System.Drawing.Point(487, 181)
        Me.Label284.Name = "Label284"
        Me.Label284.Size = New System.Drawing.Size(31, 21)
        Me.Label284.TabIndex = 164
        Me.Label284.Text = "uA"
        '
        'Label285
        '
        Me.Label285.AutoSize = True
        Me.Label285.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label285.ForeColor = System.Drawing.Color.Black
        Me.Label285.Location = New System.Drawing.Point(487, 136)
        Me.Label285.Name = "Label285"
        Me.Label285.Size = New System.Drawing.Size(30, 21)
        Me.Label285.TabIndex = 165
        Me.Label285.Text = "kV"
        '
        'Label290
        '
        Me.Label290.AutoSize = True
        Me.Label290.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label290.ForeColor = System.Drawing.Color.Black
        Me.Label290.Location = New System.Drawing.Point(115, 181)
        Me.Label290.Name = "Label290"
        Me.Label290.Size = New System.Drawing.Size(145, 21)
        Me.Label290.TabIndex = 175
        Me.Label290.Text = "Ion Pump Current"
        '
        'Label292
        '
        Me.Label292.AutoSize = True
        Me.Label292.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label292.ForeColor = System.Drawing.Color.Black
        Me.Label292.Location = New System.Drawing.Point(115, 136)
        Me.Label292.Name = "Label292"
        Me.Label292.Size = New System.Drawing.Size(148, 21)
        Me.Label292.TabIndex = 173
        Me.Label292.Text = "Ion Pump Voltage"
        '
        'lblIonEi
        '
        Me.lblIonEi.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIonEi.ForeColor = System.Drawing.Color.Black
        Me.lblIonEi.Location = New System.Drawing.Point(386, 136)
        Me.lblIonEi.Name = "lblIonEi"
        Me.lblIonEi.Size = New System.Drawing.Size(95, 20)
        Me.lblIonEi.TabIndex = 171
        Me.lblIonEi.Text = "0"
        Me.lblIonEi.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblIonIi
        '
        Me.lblIonIi.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIonIi.ForeColor = System.Drawing.Color.Black
        Me.lblIonIi.Location = New System.Drawing.Point(386, 182)
        Me.lblIonIi.Name = "lblIonIi"
        Me.lblIonIi.Size = New System.Drawing.Size(95, 20)
        Me.lblIonIi.TabIndex = 170
        Me.lblIonIi.Text = "0"
        Me.lblIonIi.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label72
        '
        Me.Label72.AutoSize = True
        Me.Label72.BackColor = System.Drawing.SystemColors.Control
        Me.Label72.Font = New System.Drawing.Font("Segoe UI Semibold", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label72.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.Label72.Location = New System.Drawing.Point(259, 11)
        Me.Label72.Name = "Label72"
        Me.Label72.Size = New System.Drawing.Size(161, 45)
        Me.Label72.TabIndex = 2
        Me.Label72.Text = "Ion Pump"
        '
        'BlueRect12
        '
        Me.BlueRect12.Enabled = False
        Me.BlueRect12.Location = New System.Drawing.Point(50, 78)
        Me.BlueRect12.MyBorderColor = System.Drawing.Color.Black
        Me.BlueRect12.MyBorderWidth = 0.001!
        Me.BlueRect12.Name = "BlueRect12"
        Me.BlueRect12.Size = New System.Drawing.Size(572, 190)
        Me.BlueRect12.TabIndex = 80
        '
        'TabPageService
        '
        Me.TabPageService.BackColor = System.Drawing.SystemColors.Control
        Me.TabPageService.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TabPageService.Controls.Add(Me.lblLogFileName)
        Me.TabPageService.Controls.Add(Me.btnServiceModeChange)
        Me.TabPageService.Controls.Add(Me.btnServiceResetLinacTime)
        Me.TabPageService.Controls.Add(Me.btnIPaddress)
        Me.TabPageService.Controls.Add(Me.LabelComputerTime)
        Me.TabPageService.Controls.Add(Me.LabelECBTime)
        Me.TabPageService.Controls.Add(Me.btnServiceStartLog)
        Me.TabPageService.Controls.Add(Me.ledServiceNormalMode)
        Me.TabPageService.Controls.Add(Me.ledServiceDevMode)
        Me.TabPageService.Controls.Add(Me.ledServicePulseLogActive)
        Me.TabPageService.Controls.Add(Me.ledServiceServMode)
        Me.TabPageService.Controls.Add(Me.Label122)
        Me.TabPageService.Controls.Add(Me.Label255)
        Me.TabPageService.Controls.Add(Me.Label286)
        Me.TabPageService.Controls.Add(Me.Label254)
        Me.TabPageService.Controls.Add(Me.Label74)
        Me.TabPageService.Controls.Add(Me.BlueRect1)
        Me.TabPageService.Controls.Add(Me.BlueRect14)
        Me.TabPageService.Controls.Add(Me.BlueRect2)
        Me.TabPageService.ForeColor = System.Drawing.Color.Black
        Me.TabPageService.Location = New System.Drawing.Point(0, 0)
        Me.TabPageService.Name = "TabPageService"
        Me.TabPageService.Size = New System.Drawing.Size(680, 580)
        Me.TabPageService.TabIndex = 10
        Me.TabPageService.Text = "TabPage9"
        '
        'lblLogFileName
        '
        Me.lblLogFileName.AutoSize = True
        Me.lblLogFileName.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLogFileName.ForeColor = System.Drawing.Color.Black
        Me.lblLogFileName.Location = New System.Drawing.Point(107, 231)
        Me.lblLogFileName.Name = "lblLogFileName"
        Me.lblLogFileName.Size = New System.Drawing.Size(110, 21)
        Me.lblLogFileName.TabIndex = 411
        Me.lblLogFileName.Text = "Log File Name"
        '
        'btnServiceModeChange
        '
        Me.btnServiceModeChange.BackColor = System.Drawing.Color.Blue
        Me.btnServiceModeChange.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnServiceModeChange.ForeColor = System.Drawing.Color.Blue
        Me.btnServiceModeChange.Location = New System.Drawing.Point(414, 85)
        Me.btnServiceModeChange.Name = "btnServiceModeChange"
        Me.btnServiceModeChange.Size = New System.Drawing.Size(173, 33)
        Me.btnServiceModeChange.TabIndex = 410
        Me.btnServiceModeChange.Tag = "1"
        Me.btnServiceModeChange.Text = "Logout"
        Me.btnServiceModeChange.UseVisualStyleBackColor = True
        '
        'btnServiceResetLinacTime
        '
        Me.btnServiceResetLinacTime.BackColor = System.Drawing.Color.Blue
        Me.btnServiceResetLinacTime.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnServiceResetLinacTime.ForeColor = System.Drawing.Color.Blue
        Me.btnServiceResetLinacTime.Location = New System.Drawing.Point(414, 292)
        Me.btnServiceResetLinacTime.Name = "btnServiceResetLinacTime"
        Me.btnServiceResetLinacTime.Size = New System.Drawing.Size(173, 33)
        Me.btnServiceResetLinacTime.TabIndex = 409
        Me.btnServiceResetLinacTime.Tag = "1"
        Me.btnServiceResetLinacTime.Text = "Reset Linac Time"
        Me.btnServiceResetLinacTime.UseVisualStyleBackColor = True
        '
        'btnIPaddress
        '
        Me.btnIPaddress.BackColor = System.Drawing.Color.Blue
        Me.btnIPaddress.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnIPaddress.ForeColor = System.Drawing.Color.Blue
        Me.btnIPaddress.Location = New System.Drawing.Point(55, 406)
        Me.btnIPaddress.Name = "btnIPaddress"
        Me.btnIPaddress.Size = New System.Drawing.Size(253, 33)
        Me.btnIPaddress.TabIndex = 409
        Me.btnIPaddress.Tag = "1"
        Me.btnIPaddress.Text = "Set IP Address"
        Me.btnIPaddress.UseVisualStyleBackColor = True
        Me.btnIPaddress.Visible = False
        '
        'LabelComputerTime
        '
        Me.LabelComputerTime.AutoSize = True
        Me.LabelComputerTime.BackColor = System.Drawing.SystemColors.Control
        Me.LabelComputerTime.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelComputerTime.ForeColor = System.Drawing.Color.Black
        Me.LabelComputerTime.Location = New System.Drawing.Point(79, 327)
        Me.LabelComputerTime.Name = "LabelComputerTime"
        Me.LabelComputerTime.Size = New System.Drawing.Size(165, 21)
        Me.LabelComputerTime.TabIndex = 1
        Me.LabelComputerTime.Text = "LabelComputerTime"
        '
        'LabelECBTime
        '
        Me.LabelECBTime.AutoSize = True
        Me.LabelECBTime.BackColor = System.Drawing.SystemColors.Control
        Me.LabelECBTime.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelECBTime.ForeColor = System.Drawing.Color.Black
        Me.LabelECBTime.Location = New System.Drawing.Point(79, 292)
        Me.LabelECBTime.Name = "LabelECBTime"
        Me.LabelECBTime.Size = New System.Drawing.Size(126, 21)
        Me.LabelECBTime.TabIndex = 1
        Me.LabelECBTime.Text = "Label ECB Time"
        '
        'btnServiceStartLog
        '
        Me.btnServiceStartLog.BackColor = System.Drawing.Color.Blue
        Me.btnServiceStartLog.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnServiceStartLog.ForeColor = System.Drawing.Color.Blue
        Me.btnServiceStartLog.Location = New System.Drawing.Point(414, 197)
        Me.btnServiceStartLog.Name = "btnServiceStartLog"
        Me.btnServiceStartLog.Size = New System.Drawing.Size(173, 33)
        Me.btnServiceStartLog.TabIndex = 409
        Me.btnServiceStartLog.Tag = "1"
        Me.btnServiceStartLog.Text = "Start Pulse Logging"
        Me.btnServiceStartLog.UseVisualStyleBackColor = True
        '
        'ledServiceNormalMode
        '
        Me.ledServiceNormalMode.FillColor = System.Drawing.SystemColors.Control
        Me.ledServiceNormalMode.ForeColor = System.Drawing.SystemColors.Control
        Me.ledServiceNormalMode.Location = New System.Drawing.Point(83, 85)
        Me.ledServiceNormalMode.MyBorderColor = System.Drawing.Color.Black
        Me.ledServiceNormalMode.MyBorderWidth = 2
        Me.ledServiceNormalMode.Name = "ledServiceNormalMode"
        Me.ledServiceNormalMode.Size = New System.Drawing.Size(18, 20)
        Me.ledServiceNormalMode.TabIndex = 396
        '
        'ledServiceDevMode
        '
        Me.ledServiceDevMode.FillColor = System.Drawing.SystemColors.Control
        Me.ledServiceDevMode.ForeColor = System.Drawing.SystemColors.Control
        Me.ledServiceDevMode.Location = New System.Drawing.Point(83, 145)
        Me.ledServiceDevMode.MyBorderColor = System.Drawing.Color.Black
        Me.ledServiceDevMode.MyBorderWidth = 2
        Me.ledServiceDevMode.Name = "ledServiceDevMode"
        Me.ledServiceDevMode.Size = New System.Drawing.Size(18, 20)
        Me.ledServiceDevMode.TabIndex = 396
        '
        'ledServicePulseLogActive
        '
        Me.ledServicePulseLogActive.FillColor = System.Drawing.SystemColors.Control
        Me.ledServicePulseLogActive.ForeColor = System.Drawing.SystemColors.Control
        Me.ledServicePulseLogActive.Location = New System.Drawing.Point(83, 200)
        Me.ledServicePulseLogActive.MyBorderColor = System.Drawing.Color.Black
        Me.ledServicePulseLogActive.MyBorderWidth = 2
        Me.ledServicePulseLogActive.Name = "ledServicePulseLogActive"
        Me.ledServicePulseLogActive.Size = New System.Drawing.Size(18, 20)
        Me.ledServicePulseLogActive.TabIndex = 396
        '
        'ledServiceServMode
        '
        Me.ledServiceServMode.FillColor = System.Drawing.Color.Black
        Me.ledServiceServMode.ForeColor = System.Drawing.Color.White
        Me.ledServiceServMode.Location = New System.Drawing.Point(83, 115)
        Me.ledServiceServMode.MyBorderColor = System.Drawing.Color.Black
        Me.ledServiceServMode.MyBorderWidth = 2
        Me.ledServiceServMode.Name = "ledServiceServMode"
        Me.ledServiceServMode.Size = New System.Drawing.Size(18, 20)
        Me.ledServiceServMode.TabIndex = 393
        '
        'Label122
        '
        Me.Label122.AutoSize = True
        Me.Label122.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label122.ForeColor = System.Drawing.Color.Black
        Me.Label122.Location = New System.Drawing.Point(107, 85)
        Me.Label122.Name = "Label122"
        Me.Label122.Size = New System.Drawing.Size(116, 21)
        Me.Label122.TabIndex = 367
        Me.Label122.Text = "Normal Mode"
        '
        'Label255
        '
        Me.Label255.AutoSize = True
        Me.Label255.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label255.ForeColor = System.Drawing.Color.Black
        Me.Label255.Location = New System.Drawing.Point(107, 145)
        Me.Label255.Name = "Label255"
        Me.Label255.Size = New System.Drawing.Size(137, 21)
        Me.Label255.TabIndex = 367
        Me.Label255.Text = "Developer Mode"
        '
        'Label286
        '
        Me.Label286.AutoSize = True
        Me.Label286.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label286.ForeColor = System.Drawing.Color.Black
        Me.Label286.Location = New System.Drawing.Point(107, 200)
        Me.Label286.Name = "Label286"
        Me.Label286.Size = New System.Drawing.Size(118, 21)
        Me.Label286.TabIndex = 367
        Me.Label286.Text = "Pulse Logging"
        '
        'Label254
        '
        Me.Label254.AutoSize = True
        Me.Label254.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label254.ForeColor = System.Drawing.Color.Black
        Me.Label254.Location = New System.Drawing.Point(107, 115)
        Me.Label254.Name = "Label254"
        Me.Label254.Size = New System.Drawing.Size(113, 21)
        Me.Label254.TabIndex = 366
        Me.Label254.Text = "Service Mode"
        '
        'Label74
        '
        Me.Label74.AutoSize = True
        Me.Label74.BackColor = System.Drawing.SystemColors.Control
        Me.Label74.Font = New System.Drawing.Font("Segoe UI Semibold", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label74.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.Label74.Location = New System.Drawing.Point(235, 11)
        Me.Label74.Name = "Label74"
        Me.Label74.Size = New System.Drawing.Size(209, 45)
        Me.Label74.TabIndex = 364
        Me.Label74.Text = "Service Tools"
        '
        'BlueRect1
        '
        Me.BlueRect1.Enabled = False
        Me.BlueRect1.Location = New System.Drawing.Point(55, 268)
        Me.BlueRect1.MyBorderColor = System.Drawing.Color.Black
        Me.BlueRect1.MyBorderWidth = 0.001!
        Me.BlueRect1.Name = "BlueRect1"
        Me.BlueRect1.Size = New System.Drawing.Size(578, 98)
        Me.BlueRect1.TabIndex = 80
        '
        'BlueRect14
        '
        Me.BlueRect14.Enabled = False
        Me.BlueRect14.Location = New System.Drawing.Point(55, 68)
        Me.BlueRect14.MyBorderColor = System.Drawing.Color.Black
        Me.BlueRect14.MyBorderWidth = 0.001!
        Me.BlueRect14.Name = "BlueRect14"
        Me.BlueRect14.Size = New System.Drawing.Size(578, 110)
        Me.BlueRect14.TabIndex = 80
        '
        'BlueRect2
        '
        Me.BlueRect2.Enabled = False
        Me.BlueRect2.Location = New System.Drawing.Point(55, 170)
        Me.BlueRect2.MyBorderColor = System.Drawing.Color.Black
        Me.BlueRect2.MyBorderWidth = 0.001!
        Me.BlueRect2.Name = "BlueRect2"
        Me.BlueRect2.Size = New System.Drawing.Size(578, 110)
        Me.BlueRect2.TabIndex = 80
        '
        'TabPageServicePanel
        '
        Me.TabPageServicePanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TabPageServicePanel.Controls.Add(Me.Label2)
        Me.TabPageServicePanel.Controls.Add(Me.Label3)
        Me.TabPageServicePanel.Controls.Add(Me.Label9)
        Me.TabPageServicePanel.Controls.Add(Me.btnLoadParameters)
        Me.TabPageServicePanel.Controls.Add(Me.BlueRect3)
        Me.TabPageServicePanel.Controls.Add(Me.btnSaveAllParams)
        Me.TabPageServicePanel.Controls.Add(Me.btnServiceRestoreFactoryDefaults)
        Me.TabPageServicePanel.Controls.Add(Me.btnMagnetronConditioning)
        Me.TabPageServicePanel.Controls.Add(Me.btnZeroArcPulseCounters)
        Me.TabPageServicePanel.Location = New System.Drawing.Point(0, 0)
        Me.TabPageServicePanel.Name = "TabPageServicePanel"
        Me.TabPageServicePanel.Size = New System.Drawing.Size(680, 580)
        Me.TabPageServicePanel.TabIndex = 12
        Me.TabPageServicePanel.Text = "TabPageService"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.Control
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(76, 137)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 21)
        Me.Label2.TabIndex = 412
        Me.Label2.Text = "Label2"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.Control
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(76, 102)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 21)
        Me.Label3.TabIndex = 413
        Me.Label3.Text = "Label1"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.SystemColors.Control
        Me.Label9.Font = New System.Drawing.Font("Segoe UI Semibold", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(232, 11)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(211, 45)
        Me.Label9.TabIndex = 417
        Me.Label9.Text = "Service Panel"
        '
        'btnLoadParameters
        '
        Me.btnLoadParameters.BackColor = System.Drawing.Color.Blue
        Me.btnLoadParameters.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLoadParameters.ForeColor = System.Drawing.Color.Blue
        Me.btnLoadParameters.Location = New System.Drawing.Point(52, 471)
        Me.btnLoadParameters.Name = "btnLoadParameters"
        Me.btnLoadParameters.Size = New System.Drawing.Size(253, 33)
        Me.btnLoadParameters.TabIndex = 409
        Me.btnLoadParameters.Tag = "1"
        Me.btnLoadParameters.Text = "Load All Parameters"
        Me.btnLoadParameters.UseVisualStyleBackColor = True
        '
        'BlueRect3
        '
        Me.BlueRect3.Enabled = False
        Me.BlueRect3.Location = New System.Drawing.Point(52, 78)
        Me.BlueRect3.MyBorderColor = System.Drawing.Color.Black
        Me.BlueRect3.MyBorderWidth = 0.001!
        Me.BlueRect3.Name = "BlueRect3"
        Me.BlueRect3.Size = New System.Drawing.Size(578, 98)
        Me.BlueRect3.TabIndex = 415
        '
        'btnSaveAllParams
        '
        Me.btnSaveAllParams.BackColor = System.Drawing.Color.Blue
        Me.btnSaveAllParams.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSaveAllParams.ForeColor = System.Drawing.Color.Blue
        Me.btnSaveAllParams.Location = New System.Drawing.Point(52, 415)
        Me.btnSaveAllParams.Name = "btnSaveAllParams"
        Me.btnSaveAllParams.Size = New System.Drawing.Size(253, 33)
        Me.btnSaveAllParams.TabIndex = 409
        Me.btnSaveAllParams.Tag = "1"
        Me.btnSaveAllParams.Text = "Save All Parameters"
        Me.btnSaveAllParams.UseVisualStyleBackColor = True
        '
        'btnServiceRestoreFactoryDefaults
        '
        Me.btnServiceRestoreFactoryDefaults.BackColor = System.Drawing.Color.Blue
        Me.btnServiceRestoreFactoryDefaults.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnServiceRestoreFactoryDefaults.ForeColor = System.Drawing.Color.Blue
        Me.btnServiceRestoreFactoryDefaults.Location = New System.Drawing.Point(52, 300)
        Me.btnServiceRestoreFactoryDefaults.Name = "btnServiceRestoreFactoryDefaults"
        Me.btnServiceRestoreFactoryDefaults.Size = New System.Drawing.Size(253, 33)
        Me.btnServiceRestoreFactoryDefaults.TabIndex = 409
        Me.btnServiceRestoreFactoryDefaults.Tag = "1"
        Me.btnServiceRestoreFactoryDefaults.Text = "Restore Factory Settings"
        Me.btnServiceRestoreFactoryDefaults.UseVisualStyleBackColor = True
        '
        'btnMagnetronConditioning
        '
        Me.btnMagnetronConditioning.BackColor = System.Drawing.Color.Blue
        Me.btnMagnetronConditioning.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMagnetronConditioning.ForeColor = System.Drawing.Color.Blue
        Me.btnMagnetronConditioning.Location = New System.Drawing.Point(377, 248)
        Me.btnMagnetronConditioning.Name = "btnMagnetronConditioning"
        Me.btnMagnetronConditioning.Size = New System.Drawing.Size(253, 33)
        Me.btnMagnetronConditioning.TabIndex = 409
        Me.btnMagnetronConditioning.Tag = "1"
        Me.btnMagnetronConditioning.Text = "Magnetron Conditioning"
        Me.btnMagnetronConditioning.UseVisualStyleBackColor = True
        '
        'btnZeroArcPulseCounters
        '
        Me.btnZeroArcPulseCounters.BackColor = System.Drawing.Color.Blue
        Me.btnZeroArcPulseCounters.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnZeroArcPulseCounters.ForeColor = System.Drawing.Color.Blue
        Me.btnZeroArcPulseCounters.Location = New System.Drawing.Point(52, 248)
        Me.btnZeroArcPulseCounters.Name = "btnZeroArcPulseCounters"
        Me.btnZeroArcPulseCounters.Size = New System.Drawing.Size(253, 33)
        Me.btnZeroArcPulseCounters.TabIndex = 409
        Me.btnZeroArcPulseCounters.Tag = "1"
        Me.btnZeroArcPulseCounters.Text = "Zero Arc && Pulse Counters"
        Me.btnZeroArcPulseCounters.UseVisualStyleBackColor = True
        '
        'tabPageDeveloper
        '
        Me.tabPageDeveloper.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.tabPageDeveloper.Controls.Add(Me.Label11)
        Me.tabPageDeveloper.Controls.Add(Me.LabelGUIVersionDeploy)
        Me.tabPageDeveloper.Controls.Add(Me.Label12)
        Me.tabPageDeveloper.Controls.Add(Me.Label17)
        Me.tabPageDeveloper.Controls.Add(Me.btnZeroOnTime)
        Me.tabPageDeveloper.Controls.Add(Me.btnRestoreData)
        Me.tabPageDeveloper.Controls.Add(Me.btnServiceReloadInitialDefaults)
        Me.tabPageDeveloper.Controls.Add(Me.btnClearDebugData)
        Me.tabPageDeveloper.Controls.Add(Me.BlueRect17)
        Me.tabPageDeveloper.Controls.Add(Me.btnServiceSaveFactoryDefaults)
        Me.tabPageDeveloper.Controls.Add(Me.btnDumpData)
        Me.tabPageDeveloper.Location = New System.Drawing.Point(0, 0)
        Me.tabPageDeveloper.Name = "tabPageDeveloper"
        Me.tabPageDeveloper.Size = New System.Drawing.Size(680, 580)
        Me.tabPageDeveloper.TabIndex = 13
        Me.tabPageDeveloper.Text = "TabPageDeveloper"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.SystemColors.Control
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(76, 129)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(69, 21)
        Me.Label11.TabIndex = 412
        Me.Label11.Text = "Label11"
        '
        'LabelGUIVersionDeploy
        '
        Me.LabelGUIVersionDeploy.AutoSize = True
        Me.LabelGUIVersionDeploy.BackColor = System.Drawing.SystemColors.Control
        Me.LabelGUIVersionDeploy.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelGUIVersionDeploy.ForeColor = System.Drawing.Color.Black
        Me.LabelGUIVersionDeploy.Location = New System.Drawing.Point(373, 529)
        Me.LabelGUIVersionDeploy.Name = "LabelGUIVersionDeploy"
        Me.LabelGUIVersionDeploy.Size = New System.Drawing.Size(127, 21)
        Me.LabelGUIVersionDeploy.TabIndex = 101
        Me.LabelGUIVersionDeploy.Text = "GUI Version 1.00"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.SystemColors.Control
        Me.Label12.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(76, 94)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(69, 21)
        Me.Label12.TabIndex = 413
        Me.Label12.Text = "Label10"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.SystemColors.Control
        Me.Label17.Font = New System.Drawing.Font("Segoe UI Semibold", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.Label17.Location = New System.Drawing.Point(217, 11)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(257, 45)
        Me.Label17.TabIndex = 417
        Me.Label17.Text = "Developer Panel"
        '
        'btnZeroOnTime
        '
        Me.btnZeroOnTime.BackColor = System.Drawing.Color.Blue
        Me.btnZeroOnTime.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnZeroOnTime.ForeColor = System.Drawing.Color.Blue
        Me.btnZeroOnTime.Location = New System.Drawing.Point(377, 225)
        Me.btnZeroOnTime.Name = "btnZeroOnTime"
        Me.btnZeroOnTime.Size = New System.Drawing.Size(253, 33)
        Me.btnZeroOnTime.TabIndex = 409
        Me.btnZeroOnTime.Tag = "1"
        Me.btnZeroOnTime.Text = "Zero On Time Counters"
        Me.btnZeroOnTime.UseVisualStyleBackColor = True
        '
        'btnRestoreData
        '
        Me.btnRestoreData.BackColor = System.Drawing.Color.Blue
        Me.btnRestoreData.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRestoreData.ForeColor = System.Drawing.Color.Blue
        Me.btnRestoreData.Location = New System.Drawing.Point(52, 461)
        Me.btnRestoreData.Name = "btnRestoreData"
        Me.btnRestoreData.Size = New System.Drawing.Size(253, 33)
        Me.btnRestoreData.TabIndex = 409
        Me.btnRestoreData.Tag = "1"
        Me.btnRestoreData.Text = "Restore Dumped Data"
        Me.btnRestoreData.UseVisualStyleBackColor = True
        '
        'btnServiceReloadInitialDefaults
        '
        Me.btnServiceReloadInitialDefaults.BackColor = System.Drawing.Color.Blue
        Me.btnServiceReloadInitialDefaults.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnServiceReloadInitialDefaults.ForeColor = System.Drawing.Color.Blue
        Me.btnServiceReloadInitialDefaults.Location = New System.Drawing.Point(52, 228)
        Me.btnServiceReloadInitialDefaults.Name = "btnServiceReloadInitialDefaults"
        Me.btnServiceReloadInitialDefaults.Size = New System.Drawing.Size(253, 33)
        Me.btnServiceReloadInitialDefaults.TabIndex = 409
        Me.btnServiceReloadInitialDefaults.Tag = "1"
        Me.btnServiceReloadInitialDefaults.Text = "Reload Initial Settings"
        Me.btnServiceReloadInitialDefaults.UseVisualStyleBackColor = True
        '
        'btnClearDebugData
        '
        Me.btnClearDebugData.BackColor = System.Drawing.Color.Blue
        Me.btnClearDebugData.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClearDebugData.ForeColor = System.Drawing.Color.Blue
        Me.btnClearDebugData.Location = New System.Drawing.Point(377, 292)
        Me.btnClearDebugData.Name = "btnClearDebugData"
        Me.btnClearDebugData.Size = New System.Drawing.Size(253, 33)
        Me.btnClearDebugData.TabIndex = 409
        Me.btnClearDebugData.Tag = "1"
        Me.btnClearDebugData.Text = "Clear Debugging Data"
        Me.btnClearDebugData.UseVisualStyleBackColor = True
        '
        'BlueRect17
        '
        Me.BlueRect17.Enabled = False
        Me.BlueRect17.Location = New System.Drawing.Point(52, 70)
        Me.BlueRect17.MyBorderColor = System.Drawing.Color.Black
        Me.BlueRect17.MyBorderWidth = 0.001!
        Me.BlueRect17.Name = "BlueRect17"
        Me.BlueRect17.Size = New System.Drawing.Size(578, 98)
        Me.BlueRect17.TabIndex = 415
        '
        'btnServiceSaveFactoryDefaults
        '
        Me.btnServiceSaveFactoryDefaults.BackColor = System.Drawing.Color.Blue
        Me.btnServiceSaveFactoryDefaults.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnServiceSaveFactoryDefaults.ForeColor = System.Drawing.Color.Blue
        Me.btnServiceSaveFactoryDefaults.Location = New System.Drawing.Point(52, 292)
        Me.btnServiceSaveFactoryDefaults.Name = "btnServiceSaveFactoryDefaults"
        Me.btnServiceSaveFactoryDefaults.Size = New System.Drawing.Size(253, 33)
        Me.btnServiceSaveFactoryDefaults.TabIndex = 409
        Me.btnServiceSaveFactoryDefaults.Tag = "1"
        Me.btnServiceSaveFactoryDefaults.Text = "Save Factory Settings"
        Me.btnServiceSaveFactoryDefaults.UseVisualStyleBackColor = True
        '
        'btnDumpData
        '
        Me.btnDumpData.BackColor = System.Drawing.Color.Blue
        Me.btnDumpData.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDumpData.ForeColor = System.Drawing.Color.Blue
        Me.btnDumpData.Location = New System.Drawing.Point(52, 406)
        Me.btnDumpData.Name = "btnDumpData"
        Me.btnDumpData.Size = New System.Drawing.Size(253, 33)
        Me.btnDumpData.TabIndex = 409
        Me.btnDumpData.Tag = "1"
        Me.btnDumpData.Text = "Dump Data"
        Me.btnDumpData.UseVisualStyleBackColor = True
        '
        'BlueRectMain
        '
        Me.BlueRectMain.Enabled = False
        Me.BlueRectMain.Location = New System.Drawing.Point(28, 410)
        Me.BlueRectMain.MyBorderColor = System.Drawing.Color.Black
        Me.BlueRectMain.MyBorderWidth = 0.001!
        Me.BlueRectMain.Name = "BlueRectMain"
        Me.BlueRectMain.Size = New System.Drawing.Size(296, 184)
        Me.BlueRectMain.TabIndex = 80
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1280, 721)
        Me.Controls.Add(Me.lblDoseRateTitle)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.PanelRadRight)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.PanelRadLeft)
        Me.Controls.Add(Me.lblBeamDuration)
        Me.Controls.Add(Me.lblIonIi2Unit)
        Me.Controls.Add(Me.lblIonIi2Title)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.btnResetFault)
        Me.Controls.Add(Me.lblIonIi2)
        Me.Controls.Add(Me.Label32)
        Me.Controls.Add(Me.PictureBoxLogo)
        Me.Controls.Add(Me.lblDoseCommand)
        Me.Controls.Add(Me.panelDispButtons)
        Me.Controls.Add(Me.TabBoards)
        Me.Controls.Add(Me.lblNoTrigger)
        Me.Controls.Add(Me.lblPulseFreq)
        Me.Controls.Add(Me.lblAccessLevel)
        Me.Controls.Add(Me.lblDoseRate)
        Me.Controls.Add(Me.lblSystem)
        Me.Controls.Add(Me.lblDoseRateUnit)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Label29)
        Me.Controls.Add(Me.lblScanMode)
        Me.Controls.Add(Me.lblShowDumpData)
        Me.Controls.Add(Me.LabelECBState)
        Me.Controls.Add(Me.BlueRectMain)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMain"
        Me.Text = "No Connection"
        Me.panelDispButtons.ResumeLayout(False)
        CType(Me.PictureBoxLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.PanelRadLeft.ResumeLayout(False)
        Me.PanelRadLeft.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelRadRight.ResumeLayout(False)
        Me.PanelRadRight.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabBoards.ResumeLayout(False)
        Me.TabPageOverview.ResumeLayout(False)
        Me.TabPageOverview.PerformLayout()
        Me.TabPageCPU.ResumeLayout(False)
        Me.TabPageCPU.PerformLayout()
        Me.TabPageGunDriver.ResumeLayout(False)
        Me.TabPageGunDriver.PerformLayout()
        Me.TabPageCooling.ResumeLayout(False)
        Me.TabPageCooling.PerformLayout()
        Me.TabPagePulseSync.ResumeLayout(False)
        Me.TabPagePulseSync.PerformLayout()
        Me.TabPageHVsupply.ResumeLayout(False)
        Me.TabPageHVsupply.PerformLayout()
        Me.TabPageMagnetron.ResumeLayout(False)
        Me.TabPageMagnetron.PerformLayout()
        Me.PanelMagnetronLeds.ResumeLayout(False)
        Me.PanelMagnetronLeds.PerformLayout()
        Me.PanelArcCounts.ResumeLayout(False)
        Me.PanelArcCounts.PerformLayout()
        Me.TabPageAFC.ResumeLayout(False)
        Me.TabPageAFC.PerformLayout()
        Me.TabPageMagnetrHtr.ResumeLayout(False)
        Me.TabPageMagnetrHtr.PerformLayout()
        Me.TabPageIonPump.ResumeLayout(False)
        Me.TabPageIonPump.PerformLayout()
        Me.panelIonPumpLogger.ResumeLayout(False)
        Me.panelIonPumpLogger.PerformLayout()
        Me.TabPageService.ResumeLayout(False)
        Me.TabPageService.PerformLayout()
        Me.TabPageServicePanel.ResumeLayout(False)
        Me.TabPageServicePanel.PerformLayout()
        Me.tabPageDeveloper.ResumeLayout(False)
        Me.tabPageDeveloper.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TimerUpdate As System.Windows.Forms.Timer
    Friend WithEvents LabelAgileInfo As System.Windows.Forms.Label
    Friend WithEvents LabelFirmwareVersion As System.Windows.Forms.Label
    Friend WithEvents TabBoards As CustomControls.RightSideTab
    Friend WithEvents TabPageCPU As System.Windows.Forms.TabPage
    Friend WithEvents btnDispOverview As CustomControls.ButtonSelected
    Friend WithEvents btnDispSysCPU As CustomControls.ButtonSelected
    Friend WithEvents btnDispGunDriver As CustomControls.ButtonSelected
    Friend WithEvents btnDispCoolSF6 As CustomControls.ButtonSelected
    Friend WithEvents btnDispPulseSync As CustomControls.ButtonSelected
    Friend WithEvents btnDispHV As CustomControls.ButtonSelected
    Friend WithEvents btnDispMagnetron As CustomControls.ButtonSelected
    Friend WithEvents btnDispAFC As CustomControls.ButtonSelected
    Friend WithEvents btnDispMagHtr As CustomControls.ButtonSelected
    Friend WithEvents btnDispIonPump As CustomControls.ButtonSelected
    Friend WithEvents btnDispService As CustomControls.ButtonSelected
    Friend WithEvents panelDispButtons As System.Windows.Forms.Panel
    Friend WithEvents PictureBoxLogo As System.Windows.Forms.PictureBox
    Friend WithEvents TabPageGunDriver As System.Windows.Forms.TabPage
    Friend WithEvents TabPagePulseSync As System.Windows.Forms.TabPage
    Friend WithEvents TabPageHVsupply As System.Windows.Forms.TabPage
    Friend WithEvents TabPageMagnetron As System.Windows.Forms.TabPage
    Friend WithEvents TabPageAFC As System.Windows.Forms.TabPage
    Friend WithEvents TabPageMagnetrHtr As System.Windows.Forms.TabPage
    Friend WithEvents TabPageIonPump As System.Windows.Forms.TabPage
    Friend WithEvents TabPageService As System.Windows.Forms.TabPage
    Friend WithEvents lblSystem As System.Windows.Forms.Label
    Friend WithEvents LabelECBState As System.Windows.Forms.Label
    Friend WithEvents ledWCpuDriveupTimeout As CustomControls.OvalLed
    Friend WithEvents ledCpuReadyFault As CustomControls.OvalLed
    Friend WithEvents ledCpuXrayLogic As CustomControls.OvalLed
    Friend WithEvents Label38 As System.Windows.Forms.Label
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents Label50 As System.Windows.Forms.Label
    Friend WithEvents Label39 As System.Windows.Forms.Label
    Friend WithEvents Label40 As System.Windows.Forms.Label
    Friend WithEvents Label41 As System.Windows.Forms.Label
    Friend WithEvents lblCpuPwrOnTime As System.Windows.Forms.Label
    Friend WithEvents lblCpuHvTime As System.Windows.Forms.Label
    Friend WithEvents lblCpuMagnetronPwr As System.Windows.Forms.Label
    Friend WithEvents Label43 As System.Windows.Forms.Label
    Friend WithEvents lblCpuXrayTime As System.Windows.Forms.Label
    Friend WithEvents Label57 As System.Windows.Forms.Label
    Friend WithEvents Label51 As System.Windows.Forms.Label
    Friend WithEvents lblCpuWarmupThy As System.Windows.Forms.Label
    Friend WithEvents lblCpuWarmupMag As System.Windows.Forms.Label
    Friend WithEvents Label52 As System.Windows.Forms.Label
    Friend WithEvents lblCpuWarmupGd As System.Windows.Forms.Label
    Friend WithEvents ledGdFPGArev As CustomControls.OvalLed
    Friend WithEvents Label61 As System.Windows.Forms.Label
    Friend WithEvents Label62 As System.Windows.Forms.Label
    Friend WithEvents Label63 As System.Windows.Forms.Label
    Friend WithEvents lblGdEk As System.Windows.Forms.Label
    Friend WithEvents Label65 As System.Windows.Forms.Label
    Friend WithEvents Label67 As System.Windows.Forms.Label
    Friend WithEvents Label68 As System.Windows.Forms.Label
    Friend WithEvents Label69 As System.Windows.Forms.Label
    Friend WithEvents Label70 As System.Windows.Forms.Label
    Friend WithEvents Label71 As System.Windows.Forms.Label
    Friend WithEvents Label72 As System.Windows.Forms.Label
    Friend WithEvents Label74 As System.Windows.Forms.Label
    Friend WithEvents Label89 As System.Windows.Forms.Label
    Friend WithEvents Label86 As System.Windows.Forms.Label
    Friend WithEvents Label83 As System.Windows.Forms.Label
    Friend WithEvents Label80 As System.Windows.Forms.Label
    Friend WithEvents Label77 As System.Windows.Forms.Label
    Friend WithEvents Label88 As System.Windows.Forms.Label
    Friend WithEvents lblGdEc As System.Windows.Forms.Label
    Friend WithEvents Label85 As System.Windows.Forms.Label
    Friend WithEvents lblGdEg As System.Windows.Forms.Label
    Friend WithEvents Label82 As System.Windows.Forms.Label
    Friend WithEvents lblGdIf As System.Windows.Forms.Label
    Friend WithEvents Label79 As System.Windows.Forms.Label
    Friend WithEvents lblGdEf As System.Windows.Forms.Label
    Friend WithEvents Label76 As System.Windows.Forms.Label
    Friend WithEvents lblGdIkp As System.Windows.Forms.Label
    Friend WithEvents btnGdEgsetCargo As System.Windows.Forms.Button
    Friend WithEvents btnGdIfSet As System.Windows.Forms.Button
    Friend WithEvents btnGdEkset As System.Windows.Forms.Button
    Friend WithEvents ledGdHtrStartup As CustomControls.OvalLed
    Friend WithEvents ledGdCAN As CustomControls.OvalLed
    Friend WithEvents ledGdADCread As CustomControls.OvalLed
    Friend WithEvents ledGdEgMon As CustomControls.OvalLed
    Friend WithEvents ledGdArc As CustomControls.OvalLed
    Friend WithEvents ledGdHVmon As CustomControls.OvalLed
    Friend WithEvents ledGdSPIcomm As CustomControls.OvalLed
    Friend WithEvents ledGdEcMon As CustomControls.OvalLed
    Friend WithEvents ledGdOT As CustomControls.OvalLed
    Friend WithEvents ledGdHtrMon As CustomControls.OvalLed
    Friend WithEvents ledGdGrid As CustomControls.OvalLed
    Friend WithEvents ledGdHtrOC As CustomControls.OvalLed
    Friend WithEvents Label104 As System.Windows.Forms.Label
    Friend WithEvents Label96 As System.Windows.Forms.Label
    Friend WithEvents Label102 As System.Windows.Forms.Label
    Friend WithEvents Label101 As System.Windows.Forms.Label
    Friend WithEvents Label95 As System.Windows.Forms.Label
    Friend WithEvents Label100 As System.Windows.Forms.Label
    Friend WithEvents Label94 As System.Windows.Forms.Label
    Friend WithEvents Label99 As System.Windows.Forms.Label
    Friend WithEvents Label91 As System.Windows.Forms.Label
    Friend WithEvents Label98 As System.Windows.Forms.Label
    Friend WithEvents Label93 As System.Windows.Forms.Label
    Friend WithEvents Label90 As System.Windows.Forms.Label
    Friend WithEvents lblSN As System.Windows.Forms.Label
    Friend WithEvents btnPfnDelay As System.Windows.Forms.Button
    Friend WithEvents btnPulseStartMax As System.Windows.Forms.Button
    Friend WithEvents ledWPulseLowOverride As CustomControls.OvalLed
    Friend WithEvents ledWPulseTrigFault As CustomControls.OvalLed
    Friend WithEvents ledPulseCanFault As CustomControls.OvalLed
    Friend WithEvents ledWPulseCustomHVon As CustomControls.OvalLed
    Friend WithEvents ledPulseKeylock As CustomControls.OvalLed
    Friend WithEvents ledPulsePFNfan As CustomControls.OvalLed
    Friend WithEvents ledWPulseCustomXrayOn As CustomControls.OvalLed
    Friend WithEvents ledPulseXrayTiming As CustomControls.OvalLed
    Friend WithEvents ledWPulseHighOverride As CustomControls.OvalLed
    Friend WithEvents ledPulseRFArc As CustomControls.OvalLed
    Friend WithEvents ledPulsePanel As CustomControls.OvalLed
    Friend WithEvents Label162 As System.Windows.Forms.Label
    Friend WithEvents Label165 As System.Windows.Forms.Label
    Friend WithEvents Label167 As System.Windows.Forms.Label
    Friend WithEvents Label168 As System.Windows.Forms.Label
    Friend WithEvents Label169 As System.Windows.Forms.Label
    Friend WithEvents Label170 As System.Windows.Forms.Label
    Friend WithEvents Label171 As System.Windows.Forms.Label
    Friend WithEvents Label172 As System.Windows.Forms.Label
    Friend WithEvents Label174 As System.Windows.Forms.Label
    Friend WithEvents Label175 As System.Windows.Forms.Label
    Friend WithEvents Label176 As System.Windows.Forms.Label
    Friend WithEvents btnPulseSampleDelay As System.Windows.Forms.Button
    Friend WithEvents btnHVsetCargo As System.Windows.Forms.Button
    Friend WithEvents ledWHvOT As CustomControls.OvalLed
    Friend WithEvents ledWHvLoadFault As CustomControls.OvalLed
    Friend WithEvents ledWHvHVoff As CustomControls.OvalLed
    Friend WithEvents ledWHvSumFault As CustomControls.OvalLed
    Friend WithEvents ledWHvPhaseLoss As CustomControls.OvalLed
    Friend WithEvents ledWHvIntlock As CustomControls.OvalLed
    Friend WithEvents ledWHvPowerOff As CustomControls.OvalLed
    Friend WithEvents ledHVCanFault As CustomControls.OvalLed
    Friend WithEvents Label158 As System.Windows.Forms.Label
    Friend WithEvents Label163 As System.Windows.Forms.Label
    Friend WithEvents Label164 As System.Windows.Forms.Label
    Friend WithEvents Label177 As System.Windows.Forms.Label
    Friend WithEvents Label178 As System.Windows.Forms.Label
    Friend WithEvents Label179 As System.Windows.Forms.Label
    Friend WithEvents Label181 As System.Windows.Forms.Label
    Friend WithEvents Label182 As System.Windows.Forms.Label
    Friend WithEvents Label183 As System.Windows.Forms.Label
    Friend WithEvents Label198 As System.Windows.Forms.Label
    Friend WithEvents Label199 As System.Windows.Forms.Label
    Friend WithEvents Label208 As System.Windows.Forms.Label
    Friend WithEvents lblHVcurrent As System.Windows.Forms.Label
    Friend WithEvents Label210 As System.Windows.Forms.Label
    Friend WithEvents lblHVprePulseVolt As System.Windows.Forms.Label
    Friend WithEvents ledCurrArcCont As CustomControls.OvalLed
    Friend WithEvents ledCurrArcSlow As CustomControls.OvalLed
    Friend WithEvents ledCurrArcFast As CustomControls.OvalLed
    Friend WithEvents ledCurrFalseTrig As CustomControls.OvalLed
    Friend WithEvents ledCurrCanFault As CustomControls.OvalLed
    Friend WithEvents Label197 As System.Windows.Forms.Label
    Friend WithEvents Label206 As System.Windows.Forms.Label
    Friend WithEvents Label212 As System.Windows.Forms.Label
    Friend WithEvents Label214 As System.Windows.Forms.Label
    Friend WithEvents Label215 As System.Windows.Forms.Label
    Friend WithEvents Label222 As System.Windows.Forms.Label
    Friend WithEvents lblCurrCabScan As System.Windows.Forms.Label
    Friend WithEvents Label224 As System.Windows.Forms.Label
    Friend WithEvents lblCurrCargoScan As System.Windows.Forms.Label
    Friend WithEvents Label226 As System.Windows.Forms.Label
    Friend WithEvents lblCurrArcsTotal As System.Windows.Forms.Label
    Friend WithEvents Label228 As System.Windows.Forms.Label
    Friend WithEvents lblCurrPulsesTotal As System.Windows.Forms.Label
    Friend WithEvents Label230 As System.Windows.Forms.Label
    Friend WithEvents lblCurrArcsPwrOn As System.Windows.Forms.Label
    Friend WithEvents Label232 As System.Windows.Forms.Label
    Friend WithEvents lblCurrPulsesPwrOn As System.Windows.Forms.Label
    Friend WithEvents Label216 As System.Windows.Forms.Label
    Friend WithEvents Label217 As System.Windows.Forms.Label
    Friend WithEvents btnAfcManualMode As System.Windows.Forms.Button
    Friend WithEvents btnAfcHomePosSet As System.Windows.Forms.Button
    Friend WithEvents btnAfcCargoCtrlVSet As System.Windows.Forms.Button
    Friend WithEvents ledWAfcManualMode As CustomControls.OvalLed
    Friend WithEvents ledAfcCanFault As CustomControls.OvalLed
    Friend WithEvents Label221 As System.Windows.Forms.Label
    Friend WithEvents Label234 As System.Windows.Forms.Label
    Friend WithEvents Label239 As System.Windows.Forms.Label
    Friend WithEvents Label241 As System.Windows.Forms.Label
    Friend WithEvents lblAfcPreAsample As System.Windows.Forms.Label
    Friend WithEvents Label243 As System.Windows.Forms.Label
    Friend WithEvents lblAfcFilteredError As System.Windows.Forms.Label
    Friend WithEvents Label249 As System.Windows.Forms.Label
    Friend WithEvents lblAfcHomePosition As System.Windows.Forms.Label
    Friend WithEvents Label251 As System.Windows.Forms.Label
    Friend WithEvents lblAfcPhaseCtrlV As System.Windows.Forms.Label
    Friend WithEvents Label161 As System.Windows.Forms.Label
    Friend WithEvents lblAfcPreBsample As System.Windows.Forms.Label
    Friend WithEvents btnMagIfSet As System.Windows.Forms.Button
    Friend WithEvents btnMagCargoIset As System.Windows.Forms.Button
    Friend WithEvents ledMagCanFault As CustomControls.OvalLed
    Friend WithEvents ledMagImUCAbs As CustomControls.OvalLed
    Friend WithEvents ledMagEmUVAbs As CustomControls.OvalLed
    Friend WithEvents ledMagTempSW As CustomControls.OvalLed
    Friend WithEvents ledMagEfUVRel As CustomControls.OvalLed
    Friend WithEvents ledWMagHtrOK As CustomControls.OvalLed
    Friend WithEvents ledMagIfOCRel As CustomControls.OvalLed
    Friend WithEvents ledMagCoolFault As CustomControls.OvalLed
    Friend WithEvents ledMagImOCAbs As CustomControls.OvalLed
    Friend WithEvents ledWMagEfOVLatch As CustomControls.OvalLed
    Friend WithEvents ledMagIfUCRel As CustomControls.OvalLed
    Friend WithEvents ledWMagOutRelayOpen As CustomControls.OvalLed
    Friend WithEvents ledWMagOK As CustomControls.OvalLed
    Friend WithEvents Label201 As System.Windows.Forms.Label
    Friend WithEvents ledMagIfOCAbs As CustomControls.OvalLed
    Friend WithEvents Label202 As System.Windows.Forms.Label
    Friend WithEvents Label203 As System.Windows.Forms.Label
    Friend WithEvents Label207 As System.Windows.Forms.Label
    Friend WithEvents Label218 As System.Windows.Forms.Label
    Friend WithEvents Label219 As System.Windows.Forms.Label
    Friend WithEvents Label220 As System.Windows.Forms.Label
    Friend WithEvents Label235 As System.Windows.Forms.Label
    Friend WithEvents Label236 As System.Windows.Forms.Label
    Friend WithEvents Label237 As System.Windows.Forms.Label
    Friend WithEvents Label238 As System.Windows.Forms.Label
    Friend WithEvents Label245 As System.Windows.Forms.Label
    Friend WithEvents Label246 As System.Windows.Forms.Label
    Friend WithEvents Label253 As System.Windows.Forms.Label
    Friend WithEvents Label256 As System.Windows.Forms.Label
    Friend WithEvents Label257 As System.Windows.Forms.Label
    Friend WithEvents Label258 As System.Windows.Forms.Label
    Friend WithEvents Label259 As System.Windows.Forms.Label
    Friend WithEvents Label264 As System.Windows.Forms.Label
    Friend WithEvents lblMagIf As System.Windows.Forms.Label
    Friend WithEvents Label266 As System.Windows.Forms.Label
    Friend WithEvents lblMagEf As System.Windows.Forms.Label
    Friend WithEvents Label268 As System.Windows.Forms.Label
    Friend WithEvents lblMagEm As System.Windows.Forms.Label
    Friend WithEvents Label270 As System.Windows.Forms.Label
    Friend WithEvents lblMagIm As System.Windows.Forms.Label
    Friend WithEvents ledIonUV As CustomControls.OvalLed
    Friend WithEvents ledIonOC As CustomControls.OvalLed
    Friend WithEvents ledIonCanFault As CustomControls.OvalLed
    Friend WithEvents Label262 As System.Windows.Forms.Label
    Friend WithEvents Label280 As System.Windows.Forms.Label
    Friend WithEvents Label281 As System.Windows.Forms.Label
    Friend WithEvents Label284 As System.Windows.Forms.Label
    Friend WithEvents Label285 As System.Windows.Forms.Label
    Friend WithEvents Label290 As System.Windows.Forms.Label
    Friend WithEvents lblIonIi As System.Windows.Forms.Label
    Friend WithEvents Label292 As System.Windows.Forms.Label
    Friend WithEvents lblIonEi As System.Windows.Forms.Label
    Friend WithEvents btnServiceStartLog As System.Windows.Forms.Button
    Friend WithEvents ledServicePulseLogActive As CustomControls.OvalLed
    Friend WithEvents Label286 As System.Windows.Forms.Label
    Friend WithEvents btnServiceSaveFactoryDefaults As System.Windows.Forms.Button
    Friend WithEvents btnServiceModeChange As System.Windows.Forms.Button
    Friend WithEvents ledServiceDevMode As CustomControls.OvalLed
    Friend WithEvents ledServiceServMode As CustomControls.OvalLed
    Friend WithEvents Label255 As System.Windows.Forms.Label
    Friend WithEvents Label254 As System.Windows.Forms.Label
    Friend WithEvents lblLogFileName As System.Windows.Forms.Label
    Friend WithEvents BlueRect4 As CustomControls.BlueRect
    Friend WithEvents TabPageCooling As System.Windows.Forms.TabPage
    Friend WithEvents btnCoolNewSF6bottle As System.Windows.Forms.Button
    Friend WithEvents btnCoolSF6Override As System.Windows.Forms.Button
    Friend WithEvents ledWSF6RelayClosed As CustomControls.OvalLed
    Friend WithEvents ledWNoSF6Pulses As CustomControls.OvalLed
    Friend WithEvents ledCoolCabTemp As CustomControls.OvalLed
    Friend WithEvents ledCoolCabTempSwitch As CustomControls.OvalLed
    Friend WithEvents ledCoolCirFlow As CustomControls.OvalLed
    Friend WithEvents ledWSF6TooLowToFill As CustomControls.OvalLed
    Friend WithEvents ledCoolMagFlow As CustomControls.OvalLed
    Friend WithEvents ledWSF6Filling As CustomControls.OvalLed
    Friend WithEvents ledWSF6FillReq As CustomControls.OvalLed
    Friend WithEvents ledCoolSF6press As CustomControls.OvalLed
    Friend WithEvents ledCoolLinacFlow As CustomControls.OvalLed
    Friend WithEvents ledWCoolTooCold As CustomControls.OvalLed
    Friend WithEvents ledCoolCoolTemp As CustomControls.OvalLed
    Friend WithEvents Label145 As System.Windows.Forms.Label
    Friend WithEvents Label111 As System.Windows.Forms.Label
    Friend WithEvents ledCoolCAN As CustomControls.OvalLed
    Friend WithEvents Label110 As System.Windows.Forms.Label
    Friend WithEvents Label113 As System.Windows.Forms.Label
    Friend WithEvents Label109 As System.Windows.Forms.Label
    Friend WithEvents Label114 As System.Windows.Forms.Label
    Friend WithEvents Label115 As System.Windows.Forms.Label
    Friend WithEvents Label116 As System.Windows.Forms.Label
    Friend WithEvents Label118 As System.Windows.Forms.Label
    Friend WithEvents Label120 As System.Windows.Forms.Label
    Friend WithEvents LabelCoolLinacFlo As System.Windows.Forms.Label
    Friend WithEvents Label124 As System.Windows.Forms.Label
    Friend WithEvents Label125 As System.Windows.Forms.Label
    Friend WithEvents Label126 As System.Windows.Forms.Label
    Friend WithEvents Label156 As System.Windows.Forms.Label
    Friend WithEvents Label155 As System.Windows.Forms.Label
    Friend WithEvents Label154 As System.Windows.Forms.Label
    Friend WithEvents Label130 As System.Windows.Forms.Label
    Friend WithEvents Label131 As System.Windows.Forms.Label
    Friend WithEvents Label132 As System.Windows.Forms.Label
    Friend WithEvents Label147 As System.Windows.Forms.Label
    Friend WithEvents Label148 As System.Windows.Forms.Label
    Friend WithEvents Label146 As System.Windows.Forms.Label
    Friend WithEvents lblCoolCabTemp As System.Windows.Forms.Label
    Friend WithEvents lblCoolCoolTemp As System.Windows.Forms.Label
    Friend WithEvents Label139 As System.Windows.Forms.Label
    Friend WithEvents lblCoolSF6Press As System.Windows.Forms.Label
    Friend WithEvents lblCoolCirFlow As System.Windows.Forms.Label
    Friend WithEvents Label141 As System.Windows.Forms.Label
    Friend WithEvents lblCoolLinacFlow As System.Windows.Forms.Label
    Friend WithEvents Label143 As System.Windows.Forms.Label
    Friend WithEvents lblCoolMagFlow As System.Windows.Forms.Label
    Friend WithEvents Label66 As System.Windows.Forms.Label
    Friend WithEvents Label97 As System.Windows.Forms.Label
    Friend WithEvents lblCurrPulsesOutOfRange As System.Windows.Forms.Label
    Friend WithEvents ledCurrLowPulseCurr As CustomControls.OvalLed
    Friend WithEvents Label103 As System.Windows.Forms.Label
    Friend WithEvents ledWMagOTActive As CustomControls.OvalLed
    Friend WithEvents ledWMagIfOCActive As CustomControls.OvalLed
    Friend WithEvents Label117 As System.Windows.Forms.Label
    Friend WithEvents Label112 As System.Windows.Forms.Label
    Friend WithEvents Label119 As System.Windows.Forms.Label
    Friend WithEvents ledServiceNormalMode As CustomControls.OvalLed
    Friend WithEvents Label122 As System.Windows.Forms.Label
    Friend WithEvents TabPageOverview As System.Windows.Forms.TabPage
    Friend WithEvents Label213 As System.Windows.Forms.Label
    Friend WithEvents btnReenableAutofill1 As System.Windows.Forms.Button
    Friend WithEvents Label134 As System.Windows.Forms.Label
    Friend WithEvents Label159 As System.Windows.Forms.Label
    Friend WithEvents Label180 As System.Windows.Forms.Label
    Friend WithEvents Meter As CustomControls.meter
    Friend WithEvents btnResetFault As System.Windows.Forms.Button
    Friend WithEvents Label123 As System.Windows.Forms.Label
    Friend WithEvents ledWCpuXrayDisabled As CustomControls.OvalLed
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents btnHVsetCab As System.Windows.Forms.Button
    Friend WithEvents btnAfcCabCtrlVSet As System.Windows.Forms.Button
    Friend WithEvents btnMagCabIset As System.Windows.Forms.Button
    Friend WithEvents btnGdEgsetCab As System.Windows.Forms.Button
    Friend WithEvents btnPulseStartMin As System.Windows.Forms.Button
    Friend WithEvents btnPulseStart1_3 As System.Windows.Forms.Button
    Friend WithEvents btnPulseStart2_3 As System.Windows.Forms.Button
    Friend WithEvents btnAfcDelay As System.Windows.Forms.Button
    Friend WithEvents btnPulseStopMin As System.Windows.Forms.Button
    Friend WithEvents btnPulseStop1_3 As System.Windows.Forms.Button
    Friend WithEvents btnPulseStop2_3 As System.Windows.Forms.Button
    Friend WithEvents btnPulseStopMax As System.Windows.Forms.Button
    Friend WithEvents Label37 As System.Windows.Forms.Label
    Friend WithEvents btnReenableAutofill2 As System.Windows.Forms.Button
    Friend WithEvents btnChangeSettingMode As System.Windows.Forms.Button
    Friend WithEvents lblModeSettings As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents LabelGUIVersionDeploy As System.Windows.Forms.Label
    Friend WithEvents lblAccessLevel As System.Windows.Forms.Label
    Friend WithEvents PanelRadLeft As System.Windows.Forms.Panel
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Label106 As System.Windows.Forms.Label
    Friend WithEvents Label108 As System.Windows.Forms.Label
    Friend WithEvents PanelRadRight As System.Windows.Forms.Panel
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents Label128 As System.Windows.Forms.Label
    Friend WithEvents Label129 As System.Windows.Forms.Label
    Friend WithEvents lblScanMode As System.Windows.Forms.Label
    Friend WithEvents Label283 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label277 As System.Windows.Forms.Label
    Friend WithEvents Label173 As System.Windows.Forms.Label
    Friend WithEvents Label276 As System.Windows.Forms.Label
    Friend WithEvents Label240 As System.Windows.Forms.Label
    Friend WithEvents Label279 As System.Windows.Forms.Label
    Friend WithEvents Label272 As System.Windows.Forms.Label
    Friend WithEvents lblCoolTemp As System.Windows.Forms.Label
    Friend WithEvents lblCabTemp As System.Windows.Forms.Label
    Friend WithEvents lblGdTemp As System.Windows.Forms.Label
    Friend WithEvents lblSF6Pressure As System.Windows.Forms.Label
    Friend WithEvents BlueRect15 As CustomControls.BlueRect
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents lblDoseRateUnit As System.Windows.Forms.Label
    Friend WithEvents lblDoseRate As System.Windows.Forms.Label
    Friend WithEvents lblPulseFreq As System.Windows.Forms.Label
    Friend WithEvents lblDoseCommand As System.Windows.Forms.Label
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents lblBeamDuration As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents lblDoseRateTitle As System.Windows.Forms.Label
    Friend WithEvents BlueRect5 As CustomControls.BlueRect
    Friend WithEvents LabelComputerTime As System.Windows.Forms.Label
    Friend WithEvents LabelECBTime As System.Windows.Forms.Label
    Friend WithEvents BlueRect7 As CustomControls.BlueRect
    Friend WithEvents BlueRect6 As CustomControls.BlueRect
    Friend WithEvents BlueRectMain As CustomControls.BlueRect
    Friend WithEvents BlueRect9 As CustomControls.BlueRect
    Friend WithEvents BlueRectMagnetron As CustomControls.BlueRect
    Friend WithEvents BlueRect11 As CustomControls.BlueRect
    Friend WithEvents BlueRect13 As CustomControls.BlueRect
    Friend WithEvents BlueRect12 As CustomControls.BlueRect
    Friend WithEvents BlueRect14 As CustomControls.BlueRect
    Friend WithEvents btnServiceResetLinacTime As System.Windows.Forms.Button
    Friend WithEvents lblAutofillRemain1 As System.Windows.Forms.Label
    Friend WithEvents lblAutofillRemain2 As System.Windows.Forms.Label
    Friend WithEvents ledHVDriveup As CustomControls.OvalLed
    Friend WithEvents btnAfcManualPosition As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents btnServiceReloadInitialDefaults As System.Windows.Forms.Button
    Friend WithEvents btnServiceRestoreFactoryDefaults As System.Windows.Forms.Button
    Friend WithEvents BlueRect2 As CustomControls.BlueRect
    Friend WithEvents BlueRect1 As CustomControls.BlueRect
    Friend WithEvents lblIonIi2Unit As System.Windows.Forms.Label
    Friend WithEvents lblIonIi2Title As System.Windows.Forms.Label
    Friend WithEvents lblIonIi2 As System.Windows.Forms.Label
    Friend WithEvents btnIPaddress As System.Windows.Forms.Button
    Friend WithEvents btnDispDeveloperPanel As CustomControls.ButtonSelected
    Friend WithEvents btnDispServicePanel As CustomControls.ButtonSelected
    Friend WithEvents TabPageServicePanel As System.Windows.Forms.TabPage
    Friend WithEvents tabPageDeveloper As System.Windows.Forms.TabPage
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents BlueRect3 As CustomControls.BlueRect
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents BlueRect17 As CustomControls.BlueRect
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lblAfcManualPosition As System.Windows.Forms.Label
    Friend WithEvents ledReadyIonpump As CustomControls.OvalLed
    Friend WithEvents ledReadyMagnetHtr As CustomControls.OvalLed
    Friend WithEvents ledReadyAfc As CustomControls.OvalLed
    Friend WithEvents ledReadyMagnetron As CustomControls.OvalLed
    Friend WithEvents ledReadyHV As CustomControls.OvalLed
    Friend WithEvents ledReadyPulseSync As CustomControls.OvalLed
    Friend WithEvents ledReadyCooling As CustomControls.OvalLed
    Friend WithEvents ledReadyGunDriver As CustomControls.OvalLed
    Friend WithEvents ledReadyCpu As CustomControls.OvalLed
    Friend WithEvents btnZeroOnTime As System.Windows.Forms.Button
    Friend WithEvents btnClearDebugData As System.Windows.Forms.Button
    Friend WithEvents btnZeroArcPulseCounters As System.Windows.Forms.Button
    Friend WithEvents lblNoTrigger As System.Windows.Forms.Label
    Friend WithEvents ledPulseTriggerStayedOn As CustomControls.OvalLed
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents panelIonPumpLogger As System.Windows.Forms.Panel
    Friend WithEvents lblIonPumpLogName As System.Windows.Forms.Label
    Friend WithEvents btnIonPumpLog As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtIonPumpLogInterval As System.Windows.Forms.TextBox
    Friend WithEvents PanelArcCounts As System.Windows.Forms.Panel
    Friend WithEvents PanelMagnetronLeds As System.Windows.Forms.Panel
    Friend WithEvents btnMagnetronConditioning As System.Windows.Forms.Button
    Friend WithEvents btnLoadParameters As System.Windows.Forms.Button
    Friend WithEvents btnSaveAllParams As System.Windows.Forms.Button
    Friend WithEvents btnRestoreData As System.Windows.Forms.Button
    Friend WithEvents btnDumpData As System.Windows.Forms.Button
    Friend WithEvents lblShowDumpData As System.Windows.Forms.Label
    Friend WithEvents lblGUIVersionAgile As System.Windows.Forms.Label
End Class
