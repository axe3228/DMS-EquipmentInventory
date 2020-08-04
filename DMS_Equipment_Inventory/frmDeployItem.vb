Public Class frmDeployItem
    Private sLocation As String
    Private idEqStockData As Integer

    Public Property FDILocation As String
        Get
            Return sLocation
        End Get
        Set(value As String)
            sLocation = value
        End Set
    End Property

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub btnSearchEqStockData_Click(sender As Object, e As EventArgs) Handles btnSearchEqStockData.Click
        Dim frm = New frmSearchEquipment(frmSearchEquipment.EMDInventory.SearchStock)
        If Not frm.ShowDialog() = Windows.Forms.DialogResult.OK Then Return
        idEqStockData = frm.FSECLSEqStockData.idEngrEquipmentStockData
        txtEquipment.Text = frm.FSECLSEqStockData.EESDEquipment
        txtBrand.Text = frm.FSECLSEqStockData.EESDBrand
        txtSerial.Text = frm.FSECLSEqStockData.EESDSerial
        txtModel.Text = frm.FSECLSEqStockData.EESDModel
    End Sub

    Private Sub btnDeploy_Click(sender As Object, e As EventArgs) Handles btnDeploy.Click
        If modServerBridge.UpdateStockData(idEqStockData, sLocation) Then
            If isEquipmentExist(idEqStockData, sLocation) Then

                MsgBox(modServerBridge.UpdateDeploymentStatus(idEqStockData, 1, "Deployed", "Equipment has been deployed again"))
            Else

                Dim cls As New cDeployment
                cls.idEngrEquipmentStockData = idEqStockData
                cls.EEDLocation = sLocation
                cls.EESDEquipment = txtEquipment.Text
                cls.EESDBrand = txtBrand.Text
                cls.EESDSerial = txtSerial.Text
                cls.EESDModel = txtModel.Text
                cls.DeploymentDate = dtpDeployedDate.Value

                MsgBox(modServerBridge.POSTDeployment(cls))

            End If
        End If

        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub
End Class