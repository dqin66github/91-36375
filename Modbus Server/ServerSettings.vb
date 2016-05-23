Option Explicit On
Option Strict On

Imports System
Imports System.Net
Imports System.Net.Sockets
Imports System.Text
Imports System.IO


Public Class ServerSettings


    Public EventLogMessages As New Dictionary(Of UInt16, String)

    Public board_to_monitor As Byte




    Private client As TcpClient
    Private server As TcpListener
    Private stream As NetworkStream
    Private xmitBuffer(200) As Byte
    Private recvBuffer(1024) As Byte
    Private connect_status As Integer  ' 0 idle, 1 waiting, 3 connected, 5 waiting for write done
    Private connect_timeout As Integer  ' reset the timeout when receiving incoming packets





    ' modbus function codes
    Private Const READ_FUNCTION = &H3
    Private Const WRITE_FUNCTION = &H10
    Private function_code As Byte
    Private command_index_number As Byte
    Private word_count As UInt16
    Private update_loop_count As Byte
    Private Const MODBUS_COMMAND_REFRESH_TOTAL = 2


    Public Const MAX_BOARD_ADDRESSES = 16
    Public ETMEthernetBoardLoggingData(MAX_BOARD_ADDRESSES) As ETM_CAN_BOARD_DATA
    Public ETMEthernetDebugData As ETM_CAN_DEBUG_DATA

    Public Const MAX_CAL_INDEX = 65536
    Public ETMEthernetCalStructure(MAX_CAL_INDEX + 1) As ETM_ETHERNET_CAL_STRUCTURE


    Public Const MAX_PULSE_SIZE_ROW = 5000
    Public Const MAX_PULSE_SIZE_DATA = 620
    '    Public ETMEthernetPulseData(MAX_PULSE_SIZE_ROW, MAX_PULSE_SIZE_DATA) As Byte
    Public pulse_index As UInt16


    Public Const MAX_EVENT_SIZE_ROW = 5000
    Public Const MAX_EVENT_SIZE_DATA = 512 ' 64 entries
    '   Public ETMEthernetEventData(MAX_EVENT_SIZE_ROW, MAX_EVENT_SIZE_DATA) As Byte
    Public event_index As UInt16
 

    Public QueueCommandToECB As Queue


    Public Sub put_modbus_commands(ByVal index As UInt16, ByVal word2 As UInt16, ByVal word1 As UInt16, ByVal word0 As UInt16)
        Dim command_to_ECB As ETM_ETHERNET_COMMAND_STRUCTURE
        command_to_ECB = New ETM_ETHERNET_COMMAND_STRUCTURE(index, word2, word1, word0)
        QueueCommandToECB.Enqueue(command_to_ECB)
    End Sub

    Public Function get_modbus_status() As Integer
        get_modbus_status = connect_status
    End Function



    Private Sub ServerSettings_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        txtIPAddr.Text = My.Settings.ServerIP

        My.Settings.HighLowEnergyReverse = True
        connect_status = 0
        update_loop_count = 0

        pulse_index = 0
        QueueCommandToECB = New Queue()



        ' init modbus data
        For i = 0 To (MAX_BOARD_ADDRESSES - 1)
            ETMEthernetBoardLoggingData(i) = New ETM_CAN_BOARD_DATA(CByte(i))
        Next
        ETMEthernetDebugData = New ETM_CAN_DEBUG_DATA(0)

        TimerUpdate.Enabled = True

        Call init_server()
        ' load the main screen
        Me.Hide()
#If True Then
        Dim main_screen As frmMain
        main_screen = New frmMain

#Else
        Dim main_screen As frmMainSuper
        main_screen = New frmMainSuper
#End If
        main_screen.ShowDialog()


    End Sub



    Private Sub ServerSettings_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        Dim status As Integer = connect_status
        TimerUpdate.Enabled = False
        My.Settings.ServerIP = txtIPAddr.Text
        connect_status = 0
