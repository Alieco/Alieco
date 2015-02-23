Public Class ListFacture
    Dim sql As New SQLControl
    Private Sub CodeAffaireTxt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CodeAffaireTxt.TextChanged
        Try
            nFactureCmb.Items.Clear()
            errorLbl.Visible = False
            If CodeAffaireTxt.Text.Length > 6 Then
                If IsConnected("SELECT nFacture FROM facturation_facture WHERE code_affaire='" & mysql_escape_string(CodeAffaireTxt.Text) & "'", False) Then
                    If myDR.HasRows Then
                        While myDR.Read
                            nFactureCmb.Items.Add(myDR("nFacture").ToString)
                        End While
                        nFactureCmb.Text = "Choisez votre N° facture" '0542757581
                    Else
                        errorLbl.Visible = True
                        errorLbl.ForeColor = Color.Red
                    End If
                End If
            End If
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub

    Private Sub ListFacture_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            auTxt.Value = Date.Now.Date
            Dim d As Date = Date.Today
            d = d.AddDays(-30)
            duTxt.Value = d
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub

    Private Sub RechercheBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RechercheBtn.Click
        Try
            Dim d = auTxt.Value.Date.AddDays(1).ToString("yyyy-MM-dd")
            Dim query As String = "SELECT code_affaire as 'Code Affaire',nFacture as 'Num de Facture',nReference as 'Num Référence',TitreCommande as 'Titre de facture',MantantHT as 'Montant Facture en HT',MantantFactureTTC as 'Montant Facture en TTC',entry_date as 'Date de Facture' FROM facturation_facture WHERE entry_date Between  '" & duTxt.Value.ToString("yyyy-MM-dd") & "' and '" & d & "'"
            If CodeAffaireTxt.Text <> "" Then query += " and code_affaire='" & CodeAffaireTxt.Text & "'"
            If nFactureCmb.SelectedIndex > -1 Then query += " and nFacture='" & nFactureCmb.Text & "'"
            Console.WriteLine(query)
            If sql.VerifiyConnection Then
                sql.RunQuery(query)
                If sql.SQLDS.Tables.Count > 0 Then
                    FactureGrid.DataSource = sql.SQLDS.Tables(0)
                    ButtonX1.Visible = True
                Else
                    ButtonX1.Visible = False
                End If
            End If
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub

    Private Sub ButtonX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX1.Click
        Try
            Dim s As New SaveFileDialog
            s.DefaultExt = "*.Xlsx"
            s.Title = "Choisisez le nom de fichier d'enregistrement"
            s.Filter = "EXCEL 2010 | *.Xlsx"
            If s.ShowDialog = Windows.Forms.DialogResult.OK Then
                FactureGrid.ExportToXlsx(s.FileName)
                'FactureGrid.ExportToExcelOld(s.FileName)
            End If
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub
End Class