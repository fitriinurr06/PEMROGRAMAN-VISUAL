Public Class ArrayMultiDimensi
    Private Sub ArrayMultiDimensi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim Arr(3, 1) As String
        Arr(0, 0) = "Nomor Induk Mahasiswa"
        Arr(0, 1) = "Nama Mahasiswa"
        Arr(1, 0) = "Jenis Kelamin"
        Arr(1, 1) = "Program Studi"
        Arr(2, 0) = "Laki-laki"
        Arr(2, 1) = "Perempuan"
        Arr(3, 0) = "Sistem Infomrasi"
        Arr(3, 1) = "Sistem Komputer"

        ListView.GridLines = True
        ListView.View = View.Details

        For Baris = 0 To 1
            For Kolom = 0 To 1
                ListView.Columns.Add(Arr(Baris, Kolom), 150)
            Next Kolom
        Next Baris

        For Baris = 2 To 2
            For Kolom = 0 To 1
                cmbjk.Items.Add(Arr(Baris, Kolom))
            Next Kolom
        Next Baris

        For Baris = 3 To 3
            For Kolom = 0 To 1
                cmbps.Items.Add(Arr(Baris, Kolom))
            Next Kolom
        Next Baris
    End Sub

    Private Sub btntambah_Click(sender As Object, e As EventArgs) Handles btntambah.Click
        Dim Arr(3) As String
        Arr(0) = txtnim.Text
        Arr(1) = txtnama.Text
        Arr(2) = cmbjk.Text
        Arr(3) = cmbps.Text

        Dim ListItem As ListViewItem
        ListItem = New ListViewItem
        ListItem = ListView.Items.Add(Arr(0))
        ListItem.SubItems.Add(Arr(1))
        ListItem.SubItems.Add(Arr(2))
        ListItem.SubItems.Add(Arr(3))
        txtnim.Text = txtnim.Text + 1
        txtnama.Text = ""
        cmbjk.Text = ""
        cmbps.Text = ""
        txtnama.Focus()
    End Sub

    Private Sub btnkeluar_Click(sender As Object, e As EventArgs) Handles btnkeluar.Click
        End
    End Sub
End Class
