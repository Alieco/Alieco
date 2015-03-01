Imports DevComponents.DotNetBar

Public Class DivisonnerBonCommande
    Public codebcDiv As String = ""
    Dim desig As String = ""
    Dim qt As String = ""
    Dim poids As String = ""
    Dim pu As String = ""
    Dim montant As String = ""
    Dim tva1 As String = ""
    Dim timbre1 As String = ""
    Dim qt1 As String = ""
    Dim j As String = ""
    Private Sub noe_load()
        OEComboBoxEx1.Items.Clear()
        OEComboBoxEx2.Items.Clear()
        IsConnected("SELECT distinct code_affaire FROM commercial_affaire", False)
        If myDR.HasRows = True Then
            While (myDR.Read())
                OEComboBoxEx1.Items.Add(myDR("code_affaire"))
                OEComboBoxEx2.Items.Add(myDR("code_affaire"))
            End While
        End If
    End Sub
    Private Sub DivisonnerBonCommande_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If codebcDiv <> "" Then
            IsConnected("SELECT * FROM logistique_appro_bcdesig WHERE codebc='" & codebcDiv & "'", False)
            If myDR.HasRows Then
                While myDR.Read
                    Dim List As ListViewItem = New ListViewItem(myDR("desigbc").ToString)
                    List.SubItems.Add(myDR("Qte").ToString)
                    List.SubItems.Add(myDR("poids").ToString)
                    List.SubItems.Add(myDR("pu").ToString)
                    List.SubItems.Add(myDR("montantbc").ToString)
                    ListView1.Items.Add(List)
                End While
                total.Text = myDR("totalht").ToString
                tva.Text = myDR("tauxva").ToString
                timbre.Text = myDR("timbre").ToString
                ttc.Text = myDR("montanttotal").ToString
                tva1 = myDR("tva").ToString
                timbre1 = myDR("timbre").ToString
            End If
        End If
        noe_load()
    End Sub
    Private Sub ListView1_Click(sender As Object, e As EventArgs) Handles ListView1.Click
        If ListView1.SelectedItems.Count > 0 Then
            QTNumericUpDown1.Maximum = ListView1.SelectedItems(0).SubItems(1).Text
            QTNumericUpDown1.Value = ListView1.SelectedItems(0).SubItems(1).Text
            desig = ListView1.SelectedItems(0).SubItems(0).Text
            qt = ListView1.SelectedItems(0).SubItems(1).Text
            poids = ListView1.SelectedItems(0).SubItems(2).Text
            pu = ListView1.SelectedItems(0).SubItems(3).Text
            montant = ListView1.SelectedItems(0).SubItems(4).Text
        End If
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles TransfereButton1.Click
        If QTNumericUpDown1.Value = 0 Then
            'J'ai mis MsgBox parceke je voulais faire vite, Je vous laisse le privillege de le changer ;)
            'Hade les messages bache tachfaw 3liya lollll
            'j'espere marakoumeche tkolou chehal sameta :P
            MsgBox("Veuillez choisir une designation avant de cliquer sur le bouton!")
        Else
            qt1 = ""
            qt1 = qt - QTNumericUpDown1.Value
            qt = QTNumericUpDown1.Value
            '
            For i = 0 To ListView2.Items.Count - 1
                If desig = ListView2.Items(i).SubItems(0).Text Then
                    qt = qt + ListView2.Items(i).SubItems(1).Text
                    ListView2.Items(i).Remove()
                End If
            Next
            Dim List As ListViewItem = New ListViewItem(desig, 1)
            List.SubItems.Add(qt)
            List.SubItems.Add(poids)
            List.SubItems.Add(pu)
            List.SubItems.Add(Math.Round((pu * qt), 2))
            ListView2.Items.Add(List)
            If qt1 = "0" Then
                If ListView1.SelectedItems.Count > 0 Then
                    ListView1.SelectedItems(0).Remove()
                End If
            Else
                ListView1.SelectedItems(0).SubItems(1).Text = qt1
                ListView1.SelectedItems(0).SubItems(4).Text = Math.Round((pu * qt1), 2)
            End If
            qt = ""
            desig = ""
            pu = ""
            poids = ""
            montant = ""
            totauxlist1()
            totauxlist2()
        End If
    End Sub
    Private Sub RetourButton1_Click(sender As Object, e As EventArgs) Handles RetourButton1.Click
        If QTNumericUpDown1.Value = 0 Then
            MsgBox("Veuillez choisir une designation avant de cliquer sur le bouton!")
        Else
            qt1 = ""
            qt1 = qt - QTNumericUpDown1.Value
            qt = QTNumericUpDown1.Value
            Dim List As ListViewItem = New ListViewItem(desig, 1)
            List.SubItems.Add(qt)
            List.SubItems.Add(poids)
            List.SubItems.Add(pu)
            List.SubItems.Add(Math.Round((pu * qt), 2))
            ListView1.Items.Add(List)
            If qt1 = "0" Then
                If ListView2.SelectedItems.Count > 0 Then
                    ListView2.SelectedItems(0).Remove()
                End If
            Else
                ListView2.SelectedItems(0).SubItems(1).Text = qt1
                ListView2.SelectedItems(0).SubItems(4).Text = Math.Round((pu * qt1), 2)
            End If
            qt = ""
            desig = ""
            pu = ""
            poids = ""
            montant = ""
            totauxlist1()
            totauxlist2()
        End If
    End Sub
    Sub totauxlist2()
        If ListView2.Items.Count >= 0 Then
            Dim total1 As Double = 0
            For i = 0 To ListView2.Items.Count - 1
                total1 += ListView2.Items(i).SubItems(4).Text
            Next
            totalTextBoxX4.Text = total1
            If tva1 <> "0" Then
                tvaTextBoxX3.Text = Math.Round((total1 * tva1), 2)
            Else
                tvaTextBoxX3.Text = 0
            End If
            If timbre1 <> "0" Then
                timbreTextBoxX1.Text = Math.Round((total1 * 0.2), 2)
            Else : timbreTextBoxX1.Text = 0
            End If
            ttcTextBoxX2.Text = Math.Round((total1 + tvaTextBoxX3.Text + timbreTextBoxX1.Text), 2)
        End If
    End Sub
    Sub totauxlist1()
        If ListView1.Items.Count >= 0 Then
            Dim total1 As Double = 0
            For i = 0 To ListView1.Items.Count - 1
                total1 += ListView1.Items(i).SubItems(4).Text
            Next
            total.Text = total1
            If tva1 <> "0" Then
                tva.Text = Math.Round((total1 * tva1), 2)
            Else
                tva.Text = 0
            End If
            If timbre1 <> "0" Then
                timbre.Text = Math.Round((total1 * 0.2), 2)
            Else : timbre.Text = 0
            End If
            ttc.Text = Math.Round((total1 + tva.Text + timbre.Text), 2)
        End If
    End Sub

    Private Sub ListView2_Click(sender As Object, e As EventArgs) Handles ListView2.Click
        If ListView2.SelectedItems.Count > 0 Then
            QTNumericUpDown1.Maximum = ListView2.SelectedItems(0).SubItems(1).Text
            QTNumericUpDown1.Value = ListView2.SelectedItems(0).SubItems(1).Text
            desig = ListView2.SelectedItems(0).SubItems(0).Text
            qt = ListView2.SelectedItems(0).SubItems(1).Text
            poids = ListView2.SelectedItems(0).SubItems(2).Text
            pu = ListView2.SelectedItems(0).SubItems(3).Text
            montant = ListView2.SelectedItems(0).SubItems(4).Text
        End If
    End Sub

    Private Sub EnregistrerButtonX6_Click(sender As Object, e As EventArgs) Handles EnregistrerButtonX6.Click
        'On ce moment la ou je vous ecris Amina rahi tkoli oui normalement matrohiche tu restes ici
        Dim id
        Dim erreur As Boolean = False
        Dim codefour As String = ""
        Dim tvaa As String = ""
        IsConnected("INSERT INTO logistique_appro_bonachat(`nature`,`type`,`synthese`,`DateBA`,`ref`,`demandeur`,`monnaie`,`delaiexe`,`modeexpe`,`modepaiem`,`ref_offre`,`imputation`,`dateEnreg`,`client`,`user`) (SELECT nature,type,synthese,DateBC,ref,demandeur,monnaie,delaiexe,modeexpe,modepaiem,ref_offre,imputation,dateEnreg,client,user FROM logistique_appro_bondecommande WHERE reference ='" & num.Text & "' limit 1)", True)
        Dim code = NumeroTextBoxX5.Text.Split("/")
        Dim c = code(0).ToString.Substring(1)
        IsConnected("UPDATE `logistique_appro_bondecommande` SET `etatCommande` ='1' WHERE `codebc` =" & c & " limit 1; ", True)
        IsConnected("SELECT idlogistique_appro_bonachat FROM logistique_appro_bonachat WHERE codeba='" & c & "'", False)
        If myDR.HasRows Then
            While myDR.Read
                id = myDR("idlogistique_appro_bonachat").ToString
            End While
        End If
        If IsConnected("UPDATE `logistique_appro_bonachat` SET `codeba` = '" & c & "',`reference` = '" & NumeroTextBoxX5.Text & "',`oe` = '" & OEComboBoxEx2.Text & "',`codestruc` = '" & codeStruct.Text & "',`namestruc` ='" & NameStructTextBoxX1.Text & "' WHERE `idlogistique_appro_bonachat` = '" & id & "';", True) = True Then
            erreur = True
        Else
            erreur = False
        End If
        'Mohamed je sais que tu vas dire que c de la merde (et moi je te dirais mais ca fonctionne ca marche ;) n'est ce pas farid
        IsConnected("SELECT * FROM logistique_appro_badesig WHERE codeba='" & c & "'", False)
        If myDR.HasRows Then
            While myDR.Read
                codefour = myDR("codefour").ToString
                tvaa = myDR("tva").ToString
            End While
        End If
        For i = 0 To ListView2.Items.Count - 1
            Dim q1 = "INSERT INTO logistique_appro_badesig VALUES(NULL,'" & c & "','" & mysql_escape_string(ListView2.Items(i).SubItems(0).Text) & "','" & ListView2.Items(i).SubItems(1).Text & "','" & ListView2.Items(i).SubItems(2).Text & "','" & ListView2.Items(i).SubItems(3).Text & "','" & ListView2.Items(i).SubItems(4).Text & "','" & totalTextBoxX4.Text & "','" & tvaa & "','" & timbreTextBoxX1.Text & "','" & ttcTextBoxX2.Text & "','" & tvaTextBoxX3.Text & "','" & codefour & "')"
            If IsConnected(q1, True) = True Then
                erreur = True
            End If
        Next
        If erreur = True Then
            MessageBoxEx.Show("Le bon a bien ete enregistre", "Succés", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ListView2.Items.Clear()
            totalTextBoxX4.Clear()
            tvaTextBoxX3.Clear()
            timbreTextBoxX1.Clear()
            ttcTextBoxX2.Clear()
            NameStructTextBoxX1.Clear()
            codeStruct.Clear()
            NumeroTextBoxX5.Clear()
            OEComboBoxEx2.Text = ""
        Else : MessageBoxEx.Show("Le bon n'a pas été enregistre", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub EnregistrementtotalButtonX1_Click(sender As Object, e As EventArgs) Handles EnregistrementtotalButtonX1.Click
        'il est 13:16 et je demande a mohamed et farid de se lever pour aller faire la priere comme tout les jours !!!!!
        'de passage mohamed rouh djawez l'armé hihihihihi
        Dim id
        Dim erreur As Boolean = False
        Dim codefour As String = ""
        Dim tvaa As String = ""
        IsConnected("INSERT INTO logistique_appro_bonachat(`nature`,`type`,`synthese`,`DateBA`,`ref`,`demandeur`,`monnaie`,`delaiexe`,`modeexpe`,`modepaiem`,`ref_offre`,`imputation`,`dateEnreg`,`client`,`user`) (SELECT nature,type,synthese,DateBC,ref,demandeur,monnaie,delaiexe,modeexpe,modepaiem,ref_offre,imputation,dateEnreg,client,user FROM logistique_appro_bondecommande WHERE reference ='" & num.Text & "' limit 1)", True)
        Dim code = num.Text.Split("/")
        Dim c = code(0).ToString.Substring(1)
        IsConnected("SELECT idlogistique_appro_bonachat FROM logistique_appro_bonachat WHERE codeba='" & c & "'", False)
        If myDR.HasRows Then
            While myDR.Read
                id = myDR("idlogistique_appro_bonachat").ToString
            End While
        End If
        If IsConnected("UPDATE `logistique_appro_bonachat` SET `codeba` = '" & c & "',`reference` = '" & num.Text & "',`oe` = '" & OEComboBoxEx1.Text & "',`codestruc` = '" & CodestructTextBoxX3.Text & "',`namestruc` ='" & NameStructTextBoxX2.Text & "' WHERE `idlogistique_appro_bonachat` = '" & id & "';", True) = True Then
            erreur = True
        Else
            erreur = False
        End If
        IsConnected("SELECT * FROM logistique_appro_badesig WHERE codeba='" & c & "'", False)
        If myDR.HasRows Then
            While myDR.Read
                codefour = myDR("codefour").ToString
                tvaa = myDR("tva").ToString
            End While
        End If
        For i = 0 To ListView1.Items.Count - 1
            Dim q1 = "INSERT INTO logistique_appro_badesig VALUES(NULL,'" & c & "','" & mysql_escape_string(ListView1.Items(i).SubItems(0).Text) & "','" & ListView1.Items(i).SubItems(1).Text & "','" & ListView1.Items(i).SubItems(2).Text & "','" & ListView1.Items(i).SubItems(3).Text & "','" & ListView1.Items(i).SubItems(4).Text & "','" & totalTextBoxX4.Text & "','" & tvaa & "','" & timbreTextBoxX1.Text & "','" & ttcTextBoxX2.Text & "','" & tvaTextBoxX3.Text & "','" & codefour & "')"
            If IsConnected(q1, True) = True Then
                erreur = True
            End If
        Next
        If erreur = True Then
            MessageBoxEx.Show("Le bon a bien ete enregistre", "Succés", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ListView1.Items.Clear()
            total.Clear()
            tva.Clear()
            timbre.Clear()
            ttc.Clear()
            NameStructTextBoxX2.Clear()
            CodestructTextBoxX3.Clear()
            num.Clear()
            OEComboBoxEx1.Text = ""
        Else : MessageBoxEx.Show("Le bon n'a pas été enregistre", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
End Class