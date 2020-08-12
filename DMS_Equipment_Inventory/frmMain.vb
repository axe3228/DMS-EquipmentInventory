Public Class frmMain
    Private frm As frmManageRepo = Nothing
    Private idStockControl As Integer
    Private idStockData As Integer
    Private idLocation As Integer
    Private controlState As String
    Private deploymentLocation As String
    Private deploymentCount As Integer

    Private Sub tsbClose_Click(sender As Object, e As EventArgs) Handles tsbClose.Click
        Me.Close()
    End Sub

    Private Sub tsbEquipment_Click(sender As Object, e As EventArgs) Handles tsbEquipment.Click
        frm = New frmManageRepo(frmManageRepo.EMDInventory.Item)
        If frm IsNot Nothing Then
            frm.ShowDialog()
        End If
    End Sub

    Private Sub tsbBrand_Click(sender As Object, e As EventArgs) Handles tsbBrand.Click
        frm = New frmManageRepo(frmManageRepo.EMDInventory.Brand)
        If frm IsNot Nothing Then
            frm.ShowDialog()
        End If

        modController.InventoryLoad(lvInventory)
    End Sub

    Private Sub tsbLocation_Click(sender As Object, e As EventArgs) Handles tsbLocation.Click
        frm = New frmManageRepo(frmManageRepo.EMDInventory.Location)
        If frm IsNot Nothing Then
            frm.ShowDialog()
        End If
    End Sub

    Private Sub tcMain_SelectedIndexChanged(sender As Object, e As EventArgs) Handles tcMain.SelectedIndexChanged
        Select Case tcMain.SelectedIndex
            Case 0
                modController.InventoryLoad(lvInventory)
            Case 1
                modController.DeploymentLocationsLoad(lvLocation)
            Case 2
                modController.StockControlLoad(lvEqStockControl)
        End Select
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        modController.InventoryLoad(lvInventory)
    End Sub

#Region "Receiving"
    Private Sub tsbNewDocu_Click(sender As Object, e As EventArgs) Handles tsbNewDocu.Click
        modServerBridge.AutoCloseStockControl() 'Auto Close Data Control Every New Document Created

        modServerBridge.POSTEquipmentStockControl()

        modController.StockControlLoad(lvEqStockControl)
        msReceiving.Visible = False
    End Sub

    Private Sub lvEqStockControl_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvEqStockControl.SelectedIndexChanged
        If lvEqStockControl.SelectedItems.Count < 1 Then Return
        idStockControl = lvEqStockControl.SelectedItems(0).Tag
        lblEqStockControlID.Text = "Document ID  : " & Format(lvEqStockControl.SelectedItems(0).Tag, "0000")
        rtbEqStockControlRemarks.Text = lvEqStockControl.SelectedItems(0).SubItems(2).Text
        controlState = lvEqStockControl.SelectedItems(0).SubItems(3).Text
        Dim _date As DateTime = lvEqStockControl.SelectedItems(0).SubItems(1).Text
        lblRDate.Text = "Date  : " & _date.ToString("MM/dd/yyyy hh:mm tt")

        If controlState = "Close" Then
            msReceiving.Visible = False
        Else
            msReceiving.Visible = True
        End If

        modController.StockDataLoad(lvEqStockData, idStockControl)
    End Sub

    Private Sub tsbReceivingSave_Click(sender As Object, e As EventArgs) Handles tsbReceivingSave.Click
        'If Not showMessageBox("Saving Stock Control. Are you sure?", MessageBoxIcon.Question) = vbYes Then Return
        Dim _class As New cEquipmentStockControl
        Dim _idData As String = "0"

        _class.idEngrEquipmentStockControl = idStockControl
        _class.EESCRemarks = rtbEqStockControlRemarks.Text
        ' _class.TimeStamp = dtpEqStockControlDate.Text & " " & TimeOfDay.ToString("hh:mm:ss tt")

        MsgBox(modServerBridge.UpdateStockControl(_class))
        modController.StockControlLoad(lvEqStockControl)
    End Sub

    Private Sub tsbReceive_Click(sender As Object, e As EventArgs) Handles tsbReceive.Click
        Dim frm As New frmReceive

        frm.EquipmentControlID = idStockControl
        If Not frm.ShowDialog() = Windows.Forms.DialogResult.OK Then Return
        modController.StockDataLoad(lvEqStockData, idStockControl)
    End Sub
    Private Sub tsbCloseDoc_Click(sender As Object, e As EventArgs) Handles tsbCloseDoc.Click
        If idStockControl <> 0 Then
            MsgBox(modServerBridge.CloseStockControl(idStockControl))
            modController.StockControlLoad(lvEqStockControl)
        Else
            Exit Sub
        End If
    End Sub

    Private Sub lvEqStockData_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvEqStockData.SelectedIndexChanged
        If lvEqStockData.SelectedItems.Count < 1 Then Return
    End Sub


    Private Sub lvEqStockData_DoubleClick(sender As Object, e As EventArgs) Handles lvEqStockData.DoubleClick
        If controlState = "Close" Then Return
        Dim _class As New cEquipmentStockData
        _class.idEngrEquipmentStockData = lvEqStockData.SelectedItems(0).Tag
        _class.EESDEquipment = lvEqStockData.SelectedItems(0).SubItems(1).Text
        _class.EESDBrand = lvEqStockData.SelectedItems(0).SubItems(2).Text
        _class.EESDSerial = lvEqStockData.SelectedItems(0).SubItems(3).Text
        _class.EESDModel = lvEqStockData.SelectedItems(0).SubItems(4).Text

        Dim frm As New frmReceive
        frm.frStockData = _class
        If Not frm.ShowDialog() = Windows.Forms.DialogResult.OK Then Return
        modController.StockDataLoad(lvEqStockData, idStockControl)
    End Sub
