Public Class frmMain
    Private frm As frmManageRepo = Nothing
    Private idStockControl As Integer
    Private idLocation As Integer

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
        POSTEquipmentStockControl()

        modController.StockControlLoad(lvEqStockControl)
        msReceiving.Visible = False
    End Sub

    Private Sub lvEqStockControl_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvEqStockControl.SelectedIndexChanged
        If lvEqStockControl.SelectedItems.Count < 1 Then Return
        idStockControl = lvEqStockControl.SelectedItems(0).Tag
        lblEqStockControlID.Text = "Document ID  : " & lvEqStockControl.SelectedItems(0).Text
        dtpEqStockControlDate.Value = lvEqStockControl.SelectedItems(0).SubItems(1).Text
        rtbEqStockControlRemarks.Text = lvEqStockControl.SelectedItems(0).SubItems(2).Text

        msReceiving.Visible = True
        modController.StockDataLoad(lvEqStockData, idStockControl)
    End Sub

    Private Sub tsbReceivingSave_Click(sender As Object, e As EventArgs) Handles tsbReceivingSave.Click
        'If Not showMessageBox("Saving Stock Control. Are you sure?", MessageBoxIcon.Question) = vbYes Then Return
        Dim _class As New cEquipmentStockControl
        Dim _idData As String = "0"

        _class.idEngrEquipmentStockControl = idStockControl
        _class.EESCRemarks = rtbEqStockControlRemarks.Text
        _class.TimeStamp = dtpEqStockControlDate.Text & " " & TimeOfDay.ToString("hh:mm:ss tt")

        MsgBox(modServerBridge.UpdateStockControl(_class))
        modController.StockControlLoad(lvEqStockControl)
    End Sub

    Private Sub tsbReceive_Click(sender As Object, e As EventArgs) Handles tsbReceive.Click
        Dim frm As New frmReceive

        frm.EquipmentControlID = idStockControl
        If Not frm.ShowDialog() = Windows.Forms.DialogResult.OK Then Return
        modController.StockDataLoad(lvEqStockData, idStockControl)
    End Sub

#End Region

#Region "Deployment"
    Private Sub tsbDeploy_Click(sender As Object, e As EventArgs) Handles tsbDeploy.Click
        Dim frm As New frmDeployItem
        frm.FDILocation = lvLocation.SelectedItems(0).Text
        If Not frm.ShowDialog() = Windows.Forms.DialogResult.OK Then Return

        modController.DeployedEquipmentsLoad(lvDeployedEquipments, lvLocation.SelectedItems(0).Text)
    End Sub

    Private Sub lvLocation_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvLocation.SelectedIndexChanged
        If lvLocation.SelectedItems.Count < 1 Then Return
        idLocation = lvLocation.SelectedItems(0).Tag

        lblLocation.Text = "Location : " & lvLocation.SelectedItems(0).Text
        modController.DeployedEquipmentsLoad(lvDeployedEquipments, lvLocation.SelectedItems(0).Text)
    End Sub

    Private Sub tsbReturn_Click(sender As Object, e As EventArgs) Handles tsbReturn.Click
        If modServerBridge.UpdateStockData(lvDeployedEquipments.SelectedItems(0).Tag, "Warehouse", "Returned") Then

            MsgBox(modServerBridge.UpdateDeploymentStatus(lvDeployedEquipments.SelectedItems(0).SubItems(6).Text, 0, "Returned", "Equipment has been returned"))
            modController.DeployedEquipmentsLoad(lvDeployedEquipments, lvLocation.SelectedItems(0).Text)
        End If
    End Sub

    Private Sub lvDeployedEquipments_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvDeployedEquipments.SelectedIndexChanged
        If lvDeployedEquipments.SelectedItems.Count < 1 Then Return

    End Sub

    Private Sub tsbDefective_Click(sender As Object, e As EventArgs) Handles tsbDefective.Click
        If modServerBridge.UpdateStockData(lvDeployedEquipments.SelectedItems(0).Tag, "Bin", "Defective") Then

            MsgBox(modServerBridge.UpdateDeploymentStatus(lvDeployedEquipments.SelectedItems(0).SubItems(6).Text, 0, "Defective", "Equipment has been pollout"))
            modController.DeployedEquipmentsLoad(lvDeployedEquipments, lvLocation.SelectedItems(0).Text)
        End If
    End Sub

#End Region

End Class

