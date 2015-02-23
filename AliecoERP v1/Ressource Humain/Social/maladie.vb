Imports DevComponents.DotNetBar
Imports DevExpress.XtraEditors.Controls

Public Class maladie
    Dim sql As New SQLControl
    Dim val As Integer = 0
#Region "Fonctions"
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
    Sub reload()
        Try
            If sql.VerifiyConnection = True Then
                sql.RunQuery("SELECT distinct Employes.Matricule,Nom,Prénom,medecin,date_soin,date_envoi,B,prenom_malade,montant, montant_consultation, observation FROM Employes,social_dossier_maladie WHERE social_dossier_maladie.Matricule=Employes.Matricule ")
                If sql.SQLDS.Tables.Count > 0 Then
                    maladiedgv.DataSource = sql.SQLDS.Tables(0)
                End If
            End If
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub
#End Region
    Private Sub Ajouter_Click(sender As System.Object, e As System.EventArgs) Handles Ajouter.Click
        Try
            If ListMatNom.SelectedIndex = -1 Then
                MessageBox.Show("Vous devez sélectionner un matricule avant de cliquer ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                Dim q As String = ""
                If Ajouter.Text = "Ajouter" Then
                    If DateTimeInput1.Value = Nothing Then
                        MessageBoxEx.Show("Vous avez laissé le champ date soin vide !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Sub
                    End If
                    If prenomMalade.Text = "" Then
                        MessageBoxEx.Show("Vous avez laissé le champ Prénom Malade  vide !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Sub
                    End If
                    q = "INSERT INTO social_dossier_maladie (Matricule,medecin,date_soin,date_envoi,B,prenom_malade,montant, montant_consultation, observation,DateEnregist)values ('" & ListMatNom.Value & "', '" & mysql_escape_string(medecin.Text) & "', '" & DateTimeInput1.Value.ToString("dd-MM-yyyy") & "','" & DateTimeInput2.Value.ToString("dd-MM-yyyy") & "','" & mysql_escape_string(b.Text) & "','" & mysql_escape_string(prenomMalade.Text) & "', '" & montant.Text & "', '" & montant_consult.Text & "', '" & mysql_escape_string(observation.Text) & "',now())"
                    If IsConnected(q, False) Then
                        MessageBoxEx.Show("L'ajout a été enregistrer dans le dossier du fonctionnaire", "Succés", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        nom.Text = ""
                        prenom.Text = ""
                        Lieux_de_Naissance.Text = ""
                        Date_entrée.Text = ""
                        Fonction.Text = ""
                        Adresse.Text = ""
                        Date_de_Naissance.Text = ""
                        sb.Text = ""
                        NSS.Text = ""
                        ListMatNom.Value = Nothing
                        medecin.Text = ""
                        DateTimeInput1.Value = Nothing
                        DateTimeInput2.Value = Nothing
                        b.Text = ""
                        prenomMalade.Text = ""
                        montant.Text = ""
                        montant_consult.Text = ""
                        observation.Text = ""
                        reload()
                    End If
                Else
                    q = "UPDATE social_dossier_maladie SET medecin ='" & mysql_escape_string(medecin.Text) & "',date_soin = '" & DateTimeInput1.Value.ToString("dd-MM-yyyy") & "',date_envoi = '" & DateTimeInput2.Value.ToString("dd-MM-yyyy") & "',B='" & mysql_escape_string(b.Text) & "',Prenom_malade='" & mysql_escape_string(prenomMalade.Text) & "',Montant='" & mysql_escape_string(montant.Text) & "',montant_consultation='" & mysql_escape_string(montant_consult.Text) & "',observation='" & mysql_escape_string(observation.Text) & "',DateEnregist=Now() WHERE idsocial_dossier_maladie = '" & val & "' limit 1"
                    If IsConnected(q, False) Then
                        MessageBoxEx.Show("L'ajout a été modifier dans le dossier du fonctionnaire", "Succés", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        nom.Text = ""
                        prenom.Text = ""
                        Lieux_de_Naissance.Text = ""
                        Date_entrée.Text = ""
                        Fonction.Text = ""
                        Adresse.Text = ""
                        Date_de_Naissance.Text = ""
                        sb.Text = ""
                        NSS.Text = ""
                        ListMatNom.Value = Nothing
                        medecin.Text = ""
                        DateTimeInput1.Value = Nothing
                        DateTimeInput2.Value = Nothing
                        b.Text = ""
                        prenomMalade.Text = ""
                        montant.Text = ""
                        montant_consult.Text = ""
                        observation.Text = ""
                        Ajouter.Text = "Ajouter"
                        Ajouter.Image = My.Resources.add_button
                        reload()
                    End If
                End If
            End If
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub
    Private Sub ListMatNom_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ListMatNom.SelectedIndexChanged
        Try
            If ListMatNom.Value.ToString.Length = 5 Then
                IsConnected("SELECT distinct Employes.Matricule,Nom,Prénom,Lieux_de_Naissance,Date_entrée,Fonction,Adresse,Date_de_Naissance,S_B_01_14,code_papers.Num_SS FROM Employes LEFT JOIN code_papers ON code_papers.Matricule=Employes.Matricule WHERE Employes.Matricule='" & ListMatNom.Value & "'", False)
                If myDR.HasRows = True Then
                    While (myDR.Read)
                        Try
                            nom.Text = myDR("Nom").ToString
                            prenom.Text = myDR("Prénom").ToString
                            Lieux_de_Naissance.Text = myDR("Lieux_de_Naissance").ToString
                            Date_entrée.Text = myDR("Date_entrée").ToString
                            Fonction.Text = myDR("Fonction").ToString
                            Adresse.Text = myDR("Adresse").ToString
                            Date_de_Naissance.Text = myDR("Date_de_Naissance").ToString
                            sb.Text = myDR("S_B_01_14").ToString
                            NSS.Text = myDR("Num_SS").ToString
                        Catch ex As Exception
                            EnvoiError(ex.Message)
                        End Try
                    End While
                End If
            End If
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub

    Private Sub ActualiserToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ActualiserToolStripMenuItem.Click
        reload()
    End Sub

    Private Sub maladie_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        load_Matricule_Nom()
        reload()
    End Sub

    Private Sub SupprimerToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles SupprimerToolStripMenuItem.Click
        Try
            Dim val1 As Integer = 0
            If GridView1.SelectedRowsCount = 0 Then
                MessageBoxEx.Show("Vous devez selectionner une maladie avant de cliquer supprimer", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                Dim m = GridView1.GetFocusedRowCellValue("Matricule").ToString()
                Dim datesoin = GridView1.GetFocusedRowCellValue("date_soin").ToString()
                If m <> Nothing Then
                    If MessageBoxEx.Show("Vous voullez vraiment supprimer cette maladie ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                        IsConnected("select idsocial_dossier_maladie from social_dossier_maladie where Matricule='" & m & "' and date_soin='" & datesoin & "'", False)
                        If myDR.HasRows Then
                            While myDR.Read
                                val1 = myDR("idsocial_dossier_maladie")
                            End While
                        End If
                        IsConnected("DELETE FROM social_dossier_maladie WHERE Matricule='" & m & "' and idsocial_dossier_maladie=" & val1 & " limit 1", True)
                        ' ButtonX3.PerformClick()
                        reload()
                    End If
                End If
            End If
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub

    Private Sub ModifierToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ModifierToolStripMenuItem.Click
        Try
            If GridView1.SelectedRowsCount = 0 Then
                MessageBoxEx.Show("Vous devez selectionner un matricule avant de cliquer modifier", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                ListMatNom.Value = GridView1.GetFocusedRowCellValue("Matricule").ToString()
                medecin.Text = GridView1.GetFocusedRowCellValue("medecin").ToString()
                prenomMalade.Text = GridView1.GetFocusedRowCellValue("prenom_malade").ToString()
                montant.Text = GridView1.GetFocusedRowCellValue("montant").ToString()
                montant_consult.Text = GridView1.GetFocusedRowCellValue("montant_consultation").ToString()
                observation.Text = GridView1.GetFocusedRowCellValue("observation").ToString()
                DateTimeInput1.Value = GridView1.GetFocusedRowCellValue("date_soin").ToString()
                DateTimeInput2.Value = GridView1.GetFocusedRowCellValue("date_envoi").ToString()
                b.Text = GridView1.GetFocusedRowCellValue("B").ToString()
                ' Me.Text = "Modifier " &
                Ajouter.Text = "Modifier "
                Ajouter.Image = My.Resources.edit
                If ListMatNom.Value <> Nothing Then
                    IsConnected("SELECT idsocial_dossier_maladie FROM social_dossier_maladie WHERE Matricule='" & ListMatNom.Value & "' and date_soin='" & DateTimeInput1.Value.ToString("dd-MM-yyyy") & "'", False)
                    If myDR.HasRows = True Then
                        While (myDR.Read)
                            val = myDR("idsocial_dossier_maladie").ToString
                        End While
                    End If
                End If
            End If
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub
End Class