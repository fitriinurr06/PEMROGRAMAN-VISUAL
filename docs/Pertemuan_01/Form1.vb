Imports System.Data.OleDb
Public Class DataKaryawan
    Sub KosongkanFrom()
        txtkode.Clear()
        txtnama.Clear()
        txtalamat.Clear()
        txtposisi.Clear()
        txtgaji.Clear()
        cmbjenis.Text = ""
    End Sub
    Sub MatikanFrom()
        txtkode.Enabled = False
        txtnama.Enabled = False
        txtalamat.Enabled = False
        txtposisi.Enabled = False
        txtgaji.Enabled = False
        cmbjenis.Enabled = False
    End Sub
    Sub HidupkanFrom()
        txtkode.Enabled = True
        txtnama.Enabled = True
        txtalamat.Enabled = True
        txtposisi.Enabled = True
        txtgaji.Enabled = True
        cmbjenis.Enabled = True
    End Sub
    Sub AturGrid()
        DataGridView1.Columns(0).Width = 120
        DataGridView1.Columns(1).Width = 150
        DataGridView1.Columns(2).Width = 100
        DataGridView1.Columns(3).Width = 80
        DataGridView1.Columns(4).Width = 80
        DataGridView1.Columns(5).Width = 80
        DataGridView1.Columns(0).HeaderText = "Kode_Karyawan"
        DataGridView1.Columns(1).HeaderText = "Nama_Karyawan"
        DataGridView1.Columns(2).HeaderText = "Alamat"
        DataGridView1.Columns(3).HeaderText = "Posisi"
        DataGridView1.Columns(4).HeaderText = "Jenis_Kelamin"
        DataGridView1.Columns(5).HeaderText = "Gaji_Perbulan"
    End Sub
    Sub TampilkanData()
        Da = New OleDbDataAdapter("select * from tb_karyawan", Conn)
        Ds = New DataSet
        Ds.Clear()
        Da.Fill(Ds, "tb_karyawan")
        DataGridView1.DataSource = Ds.Tables("tb_karyawan")
        DataGridView1.ReadOnly = True
        DataGridView1.Refresh()
    End Sub
    Sub Ubah()
        Try
            Call Koneksi()
            Dim str As String
            str = "Update tb_karyawan set Nama_Karyawan = '" & txtnama.Text & "', Alamat = '" & txtalamat.Text & "', Posisi = '" & txtposisi.Text & "', Jenis_Kelamin = '" & cmbjenis.Text & "', Gaji_Perbulan = '" & txtgaji.Text & "' Where Kode_Karyawan = '" & txtkode.Text & "'"
            Cmd = New OleDbCommand(str, Conn)
            Cmd.ExecuteNonQuery()

            MessageBox.Show("Data Karyawan Berhasil Diubah", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Data Karyawan Gagal Diubah" + ex.Message)
        End Try
    End Sub
    Sub Hapus()
        Try
            Call Koneksi()
            Dim str As String
            str = "Delete * from tb_karyawan where Kode_Karyawan = '" & txtkode.Text & "'"
            Cmd = New OleDbCommand(str, Conn)
            Cmd.ExecuteNonQuery()

            MessageBox.Show("Data Karyawan Berhasil Dihapus", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Data Karyawan Gagal Dihapus", "Informasi", MessageBoxButtons.OK)
        End Try
    End Sub
    Private Sub DataKaryawan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Koneksi()
        Call MatikanFrom()
        Call TampilkanData()
        Call AturGrid()
        cmbjenis.Items.Add("Laki-laki")
        cmbjenis.Items.Add("Perempuan")
    End Sub

    Private Sub btntambah_Click(sender As Object, e As EventArgs) Handles btntambah.Click
        Call HidupkanFrom()
        Call KosongkanFrom()
    End Sub

    Private Sub btnbatal_Click(sender As Object, e As EventArgs) Handles btnbatal.Click
        Me.Close()
    End Sub

    Private Sub btnhapus_Click(sender As Object, e As EventArgs) Handles btnhapus.Click
        If MessageBox.Show("Yakin Ingin Menghapus Data Karyawan?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Call Hapus()
            Call TampilkanData()
            Call KosongkanFrom()
            txtkode.Focus()
        End If
    End Sub

    Private Sub btnubah_Click(sender As Object, e As EventArgs) Handles btnubah.Click
        If MessageBox.Show("Yakin Ingin Mengubah Data Karyawan?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Call Ubah()
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
            Me.txtalamat.Text = .Cells(2).Value
            Me.txtposisi.Text = .Cells(3).Value
            Me.cmbjenis.Text = .Cells(4).Value
            Me.txtgaji.Text = .Cells(5).Value
        End With
    End Sub

    Private Sub btnsimpan_Click(sender As Object, e As EventArgs) Handles btnsimpan.Click
        If txtkode.Text = "" Or txtnama.Text = "" Or txtalamat.Text = "" Or txtposisi.Text = "" Or cmbjenis.Text = "" Or txtgaji.Text = "" Then
            MsgBox("Data Karyawan Belum Lengkap")
            txtkode.Focus()
            Exit Sub
        Else
            Cmd = New OleDbCommand("select*from tb_karyawan where Kode_Karyawan = '" & txtkode.Text & "'", Conn)
            Rd = Cmd.ExecuteReader
            Rd.Read()
            If Not Rd.HasRows Then

                Call Koneksi()
                Dim Simpan As String
                Simpan = "insert into tb_karyawan values ('" & txtkode.Text & "','" & txtnama.Text & "','" & txtalamat.Text & "','" & txtposisi.Text & "','" & cmbjenis.Text & "','" & txtgaji.Text & "')"
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

    Private Sub btnlaporan_Click(sender As Object, e As EventArgs) Handles btnlaporan.Click

    End Sub
End Class
