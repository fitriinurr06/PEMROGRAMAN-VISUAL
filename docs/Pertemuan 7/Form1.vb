Public Class Form1

    Private Sub btntambah_Click(sender As Object, e As EventArgs) Handles btntambah.Click
        txthasil.Text = (Integer.Parse(txtangka1.Text) + Integer.Parse(txtangka2.Text)).ToString()
    End Sub

    Private Sub btnkurang_Click(sender As Object, e As EventArgs) Handles btnkurang.Click
        txthasil.Text = (Integer.Parse(txtangka1.Text) - Integer.Parse(txtangka2.Text)).ToString()
    End Sub

    Private Sub btnkali_Click(sender As Object, e As EventArgs) Handles btnkali.Click
        txthasil.Text = (Integer.Parse(txtangka1.Text) * Integer.Parse(txtangka2.Text)).ToString()
    End Sub

    Private Sub btnbagi_Click(sender As Object, e As EventArgs) Handles btnbagi.Click
        txthasil.Text = (Integer.Parse(txtangka1.Text) / Integer.Parse(txtangka2.Text)).ToString()
    End Sub

    Private Sub btnpangkat_Click(sender As Object, e As EventArgs) Handles btnpangkat.Click
        txthasil.Text = (Integer.Parse(txtangka1.Text) ^ Integer.Parse(txtangka2.Text)).ToString()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        txtangka1.Text = ""
        txtangka2.Text = ""
        txthasil.Text = ""
    End Sub
End Class
