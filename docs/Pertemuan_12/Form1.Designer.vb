<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DataBuku
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtdeskripsi = New System.Windows.Forms.TextBox()
        Me.txtkodebuku = New System.Windows.Forms.TextBox()
        Me.txtjudul = New System.Windows.Forms.TextBox()
        Me.txtpengarang = New System.Windows.Forms.TextBox()
        Me.txtpenerbit = New System.Windows.Forms.TextBox()
        Me.txtharga = New System.Windows.Forms.TextBox()
        Me.txtcaridata = New System.Windows.Forms.TextBox()
        Me.txtjmlbuku = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cmbkodejenis = New System.Windows.Forms.ComboBox()
        Me.btntambah = New System.Windows.Forms.Button()
        Me.btnsimpan = New System.Windows.Forms.Button()
        Me.btnhapus = New System.Windows.Forms.Button()
        Me.btnbatal = New System.Windows.Forms.Button()
        Me.btnkeluar = New System.Windows.Forms.Button()
        Me.btnubah = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.txtjenis = New System.Windows.Forms.TextBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Harrington", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(310, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(305, 34)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Toko Buku ""Cendikia"""
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(106, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Kode Buku"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(419, 64)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Kode Jenis"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(106, 101)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(32, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Judul"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(106, 136)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(59, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Pengarang"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(106, 173)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(46, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Penerbit"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(419, 102)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(50, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Deskripsi"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(106, 214)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(68, 13)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Jumlah Buku"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(428, 216)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(36, 13)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Harga"
        '
        'txtdeskripsi
        '
        Me.txtdeskripsi.Location = New System.Drawing.Point(516, 92)
        Me.txtdeskripsi.Multiline = True
        Me.txtdeskripsi.Name = "txtdeskripsi"
        Me.txtdeskripsi.Size = New System.Drawing.Size(338, 110)
        Me.txtdeskripsi.TabIndex = 9
        '
        'txtkodebuku
        '
        Me.txtkodebuku.Location = New System.Drawing.Point(210, 64)
        Me.txtkodebuku.Name = "txtkodebuku"
        Me.txtkodebuku.Size = New System.Drawing.Size(119, 20)
        Me.txtkodebuku.TabIndex = 10
        '
        'txtjudul
        '
        Me.txtjudul.Location = New System.Drawing.Point(210, 102)
        Me.txtjudul.Name = "txtjudul"
        Me.txtjudul.Size = New System.Drawing.Size(193, 20)
        Me.txtjudul.TabIndex = 11
        '
        'txtpengarang
        '
        Me.txtpengarang.Location = New System.Drawing.Point(210, 136)
        Me.txtpengarang.Name = "txtpengarang"
        Me.txtpengarang.Size = New System.Drawing.Size(193, 20)
        Me.txtpengarang.TabIndex = 12
        '
        'txtpenerbit
        '
        Me.txtpenerbit.Location = New System.Drawing.Point(210, 173)
        Me.txtpenerbit.Name = "txtpenerbit"
        Me.txtpenerbit.Size = New System.Drawing.Size(193, 20)
        Me.txtpenerbit.TabIndex = 13
        '
        'txtharga
        '
        Me.txtharga.Location = New System.Drawing.Point(515, 214)
        Me.txtharga.Name = "txtharga"
        Me.txtharga.Size = New System.Drawing.Size(100, 20)
        Me.txtharga.TabIndex = 15
        '
        'txtcaridata
        '
        Me.txtcaridata.Location = New System.Drawing.Point(262, 301)
        Me.txtcaridata.Name = "txtcaridata"
        Me.txtcaridata.Size = New System.Drawing.Size(216, 20)
        Me.txtcaridata.TabIndex = 16
        '
        'txtjmlbuku
        '
        Me.txtjmlbuku.Location = New System.Drawing.Point(210, 211)
        Me.txtjmlbuku.Name = "txtjmlbuku"
        Me.txtjmlbuku.Size = New System.Drawing.Size(100, 20)
        Me.txtjmlbuku.TabIndex = 17
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(198, 304)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(51, 13)
        Me.Label10.TabIndex = 18
        Me.Label10.Text = "Cari Data"
        '
        'cmbkodejenis
        '
        Me.cmbkodejenis.FormattingEnabled = True
        Me.cmbkodejenis.Location = New System.Drawing.Point(516, 61)
        Me.cmbkodejenis.Name = "cmbkodejenis"
        Me.cmbkodejenis.Size = New System.Drawing.Size(121, 21)
        Me.cmbkodejenis.TabIndex = 19
        '
        'btntambah
        '
        Me.btntambah.Location = New System.Drawing.Point(94, 255)
        Me.btntambah.Name = "btntambah"
        Me.btntambah.Size = New System.Drawing.Size(75, 23)
        Me.btntambah.TabIndex = 20
        Me.btntambah.Text = "&Tambah"
        Me.btntambah.UseVisualStyleBackColor = True
        '
        'btnsimpan
        '
        Me.btnsimpan.Location = New System.Drawing.Point(214, 255)
        Me.btnsimpan.Name = "btnsimpan"
        Me.btnsimpan.Size = New System.Drawing.Size(75, 23)
        Me.btnsimpan.TabIndex = 21
        Me.btnsimpan.Text = "&Simpan"
        Me.btnsimpan.UseVisualStyleBackColor = True
        '
        'btnhapus
        '
        Me.btnhapus.Location = New System.Drawing.Point(473, 255)
        Me.btnhapus.Name = "btnhapus"
        Me.btnhapus.Size = New System.Drawing.Size(75, 23)
        Me.btnhapus.TabIndex = 22
        Me.btnhapus.Text = "&Hapus"
        Me.btnhapus.UseVisualStyleBackColor = True
        '
        'btnbatal
        '
        Me.btnbatal.Location = New System.Drawing.Point(596, 255)
        Me.btnbatal.Name = "btnbatal"
        Me.btnbatal.Size = New System.Drawing.Size(75, 23)
        Me.btnbatal.TabIndex = 23
        Me.btnbatal.Text = "&Batal"
        Me.btnbatal.UseVisualStyleBackColor = True
        '
        'btnkeluar
        '
        Me.btnkeluar.Location = New System.Drawing.Point(712, 255)
        Me.btnkeluar.Name = "btnkeluar"
        Me.btnkeluar.Size = New System.Drawing.Size(75, 23)
        Me.btnkeluar.TabIndex = 24
        Me.btnkeluar.Text = "&Keluar"
        Me.btnkeluar.UseVisualStyleBackColor = True
        '
        'btnubah
        '
        Me.btnubah.Location = New System.Drawing.Point(344, 255)
        Me.btnubah.Name = "btnubah"
        Me.btnubah.Size = New System.Drawing.Size(75, 23)
        Me.btnubah.TabIndex = 25
        Me.btnubah.Text = "&Ubah"
        Me.btnubah.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.PeachPuff
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 336)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(869, 222)
        Me.DataGridView1.TabIndex = 26
        '
        'txtjenis
        '
        Me.txtjenis.Location = New System.Drawing.Point(643, 61)
        Me.txtjenis.Name = "txtjenis"
        Me.txtjenis.Size = New System.Drawing.Size(144, 20)
        Me.txtjenis.TabIndex = 27
        '
        'DataBuku
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkSalmon
        Me.ClientSize = New System.Drawing.Size(893, 587)
        Me.Controls.Add(Me.txtjenis)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btnubah)
        Me.Controls.Add(Me.btnkeluar)
        Me.Controls.Add(Me.btnbatal)
        Me.Controls.Add(Me.btnhapus)
        Me.Controls.Add(Me.btnsimpan)
        Me.Controls.Add(Me.btntambah)
        Me.Controls.Add(Me.cmbkodejenis)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtjmlbuku)
        Me.Controls.Add(Me.txtcaridata)
        Me.Controls.Add(Me.txtharga)
        Me.Controls.Add(Me.txtpenerbit)
        Me.Controls.Add(Me.txtpengarang)
        Me.Controls.Add(Me.txtjudul)
        Me.Controls.Add(Me.txtkodebuku)
        Me.Controls.Add(Me.txtdeskripsi)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "DataBuku"
        Me.Text = "Data Buku Toko ""Cendikia"""
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents txtdeskripsi As TextBox
    Friend WithEvents txtkodebuku As TextBox
    Friend WithEvents txtjudul As TextBox
    Friend WithEvents txtpengarang As TextBox
    Friend WithEvents txtpenerbit As TextBox
    Friend WithEvents txtharga As TextBox
    Friend WithEvents txtcaridata As TextBox
    Friend WithEvents txtjmlbuku As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents cmbkodejenis As ComboBox
    Friend WithEvents btntambah As Button
    Friend WithEvents btnsimpan As Button
    Friend WithEvents btnhapus As Button
    Friend WithEvents btnbatal As Button
    Friend WithEvents btnkeluar As Button
    Friend WithEvents btnubah As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents txtjenis As TextBox
End Class
