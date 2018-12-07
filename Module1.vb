Imports System.Data.SqlClient
Module Module1
    Public conn As SqlConnection
    Public data As DataSet
    Public baca As SqlDataReader
    Public adaptor As SqlDataAdapter
    Public cmd As SqlCommand
    Public ass As DataTable
    Public GetInvHeaderValue As Object
    Public sq, sql As String
    Public Sub koneksi()
        sq = "Data Source=DESKTOP-7EFEVQ9;Initial Catalog=uts;User ID=P17410100163;Password=P170163Aro"

        conn = New SqlConnection(sq)
        Try
            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If
        Catch ex As Exception
            MsgBox(Err.Description, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Public Sub tutupkoneksi()
        If conn.State = ConnectionState.Open Then
            Try
                conn.Close()
            Catch ex As Exception
                MsgBox("Gagal menutup koneksi: " & ex.ToString)
            End Try
        End If
    
    End Sub
End Module
