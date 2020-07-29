Public Class frmSearchEquipment
    Public type As EMDInventory

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

    Private Sub frmSearchEquipment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' modGui.updateGui(Me)
        Initialize()
    End Sub

    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click
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
               ' EMDIControl.iBrandLoadv2(lvItems)
            Case EMDInventory.SearchBrand
                addColumn("Brand ID", 70)
                addColumn("Equipment", 170)
                addColumn("Brand", 155)
                ' txtSearch.Text = eqName
              '  SearchBrand()
            Case EMDInventory.SearchStock
                addColumn("Stock ID", 70)
                addColumn("Equipment", 170)
                addColumn("Brand", 155)
                addColumn("Model", 155)
                addColumn("Serial", 155)
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
End Class