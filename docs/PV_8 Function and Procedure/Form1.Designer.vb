<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FunctionProcedure
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
        Me.txtangka1 = New System.Windows.Forms.TextBox()
        Me.txtangka2 = New System.Windows.Forms.TextBox()
        Me.txthasil = New System.Windows.Forms.TextBox()
        Me.btntambah = New System.Windows.Forms.Button()
        Me.btnkurang = New System.Windows.Forms.Button()
        Me.btnkali = New System.Windows.Forms.Button()
        Me.btnbagi = New System.Windows.Forms.Button()
        Me.btnpangkat = New System.Windows.Forms.Button()
        Me.btnrefresh = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Forte", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(107, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(241, 26)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Kalkulator Sederhana"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(52, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Angka 1"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(52, 117)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Angka 2"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(52, 160)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(36, 16)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Hasil"
        '
        'txtangka1
        '
        Me.txtangka1.Location = New System.Drawing.Point(120, 72)
        Me.txtangka1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtangka1.Name = "txtangka1"
        Me.txtangka1.Size = New System.Drawing.Size(116, 22)
        Me.txtangka1.TabIndex = 4
        '
        'txtangka2
        '
        Me.txtangka2.Location = New System.Drawing.Point(120, 115)
        Me.txtangka2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtangka2.Name = "txtangka2"
        Me.txtangka2.Size = New System.Drawing.Size(116, 22)
        Me.txtangka2.TabIndex = 5
        '
        'txthasil
        '
        Me.txthasil.Location = New System.Drawing.Point(120, 160)
        Me.txthasil.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txthasil.Name = "txthasil"
        Me.txthasil.Size = New System.Drawing.Size(116, 22)
        Me.txthasil.TabIndex = 6
        '
        'btntambah
        '
        Me.btntambah.Location = New System.Drawing.Point(290, 64)
        Me.btntambah.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btntambah.Name = "btntambah"
        Me.btntambah.Size = New System.Drawing.Size(87, 28)
        Me.btntambah.TabIndex = 7
        Me.btntambah.Text = "Tambah (+)"
        Me.btntambah.UseVisualStyleBackColor = True
        '
        'btnkurang
        '
        Me.btnkurang.Location = New System.Drawing.Point(290, 99)
        Me.btnkurang.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnkurang.Name = "btnkurang"
        Me.btnkurang.Size = New System.Drawing.Size(87, 28)
        Me.btnkurang.TabIndex = 8
        Me.btnkurang.Text = "Kurang (-)"
        Me.btnkurang.UseVisualStyleBackColor = True
        '
        'btnkali
        '
        Me.btnkali.Location = New System.Drawing.Point(290, 134)
        Me.btnkali.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnkali.Name = "btnkali"
        Me.btnkali.Size = New System.Drawing.Size(87, 28)
        Me.btnkali.TabIndex = 9
        Me.btnkali.Text = "Kali (*)"
        Me.btnkali.UseVisualStyleBackColor = True
        '
        'btnbagi
        '
        Me.btnbagi.Location = New System.Drawing.Point(290, 170)
        Me.btnbagi.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnbagi.Name = "btnbagi"
        Me.btnbagi.Size = New System.Drawing.Size(87, 28)
        Me.btnbagi.TabIndex = 10
        Me.btnbagi.Text = "Bagi (/)"
        Me.btnbagi.UseVisualStyleBackColor = True
        '
        'btnpangkat
        '
        Me.btnpangkat.Location = New System.Drawing.Point(290, 205)
        Me.btnpangkat.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnpangkat.Name = "btnpangkat"
        Me.btnpangkat.Size = New System.Drawing.Size(87, 28)
        Me.btnpangkat.TabIndex = 11
        Me.btnpangkat.Text = "Pangkat (^)"
        Me.btnpangkat.UseVisualStyleBackColor = True
        '
        'btnrefresh
        '
        Me.btnrefresh.Location = New System.Drawing.Point(134, 205)
        Me.btnrefresh.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnrefresh.Name = "btnrefresh"
        Me.btnrefresh.Size = New System.Drawing.Size(87, 28)
        Me.btnrefresh.TabIndex = 12
        Me.btnrefresh.Text = "Refresh"
        Me.btnrefresh.UseVisualStyleBackColor = True
        '
        'FunctionProcedure
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(448, 276)
        Me.Controls.Add(Me.btnrefresh)
        Me.Controls.Add(Me.btnpangkat)
        Me.Controls.Add(Me.btnbagi)
        Me.Controls.Add(Me.btnkali)
        Me.Controls.Add(Me.btnkurang)
        Me.Controls.Add(Me.btntambah)
        Me.Controls.Add(Me.txthasil)
        Me.Controls.Add(Me.txtangka2)
        Me.Controls.Add(Me.txtangka1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Californian FB", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "FunctionProcedure"
        Me.Text = "FunctionAndProcedure"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtangka1 As TextBox
    Friend WithEvents txtangka2 As TextBox
    Friend WithEvents txthasil As TextBox
    Friend WithEvents btntambah As Button
    Friend WithEvents btnkurang As Button
    Friend WithEvents btnkali As Button
    Friend WithEvents btnbagi As Button
    Friend WithEvents btnpangkat As Button
    Friend WithEvents btnrefresh As Button
End Class
