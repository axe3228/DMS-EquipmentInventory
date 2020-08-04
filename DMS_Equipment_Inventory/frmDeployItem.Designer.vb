<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDeployItem
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnDeploy = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.dtpDeployedDate = New System.Windows.Forms.DateTimePicker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtModel = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtBrand = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtSerial = New System.Windows.Forms.TextBox()
        Me.btnSearchEqStockData = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtEquipment = New System.Windows.Forms.TextBox()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel3
        '
        Me.Panel3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel3.BackColor = System.Drawing.Color.Firebrick
        Me.Panel3.Controls.Add(Me.Label6)
        Me.Panel3.Controls.Add(Me.Panel4)
        Me.Panel3.Location = New System.Drawing.Point(5, 4)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(303, 240)
        Me.Panel3.TabIndex = 3
        Me.Panel3.Tag = "1"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label6.Location = New System.Drawing.Point(5, 8)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(121, 14)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Deploy Equipment"
        '
        'Panel4
        '
        Me.Panel4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel4.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel4.Controls.Add(Me.Button1)
        Me.Panel4.Controls.Add(Me.btnDeploy)
        Me.Panel4.Controls.Add(Me.Label7)
        Me.Panel4.Controls.Add(Me.dtpDeployedDate)
        Me.Panel4.Controls.Add(Me.Label8)
        Me.Panel4.Controls.Add(Me.txtModel)
        Me.Panel4.Controls.Add(Me.Label9)
        Me.Panel4.Controls.Add(Me.txtBrand)
        Me.Panel4.Controls.Add(Me.Label10)
        Me.Panel4.Controls.Add(Me.txtSerial)
        Me.Panel4.Controls.Add(Me.btnSearchEqStockData)
        Me.Panel4.Controls.Add(Me.Label11)
        Me.Panel4.Controls.Add(Me.txtEquipment)
        Me.Panel4.Location = New System.Drawing.Point(3, 31)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(297, 204)
        Me.Panel4.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.BackColor = System.Drawing.Color.Firebrick
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.Window
        Me.Button1.Location = New System.Drawing.Point(215, 174)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 157
        Me.Button1.Text = "Cancel"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'btnDeploy
        '
        Me.btnDeploy.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDeploy.BackColor = System.Drawing.Color.Firebrick
        Me.btnDeploy.FlatAppearance.BorderSize = 0
        Me.btnDeploy.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDeploy.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDeploy.ForeColor = System.Drawing.SystemColors.Window
        Me.btnDeploy.Location = New System.Drawing.Point(134, 174)
        Me.btnDeploy.Name = "btnDeploy"
        Me.btnDeploy.Size = New System.Drawing.Size(75, 23)
        Me.btnDeploy.TabIndex = 156
        Me.btnDeploy.Text = "Deploy"
        Me.btnDeploy.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label7.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(49, 137)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(34, 13)
        Me.Label7.TabIndex = 155
        Me.Label7.Text = "Date"
        '
        'dtpDeployedDate
        '
        Me.dtpDeployedDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDeployedDate.Location = New System.Drawing.Point(89, 134)
        Me.dtpDeployedDate.Name = "dtpDeployedDate"
        Me.dtpDeployedDate.Size = New System.Drawing.Size(182, 20)
        Me.dtpDeployedDate.TabIndex = 154
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label8.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(43, 106)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(40, 13)
        Me.Label8.TabIndex = 153
        Me.Label8.Text = "Model"
        '
        'txtModel
        '
        Me.txtModel.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtModel.Location = New System.Drawing.Point(89, 103)
        Me.txtModel.Name = "txtModel"
        Me.txtModel.ReadOnly = True
        Me.txtModel.Size = New System.Drawing.Size(182, 21)
        Me.txtModel.TabIndex = 152
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label9.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(42, 50)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(41, 13)
        Me.Label9.TabIndex = 151
        Me.Label9.Text = "Brand"
        '
        'txtBrand
        '
        Me.txtBrand.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBrand.Location = New System.Drawing.Point(89, 47)
        Me.txtBrand.Name = "txtBrand"
        Me.txtBrand.ReadOnly = True
        Me.txtBrand.Size = New System.Drawing.Size(182, 21)
        Me.txtBrand.TabIndex = 150
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label10.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(43, 79)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(40, 13)
        Me.Label10.TabIndex = 149
        Me.Label10.Text = "Serial"
        '
        'txtSerial
        '
        Me.txtSerial.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSerial.Location = New System.Drawing.Point(89, 76)
        Me.txtSerial.Name = "txtSerial"
        Me.txtSerial.ReadOnly = True
        Me.txtSerial.Size = New System.Drawing.Size(182, 21)
        Me.txtSerial.TabIndex = 148
        '
        'btnSearchEqStockData
        '
        Me.btnSearchEqStockData.BackColor = System.Drawing.Color.Firebrick
        Me.btnSearchEqStockData.FlatAppearance.BorderSize = 0
        Me.btnSearchEqStockData.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSearchEqStockData.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearchEqStockData.ForeColor = System.Drawing.SystemColors.Window
        Me.btnSearchEqStockData.Location = New System.Drawing.Point(239, 18)
        Me.btnSearchEqStockData.Name = "btnSearchEqStockData"
        Me.btnSearchEqStockData.Size = New System.Drawing.Size(32, 21)
        Me.btnSearchEqStockData.TabIndex = 147
        Me.btnSearchEqStockData.Text = "..."
        Me.btnSearchEqStockData.UseVisualStyleBackColor = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label11.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(16, 22)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(67, 13)
        Me.Label11.TabIndex = 146
        Me.Label11.Text = "Equipment"
        '
        'txtEquipment
        '
        Me.txtEquipment.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEquipment.Location = New System.Drawing.Point(89, 19)
        Me.txtEquipment.Name = "txtEquipment"
        Me.txtEquipment.ReadOnly = True
        Me.txtEquipment.Size = New System.Drawing.Size(144, 21)
        Me.txtEquipment.TabIndex = 145
        '
        'frmDeployItem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(313, 248)
        Me.Controls.Add(Me.Panel3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmDeployItem"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmDeployItem"
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents btnDeploy As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents dtpDeployedDate As DateTimePicker
    Friend WithEvents Label8 As Label
    Friend WithEvents txtModel As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtBrand As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txtSerial As TextBox
    Friend WithEvents btnSearchEqStockData As Button
    Friend WithEvents Label11 As Label
    Friend WithEvents txtEquipment As TextBox
End Class
