Enum MODBUS_COMMANDS
    MODBUS_WR_HVLAMBDA = 1
    MODBUS_WR_ION_PUMP
    MODBUS_WR_AFC
    MODBUS_WR_COOLING
    MODBUS_WR_HTR_MAGNET
    MODBUS_WR_GUN_DRIVER
    MODBUS_WR_MAGNETRON_CURRENT
    MODBUS_WR_PULSE_SYNC
    MODBUS_WR_ETHERNET
    MODBUS_WR_DEBUG_DATA
    MODBUS_WR_EVENTS

    MODBUS_WR_ONE_CAL_ENTRY
    MODBUS_WR_PULSE_LOG
    MODBUS_RD_COMMAND_DETAIL

End Enum

Enum SET_CMDS
	SET_GUN_DRIVER_CATHODE_VOLTAGE = 0
 	SET_GUN_DRIVER_HEATER_VOLTAGE
 	SET_GUN_DRIVER_HIGH_ENERGY_PULSE_TOP_VOLTAGE
 	SET_GUN_DRIVER_LOW_ENERGY_PULSE_TOP_VOLTAGE
 
  	SET_PULSE_SYNC_GRID_PULSE_DELAY_HIGH_ENERGY_A_B
 	SET_PULSE_SYNC_GRID_PULSE_DELAY_LOW_ENERGY_A_B
 	SET_PULSE_SYNC_GRID_PULSE_DELAY_HIGH_ENERGY_C_D
 	SET_PULSE_SYNC_GRID_PULSE_DELAY_LOW_ENERGY_C_D
 	SET_PULSE_SYNC_GRID_PULSE_WIDTH_HIGH_ENERGY_A_B
 	SET_PULSE_SYNC_GRID_PULSE_WIDTH_LOW_ENERGY_A_B
 	SET_PULSE_SYNC_GRID_PULSE_WIDTH_HIGH_ENERGY_C_D
 	SET_PULSE_SYNC_GRID_PULSE_WIDTH_LOW_ENERGY_C_D
 	SET_PULSE_SYNC_RF_TRIGGER_AND_THYRATRON_PULSE_DELAY_HIGH_ENERGY
 	SET_PULSE_SYNC_RF_TRIGGER_AND_THYRATRON_PULSE_DELAY_LOW_ENERGY
 	SET_PULSE_SYNC_AFC_AND_SPARE_PULSE_DELAY_HIGH_ENERGY
 	SET_PULSE_SYNC_AFC_AND_SPARE_PULSE_DELAY_LOW_ENERGY
 
  	SET_HIGH_ENERGY_SET_POINT
 	SET_LOW_ENERGY_SET_POINT

 	SET_HOME_POSITION
 	SET_AFC_AFT_CONTROL_VOLTAGE_HIGH_ENERGY
 	SET_AFC_AFT_CONTROL_VOLTAGE_LOW_ENERGY
    SET_CMD_AFC_MANUAL_TARGET_POSITION

  	SET_ELECTROMAGNET_CURRENT_HIGH_ENERGY
 	SET_ELECTROMAGNET_CURRENT_LOW_ENERGY
    SET_HEATER_CURRENT_AT_STANDBY

    SET_CMD_AFC_SELECT_MANUAL_MODE   ' put these two commands at the end to process them separately
    SET_CMD_AFC_SELECT_AFC_MODE

    LENGTH
End Enum

' global constants, multipliers for system timers, directories to save log.
Public Class Constants
    Public Const YEAR_MULT = 35942400
    Public Const MONTH_MULT = 2764800
    Public Const DAY_MULT = 86400
    Public Const HOUR_MULT = 3600
    Public Const MIN_MULT = 60

    Public Const DIR_LOG = "2.5MeV Linac"  ' location for log files
    Public Const DIR_EVENT = "Event Log"
    Public Const DIR_PULSE = "Pulse Log"
    Public Const DIR_IONPUMP = "Ion Pump Log"
    Public Const DIR_PARAM = "Param Set Log"
    Public Const DIR_DATA_DUMP = "Data Dump Log"

End Class

