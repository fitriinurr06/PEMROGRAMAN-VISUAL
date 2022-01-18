Imports System.Data.OleDb
Public Class DataBuku
    Sub KosongkanFrom()
        txtkodebuku.Clear()
        txtjudul.Clear()
        txtpengarang.Clear()
        txtpenerbit.Clear()
        txtjmlbuku.Clear()
        txtharga.Clear()
        txtdeskripsi.Clear()
        txtcaridata.Clear()
        cmbkodejenis.Text = ""
    End Sub
    Sub MatikanFrom()
        txtkodebuku.Enabled = False
        txtjudul.Enabled = False
        txtpengarang.Enabled = False
        txtpenerbit.Enabled = False
        txtjmlbuku.Enabled = False
        txtharga.Enabled = False
        txtdeskripsi.Enabled = False
        txtcaridata.Enabled = False
        cmbkodejenis.Enabled = False
    End Sub
    Sub HidupkanFrom()
        txtkodebuku.Enabled = True
        txtjudul.Enabled = True
        txtpengarang.Enabled = True
        txtpenerbit.Enabled = True
        txtjmlbuku.Enabled = True
        txtharga.Enabled = True
        txtdeskripsi.Enabled = True
        txtcaridata.Enabled = True
        cmbkodejenis.Enabled = True
    End Sub
    Sub AturGrid()
        DataGridView1.Columns(0).Width = 80
        DataGridView1.Columns(1).Width = 80
        DataGridView1.Columns(2).Width = 300
        DataGridView1.Columns(3).Width = 250
        DataGridView1.Columns(4).Width = 250
        DataGridView1.Columns(5).Width = 70
        DataGridView1.Columns(6).Width = 70
        DataGridView1.Columns(7).Width = 700
        DataGridView1.Columns(0).HeaderText = "Kode Buku"
        DataGridView1.Columns(1).HeaderText = "Kode Jenis"
        DataGridView1.Columns(2).HeaderText = "Judul"
        DataGridView1.Columns(3).HeaderText = "Pengarang"
        DataGridView1.Columns(4).HeaderText = "Penerbit"
        DataGridView1.Columns(5).HeaderText = "Jumlah Buku"
        DataGridView1.Columns(6).HeaderText = "Harga"
        DataGridView1.Columns(7).HeaderText = "Deskripsi"
    End Sub
    Sub TampilkanData()
        Da = New OleDbDataAdapter("select * from tb_databuku", Conn)
        Ds = New DataSet
        Ds.Clear()
        Da.Fill(Ds, "tb_databuku")
        DataGridView1.DataSource = Ds.Tables("tb_databuku")
        DataGridView1.ReadOnly = True
        DataGridView1.Refresh()
    End Sub

    Sub Ubah()
        Try
            Call Koneksi()
            Dim str As String
            str = "Update tb_databuku set Judul = '" & txtjudul.Text & "', Kode_Jenis = '" & cmbkodejenis.Text & "', Pengarang = '" & txtpengarang.Text & "', Penerbit = '" & txtpenerbit.Text & "', Jumlah_Buku = '" & txtjmlbuku.Text & "', Harga = '" & txtharga.Text & "', Deskripsi = '" & txtdeskripsi.Text & "' Where Kode_Buku = '" & txtkodebuku.Text & "'"
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
            str = "Delete * from tb_databuku where Kode_Buku = '" & txtkodebuku.Text & "'"
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
        cmbkodejenis.Items.Add("JN11001")
        cmbkodejenis.Items.Add("JP11002")
        cmbkodejenis.Items.Add("JB11003")
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

    Private Sub btnhapus_Click(sender As Object, e As EventArgs) Handles btnhapus.Click
        If MessageBox.Show("Yakin Ingin Menghapus Data Buku?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Call Hapus()
            Call TampilkanData()
            Call KosongkanFrom()
            txtkodebuku.Focus()
        End If
    End Sub

    Private Sub btnubah_Click(sender As Object, e As EventArgs) Handles btnubah.Click
        If MessageBox.Show("Yakin Ingin Mengubah Data Buku?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Call Ubah()
            Call TampilkanData()
            Call KosongkanFrom()
            txtkodebuku.Focus()
        End If
    End Sub

    Private Sub btnsimpan_Click(sender As Object, e As EventArgs) Handles btnsimpan.Click
        If txtkodebuku.Text = "" Or cmbkodejenis.Text = "" Or txtjudul.Text = "" Or txtpengarang.Text = "" Or txtpenerbit.Text = "" Or txtjmlbuku.Text = "" Or txtharga.Text = "" Or txtdeskripsi.Text = "" Then
            MsgBox("Data Belum Lengkap")
            txtkodebuku.Focus()
            Exit Sub
        Else
            Cmd = New OleDbCommand("select*from tb_databuku where Kode_Buku = '" & txtkodebuku.Text & "'", Conn)
            Rd = Cmd.ExecuteReader
            Rd.Read()
            If Not Rd.HasRows Then

                Call Koneksi()
                Dim Simpan As String
                Simpan = "insert into tb_databuku values ('" & txtkodebuku.Text & "','" & cmbkodejenis.Text & "','" & txtjudul.Text & "','" & txtpengarang.Text & "','" & txtpenerbit.Text & "','" & txtjmlbuku.Text & "','" & txtharga.Text & "','" & txtdeskripsi.Text & "')"
                Cmd = New OleDbCommand(Simpan, Conn)
                Cmd.ExecuteNonQuery()

                MsgBox("Input Data Sukses", MsgBoxStyle.Information, "Perhatian")
            Else
                MsgBox("Kode Sudah Ada")
            End If

            Call MatikanFrom()
            Call KosongkanFrom()
            Call TampilkanData()
            txtkodebuku.Focus()
        End If
    End Sub

    Private Sub txtcaridata_TextChanged(sender As Object, e As EventArgs) Handles txtcaridata.TextChanged
        Call Koneksi()
        Cmd = New OleDbCommand("select * from tb_databuku Where Judul like '%" & txtcaridata.Text & "%'", Conn)
        Rd = Cmd.ExecuteReader
        Rd.Read()
        If Rd.HasRows Then
            Call Koneksi()
            Da = New OleDbDataAdapter("select * from tb_databuku Where Judul like '%" & txtcaridata.Text & "%'", Conn)
            Ds = New DataSet
            Da.Fill(Ds, "tb_databuku")
            DataGridView1.DataSource = Ds.Tables("tb_databuku")
        Else
            MsgBox("Data Tidak Ditemukan")
        End If
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim i As Integer
        i = Me.DataGridView1.CurrentRow.Index
        With DataGridView1.Rows.Item(i)
            Me.txtkodebuku.Text = .Cells(0).Value
            Me.txtjudul.Text = .Cells(1).Value
            Me.txtpengarang.Text = .Cells(2).Value
            Me.txtpenerbit.Text = .Cells(3).Value
            Me.txtjmlbuku.Text = .Cells(4).Value
            Me.txtharga.Text = .Cells(5).Value
            Me.txtdeskripsi.Text = .Cells(6).Value
            Me.cmbkodejenis.Text = .Cells(7).Value
        End With
    End Sub

    Private Sub cmbkodejenis_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbkodejenis.SelectedIndexChanged
        If cmbkodejenis.Text = "JN11001" Then
            txtjenis.Text = "Novel"
        ElseIf cmbkodejenis.Text = "JP11002" Then
            txtjenis.Text = "Buku Pelajaran"
        ElseIf cmbkodejenis.Text = "JB11003" Then
            txtjenis.Text = "Bank Soal"
        End If
    End Sub
End Class
