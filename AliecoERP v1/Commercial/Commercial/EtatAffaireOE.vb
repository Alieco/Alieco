Imports MySql.Data.MySqlClient
Imports DevComponents.DotNetBar

Public Class OE
    Public aff As String = ""
    Public codeaf As Integer
    Public idcommercialOE As Integer
    Public idcommercialMOE As Integer
    Dim red As String = ""
    'Dim aOE
    Dim aMOE
    Private Sub EtatAffaireOE_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'Try
        load_client()
        load_Code_affaire()
        IsConnected("SELECT distinct fullname FROM users where  user_id=20", False)
        If myDR.HasRows Then
            While myDR.Read
                Dim vs = myDR("fullname").ToString
                Dim v = vs.Split(" ")
                vise.Text = v(0).Substring(0, 1) & v(1).Substring(0, 2)
            End While
        End If
        IsConnected("SELECT distinct fullname FROM users where  user_id=21", False)
        If myDR.HasRows Then
            While myDR.Read
                Dim cl = myDR("fullname").ToString
                Dim c = cl.Split(" ")
                cliche.Text = c(0).Substring(0, 1) & c(1).Substring(0, 2)
            End While
        End If
        IsConnected("SELECT distinct fullname FROM users where (type = 21 or type=0) and user_id='" & user_id & "'", False)
        If myDR.HasRows Then
            While myDR.Read
                'MsgBox(myDR("fullname").ToString)
                Dim etab = myDR("fullname").ToString
                Dim et = etab.Split(" ")
                'MsgBox("aff1 " & et(0))
                'MsgBox("aff2 " & et(1))
                'MsgBox("aff3 " & et(2))
                If et(0) <> "" And et(1) <> "" Then
                    etabli.Text = et(0).Substring(0, 1) & et(1).Substring(0, 2)
                Else
                    etabli.Text = et(0).Substring(0, 1) & et(1).Substring(0, 1) & et(2).Substring(0, 1)
                End If
            End While
        End If
        ''IsConnected("SELECT MAX(commande) FROM commercial_moe  ", False)
        ''If myDR.HasRows = True Then
        ''    While (myDR.Read)
        ''        aMOE = myDR("commande").ToString
        ''    End While
        ''End If
        If ButtonX6.Text = "Modifier" Then
            Label26.Text = "Origine de la modification"
            Label3.Text = "Modification N° "
            ' commandecl.Text = a + 1
            Dim des As String = ""
            IsConnected("SELECT distinct commercial_oe.code_affaire,redevance,destination,datediff,EtabliPar,visePar,clichePar,destination,NClassement,code1,code2,code3,code4,code5,proposition,duProposition, commande,duCommande,poids,controle,miseEnChantier,protection,emballage,marquage,destinataire,modeEnvoi,docExpCl,docExpTier,assurance,revision, MontantPrevisionnel, penabilite, taxe, codeTravaux, protection, commercial_oe_ensemble_general.category, commercial_oe_ensemble_general.num_execution, commercial_oe_ensemble_general.Text FROM commercial_oe left join commercial_oe_ensemble_general on commercial_oe.idcommercial_OE=commercial_oe_ensemble_general.idcommercial_OE WHERE commercial_oe.idcommercial_OE='" & idcommercialOE & "'", False)
            If myDR.HasRows = True Then
                While (myDR.Read)
                    des = myDR("destination")
                    commandecl.Text = myDR("commande").ToString
                      Dim List As ListViewItem = New ListViewItem(myDR("category").ToString, 1)
                    List.SubItems.Add(myDR("num_execution").ToString)
                    List.SubItems.Add(myDR("text").ToString)
                    ListView1.Items.Add(List)
                    'nomClient.Text = myDR("").ToString
                    datediff.Value = myDR("datediff").ToString
                    etabli.Text = myDR("EtabliPar").ToString
                    vise.Text = myDR("visePar").ToString
                    cliche.Text = myDR("clichePar").ToString
                    If des <> "" Then
                        Dim dest() = des.Split(",")
                        dossiercorres.Text = dest(0).Substring(dest(0).Length - 2).Replace("|", "").Replace("0", "")
                        serviceordennancement.Text = dest(1).Substring(dest(1).Length - 2).Replace("|", "").Replace("0", "")
                        commercial.Text = dest(2).Substring(dest(2).Length - 2).Replace("|", "").Replace("0", "")
                        comptabilite.Text = dest(3).Substring(dest(3).Length - 2).Replace("|", "").Replace("0", "")
                        be.Text = dest(4).Substring(dest(4).Length - 2).Replace("|", "").Replace("0", "")
                        approvisionnement.Text = dest(5).Substring(dest(5).Length - 2).Replace("|", "").Replace("0", "")
                        miseEnChantier.Text = dest(6).Substring(dest(6).Length - 2).Replace("|", "").Replace("0", "")
                        mecanique.Text = dest(7).Substring(dest(7).Length - 2).Replace("|", "").Replace("0", "")
                        chaudronnerie.Text = dest(8).Substring(dest(8).Length - 2).Replace("|", "").Replace("0", "")
                        generaux.Text = dest(9).Substring(dest(9).Length - 2).Replace("|", "").Replace("0", "")
                        magasin.Text = dest(10).Substring(dest(10).Length - 2).Replace("|", "").Replace("0", "")
                        expedition.Text = dest(11).Substring(dest(11).Length - 2).Replace("|", "").Replace("0", "")
                        montage.Text = dest(12).Substring(dest(12).Length - 2).Replace("|", "").Replace("0", "")
                        revient.Text = dest(13).Substring(dest(13).Length - 2).Replace("|", "").Replace("0", "")
                    End If
                    nclassement.Text = myDR("NClassement").ToString
                    c1.Text = myDR("code1").ToString
                    c2.Text = myDR("code2").ToString
                    c3.Text = myDR("code3").ToString
                    c4.Text = myDR("code4").ToString
                    c5.Text = myDR("code5").ToString
                    nomProposition.Text = myDR("proposition").ToString
                    duPropo.Value = myDR("duProposition").ToString
                    commandecl.Text = myDR("commande").ToString
                    duCl.Value = myDR("duCommande").ToString
                    poid.Text = myDR("poids").ToString
                    controle.Text = myDR("controle").ToString
                    chantierEtabli.Text = myDR("miseEnChantier").ToString
                    protectionInterne.Text = myDR("protectionInterne").ToString
                    protectionExterne.Text = myDR("protectionExterne").ToString
                    emballage.Text = myDR("emballage").ToString
                    marquage.Text = myDR("marquage").ToString
                    destina.Text = myDR("destinataire").ToString
                    modeEnvoi.Text = myDR("modeEnvoi").ToString
                    docExpediCl.Text = myDR("docExpCl").ToString
                    docExpeditier.Text = myDR("docExpTier").ToString
                    assurrance.Text = myDR("assurance").ToString
                    revision.Text = myDR("revision").ToString
                    montanPrevisionnel.Text = myDR("MontantPrevisionnel").ToString
                    penalite.Text = myDR("penabilite").ToString
                    taxe.Text = myDR("taxe").ToString
                    codeTravaux.Text = myDR("codeTravaux").ToString
                    If myDR("redevance").ToString = "Oui" Then
                        redevanceO.Checked = True
                    ElseIf myDR("redevance").ToString = "Non" Then
                        RadioButton2.Checked = True
                    End If
                End While
            End If
            If IsConnected("SELECT  distinct code_affaire,delai_exe,EntréeDate from commercial_affaire where code_affaire= '" & aff & "'", False) Then
                If myDR.HasRows Then
                    While myDR.Read
                        delais.Text = myDR("delai_exe").ToString() & " a partir " & myDR("EntréeDate").ToString("yyyy-MM-dd")
                    End While
                End If
            End If
            Dim avance As String = ""
            Dim terme As String = ""
            Dim modalit As String = ""
            Dim query = "SELECT valeurpour,description, type from commercial_affaire, commercial_affaire_modalite where commercial_affaire_modalite.code=commercial_affaire.code_affaire and commercial_affaire.code_affaire='" & aff & "'"
            If IsConnected(query, False) Then
                If myDR.HasRows = True Then
                    While (myDR.Read)
                        If myDR("type") = "Avance remboursement" Then
                            avance += Environment.NewLine & "  • " & myDR("valeurpour").ToString & "% " & myDR("description").ToString
                        Else
                            terme += Environment.NewLine & "  • " & myDR("valeurpour").ToString & "% " & myDR("description").ToString
                        End If
                    End While
                    If avance <> "" Then avance = " • Avances remboursable : " & vbNewLine & avance
                    If terme <> "" Then terme = " • Terme de payement : " & vbNewLine & terme
                    modalit = avance & vbNewLine & terme
                End If
            End If
            modePaiement.Text = modalit
            Dim query1 = "SELECT total, totaltva, totalttc from commercial_affaire, commercial_affaire_bordereauprix where commercial_affaire_bordereauprix.code=commercial_affaire.code_affaire and commercial_affaire.code_affaire='" & aff & "'"
            If IsConnected(query1, False) Then
                If myDR.HasRows Then
                    While myDR.Read
                        ht.Text = myDR("total")
                        tva.Text = myDR("totaltva")
                        ttc.Text = myDR("totalttc")
                    End While
                End If
            End If
        ElseIf ButtonX6.Text = "Modifier MOE" Then
            '*********************Modifier MOE*******************

            'MsgBox(idcommercialMOE)
            Label26.Text = "Origine de la modification"
            Label3.Text = "Modification N° "
            ' commandecl.Text = a + 1
            Dim des As String = ""
            IsConnected("SELECT distinct commercial_moe.code_affaire,redevance,destination,datediff,EtabliPar,visePar,clichePar,destination,NClassement,code1,code2,code3,code4,code5,proposition,duProposition, commande,duCommande,poids,controle,miseEnChantier,protection,emballage,marquage,destinataire,modeEnvoi,docExpCl,docExpTier,assurance,revision, MontantPrevisionnel, penabilite, taxe, codeTravaux, protection, commercial_moe_ensemble_general.category, commercial_moe_ensemble_general.num_execution, commercial_moe_ensemble_general.Text FROM commercial_moe left join commercial_moe_ensemble_general on commercial_moe.idcommercial_MOE=commercial_moe_ensemble_general.idcommercial_MOE WHERE commercial_moe.idcommercial_MOE='" & idcommercialMOE & "'", False)
            If myDR.HasRows = True Then
                While (myDR.Read)
                    des = myDR("destination").ToString
                    commandecl.Text = myDR("commande").ToString
                    Dim List As ListViewItem = New ListViewItem(myDR("category").ToString, 1)
                    List.SubItems.Add(myDR("num_execution").ToString)
                    List.SubItems.Add(myDR("text").ToString)
                    ListView1.Items.Add(List)
                    datediff.Value = myDR("datediff").ToString
                    etabli.Text = myDR("EtabliPar").ToString
                    vise.Text = myDR("visePar").ToString
                    cliche.Text = myDR("clichePar").ToString
                    If des <> "" Then
                        Dim dest() = des.Split(",")
                        dossiercorres.Text = dest(0).Substring(dest(0).Length - 2).Replace("|", "").Replace("0", "")
                        serviceordennancement.Text = dest(1).Substring(dest(1).Length - 2).Replace("|", "").Replace("0", "")
                        commercial.Text = dest(2).Substring(dest(2).Length - 2).Replace("|", "").Replace("0", "")
                        comptabilite.Text = dest(3).Substring(dest(3).Length - 2).Replace("|", "").Replace("0", "")
                        be.Text = dest(4).Substring(dest(4).Length - 2).Replace("|", "").Replace("0", "")
                        approvisionnement.Text = dest(5).Substring(dest(5).Length - 2).Replace("|", "").Replace("0", "")
                        miseEnChantier.Text = dest(6).Substring(dest(6).Length - 2).Replace("|", "").Replace("0", "")
                        mecanique.Text = dest(7).Substring(dest(7).Length - 2).Replace("|", "").Replace("0", "")
                        chaudronnerie.Text = dest(8).Substring(dest(8).Length - 2).Replace("|", "").Replace("0", "")
                        generaux.Text = dest(9).Substring(dest(9).Length - 2).Replace("|", "").Replace("0", "")
                        magasin.Text = dest(10).Substring(dest(10).Length - 2).Replace("|", "").Replace("0", "")
                        expedition.Text = dest(11).Substring(dest(11).Length - 2).Replace("|", "").Replace("0", "")
                        montage.Text = dest(12).Substring(dest(12).Length - 2).Replace("|", "").Replace("0", "")
                        revient.Text = dest(13).Substring(dest(13).Length - 2).Replace("|", "").Replace("0", "")
                    End If
                    nclassement.Text = myDR("NClassement").ToString
                    c1.Text = myDR("code1").ToString
                    c2.Text = myDR("code2").ToString
                    c3.Text = myDR("code3").ToString
                    c4.Text = myDR("code4").ToString
                    c5.Text = myDR("code5").ToString
                    nomProposition.Text = myDR("proposition").ToString
                    duPropo.Value = myDR("duProposition").ToString
                    commandecl.Text = myDR("commande").ToString
                    duCl.Value = myDR("duCommande").ToString
                    poid.Text = myDR("poids").ToString
                    controle.Text = myDR("controle").ToString
                    chantierEtabli.Text = myDR("miseEnChantier").ToString
                    protectionInterne.Text = myDR("protectionInterne").ToString
                    protectionExterne.Text = myDR("protectionExterne").ToString
                    emballage.Text = myDR("emballage").ToString
                    marquage.Text = myDR("marquage").ToString
                    destina.Text = myDR("destinataire").ToString
                    modeEnvoi.Text = myDR("modeEnvoi").ToString
                    docExpediCl.Text = myDR("docExpCl").ToString
                    docExpeditier.Text = myDR("docExpTier").ToString
                    assurrance.Text = myDR("assurance").ToString
                    revision.Text = myDR("revision").ToString
                    montanPrevisionnel.Text = myDR("MontantPrevisionnel").ToString
                    penalite.Text = myDR("penabilite").ToString
                    taxe.Text = myDR("taxe").ToString
                    codeTravaux.Text = myDR("codeTravaux").ToString
                    If myDR("redevance").ToString = "Oui" Then
                        redevanceO.Checked = True
                    ElseIf myDR("redevance").ToString = "Non" Then
                        RadioButton2.Checked = True
                    End If
                    'red = myDR("redevance").ToString

                    'numero.Text = myDR("numero").ToString
                End While
            End If
            If IsConnected("SELECT  * from commercial_affaire where code_affaire= '" & aff & "'", False) Then
                If myDR.HasRows Then
                    While myDR.Read
                        'nomClient.Text = myDR("nomcl").ToString()
                        delais.Text = myDR("delai_exe").ToString() & " a partir " & myDR("EntréeDate").ToString()
                    End While
                End If
            End If
            Dim avance As String = ""
            Dim terme As String = ""
            Dim modalit As String = ""
            Dim query = "SELECT valeurpour,description, type from commercial_affaire, commercial_affaire_modalite where commercial_affaire_modalite.code=commercial_affaire.code_affaire and commercial_affaire.code_affaire='" & aff & "'"
            If IsConnected(query, False) Then
                If myDR.HasRows = True Then
                    While (myDR.Read)
                        If myDR("type") = "Avance remboursement" Then
                            avance += Environment.NewLine & "  • " & myDR("valeurpour").ToString & "% " & myDR("description").ToString
                        Else
                            terme += Environment.NewLine & "  • " & myDR("valeurpour").ToString & "% " & myDR("description").ToString
                        End If
                    End While
                    If avance <> "" Then avance = " • Avances remboursable : " & vbNewLine & avance
                    If terme <> "" Then terme = " • Terme de payement : " & vbNewLine & terme
                    modalit = avance & vbNewLine & terme
                End If
            End If
            modePaiement.Text = modalit
            Dim query1 = "SELECT total, totaltva, totalttc from commercial_affaire, commercial_affaire_bordereauprix where commercial_affaire_bordereauprix.code=commercial_affaire.code_affaire and commercial_affaire.code_affaire='" & aff & "'"
            If IsConnected(query1, False) Then
                If myDR.HasRows Then
                    While myDR.Read
                        ht.Text = myDR("total")
                        tva.Text = myDR("totaltva")
                        ttc.Text = myDR("totalttc")
                    End While
                End If
            End If
        End If
        reload()
        'Catch ex As Exception
        '    EnvoiError(ex.Message)
        'End Try
    End Sub

    Private Sub load_Code_affaire()
        Try
            Dim query = "SELECT DISTINCT(code_affaire) from commercial_affaire where nomcl='" & nomClient.Text & "'"
            If IsConnected(query, False) Then
                numero.Items.Clear()
                If myDR.HasRows Then
                    While myDR.Read
                        numero.Items.Add(myDR("code_affaire"))
                    End While
                End If
            End If
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub
    Sub load_client()
        Try
            'SELECT DISTINCT(RaisonSocial) from commercial_affaire left join commercial_client on commercial_affaire.idclient=commercial_client.idclient
            Dim query = "SELECT DISTINCT(nomcl) from commercial_affaire"
            If IsConnected(query, False) Then
                nomClient.Items.Clear()
                If myDR.HasRows Then
                    While myDR.Read
                        nomClient.Items.Add(myDR("nomcl"))
                    End While
                End If
            End If
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub
    Sub load_affaire()
        Try
            Dim query = "SELECT DISTINCT(titre) from commercial_affaire where nomcl='" & nomClient.Text & "' and code_affaire='" & numero.Text & "'"
            affaire.Text = ""
            If IsConnected(query, False) Then
                If myDR.HasRows Then
                    While myDR.Read
                        affaire.Text = myDR("titre").ToString()
                    End While
                End If
            End If
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub
    Sub load_prix()
        Try
            Dim query = "SELECT total, totaltva, totalttc from commercial_affaire, commercial_affaire_bordereauprix where commercial_affaire_bordereauprix.code=commercial_affaire.code_affaire and commercial_affaire.code_affaire='" & numero.Text & "'"
            'titre='" & affaire.Text & "' and nomcl='" & nomClient.Text & "'
            If IsConnected(query, False) Then
                If myDR.HasRows Then
                    While myDR.Read
                        ht.Text = myDR("total")
                        tva.Text = myDR("totaltva")
                        ttc.Text = myDR("totalttc")
                    End While
                End If
            End If
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub
    Sub load_modalitePaiement()
        Try
            Dim avance As String = ""
            Dim terme As String = ""
            Dim modalit As String = ""
            Dim query = "SELECT valeurpour,description, type from commercial_affaire, commercial_affaire_modalite where commercial_affaire_modalite.code=commercial_affaire.code_affaire and commercial_affaire.code_affaire='" & numero.Text & "'"
            If IsConnected(query, False) Then
                If myDR.HasRows = True Then
                    While (myDR.Read)
                        If myDR("type") = "Avance remboursement" Then
                            avance += Environment.NewLine & "  • " & myDR("valeurpour").ToString & "% " & myDR("description").ToString
                        Else
                            terme += Environment.NewLine & "  • " & myDR("valeurpour").ToString & "% " & myDR("description").ToString
                        End If
                    End While
                    If avance <> "" Then avance = " • Avances remboursable : " & vbNewLine & avance
                    If terme <> "" Then terme = " • Terme de payement : " & vbNewLine & terme
                    modalit = avance & vbNewLine & terme
                End If
            End If
            modePaiement.Text = modalit
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub
    Sub load_delais()
        Try
            Dim query = "SELECT delai_exe,EntréeDate from commercial_affaire where commercial_affaire.code_affaire='" & numero.Text & "' "
            'code_affaire ='" & aff & "'
            If IsConnected(query, False) Then
                If myDR.HasRows Then
                    While myDR.Read
                        delais.Text = myDR("delai_exe") & " a partir " & myDR("EntréeDate")
                    End While
                End If
            End If
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub
    Private Sub ButtonX6_Click(sender As System.Object, e As System.EventArgs) Handles ButtonX6.Click
        Try
            If ButtonX6.Text = "Enregistrer" Then
                If nomClient.Text = "" Then
                    MessageBoxEx.Show("Vous avez laissé le champ Nom client vide !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If
                If numero.Text = "" Then
                    MessageBoxEx.Show("Vous avez laissé le champ N° vide !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If
                If nomProposition.Text = "" Then
                    MessageBoxEx.Show("Vous avez laissé le champ de Notre proposition vide !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If
                If commandecl.Text = "" Then
                    MessageBoxEx.Show("Vous avez laissé le champ N° commande client vide !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If
                Dim erreur As Boolean = False
                Dim controle1 As String = ""
                'IsConnected("SELECT * FROM commercial_affaire WHERE titre='" & affaire.Text & "'", False)
                'If myDR.HasRows = True Then
                '    While (myDR.Read)
                '        aff = myDR("code_affaire")
                '    End While
                'End If
                Try

                    If redevanceO.Checked = True Then
                        red = "Oui"
                    Else : red = "Non"
                    End If
                    For i = 0 To CheckedComboBoxEdit1.Properties.Items.Count - 1
                        If CheckedComboBoxEdit1.Properties.Items(i).CheckState = CheckState.Checked Then
                            controle1 += CheckedComboBoxEdit1.Properties.Items(i).ToString & "|"
                        End If
                    Next
                    MsgBox(controle1)
                    Dim quary = "INSERT INTO commercial_oe VALUES(NULL,'" & numero.Text & "','" & c1.Text & "','" & c2.Text & "','" & c3.Text & "', '" & c4.Text & "', '" & c5.Text & "', '" & nclassement.Text & "','" & mysql_escape_string(nomProposition.Text) & "', '" & duPropo.Value.ToString("yyyy-MM-dd") & "','" & mysql_escape_string(commandecl.Text) & "','" & duCl.Value.ToString("yyyy-MM-dd") & "','" & codeTravaux.Text & "','" & mysql_escape_string(controle1) & "','" & mysql_escape_string(chantierEtabli.Text) & "','" & mysql_escape_string(etabli.Text) & "','" & mysql_escape_string(vise.Text) & "','" & mysql_escape_string(cliche.Text) & "','" & mysql_escape_string(protectionInterne.Text) & "','" & mysql_escape_string(protectionExterne.Text) & "','" & mysql_escape_string(emballage.Text) & "','" & mysql_escape_string(marquage.Text) & "', '" & mysql_escape_string(destina.Text) & "','" & mysql_escape_string(modeEnvoi.Text) & "','" & mysql_escape_string(assurrance.Text) & "', '" & mysql_escape_string(revision.Text) & "','" & mysql_escape_string(taxe.Text) & "','" & mysql_escape_string(docExpediCl.Text) & "', '" & mysql_escape_string(docExpeditier.Text) & "', '" & mysql_escape_string(red) & "','" & mysql_escape_string(montanPrevisionnel.Text) & "','" & mysql_escape_string(penalite.Text) & "','Dossier correspondance | " & dossiercorres.Text & ",Service Ordonnancement | " & serviceordennancement.Text & ", Service commercial | " & commercial.Text & ", Comptabilite | " & comptabilite.Text & ", BE | " & be.Text & ", Approvisionnement | " & approvisionnement.Text & ",Mise en chantier | " & miseEnChantier.Text & ", Mecanique | " & mecanique.Text & ", Chaudronnerie | " & chaudronnerie.Text & ", Service generaux | " & generaux.Text & ", Magasin | " & magasin.Text & ", Expedition | " & expedition.Text & ", Montage | " & montage.Text & ", Service Prix de revient | " & revient.Text & "','" & datediff.Value.ToString("yyyy-MM-dd") & "','" & poid.Text & "','" & user_id & "', Now());"
                    If IsConnected(quary, True) = False Then
                        erreur = True
                    End If
                    For i = 0 To ListView1.Items.Count - 1
                        Try
                            Dim quary1 = "INSERT INTO commercial_oe_ensemble_general VALUES(NULL,'" & ListView1.Items(i).SubItems(0).Text & "','" & ListView1.Items(i).SubItems(1).Text & "','" & ListView1.Items(i).SubItems(2).Text & "','" & ListView1.Items(i).SubItems(3).Text & "','" & ListView1.Items(i).SubItems(4).Text & "',(SELECT idcommercial_OE FROM commercial_oe order by idcommercial_OE desc limit 1));"
                            'SELECT idcommercial_OE FROM commercial_oe where idcommercial_OE='" & idcommercialOE & "'
                            If IsConnected(quary1, True) = False Then
                                erreur = True
                            End If
                        Catch ex As Exception
                            EnvoiError(ex.Message)
                        End Try
                    Next
                    If erreur = False Then
                        MessageBoxEx.Show("L'OE a bien été enregistrer", "Succés", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        datediff.Value = Nothing
                        etabli.Clear()
                        vise.Clear()
                        cliche.Clear()
                        dossiercorres.Clear()
                        serviceordennancement.Clear()
                        commercial.Clear()
                        comptabilite.Clear()
                        be.Clear()
                        approvisionnement.Clear()
                        miseEnChantier.Clear()
                        mecanique.Clear()
                        chaudronnerie.Clear()
                        generaux.Clear()
                        magasin.Clear()
                        expedition.Clear()
                        montage.Clear()
                        revient.Clear()
                        nomClient.Text = ""
                        affaire.Text = ""
                        nclassement.Clear()
                        numero.Text = ""
                        c1.Clear()
                        c2.Clear()
                        c3.Clear()
                        c4.Clear()
                        c5.Clear()
                        nomProposition.Clear()
                        duPropo.Value = Nothing
                        commandecl.Clear()
                        duCl.Value = Nothing
                        poid.Clear()
                        delais.Clear()
                        controle.Clear()
                        chantierEtabli.Clear()
                        ListView1.Items.Clear()
                        protectionInterne.Clear()
                        protectionExterne.Clear()
                        emballage.Clear()
                        marquage.Clear()
                        destina.Clear()
                        modeEnvoi.Items.Clear()
                        docExpediCl.Clear()
                        docExpeditier.Clear()
                        assurrance.Clear()
                        ht.Clear()
                        tva.Clear()
                        ttc.Clear()
                        modePaiement.Clear()
                        revision.Clear()
                        montanPrevisionnel.Clear()
                        penalite.Clear()
                        taxe.Clear()
                        codeTravaux.Clear()
                        CheckedComboBoxEdit1.Properties.Items.Clear()
                        ButtonX6.Enabled = False
                        ' reload()
                    End If
                Catch ex As Exception
                    EnvoiError(ex.Message)
                End Try
            Else
                Dim cmd
                IsConnected("SELECT MAX(commande) as commande FROM commercial_moe", False)
                If myDR.HasRows Then
                    While myDR.Read
                        cmd = myDR("commande").ToString
                        'MsgBox(cmd)
                    End While
                End If
                Dim erreur As Boolean = False
                Dim red As String = ""
                Try
                    If redevanceO.Checked = True Then
                        red = "Oui"
                    Else : red = "Non"
                    End If
                    ' MsgBox("aff 2 =" & aff)
                    Dim quary = "INSERT INTO commercial_moe VALUES(NULL,'" & aff & "','" & c1.Text & "','" & c2.Text & "','" & c3.Text & "', '" & c4.Text & "', '" & c5.Text & "', '" & nclassement.Text & "','" & mysql_escape_string(nomProposition.Text) & "', '" & duPropo.Value.ToString("yyyy-MM-dd") & "','" & cmd + 1 & "','" & duCl.Value.ToString("yyyy-MM-dd") & "','" & codeTravaux.Text & "','" & mysql_escape_string(controle.Text) & "','" & mysql_escape_string(chantierEtabli.Text) & "','" & mysql_escape_string(etabli.Text) & "','" & mysql_escape_string(vise.Text) & "','" & mysql_escape_string(cliche.Text) & "','" & mysql_escape_string(protectionInterne.Text) & "','" & mysql_escape_string(protectionExterne.Text) & "','" & mysql_escape_string(emballage.Text) & "','" & mysql_escape_string(marquage.Text) & "', '" & mysql_escape_string(destina.Text) & "','" & mysql_escape_string(modeEnvoi.Text) & "','" & mysql_escape_string(assurrance.Text) & "', '" & mysql_escape_string(revision.Text) & "','" & mysql_escape_string(taxe.Text) & "','" & mysql_escape_string(docExpediCl.Text) & "', '" & mysql_escape_string(docExpeditier.Text) & "', '" & mysql_escape_string(red) & "','" & mysql_escape_string(montanPrevisionnel.Text) & "','" & mysql_escape_string(penalite.Text) & "','Dossier correspondance | " & dossiercorres.Text & ",Service Ordonnancement | " & serviceordennancement.Text & ", Service commercial | " & commercial.Text & ", Comptabilite | " & comptabilite.Text & ", BE | " & be.Text & ", Approvisionnement | " & approvisionnement.Text & ",Mise en chantier | " & miseEnChantier.Text & ", Mecanique | " & mecanique.Text & ", Chaudronnerie | " & chaudronnerie.Text & ", Service generaux | " & generaux.Text & ", Magasin | " & magasin.Text & ", Expedition | " & expedition.Text & ", Montage | " & montage.Text & ", Service Prix de revient | " & revient.Text & "','" & datediff.Value.ToString("yyyy-MM-dd") & "','" & poid.Text & "','" & user_id & "', Now());"
                    If IsConnected(quary, True) = False Then
                        erreur = True
                    End If
                    For i = 0 To ListView1.Items.Count - 1
                        Try
                        Dim quary1 = " INSERT INTO commercial_moe_ensemble_general VALUES(NULL,'" & ListView1.Items(i).SubItems(0).Text & "','" & ListView1.Items(i).SubItems(1).Text & "','" & ListView1.Items(i).SubItems(2).Text & "','" & ListView1.Items(i).SubItems(3).Text & "','" & ListView1.Items(i).SubItems(4).Text & "',(SELECT idcommercial_MOE FROM commercial_moe order by idcommercial_MOE desc limit 1));"
                        If IsConnected(quary1, True) = False Then
                            erreur = True
                        End If
                        Catch ex As Exception
                    EnvoiError(ex.Message)
                End Try
                    Next
                If erreur = False Then
                    MessageBoxEx.Show("L'OE a bien été modifier", "Succés", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    datediff.Value = Nothing
                    etabli.Clear()
                    vise.Clear()
                    cliche.Clear()
                    dossiercorres.Clear()
                    serviceordennancement.Clear()
                    commercial.Clear()
                    comptabilite.Clear()
                    be.Clear()
                    approvisionnement.Clear()
                    miseEnChantier.Clear()
                    mecanique.Clear()
                    chaudronnerie.Clear()
                    generaux.Clear()
                    magasin.Clear()
                    expedition.Clear()
                    montage.Clear()
                    revient.Clear()
                    nomClient.Text = ""
                    affaire.Text = ""
                    nclassement.Clear()
                    numero.Text = ""
                    c1.Clear()
                    c2.Clear()
                    c3.Clear()
                    c4.Clear()
                    c5.Clear()
                    nomProposition.Clear()
                    duPropo.Value = Nothing
                    commandecl.Clear()
                    duCl.Value = Nothing
                    poid.Clear()
                    delais.Clear()
                    controle.Clear()
                    chantierEtabli.Clear()
                    ListView1.Items.Clear()
                    protectionInterne.Clear()
                    protectionExterne.Clear()
                    emballage.Clear()
                    marquage.Clear()
                    destina.Clear()
                    modeEnvoi.Items.Clear()
                    docExpediCl.Clear()
                    docExpeditier.Clear()
                    assurrance.Clear()
                    ht.Clear()
                    tva.Clear()
                    ttc.Clear()
                    modePaiement.Clear()
                    revision.Clear()
                    montanPrevisionnel.Clear()
                    penalite.Clear()
                    taxe.Clear()
                        codeTravaux.Clear()
                        CheckedComboBoxEdit1.Properties.Items.Clear()
                    ' reload1()
                    ButtonX6.Text = "Enregistrer"
                    ButtonX6.Image = My.Resources.secure_ok
                    Me.Close()
                End If
                reload()
                Catch ex As Exception
                    EnvoiError(ex.Message)
                End Try
            End If
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub

    Private Sub ButtonX3_Click(sender As System.Object, e As System.EventArgs) Handles ButtonX3.Click
        Try
            TabControl1.SelectedTabIndex = 1
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub

    Private Sub ButtonX7_Click(sender As System.Object, e As System.EventArgs) Handles ButtonX7.Click
        Try
            Dim List As ListViewItem = New ListViewItem(ensembleGeneraux.Text, 1)
            List.SubItems.Add(exe.Text)
            List.SubItems.Add(titre.Text)
            List.SubItems.Add(soustitre.Text)
            List.SubItems.Add(defFournit.Text)
            ListView1.Items.Add(List)
            ensembleGeneraux.Clear()
            exe.Clear()
            titre.Clear()
            soustitre.Clear()
            defFournit.Clear()
            ButtonX7.Enabled = False
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub

    Private Sub nomClient_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles nomClient.SelectedIndexChanged
        Try
            ButtonX6.Enabled = True
            load_Code_affaire()
            numero.Text = ""
            ' load_affaire()
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub

    'Private Sub affaire_SelectedIndexChanged(sender As System.Object, e As System.EventArgs)
    '    Try
    '        IsConnected("SELECT * FROM commercial_affaire WHERE nomcl='" & nomClient.Text & "'", False)
    '        If myDR.HasRows Then
    '            While myDR.Read
    '                numero.Text = myDR("code_affaire").ToString
    '                affaire.Text = myDR("titre").ToString
    '            End While
    '        End If
    '        load_prix()
    '        load_modalitePaiement()
    '        load_delais()
    '    Catch ex As Exception
    '        EnvoiError(ex.Message)
    '    End Try
    'End Sub
    Private Sub numero_TextChanged(sender As Object, e As EventArgs) Handles numero.TextChanged
        load_prix()
        load_modalitePaiement()
        load_delais()
        affaire.Text = ""
        delais.Text = ""
        IsConnected("SELECT * FROM commercial_affaire WHERE code_affaire='" & numero.Text & "'", False)
        If myDR.HasRows Then
            While myDR.Read
                delais.Text = myDR("delai_exe").ToString() & " a partir " & myDR("EntréeDate").ToString()
                affaire.Text = myDR("titre").ToString
            End While
        End If
    End Sub
#Region "fonctions"
    Sub reload()
        IsConnected("SELECT distinct controle FROM commercial_oe_controle ", False)
        If myDR.HasRows Then
            While myDR.Read
                CheckedComboBoxEdit1.Properties.Items.Add(myDR("controle"))
            End While
        End If
    End Sub
#End Region
    Private Sub ModifStripMenuItem1_Click(sender As System.Object, e As System.EventArgs) Handles ModifStripMenuItem1.Click
        Try
            For i = 0 To ListView1.Items.Count - 1
                If ListView1.Items(i).Selected = True Then
                    ensembleGeneraux.Text = ListView1.Items(i).Text
                    exe.Text = ListView1.Items(i).SubItems(1).Text
                    titre.Text = ListView1.Items(i).SubItems(2).Text
                    soustitre.Text = ListView1.Items(i).SubItems(3).Text
                    defFournit.Text = ListView1.Items(i).SubItems(4).Text
                    ListView1.Items(i).Remove()
                End If
            Next
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub

    Private Sub SupStripMenuItem2_Click(sender As System.Object, e As System.EventArgs) Handles SupStripMenuItem2.Click
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

    Private Sub ensembleGeneraux_TextChanged(sender As System.Object, e As System.EventArgs) Handles ensembleGeneraux.TextChanged
        If exe.Text <> "" And defFournit.Text <> "" And ensembleGeneraux.Text <> "" Then
            ButtonX7.Enabled = True
            titre.Enabled = False
            soustitre.Enabled = False
        Else
            titre.Enabled = True
            soustitre.Enabled = True
            ButtonX7.Enabled = False
        End If
    End Sub

    Private Sub exe_TextChanged(sender As System.Object, e As System.EventArgs) Handles exe.TextChanged
        If exe.Text <> "" And defFournit.Text <> "" And ensembleGeneraux.Text <> "" Then
            ButtonX7.Enabled = True
            titre.Enabled = False
            soustitre.Enabled = False
        Else
            titre.Enabled = True
            soustitre.Enabled = True
            ButtonX7.Enabled = False
        End If
    End Sub

    Private Sub ButtonX1_Click(sender As System.Object, e As System.EventArgs) Handles ButtonX1.Click
        If controle.Text <> "" Then
            Dim q = "INSERT INTO commercial_oe_controle (`idControle`,`controle`) VALUES(null,'" & controle.Text & "')"
            If IsConnected(q, False) Then
                controle.Text = ""
                ButtonX1.Enabled = False
            End If
            reload()
        End If
    End Sub
    Private Sub controle_TextChanged(sender As System.Object, e As System.EventArgs) Handles controle.TextChanged
        If controle.Text <> "" Then
            ButtonX1.Enabled = True
        End If
    End Sub
    Private Sub defFournit_TextChanged(sender As System.Object, e As System.EventArgs) Handles defFournit.TextChanged
        If exe.Text <> "" And defFournit.Text <> "" And ensembleGeneraux.Text <> "" Then
            ButtonX7.Enabled = True
            titre.Enabled = False
            soustitre.Enabled = False
        Else
            titre.Enabled = True
            soustitre.Enabled = True
            ButtonX7.Enabled = False
        End If
    End Sub
    Private Sub titre_TextChanged(sender As Object, e As EventArgs) Handles titre.TextChanged
        If titre.Text <> "" And soustitre.Text <> "" Then
            defFournit.Enabled = False
            exe.Enabled = False
            ensembleGeneraux.Enabled = False
            ButtonX7.Enabled = True
        Else
            defFournit.Enabled = True
            exe.Enabled = True
            ensembleGeneraux.Enabled = True
            ButtonX7.Enabled = False
        End If
    End Sub
    Private Sub soustitre_TextChanged(sender As Object, e As EventArgs) Handles soustitre.TextChanged
        If titre.Text <> "" And soustitre.Text <> "" Then
            defFournit.Enabled = False
            exe.Enabled = False
            ensembleGeneraux.Enabled = False
            ButtonX7.Enabled = True
        Else
            defFournit.Enabled = True
            exe.Enabled = True
            ensembleGeneraux.Enabled = True
            ButtonX7.Enabled = False
        End If
    End Sub
End Class