#End Region

#Region "Deployment"
    Private Sub tsbDeploy_Click(sender As Object, e As EventArgs) Handles tsbDeploy.Click
        Dim frm As New frmDeployItem
        frm.FDILocation = deploymentLocation
        If Not frm.ShowDialog() = Windows.Forms.DialogResult.OK Then Return

        lblEqCount.Text = "Equipment Deployed : " & deploymentCount
        modController.DeployedEquipmentsLoad(lvDeployedEquipments, deploymentLocation)
        modController.DeploymentLocationsLoad(lvLocation)
    End Sub

    Private Sub lvLocation_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvLocation.SelectedIndexChanged
        If lvLocation.SelectedItems.Count < 1 Then Return
        idLocation = lvLocation.SelectedItems(0).Tag
        deploymentLocation = lvLocation.SelectedItems(0).Text
        deploymentCount = lvLocation.SelectedItems(0).SubItems(2).Text

        lblLocation.Text = "Location : " & deploymentLocation
        msDeployment.Visible = True
        'lblEqCount.Text = "Equipment Deployed : " & deploymentCount
        modController.DeployedEquipmentsLoad(lvDeployedEquipments, lvLocation.SelectedItems(0).Text)
    End Sub

    Private Sub tsbReturn_Click(sender As Object, e As EventArgs) Handles tsbReturn.Click
        If modServerBridge.UpdateStockData(idStockData, "Warehouse", "Returned") Then

            MsgBox(modServerBridge.UpdateDeploymentStatus(idStockControl, 0, "Returned", "Equipment has been returned"))

            lblEqCount.Text = "Equipment Deployed : " & deploymentCount
            modController.DeployedEquipmentsLoad(lvDeployedEquipments, deploymentLocation)
            modController.DeploymentLocationsLoad(lvLocation)
        End If
    End Sub

    Private Sub lvDeployedEquipments_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvDeployedEquipments.SelectedIndexChanged
        If lvDeployedEquipments.SelectedItems.Count < 1 Then Return
        idStockControl = lvDeployedEquipments.SelectedItems(0).SubItems(6).Text
        idStockData = lvDeployedEquipments.SelectedItems(0).Tag
    End Sub

    Private Sub tsbDefective_Click(sender As Object, e As EventArgs) Handles tsbDefective.Click
        If modServerBridge.UpdateStockData(idStockData, "Bin", "Defective") Then

            MsgBox(modServerBridge.UpdateDeploymentStatus(idStockControl, 0, "Defective", "Equipment has been pullout"))

            lblEqCount.Text = "Equipment Deployed : " & deploymentCount
            modController.DeployedEquipmentsLoad(lvDeployedEquipments, deploymentLocation)
            modController.DeploymentLocationsLoad(lvLocation)
        End If
    End Sub

    Private Sub lvDeployedEquipments_KeyDown(sender As Object, e As KeyEventArgs) Handles lvDeployedEquipments.KeyDown
        If e.KeyCode = Keys.Delete Then
            If modServerBridge.UpdateStockData(idStockData, "Warehouse", "Returned") Then

                MsgBox(modServerBridge.UpdateDeploymentStatus(idStockControl, 0, "Deleted", "Deployment Details have been remove"))
                modController.DeployedEquipmentsLoad(lvDeployedEquipments, deploymentLocation)
                modController.DeploymentLocationsLoad(lvLocation)
            End If
        End If
    End Sub

#End Region

End Class

