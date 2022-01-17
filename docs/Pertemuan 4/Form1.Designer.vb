<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.lbljenismakanan = New System.Windows.Forms.Label()
        Me.lblnmmakanan = New System.Windows.Forms.Label()
        Me.lblharga = New System.Windows.Forms.Label()
        Me.lbljumlah = New System.Windows.Forms.Label()
        Me.lbluang = New System.Windows.Forms.Label()
        Me.lbltotalharga = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btnhitung = New System.Windows.Forms.Button()
        Me.btnrefresh = New System.Windows.Forms.Button()
        Me.txtuang = New System.Windows.Forms.TextBox()
        Me.txtkembalian = New System.Windows.Forms.TextBox()
        Me.txtharga = New System.Windows.Forms.TextBox()
        Me.txtjumlah = New System.Windows.Forms.TextBox()
        Me.cmbjenismakanan = New System.Windows.Forms.ComboBox()
        Me.cmbnmmakanan = New System.Windows.Forms.ComboBox()
        Me.lblkembalian = New System.Windows.Forms.Label()
        Me.txttotalharga = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnhitungkembalian = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbljenismakanan
        '
        Me.lbljenismakanan.AutoSize = True
        Me.lbljenismakanan.Font = New System.Drawing.Font("Mongolian Baiti", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbljenismakanan.Location = New System.Drawing.Point(25, 81)
        Me.lbljenismakanan.Name = "lbljenismakanan"
        Me.lbljenismakanan.Size = New System.Drawing.Size(135, 20)
        Me.lbljenismakanan.TabIndex = 0
        Me.lbljenismakanan.Text = "Jenis Makanan"
        '
        'lblnmmakanan
        '
        Me.lblnmmakanan.AutoSize = True
        Me.lblnmmakanan.Font = New System.Drawing.Font("Mongolian Baiti", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblnmmakanan.Location = New System.Drawing.Point(25, 124)
        Me.lblnmmakanan.Name = "lblnmmakanan"
        Me.lblnmmakanan.Size = New System.Drawing.Size(142, 20)
        Me.lblnmmakanan.TabIndex = 1
        Me.lblnmmakanan.Text = "Nama Makanan"
        '
        'lblharga
        '
        Me.lblharga.AutoSize = True
        Me.lblharga.Font = New System.Drawing.Font("Mongolian Baiti", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblharga.Location = New System.Drawing.Point(25, 163)
        Me.lblharga.Name = "lblharga"
        Me.lblharga.Size = New System.Drawing.Size(60, 20)
        Me.lblharga.TabIndex = 2
        Me.lblharga.Text = "Harga"
        '
        'lbljumlah
        '
        Me.lbljumlah.AutoSize = True
        Me.lbljumlah.Font = New System.Drawing.Font("Mongolian Baiti", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbljumlah.Location = New System.Drawing.Point(25, 204)
        Me.lbljumlah.Name = "lbljumlah"
        Me.lbljumlah.Size = New System.Drawing.Size(70, 20)
        Me.lbljumlah.TabIndex = 3
        Me.lbljumlah.Text = "Jumlah"
        '
        'lbluang
        '
        Me.lbluang.AutoSize = True
        Me.lbluang.Font = New System.Drawing.Font("Mongolian Baiti", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbluang.Location = New System.Drawing.Point(421, 162)
        Me.lbluang.Name = "lbluang"
        Me.lbluang.Size = New System.Drawing.Size(113, 20)
        Me.lbluang.TabIndex = 5
        Me.lbluang.Text = "Pembayaran"
        '
        'lbltotalharga
        '
        Me.lbltotalharga.AutoSize = True
        Me.lbltotalharga.Font = New System.Drawing.Font("Mongolian Baiti", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltotalharga.Location = New System.Drawing.Point(421, 124)
        Me.lbltotalharga.Name = "lbltotalharga"
        Me.lbltotalharga.Size = New System.Drawing.Size(111, 20)
        Me.lbltotalharga.TabIndex = 6
        Me.lbltotalharga.Text = "Total Harga"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("MS Reference Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(157, 25)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(330, 26)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "THE KITCHEN ""MANTULITA"""
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(-1, 271)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(429, 13)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Terima Kasih Atas Kunjungan Anda, Jangan Lupa Untuk Datang Lagi Ya :)"
        '
        'btnhitung
        '
        Me.btnhitung.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnhitung.Location = New System.Drawing.Point(434, 242)
        Me.btnhitung.Name = "btnhitung"
        Me.btnhitung.Size = New System.Drawing.Size(185, 30)
        Me.btnhitung.TabIndex = 9
        Me.btnhitung.Text = "Hitung Total Harga"
        Me.btnhitung.UseVisualStyleBackColor = True
        '
        'btnrefresh
        '
        Me.btnrefresh.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnrefresh.Location = New System.Drawing.Point(625, 262)
        Me.btnrefresh.Name = "btnrefresh"
        Me.btnrefresh.Size = New System.Drawing.Size(75, 31)
        Me.btnrefresh.TabIndex = 10
        Me.btnrefresh.Text = "Refresh"
        Me.btnrefresh.UseVisualStyleBackColor = True
        '
        'txtuang
        '
        Me.txtuang.Location = New System.Drawing.Point(558, 162)
        Me.txtuang.Name = "txtuang"
        Me.txtuang.Size = New System.Drawing.Size(144, 20)
        Me.txtuang.TabIndex = 12
        '
        'txtkembalian
        '
        Me.txtkembalian.Location = New System.Drawing.Point(558, 203)
        Me.txtkembalian.Name = "txtkembalian"
        Me.txtkembalian.Size = New System.Drawing.Size(144, 20)
        Me.txtkembalian.TabIndex = 13
        '
        'txtharga
        '
        Me.txtharga.Location = New System.Drawing.Point(203, 165)
        Me.txtharga.Name = "txtharga"
        Me.txtharga.Size = New System.Drawing.Size(166, 20)
        Me.txtharga.TabIndex = 16
        '
        'txtjumlah
        '
        Me.txtjumlah.Location = New System.Drawing.Point(203, 203)
        Me.txtjumlah.Name = "txtjumlah"
        Me.txtjumlah.Size = New System.Drawing.Size(166, 20)
        Me.txtjumlah.TabIndex = 17
        '
        'cmbjenismakanan
        '
        Me.cmbjenismakanan.FormattingEnabled = True
        Me.cmbjenismakanan.Location = New System.Drawing.Point(203, 80)
        Me.cmbjenismakanan.Name = "cmbjenismakanan"
        Me.cmbjenismakanan.Size = New System.Drawing.Size(166, 21)
        Me.cmbjenismakanan.TabIndex = 18
        '
        'cmbnmmakanan
        '
        Me.cmbnmmakanan.FormattingEnabled = True
        Me.cmbnmmakanan.Location = New System.Drawing.Point(203, 123)
        Me.cmbnmmakanan.Name = "cmbnmmakanan"
        Me.cmbnmmakanan.Size = New System.Drawing.Size(166, 21)
        Me.cmbnmmakanan.TabIndex = 19
        '
        'lblkembalian
        '
        Me.lblkembalian.AutoSize = True
        Me.lblkembalian.Font = New System.Drawing.Font("Mongolian Baiti", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblkembalian.Location = New System.Drawing.Point(421, 201)
        Me.lblkembalian.Name = "lblkembalian"
        Me.lblkembalian.Size = New System.Drawing.Size(101, 20)
        Me.lblkembalian.TabIndex = 20
        Me.lblkembalian.Text = "Kembalian"
        '
        'txttotalharga
        '
        Me.txttotalharga.Location = New System.Drawing.Point(558, 121)
        Me.txttotalharga.Name = "txttotalharga"
        Me.txttotalharga.Size = New System.Drawing.Size(144, 20)
        Me.txttotalharga.TabIndex = 21
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(493, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(209, 96)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 22
        Me.PictureBox1.TabStop = False
        '
        'btnhitungkembalian
        '
        Me.btnhitungkembalian.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnhitungkembalian.Location = New System.Drawing.Point(435, 279)
        Me.btnhitungkembalian.Name = "btnhitungkembalian"
        Me.btnhitungkembalian.Size = New System.Drawing.Size(184, 28)
        Me.btnhitungkembalian.TabIndex = 23
        Me.btnhitungkembalian.Text = "Hitung Kembalian"
        Me.btnhitungkembalian.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(758, 336)
        Me.Controls.Add(Me.btnhitungkembalian)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.txttotalharga)
        Me.Controls.Add(Me.lblkembalian)
        Me.Controls.Add(Me.cmbnmmakanan)
        Me.Controls.Add(Me.cmbjenismakanan)
        Me.Controls.Add(Me.txtjumlah)
        Me.Controls.Add(Me.txtharga)
        Me.Controls.Add(Me.txtkembalian)
        Me.Controls.Add(Me.txtuang)
        Me.Controls.Add(Me.btnrefresh)
        Me.Controls.Add(Me.btnhitung)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.lbltotalharga)
        Me.Controls.Add(Me.lbluang)
        Me.Controls.Add(Me.lbljumlah)
        Me.Controls.Add(Me.lblharga)
        Me.Controls.Add(Me.lblnmmakanan)
        Me.Controls.Add(Me.lbljenismakanan)
        Me.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Name = "Form1"
        Me.Text = "Selamat Menikmati Sajian Kami"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbljenismakanan As Label
    Friend WithEvents lblnmmakanan As Label
    Friend WithEvents lblharga As Label
    Friend WithEvents lbljumlah As Label
    Friend WithEvents lbluang As Label
    Friend WithEvents lbltotalharga As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents btnhitung As Button
    Friend WithEvents btnrefresh As Button
    Friend WithEvents txtuang As TextBox
    Friend WithEvents txtkembalian As TextBox
    Friend WithEvents txtharga As TextBox
    Friend WithEvents txtjumlah As TextBox
    Friend WithEvents cmbjenismakanan As ComboBox
    Friend WithEvents cmbnmmakanan As ComboBox
    Friend WithEvents lblkembalian As Label
    Friend WithEvents txttotalharga As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnhitungkembalian As Button
End Class
