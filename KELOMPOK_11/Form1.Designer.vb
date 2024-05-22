<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(form1))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnInput = New System.Windows.Forms.Button()
        Me.btnGrafik = New System.Windows.Forms.Button()
        Me.btnInformasi = New System.Windows.Forms.Button()
        Me.btnIjazah = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnKeluar = New System.Windows.Forms.Button()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.InputData1 = New KELOMPOK_11.inputData()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Silver
        Me.Panel1.Controls.Add(Me.btnInput)
        Me.Panel1.Controls.Add(Me.btnGrafik)
        Me.Panel1.Controls.Add(Me.btnInformasi)
        Me.Panel1.Controls.Add(Me.btnIjazah)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.btnKeluar)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(182, 480)
        Me.Panel1.TabIndex = 6
        '
        'btnInput
        '
        Me.btnInput.FlatAppearance.BorderSize = 0
        Me.btnInput.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnInput.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInput.ForeColor = System.Drawing.SystemColors.Control
        Me.btnInput.Location = New System.Drawing.Point(1, 160)
        Me.btnInput.Margin = New System.Windows.Forms.Padding(2)
        Me.btnInput.Name = "btnInput"
        Me.btnInput.Padding = New System.Windows.Forms.Padding(19, 0, 0, 0)
        Me.btnInput.Size = New System.Drawing.Size(182, 36)
        Me.btnInput.TabIndex = 16
        Me.btnInput.Text = "Input Data"
        Me.btnInput.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnInput.UseVisualStyleBackColor = True
        '
        'btnGrafik
        '
        Me.btnGrafik.FlatAppearance.BorderSize = 0
        Me.btnGrafik.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGrafik.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGrafik.ForeColor = System.Drawing.SystemColors.Control
        Me.btnGrafik.Location = New System.Drawing.Point(1, 196)
        Me.btnGrafik.Margin = New System.Windows.Forms.Padding(2)
        Me.btnGrafik.Name = "btnGrafik"
        Me.btnGrafik.Padding = New System.Windows.Forms.Padding(19, 0, 0, 0)
        Me.btnGrafik.Size = New System.Drawing.Size(182, 36)
        Me.btnGrafik.TabIndex = 15
        Me.btnGrafik.Text = "Grafik Kelulusan"
        Me.btnGrafik.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGrafik.UseVisualStyleBackColor = True
        '
        'btnInformasi
        '
        Me.btnInformasi.FlatAppearance.BorderSize = 0
        Me.btnInformasi.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnInformasi.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInformasi.ForeColor = System.Drawing.SystemColors.Control
        Me.btnInformasi.Location = New System.Drawing.Point(1, 230)
        Me.btnInformasi.Margin = New System.Windows.Forms.Padding(2)
        Me.btnInformasi.Name = "btnInformasi"
        Me.btnInformasi.Padding = New System.Windows.Forms.Padding(19, 0, 0, 0)
        Me.btnInformasi.Size = New System.Drawing.Size(182, 36)
        Me.btnInformasi.TabIndex = 14
        Me.btnInformasi.Text = "Informasi Kelulusan"
        Me.btnInformasi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnInformasi.UseVisualStyleBackColor = True
        '
        'btnIjazah
        '
        Me.btnIjazah.FlatAppearance.BorderSize = 0
        Me.btnIjazah.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnIjazah.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnIjazah.ForeColor = System.Drawing.SystemColors.Control
        Me.btnIjazah.Location = New System.Drawing.Point(1, 265)
        Me.btnIjazah.Margin = New System.Windows.Forms.Padding(2)
        Me.btnIjazah.Name = "btnIjazah"
        Me.btnIjazah.Padding = New System.Windows.Forms.Padding(19, 0, 0, 0)
        Me.btnIjazah.Size = New System.Drawing.Size(182, 36)
        Me.btnIjazah.TabIndex = 13
        Me.btnIjazah.Text = "Ijazah dan Laporan"
        Me.btnIjazah.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnIjazah.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.KELOMPOK_11.My.Resources.Resources.garuda
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(27, 25)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(119, 89)
        Me.PictureBox1.TabIndex = 12
        Me.PictureBox1.TabStop = False
        '
        'btnKeluar
        '
        Me.btnKeluar.FlatAppearance.BorderSize = 0
        Me.btnKeluar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnKeluar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnKeluar.ForeColor = System.Drawing.SystemColors.Control
        Me.btnKeluar.Location = New System.Drawing.Point(1, 425)
        Me.btnKeluar.Margin = New System.Windows.Forms.Padding(2)
        Me.btnKeluar.Name = "btnKeluar"
        Me.btnKeluar.Padding = New System.Windows.Forms.Padding(19, 0, 0, 0)
        Me.btnKeluar.Size = New System.Drawing.Size(182, 36)
        Me.btnKeluar.TabIndex = 11
        Me.btnKeluar.Text = "Keluar"
        Me.btnKeluar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnKeluar.UseVisualStyleBackColor = True
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'InputData1
        '
        Me.InputData1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.InputData1.Location = New System.Drawing.Point(182, 0)
        Me.InputData1.Name = "InputData1"
        Me.InputData1.Size = New System.Drawing.Size(690, 480)
        Me.InputData1.TabIndex = 7
        '
        'form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(872, 480)
        Me.Controls.Add(Me.InputData1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "s"
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents btnKeluar As System.Windows.Forms.Button
    Friend WithEvents PrintPreviewDialog1 As System.Windows.Forms.PrintPreviewDialog
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
    Friend WithEvents btnIjazah As System.Windows.Forms.Button
    Friend WithEvents btnInput As System.Windows.Forms.Button
    Friend WithEvents btnGrafik As System.Windows.Forms.Button
    Friend WithEvents btnInformasi As System.Windows.Forms.Button
    Friend WithEvents InputData1 As KELOMPOK_11.inputData

End Class
