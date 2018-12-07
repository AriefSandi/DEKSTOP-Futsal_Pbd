Public Class TD_Sewa

    'L0 = 404, 539
    'L1 = 776, 539
    Private Sub BunifuFlatButton1_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton1.Click
        Me.Hide()
        BunifuMaterialTextbox1.Text = ""
        BunifuMaterialTextbox2.Text = ""
        BunifuMaterialTextbox3.Text = ""
        BunifuMaterialTextbox4.Text = ""
        BunifuMaterialTextbox5.Text = ""
        BunifuDropdown1.selectedIndex = 0
        BunifuDropdown2.selectedIndex = 0
        
    End Sub

    Private Sub BunifuFlatButton2_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton2.Click
        If Me.Width = 404 Then
            Me.Width = 776
        End If

    End Sub

    Private Sub BunifuCustomLabel1_Click(sender As Object, e As EventArgs) Handles BunifuCustomLabel1.Click

    End Sub

    Private Sub BunifuMaterialTextbox1_OnValueChanged(sender As Object, e As EventArgs) Handles BunifuMaterialTextbox1.OnValueChanged

    End Sub

    Private Sub BunifuMaterialTextbox2_OnValueChanged(sender As Object, e As EventArgs) Handles BunifuMaterialTextbox2.OnValueChanged

    End Sub

    Private Sub BunifuMaterialTextbox3_OnValueChanged(sender As Object, e As EventArgs) Handles BunifuMaterialTextbox3.OnValueChanged

    End Sub

    Private Sub Header_Paint(sender As Object, e As PaintEventArgs) Handles Header.Paint

    End Sub

    Private Sub bTambah_Click(sender As Object, e As EventArgs) Handles bTambah.Click
        If BunifuDropdown1.selectedValue = BunifuDropdown2.selectedValue Then
            MsgBox("Maaf Input Waktu Salah")
        Else
            MsgBox("data telah diinputkan ke database")
            Me.Hide()
            BunifuMaterialTextbox1.Text = ""
            BunifuMaterialTextbox2.Text = ""
            BunifuMaterialTextbox3.Text = ""
            BunifuMaterialTextbox4.Text = ""
            BunifuMaterialTextbox5.Text = ""
            BunifuDropdown1.selectedIndex = 0
            BunifuDropdown2.selectedIndex = 0
        End If
   
    End Sub
    
End Class
