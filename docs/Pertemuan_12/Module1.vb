Imports System.Data.OleDb
Module Module1
    Public Conn As OleDbConnection
    Public Da As OleDbDataAdapter
    Public Ds As DataSet
    Public Cmd As OleDbCommand
    Public Rd As OleDbDataReader
    Public LokasiDB As String
    Sub Koneksi()
        LokasiDB = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=database_jualbuku.accdb"
        Conn = New OleDbConnection(LokasiDB)
        If Conn.State = ConnectionState.Closed Then
            Conn.Open()
        End If
    End Sub
End Module
