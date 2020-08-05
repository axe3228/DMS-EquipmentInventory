Module modController

    Public Sub FieldClear(parent As Control)
        For Each child As Control In parent.Controls
            Select Case True
                Case TypeOf child Is TextBox
                    child.ResetText()
                Case TypeOf child Is NumericUpDown
                    child.ResetText()
                Case TypeOf child Is ComboBox
                    child.ResetText()
                Case TypeOf child Is RichTextBox
                    child.ResetText()
            End Select
        Next
    End Sub

    Public Sub EquipmentLoad(lv As ListView)
        Dim lst = modServerBridge.GetEquipment
        lv.Items.Clear()
        For Each c As cConstant In lst
            Dim oItem As New ListViewItem
            oItem.Text = Format(c.idEngrEquipment, "0000")
            oItem.SubItems.Add(c.EngrEquipmentName)
            oItem.Tag = c.idEngrEquipment

            lv.Items.Add(oItem)
        Next
    End Sub

    Public Sub BrandLoad(lv As ListView, isFilter As Boolean, key As String)
        Dim lst As IEnumerable(Of cConstant) = modServerBridge.GetBrand.ToList

        If isFilter Then
            lst =
              From _lst As cConstant In lst
              Order By _lst.unEngrEquipmentBrand Descending
              Where _lst.EngrEquipmentName.ToLower = key.ToLower
              Select _lst
        End If

        lv.Items.Clear()

        For Each c As cConstant In lst
            Dim oItem As New ListViewItem
            oItem.Text = Format(c.idEngrEquipmentBrand, "0000")
            oItem.SubItems.Add(c.EngrEquipmentName)
            oItem.SubItems.Add(c.BrandName)
            oItem.Tag = c.idEngrEquipmentBrand

            lv.Items.Add(oItem)
        Next
    End Sub

    Public Sub LocationsLoad(lv As ListView)
        Dim lst = modServerBridge.GetLocation
        lv.Items.Clear()
        For Each c As cConstant In lst
            Dim oItem As New ListViewItem
            oItem.Text = Format(c.idEngrLocation, "0000")
            oItem.SubItems.Add(c.LocatioName)
            oItem.Tag = c.idEngrLocation

            lv.Items.Add(oItem)
        Next
    End Sub

#Region "Receiving"
    Public Sub StockControlLoad(lv As ListView)
        Dim lst As IEnumerable(Of cEquipmentStockControl) =
              From _lst As cEquipmentStockControl In modServerBridge.GetStockControl
              Order By _lst.unEngrEquipmentStockControl Descending
              Select _lst

        lv.Items.Clear()
        For Each c In lst
            Dim oItem As New ListViewItem
            oItem.Text = Format(c.unEngrEquipmentStockControl, "0000")
            oItem.SubItems.Add(c.TimeStamp)
            oItem.SubItems.Add(c.EESCRemarks)

            oItem.ImageKey = "document.png"
            oItem.Tag = c.idEngrEquipmentStockControl

            lv.Items.Add(oItem)
        Next
    End Sub

    Public Sub StockDataLoad(lv As ListView, idStockControl As Integer)
        Dim lst As IEnumerable(Of cEquipmentStockData)
        Dim id As Integer

        If idStockControl <> 0 Then
            lst =
                From _lst As cEquipmentStockData In modServerBridge.GetStockData(idStockControl)
                Order By _lst.unEngrEquipmentStockData Descending
                Select _lst
        Else
            lst =
                From _lst As cEquipmentStockData In modServerBridge.GetStockData(idStockControl)
                Order By _lst.idEngrEquipmentStockData Ascending
                Where _lst.EESDLocation = "Warehouse"
                Select _lst
        End If

        lv.Items.Clear()
        For Each c In lst
            Dim oItem As New ListViewItem

            If idStockControl <> 0 Then
                id = c.unEngrEquipmentStockData
            Else
                id = c.idEngrEquipmentStockData
            End If

            oItem.Text = Format(id, "0000")
            oItem.SubItems.Add(c.EESDEquipment)
            oItem.SubItems.Add(c.EESDBrand)
            oItem.SubItems.Add(c.EESDSerial)
            oItem.SubItems.Add(c.EESDModel)
            oItem.SubItems.Add(c.EESDState)

            oItem.ImageKey = "document.png"
            oItem.Tag = c.idEngrEquipmentStockData

            lv.Items.Add(oItem)
        Next
    End Sub


#End Region

#Region "Deployement"
    Public Sub DeploymentLocationsLoad(lv As ListView)

        lv.Items.Clear()
        Dim lst As IEnumerable(Of cConstant) =
            From _lst In modServerBridge.GetLocation
            Order By _lst.LocatioName
            Select _lst

        For Each c In lst
            Dim oItem As New ListViewItem
            oItem.Text = c.LocatioName
            'oItem.SubItems.Add("Equipment Deployed : " & EMDIModel.GetDeployEquipmentCount(c.ELName))

            oItem.ImageKey = "location.png"
            oItem.Tag = c.idEngrLocation

            lv.Items.Add(oItem)
        Next

        'lvLocation.Text = "Location Count : " & lstLocation.Count
    End Sub

    Public Sub DeployedEquipmentsLoad(lv As ListView, location As String)
        lv.Items.Clear()

        For Each c In modServerBridge.GetDeployedEquipments(location)

            Dim oItem As New ListViewItem
            oItem.Text = Format(c.unDeployment, "0000")
            oItem.SubItems.Add(c.EESDEquipment)
            oItem.SubItems.Add(c.EESDBrand)
            oItem.SubItems.Add(c.EESDSerial)
            oItem.SubItems.Add(c.EESDModel)
            oItem.SubItems.Add(c.DeploymentDate)
            oItem.SubItems.Add(c.idDeployment)
            oItem.Tag = c.idEngrEquipmentStockData

            lv.Items.Add(oItem)
        Next

        ' lblEDCount.Text = "Equipment Deployed : " & lvDeployedEquipments.Items.Count
    End Sub


#End Region

#Region "Inventory"
    Public Sub InventoryLoad(lv As ListView)
        lv.Items.Clear()
        Dim lst = modServerBridge.GetStockData(0)
        For Each c In modServerBridge.GetInventoryEquipments
            Dim oItem As New ListViewItem
            oItem.Text = c.EESDEquipment
            oItem.SubItems.Add(c.EESDBrand)
            oItem.SubItems.Add(0)
            oItem.SubItems.Add(0)
            oItem.SubItems.Add(0)
            oItem.SubItems.Add(0)
            oItem.SubItems.Add(0)

            lv.Items.Add(oItem)
        Next

        'Dim itemlist As New List(Of String)
        'itemlist.Add("RED")
        'itemlist.Add("RED")
        'itemlist.Add("RED")
        'itemlist.Add("GREEN")

        Dim groups = lst.GroupBy(Function(value) value.EESDBrand)

        'https://stackoverflow.com/questions/7325278/group-by-in-linq

        For Each grp In groups
            Console.WriteLine(grp(0).EESDEquipment & " - " & grp.Count)
        Next
    End Sub
#End Region
End Module
