Imports MySql.Data.MySqlClient

Public Class inputData
    Dim isngulang As String
    Public ipk As Double
    Public gelar As String
    Public predikat As String
    Dim _isempty = False
    Dim jenisKelamin
    'Dim dataMhs As New List(Of String)
    Dim dataMhs As New List(Of List(Of String))()

    Public countDataMhs As Integer


    Public Sub onlychar(e As KeyPressEventArgs)
        Dim btn As Integer = Asc(e.KeyChar)
        If Not (((btn >= 65) And (btn <= 90)) Or ((btn >= 97) And (btn <= 122)) Or
        (btn = 8) Or (btn = 32) Or (btn = 46)) Then
            e.Handled = True


        End If


    End Sub

    Public Sub onlynum(e As KeyPressEventArgs)
        Dim btn As Integer = Asc(e.KeyChar)
        If Not (((btn >= 48) And (btn <= 57)) Or (btn = 8)) Then
            e.Handled = True
        End If


    End Sub

    Public Sub onlynum_ipk(e As KeyPressEventArgs)
        Dim btn As Integer = Asc(e.KeyChar)
        If Not (((btn >= 48) And (btn <= 57)) Or (btn = 8) Or (btn = 46)) Then
            e.Handled = True
        End If

    End Sub

    Public Sub check_ipk()
        ipk = CDbl(Val(txtIPK.Text))

        If (ipk > 4.0) Then

            MessageBox.Show("ipk melebihi batas", "kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error)
            _isempty = False

            txtIPK.Clear()
        ElseIf (ipk < 2) Then
            MessageBox.Show("ipk anda kurang", "kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtIPK.Clear()
            _isempty = False

        End If
    End Sub

    Public Sub isempty()
        If txtNim.Text = "" Then
            MessageBox.Show("nim wajib diisi", "kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error)

            'msgbox("nim wajib diisi")
            txtNim.Select()
        ElseIf txtNama.Text = "" Then
            MessageBox.Show("nama wajib diisi", "kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtNama.Select()

        ElseIf cbProdi.Text = "" Then
            MessageBox.Show("prodi wajib diisi", "kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error)

            'msgbox("prodi wajib diisi")
            'txtnama.select()
        ElseIf isngulang = "" Then
            MessageBox.Show("pernah mengulang wajib diisi", "kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error)

            'msgbox("pernah mengulang wajib diisi")

        ElseIf txtIPK.Text = "" Then
            MessageBox.Show("nilai ipk wajib diisi", "kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error)

            'msgbox("nilai ipk wajib diisi")
            txtIPK.Select()
        Else
            _isempty = True

        End If

    End Sub

    Public Sub iscumluade()
        If (ipk >= 3.51) And isngulang = "tidak" Then
            predikat = "predikat cumluade"
        ElseIf (ipk <= 3.5) And (ipk >= 3.01) Then
            predikat = "predikat sangat memuaskan"

        ElseIf (ipk <= 3.0) And (ipk >= 2.76) Then
            predikat = "predikat memuaskan"
        ElseIf (ipk <= 2.75) And (ipk >= 2) Then
            predikat = "predikat cukup"

        Else
            predikat = ""

        End If
    End Sub

    Public Sub gelartext()
        If cbProdi.Text = "anatomi manusia" Then
            gelar = "sarjana kedokteran (s.ked)"
        ElseIf cbProdi.Text = "biologi sel" Then
            gelar = "sarjana sains (s.si)"
        ElseIf cbProdi.Text = "kalkulus" Then
            gelar = "sarjana teknik (s.t.)"
        ElseIf cbProdi.Text = "dasar-dasar ekonomi" Then
            gelar = "sarjana ekonomi (s.e.)"
        ElseIf cbProdi.Text = "elemen kimia" Then
            gelar = "sarjana kimia (s.kim)"
        ElseIf cbProdi.Text = "fisika dasar" Then
            gelar = "sarjana fisika (s.fis)"
        ElseIf cbProdi.Text = "geografi fisik" Then
            gelar = "sarjana geografi (s.geog)"
        ElseIf cbProdi.Text = "sejarah" Then
            gelar = "sarjana humaniora (s.hum)"
        ElseIf cbProdi.Text = "informatika" Then
            gelar = "sarjana komputer (s.kom)"
        ElseIf cbProdi.Text = "jaringan komunikasi" Then
            gelar = "sarjana jaringan (s.j.)"
        ElseIf cbProdi.Text = "kebijakan publik" Then
            gelar = "sarjana ilmu politik (s.ip)"
        ElseIf cbProdi.Text = "logika matematika" Then
            gelar = "sarjana matematika (s.mat)"
        ElseIf cbProdi.Text = "mikroekonomi" Then
            gelar = "sarjana ekonomi (s.e.)"
        ElseIf cbProdi.Text = "neurosains" Then
            gelar = "sarjana neurosains (s.n.)"
        ElseIf cbProdi.Text = "organisasi bisnis" Then
            gelar = "sarjana ilmu bisnis (s.ib)"
        ElseIf cbProdi.Text = "psikologi perkembangan" Then
            gelar = "sarjana psikologi (s.psi)"
        ElseIf cbProdi.Text = "kuantum fisika" Then
            gelar = "sarjana fisika (s.fis)"
        ElseIf cbProdi.Text = "rekayasa perangkat lunak" Then
            gelar = "sarjana komputer (s.kom)"
        ElseIf cbProdi.Text = "statistik" Then
            gelar = "sarjana statistik (s.s.)"
        ElseIf cbProdi.Text = "teori politik" Then
            gelar = "sarjana politik (s.pol.)"
        ElseIf cbProdi.Text = "usaha kecil dan menengah" Then
            gelar = "sarjana ekonomi (s.e.)"
        ElseIf cbProdi.Text = "virologi" Then
            gelar = "sarjana virologi (s.v.)"
        ElseIf cbProdi.Text = "wirausaha" Then
            gelar = "sarjana wirausaha (s.wira)"
        ElseIf cbProdi.Text = "yurisprudensi" Then
            gelar = "sarjana hukum (s.h.)"
        ElseIf cbProdi.Text = "zoologi" Then
            gelar = "sarjana biologi (s.bio)"
        End If


    End Sub

    Private Sub txtnim_keypress(sender As Object, e As KeyPressEventArgs) Handles txtNim.KeyPress
        onlynum(e)

    End Sub

    Private Sub txtnama_keypress(sender As Object, e As KeyPressEventArgs) Handles txtNama.KeyPress
        onlychar(e)

    End Sub

    Private Sub txtipk_keypress(sender As Object, e As KeyPressEventArgs) Handles txtIPK.KeyPress
        onlynum_ipk(e)

    End Sub



    Private Sub rbya_checkedchanged(sender As Object, e As EventArgs) Handles rbYa.CheckedChanged
        isngulang = "ya"
    End Sub

    Private Sub rbtidak_checkedchanged(sender As Object, e As EventArgs) Handles rbTidak.CheckedChanged
        isngulang = "tidak"
    End Sub

    Private Sub rbLK_CheckedChanged(sender As Object, e As EventArgs) Handles rbLK.CheckedChanged
        jenisKelamin = "laki-laki"
    End Sub
    Private Sub rbPR_CheckedChanged(sender As Object, e As EventArgs) Handles rbPR.CheckedChanged
        jenisKelamin = "perempuan"
    End Sub

    Private Sub empety()
        'clear all field
        txtNama.Clear()
        txtNim.Clear()
        txtIPK.Clear()
        cbProdi.SelectedIndex = -1
        rbYa.Checked = False
        rbTidak.Checked = False
        rbLK.Checked = False
        rbPR.Checked = False
    End Sub

    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        empety()


    End Sub


    Private Sub inputData_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        'open the file explorer
        Dim openFile As New OpenFileDialog()
        Try
            openFile.Filter = "JPEG(*.jpeg;*.jpg)|*.jpg|PNG(+.png)|*.png"
            If openFile.ShowDialog() = Windows.Forms.DialogResult.OK Then
                PictureBox2.Image = Image.FromFile(openFile.FileName)
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

        isempty()
        check_ipk()

        If _isempty Then
            dataMhs.Add(New List(Of String) From {txtNim.Text, txtNama.Text, jenisKelamin, cbProdi.Text, isngulang, txtIPK.Text})
            'For Each value In dataMhs
            '    Console.WriteLine(value)
            'Next
            empety()
            countDataMhs = dataMhs.Count

            'access the list
            For Each row As List(Of String) In dataMhs
                'For Each item As String In row
                '    Console.WriteLine(item)

                'Next
                Console.WriteLine(row(0))
                Console.WriteLine(row(1))
                Console.WriteLine(row(2))

            Next
            Console.WriteLine(countDataMhs)

            'CreateObject("WScript.Shell").Popup("Welcome", 1, "Title")

        End If


    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim q As String = "INSERT INTO mahasiswa values(@nim,@nama,@jenisKelamin,@prodi,@isngulang,@ipk)"

        If countDataMhs = 0 Then
            isempty()

            If _isempty Then
                dataMhs.Add(New List(Of String) From {txtNim.Text, txtNama.Text, jenisKelamin, cbProdi.Text, isngulang, txtIPK.Text})
                cmd = New MySqlCommand(q, conn)
                cmd.Parameters.AddWithValue("nim", txtNim.Text)
                cmd.Parameters.AddWithValue("nama", txtNama.Text)
                cmd.Parameters.AddWithValue("jenisKelamin", jenisKelamin)
                cmd.Parameters.AddWithValue("prodi", cbProdi.Text)
                cmd.Parameters.AddWithValue("isngulang", isngulang)
                cmd.Parameters.AddWithValue("ipk", txtIPK.Text)
                cmd.ExecuteNonQuery()
                MsgBox("berhasil ditambah ke db")
                empety()

            Else




            End If
            'MessageBox.Show("", "kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            For Each row As List(Of String) In dataMhs

                cmd = New MySqlCommand(q, conn)
                cmd.Parameters.AddWithValue("nim", row(0))
                cmd.Parameters.AddWithValue("nama", row(1))
                cmd.Parameters.AddWithValue("jenisKelamin", row(2))
                cmd.Parameters.AddWithValue("prodi", row(3))
                cmd.Parameters.AddWithValue("isngulang", row(4))
                cmd.Parameters.AddWithValue("ipk", row(5))
                cmd.ExecuteNonQuery()


            Next
            MsgBox("berhasil ditambah ke db")


        End If
    End Sub

    
End Class
