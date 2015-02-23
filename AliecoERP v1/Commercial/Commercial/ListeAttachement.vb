Imports DevComponents.DotNetBar

Public Class ListeAttachement
    Dim sql As New SQLControl
    Dim nbDGA
    Dim nbDGS
    Dim dateAu As Date
    Private Sub ExporterButtonX1_Click(sender As Object, e As EventArgs) Handles ExporterButtonX1.Click
        Try
            Dim s As New SaveFileDialog
            s.DefaultExt = "*.xlsx"
            s.Title = "Choisisez le nom de fichier d'enregistrement"
            s.Filter = "Excel 2010 | *.xlsx"
            If s.ShowDialog = Windows.Forms.DialogResult.OK Then
                AttachementDG.ExportToXlsx(s.FileName)
            End If
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub

    Private Sub AfficherButtonX2_Click(sender As Object, e As EventArgs) Handles AfficherButtonX2.Click
        If CodeAffComboBoxEx1.Text = "" Or du.Value = Nothing Or au.Value = Nothing Then
            MessageBoxEx.Show("Veuillez remplir les champs vide ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            dateAu = au.Value
            dateAu = dateAu.AddDays(+1)
            If au.Value > du.Value Then
                If Me.Text = "Liste des attachements" Then
                    Load_List_Attachement()
                    'IsConnected("SELECT count(idCommercial_Attachement) as nb FROM commercial_attachement WHERE code_affaire='" & CodeAffComboBoxEx1.Text & "' and  ", False)
                    TitreLabelX4.Text = "Attachetement des travaux de l'affaire " & CodeAffComboBoxEx1.Text & " contient " & nbDGA & " ligne(s)"
                Else
                    Load_List_Situation()
                    TitreLabelX4.Text = "Situation des travaux " & CodeAffComboBoxEx1.Text & " contient " & nbDGS & " ligne(s)"
                End If
            Else
                MessageBoxEx.Show("Veuillez saisir une date correcte ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub
    Private Sub Load_List_Attachement()
        AttachementDG.DataSource = Nothing
        If sql.VerifiyConnection = True Then
            sql.RunQuery("SELECT commercial_attachement.code_affaire as 'Code affaire',num as 'N°', desig as 'Désignations', unite as 'Unité', Qt as 'Qte prévues', Qt_Precedente as 'Qte Précédente', Qt_Mois as 'Qte du Mois', Qt_Cumul as 'Qte cumulées',DateEnregistrement, idCommercial_Attachement as 'Code' FROM commercial_affaire_bordereauprix, commercial_attachement WHERE commercial_affaire_bordereauprix.idBordereauPrix=commercial_attachement.idBordereauPrix and DateEnregistrement between '" & du.Value.ToString("yyyy-MM-dd") & "' and '" & dateAu.ToString("yyyy-MM-dd") & "' and commercial_attachement.code_affaire='" & CodeAffComboBoxEx1.Text & "' ")
            If sql.SQLDS.Tables.Count > 0 Then
                nbDGA = sql.SQLDS.Tables(0).Rows.Count
                AttachementDG.DataSource = sql.SQLDS.Tables(0)
            End If
        End If

    End Sub
    Private Sub Load_List_Situation()
        AttachementDG.DataSource = Nothing
        If sql.VerifiyConnection = True Then
             sql.RunQuery("SELECT commercial_attachement.code_affaire as 'Code affaire',num as 'N°', desig as 'Désignations', unite as 'Unité', Qt as 'Qte prévues', Qt_Precedente as 'Qte Précédente', Qt_Mois as 'Qte du Mois', Qt_Cumul as 'Qte cumulées',PrixUnit as 'Prix Unitaire' ,Montant_Mois as 'Montant du mois',Observation ,DateEnregistrementSituation, idCommercial_Attachement as 'Code' FROM commercial_affaire_bordereauprix, commercial_attachement WHERE commercial_affaire_bordereauprix.idBordereauPrix=commercial_attachement.idBordereauPrix and DateEnregistrement between '" & du.Value.ToString("yyyy-MM-dd") & "' and '" & dateAu.ToString("yyyy-MM-dd") & "' and commercial_attachement.code_affaire='" & CodeAffComboBoxEx1.Text & "' ")
            If sql.SQLDS.Tables.Count > 0 Then
                nbDGS = sql.SQLDS.Tables(0).Rows.Count
                AttachementDG.DataSource = sql.SQLDS.Tables(0)
            End If
        End If
    End Sub

    Private Sub SupprimerLattachementToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SupprimerLattachementToolStripMenuItem.Click
        Try
            If Me.Text = "Liste des attachements" Then
                If GridView1.SelectedRowsCount = 0 Then
                    MessageBoxEx.Show("Vous devez selectionner une affaire avant de cliquer supprimer", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    Dim m = GridView1.GetFocusedRowCellValue("Code").ToString()
                    If m <> Nothing Then
                        If MessageBoxEx.Show("Vous voullez vraiment supprimer l'attachement ?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                            IsConnected("Delete from commercial_attachement WHERE idCommercial_Attachement =" & m & " limit 1", True)
                            Load_List_Attachement()
                        End If
                    End If
                End If
            Else
                If GridView1.SelectedRowsCount = 0 Then
                    MessageBoxEx.Show("Vous devez selectionner une situation avant de cliquer supprimer", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    Dim m = GridView1.GetFocusedRowCellValue("Code").ToString()
                    If m <> Nothing Then
                        If MessageBoxEx.Show("Vous voullez vraiment supprimer l'attachement ?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                            IsConnected("Delete from commercial_attachement WHERE idCommercial_Attachement =" & m & " limit 1", True)
                            Load_List_Situation()
                        End If
                    End If
                End If
            End If
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub

    Private Sub ModifierLAttachementToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Try
            If Me.Text = "Liste des attachements" Then
                If GridView1.SelectedRowsCount = 0 Then
                    MessageBoxEx.Show("Vous devez selectionner un attachement avant de cliquer modifier", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    Attachement.Text = "Modification de l'attachement "
                    Attachement.EnregistrerButtonX1.Text = "Engeristrer les modifications"
                    Attachement.code = GridView1.GetFocusedRowCellValue("Code").ToString()
                    Attachement.CodeAffaireComboBoxEx1.Text = CodeAffComboBoxEx1.Text
                    Attachement.DesignationComboBoxEx2.Text = GridView1.GetFocusedRowCellValue("Désignations").ToString()
                    Attachement.QtCumulLabelX9.Text = GridView1.GetFocusedRowCellValue("Qte cumulées").ToString()
                    Attachement.QtPrecedenteLabelX5.Text = GridView1.GetFocusedRowCellValue("Qte Précédente").ToString()
                    Attachement.QtPrevueLabelX6.Text = GridView1.GetFocusedRowCellValue("Qte prévues").ToString()
                    Attachement.UnitéComboBoxEx3.Text = GridView1.GetFocusedRowCellValue("Unité").ToString()
                    Attachement.qt.Text = GridView1.GetFocusedRowCellValue("Qte du Mois").ToString()
                    Attachement.MdiParent = Mainfrm
                    Attachement.Show()
                End If
            Else
                If GridView1.SelectedRowsCount = 0 Then
                    MessageBoxEx.Show("Vous devez selectionner une offre avant de cliquer modifier", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    Situation.Text = "Modification de la situation "
                    Situation.EnregistrerButtonX1.Text = "Engeristrer les modifications"
                    Situation.codeS = GridView1.GetFocusedRowCellValue("Code").ToString()
                    Situation.CodeAffaireComboBoxEx1.Text = CodeAffComboBoxEx1.Text
                    Situation.DesignationComboBoxEx2.Text = GridView1.GetFocusedRowCellValue("Désignations").ToString()
                    Situation.PrixUnitaireLabelX6.Text = GridView1.GetFocusedRowCellValue("Prix Unitaire").ToString()
                    Situation.MontantMoisLabelX7.Text = GridView1.GetFocusedRowCellValue("Montant du mois").ToString()
                    Situation.QtPrevueLabelX6.Text = GridView1.GetFocusedRowCellValue("Qte prévues").ToString()
                    Situation.ObservationTextBoxX1.Text = GridView1.GetFocusedRowCellValue("Observation").ToString()
                    Situation.MdiParent = Mainfrm
                    Situation.Show()
                End If
            End If
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub
    Private Sub load_Affaire()
        IsConnected("SELECT distinct code_affaire FROM commercial_affaire", False)
        If myDR.HasRows Then
            CodeAffComboBoxEx1.Items.Clear()
            While myDR.Read
                CodeAffComboBoxEx1.Items.Add(myDR("code_affaire").ToString)
            End While
        End If
    End Sub

    Private Sub ListeAttachement_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Dim a As Date = Date.Now.Date
        'a = a.AddDays(+1)
        au.Value = Date.Now.Date
        Dim d As Date = Date.Today
        d = d.AddDays(-30)
        du.Value = d
        If Me.Text = "Liste des attachements" Then
            AjouterUnAttachementToolStripMenuItem.Text = "Ajouter un Attachement"
            'ModifierLAttachementToolStripMenuItem.Text = "Modifier l'Attachement"
            SupprimerLattachementToolStripMenuItem.Text = "Supprimer l'attachement"
        Else
            AjouterUnAttachementToolStripMenuItem.Text = "Ajouter une situation"
            'ModifierLAttachementToolStripMenuItem.Text = "Modifier la situation"
            SupprimerLattachementToolStripMenuItem.Text = "Supprimer la situation"
        End If
        load_Affaire()
    End Sub

    Private Sub AjouterUnAttachementToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AjouterUnAttachementToolStripMenuItem.Click
        If Me.Text = "Liste des attachements" Then
            Attachement.MdiParent = Mainfrm
            Attachement.Show()
        Else
            Situation.MdiParent = Mainfrm
            Situation.Show()
        End If
    End Sub
End Class