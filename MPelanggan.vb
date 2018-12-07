Imports System.Data.SqlClient
Public Class MPelanggan
    Private Sub bTambah_Click(sender As Object, e As EventArgs) Handles bTambah.Click
        TD_Pelanggan.Show()
    End Sub

    Private Sub MPelanggan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        koneksi()
        sql = "select * from pelanggan order by id_pelanggan "
        adaptor = New SqlDataAdapter(sql, conn)
        data = New DataSet
        adaptor.Fill(data)
        ass = New DataTable
        For Each ass In data.Tables
            table1.DataSource = ass
        Next
        tutupkoneksi()
    End Sub
End Class