Imports DevComponents.DotNetBar
Imports DevExpress.XtraEditors.Controls

Public Class AjoutArretTravail
    Dim sql As New SQLControl
    Public idarret As String = ""
    'Sub reload()
    '    Try
    '        If Sql.VerifiyConnection = True Then
    '            Sql.RunQuery("SELECT idArret_de_travail as 'Numero de refferance',employes.Matricule,Nom,Prénom,Date_de_Naissance as 'Date de Naissance',lieux_de_naissance as 'Lieu de Naissance',arret_du as 'Arrét du ',arret_au as 'Arrét au',nb_jours as 'Nombre de jours',date_reprise as 'Date de Reprise',nature_conge as 'Nature de Congé',siege_lesion as 'Siege des liaisions',nature_lesion as 'Nature des liaisions',Observation FROM employes LEFT JOIN social_arret_de_travail ON employes.Matricule = social_arret_de_travail.matricule WHERE social_arret_de_travail.arret_du between '" & Du.Text & "'and '" & au.Text & "'")
    '        End If
    '        If Sql.SQLDS.Tables.Count > 0 Then
    '            For Each r As DataRow In Sql.SQLDS.Tables(0).Rows
    '                If r.Item(7).ToString = "00:00:00" Or r.Item(7).ToString = "01-01-0001" Or r.Item(7).ToString = "01/01/0001" Then r.Item(7) = ""
    '            Next
    '            GestionArretTravail.arretDgv.DataSource = sql.SQLDS.Tables(0)
    '        End If
    '    Catch ex As Exception
    '        EnvoiError(ex.Message)
    '    End Try
    'End Sub
    Private Sub ButtonX2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Ajouter.Click
        Try
            If ListMatNom.SelectedIndex = -1 Then
                MessageBoxEx.Show("Vous devez sélectionner un matricule avant de cliquer ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                Dim q2 As String = ""
                If Ajouter.Text = "Ajouter" Then
                    If NC.Text = "" Then
                        MessageBoxEx.Show("Vous avez laissé le champ Nature Conge vide !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Sub
                    End If
                    If Du.Text = "" Then
                        MessageBoxEx.Show("Vous avez laissé le champ date debut  vide !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Sub
                    End If
                    If au.Text = "" Then
                        MessageBoxEx.Show("Vous avez laissé le champ date fin vide !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Sub
                    End If
                    If NDJ.Text = "" Then
                        MessageBoxEx.Show("Vous avez laissé le champ nombre jours pris vide !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Sub
                    End If
                    'If NC.Text = "" Then
                    '    MessageBoxEx.Show("Vous avez laissé le champ Nature Conge vide !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    '    Exit Sub
                    'End If
                    If DR.Text = "" Then
                        MessageBoxEx.Show("Vous avez laissé le champ Date de reprise vide !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Sub
                    End If
                    q2 = "INSERT INTO `social_arret_de_travail`(`idArret_de_travail`,`arret_du`,`arret_au`,`nb_jours`,`date_reprise`,`nature_conge`,`siege_lesion`,`nature_lesion`,`Observation`,`Matricule`,DateEnregistrement)VALUES(NULL,'" & Du.Value.ToString("dd-MM-yyyy") & "','" & au.Value.ToString("dd-MM-yyyy") & "','" & mysql_escape_string(NDJ.Text) & "','" & mysql_escape_string(DR.Value.ToString("dd-MM-yyyy")) & "','" & mysql_escape_string(NC.Text) & "','" & mysql_escape_string(sdl.Text) & "','" & mysql_escape_string(ndl.Text) & "','" & mysql_escape_string(obs.Text) & "','" & ListMatNom.Value & "',Now());"
                    If MessageBoxEx.Show("Voullez vous vraiment ajouter cet arrét de travail ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                        If IsConnected(q2, True) = True Then
                            MessageBoxEx.Show("L'ajout est términé avec succes ! ", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            nom.Text = ""
                            prenom.Text = ""
                            Lieux_de_Naissance.Text = ""
                            Date_entrée.Text = ""
                            Fonction.Text = ""
                            Adresse.Text = ""
                            Date_de_Naissance.Text = ""
                            NSS.Text = ""
                            Du.Value = Nothing
                            au.Value = Nothing
                            NDJ.Text = ""
                            DR.Value = Nothing
                            NC.Text = ""
                            sdl.Text = ""
                            ndl.Text = ""
                            obs.Text = ""
                            ListMatNom.Value = Nothing
                            'GestionArretTravail.reload()
                            If sql.VerifiyConnection = True Then
                                sql.RunQuery("SELECT idArret_de_travail as 'Numero de referance',employes.Matricule,Nom,Prénom,Date_de_Naissance as 'Date de Naissance',lieux_de_naissance as 'Lieu de Naissance',arret_du as 'Arrét du',arret_au as 'Arrét au',nb_jours as 'Nombre de jours',date_reprise as 'Date de Reprise',nature_conge as 'Nature de Congé',siege_lesion as 'Siege des liaisions',nature_lesion as 'Nature des liaisions',Observation FROM employes LEFT JOIN social_arret_de_travail ON employes.Matricule = social_arret_de_travail.matricule WHERE employes.Matricule ='" & ListMatNom.Value & "'and (social_arret_de_travail.arret_du>= '" & GestionArretTravail.du.Value.ToString("dd-MM-yyyy") & "' and social_arret_de_travail.arret_du<='" & GestionArretTravail.au.Value.ToString("dd-MM-yyyy") & "')")
                            End If
                            If sql.SQLDS.Tables.Count > 0 Then
                                For Each r As DataRow In sql.SQLDS.Tables(0).Rows
                                    If r.Item(7).ToString = "00:00:00" Or r.Item(7).ToString = "01-01-0001" Or r.Item(7).ToString = "01/01/0001" Then
                                        r.Item(7) = ""
                                    End If
                                    If r.Item(8).ToString = "00:00:00" Or r.Item(8).ToString = "01-01-0001" Or r.Item(8).ToString = "01/01/0001" Then
                                        r.Item(8) = ""
                                    End If
                                Next
                                GestionArretTravail.arretDgv.DataSource = sql.SQLDS.Tables(0)
                            End If
                        End If
                    End If
                Else
                    q2 = "UPDATE  social_arret_de_travail set arret_du='" & Du.Value.ToString("dd-MM-yyyy") & "', arret_au='" & au.Value.ToString("dd-MM-yyyy") & "', nb_jours='" & NDJ.Text & "', date_reprise='" & DR.Value.ToString("dd-MM-yyyy") & "', nature_conge='" & mysql_escape_string(NC.Text) & "', siege_lesion='" & mysql_escape_string(sdl.Text) & "', nature_lesion='" & mysql_escape_string(ndl.Text) & "', Observation='" & mysql_escape_string(obs.Text) & "' where idArret_de_travail='" & idarret & "'Limit 1"
                    If MessageBoxEx.Show("Voullez vous vraiment modifier cet arrét de travail ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                        If IsConnected(q2, True) = True Then
                            MessageBoxEx.Show("La modification est términé avec succes ! ", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            nom.Text = ""
                            prenom.Text = ""
                            Lieux_de_Naissance.Text = ""
                            Date_entrée.Text = ""
                            Fonction.Text = ""
                            Adresse.Text = ""
                            Date_de_Naissance.Text = ""
                            NSS.Text = ""
                            NC.SelectedIndex = -1
                            sdl.Text = ""
                            ndl.Text = ""
                            obs.Text = ""
                            Du.Value = Nothing
                            au.Value = Nothing
                            NDJ.Text = ""
                            DR.Value = Nothing
                            ListMatNom.Value = Nothing
                            Ajouter.Text = "Ajouter"
                            Ajouter.Image = My.Resources.add_button
                            Me.Text = "Ajouter l'arret de travail "
                            ' GestionArretTravail.reload()
                            If sql.VerifiyConnection = True Then
                                sql.RunQuery("SELECT idArret_de_travail as 'Numero de referance',employes.Matricule,Nom,Prénom,Date_de_Naissance as 'Date de Naissance',lieux_de_naissance as 'Lieu de Naissance',arret_du as 'Arrét du',arret_au as 'Arrét au',nb_jours as 'Nombre de jours',date_reprise as 'Date de Reprise',nature_conge as 'Nature de Congé',siege_lesion as 'Siege des liaisions',nature_lesion as 'Nature des liaisions',Observation FROM employes LEFT JOIN social_arret_de_travail ON employes.Matricule = social_arret_de_travail.matricule WHERE employes.Matricule ='" & ListMatNom.Value & "'and (social_arret_de_travail.arret_du>= '" & GestionArretTravail.du.Value.ToString("dd-MM-yyyy") & "' and social_arret_de_travail.arret_du<='" & GestionArretTravail.au.Value.ToString("dd-MM-yyyy") & "')")
                            End If
                            If sql.SQLDS.Tables.Count > 0 Then
                                For Each r As DataRow In sql.SQLDS.Tables(0).Rows
                                    If r.Item(7).ToString = "00:00:00" Or r.Item(7).ToString = "01-01-0001" Or r.Item(7).ToString = "01/01/0001" Then
                                        r.Item(7) = ""
                                    End If
                                    If r.Item(8).ToString = "00:00:00" Or r.Item(8).ToString = "01-01-0001" Or r.Item(8).ToString = "01/01/0001" Then
                                        r.Item(8) = ""
                                    End If
                                Next
                                GestionArretTravail.arretDgv.DataSource = sql.SQLDS.Tables(0)
                            End If
                            Me.Close()
                        End If
                    End If
                End If
            End If
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub
#Region "fonction"
    Private Sub load_Matricule_Nom()
        ListMatNom.Properties.Items.Clear()
        IsConnected("SELECT DISTINCT Matricule,Nom,Prénom FROM employes ", False)
        If myDR.HasRows Then
            While myDR.Read
                ListMatNom.Properties.Items.Add(New ImageComboBoxItem(myDR("Matricule").ToString & " - " & myDR("Nom").ToString & " " & myDR("Prénom").ToString, myDR("Matricule").ToString, 4))
            End While
            ListMatNom.Properties.SmallImages = StatImageList
            ListMatNom.Properties.LargeImages = StatImageList
        End If
    End Sub
#End Region
    Private Sub ListMatNom_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ListMatNom.SelectedIndexChanged
        Try
            If ListMatNom.Value.ToString.Length = 5 Then
                'IsConnected("SELECT * FROM Employes, WHERE Matricule='" & ListMatNom.Value & "'", False)
                IsConnected("SELECT employes.Matricule,nom,prénom,fonction,Date_de_Naissance,Lieux_de_Naissance,Adresse,Date_entrée,code_papers.Num_SS,Direction FROM employes LEFT JOIN code_papers ON employes.Matricule = code_papers.Matricule WHERE employes.Matricule ='" & ListMatNom.Value & "'", False)
                If myDR.HasRows = True Then
                    While (myDR.Read)
                        nom.Text = myDR("Nom").ToString
                        prenom.Text = myDR("Prénom").ToString
                        Lieux_de_Naissance.Text = myDR("Lieux_de_Naissance").ToString
                        Date_entrée.Text = myDR("Date_entrée").ToString
                        Fonction.Text = myDR("Fonction").ToString
                        Adresse.Text = myDR("Adresse").ToString
                        Date_de_Naissance.Text = myDR("Date_de_Naissance").ToString
                        NSS.Text = myDR("NSS").ToString
                    End While
                End If
                'IsConnected("SELECT * FROM social_n_securite WHERE Matricule='" & ListMatNom.Value & "'", False)
                'If myDR.HasRows = True Then
                '    While (myDR.Read)
                '        NSS.Text = myDR("NSS").ToString
                '    End While
                'End If
            End If
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub

    Private Sub AjoutArretTravail_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Try
            NDJ.Enabled = False
            load_Matricule_Nom()
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub
    Private Sub au_TextChanged(sender As System.Object, e As System.EventArgs) Handles au.TextChanged
        Try
            Dim datedu As String = Du.Value
            Dim dateau As String = au.Value
            NDJ.Enabled = True
            Dim nbj As String = ""
            nbj = Math.Floor(DateDiff(DateInterval.Day, DateValue(datedu), DateValue(dateau)))
            NDJ.Text = nbj.ToString
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub
End Class