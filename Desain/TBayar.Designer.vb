<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TBayar
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.table1 = New Bunifu.Framework.UI.BunifuCustomDataGrid()
        Me.id_pembayaran = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id_sewa = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tanggal_bayar = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bTambah = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.BunifuCustomLabel1 = New Bunifu.Framework.UI.BunifuCustomLabel()
        CType(Me.table1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'table1
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.table1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.table1.BackgroundColor = System.Drawing.Color.Gainsboro
        Me.table1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.table1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(165, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.table1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.table1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.table1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id_pembayaran, Me.id_sewa, Me.tanggal_bayar})
        Me.table1.DoubleBuffered = True
        Me.table1.EnableHeadersVisualStyles = False
        Me.table1.HeaderBgColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.table1.HeaderForeColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.table1.Location = New System.Drawing.Point(28, 173)
        Me.table1.Name = "table1"
        Me.table1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.table1.Size = New System.Drawing.Size(745, 309)
        Me.table1.TabIndex = 10
        '
        'id_pembayaran
        '
        Me.id_pembayaran.HeaderText = "ID PEMBAYARAN"
        Me.id_pembayaran.Name = "id_pembayaran"
        Me.id_pembayaran.Width = 234
        '
        'id_sewa
        '
        Me.id_sewa.HeaderText = "ID SEWA"
        Me.id_sewa.Name = "id_sewa"
        Me.id_sewa.Width = 234
        '
        'tanggal_bayar
        '
        Me.tanggal_bayar.HeaderText = "TANGGAL BAYAR"
        Me.tanggal_bayar.Name = "tanggal_bayar"
        Me.tanggal_bayar.Width = 234
        '
        'bTambah
        '
        Me.bTambah.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.bTambah.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.bTambah.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bTambah.BorderRadius = 0
        Me.bTambah.ButtonText = "            Tambah Data"
        Me.bTambah.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bTambah.DisabledColor = System.Drawing.Color.Gray
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
        Me.bTambah.Location = New System.Drawing.Point(28, 104)
        Me.bTambah.Name = "bTambah"
        Me.bTambah.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.bTambah.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.bTambah.OnHoverTextColor = System.Drawing.Color.White
        Me.bTambah.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.bTambah.selected = False
        Me.bTambah.Size = New System.Drawing.Size(149, 35)
        Me.bTambah.TabIndex = 9
        Me.bTambah.Text = "            Tambah Data"
        Me.bTambah.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bTambah.Textcolor = System.Drawing.Color.White
        Me.bTambah.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'BunifuCustomLabel1
        '
        Me.BunifuCustomLabel1.AutoSize = True
        Me.BunifuCustomLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.BunifuCustomLabel1.Location = New System.Drawing.Point(21, 20)
        Me.BunifuCustomLabel1.Name = "BunifuCustomLabel1"
        Me.BunifuCustomLabel1.Size = New System.Drawing.Size(198, 37)
        Me.BunifuCustomLabel1.TabIndex = 8
        Me.BunifuCustomLabel1.Text = "Pembayaran"
        '
        'TBayar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(829, 566)
        Me.Controls.Add(Me.table1)
        Me.Controls.Add(Me.bTambah)
        Me.Controls.Add(Me.BunifuCustomLabel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "TBayar"
        Me.Text = "TBayar"
        CType(Me.table1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents table1 As Bunifu.Framework.UI.BunifuCustomDataGrid
    Friend WithEvents bTambah As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents BunifuCustomLabel1 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents id_pembayaran As DataGridViewTextBoxColumn
    Friend WithEvents id_sewa As DataGridViewTextBoxColumn
    Friend WithEvents tanggal_bayar As DataGridViewTextBoxColumn
End Class
