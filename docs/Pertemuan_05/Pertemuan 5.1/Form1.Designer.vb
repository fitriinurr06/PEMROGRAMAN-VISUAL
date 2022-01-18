<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblnoktp = New System.Windows.Forms.Label()
        Me.lblnama = New System.Windows.Forms.Label()
        Me.lbljeniskamar = New System.Windows.Forms.Label()
        Me.lblhargasewa = New System.Windows.Forms.Label()
        Me.lbllamamenginap = New System.Windows.Forms.Label()
        Me.lblpembayaran = New System.Windows.Forms.Label()
        Me.lblkembalian = New System.Windows.Forms.Label()
        Me.lbltotalsewa = New System.Windows.Forms.Label()
        Me.cmbjeniskamar = New System.Windows.Forms.ComboBox()
        Me.txtnoktp = New System.Windows.Forms.TextBox()
        Me.txtlamamenginap = New System.Windows.Forms.TextBox()
        Me.txttotalsewa = New System.Windows.Forms.TextBox()
        Me.txtpembayaran = New System.Windows.Forms.TextBox()
        Me.txtkembalian = New System.Windows.Forms.TextBox()
        Me.txtnama = New System.Windows.Forms.TextBox()
        Me.txthargasewa = New System.Windows.Forms.TextBox()
        Me.btntotalsewa = New System.Windows.Forms.Button()
        Me.btnkembalian = New System.Windows.Forms.Button()
        Me.btnrefresh = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Agency FB", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(179, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(234, 34)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "PENGINAPAN PODO MORO"
        '
        'lblnoktp
        '
        Me.lblnoktp.AutoSize = True
        Me.lblnoktp.Font = New System.Drawing.Font("Agency FB", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblnoktp.Location = New System.Drawing.Point(28, 69)
        Me.lblnoktp.Name = "lblnoktp"
        Me.lblnoktp.Size = New System.Drawing.Size(66, 25)
        Me.lblnoktp.TabIndex = 1
        Me.lblnoktp.Text = "No.KTP :"
        '
        'lblnama
        '
        Me.lblnama.AutoSize = True
        Me.lblnama.Font = New System.Drawing.Font("Agency FB", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblnama.Location = New System.Drawing.Point(28, 102)
        Me.lblnama.Name = "lblnama"
        Me.lblnama.Size = New System.Drawing.Size(58, 25)
        Me.lblnama.TabIndex = 2
        Me.lblnama.Text = "Nama : "
        '
        'lbljeniskamar
        '
        Me.lbljeniskamar.AutoSize = True
        Me.lbljeniskamar.Font = New System.Drawing.Font("Agency FB", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbljeniskamar.Location = New System.Drawing.Point(27, 138)
        Me.lbljeniskamar.Name = "lbljeniskamar"
        Me.lbljeniskamar.Size = New System.Drawing.Size(96, 25)
        Me.lbljeniskamar.TabIndex = 3
        Me.lbljeniskamar.Text = "Jenis Kamar :"
        '
        'lblhargasewa
        '
        Me.lblhargasewa.AutoSize = True
        Me.lblhargasewa.Font = New System.Drawing.Font("Agency FB", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblhargasewa.Location = New System.Drawing.Point(27, 168)
        Me.lblhargasewa.Name = "lblhargasewa"
        Me.lblhargasewa.Size = New System.Drawing.Size(143, 25)
        Me.lblhargasewa.TabIndex = 4
        Me.lblhargasewa.Text = "Harga Sewa Perhari :"
        '
        'lbllamamenginap
        '
        Me.lbllamamenginap.AutoSize = True
        Me.lbllamamenginap.Font = New System.Drawing.Font("Agency FB", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbllamamenginap.Location = New System.Drawing.Point(27, 202)
        Me.lbllamamenginap.Name = "lbllamamenginap"
        Me.lbllamamenginap.Size = New System.Drawing.Size(111, 25)
        Me.lbllamamenginap.TabIndex = 5
        Me.lbllamamenginap.Text = "Lama Menginap :"
        '
        'lblpembayaran
        '
        Me.lblpembayaran.AutoSize = True
        Me.lblpembayaran.Font = New System.Drawing.Font("Agency FB", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblpembayaran.Location = New System.Drawing.Point(28, 274)
        Me.lblpembayaran.Name = "lblpembayaran"
        Me.lblpembayaran.Size = New System.Drawing.Size(97, 25)
        Me.lblpembayaran.TabIndex = 6
        Me.lblpembayaran.Text = "Pembayaran :"
        '
        'lblkembalian
        '
        Me.lblkembalian.AutoSize = True
        Me.lblkembalian.Font = New System.Drawing.Font("Agency FB", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblkembalian.Location = New System.Drawing.Point(27, 308)
        Me.lblkembalian.Name = "lblkembalian"
        Me.lblkembalian.Size = New System.Drawing.Size(81, 25)
        Me.lblkembalian.TabIndex = 7
        Me.lblkembalian.Text = "Kembalian :"
        '
        'lbltotalsewa
        '
        Me.lbltotalsewa.AutoSize = True
        Me.lbltotalsewa.Font = New System.Drawing.Font("Agency FB", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltotalsewa.Location = New System.Drawing.Point(28, 238)
        Me.lbltotalsewa.Name = "lbltotalsewa"
        Me.lbltotalsewa.Size = New System.Drawing.Size(87, 25)
        Me.lbltotalsewa.TabIndex = 8
        Me.lbltotalsewa.Text = "Total Sewa :"
        '
        'cmbjeniskamar
        '
        Me.cmbjeniskamar.Font = New System.Drawing.Font("Agency FB", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbjeniskamar.FormattingEnabled = True
        Me.cmbjeniskamar.Location = New System.Drawing.Point(176, 131)
        Me.cmbjeniskamar.Name = "cmbjeniskamar"
        Me.cmbjeniskamar.Size = New System.Drawing.Size(147, 32)
        Me.cmbjeniskamar.TabIndex = 9
        '
        'txtnoktp
        '
        Me.txtnoktp.Font = New System.Drawing.Font("Agency FB", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnoktp.Location = New System.Drawing.Point(176, 62)
        Me.txtnoktp.Name = "txtnoktp"
        Me.txtnoktp.Size = New System.Drawing.Size(147, 30)
        Me.txtnoktp.TabIndex = 10
        '
        'txtlamamenginap
        '
        Me.txtlamamenginap.Font = New System.Drawing.Font("Agency FB", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtlamamenginap.Location = New System.Drawing.Point(176, 202)
        Me.txtlamamenginap.Name = "txtlamamenginap"
        Me.txtlamamenginap.Size = New System.Drawing.Size(147, 30)
        Me.txtlamamenginap.TabIndex = 11
        '
        'txttotalsewa
        '
        Me.txttotalsewa.Font = New System.Drawing.Font("Agency FB", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttotalsewa.Location = New System.Drawing.Point(176, 238)
        Me.txttotalsewa.Name = "txttotalsewa"
        Me.txttotalsewa.Size = New System.Drawing.Size(147, 30)
        Me.txttotalsewa.TabIndex = 12
        '
        'txtpembayaran
        '
        Me.txtpembayaran.Font = New System.Drawing.Font("Agency FB", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpembayaran.Location = New System.Drawing.Point(176, 275)
        Me.txtpembayaran.Name = "txtpembayaran"
        Me.txtpembayaran.Size = New System.Drawing.Size(147, 30)
        Me.txtpembayaran.TabIndex = 13
        '
        'txtkembalian
        '
        Me.txtkembalian.Font = New System.Drawing.Font("Agency FB", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtkembalian.Location = New System.Drawing.Point(176, 311)
        Me.txtkembalian.Name = "txtkembalian"
        Me.txtkembalian.Size = New System.Drawing.Size(147, 30)
        Me.txtkembalian.TabIndex = 14
        '
        'txtnama
        '
        Me.txtnama.Font = New System.Drawing.Font("Agency FB", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnama.Location = New System.Drawing.Point(176, 97)
        Me.txtnama.Name = "txtnama"
        Me.txtnama.Size = New System.Drawing.Size(147, 30)
        Me.txtnama.TabIndex = 15
        '
        'txthargasewa
        '
        Me.txthargasewa.Font = New System.Drawing.Font("Agency FB", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txthargasewa.Location = New System.Drawing.Point(176, 168)
        Me.txthargasewa.Name = "txthargasewa"
        Me.txthargasewa.Size = New System.Drawing.Size(147, 30)
        Me.txthargasewa.TabIndex = 16
        '
        'btntotalsewa
        '
        Me.btntotalsewa.Font = New System.Drawing.Font("Agency FB", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btntotalsewa.Location = New System.Drawing.Point(372, 239)
        Me.btntotalsewa.Name = "btntotalsewa"
        Me.btntotalsewa.Size = New System.Drawing.Size(127, 33)
        Me.btntotalsewa.TabIndex = 17
        Me.btntotalsewa.Text = "Hitung Total Sewa"
        Me.btntotalsewa.UseVisualStyleBackColor = True
        '
        'btnkembalian
        '
        Me.btnkembalian.Font = New System.Drawing.Font("Agency FB", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnkembalian.Location = New System.Drawing.Point(372, 277)
        Me.btnkembalian.Name = "btnkembalian"
        Me.btnkembalian.Size = New System.Drawing.Size(127, 31)
        Me.btnkembalian.TabIndex = 18
        Me.btnkembalian.Text = "Hitung Kembalian"
        Me.btnkembalian.UseVisualStyleBackColor = True
        '
        'btnrefresh
        '
        Me.btnrefresh.Font = New System.Drawing.Font("Agency FB", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnrefresh.Location = New System.Drawing.Point(372, 319)
        Me.btnrefresh.Name = "btnrefresh"
        Me.btnrefresh.Size = New System.Drawing.Size(127, 27)
        Me.btnrefresh.TabIndex = 19
        Me.btnrefresh.Text = "Refresh"
        Me.btnrefresh.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(332, 62)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(198, 165)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 20
        Me.PictureBox1.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MediumTurquoise
        Me.ClientSize = New System.Drawing.Size(539, 353)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnrefresh)
        Me.Controls.Add(Me.btnkembalian)
        Me.Controls.Add(Me.btntotalsewa)
        Me.Controls.Add(Me.txthargasewa)
        Me.Controls.Add(Me.txtnama)
        Me.Controls.Add(Me.txtkembalian)
        Me.Controls.Add(Me.txtpembayaran)
        Me.Controls.Add(Me.txttotalsewa)
        Me.Controls.Add(Me.txtlamamenginap)
        Me.Controls.Add(Me.txtnoktp)
        Me.Controls.Add(Me.cmbjeniskamar)
        Me.Controls.Add(Me.lbltotalsewa)
        Me.Controls.Add(Me.lblkembalian)
        Me.Controls.Add(Me.lblpembayaran)
        Me.Controls.Add(Me.lbllamamenginap)
        Me.Controls.Add(Me.lblhargasewa)
        Me.Controls.Add(Me.lbljeniskamar)
        Me.Controls.Add(Me.lblnama)
        Me.Controls.Add(Me.lblnoktp)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Penginapan Podo Moro"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents lblnoktp As Label
    Friend WithEvents lblnama As Label
    Friend WithEvents lbljeniskamar As Label
    Friend WithEvents lblhargasewa As Label
    Friend WithEvents lbllamamenginap As Label
    Friend WithEvents lblpembayaran As Label
    Friend WithEvents lblkembalian As Label
    Friend WithEvents lbltotalsewa As Label
    Friend WithEvents cmbjeniskamar As ComboBox
    Friend WithEvents txtnoktp As TextBox
    Friend WithEvents txtlamamenginap As TextBox
    Friend WithEvents txttotalsewa As TextBox
    Friend WithEvents txtpembayaran As TextBox
    Friend WithEvents txtkembalian As TextBox
    Friend WithEvents txtnama As TextBox
    Friend WithEvents txthargasewa As TextBox
    Friend WithEvents btntotalsewa As Button
    Friend WithEvents btnkembalian As Button
    Friend WithEvents btnrefresh As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
