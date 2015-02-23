Imports DevExpress.XtraEditors.Controls
Public Class FicheSocialeFrm
    Private Sub ButtonX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX1.Click
        Try
            If ListMatNom.SelectedIndex = -1 Then
                MessageBox.Show("Vous devez sélectionner un matricule avant de cliquer ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                If ListMatNom.Value.ToString.Length = 5 And IsNumeric(ListMatNom.Value) Then
                    Dim ds1 As ArretTravailDS = New ArretTravailDS
                    Dim titre As String = ""
                    ds1.EnforceConstraints = False
                    Try
                        'Attempt to fill the dataset MainTable
                        ds1.FicheSocial.Clear()
                        IsConnected("SELECT employes.Matricule,nom,prénom,fonction,Date_de_Naissance,Lieux_de_Naissance,Adresse,Date_entrée,code_papers.Num_SS,Direction FROM employes LEFT JOIN code_papers ON employes.Matricule = code_papers.Matricule WHERE employes.Matricule ='" & ListMatNom.Value & "'", False)
                        If myDR.HasRows Then
                            While myDR.Read
                                titre = "Fiche sociale de " & myDR("nom") & " " & myDR("prénom")
                                ds1.FicheSocial.AddFicheSocialRow(IIf(IsDBNull(myDR("Matricule")), "", myDR("Matricule")), IIf(IsDBNull(myDR("nom")), "", myDR("nom")), IIf(IsDBNull(myDR("prénom")), "", myDR("prénom")), IIf(IsDBNull(myDR("fonction")), "", myDR("fonction")), IIf(IsDBNull(myDR("Date_de_Naissance")), "", myDR("Date_de_Naissance")), IIf(IsDBNull(myDR("Lieux_de_Naissance")), "", myDR("Lieux_de_Naissance")), IIf(IsDBNull(myDR("Adresse")), "", myDR("Adresse")), IIf(IsDBNull(myDR("Date_entrée")), "", myDR("Date_entrée")), IIf(IsDBNull(myDR("Num_SS")), "", myDR("Num_SS")), IIf(IsDBNull(myDR("Direction")), "", myDR("Direction")))
                            End While
                        End If
                    Catch ex As Exception
                        EnvoiError(ex.Message)
                    Finally
                        ds1.EnforceConstraints = True
                    End Try

                    Dim cr As New FicheSocial()
                    cr.XrLabel21.Text = titre.ToString
                    cr.DataSource = ds1
                    DocumentViewer1.DocumentSource = cr
                    cr.CreateDocument(True)
                End If
            End If
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub
#Region "reload"
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
    Private Sub FicheSocialeFrm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        load_Matricule_Nom()
    End Sub
End Class