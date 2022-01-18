Imports System.Drawing.Printing
Public Class TokoBungaFlorist
    Dim WithEvents PD As New PrintDocument
    Dim PPD As New PrintPreviewDialog
    Dim t_harga As Long
    Dim t_jml As Long
    Private Sub btncetak_Click(sender As Object, e As EventArgs) Handles btncetak.Click
        PPD.Document = PD
        PPD.ShowDialog()
        'PD.Print()

    End Sub

    Private Sub TokoBungaFlorist_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub PD_PrintPage(sender As Object, e As PrintPageEventArgs) Handles PD.PrintPage
        Dim f10 As New Font("Times New Roman", 10, FontStyle.Regular)
        Dim f10b As New Font("Times New Roman", 10, FontStyle.Bold)
        Dim f14 As New Font("Times New Roman", 14, FontStyle.Bold)

        Dim leftmargin As Integer = PD.DefaultPageSettings.Margins.Left
        Dim centermargin As Integer = PD.DefaultPageSettings.PaperSize.Width / 2
        Dim rightmargin As Integer = PD.DefaultPageSettings.PaperSize.Width

        Dim kanan As New StringFormat
        Dim tengah As New StringFormat
        kanan.Alignment = StringAlignment.Far
        tengah.Alignment = StringAlignment.Center

        Dim garis As String
        garis = "-------------------------------------------------------------------------"

        e.Graphics.DrawString("Toko Bunga Florist", f14, Brushes.Black, centermargin, 5, tengah)
        e.Graphics.DrawString("Jln.Cengkeh No.14 Taman Sari Jakarta Barat", f10, Brushes.Black, centermargin, 25, tengah)
        e.Graphics.DrawString("No.HP 087-990-889-007", f10, Brushes.Black, centermargin, 40, tengah)

        e.Graphics.DrawString("No.Faktur", f10, Brushes.Black, 0, 60)
        e.Graphics.DrawString(":", f10, Brushes.Black, 65, 60)
        e.Graphics.DrawString("12345", f10, Brushes.Black, 75, 60)

        e.Graphics.DrawString("Kasir", f10, Brushes.Black, 0, 75)
        e.Graphics.DrawString(":", f10, Brushes.Black, 65, 75)
        e.Graphics.DrawString("Alyssa", f10, Brushes.Black, 75, 75)

        e.Graphics.DrawString("26/07/2021 00:00", f10, Brushes.Black, 0, 90)

        e.Graphics.DrawString(garis, f10, Brushes.Black, 0, 100)
        DataGridView1.AllowUserToAddRows = False

        Dim tinggi As Integer
        Dim i As Long
        For baris As Integer = 0 To DataGridView1.RowCount - 1
            tinggi += 15
            e.Graphics.DrawString(DataGridView1.Rows(baris).Cells(1).Value.ToString, f10, Brushes.Black, 0, 100 + tinggi)
            e.Graphics.DrawString(DataGridView1.Rows(baris).Cells(0).Value.ToString, f10, Brushes.Black, 50, 100 + tinggi)

            i = DataGridView1.Rows(baris).Cells(2).Value
            DataGridView1.Rows(baris).Cells(2).Value = Format(i, "##,##0")
            e.Graphics.DrawString(DataGridView1.Rows(baris).Cells(2).Value.ToString, f10, Brushes.Black, rightmargin, 100 + tinggi, kanan)

        Next
        tinggi = 110 + tinggi
        hitungtotal()

        e.Graphics.DrawString(garis, f10, Brushes.Black, 0, tinggi)
        e.Graphics.DrawString("Total Harga : " & Format(t_harga, "##,##0"), f10b, Brushes.Black, rightmargin, 10 + tinggi, kanan)
        e.Graphics.DrawString(t_jml, f10b, Brushes.Black, 0, 10 + tinggi)

        e.Graphics.DrawString("Terimakasih Telah Belanja", f10, Brushes.Black, centermargin, 35 + tinggi, tengah)
        e.Graphics.DrawString("Jangan Lupa Mampir Lagi Ya :)", f10, Brushes.Black, centermargin, 50 + tinggi, tengah)
    End Sub

    Sub hitungtotal()
        Dim hitung As Long = 0
        For baris As Long = 0 To DataGridView1.RowCount - 1
            hitung = hitung + DataGridView1.Rows(baris).Cells(2).Value
        Next
        t_harga = hitung

        Dim jml As Long = 0
        For baris As Long = 0 To DataGridView1.RowCount - 1
            jml = jml + DataGridView1.Rows(baris).Cells(1).Value
        Next
        t_jml = jml
    End Sub

    Private Sub PD_BeginPrint(sender As Object, e As PrintEventArgs) Handles PD.BeginPrint
        Dim pagesetup As New PageSettings
        pagesetup.PaperSize = New PaperSize("Custom", 350, 400)
        PD.DefaultPageSettings = pagesetup
    End Sub
End Class
