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
        Me.btnfor = New System.Windows.Forms.Button()
        Me.btnwhile = New System.Windows.Forms.Button()
        Me.btnloopuntil = New System.Windows.Forms.Button()
        Me.btndowhile = New System.Windows.Forms.Button()
        Me.cmbfor = New System.Windows.Forms.ComboBox()
        Me.cmbloopuntil = New System.Windows.Forms.ComboBox()
        Me.listboxwhile = New System.Windows.Forms.ListBox()
        Me.listboxganjil = New System.Windows.Forms.ListBox()
        Me.listboxgenap = New System.Windows.Forms.ListBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Lucida Handwriting", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(237, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(313, 31)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "LOOPING STATEMENT"
        '
        'btnfor
        '
        Me.btnfor.Location = New System.Drawing.Point(32, 54)
        Me.btnfor.Name = "btnfor"
        Me.btnfor.Size = New System.Drawing.Size(75, 23)
        Me.btnfor.TabIndex = 1
        Me.btnfor.Text = "FOR"
        Me.btnfor.UseVisualStyleBackColor = True
        '
        'btnwhile
        '
        Me.btnwhile.Location = New System.Drawing.Point(32, 117)
        Me.btnwhile.Name = "btnwhile"
        Me.btnwhile.Size = New System.Drawing.Size(75, 23)
        Me.btnwhile.TabIndex = 2
        Me.btnwhile.Text = "WHILE"
        Me.btnwhile.UseVisualStyleBackColor = True
        '
        'btnloopuntil
        '
        Me.btnloopuntil.Location = New System.Drawing.Point(424, 54)
        Me.btnloopuntil.Name = "btnloopuntil"
        Me.btnloopuntil.Size = New System.Drawing.Size(102, 23)
        Me.btnloopuntil.TabIndex = 3
        Me.btnloopuntil.Text = "LOOP UNTIL"
        Me.btnloopuntil.UseVisualStyleBackColor = True
        '
        'btndowhile
        '
        Me.btndowhile.Location = New System.Drawing.Point(424, 117)
        Me.btndowhile.Name = "btndowhile"
        Me.btndowhile.Size = New System.Drawing.Size(75, 23)
        Me.btndowhile.TabIndex = 4
        Me.btndowhile.Text = "DO WHILE"
        Me.btndowhile.UseVisualStyleBackColor = True
        '
        'cmbfor
        '
        Me.cmbfor.FormattingEnabled = True
        Me.cmbfor.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15"})
        Me.cmbfor.Location = New System.Drawing.Point(146, 54)
        Me.cmbfor.Name = "cmbfor"
        Me.cmbfor.Size = New System.Drawing.Size(239, 21)
        Me.cmbfor.TabIndex = 5
        '
        'cmbloopuntil
        '
        Me.cmbloopuntil.FormattingEnabled = True
        Me.cmbloopuntil.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15"})
        Me.cmbloopuntil.Location = New System.Drawing.Point(543, 54)
        Me.cmbloopuntil.Name = "cmbloopuntil"
        Me.cmbloopuntil.Size = New System.Drawing.Size(121, 21)
        Me.cmbloopuntil.TabIndex = 6
        '
        'listboxwhile
        '
        Me.listboxwhile.FormattingEnabled = True
        Me.listboxwhile.Location = New System.Drawing.Point(146, 117)
        Me.listboxwhile.Name = "listboxwhile"
        Me.listboxwhile.Size = New System.Drawing.Size(239, 199)
        Me.listboxwhile.TabIndex = 7
        '
        'listboxganjil
        '
        Me.listboxganjil.FormattingEnabled = True
        Me.listboxganjil.Location = New System.Drawing.Point(543, 117)
        Me.listboxganjil.Name = "listboxganjil"
        Me.listboxganjil.Size = New System.Drawing.Size(120, 134)
        Me.listboxganjil.TabIndex = 8
        '
        'listboxgenap
        '
        Me.listboxgenap.FormattingEnabled = True
        Me.listboxgenap.Location = New System.Drawing.Point(693, 117)
        Me.listboxgenap.Name = "listboxgenap"
        Me.listboxgenap.Size = New System.Drawing.Size(120, 134)
        Me.listboxgenap.TabIndex = 9
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(553, 266)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(98, 16)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Bilangan Ganjil"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(706, 266)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(105, 16)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Bilangan Genap"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(843, 332)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.listboxgenap)
        Me.Controls.Add(Me.listboxganjil)
        Me.Controls.Add(Me.listboxwhile)
        Me.Controls.Add(Me.cmbloopuntil)
        Me.Controls.Add(Me.cmbfor)
        Me.Controls.Add(Me.btndowhile)
        Me.Controls.Add(Me.btnloopuntil)
        Me.Controls.Add(Me.btnwhile)
        Me.Controls.Add(Me.btnfor)
        Me.Controls.Add(Me.Label1)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Name = "Form1"
        Me.Text = "Looping"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btnfor As Button
    Friend WithEvents btnwhile As Button
    Friend WithEvents btnloopuntil As Button
    Friend WithEvents btndowhile As Button
    Friend WithEvents cmbfor As ComboBox
    Friend WithEvents cmbloopuntil As ComboBox
    Friend WithEvents listboxwhile As ListBox
    Friend WithEvents listboxganjil As ListBox
    Friend WithEvents listboxgenap As ListBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
End Class
