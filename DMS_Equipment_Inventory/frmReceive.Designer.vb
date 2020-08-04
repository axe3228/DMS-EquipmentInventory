<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReceive
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtModel = New System.Windows.Forms.TextBox()
        Me.lblTwo = New System.Windows.Forms.Label()
        Me.txtSerial = New System.Windows.Forms.TextBox()
        Me.btnEquipment = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtEquipment = New System.Windows.Forms.TextBox()
        Me.btnBrand = New System.Windows.Forms.Button()
        Me.lblOne = New System.Windows.Forms.Label()
        Me.txtBrand = New System.Windows.Forms.TextBox()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.Firebrick
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.lblTitle)
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(341, 191)
        Me.Panel1.TabIndex = 1
        Me.Panel1.Tag = "1"
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel2.Controls.Add(Me.btnCancel)
        Me.Panel2.Controls.Add(Me.btnAdd)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.txtModel)
        Me.Panel2.Controls.Add(Me.lblTwo)
        Me.Panel2.Controls.Add(Me.txtSerial)
        Me.Panel2.Controls.Add(Me.btnEquipment)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.txtEquipment)
        Me.Panel2.Controls.Add(Me.btnBrand)
        Me.Panel2.Controls.Add(Me.lblOne)
        Me.Panel2.Controls.Add(Me.txtBrand)
        Me.Panel2.Location = New System.Drawing.Point(3, 25)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(335, 163)
        Me.Panel2.TabIndex = 1
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancel.BackColor = System.Drawing.Color.Firebrick
        Me.btnCancel.FlatAppearance.BorderSize = 0
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.SystemColors.Window
        Me.btnCancel.Location = New System.Drawing.Point(254, 134)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 150
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'btnAdd
        '
        Me.btnAdd.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAdd.BackColor = System.Drawing.Color.Firebrick
        Me.btnAdd.FlatAppearance.BorderSize = 0
        Me.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdd.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.ForeColor = System.Drawing.SystemColors.Window
        Me.btnAdd.Location = New System.Drawing.Point(173, 134)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnAdd.TabIndex = 149
        Me.btnAdd.Text = "Receive"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label3.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(9, 100)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 13)
        Me.Label3.TabIndex = 148
        Me.Label3.Text = "Model"
        '
        'txtModel
        '
        Me.txtModel.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtModel.Location = New System.Drawing.Point(89, 97)
        Me.txtModel.Name = "txtModel"
        Me.txtModel.Size = New System.Drawing.Size(230, 21)
        Me.txtModel.TabIndex = 147
        '
        'lblTwo
        '
        Me.lblTwo.AutoSize = True
        Me.lblTwo.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblTwo.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTwo.Location = New System.Drawing.Point(9, 73)
        Me.lblTwo.Name = "lblTwo"
        Me.lblTwo.Size = New System.Drawing.Size(40, 13)
        Me.lblTwo.TabIndex = 146
        Me.lblTwo.Text = "Serial"
        '
        'txtSerial
        '
        Me.txtSerial.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSerial.Location = New System.Drawing.Point(89, 70)
        Me.txtSerial.Name = "txtSerial"
        Me.txtSerial.Size = New System.Drawing.Size(230, 21)
        Me.txtSerial.TabIndex = 145
        '
        'btnEquipment
        '
        Me.btnEquipment.BackColor = System.Drawing.Color.Firebrick
        Me.btnEquipment.FlatAppearance.BorderSize = 0
        Me.btnEquipment.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEquipment.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEquipment.ForeColor = System.Drawing.SystemColors.Window
        Me.btnEquipment.Location = New System.Drawing.Point(277, 14)
        Me.btnEquipment.Name = "btnEquipment"
        Me.btnEquipment.Size = New System.Drawing.Size(42, 21)
        Me.btnEquipment.TabIndex = 144
        Me.btnEquipment.Text = "..."
        Me.btnEquipment.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(9, 17)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 13)
        Me.Label2.TabIndex = 143
        Me.Label2.Text = "Equipment"
        '
        'txtEquipment
        '
        Me.txtEquipment.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEquipment.Location = New System.Drawing.Point(89, 14)
        Me.txtEquipment.Name = "txtEquipment"
        Me.txtEquipment.ReadOnly = True
        Me.txtEquipment.Size = New System.Drawing.Size(182, 21)
        Me.txtEquipment.TabIndex = 1
        '
        'btnBrand
        '
        Me.btnBrand.BackColor = System.Drawing.Color.Firebrick
        Me.btnBrand.FlatAppearance.BorderSize = 0
        Me.btnBrand.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBrand.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBrand.ForeColor = System.Drawing.SystemColors.Window
        Me.btnBrand.Location = New System.Drawing.Point(277, 43)
        Me.btnBrand.Name = "btnBrand"
        Me.btnBrand.Size = New System.Drawing.Size(42, 21)
        Me.btnBrand.TabIndex = 141
        Me.btnBrand.Text = "..."
        Me.btnBrand.UseVisualStyleBackColor = False
        '
        'lblOne
        '
        Me.lblOne.AutoSize = True
        Me.lblOne.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblOne.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOne.Location = New System.Drawing.Point(9, 46)
        Me.lblOne.Name = "lblOne"
        Me.lblOne.Size = New System.Drawing.Size(41, 13)
        Me.lblOne.TabIndex = 140
        Me.lblOne.Text = "Brand"
        '
        'txtBrand
        '
        Me.txtBrand.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBrand.Location = New System.Drawing.Point(89, 43)
        Me.txtBrand.Name = "txtBrand"
        Me.txtBrand.ReadOnly = True
        Me.txtBrand.Size = New System.Drawing.Size(182, 21)
        Me.txtBrand.TabIndex = 2
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblTitle.Location = New System.Drawing.Point(5, 5)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(126, 14)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Receive Equipment"
        '
        'frmReceive
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(347, 197)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmReceive"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmReceive"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents txtModel As TextBox
    Friend WithEvents lblTwo As Label
    Friend WithEvents txtSerial As TextBox
    Friend WithEvents btnEquipment As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents txtEquipment As TextBox
    Friend WithEvents btnBrand As Button
    Friend WithEvents lblOne As Label
    Friend WithEvents txtBrand As TextBox
    Friend WithEvents lblTitle As Label
End Class
