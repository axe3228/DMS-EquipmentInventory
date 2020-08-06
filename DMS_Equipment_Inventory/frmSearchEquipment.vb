Public Class frmSearchEquipment
    Public type As EMDInventory
    Private _cConstant As New cConstant
    Private _cEqStockData As New cEquipmentStockData

    Enum EMDInventory
        Equipment
        Brand
        Location
        SearchBrand
        SearchStock
    End Enum

    Public Sub New(type As EMDInventory)
        InitializeComponent()
        Me.type = type
    End Sub

    Public Property FSECLSConstant As cConstant
        Get
            Return _cConstant
        End Get
        Set(value As cConstant)
            _cConstant = value
        End Set
    End Property

    Public Property FSECLSEqStockData As cEquipmentStockData
        Get
            Return _cEqStockData
        End Get
        Set(value As cEquipmentStockData)
            _cEqStockData = value
        End Set
    End Property

    Private Sub frmSearchEquipment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' modGui.updateGui(Me)
        Initialize()
    End Sub

    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        If lvItems.SelectedItems.Count < 1 Then Return
        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub

    Private Sub Initialize()
        lvItems.Columns.Clear()
        lvItems.Items.Clear()

        Select Case type
            Case EMDInventory.Equipment
                addColumn("ID", 70)
                addColumn("Equipment", 170)
                modController.EquipmentLoad(lvItems)
            Case EMDInventory.Brand
                addColumn("Brand ID", 70)
                addColumn("Equipment", 170)
                addColumn("Brand", 155)
                txtSearch.Text = _cConstant.EngrEquipmentName
                modController.BrandLoad(lvItems, True, txtSearch.Text)
                btnSearch.Visible = False
            Case EMDInventory.SearchBrand
                addColumn("Brand ID", 70)
                addColumn("Equipment", 170)
                addColumn("Brand", 155)
                ' txtSearch.Text = eqName
              '  SearchBrand()
            Case EMDInventory.SearchStock
                addColumn("ID", 70)
                addColumn("Equipment", 170)
                addColumn("Brand", 155)
                addColumn("Model", 155)
                addColumn("Serial", 155)
                modController.StockDataLoad(lvItems, 0)
                ' SortStockData()
                '  SearchStock()
        End Select
    End Sub

    Private Sub addColumn(text As String, width As Integer)
        Dim ch As New ColumnHeader
        ch.Name = "ch" & lvItems.Columns.Count
        ch.Text = text
        ch.Width = width
        lvItems.Columns.Add(ch)
    End Sub

    Private Sub btnCancel_Click_1(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub lvItems_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvItems.SelectedIndexChanged
        If lvItems.SelectedItems.Count < 1 Then Return

        Select Case type
            Case EMDInventory.Equipment
                _cConstant.EngrEquipmentName = lvItems.SelectedItems(0).SubItems(1).Text
            Case EMDInventory.Brand
                _cConstant.BrandName = lvItems.SelectedItems(0).SubItems(2).Text
            Case EMDInventory.SearchBrand

            Case EMDInventory.SearchStock
                _cEqStockData.idEngrEquipmentStockData = lvItems.SelectedItems(0).Tag
                _cEqStockData.EESDEquipment = lvItems.SelectedItems(0).SubItems(1).Text
                _cEqStockData.EESDBrand = lvItems.SelectedItems(0).SubItems(2).Text
                _cEqStockData.EESDSerial = lvItems.SelectedItems(0).SubItems(3).Text
                _cEqStockData.EESDModel = lvItems.SelectedItems(0).SubItems(4).Text
        End Select

    End Sub

    Private Sub lvItems_DoubleClick(sender As Object, e As EventArgs) Handles lvItems.DoubleClick
        btnOk.PerformClick()
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Select Case type
            Case EMDInventory.Equipment

            Case EMDInventory.Brand
                modController.BrandLoad(lvItems, True, txtSearch.Text)
            Case EMDInventory.SearchBrand

            Case EMDInventory.SearchStock

        End Select

    End Sub

    Private Sub lvItems_KeyDown(sender As Object, e As KeyEventArgs) Handles lvItems.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnOk.PerformClick()
        End If
    End Sub
End Class