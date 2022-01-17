Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbjeniskamar.Items.Add("VIP")
        cmbjeniskamar.Items.Add("Kelas I")
        cmbjeniskamar.Items.Add("Kelas II")
        cmbjeniskamar.Items.Add("Kelas III")

    End Sub

    Private Sub cmbjeniskamar_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbjeniskamar.SelectedIndexChanged
        If cmbjeniskamar.Text = "VIP" Then
            txthargasewa.Text = 750000
        ElseIf cmbjeniskamar.Text = "Kelas I" Then
            txthargasewa.Text = 500000
        ElseIf cmbjeniskamar.Text = "Kelas II" Then
            txthargasewa.Text = 300000
        ElseIf cmbjeniskamar.Text = "Kelas III" Then
            txthargasewa.Text = 150000
        End If
    End Sub

    Private Sub btntotalsewa_Click(sender As Object, e As EventArgs) Handles btntotalsewa.Click
        txttotalsewa.Text = Val(txthargasewa.Text) * Val(txtlamamenginap.Text)
    End Sub

    Private Sub btnkembalian_Click(sender As Object, e As EventArgs) Handles btnkembalian.Click
        txtkembalian.Text = txtpembayaran.Text - txttotalsewa.Text
    End Sub

    Private Sub btnrefresh_Click(sender As Object, e As EventArgs) Handles btnrefresh.Click
        txtnoktp.ResetText()
        txtnama.ResetText()
        cmbjeniskamar.ResetText()
        txthargasewa.ResetText()
        txtlamamenginap.ResetText()
        txttotalsewa.ResetText()
        txtpembayaran.ResetText()
        txtkembalian.ResetText()
    End Sub
End Class
