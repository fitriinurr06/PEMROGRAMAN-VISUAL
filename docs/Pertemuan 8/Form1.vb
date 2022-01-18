Public Class FunctionProcedure
    Sub Refresh()
        txtangka1.Text = ""
        txtangka2.Text = ""
        txthasil.Text = ""
        txtangka1.Focus()
        txtangka2.Focus()
        txthasil.Enabled = True
    End Sub
    Private Sub FunctionProcedure_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Refresh()
    End Sub

    Private Sub btnrefresh_Click(sender As Object, e As EventArgs) Handles btnrefresh.Click
        Call Refresh()
    End Sub

    Private Function Tambah()
        Dim a1, a2, total As Double
        a1 = Val(txtangka1.Text)
        a2 = Val(txtangka2.Text)
        total = a1 + a2
        txthasil.Text = total
        Return total
    End Function

    Private Sub btntambah_Click(sender As Object, e As EventArgs) Handles btntambah.Click
        Call Tambah()
    End Sub

    Private Function Kurang()
        Dim a1, a2, total As Double
        a1 = Val(txtangka1.Text)
        a2 = Val(txtangka2.Text)
        total = a1 - a2
        txthasil.Text = total
        Return total
    End Function

    Private Sub btnkurang_Click(sender As Object, e As EventArgs) Handles btnkurang.Click
        Call Kurang()
    End Sub

    Private Function Kali()
        Dim a1, a2, total As Double
        a1 = Val(txtangka1.Text)
        a2 = Val(txtangka2.Text)
        total = a1 * a2
        txthasil.Text = total
        Return total
    End Function

    Private Sub btnkali_Click(sender As Object, e As EventArgs) Handles btnkali.Click
        Call Kali()
    End Sub
    Private Function Bagi()
        Dim a1, a2, total As Double
        a1 = Val(txtangka1.Text)
        a2 = Val(txtangka2.Text)
        total = a1 / a2
        txthasil.Text = total
        Return total
    End Function

    Private Sub btnbagi_Click(sender As Object, e As EventArgs) Handles btnbagi.Click
        Call Bagi()
    End Sub
    Private Function Pangkat()
        Dim a1, a2, total As Double
        a1 = Val(txtangka1.Text)
        a2 = Val(txtangka2.Text)
        total = a1 ^ a2
        txthasil.Text = total
        Return total
    End Function

    Private Sub btnpangkat_Click(sender As Object, e As EventArgs) Handles btnpangkat.Click
        Call Pangkat()
    End Sub
End Class
