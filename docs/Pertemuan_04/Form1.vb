Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbjenismakanan.Items.Add("Soto")
        cmbjenismakanan.Items.Add("Ayam")
        cmbjenismakanan.Items.Add("Nasi Goreng")
    End Sub

    Private Sub cmbjenismakanan_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbjenismakanan.SelectedIndexChanged
        If cmbjenismakanan.Text = "Soto" Then
            cmbnmmakanan.Items.Clear()
            cmbnmmakanan.Text = ""
            cmbnmmakanan.Items.Add("Soto Lamongan")
            cmbnmmakanan.Items.Add("Soto Betawi")
            cmbnmmakanan.Items.Add("Soto Mie Bogor")

        ElseIf cmbjenismakanan.Text = "Ayam" Then
            cmbnmmakanan.Items.Clear()
            cmbnmmakanan.Text = ""
            cmbnmmakanan.Items.Add("Ayam Goreng")
            cmbnmmakanan.Items.Add("Ayam Geprek")
            cmbnmmakanan.Items.Add("Ayam Bakar")

        ElseIf cmbjenismakanan.Text = "Nasi Goreng" Then
            cmbnmmakanan.Items.Clear()
            cmbnmmakanan.Text = ""
            cmbnmmakanan.Items.Add("Nasi Goreng Jawa")
            cmbnmmakanan.Items.Add("Nas Goreng Pete")
            cmbnmmakanan.Items.Add("Nasi Goreng Seafood")
        End If
    End Sub

    Private Sub cmbnmmakanan_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbnmmakanan.SelectedIndexChanged
        If cmbnmmakanan.Text = "Soto Lamongan" Then
            txtharga.Text = 17000
        ElseIf cmbnmmakanan.Text = "Soto Betawi" Then
            txtharga.Text = 18000
        ElseIf cmbnmmakanan.Text = "Soto Mie Bogor" Then
            txtharga.Text = 18000
        ElseIf cmbnmmakanan.Text = "Ayam Goreng" Then
            txtharga.Text = 25000
        ElseIf cmbnmmakanan.Text = "Ayam Geprek" Then
            txtharga.Text = 20000
        ElseIf cmbnmmakanan.Text = "Ayam Bakar" Then
            txtharga.Text = 28000
        ElseIf cmbnmmakanan.Text = "Nasi Goreng Jawa" Then
            txtharga.Text = 12000
        ElseIf cmbnmmakanan.Text = "Nasi Goreng Pete" Then
            txtharga.Text = 15000
        ElseIf cmbnmmakanan.Text = "Nasi Goreng Seafood" Then
            txtharga.Text = 30000
        End If
    End Sub

    Private Sub btnhitung_Click(sender As Object, e As EventArgs) Handles btnhitung.Click
        txttotalharga.Text = Val(txtharga.Text) * Val(txtjumlah.Text)
    End Sub

    Private Sub btnhitungkembalian_Click(sender As Object, e As EventArgs) Handles btnhitungkembalian.Click
        txtkembalian.Text = txtuang.Text - txttotalharga.Text
    End Sub

    Private Sub btnrefresh_Click(sender As Object, e As EventArgs) Handles btnrefresh.Click
        cmbjenismakanan.ResetText()
        cmbnmmakanan.ResetText()
        txtharga.ResetText()
        txtjumlah.ResetText()
        txttotalharga.ResetText()
        txtuang.ResetText()
        txtkembalian.ResetText()
    End Sub
End Class