<Serializable()> Public Class ETM_CAN_BOARD_DATA
    Public data_identification As Byte         ' This is a unique identifier for each data set

    ' Status Register
    Public control_notice_bits As UInt16
    Public fault_bits As UInt16
    Public logged_bits As UInt16
    Public not_logged_bits As UInt16

    'Log Data
    Public log_data(24) As UInt16

    ' Configuration 0
    Public agile_number As UInt32
    Public agile_dash As UInt16
    Public agile_rev_ascii As UInt16

    ' Configuarion 1
    Public serial_number As UInt16
    Public firmware_agile_rev As UInt16
    Public firmware_branch As UInt16
    Public firmware_branch_rev As UInt16

    'ECB Local Data 0
    Public ecb_local_data(16) As UInt16

    Sub New(ByVal id As Byte)
        data_identification = id
    End Sub

    Public Sub SetData(ByRef data As Byte(), ByVal length As UInt16, ByVal offset As Byte)
        If (length < 104) Then Exit Sub

        ' Status Register
        control_notice_bits = (CUShort(data(offset + 1)) << 8) + CUShort(data(offset))
        fault_bits = (CUShort(data(offset + 3)) << 8) + CUShort(data(offset + 2))
        logged_bits = (CUShort(data(offset + 5)) << 8) + CUShort(data(offset + 4))
        not_logged_bits = (CUShort(data(offset + 7)) << 8) + CUShort(data(offset + 6))

        'Log Data
        For i = 0 To (23)
            log_data(i) = (CUShort(data(offset + i * 2 + 1 + 8)) << 8) + CUShort(data(offset + i * 2 + 8))
        Next

        ' Configuration 0
        agile_rev_ascii = (CUShort(data(offset + 57)) << 8) + CUShort(data(offset + 56))
        agile_dash = (CUShort(data(offset + 59)) << 8) + CUShort(data(offset + 58))
        agile_number = (CUShort(data(offset + 63)) << 24) + (CUShort(data(offset + 62)) << 16) + (CUShort(data(offset + 61)) << 8) + CUShort(data(offset + 60))

        ' Configuration 1
        firmware_branch_rev = (CUShort(data(offset + 65)) << 8) + CUShort(data(offset + 64))
        firmware_branch = (CUShort(data(offset + 67)) << 8) + CUShort(data(offset + 66))
        firmware_agile_rev = (CUShort(data(offset + 69)) << 8) + CUShort(data(offset + 68))
        serial_number = (CUShort(data(offset + 71)) << 8) + CUShort(data(offset + 70))

        'local Data
        For i = 0 To (16)
            ecb_local_data(i) = (CUShort(data(offset + i * 2 + 1 + 72)) << 8) + CUShort(data(offset + i * 2 + 72))
        Next
    End Sub

End Class


