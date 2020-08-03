Public Class frmManageRepo

    Public type As EMDInventory
    Private _class As New cConstant

    Enum EMDInventory
        Item
        Brand
        Location
    End Enum

    Public Sub New(type As EMDInventory)
        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
        Me.type = type
    End Sub

    Private Sub Initialize()
        lvRepository.Columns.Clear()
        lvRepository.Items.Clear()

        Select Case type
            Case EMDInventory.Item
                addColumn("ID", 70)
                addColumn("Equipment", 170)
                modController.EquipmentLoad(lvRepository)
            Case EMDInventory.Brand
                addColumn("ID", 70)
                addColumn("Equipment", 170)
                addColumn("Brand", 155)
                modController.BrandLoad(lvRepository)
            Case EMDInventory.Location
                addColumn("ID", 70)
                addColumn("Location", 170)
                modController.LocationsLoad(lvRepository)
        End Select
    End Sub

    Private Sub addColumn(text As String, width As Integer)
        Dim ch As New ColumnHeader
        ch.Name = "ch" & lvRepository.Columns.Count
        ch.Text = text
        ch.Width = width
        lvRepository.Columns.Add(ch)
    End Sub

    Private Sub tsbClose_Click(sender As Object, e As EventArgs) Handles tsbClose.Click
        Me.Close()
    End Sub

    Private Sub tscbRepository_SelectedIndexChanged(sender As Object, e As EventArgs) Handles tscbRepository.SelectedIndexChanged
        If tscbRepository.SelectedIndex = -1 Then Exit Sub
        Select Case tscbRepository.SelectedItem
            Case "Equipment"
                type = EMDInventory.Item
            Case "Brand"
                type = EMDInventory.Brand
            Case "Location"
                type = EMDInventory.Location
        End Select

        Initialize()
    End Sub

    Private Sub frmManageRepo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Select Case type
            Case EMDInventory.Item
                tscbRepository.SelectedItem = "Equipment"
            Case EMDInventory.Brand
                tscbRepository.SelectedItem = "Brand"
            Case EMDInventory.Location
                tscbRepository.SelectedItem = "Location"
        End Select
    End Sub

    Private Sub tsbAddRepo_Click(sender As Object, e As EventArgs) Handles tsbAddRepo.Click
        Dim frm As frmAddItem = Nothing
        Select Case type
            Case 0
                frm = New frmAddItem("Equipment")
            Case 1
                frm = New frmAddItem("Brand")
            Case 2
                frm = New frmAddItem("Location")
        End Select

        If frm IsNot Nothing Then
            frm.ShowDialog()
            Initialize()
        End If
    End Sub

    Private Sub lvRepository_KeyDown(sender As Object, e As KeyEventArgs) Handles lvRepository.KeyDown
        If e.KeyCode = Keys.Enter Then
            tsbAddRepo.PerformClick()
        End If
    End Sub

    Private Sub lvRepository_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvRepository.SelectedIndexChanged
        If lvRepository.SelectedItems.Count < 1 Then Return

        Select Case tscbRepository.SelectedItem
            Case "Equipment"
                _class.idEngrEquipment = lvRepository.SelectedItems(0).Tag
                _class.EngrEquipmentName = lvRepository.SelectedItems(0).SubItems(1).Text
            Case "Brand"
                type = EMDInventory.Brand
            Case "Location"
                type = EMDInventory.Location
        End Select

    End Sub

    Private Sub lvRepository_DoubleClick(sender As Object, e As EventArgs) Handles lvRepository.DoubleClick
        Dim frm As frmAddItem = Nothing

        Select Case tscbRepository.SelectedItem
            Case "Equipment"
                frm = New frmAddItem("Equipment")
                frm.cConstant = _class
            Case "Brand"
                type = EMDInventory.Brand
            Case "Location"
                type = EMDInventory.Location
        End Select

        If frm IsNot Nothing Then
            frm.ShowDialog()
            Initialize()
        End If
    End Sub
End Class