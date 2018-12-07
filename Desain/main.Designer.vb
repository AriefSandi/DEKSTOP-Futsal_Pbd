<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class main
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim Animation7 As BunifuAnimatorNS.Animation = New BunifuAnimatorNS.Animation()
        Dim Animation6 As BunifuAnimatorNS.Animation = New BunifuAnimatorNS.Animation()
        Dim Animation8 As BunifuAnimatorNS.Animation = New BunifuAnimatorNS.Animation()
        Dim Animation5 As BunifuAnimatorNS.Animation = New BunifuAnimatorNS.Animation()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(main))
        Me.Header = New System.Windows.Forms.Panel()
        Me.ext = New Bunifu.Framework.UI.BunifuImageButton()
        Me.BunifuCustomLabel1 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.sidepanel = New System.Windows.Forms.Panel()
        Me.btnMenu = New Bunifu.Framework.UI.BunifuImageButton()
        Me.logo = New System.Windows.Forms.PictureBox()
        Me.BunifuCustomLabel3 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel2 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.bTentang = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.bLaporan = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.bTransaksi = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.bMaster = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.bDashboard = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.BunifuDragControl1 = New Bunifu.Framework.UI.BunifuDragControl(Me.components)
        Me.PanelTrans = New BunifuAnimatorNS.BunifuTransition(Me.components)
        Me.MainPanel = New System.Windows.Forms.Panel()
        Me.BunifuCustomLabel8 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel6 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel5 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel4 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.LogoTrans = New BunifuAnimatorNS.BunifuTransition(Me.components)
        Me.PanelTrans2 = New BunifuAnimatorNS.BunifuTransition(Me.components)
        Me.mainTrans = New BunifuAnimatorNS.BunifuTransition(Me.components)
        Me.BunifuFlatButton1 = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.Header.SuspendLayout()
        CType(Me.ext, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.sidepanel.SuspendLayout()
        CType(Me.btnMenu, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.logo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MainPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'Header
        '
        Me.Header.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.Header.Controls.Add(Me.ext)
        Me.Header.Controls.Add(Me.BunifuCustomLabel1)
        Me.mainTrans.SetDecoration(Me.Header, BunifuAnimatorNS.DecorationType.None)
        Me.PanelTrans.SetDecoration(Me.Header, BunifuAnimatorNS.DecorationType.None)
        Me.LogoTrans.SetDecoration(Me.Header, BunifuAnimatorNS.DecorationType.None)
        Me.PanelTrans2.SetDecoration(Me.Header, BunifuAnimatorNS.DecorationType.None)
        Me.Header.Dock = System.Windows.Forms.DockStyle.Top
        Me.Header.Location = New System.Drawing.Point(0, 0)
        Me.Header.Name = "Header"
        Me.Header.Size = New System.Drawing.Size(1049, 34)
        Me.Header.TabIndex = 1
        '
        'ext
        '
        Me.ext.BackColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(209, Byte), Integer))
        Me.mainTrans.SetDecoration(Me.ext, BunifuAnimatorNS.DecorationType.None)
        Me.LogoTrans.SetDecoration(Me.ext, BunifuAnimatorNS.DecorationType.None)
        Me.PanelTrans.SetDecoration(Me.ext, BunifuAnimatorNS.DecorationType.None)
        Me.PanelTrans2.SetDecoration(Me.ext, BunifuAnimatorNS.DecorationType.None)
        Me.ext.Image = CType(resources.GetObject("ext.Image"), System.Drawing.Image)
        Me.ext.ImageActive = Nothing
        Me.ext.Location = New System.Drawing.Point(1013, 10)
        Me.ext.Name = "ext"
        Me.ext.Size = New System.Drawing.Size(15, 15)
        Me.ext.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ext.TabIndex = 2
        Me.ext.TabStop = False
        Me.ext.Zoom = 10
        '
        'BunifuCustomLabel1
        '
        Me.BunifuCustomLabel1.AutoSize = True
        Me.PanelTrans2.SetDecoration(Me.BunifuCustomLabel1, BunifuAnimatorNS.DecorationType.None)
        Me.LogoTrans.SetDecoration(Me.BunifuCustomLabel1, BunifuAnimatorNS.DecorationType.None)
        Me.mainTrans.SetDecoration(Me.BunifuCustomLabel1, BunifuAnimatorNS.DecorationType.None)
        Me.PanelTrans.SetDecoration(Me.BunifuCustomLabel1, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuCustomLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel1.Location = New System.Drawing.Point(9, 9)
        Me.BunifuCustomLabel1.Name = "BunifuCustomLabel1"
        Me.BunifuCustomLabel1.Size = New System.Drawing.Size(160, 15)
        Me.BunifuCustomLabel1.TabIndex = 1
        Me.BunifuCustomLabel1.Text = "Futsal Management System"
        '
        'sidepanel
        '
        Me.sidepanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.sidepanel.Controls.Add(Me.BunifuFlatButton1)
        Me.sidepanel.Controls.Add(Me.btnMenu)
        Me.sidepanel.Controls.Add(Me.logo)
        Me.sidepanel.Controls.Add(Me.BunifuCustomLabel3)
        Me.sidepanel.Controls.Add(Me.BunifuCustomLabel2)
        Me.sidepanel.Controls.Add(Me.bTentang)
        Me.sidepanel.Controls.Add(Me.bLaporan)
        Me.sidepanel.Controls.Add(Me.bTransaksi)
        Me.sidepanel.Controls.Add(Me.bMaster)
        Me.sidepanel.Controls.Add(Me.bDashboard)
        Me.mainTrans.SetDecoration(Me.sidepanel, BunifuAnimatorNS.DecorationType.None)
        Me.PanelTrans.SetDecoration(Me.sidepanel, BunifuAnimatorNS.DecorationType.None)
        Me.LogoTrans.SetDecoration(Me.sidepanel, BunifuAnimatorNS.DecorationType.None)
        Me.PanelTrans2.SetDecoration(Me.sidepanel, BunifuAnimatorNS.DecorationType.None)
        Me.sidepanel.Dock = System.Windows.Forms.DockStyle.Left
        Me.sidepanel.Location = New System.Drawing.Point(0, 34)
        Me.sidepanel.Name = "sidepanel"
        Me.sidepanel.Size = New System.Drawing.Size(220, 566)
        Me.sidepanel.TabIndex = 2
        '
        'btnMenu
        '
        Me.btnMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.mainTrans.SetDecoration(Me.btnMenu, BunifuAnimatorNS.DecorationType.None)
        Me.LogoTrans.SetDecoration(Me.btnMenu, BunifuAnimatorNS.DecorationType.None)
        Me.PanelTrans.SetDecoration(Me.btnMenu, BunifuAnimatorNS.DecorationType.None)
        Me.PanelTrans2.SetDecoration(Me.btnMenu, BunifuAnimatorNS.DecorationType.None)
        Me.btnMenu.Image = CType(resources.GetObject("btnMenu.Image"), System.Drawing.Image)
        Me.btnMenu.ImageActive = Nothing
        Me.btnMenu.Location = New System.Drawing.Point(181, 15)
        Me.btnMenu.Name = "btnMenu"
        Me.btnMenu.Size = New System.Drawing.Size(20, 20)
        Me.btnMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnMenu.TabIndex = 9
        Me.btnMenu.TabStop = False
        Me.btnMenu.Zoom = 10
        '
        'logo
        '
        Me.PanelTrans2.SetDecoration(Me.logo, BunifuAnimatorNS.DecorationType.None)
        Me.mainTrans.SetDecoration(Me.logo, BunifuAnimatorNS.DecorationType.None)
        Me.LogoTrans.SetDecoration(Me.logo, BunifuAnimatorNS.DecorationType.None)
        Me.PanelTrans.SetDecoration(Me.logo, BunifuAnimatorNS.DecorationType.None)
        Me.logo.Image = CType(resources.GetObject("logo.Image"), System.Drawing.Image)
        Me.logo.Location = New System.Drawing.Point(17, 70)
        Me.logo.Name = "logo"
        Me.logo.Size = New System.Drawing.Size(50, 48)
        Me.logo.TabIndex = 8
        Me.logo.TabStop = False
        '
        'BunifuCustomLabel3
        '
        Me.BunifuCustomLabel3.AutoSize = True
        Me.PanelTrans2.SetDecoration(Me.BunifuCustomLabel3, BunifuAnimatorNS.DecorationType.None)
        Me.LogoTrans.SetDecoration(Me.BunifuCustomLabel3, BunifuAnimatorNS.DecorationType.None)
        Me.mainTrans.SetDecoration(Me.BunifuCustomLabel3, BunifuAnimatorNS.DecorationType.None)
        Me.PanelTrans.SetDecoration(Me.BunifuCustomLabel3, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuCustomLabel3.Location = New System.Drawing.Point(93, 99)
        Me.BunifuCustomLabel3.Name = "BunifuCustomLabel3"
        Me.BunifuCustomLabel3.Size = New System.Drawing.Size(67, 13)
        Me.BunifuCustomLabel3.TabIndex = 7
        Me.BunifuCustomLabel3.Text = "Administrator"
        '
        'BunifuCustomLabel2
        '
        Me.BunifuCustomLabel2.AutoSize = True
        Me.PanelTrans2.SetDecoration(Me.BunifuCustomLabel2, BunifuAnimatorNS.DecorationType.None)
        Me.LogoTrans.SetDecoration(Me.BunifuCustomLabel2, BunifuAnimatorNS.DecorationType.None)
        Me.mainTrans.SetDecoration(Me.BunifuCustomLabel2, BunifuAnimatorNS.DecorationType.None)
        Me.PanelTrans.SetDecoration(Me.BunifuCustomLabel2, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuCustomLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel2.Location = New System.Drawing.Point(93, 76)
        Me.BunifuCustomLabel2.Name = "BunifuCustomLabel2"
        Me.BunifuCustomLabel2.Size = New System.Drawing.Size(66, 15)
        Me.BunifuCustomLabel2.TabIndex = 6
        Me.BunifuCustomLabel2.Text = "Arief Sandi"
        '
        'bTentang
        '
        Me.bTentang.Activecolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.bTentang.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.bTentang.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bTentang.BorderRadius = 0
        Me.bTentang.ButtonText = "     Tentang Aplikasi"
        Me.bTentang.Cursor = System.Windows.Forms.Cursors.Hand
        Me.mainTrans.SetDecoration(Me.bTentang, BunifuAnimatorNS.DecorationType.None)
        Me.LogoTrans.SetDecoration(Me.bTentang, BunifuAnimatorNS.DecorationType.None)
        Me.PanelTrans.SetDecoration(Me.bTentang, BunifuAnimatorNS.DecorationType.None)
        Me.PanelTrans2.SetDecoration(Me.bTentang, BunifuAnimatorNS.DecorationType.None)
        Me.bTentang.DisabledColor = System.Drawing.Color.Gray
        Me.bTentang.Iconcolor = System.Drawing.Color.Transparent
        Me.bTentang.Iconimage = CType(resources.GetObject("bTentang.Iconimage"), System.Drawing.Image)
        Me.bTentang.Iconimage_right = Nothing
        Me.bTentang.Iconimage_right_Selected = Nothing
        Me.bTentang.Iconimage_Selected = Nothing
        Me.bTentang.IconMarginLeft = 0
        Me.bTentang.IconMarginRight = 0
        Me.bTentang.IconRightVisible = True
        Me.bTentang.IconRightZoom = 0R
        Me.bTentang.IconVisible = True
        Me.bTentang.IconZoom = 40.0R
        Me.bTentang.IsTab = True
        Me.bTentang.Location = New System.Drawing.Point(0, 348)
        Me.bTentang.Name = "bTentang"
        Me.bTentang.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.bTentang.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(209, Byte), Integer))
        Me.bTentang.OnHoverTextColor = System.Drawing.Color.White
        Me.bTentang.selected = False
        Me.bTentang.Size = New System.Drawing.Size(220, 48)
        Me.bTentang.TabIndex = 4
        Me.bTentang.Text = "     Tentang Aplikasi"
        Me.bTentang.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bTentang.Textcolor = System.Drawing.Color.White
        Me.bTentang.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'bLaporan
        '
        Me.bLaporan.Activecolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.bLaporan.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.bLaporan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bLaporan.BorderRadius = 0
        Me.bLaporan.ButtonText = "     Laporan"
        Me.bLaporan.Cursor = System.Windows.Forms.Cursors.Hand
        Me.mainTrans.SetDecoration(Me.bLaporan, BunifuAnimatorNS.DecorationType.None)
        Me.LogoTrans.SetDecoration(Me.bLaporan, BunifuAnimatorNS.DecorationType.None)
        Me.PanelTrans.SetDecoration(Me.bLaporan, BunifuAnimatorNS.DecorationType.None)
        Me.PanelTrans2.SetDecoration(Me.bLaporan, BunifuAnimatorNS.DecorationType.None)
        Me.bLaporan.DisabledColor = System.Drawing.Color.Gray
        Me.bLaporan.Iconcolor = System.Drawing.Color.Transparent
        Me.bLaporan.Iconimage = CType(resources.GetObject("bLaporan.Iconimage"), System.Drawing.Image)
        Me.bLaporan.Iconimage_right = Nothing
        Me.bLaporan.Iconimage_right_Selected = Nothing
        Me.bLaporan.Iconimage_Selected = Nothing
        Me.bLaporan.IconMarginLeft = 0
        Me.bLaporan.IconMarginRight = 0
        Me.bLaporan.IconRightVisible = True
        Me.bLaporan.IconRightZoom = 0R
        Me.bLaporan.IconVisible = True
        Me.bLaporan.IconZoom = 40.0R
        Me.bLaporan.IsTab = True
        Me.bLaporan.Location = New System.Drawing.Point(0, 301)
        Me.bLaporan.Name = "bLaporan"
        Me.bLaporan.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.bLaporan.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(209, Byte), Integer))
        Me.bLaporan.OnHoverTextColor = System.Drawing.Color.White
        Me.bLaporan.selected = False
        Me.bLaporan.Size = New System.Drawing.Size(220, 48)
        Me.bLaporan.TabIndex = 3
        Me.bLaporan.Text = "     Laporan"
        Me.bLaporan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bLaporan.Textcolor = System.Drawing.Color.White
        Me.bLaporan.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'bTransaksi
        '
        Me.bTransaksi.Activecolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.bTransaksi.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.bTransaksi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bTransaksi.BorderRadius = 0
        Me.bTransaksi.ButtonText = "     Data Transaksi"
        Me.bTransaksi.Cursor = System.Windows.Forms.Cursors.Hand
        Me.mainTrans.SetDecoration(Me.bTransaksi, BunifuAnimatorNS.DecorationType.None)
        Me.LogoTrans.SetDecoration(Me.bTransaksi, BunifuAnimatorNS.DecorationType.None)
        Me.PanelTrans.SetDecoration(Me.bTransaksi, BunifuAnimatorNS.DecorationType.None)
        Me.PanelTrans2.SetDecoration(Me.bTransaksi, BunifuAnimatorNS.DecorationType.None)
        Me.bTransaksi.DisabledColor = System.Drawing.Color.Gray
        Me.bTransaksi.Iconcolor = System.Drawing.Color.Transparent
        Me.bTransaksi.Iconimage = CType(resources.GetObject("bTransaksi.Iconimage"), System.Drawing.Image)
        Me.bTransaksi.Iconimage_right = Nothing
        Me.bTransaksi.Iconimage_right_Selected = Nothing
        Me.bTransaksi.Iconimage_Selected = Nothing
        Me.bTransaksi.IconMarginLeft = 0
        Me.bTransaksi.IconMarginRight = 0
        Me.bTransaksi.IconRightVisible = True
        Me.bTransaksi.IconRightZoom = 0R
        Me.bTransaksi.IconVisible = True
        Me.bTransaksi.IconZoom = 40.0R
        Me.bTransaksi.IsTab = True
        Me.bTransaksi.Location = New System.Drawing.Point(0, 254)
        Me.bTransaksi.Name = "bTransaksi"
        Me.bTransaksi.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.bTransaksi.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(209, Byte), Integer))
        Me.bTransaksi.OnHoverTextColor = System.Drawing.Color.White
        Me.bTransaksi.selected = False
        Me.bTransaksi.Size = New System.Drawing.Size(220, 48)
        Me.bTransaksi.TabIndex = 2
        Me.bTransaksi.Text = "     Data Transaksi"
        Me.bTransaksi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bTransaksi.Textcolor = System.Drawing.Color.White
        Me.bTransaksi.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'bMaster
        '
        Me.bMaster.Activecolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.bMaster.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.bMaster.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bMaster.BorderRadius = 0
        Me.bMaster.ButtonText = "     Master Data"
        Me.bMaster.Cursor = System.Windows.Forms.Cursors.Hand
        Me.mainTrans.SetDecoration(Me.bMaster, BunifuAnimatorNS.DecorationType.None)
        Me.LogoTrans.SetDecoration(Me.bMaster, BunifuAnimatorNS.DecorationType.None)
        Me.PanelTrans.SetDecoration(Me.bMaster, BunifuAnimatorNS.DecorationType.None)
        Me.PanelTrans2.SetDecoration(Me.bMaster, BunifuAnimatorNS.DecorationType.None)
        Me.bMaster.DisabledColor = System.Drawing.Color.Gray
        Me.bMaster.Iconcolor = System.Drawing.Color.Transparent
        Me.bMaster.Iconimage = CType(resources.GetObject("bMaster.Iconimage"), System.Drawing.Image)
        Me.bMaster.Iconimage_right = Nothing
        Me.bMaster.Iconimage_right_Selected = Nothing
        Me.bMaster.Iconimage_Selected = Nothing
        Me.bMaster.IconMarginLeft = 0
        Me.bMaster.IconMarginRight = 0
        Me.bMaster.IconRightVisible = True
        Me.bMaster.IconRightZoom = 0R
        Me.bMaster.IconVisible = True
        Me.bMaster.IconZoom = 40.0R
        Me.bMaster.IsTab = True
        Me.bMaster.Location = New System.Drawing.Point(0, 207)
        Me.bMaster.Name = "bMaster"
        Me.bMaster.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.bMaster.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(209, Byte), Integer))
        Me.bMaster.OnHoverTextColor = System.Drawing.Color.White
        Me.bMaster.selected = False
        Me.bMaster.Size = New System.Drawing.Size(220, 48)
        Me.bMaster.TabIndex = 1
        Me.bMaster.Text = "     Master Data"
        Me.bMaster.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bMaster.Textcolor = System.Drawing.Color.White
        Me.bMaster.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'bDashboard
        '
        Me.bDashboard.Activecolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.bDashboard.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.bDashboard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bDashboard.BorderRadius = 0
        Me.bDashboard.ButtonText = "     Dashboard"
        Me.bDashboard.Cursor = System.Windows.Forms.Cursors.Hand
        Me.mainTrans.SetDecoration(Me.bDashboard, BunifuAnimatorNS.DecorationType.None)
        Me.LogoTrans.SetDecoration(Me.bDashboard, BunifuAnimatorNS.DecorationType.None)
        Me.PanelTrans.SetDecoration(Me.bDashboard, BunifuAnimatorNS.DecorationType.None)
        Me.PanelTrans2.SetDecoration(Me.bDashboard, BunifuAnimatorNS.DecorationType.None)
        Me.bDashboard.DisabledColor = System.Drawing.Color.Gray
        Me.bDashboard.Iconcolor = System.Drawing.Color.Transparent
        Me.bDashboard.Iconimage = CType(resources.GetObject("bDashboard.Iconimage"), System.Drawing.Image)
        Me.bDashboard.Iconimage_right = Nothing
        Me.bDashboard.Iconimage_right_Selected = Nothing
        Me.bDashboard.Iconimage_Selected = Nothing
        Me.bDashboard.IconMarginLeft = 0
        Me.bDashboard.IconMarginRight = 0
        Me.bDashboard.IconRightVisible = True
        Me.bDashboard.IconRightZoom = 0R
        Me.bDashboard.IconVisible = True
        Me.bDashboard.IconZoom = 40.0R
        Me.bDashboard.IsTab = True
        Me.bDashboard.Location = New System.Drawing.Point(0, 160)
        Me.bDashboard.Name = "bDashboard"
        Me.bDashboard.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.bDashboard.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(209, Byte), Integer))
        Me.bDashboard.OnHoverTextColor = System.Drawing.Color.White
        Me.bDashboard.selected = False
        Me.bDashboard.Size = New System.Drawing.Size(220, 48)
        Me.bDashboard.TabIndex = 0
        Me.bDashboard.Text = "     Dashboard"
        Me.bDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bDashboard.Textcolor = System.Drawing.Color.White
        Me.bDashboard.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'BunifuDragControl1
        '
        Me.BunifuDragControl1.Fixed = True
        Me.BunifuDragControl1.Horizontal = True
        Me.BunifuDragControl1.TargetControl = Nothing
        Me.BunifuDragControl1.Vertical = True
        '
        'PanelTrans
        '
        Me.PanelTrans.AnimationType = BunifuAnimatorNS.AnimationType.HorizSlide
        Me.PanelTrans.Cursor = Nothing
        Animation7.AnimateOnlyDifferences = True
        Animation7.BlindCoeff = CType(resources.GetObject("Animation7.BlindCoeff"), System.Drawing.PointF)
        Animation7.LeafCoeff = 0!
        Animation7.MaxTime = 1.0!
        Animation7.MinTime = 0!
        Animation7.MosaicCoeff = CType(resources.GetObject("Animation7.MosaicCoeff"), System.Drawing.PointF)
        Animation7.MosaicShift = CType(resources.GetObject("Animation7.MosaicShift"), System.Drawing.PointF)
        Animation7.MosaicSize = 0
        Animation7.Padding = New System.Windows.Forms.Padding(0)
        Animation7.RotateCoeff = 0!
        Animation7.RotateLimit = 0!
        Animation7.ScaleCoeff = CType(resources.GetObject("Animation7.ScaleCoeff"), System.Drawing.PointF)
        Animation7.SlideCoeff = CType(resources.GetObject("Animation7.SlideCoeff"), System.Drawing.PointF)
        Animation7.TimeCoeff = 0!
        Animation7.TransparencyCoeff = 0!
        Me.PanelTrans.DefaultAnimation = Animation7
        '
        'MainPanel
        '
        Me.MainPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.MainPanel.Controls.Add(Me.BunifuCustomLabel8)
        Me.MainPanel.Controls.Add(Me.BunifuCustomLabel6)
        Me.MainPanel.Controls.Add(Me.BunifuCustomLabel5)
        Me.MainPanel.Controls.Add(Me.BunifuCustomLabel4)
        Me.mainTrans.SetDecoration(Me.MainPanel, BunifuAnimatorNS.DecorationType.None)
        Me.PanelTrans.SetDecoration(Me.MainPanel, BunifuAnimatorNS.DecorationType.None)
        Me.LogoTrans.SetDecoration(Me.MainPanel, BunifuAnimatorNS.DecorationType.None)
        Me.PanelTrans2.SetDecoration(Me.MainPanel, BunifuAnimatorNS.DecorationType.None)
        Me.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MainPanel.Location = New System.Drawing.Point(220, 34)
        Me.MainPanel.Name = "MainPanel"
        Me.MainPanel.Size = New System.Drawing.Size(829, 566)
        Me.MainPanel.TabIndex = 3
        '
        'BunifuCustomLabel8
        '
        Me.BunifuCustomLabel8.AutoSize = True
        Me.PanelTrans2.SetDecoration(Me.BunifuCustomLabel8, BunifuAnimatorNS.DecorationType.None)
        Me.LogoTrans.SetDecoration(Me.BunifuCustomLabel8, BunifuAnimatorNS.DecorationType.None)
        Me.mainTrans.SetDecoration(Me.BunifuCustomLabel8, BunifuAnimatorNS.DecorationType.None)
        Me.PanelTrans.SetDecoration(Me.BunifuCustomLabel8, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuCustomLabel8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.BunifuCustomLabel8.Location = New System.Drawing.Point(167, 539)
        Me.BunifuCustomLabel8.Name = "BunifuCustomLabel8"
        Me.BunifuCustomLabel8.Size = New System.Drawing.Size(519, 16)
        Me.BunifuCustomLabel8.TabIndex = 4
        Me.BunifuCustomLabel8.Text = "Arief Prasetyo, Arief Sandi, Aldi Susanto, Catur Rochmad, Fawwaz Zuhdi, Vio Firma" &
    "nda"
        '
        'BunifuCustomLabel6
        '
        Me.BunifuCustomLabel6.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BunifuCustomLabel6.AutoSize = True
        Me.PanelTrans2.SetDecoration(Me.BunifuCustomLabel6, BunifuAnimatorNS.DecorationType.None)
        Me.LogoTrans.SetDecoration(Me.BunifuCustomLabel6, BunifuAnimatorNS.DecorationType.None)
        Me.mainTrans.SetDecoration(Me.BunifuCustomLabel6, BunifuAnimatorNS.DecorationType.None)
        Me.PanelTrans.SetDecoration(Me.BunifuCustomLabel6, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuCustomLabel6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.BunifuCustomLabel6.Location = New System.Drawing.Point(349, 303)
        Me.BunifuCustomLabel6.Name = "BunifuCustomLabel6"
        Me.BunifuCustomLabel6.Size = New System.Drawing.Size(155, 24)
        Me.BunifuCustomLabel6.TabIndex = 2
        Me.BunifuCustomLabel6.Text = "Berbasis Dekstop"
        '
        'BunifuCustomLabel5
        '
        Me.BunifuCustomLabel5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BunifuCustomLabel5.AutoSize = True
        Me.PanelTrans2.SetDecoration(Me.BunifuCustomLabel5, BunifuAnimatorNS.DecorationType.None)
        Me.LogoTrans.SetDecoration(Me.BunifuCustomLabel5, BunifuAnimatorNS.DecorationType.None)
        Me.mainTrans.SetDecoration(Me.BunifuCustomLabel5, BunifuAnimatorNS.DecorationType.None)
        Me.PanelTrans.SetDecoration(Me.BunifuCustomLabel5, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuCustomLabel5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.BunifuCustomLabel5.Location = New System.Drawing.Point(265, 279)
        Me.BunifuCustomLabel5.Name = "BunifuCustomLabel5"
        Me.BunifuCustomLabel5.Size = New System.Drawing.Size(322, 24)
        Me.BunifuCustomLabel5.TabIndex = 1
        Me.BunifuCustomLabel5.Text = "Aplikasi Penyewaan Lapangan Futsal"
        '
        'BunifuCustomLabel4
        '
        Me.BunifuCustomLabel4.AutoSize = True
        Me.PanelTrans2.SetDecoration(Me.BunifuCustomLabel4, BunifuAnimatorNS.DecorationType.None)
        Me.LogoTrans.SetDecoration(Me.BunifuCustomLabel4, BunifuAnimatorNS.DecorationType.None)
        Me.mainTrans.SetDecoration(Me.BunifuCustomLabel4, BunifuAnimatorNS.DecorationType.None)
        Me.PanelTrans.SetDecoration(Me.BunifuCustomLabel4, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuCustomLabel4.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.BunifuCustomLabel4.Location = New System.Drawing.Point(322, 188)
        Me.BunifuCustomLabel4.Name = "BunifuCustomLabel4"
        Me.BunifuCustomLabel4.Size = New System.Drawing.Size(208, 31)
        Me.BunifuCustomLabel4.TabIndex = 0
        Me.BunifuCustomLabel4.Text = "Selamat Datang"
        '
        'LogoTrans
        '
        Me.LogoTrans.AnimationType = BunifuAnimatorNS.AnimationType.VertSlide
        Me.LogoTrans.Cursor = Nothing
        Animation6.AnimateOnlyDifferences = True
        Animation6.BlindCoeff = CType(resources.GetObject("Animation6.BlindCoeff"), System.Drawing.PointF)
        Animation6.LeafCoeff = 0!
        Animation6.MaxTime = 1.0!
        Animation6.MinTime = 0!
        Animation6.MosaicCoeff = CType(resources.GetObject("Animation6.MosaicCoeff"), System.Drawing.PointF)
        Animation6.MosaicShift = CType(resources.GetObject("Animation6.MosaicShift"), System.Drawing.PointF)
        Animation6.MosaicSize = 0
        Animation6.Padding = New System.Windows.Forms.Padding(0)
        Animation6.RotateCoeff = 0!
        Animation6.RotateLimit = 0!
        Animation6.ScaleCoeff = CType(resources.GetObject("Animation6.ScaleCoeff"), System.Drawing.PointF)
        Animation6.SlideCoeff = CType(resources.GetObject("Animation6.SlideCoeff"), System.Drawing.PointF)
        Animation6.TimeCoeff = 0!
        Animation6.TransparencyCoeff = 0!
        Me.LogoTrans.DefaultAnimation = Animation6
        '
        'PanelTrans2
        '
        Me.PanelTrans2.AnimationType = BunifuAnimatorNS.AnimationType.HorizBlind
        Me.PanelTrans2.Cursor = Nothing
        Animation8.AnimateOnlyDifferences = True
        Animation8.BlindCoeff = CType(resources.GetObject("Animation8.BlindCoeff"), System.Drawing.PointF)
        Animation8.LeafCoeff = 0!
        Animation8.MaxTime = 1.0!
        Animation8.MinTime = 0!
        Animation8.MosaicCoeff = CType(resources.GetObject("Animation8.MosaicCoeff"), System.Drawing.PointF)
        Animation8.MosaicShift = CType(resources.GetObject("Animation8.MosaicShift"), System.Drawing.PointF)
        Animation8.MosaicSize = 0
        Animation8.Padding = New System.Windows.Forms.Padding(0)
        Animation8.RotateCoeff = 0!
        Animation8.RotateLimit = 0!
        Animation8.ScaleCoeff = CType(resources.GetObject("Animation8.ScaleCoeff"), System.Drawing.PointF)
        Animation8.SlideCoeff = CType(resources.GetObject("Animation8.SlideCoeff"), System.Drawing.PointF)
        Animation8.TimeCoeff = 0!
        Animation8.TransparencyCoeff = 0!
        Me.PanelTrans2.DefaultAnimation = Animation8
        '
        'mainTrans
        '
        Me.mainTrans.AnimationType = BunifuAnimatorNS.AnimationType.HorizSlide
        Me.mainTrans.Cursor = Nothing
        Animation5.AnimateOnlyDifferences = True
        Animation5.BlindCoeff = CType(resources.GetObject("Animation5.BlindCoeff"), System.Drawing.PointF)
        Animation5.LeafCoeff = 0!
        Animation5.MaxTime = 1.0!
        Animation5.MinTime = 0!
        Animation5.MosaicCoeff = CType(resources.GetObject("Animation5.MosaicCoeff"), System.Drawing.PointF)
        Animation5.MosaicShift = CType(resources.GetObject("Animation5.MosaicShift"), System.Drawing.PointF)
        Animation5.MosaicSize = 0
        Animation5.Padding = New System.Windows.Forms.Padding(0)
        Animation5.RotateCoeff = 0!
        Animation5.RotateLimit = 0!
        Animation5.ScaleCoeff = CType(resources.GetObject("Animation5.ScaleCoeff"), System.Drawing.PointF)
        Animation5.SlideCoeff = CType(resources.GetObject("Animation5.SlideCoeff"), System.Drawing.PointF)
        Animation5.TimeCoeff = 0!
        Animation5.TransparencyCoeff = 0!
        Me.mainTrans.DefaultAnimation = Animation5
        '
        'BunifuFlatButton1
        '
        Me.BunifuFlatButton1.Activecolor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BunifuFlatButton1.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.BunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuFlatButton1.BorderRadius = 0
        Me.BunifuFlatButton1.ButtonText = "     LOGOUT"
        Me.BunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.mainTrans.SetDecoration(Me.BunifuFlatButton1, BunifuAnimatorNS.DecorationType.None)
        Me.LogoTrans.SetDecoration(Me.BunifuFlatButton1, BunifuAnimatorNS.DecorationType.None)
        Me.PanelTrans.SetDecoration(Me.BunifuFlatButton1, BunifuAnimatorNS.DecorationType.None)
        Me.PanelTrans2.SetDecoration(Me.BunifuFlatButton1, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray
        Me.BunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton1.Iconimage = CType(resources.GetObject("BunifuFlatButton1.Iconimage"), System.Drawing.Image)
        Me.BunifuFlatButton1.Iconimage_right = Nothing
        Me.BunifuFlatButton1.Iconimage_right_Selected = Nothing
        Me.BunifuFlatButton1.Iconimage_Selected = Nothing
        Me.BunifuFlatButton1.IconMarginLeft = 0
        Me.BunifuFlatButton1.IconMarginRight = 0
        Me.BunifuFlatButton1.IconRightVisible = True
        Me.BunifuFlatButton1.IconRightZoom = 0R
        Me.BunifuFlatButton1.IconVisible = True
        Me.BunifuFlatButton1.IconZoom = 40.0R
        Me.BunifuFlatButton1.IsTab = True
        Me.BunifuFlatButton1.Location = New System.Drawing.Point(0, 519)
        Me.BunifuFlatButton1.Name = "BunifuFlatButton1"
        Me.BunifuFlatButton1.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.BunifuFlatButton1.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White
        Me.BunifuFlatButton1.selected = False
        Me.BunifuFlatButton1.Size = New System.Drawing.Size(220, 48)
        Me.BunifuFlatButton1.TabIndex = 10
        Me.BunifuFlatButton1.Text = "     LOGOUT"
        Me.BunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BunifuFlatButton1.Textcolor = System.Drawing.Color.White
        Me.BunifuFlatButton1.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(1049, 600)
        Me.Controls.Add(Me.MainPanel)
        Me.Controls.Add(Me.sidepanel)
        Me.Controls.Add(Me.Header)
        Me.PanelTrans2.SetDecoration(Me, BunifuAnimatorNS.DecorationType.None)
        Me.mainTrans.SetDecoration(Me, BunifuAnimatorNS.DecorationType.None)
        Me.PanelTrans.SetDecoration(Me, BunifuAnimatorNS.DecorationType.None)
        Me.LogoTrans.SetDecoration(Me, BunifuAnimatorNS.DecorationType.None)
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.Header.ResumeLayout(False)
        Me.Header.PerformLayout()
        CType(Me.ext, System.ComponentModel.ISupportInitialize).EndInit()
        Me.sidepanel.ResumeLayout(False)
        Me.sidepanel.PerformLayout()
        CType(Me.btnMenu, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.logo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MainPanel.ResumeLayout(False)
        Me.MainPanel.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Header As Panel
    Friend WithEvents sidepanel As Panel
    Friend WithEvents bTentang As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents bLaporan As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents bTransaksi As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents bMaster As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents bDashboard As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents BunifuCustomLabel1 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents logo As PictureBox
    Friend WithEvents BunifuCustomLabel3 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel2 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuDragControl1 As Bunifu.Framework.UI.BunifuDragControl
    Friend WithEvents LogoTrans As BunifuAnimatorNS.BunifuTransition
    Friend WithEvents PanelTrans As BunifuAnimatorNS.BunifuTransition
    Friend WithEvents btnMenu As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents PanelTrans2 As BunifuAnimatorNS.BunifuTransition
    Friend WithEvents MainPanel As Panel
    Friend WithEvents ext As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents mainTrans As BunifuAnimatorNS.BunifuTransition
    Friend WithEvents BunifuCustomLabel4 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel6 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel5 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel8 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuFlatButton1 As Bunifu.Framework.UI.BunifuFlatButton

End Class
