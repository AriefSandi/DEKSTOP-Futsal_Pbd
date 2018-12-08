Public Class Transaksi
    'booking
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        main.MainPanel.Controls.Clear()
        TSewa.TopLevel = False
        main.MainPanel.Controls.Add(TSewa)
        TSewa.Show()
    End Sub

    Private Sub PanelD1_Click(sender As Object, e As EventArgs) Handles PanelD1.Click
        main.MainPanel.Controls.Clear()
        TSewa.TopLevel = False
        main.MainPanel.Controls.Add(TSewa)
        TSewa.Show()
    End Sub

    'bayarr
    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        main.MainPanel.Controls.Clear()
        TBayar.TopLevel = False
        main.MainPanel.Controls.Add(TBayar)
        TBayar.Show()
    End Sub

    Private Sub Paneld2_Click(sender As Object, e As EventArgs) Handles Paneld2.Click
        main.MainPanel.Controls.Clear()
        TBayar.TopLevel = False
        main.MainPanel.Controls.Add(TBayar)
        TBayar.Show()
    
    
    End Sub
End Class
