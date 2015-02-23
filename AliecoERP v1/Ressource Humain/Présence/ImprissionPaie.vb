Imports DevComponents.DotNetBar
Imports DevExpress.XtraPrinting
Imports DevExpress.XtraReports.UI

Public Class ImprissionPaie
    Dim report1 As New fichedePaieRp()
    Dim i = 0
    Private Sub ImprissionPaie_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            For i As Integer = 2000 To Date.Now.Year
                Anne.Items.Add(i)
            Next
            Anne.SelectedIndex = Anne.Items.Count - 1
            For i As Integer = 1 To 12
                If i < 10 Then
                    Moi.Items.Add("0" & i)
                Else
                    Moi.Items.Add(i)
                End If
            Next
            Moi.SelectedIndex = Date.Now.Month - 1
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub

    Private Sub ButtonX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX1.Click
        Try
            CheckedListBox1.Items.Clear()
            Dim query = ""
            If RadioButton1.Checked Then
                query = "SELECT DISTINCT(employes.Matricule),Nom,Prénom FROM paie_mensuel,employes WHERE paie_mensuel.Matricule=employes.Matricule And paie_mensuel.type='P' and moi_annee='" & Moi.Text & Anne.Text & "' ORDER BY employes.Matricule ASC "
            End If
            If RadioButton2.Checked Then
                query = "SELECT DISTINCT(employes.Matricule),Nom,Prénom FROM paie_mensuel,employes WHERE paie_mensuel.Matricule=employes.Matricule And paie_mensuel.type='B' and moi_annee='" & Moi.Text & Anne.Text & "' ORDER BY employes.Matricule ASC "
            End If
            If RadioButton3.Checked Then
                query = "SELECT DISTINCT(employes.Matricule),Nom,Prénom FROM paie_mensuel,employes WHERE paie_mensuel.Matricule=employes.Matricule And paie_mensuel.type='V' and moi_annee LIKE '%" & Anne.Text & "%' ORDER BY employes.Matricule ASC "
            End If
            ' Clipboard.SetText(query)
            If IsConnected(query, False) Then
                If myDR.HasRows Then
                    While myDR.Read
                        CheckedListBox1.Items.Add(myDR("Matricule") & " - " & myDR("Nom") & " " & myDR("Prénom"))
                    End While
                End If
                If CheckedListBox1.Items.Count > 0 Then
                    checktous.Visible = True
                    checktous.Checked = False
                    paiebtn.Visible = False
                    genererPaie.Visible = True
                Else
                    checktous.Visible = False
                    paiebtn.Visible = False
                    genererPaie.Visible = True
                End If
            Else
                MessageBoxEx.Show("Une Erreur s'est produit ")
            End If
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub


    Private Sub checktous_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles checktous.CheckedChanged
        Try
            If checktous.Checked = True Then
                For i As Integer = 0 To CheckedListBox1.Items.Count - 1
                    CheckedListBox1.SetItemChecked(i, CheckState.Checked)
                    genererPaie.Enabled = True
                Next
            Else
                For i As Integer = 0 To CheckedListBox1.Items.Count - 1
                    CheckedListBox1.SetItemChecked(i, CheckState.Unchecked)
                    genererPaie.Enabled = False
                Next
            End If
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub

    Private Sub ImprissionPaie_Resize(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Resize
        Try
            checktous.Left = 1200 + (Me.Width - 1200) - checktous.Width - 142
            genererPaie.Left = 1200 + (Me.Width - 1200) - genererPaie.Width - 90
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub

    Private Sub CheckedListBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckedListBox1.SelectedIndexChanged
        Try
            If CheckedListBox1.CheckedItems.Count > 0 Then
                genererPaie.Enabled = True
            Else
                genererPaie.Enabled = False
            End If
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub

    Private Sub genererPaie_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles genererPaie.Click
        Try
            'Dim report1 As fichedePaieRp = New fichedePaieRp()
            report1.CreateDocument()
            For Each itemChecked In CheckedListBox1.CheckedItems
                Dim ds1 As New FicheDePaieDs
                ' ds1.Relations.Remove("Employes_Paie")
                Const quote As String = """"
                Dim mat = itemChecked.ToString().Split(" - ")
                Dim query = ""
                Dim quary1 = ""
                Dim query2 = ""
                If RadioButton1.Checked Then
                    query = "SELECT distinct (Employes.Matricule), nom, prénom, fonction, cat,Ech, S_B_01_14, moi_annee, liborg, csect, Sit_fam, adherent, total_impots,total_ss, total_gain, total_retenue, Mode_Paiement,net_payer FROM paie_mensuel,employes, paie_direction WHERE paie_mensuel.Matricule=employes.Matricule and  paie_mensuel.type='P' and moi_annee='" & Moi.Text & Anne.Text & "'  and Employes.Matricule='" & mat(0) & "' ORDER BY employes.Matricule ASC "
                    quary1 = "SELECT Num_SS, Num_CPT,Matricule FROM code_papers WHERE Matricule= '" & mat(0) & "' "
                    query2 = "SELECT * FROM alieco.paie_mensuel where Matricule='" & mat(0) & "'and paie_mensuel.type='P' and moi_annee='" & Moi.Text & Anne.Text & "' "
                End If
                If RadioButton2.Checked Then
                    query = "SELECT distinct( Employes.Matricule), nom, prénom, fonction, cat,Ech, S_B_01_14, moi_annee, liborg, csect, Sit_fam, adherent, total_impots,total_ss, total_gain, total_retenue, Mode_Paiement,net_payer FROM paie_mensuel,employes, code_papers, paie_direction WHERE paie_mensuel.Matricule=employes.Matricule and  paie_mensuel.type='B' and moi_annee='" & Moi.Text & Anne.Text & "'  and Employes.Matricule='" & mat(0) & "' ORDER BY employes.Matricule ASC "
                    quary1 = "SELECT Num_SS, Num_CPT,Matricule FROM code_papers WHERE Matricule= '" & mat(0) & "' "
                    query2 = "SELECT * FROM alieco.paie_mensuel where Matricule='" & mat(0) & "'and paie_mensuel.type='B' and moi_annee='" & Moi.Text & Anne.Text & "' "
                End If
                If RadioButton3.Checked Then
                    query = "SELECT distinct(Employes.Matricule), nom, prénom, fonction, cat,Ech, S_B_01_14, moi_annee, liborg, csect, Num_SS, Num_CPT, Sit_fam, adherent, total_impots,total_ss, total_gain, total_retenue, Mode_Paiement,net_payer FROM paie_mensuel,employes, code_papers, paie_direction WHERE paie_mensuel.Matricule=employes.Matricule and paie_mensuel.type='V' and moi_annee='" & Moi.Text & Anne.Text & "'  and Employes.Matricule='" & mat(0) & "' ORDER BY employes.Matricule ASC "
                    quary1 = "SELECT Num_SS, Num_CPT, Matricule FROM code_papers WHERE Matricule= '" & mat(0) & "' "
                    query2 = "SELECT * FROM alieco.paie_mensuel where Matricule='" & mat(0) & "' and paie_mensuel.type='V' and moi_annee='" & Moi.Text & Anne.Text & "' "
                End If
                If IsConnected(query, False) Then
                    If myDR.HasRows Then
                        While myDR.Read
                            ds1.Employes.AddEmployesRow(IIf((IsDBNull(myDR("Matricule")) Or myDR("Matricule") = "0"), "", CDbl(myDR("Matricule"))), IIf(IsDBNull(myDR("nom")), "", myDR("nom") & " " & myDR("prénom")), IIf(IsDBNull(myDR("fonction")), "", myDR("fonction")), IIf(IsDBNull(myDR("cat")), "", myDR("cat")), IIf(IsDBNull(myDR("Ech")), "", myDR("Ech")), IIf(IsDBNull(myDR("S_B_01_14")), 0, myDR("S_B_01_14")), IIf(IsDBNull(myDR("moi_annee")), "", myDR("moi_annee")), IIf(IsDBNull(myDR("liborg")), "", myDR("liborg")), IIf(IsDBNull(myDR("csect")), "", myDR("csect")), IIf(IsDBNull(myDR("sit_fam")), "", myDR("sit_fam")), IIf(IsDBNull(myDR("adherent")), "", myDR("adherent")), IIf(IsDBNull(myDR("total_impots")), "", myDR("total_impots")), IIf(IsDBNull(myDR("total_ss")), "", myDR("total_ss")), IIf(IsDBNull(myDR("total_gain")), "", myDR("total_gain")), IIf(IsDBNull(myDR("total_retenue")), "", myDR("total_retenue")), IIf(IsDBNull(myDR("net_payer")), "", myDR("net_payer")), IIf(IsDBNull(myDR("mode_paiement")), "", myDR("mode_paiement")))
                        End While
                    End If
                End If
                If IsConnected(quary1, False) Then
                    If myDR.HasRows Then
                        While myDR.Read
                            ds1.Code_papers.AddCode_papersRow(IIf(IsDBNull(myDR("Num_SS")), "", myDR("Num_SS")), IIf(IsDBNull(myDR("Num_CPT")), "", myDR("Num_CPT")), IIf((IsDBNull(myDR("Matricule")) Or myDR("Matricule") = "0"), "", CDbl(myDR("Matricule"))))
                        End While
                    End If
                End If
                If IsConnected(query2, False) Then
                    If myDR.HasRows Then
                        While myDR.Read
                            ds1.Paie.AddPaieRow(IIf(IsDBNull(myDR("code")), "", myDR("code")), IIf(IsDBNull(myDR("libellé")), "", myDR("libellé")), IIf((IsDBNull(myDR("nombre")) Or myDR("nombre") = "0"), "", (myDR("nombre"))), IIf((IsDBNull(myDR("taux")) Or myDR("taux") = "0"), "", myDR("taux")), IIf((IsDBNull(myDR("soumis_Impots")) Or myDR("soumis_Impots") = "0"), "", myDR("soumis_Impots")), IIf((IsDBNull(myDR("soumis_ss")) Or myDR("soumis_ss") = "0"), "", myDR("soumis_ss")), IIf((IsDBNull(myDR("gain")) Or myDR("gain") = "0"), "", myDR("gain")), IIf((IsDBNull(myDR("retenue")) Or myDR("retenue") = "0"), "", myDR("retenue")), IIf(IsDBNull(myDR("Matricule")), "", myDR("Matricule").ToString))
                        End While
                    End If
                End If
                ' ds1.Relations.Add("Employes_Paie", ds1.Tables("Employes").Columns("Matricule"), ds1.Tables("Paie").Columns("Matricule"))
                Dim r As New fichedePaieRp
                r.DataSource = ds1
                r.CreateDocument()
                report1.Pages.AddRange(r.Pages)
            Next
            report1.Pages.RemoveAt(0)
            DocumentViewer1.DocumentSource = report1
            paiebtn.Visible = True
            paiebtn.Pulse()
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub
    Private Sub printingSystem_StartPrint(ByVal sender As Object, ByVal e As PrintDocumentEventArgs)
        ' Set the page range.
        'e.PrintDocument.PrinterSettings.PrintToFile = True
        ''Dim pageSettings As XtraPageSettingsBase = report1.PrintingSystem.PageSettings
        ''pageSettings.TopMargin = -20
        ''pageSettings.TopMargin -= 5 * i

        'e.PrintDocument.PrinterSettings.FromPage = i
        'e.PrintDocument.PrinterSettings.ToPage = i
    End Sub

    Private Sub ButtonX2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles paiebtn.Click
        AddHandler report1.PrintingSystem.StartPrint, AddressOf printingSystem_StartPrint
        'For i = 1 To report1.Pages.Count
        ' report1.ExportToPdf("C:\paie.pdf")
        Try
            report1.Print()
            'Next
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub
End Class