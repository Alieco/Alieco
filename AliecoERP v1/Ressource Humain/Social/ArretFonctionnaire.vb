Imports DevExpress.XtraEditors.Controls

Public Class ArretFonctionnaire
    Private Sub ButtonX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Afficher.Click
        Try
            Dim ds1 As ArretTravailDS = New ArretTravailDS
            Dim titre As String = ""
            ds1.EnforceConstraints = False
            Try
                ' Attempt to fill the dataset MainTable
                ds1.Arret.Clear()
                IsConnected("SELECT idArret_de_travail,arret_du,arret_au,date_reprise,nature_conge,siege_lesion,nature_lesion,observation,matricule FROM social_arret_de_travail WHERE Matricule= '" & ListMatNom.Value & "'", False)
                If myDR.HasRows Then

                    While myDR.Read
                        ' titre = "Table comparative de " & myDR("Titre_formation")
                        ds1.Arret.AddArretRow(IIf(IsDBNull(myDR("idArret_de_travail")), "", myDR("idArret_de_travail")), IIf(IsDBNull(myDR("arret_du")), "", myDR("arret_du")), IIf(IsDBNull(myDR("arret_au")), "", myDR("arret_au")), IIf(IsDBNull(myDR("date_reprise")), "", myDR("date_reprise")), IIf(IsDBNull(myDR("nature_conge")), "", myDR("nature_conge")), IIf(IsDBNull(myDR("siege_lesion")), "", myDR("siege_lesion")), IIf(IsDBNull(myDR("nature_lesion")), "", myDR("nature_lesion")), IIf(IsDBNull(myDR("observation")), "", myDR("observation")), IIf(IsDBNull(myDR("matricule")), "", myDR("matricule")))
                    End While
                End If
                'Attempt to fill the dataset MainTable
                ds1.FicheSocial.Clear()
                IsConnected("SELECT DISTINCT employes.Matricule,nom,prénom,fonction,Date_de_Naissance,Lieux_de_Naissance,Adresse,Date_entrée,code_papers.Num_SS,Direction FROM employes left join code_papers on code_papers.matricule = employes.matricule  WHERE employes.matricule= '" & ListMatNom.Value & "'", False)
                If myDR.HasRows Then
                    While myDR.Read
                        titre = "Rapport des arréts de travail de " & myDR("nom") & " " & myDR("prénom")
                        ds1.FicheSocial.AddFicheSocialRow(IIf(IsDBNull(myDR("Matricule")), "", myDR("Matricule")), IIf(IsDBNull(myDR("nom")), "", myDR("nom")), IIf(IsDBNull(myDR("prénom")), "", myDR("prénom")), IIf(IsDBNull(myDR("fonction")), "", myDR("fonction")), IIf(IsDBNull(myDR("Date_de_Naissance")), "", myDR("Date_de_Naissance")), IIf(IsDBNull(myDR("Lieux_de_Naissance")), "", myDR("Lieux_de_Naissance")), IIf(IsDBNull(myDR("Adresse")), "", myDR("Adresse")), IIf(IsDBNull(myDR("Date_entrée")), "", myDR("Date_entrée")), IIf(IsDBNull(myDR("Num_SS")), "", myDR("Num_SS")), IIf(IsDBNull(myDR("Direction")), "", myDR("Direction")))
                    End While
                End If
            Catch ex As Exception
                EnvoiError(ex.Message)
            Finally
                ds1.EnforceConstraints = True
            End Try
            Dim cr As New ArretTravailRP()
            cr.XrLabel21.Text = titre.ToString
            cr.DataSource = ds1
            DocumentViewer1.DocumentSource = cr
            cr.CreateDocument(True)
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub
#Region "Fonctions"
    Private Sub load_Matricule_Nom()
        ListMatNom.Properties.Items.Clear()
        IsConnected("SELECT DISTINCT employes.Matricule,employes.Nom,employes.Prénom FROM employes,social_arret_de_travail where employes.Matricule = social_arret_de_travail.matricule ", False)
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
        Afficher.Enabled = True
        If ListMatNom.Value = Nothing Then
            MessageBox.Show("Vous devez sélectionner un arrét de travail avant de cliquer ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Afficher.Enabled = False
        Else
            Afficher.Enabled = True
        End If
    End Sub
    Private Sub ArretFonctionnaire_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        load_Matricule_Nom()
        Afficher.Enabled = False
    End Sub
End Class