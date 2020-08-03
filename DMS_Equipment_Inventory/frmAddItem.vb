Public Class frmAddItem

    Private _class As New cConstant
    Private type As String

    Public Sub New(type As String)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.type = type
    End Sub

    Public Property cConstant As cConstant
        Get
            Return _class
        End Get
        Set(value As cConstant)
            _class = value
        End Set
    End Property

    Private Sub Initialize()
        Select Case type
            Case "Equipment"
                lblItem.Visible = False
                txtItem.Visible = False
                btnSearchItem.Visible = False

                lblFormTitle.Text = "Add Equipment"

                If Not _class.idEngrEquipment = Nothing Then
                    txtName.Text = _class.EngrEquipmentName
                    btnAdd.Text = "Update"
                End If
            Case "Brand"
                lblFormTitle.Text = "Add Brand"
            Case "Location"
                lblItem.Visible = False
                txtItem.Visible = False
                btnSearchItem.Visible = False
                lblFormTitle.Text = "Add Location"

        End Select
    End Sub

    Private Sub frmAddItem_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Initialize()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Select Case type
            Case "Equipment"
                If Not _class.idEngrEquipment = Nothing Then
                    modServerBridge.UpdateEquipment(_class.idEngrEquipment, txtName.Text)
                Else
                    MsgBox(modServerBridge.POSTEquipment(txtName.Text))
                End If

            Case "Brand"
                lblFormTitle.Text = "Add Brand"
                MsgBox(modServerBridge.POSTBrand(txtItem.Text, txtName.Text))

            Case "Location"
                lblFormTitle.Text = "Add Location"
                MsgBox(modServerBridge.POSTLocation(txtName.Text))
        End Select

        FieldClear(Panel2)
        Me.Close()
    End Sub

    Private Sub txtName_KeyDown(sender As Object, e As KeyEventArgs) Handles txtName.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnAdd.PerformClick()
        End If
    End Sub

    Private Sub btnSearchItem_Click(sender As Object, e As EventArgs) Handles btnSearchItem.Click
        Dim frm As frmSearchEquipment = Nothing
        frm = New frmSearchEquipment(frmSearchEquipment.EMDInventory.Equipment)

        If frm IsNot Nothing Then
            If frm.ShowDialog() = Windows.Forms.DialogResult.OK Then

                txtItem.Text = frm.FSECLSConstant.EngrEquipmentName
            End If
        End If
    End Sub
End Class