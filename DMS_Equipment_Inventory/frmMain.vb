Public Class frmMain
    Private frm As frmManageRepo = Nothing
    Private Sub tsbClose_Click(sender As Object, e As EventArgs) Handles tsbClose.Click
        Me.Close()
    End Sub

    Private Sub tsbEquipment_Click(sender As Object, e As EventArgs) Handles tsbEquipment.Click
        frm = New frmManageRepo(frmManageRepo.EMDInventory.Item)
        If frm IsNot Nothing Then
            frm.ShowDialog()
        End If
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        frm = New frmManageRepo(frmManageRepo.EMDInventory.Brand)
        If frm IsNot Nothing Then
            frm.ShowDialog()
        End If
    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        frm = New frmManageRepo(frmManageRepo.EMDInventory.Location)
        If frm IsNot Nothing Then
            frm.ShowDialog()
        End If
    End Sub
End Class
