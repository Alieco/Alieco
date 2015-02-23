Imports System.Globalization
Imports System.IO.File
Imports System.IO
Imports DevComponents.DotNetBar
Imports MySql.Data
Imports MySql.Data.MySqlClient

Public Class ImportPresence
    Private dt As DataTable
    Private Sub ButtonX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX1.Click
        Try
            'BackgroundWorker2.RunWorkerAsync()
            dt = New DataTable
            dt.Columns.Add("Matricule")
            dt.Columns.Add("Nom & Prénom")
            dt.Columns.Add("Direction")
            dt.Columns.Add("Date")
            dt.Columns.Add("Entrée1")
            dt.Columns.Add("Sortie1")
            dt.Columns.Add("Entrée2")
            dt.Columns.Add("Sortie2")
            dt.Columns.Add("Entrée3")
            dt.Columns.Add("Sortie3")
            dt.Columns.Add("Heures Travaillé")
            dt.Columns.Add("Absence")
            dt.Columns.Add("Heures suplimentaires")
            dt.Columns.Add("Motif")
            Dim EntryDate As String = ""
            Dim direction As String = ""
            Dim sex As String = ""
            Dim o As New OpenFileDialog
            o.Filter = "CSV Files | *.csv"
            If o.ShowDialog = Windows.Forms.DialogResult.OK Then
                TextBoxX1.Text = o.FileName
            End If
            Dim FILE_NAME As String = o.FileName
            Dim TextLine As String = ""
            Mainfrm.ProgressBarItem1.Value = 0
            If File.Exists(FILE_NAME) = True Then
                ' Pdgv.Rows.Clear()
                Dim nb As Integer = File.ReadAllLines(FILE_NAME).Length
                Mainfrm.ProgressBarItem1.Maximum = nb
                ' Mainfrm.LabelItem3.Text = "Nombre de ligne avant l'importe :  " & nb
                Dim fileReader As New StreamReader(FILE_NAME)
                Do While fileReader.Peek() <> -1
                    Dim line = encode(fileReader.ReadLine().Replace("""", "").Replace("�", "é"))
                    Dim columns = line.Split(",")

                    If columns.Length = 31 Then

                        Dim mat = columns(20).Replace("é", "")
                        If mat = "" Or Not IsNumeric(mat) Then
                            mat = columns(18).Replace("é", "")
                            ' Console.WriteLine("SELECT Direction From employes WHERE Matricule=" & mat & " LIMIT 1")
                            If IsConnected("SELECT Direction,Sexe From employes WHERE Matricule=" & mat & " LIMIT 1", False) Then
                                If myDR.HasRows = True Then
                                    While myDR.Read
                                        direction = myDR("Direction")
                                        sex = myDR("Sexe")
                                    End While
                                Else
                                    direction = ""
                                End If
                            End If
                            addToPDGV(columns(18).Replace("é", ""), columns(19), direction, EntryDate, StrToTime(columns(20)), StrToTimeSortie(columns(21)), StrToTime(columns(22)), StrToTimeSortie(columns(23)), StrToTime(columns(24)), StrToTimeSortie(columns(25)), "", encode(columns(28) & "-" & columns(29) & "-" & columns(30)), sex)
                            Mainfrm.ProgressBarItem1.Value += 1
                            Mainfrm.LabelItem2.Text = "Nombre de ligne : " & GridView1.DataRowCount
                        ElseIf IsNumeric(mat) Then
                            EntryDate = columns(19)
                            mat = columns(20).Replace("é", "")
                            If IsConnected("SELECT Direction,Sexe From employes WHERE Matricule=" & mat & " LIMIT 1", False) Then
                                If myDR.HasRows = True Then
                                    While myDR.Read
                                        direction = myDR("Direction")
                                        sex = myDR("Sexe")
                                    End While
                                Else
                                    direction = ""
                                End If
                            End If
                            addToPDGV(columns(20).Replace("é", ""), columns(21), direction, columns(19), StrToTime(columns(22)), StrToTimeSortie(columns(23)), StrToTime(columns(24)), StrToTimeSortie(columns(25)), StrToTime(columns(26)), StrToTimeSortie(columns(27)), "", encode(columns(30)), sex)
                            Mainfrm.ProgressBarItem1.Value += 1
                            Mainfrm.LabelItem2.Text = "Nombre de ligne : " & GridView1.DataRowCount
                        End If
                        '  Console.WriteLine("SELECT Direction From employes WHERE Matricule=" & columns(18).Replace("é", "") & " LIMIT 1")

                    ElseIf columns.Length = 29 Then
                        If columns(18).Replace("é", "") = "" Then
                            Console.WriteLine(EntryDate & " 2")
                        End If
                        'Console.WriteLine("SELECT Direction From employes WHERE Matricule=" & columns(18).Replace("é", "") & " LIMIT 1")
                        If IsConnected("SELECT Direction,Sexe From employes WHERE Matricule=" & columns(18).Replace("é", "") & " LIMIT 1", False) Then
                            If myDR.HasRows = True Then
                                While myDR.Read
                                    direction = myDR("Direction")
                                    sex = myDR("Sexe")
                                End While
                            Else
                                direction = ""
                            End If
                        End If
                        addToPDGV(columns(18).Replace("é", ""), columns(19), direction, EntryDate, StrToTime(columns(20)), StrToTimeSortie(columns(21)), StrToTime(columns(22)), StrToTimeSortie(columns(23)), StrToTime(columns(24)), StrToTimeSortie(columns(25)), "", encode(columns(28)), sex)
                        Mainfrm.ProgressBarItem1.Value += 1
                        Mainfrm.LabelItem2.Text = "Nombre de ligne : " & GridView1.DataRowCount
                    ElseIf columns.Length = 30 Then
                        Dim mat = columns(18).Replace("é", "")
                        If IsConnected("SELECT Direction,Sexe From employes WHERE Matricule=" & mat & " LIMIT 1", False) Then
                            If myDR.HasRows = True Then
                                While myDR.Read
                                    direction = myDR("Direction")
                                    sex = myDR("Sexe")
                                End While
                            Else
                                direction = ""
                            End If
                        End If
                        addToPDGV(columns(18).Replace("é", ""), columns(19), direction, EntryDate, StrToTime(columns(20)), StrToTimeSortie(columns(21)), StrToTime(columns(22)), StrToTimeSortie(columns(23)), StrToTime(columns(24)), StrToTimeSortie(columns(25)), "", encode(columns(28) & "-" & columns(29)), sex)
                        Mainfrm.ProgressBarItem1.Value += 1
                        Mainfrm.LabelItem2.Text = "Nombre de ligne : " & GridView1.DataRowCount
                        '  Clipboard.SetText(line)
                    Else
                        ' MsgBox(columns.Length)
                    End If
                Loop
                Mainfrm.LabelItem2.Text = "Nombre de ligne : " & GridView1.DataRowCount
                'For i = 0 To Pdgv.RowCount - 2
                '    If i < Pdgv.RowCount - 1 Then
                '        Dim somm As Double = 8.25
                '        Dim dgvRow As DataGridViewRow = Pdgv.Rows(i)
                '        If CStr(dgvRow.Cells(4).Value) <> "" And CStr(dgvRow.Cells(5).Value) <> "" Then
                '            Dim t1, t2 As DateTime
                '            t1 = dgvRow.Cells(4).Value
                '            t2 = dgvRow.Cells(5).Value
                '            If (t2 <= "12:45:00" And t2 >= "12:00:00") Then
                '                t2 = "12:45:00"
                '                Dim d1 As System.TimeSpan
                '                d1 = t2.Subtract(t1)
                '                somm -= d1.TotalHours
                '            Else
                '                Dim d1 As System.TimeSpan
                '                d1 = t2.Subtract(t1)
                '                somm -= d1.TotalHours
                '            End If

                '        End If
                '        If CStr(dgvRow.Cells(6).Value) <> "" And CStr(dgvRow.Cells(7).Value) <> "" Then
                '            Dim t1, t2 As DateTime
                '            t1 = dgvRow.Cells(6).Value
                '            t2 = dgvRow.Cells(7).Value
                '            If (t2 <= "12:45:00" And t2 >= "12:00:00") Then
                '                t2 = "12:45:00"
                '                Dim d1 As System.TimeSpan
                '                d1 = t2.Subtract(t1)
                '                somm -= d1.TotalHours
                '            Else
                '                Dim d1 As System.TimeSpan
                '                d1 = t2.Subtract(t1)
                '                somm -= d1.TotalHours
                '            End If
                '        End If
                '        If CStr(dgvRow.Cells(8).Value) <> "" And CStr(dgvRow.Cells(9).Value) <> "" Then
                '            Dim t1, t2 As DateTime
                '            t1 = dgvRow.Cells(8).Value
                '            t2 = dgvRow.Cells(9).Value
                '            If (t2 <= "12:45:00" And t2 >= "12:00:00") Then
                '                t2 = "12:45:00"
                '                Dim d1 As System.TimeSpan
                '                d1 = t2.Subtract(t1)
                '                somm -= d1.TotalHours
                '            Else
                '                Dim d1 As System.TimeSpan
                '                d1 = t2.Subtract(t1)
                '                somm -= d1.TotalHours
                '            End If
                '        End If
                '        If somm < 0 Then
                '            dgvRow.Cells(11).Value = String.Format("{0:0.00}", Math.Abs(somm)).ToString
                '            dgvRow.Cells(10).Value = String.Format("{0:0.00}", "0.00").ToString
                '        Else
                '            dgvRow.Cells(10).Value = String.Format("{0:0.00}", somm).ToString
                '        End If

                '    End If
                'Next

            Else

                MessageBoxEx.Show("Vous n'avez pas choisis un fichier", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)

            End If
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub
    Sub addToPDGV(ByVal mat As String, ByVal nom As String, ByVal direction As String, ByVal EntryDate As String, ByVal entry1 As String, ByVal sortie1 As String, ByVal entry2 As String, ByVal sortie2 As String, ByVal entry3 As String, ByVal sortie3 As String, ByVal somme As String, ByVal motif As String, ByVal sex As String)
        Try
            Dim pointage(5) As String
            pointage(0) = IIf(entry1 = "", sortie1, entry1)
            pointage(1) = IIf(sortie1 = "", entry2, sortie1)
            pointage(2) = IIf(entry2 = "", sortie2, entry2)
            pointage(3) = IIf(sortie2 = "", entry3, sortie2)
            pointage(4) = IIf(entry3 = "", sortie3, entry3)
            pointage(5) = IIf(sortie3 = "", "", sortie3)
            Array.Sort(pointage)

            Dim i As Integer = 0
            For i = 0 To pointage.Length - 1
                For i2 As Integer = i + 1 To pointage.Length - 1
                    If pointage(i).ToString = pointage(i2).ToString And pointage(i).ToString <> "" Then
                        pointage(i2) = ""
                    End If
                Next
            Next
            i = 0
            While i <= 4
                'Console.WriteLine("i: " & i)
                If pointage(i).ToString = "" Or pointage(i).ToString = String.Empty Then
                    Dim j As Integer = i + 1
                    For j = i + 1 To 5
                        If pointage(j) <> "" Then
                            pointage(i) = pointage(j)
                            pointage(j) = ""
                            Exit For
                        End If
                    Next
                End If
                i += 1
            End While
            Dim s = SommeMotif(SommeAbsence(pointage(0), pointage(1), pointage(2), pointage(3), pointage(4), pointage(5), sex), motif)
            'Pdgv.Rows.Add(mat, nom, direction, EntryDate, pointage(0), pointage(1), pointage(2), pointage(3), pointage(4), pointage(5), s, "", motif)

            Dim dr As DataRow = dt.NewRow()
            dr(0) = mat
            dr(1) = nom
            dr(2) = direction
            dr(3) = EntryDate
            dr(4) = pointage(0)
            dr(5) = pointage(1)
            dr(6) = pointage(2)
            dr(7) = pointage(3)
            dr(8) = pointage(4)
            dr(9) = pointage(5)
            dr(10) = SommeTravail(pointage(0), pointage(1), pointage(2), pointage(3), pointage(4), pointage(5))
            dr(11) = s
            dr(12) = ""
            dr(13) = motif
            dt.Rows.Add(dr)
            Grid1.DataSource = dt
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub
    Public Shared Function encode(ByVal str As String) As String
        Try
            Dim utf8Encoding As New System.Text.UTF8Encoding
            Dim encodedString() As Byte
            encodedString = utf8Encoding.GetBytes(str)
            Return utf8Encoding.GetString(encodedString)
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
        Return Nothing
    End Function
    Public Function StrToTime(ByVal str As String) As String
        Try
            If str = "" Then Return ""
            If str.Length = 6 Then str = str.Insert(2, ":").Insert(5, ":")
            Dim dtTime As DateTime = Convert.ToDateTime(str)
            Return dtTime.ToString("HH:mm")
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
        Return Nothing
    End Function
    Public Function StrToTimeSortie(ByVal str As String) As String
        Try
            If str = "" Then Return ""
            If str.Length = 6 Then str = str.Insert(2, ":").Insert(5, ":")
            Dim dtTime As DateTime = Convert.ToDateTime(str)
            dtTime = DateAdd(DateInterval.Minute, 1, dtTime)
            Return dtTime.ToString("HH:mm")
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
        Return Nothing
    End Function

    Private Sub ButtonX2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX2.Click
        Try
            If Not BackgroundWorker1.IsBusy Then
                ButtonX2.Enabled = False
                ButtonX1.Enabled = False
                Mainfrm.ProgressBarItem1.Value = 0
                Mainfrm.ProgressBarItem1.Maximum = GridView1.DataRowCount - 1
                BackgroundWorker1.RunWorkerAsync()
            End If
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub
    'Private Sub Pdgv_RowPostPaint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewRowPostPaintEventArgs) Handles Pdgv.RowPostPaint
    '    If e.RowIndex < Pdgv.RowCount - 1 Then
    '        Dim somm As Double = 8.25
    '        Dim dgvRow As DataGridViewRow = Pdgv.Rows(e.RowIndex)
    '        'MsgBox(CStr(dgvRow.Cells(0).Value))
    '        If CStr(dgvRow.Cells(4).Value) <> "" And CStr(dgvRow.Cells(5).Value) = "" Then
    '            dgvRow.DefaultCellStyle.BackColor = Color.FromArgb(77, 128, 183)
    '            dgvRow.Cells(5).Style.BackColor = Color.FromArgb(231, 76, 60)
    '            dgvRow.DefaultCellStyle.ForeColor = Color.FromArgb(255, 255, 255)
    '        End If
    '        If CStr(dgvRow.Cells(6).Value) <> "" And CStr(dgvRow.Cells(7).Value) = "" Then
    '            dgvRow.DefaultCellStyle.BackColor = Color.FromArgb(77, 128, 183)
    '            dgvRow.Cells(7).Style.BackColor = Color.FromArgb(231, 76, 60)
    '            dgvRow.DefaultCellStyle.ForeColor = Color.FromArgb(255, 255, 255)
    '        End If
    '        If CStr(dgvRow.Cells(8).Value) <> "" And CStr(dgvRow.Cells(9).Value) = "" Then
    '            dgvRow.DefaultCellStyle.BackColor = Color.FromArgb(77, 128, 183)
    '            dgvRow.Cells(9).Style.BackColor = Color.FromArgb(231, 76, 60)
    '            dgvRow.DefaultCellStyle.ForeColor = Color.FromArgb(255, 255, 255)
    '        End If
    '        If CStr(dgvRow.Cells(4).Value) <> "" And CStr(dgvRow.Cells(5).Value) <> "" Then
    '            Dim t1, t2 As DateTime
    '            t1 = dgvRow.Cells(4).Value
    '            t2 = dgvRow.Cells(5).Value
    '            If (t1 <= "08:00:00") Then
    '                t1 = "08:00:00"
    '            End If
    '            If (t2 <= "12:45:00" And t2 >= "12:00:00") Then
    '                t2 = "12:45:00"
    '                Dim d1 As System.TimeSpan
    '                d1 = t2.Subtract(t1)
    '                somm -= d1.TotalHours
    '            Else
    '                Dim d1 As System.TimeSpan
    '                d1 = t2.Subtract(t1)
    '                somm -= d1.TotalHours
    '            End If

    '        End If
    '        If CStr(dgvRow.Cells(6).Value) <> "" And CStr(dgvRow.Cells(7).Value) <> "" Then
    '            Dim t1, t2 As DateTime
    '            t1 = dgvRow.Cells(6).Value
    '            t2 = dgvRow.Cells(7).Value
    '            If (t1 <= "08:00:00") Then
    '                t1 = "08:00:00"
    '            End If
    '            If (t2 <= "12:45:00" And t2 >= "12:00:00") Then
    '                t2 = "12:45:00"
    '                Dim d1 As System.TimeSpan
    '                d1 = t2.Subtract(t1)
    '                somm -= d1.TotalHours
    '            Else
    '                Dim d1 As System.TimeSpan
    '                d1 = t2.Subtract(t1)
    '                somm -= d1.TotalHours
    '            End If
    '        End If
    '        If CStr(dgvRow.Cells(8).Value) <> "" And CStr(dgvRow.Cells(9).Value) <> "" Then
    '            Dim t1, t2 As DateTime
    '            t1 = dgvRow.Cells(8).Value
    '            t2 = dgvRow.Cells(9).Value
    '            If (t1 <= "08:00:00") Then
    '                t1 = "08:00:00"
    '            End If
    '            If (t2 <= "12:45:00" And t2 >= "12:00:00") Then
    '                t2 = "12:45:00"
    '                Dim d1 As System.TimeSpan
    '                d1 = t2.Subtract(t1)
    '                somm -= d1.TotalHours
    '            Else
    '                Dim d1 As System.TimeSpan
    '                d1 = t2.Subtract(t1)
    '                somm -= d1.TotalHours
    '            End If
    '        End If
    '        If somm < 0 Then
    '            dgvRow.Cells(11).Value = String.Format("{0:0.00}", Math.Abs(somm)).ToString
    '            dgvRow.Cells(10).Value = String.Format("{0:0.00}", "0.00").ToString
    '        Else
    '            If somm = 8.25 Then somm = 8
    '            dgvRow.Cells(10).Value = String.Format("{0:0.00}", somm).ToString
    '        End If

    '    End If
    'End Sub
    Public Function SommeAbsence(ByVal e1 As String, ByVal s1 As String, ByVal e2 As String, ByVal s2 As String, ByVal e3 As String, ByVal s3 As String, Optional ByVal sex As String = "") As String
        Try
            If RadioButton1.Checked Then
                Dim ta1, ta2 As DateTime
                ta1 = duN.Value.ToString("HH:mm:ss")
                ta2 = auN.Value.ToString("HH:mm:ss")
                Dim da1 As System.TimeSpan
                da1 = ta2.Subtract(ta1)
                Dim somm1, somm As Double
                somm1 = da1.TotalHours
                somm = da1.TotalHours
                Dim pointage(5) As String
                pointage(0) = IIf(e1 = "", s1, e1)
                pointage(1) = IIf(s1 = "", e2, s1)
                pointage(2) = IIf(e2 = "", s2, e2)
                pointage(3) = IIf(s2 = "", e3, s2)
                pointage(4) = IIf(e3 = "", s3, e3)
                pointage(5) = IIf(s3 = "", "", s3)
                For t As Integer = 0 To pointage.Length - 1
                    Dim t1 As DateTime
                    If pointage(t) <> "" Then
                        t1 = pointage(t)
                        If (t1 <= ta1) Then
                            pointage(t) = ta1
                        End If
                        If (t1 >= ta2) Then
                            pointage(t) = ta2
                        End If
                    End If
                Next
                Array.Sort(pointage)
                Dim i As Integer = 0
                For i = 0 To pointage.Length - 1
                    For i2 As Integer = i + 1 To pointage.Length - 1
                        If pointage(i).ToString = pointage(i2).ToString And pointage(i).ToString <> "" Then
                            pointage(i2) = ""
                        End If
                    Next
                Next
                i = 0
                While i <= 4
                    'Console.WriteLine("i: " & i)
                    If pointage(i).ToString = "" Or pointage(i).ToString = String.Empty Then
                        Dim j As Integer = i + 1
                        For j = i + 1 To 5
                            If pointage(j) <> "" Then
                                pointage(i) = pointage(j)
                                pointage(j) = ""
                                Exit For
                            End If
                        Next
                    End If
                    i += 1
                End While
                Array.Sort(pointage)
                For t As Integer = 0 To pointage.Length - 2
                    If pointage(t) <> "" And pointage(t + 1) <> "" Then
                        Dim t1, t2 As DateTime
                        t1 = pointage(t)
                        t2 = pointage(t + 1)
                        If (t2 <= "12:45:00" And t2 >= "12:00:00") And (t1 <= "12:45:00" And t1 >= "12:00:00") Then
                            pointage(t) = ""
                            pointage(t + 1) = ""
                        End If
                    End If
                Next
                Array.Sort(pointage)
                For t As Integer = 0 To pointage.Length - 2
                    If pointage(t) <> "" And pointage(t + 1) <> "" Then
                        Dim t1, t2 As DateTime
                        t1 = pointage(t)
                        t2 = pointage(t + 1)
                        Dim d1 As System.TimeSpan
                        d1 = t2.Subtract(t1)
                        If d1.TotalMinutes < 3 Then
                            pointage(t + 1) = ""
                        End If
                    End If
                Next
                Array.Sort(pointage)
                i = 0
                While i <= 4
                    If pointage(i).ToString = "" Or pointage(i).ToString = String.Empty Then
                        Dim j As Integer = i + 1
                        For j = i + 1 To 5
                            If pointage(j) <> "" Then
                                pointage(i) = pointage(j)
                                pointage(j) = ""
                                Exit For
                            End If
                        Next
                    End If
                    i += 1
                End While
                e1 = pointage(0)
                s1 = pointage(1)
                e2 = pointage(2)
                s2 = pointage(3)
                e3 = pointage(4)
                s3 = pointage(5)
                ' Console.WriteLine("time: " & e1 & "-" & s1 & "-" & e2 & "-" & s2 & "-" & e3 & "-" & s3)
                If CStr(e1) <> "" And CStr(s1) <> "" Then
                    Dim t1, t2 As DateTime
                    t1 = e1
                    t2 = s1
                    If (t1 <= ta1) Then
                        t1 = ta1
                    End If
                    If (t2 >= ta2) Then
                        t2 = ta2
                    End If
                    If (t2 <= "12:45:00" And t2 >= "12:00:00") Then
                        t2 = "12:45:00"
                    End If
                    If (t1 <= "12:45:00" And t1 >= "12:00:00") Then
                        t1 = "12:00:00"
                    End If
                    Dim d1 As System.TimeSpan
                    d1 = t2.Subtract(t1)
                    somm -= d1.TotalHours
                    ' Console.WriteLine("time: " & t1 & t2 & somm)
                End If
                If CStr(e2) <> "" And CStr(s2) <> "" Then
                    Dim t1, t2 As DateTime
                    t1 = e2
                    t2 = s2
                    If (t1 <= ta1) Then
                        t1 = ta1
                    End If
                    If (t2 >= ta2) Then
                        t2 = ta2
                    End If
                    If (t2 <= "12:45:00" And t2 >= "12:00:00") Then
                        t2 = "12:45:00"
                    End If
                    If (t1 <= "12:45:00" And t1 >= "12:00:00") Then
                        t1 = "12:00:00"
                    End If
                    Dim d1 As System.TimeSpan
                    d1 = t2.Subtract(t1)
                    somm -= d1.TotalHours
                    ' Console.WriteLine("time2: " & t1 & t2 & somm)
                End If
                If CStr(e3) <> "" And CStr(s3) <> "" Then
                    Dim t1, t2 As DateTime
                    t1 = e3
                    t2 = s3
                    If (t1 <= ta1) Then
                        t1 = ta1
                    End If
                    If (t2 >= ta2) Then
                        t2 = ta2
                    End If
                    If (t2 <= "12:45:00" And t2 >= "12:00:00") Then
                        t2 = "12:45:00"
                    End If
                    If (t1 <= "12:45:00" And t1 >= "12:00:00") Then
                        t1 = "12:00:00"
                    End If
                    Dim d1 As System.TimeSpan
                    d1 = t2.Subtract(t1)
                    somm -= d1.TotalHours
                    ' Console.WriteLine("time3: " & t1 & t2 & somm)
                End If
                If somm > 8 Then
                    Return String.Format("{0:0.00}", "8.00").ToString
                ElseIf somm < 0 Then
                    ' dgvRow.Cells(11).Value = String.Format("{0:0.00}", Math.Abs(somm)).ToString
                    Return String.Format("{0:0.00}", "0.00").ToString
                Else
                    If somm = 8.25 Then somm = 8
                    Return String.Format("{0:0.00}", somm).ToString
                End If
            ElseIf RadioButton2.Checked Then
                Dim somm As Double
                Dim tt1, tt2 As DateTime
                If sex = "Femme" Or sex = "Madame" Or sex = "Mademoiselle" Or sex = "F" Then

                    tt1 = duR.Value.ToString("HH:mm:ss")
                    tt2 = AuF.Value.ToString("HH:mm:ss")
                    Dim d1 As System.TimeSpan
                    d1 = tt2.Subtract(tt1)
                    somm = d1.TotalHours
                Else

                    tt1 = duR.Value.ToString("HH:mm:ss")
                    tt2 = AuH.Value.ToString("HH:mm:ss")
                    Dim d1 As System.TimeSpan
                    d1 = tt2.Subtract(tt1)
                    somm = d1.TotalHours
                End If

                Dim pointage(5) As String
                pointage(0) = IIf(e1 = "", s1, e1)
                pointage(1) = IIf(s1 = "", e2, s1)
                pointage(2) = IIf(e2 = "", s2, e2)
                pointage(3) = IIf(s2 = "", e3, s2)
                pointage(4) = IIf(e3 = "", s3, e3)
                pointage(5) = IIf(s3 = "", "", s3)
                For t As Integer = 0 To pointage.Length - 1
                    Dim t1 As DateTime
                    If pointage(t) <> "" Then
                        t1 = pointage(t)
                        If (t1 <= tt1) Then
                            pointage(t) = tt1
                        End If
                        If (t1 >= tt2) Then
                            pointage(t) = tt2
                        End If
                    End If
                Next
                Array.Sort(pointage)
                Dim i As Integer = 0
                For i = 0 To pointage.Length - 1
                    For i2 As Integer = i + 1 To pointage.Length - 1
                        If pointage(i).ToString = pointage(i2).ToString And pointage(i).ToString <> "" Then
                            pointage(i2) = ""
                        End If
                    Next
                Next
                i = 0
                While i <= 4
                    'Console.WriteLine("i: " & i)
                    If pointage(i).ToString = "" Or pointage(i).ToString = String.Empty Then
                        Dim j As Integer = i + 1
                        For j = i + 1 To 5
                            If pointage(j) <> "" Then
                                pointage(i) = pointage(j)
                                pointage(j) = ""
                                Exit For
                            End If
                        Next
                    End If
                    i += 1
                End While
                Array.Sort(pointage)
                For t As Integer = 0 To pointage.Length - 2
                    If pointage(t) <> "" And pointage(t + 1) <> "" Then
                        Dim t1, t2 As DateTime
                        t1 = pointage(t)
                        t2 = pointage(t + 1)
                        Dim d1 As System.TimeSpan
                        d1 = t2.Subtract(t1)
                        If d1.TotalMinutes < 3 Then
                            pointage(t + 1) = ""
                        End If
                    End If
                Next

                Array.Sort(pointage)
                i = 0
                While i <= 4
                    If pointage(i).ToString = "" Or pointage(i).ToString = String.Empty Then
                        Dim j As Integer = i + 1
                        For j = i + 1 To 5
                            If pointage(j) <> "" Then
                                pointage(i) = pointage(j)
                                pointage(j) = ""
                                Exit For
                            End If
                        Next
                    End If
                    i += 1
                End While
                e1 = pointage(0)
                s1 = pointage(1)
                e2 = pointage(2)
                s2 = pointage(3)
                e3 = pointage(4)
                s3 = pointage(5)
                ' Console.WriteLine("time: " & e1 & "-" & s1 & "-" & e2 & "-" & s2 & "-" & e3 & "-" & s3)

                If CStr(e1) <> "" And CStr(s1) <> "" Then
                    Dim t1, t2 As DateTime
                    t1 = e1
                    t2 = s1
                    If (t1 <= tt1) Then
                        t1 = tt1
                    End If
                    If (t1 >= tt2) Then
                        t2 = tt2
                    End If

                    Dim d1 As System.TimeSpan
                    d1 = t2.Subtract(t1)
                    somm -= d1.TotalHours

                    ' Console.WriteLine("time: " & t1 & t2 & somm)

                End If
                If CStr(e2) <> "" And CStr(s2) <> "" Then
                    Dim t1, t2 As DateTime
                    t1 = e2
                    t2 = s2
                    If (t1 <= tt1) Then
                        t1 = tt1
                    End If
                    If (t1 >= tt2) Then
                        t2 = tt2
                    End If

                    Dim d1 As System.TimeSpan
                    d1 = t2.Subtract(t1)
                    somm -= d1.TotalHours
                    ' Console.WriteLine("time2: " & t1 & t2 & somm)
                End If
                If CStr(e3) <> "" And CStr(s3) <> "" Then
                    Dim t1, t2 As DateTime
                    t1 = e3
                    t2 = s3
                    If (t1 <= tt1) Then
                        t1 = tt1
                    End If
                    If (t1 >= tt2) Then
                        t2 = tt2
                    End If

                    Dim d1 As System.TimeSpan
                    d1 = t2.Subtract(t1)
                    somm -= d1.TotalHours
                    ' Console.WriteLine("time3: " & t1 & t2 & somm)
                End If
                Return String.Format("{0:0.00}", somm).ToString
            End If
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
        Return Nothing
    End Function
    Public Function SommeMotif(ByVal somme As String, ByVal motif As String) As String
        Try
            If motif.Contains("Congé.Ann") Or motif.Contains("Congee statutaire") Or motif.Contains("Formation") Or motif.Contains("Mission V") Or motif.Contains("Recuperation Formation") Or motif.Contains("week end") Or motif.Contains("Bon de sortie service") Or motif.Contains("Omnission pointage") Or motif.Contains("Bon Sortie cp") Or motif.Contains("Bon sortie Soin") Or motif.Contains("Bon.Sortie - allaitement") Or motif.Contains("allaitement") Then
                Return "0.00"
            Else
                Return somme
            End If
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
        Return Nothing
    End Function
    Private Sub BackgroundWorker1_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        Try
            For i = 0 To GridView1.DataRowCount - 1
                Try
                    Dim ab As String = GridView1.GetRowCellValue(i, "Absence").ToString()
                    Dim hs As String = GridView1.GetRowCellValue(i, "Heures suplementaires").ToString()
                    Dim quary As String = " INSERT INTO presence_pointage(Matricule,date_pointage,Entree1,Sortie1,Entree2,Sortie2,Entree3,Sortie3,Absence,HeureSupplementaire,Motif)VALUES(" & GridView1.GetRowCellValue(i, "Matricule").ToString() & ",'" & CDate(GridView1.GetRowCellValue(i, "Date").ToString()).ToString("yyyy-MM-dd") & "','" & GridView1.GetRowCellValue(i, "Entrée1").ToString() & "','" & GridView1.GetRowCellValue(i, "Sortie1").ToString() & "','" & GridView1.GetRowCellValue(i, "Entrée2").ToString() & "','" & GridView1.GetRowCellValue(i, "Sortie2").ToString() & "','" & GridView1.GetRowCellValue(i, "Entrée3").ToString() & "','" & GridView1.GetRowCellValue(i, "Sortie3").ToString() & "','" & ab.Replace(",", ".") & "','" & hs & "','" & GridView1.GetRowCellValue(i, "Motif").ToString() & "')"
                    If IsConnected(quary, False) = True Then
                        BackgroundWorker1.ReportProgress(i)
                    End If
                Catch ex As MySqlException
                    MessageBox.Show(ex.Message)
                End Try
            Next
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
        'For i As Integer = 0 To GridView1.DataRowCount - 1
        '    ' MessageBoxEx.Show(GridView1.GetRowCellValue(i, "Matricule").ToString())
        '    GridView1.SetRowCellValue(i, "Heures suplimentaires", "88888")
        '    'If GridView1.GetRowCellValue(i, "Matricule").ToString() = "A" Then
        '    '    ' Your code here
        '    'End If
        'Next i
    End Sub

    Private Sub ImportPresence_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Control.CheckForIllegalCrossThreadCalls = False
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub

    Private Sub BackgroundWorker1_RunWorkerCompleted(ByVal sender As System.Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted
        Try
            ButtonX2.Enabled = True
            ButtonX1.Enabled = True
            MessageBoxEx.Show("Le poitage à bien été enregistrer", "Succés", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub

    Private Sub BackgroundWorker1_ProgressChanged(ByVal sender As System.Object, ByVal e As System.ComponentModel.ProgressChangedEventArgs) Handles BackgroundWorker1.ProgressChanged
        Try
            Mainfrm.ProgressBarItem1.Value = e.ProgressPercentage
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub

    Private Function SommeTravail(ByVal e1 As String, ByVal s1 As String, ByVal e2 As String, ByVal s2 As String, ByVal e3 As String, ByVal s3 As String) As String
        Try
            Dim somm As Double = 0
            Dim pointage(5) As String
            pointage(0) = IIf(e1 = "", s1, e1)
            pointage(1) = IIf(s1 = "", e2, s1)
            pointage(2) = IIf(e2 = "", s2, e2)
            pointage(3) = IIf(s2 = "", e3, s2)
            pointage(4) = IIf(e3 = "", s3, e3)
            pointage(5) = IIf(s3 = "", "", s3)
            For t As Integer = 0 To pointage.Length - 1
                Dim t1 As DateTime
                If pointage(t) <> "" Then
                    t1 = pointage(t)
                    If (t1 <= "08:00:00") Then
                        pointage(t) = "08:00:00"
                    End If
                    If (t1 >= "16:15:00") Then
                        pointage(t) = "16:15:00"
                    End If
                End If
            Next
            Array.Sort(pointage)
            Dim i As Integer = 0
            For i = 0 To pointage.Length - 1
                For i2 As Integer = i + 1 To pointage.Length - 1
                    If pointage(i).ToString = pointage(i2).ToString And pointage(i).ToString <> "" Then
                        pointage(i2) = ""
                    End If
                Next
            Next
            i = 0
            While i <= 4
                'Console.WriteLine("i: " & i)
                If pointage(i).ToString = "" Or pointage(i).ToString = String.Empty Then
                    Dim j As Integer = i + 1
                    For j = i + 1 To 5
                        If pointage(j) <> "" Then
                            pointage(i) = pointage(j)
                            pointage(j) = ""
                            Exit For
                        End If
                    Next
                End If
                i += 1
            End While
            Array.Sort(pointage)
            For t As Integer = 0 To pointage.Length - 2
                If pointage(t) <> "" And pointage(t + 1) <> "" Then
                    Dim t1, t2 As DateTime
                    t1 = pointage(t)
                    t2 = pointage(t + 1)
                    If (t2 <= "12:45:00" And t2 >= "12:00:00") And (t1 <= "12:45:00" And t1 >= "12:00:00") Then
                        pointage(t) = ""
                        pointage(t + 1) = ""
                    End If
                End If
            Next
            Array.Sort(pointage)
            For t As Integer = 0 To pointage.Length - 2
                If pointage(t) <> "" And pointage(t + 1) <> "" Then
                    Dim t1, t2 As DateTime
                    t1 = pointage(t)
                    t2 = pointage(t + 1)
                    Dim d1 As System.TimeSpan
                    d1 = t2.Subtract(t1)
                    If d1.TotalMinutes < 3 Then
                        pointage(t + 1) = ""
                    End If
                End If
            Next

            Array.Sort(pointage)
            i = 0
            While i <= 4
                If pointage(i).ToString = "" Or pointage(i).ToString = String.Empty Then
                    Dim j As Integer = i + 1
                    For j = i + 1 To 5
                        If pointage(j) <> "" Then
                            pointage(i) = pointage(j)
                            pointage(j) = ""
                            Exit For
                        End If
                    Next
                End If
                i += 1
            End While
            e1 = pointage(0)
            s1 = pointage(1)
            e2 = pointage(2)
            s2 = pointage(3)
            e3 = pointage(4)
            s3 = pointage(5)
            ' Console.WriteLine("time: " & e1 & "-" & s1 & "-" & e2 & "-" & s2 & "-" & e3 & "-" & s3)

            If CStr(e1) <> "" And CStr(s1) <> "" Then
                Dim t1, t2 As DateTime
                t1 = e1
                t2 = s1
                If (t1 <= "08:00:00") Then
                    t1 = "08:00:00"
                End If
                If (t2 >= "16:15:00") Then
                    t2 = "16:15:00"
                End If
                If (t2 <= "12:45:00" And t2 >= "12:00:00") Then
                    t2 = "12:45:00"
                    Dim d1 As System.TimeSpan
                    d1 = t2.Subtract(t1)
                    somm += d1.TotalHours
                Else
                    Dim d1 As System.TimeSpan
                    d1 = t2.Subtract(t1)
                    somm += d1.TotalHours
                End If
                ' Console.WriteLine("time: " & t1 & t2 & somm)

            End If
            If CStr(e2) <> "" And CStr(s2) <> "" Then
                Dim t1, t2 As DateTime
                t1 = e2
                t2 = s2
                If (t1 <= "08:00:00") Then
                    t1 = "08:00:00"
                End If
                If (t2 >= "16:15:00") Then
                    t2 = "16:15:00"
                End If
                If (t2 <= "12:45:00" And t2 >= "12:00:00") Then
                    t2 = "12:45:00"
                    Dim d1 As System.TimeSpan
                    d1 = t2.Subtract(t1)
                    somm += d1.TotalHours
                Else
                    Dim d1 As System.TimeSpan
                    d1 = t2.Subtract(t1)
                    somm += d1.TotalHours
                End If
                ' Console.WriteLine("time2: " & t1 & t2 & somm)
            End If
            If CStr(e3) <> "" And CStr(s3) <> "" Then
                Dim t1, t2 As DateTime
                t1 = e3
                t2 = s3
                If (t1 <= "08:00:00") Then
                    t1 = "08:00:00"
                End If
                If (t2 >= "16:15:00") Then
                    t2 = "16:15:00"
                End If
                If (t2 <= "12:45:00" And t2 >= "12:00:00") Then
                    t2 = "12:45:00"
                    Dim d1 As System.TimeSpan
                    d1 = t2.Subtract(t1)
                    somm += d1.TotalHours
                Else
                    Dim d1 As System.TimeSpan
                    d1 = t2.Subtract(t1)
                    somm += d1.TotalHours
                End If
                ' Console.WriteLine("time3: " & t1 & t2 & somm)
            End If
            If somm > 8 Then
                Return String.Format("{0:0.00}", "8.00").ToString
            ElseIf somm < 0 Then
                ' dgvRow.Cells(11).Value = String.Format("{0:0.00}", Math.Abs(somm)).ToString
                Return String.Format("{0:0.00}", "0.00").ToString
            Else
                If somm = 8.25 Then somm = 8
                Return String.Format("{0:0.00}", somm).ToString
            End If
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
        Return Nothing
    End Function
    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        Try
            If RadioButton1.Checked Then
                RadioButton2.Checked = False
            End If
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub

    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged
        Try
            If RadioButton2.Checked Then
                RadioButton1.Checked = False
            End If
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub
End Class