#If DEMO_MODE = 0 Then

        Try
            Select Case (status)
                Case 1
                    '   server.EndAcceptTcpClient()
                    server.Stop()
                Case 2, 3, 4, 5
                    stream.Close()
                    client.Close()
                    server.Stop()
                Case Else
            End Select
            '  load_save_modbus_data(True)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

#End If
    End Sub







    ' This looks for new messages
    Private Sub DoRecvDoneCallback(ByVal ar As IAsyncResult)
        Dim myStream As NetworkStream = CType(ar.AsyncState, NetworkStream)
        Dim bytecount As Int16, msglength As Int16
        Static last_ref As UShort = 0
        Static trans_num(100) As UShort

        If (connect_status > 0) Then
            Try
                bytecount = CShort(myStream.EndRead(ar))

                Do While (bytecount > 6)
                    connect_timeout = 0
                    ' get msg length
                    msglength = CShort(recvBuffer(4) * 256 + recvBuffer(5))
                    If (bytecount >= (6 + msglength)) Then
                        function_code = recvBuffer(7)
                        command_index_number = recvBuffer(6)
                        If (command_index_number = MODBUS_COMMAND_REFRESH_TOTAL) Then
                            If (update_loop_count < 255) Then
                                update_loop_count = CByte(update_loop_count + 1)
                            Else
                                update_loop_count = 1
                            End If
                        End If
                        word_count = CUShort(recvBuffer(10) * 256 + recvBuffer(11))   ' read data length or number of registers
                        Call modbus_reply()
                        bytecount = CShort(bytecount - (6 + msglength))
                        If (bytecount > 6) Then
                            For i = 0 To (bytecount - 1)
                                recvBuffer(i) = recvBuffer(i + 6 + msglength)  ' shift to next packet
                            Next
                        Else
                            bytecount = 0
                        End If
                    Else
                        bytecount = 0
                    End If
                Loop
            Catch ex As Exception
                MsgBox("DoRecvDoneCallback: " + ex.ToString)
            End Try

        End If

    End Sub


    ' This sends out a reply to a message from the ECB
    ' If the ECB is transmitting data to the GUI, the GUI processes the data and sends out ack
    ' If the ECB is requesting a command list, the GUI sends out the command list
    Public Sub modbus_reply()
        Dim i As UInt16
        Dim msglen As Integer, datalen As Integer
        Dim data(30) As Byte  ' max data length 30
        Dim command_to_ECB As ETM_ETHERNET_COMMAND_STRUCTURE
        Dim pulse_data(MAX_PULSE_SIZE_DATA) As Byte
        Dim event_data(MAX_EVENT_SIZE_DATA) As Byte
        Dim command_id As Byte

        command_id = command_index_number

        If (function_code = WRITE_FUNCTION) Then
            ' The ECB is writing Data to the GUI
            ' Process the data and send ack back to the ECB

            connect_status = 5

            xmitBuffer(0) = recvBuffer(0) '  Transaction number high byte
            xmitBuffer(1) = recvBuffer(1) '  Transaction number low byte
            xmitBuffer(2) = 0 ' Protocol high Byte
            xmitBuffer(3) = 0 ' Protocol low byte
            xmitBuffer(4) = 0 ' Byte length is always 6 for write cmd
            xmitBuffer(5) = 6 ' Byte length is always 6 for write cmd
            xmitBuffer(6) = command_id ' Respond with the same command_id
            xmitBuffer(7) = recvBuffer(7) ' Respond with the same function code
            xmitBuffer(8) = 0
            xmitBuffer(9) = CByte(QueueCommandToECB.Count) '  This tells the ECB how many messages are waiting on the GUI
            xmitBuffer(10) = board_to_monitor ' This tells the ECB what slave board to store debug data for
            xmitBuffer(11) = 0


            If (command_id >= CUShort(MODBUS_COMMANDS.MODBUS_WR_HVLAMBDA) And command_id <= CUShort(MODBUS_COMMANDS.MODBUS_WR_ETHERNET)) Then
                ' DPARKER do we need to check received data
                ETMEthernetBoardLoggingData(command_id).SetData(recvBuffer, CUShort(word_count * 2), 13)
                stream.BeginWrite(xmitBuffer, 0, 12, New AsyncCallback(AddressOf DoXmitDoneCallback), stream)   ' data are valid, then send ack

            ElseIf (command_id = MODBUS_COMMANDS.MODBUS_WR_DEBUG_DATA) Then

                ETMEthernetDebugData.SetData(recvBuffer, CUShort(word_count * 2), 13)
                stream.BeginWrite(xmitBuffer, 0, 12, New AsyncCallback(AddressOf DoXmitDoneCallback), stream)   ' data are valid, then send ack
            ElseIf (command_id = MODBUS_COMMANDS.MODBUS_WR_EVENTS) Then

                For i = 0 To CUShort((word_count * 2 - 1))
                    '  ETMEthernetEventData(event_index, i) = recvBuffer(13 + i) ' for debug only
                    If (i < MAX_EVENT_SIZE_DATA) Then event_data(i) = recvBuffer(13 + i)
                Next
                event_index = CUShort(event_index + 1)
                If (event_index >= MAX_EVENT_SIZE_ROW) Then event_index = 0
                Call save_event_data(event_data, CUShort(word_count * 2))
                stream.BeginWrite(xmitBuffer, 0, 12, New AsyncCallback(AddressOf DoXmitDoneCallback), stream)   ' data are valid, then send ack

            ElseIf (command_id = MODBUS_COMMANDS.MODBUS_WR_ONE_CAL_ENTRY) Then
                If (word_count >= 3) Then
                    i = CUShort(recvBuffer(13) * 256 + recvBuffer(14))
                    ETMEthernetCalStructure(i).scale = CUShort(recvBuffer(15) * 256 + recvBuffer(16))
                    ETMEthernetCalStructure(i).offset = CUShort(recvBuffer(17) * 256 + recvBuffer(18))
                    stream.BeginWrite(xmitBuffer, 0, 12, New AsyncCallback(AddressOf DoXmitDoneCallback), stream)   ' data are valid, then send ack
                End If

            ElseIf (command_id = MODBUS_COMMANDS.MODBUS_WR_PULSE_LOG) Then
                For i = 0 To CUShort((word_count * 2 - 1))
                    '    ETMEthernetPulseData(pulse_index, i) = recvBuffer(13 + i)  ' for debug only
                    If (i < MAX_PULSE_SIZE_DATA) Then pulse_data(i) = recvBuffer(13 + i)
                Next
                pulse_index = CUShort(pulse_index + 1)
                If (pulse_index >= MAX_PULSE_SIZE_ROW) Then pulse_index = 0
                Call save_pulse_data(pulse_data)
                stream.BeginWrite(xmitBuffer, 0, 12, New AsyncCallback(AddressOf DoXmitDoneCallback), stream)   ' data are valid, then send ack
            End If


        ElseIf (function_code = READ_FUNCTION) Then
            ' The ECB is Requesting Commands from the GUI
            ' Send the requested list of commands to the ECB

            connect_status = 5

            datalen = word_count * 2
            msglen = datalen + 3


            xmitBuffer(0) = recvBuffer(0) '  Transaction number high byte
            xmitBuffer(1) = recvBuffer(1) '  Transaction number low byte
            xmitBuffer(2) = 0 ' Protocol high Byte
            xmitBuffer(3) = 0 ' Protocol low byte
            xmitBuffer(4) = CByte(Math.Truncate(msglen / 256))
            xmitBuffer(5) = CByte(msglen Mod 256)
            xmitBuffer(6) = command_id ' Respond with the same command_id
            xmitBuffer(7) = recvBuffer(7) ' Respond with the same function code
            xmitBuffer(8) = CByte(datalen Mod 256)

            i = 0
            Do While (word_count >= 4 And QueueCommandToECB.Count > 0)
                ' Add each to the xmitBuffer
                command_to_ECB = CType(QueueCommandToECB.Dequeue, ETM_ETHERNET_COMMAND_STRUCTURE)
                xmitBuffer(9 + i * 8) = CByte(Math.Truncate(command_to_ECB.command_index / 256))
                xmitBuffer(10 + i * 8) = CByte(command_to_ECB.command_index Mod 256)
                xmitBuffer(11 + i * 8) = CByte(Math.Truncate(command_to_ECB.data(2) / 256))
                xmitBuffer(12 + i * 8) = CByte(command_to_ECB.data(2) Mod 256)
                xmitBuffer(13 + i * 8) = CByte(Math.Truncate(command_to_ECB.data(1) / 256))
                xmitBuffer(14 + i * 8) = CByte(command_to_ECB.data(1) Mod 256)
                xmitBuffer(15 + i * 8) = CByte(Math.Truncate(command_to_ECB.data(0) / 256))
                xmitBuffer(16 + i * 8) = CByte(command_to_ECB.data(0) Mod 256)

                word_count = CUShort(word_count - 4)
                i = CUShort(i + 1)
            Loop


            stream.BeginWrite(xmitBuffer, 0, (msglen + 6), New AsyncCallback(AddressOf DoXmitDoneCallback), stream)           '(xmitBuffer, 0, 12)
        End If
    End Sub


    Public Sub init_server()
