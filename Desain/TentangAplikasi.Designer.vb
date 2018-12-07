<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class TentangAplikasi
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
        Me.BunifuCustomLabel8 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel6 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel5 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel4 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.SuspendLayout()
        '
        'BunifuCustomLabel8
        '
        Me.BunifuCustomLabel8.AutoSize = True
        Me.BunifuCustomLabel8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.BunifuCustomLabel8.Location = New System.Drawing.Point(167, 539)
        Me.BunifuCustomLabel8.Name = "BunifuCustomLabel8"
        Me.BunifuCustomLabel8.Size = New System.Drawing.Size(519, 16)
        Me.BunifuCustomLabel8.TabIndex = 9
        Me.BunifuCustomLabel8.Text = "Arief Prasetyo, Arief Sandi, Aldi Susanto, Catur Rochmad, Fawwaz Zuhdi, Vio Firma" &
    "nda"
        '
        'BunifuCustomLabel6
        '
        Me.BunifuCustomLabel6.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BunifuCustomLabel6.AutoSize = True
        Me.BunifuCustomLabel6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.BunifuCustomLabel6.Location = New System.Drawing.Point(349, 303)
        Me.BunifuCustomLabel6.Name = "BunifuCustomLabel6"
        Me.BunifuCustomLabel6.Size = New System.Drawing.Size(155, 24)
        Me.BunifuCustomLabel6.TabIndex = 8
        Me.BunifuCustomLabel6.Text = "Berbasis Dekstop"
        '
        'BunifuCustomLabel5
        '
        Me.BunifuCustomLabel5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BunifuCustomLabel5.AutoSize = True
        Me.BunifuCustomLabel5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.BunifuCustomLabel5.Location = New System.Drawing.Point(265, 279)
        Me.BunifuCustomLabel5.Name = "BunifuCustomLabel5"
        Me.BunifuCustomLabel5.Size = New System.Drawing.Size(322, 24)
        Me.BunifuCustomLabel5.TabIndex = 7
        Me.BunifuCustomLabel5.Text = "Aplikasi Penyewaan Lapangan Futsal"
        '
        'BunifuCustomLabel4
        '
        Me.BunifuCustomLabel4.AutoSize = True
        Me.BunifuCustomLabel4.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.BunifuCustomLabel4.Location = New System.Drawing.Point(322, 188)
        Me.BunifuCustomLabel4.Name = "BunifuCustomLabel4"
        Me.BunifuCustomLabel4.Size = New System.Drawing.Size(208, 31)
        Me.BunifuCustomLabel4.TabIndex = 6
        Me.BunifuCustomLabel4.Text = "Selamat Datang"
        '
        'TentangAplikasi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(829, 566)
        Me.Controls.Add(Me.BunifuCustomLabel8)
        Me.Controls.Add(Me.BunifuCustomLabel6)
        Me.Controls.Add(Me.BunifuCustomLabel5)
        Me.Controls.Add(Me.BunifuCustomLabel4)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "TentangAplikasi"
        Me.Text = "TentangAplikasi"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BunifuCustomLabel8 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel6 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel5 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel4 As Bunifu.Framework.UI.BunifuCustomLabel
End Class
