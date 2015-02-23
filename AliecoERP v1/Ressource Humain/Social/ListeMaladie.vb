Imports DevExpress.XtraEditors.Controls
Public Class ListeMaladie
#Region "Fonctions"
    Private Sub load_Matricule_Nom()
        ListMatNom.Properties.Items.Clear()
        IsConnected("SELECT DISTINCT employes.Matricule,employes.Nom,employes.Prénom FROM employes,social_dossier_maladie where employes.Matricule = social_dossier_maladie.matricule ", False)
        If myDR.HasRows Then
            While myDR.Read
                ListMatNom.Properties.Items.Add(New ImageComboBoxItem(myDR("Matricule").ToString & " - " & myDR("Nom").ToString & " " & myDR("Prénom").ToString, myDR("Matricule").ToString, 4))
            End While
            ListMatNom.Properties.SmallImages = StatImageList
            ListMatNom.Properties.LargeImages = StatImageList
        End If
    End Sub
#End Region
    Private Sub ListeMaladie_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        load_Matricule_Nom()
        Afficher.Enabled = False
    End Sub

    Private Sub ListMatNom_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ListMatNom.SelectedIndexChanged
        Afficher.Enabled = True
    End Sub
    Private Sub Afficher_Click(sender As System.Object, e As System.EventArgs) Handles Afficher.Click
        Try
            Dim ds1 As Dossier_Maladie = New Dossier_Maladie
            Dim titre As String = ""
            ds1.EnforceConstraints = False
            Try
                ' Attempt to fill the dataset MainTable
                ds1.Dossier_malad.Clear()
                ds1.FicheSocial.Clear()
                IsConnected("SELECT Matricule,medecin,date_soin,date_envoi,B,prenom_malade,montant, montant_consultation, observation FROM social_dossier_maladie WHERE Matricule= '" & ListMatNom.Value & "'", False)
                If myDR.HasRows Then
                    While myDR.Read
                        ds1.Dossier_malad.AddDossier_maladRow(IIf(IsDBNull(myDR("Matricule")), "", CDbl(myDR("Matricule"))), IIf(IsDBNull(myDR("date_soin")), "", myDR("date_soin")), IIf(IsDBNull(myDR("date_envoi")), "", myDR("date_envoi")), IIf(IsDBNull(myDR("B")), "", myDR("B")), IIf(IsDBNull(myDR("prenom_malade")), "", myDR("prenom_malade")), IIf(IsDBNull(myDR("montant")), "", myDR("montant")), IIf(IsDBNull(myDR("montant_consultation")), "", myDR("montant_consultation")), IIf(IsDBNull(myDR("Observation")), "", myDR("Observation")), IIf(IsDBNull(myDR("medecin")), "", myDR("medecin")))
                    End While
                End If
                IsConnected("SELECT DISTINCT employes.Matricule,nom,prénom,fonction,Date_de_Naissance,Lieux_de_Naissance,Adresse,Date_entrée,code_papers.Num_SS,Direction FROM employes left join code_papers on employes.matricule = code_papers.matricule WHERE employes.Matricule= '" & ListMatNom.Value & "'", False)
                If myDR.HasRows Then
                    While myDR.Read
                        titre = "DOSSIER DE MALADIE : " & myDR("Nom") & " " & myDR("Prénom")
                        ds1.FicheSocial.AddFicheSocialRow(IIf(IsDBNull(myDR("Matricule")), "", CDbl(myDR("Matricule"))), IIf(IsDBNull(myDR("Nom")), "", myDR("Nom")), IIf(IsDBNull(myDR("Prénom")), "", myDR("Prénom")), IIf(IsDBNull(myDR("Fonction")), "", myDR("Fonction")), IIf(IsDBNull(myDR("Date_de_Naissance")), "", myDR("Date_de_Naissance")), IIf(IsDBNull(myDR("Lieux_de_Naissance")), "", myDR("Lieux_de_Naissance")), IIf(IsDBNull(myDR("Adresse")), "", myDR("Adresse")), IIf(IsDBNull(myDR("Date_entrée")), "", myDR("Date_entrée")), IIf(IsDBNull(myDR("Num_SS")), "", myDR("Num_SS")), IIf(IsDBNull(myDR("direction")), "", myDR("direction")))
                    End While
                End If

            Catch ex As Exception
                EnvoiError(ex.Message)
            Finally
                ds1.EnforceConstraints = True
            End Try
            Dim cr As New DossierMaladie()
            cr.XrLabel1.Text = titre.ToString
            cr.DataSource = ds1
            DocumentViewer1.DocumentSource = cr
            cr.CreateDocument(True)
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub
End Class