#If DEMO_MODE = 0 Then

        Try
            Application.DoEvents()
            server = New TcpListener(IPAddress.Parse(txtIPAddr.Text), 502)
            server.Start()
            server.BeginAcceptTcpClient(New AsyncCallback(AddressOf DoAcceptTcpClientCallback), server)
            connect_status = 1
            connect_timeout = 0
            update_loop_count = 0
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
#Else
        connect_status = 1
        connect_timeout = 0
        update_loop_count = 0


#End If
    End Sub



    Private Sub DoAcceptTcpClientCallback(ByVal ar As IAsyncResult)
        ' Get the listener that handles the client request.
        Dim listener As TcpListener = CType(ar.AsyncState, TcpListener)
        ' End the operation 
        If (connect_status > 0) Then
            Try
                client = listener.EndAcceptTcpClient(ar)
                stream = client.GetStream()
                stream.BeginRead(recvBuffer, 0, recvBuffer.Length, New AsyncCallback(AddressOf DoRecvDoneCallback), stream)
                connect_status = 3
                connect_timeout = 0
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub


    Private Sub DoXmitDoneCallback(ByVal ar As IAsyncResult)
        Dim myStream As NetworkStream = CType(ar.AsyncState, NetworkStream)
        If (connect_status > 3) Then
            myStream.EndWrite(ar)
            connect_status = 3
            stream.BeginRead(recvBuffer, 0, recvBuffer.Length, New AsyncCallback(AddressOf DoRecvDoneCallback), stream)
        End If
    End Sub

    Public Function isValidIPaddress(ByVal addr As String) As Boolean
        Dim ret As Boolean = True

        Try
            IPAddress.Parse(addr)
        Catch ex As Exception
            ret = False
        End Try

        isValidIPaddress = ret
    End Function
    Public Sub changeIPaddress(ByVal address As String)
        Try
            txtIPAddr.Text = address
            update_loop_count = 0
            connect_status = 0  ' closing the connection
