Public Class form1
    
    

  
    'Private Sub btncetak_click(sender As Object, e As eventargs) Handles btncetak.click
    '    _isempty = False
    '    isempty()
    '    check_ipk()
    '    iscumluade()
    '    gelartext()

    '    If _isempty Then
    '        Me.printpreviewdialog1.showdialog()

    '    End If


    'End Sub

    

    Private Sub form1_load(sender As Object, e As EventArgs) Handles MyBase.Load
        AddHandler printdocument1.printpage, AddressOf Me.printdocument1_printpage
        Me.PrintPreviewDialog1.Document = Me.PrintDocument1
        btnInput.BackColor = Color.DeepPink

        koneksi()

    End Sub


    

    Private Sub printdocument1_printpage(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs)
        Dim f As font = New font("calibri", 14, fontstyle.bold)
        Dim g As font = New font("calibri", 24, fontstyle.bold)
        Dim tnr As font = New font("times new roman", 24, fontstyle.bold)
        Dim h As font = New font("calibri", 22, fontstyle.bold)
        Dim i As font = New font("calibri", 12, fontstyle.bold)
        Dim j As font = New font("calibri", 12.5, fontstyle.bold)
        Dim br As solidbrush = New solidbrush(color.black)
        Dim red As solidbrush = New solidbrush(color.darkblue)
        Dim skom As solidbrush = New solidbrush(color.darkred)
        Dim p As pen = New pen(color.black)

        Dim startx As Integer = 50
        Dim startx1 As Integer = 35
        Dim starty As Integer = 50
        Dim starty1 As Integer = 35
        Dim boxwidth As Integer = 750
        Dim boxwidth1 As Integer = 780
        Dim boxheight As Integer = 420
        Dim boxheight1 As Integer = 450
        Dim lineheight As Integer = 25

        e.graphics.drawrectangle(p, startx, starty, boxwidth, boxheight)
        e.graphics.drawrectangle(p, startx1, starty1, boxwidth1, boxheight1)

        starty += 10
        Dim stringformat As New stringformat()
        stringformat.alignment = stringalignment.center
        e.graphics.drawstring("kementerian bumi jaya operomasi", tnr, br, New rectangle(startx, starty, boxwidth, boxheight), stringformat)
        starty += lineheight * 1.25
        e.graphics.drawstring("universitas garuda jaya", tnr, br, New rectangle(startx, starty, boxwidth, boxheight), stringformat)
        starty += lineheight * 2
        e.graphics.drawstring("dengan ini menyatakan bahwa", f, br, New rectangle(startx, starty, boxwidth, boxheight), stringformat)
        starty += lineheight

        e.Graphics.DrawString(InputData1.txtNama.Text, h, red, New Rectangle(startx, starty, boxwidth, boxheight), stringformat)
        starty += lineheight * 1.25
        e.Graphics.DrawString(InputData1.txtNim.Text, f, br, New Rectangle(startx, starty, boxwidth, boxheight), stringformat)
        starty += lineheight * 1.5

        e.Graphics.DrawString("telah menyelesaikan studi dan memenuhi segala syarat pendidikan strata satu program studi " & InputData1.cbProdi.Text, i, br, New Rectangle(startx, starty, boxwidth, boxheight), stringformat)
        starty += lineheight * 1.65

        e.graphics.drawstring("lulus pada tanggal 20 juni 2024", j, br, New rectangle(startx, starty, boxwidth, boxheight), stringformat)
        starty += lineheight

        e.graphics.drawstring("oleh sebab itu, padanya diberikan gelar", i, br, New rectangle(startx, starty, boxwidth, boxheight), stringformat)
        starty += lineheight
        e.Graphics.DrawString(InputData1.gelar, g, skom, New Rectangle(startx, starty, boxwidth, boxheight), stringformat)
        starty += lineheight * 1.5
        e.Graphics.DrawString(InputData1.predikat, f, br, New Rectangle(startx, starty, boxwidth, boxheight), stringformat)
        starty += lineheight * 2

        e.graphics.drawstring("dengan segala hak dan kewajiban yang melekat pada gelar tersebut", f, br, New rectangle(startx, starty, boxwidth, boxheight), stringformat)
    End Sub


    Private Sub printdocument1_printpage_1(sender As Object, e As printing.printpageeventargs) Handles printdocument1.printpage

    End Sub
    'Dim onhover = color.aqua
    'Dim onleave = color.white

    'Private Sub label4_mouseenter(sender As Object, e As eventargs) Handles label4.mouseenter
    '    label4.forecolor = onhover

    'End Sub



    'Private Sub label4_mouseleave(sender As Object, e As eventargs) Handles label4.mouseleave
    '    label4.forecolor = onleave

    'End Sub

    'Private Sub label5_mouseenter(sender As Object, e As eventargs) Handles label5.mouseenter
    '    label5.forecolor = onhover

    'End Sub

    'Private Sub label5_mouseleave(sender As Object, e As eventargs) Handles label5.mouseleave
    '    label5.forecolor = onleave

    'End Sub


    'Private Sub label6_mouseenter(sender As Object, e As eventargs) Handles label6.mouseenter
    '    label6.forecolor = onhover
    'End Sub

    'Private Sub label6_mouseleave(sender As Object, e As eventargs) Handles label6.mouseleave
    '    label6.forecolor = onleave
    'End Sub


    'Private Sub label7_mouseenter(sender As Object, e As eventargs)
    '    label7.forecolor = onhover
    'End Sub

    'Private Sub label7_mouseleave(sender As Object, e As eventargs)
    '    label7.forecolor = onleave
    'End Sub

    'Private Sub label8_mouseenter(sender As Object, e As eventargs)
    '    label8.forecolor = onhover

    'End Sub


    'Private Sub label8_mouseleave(sender As Object, e As eventargs)
    '    label8.forecolor = onleave
    'End Sub

    Private Sub btnKeluar_Click(sender As Object, e As EventArgs) Handles btnKeluar.Click
        btnKeluar.BackColor = Color.DeepPink
        Me.Close()
    End Sub

    Private Sub btnInput_Click(sender As Object, e As EventArgs) Handles btnInput.Click
        btnInput.BackColor = Color.DeepPink
        btnGrafik.BackColor = Color.Silver
        btnInformasi.BackColor = Color.Silver
        btnIjazah.BackColor = Color.Silver
    End Sub

    Private Sub btnGrafik_Click(sender As Object, e As EventArgs) Handles btnGrafik.Click
        btnGrafik.BackColor = Color.DeepPink
        btnInput.BackColor = Color.Silver
        btnInformasi.BackColor = Color.Silver
        btnIjazah.BackColor = Color.Silver
    End Sub

    Private Sub btnInformasi_Click(sender As Object, e As EventArgs) Handles btnInformasi.Click
        btnGrafik.BackColor = Color.Silver
        btnInput.BackColor = Color.Silver
        btnInformasi.BackColor = Color.DeepPink
        btnIjazah.BackColor = Color.Silver
    End Sub

    Private Sub btnIjazah_Click(sender As Object, e As EventArgs) Handles btnIjazah.Click
        btnGrafik.BackColor = Color.Silver
        btnInput.BackColor = Color.Silver
        btnInformasi.BackColor = Color.Silver
        btnIjazah.BackColor = Color.DeepPink
    End Sub

  
    


End Class
