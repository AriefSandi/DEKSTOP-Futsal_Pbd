Imports System.Data.SqlClient
Public Class MTarif
    Private Sub bTambah_Click(sender As Object, e As EventArgs) Handles bTambah.Click
        TD_Tarif.Show()
    End Sub

    Private Sub MTarif_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        koneksi()
        sql = "select * from tarif order by kd_tarif "
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