#If DEMO_MODE = 0 Then
            stream.Close()
            client.Close()
            server.Stop()
#End If
            init_server()
  
        Catch ex As Exception

        End Try
    End Sub

    Public Sub btnConnect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConnect.Click
        update_loop_count = 0
        connect_status = 0  ' closing the connection
        stream.Close()
        client.Close()
        server.Stop()
        init_server()
    End Sub




    Private Sub TimerUpdate_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimerUpdate.Tick
        Dim tmpstr As String
        Select Case connect_status
            Case 0
                lblConnectStatus.Text = "Idle"
            Case 1
                lblConnectStatus.Text = "Linac Disconnected"
            Case 2
                lblConnectStatus.Text = "Restart connection..."
                init_server()
            Case Else
                '   lblConnectStatus.Text = "Connected, " & "Loop Count:" & update_loop_count & "   RepeatCmd Index:" & trans_index
                tmpstr = "Linac Connected "
                If (update_loop_count Mod 2) > 0 Then
                    tmpstr = tmpstr & "."
                Else
                    tmpstr = tmpstr & " "
                End If


                lblConnectStatus.Text = tmpstr
                connect_timeout = connect_timeout + 1
                If (connect_timeout = 5) Then
                    update_loop_count = 0
                    connect_status = 0  ' closing the connection
                    stream.Close()
                    client.Close()
                    server.Stop()
                    init_server()
                End If

        End Select

    End Sub






    ' --------------------------------- Logging Functions ----------------------------------- '



    Public event_log_enabled As Boolean
    Public event_log_file_name As String
    Public event_log_file_path As String
    Public event_log_file As System.IO.StreamWriter

    Public Sub OpenEventLogFile()
        event_log_file_name = "P1395_Event_log.csv"
        event_log_file_path = System.IO.Path.Combine(My.Computer.FileSystem.SpecialDirectories.MyDocuments, event_log_file_name)
        event_log_file = My.Computer.FileSystem.OpenTextFileWriter(event_log_file_path, True)

        'event_log_file.Write("Event Number, ")
        'event_log_file.Write("Event Time, ")
        'event_log_file.Write("Event ID")
        'event_log_file.WriteLine("")
    End Sub


    Public Sub CloseEventLogFile()
        event_log_file.Close()
    End Sub

    Private Sub save_event_data(ByRef bytes As Byte(), ByVal length As UInt16)
        Dim time As UInt32
        Dim event_id As UInt16
        Dim event_number As UInt16
        Dim event_count As Integer
        Dim head As Integer
        Dim time_log As String
        Dim year As Integer
        Dim month As Integer
        Dim day As Integer
        Dim hour As Integer
        Dim minute As Integer
        Dim second As Integer
        Dim Log_Message As String = ""

        If event_log_enabled Then
            If (length > MAX_EVENT_SIZE_DATA) Then length = MAX_EVENT_SIZE_DATA
            event_count = CInt(length / 8)  ' one event is 8 bytes
            If (event_count < 1) Then Exit Sub
            OpenEventLogFile()
            For index = 0 To (event_count - 1)
                head = index * 8
                event_number = CUShort(bytes(head + 0)) << 8
                event_number += CUShort(bytes(head + 1))
                time = CUInt(bytes(head + 2)) << 24
                time += CUInt(bytes(head + 3)) << 16
                time += CUInt(bytes(head + 4)) << 8
                time += CUInt(bytes(head + 5))

                year = CInt(Math.Truncate(time / 31622400))

                time = CUInt(time Mod 31622400)
                month = CInt(Math.Truncate(time / 2678400))

                time = CUInt(time Mod 2678400)
                day = CInt(Math.Truncate(time / 86400))

                time = CUInt(time Mod 86400)
                hour = CInt(Math.Truncate(time / 3600))

                time = CUInt(time Mod 3600)
                minute = CInt(Math.Truncate(time / 60))

                second = CInt(time Mod 60)
                time_log = "20" & Format(year, "00") & "/" & Format(month, "00") & "/" & Format(day, "00") & " " & Format(hour, "00") & ":" & Format(minute, "00") & ":" & Format(second, "00")
                event_id = CUShort(bytes(head + 6)) << 8
                event_id += CUShort(bytes(head + 7))
                If EventLogMessages.TryGetValue(event_id, Log_Message) Then
                    event_log_file.WriteLine(event_number & "," & time_log & "," & Log_Message.Trim())
                Else
                    event_log_file.WriteLine(event_number & "," & time_log & "," & "Unknow ID = 0x" & event_id.ToString("X4"))
                End If

            Next
            CloseEventLogFile()
        End If

    End Sub





    Public pulse_log_enabled As Boolean
    Public pulse_log_file_name As String
    Public pulse_log_file_path As String
    Public pulse_log_file As System.IO.StreamWriter

    Public Sub OpenPulseLogFile()
        pulse_log_file_name = "Pulse_log_" & DateTime.Now.ToString("yyyy_MM_dd_HH_mm") & ".csv"
