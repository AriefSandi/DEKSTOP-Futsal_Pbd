Imports System.Data.SqlClient

Public Class MLapangan
    Private Sub bTambah_Click(sender As Object, e As EventArgs) Handles bTambah.Click
        TD_Lapangan.Show()
    End Sub

    Private Sub MLapangan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        koneksi()
        sql = "select * from lapangan order by kd_lapangan"
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