<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class inputData
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(inputData))
        Me.group_rdJK = New System.Windows.Forms.GroupBox()
        Me.rbPR = New System.Windows.Forms.RadioButton()
        Me.rbLK = New System.Windows.Forms.RadioButton()
        Me.btnBatal = New System.Windows.Forms.Button()
        Me.btnBrowse = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rbYa = New System.Windows.Forms.RadioButton()
        Me.rbTidak = New System.Windows.Forms.RadioButton()
        Me.txtIPK = New System.Windows.Forms.TextBox()
        Me.cbProdi = New System.Windows.Forms.ComboBox()
        Me.txtNama = New System.Windows.Forms.TextBox()
        Me.txtNim = New System.Windows.Forms.TextBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.group_rdJK.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'group_rdJK
        '
        Me.group_rdJK.Controls.Add(Me.rbPR)
        Me.group_rdJK.Controls.Add(Me.rbLK)
        Me.group_rdJK.Location = New System.Drawing.Point(173, 276)
        Me.group_rdJK.Margin = New System.Windows.Forms.Padding(2)
        Me.group_rdJK.Name = "group_rdJK"
        Me.group_rdJK.Padding = New System.Windows.Forms.Padding(2)
        Me.group_rdJK.Size = New System.Drawing.Size(186, 32)
        Me.group_rdJK.TabIndex = 50
        Me.group_rdJK.TabStop = False
        '
        'rbPR
        '
        Me.rbPR.AutoSize = True
        Me.rbPR.Location = New System.Drawing.Point(95, 7)
        Me.rbPR.Margin = New System.Windows.Forms.Padding(2)
        Me.rbPR.Name = "rbPR"
        Me.rbPR.Size = New System.Drawing.Size(79, 17)
        Me.rbPR.TabIndex = 1
        Me.rbPR.TabStop = True
        Me.rbPR.Text = "Perempuan"
        Me.rbPR.UseVisualStyleBackColor = True
        '
        'rbLK
        '
        Me.rbLK.AutoSize = True
        Me.rbLK.Location = New System.Drawing.Point(3, 7)
        Me.rbLK.Margin = New System.Windows.Forms.Padding(2)
        Me.rbLK.Name = "rbLK"
        Me.rbLK.Size = New System.Drawing.Size(68, 17)
        Me.rbLK.TabIndex = 0
        Me.rbLK.TabStop = True
        Me.rbLK.Text = "Laki-Laki"
        Me.rbLK.UseVisualStyleBackColor = True
        '
        'btnBatal
        '
        Me.btnBatal.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.btnBatal.FlatAppearance.BorderSize = 0
        Me.btnBatal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBatal.Location = New System.Drawing.Point(252, 126)
        Me.btnBatal.Margin = New System.Windows.Forms.Padding(2)
        Me.btnBatal.Name = "btnBatal"
        Me.btnBatal.Size = New System.Drawing.Size(56, 26)
        Me.btnBatal.TabIndex = 45
        Me.btnBatal.Text = "Batal"
        Me.btnBatal.UseVisualStyleBackColor = False
        '
        'btnBrowse
        '
        Me.btnBrowse.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.btnBrowse.FlatAppearance.BorderSize = 0
        Me.btnBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBrowse.Location = New System.Drawing.Point(35, 126)
        Me.btnBrowse.Margin = New System.Windows.Forms.Padding(2)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.Size = New System.Drawing.Size(56, 26)
        Me.btnBrowse.TabIndex = 43
        Me.btnBrowse.Text = "Unggah"
        Me.btnBrowse.UseVisualStyleBackColor = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.DeepPink
        Me.Label11.Location = New System.Drawing.Point(33, 380)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(128, 17)
        Me.Label11.TabIndex = 42
        Me.Label11.Text = "Pernah Mengulang"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.DeepPink
        Me.Label10.Location = New System.Drawing.Point(33, 430)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(29, 17)
        Me.Label10.TabIndex = 41
        Me.Label10.Text = "IPK"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.DeepPink
        Me.Label9.Location = New System.Drawing.Point(33, 281)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(95, 17)
        Me.Label9.TabIndex = 40
        Me.Label9.Text = "Jenis Kelamin"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DeepPink
        Me.Label3.Location = New System.Drawing.Point(33, 331)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(98, 17)
        Me.Label3.TabIndex = 39
        Me.Label3.Text = "Program Studi"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DeepPink
        Me.Label2.Location = New System.Drawing.Point(33, 232)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(104, 17)
        Me.Label2.TabIndex = 38
        Me.Label2.Text = "Nama Lengkap"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DeepPink
        Me.Label1.Location = New System.Drawing.Point(33, 182)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(137, 17)
        Me.Label1.TabIndex = 37
        Me.Label1.Text = "No Induk Mahasiswa"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rbYa)
        Me.GroupBox1.Controls.Add(Me.rbTidak)
        Me.GroupBox1.Location = New System.Drawing.Point(174, 370)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Size = New System.Drawing.Size(185, 26)
        Me.GroupBox1.TabIndex = 36
        Me.GroupBox1.TabStop = False
        '
        'rbYa
        '
        Me.rbYa.AutoSize = True
        Me.rbYa.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.rbYa.Location = New System.Drawing.Point(4, 6)
        Me.rbYa.Margin = New System.Windows.Forms.Padding(2)
        Me.rbYa.Name = "rbYa"
        Me.rbYa.Size = New System.Drawing.Size(38, 17)
        Me.rbYa.TabIndex = 3
        Me.rbYa.TabStop = True
        Me.rbYa.Text = "Ya"
        Me.rbYa.UseVisualStyleBackColor = True
        '
        'rbTidak
        '
        Me.rbTidak.AutoSize = True
        Me.rbTidak.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.rbTidak.Location = New System.Drawing.Point(94, 6)
        Me.rbTidak.Margin = New System.Windows.Forms.Padding(2)
        Me.rbTidak.Name = "rbTidak"
        Me.rbTidak.Size = New System.Drawing.Size(52, 17)
        Me.rbTidak.TabIndex = 4
        Me.rbTidak.TabStop = True
        Me.rbTidak.Text = "Tidak"
        Me.rbTidak.UseVisualStyleBackColor = True
        '
        'txtIPK
        '
        Me.txtIPK.Location = New System.Drawing.Point(174, 424)
        Me.txtIPK.Margin = New System.Windows.Forms.Padding(2)
        Me.txtIPK.MaxLength = 4
        Me.txtIPK.Name = "txtIPK"
        Me.txtIPK.Size = New System.Drawing.Size(98, 20)
        Me.txtIPK.TabIndex = 35
        '
        'cbProdi
        '
        Me.cbProdi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbProdi.FormattingEnabled = True
        Me.cbProdi.Items.AddRange(New Object() {"Anatomi Manusia", "Biologi Sel", "Kalkulus", "Dasar-dasar Ekonomi", "Elemen Kimia", "Fisika Dasar", "Geografi Fisik", "Sejarah", "Informatika", "Jaringan Komunikasi", "Kebijakan Publik", "Logika Matematika", "Mikroekonomi", "Neurosains", "Organisasi Bisnis", "Psikologi Perkembangan", "Kuantum Fisika (Q untuk Quantum dalam bahasa Inggris)", "Rekayasa Perangkat Lunak", "Statistik", "Teori Politik", "Usaha Kecil dan Menengah", "Virologi", "Wirausaha", "Yurisprudensi ", "Zoologi"})
        Me.cbProdi.Location = New System.Drawing.Point(174, 332)
        Me.cbProdi.Margin = New System.Windows.Forms.Padding(2)
        Me.cbProdi.Name = "cbProdi"
        Me.cbProdi.Size = New System.Drawing.Size(101, 21)
        Me.cbProdi.TabIndex = 34
        '
        'txtNama
        '
        Me.txtNama.Location = New System.Drawing.Point(174, 227)
        Me.txtNama.Margin = New System.Windows.Forms.Padding(2)
        Me.txtNama.Name = "txtNama"
        Me.txtNama.Size = New System.Drawing.Size(186, 20)
        Me.txtNama.TabIndex = 33
        '
        'txtNim
        '
        Me.txtNim.Location = New System.Drawing.Point(174, 180)
        Me.txtNim.Margin = New System.Windows.Forms.Padding(2)
        Me.txtNim.MaxLength = 10
        Me.txtNim.Name = "txtNim"
        Me.txtNim.Size = New System.Drawing.Size(186, 20)
        Me.txtNim.TabIndex = 32
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(34, 6)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(89, 112)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 49
        Me.PictureBox2.TabStop = False
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.btnSave.FlatAppearance.BorderSize = 0
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Image = CType(resources.GetObject("btnSave.Image"), System.Drawing.Image)
        Me.btnSave.Location = New System.Drawing.Point(213, 126)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(2)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(34, 26)
        Me.btnSave.TabIndex = 48
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.btnDelete.FlatAppearance.BorderSize = 0
        Me.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDelete.Image = CType(resources.GetObject("btnDelete.Image"), System.Drawing.Image)
        Me.btnDelete.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnDelete.Location = New System.Drawing.Point(174, 126)
        Me.btnDelete.Margin = New System.Windows.Forms.Padding(2)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(34, 26)
        Me.btnDelete.TabIndex = 47
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'btnEdit
        '
        Me.btnEdit.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.btnEdit.FlatAppearance.BorderSize = 0
        Me.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEdit.Image = CType(resources.GetObject("btnEdit.Image"), System.Drawing.Image)
        Me.btnEdit.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnEdit.Location = New System.Drawing.Point(135, 126)
        Me.btnEdit.Margin = New System.Windows.Forms.Padding(2)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(34, 26)
        Me.btnEdit.TabIndex = 46
        Me.btnEdit.UseVisualStyleBackColor = False
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.btnAdd.FlatAppearance.BorderSize = 0
        Me.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdd.Image = CType(resources.GetObject("btnAdd.Image"), System.Drawing.Image)
        Me.btnAdd.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnAdd.Location = New System.Drawing.Point(96, 126)
        Me.btnAdd.Margin = New System.Windows.Forms.Padding(2)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(34, 26)
        Me.btnAdd.TabIndex = 44
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'inputData
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.group_rdJK)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.btnBatal)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.btnBrowse)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtIPK)
        Me.Controls.Add(Me.cbProdi)
        Me.Controls.Add(Me.txtNama)
        Me.Controls.Add(Me.txtNim)
        Me.Name = "inputData"
        Me.Size = New System.Drawing.Size(415, 463)
        Me.group_rdJK.ResumeLayout(False)
        Me.group_rdJK.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents group_rdJK As System.Windows.Forms.GroupBox
    Friend WithEvents rbPR As System.Windows.Forms.RadioButton
    Friend WithEvents rbLK As System.Windows.Forms.RadioButton
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnEdit As System.Windows.Forms.Button
    Friend WithEvents btnBatal As System.Windows.Forms.Button
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents btnBrowse As System.Windows.Forms.Button
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rbYa As System.Windows.Forms.RadioButton
    Friend WithEvents rbTidak As System.Windows.Forms.RadioButton
    Friend WithEvents txtIPK As System.Windows.Forms.TextBox
    Friend WithEvents cbProdi As System.Windows.Forms.ComboBox
    Friend WithEvents txtNama As System.Windows.Forms.TextBox
    Friend WithEvents txtNim As System.Windows.Forms.TextBox

End Class
