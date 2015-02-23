Imports DevComponents.DotNetBar
Imports DevComponents.DotNetBar.Controls

Public Class Ajoutfonctionnaire
    Dim dir As String = "null"
    Dim dep As String = "null"
    Dim serv As String = "null"
    Dim equi As String = "null"
    Dim hal As String = "null"
    Dim fon As String = "null"
    Dim montant As String = "null"
    Private Sub FermerToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub MinimiserToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        '   Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Ajoutfonctionnaire_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            ' Me.WindowState = FormWindowState.Maximized
            For i = 0 To 15
                ech.Items.Add(i)
            Next
            For i = 1 To 20
                cat.Items.Add(i)
            Next
            cat.Items.Add("CS")

            load_departement()
            load_direction()
            load_service()
            load_region()
            load_fonction()
            load_hall()
            load_equipe()
            load_niveau()
            Dim a As Integer
            IsConnected("select MAX(Matricule) as Matricule from (select MAX(Matricule) as Matricule FROM employes UNION SELECT MAX(Matricule) as Matricule from stagiaire)  AS T  ", False)
            If myDR.HasRows = True Then
                While (myDR.Read())
                    a = myDR("Matricule")
                End While
            End If
            mat.Text = a + 1
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub

    Private Sub MaximiserToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub NormalToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.WindowState = FormWindowState.Normal
    End Sub

    Private Sub DateTimeInput1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateEntry.ValueChanged
        Try
            Dim strDOB As String = DateEntry.Value
            strDOB = Math.Floor(DateDiff(DateInterval.Month, DateValue(strDOB), Now()) / 12)
            entxt.Text = strDOB.ToString
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub

    Private Sub DateTimeInput2_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles datenais.ValueChanged
        Try
            Dim strDOB As String = datenais.Value
            strDOB = Math.Floor(DateDiff(DateInterval.Month, DateValue(strDOB), Now()) / 12)
            agetxt.Text = strDOB.ToString
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub
#Region "fonctions"

    Private Sub load_service()
        Try
            If IsConnected("SELECT DISTINCT name_service FROM Services ", False) = True Then
                If myDR.HasRows = True Then
                    ServiceComboBoxEx3.Items.Clear()
                    While (myDR.Read())
                        ServiceComboBoxEx3.Items.Add(myDR("name_service"))
                    End While
                End If
            End If
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub

    Private Sub load_fonction()
        Try
            If IsConnected("SELECT DISTINCT titre_fonction FROM Fonction ", False) = True Then
                If myDR.HasRows = True Then
                    fonction.Items.Clear()
                    While (myDR.Read())
                        fonction.Items.Add(myDR("titre_fonction"))
                    End While
                End If
            End If
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub
    Private Sub load_equipe()
        Try
            If IsConnected("SELECT DISTINCT Equipe FROM Employes ", False) = True Then
                If myDR.HasRows = True Then
                    equipe.Items.Clear()
                    While (myDR.Read())
                        equipe.Items.Add(myDR("Equipe"))
                    End While
                End If
            End If
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub
    Private Sub load_hall()
        Try
            If IsConnected("SELECT DISTINCT Hall FROM Employes ", False) = True Then
                If myDR.HasRows = True Then
                    hall.Items.Clear()
                    While (myDR.Read())
                        hall.Items.Add(myDR("Hall"))
                    End While
                End If
            End If
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub
    Public Sub load_niveau()
        Try
            If IsConnected("SELECT DISTINCT description_niveau FROM niveau", False) = True Then
                If myDR.HasRows = True Then
                    niveau.Items.Clear()
                    While (myDR.Read())
                        niveau.Items.Add(myDR("description_niveau"))
                    End While
                End If
            End If
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub
    Private Sub load_departement()
        Try
            If IsConnected("SELECT DISTINCT name_departement FROM Departement ", False) = True Then
                If myDR.HasRows = True Then
                    departementComboBoxEx2.Items.Clear()
                    While (myDR.Read())
                        departementComboBoxEx2.Items.Add(myDR("name_departement"))
                    End While
                End If
            End If
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub
    Private Sub load_direction()
        Try
            If IsConnected("SELECT DISTINCT name_direction FROM direction ", False) = True Then
                If myDR.HasRows = True Then
                    directionComboBoxEx1.Items.Clear()
                    While (myDR.Read())
                        directionComboBoxEx1.Items.Add(myDR("name_direction"))
                    End While
                End If
            End If
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub
    Private Sub load_region()
        Try
            If IsConnected("SELECT * FROM willaya ", False) = True Then
                If myDR.HasRows = True Then
                    region1.Items.Clear()
                    region2.Items.Clear()
                    While (myDR.Read())
                        region1.Items.Add(myDR("willaya"))
                        region2.Items.Add(myDR("willaya"))
                        'region1.Items.Add(myDR("id") & " - " & myDR("willaya"))
                        'region2.Items.Add(myDR("id") & " - " & myDR("willaya"))
                    End While
                End If
            End If
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub
    'Private Sub load_fonction()
    '    If IsConnected("SELECT * FROM Fonction ", False) = True Then
    '        If myDR.HasRows = True Then
    '            fonction.Items.Clear()
    '            While (myDR.Read())
    '                fonction.Items.Add(myDR("titre_fonction"))

    '            End While
    '        End If
    '    End If
    'End Sub
