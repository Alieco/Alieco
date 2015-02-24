Imports DevComponents.DotNetBar
Imports DevExpress.XtraEditors.Controls
Public Class GestionArretTravail
    Dim sql As New SQLControl
    Dim val As Integer = 0
    Dim nb
    Dim nb1
#Region "Fonctions"
    Private Sub load_Matricule_Nom()
        ListMatNom.Properties.Items.Clear()
        If du.Value = Nothing Or au.Value = Nothing Then
            MessageBoxEx.Show("Veuillez saisir la date!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            IsConnected("SELECT DISTINCT employes.Matricule,employes.Nom,employes.Prénom FROM employes,social_arret_de_travail where employes.Matricule = social_arret_de_travail.matricule and (social_arret_de_travail.arret_du>= '" & du.Value.ToString("dd-MM-yyyy") & "' and social_arret_de_travail.arret_du<='" & au.Value.ToString("dd-MM-yyyy") & "')", False)
            If myDR.HasRows Then
                While myDR.Read
                    ListMatNom.Properties.Items.Add(New ImageComboBoxItem(myDR("Matricule").ToString & " - " & myDR("Nom").ToString & " " & myDR("Prénom").ToString, myDR("Matricule").ToString, 4))
                End While
                ListMatNom.Properties.SmallImages = StatImageList
                ListMatNom.Properties.LargeImages = StatImageList
            End If
        End If
    End Sub
    Sub reload()
        Try
            If du.Value = Nothing Or au.Value = Nothing Then
                MessageBoxEx.Show("Veuillez saisir la date!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                If sql.VerifiyConnection = True Then
                    sql.RunQuery("SELECT idArret_de_travail as 'Numero de referance',employes.Matricule,Nom,Prénom,Date_de_Naissance as 'Date de Naissance',lieux_de_naissance as 'Lieu de Naissance',arret_du as 'Arrét du',arret_au as 'Arrét au',nb_jours as 'Nombre de jours',date_reprise as 'Date de Reprise',nature_conge as 'Nature de Congé',siege_lesion as 'Siege des liaisions',nature_lesion as 'Nature des liaisions',Observation FROM employes LEFT JOIN social_arret_de_travail ON employes.Matricule = social_arret_de_travail.matricule WHERE employes.Matricule ='" & ListMatNom.Value & "'and (social_arret_de_travail.arret_du>= '" & du.Value.ToString("dd-MM-yyyy") & "' and social_arret_de_travail.arret_du<='" & au.Value.ToString("dd-MM-yyyy") & "')")
                End If
                If sql.SQLDS.Tables.Count > 0 Then
                    For Each r As DataRow In sql.SQLDS.Tables(0).Rows
                        If r.Item(7).ToString = "00:00:00" Or r.Item(7).ToString = "01-01-0001" Or r.Item(7).ToString = "01/01/0001" Or r.Item(8).ToString = "00:00:00" Or r.Item(8).ToString = "01-01-0001" Or r.Item(8).ToString = "01/01/0001" Then
                            r.Item(7) = ""
                            r.Item(8) = ""
                        End If
                    Next
                    arretDgv.DataSource = sql.SQLDS.Tables(0)
                End If
            End If
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub
#End Region
    Private Sub GestionArretTravail_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        au.Value = Date.Now.Date
        Dim dt As Date = Date.Today
        dt = dt.AddDays(-30)
        du.Value = dt
    End Sub

    Private Sub ActualiserToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ActualiserToolStripMenuItem.Click
        Try
            reload()
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub

    Private Sub AjouterToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles AjouterToolStripMenuItem.Click
        Dim aj As AjoutArretTravail = New AjoutArretTravail
        aj.Ajouter.Text = "Ajouter"
        aj.Ajouter.Image = My.Resources.add_button
        aj.Text = "Ajouter un arret de travail "
        aj.MdiParent = Mainfrm
        aj.Show()
    End Sub

    Private Sub ModifierToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ModifierToolStripMenuItem.Click
        Try
            If GridView1.SelectedRowsCount = 0 Then
                MessageBoxEx.Show("Vous devez selectionner le matricule avant de cliquer modifier", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                AjoutArretTravail.ListMatNom.Value = GridView1.GetFocusedRowCellValue("Matricule").ToString
                AjoutArretTravail.Du.Value = GridView1.GetFocusedRowCellValue("Arrét du").ToString
                AjoutArretTravail.au.Value = GridView1.GetFocusedRowCellValue("Arrét au").ToString
                AjoutArretTravail.NDJ.Text = GridView1.GetFocusedRowCellValue("Nombre de jours").ToString
                AjoutArretTravail.DR.Value = GridView1.GetFocusedRowCellValue("Date de Reprise").ToString
                AjoutArretTravail.NC.Text = GridView1.GetFocusedRowCellValue("Nature de Congé").ToString
                AjoutArretTravail.sdl.Text = GridView1.GetFocusedRowCellValue("Siege des liaisions").ToString
                AjoutArretTravail.ndl.Text = GridView1.GetFocusedRowCellValue("Nature des liaisions").ToString
                AjoutArretTravail.obs.Text = GridView1.GetFocusedRowCellValue("Observation").ToString
                AjoutArretTravail.idarret = GridView1.GetFocusedRowCellValue("Numero de referance").ToString
                AjoutArretTravail.Ajouter.Text = "Modifier l'arret de travail"
                AjoutArretTravail.Ajouter.Image = My.Resources.edit
                AjoutArretTravail.Text = "Modifier "
                'If ListMatNom.Value <> Nothing Then
                'IsConnected("SELECT idArret_de_travail FROM social_arret_de_travail WHERE Matricule='" & ListMatNom.Value & "' and nature_conge='" & AjoutArretTravail.NC.Text & "'", False)
                'If myDR.HasRows = True Then
                '    While (myDR.Read)
                '        val = myDR("idArret_de_travail").ToString
                '    End While
                'End If
                'If ListMatNom.Value.ToString.Length = 5 Then

                IsConnected("SELECT employes.Matricule,nom,prénom,fonction,Date_de_Naissance,Lieux_de_Naissance,Adresse,Date_entrée,code_papers.Num_SS,Direction FROM employes LEFT JOIN code_papers ON employes.Matricule = code_papers.Matricule WHERE employes.Matricule ='" & AjoutArretTravail.ListMatNom.Value & "'", False)
                If myDR.HasRows = True Then
                    While (myDR.Read)
                        AjoutArretTravail.nom.Text = myDR("Nom").ToString
                        AjoutArretTravail.prenom.Text = myDR("Prénom").ToString
                        AjoutArretTravail.Lieux_de_Naissance.Text = myDR("Lieux_de_Naissance").ToString
                        AjoutArretTravail.Date_entrée.Text = myDR("Date_entrée").ToString
                        AjoutArretTravail.Fonction.Text = myDR("Fonction").ToString
                        AjoutArretTravail.Adresse.Text = myDR("Adresse").ToString
                        AjoutArretTravail.Date_de_Naissance.Text = myDR("Date_de_Naissance").ToString
                        AjoutArretTravail.NSS.Text = myDR("Num_SS").ToString
                    End While
                End If
                'End If
                'End If
                AjoutArretTravail.ShowDialog()
            End If
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub
    Private Sub SupprimerToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles SupprimerToolStripMenuItem.Click
        Try
            Dim val1 As Integer = 0
            If GridView1.SelectedRowsCount = 0 Then
                MessageBoxEx.Show("Vous devez selectionner un Matricule avant de cliquer supprimer", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                Dim m = GridView1.GetFocusedRowCellValue("Matricule").ToString()
                Dim nature_conge = GridView1.GetFocusedRowCellValue("Nature de Congé").ToString()
                If m <> Nothing Then
                    If MessageBoxEx.Show("Vous voullez vraiment supprimer l'arrét de travail ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                        IsConnected("select idArret_de_travail from social_arret_de_travail where Matricule='" & m & "' and nature_conge='" & nature_conge & "'", False)
                        If myDR.HasRows Then
                            While myDR.Read
                                val1 = myDR("idArret_de_travail")
                            End While
                        End If
                        IsConnected("DELETE FROM social_arret_de_travail WHERE Matricule='" & m & "' and idArret_de_travail=" & val1 & " limit 1", True)
                        ' ButtonX3.PerformClick()
                        reload()
                    End If
                End If
            End If
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub

    Private Sub ButtonX4_Click(sender As System.Object, e As System.EventArgs) Handles ButtonX4.Click
        If du.Value = Nothing Or au.Value = Nothing Then
            MessageBoxEx.Show("Veuillez saisir la date!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            Dim a As Date = au.Value.ToString("dd-MM-yyyy")
            a = a.AddDays(+1)
            If ListMatNom.SelectedIndex <> -1 Then
                If sql.VerifiyConnection = True Then
                    'MessageBoxEx.Show("Vous devez sélectionner un matricule avant de cliquer ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    sql.RunQuery("SELECT idArret_de_travail as 'Numero de referance',employes.Matricule,Nom,Prénom,Date_de_Naissance as 'Date de Naissance',lieux_de_naissance as 'Lieu de Naissance',arret_du as 'Arrét du',arret_au as 'Arrét au',nb_jours as 'Nombre de jours',date_reprise as 'Date de Reprise',nature_conge as 'Nature de Congé',siege_lesion as 'Siege des liaisions',nature_lesion as 'Nature des liaisions',Observation FROM social_arret_de_travail,employes WHERE employes.Matricule = social_arret_de_travail.matricule and employes.Matricule ='" & ListMatNom.Value & "'and (social_arret_de_travail.arret_du>= '" & du.Value.ToString("dd-MM-yyyy") & "' and social_arret_de_travail.arret_du<='" & a.ToString("dd-MM-yyyy") & "')")
                End If
                If sql.SQLDS.Tables.Count > 0 Then
                    nb = sql.SQLDS.Tables(0).Rows.Count
                    arretDgv.DataSource = sql.SQLDS.Tables(0)
                End If
                LabelX3.Text = ""
                If nb = 0 Then
                    MessageBox.Show("il n'y a pas des donneés sur l'arret de travail entre les 2 Date", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    LabelX3.Text = ""
                ElseIf nb = 1 Then
                    LabelX3.Text = "Le nombre de ligne est : " & nb
                Else
                    LabelX3.Text = "Le nombre des lignes sont : " & nb
                End If
            Else
                If sql.VerifiyConnection = True Then
                    sql.RunQuery("SELECT idArret_de_travail as 'Numero de referance',employes.Matricule,Nom,Prénom,Date_de_Naissance as 'Date de Naissance',lieux_de_naissance as 'Lieu de Naissance',arret_du as 'Arrét du',arret_au as 'Arrét au',nb_jours as 'Nombre de jours',date_reprise as 'Date de Reprise',nature_conge as 'Nature de Congé',siege_lesion as 'Siege des liaisions',nature_lesion as 'Nature des liaisions',Observation FROM social_arret_de_travail,employes WHERE employes.Matricule = social_arret_de_travail.matricule and (social_arret_de_travail.arret_du>= '" & du.Value.ToString("dd-MM-yyyy") & "' and social_arret_de_travail.arret_du<='" & a.ToString("dd-MM-yyyy") & "')")
                End If
                If sql.SQLDS.Tables.Count > 0 Then
                    nb1 = sql.SQLDS.Tables(0).Rows.Count
                    arretDgv.DataSource = sql.SQLDS.Tables(0)
                End If
                If nb1 = 0 Then
                    MessageBox.Show("il n'y a pas des donneés sur l'arret de travail ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    LabelX3.Text = ""
                ElseIf nb1 = 1 Then
                    LabelX3.Text = "Le nombre de ligne est : " & nb1
                Else
                    LabelX3.Text = "Le nombre des lignes sont : " & nb1
                End If
            End If
            End If
    End Sub
    Private Sub ListMatNom_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ListMatNom.SelectedIndexChanged
        If ListMatNom.SelectedIndex = -1 Then
            MessageBoxEx.Show("Vous devez sélectionner un matricule avant de cliquer ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            reload()
            'If IsConnected("SELECT idArret_de_travail as 'Numero de referance',employes.Matricule,Nom,Prénom,Date_de_Naissance as 'Date de Naissance',lieux_de_naissance as 'Lieu de Naissance',arret_du as 'Arrét du ',arret_au as 'Arrét au',nb_jours as 'Nombre de jours',date_reprise as 'Date de Reprise',nature_conge as 'Nature de Congé',siege_lesion as 'Siege des liaisions',nature_lesion as 'Nature des liaisions',Observation FROM social_arret_de_travail,employes WHERE employes.Matricule = social_arret_de_travail.matricule and social_arret_de_travail.arret_du between '" & du.Text & "' and '" & au.Text & "'", False) = False Then
            '    MessageBoxEx.Show("Il n'y pas des données entre les 2 dates sélectionnées", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
            'ElseIf IsConnected("SELECT idArret_de_travail as 'Numero de referance',employes.Matricule,Nom,Prénom,Date_de_Naissance as 'Date de Naissance',lieux_de_naissance as 'Lieu de Naissance',arret_du as 'Arrét du ',arret_au as 'Arrét au',nb_jours as 'Nombre de jours',date_reprise as 'Date de Reprise',nature_conge as 'Nature de Congé',siege_lesion as 'Siege des liaisions',nature_lesion as 'Nature des liaisions',Observation FROM social_arret_de_travail,employes WHERE employes.Matricule = social_arret_de_travail.matricule and social_arret_de_travail.matricule= '" & ListMatNom.Value & "' and social_arret_de_travail.arret_du between '" & du.Text & "' and '" & au.Text & "'", False) = False Then
            '    MessageBoxEx.Show("Ce matricule " & ListMatNom.Value & " n'a pas des données entre les 2 dates sélectionnées", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub du_TextChanged(sender As System.Object, e As System.EventArgs) Handles du.TextChanged
        If au.Value <> Nothing Then
            load_Matricule_Nom()
        End If
    End Sub

    Private Sub au_TextChanged(sender As System.Object, e As System.EventArgs) Handles au.TextChanged
        If du.Value <> Nothing Then
            load_Matricule_Nom()
        End If
    End Sub
End Class