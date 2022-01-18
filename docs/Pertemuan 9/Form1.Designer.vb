<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ArrayMultiDimensi
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
        Me.txtnim = New System.Windows.Forms.TextBox()
        Me.txtnama = New System.Windows.Forms.TextBox()
        Me.cmbjk = New System.Windows.Forms.ComboBox()
        Me.cmbps = New System.Windows.Forms.ComboBox()
        Me.btntambah = New System.Windows.Forms.Button()
        Me.ListView = New System.Windows.Forms.ListView()
        Me.btnkeluar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Cambria", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(140, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(413, 22)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "DATA MAHASISWA FAKULTAS ILMU KOMPUTER"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Mongolian Baiti", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(169, 84)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(142, 14)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nomor Induk Mahasiswa"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Mongolian Baiti", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(169, 115)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(101, 14)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Nama Mahasiswa"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Mongolian Baiti", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(169, 148)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(83, 14)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Jenis Kelamin"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Mongolian Baiti", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(169, 184)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(84, 14)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Program Studi"
        '
        'txtnim
        '
        Me.txtnim.Location = New System.Drawing.Point(346, 81)
        Me.txtnim.Name = "txtnim"
        Me.txtnim.Size = New System.Drawing.Size(163, 20)
        Me.txtnim.TabIndex = 5
        '
        'txtnama
        '
        Me.txtnama.Location = New System.Drawing.Point(346, 115)
        Me.txtnama.Name = "txtnama"
        Me.txtnama.Size = New System.Drawing.Size(163, 20)
        Me.txtnama.TabIndex = 6
        '
        'cmbjk
        '
        Me.cmbjk.FormattingEnabled = True
        Me.cmbjk.Location = New System.Drawing.Point(346, 148)
        Me.cmbjk.Name = "cmbjk"
        Me.cmbjk.Size = New System.Drawing.Size(163, 21)
        Me.cmbjk.TabIndex = 7
        '
        'cmbps
        '
        Me.cmbps.FormattingEnabled = True
        Me.cmbps.Location = New System.Drawing.Point(346, 184)
        Me.cmbps.Name = "cmbps"
        Me.cmbps.Size = New System.Drawing.Size(163, 21)
        Me.cmbps.TabIndex = 8
        '
        'btntambah
        '
        Me.btntambah.Location = New System.Drawing.Point(271, 217)
        Me.btntambah.Name = "btntambah"
        Me.btntambah.Size = New System.Drawing.Size(75, 23)
        Me.btntambah.TabIndex = 9
        Me.btntambah.Text = "Tambah"
        Me.btntambah.UseVisualStyleBackColor = True
        '
        'ListView
        '
        Me.ListView.HideSelection = False
        Me.ListView.Location = New System.Drawing.Point(8, 253)
        Me.ListView.Name = "ListView"
        Me.ListView.Size = New System.Drawing.Size(670, 171)
        Me.ListView.TabIndex = 10
        Me.ListView.UseCompatibleStateImageBehavior = False
        '
        'btnkeluar
        '
        Me.btnkeluar.Location = New System.Drawing.Point(378, 217)
        Me.btnkeluar.Name = "btnkeluar"
        Me.btnkeluar.Size = New System.Drawing.Size(75, 23)
        Me.btnkeluar.TabIndex = 11
        Me.btnkeluar.Text = "Keluar"
        Me.btnkeluar.UseVisualStyleBackColor = True
        '
        'ArrayMultiDimensi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.ClientSize = New System.Drawing.Size(683, 426)
        Me.Controls.Add(Me.btnkeluar)
        Me.Controls.Add(Me.ListView)
        Me.Controls.Add(Me.btntambah)
        Me.Controls.Add(Me.cmbps)
        Me.Controls.Add(Me.cmbjk)
        Me.Controls.Add(Me.txtnama)
        Me.Controls.Add(Me.txtnim)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "ArrayMultiDimensi"
        Me.Text = "Array Multi Dimensi"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtnim As TextBox
    Friend WithEvents txtnama As TextBox
    Friend WithEvents cmbjk As ComboBox
    Friend WithEvents cmbps As ComboBox
    Friend WithEvents btntambah As Button
    Friend WithEvents ListView As ListView
    Friend WithEvents btnkeluar As Button
End Class
