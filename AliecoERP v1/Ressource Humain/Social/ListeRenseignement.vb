Imports DevExpress.XtraEditors.Controls

Public Class ListeRenseignement
#Region "Fonctions"
    Private Sub load_Matricule_Nom()
        ListMatNom.Properties.Items.Clear()
        IsConnected("SELECT DISTINCT employes.Matricule,employes.Nom,employes.Prénom FROM employes,socialeconjoint where employes.Matricule = socialeconjoint.matricule ", False)
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
    End Sub
    Private Sub ListeRenseignement_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        load_Matricule_Nom()
        Afficher.Enabled = False
    End Sub

    Private Sub Afficher_Click(sender As System.Object, e As System.EventArgs) Handles Afficher.Click
        Try
            If ListMatNom.Value = Nothing Then
                MessageBox.Show("Vous devez sélectionner un matricule avant de cliquer ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                Dim ds1 As FicheRenseignementDS1 = New FicheRenseignementDS1
                Dim titre As String = ""
                ds1.EnforceConstraints = False
                Try
                    ds1.FichRenseig.Clear()
                    ds1.socialeconjoint.Clear()
                    ds1.socialenf.Clear()
                    IsConnected("SELECT  distinct Employes.Matricule,NomConj,PrenomConj,DateNaisConj,DateMariage from Employes LEFT JOIN socialeconjoint on Employes.Matricule=socialeconjoint.Matricule where Employes.Matricule= '" & ListMatNom.Value & "' ", False)
                    If myDR.HasRows Then
                        While myDR.Read
                            ds1.socialeconjoint.AddsocialeconjointRow(IIf(IsDBNull(myDR("Matricule")), "", CDbl(myDR("Matricule"))), IIf(IsDBNull(myDR("NomConj")), "", myDR("NomConj")), IIf(IsDBNull(myDR("PrenomConj")), "", myDR("PrenomConj")), IIf(IsDBNull(myDR("DateNaisConj")), "", myDR("DateNaisConj")), IIf(IsDBNull(myDR("DateMariage")), "", myDR("DateMariage")))
                        End While
                    End If
                    IsConnected("SELECT distinct PrenomEnfant,Matricule,DateNaisEnfant,ObsEnf from socialenf where Matricule= '" & ListMatNom.Value & "'", False)
                    If myDR.HasRows Then
                        While myDR.Read
                            ds1.socialenf.AddsocialenfRow(IIf(IsDBNull(myDR("Matricule")), "", CDbl(myDR("Matricule"))), IIf(IsDBNull(myDR("PrenomEnfant")), "", myDR("PrenomEnfant")), IIf(IsDBNull(myDR("DateNaisEnfant")), "", myDR("DateNaisEnfant")), IIf(IsDBNull(myDR("ObsEnf")), "", myDR("ObsEnf")))
                        End While
                    End If
                    IsConnected("select distinct Employes.Matricule,Nom,Prénom,Date_de_Naissance,Lieux_de_Naissance,Adresse,Fonction,Date_entrée,S_B_01_14,code_papers.Num_SS FROM Employes left join code_papers on Employes.Matricule=code_papers.Matricule WHERE Employes.Matricule= '" & ListMatNom.Value & "'", False)
                    If myDR.HasRows Then
                        While myDR.Read
                            titre = "Fiche de Renseignement  " & myDR("Nom") & " " & myDR("Prénom")
                            ds1.FichRenseig.AddFichRenseigRow(IIf(IsDBNull(myDR("Matricule")), "", CDbl(myDR("Matricule"))), IIf(IsDBNull(myDR("Nom")), "", myDR("Nom")), IIf(IsDBNull(myDR("Prénom")), "", myDR("Prénom")), IIf(IsDBNull(myDR("Date_de_Naissance")), "", myDR("Date_de_Naissance")), IIf(IsDBNull(myDR("Lieux_de_Naissance")), "", myDR("Lieux_de_Naissance")), IIf(IsDBNull(myDR("Adresse")), "", myDR("Adresse")), IIf(IsDBNull(myDR("Fonction")), "", myDR("Fonction")), IIf(IsDBNull(myDR("Date_entrée")), "", myDR("Date_entrée")), IIf(IsDBNull(myDR("S_B_01_14")), "", myDR("S_B_01_14")), IIf(IsDBNull(myDR("Num_SS")), "", myDR("Num_SS")))
                        End While
                    End If
                Catch ex As Exception
                    EnvoiError(ex.Message)
                Finally
                    ds1.EnforceConstraints = True
                End Try
                Dim cr As New FichRenseignamentRP()
                cr.XrLabel4.Text = titre.ToString
                cr.DataSource = ds1
                DocumentViewer1.DocumentSource = cr
                cr.CreateDocument(True)
            End If
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub
End Class