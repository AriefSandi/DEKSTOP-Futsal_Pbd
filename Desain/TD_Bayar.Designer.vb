<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class TD_Bayar
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TD_Bayar))
        Me.BunifuMaterialTextbox3 = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Header = New System.Windows.Forms.Panel()
        Me.ext = New Bunifu.Framework.UI.BunifuImageButton()
        Me.BunifuFlatButton1 = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.bTambah = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.BunifuMaterialTextbox2 = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.BunifuMaterialTextbox1 = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.BunifuCustomLabel1 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.Header.SuspendLayout()
        CType(Me.ext, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BunifuMaterialTextbox3
        '
        Me.BunifuMaterialTextbox3.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.BunifuMaterialTextbox3.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.BunifuMaterialTextbox3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.BunifuMaterialTextbox3.HintForeColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(144, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.BunifuMaterialTextbox3.HintText = "TANGGAL BAYAR"
        Me.BunifuMaterialTextbox3.isPassword = False
        Me.BunifuMaterialTextbox3.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.BunifuMaterialTextbox3.LineIdleColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.BunifuMaterialTextbox3.LineMouseHoverColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.BunifuMaterialTextbox3.LineThickness = 3
        Me.BunifuMaterialTextbox3.Location = New System.Drawing.Point(28, 268)
        Me.BunifuMaterialTextbox3.Margin = New System.Windows.Forms.Padding(4)
        Me.BunifuMaterialTextbox3.Name = "BunifuMaterialTextbox3"
        Me.BunifuMaterialTextbox3.Size = New System.Drawing.Size(342, 33)
        Me.BunifuMaterialTextbox3.TabIndex = 32
        Me.BunifuMaterialTextbox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Header
        '
        Me.Header.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.Header.Controls.Add(Me.ext)
        Me.Header.Dock = System.Windows.Forms.DockStyle.Top
        Me.Header.Location = New System.Drawing.Point(0, 0)
        Me.Header.Name = "Header"
        Me.Header.Size = New System.Drawing.Size(404, 19)
        Me.Header.TabIndex = 31
        '
        'ext
        '
        Me.ext.BackColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(209, Byte), Integer))
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
        'BunifuFlatButton1
        '
        Me.BunifuFlatButton1.Activecolor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.BunifuFlatButton1.BackColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.BunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuFlatButton1.BorderRadius = 5
        Me.BunifuFlatButton1.ButtonText = " Batal"
        Me.BunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray
        Me.BunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton1.Iconimage = Nothing
        Me.BunifuFlatButton1.Iconimage_right = Nothing
        Me.BunifuFlatButton1.Iconimage_right_Selected = Nothing
        Me.BunifuFlatButton1.Iconimage_Selected = Nothing
        Me.BunifuFlatButton1.IconMarginLeft = 0
        Me.BunifuFlatButton1.IconMarginRight = 0
        Me.BunifuFlatButton1.IconRightVisible = True
        Me.BunifuFlatButton1.IconRightZoom = 0R
        Me.BunifuFlatButton1.IconVisible = True
        Me.BunifuFlatButton1.IconZoom = 90.0R
        Me.BunifuFlatButton1.IsTab = False
        Me.BunifuFlatButton1.Location = New System.Drawing.Point(28, 495)
        Me.BunifuFlatButton1.Name = "BunifuFlatButton1"
        Me.BunifuFlatButton1.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.BunifuFlatButton1.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.BunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White
        Me.BunifuFlatButton1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BunifuFlatButton1.selected = False
        Me.BunifuFlatButton1.Size = New System.Drawing.Size(120, 35)
        Me.BunifuFlatButton1.TabIndex = 30
        Me.BunifuFlatButton1.Text = " Batal"
        Me.BunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.BunifuFlatButton1.Textcolor = System.Drawing.Color.White
        Me.BunifuFlatButton1.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'bTambah
        '
        Me.bTambah.Activecolor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.bTambah.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.bTambah.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bTambah.BorderRadius = 5
        Me.bTambah.ButtonText = "Tambah Data"
        Me.bTambah.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bTambah.DisabledColor = System.Drawing.Color.Gray
        Me.bTambah.ForeColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.bTambah.Iconcolor = System.Drawing.Color.Transparent
        Me.bTambah.Iconimage = Nothing
        Me.bTambah.Iconimage_right = Nothing
        Me.bTambah.Iconimage_right_Selected = Nothing
        Me.bTambah.Iconimage_Selected = Nothing
        Me.bTambah.IconMarginLeft = 0
        Me.bTambah.IconMarginRight = 0
        Me.bTambah.IconRightVisible = True
        Me.bTambah.IconRightZoom = 0R
        Me.bTambah.IconVisible = True
        Me.bTambah.IconZoom = 90.0R
        Me.bTambah.IsTab = False
        Me.bTambah.Location = New System.Drawing.Point(244, 495)
        Me.bTambah.Name = "bTambah"
        Me.bTambah.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.bTambah.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.bTambah.OnHoverTextColor = System.Drawing.Color.White
        Me.bTambah.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.bTambah.selected = False
        Me.bTambah.Size = New System.Drawing.Size(126, 35)
        Me.bTambah.TabIndex = 29
        Me.bTambah.Text = "Tambah Data"
        Me.bTambah.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.bTambah.Textcolor = System.Drawing.Color.White
        Me.bTambah.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'BunifuMaterialTextbox2
        '
        Me.BunifuMaterialTextbox2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.BunifuMaterialTextbox2.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.BunifuMaterialTextbox2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.BunifuMaterialTextbox2.HintForeColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(144, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.BunifuMaterialTextbox2.HintText = "ID SEWA"
        Me.BunifuMaterialTextbox2.isPassword = False
        Me.BunifuMaterialTextbox2.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.BunifuMaterialTextbox2.LineIdleColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.BunifuMaterialTextbox2.LineMouseHoverColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.BunifuMaterialTextbox2.LineThickness = 3
        Me.BunifuMaterialTextbox2.Location = New System.Drawing.Point(28, 215)
        Me.BunifuMaterialTextbox2.Margin = New System.Windows.Forms.Padding(4)
        Me.BunifuMaterialTextbox2.Name = "BunifuMaterialTextbox2"
        Me.BunifuMaterialTextbox2.Size = New System.Drawing.Size(342, 33)
        Me.BunifuMaterialTextbox2.TabIndex = 28
        Me.BunifuMaterialTextbox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'BunifuMaterialTextbox1
        '
        Me.BunifuMaterialTextbox1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.BunifuMaterialTextbox1.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.BunifuMaterialTextbox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.BunifuMaterialTextbox1.HintForeColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(144, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.BunifuMaterialTextbox1.HintText = "ID PEMBAYARAN"
        Me.BunifuMaterialTextbox1.isPassword = False
        Me.BunifuMaterialTextbox1.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.BunifuMaterialTextbox1.LineIdleColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.BunifuMaterialTextbox1.LineMouseHoverColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.BunifuMaterialTextbox1.LineThickness = 3
        Me.BunifuMaterialTextbox1.Location = New System.Drawing.Point(28, 159)
        Me.BunifuMaterialTextbox1.Margin = New System.Windows.Forms.Padding(4)
        Me.BunifuMaterialTextbox1.Name = "BunifuMaterialTextbox1"
        Me.BunifuMaterialTextbox1.Size = New System.Drawing.Size(342, 33)
        Me.BunifuMaterialTextbox1.TabIndex = 27
        Me.BunifuMaterialTextbox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'BunifuCustomLabel1
        '
        Me.BunifuCustomLabel1.AutoSize = True
        Me.BunifuCustomLabel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.BunifuCustomLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.BunifuCustomLabel1.Location = New System.Drawing.Point(23, 89)
        Me.BunifuCustomLabel1.Name = "BunifuCustomLabel1"
        Me.BunifuCustomLabel1.Size = New System.Drawing.Size(200, 25)
        Me.BunifuCustomLabel1.TabIndex = 26
        Me.BunifuCustomLabel1.Text = "Tambah Data Sewa"
        '
        'TD_Bayar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(404, 539)
        Me.Controls.Add(Me.BunifuMaterialTextbox3)
        Me.Controls.Add(Me.Header)
        Me.Controls.Add(Me.BunifuFlatButton1)
        Me.Controls.Add(Me.bTambah)
        Me.Controls.Add(Me.BunifuMaterialTextbox2)
        Me.Controls.Add(Me.BunifuMaterialTextbox1)
        Me.Controls.Add(Me.BunifuCustomLabel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "TD_Bayar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "TD_Bayar"
        Me.Header.ResumeLayout(False)
        CType(Me.ext, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BunifuMaterialTextbox3 As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents Header As Panel
    Friend WithEvents ext As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents BunifuFlatButton1 As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents bTambah As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents BunifuMaterialTextbox2 As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents BunifuMaterialTextbox1 As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents BunifuCustomLabel1 As Bunifu.Framework.UI.BunifuCustomLabel
End Class
