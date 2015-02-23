Imports DevExpress.XtraReports.UI
Imports DevExpress.XtraEditors.Controls
Imports DevComponents.DotNetBar
Public Class ATS
    Private Sub ButtonX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX1.Click
        Try
            If ListMatNom.SelectedIndex = -1 Then
                MessageBoxEx.Show("Vous devez sélectionner un matricule avant de cliquer ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                Dim ds1 As ATSDS = New ATSDS
                ' If du.Text > au.Text Then
                If ListMatNom.Value <> Nothing And du.Text <> "" And au.Text <> "" Then
                    ds1.EnforceConstraints = False
                    Try
                        'Attempt to fill the dataset MainTable
                        ds1.EmploiyeATSDT.Clear()
                        If IsConnected("SELECT distinct employes.Matricule,nom,prénom,Date_de_Naissance,Lieux_de_Naissance,Adresse,fonction,code_papers.Num_SS FROM employes left join code_papers on employes.Matricule=code_papers.Matricule where employes.matricule='" & ListMatNom.Value & "'", False) Then
                            If myDR.HasRows Then
                                While myDR.Read
                                    ds1.EmploiyeATSDT.AddEmploiyeATSDTRow(IIf(IsDBNull(myDR("Matricule")), "", myDR("Matricule")), IIf(IsDBNull(myDR("nom")), "", myDR("nom")), IIf(IsDBNull(myDR("prénom")), "", myDR("prénom")), IIf(IsDBNull(myDR("Date_de_Naissance")), "", myDR("Date_de_Naissance")), IIf(IsDBNull(myDR("Lieux_de_Naissance")), "", myDR("Lieux_de_Naissance")), IIf(IsDBNull(myDR("Adresse")), "", myDR("Adresse")), IIf(IsDBNull(myDR("fonction")), "", myDR("fonction")), IIf(IsDBNull(myDR("Num_SS")), "", myDR("Num_SS")))
                                End While
                            End If
                        End If
                        ds1.ATSDT.Clear()
                        If IsConnected("select  distinct b.moi_annee,a.nombre, b.cotise, b.Matricule,b.net_payer FROM (select nombre,moi_annee FROM paie_mensuel WHERE paie_mensuel.type='P' and paie_mensuel.code='150' and paie_mensuel.Matricule= '" & ListMatNom.Value & "' and STR_TO_DATE(paie_mensuel.moi_annee, '%m%Y')>= STR_TO_DATE('" & du.Text & "','%m%Y') and STR_TO_DATE(paie_mensuel.moi_annee, '%m%Y')<= STR_TO_DATE('" & au.Text & "', '%m%Y') group by moi_annee) a,(SELECT distinct paie_mensuel.moi_annee, Matricule,net_payer, sum(soumis_Impots) as cotise FROM paie_mensuel WHERE paie_mensuel.type='P' and (paie_mensuel.code='561' or paie_mensuel.code='564' or paie_mensuel.code='610') and paie_mensuel.matricule= '" & ListMatNom.Value & "' and  STR_TO_DATE(paie_mensuel.moi_annee, '%m%Y')>= STR_TO_DATE('" & du.Text & "','%m%Y') and STR_TO_DATE(paie_mensuel.moi_annee, '%m%Y')<= STR_TO_DATE('" & au.Text & "', '%m%Y') group by moi_annee) b where a.moi_annee=b.moi_annee order by STR_TO_DATE(b.moi_annee, '%m%Y') asc", False) Then
                            If myDR.HasRows Then
                                While myDR.Read
                                    ds1.ATSDT.AddATSDTRow(IIf(IsDBNull(myDR("Matricule")), "", myDR("Matricule")), IIf(IsDBNull(myDR("moi_annee")), "", myDR("moi_annee")), IIf(IsDBNull(myDR("nombre")), "", myDR("nombre")), IIf(IsDBNull(myDR("cotise")), "", myDR("cotise")), IIf(IsDBNull(myDR("net_payer")), "", myDR("net_payer")))
                                End While
                            End If
                        End If
                        Dim q = "INSERT INTO social_ats_historique (idsocial_ats_historique,Matricule,DateEntree)VALUES(null,'" & ListMatNom.Value & "',now())"
                        IsConnected(q, True)
                    Catch ex As Exception
                        EnvoiError(ex.Message)
                    Finally
                        ds1.EnforceConstraints = True
                    End Try
                Else
                    MessageBox.Show("Vous avais laisse les champs vide !", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Hand)
                End If
                'Else : MessageBox.Show("Vous avais la date !", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Hand)
                'End If
                Dim cr As New ATSRp1()
                cr.DataSource = ds1

                If IsConnected("select * from company", False) Then
                    If myDR.HasRows Then
                        While myDR.Read
                            cr.XrLabel1.Text = myDR("agence").ToString
                            cr.XrLabel11.Text = myDR("centrep").ToString
                            cr.XrLabel13.Text = myDR("nom_entreprise").ToString
                            cr.XrLabel10.Text = myDR("nadherent").ToString
                            cr.XrLabel12.Text = myDR("nom_entreprise").ToString
                            cr.XrLabel9.Text = myDR("addres_entreprise").ToString
                        End While
                    End If
                End If
                If IsConnected("select * from employes where Matricule='" & ListMatNom.Value & "'", False) Then
                    If myDR.HasRows Then
                        While myDR.Read
                            cr.XrLabel14.Text = myDR("Date_entrée").ToString
                            cr.XrLabel15.Text = myDR("Date_fin_de_contrat").ToString
                            If myDR("Date_fin_de_contrat").ToString <> "" And myDR("Date_entrée_1").ToString = "" Then
                                cr.XrLabel17.Text = Date.Now.ToString()
                            Else
                                cr.XrLabel16.Text = myDR("Date_entrée_1").ToString
                            End If
                        End While
                    End If
                End If
                If IsConnected("select * from employes_securitesociale_ats where Matricule='" & ListMatNom.Value & "' and type='inferieure6'", False) Then
                    If myDR.HasRows Then
                        While myDR.Read
                            cr.XrLabel19.Text = myDR("jour").ToString
                            cr.XrLabel20.Text = myDR("heure").ToString
                            cr.XrLabel21.Text = myDR("datedu").ToString
                            cr.XrLabel18.Text = myDR("dateau").ToString
                        End While
                    End If
                End If
                If IsConnected("select * from employes_securitesociale_ats where Matricule='" & ListMatNom.Value & "' and type='depasse6'", False) Then
                    If myDR.HasRows Then
                        While myDR.Read
                            cr.XrLabel19.Text = myDR("jour").ToString
                            cr.XrLabel20.Text = myDR("heure").ToString
                            cr.XrLabel21.Text = myDR("datedu").ToString
                            cr.XrLabel18.Text = myDR("dateau").ToString
                        End While

                    End If
                End If
                Dim cr1 As New ATSRp2()
                cr1.DataSource = ds1
                cr1.CreateDocument()
                cr.CreateDocument()
                cr.Pages.AddRange(cr1.Pages)
                DocumentViewer1.DocumentSource = cr
            End If
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub
#Region "Loading"
    Private Sub load_MoiAnnee()
        Try
            If IsConnected("SELECT DISTINCT moi_annee FROM paie_mensuel order by STR_TO_DATE(moi_annee, '%m%Y') asc", False) = True Then
                If myDR.HasRows = True Then
                    du.Items.Clear()
                    au.Items.Clear()
                    While (myDR.Read())
                        du.Items.Add(myDR("moi_annee"))
                        au.Items.Add(myDR("moi_annee"))
                    End While
                End If
            End If
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub
    Private Sub load_Matricule_Nom()
        ListMatNom.Properties.Items.Clear()
        IsConnected("SELECT DISTINCT employes.Matricule,employes.Nom,employes.Prénom FROM employes ", False)
        If myDR.HasRows Then
            While myDR.Read
                ListMatNom.Properties.Items.Add(New ImageComboBoxItem(myDR("Matricule").ToString & " - " & myDR("Nom").ToString & " " & myDR("Prénom").ToString, myDR("Matricule").ToString, 4))
            End While
            ListMatNom.Properties.SmallImages = StatImageList
            ListMatNom.Properties.LargeImages = StatImageList
        End If
    End Sub
#End Region
    Private Sub ATS_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        load_MoiAnnee()
        load_Matricule_Nom()
    End Sub

    Private Sub ButtonX2_Click(sender As System.Object, e As System.EventArgs) Handles ButtonX2.Click
        FormATS.type = "inferieure6"
        FormATS.mat1 = ListMatNom.Value
        FormATS.ShowDialog()
    End Sub

    Private Sub ButtonX3_Click(sender As System.Object, e As System.EventArgs) Handles ButtonX3.Click
        FormATS.type = "depassant6"
        FormATS.mat1 = ListMatNom.Value
        FormATS.ShowDialog()
    End Sub
End Class