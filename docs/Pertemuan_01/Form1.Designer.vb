<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DataKaryawan
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnsimpan = New System.Windows.Forms.Button()
        Me.btnhapus = New System.Windows.Forms.Button()
        Me.btnubah = New System.Windows.Forms.Button()
        Me.btntambah = New System.Windows.Forms.Button()
        Me.btnbatal = New System.Windows.Forms.Button()
        Me.btnlaporan = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtkode = New System.Windows.Forms.TextBox()
        Me.txtnama = New System.Windows.Forms.TextBox()
        Me.txtalamat = New System.Windows.Forms.TextBox()
        Me.txtposisi = New System.Windows.Forms.TextBox()
        Me.txtgaji = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cmbjenis = New System.Windows.Forms.ComboBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnsimpan
        '
        Me.btnsimpan.Location = New System.Drawing.Point(76, 227)
        Me.btnsimpan.Name = "btnsimpan"
        Me.btnsimpan.Size = New System.Drawing.Size(75, 23)
        Me.btnsimpan.TabIndex = 0
        Me.btnsimpan.Text = "&Simpan"
        Me.btnsimpan.UseVisualStyleBackColor = True
        '
        'btnhapus
        '
        Me.btnhapus.Location = New System.Drawing.Point(194, 227)
        Me.btnhapus.Name = "btnhapus"
        Me.btnhapus.Size = New System.Drawing.Size(75, 23)
        Me.btnhapus.TabIndex = 1
        Me.btnhapus.Text = "&Hapus"
        Me.btnhapus.UseVisualStyleBackColor = True
        '
        'btnubah
        '
        Me.btnubah.Location = New System.Drawing.Point(313, 227)
        Me.btnubah.Name = "btnubah"
        Me.btnubah.Size = New System.Drawing.Size(75, 23)
        Me.btnubah.TabIndex = 2
        Me.btnubah.Text = "&Ubah"
        Me.btnubah.UseVisualStyleBackColor = True
        '
        'btntambah
        '
        Me.btntambah.Location = New System.Drawing.Point(436, 227)
        Me.btntambah.Name = "btntambah"
        Me.btntambah.Size = New System.Drawing.Size(75, 23)
        Me.btntambah.TabIndex = 3
        Me.btntambah.Text = "&Tambah"
        Me.btntambah.UseVisualStyleBackColor = True
        '
        'btnbatal
        '
        Me.btnbatal.Location = New System.Drawing.Point(557, 227)
        Me.btnbatal.Name = "btnbatal"
        Me.btnbatal.Size = New System.Drawing.Size(75, 23)
        Me.btnbatal.TabIndex = 4
        Me.btnbatal.Text = "&Batal"
        Me.btnbatal.UseVisualStyleBackColor = True
        '
        'btnlaporan
        '
        Me.btnlaporan.Location = New System.Drawing.Point(676, 227)
        Me.btnlaporan.Name = "btnlaporan"
        Me.btnlaporan.Size = New System.Drawing.Size(75, 23)
        Me.btnlaporan.TabIndex = 5
        Me.btnlaporan.Text = "&Laporan"
        Me.btnlaporan.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Bernard MT Condensed", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(221, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(386, 28)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "DATA KARYAWAN PT.GARUDA NUSANTARA"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(89, 81)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Kode_Karyawan"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(89, 128)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(88, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Nama_Karyawan"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(89, 177)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Alamat"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(440, 81)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(34, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Posisi"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(440, 125)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(73, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Gaji_Perbulan"
        '
        'txtkode
        '
        Me.txtkode.Location = New System.Drawing.Point(189, 81)
        Me.txtkode.Name = "txtkode"
        Me.txtkode.Size = New System.Drawing.Size(116, 20)
        Me.txtkode.TabIndex = 12
        '
        'txtnama
        '
        Me.txtnama.Location = New System.Drawing.Point(189, 125)
        Me.txtnama.Name = "txtnama"
        Me.txtnama.Size = New System.Drawing.Size(184, 20)
        Me.txtnama.TabIndex = 13
        '
        'txtalamat
        '
        Me.txtalamat.Location = New System.Drawing.Point(189, 174)
        Me.txtalamat.Name = "txtalamat"
        Me.txtalamat.Size = New System.Drawing.Size(184, 20)
        Me.txtalamat.TabIndex = 14
        '
        'txtposisi
        '
        Me.txtposisi.Location = New System.Drawing.Point(532, 74)
        Me.txtposisi.Name = "txtposisi"
        Me.txtposisi.Size = New System.Drawing.Size(186, 20)
        Me.txtposisi.TabIndex = 15
        '
        'txtgaji
        '
        Me.txtgaji.Location = New System.Drawing.Point(532, 118)
        Me.txtgaji.Name = "txtgaji"
        Me.txtgaji.Size = New System.Drawing.Size(186, 20)
        Me.txtgaji.TabIndex = 16
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(440, 177)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(74, 13)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "Jenis_Kelamin"
        '
        'cmbjenis
        '
        Me.cmbjenis.FormattingEnabled = True
        Me.cmbjenis.Location = New System.Drawing.Point(532, 169)
        Me.cmbjenis.Name = "cmbjenis"
        Me.cmbjenis.Size = New System.Drawing.Size(186, 21)
        Me.cmbjenis.TabIndex = 18
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.Plum
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(80, 276)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(666, 215)
        Me.DataGridView1.TabIndex = 19
        '
        'DataKaryawan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Thistle
        Me.ClientSize = New System.Drawing.Size(825, 519)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.cmbjenis)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtgaji)
        Me.Controls.Add(Me.txtposisi)
        Me.Controls.Add(Me.txtalamat)
        Me.Controls.Add(Me.txtnama)
        Me.Controls.Add(Me.txtkode)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnlaporan)
        Me.Controls.Add(Me.btnbatal)
        Me.Controls.Add(Me.btntambah)
        Me.Controls.Add(Me.btnubah)
        Me.Controls.Add(Me.btnhapus)
        Me.Controls.Add(Me.btnsimpan)
        Me.Name = "DataKaryawan"
        Me.Text = "LaporanDataKaryawan"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnsimpan As Button
    Friend WithEvents btnhapus As Button
    Friend WithEvents btnubah As Button
    Friend WithEvents btntambah As Button
    Friend WithEvents btnbatal As Button
    Friend WithEvents btnlaporan As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtkode As TextBox
    Friend WithEvents txtnama As TextBox
    Friend WithEvents txtalamat As TextBox
    Friend WithEvents txtposisi As TextBox
    Friend WithEvents txtgaji As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents cmbjenis As ComboBox
    Friend WithEvents DataGridView1 As DataGridView
End Class
