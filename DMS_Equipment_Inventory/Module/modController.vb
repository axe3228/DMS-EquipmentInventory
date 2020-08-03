Module modController

    Private lv As ListView

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

    Public Sub EquipmentLoad(lv)
        Dim lst = modServerBridge.GetEquipment
        For Each c As cConstant In lst
            Dim oItem As New ListViewItem
            oItem.Text = Format(c.idEngrEquipment, "0000")
            oItem.SubItems.Add(c.EngrEquipmentName)
            oItem.Tag = c.idEngrEquipment

            lv.Items.Add(oItem)
        Next
    End Sub

    Public Sub BrandLoad(lv)
        Dim lst = modServerBridge.GetBrand
        For Each c As cConstant In lst
            Dim oItem As New ListViewItem
            oItem.Text = Format(c.idEngrEquipmentBrand, "0000")
            oItem.SubItems.Add(c.EngrEquipmentName)
            oItem.SubItems.Add(c.BrandName)
            oItem.Tag = c.idEngrEquipmentBrand

            lv.Items.Add(oItem)
        Next
    End Sub

    Public Sub LocationsLoad(lv)
        Dim lst = modServerBridge.GetLocation
        For Each c As cConstant In lst
            Dim oItem As New ListViewItem
            oItem.Text = Format(c.idEngrLocation, "0000")
            oItem.SubItems.Add(c.LocatioName)
            oItem.Tag = c.idEngrLocation

            lv.Items.Add(oItem)
        Next
    End Sub
End Module
