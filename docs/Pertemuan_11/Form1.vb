Imports System.Data.OleDb
Public Class DataBuku
    Sub KosongkanFrom()
        txtkode.Clear()
        txtnama.Clear()
        txtharga.Clear()
        txthalaman.Clear()
    End Sub
    Sub MatikanFrom()
        txtkode.Enabled = False
        txtnama.Enabled = False
        txtharga.Enabled = False
        txthalaman.Enabled = False
    End Sub
    Sub HidupkanFrom()
        txtkode.Enabled = True
        txtnama.Enabled = True
        txtharga.Enabled = True
        txthalaman.Enabled = True
    End Sub
    Sub TampilkanData()
        Da = New OleDbDataAdapter("select*from table_buku", Conn)
        Ds = New DataSet
        Ds.Clear()
        Da.Fill(Ds, "table_buku")
        DataGridView1.DataSource = Ds.Tables("table_buku")
        DataGridView1.Refresh()
    End Sub
    Sub AturGrid()
        DataGridView1.Columns(0).Width = 100
        DataGridView1.Columns(1).Width = 200
        DataGridView1.Columns(2).Width = 70
        DataGridView1.Columns(3).Width = 80
        DataGridView1.Columns(0).HeaderText = "Kode_Buku"
        DataGridView1.Columns(1).HeaderText = "Nama_Buku"
        DataGridView1.Columns(2).HeaderText = "Harga"
        DataGridView1.Columns(3).HeaderText = "Halaman"
    End Sub
    Sub Ubah()
        Try
            Call Koneksi()
            Dim str As String
            str = "Update table_buku set Nama_Buku = '" & txtnama.Text & "', Harga = '" & txtharga.Text & "', Halaman = '" & txthalaman.Text & "' Where Kode_Buku = '" & txtkode.Text & "'"
            Cmd = New OleDbCommand(str, Conn)
            Cmd.ExecuteNonQuery()

            MessageBox.Show("Data Buku Berhasil Diubah", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Data Buku Gagal Diubah" + ex.Message)
        End Try
    End Sub
    Sub Hapus()
        Try
            Call Koneksi()
            Dim str As String
            str = "Delete * from table_buku where Kode_Buku = '" & txtkode.Text & "'"
            Cmd = New OleDbCommand(str, Conn)
            Cmd.ExecuteNonQuery()

            MessageBox.Show("Data Buku Berhasil Dihapus", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Data Buku Gagal Dihapus", "Informasi", MessageBoxButtons.OK)
        End Try
    End Sub

    Private Sub DataBuku_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Koneksi()
        Call MatikanFrom()
        Call TampilkanData()
        Call AturGrid()
    End Sub

    Private Sub btnkeluar_Click(sender As Object, e As EventArgs) Handles btnkeluar.Click
        Me.Close()
    End Sub

    Private Sub btntambah_Click(sender As Object, e As EventArgs) Handles btntambah.Click
        Call HidupkanFrom()
        Call KosongkanFrom()
    End Sub

    Private Sub btnbatal_Click(sender As Object, e As EventArgs) Handles btnbatal.Click
        Call MatikanFrom()
        Call KosongkanFrom()
    End Sub

    Private Sub btnsimpan_Click(sender As Object, e As EventArgs) Handles btnsimpan.Click
        If txtkode.Text = "" Or txtnama.Text = "" Or txtharga.Text = "" Or txthalaman.Text = "" Then
            MsgBox("Data Belum Lengkap")
            txtkode.Focus()
            Exit Sub
        Else
            Cmd = New OleDbCommand("select*from table_buku where Kode_Buku = '" & txtkode.Text & "'", Conn)
            Dr = Cmd.ExecuteReader
            Dr.Read()
            If Not Dr.HasRows Then
                Dim Simpan As String
                Simpan = "insert into table_buku values('" & txtkode.Text & "','" & txtnama.Text & "','" & txtharga.Text & "','" & txthalaman.Text & "')"
                Cmd = New OleDbCommand(Simpan, Conn)
                Cmd.ExecuteNonQuery()
                MsgBox("Input Data Sukses", MsgBoxStyle.Information, "Perhatian")
            Else
                MsgBox("Kode Sudah Ada")
            End If

            Call MatikanFrom()
            Call KosongkanFrom()
            Call TampilkanData()
            txtkode.Focus()
        End If
    End Sub

    Private Sub btnubah_Click(sender As Object, e As EventArgs) Handles btnubah.Click
        If MessageBox.Show("Yakin Ingin Mengubah Data Buku?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Call Ubah()
            Call TampilkanData()
            Call KosongkanFrom()
            txtkode.Focus()
        End If
    End Sub

    Private Sub btnhapus_Click(sender As Object, e As EventArgs) Handles btnhapus.Click
        If MessageBox.Show("Yakin Ingin Menghapus Data Buku?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Call Hapus()
            Call TampilkanData()
            Call KosongkanFrom()
            txtkode.Focus()
        End If
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim i As Integer
        i = Me.DataGridView1.CurrentRow.Index
        With DataGridView1.Rows.Item(i)
            Me.txtkode.Text = .Cells(0).Value
            Me.txtnama.Text = .Cells(1).Value
            Me.txtharga.Text = .Cells(2).Value
            Me.txthalaman.Text = .Cells(3).Value
        End With
    End Sub
End Class
