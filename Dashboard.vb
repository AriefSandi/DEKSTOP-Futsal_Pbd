Imports System.Data.SqlClient
Public Class Dashboard
    Private Sub Chart1_Click(sender As Object, e As EventArgs) Handles Chart1.Click

    End Sub

    Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        koneksi()
        'booking
        Dim a As String
        sql = "SELECT convert(varchar,count(*)) FROM sewa"
        cmd.CommandText = sql
        cmd.Connection = conn
        a = cmd.ExecuteScalar().ToString()
        BunifuCustomLabel5.Text = a
        'lapangan
        Dim b As String
        sql = "SELECT convert(varchar,count(*)) FROM lapangan"
        cmd.CommandText = sql
        cmd.Connection = conn
        b = cmd.ExecuteScalar().ToString()
        BunifuCustomLabel6.Text = b

        'member
        Dim c As String
        sql = "SELECT convert(varchar,count(*)) FROM pelanggan"
        cmd.CommandText = sql
        cmd.Connection = conn
        c = cmd.ExecuteScalar().ToString()
        BunifuCustomLabel7.Text = c
        tutupkoneksi()
    End Sub
End Class
