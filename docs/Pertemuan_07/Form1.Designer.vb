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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtangka1 = New System.Windows.Forms.TextBox()
        Me.txtangka2 = New System.Windows.Forms.TextBox()
        Me.txthasil = New System.Windows.Forms.TextBox()
        Me.btnpangkat = New System.Windows.Forms.Button()
        Me.btnkurang = New System.Windows.Forms.Button()
        Me.btntambah = New System.Windows.Forms.Button()
        Me.btnkali = New System.Windows.Forms.Button()
        Me.btnbagi = New System.Windows.Forms.Button()
        Me.lblangka1 = New System.Windows.Forms.Label()
        Me.lblangka2 = New System.Windows.Forms.Label()
        Me.lblhasil = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Monotype Corsiva", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(160, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(195, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Kalkulator Sederhana"
        '
        'txtangka1
        '
        Me.txtangka1.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtangka1.Location = New System.Drawing.Point(165, 88)
        Me.txtangka1.Name = "txtangka1"
        Me.txtangka1.Size = New System.Drawing.Size(126, 25)
        Me.txtangka1.TabIndex = 1
        '
        'txtangka2
        '
        Me.txtangka2.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtangka2.Location = New System.Drawing.Point(165, 133)
        Me.txtangka2.Name = "txtangka2"
        Me.txtangka2.Size = New System.Drawing.Size(126, 25)
        Me.txtangka2.TabIndex = 2
        '
        'txthasil
        '
        Me.txthasil.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txthasil.Location = New System.Drawing.Point(165, 180)
        Me.txthasil.Name = "txthasil"
        Me.txthasil.Size = New System.Drawing.Size(126, 25)
        Me.txthasil.TabIndex = 3
        '
        'btnpangkat
        '
        Me.btnpangkat.Location = New System.Drawing.Point(333, 222)
        Me.btnpangkat.Name = "btnpangkat"
        Me.btnpangkat.Size = New System.Drawing.Size(75, 23)
        Me.btnpangkat.TabIndex = 4
        Me.btnpangkat.Text = "Pangkat(^)"
        Me.btnpangkat.UseVisualStyleBackColor = True
        '
        'btnkurang
        '
        Me.btnkurang.Location = New System.Drawing.Point(333, 106)
        Me.btnkurang.Name = "btnkurang"
        Me.btnkurang.Size = New System.Drawing.Size(75, 23)
        Me.btnkurang.TabIndex = 6
        Me.btnkurang.Text = "Kurang(-)"
        Me.btnkurang.UseVisualStyleBackColor = True
        '
        'btntambah
        '
        Me.btntambah.Location = New System.Drawing.Point(333, 66)
        Me.btntambah.Name = "btntambah"
        Me.btntambah.Size = New System.Drawing.Size(75, 23)
        Me.btntambah.TabIndex = 7
        Me.btntambah.Text = "Tambah (+)"
        Me.btntambah.UseVisualStyleBackColor = True
        '
        'btnkali
        '
        Me.btnkali.Location = New System.Drawing.Point(333, 146)
        Me.btnkali.Name = "btnkali"
        Me.btnkali.Size = New System.Drawing.Size(75, 23)
        Me.btnkali.TabIndex = 8
        Me.btnkali.Text = "Kali(*)"
        Me.btnkali.UseVisualStyleBackColor = True
        '
        'btnbagi
        '
        Me.btnbagi.Location = New System.Drawing.Point(333, 184)
        Me.btnbagi.Name = "btnbagi"
        Me.btnbagi.Size = New System.Drawing.Size(75, 23)
        Me.btnbagi.TabIndex = 9
        Me.btnbagi.Text = "Bagi(/)"
        Me.btnbagi.UseVisualStyleBackColor = True
        '
        'lblangka1
        '
        Me.lblangka1.AutoSize = True
        Me.lblangka1.Location = New System.Drawing.Point(87, 90)
        Me.lblangka1.Name = "lblangka1"
        Me.lblangka1.Size = New System.Drawing.Size(49, 14)
        Me.lblangka1.TabIndex = 10
        Me.lblangka1.Text = "Angka 1"
        '
        'lblangka2
        '
        Me.lblangka2.AutoSize = True
        Me.lblangka2.Location = New System.Drawing.Point(86, 136)
        Me.lblangka2.Name = "lblangka2"
        Me.lblangka2.Size = New System.Drawing.Size(49, 14)
        Me.lblangka2.TabIndex = 11
        Me.lblangka2.Text = "Angka 2"
        '
        'lblhasil
        '
        Me.lblhasil.AutoSize = True
        Me.lblhasil.Location = New System.Drawing.Point(87, 180)
        Me.lblhasil.Name = "lblhasil"
        Me.lblhasil.Size = New System.Drawing.Size(34, 14)
        Me.lblhasil.TabIndex = 12
        Me.lblhasil.Text = "Hasil"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(193, 222)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 13
        Me.Button1.Text = "Delete"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(509, 300)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lblhasil)
        Me.Controls.Add(Me.lblangka2)
        Me.Controls.Add(Me.lblangka1)
        Me.Controls.Add(Me.btnbagi)
        Me.Controls.Add(Me.btnkali)
        Me.Controls.Add(Me.btntambah)
        Me.Controls.Add(Me.btnkurang)
        Me.Controls.Add(Me.btnpangkat)
        Me.Controls.Add(Me.txthasil)
        Me.Controls.Add(Me.txtangka2)
        Me.Controls.Add(Me.txtangka1)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Monotype Corsiva", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "Form1"
        Me.Text = "Kalkulator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtangka1 As TextBox
    Friend WithEvents txtangka2 As TextBox
    Friend WithEvents txthasil As TextBox
    Friend WithEvents btnpangkat As Button
    Friend WithEvents btnkurang As Button
    Friend WithEvents btntambah As Button
    Friend WithEvents btnkali As Button
    Friend WithEvents btnbagi As Button
    Friend WithEvents lblangka1 As Label
    Friend WithEvents lblangka2 As Label
    Friend WithEvents lblhasil As Label
    Friend WithEvents Button1 As Button
End Class
