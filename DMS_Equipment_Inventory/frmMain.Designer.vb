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
        Me.lvInventory = New System.Windows.Forms.ListView()
        Me.chName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chBrand = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chStock = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chDeployed = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.tpDeployment = New System.Windows.Forms.TabPage()
        Me.scDeployment = New System.Windows.Forms.SplitContainer()
        Me.lvLocation = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ilListViewIcons = New System.Windows.Forms.ImageList(Me.components)
        Me.msLocationCount = New System.Windows.Forms.MenuStrip()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.scDepContainer = New System.Windows.Forms.SplitContainer()
        Me.lblEqCount = New System.Windows.Forms.Label()
        Me.lblLocation = New System.Windows.Forms.Label()
        Me.msDeployment = New System.Windows.Forms.MenuStrip()
        Me.ToolStripButton6 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbDeploy = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbReturn = New System.Windows.Forms.ToolStripButton()
        Me.tss2 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbDefective = New System.Windows.Forms.ToolStripButton()
        Me.lvDeployedEquipments = New System.Windows.Forms.ListView()
        Me.chId = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chDName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chDBrand = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chDSerial = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chDModel = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chDDate = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.scReceiving = New System.Windows.Forms.SplitContainer()
        Me.lvEqStockControl = New System.Windows.Forms.ListView()
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.MenuStrip2 = New System.Windows.Forms.MenuStrip()
        Me.tsbNewDocu = New System.Windows.Forms.ToolStripButton()
        Me.msRDocCount = New System.Windows.Forms.MenuStrip()
        Me.tslDocCount = New System.Windows.Forms.ToolStripLabel()
        Me.scRContainer = New System.Windows.Forms.SplitContainer()
        Me.rtbEqStockControlRemarks = New System.Windows.Forms.RichTextBox()
        Me.lblRRemarks = New System.Windows.Forms.Label()
        Me.lblRDate = New System.Windows.Forms.Label()
        Me.lblEqStockControlID = New System.Windows.Forms.Label()
        Me.msReceiving = New System.Windows.Forms.MenuStrip()
        Me.tsbReceivingSave = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator8 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbReceive = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbCloseDoc = New System.Windows.Forms.ToolStripButton()
        Me.lvEqStockData = New System.Windows.Forms.ListView()
        Me.chRID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chRItem = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chRBrand = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chRSerial = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chRModel = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.tsMain = New System.Windows.Forms.ToolStrip()
        Me.tslManage = New System.Windows.Forms.ToolStripLabel()
        Me.tsbEquipment = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbBrand = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbLocation = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbClose = New System.Windows.Forms.ToolStripButton()
        Me.ilLocationIcons = New System.Windows.Forms.ImageList(Me.components)
        Me.Panel1.SuspendLayout()
        Me.tcMain.SuspendLayout()
        Me.tpInventory.SuspendLayout()
        Me.tpDeployment.SuspendLayout()
        CType(Me.scDeployment, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.scDeployment.Panel1.SuspendLayout()
        Me.scDeployment.Panel2.SuspendLayout()
        Me.scDeployment.SuspendLayout()
        Me.msLocationCount.SuspendLayout()
        CType(Me.scDepContainer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.scDepContainer.Panel1.SuspendLayout()
        Me.scDepContainer.Panel2.SuspendLayout()
        Me.scDepContainer.SuspendLayout()
        Me.msDeployment.SuspendLayout()
        Me.TabPage1.SuspendLayout()
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
        Me.msReceiving.SuspendLayout()
        Me.tsMain.SuspendLayout()
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
        Me.Panel1.Size = New System.Drawing.Size(1108, 608)
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
        Me.tcMain.Size = New System.Drawing.Size(1108, 579)
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
        Me.tpInventory.Size = New System.Drawing.Size(1100, 553)
        Me.tpInventory.TabIndex = 0
        Me.tpInventory.Text = "Inventory"
        '
        'lvInventory
        '
        Me.lvInventory.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lvInventory.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.chName, Me.chBrand, Me.chStock, Me.chDeployed, Me.ColumnHeader6, Me.ColumnHeader7, Me.ColumnHeader8})
        Me.lvInventory.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lvInventory.FullRowSelect = True
        Me.lvInventory.HideSelection = False
        Me.lvInventory.Location = New System.Drawing.Point(3, 3)
        Me.lvInventory.Name = "lvInventory"
        Me.lvInventory.Size = New System.Drawing.Size(1094, 547)
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
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Returned"
        Me.ColumnHeader6.Width = 100
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Defective"
        Me.ColumnHeader7.Width = 100
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "Total Stock"
        Me.ColumnHeader8.Width = 100
        '
        'tpDeployment
        '
        Me.tpDeployment.BackColor = System.Drawing.Color.Gray
        Me.tpDeployment.Controls.Add(Me.scDeployment)
        Me.tpDeployment.Location = New System.Drawing.Point(4, 22)
        Me.tpDeployment.Name = "tpDeployment"
        Me.tpDeployment.Padding = New System.Windows.Forms.Padding(3)
        Me.tpDeployment.Size = New System.Drawing.Size(1100, 553)
        Me.tpDeployment.TabIndex = 1
        Me.tpDeployment.Text = "Deployment"
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
        Me.scDeployment.Size = New System.Drawing.Size(1094, 547)
        Me.scDeployment.SplitterDistance = 217
        Me.scDeployment.TabIndex = 0
        '
        'lvLocation
        '
        Me.lvLocation.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2})
        Me.lvLocation.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lvLocation.FullRowSelect = True
        Me.lvLocation.HideSelection = False
        Me.lvLocation.LargeImageList = Me.ilListViewIcons
        Me.lvLocation.Location = New System.Drawing.Point(0, 0)
        Me.lvLocation.Name = "lvLocation"
        Me.lvLocation.Size = New System.Drawing.Size(217, 523)
        Me.lvLocation.SmallImageList = Me.ilListViewIcons
        Me.lvLocation.TabIndex = 1
        Me.lvLocation.UseCompatibleStateImageBehavior = False
        Me.lvLocation.View = System.Windows.Forms.View.Tile
        '
        'ilListViewIcons
        '
        Me.ilListViewIcons.ImageStream = CType(resources.GetObject("ilListViewIcons.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ilListViewIcons.TransparentColor = System.Drawing.Color.Transparent
        Me.ilListViewIcons.Images.SetKeyName(0, "document.png")
        Me.ilListViewIcons.Images.SetKeyName(1, "location.png")
        Me.ilListViewIcons.Images.SetKeyName(2, "docClose.png")
        Me.ilListViewIcons.Images.SetKeyName(3, "docOpen.png")
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
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripLabel1.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(112, 17)
        Me.ToolStripLabel1.Text = "Location Count : 0"
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
        Me.scDepContainer.Panel1.Controls.Add(Me.lblEqCount)
        Me.scDepContainer.Panel1.Controls.Add(Me.lblLocation)
        Me.scDepContainer.Panel1.Controls.Add(Me.msDeployment)
        '
        'scDepContainer.Panel2
        '
        Me.scDepContainer.Panel2.Controls.Add(Me.lvDeployedEquipments)
        Me.scDepContainer.Size = New System.Drawing.Size(873, 547)
        Me.scDepContainer.SplitterDistance = 106
        Me.scDepContainer.TabIndex = 0
        '
        'lblEqCount
        '
        Me.lblEqCount.AutoSize = True
        Me.lblEqCount.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEqCount.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblEqCount.Location = New System.Drawing.Point(8, 31)
        Me.lblEqCount.Name = "lblEqCount"
        Me.lblEqCount.Size = New System.Drawing.Size(145, 13)
        Me.lblEqCount.TabIndex = 1
        Me.lblEqCount.Text = "Equipment Deployed : 0"
        Me.lblEqCount.Visible = False
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
        'msDeployment
        '
        Me.msDeployment.BackColor = System.Drawing.Color.Firebrick
        Me.msDeployment.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.msDeployment.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.msDeployment.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton6, Me.ToolStripSeparator5, Me.tsbDeploy, Me.ToolStripSeparator4, Me.tsbReturn, Me.tss2, Me.tsbDefective})
        Me.msDeployment.Location = New System.Drawing.Point(0, 79)
        Me.msDeployment.Name = "msDeployment"
        Me.msDeployment.Size = New System.Drawing.Size(873, 27)
        Me.msDeployment.TabIndex = 2
        Me.msDeployment.Text = "MenuStrip1"
        Me.msDeployment.Visible = False
        '
        'ToolStripButton6
        '
        Me.ToolStripButton6.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.ToolStripButton6.Image = CType(resources.GetObject("ToolStripButton6.Image"), System.Drawing.Image)
        Me.ToolStripButton6.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton6.Name = "ToolStripButton6"
        Me.ToolStripButton6.Size = New System.Drawing.Size(56, 20)
        Me.ToolStripButton6.Text = "Save"
        Me.ToolStripButton6.Visible = False
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(6, 23)
        Me.ToolStripSeparator5.Visible = False
        '
        'tsbDeploy
        '
        Me.tsbDeploy.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.tsbDeploy.Image = CType(resources.GetObject("tsbDeploy.Image"), System.Drawing.Image)
        Me.tsbDeploy.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbDeploy.Name = "tsbDeploy"
        Me.tsbDeploy.Size = New System.Drawing.Size(67, 20)
        Me.tsbDeploy.Text = "Deploy"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 23)
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
        'tss2
        '
        Me.tss2.Name = "tss2"
        Me.tss2.Size = New System.Drawing.Size(6, 23)
        '
        'tsbDefective
        '
        Me.tsbDefective.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tsbDefective.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.tsbDefective.Image = CType(resources.GetObject("tsbDefective.Image"), System.Drawing.Image)
        Me.tsbDefective.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbDefective.Name = "tsbDefective"
        Me.tsbDefective.Size = New System.Drawing.Size(81, 20)
        Me.tsbDefective.Text = "Defective"
        '
        'lvDeployedEquipments
        '
        Me.lvDeployedEquipments.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.chId, Me.chDName, Me.chDBrand, Me.chDSerial, Me.chDModel, Me.chDDate})
        Me.lvDeployedEquipments.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lvDeployedEquipments.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvDeployedEquipments.FullRowSelect = True
        Me.lvDeployedEquipments.HideSelection = False
        Me.lvDeployedEquipments.Location = New System.Drawing.Point(0, 0)
        Me.lvDeployedEquipments.Name = "lvDeployedEquipments"
        Me.lvDeployedEquipments.Size = New System.Drawing.Size(873, 437)
        Me.lvDeployedEquipments.TabIndex = 0
        Me.lvDeployedEquipments.UseCompatibleStateImageBehavior = False
        Me.lvDeployedEquipments.View = System.Windows.Forms.View.Details
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
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.Gray
        Me.TabPage1.Controls.Add(Me.scReceiving)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1100, 553)
        Me.TabPage1.TabIndex = 2
        Me.TabPage1.Text = "Receiving"
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
        Me.scReceiving.Panel1.Controls.Add(Me.lvEqStockControl)
        Me.scReceiving.Panel1.Controls.Add(Me.MenuStrip2)
        Me.scReceiving.Panel1.Controls.Add(Me.msRDocCount)
        '
        'scReceiving.Panel2
        '
        Me.scReceiving.Panel2.Controls.Add(Me.scRContainer)
        Me.scReceiving.Size = New System.Drawing.Size(1094, 547)
        Me.scReceiving.SplitterDistance = 230
        Me.scReceiving.TabIndex = 0
        '
        'lvEqStockControl
        '
        Me.lvEqStockControl.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader3, Me.ColumnHeader4})
        Me.lvEqStockControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lvEqStockControl.HideSelection = False
        Me.lvEqStockControl.LargeImageList = Me.ilListViewIcons
        Me.lvEqStockControl.Location = New System.Drawing.Point(0, 27)
        Me.lvEqStockControl.Name = "lvEqStockControl"
        Me.lvEqStockControl.Size = New System.Drawing.Size(230, 496)
        Me.lvEqStockControl.SmallImageList = Me.ilListViewIcons
        Me.lvEqStockControl.TabIndex = 2
        Me.lvEqStockControl.UseCompatibleStateImageBehavior = False
        Me.lvEqStockControl.View = System.Windows.Forms.View.Tile
        '
        'MenuStrip2
        '
        Me.MenuStrip2.BackColor = System.Drawing.Color.Firebrick
        Me.MenuStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbNewDocu})
        Me.MenuStrip2.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip2.Name = "MenuStrip2"
        Me.MenuStrip2.Size = New System.Drawing.Size(230, 27)
        Me.MenuStrip2.TabIndex = 0
        Me.MenuStrip2.Text = "MenuStrip2"
        '
        'tsbNewDocu
        '
        Me.tsbNewDocu.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tsbNewDocu.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.tsbNewDocu.Image = CType(resources.GetObject("tsbNewDocu.Image"), System.Drawing.Image)
        Me.tsbNewDocu.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbNewDocu.Name = "tsbNewDocu"
        Me.tsbNewDocu.Size = New System.Drawing.Size(51, 20)
        Me.tsbNewDocu.Text = "New"
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
        Me.scRContainer.Panel1.Controls.Add(Me.rtbEqStockControlRemarks)
        Me.scRContainer.Panel1.Controls.Add(Me.lblRRemarks)
        Me.scRContainer.Panel1.Controls.Add(Me.lblRDate)
        Me.scRContainer.Panel1.Controls.Add(Me.lblEqStockControlID)
        Me.scRContainer.Panel1.Controls.Add(Me.msReceiving)
        '
        'scRContainer.Panel2
        '
        Me.scRContainer.Panel2.Controls.Add(Me.lvEqStockData)
        Me.scRContainer.Size = New System.Drawing.Size(860, 547)
        Me.scRContainer.SplitterDistance = 124
        Me.scRContainer.TabIndex = 0
        '
        'rtbEqStockControlRemarks
        '
        Me.rtbEqStockControlRemarks.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.rtbEqStockControlRemarks.Location = New System.Drawing.Point(644, 6)
        Me.rtbEqStockControlRemarks.Name = "rtbEqStockControlRemarks"
        Me.rtbEqStockControlRemarks.Size = New System.Drawing.Size(209, 67)
        Me.rtbEqStockControlRemarks.TabIndex = 5
        Me.rtbEqStockControlRemarks.Text = ""
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
        'lblEqStockControlID
        '
        Me.lblEqStockControlID.AutoSize = True
        Me.lblEqStockControlID.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEqStockControlID.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblEqStockControlID.Location = New System.Drawing.Point(9, 12)
        Me.lblEqStockControlID.Name = "lblEqStockControlID"
        Me.lblEqStockControlID.Size = New System.Drawing.Size(100, 13)
        Me.lblEqStockControlID.TabIndex = 1
        Me.lblEqStockControlID.Text = "Document ID  : "
        '
        'msReceiving
        '
        Me.msReceiving.BackColor = System.Drawing.Color.Firebrick
        Me.msReceiving.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.msReceiving.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.msReceiving.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbReceivingSave, Me.ToolStripSeparator8, Me.tsbReceive, Me.ToolStripSeparator6, Me.tsbCloseDoc})
        Me.msReceiving.Location = New System.Drawing.Point(0, 97)
        Me.msReceiving.Name = "msReceiving"
        Me.msReceiving.Size = New System.Drawing.Size(860, 27)
        Me.msReceiving.TabIndex = 1
        Me.msReceiving.Text = "MenuStrip3"
        Me.msReceiving.Visible = False
        '
        'tsbReceivingSave
        '
        Me.tsbReceivingSave.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.tsbReceivingSave.Image = CType(resources.GetObject("tsbReceivingSave.Image"), System.Drawing.Image)
        Me.tsbReceivingSave.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbReceivingSave.Name = "tsbReceivingSave"
        Me.tsbReceivingSave.Size = New System.Drawing.Size(56, 20)
        Me.tsbReceivingSave.Text = "Save"
        '
        'ToolStripSeparator8
        '
        Me.ToolStripSeparator8.Name = "ToolStripSeparator8"
        Me.ToolStripSeparator8.Size = New System.Drawing.Size(6, 23)
        '
        'tsbReceive
        '
        Me.tsbReceive.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.tsbReceive.Image = CType(resources.GetObject("tsbReceive.Image"), System.Drawing.Image)
        Me.tsbReceive.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbReceive.Name = "tsbReceive"
        Me.tsbReceive.Size = New System.Drawing.Size(72, 20)
        Me.tsbReceive.Text = "Receive"
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(6, 23)
        '
        'tsbCloseDoc
        '
        Me.tsbCloseDoc.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.tsbCloseDoc.Image = CType(resources.GetObject("tsbCloseDoc.Image"), System.Drawing.Image)
        Me.tsbCloseDoc.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbCloseDoc.Name = "tsbCloseDoc"
        Me.tsbCloseDoc.Size = New System.Drawing.Size(59, 20)
        Me.tsbCloseDoc.Text = "Close"
        '
        'lvEqStockData
        '
        Me.lvEqStockData.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lvEqStockData.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.chRID, Me.chRItem, Me.chRBrand, Me.chRSerial, Me.chRModel})
        Me.lvEqStockData.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lvEqStockData.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvEqStockData.FullRowSelect = True
        Me.lvEqStockData.HideSelection = False
        Me.lvEqStockData.Location = New System.Drawing.Point(0, 0)
        Me.lvEqStockData.Name = "lvEqStockData"
        Me.lvEqStockData.Size = New System.Drawing.Size(860, 419)
        Me.lvEqStockData.TabIndex = 0
        Me.lvEqStockData.UseCompatibleStateImageBehavior = False
        Me.lvEqStockData.View = System.Windows.Forms.View.Details
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
        'tsMain
        '
        Me.tsMain.BackColor = System.Drawing.Color.Firebrick
        Me.tsMain.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.tsMain.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tsMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tslManage, Me.tsbEquipment, Me.ToolStripSeparator1, Me.tsbBrand, Me.ToolStripSeparator2, Me.tsbLocation, Me.ToolStripSeparator3, Me.tsbClose})
        Me.tsMain.Location = New System.Drawing.Point(0, 0)
        Me.tsMain.Name = "tsMain"
        Me.tsMain.Padding = New System.Windows.Forms.Padding(3)
        Me.tsMain.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.tsMain.Size = New System.Drawing.Size(1108, 29)
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
        'tsbBrand
        '
        Me.tsbBrand.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.tsbBrand.Image = CType(resources.GetObject("tsbBrand.Image"), System.Drawing.Image)
        Me.tsbBrand.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbBrand.Name = "tsbBrand"
        Me.tsbBrand.Size = New System.Drawing.Size(61, 20)
        Me.tsbBrand.Text = "Brand"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 23)
        '
        'tsbLocation
        '
        Me.tsbLocation.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.tsbLocation.Image = CType(resources.GetObject("tsbLocation.Image"), System.Drawing.Image)
        Me.tsbLocation.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbLocation.Name = "tsbLocation"
        Me.tsbLocation.Size = New System.Drawing.Size(74, 20)
        Me.tsbLocation.Text = "Location"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 23)
        '
        'tsbClose
        '
        Me.tsbClose.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tsbClose.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbClose.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tsbClose.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.tsbClose.Image = CType(resources.GetObject("tsbClose.Image"), System.Drawing.Image)
        Me.tsbClose.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbClose.Name = "tsbClose"
        Me.tsbClose.Size = New System.Drawing.Size(23, 20)
        Me.tsbClose.Text = "X"
        '
        'ilLocationIcons
        '
        Me.ilLocationIcons.ImageStream = CType(resources.GetObject("ilLocationIcons.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ilLocationIcons.TransparentColor = System.Drawing.Color.Transparent
        Me.ilLocationIcons.Images.SetKeyName(0, "location.png")
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
        Me.msDeployment.ResumeLayout(False)
        Me.msDeployment.PerformLayout()
        Me.TabPage1.ResumeLayout(False)
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
        Me.msReceiving.ResumeLayout(False)
        Me.msReceiving.PerformLayout()
        Me.tsMain.ResumeLayout(False)
        Me.tsMain.PerformLayout()
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
    Friend WithEvents tsbBrand As ToolStripButton
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents tsbLocation As ToolStripButton
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents tsbClose As ToolStripButton
    Friend WithEvents lvInventory As ListView
    Friend WithEvents chName As ColumnHeader
    Friend WithEvents chBrand As ColumnHeader
    Friend WithEvents chStock As ColumnHeader
    Friend WithEvents chDeployed As ColumnHeader
    Friend WithEvents scDeployment As SplitContainer
    Friend WithEvents lvLocation As ListView
    Friend WithEvents msLocationCount As MenuStrip
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents scDepContainer As SplitContainer
    Friend WithEvents ilLocationIcons As ImageList
    Friend WithEvents lblEqCount As Label
    Friend WithEvents lblLocation As Label
    Friend WithEvents msDeployment As MenuStrip
    Friend WithEvents ToolStripButton6 As ToolStripButton
    Friend WithEvents ToolStripSeparator5 As ToolStripSeparator
    Friend WithEvents tsbDeploy As ToolStripButton
    Friend WithEvents ToolStripSeparator4 As ToolStripSeparator
    Friend WithEvents tsbReturn As ToolStripButton
    Friend WithEvents lvDeployedEquipments As ListView
    Friend WithEvents chId As ColumnHeader
    Friend WithEvents chDName As ColumnHeader
    Friend WithEvents chDBrand As ColumnHeader
    Friend WithEvents chDSerial As ColumnHeader
    Friend WithEvents chDModel As ColumnHeader
    Friend WithEvents chDDate As ColumnHeader
    Friend WithEvents scReceiving As SplitContainer
    Friend WithEvents lvEqStockControl As ListView
    Friend WithEvents MenuStrip2 As MenuStrip
    Friend WithEvents tsbNewDocu As ToolStripButton
    Friend WithEvents msRDocCount As MenuStrip
    Friend WithEvents tslDocCount As ToolStripLabel
    Friend WithEvents scRContainer As SplitContainer
    Friend WithEvents rtbEqStockControlRemarks As RichTextBox
    Friend WithEvents lblRRemarks As Label
    Friend WithEvents lblRDate As Label
    Friend WithEvents lblEqStockControlID As Label
    Friend WithEvents msReceiving As MenuStrip
    Friend WithEvents tsbReceivingSave As ToolStripButton
    Friend WithEvents ToolStripSeparator8 As ToolStripSeparator
    Friend WithEvents tsbReceive As ToolStripButton
    Friend WithEvents lvEqStockData As ListView
    Friend WithEvents chRID As ColumnHeader
    Friend WithEvents chRItem As ColumnHeader
    Friend WithEvents chRBrand As ColumnHeader
    Friend WithEvents chRSerial As ColumnHeader
    Friend WithEvents chRModel As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ilListViewIcons As ImageList
    Friend WithEvents tss2 As ToolStripSeparator
    Friend WithEvents tsbDefective As ToolStripButton
    Friend WithEvents ColumnHeader6 As ColumnHeader
    Friend WithEvents ColumnHeader7 As ColumnHeader
    Friend WithEvents ColumnHeader8 As ColumnHeader
    Friend WithEvents ToolStripSeparator6 As ToolStripSeparator
    Friend WithEvents tsbCloseDoc As ToolStripButton
End Class
