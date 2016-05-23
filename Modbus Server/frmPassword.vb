Public Class frmPassword
    Public access_level As Byte  ' 0 normal, 1 service, 2 developer
    Private Sub btnOK_Click(sender As System.Object, e As System.EventArgs) Handles btnOK.Click
         If (txtPassword.Text = "452873") Then
            ' admin level
            access_level = 2
            '  ServerSettings.setModbusData(3, 0, (452873 Mod 65536)) ' pw entry
            '  ServerSettings.setModbusData(3, 1, (452873 \ 65536))
        ElseIf (txtPassword.Text = "06549") Then
            ' service level
            access_level = 1
            ' ServerSettings.setModbusData(3, 0, (452873 Mod 65536)) ' pw entry
            ' ServerSettings.setModbusData(3, 1, (452873 \ 65536))
        Else
            access_level = 0
            ' ServerSettings.setModbusData(3, 0, 1) ' pw entry
            ' ServerSettings.setModbusData(3, 1, 0)
        End If
 
        txtPassword.Text = "12345678" ' dummy
        Me.Hide()
    End Sub

    Private Sub btnCancel_Click(sender As System.Object, e As System.EventArgs) Handles btnCancel.Click
        Me.Hide()

    End Sub

 

    Private Sub frmPassword_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        access_level = 0
        txtPassword.Text = "12345678" ' dummy
        Me.AcceptButton = btnOK
    End Sub
End Class