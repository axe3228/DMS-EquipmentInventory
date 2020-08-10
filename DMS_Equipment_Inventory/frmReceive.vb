Public Class frmReceive

    Private _idControl As Integer
    Private _cStockData As cEquipmentStockData

    Public Property EquipmentControlID As Integer
        Get
            Return _idControl
        End Get
        Set(value As Integer)
            _idControl = value
        End Set
    End Property

    Public Property frStockData As cEquipmentStockData
        Get
            Return _cStockData
        End Get
        Set(value As cEquipmentStockData)
            _cStockData = value
        End Set
    End Property

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnEquipment_Click(sender As Object, e As EventArgs) Handles btnEquipment.Click
        Dim frm = New frmSearchEquipment(frmSearchEquipment.EMDInventory.Equipment)
        If Not frm.ShowDialog() = Windows.Forms.DialogResult.OK Then Return
        txtEquipment.Text = frm.FSECLSConstant.EngrEquipmentName
        txtBrand.Text = ""
    End Sub

    Private Sub btnBrand_Click(sender As Object, e As EventArgs) Handles btnBrand.Click
        If txtEquipment.Text = "" Then Return

        Dim frm = New frmSearchEquipment(frmSearchEquipment.EMDInventory.Brand)
        frm.FSECLSConstant.EngrEquipmentName = txtEquipment.Text

        If Not frm.ShowDialog() = Windows.Forms.DialogResult.OK Then Return
        txtBrand.Text = frm.FSECLSConstant.BrandName

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim _cls As New cEquipmentStockData

        _cls.idEngrEquipmentStockControl = _idControl
        _cls.EESDEquipment = txtEquipment.Text
        _cls.EESDBrand = txtBrand.Text
        _cls.EESDSerial = txtSerial.Text
        _cls.EESDModel = txtModel.Text

        For Each child As Control In Panel2.Controls
            Select Case True
                Case TypeOf child Is TextBox
                    If child.Text = "" Then
                        MsgBox("All must be filled")
                        Exit Sub
                    End If
            End Select
        Next

        MsgBox(modServerBridge.POSTEquipmentStockData(_cls))

        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub

    Private Sub txtModel_KeyDown(sender As Object, e As KeyEventArgs) Handles txtModel.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnAdd.PerformClick()
        End If
    End Sub
End Class