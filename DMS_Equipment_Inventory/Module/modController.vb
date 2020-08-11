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
            oItem.Text = Format(c.unEngrEquipmentStockControl, "0000") & " - " & c.EESCState
            oItem.SubItems.Add(c.TimeStamp)
            oItem.SubItems.Add(c.EESCRemarks)
            oItem.SubItems.Add(c.EESCState)

            oItem.ImageKey = "doc" & c.EESCState & ".png"
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
            Dim count = modServerBridge.DeployedEqCounter(c.LocatioName)
            oItem.Text = c.LocatioName
            oItem.SubItems.Add("Equipment Deployed : " & count)
            oItem.SubItems.Add(count)

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
        Dim lstTotalStock As New List(Of cConstant)
        Dim lstStockNames As New List(Of cEMDInventory)
        Dim lstStocksDefective As New List(Of cEMDInventory)
        Dim lstStocksReturned As New List(Of cEMDInventory)
        Dim lstStocksDeployed As New List(Of cEMDInventory)
        Dim lstInStock As New List(Of cEMDInventory)
        Dim lstInventory As New List(Of cEMDInventory)

        'Step #1 Getting all the Equipment Name, Brand Name and Total Stocks* 
        Dim grpnamexbrandxtotal = lst.GroupBy(Function(value) value.eqnamexbrandname)
        For Each grp In grpnamexbrandxtotal
            Dim _cls As New cEMDInventory

            _cls.EquipmentName = grp(0).EESDEquipment
            _cls.BrandName = grp(0).EESDBrand
            _cls.TotalStock = grp.Count

            lstStockNames.Add(_cls)
        Next
        '**************

        'Step #2 Getting all the defectives, Returned and Deployed counts*
        Dim grpStates = lst.GroupBy(Function(value) value.eqnamexbrandnamexstate)
        For Each grp In grpStates
            Dim _cls As New cEMDInventory
            Select Case grp(0).EESDState
                Case "Defective"
                    _cls.EquipmentName = grp(0).EESDEquipment
                    _cls.BrandName = grp(0).EESDBrand
                    _cls.Defective = grp.Count

                    lstStocksDefective.Add(_cls)
                Case "Returned"
                    _cls.EquipmentName = grp(0).EESDEquipment
                    _cls.BrandName = grp(0).EESDBrand
                    _cls.Returned = grp.Count

                    lstStocksReturned.Add(_cls)
                Case "Deployed"
                    _cls.EquipmentName = grp(0).EESDEquipment
                    _cls.BrandName = grp(0).EESDBrand
                    _cls.Deployed = grp.Count

                    lstStocksDeployed.Add(_cls)
            End Select
        Next
        '**************

        'Step #3 Getting all In Stocks*
        Dim grpnamexbrandxlocation = lst.GroupBy(Function(value) value.eqnamexbrandnamexstate)
        For Each grp In grpnamexbrandxlocation
            If grp(0).EESDLocation = "Warehouse" Then
                Dim _cls As New cEMDInventory
                _cls.EquipmentName = grp(0).EESDEquipment
                _cls.BrandName = grp(0).EESDBrand
                _cls.InStock = grp.Count

                lstInStock.Add(_cls)
            End If
        Next
        '*****************************

        'Sorting Gatherd Inventory Data
        For Each stocknames In lstStockNames
            Dim cInv As New cEMDInventory
            cInv.EquipmentName = stocknames.EquipmentName
            cInv.BrandName = stocknames.BrandName
            cInv.TotalStock = stocknames.TotalStock
            Dim id = stocknames.EquipmentName & " - " & stocknames.BrandName

            For Each defectives In lstStocksDefective
                If id = defectives.EquipmentName & " - " & defectives.BrandName Then
                    cInv.Defective = defectives.Defective
                End If
            Next

            For Each returned In lstStocksReturned
                If id = returned.EquipmentName & " - " & returned.BrandName Then
                    cInv.Returned = returned.Returned
                End If
            Next

            For Each deployed In lstStocksDeployed
                If id = deployed.EquipmentName & " - " & deployed.BrandName Then
                    cInv.Deployed = deployed.Deployed
                End If
            Next

            For Each inStock In lstInStock
                If id = inStock.EquipmentName & " - " & inStock.BrandName Then
                    cInv.InStock = inStock.InStock
                End If
            Next

            lstInventory.Add(cInv)
        Next
        '****************     

        For Each c In lstInventory
            Dim oItem As New ListViewItem
            oItem.Text = c.EquipmentName
            oItem.SubItems.Add(c.BrandName)
            oItem.SubItems.Add(c.InStock)
            oItem.SubItems.Add(c.Deployed)
            oItem.SubItems.Add(c.Returned)
            oItem.SubItems.Add(c.Defective)
            oItem.SubItems.Add(c.TotalStock)

            lv.Items.Add(oItem)
        Next

        'Console.WriteLine(grp(0).eqnamexbrandname & " - " & grp.Count)
    End Sub
#End Region
End Module
