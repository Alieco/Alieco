Imports MySql.Data.MySqlClient
Imports DevComponents.DotNetBar
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls

Public Class ficheDePaie
    Public sass As Boolean = False
    Public sai As Boolean = False
    Public gain As Boolean = False
    Public moianpr As String = ""
    Public codec As String = ""
    Public radio As String = ""
    Public salaire As String = ""
    Public image As Integer = 0
    Dim ValeurMax As Double = My.Settings.ValeurMax
    Private Sub ficheDePaie_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            ValeurMax = My.Settings.ValeurMax
            ValeurMaxLbl.Text = "la valeur MAX : " & ValeurMax & " DA  , Cliquer pour modifier"
            load_type()
            mat.Select()
            moianpr = Date.Now.ToString("MM") - 1
            If moianpr.Length = 1 Then moianpr = "0" & moianpr & Date.Now.ToString("yyyy") Else moianpr = moianpr & Date.Now.ToString("yyyy")
            datej.Text = Date.Now.ToString("MMyyyy")
            codec = GetUniqueKey()
            load_service()
            loadMatricule()
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub
    Private Sub load_type()
        IsConnected("SELECT * FROM paie_banque WHERE codtab like 'M%';", False)
        If myDR.HasRows Then
            mode_paiement.Items.Clear()
            While myDR.Read
                mode_paiement.Items.Add(myDR("libtab").ToString)
            End While
        End If

    End Sub
    Private Function GetUniqueKey() As String
        Try
            Dim date1 As Date = Date.Now
            Return date1.ToString("yyyyMMddHHmmss")
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Function

    Private Sub load_service()
        Try
            If IsConnected("SELECT DISTINCT liborg FROM paie_direction ", False) = True Then
                If myDR.HasRows = True Then
                    direction.Items.Clear()
                    While (myDR.Read())
                        direction.Items.Add(myDR("liborg"))
                    End While
                End If
            End If
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub
    ' If IsConnected("SELECT DISTINCT csect, liborg FROM paie_direction ", False) = True Then
    Private Sub mat_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mat.TextChanged
        Try
            Dim exst As Boolean = False
            Dim a As Integer = 0
            Dim erreur As Boolean = False
            code.Clear()
            If mat.Text.Length = 5 Then
                SupprimerBtn.Enabled = False
                If IsConnected("SELECT * FROM paie_mensuel WHERE Matricule='" & mat.Text & "' and moi_annee='" & datej.Text & "' and type='P'", False) = True Then
                    If myDR.HasRows = True Then
                        EnregistrBtn.Text = "Enregistrer les modifications "
                        EnregistrBtn.Enabled = True
                        '  MessageBoxEx.Show("La paie de l'employer " & mat.Text & "  a deja été enregistré", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        While (myDR.Read)
                            exst = True
                            Dim var As Integer = 0
                            If myDR("gain").ToString = 0 Then
                                var = 1
                            End If

                            GroupBox2.Enabled = True
                            datej.Text = myDR("moi_annee").ToString
                            nbheure.Text = myDR("tauxhoraire").ToString
                            codedirection.Text = myDR("codesection").ToString
                            totalas.Text = myDR("total_impots").ToString
                            totalss.Text = myDR("total_ss").ToString
                            totalgain.Text = myDR("total_gain").ToString
                            totalretenue.Text = myDR("total_retenue").ToString
                            netpayer.Text = myDR("net_payer").ToString
                            Dim List1 As ListViewItem = New ListViewItem(myDR("code").ToString, var)
                            List1.SubItems.Add(myDR("libellé").ToString)
                            List1.SubItems.Add(myDR("nombre").ToString)
                            List1.SubItems.Add(myDR("taux").ToString)
                            List1.SubItems.Add(myDR("soumis_Impots").ToString)
                            List1.SubItems.Add(myDR("soumis_ss").ToString)
                            List1.SubItems.Add(myDR("gain").ToString)
                            List1.SubItems.Add(myDR("retenue").ToString)
                            List1.SubItems.Add(myDR("nombre").ToString)
                            List1.SubItems.Add(myDR("taux").ToString)
                            List1.SubItems.Add(myDR("soumis_Impots").ToString)
                            List1.SubItems.Add(myDR("soumis_ss").ToString)
                            ListView1.Items.Add(List1)

                            If IsNumeric(sb.Text) Then
                                nbheure.Text = String.Format("{0:0.00}", (sb.Text / 173.33))
                            End If
                        End While
                        IsConnected("SELECT * FROM employes WHERE Matricule=" & mat.Text, False)
                        If myDR.HasRows = True Then
                            While (myDR.Read)
                                nom.Text = myDR("Nom")
                                prenom.Text = myDR("Prénom").ToString()
                                fonction.Text = myDR("Fonction").ToString
                                ech.Text = myDR("Ech").ToString
                                cat.Text = myDR("Cat").ToString
                                sb.Text = myDR("S_B_01_14").ToString.Replace(".", ",")
                                direction.Text = myDR("Direction").ToString
                                sf.Text = myDR("sit_fam").ToString
                                EnregistrBtn.Enabled = False
                                EnregistrBtn.Text = "Enregistrer les modifications "
                                EnregistrBtn.Image = My.Resources.edit
                            End While
                        End If
                        If exst = True Then
                            IsConnected("SELECT * FROM paie_blockage WHERE Matricule='" & mat.Text & "' and moi_annee='" & datej.Text & "' LIMIT 1", False)
                            If myDR.HasRows = True Then
                                VerouillerCheck.Checked = True
                                
                            Else
                                VerouillerCheck.Checked = False
                            End If
                        Else
                            VerouillerCheck.Checked = False
                        End If

                        IsConnected("SELECT * FROM code_papers WHERE Matricule='" & mat.Text & "'", False)
                        If myDR.HasRows = True Then

                            While (myDR.Read)
                                Try
                                    numbanque.Text = myDR("Num_CPT").ToString
                                    numss.Text = myDR("Num_SS").ToString
                                    codedirection.Text = myDR("Affectation").ToString
                                    mode_paiement.SelectedIndex = myDR("Mod_Paiement").ToString - 1

                                Catch ex As Exception
                                    EnvoiError(ex.Message)

                                End Try
                            End While
                        End If

                    Else
                        EnregistrBtn.Text = "Enregistrer"
                        verrioullerBtn.Enabled = False
                        EnregistrBtn.Visible = True
                        SupprimerBtn.Visible = True
                        EnregistrBtn.Enabled = False
                        EnregistrBtn.Image = My.Resources.secure_ok
                        ListView1.Items.Clear()
                        IsConnected("SELECT * FROM Employes WHERE Employes.Matricule=" & mat.Text, False)
                        If myDR.HasRows = True Then
                            While (myDR.Read)
                                nom.Text = myDR("Nom").ToString
                                prenom.Text = myDR("Prénom").ToString
                                fonction.Text = myDR("Fonction").ToString
                                ech.Text = myDR("Ech").ToString
                                cat.Text = myDR("Cat").ToString
                                sb.Text = myDR("S_B_01_14").ToString.Replace(".", ",")
                                If IsNumeric(sb.Text) Then
                                    nbheure.Text = String.Format("{0:0.00}", (sb.Text / 173.33))
                                End If
                                direction.Text = myDR("Direction").ToString
                                sf.Text = myDR("sit_fam").ToString
                                GroupBox2.Enabled = True
                                Dim List As ListViewItem = New ListViewItem("001", 0)
                                List.SubItems.Add("SALAIRE DE BASE")
                                List.SubItems.Add("")
                                List.SubItems.Add("")
                                List.SubItems.Add(sb.Text)
                                List.SubItems.Add(sb.Text)
                                List.SubItems.Add(sb.Text)
                                List.SubItems.Add("")
                                ListView1.Items.Add(List)
                                Dim moi As String = Date.Now.ToString("MM") - 1
                                Dim anne As String = Date.Now.ToString("yyyy")
                                If moi = 0 Then
                                    anne -= 1
                                    moi = "12"
                                End If
                                If datej.Text.Length = 6 Then
                                    moi = datej.Text.Substring(0, 2) - 1
                                    If moi.Length < 1 Then moi = "0" & moi
                                    anne = datej.Text.Substring(2, 4)
                                    If moi = 0 Then
                                        anne -= 1
                                        moi = "12"
                                    End If
                                End If


                                IsConnected("SELECT Sum(Absence) AS Absence FROM presence_pointage WHERE  NOT EXISTS(SELECT  * FROM    joursferies  WHERE   presence_pointage.date_pointage = joursferies.jourf) AND presence_pointage.date_pointage BETWEEN '" & anne & "-" & moi & "-01' AND '" & anne & "-" & moi & "-31' AND Matricule=" & mat.Text & " GROUP BY Matricule;", False)
                                If myDR.HasRows = True Then
                                    While (myDR.Read)
                                        Dim List1 As ListViewItem = New ListViewItem("072", 1)
                                        List1.SubItems.Add("RETENUE ABSENCE")
                                        List1.SubItems.Add(myDR("Absence").ToString)
                                        List1.SubItems.Add(nbheure.Text)
                                        List1.SubItems.Add(Math.Round((nbheure.Text * myDR("Absence")), 2))
                                        List1.SubItems.Add(Math.Round((nbheure.Text * myDR("Absence")), 2))
                                        List1.SubItems.Add("")
                                        List1.SubItems.Add(Math.Round((nbheure.Text * myDR("Absence")), 2))
                                        ListView1.Items.Add(List1)
                                    End While
                                End If
                                Dim moiannn As String = moi & anne
                                IsConnected("SELECT moi_annee FROM paie_mensuel, paie_rubrique WHERE Matricule='" & mat.Text & "' and code=ind and code<>'001' and fix='F'and code<>'980' and code<>'660' and code<>'610' and code<>'564'and code<>'561' and paie_mensuel.type ='P' order by idpaie_monsuel desc LIMIT 1", False)
                                If myDR.HasRows Then
                                    While myDR.Read
                                        If myDR("moi_annee").ToString <> "" Then
                                            moiannn = myDR("moi_annee").ToString
                                        End If
                                    End While
                                End If
                                IsConnected("SELECT * FROM paie_mensuel, paie_rubrique WHERE moi_annee='" & moiannn & "' and Matricule='" & mat.Text & "' and code=ind and code<>'001' and fix='F'and code<>'980' and code<>'660' and code<>'610' and code<>'564'and code<>'561' and paie_mensuel.type ='P'", False)
                                If myDR.HasRows = True Then
                                    While (myDR.Read)
                                        Dim i As Integer = IIf(myDR("retenue").ToString = "", 1, 0)
                                        Dim List1 As ListViewItem = New ListViewItem(myDR("code").ToString, i)
                                        List1.SubItems.Add(myDR("libellé").ToString)
                                        List1.SubItems.Add(myDR("nombre").ToString)
                                        List1.SubItems.Add(myDR("taux").ToString)
                                        List1.SubItems.Add(myDR("soumis_Impots").ToString)
                                        List1.SubItems.Add(myDR("soumis_ss").ToString)
                                        List1.SubItems.Add(myDR("gain").ToString)
                                        List1.SubItems.Add(myDR("retenue").ToString)
                                        ListView1.Items.Add(List1)
                                        ' mode_paiement.Text = myDR("mode_paiement").ToString
                                    End While
                                End If
                                For i = 0 To ListView1.Items.Count - 1
                                    If ListView1.Items(i).Text = "0" Then
                                        ListView1.Items(i).Text = ""
                                    End If
                                    For j = 1 To 7
                                        If ListView1.Items(i).SubItems(j).Text = "0" Then
                                            ListView1.Items(i).SubItems(j).Text = ""
                                        End If

                                    Next
                                Next
                            End While
                        End If
                        IsConnected("SELECT * FROM code_papers WHERE Matricule='" & mat.Text & "'", False)
                        If myDR.HasRows = True Then
                            While (myDR.Read)
                                numbanque.Text = myDR("Num_CPT").ToString
                                numss.Text = myDR("Num_SS").ToString
                                codedirection.Text = myDR("Affectation").ToString
                                mode_paiement.SelectedIndex = myDR("Mod_Paiement").ToString - 1
                            End While
                        End If
                    End If
                End If
            Else
                ' mat.Text = ""
                nom.Clear()
                prenom.Clear()
                fonction.Clear()
                ech.Clear()
                cat.Clear()
                sb.Clear()
                numbanque.Clear()
                numss.Clear()
                nbheure.Clear()
                service.Clear()
                sf.Clear()
                ListView1.Items.Clear()
                code.Clear()
                libele.Clear()
                nb.Value = Nothing
                taux.Clear()
                valeur.Clear()
                totalas.Clear()
                totalgain.Clear()
                totalretenue.Clear()
                totalss.Clear()
                netpayer.Clear()
                mode_paiement.SelectedIndex = -1
                EnregistrBtn.Enabled = False
            End If
            For i = 0 To ListView1.Items.Count - 1
                If ListView1.Items(i).Text = "0" Then
                    ListView1.Items(i).Text = ""
                End If
                For j = 1 To 7
                    If ListView1.Items(i).SubItems(j).Text = "0" Then
                        ListView1.Items(i).SubItems(j).Text = ""
                    End If

                Next
            Next
            'For i = 0 To ListView1.Items.Count - 1
            '    For j = 2 To ListView1.Items.Count - 1
            '        If ListView1.Items(i).SubItems(j).Text = 0 Then
            '            ListView1.Items(i).SubItems(j).Text = ""
            '            'ListView1.Items(i).SubItems(3).Text = ""
            '            'ListView1.Items(i).SubItems(4).Text = ""
            '            'ListView1.Items(i).SubItems(5).Text = ""
            '            'ListView1.Items(i).SubItems(6).Text = ""
            '            'ListView1.Items(i).SubItems(7).Text = ""
            '            'And ListView1.Items(i).SubItems(3).Text = 0 And ListView1.Items(i).SubItems(4).Text = 0 And ListView1.Items(i).SubItems(5).Text = 0 And ListView1.Items(i).SubItems(6).Text = 0 And ListView1.Items(i).SubItems(7).Text = 0
            '        End If
            '    Next
            'Next
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub

    Private Sub ButtonX2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX2.Click
        Try
            If valeur.Text = "" Then
                MessageBoxEx.Show("vous avez laissé le champ vide ", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            Dim val1 As Double = 0
            val1 = valeur.Text.Replace(".", ",")
            If IsNumeric(val1) Then
                'Dim image As Integer = 0
                Dim sas As String = ""
                If gain = False Then
                    image = 1
                Else : image = 0
                End If
                Dim c = code.Text
                Dim List As ListViewItem = New ListViewItem(c, image)
                List.SubItems.Add(libele.Text)
                List.SubItems.Add(nb.Text)
                List.SubItems.Add(taux.Text)
                If sass = True Then
                    List.SubItems.Add(valeur.Text)
                Else : List.SubItems.Add("")
                End If
                If sai = True Then
                    List.SubItems.Add(valeur.Text)
                Else : List.SubItems.Add("")
                End If

                If gain = False Then
                    List.SubItems.Add("")
                    List.SubItems.Add(valeur.Text)
                Else
                    List.SubItems.Add(valeur.Text)
                    List.SubItems.Add("")
                End If
                Dim exist As Boolean = False
                For i = 0 To ListView1.Items.Count - 1
                    If ListView1.Items(i).Text = code.Text Then
                        exist = True

                        ListView1.Items(i).Remove()
                        ListView1.Items.Insert(i, List)
                    End If
                Next
                If exist = False Then
                    ListView1.Items.Add(List)
                End If
                valeur.Clear()
                nb.Value = Nothing
                nb.Text = ""
                taux.Clear()
                libele.Clear()
                code.Clear()
                Dim listItem As ListViewItem
                For Each listItem In ListView1.Items
                    If listItem.Text = "561" Or listItem.Text = "564" Or listItem.Text = "610" Or listItem.Text = "660" Or listItem.Text = "980" Then
                        ListView1.Items.Remove(listItem)
                    End If
                Next
                code.Select()
                ButtonX2.Enabled = False
                totalas.Clear()
                totalgain.Clear()
                totalretenue.Clear()
                totalss.Clear()
                netpayer.Clear()
            Else : MessageBoxEx.Show("Veuillez saisir une valeur numerique", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub

    Private Sub ButtonX3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX3.Click
        Try
            If ListView1.Items.Count > 0 Then
                If paie.Checked Then
                    radio = "P"
                    Finalisation()
                Else
                    EnregistrBtn.Enabled = True
                    radio = "V"

                End If
                EnregistrBtn.Enabled = True
                SupprimerBtn.Enabled = True
            Else
                MessageBoxEx.Show("Veuillez saisir des rubrique avant de cliquer sur afficher les bouton", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub
    Sub Finalisation()
        Try
            totalss.Text = 0
            totalas.Text = 0
            totalgain.Text = 0
            totalretenue.Text = 0
            netpayer.Text = 0
            Dim listItem As ListViewItem
            For Each listItem In ListView1.Items
                If listItem.Text = "561" Or listItem.Text = "564" Or listItem.Text = "610" Or listItem.Text = "660" Or listItem.Text = "980" Then
                    ListView1.Items.Remove(listItem)
                End If
            Next
            Dim s2 As Double = 0
            Dim r2 As Double = 0
            For i = 0 To ListView1.Items.Count - 1
                If ListView1.Items.Item(i).SubItems(5).Text <> "" And ListView1.Items.Item(i).SubItems(5).Text <> "0" Then
                    If ListView1.Items.Item(i).SubItems(7).Text <> "" And ListView1.Items.Item(i).SubItems(7).Text <> "0" Then
                        r2 += ListView1.Items.Item(i).SubItems(5).Text
                    Else
                        s2 += ListView1.Items.Item(i).SubItems(5).Text.Replace(".", ",")
                    End If
                End If
            Next
            totalss.Text = s2 - r2
            Dim s3 As Double = 0
            For i = 0 To ListView1.Items.Count - 1
                If ListView1.Items.Item(i).SubItems(6).Text <> "" And ListView1.Items.Item(i).SubItems(6).Text <> "0" Then
                    s3 += ListView1.Items.Item(i).SubItems(6).Text.Replace(".", ",")
                End If
            Next
            totalgain.Text = s3
            Dim List As ListViewItem = New ListViewItem("561", 1)
            List.SubItems.Add("ASSURANCE CHOMAGE")
            List.SubItems.Add("")
            List.SubItems.Add("0.50")
            List.SubItems.Add(Math.Round((totalss.Text * 0.005), 2))
            List.SubItems.Add("")
            List.SubItems.Add("")
            List.SubItems.Add(Math.Round((totalss.Text * 0.005), 2))
            ListView1.Items.Add(List)
            Dim List1 As ListViewItem = New ListViewItem("564", 1)
            List1.SubItems.Add("RETRAITE ANTICIPEE")
            List1.SubItems.Add("")
            List1.SubItems.Add("0.50")
            List1.SubItems.Add(Math.Round((totalss.Text * 0.005), 2))
            List1.SubItems.Add("")
            List1.SubItems.Add("")
            List1.SubItems.Add(Math.Round((totalss.Text * 0.005), 2))
            ListView1.Items.Add(List1)
            Dim List2 As ListViewItem = New ListViewItem("610", 1)
            List2.SubItems.Add("RETENUE SECURITE SOCIALE")
            List2.SubItems.Add("")
            List2.SubItems.Add("8")
            List2.SubItems.Add(Math.Round((totalss.Text * 0.08), 2))
            List2.SubItems.Add("")
            List2.SubItems.Add("")
            List2.SubItems.Add(Math.Round((totalss.Text * 0.08), 2))
            ListView1.Items.Add(List2)
            If paie.Checked = True Then
                Dim List3 As ListViewItem = New ListViewItem("660", 1)
                List3.SubItems.Add("RETENUE MUTUELLE")
                List3.SubItems.Add("")
                List3.SubItems.Add("1.50")
                List3.SubItems.Add("")
                List3.SubItems.Add("")
                List3.SubItems.Add("")
                List3.SubItems.Add(Math.Round((totalss.Text * 0.015), 2))
                ListView1.Items.Add(List3)
            End If
            totalas.Text = totalss.Text - ((totalss.Text * 0.08) + (totalss.Text * 0.01))
            Dim s4 As Double = 0
            For i = 0 To ListView1.Items.Count - 1
                If ListView1.Items.Item(i).SubItems(4).Text <> "" And ListView1.Items.Item(i).SubItems(5).Text = "" And ListView1.Items.Item(i).SubItems(7).Text = "" Then
                    s4 += ListView1.Items.Item(i).SubItems(4).Text
                    'MsgBox(ListView1.Items.Item(i).SubItems(4).Text)
                End If
            Next
            totalas.Text += Math.Round(s4, 2)
            totalas.Text = Math.Round((totalas.Text + 0.01), 2)
            Console.WriteLine(totalas.Text)
            Dim abs As Double = 0
            Dim sab As Double = 0
            For i = 0 To ListView1.Items.Count - 1
                If ListView1.Items.Item(i).Text = "072" Then
                    abs = ListView1.Items.Item(i).SubItems(2).Text
                End If
                If ListView1.Items.Item(i).Text = "001" Then
                    sab = ListView1.Items.Item(i).SubItems(4).Text
                End If
            Next
            Dim List4 As ListViewItem = New ListViewItem("980", 1)
            List4.SubItems.Add("I. R. G.")
            List4.SubItems.Add("")
            List4.SubItems.Add("")
            List4.SubItems.Add("")
            List4.SubItems.Add("")
            List4.SubItems.Add("")
            Console.WriteLine(totalas.Text & " ," & sab & " ," & abs)
            'MsgBox(totalas.Text)
            'MsgBox(sab)
            'MsgBox(abs)
            List4.SubItems.Add(Math.Round(IRG08(totalas.Text, sab.ToString.Replace(".", ","), abs.ToString.Replace(".", ",")), 2))
            'MsgBox(IRG08(totalas.Text, sab.ToString.Replace(".", ","), abs.ToString.Replace(".", ",")))
            'MsgBox(Math.Round(IRG08(totalas.Text, sab.ToString.Replace(".", ","), abs.ToString.Replace(".", ",")), 2))
            ListView1.Items.Add(List4)
            Dim s5 As Double = 0
            For i = 0 To ListView1.Items.Count - 1
                If ListView1.Items.Item(i).SubItems(7).Text <> "" Then
                    s5 += ListView1.Items.Item(i).SubItems(7).Text
                End If
            Next
            totalretenue.Text = Math.Round(s5, 2)
            netpayer.Text = totalgain.Text - totalretenue.Text
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub

    Sub Finalisation1()
        Try
            totalss.Text = 0
            totalgain.Text = 0
            totalretenue.Text = 0
            netpayer.Text = 0
            Dim listItem As ListViewItem
            For Each listItem In ListView1.Items
                If listItem.Text = "561" Or listItem.Text = "564" Or listItem.Text = "610" Or listItem.Text = "980" Then
                    ListView1.Items.Remove(listItem)
                End If
            Next
            Dim s2 As Double = 0
            Dim r2 As Double = 0
            For i = 0 To ListView1.Items.Count - 1
                If ListView1.Items.Item(i).SubItems(5).Text <> "" Then
                    If ListView1.Items.Item(i).SubItems(7).Text <> "" Then
                        r2 += ListView1.Items.Item(i).SubItems(5).Text
                    Else
                        s2 += ListView1.Items.Item(i).SubItems(5).Text.Replace(".", ",")
                    End If
                End If
            Next
            totalss.Text = s2 - r2
            Dim s3 As Double = 0
            For i = 0 To ListView1.Items.Count - 1
                If ListView1.Items.Item(i).SubItems(6).Text <> "" Then
                    s3 += ListView1.Items.Item(i).SubItems(6).Text.Replace(".", ",")
                End If
            Next
            totalgain.Text = s3
            Dim List As ListViewItem = New ListViewItem("561", 1)
            List.SubItems.Add("ASSURANCE CHOMAGE")
            List.SubItems.Add("")
            List.SubItems.Add("0.50")
            List.SubItems.Add(Math.Round((totalss.Text * 0.005), 2))
            List.SubItems.Add("")
            List.SubItems.Add("")
            List.SubItems.Add(Math.Round((totalss.Text * 0.005), 2))
            ListView1.Items.Add(List)
            Dim List1 As ListViewItem = New ListViewItem("564", 1)
            List1.SubItems.Add("RETRAITE ANTICIPEE")
            List1.SubItems.Add("")
            List1.SubItems.Add("0.50")
            List1.SubItems.Add(Math.Round((totalss.Text * 0.005), 2))
            List1.SubItems.Add("")
            List1.SubItems.Add("")
            List1.SubItems.Add(Math.Round((totalss.Text * 0.005), 2))
            ListView1.Items.Add(List1)
            Dim List2 As ListViewItem = New ListViewItem("610", 1)
            List2.SubItems.Add("RETENUE SECURITE SOCIALE")
            List2.SubItems.Add("")
            List2.SubItems.Add("8")
            List2.SubItems.Add(Math.Round((totalss.Text * 0.08), 2))
            List2.SubItems.Add("")
            List2.SubItems.Add("")
            List2.SubItems.Add(Math.Round((totalss.Text * 0.08), 2))
            ListView1.Items.Add(List2)
            totalas.Text = totalss.Text - ((totalss.Text * 0.08) + (totalss.Text * 0.01))
            Dim s4 As Double = 0
            For i = 0 To ListView1.Items.Count - 1
                If ListView1.Items.Item(i).SubItems(4).Text <> "" And ListView1.Items.Item(i).SubItems(5).Text = "" And ListView1.Items.Item(i).SubItems(7).Text = "" Then
                    s4 += ListView1.Items.Item(i).SubItems(4).Text
                End If
            Next
            totalas.Text += Math.Round(s4, 2)
            totalas.Text = Math.Round((totalas.Text + 0.01), 2)
            Console.WriteLine(totalas.Text)
            Dim List4 As ListViewItem = New ListViewItem("980", 1)
            List4.SubItems.Add("I. R. G.")
            List4.SubItems.Add("")
            List4.SubItems.Add("")
            List4.SubItems.Add("")
            List4.SubItems.Add("")
            List4.SubItems.Add("")
            List4.SubItems.Add(Math.Round((totalas.Text * 0.1), 2))
            ListView1.Items.Add(List4)
            Dim s5 As Double = 0
            For i = 0 To ListView1.Items.Count - 1
                If ListView1.Items.Item(i).SubItems(7).Text <> "" Then
                    s5 += ListView1.Items.Item(i).SubItems(7).Text
                End If
            Next
            totalretenue.Text = Math.Round(s5, 2)
            netpayer.Text = totalgain.Text - totalretenue.Text
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub

    Private Sub nb_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            If taux.Text <> "" And nb.Text <> "" Then
                valeur.Text = taux.Text.Replace(".", ",") * nb.Text.Replace(".", ",")
            End If
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub

    Public Function IRG08(ByVal MBRUT As Double, Optional ByVal SalaireDeBase As Double = 0, Optional ByVal absence As Double = 0) As Double
        Try
            Dim asb As Double = 0
            Dim proa As Double = 0
            If SalaireDeBase > 0 And absence > 0 Then
                proa = 173.33 - absence
                asb = (SalaireDeBase / 173.33) * absence
                MBRUT += asb
            End If
            If MBRUT <= 15000 Then Return 0
            Dim TRS = {120000, 360000, 1440000, 9999999}
            Dim TAX = {0, 20, 30, 35}
            Dim IMPAN = {0.0, 48000.0, 372000.0, 3367999.65}
            Dim soumis As Double = 0
            Dim i As Integer
            i = 0
            soumis = Int(MBRUT / 10)
            soumis = Int(soumis * 10)
            Dim BRTS = Int(soumis * 12)
            Dim j = True
            Do While j
                If BRTS <= TRS(i) Then Exit Do
                i = i + 1
            Loop
            Dim n = BRTS - TRS(i - 1)
            Dim IMPOTA = (n * TAX(i) / 100) + Val(IMPAN(i - 1))
            Dim IMPM = IMPOTA / 12
            Dim ABAT = (40 * IMPM / 100)
            If ABAT < 1000 Then ABAT = 1000
            If ABAT > 1500 Then ABAT = 1500
            Dim RET = IMPM - ABAT
            If RET < 0 Then RET = 0
            Dim RTS1 = Int(RET * 10)
            RTS1 = RTS1 / 10
            If proa > 0 Then
                Dim IrgAsb = ((proa * RTS1) / 173.33)
                IrgAsb = Int(IrgAsb * 10)
                IrgAsb = IrgAsb / 10
                Return Math.Round(IrgAsb, 2)
            End If
            Return Math.Round(RTS1, 2)
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
        Return Nothing
    End Function

    Private Sub code_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles code.TextChanged
        Try
            If code.Text.Length = 3 Then
                Dim c1 = code.Text
                IsConnected("SELECT * FROM paie_rubrique WHERE ind='" & code.Text & "'", False)
                If myDR.HasRows = True Then
                    While (myDR.Read)
                        ButtonX2.Enabled = True
                        libele.Text = myDR("libind").ToString
                        If code.Text = "066" Or code.Text = "067" Or code.Text = "068" Or code.Text = "077" Or code.Text = "078" Or code.Text = "079" Then
                            taux.Text = Math.Round((myDR("tauxpu") * nbheure.Text), 2)
                        Else
                            If myDR("tauxpu") = "0" Then
                                taux.Text = ""
                            Else
                                taux.Text = myDR("tauxpu")
                            End If
                        End If
                        If code.Text = "072" Then
                            taux.Text = nbheure.Text
                        End If
                        If Not IsDBNull(myDR("soumits")) And myDR("soumits") = "O" Then
                            sass = True
                        Else : sass = False
                        End If
                        nb.Focus()
                        If taux.Text = "" And (nb.Text = "0,00" Or nb.Text = "") Then
                            valeur.Focus()
                        End If
                        If Not IsDBNull(myDR("soumiss")) And myDR("soumiss") = "O" Then
                            sai = True
                        Else : sai = False
                        End If
                        If IsDBNull(myDR("sens")) = False And myDR("sens") = "+" Then
                            gain = True
                        Else : gain = False
                        End If
                    End While
                End If
            End If
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub

    Private Sub ListView1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListView1.SelectedIndexChanged
        Try
            If ListView1.SelectedItems.Count > 0 Then
                ListView1.ContextMenuStrip = ContextMenuStrip1
            Else : ListView1.ContextMenuStrip = Nothing
            End If
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub

    Private Sub ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem1.Click
        Try
            For i = 0 To ListView1.Items.Count - 1
                If ListView1.Items(i).Selected = True Then
                    code.Text = ListView1.Items(i).Text
                    libele.Text = ListView1.Items(i).SubItems(1).Text
                    nb.Text = ListView1.Items(i).SubItems(2).Text
                    taux.Text = ListView1.Items(i).SubItems(3).Text
                    If ListView1.Items(i).SubItems(4).Text = "" Then
                        sass = False
                    Else : sass = True
                        valeur.Text = ListView1.Items(i).SubItems(4).Text
                    End If
                    If ListView1.Items(i).SubItems(5).Text = "" Then
                        sai = False
                    Else : sai = True
                        valeur.Text = ListView1.Items(i).SubItems(5).Text
                    End If
                    If ListView1.Items(i).SubItems(6).Text = "" Then
                        gain = False
                    Else : gain = True
                        valeur.Text = ListView1.Items(i).SubItems(6).Text
                    End If
                End If
            Next
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub

    Private Sub taux_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles taux.TextChanged
        Try
            If taux.Text <> "" And nb.Text <> "" Then
                valeur.Text = Math.Round((taux.Text.Replace(".", ",") * nb.Text.Replace(".", ",")), 2)
            End If
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub

    Private Sub nb_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nb.ValueChanged
        Try
            If taux.Text <> "" And nb.Text <> "" Then
                valeur.Text = Math.Round((taux.Text.Replace(".", ",") * nb.Text.Replace(".", ",")), 2)
            End If
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub

    Private Sub ToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem2.Click
        Try
            For i = 0 To ListView1.Items.Count - 1
                If ListView1.Items(i).Selected = True Then
                    ListView1.Items(i).Remove()
                    Exit For
                End If
            Next
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub

    Private Sub ButtonX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EnregistrBtn.Click
        Try
            If VerouillerCheck.Checked = True Then
                IsConnected("INSERT INTO `paie_blockage`(`id`,`matricule`,`moi_annee`,`blockage`,`entry_date`)VALUES(NULL,'" & mat.Text & "','" & datej.Text & "','1',NOW());", True)
            Else
                IsConnected("DELETE FROM `paie_blockage` WHERE `matricule`='" & mat.Text & "' and `moi_annee`='" & datej.Text & "' LIMIT 1;", True)
            End If
            If EnregistrBtn.Text = "Enregistrer" Then
                Dim quary As String
                Dim erreur As Boolean = False
                For i = 0 To ListView1.Items.Count - 1

                    Dim nombre As Double = 0
                    Dim taux As Double = 0
                    Dim soumis_Impots As Double = 0
                    Dim soumis_ss As Double = 0
                    Dim gain As Double = 0
                    Dim retenue As Double = 0

                    If ListView1.Items(i).SubItems(2).Text <> "" Then nombre = ListView1.Items(i).SubItems(2).Text
                    If ListView1.Items(i).SubItems(3).Text <> "" Then taux = ListView1.Items(i).SubItems(3).Text.Replace(".", ",")
                    If ListView1.Items(i).SubItems(4).Text <> "" Then soumis_Impots = ListView1.Items(i).SubItems(4).Text.Replace(".", ",")
                    If ListView1.Items(i).SubItems(5).Text <> "" Then soumis_ss = ListView1.Items(i).SubItems(5).Text.Replace(".", ",")
                    If ListView1.Items(i).SubItems(6).Text <> "" Then gain = ListView1.Items(i).SubItems(6).Text.Replace(".", ",")
                    If ListView1.Items(i).SubItems(7).Text <> "" Then retenue = ListView1.Items(i).SubItems(7).Text.Replace(".", ",")
                    'Console.WriteLine(ListView1.Items(i).SubItems(3).Text)
                    '
                    quary = " INSERT INTO paie_mensuel (Matricule, code, libellé, nombre, taux, soumis_Impots, soumis_ss, gain, retenue, net_payer, total_impots, total_ss, total_gain, total_retenue, mode_paiement, ncompte_bancaire,moi_annee, type,codepaie,codesection,tauxhoraire,EntreDate)  VALUES(" & mat.Text & ",'" & ListView1.Items(i).SubItems(0).Text & "','" & mysql_escape_string(ListView1.Items(i).SubItems(1).Text.Replace(",", ".")) & "'," & nombre.ToString.Replace(",", ".") & "," & taux.ToString.Replace(",", ".") & ",'" & soumis_Impots.ToString.Replace(",", ".") & "','" & soumis_ss.ToString.Replace(",", ".") & "','" & gain.ToString.Replace(",", ".") & "','" & retenue.ToString.Replace(",", ".") & "','" & netpayer.Text.Replace(",", ".") & "','" & totalas.Text.Replace(",", ".") & "','" & totalss.Text.Replace(",", ".") & "','" & totalgain.Text.Replace(",", ".") & "','" & totalretenue.Text.Replace(",", ".") & "','" & mode_paiement.Text & "','" & numbanque.Text & "','" & datej.Text & "','" & radio & "','" & codec & "','" & codedirection.Text & "','" & nbheure.Text & "',Now());"
                    'Clipboard.SetText(quary)
                    If IsConnected(quary, True) = False Then
                        erreur = True
                    End If
                Next
                If erreur = False Then
                    MessageBoxEx.Show("La paie a bien été enregistrer", "Succés", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    mat.Text = ""
                    nom.Clear()
                    prenom.Clear()
                    fonction.Clear()
                    ech.Clear()
                    cat.Clear()
                    sb.Clear()
                    numbanque.Clear()
                    numss.Clear()
                    nbheure.Clear()
                    service.Clear()
                    sf.Clear()
                    ListView1.Items.Clear()
                    code.Clear()
                    libele.Clear()
                    nb.Value = Nothing
                    taux.Clear()
                    valeur.Clear()
                    totalas.Clear()
                    totalgain.Clear()
                    totalretenue.Clear()
                    totalss.Clear()
                    netpayer.Clear()
                    mode_paiement.SelectedIndex = -1
                    EnregistrBtn.Enabled = False
                    SupprimerBtn.Enabled = False
                    VerouillerCheck.Checked = False
                End If
            Else
                EnregistrBtn.Enabled = True
                Dim quary As String
                Dim erreur As Boolean = False
                IsConnected("DELETE FROM paie_mensuel WHERE type='P' and Matricule ='" & mat.Text & "' and moi_annee='" & datej.Text & "'limit 30", True)
                For i = 0 To ListView1.Items.Count - 1
                    Dim nombre As Double = 0
                    Dim taux As Double = 0
                    Dim soumis_Impots As Double = 0
                    Dim soumis_ss As Double = 0
                    Dim gain As Double = 0
                    Dim retenue As Double = 0

                    If ListView1.Items(i).SubItems(2).Text <> "" Then nombre = ListView1.Items(i).SubItems(2).Text
                    If ListView1.Items(i).SubItems(3).Text <> "" Then taux = ListView1.Items(i).SubItems(3).Text.Replace(".", ",")
                    If ListView1.Items(i).SubItems(4).Text <> "" Then soumis_Impots = ListView1.Items(i).SubItems(4).Text.Replace(".", ",")
                    If ListView1.Items(i).SubItems(5).Text <> "" Then soumis_ss = ListView1.Items(i).SubItems(5).Text.Replace(".", ",")
                    If ListView1.Items(i).SubItems(6).Text <> "" Then gain = ListView1.Items(i).SubItems(6).Text.Replace(".", ",")
                    If ListView1.Items(i).SubItems(7).Text <> "" Then retenue = ListView1.Items(i).SubItems(7).Text.Replace(".", ",")
                    'Console.WriteLine(ListView1.Items(i).SubItems(3).Text)
                    quary = " INSERT INTO paie_mensuel (Matricule, code, libellé, nombre, taux, soumis_Impots, soumis_ss, gain, retenue, net_payer, total_impots, total_ss, total_gain, total_retenue, mode_paiement, ncompte_bancaire,moi_annee, type,codepaie,codesection,tauxhoraire,EntreDate)  VALUES(" & mat.Text & ",'" & ListView1.Items(i).SubItems(0).Text & "','" & ListView1.Items(i).SubItems(1).Text.Replace(",", ".") & "'," & nombre.ToString.Replace(",", ".") & "," & taux.ToString.Replace(",", ".") & ",'" & soumis_Impots.ToString.Replace(",", ".") & "','" & soumis_ss.ToString.Replace(",", ".") & "','" & gain.ToString.Replace(",", ".") & "','" & retenue.ToString.Replace(",", ".") & "','" & netpayer.Text.Replace(",", ".") & "','" & totalas.Text.Replace(",", ".") & "','" & totalss.Text.Replace(",", ".") & "','" & totalgain.Text.Replace(",", ".") & "','" & totalretenue.Text.Replace(",", ".") & "','" & mode_paiement.Text & "','" & numbanque.Text & "','" & datej.Text & "','" & radio & "','" & codec & "','" & codedirection.Text & "','" & nbheure.Text & "',Now());"
                    Clipboard.SetText(quary)
                    If IsConnected(quary, True) = False Then
                        erreur = True
                    End If
                Next
                If erreur = False Then
                    MessageBoxEx.Show("La paie a bien été enregistrer", "Succés", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    mat.Text = ""
                    nom.Clear()
                    prenom.Clear()
                    fonction.Clear()
                    ech.Clear()
                    cat.Clear()
                    sb.Clear()
                    numbanque.Clear()
                    numss.Clear()
                    nbheure.Clear()
                    service.Clear()
                    sf.Clear()
                    ListView1.Items.Clear()
                    code.Clear()
                    libele.Clear()
                    nb.Value = Nothing
                    taux.Clear()
                    valeur.Clear()
                    totalas.Clear()
                    totalgain.Clear()
                    totalretenue.Clear()
                    mode_paiement.SelectedIndex = -1
                    totalss.Clear()
                    netpayer.Clear()
                    EnregistrBtn.Enabled = False
                    SupprimerBtn.Enabled = False
                    EnregistrBtn.Text = "Enregistrer"
                    EnregistrBtn.Enabled = False
                    EnregistrBtn.Image = My.Resources.secure_ok
                    VerouillerCheck.Checked = False
                End If

            End If

        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub

    Private Sub direction_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles direction.SelectedIndexChanged
        Try
            If IsConnected("SELECT DISTINCT csect FROM paie_direction where liborg='" & direction.Text & "'", False) = True Then
                If myDR.HasRows = True Then
                    While (myDR.Read())
                        codedirection.Text = myDR("csect")
                    End While
                End If
            End If
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub

    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles variable.CheckedChanged
        Try
            nb.Enabled = False
            taux.Enabled = False
            ListView1.Items.Clear()
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub

    Private Sub paie_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles paie.CheckedChanged
        Try
            nb.Enabled = True
            taux.Enabled = True
            If mat.Text.Length = 5 Then
                IsConnected("SELECT * FROM paie_mensuel, paie_rubrique WHERE moi_annee='" & moianpr & "' and Matricule='" & mat.Text & "' and code=ind and fix='F'and code<>'980' and code<>'660' and code<>'610' and code<>'564'and code<>'561' and paie_mensuel.type ='P'", False)
                'Clipboard.SetText("SELECT * FROM paie_mensuel, paie_rubrique WHERE moi_annee='" & moianpr & "' and Matricule='" & mat.Text & "' and code=ind and code<>'001' and fix='F'and code<>'980' and code<>'660' and code<>'610' and code<>'564'and code<>'561' and paie_mensuel.type ='P'")
                If myDR.HasRows = True Then
                    While (myDR.Read)
                        Dim List1 As ListViewItem = New ListViewItem(myDR("code").ToString, 0)
                        List1.SubItems.Add(myDR("libellé").ToString)
                        List1.SubItems.Add(myDR("nombre").ToString)
                        List1.SubItems.Add(myDR("taux").ToString)
                        List1.SubItems.Add(myDR("soumis_Impots").ToString)
                        List1.SubItems.Add(myDR("soumis_ss").ToString)
                        List1.SubItems.Add(myDR("gain").ToString)
                        List1.SubItems.Add(myDR("retenue").ToString)
                        ListView1.Items.Add(List1)
                        ' mode_paiement.Text = myDR("mode_paiement").ToString
                    End While
                End If
            End If
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub

    Private Sub ButtonX4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SupprimerBtn.Click
        Try
            If MessageBoxEx.Show("Voullez vous vraiment supprimer cette paie ?" & Environment.NewLine & "ATTENTION : CETTE ACTION EST IRREVERSIBLE !!!" & Environment.NewLine & "Cliquez sur 'Oui' pour Supprimer , 'No' pour Annuler la supprission", "Rechargement de paie ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                If paie.Checked = True Then
                    IsConnected("DELETE FROM paie_mensuel WHERE type='P' and Matricule ='" & mat.Text & "' and moi_annee='" & datej.Text & "'limit 30", True)
                    MessageBoxEx.Show("La paie est supprimée", "Succés", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    mat.Text = ""
                    nom.Clear()
                    prenom.Clear()
                    fonction.Clear()
                    ech.Clear()
                    cat.Clear()
                    sb.Clear()
                    numbanque.Clear()
                    numss.Clear()
                    nbheure.Clear()
                    service.Clear()
                    sf.Clear()
                    ListView1.Items.Clear()
                    code.Clear()
                    libele.Clear()
                    nb.Value = Nothing
                    taux.Clear()
                    valeur.Clear()
                    totalas.Clear()
                    totalgain.Clear()
                    totalretenue.Clear()
                    totalss.Clear()
                    netpayer.Clear()
                    EnregistrBtn.Enabled = False
                    EnregistrBtn.Text = "Enregistrer"
                    EnregistrBtn.Image = My.Resources.secure_ok
                    SupprimerBtn.Enabled = False
                End If

            End If

        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub

    Private Sub datej_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles datej.TextChanged
        EnregistrBtn.Visible = False
        paieVerouilleLbl.Visible = False
        SupprimerBtn.Visible = False
        If datej.Text.Length = 6 Then
            loadMatricule()
            'MessageBoxEx.Show("La paie est vérouillé pour ce mois, vous ne pouvez pas ni modifier ni supprimer cette paie", "Paie vérouillé", MessageBoxButtons.OK, MessageBoxIcon.Error)
            If IsConnected("SELECT * FROM paie_verrouillage WHERE moi_annee='" & mysql_escape_string(datej.Text) & "' LIMIT 1", False) Then
                If myDR.HasRows Then
                    paieVerouilleLbl.Visible = True
                    paieVerouilleLbl.ForeColor = ColorTranslator.FromHtml("#c0392b")
                    EnregistrBtn.Visible = False
                    SupprimerBtn.Visible = False
                Else
                    paieVerouilleLbl.Visible = False
                    EnregistrBtn.Visible = True
                    SupprimerBtn.Visible = True
                End If
            End If

        End If
        If datej.Text.Length = 6 And mat.Text.Length = 5 Then

            If MessageBoxEx.Show("Voullez vous rechercher la paie avec la date que vous avez entré?", "Rechargement de paie", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                Try
                    Dim exst As Boolean = False
                    Dim a As Integer = 0
                    Dim erreur As Boolean = False
                    code.Clear()
                    If mat.Text.Length = 5 Then
                        SupprimerBtn.Enabled = False
                        If IsConnected("SELECT * FROM paie_mensuel WHERE Matricule='" & mat.Text & "' and moi_annee='" & datej.Text & "' and type='P'", False) = True Then
                            If myDR.HasRows = True Then
                                EnregistrBtn.Text = "Enregistrer les modifications "
                                EnregistrBtn.Enabled = True
                                exst = True
                                ListView1.Items.Clear()
                                While (myDR.Read)
                                    Dim var As Integer = 0
                                    If myDR("gain").ToString = 0 Then
                                        var = 1
                                    End If

                                    GroupBox2.Enabled = True
                                    datej.Text = myDR("moi_annee").ToString
                                    nbheure.Text = myDR("tauxhoraire").ToString
                                    codedirection.Text = myDR("codesection").ToString
                                    totalas.Text = myDR("total_impots").ToString
                                    totalss.Text = myDR("total_ss").ToString
                                    totalgain.Text = myDR("total_gain").ToString
                                    totalretenue.Text = myDR("total_retenue").ToString
                                    netpayer.Text = myDR("net_payer").ToString
                                    Dim List1 As ListViewItem = New ListViewItem(myDR("code").ToString, var)
                                    List1.SubItems.Add(myDR("libellé").ToString)
                                    List1.SubItems.Add(myDR("nombre").ToString)
                                    List1.SubItems.Add(myDR("taux").ToString)
                                    List1.SubItems.Add(myDR("soumis_Impots").ToString)
                                    List1.SubItems.Add(myDR("soumis_ss").ToString)
                                    List1.SubItems.Add(myDR("gain").ToString)
                                    List1.SubItems.Add(myDR("retenue").ToString)
                                    List1.SubItems.Add(myDR("nombre").ToString)
                                    List1.SubItems.Add(myDR("taux").ToString)
                                    List1.SubItems.Add(myDR("soumis_Impots").ToString)
                                    List1.SubItems.Add(myDR("soumis_ss").ToString)
                                    ListView1.Items.Add(List1)
                                    ' mode_paiement.Text = myDR("mode_paiement").ToString
                                    If IsNumeric(sb.Text) Then
                                        nbheure.Text = String.Format("{0:0.00}", (sb.Text / 173.33))
                                    End If
                                End While
                                IsConnected("SELECT * FROM employes WHERE Matricule=" & mat.Text, False)
                                If myDR.HasRows = True Then
                                    While (myDR.Read)
                                        nom.Text = myDR("Nom")
                                        prenom.Text = myDR("Prénom").ToString()
                                        fonction.Text = myDR("Fonction").ToString
                                        ech.Text = myDR("Ech").ToString
                                        cat.Text = myDR("Cat").ToString
                                        sb.Text = myDR("S_B_01_14").ToString
                                        direction.Text = myDR("Direction").ToString
                                        sf.Text = myDR("sit_fam").ToString
                                        EnregistrBtn.Enabled = False
                                        EnregistrBtn.Text = "Enregistrer les modifications "
                                        EnregistrBtn.Image = My.Resources.edit
                                    End While
                                End If
                                'If exst = True Then
                                '    IsConnected("SELECT * FROM paie_verrouillage WHERE Matricule='" & mat.Text & "' and moi_annee='" & datej.Text & "' LIMIT 1", False)
                                '    If myDR.HasRows = True Then
                                '        verrioullerBtn.Enabled = False
                                '        EnregistrBtn.Visible = False
                                '        SupprimerBtn.Visible = False
                                '    Else
                                '        verrioullerBtn.Enabled = True
                                '        EnregistrBtn.Visible = True
                                '        SupprimerBtn.Visible = True
                                '    End If
                                'Else
                                '    EnregistrBtn.Visible = True
                                '    SupprimerBtn.Visible = True
                                'End If
                                If exst = True Then
                                    IsConnected("SELECT * FROM paie_blockage WHERE Matricule='" & mat.Text & "' and moi_annee='" & datej.Text & "' LIMIT 1", False)
                                    If myDR.HasRows = True Then
                                        VerouillerCheck.Checked = True

                                    Else
                                        VerouillerCheck.Checked = False
                                    End If
                                Else
                                    VerouillerCheck.Checked = False
                                End If
                                IsConnected("SELECT * FROM code_papers WHERE Matricule=" & mat.Text, False)
                                If myDR.HasRows = True Then
                                    While (myDR.Read)
                                        Try
                                            numbanque.Text = myDR("Num_CPT").ToString
                                            numss.Text = myDR("Num_SS").ToString
                                            codedirection.Text = myDR("Affectation").ToString
                                        Catch ex As Exception

                                        End Try
                                    End While
                                End If

                            Else
                                EnregistrBtn.Text = "Enregistrer"
                                verrioullerBtn.Enabled = False
                                EnregistrBtn.Visible = True
                                SupprimerBtn.Visible = True
                                EnregistrBtn.Enabled = False
                                EnregistrBtn.Image = My.Resources.secure_ok
                                ListView1.Items.Clear()
                                IsConnected("SELECT * FROM Employes WHERE Employes.Matricule=" & mat.Text, False)
                                If myDR.HasRows = True Then
                                    While (myDR.Read)
                                        nom.Text = myDR("Nom").ToString
                                        prenom.Text = myDR("Prénom").ToString
                                        fonction.Text = myDR("Fonction").ToString
                                        ech.Text = myDR("Ech").ToString
                                        cat.Text = myDR("Cat").ToString
                                        sb.Text = myDR("S_B_01_14").ToString
                                        If IsNumeric(sb.Text) Then
                                            nbheure.Text = String.Format("{0:0.00}", (sb.Text / 173.33))
                                        End If
                                        direction.Text = myDR("Direction").ToString
                                        sf.Text = myDR("sit_fam").ToString
                                        GroupBox2.Enabled = True
                                        Dim List As ListViewItem = New ListViewItem("001", 0)
                                        List.SubItems.Add("SALAIRE DE BASE")
                                        List.SubItems.Add("")
                                        List.SubItems.Add("")
                                        List.SubItems.Add(sb.Text)
                                        List.SubItems.Add(sb.Text)
                                        List.SubItems.Add(sb.Text)
                                        List.SubItems.Add("")
                                        ListView1.Items.Add(List)
                                        Dim moi As String = Date.Now.ToString("MM") - 1
                                        Dim anne As String = Date.Now.ToString("yyyy")
                                        If moi = 0 Then
                                            anne -= 1
                                            moi = "12"
                                        End If
                                        If datej.Text.Length = 6 Then
                                            moi = datej.Text.Substring(0, 2) - 1
                                            If moi.Length < 1 Then moi = "0" & moi
                                            anne = datej.Text.Substring(2, 4)
                                            If moi = 0 Then
                                                anne -= 1
                                                moi = "12"
                                            End If
                                        End If


                                        IsConnected("SELECT Sum(Absence) AS Absence FROM presence_pointage WHERE  NOT EXISTS(SELECT  * FROM    joursferies  WHERE   presence_pointage.date_pointage = joursferies.jourf) AND presence_pointage.date_pointage BETWEEN '" & anne & "-" & moi & "-01' AND '" & anne & "-" & moi & "-31' AND Matricule=" & mat.Text & " GROUP BY Matricule;", False)
                                        If myDR.HasRows = True Then
                                            While (myDR.Read)
                                                Dim List1 As ListViewItem = New ListViewItem("072", 1)
                                                List1.SubItems.Add("RETENUE ABSENCE")
                                                List1.SubItems.Add(myDR("Absence").ToString)
                                                List1.SubItems.Add(nbheure.Text)
                                                List1.SubItems.Add(Math.Round((nbheure.Text * myDR("Absence")), 2))
                                                List1.SubItems.Add(Math.Round((nbheure.Text * myDR("Absence")), 2))
                                                List1.SubItems.Add("")
                                                List1.SubItems.Add(Math.Round((nbheure.Text * myDR("Absence")), 2))
                                                ListView1.Items.Add(List1)
                                            End While
                                        End If
                                        Dim moiannn As String = moi & anne
                                        IsConnected("SELECT moi_annee FROM paie_mensuel, paie_rubrique WHERE Matricule='" & mat.Text & "' and code=ind and code<>'001' and fix='F'and code<>'980' and code<>'660' and code<>'610' and code<>'564'and code<>'561' and paie_mensuel.type ='P' order by idpaie_monsuel desc LIMIT 1", False)
                                        If myDR.HasRows Then
                                            While myDR.Read
                                                If myDR("moi_annee").ToString <> "" Then
                                                    moiannn = myDR("moi_annee").ToString
                                                End If
                                            End While
                                        End If
                                        IsConnected("SELECT * FROM paie_mensuel, paie_rubrique WHERE moi_annee='" & moiannn & "' and Matricule='" & mat.Text & "' and code=ind and code<>'001' and fix='F'and code<>'980' and code<>'660' and code<>'610' and code<>'564'and code<>'561' and paie_mensuel.type ='P'", False)
                                        If myDR.HasRows = True Then
                                            While (myDR.Read)
                                                Dim i As Integer = IIf(myDR("retenue").ToString = "", 1, 0)
                                                Dim List1 As ListViewItem = New ListViewItem(myDR("code").ToString, i)
                                                List1.SubItems.Add(myDR("libellé").ToString)
                                                List1.SubItems.Add(myDR("nombre").ToString)
                                                List1.SubItems.Add(myDR("taux").ToString)
                                                List1.SubItems.Add(myDR("soumis_Impots").ToString)
                                                List1.SubItems.Add(myDR("soumis_ss").ToString)
                                                List1.SubItems.Add(myDR("gain").ToString)
                                                List1.SubItems.Add(myDR("retenue").ToString)
                                                ListView1.Items.Add(List1)
                                                ' mode_paiement.Text = myDR("mode_paiement").ToString
                                            End While
                                        End If
                                        For i = 0 To ListView1.Items.Count - 1
                                            If ListView1.Items(i).Text = "0" Then
                                                ListView1.Items(i).Text = ""
                                            End If
                                            For j = 1 To 7
                                                If ListView1.Items(i).SubItems(j).Text = "0" Then
                                                    ListView1.Items(i).SubItems(j).Text = ""
                                                End If

                                            Next
                                        Next
                                    End While
                                End If
                                IsConnected("SELECT * FROM code_papers WHERE Matricule=" & mat.Text, False)
                                If myDR.HasRows = True Then
                                    While (myDR.Read)
                                        numbanque.Text = myDR("Num_CPT").ToString
                                        numss.Text = myDR("Num_SS").ToString
                                        codedirection.Text = myDR("Affectation").ToString
                                    End While
                                End If
                            End If
                        End If
                    Else
                        ' mat.Text = ""
                        nom.Clear()
                        prenom.Clear()
                        fonction.Clear()
                        ech.Clear()
                        cat.Clear()
                        sb.Clear()
                        numbanque.Clear()
                        numss.Clear()
                        nbheure.Clear()
                        service.Clear()
                        sf.Clear()
                        ListView1.Items.Clear()
                        code.Clear()
                        libele.Clear()
                        nb.Value = Nothing
                        taux.Clear()
                        valeur.Clear()
                        totalas.Clear()
                        totalgain.Clear()
                        totalretenue.Clear()
                        totalss.Clear()
                        netpayer.Clear()
                        mode_paiement.SelectedIndex = -1
                        EnregistrBtn.Enabled = False
                    End If
                    For i = 0 To ListView1.Items.Count - 1
                        If ListView1.Items(i).Text = "0" Then
                            ListView1.Items(i).Text = ""
                        End If
                        For j = 1 To 7
                            If ListView1.Items(i).SubItems(j).Text = "0" Then
                                ListView1.Items(i).SubItems(j).Text = ""
                            End If

                        Next
                    Next
                Catch ex As Exception
                    EnvoiError(ex.Message)
                End Try
            Else
                Try
                    If IsConnected("SELECT * FROM paie_mensuel WHERE Matricule='" & mat.Text & "' and moi_annee='" & datej.Text & "' and type='P'", False) = True Then
                        If myDR.HasRows = True Then
                            EnregistrBtn.Text = "Enregistrer les modifications "
                        End If
                    End If
                Catch ex As Exception
                    EnvoiError(ex.Message)
                End Try
            End If

        End If
    End Sub


    Private Sub valeur_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles valeur.KeyPress
        'If Not IsNumeric(valeur.Text) And valeur.Text.Length > 0 Then
        '    MessageBoxEx.Show("Vous ne pouvez pas introduire des caractaires dans ce champ", "Erreur ", MessageBoxButtons.OK, MessageBoxIcon.Error)
        'ElseIf valeur.Text.Length > 0 Then
        '    If CDbl(valeur.Text) > ValeurMax Then
        '        e.Handled = True
        '        Return
        '    End If
        'End If
        If e.KeyChar <> ControlChars.Back AndAlso e.KeyChar <> "-"c AndAlso e.KeyChar <> "."c AndAlso e.KeyChar <> ","c Then
            'allow backspace for deleting and minus simbol
            e.Handled = Not Char.IsNumber(e.KeyChar)
            'allow numbers only
            If Not e.Handled Then
                Dim num As Double = Double.Parse(String.Format("{0}{1}", If(valeur.Text = String.Empty, "", valeur.Text.Replace(".", ",")), e.KeyChar.ToString().Replace(".", ",")))
                If num > ValeurMax Then
                    e.Handled = True
                End If
            End If
        End If
    End Sub


    Private Sub ValeurMaxLbl_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles ValeurMaxLbl.LinkClicked
        If ValeurMaxFrm.ShowDialog = Windows.Forms.DialogResult.OK Then
            ' ValeurMax = My.Settings.ValeurMax
            ValeurMax = ValeurMaxFrm.Valeurmax
            My.Settings.ValeurMax = ValeurMax
            My.Settings.Save()
            ValeurMaxLbl.Text = "la valeur MAX : " & ValeurMax & " DA  , Cliquer pour modifier"
        End If
    End Sub

    Private Sub ButtonX5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles verrioullerBtn.Click
        If mat.Text.Length = 5 And datej.Text.Length = 6 Then
            If MessageBoxEx.Show("Voullez vous vraiment verrouiller cette paie ?" & Environment.NewLine & "Attention: lorsque une paie est verrouillé, elle sera unéditable !", "Confirmation ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                IsConnected("Insert into paie_verrouillage Values(Null,'" & mat.Text & "','" & datej.Text & "','1',NOW())", True)
                verrioullerBtn.Enabled = False
                EnregistrBtn.Visible = False
                SupprimerBtn.Visible = False
            End If
        End If
    End Sub

    Private Sub loadMatricule()
        MatriculeList.Properties.Items.Clear()
        IsConnected("SELECT * FROM (SELECT DISTINCT(employes.Matricule),employes.Nom,employes.Prénom,paie_mensuel.moi_annee,paie_blockage.blockage FROM employes LEFT OUTER JOIN paie_mensuel ON employes.Matricule=paie_mensuel.Matricule  LEFT OUTER JOIN paie_blockage ON employes.Matricule=paie_blockage.Matricule ) P WHERE moi_annee= '" & datej.Text & "' or  moi_annee is Null ", False)
        If myDR.HasRows Then
            While myDR.Read
                Dim h As Integer = 2
                If myDR("moi_annee").ToString <> "" Then
                    h = 1
                    
                End If
                If myDR("blockage").ToString = "1" Then
                    h = 3
                End If
                MatriculeList.Properties.Items.Add(New ImageComboBoxItem(myDR("Matricule").ToString & " - " & myDR("Nom").ToString & " " & myDR("Prénom").ToString, myDR("Matricule").ToString, h))
            End While
            MatriculeList.Properties.SmallImages = StatImageList
            MatriculeList.Properties.LargeImages = StatImageList
        End If
    End Sub

    Private Sub nb_KeyPress(sender As Object, e As KeyPressEventArgs) Handles nb.KeyPress
        If e.KeyChar = "."c Then e.KeyChar = ","
    End Sub
End Class