<Serializable()> Public Class ETM_CAN_DEBUG_DATA
    Public data_identification As Byte         ' This is a unique identifier for each data set

    Public debug_0 As UInt16
    Public debug_1 As UInt16
    Public debug_2 As UInt16
    Public debug_3 As UInt16

    Public debug_4 As UInt16
    Public debug_5 As UInt16
    Public debug_6 As UInt16
    Public debug_7 As UInt16

    Public debug_8 As UInt16
    Public debug_9 As UInt16
    Public debug_A As UInt16
    Public debug_B As UInt16

    Public debug_C As UInt16
    Public debug_D As UInt16
    Public debug_E As UInt16
    Public debug_F As UInt16


    ' Can data log - 0x20
    Public can_tx_0 As UInt16            ' count of tx_0 transmits
    Public can_tx_1 As UInt16            ' count of tx_1 transmits
    Public can_tx_2 As UInt16            ' count of tx_2 transmits
    Public CXEC_reg_max As UInt16        ' MAX instead of instantaneous value of CXEC

    ' Can data log - 0x21
    Public can_rx_0_filt_0 As UInt16     ' count of messages received by this filter
    Public can_rx_0_filt_1 As UInt16     ' count of messages received by this filter
    Public can_rx_1_filt_2 As UInt16     ' count of messages received by this filter
    Public CXINTF_max As UInt16          ' logical or of the CXINTF register every time the can ISR is entered

    ' Can data log - 0x22
    Public can_unknown_msg_id As UInt16  ' NOT POSSIBLE SLAVE' count of the number of unknown message ids
    Public can_invalid_index As UInt16   ' count of the number of invalid message index
    Public can_address_error As UInt16   ' NOT POSSIBLE SLAVE ' count of the number of received messages not addressed to this board
    Public can_error_flag As UInt16      ' counts the number of CAN error flags interrupts

    ' Can data log - 0x23
    Public can_tx_buf_overflow As UInt16 ' overwrite count on etm_can_tx_message_buffer 
    Public can_rx_buf_overflow As UInt16 ' overwrite count on etm_can_rx_message_buffer
    Public can_rx_log_buf_overflow As UInt16 ' MASTER ONLY - overwrite count on the logging data buffer overflow count
    Public can_timeout As UInt16         ' count of the number of can timeouts

    ' Board Debug Data - 0x24
    Public reset_count As UInt16     ' This counts the number of processor resets since cleared by the user
    Public RCON_value As UInt16      ' The current value of RCON
    Public reserved_1 As UInt16
    Public reserved_0 As UInt16

    ' Board Debug Data - 0x25
    Public i2c_bus_error_count As UInt16
    Public spi_bus_error_count As UInt16
    Public scale_error_count As UInt16
    Public self_test_results As UInt16


    Sub New(ByVal id As Byte)
        data_identification = id
    End Sub

    Public Sub SetData(ByRef data As Byte(), ByVal length As UInt16, ByVal offset As Byte)
        Dim i As Byte
        'If (length < 48) Then Exit Sub

        i = offset
        debug_0 = (CUShort(data(i + 1)) << 8) + CUShort(data(i))
        debug_1 = (CUShort(data(i + 3)) << 8) + CUShort(data(i + 2))
        debug_2 = (CUShort(data(i + 5)) << 8) + CUShort(data(i + 4))
        debug_3 = (CUShort(data(i + 7)) << 8) + CUShort(data(i + 6))

        i = offset + 8
        debug_4 = (CUShort(data(i + 1)) << 8) + CUShort(data(i))
        debug_5 = (CUShort(data(i + 3)) << 8) + CUShort(data(i + 2))
        debug_6 = (CUShort(data(i + 5)) << 8) + CUShort(data(i + 4))
        debug_7 = (CUShort(data(i + 7)) << 8) + CUShort(data(i + 6))

        i = offset + 16
        debug_8 = (CUShort(data(i + 1)) << 8) + CUShort(data(i))
        debug_9 = (CUShort(data(i + 3)) << 8) + CUShort(data(i + 2))
        debug_A = (CUShort(data(i + 5)) << 8) + CUShort(data(i + 4))
        debug_B = (CUShort(data(i + 7)) << 8) + CUShort(data(i + 6))

        i = offset + 24
        debug_C = (CUShort(data(i + 1)) << 8) + CUShort(data(i))
        debug_D = (CUShort(data(i + 3)) << 8) + CUShort(data(i + 2))
        debug_E = (CUShort(data(i + 5)) << 8) + CUShort(data(i + 4))
        debug_F = (CUShort(data(i + 7)) << 8) + CUShort(data(i + 6))

        i = offset + 32
        can_tx_0 = (CUShort(data(i + 1)) << 8) + CUShort(data(i))
        can_tx_1 = (CUShort(data(i + 3)) << 8) + CUShort(data(i + 2))
        can_tx_2 = (CUShort(data(i + 5)) << 8) + CUShort(data(i + 4))
        CXEC_reg_max = (CUShort(data(i + 7)) << 8) + CUShort(data(i + 6))

        i = offset + 40
        can_rx_0_filt_0 = (CUShort(data(i + 1)) << 8) + CUShort(data(i))
        can_rx_0_filt_1 = (CUShort(data(i + 3)) << 8) + CUShort(data(i + 2))
        can_rx_1_filt_2 = (CUShort(data(i + 5)) << 8) + CUShort(data(i + 4))
        CXINTF_max = (CUShort(data(i + 7)) << 8) + CUShort(data(i + 6))

        i = offset + 48
        can_unknown_msg_id = (CUShort(data(i + 1)) << 8) + CUShort(data(i))
        can_invalid_index = (CUShort(data(i + 3)) << 8) + CUShort(data(i + 2))
        can_address_error = (CUShort(data(i + 5)) << 8) + CUShort(data(i + 4))
        can_error_flag = (CUShort(data(i + 7)) << 8) + CUShort(data(i + 6))

        i = offset + 56
        can_tx_buf_overflow = (CUShort(data(i + 1)) << 8) + CUShort(data(i))
        can_rx_buf_overflow = (CUShort(data(i + 3)) << 8) + CUShort(data(i + 2))
        can_rx_log_buf_overflow = (CUShort(data(i + 5)) << 8) + CUShort(data(i + 4))
        can_timeout = (CUShort(data(i + 7)) << 8) + CUShort(data(i + 6))

        i = offset + 64
        reset_count = (CUShort(data(i + 1)) << 8) + CUShort(data(i))
        RCON_value = (CUShort(data(i + 3)) << 8) + CUShort(data(i + 2))
        reserved_1 = (CUShort(data(i + 5)) << 8) + CUShort(data(i + 4))
        reserved_0 = (CUShort(data(i + 7)) << 8) + CUShort(data(i + 6))

        i = offset + 72
        i2c_bus_error_count = (CUShort(data(i + 1)) << 8) + CUShort(data(i))
        spi_bus_error_count = (CUShort(data(i + 3)) << 8) + CUShort(data(i + 2))
        scale_error_count = (CUShort(data(i + 5)) << 8) + CUShort(data(i + 4))
        self_test_results = (CUShort(data(i + 7)) << 8) + CUShort(data(i + 6))

    End Sub

End Class


Public Structure ETM_ETHERNET_CAL_STRUCTURE
    Public scale As UInt16
    Public offset As UInt16
    ' constructor

End Structure
Public Class ETM_ETHERNET_COMMAND_STRUCTURE
    Public command_index As UInt16
    Public data(3) As UInt16

    ' constructor
    Sub New(ByVal index As UInt16, ByVal word2 As UInt16, ByVal word1 As UInt16, ByVal word0 As UInt16)
        command_index = index
        data(0) = word0
        data(1) = word1
        data(2) = word2
    End Sub
End Class
Public Class SET_COMMAND_STRUCTURE
    Public command_index As UInt16
    Public max As UInt16
    Public min As UInt16

    ' constructor
    Sub New(ByVal index As UInt16, ByVal max_val As UInt16, ByVal min_val As UInt16)
        command_index = index
        max = max_val
        min = min_val

    End Sub
End Class

