Imports DevComponents.DotNetBar
Public Class Rapport
    Dim Sql As New SQLControl
    Dim DataSet As New RapportApproDS()
    
    Private Sub Rapport_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            loadfournisseur()
            ' loadstructure()
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub

    Private Sub loadstructure()
        Try
            fournisseur.Items.Clear()
            IsConnected("SELECT distinct codestruc, namestruc FROM logistique_appro_bonachat", False)
            If myDR.HasRows = True Then
                While (myDR.Read)
                    fournisseur.Items.Add(myDR("codestruc").ToString & "-" & myDR("namestruc").ToString)
                End While
            End If
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub
    Private Sub loadAcheteur()
        Try
            fournisseur.Items.Clear()
            IsConnected("SELECT distinct recept_remt FROM logistique_appro_demandedesig", False)
            If myDR.HasRows = True Then
                While (myDR.Read)
                    fournisseur.Items.Add(myDR("recept_remt").ToString)
                End While
            End If
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub
    Private Sub loadMonnaie()
        Try
            fournisseur.Items.Clear()
            IsConnected("SELECT distinct monnaie FROM logistique_appro_bonachat", False)
            If myDR.HasRows = True Then
                While (myDR.Read)
                    fournisseur.Items.Add(myDR("monnaie").ToString)
                End While
            End If
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub
    Private Sub loadAffaire()
        Try
            fournisseur.Items.Clear()
            IsConnected("SELECT distinct oe FROM logistique_appro_bonachat", False)
            If myDR.HasRows = True Then
                While (myDR.Read)
                    fournisseur.Items.Add(myDR("oe").ToString)
                End While
            End If
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub
    Private Sub loadDesignation()
        Try
            fournisseur.Items.Clear()
            IsConnected("SELECT distinct oe FROM logistique_appro_bonachat", False)
            If myDR.HasRows = True Then
                While (myDR.Read)
                    fournisseur.Items.Add(myDR("oe").ToString)
                End While
            End If
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub
    Private Sub loadfournisseur()
        Try
            fournisseur.Items.Clear()
            IsConnected("SELECT distinct code, nomfourn FROM logistique_appro_fournis", False)
            If myDR.HasRows = True Then
                While (myDR.Read)
                    fournisseur.Items.Add(myDR("code").ToString & "-" & myDR("nomfourn").ToString)
                End While
            End If
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub
    Private Sub Affiche_Rapport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Affiche_Rapport.Click
        Try
            Dim cr As RapportAppro = New RapportAppro
            Dim cr1 As RapportAppro1 = New RapportAppro1
            Dim cr2 As RapportAppro2 = New RapportAppro2
            If du.Value = Nothing And au.Value = Nothing Then
                MessageBoxEx.Show("Veuillez saisir la date", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                Dim s
                Dim f

                If RadioGroup1.SelectedIndex = 0 Then
                    If fournisseur.Text <> "" Then
                        f = fournisseur.Text.Split(" - ")
                        DataSet.EnforceConstraints = False
                        Try
                            DataSet.RapportApproDT.Clear()
                            IsConnected("SELECT b.DateBA,d.desigba,d.Qte,d.pu,d.montantbc,d.codeba,f.code,b.demandeur,f.nomfourn FROM logistique_appro_fournis f,logistique_appro_bonachat b, logistique_appro_badesig d WHERE f.code=d.codefour and d.codeba=b.codeba and (f.code LIKE '%" & f(0) & "%' OR nomfourn like '%" & f(2) & "%') and b.dateEnreg between '" & du.Value.ToString("yyyy-MM-dd") & "' and '" & au.Value.ToString("yyyy-MM-dd") & "'", False)
                            If myDR.HasRows Then
                                While myDR.Read
                                    cr.XrLabel1.Text = myDR("nomfourn").ToString
                                    DataSet.RapportApproDT.AddRapportApproDTRow(IIf(IsDBNull(myDR("DateBa")), "", myDR("DateBa")), IIf(IsDBNull(myDR("desigba")), "", myDR("desigba")), IIf(IsDBNull(myDR("Qte")), "", myDR("Qte")), IIf(IsDBNull(myDR("pu")), "", myDR("pu")), IIf(IsDBNull(myDR("montantbc")), "", myDR("montantbc")), IIf(IsDBNull(myDR("codeba")), "", myDR("codeba")), IIf(IsDBNull(myDR("code")), "", myDR("code")), IIf(IsDBNull(myDR("demandeur")), "", myDR("demandeur")), IIf(IsDBNull(myDR("nomfourn")), "", myDR("nomfourn")))
                                End While
                                'Else
                                '    MessageBox.Show("Il n'a y pas des donnees sur Ce fournisseur -> " & f(2) & "", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            End If
                            If titre.Text <> "" Then
                                cr.XrLabel1.Text = titre.Text
                            End If
                            cr.DataSource = DataSet
                            DocumentViewer1.DocumentSource = cr
                            cr.CreateDocument(True)
                        Catch ex As Exception
                            EnvoiError(ex.Message)
                        Finally
                            DataSet.EnforceConstraints = True
                        End Try
                    End If

                ElseIf RadioGroup1.SelectedIndex = 3 Or RadioGroup1.SelectedIndex = 4 Then
                    If fournisseur.Text <> "" Then
                        DataSet.EnforceConstraints = False
                        Dim condition
                        If RadioGroup1.SelectedIndex = 3 Then
                            s = fournisseur.Text.Split("-")
                            condition = " imputation LIKE '%" & s(0) & "%'"
                        Else : condition = " imputation LIKE'%" & fournisseur.Text & "%'"
                        End If
                        Try
                            DataSet.RapportAppro2DT.Clear()
                            IsConnected("SELECT b.DateBA,d.desigba,d.Qte,d.pu,d.montantbc,d.codeba,imputation,b.modepaiem,b.demandeur,b.codestruc FROM logistique_appro_fournis f,logistique_appro_bonachat b, logistique_appro_badesig d WHERE f.code=d.codefour and d.codeba=b.codeba and " & condition & " and b.dateEnreg between '" & du.Value.ToString("yyyy-MM-dd") & "' and '" & au.Value.ToString("yyyy-MM-dd") & "'", False)
                            If myDR.HasRows Then
                                While myDR.Read
                                    cr2.XrLabel1.Text = myDR("imputation").ToString & " du '" & du.Value.ToString("dd/MM/yyyy") & "' au " & au.Value.ToString("dd/MM/yyyy") & "' "
                                    DataSet.RapportAppro2DT.AddRapportAppro2DTRow(IIf(IsDBNull(myDR("DateBa")), "", myDR("DateBa")), IIf(IsDBNull(myDR("desigba")), "", myDR("desigba")), IIf(IsDBNull(myDR("Qte")), "", myDR("Qte")), IIf(IsDBNull(myDR("pu")), "", myDR("pu")), IIf(IsDBNull(myDR("montantbc")), "", myDR("montantbc")), IIf(IsDBNull(myDR("codeba")), "", myDR("codeba")), IIf(IsDBNull(myDR("modepaiem")), "", myDR("modepaiem")), IIf(IsDBNull(myDR("demandeur")), "", myDR("demandeur")), IIf(IsDBNull(myDR("imputation")), "", myDR("imputation")))
                                End While
                                'Else
                                '    MessageBox.Show("Il n'a y pas des donnees sur Ce fournisseur -> " & f(2) & "", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            End If
                            If titre.Text <> "" Then cr2.XrLabel1.Text = titre.Text
                            cr2.DataSource = DataSet
                            DocumentViewer1.DocumentSource = cr2
                            cr2.CreateDocument(True)
                            condition = ""
                        Catch ex As Exception
                            EnvoiError(ex.Message)
                        Finally
                            DataSet.EnforceConstraints = True
                        End Try
                    End If

                ElseIf RadioGroup1.SelectedIndex = 1 Or RadioGroup1.SelectedIndex = 2 Then
                    If fournisseur.Text <> "" Then
                        DataSet.EnforceConstraints = False
                        Dim condition
                        If RadioGroup1.SelectedIndex = 1 Then
                            condition = " user LIKE'%" & fournisseur.Text & "%'"
                        Else : condition = " monnaie LIKE'%" & fournisseur.Text & "%'"
                        End If
                        Try
                            DataSet.RapportAppro1DT.Clear()
                            IsConnected("SELECT b.DateBA,d.desigba,d.Qte,d.pu,d.montantbc,d.codeba,b.demandeur,b.delaiexe,client,imputation FROM logistique_appro_bonachat b, logistique_appro_badesig d WHERE d.codeba=b.codeba and " & condition & " and b.dateEnreg between '" & du.Value.ToString("yyyy-MM-dd") & "' and '" & au.Value.ToString("yyyy-MM-dd") & "'", False)
                            If myDR.HasRows Then
                                While myDR.Read
                                    cr1.XrLabel1.Text = " Achats du '" & du.Value.ToString("dd/MM/yyyy") & "' au " & au.Value.ToString("dd/MM/yyyy") & "' "
                                    DataSet.RapportAppro1DT.AddRapportAppro1DTRow(IIf(IsDBNull(myDR("DateBa")), "", myDR("DateBa")), IIf(IsDBNull(myDR("desigba")), "", myDR("desigba")), IIf(IsDBNull(myDR("Qte")), "", myDR("Qte")), IIf(IsDBNull(myDR("pu")), "", myDR("pu")), IIf(IsDBNull(myDR("montantbc")), "", myDR("montantbc")), IIf(IsDBNull(myDR("codeba")), "", myDR("codeba")), IIf(IsDBNull(myDR("delaiexe")), "", myDR("delaiexe")), IIf(IsDBNull(myDR("imputation")), "", myDR("imputation")), IIf(IsDBNull(myDR("client")), "", myDR("client")))
                                End While
                                'Else
                                '    MessageBox.Show("Il n'a y pas des donnees sur Ce fournisseur -> " & f(2) & "", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            End If
                            If titre.Text <> "" Then cr1.XrLabel1.Text = titre.Text
                            cr1.DataSource = DataSet
                            DocumentViewer1.DocumentSource = cr1
                            cr1.CreateDocument(True)
                        Catch ex As Exception
                            EnvoiError(ex.Message)
                        Finally
                            DataSet.EnforceConstraints = True
                        End Try
                    End If
                End If
            End If
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub
    'Private Sub fournisseur_TextChanged(sender As System.Object, e As System.EventArgs) Handles fournisseur.TextChanged
    '    structure1.Enabled = False
    '    Acheteur.Enabled = False
    '    fournisseur.Enabled = True
    'End Sub

    'Private Sub Acheteur_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Acheteur.TextChanged
    '    fournisseur.Enabled = False
    '    structure1.Enabled = False
    '    Acheteur.Enabled = True
    'End Sub

    'Private Sub structure1_TextChanged(sender As System.Object, e As System.EventArgs) Handles structure1.TextChanged
    '    fournisseur.Enabled = False
    '    Acheteur.Enabled = False
    '    structure1.Enabled = True
    'End Sub

    Private Sub RadioGroup1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles RadioGroup1.SelectedIndexChanged
        Select Case RadioGroup1.SelectedIndex
            Case 0
                fournisseur.Text = ""
                fournisseur.WatermarkText = "Code, Nom fournisseur..."
                loadfournisseur()
            Case 1
                fournisseur.Text = ""
                fournisseur.WatermarkText = "Acheteur..."
                loadAcheteur()
            Case 2
                fournisseur.Text = ""
                fournisseur.WatermarkText = "Monnaie..."
                loadMonnaie()
            Case 3
                fournisseur.Text = ""
                fournisseur.WatermarkText = "structure..."
                loadstructure()
            Case 4
                fournisseur.Text = ""
                fournisseur.WatermarkText = "Affaire..."
                loadAffaire()
            Case 5
                fournisseur.Text = ""
                fournisseur.WatermarkText = "Affaire..."
                loadDesignation()
        End Select
    End Sub
End Class