#If True Then
        pulse_log_file_path = System.IO.Path.Combine(My.Computer.FileSystem.SpecialDirectories.MyDocuments, pulse_log_file_name)
#Else
        pulse_log_file_path = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location)
        pulse_log_file_path = My.Computer.FileSystem.GetParentPath(pulse_log_file_path)
        pulse_log_file_path = System.IO.Path.Combine(pulse_log_file_path, pulse_log_file_name)
#End If
        pulse_log_file = My.Computer.FileSystem.OpenTextFileWriter(pulse_log_file_path, True)
        pulse_log_enabled = True

        pulse_log_file.Write("Pulse Count, ")
        pulse_log_file.Write("Status Bits, ")
        pulse_log_file.Write("Pulse Seconds, ")
        pulse_log_file.Write("Pulse Milliseconds, ")
        pulse_log_file.Write("Lambda Vmon, ")
        pulse_log_file.Write("Lambda Vmon Pre-Pulse, ")
        pulse_log_file.Write("Lambda Vprog Pre-Pulse, ")
        pulse_log_file.Write("AFC Current Position, ")
        pulse_log_file.Write("AFC Target Position, ")
        pulse_log_file.Write("AFC Readback A, ")
        pulse_log_file.Write("AFC Readback B, ")
        pulse_log_file.Write("AFC Readback Error Filtered, ")
        pulse_log_file.Write("Ion Pump High Target Current, ")
        pulse_log_file.Write("Ion Pump Low Target Current, ")
        pulse_log_file.Write("Magnetron Current Internal ADC, ")
        pulse_log_file.Write("Magnetron Current External ADC, ")
        pulse_log_file.Write("Pulse Sync Trigger Width, ")
        pulse_log_file.Write("Pulse Sync Trigger Width Filtered, ")
        pulse_log_file.Write("Pulse Grid Start, ")
        pulse_log_file.Write("Pulse Grid Stop, ")
        pulse_log_file.Write("Pulse PRF (.1Hz), ")
        pulse_log_file.Write("ECB Message Count")
        pulse_log_file.WriteLine("")
    End Sub


    Public Sub ClosePulseLogFile()
        If pulse_log_enabled Then
            pulse_log_file.Close()
        End If
        pulse_log_enabled = False

    End Sub

    Private Sub save_pulse_data(ByRef bytes As Byte())
        Static file_index As UInt16 = 0
        Static file_opened As Boolean = False
        Dim data_word As Integer
        Dim mem_location As Integer

        If pulse_log_enabled Then
            For data_row = 0 To 15
                For data_column = 0 To 15
                    mem_location = data_row * 38 + data_column * 2 + 2
                    data_word = bytes(mem_location + 1) * 256 + bytes(mem_location)
                    If data_column = 11 Then
                        If (data_word > &H8000) Then
                            data_word = -(data_word - &H8000)
                        End If
                    End If
                    pulse_log_file.Write(data_word & ",")
                Next

                For data_column = 16 To 17
                    mem_location = data_row * 38 + data_column * 2 + 2
                    data_word = bytes(mem_location)
                    pulse_log_file.Write(data_word & ",")
                    data_word = bytes(mem_location + 1)
                    pulse_log_file.Write(data_word & ",")
                Next

                For data_column = 18 To 18
                    mem_location = data_row * 38 + data_column * 2 + 2
                    data_word = bytes(mem_location + 1) * 256 + bytes(mem_location)
                    pulse_log_file.Write(data_word & ",")
                Next

                data_word = bytes(0) * 256 + bytes(1)
                pulse_log_file.Write(data_word)
                pulse_log_file.WriteLine("")
            Next
            'pulse_log_file.WriteLine("")
            'pulse_log_file.WriteLine("")

        End If

    End Sub












End Class
