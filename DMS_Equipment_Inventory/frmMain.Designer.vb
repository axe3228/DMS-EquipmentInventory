<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.tcMain = New System.Windows.Forms.TabControl()
        Me.tpInventory = New System.Windows.Forms.TabPage()
        Me.tpDeployment = New System.Windows.Forms.TabPage()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.tsMain = New System.Windows.Forms.ToolStrip()
        Me.tslManage = New System.Windows.Forms.ToolStripLabel()
        Me.tsbEquipment = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton3 = New System.Windows.Forms.ToolStripButton()
        Me.lvInventory = New System.Windows.Forms.ListView()
        Me.chName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chBrand = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chStock = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chDeployed = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chTotalStock = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.scDeployment = New System.Windows.Forms.SplitContainer()
        Me.msLocationCount = New System.Windows.Forms.MenuStrip()
        Me.lvLocation = New System.Windows.Forms.ListView()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.ilLocationIcons = New System.Windows.Forms.ImageList(Me.components)
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.scDepContainer = New System.Windows.Forms.SplitContainer()
        Me.lblLocation = New System.Windows.Forms.Label()
        Me.lblEDCount = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.tsbReturn = New System.Windows.Forms.ToolStripButton()
        Me.tsbDeployed = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton6 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.chId = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chDName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chDBrand = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chDSerial = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chDModel = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chDDate = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.scReceiving = New System.Windows.Forms.SplitContainer()
        Me.MenuStrip2 = New System.Windows.Forms.MenuStrip()
        Me.tsbRNew = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbRRefresh = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripTextBox1 = New System.Windows.Forms.ToolStripTextBox()
        Me.msRDocCount = New System.Windows.Forms.MenuStrip()
        Me.tslDocCount = New System.Windows.Forms.ToolStripLabel()
        Me.lvRStockControl = New System.Windows.Forms.ListView()
        Me.scRContainer = New System.Windows.Forms.SplitContainer()
        Me.lblRDocID = New System.Windows.Forms.Label()
        Me.lblRDate = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.lblRRemarks = New System.Windows.Forms.Label()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.MenuStrip3 = New System.Windows.Forms.MenuStrip()
        Me.tsbRSave = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbRRefreshData = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator8 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton4 = New System.Windows.Forms.ToolStripButton()
        Me.lvRStockData = New System.Windows.Forms.ListView()
        Me.chRID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chRItem = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chRBrand = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chRSerial = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chRModel = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Panel1.SuspendLayout()
        Me.tcMain.SuspendLayout()
        Me.tpInventory.SuspendLayout()
        Me.tpDeployment.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.tsMain.SuspendLayout()
        CType(Me.scDeployment, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.scDeployment.Panel1.SuspendLayout()
        Me.scDeployment.Panel2.SuspendLayout()
        Me.scDeployment.SuspendLayout()
        Me.msLocationCount.SuspendLayout()
        CType(Me.scDepContainer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.scDepContainer.Panel1.SuspendLayout()
        Me.scDepContainer.Panel2.SuspendLayout()
        Me.scDepContainer.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.scReceiving, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.scReceiving.Panel1.SuspendLayout()
        Me.scReceiving.Panel2.SuspendLayout()
        Me.scReceiving.SuspendLayout()
        Me.MenuStrip2.SuspendLayout()
        Me.msRDocCount.SuspendLayout()
        CType(Me.scRContainer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.scRContainer.Panel1.SuspendLayout()
        Me.scRContainer.Panel2.SuspendLayout()
        Me.scRContainer.SuspendLayout()
        Me.MenuStrip3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Window
        Me.Panel1.Controls.Add(Me.tcMain)
        Me.Panel1.Controls.Add(Me.tsMain)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1111, 608)
        Me.Panel1.TabIndex = 0
        '
        'tcMain
        '
        Me.tcMain.Controls.Add(Me.tpInventory)
        Me.tcMain.Controls.Add(Me.tpDeployment)
        Me.tcMain.Controls.Add(Me.TabPage1)
        Me.tcMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tcMain.Location = New System.Drawing.Point(0, 29)
        Me.tcMain.Name = "tcMain"
        Me.tcMain.SelectedIndex = 0
        Me.tcMain.Size = New System.Drawing.Size(1111, 579)
        Me.tcMain.TabIndex = 1
        '
        'tpInventory
        '
        Me.tpInventory.BackColor = System.Drawing.Color.Gray
        Me.tpInventory.Controls.Add(Me.lvInventory)
        Me.tpInventory.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tpInventory.ForeColor = System.Drawing.Color.Gray
        Me.tpInventory.Location = New System.Drawing.Point(4, 22)
        Me.tpInventory.Name = "tpInventory"
        Me.tpInventory.Padding = New System.Windows.Forms.Padding(3)
        Me.tpInventory.Size = New System.Drawing.Size(1103, 553)
        Me.tpInventory.TabIndex = 0
        Me.tpInventory.Text = "Inventory"
        '
        'tpDeployment
        '
        Me.tpDeployment.BackColor = System.Drawing.Color.Gray
        Me.tpDeployment.Controls.Add(Me.scDeployment)
        Me.tpDeployment.Location = New System.Drawing.Point(4, 22)
        Me.tpDeployment.Name = "tpDeployment"
        Me.tpDeployment.Padding = New System.Windows.Forms.Padding(3)
        Me.tpDeployment.Size = New System.Drawing.Size(1103, 553)
        Me.tpDeployment.TabIndex = 1
        Me.tpDeployment.Text = "Deployment"
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.Gray
        Me.TabPage1.Controls.Add(Me.scReceiving)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1103, 553)
        Me.TabPage1.TabIndex = 2
        Me.TabPage1.Text = "Receiving"
        '
        'tsMain
        '
        Me.tsMain.BackColor = System.Drawing.Color.Firebrick
        Me.tsMain.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.tsMain.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tsMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tslManage, Me.tsbEquipment, Me.ToolStripSeparator1, Me.ToolStripButton1, Me.ToolStripSeparator2, Me.ToolStripButton2, Me.ToolStripSeparator3, Me.ToolStripButton3})
        Me.tsMain.Location = New System.Drawing.Point(0, 0)
        Me.tsMain.Name = "tsMain"
        Me.tsMain.Padding = New System.Windows.Forms.Padding(3)
        Me.tsMain.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.tsMain.Size = New System.Drawing.Size(1111, 29)
        Me.tsMain.TabIndex = 0
        Me.tsMain.Text = "tsMain"
        '
        'tslManage
        '
        Me.tslManage.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.tslManage.Name = "tslManage"
        Me.tslManage.Size = New System.Drawing.Size(64, 20)
        Me.tslManage.Text = "Manage : "
        '
        'tsbEquipment
        '
        Me.tsbEquipment.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.tsbEquipment.Image = CType(resources.GetObject("tsbEquipment.Image"), System.Drawing.Image)
        Me.tsbEquipment.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbEquipment.Name = "tsbEquipment"
        Me.tsbEquipment.Size = New System.Drawing.Size(87, 20)
        Me.tsbEquipment.Text = "Equipment"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 23)
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(61, 20)
        Me.ToolStripButton1.Text = "Brand"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 23)
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.ToolStripButton2.Image = CType(resources.GetObject("ToolStripButton2.Image"), System.Drawing.Image)
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(87, 20)
        Me.ToolStripButton2.Text = "Equipment"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 23)
        '
        'ToolStripButton3
        '
        Me.ToolStripButton3.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton3.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripButton3.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.ToolStripButton3.Image = CType(resources.GetObject("ToolStripButton3.Image"), System.Drawing.Image)
        Me.ToolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton3.Name = "ToolStripButton3"
        Me.ToolStripButton3.Size = New System.Drawing.Size(23, 20)
        Me.ToolStripButton3.Text = "X"
        '
        'lvInventory
        '
        Me.lvInventory.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lvInventory.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.chName, Me.chBrand, Me.chStock, Me.chDeployed, Me.chTotalStock})
        Me.lvInventory.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lvInventory.HideSelection = False
        Me.lvInventory.Location = New System.Drawing.Point(3, 3)
        Me.lvInventory.Name = "lvInventory"
        Me.lvInventory.Size = New System.Drawing.Size(1097, 547)
        Me.lvInventory.TabIndex = 0
        Me.lvInventory.UseCompatibleStateImageBehavior = False
        Me.lvInventory.View = System.Windows.Forms.View.Details
        '
        'chName
        '
        Me.chName.Text = "Item Name"
        Me.chName.Width = 130
        '
        'chBrand
        '
        Me.chBrand.Text = "Brand"
        Me.chBrand.Width = 120
        '
        'chStock
        '
        Me.chStock.Text = "In Stock"
        Me.chStock.Width = 80
        '
        'chDeployed
        '
        Me.chDeployed.Text = "Deployed"
        Me.chDeployed.Width = 80
        '
        'chTotalStock
        '
        Me.chTotalStock.Text = "Total Stock"
        Me.chTotalStock.Width = 80
        '
        'scDeployment
        '
        Me.scDeployment.Dock = System.Windows.Forms.DockStyle.Fill
        Me.scDeployment.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.scDeployment.Location = New System.Drawing.Point(3, 3)
        Me.scDeployment.Name = "scDeployment"
        '
        'scDeployment.Panel1
        '
        Me.scDeployment.Panel1.Controls.Add(Me.lvLocation)
        Me.scDeployment.Panel1.Controls.Add(Me.msLocationCount)
        '
        'scDeployment.Panel2
        '
        Me.scDeployment.Panel2.Controls.Add(Me.scDepContainer)
        Me.scDeployment.Size = New System.Drawing.Size(1097, 547)
        Me.scDeployment.SplitterDistance = 217
        Me.scDeployment.TabIndex = 0
        '
        'msLocationCount
        '
        Me.msLocationCount.BackColor = System.Drawing.Color.Firebrick
        Me.msLocationCount.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.msLocationCount.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1})
        Me.msLocationCount.Location = New System.Drawing.Point(0, 523)
        Me.msLocationCount.Name = "msLocationCount"
        Me.msLocationCount.Size = New System.Drawing.Size(217, 24)
        Me.msLocationCount.TabIndex = 0
        Me.msLocationCount.Text = "MenuStrip1"
        '
        'lvLocation
        '
        Me.lvLocation.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2})
        Me.lvLocation.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lvLocation.HideSelection = False
        Me.lvLocation.Location = New System.Drawing.Point(0, 0)
        Me.lvLocation.Name = "lvLocation"
        Me.lvLocation.Size = New System.Drawing.Size(217, 523)
        Me.lvLocation.TabIndex = 1
        Me.lvLocation.UseCompatibleStateImageBehavior = False
        Me.lvLocation.View = System.Windows.Forms.View.Tile
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripLabel1.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(112, 17)
        Me.ToolStripLabel1.Text = "Location Count : 0"
        '
        'ilLocationIcons
        '
        Me.ilLocationIcons.ImageStream = CType(resources.GetObject("ilLocationIcons.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ilLocationIcons.TransparentColor = System.Drawing.Color.Transparent
        Me.ilLocationIcons.Images.SetKeyName(0, "location.png")
        '
        'scDepContainer
        '
        Me.scDepContainer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.scDepContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.scDepContainer.Location = New System.Drawing.Point(0, 0)
        Me.scDepContainer.Name = "scDepContainer"
        Me.scDepContainer.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'scDepContainer.Panel1
        '
        Me.scDepContainer.Panel1.BackColor = System.Drawing.Color.Firebrick
        Me.scDepContainer.Panel1.Controls.Add(Me.lblEDCount)
        Me.scDepContainer.Panel1.Controls.Add(Me.lblLocation)
        Me.scDepContainer.Panel1.Controls.Add(Me.MenuStrip1)
        '
        'scDepContainer.Panel2
        '
        Me.scDepContainer.Panel2.Controls.Add(Me.ListView1)
        Me.scDepContainer.Size = New System.Drawing.Size(876, 547)
        Me.scDepContainer.SplitterDistance = 106
        Me.scDepContainer.TabIndex = 0
        '
        'lblLocation
        '
        Me.lblLocation.AutoSize = True
        Me.lblLocation.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLocation.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblLocation.Location = New System.Drawing.Point(8, 11)
        Me.lblLocation.Name = "lblLocation"
        Me.lblLocation.Size = New System.Drawing.Size(67, 13)
        Me.lblLocation.TabIndex = 0
        Me.lblLocation.Text = "Location : "
        '
        'lblEDCount
        '
        Me.lblEDCount.AutoSize = True
        Me.lblEDCount.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEDCount.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblEDCount.Location = New System.Drawing.Point(8, 31)
        Me.lblEDCount.Name = "lblEDCount"
        Me.lblEDCount.Size = New System.Drawing.Size(145, 13)
        Me.lblEDCount.TabIndex = 1
        Me.lblEDCount.Text = "Equipment Deployed : 0"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Firebrick
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.MenuStrip1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton6, Me.ToolStripSeparator5, Me.tsbDeployed, Me.ToolStripSeparator4, Me.tsbReturn})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 79)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(876, 27)
        Me.MenuStrip1.TabIndex = 2
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'tsbReturn
        '
        Me.tsbReturn.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.tsbReturn.Image = CType(resources.GetObject("tsbReturn.Image"), System.Drawing.Image)
        Me.tsbReturn.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbReturn.Margin = New System.Windows.Forms.Padding(5, 1, 0, 2)
        Me.tsbReturn.Name = "tsbReturn"
        Me.tsbReturn.Size = New System.Drawing.Size(65, 20)
        Me.tsbReturn.Text = "Return"
        '
        'tsbDeployed
        '
        Me.tsbDeployed.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.tsbDeployed.Image = CType(resources.GetObject("tsbDeployed.Image"), System.Drawing.Image)
        Me.tsbDeployed.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbDeployed.Margin = New System.Windows.Forms.Padding(5, 1, 0, 2)
        Me.tsbDeployed.Name = "tsbDeployed"
        Me.tsbDeployed.Size = New System.Drawing.Size(67, 20)
        Me.tsbDeployed.Text = "Deploy"
        '
        'ToolStripButton6
        '
        Me.ToolStripButton6.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.ToolStripButton6.Image = CType(resources.GetObject("ToolStripButton6.Image"), System.Drawing.Image)
        Me.ToolStripButton6.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton6.Name = "ToolStripButton6"
        Me.ToolStripButton6.Size = New System.Drawing.Size(56, 20)
        Me.ToolStripButton6.Text = "Save"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 23)
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(6, 23)
        '
        'ListView1
        '
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.chId, Me.chDName, Me.chDBrand, Me.chDSerial, Me.chDModel, Me.chDDate})
        Me.ListView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListView1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListView1.HideSelection = False
        Me.ListView1.Location = New System.Drawing.Point(0, 0)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(876, 437)
        Me.ListView1.TabIndex = 0
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'chId
        '
        Me.chId.Text = "ID"
        '
        'chDName
        '
        Me.chDName.Text = "Item"
        Me.chDName.Width = 130
        '
        'chDBrand
        '
        Me.chDBrand.Text = "Brand"
        Me.chDBrand.Width = 120
        '
        'chDSerial
        '
        Me.chDSerial.Text = "Serial"
        Me.chDSerial.Width = 120
        '
        'chDModel
        '
        Me.chDModel.Text = "Model"
        Me.chDModel.Width = 120
        '
        'chDDate
        '
        Me.chDDate.Text = "Date"
        Me.chDDate.Width = 120
        '
        'scReceiving
        '
        Me.scReceiving.Dock = System.Windows.Forms.DockStyle.Fill
        Me.scReceiving.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.scReceiving.Location = New System.Drawing.Point(3, 3)
        Me.scReceiving.Name = "scReceiving"
        '
        'scReceiving.Panel1
        '
        Me.scReceiving.Panel1.Controls.Add(Me.lvRStockControl)
        Me.scReceiving.Panel1.Controls.Add(Me.MenuStrip2)
        Me.scReceiving.Panel1.Controls.Add(Me.msRDocCount)
        '
        'scReceiving.Panel2
        '
        Me.scReceiving.Panel2.Controls.Add(Me.scRContainer)
        Me.scReceiving.Size = New System.Drawing.Size(1097, 547)
        Me.scReceiving.SplitterDistance = 230
        Me.scReceiving.TabIndex = 0
        '
        'MenuStrip2
        '
        Me.MenuStrip2.BackColor = System.Drawing.Color.Firebrick
        Me.MenuStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbRNew, Me.ToolStripSeparator6, Me.tsbRRefresh, Me.ToolStripTextBox1})
        Me.MenuStrip2.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip2.Name = "MenuStrip2"
        Me.MenuStrip2.Size = New System.Drawing.Size(230, 27)
        Me.MenuStrip2.TabIndex = 0
        Me.MenuStrip2.Text = "MenuStrip2"
        '
        'tsbRNew
        '
        Me.tsbRNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbRNew.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.tsbRNew.Image = CType(resources.GetObject("tsbRNew.Image"), System.Drawing.Image)
        Me.tsbRNew.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbRNew.Name = "tsbRNew"
        Me.tsbRNew.Size = New System.Drawing.Size(23, 20)
        Me.tsbRNew.Text = "Add"
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(6, 23)
        '
        'tsbRRefresh
        '
        Me.tsbRRefresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbRRefresh.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.tsbRRefresh.Image = CType(resources.GetObject("tsbRRefresh.Image"), System.Drawing.Image)
        Me.tsbRRefresh.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbRRefresh.Name = "tsbRRefresh"
        Me.tsbRRefresh.Size = New System.Drawing.Size(23, 20)
        Me.tsbRRefresh.Text = "Refresh"
        '
        'ToolStripTextBox1
        '
        Me.ToolStripTextBox1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripTextBox1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripTextBox1.Margin = New System.Windows.Forms.Padding(1, 0, 5, 0)
        Me.ToolStripTextBox1.Name = "ToolStripTextBox1"
        Me.ToolStripTextBox1.Size = New System.Drawing.Size(100, 23)
        '
        'msRDocCount
        '
        Me.msRDocCount.BackColor = System.Drawing.Color.Firebrick
        Me.msRDocCount.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.msRDocCount.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.msRDocCount.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tslDocCount})
        Me.msRDocCount.Location = New System.Drawing.Point(0, 523)
        Me.msRDocCount.Name = "msRDocCount"
        Me.msRDocCount.Size = New System.Drawing.Size(230, 24)
        Me.msRDocCount.TabIndex = 1
        Me.msRDocCount.Text = "MenuStrip3"
        '
        'tslDocCount
        '
        Me.tslDocCount.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.tslDocCount.Name = "tslDocCount"
        Me.tslDocCount.Size = New System.Drawing.Size(89, 17)
        Me.tslDocCount.Text = "Row Count : 0"
        '
        'lvRStockControl
        '
        Me.lvRStockControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lvRStockControl.HideSelection = False
        Me.lvRStockControl.Location = New System.Drawing.Point(0, 27)
        Me.lvRStockControl.Name = "lvRStockControl"
        Me.lvRStockControl.Size = New System.Drawing.Size(230, 496)
        Me.lvRStockControl.TabIndex = 2
        Me.lvRStockControl.UseCompatibleStateImageBehavior = False
        '
        'scRContainer
        '
        Me.scRContainer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.scRContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.scRContainer.Location = New System.Drawing.Point(0, 0)
        Me.scRContainer.Name = "scRContainer"
        Me.scRContainer.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'scRContainer.Panel1
        '
        Me.scRContainer.Panel1.BackColor = System.Drawing.Color.Firebrick
        Me.scRContainer.Panel1.Controls.Add(Me.RichTextBox1)
        Me.scRContainer.Panel1.Controls.Add(Me.lblRRemarks)
        Me.scRContainer.Panel1.Controls.Add(Me.DateTimePicker1)
        Me.scRContainer.Panel1.Controls.Add(Me.lblRDate)
        Me.scRContainer.Panel1.Controls.Add(Me.lblRDocID)
        Me.scRContainer.Panel1.Controls.Add(Me.MenuStrip3)
        '
        'scRContainer.Panel2
        '
        Me.scRContainer.Panel2.Controls.Add(Me.lvRStockData)
        Me.scRContainer.Size = New System.Drawing.Size(863, 547)
        Me.scRContainer.SplitterDistance = 124
        Me.scRContainer.TabIndex = 0
        '
        'lblRDocID
        '
        Me.lblRDocID.AutoSize = True
        Me.lblRDocID.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRDocID.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblRDocID.Location = New System.Drawing.Point(9, 12)
        Me.lblRDocID.Name = "lblRDocID"
        Me.lblRDocID.Size = New System.Drawing.Size(100, 13)
        Me.lblRDocID.TabIndex = 1
        Me.lblRDocID.Text = "Document ID  : "
        '
        'lblRDate
        '
        Me.lblRDate.AutoSize = True
        Me.lblRDate.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRDate.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblRDate.Location = New System.Drawing.Point(9, 33)
        Me.lblRDate.Name = "lblRDate"
        Me.lblRDate.Size = New System.Drawing.Size(47, 13)
        Me.lblRDate.TabIndex = 2
        Me.lblRDate.Text = "Date : "
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(60, 30)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(109, 20)
        Me.DateTimePicker1.TabIndex = 3
        '
        'lblRRemarks
        '
        Me.lblRRemarks.AutoSize = True
        Me.lblRRemarks.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRRemarks.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblRRemarks.Location = New System.Drawing.Point(567, 9)
        Me.lblRRemarks.Name = "lblRRemarks"
        Me.lblRRemarks.Size = New System.Drawing.Size(71, 13)
        Me.lblRRemarks.TabIndex = 4
        Me.lblRRemarks.Text = "Remarks : "
        '
        'RichTextBox1
        '
        Me.RichTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RichTextBox1.Location = New System.Drawing.Point(644, 6)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(209, 67)
        Me.RichTextBox1.TabIndex = 5
        Me.RichTextBox1.Text = ""
        '
        'MenuStrip3
        '
        Me.MenuStrip3.BackColor = System.Drawing.Color.Firebrick
        Me.MenuStrip3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.MenuStrip3.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbRSave, Me.ToolStripSeparator7, Me.tsbRRefreshData, Me.ToolStripSeparator8, Me.ToolStripButton4})
        Me.MenuStrip3.Location = New System.Drawing.Point(0, 97)
        Me.MenuStrip3.Name = "MenuStrip3"
        Me.MenuStrip3.Size = New System.Drawing.Size(863, 27)
        Me.MenuStrip3.TabIndex = 6
        Me.MenuStrip3.Text = "MenuStrip3"
        '
        'tsbRSave
        '
        Me.tsbRSave.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.tsbRSave.Image = CType(resources.GetObject("tsbRSave.Image"), System.Drawing.Image)
        Me.tsbRSave.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbRSave.Name = "tsbRSave"
        Me.tsbRSave.Size = New System.Drawing.Size(51, 20)
        Me.tsbRSave.Text = "Save"
        '
        'ToolStripSeparator7
        '
        Me.ToolStripSeparator7.Name = "ToolStripSeparator7"
        Me.ToolStripSeparator7.Size = New System.Drawing.Size(6, 23)
        '
        'tsbRRefreshData
        '
        Me.tsbRRefreshData.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.tsbRRefreshData.Image = CType(resources.GetObject("tsbRRefreshData.Image"), System.Drawing.Image)
        Me.tsbRRefreshData.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbRRefreshData.Name = "tsbRRefreshData"
        Me.tsbRRefreshData.Size = New System.Drawing.Size(66, 20)
        Me.tsbRRefreshData.Text = "Refresh"
        '
        'ToolStripSeparator8
        '
        Me.ToolStripSeparator8.Name = "ToolStripSeparator8"
        Me.ToolStripSeparator8.Size = New System.Drawing.Size(6, 23)
        '
        'ToolStripButton4
        '
        Me.ToolStripButton4.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.ToolStripButton4.Image = CType(resources.GetObject("ToolStripButton4.Image"), System.Drawing.Image)
        Me.ToolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton4.Name = "ToolStripButton4"
        Me.ToolStripButton4.Size = New System.Drawing.Size(67, 20)
        Me.ToolStripButton4.Text = "Receive"
        '
        'lvRStockData
        '
        Me.lvRStockData.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lvRStockData.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.chRID, Me.chRItem, Me.chRBrand, Me.chRSerial, Me.chRModel})
        Me.lvRStockData.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lvRStockData.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvRStockData.HideSelection = False
        Me.lvRStockData.Location = New System.Drawing.Point(0, 0)
        Me.lvRStockData.Name = "lvRStockData"
        Me.lvRStockData.Size = New System.Drawing.Size(863, 419)
        Me.lvRStockData.TabIndex = 0
        Me.lvRStockData.UseCompatibleStateImageBehavior = False
        Me.lvRStockData.View = System.Windows.Forms.View.Details
        '
        'chRID
        '
        Me.chRID.Text = "ID"
        '
        'chRItem
        '
        Me.chRItem.Text = "Item"
        Me.chRItem.Width = 120
        '
        'chRBrand
        '
        Me.chRBrand.Text = "Brand"
        Me.chRBrand.Width = 120
        '
        'chRSerial
        '
        Me.chRSerial.Text = "Serial"
        Me.chRSerial.Width = 120
        '
        'chRModel
        '
        Me.chRModel.Text = "Model"
        Me.chRModel.Width = 120
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1108, 608)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MainMenuStrip = Me.msLocationCount
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Main"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.tcMain.ResumeLayout(False)
        Me.tpInventory.ResumeLayout(False)
        Me.tpDeployment.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.tsMain.ResumeLayout(False)
        Me.tsMain.PerformLayout()
        Me.scDeployment.Panel1.ResumeLayout(False)
        Me.scDeployment.Panel1.PerformLayout()
        Me.scDeployment.Panel2.ResumeLayout(False)
        CType(Me.scDeployment, System.ComponentModel.ISupportInitialize).EndInit()
        Me.scDeployment.ResumeLayout(False)
        Me.msLocationCount.ResumeLayout(False)
        Me.msLocationCount.PerformLayout()
        Me.scDepContainer.Panel1.ResumeLayout(False)
        Me.scDepContainer.Panel1.PerformLayout()
        Me.scDepContainer.Panel2.ResumeLayout(False)
        CType(Me.scDepContainer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.scDepContainer.ResumeLayout(False)
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.scReceiving.Panel1.ResumeLayout(False)
        Me.scReceiving.Panel1.PerformLayout()
        Me.scReceiving.Panel2.ResumeLayout(False)
        CType(Me.scReceiving, System.ComponentModel.ISupportInitialize).EndInit()
        Me.scReceiving.ResumeLayout(False)
        Me.MenuStrip2.ResumeLayout(False)
        Me.MenuStrip2.PerformLayout()
        Me.msRDocCount.ResumeLayout(False)
        Me.msRDocCount.PerformLayout()
        Me.scRContainer.Panel1.ResumeLayout(False)
        Me.scRContainer.Panel1.PerformLayout()
        Me.scRContainer.Panel2.ResumeLayout(False)
        CType(Me.scRContainer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.scRContainer.ResumeLayout(False)
        Me.MenuStrip3.ResumeLayout(False)
        Me.MenuStrip3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents tcMain As TabControl
    Friend WithEvents tpInventory As TabPage
    Friend WithEvents tpDeployment As TabPage
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents tsMain As ToolStrip
    Friend WithEvents tslManage As ToolStripLabel
    Friend WithEvents tsbEquipment As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents ToolStripButton2 As ToolStripButton
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents ToolStripButton3 As ToolStripButton
    Friend WithEvents lvInventory As ListView
    Friend WithEvents chName As ColumnHeader
    Friend WithEvents chBrand As ColumnHeader
    Friend WithEvents chStock As ColumnHeader
    Friend WithEvents chDeployed As ColumnHeader
    Friend WithEvents chTotalStock As ColumnHeader
    Friend WithEvents scDeployment As SplitContainer
    Friend WithEvents lvLocation As ListView
    Friend WithEvents msLocationCount As MenuStrip
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents scDepContainer As SplitContainer
    Friend WithEvents ilLocationIcons As ImageList
    Friend WithEvents lblEDCount As Label
    Friend WithEvents lblLocation As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ToolStripButton6 As ToolStripButton
    Friend WithEvents ToolStripSeparator5 As ToolStripSeparator
    Friend WithEvents tsbDeployed As ToolStripButton
    Friend WithEvents ToolStripSeparator4 As ToolStripSeparator
    Friend WithEvents tsbReturn As ToolStripButton
    Friend WithEvents ListView1 As ListView
    Friend WithEvents chId As ColumnHeader
    Friend WithEvents chDName As ColumnHeader
    Friend WithEvents chDBrand As ColumnHeader
    Friend WithEvents chDSerial As ColumnHeader
    Friend WithEvents chDModel As ColumnHeader
    Friend WithEvents chDDate As ColumnHeader
    Friend WithEvents scReceiving As SplitContainer
    Friend WithEvents lvRStockControl As ListView
    Friend WithEvents MenuStrip2 As MenuStrip
    Friend WithEvents tsbRNew As ToolStripButton
    Friend WithEvents ToolStripSeparator6 As ToolStripSeparator
    Friend WithEvents tsbRRefresh As ToolStripButton
    Friend WithEvents ToolStripTextBox1 As ToolStripTextBox
    Friend WithEvents msRDocCount As MenuStrip
    Friend WithEvents tslDocCount As ToolStripLabel
    Friend WithEvents scRContainer As SplitContainer
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents lblRRemarks As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents lblRDate As Label
    Friend WithEvents lblRDocID As Label
    Friend WithEvents MenuStrip3 As MenuStrip
    Friend WithEvents tsbRSave As ToolStripButton
    Friend WithEvents ToolStripSeparator7 As ToolStripSeparator
    Friend WithEvents tsbRRefreshData As ToolStripButton
    Friend WithEvents ToolStripSeparator8 As ToolStripSeparator
    Friend WithEvents ToolStripButton4 As ToolStripButton
    Friend WithEvents lvRStockData As ListView
    Friend WithEvents chRID As ColumnHeader
    Friend WithEvents chRItem As ColumnHeader
    Friend WithEvents chRBrand As ColumnHeader
    Friend WithEvents chRSerial As ColumnHeader
    Friend WithEvents chRModel As ColumnHeader
End Class
