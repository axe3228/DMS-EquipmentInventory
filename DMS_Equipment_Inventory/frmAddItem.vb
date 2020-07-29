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
            Case "Item"
                lblItem.Visible = False
                txtItem.Visible = False
                btnSearchItem.Visible = False

                lblFormTitle.Text = "Add Equipment"

                If Not _class.idEngrEquipment = Nothing Then
                    txtName.Text = _class.EngrEqptName
                    btnAdd.Text = "Update"
                End If
            Case "Brand"
                lblFormTitle.Text = "Add Brand"
            Case "Location"
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
            Case "Item"

                If Not _class.idEngrEquipment = Nothing Then
                    modServerBridge.UpdateItem(_class.idEngrEquipment, txtName.Text)
                Else
                    modServerBridge.POSTItem(txtName.Text)
                End If
            Case "Brand"
                lblFormTitle.Text = "Add Brand"
                'modServerBridge.POSTBrand()
            Case "Location"
                lblItem.Visible = False
                txtItem.Visible = False
                btnSearchItem.Visible = False

                lblFormTitle.Text = "Add Location"
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
                ' idEqpt = frm.idGetSet
                ' txtOne.Text = frm.Equipment
            End If
        End If
    End Sub
End Class