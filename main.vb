Public Class main

    Dim a
    Private Sub btnMenu_Click(sender As Object, e As EventArgs) Handles btnMenu.Click
        If sidepanel.Width = 220 Then
            'untuk minimize'
            LogoTrans.HideSync(logo)
            sidepanel.Visible = False
            sidepanel.Width = 50
            btnMenu.Left = 15
            BunifuCustomLabel4.Left = 322 + 105
            BunifuCustomLabel5.Left = 265 + 105
            BunifuCustomLabel6.Left = 349 + 105
            BunifuCustomLabel8.Left = 167 + 105

            'tentang aplikasi
            TentangAplikasi.BunifuCustomLabel4.Left = 322 + 105
            TentangAplikasi.BunifuCustomLabel5.Left = 265 + 105
            TentangAplikasi.BunifuCustomLabel6.Left = 349 + 105
            TentangAplikasi.BunifuCustomLabel8.Left = 167 + 105
            TentangAplikasi.Width = 829 + 170

            'dashboard
            Dashboard.PanelD1.Left = 28
            Dashboard.Paneld2.Left = 292
            Dashboard.Paneld3.Left = 555
            Dashboard.Chart1.Width = 748 + 150
            Dashboard.Width = 829 + 170

            'master
            Master.PanelD1.Left = 28 + 70
            Master.Paneld2.Left = 292 + 90
            Master.Paneld3.Left = 555 + 110
            Master.Width = 829 + 170
            '++ master pelanggan
            MPelanggan.bTambah.Left = 28 + 70
            MPelanggan.table1.Left = 28 + 70
            MPelanggan.Width = 829 + 170
            '++ master lapangan
            MLapangan.bTambah.Left = 28 + 70
            MLapangan.table1.Left = 28 + 70
            MLapangan.Width = 829 + 170
            '++ master tarif
            MTarif.bTambah.Left = 28 + 70
            MTarif.table1.Left = 28 + 70
            MTarif.Width = 829 + 170

            'transaksi
            Transaksi.PanelD1.Left = 172 + 70
            Transaksi.Paneld2.Left = 436 + 90
            Transaksi.Width = 829 + 170
            '++ Booking
            TSewa.bTambah.Left = 28 + 70
            TSewa.table1.Left = 28 + 70
            TSewa.Width = 829 + 170
            '++ Bayar
            TBayar.bTambah.Left = 28 + 70
            TBayar.table1.Left = 28 + 70
            TBayar.Width = 829 + 170

            'laporan
            Laporan.Panel1.Left = 28 + 70
            Laporan.Width = 829 + 170



            'sync
            PanelTrans.ShowSync(sidepanel)
            MainPanel.Width = 829 + 50
        Else
            'untuk expand'
            sidepanel.Visible = False
            sidepanel.Width = 220
            btnMenu.Left = 181
            MainPanel.Width = 829
            BunifuCustomLabel4.Left = 322
            BunifuCustomLabel5.Left = 265
            BunifuCustomLabel6.Left = 349
            BunifuCustomLabel8.Left = 167
            'tentang aplikasi
            TentangAplikasi.BunifuCustomLabel4.Left = 322
            TentangAplikasi.BunifuCustomLabel5.Left = 265
            TentangAplikasi.BunifuCustomLabel6.Left = 349
            TentangAplikasi.BunifuCustomLabel8.Left = 167
            TentangAplikasi.Width = 829
            'dashboard
            Dashboard.PanelD1.Left = 28
            Dashboard.Paneld2.Left = 292
            Dashboard.Paneld3.Left = 555
            Dashboard.Chart1.Width = 748
            Dashboard.Width = 829
            'master
            Master.PanelD1.Left = 28
            Master.Paneld2.Left = 292
            Master.Paneld3.Left = 555
            Master.Width = 829
            '++ master pelanggan
            MPelanggan.bTambah.Left = 28
            MPelanggan.table1.Left = 28
            MPelanggan.Width = 829
            '++ master lapangan
            MLapangan.bTambah.Left = 28
            MLapangan.table1.Left = 28
            MLapangan.Width = 829
            '++ master tarif
            MTarif.bTambah.Left = 28
            MTarif.table1.Left = 28
            MTarif.Width = 829

            'transaksi
            Transaksi.PanelD1.Left = 172
            Transaksi.Paneld2.Left = 436
            Transaksi.Width = 829
            '++ Booking
            TSewa.bTambah.Left = 28
            TSewa.table1.Left = 28
            TSewa.Width = 829 + 170
            '++ Bayar
            TBayar.bTambah.Left = 28
            TBayar.table1.Left = 28
            TBayar.Width = 829

            'laporan
            Laporan.Panel1.Left = 28
            Laporan.Width = 829


            'sync
            PanelTrans2.ShowSync(sidepanel)
            LogoTrans.ShowSync(logo)
            mainTrans.ShowSync(MainPanel)


        End If
    End Sub

    Private Sub ext_Click(sender As Object, e As EventArgs) Handles ext.Click

        Me.Close()
        login.Close()
        TD_Lapangan.Close()
        TD_Pelanggan.Close()
        TD_Tarif.Close()
    End Sub

    Private Sub bDashboard_Click(sender As Object, e As EventArgs) Handles bDashboard.Click
        MainPanel.Controls.Clear()
        Dashboard.TopLevel = False
        MainPanel.Controls.Add(Dashboard)
        Dashboard.Show()
    End Sub

    Private Sub bMaster_Click(sender As Object, e As EventArgs) Handles bMaster.Click
        MainPanel.Controls.Clear()
        Master.TopLevel = False
        MainPanel.Controls.Add(Master)
        Master.Show()
    End Sub

    Private Sub bTransaksi_Click(sender As Object, e As EventArgs) Handles bTransaksi.Click
        MainPanel.Controls.Clear()
        Transaksi.TopLevel = False
        MainPanel.Controls.Add(Transaksi)
        Transaksi.Show()
    End Sub

    Private Sub bLaporan_Click(sender As Object, e As EventArgs) Handles bLaporan.Click
        MainPanel.Controls.Clear()
        Laporan.TopLevel = False
        MainPanel.Controls.Add(Laporan)
        Laporan.Show()
    End Sub

    Private Sub bTentang_Click(sender As Object, e As EventArgs) Handles bTentang.Click
        MainPanel.Controls.Clear()
        TentangAplikasi.TopLevel = False
        MainPanel.Controls.Add(TentangAplikasi)
        TentangAplikasi.Show()
    End Sub

    Private Sub BunifuFlatButton1_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton1.Click
        Me.Hide()
        login.BunifuMaterialTextbox1.Text = ""
        login.BunifuMaterialTextbox2.Text = ""
        login.Show()

    End Sub
End Class
