Imports System.Data.OleDb
Public Class KoneksiDatabase
    Dim Conn As OleDbConnection
    Dim Da As OleDbDataAdapter
    Dim Ds As DataSet
    Dim LokasiDB As String
    Sub Koneksi()
        LokasiDB = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=dbmahasiswa.accdb"
        Conn = New OleDbConnection(LokasiDB)
        If Conn.State = ConnectionState.Closed Then
            Conn.Open()
        End If
    End Sub

    Private Sub KoneksiDatabase_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Koneksi()
        Da = New OleDbDataAdapter("select*from TBL_MAHASISWA", Conn)
        Ds = New DataSet
        Ds.Clear()
        Da.Fill(Ds, "TBL_MAHASISWA")
        DataGridView1.DataSource = (Ds.Tables("TBL_MAHASISWA"))
    End Sub


End Class
