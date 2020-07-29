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
        Dim lst = modServerBridge.GETItem
        For Each c As cConstant In lst
            Dim oItem As New ListViewItem
            oItem.Text = Format(c.unEngrEquipment, "0000")
            oItem.SubItems.Add(c.EngrEqptName)
            oItem.Tag = c.idEngrEquipment

            lv.Items.Add(oItem)
        Next
    End Sub
End Module
