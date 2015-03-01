Imports DevComponents.DotNetBar

Public Class BonCommande
    Public codecom As String = ""
    Public codeam As String = ""
    Public codecm As String = ""
    Dim rcode As String = ""
    Private Sub ButtonX3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX3.Click
        AjoutFourniss.ShowDialog()
    End Sub

    Private Sub ButtonX7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX7.Click
        If qt.Value = 0 Or prixunitaire.Value = 0 Or desig.Text = "" Then
            MessageBoxEx.Show("Vous avez laissé un champ vide, " & Environment.NewLine & "Veuillez remplir les champs vide!", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            Dim List As ListViewItem = New ListViewItem(desig.Text, 1)
            List.SubItems.Add(qt.Text)
            List.SubItems.Add(poid.Text)
            List.SubItems.Add(prixunitaire.Text)
            List.SubItems.Add(Math.Round((prixunitaire.Text * qt.Text), 2))
            ListView2.Items.Add(List)
            qt.Value = Nothing
            desig.Clear()
            prixunitaire.Value = Nothing
            poid.Value = Nothing
        End If
    End Sub

    Private Sub codefour_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles codefour.TextChanged
        If codefour.Text.Length > 1 Then
            IsConnected("SELECT * FROM logistique_appro_fournis WHERE code= '" & codefour.Text & "'", False)
            If myDR.HasRows Then
                While myDR.Read
                    nomfour.Text = myDR("nomfourn").ToString
                    adrfour.Text = myDR("adress").ToString
                    villefour.Text = myDR("ville").ToString
                End While
            Else
                nomfour.Text = ""
                adrfour.Text = ""
                villefour.Text = ""
            End If
        Else
            nomfour.Text = ""
            adrfour.Text = ""
            villefour.Text = ""
        End If
    End Sub

    Private Sub ButtonX8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX8.Click
        If ListView2.Items.Count < 1 Then
            MessageBoxEx.Show("Vous ne pouvez pas afficher les totaux tant que la liste des designations est vide", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        Else
            If tva1.Text = "" Then
                MessageBoxEx.Show(" Veuillez saisir le taux de TVA ", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            Else
                If ListView2.Items.Count > 0 Then
                    Dim total1 As Double = 0
                    For i = 0 To ListView2.Items.Count - 1
                        total1 += ListView2.Items(i).SubItems(4).Text
                    Next
                    total.Text = total1
                    If tva1.Text = "0" Then
                        tva.Text = 0
                    ElseIf tva1.Text = "17" Then
                        tva.Text = Math.Round((total1 * 0.17), 2)
                    ElseIf tva1.Text = "21" Then
                        tva.Text = Math.Round((total1 * 0.21), 2)
                    ElseIf tva1.Text = "7" Then
                        tva.Text = Math.Round((total1 * 0.07), 2)
                    End If
                    If modepaiem.Text = "Espece" Then
                        timbre.Text = Math.Round((total1 * 0.2), 2)
                    Else : timbre.Text = 0
                    End If
                    ttc.Text = Math.Round((total1 + tva.Text + timbre.Text), 2)
                    'total1+tva.Text + timbre.Text
                End If
            End If
        End If
    End Sub

    Private Sub ButtonX6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX6.Click
        'C encore moi alors alors Amina kolilhoume ikhalouk tsali sameti comme je faisais ;)
        If ListView2.Items.Count > 0 Then
            If num.Text <> "" Or reference.Text <> "" Or demandeur.Text <> "" Or imputation.Text <> "" Or monnaie.Text <> "" Or modeexpe.Text <> "" Or modepaiem.Text <> "" Then
                If ButtonX6.Text = "Enregistrer" Then
                    Dim erreur As Boolean = False
                    Dim q = "INSERT INTO `logistique_appro_bondecommande` VALUES(NULL,'" & num.Text & "','" & reference.Text & "','" & nature.Text & "','" & type.Text & "','" & synthese.Text & "','" & oe.Text & "','" & codestruc.Text & "','" & namestruc.Text & "','" & DateTimeInput1.Value.ToString() & "','" & ref.Text & "','" & demandeur.Text & "','" & monnaie.Text & "','" & delaiexe.Text & "','" & modeexpe.Text & "','" & modepaiem.Text & "','" & refoffre.Text & "','" & imputation.Text & "',Now(),'" & client.Text & "','" & AcheteurComboBoxEx1.Text & "','0')"
                    If IsConnected(q, True) = False Then
                        erreur = True
                    End If
                    For i = 0 To ListView2.Items.Count - 1
                        Dim q1 = "INSERT INTO logistique_appro_bcdesig VALUES(NULL,'" & num.Text & "','" & mysql_escape_string(ListView2.Items(i).SubItems(0).Text) & "','" & ListView2.Items(i).SubItems(1).Text & "','" & ListView2.Items(i).SubItems(2).Text & "','" & ListView2.Items(i).SubItems(3).Text & "','" & ListView2.Items(i).SubItems(4).Text & "','" & total.Text & "','" & tva1.Text & "','" & timbre.Text & "','" & ttc.Text & "','" & tva.Text & "','" & codefour.Text & "')"
                        If IsConnected(q1, True) = False Then
                            erreur = True
                        End If
                    Next
                    If erreur = False Then
                        MessageBoxEx.Show("Le bon de commande a bien été enregistrer", "Succés", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Dim frm = New BonCommande
                        frm.MdiParent = Mainfrm
                        frm.Show()
                        Me.Close()
                    Else : MessageBoxEx.Show("Le bon de commande n'a pas été enregistrer", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                ElseIf ButtonX6.Text = "Engerister le bon d'achat" Then
                    Dim erreur1 As Boolean = False
                    Dim q = "INSERT INTO `logistique_appro_bonachat` VALUES(NULL,'" & num.Text & "','" & reference.Text & "','" & type.Text & "','" & nature.Text & "','" & synthese.Text & "','" & oe.Text & "','" & codestruc.Text & "','" & namestruc.Text & "','" & DateTimeInput1.Value.ToString() & "','" & ref.Text & "','" & demandeur.Text & "','" & monnaie.Text & "','" & delaiexe.Text & "','" & modeexpe.Text & "','" & modepaiem.Text & "','" & refoffre.Text & "','" & imputation.Text & "',Now(),'" & client.Text & "','" & AcheteurComboBoxEx1.Text & "')"
                    If IsConnected(q, True) = False Then
                        erreur1 = True
                    End If
                    For i = 0 To ListView2.Items.Count - 1
                        Dim q1 = "INSERT INTO logistique_appro_badesig VALUES(NULL,'" & num.Text & "','" & mysql_escape_string(ListView2.Items(i).SubItems(0).Text) & "','" & ListView2.Items(i).SubItems(1).Text & "','" & ListView2.Items(i).SubItems(2).Text & "','" & ListView2.Items(i).SubItems(3).Text & "','" & ListView2.Items(i).SubItems(4).Text & "','" & total.Text & "','" & tva1.Text & "','" & timbre.Text & "','" & ttc.Text & "','" & tva.Text & "','" & codefour.Text & "')"
                        If IsConnected(q1, True) = False Then
                            erreur1 = True
                        End If
                    Next
                    If erreur1 = False Then
                        MessageBoxEx.Show("Le bon d'achat a bien été enregistrer", "Succés", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Dim frm = New BonCommande
                        frm.MdiParent = Mainfrm
                        frm.Show()
                        Me.Close()
                    Else : MessageBoxEx.Show("Le bon d'achat n'a pas été enregistrer", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                ElseIf ButtonX6.Text = "Modifier le bon de commande" Then
                    Dim erreur As Boolean = False
                    IsConnected("Delete from logistique_appro_bondecommande WHERE codebc =" & codecm & " limit 1", True)
                    IsConnected("Delete from logistique_appro_bcdesig WHERE codebc =" & codecm & " ", True)
                    Dim q = "INSERT INTO `logistique_appro_bondecommande` VALUES(NULL,'" & num.Text & "','" & reference.Text & "','" & type.Text & "','" & nature.Text & "','" & synthese.Text & "','" & oe.Text & "','" & codestruc.Text & "','" & namestruc.Text & "','" & DateTimeInput1.Value.ToString() & "','" & ref.Text & "','" & demandeur.Text & "','" & monnaie.Text & "','" & delaiexe.Text & "','" & modeexpe.Text & "','" & modepaiem.Text & "','" & refoffre.Text & "','" & imputation.Text & "',Now(),'" & client.Text & "','" & AcheteurComboBoxEx1.Text & "','0')"
                    If IsConnected(q, True) = False Then
                        erreur = True
                    End If
                    For i = 0 To ListView2.Items.Count - 1
                        Dim q1 = "INSERT INTO logistique_appro_bcdesig VALUES(NULL,'" & num.Text & "','" & mysql_escape_string(ListView2.Items(i).SubItems(0).Text) & "','" & ListView2.Items(i).SubItems(0).Text & "','" & ListView2.Items(i).SubItems(0).Text & "','" & ListView2.Items(i).SubItems(0).Text & "','" & ListView2.Items(i).SubItems(0).Text & "','" & total.Text & "','" & tva1.Text & "','" & timbre.Text & "','" & ttc.Text & "','" & tva.Text & "','" & codefour.Text & "')"
                        If IsConnected(q1, True) = False Then
                            erreur = True
                        End If
                    Next
                    If erreur = False Then
                        MessageBoxEx.Show("Le bon de commande a bien été enregistrer", "Succés", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Dim frm = New BonCommande
                        frm.MdiParent = Mainfrm
                        frm.Show()
                        Me.Close()
                    Else : MessageBoxEx.Show("Le bon de commande n'a pas été enregistrer", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                Else
                    IsConnected("Delete from logistique_appro_bonachat WHERE codeba =" & codeam & " limit 1", True)
                    IsConnected("Delete from logistique_appro_badesig WHERE codeba =" & codeam & " ", True)
                    Dim erreur1 As Boolean = False
                    Dim q = "INSERT INTO `logistique_appro_bonachat` VALUES(NULL,'" & num.Text & "','" & reference.Text & "','" & type.Text & "','" & nature.Text & "','" & synthese.Text & "','" & oe.Text & "','" & codestruc.Text & "','" & namestruc.Text & "','" & DateTimeInput1.Value.ToString() & "','" & ref.Text & "','" & demandeur.Text & "','" & monnaie.Text & "','" & delaiexe.Text & "','" & modeexpe.Text & "','" & modepaiem.Text & "','" & refoffre.Text & "','" & imputation.Text & "',Now(),'" & client.Text & "','" & AcheteurComboBoxEx1.Text & "')"
                    If IsConnected(q, True) = False Then
                        erreur1 = True
                    End If
                    For i = 0 To ListView2.Items.Count - 1
                        Dim q1 = "INSERT INTO logistique_appro_badesig VALUES(NULL,'" & num.Text & "','" & mysql_escape_string(ListView2.Items(i).SubItems(0).Text) & "','" & ListView2.Items(i).SubItems(0).Text & "','" & ListView2.Items(i).SubItems(0).Text & "','" & ListView2.Items(i).SubItems(0).Text & "','" & ListView2.Items(i).SubItems(0).Text & "','" & total.Text & "','" & tva1.Text & "','" & timbre.Text & "','" & ttc.Text & "','" & tva.Text & "','" & codefour.Text & "')"
                        If IsConnected(q1, True) = False Then
                            erreur1 = True
                        End If
                    Next
                    If erreur1 = False Then
                        MessageBoxEx.Show("Le bon d'achat a bien été enregistré", "Succés", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Dim frm = New BonCommande
                        frm.MdiParent = Mainfrm
                        frm.Show()
                        Me.Close()
                    Else : MessageBoxEx.Show("Le bon d'achat n'a pas été enregistré", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                End If
            Else : MessageBoxEx.Show("Le bon ne peut etre enregistré" & Environment.NewLine & " Veuillez remplir les champs vide", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else : MessageBoxEx.Show("Le bon ne peut etre enregistré", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub BonCommande_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If codecom = "" And codeam = "" And codecm = "" Then
            Dim a As Double = 0
            IsConnected("SELECT MAX(codebc) as number FROM logistique_appro_bondecommande", False)
            If myDR.HasRows = True Then
                While (myDR.Read())
                    a = myDR("number")
                End While
            End If
            num.Text = a + 1
            DateTimeInput1.Value = Now
        ElseIf codecom <> "" And codeam = "" And codecm = "" Then
            rcode = codecom
            load_comm()
            load_desi()
            ButtonX6.Text = "Engerister le bon d'achat"
        ElseIf codecom = "" And codeam = "" And codecm <> "" Then
            rcode = codecm
            load_comm()
            load_desi()
            ButtonX6.Text = "Modifier le bon de commande"
        ElseIf codecom = "" And codeam <> "" And codecm = "" Then
            rcode = codeam
            load_comm1()
            load_desi1()
            ButtonX6.Text = "Modifier le bon d'achat"
        End If
        noe_load()
    End Sub
    Private Sub noe_load()
        oe.Items.Clear()
        IsConnected("SELECT distinct code_affaire FROM commercial_affaire", False)
        If myDR.HasRows = True Then
            While (myDR.Read())
                oe.Items.Add(myDR("code_affaire"))
            End While
        End If
    End Sub

    Private Sub type_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles type.TextChanged
        'If codecom = "" And codeam = "" And codecm = "" Then
        '    If type.SelectedIndex > -1 And num.Text <> "" Then
        '        Dim annee = Date.Now.ToString("yy")
        '        Dim t = type.Text.First
        '        reference.Text = t + num.Text + "/" + annee
        '    End If
        'End If
    End Sub

    Private Sub load_comm()
        Dim codefour1 As String = ""
        IsConnected("SELECT * FROM logistique_appro_bondecommande where codebc='" & rcode & "'", False)
        If myDR.HasRows = True Then
            While (myDR.Read())
                delaiexe.Text = myDR("delaiexe").ToString
                modeexpe.Text = myDR("modeexpe").ToString
                modepaiem.Text = myDR("modepaiem").ToString
                refoffre.Text = myDR("ref_offre").ToString
                DateTimeInput1.Value = myDR("dateEnreg").ToString
                ref.Text = myDR("ref").ToString
                demandeur.Text = myDR("demandeur").ToString
                monnaie.Text = myDR("monnaie").ToString
                nature.Text = myDR("nature").ToString
                type.Text = myDR("type").ToString
                synthese.Text = myDR("synthese").ToString
                client.Text = myDR("client").ToString
                oe.Text = myDR("oe").ToString
                If oe.Text = "" Then
                    RadioButton2.Checked = True
                End If
                codestruc.Text = myDR("codestruc").ToString
                If codestruc.Text = "" Then
                    RadioButton1.Checked = True
                End If
                namestruc.Text = myDR("namestruc").ToString
                imputation.Text = myDR("imputation").ToString
                reference.Text = myDR("reference").ToString
            End While
        End If

        'IsConnected("SELECT * FROM logistique_appro_fournis where code='" & codefour1 & "'", False)
        'If myDR.HasRows = True Then
        '    While (myDR.Read())
        '        nomfour.Text = myDR("nomfourn")
        '        adrfour.Text = myDR("adress")
        '        villefour.Text = myDR("ville")
        '    End While
        'End If
    End Sub

    Private Sub load_desi()
        IsConnected("SELECT * FROM logistique_appro_bcdesig where codebc='" & rcode & "'", False)
        If myDR.HasRows = True Then
            While (myDR.Read)
                Dim List As ListViewItem = New ListViewItem(myDR("desigbc").ToString)
                List.SubItems.Add(myDR("Qte").ToString)
                List.SubItems.Add(myDR("poids").ToString)
                List.SubItems.Add(myDR("pu").ToString)
                List.SubItems.Add(myDR("montantbc").ToString)
                ListView2.Items.Add(List)
            End While
            total.Text = myDR("totalht").ToString
            tva.Text = myDR("tauxva").ToString
            timbre.Text = myDR("timbre").ToString
            ttc.Text = myDR("montanttotal").ToString
            tva1.Text = myDR("tva").ToString
            codefour.Text = myDR("codefour").ToString
        End If
    End Sub

    Private Sub type_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles type.SelectedIndexChanged
        '**************************************
        '**************************************
        If codecom = "" And codeam = "" And codecm = "" Then
            If type.SelectedIndex > -1 And num.Text <> "" Then
                Dim annee = Date.Now.ToString("yy")
                Dim t = type.Text.First
                reference.Text = t + num.Text + "/" + annee
            End If
        End If
    End Sub

    Private Sub num_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles num.TextChanged
        If type.SelectedIndex > -1 And num.Text <> "" Then
            Dim annee = Date.Now.ToString("yy")
            Dim t = type.Text.First
            reference.Text = t + num.Text + "/" + annee
        End If
    End Sub

    'Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
    '    aff.Enabled = True
    '    oe.Enabled = True
    '    str.Enabled = False
    '    codestruc.Text = ""
    '    namestruc.Text = ""
    '    imputation.Text = ""
    '    codestruc.Enabled = False
    '    namestruc.Enabled = False
    'End Sub

    'Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged
    '    str.Enabled = True
    '    codestruc.Enabled = True
    '    namestruc.Enabled = True
    '    oe.SelectedIndex = -1
    '    imputation.Text = ""
    '    aff.Enabled = False
    '    oe.Enabled = False
    'End Sub

    Private Sub load_comm1()
        Dim codefour1 As String = ""
        IsConnected("SELECT * FROM logistique_appro_bonachat where codeba='" & rcode & "'", False)
        If myDR.HasRows = True Then
            While (myDR.Read())
                delaiexe.Text = myDR("delaiexe").ToString
                modeexpe.Text = myDR("modeexpe").ToString
                modepaiem.Text = myDR("modepaiem").ToString
                refoffre.Text = myDR("ref_offre").ToString
                DateTimeInput1.Value = myDR("dateEnreg").ToString
                ref.Text = myDR("ref").ToString
                demandeur.Text = myDR("demandeur").ToString
                monnaie.Text = myDR("monnaie").ToString
                nature.Text = myDR("nature").ToString
                type.Text = myDR("type").ToString
                synthese.Text = myDR("synthese").ToString
                client.Text = myDR("client").ToString
                oe.Text = myDR("oe").ToString
                If oe.Text = "" Then
                    RadioButton2.Checked = True
                End If
                codestruc.Text = myDR("codestruc").ToString
                If codestruc.Text = "" Then
                    RadioButton1.Checked = True
                End If
                namestruc.Text = myDR("namestruc").ToString
                imputation.Text = myDR("imputation").ToString
                reference.Text = myDR("reference").ToString
            End While
        End If
    End Sub

    Private Sub load_desi1()
        IsConnected("SELECT * FROM logistique_appro_badesig where codeba='" & rcode & "'", False)
        If myDR.HasRows = True Then
            While (myDR.Read())
                Dim List As ListViewItem = New ListViewItem(myDR("desigba").ToString)
                List.SubItems.Add(myDR("Qte").ToString)
                List.SubItems.Add(myDR("poids").ToString)
                List.SubItems.Add(myDR("pu").ToString)
                List.SubItems.Add(myDR("montantbc").ToString)
                ListView2.Items.Add(List)
            End While
            total.Text = myDR("totalht").ToString
            tva.Text = myDR("tauxva").ToString
            timbre.Text = myDR("timbre").ToString
            ttc.Text = myDR("montanttotal").ToString
            tva1.Text = myDR("tva").ToString
            codefour.Text = myDR("codefour").ToString
        End If
    End Sub

    Private Sub ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem1.Click
        Try
            For i = 0 To ListView2.Items.Count - 1
                If ListView2.Items(i).Selected = True Then
                    desig.Text = ListView2.Items(i).SubItems(0).Text
                    qt.Text = ListView2.Items(i).SubItems(1).Text
                    poid.Value = ListView2.Items(i).SubItems(2).Text
                    prixunitaire.Value = ListView2.Items(i).SubItems(3).Text
                    ListView2.Items(i).Remove()
                End If
            Next
            total.Text = ""
            tva.Text = ""
            timbre.Text = ""
            ttc.Text = ""
            tva1.Text = ""
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub

    Private Sub ToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem2.Click
        Try
            For i = 0 To ListView2.Items.Count - 1
                If ListView2.Items(i).Selected = True Then
                    ListView2.Items(i).Remove()
                    Exit For
                End If
            Next
            total.Text = ""
            tva.Text = ""
            timbre.Text = ""
            ttc.Text = ""
            tva1.Text = ""
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub

    Private Sub oe_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles oe.SelectedIndexChanged
        If oe.Text <> "" And type.Text = "Affaire" Then
            imputation.Text = oe.Text
        End If
    End Sub

    Private Sub codestruc_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles codestruc.TextChanged
        If codestruc.Text <> "" And type.Text <> "Affaire" Then
            imputation.Text = codestruc.Text
        End If
    End Sub

    Private Sub tva1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles tva1.SelectedIndexChanged
        total.Clear()
        tva.Clear()
        timbre.Clear()
        ttc.Clear()
    End Sub
End Class