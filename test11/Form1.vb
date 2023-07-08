Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim name As String

        Dim sthira As String
        Dim kuli As String
        Dim ammala As String

        Dim ol As String
        Dim al As String
        Dim degree As String

        Dim occupation As String

        Dim kollekinnw As String
        Dim kollekna As String
        Dim kellekinnw As String
        Dim kellekna As String

        Dim depala As String
        Dim adayama As String

        Dim yes As String
        Dim no As String

        Dim ela As String
        Dim ew As String
        Dim hpo As String

        Dim s As String
        Dim l As String



        occupation = ListBox1.SelectedItem
        depala = ListBox2.SelectedItem
        adayama = ListBox3.SelectedItem
        ew = ListBox4.SelectedItem
        hpo = ListBox5.SelectedItem






        Dim x(3, 8) As String

        x(0, 0) = "G.C.E. A/L කරලා Degree එකක් කරන්න ඔනේ or private job එකක් කරන්න ඔනේ."
        x(1, 0) = "Gov Campus or Private Campus ගිහින් degree එකක් කරන්න ඔනේ or වෘත්තිය සුදුසුකමක් හදාගන්න ඔනේ. "
        x(2, 0) = "Finally හොද job එකක් කරන්න පුලුවන්."

        x(0, 1) = "නිවස තමාගේ වන නිසා නිවසේ නඩත්තු වියදම් හැර වෙනත් වියදමි නැත."
        x(1, 1) = "මාසිකව කුලි ගාස්තුවක් ගෙවිය යුතුය (about 40000 LKR monthly)"
        x(2, 1) = "තමාගේම නිවසක් සාදාගත යුතුය (about 50 lks at least) or කුලි නිවසකට යායුතුය (about 40000LKR monthly)"

        x(0, 2) = "කෙල්ලෙක් හොයාගන්න ඔනේ, දැනටම කෙල්ලෙක් නැ කියන්නේ උබ කැතයි. ඒනිසා පෙනුම ගැන හිතන්න ඔනේ."
        x(1, 2) = "කොල්ලෙක් හොයාගන්න ඔනේ, දැනටම කොල්ලෙක් නැ කියන්නේ උබ කැතයි. ඒනිසා පෙනුම ගැන හිතන්න ඔනේ."

        x(0, 3) = "කෙල්ලෙක් ඉන්නවනම් එයාට gifts අරන් දෙන්න ඔන, ඇවිදින්න ඔන, කසාද බදින්න ඔන , ඊට පස්සෙ පවුල් වියදම්, එයාගෙ දෙමාපියන් බලාගන්නත් ඔනේ."
        x(1, 3) = "කොල්ලෙක් ඉන්නවනම් එයාව කසාද බදින්න ඔන, Dowry හදාගන්න ඔන, කොල්ලට සල්ලි නැත්නම් වෙන එකකට මාරුවෙන්න ඔනේ or එයත් එක්ක ගොඩ යන්න ඔනේ."

        x(0, 4) = "දේපල තිබේ නම් එවා නඩත්තු කරන්න ඔනේ, ලැබෙන ආදායම වැඩිකර ගන්න ඔනේ."
        x(1, 4) = "දේපල නැත්නම් දේපල එකතු කරන්න ඔනේ or නිකන් job එකේ ආදායමෙන් ජිවත් වෙන්න ඔනේ."

        x(0, 5) = "1000*30 = 30000 lkr for month"
        x(1, 5) = "125*30 = 3750 for month"

        x(0, 6) = "3000*12 = 36000lkr for year"
        x(1, 6) = "125*12 = 1500 for year"

        x(0, 7) = "12000 *1 = 12000 for year"
        x(1, 7) = "125*1 = 125 for year"

        name = TextBox1.Text


        If CheckBox1.Checked Then
            sthira = x(0, 1)
        ElseIf CheckBox2.Checked Then
            kuli = x(1, 1)
        ElseIf CheckBox3.Checked Then
            ammala = x(2, 1)
        End If
        If CheckBox4.Checked Then
            ol = x(0, 0)
        ElseIf CheckBox5.Checked Then
            al = x(1, 0)
        ElseIf CheckBox6.Checked Then
            degree = x(2, 0)
        End If
        If CheckBox7.Checked Then
            kollekinnw = x(1, 3)
        ElseIf CheckBox8.Checked Then
            kollekna = x(1, 2)
        ElseIf CheckBox9.Checked Then
            kellekinnw = x(0, 3)
        ElseIf CheckBox10.Checked Then
            kellekna = x(0, 2)
        End If
        If CheckBox11.Checked Then
            If ew = ("Daily") Then
                s = x(1, 5)
            ElseIf ew = ("Monthly") Then
                s = x(1, 6)
            ElseIf ew = ("yearly") Then
                s = x(1, 7)
            End If

            If hpo = ("Daily") Then
                l = x(0, 5)
            ElseIf hpo = ("Monthly") Then
                l = x(0, 6)
            ElseIf hpo = ("yearly") Then
                l = x(0, 7)
            End If


        ElseIf CheckBox12.Checked Then
            ela = ("සුබ පැතුම්!, ඔබ මාසයකට රු. 35000ක් පමන ඉතුරු කරනවා ")

        End If


        MsgBox("hi " & name & vbNewLine &
               "Thank you for using Life Solution Software" & vbNewLine &
               "මෙන්න ඔබගේ ඉදිරි අවුරුදු 10ට එන ප්‍රශ්න!" & vbNewLine &
               ol & al & degree & vbNewLine &
               "ඔබගේ වෘත්තිය සුදුසුකම වන්නේ " & occupation & vbNewLine &
               sthira & kuli & ammala & vbNewLine &
               kollekinnw & kollekna & kellekinnw & kellekna & vbNewLine &
               "ඔබට අයත් දේපල " & depala & "හා ආදායම " & adayama & vbNewLine &
               yes & no & vbNewLine &
               "ඔබට මත්ද්‍රවය සදහා යන වියදම් " & s & l)


    End Sub


End Class