#End Region

    Private Sub radiofemme_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radiofemme.CheckedChanged
        Try
            If radiofemme.Checked = True Then
                service_national.Enabled = False
                service_national.Text = "Non concernée"
            Else
                service_national.Enabled = True
                service_national.Text = ""
            End If
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub
    Private Sub ButtonX3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Ajout_fonction.MdiParent = Mainfrm
            Ajout_fonction.Show()
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub




    'Private Sub hall_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles hall.SelectedIndexChanged
    '    IsConnected("select Hall from Employes WHERE Hall='" & hall.Text & "'", False)
    '    If myDR.HasRows = True Then
    '        While (myDR.Read())
    '            hal = myDR("Hall")
    '        End While
    '    End If
    'End Sub

    'Private Sub equipe_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles equipe.SelectedIndexChanged
    '    IsConnected("select Equipe from Employes WHERE Equipe='" & equipe.Text & "'", False)
    '    If myDR.HasRows = True Then
    '        While (myDR.Read())
    '            equi = myDR("Equipe")
    '        End While
    '    End If
    'End Sub



    'Private Sub fonction_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fonction.SelectedIndexChanged
    '    IsConnected("SELECT id_cat,id_ech,id_fonction FROM Fonction where titre_fonction='" & fonction.Text & "'", False)
    '    If myDR.HasRows = True Then
    '        While (myDR.Read())
    '            cat.Text = myDR("id_cat")
    '            fon = myDR("id_fonction")
    '            Dim echel = myDR("id_ech")
    '            If cat.Text = "CS" Then
    '                ech.Items.Clear()
    '                Dim cs() As String = {"CS junior N°1", "CS junior N°2", "CS1", "CS2", "CS3", "CS4"}
    '                ech.Items.AddRange(cs)
    '                Select Case echel
    '                    Case "csjun1"
    '                        ech.SelectedIndex = 0
    '                    Case "csjun2"
    '                        ech.SelectedIndex = 1
    '                    Case "cs1"
    '                        ech.SelectedIndex = 2
    '                    Case "cs2"
    '                        ech.SelectedIndex = 3
    '                    Case "cs3"
    '                        ech.SelectedIndex = 4
    '                    Case "cs4"
    '                        ech.SelectedIndex = 5
    '                End Select
    '                Clipboard.SetText("SELECT " & echel & " FROM GrilleCS where Element='salaire_base' ")
    '                IsConnected("SELECT " & echel & " FROM GrilleCS where Element='salaire_base' ", False)
    '                If myDR.HasRows = True Then
    '                    While (myDR.Read())
    '                        salaire.Text = myDR(echel) & ".00 DA"
    '                    End While
    '                End If
    '            Else
    '                ech.Items.Clear()
    '                For i = 0 To 15
    '                    ech.Items.Add(i)
    '                Next
    '                ech.SelectedIndex = echel
    '                IsConnected("SELECT ech_" & echel & " FROM Grille where  F1='" & cat.Text & "' ", False)
    '                If myDR.HasRows = True Then
    '                    While (myDR.Read())
    '                        salaire.Text = myDR("ech_" & echel) & ".00 DA"
    '                    End While
    '                End If

    '            End If
    '            'ech.Text = myDR("id_ech")

    '        End While

    '    End If

    'End Sub
    Private Sub fonction_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fonction.SelectedIndexChanged
        Try
            IsConnected("SELECT id_Cat,id_Ech,titre_Fonction FROM Fonction where titre_Fonction='" & mysql_escape_string(fonction.Text) & "'", False)
            If myDR.HasRows = True Then
                While (myDR.Read())
                    cat.Text = myDR("id_Cat")
                    fon = myDR("titre_Fonction")
                    Dim echel = myDR("id_Ech")
                    If cat.Text = "CS" Then
                        ech.Items.Clear()
                        Dim cs() As String = {"CS junior N°1", "CS junior N°2", "CS1", "CS2", "CS3", "CS4"}
                        ech.Items.AddRange(cs)
                        Select Case echel
                            Case "csjun1"
                                ech.SelectedIndex = 0
                            Case "csjun2"
                                ech.SelectedIndex = 1
                            Case "cs1"
                                ech.SelectedIndex = 2
                            Case "cs2"
                                ech.SelectedIndex = 3
                            Case "cs3"
                                ech.SelectedIndex = 4
                            Case "cs4"
                                ech.SelectedIndex = 5
                        End Select
                        ' Clipboard.SetText("SELECT " & echel & " FROM GrilleCS where Element='salaire_base' ")
                        IsConnected("SELECT " & echel & " FROM GrilleCS where Element='salaire_base' ", False)
                        If myDR.HasRows = True Then
                            While (myDR.Read())
                                salaire.Text = myDR(echel) & ".00 DA"
                            End While
                        End If
                    Else
                        ech.Items.Clear()
                        For i = 0 To 15
                            ech.Items.Add(i)
                        Next
                        ech.SelectedIndex = echel
                        IsConnected("SELECT ech_" & echel & " FROM Grille where  F1='" & cat.Text & "' ", False)
                        If myDR.HasRows = True Then
                            While (myDR.Read())
                                salaire.Text = myDR("ech_" & echel) & ".00 DA"
                            End While
                        End If

                    End If
                    'ech.Text = myDR("id_ech")

                End While
            End If
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub
    Private Sub ech_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ech.SelectedIndexChanged
        Try
            salaire.Clear()
            If cat.Text <> "" Then
                If cat.Text = "CS" Then
                    If ech.SelectedIndex > -1 Then
                        Dim col As String = ""
                        Select Case ech.SelectedIndex
                            Case 0
                                col = "csjun1"
                            Case 1
                                col = "csjun2"
                            Case 2
                                col = "cs1"
                            Case 3
                                col = "cs2"
                            Case 4
                                col = "cs3"
                            Case 5
                                col = "cs4"
                            Case Else
                                col = "csjun1"
                        End Select
                        IsConnected("SELECT " & col & " FROM GrilleCS where Element='salaire_base' ", False)
                        If myDR.HasRows = True Then
                            While (myDR.Read())
                                salaire.Text = myDR(col) & ".00 DA"
                            End While
                        End If
                    End If
                Else
                    If ech.SelectedIndex > -1 Then
                        IsConnected("SELECT ech_" & ech.SelectedIndex.ToString & " FROM Grille where F1=" & cat.Text, False)
                        If myDR.HasRows = True Then
                            While (myDR.Read())
                                salaire.Text = myDR("ech_" & ech.SelectedIndex) & ".00 DA"
                            End While

                        End If
                    End If
                End If
            End If
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub

    'Private Sub ButtonX8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    Dim ha = InputBox(" Veuillez saisir le hall a ajouter", "Ajout d'un hall")
    '    If Not ha = Nothing Then
    '        IsConnected("INSERT INTO Hall (description_hall) values('" & ha & "')", True)
    '        load_hall()
    '    End If
    'End Sub

    'Private Sub ButtonX15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    InfoEntreprise.MdiParent = Mainfrm
    '    InfoEntreprise.Show()
    'End Sub

    'Private Sub ButtonX7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    InfoEntreprise.MdiParent = Mainfrm
    '    InfoEntreprise.Show()
    'End Sub

    'Private Sub ButtonX14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    InfoEntreprise.MdiParent = Mainfrm
    '    InfoEntreprise.Show()
    'End Sub

    'Private Sub ButtonX9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    Dim se = InputBox(" Veuillez saisir l'equipe a ajouter", "Ajout d'une equipe")
    '    If Not se = Nothing Then
    '        IsConnected("INSERT INTO Equipe (description_equipe) values('" & se & "')", True)
    '        load_equipe()
    '    End If
    'End Sub


    Private Sub cat_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cat.SelectedIndexChanged
        Try
            salaire.Clear()
            If cat.Text <> "" Then
                If cat.Text = "CS" Then
                    ech.Items.Clear()
                    Dim cs() As String = {"CS junior N1", "CS junior N2", "CS1", "CS2", "CS3", "CS4"}
                    ech.Items.AddRange(cs)
                    If ech.SelectedIndex > -1 Then
                        Dim col As String = ""
                        Select Case ech.SelectedIndex
                            Case 0
                                col = "csjun1"
                            Case 1
                                col = "csjun2"
                            Case 2
                                col = "cs1"
                            Case 3
                                col = "cs2"
                            Case 4
                                col = "cs3"
                            Case 5
                                col = "cs4"
                            Case Else
                                col = "csjun1"
                        End Select
                        IsConnected("SELECT " & col & " FROM GrilleCS where Element='salaire_base' ", False)
                        If myDR.HasRows = True Then
                            While (myDR.Read())
                                salaire.Text = myDR(col) & ".00 DA"
                            End While
                        End If
                    End If
                Else
                    ech.Items.Clear()
                    For i = 0 To 15
                        ech.Items.Add(i)
                    Next
                    'IsConnected("SELECT ech_" & ech.SelectedIndex.ToString & " FROM Grille where F1=" & cat.Text, False)
                    'If myDR.HasRows = True Then
                    '    While (myDR.Read())
                    '        salaire.Text = myDR("ech_" & ech.SelectedIndex) & ".00 DA"
                    '    End While

                    'End If
                End If
            End If
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub

    Private Sub ButtonX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX1.Click
        Try
            If mat.Text = "" Then
                MessageBoxEx.Show("Vous avez laissé le champ Matricule vide", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            IsConnected("SELECT Matricule FROM Employes WHERE Matricule='" & mat.Text & "'", False)
            If myDR.HasRows = True Then
                MessageBoxEx.Show("le Matricule existe déja dans la list d'employés", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            If prenom.Text = "" Then
                MessageBoxEx.Show("Vous avez laissé le champ Prénom vide !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            If nom.Text = "" Then
                MessageBoxEx.Show("Vous avez laissé le champ Nom vide !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            If datenais.IsEmpty Then
                MessageBoxEx.Show("Vous avez laissé le champ de date de naissance vide !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            If DateEntry.IsEmpty Then
                MessageBoxEx.Show("Vous avez laissé le champ de date d'entrée vide !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            'If region1.SelectedIndex = -1 Then
            '    MessageBoxEx.Show("Vous n'avez pas choisis la willaya de naissance !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
            '    Exit Sub
            'End If
            'If region2.SelectedIndex = -1 Then
            '    MessageBoxEx.Show("Vous n'avez pas choisis la willaya de résidance !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
            '    Exit Sub
            'End If
            If situationf.SelectedIndex = -1 Then
                MessageBoxEx.Show("Vous n'avez pas choisis la situation familliale !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            If lnais.Text = "" Then
                MessageBoxEx.Show("Vous avez laissé le champ lieu de naissance vide !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            If adresse.Text = "" Then
                MessageBoxEx.Show("Vous avez laissé le champ d'addresse vide !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            If niveau.SelectedIndex = -1 Then
                MessageBoxEx.Show("Vous n'avez pas choisis niveau !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            If fonction.SelectedIndex = -1 Then
                MessageBoxEx.Show("Vous n'avez pas choisis la fonction  !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            If nc.SelectedIndex = -1 Then
                MessageBoxEx.Show("Vous n'avez pas choisis la nature de contrat !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            If collect.SelectedIndex = -1 Then
                MessageBoxEx.Show("Vous n'avez pas choisis le champ collectif !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            If statut.SelectedIndex = -1 Then
                MessageBoxEx.Show("Vous n'avez pas choisis le statut !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            If sal.SelectedIndex = -1 Then
                MessageBoxEx.Show("Vous n'avez pas choisis la salibilité  !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            If pen.SelectedIndex = -1 Then
                MessageBoxEx.Show("Vous n'avez pas choisis la pénibilité !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            If ins.SelectedIndex = -1 Then
                MessageBoxEx.Show("Vous n'avez pas choisis l'insalabilité !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            If danger.SelectedIndex = -1 Then
                MessageBoxEx.Show("Vous n'avez pas choisis le champ danger!", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            Dim niv = niveau.SelectedIndex + 1
            Dim gen = "Homme"
            If radiofemme.Checked = True Then
                gen = "Femme"
            Else
                gen = "Homme"
            End If

            Dim q As String = "INSERT INTO Employes" & _
                "(Matricule" & _
               ",Nom " & _
               ",Prénom" & _
               ",Date_de_Naissance" & _
               ",Lieux_de_Naissance" & _
               ",Ville" & _
               ",Date_entrée" & _
               ",Date_entrée_1" & _
               ",etat_emp" & _
               ",Date_fin_de_contrat" & _
               ",Fonction" & _
               ",Ech" & _
               ",Cat" & _
               ",S_B_01_14" & _
               ",Groupe" & _
               ",Direction" & _
               ",Département" & _
               ",Service" & _
               ",Hall" & _
               ",Equipe" & _
               ",Collectif" & _
               ",Collectif_prc" & _
               ",Statut" & _
               ",Motif_de_Recrut" & _
               ",Nbres_Cont" & _
               ",Niveau" & _
               ",NC" & _
               ",Service_national" & _
               ",Sexe" & _
               ",Sit_fam" & _
               ",Adresse" & _
               ",Ville1" & _
               ",Salissure" & _
               ",Pénibilité" & _
               ",Insalubrité" & _
               ",Danger" & _
               ",NumTel" & _
               ",Formation_ext" & _
               ",Formation_int" & _
               ",Age1" & _
               ",Anc_1" & _
               ",user_id" & _
            ",date_enregistrement" & _
               ",Type)" & _
            "VALUES" & _
               "('" & mat.Text & "'" & _
               ",'" & mysql_escape_string(nom.Text) & "'" & _
               ",'" & mysql_escape_string(prenom.Text) & "'" & _
               ",'" & datenais.Value.ToString("yyyy-MM-dd") & "'" & _
               ",'" & mysql_escape_string(lnais.Text) & "'" & _
               ",'" & region1.Text & "'" & _
               ",'" & DateEntry.Value.ToString("yyyy-MM-dd") & "'" & _
               ",'" & DateTimeInput2.Value.ToString("yyyy-MM-dd") & "'" & _
               ",'1'" & _
               ",'" & DateTimeInput3.Value.ToString("yyyy-MM-dd") & "'" & _
               ",'" & mysql_escape_string(fonction.Text) & "'" & _
               ",'" & ech.Text & "'" & _
               ",'" & cat.Text & "'" & _
               ",'" & salaire.Text.Replace("DA", "") & "'" & _
               ",'" & groupe.Text & "'" & _
               ",'" & directionComboBoxEx1.Text & "'" & _
               ",'" & departementComboBoxEx2.Text & "'" & _
               ",'" & ServiceComboBoxEx3.Text & "'" & _
               ",'" & hall.Text & "'" & _
               ",'" & equipe.Text & "'" & _
               ",'" & collect.Text & "'" & _
               ",'" & collectif.Text & "'" & _
               ",'" & statut.Text & "'" & _
               ",'" & mysql_escape_string(motif_recru.Text) & "'" & _
               ",'" & ncontrat.Value & "'" & _
               ",'" & mysql_escape_string(niveau.Text) & "'" & _
               ",'" & nc.Text & "'" & _
               ",'" & service_national.Text & "'" & _
               ",'" & gen & "'" & _
               ",'" & situationf.Text & "'" & _
               ",'" & adresse.Text & "'" & _
               ",'" & region2.Text & "'" & _
               ",'" & sal.Text & "'" & _
               ",'" & pen.Text & "'" & _
               ",'" & ins.Text & "'" & _
               ",'" & danger.Text & "'" & _
               ",'" & numtel.Text & "'" & _
               ",'" & mysql_escape_string(fmtext.Text) & "'" & _
               ",'" & mysql_escape_string(fmtint.Text) & "'" & _
                ",'" & agetxt.Text & "'" & _
               ",'" & entxt.Text & "'" & _
                ",'" & user_id & "'" & _
               ",NOW()" & _
               ",'" & type.Text & "')"
            '  Dim auery = "INSERT INTO Employes(Matricule,Nom,Prénom,Date_de_Naissance,Lieu_de_Naissance,Ville,Date_entrée,NC,Adresse,Date_entrée_1,Date_fin_de_contrat,Ech,Cat,S_B_01_14,Collectif,Groupe,Collectif_prc,Statut,Motif_de_Recrut,Nbres_Cont,Service_national,Sit_fam,Ville1,Salissure,Pénibilité,Insalubrité,Danger,Niveau,etat_emp,Sexe,Fonction,Direction,Service,Département,Hall,Equipe,NumTel,Formation_ext,Formation_int,agetxt,entxt,type) values ('" & mat.Text & "', '" & nom.Text & "', '" & prenom.Text & "','" & datenais.Value & "','" & lnais.Text & "'," & region1.SelectedIndex + 1 & ",'" & DateEntry.Value & "','" & nc.Text & "','" & adresse.Text & "','" & DateTimeInput2.Value & "','" & DateTimeInput3.Value & "','" & ech.Text & "','" & "','" & cat.SelectedIndex & "','" & "','" & salaire.Text & "','" & collectif.Text & "','" & groupe.Text & "','" & collect.Text & "','" & statut.Text & "','" & motif_recru.Text & "','" & ncontrat.Value & "','" & service_national.Text & "','" & situationf.Text & "'," & region2.Text & ",'" & sal.Text & "','" & pen.Text & "','" & ins.Text & "','" & danger.Text & "'," & niveau.Text & ",1,'" & gen & "','" & fonction.Text & "','" & "','" & directionComboBoxEx1.Text & "','" & ServiceComboBoxEx3.Text & "','" & departementComboBoxEx2.Text & "','" & hall.Text & "','" & equipe.Text & "','" & numtel.Text & "','" & fmtext.Text & "','" & fmtint.Text & "','" & agetxt.Text & "','" & entxt.Text & "','" & type.Text & "' )"
            ' Clipboard.SetText(q)
            If IsConnected(q, False) Then
                MessageBoxEx.Show("Le fonctionnaire a bien été enregistrer", "Succés", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Dim frm = New Ajoutfonctionnaire
                frm.MdiParent = Mainfrm
                frm.Show()
                Me.Close()
            End If
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub

    Private Sub ButtonX2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX2.Click
        Try
            Me.Close()
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub

    Private Sub ButtonX3_Click_1(sender As System.Object, e As System.EventArgs) Handles ButtonX3.Click
        AddNiveau.ShowDialog()
    End Sub
End Class