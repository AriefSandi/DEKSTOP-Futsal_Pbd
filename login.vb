Imports System.Data.SqlClient
Public Class login
    'posisi kanan = 436, 0


    Private Sub login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BunifuFlatButton3_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton3.Click


        For i As Integer = 0 To 218
            Panel1.Location = New Point(Panel1.Location.X + 2, Panel1.Location.Y)
            BunifuCustomLabel3.Text = "LOGIN STAFF"
            BunifuMaterialTextbox1.Text = ""
            BunifuMaterialTextbox2.Text = ""
        Next
    End Sub

    Private Sub BunifuFlatButton1_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton1.Click


        For i As Integer = 0 To 218
            Panel1.Location = New Point(Panel1.Location.X - 2, Panel1.Location.Y)
            BunifuCustomLabel3.Text = "LOGIN ADMIN"
            BunifuMaterialTextbox1.Text = ""
            BunifuMaterialTextbox2.Text = ""
        Next
    End Sub

    Private Sub BunifuFlatButton2_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton2.Click
        Dim sql, user, password As String
        user = BunifuMaterialTextbox1.Text
        password = BunifuMaterialTextbox2.Text

        Call koneksi()

        'login admin
        If Panel1.Location.X < 436 Then
            sql = "SELECT * FROM adm_staff WHERE id_staff='" + user + "' AND password_staff='" + password + "'and id_status = 1"
            cmd = New SqlCommand(sql, conn)
            baca = cmd.ExecuteReader
            baca.Read()

            If baca.HasRows = True Then
                Dim a As String = BunifuMaterialTextbox1.Text
                Dim b As String = "Admin"
                main.BunifuCustomLabel3.Text = "Administrator"
                main.BunifuCustomLabel2.Text = BunifuMaterialTextbox1.Text

                MessageBox.Show("Selamat Datang " & b & " " & a)
                main.Show()
                Me.Hide()
                tutupkoneksi()
            Else
                MessageBox.Show("Kombinasi Username dan Password Salah", "Konfirmasi", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
            'login staff
        ElseIf Panel1.Location.X = 436 Then
            sql = "SELECT * FROM adm_staff WHERE id_staff='" + user + "' AND password_staff='" + password + "'and id_status = 2"
            cmd = New SqlCommand(sql, conn)
            baca = cmd.ExecuteReader
            baca.Read()

            If baca.HasRows = True Then
                Dim a As String = BunifuMaterialTextbox1.Text
                Dim b As String = "Staff"
                main.BunifuCustomLabel3.Text = "Staff"
                main.BunifuCustomLabel2.Text = BunifuMaterialTextbox1.Text

                MessageBox.Show("Selamat Datang " & b & " " & a)
                main.Show()
                Me.Hide()
                tutupkoneksi()
            Else
                MessageBox.Show("Kombinasi Username dan Password Salah", "Konfirmasi", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub
End Class
