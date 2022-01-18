Imports System.Data.OleDb
Module Module1
    Public Conn As OleDbConnection
    Public Da As OleDbDataAdapter
    Public Ds As DataSet
    Public Cmd As OleDbCommand
    Public Dr As OleDbDataReader
    Sub Koneksi()
        Try
            Conn = New OleDbConnection("provider=microsoft.ace.oledb.12.0; data source=db_databuku.accdb;")
            Conn.Open()
            MsgBox("Koneksi Database Sukses")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Module
