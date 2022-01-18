<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMenuUtama
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormMenuUtama))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.TransaksiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataBukuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataPelangganToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TransaksiToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.PembelianToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PenjualanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LaporanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LaporanDataToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataBukuToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataPelangganToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.LaporanTransaksiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataPembelianToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataPelangganToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.KeluarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TransaksiToolStripMenuItem, Me.TransaksiToolStripMenuItem1, Me.LaporanToolStripMenuItem, Me.KeluarToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(661, 44)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'TransaksiToolStripMenuItem
        '
        Me.TransaksiToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DataBukuToolStripMenuItem, Me.DataPelangganToolStripMenuItem})
        Me.TransaksiToolStripMenuItem.Image = CType(resources.GetObject("TransaksiToolStripMenuItem.Image"), System.Drawing.Image)
        Me.TransaksiToolStripMenuItem.Name = "TransaksiToolStripMenuItem"
        Me.TransaksiToolStripMenuItem.Size = New System.Drawing.Size(102, 40)
        Me.TransaksiToolStripMenuItem.Text = "Master Data"
        Me.TransaksiToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'DataBukuToolStripMenuItem
        '
        Me.DataBukuToolStripMenuItem.Name = "DataBukuToolStripMenuItem"
        Me.DataBukuToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.DataBukuToolStripMenuItem.Text = "Data Buku"
        '
        'DataPelangganToolStripMenuItem
        '
        Me.DataPelangganToolStripMenuItem.Name = "DataPelangganToolStripMenuItem"
        Me.DataPelangganToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.DataPelangganToolStripMenuItem.Text = "Data Pelanggan"
        '
        'TransaksiToolStripMenuItem1
        '
        Me.TransaksiToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PembelianToolStripMenuItem, Me.PenjualanToolStripMenuItem})
        Me.TransaksiToolStripMenuItem1.Image = CType(resources.GetObject("TransaksiToolStripMenuItem1.Image"), System.Drawing.Image)
        Me.TransaksiToolStripMenuItem1.Name = "TransaksiToolStripMenuItem1"
        Me.TransaksiToolStripMenuItem1.Size = New System.Drawing.Size(66, 35)
        Me.TransaksiToolStripMenuItem1.Text = "Transaksi"
        Me.TransaksiToolStripMenuItem1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'PembelianToolStripMenuItem
        '
        Me.PembelianToolStripMenuItem.Name = "PembelianToolStripMenuItem"
        Me.PembelianToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.PembelianToolStripMenuItem.Text = "Pembelian"
        '
        'PenjualanToolStripMenuItem
        '
        Me.PenjualanToolStripMenuItem.Name = "PenjualanToolStripMenuItem"
        Me.PenjualanToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.PenjualanToolStripMenuItem.Text = "Penjualan"
        '
        'LaporanToolStripMenuItem
        '
        Me.LaporanToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LaporanDataToolStripMenuItem, Me.LaporanTransaksiToolStripMenuItem})
        Me.LaporanToolStripMenuItem.Image = CType(resources.GetObject("LaporanToolStripMenuItem.Image"), System.Drawing.Image)
        Me.LaporanToolStripMenuItem.Name = "LaporanToolStripMenuItem"
        Me.LaporanToolStripMenuItem.Size = New System.Drawing.Size(62, 35)
        Me.LaporanToolStripMenuItem.Text = "Laporan"
        Me.LaporanToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'LaporanDataToolStripMenuItem
        '
        Me.LaporanDataToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DataBukuToolStripMenuItem1, Me.DataPelangganToolStripMenuItem1})
        Me.LaporanDataToolStripMenuItem.Name = "LaporanDataToolStripMenuItem"
        Me.LaporanDataToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.LaporanDataToolStripMenuItem.Text = "Laporan Data"
        '
        'DataBukuToolStripMenuItem1
        '
        Me.DataBukuToolStripMenuItem1.Name = "DataBukuToolStripMenuItem1"
        Me.DataBukuToolStripMenuItem1.Size = New System.Drawing.Size(180, 22)
        Me.DataBukuToolStripMenuItem1.Text = "Data Buku"
        '
        'DataPelangganToolStripMenuItem1
        '
        Me.DataPelangganToolStripMenuItem1.Name = "DataPelangganToolStripMenuItem1"
        Me.DataPelangganToolStripMenuItem1.Size = New System.Drawing.Size(180, 22)
        Me.DataPelangganToolStripMenuItem1.Text = "Data Pelanggan"
        '
        'LaporanTransaksiToolStripMenuItem
        '
        Me.LaporanTransaksiToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DataPembelianToolStripMenuItem, Me.DataPelangganToolStripMenuItem2})
        Me.LaporanTransaksiToolStripMenuItem.Name = "LaporanTransaksiToolStripMenuItem"
        Me.LaporanTransaksiToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.LaporanTransaksiToolStripMenuItem.Text = "Laporan Transaksi"
        '
        'DataPembelianToolStripMenuItem
        '
        Me.DataPembelianToolStripMenuItem.Name = "DataPembelianToolStripMenuItem"
        Me.DataPembelianToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.DataPembelianToolStripMenuItem.Text = "Data Pembelian"
        '
        'DataPelangganToolStripMenuItem2
        '
        Me.DataPelangganToolStripMenuItem2.Name = "DataPelangganToolStripMenuItem2"
        Me.DataPelangganToolStripMenuItem2.Size = New System.Drawing.Size(180, 22)
        Me.DataPelangganToolStripMenuItem2.Text = "Data Pelanggan"
        '
        'KeluarToolStripMenuItem
        '
        Me.KeluarToolStripMenuItem.Image = CType(resources.GetObject("KeluarToolStripMenuItem.Image"), System.Drawing.Image)
        Me.KeluarToolStripMenuItem.Name = "KeluarToolStripMenuItem"
        Me.KeluarToolStripMenuItem.Size = New System.Drawing.Size(63, 40)
        Me.KeluarToolStripMenuItem.Text = "Keluar"
        Me.KeluarToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'FormMenuUtama
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(661, 256)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "FormMenuUtama"
        Me.Text = "MenuUtama"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents TransaksiToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DataBukuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DataPelangganToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TransaksiToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents PembelianToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PenjualanToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LaporanToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LaporanDataToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DataBukuToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents DataPelangganToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents LaporanTransaksiToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DataPembelianToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DataPelangganToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents KeluarToolStripMenuItem As ToolStripMenuItem
End Class
