Public Class Master

    'MPelanggan
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        main.MainPanel.Controls.Clear()
        MPelanggan.TopLevel = False
        main.MainPanel.Controls.Add(MPelanggan)
        MPelanggan.Show()
    End Sub

    Private Sub PanelD1_Click(sender As Object, e As EventArgs) Handles PanelD1.Click
        main.MainPanel.Controls.Clear()
        MPelanggan.TopLevel = False
        main.MainPanel.Controls.Add(MPelanggan)
        MPelanggan.Show()
    End Sub

    'MLapangan
    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        main.MainPanel.Controls.Clear()
        MLapangan.TopLevel = False
        main.MainPanel.Controls.Add(MLapangan)
        MLapangan.Show()
    End Sub

    Private Sub Paneld2_Click(sender As Object, e As EventArgs) Handles Paneld2.Click
        main.MainPanel.Controls.Clear()
        MLapangan.TopLevel = False
        main.MainPanel.Controls.Add(MLapangan)
        MLapangan.Show()
    End Sub

    'MTarif
    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        main.MainPanel.Controls.Clear()
        MTarif.TopLevel = False
        main.MainPanel.Controls.Add(MTarif)
        MTarif.Show()
    End Sub

    Private Sub Paneld3_Click(sender As Object, e As EventArgs) Handles Paneld3.Click
        main.MainPanel.Controls.Clear()
        MTarif.TopLevel = False
        main.MainPanel.Controls.Add(MTarif)
        MTarif.Show()
    End Sub


End Class