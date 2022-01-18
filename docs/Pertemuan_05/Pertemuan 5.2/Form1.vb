Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbnamamakanan.Items.Add("Kimchi Cabbage")
        cmbnamamakanan.Items.Add("Kimbap")
        cmbnamamakanan.Items.Add("Japchae")
        cmbnamamakanan.Items.Add("Bulgogi")
        cmbnamamakanan.Items.Add("Rabokki")
        cmbnamaminuman.Items.Add("Americano")
        cmbnamaminuman.Items.Add("Milk Shake Taro")
        cmbnamaminuman.Items.Add("Milk Shake Chocolate")
        cmbnamaminuman.Items.Add("Cappucino Ice")
    End Sub

    Private Sub cmbnamamakanan_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbnamamakanan.SelectedIndexChanged
        If cmbnamamakanan.Text = "Kimchi Cabbage" Then
            txthargamakanan.Text = 50000
        ElseIf cmbnamamakanan.Text = "Kimbap" Then
            txthargamakanan.Text = 45000
        ElseIf cmbnamamakanan.Text = "Japchae" Then
            txthargamakanan.Text = 30000
        ElseIf cmbnamamakanan.Text = "Bulgogi" Then
            txthargamakanan.Text = 40000
        ElseIf cmbnamamakanan.Text = "Rabboki" Then
            txthargamakanan.Text = 47000
        End If
    End Sub

    Private Sub cmbnamaminuman_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbnamaminuman.SelectedIndexChanged
        If cmbnamaminuman.Text = "Americano" Then
            txthargaminuman.Text = 30000
        ElseIf cmbnamaminuman.Text = "Milk Shake Taro" Then
            txthargaminuman.Text = 20000
        ElseIf cmbnamaminuman.Text = "Milk Shake Chocolate" Then
            txthargaminuman.Text = 30000
        ElseIf cmbnamaminuman.Text = "Cappucino Ice" Then
            txthargaminuman.Text = 35000
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        txttotalhargamakanan.Text = Val(txthargamakanan.Text) * Val(txtjumlahmakanan.Text)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        txttotalhargaminuman.Text = Val(txthargaminuman.Text) * Val(txtjumlahminuman.Text)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        txttotalkeseluruhan.Text = Val(txttotalhargamakanan.Text) + Val(txttotalhargaminuman.Text)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        txtkembalian.Text = txtpembayaran.Text - txttotalkeseluruhan.Text
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        txtnamapemesan.ResetText()
        txtnotempatduduk.ResetText()
        cmbnamamakanan.ResetText()
        txthargamakanan.ResetText()
        txtjumlahmakanan.ResetText()
        txttotalhargamakanan.ResetText()
        cmbnamaminuman.ResetText()
        txthargaminuman.ResetText()
        txtjumlahminuman.ResetText()
        txttotalhargaminuman.ResetText()
        txttotalkeseluruhan.ResetText()
        txtpembayaran.ResetText()
        txtkembalian.ResetText()
    End Sub
End Class
