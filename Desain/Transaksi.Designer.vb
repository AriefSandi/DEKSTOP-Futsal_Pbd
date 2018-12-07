<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Transaksi
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Transaksi))
        Me.BunifuCustomLabel1 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.Paneld2 = New System.Windows.Forms.Panel()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.BunifuCustomLabel3 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PanelD1 = New System.Windows.Forms.Panel()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.BunifuCustomLabel2 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Paneld2.SuspendLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelD1.SuspendLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BunifuCustomLabel1
        '
        Me.BunifuCustomLabel1.AutoSize = True
        Me.BunifuCustomLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.BunifuCustomLabel1.Location = New System.Drawing.Point(21, 20)
        Me.BunifuCustomLabel1.Name = "BunifuCustomLabel1"
        Me.BunifuCustomLabel1.Size = New System.Drawing.Size(234, 37)
        Me.BunifuCustomLabel1.TabIndex = 2
        Me.BunifuCustomLabel1.Text = "Data Transaksi"
        '
        'Paneld2
        '
        Me.Paneld2.BackColor = System.Drawing.Color.White
        Me.Paneld2.Controls.Add(Me.PictureBox5)
        Me.Paneld2.Controls.Add(Me.BunifuCustomLabel3)
        Me.Paneld2.Controls.Add(Me.PictureBox2)
        Me.Paneld2.Location = New System.Drawing.Point(436, 233)
        Me.Paneld2.Name = "Paneld2"
        Me.Paneld2.Size = New System.Drawing.Size(221, 100)
        Me.Paneld2.TabIndex = 7
        '
        'PictureBox5
        '
        Me.PictureBox5.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox5.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), System.Drawing.Image)
        Me.PictureBox5.Location = New System.Drawing.Point(19, 27)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(52, 51)
        Me.PictureBox5.TabIndex = 4
        Me.PictureBox5.TabStop = False
        '
        'BunifuCustomLabel3
        '
        Me.BunifuCustomLabel3.AutoSize = True
        Me.BunifuCustomLabel3.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.BunifuCustomLabel3.Location = New System.Drawing.Point(142, 53)
        Me.BunifuCustomLabel3.Name = "BunifuCustomLabel3"
        Me.BunifuCustomLabel3.Size = New System.Drawing.Size(34, 13)
        Me.BunifuCustomLabel3.TabIndex = 2
        Me.BunifuCustomLabel3.Text = "Bayar"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.PictureBox2.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(93, 100)
        Me.PictureBox2.TabIndex = 1
        Me.PictureBox2.TabStop = False
        '
        'PanelD1
        '
        Me.PanelD1.BackColor = System.Drawing.Color.White
        Me.PanelD1.Controls.Add(Me.PictureBox4)
        Me.PanelD1.Controls.Add(Me.BunifuCustomLabel2)
        Me.PanelD1.Controls.Add(Me.PictureBox1)
        Me.PanelD1.Location = New System.Drawing.Point(172, 233)
        Me.PanelD1.Name = "PanelD1"
        Me.PanelD1.Size = New System.Drawing.Size(221, 100)
        Me.PanelD1.TabIndex = 6
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(22, 27)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(47, 48)
        Me.PictureBox4.TabIndex = 3
        Me.PictureBox4.TabStop = False
        '
        'BunifuCustomLabel2
        '
        Me.BunifuCustomLabel2.AutoSize = True
        Me.BunifuCustomLabel2.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.BunifuCustomLabel2.Location = New System.Drawing.Point(134, 53)
        Me.BunifuCustomLabel2.Name = "BunifuCustomLabel2"
        Me.BunifuCustomLabel2.Size = New System.Drawing.Size(46, 13)
        Me.BunifuCustomLabel2.TabIndex = 1
        Me.BunifuCustomLabel2.Text = "Booking"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.PictureBox1.ErrorImage = Nothing
        Me.PictureBox1.ImageLocation = ""
        Me.PictureBox1.InitialImage = Nothing
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(93, 100)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Transaksi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(829, 566)
        Me.Controls.Add(Me.Paneld2)
        Me.Controls.Add(Me.PanelD1)
        Me.Controls.Add(Me.BunifuCustomLabel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Transaksi"
        Me.Text = "Transaksi"
        Me.Paneld2.ResumeLayout(False)
        Me.Paneld2.PerformLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelD1.ResumeLayout(False)
        Me.PanelD1.PerformLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BunifuCustomLabel1 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents Paneld2 As Panel
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents BunifuCustomLabel3 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PanelD1 As Panel
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents BunifuCustomLabel2 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents PictureBox1 As PictureBox
End Class
