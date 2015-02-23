Imports DevExpress.XtraEditors.Controls
Imports DevComponents.DotNetBar

Public Class AttestationSalaire
    Private Sub ButtonX1_Click(sender As System.Object, e As System.EventArgs) Handles ButtonX1.Click
        Try
            Dim moianne5(12, 2) As String
            Dim moianne3(12, 2) As String
            Dim moianne1(12, 2) As String
            Dim moianne2(12, 2) As String
            Dim moianne4(12, 2) As String
            Dim som As Double = 0
            If ListMatNom.SelectedIndex = -1 Then
                MessageBoxEx.Show("Vous devez sélectionner un matricule avant de cliquer ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                Dim nbannee = (au.Text.Substring(2, 4) - du.Text.Substring(2, 4)) + 1
                Dim ds1 As AttestSalaireDS = New AttestSalaireDS
                Dim cr As New AttestSalaireRp1()
                Dim cr1 As New AttestSalaireRp2()

                If ListMatNom.Value <> Nothing And du.Text <> "" And au.Text <> "" Then
                    ds1.EnforceConstraints = False
                    Try
                        'Attempt to fill the dataset MainTable
                        ds1.EmploiyeDT.Clear()
                        If IsConnected("SELECT employes.Matricule,nom,prénom,Date_de_Naissance,Lieux_de_Naissance,Date_entrée,Date_fin_de_contrat,code_papers.Num_SS,Groupe FROM employes left join code_papers on employes.Matricule=code_papers.Matricule  WHERE employes.Matricule='" & ListMatNom.Value & "'", False) Then
                            If myDR.HasRows Then
                                While myDR.Read
                                    Try
                                        ds1.EmploiyeDT.AddEmploiyeDTRow(IIf(IsDBNull(myDR("Matricule")), "", myDR("Matricule")), IIf(IsDBNull(myDR("nom") & "" & myDR("prénom")), "", myDR("nom") & "" & myDR("prénom")), IIf(IsDBNull(myDR("Date_de_Naissance")), "", myDR("Date_de_Naissance")), IIf(IsDBNull(myDR("Lieux_de_Naissance")), "", myDR("Lieux_de_Naissance")), IIf(IsDBNull(myDR("Date_entrée")), "", myDR("Date_entrée")), IIf(IsDBNull(myDR("Date_fin_de_contrat")), "", myDR("Date_fin_de_contrat")), IIf(IsDBNull(myDR("Num_SS")), "", myDR("Num_SS")), IIf(IsDBNull(myDR("Groupe")), "", myDR("Groupe")))
                                    Catch ex As Exception
                                        MsgBox(ex.Message)
                                    End Try
                                End While
                            End If
                        End If
                        ds1.AtteSalaireDT.Clear()
                        '"SELECT distinct net_payer,Matricule,moi_annee FROM paie_mensuel WHERE type='P' and matricule='" & mat.Text & "' and  STR_TO_DATE(moi_annee, '%m%Y')>= STR_TO_DATE('" & du.Text & "','%m%Y') and STR_TO_DATE(moi_annee, '%m%Y')<= STR_TO_DATE('" & au.Text & "', '%m%Y') order by moi_annee asc"
                        Dim i As Integer = 0
                        Dim j As Integer = 0
                        Dim k As Integer = 0
                        Dim l As Integer = 0
                        Dim m As Integer = 0
                        Dim i1 As Integer = 0
                        Dim j1 As Integer = 0
                        Dim k1 As Integer = 0
                        Dim l1 As Integer = 0
                        Dim m1 As Integer = 0
                        Dim moiAnnee As String = ""
                        Dim annee1 As String = du.Text.ToString.Substring(2, 4)
                        If IsConnected("SELECT distinct net_payer,Matricule,moi_annee FROM paie_mensuel WHERE type='P' and matricule='" & ListMatNom.Value & "' and STR_TO_DATE(moi_annee, '%m%Y')>= STR_TO_DATE('" & du.Text & "','%m%Y') and STR_TO_DATE(moi_annee, '%m%Y')<= STR_TO_DATE('" & au.Text & "', '%m%Y') order by STR_TO_DATE(moi_annee, '%m%Y') asc", False) Then
                            If myDR.HasRows Then
                                While myDR.Read
                                    som = som + IIf(IsDBNull(myDR("net_payer").ToString), 0, myDR("net_payer").ToString)
                                    moiAnnee = myDR("moi_annee").ToString
                                    If moiAnnee.Substring(2, 4) = annee1 Then
                                        moianne1(i, 0) = myDR("moi_annee").ToString
                                        moianne1(i, 1) = myDR("net_payer").ToString
                                        i = i + 1
                                    ElseIf moiAnnee.Substring(2, 4) = (annee1 + 1) Then
                                        moianne2(j, 0) = myDR("moi_annee").ToString
                                        moianne2(j, 1) = myDR("net_payer").ToString
                                        j = j + 1
                                    ElseIf moiAnnee.Substring(2, 4) = (annee1 + 2) Then
                                        moianne3(k, 0) = myDR("moi_annee").ToString
                                        moianne3(k, 1) = myDR("net_payer").ToString
                                        k = k + 1
                                    ElseIf moiAnnee.Substring(2, 4) = (annee1 + 3) Then
                                        moianne4(l, 0) = myDR("moi_annee").ToString
                                        moianne4(l, 1) = myDR("net_payer").ToString
                                        l = l + 1
                                    ElseIf moiAnnee.Substring(2, 4) = (annee1 + 4) Then
                                        moianne5(m, 0) = myDR("moi_annee").ToString
                                        moianne5(m, 1) = myDR("net_payer").ToString
                                        m = m + 1
                                    End If
                                End While
                            End If
                        End If
                        i = 0
                        j = 0
                        k = 0
                        l = 0
                        m = 0
                        While i < 12 And j < 12 And k < 12 And l1 < 12 And m < 12
                            ds1.AtteSalaireDT.AddAtteSalaireDTRow(IIf(IsDBNull(moianne1(i, 0)), "", moianne1(i, 0)), IIf(IsDBNull(moianne1(i, 1)), "", moianne1(i, 1)), IIf(IsDBNull(moianne2(j, 0)), "", moianne2(j, 0)), IIf(IsDBNull(moianne2(j, 1)), "", moianne2(j, 1)), IIf(IsDBNull(moianne3(l, 0)), "", moianne3(l, 0)), IIf(IsDBNull(moianne3(l, 1)), "", moianne3(l, 1)), IIf(IsDBNull(moianne4(k, 0)), "", moianne4(k, 0)), IIf(IsDBNull(moianne4(k, 1)), "", moianne4(k, 1)), IIf(IsDBNull(moianne5(m, 0)), "", moianne5(m, 0)), IIf(IsDBNull(moianne5(m, 1)), "", moianne5(m, 1)))
                            'GridControl1.DataSource = ds1.AtteSalaireDT
                            i = i + 1
                            j = j + 1
                            k = k + 1
                            l = l + 1
                            m = m + 1
                        End While
                        If IsConnected("select * from company ", False) Then
                            If myDR.HasRows Then
                                While myDR.Read
                                    cr.XrLabel1.Text = myDR("nom_entreprise")
                                    cr.XrLabel8.Text = myDR("nadherent")
                                End While
                            End If
                        End If
                        If IsConnected("select distinct Matricule,fonction from employes where  Matricule='" & ListMatNom.Value & "'", False) Then
                            If myDR.HasRows Then
                                While myDR.Read
                                    cr.XrLabel5.Text = myDR("fonction")
                                End While
                            End If
                        End If
                        If IsConnected("select distinct Matricule,Groupe from employes where groupe like '%execution%' or groupe like '%maitrise%' or groupe like 'ex' and Matricule='" & ListMatNom.Value & "'", False) Then
                            If myDR.HasRows Then
                                While myDR.Read
                                    cr.XrLabel4.Text = " + "
                                End While
                            End If
                        End If
                        If IsConnected("select distinct Matricule,Groupe from employes where Groupe = 'cadre' and Matricule='" & ListMatNom.Value & "'", False) Then
                            If myDR.HasRows Then
                                While myDR.Read
                                    cr.XrLabel3.Text = " + "
                                End While
                            End If
                        End If
                        If IsConnected("select distinct Matricule,Groupe from employes where Groupe like '%cs%' and Matricule='" & ListMatNom.Value & "'", False) Then
                            If myDR.HasRows Then
                                While myDR.Read
                                    cr.XrLabel2.Text = " + "
                                End While
                            End If
                        End If
                        If IsConnected("select distinct Matricule,Groupe from employes where Groupe like '%cd%' and Matricule='" & ListMatNom.Value & "'", False) Then
                            If myDR.HasRows Then
                                While myDR.Read
                                    cr.XrLabel13.Text = " + "
                                End While
                            End If
                        End If
                    Catch ex As Exception
                        EnvoiError(ex.Message)
                    Finally
                        ds1.EnforceConstraints = True
                    End Try
                Else
                    MessageBox.Show("Vous avais laisse les champs vide !", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Hand)
                End If
                cr.DataSource = ds1
                cr1.DataSource = ds1
                cr1.XrTableCell2.Text = som
                cr1.XrLabel7.Text = Math.Round((som / nbannee), 2)
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
    Private Sub load_MoiAnnee()
        Try
            If IsConnected("SELECT DISTINCT moi_annee FROM paie_mensuel order by STR_TO_DATE(moi_annee, '%m%Y') asc ", False) = True Then
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
#End Region

    Private Sub AttestationSalaire_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        load_MoiAnnee()
        load_Matricule_Nom()
    End Sub
End Class