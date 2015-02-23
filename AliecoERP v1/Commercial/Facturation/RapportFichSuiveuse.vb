Imports DevExpress.XtraRichEdit
Imports DevExpress.XtraRichEdit.API.Native
Imports DevExpress.XtraRichEdit.Utils
Imports System.IO
Imports DevExpress.Office.Utils
Imports DevComponents.DotNetBar

Public Class RapportFichSuiveuse

    'Private Sub CodeAffaireTxt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    clientcombo.Items.Clear()
    '    errorLbl.Visible = False
    '    If CodeAffaireTxt.Text.Length > 6 Then
    '        If IsConnected("SELECT nFacture FROM facturation_facture WHERE code_affaire='" & mysql_escape_string(CodeAffaireTxt.Text) & "'", False) Then
    '            If myDR.HasRows Then
    '                While myDR.Read
    '                    clientcombo.Items.Add(myDR("nFacture").ToString)
    '                End While
    '                clientcombo.Text = "Choisez votre N° facture" '0542757581
    '            Else
    '                errorLbl.Visible = True
    '                errorLbl.ForeColor = Color.Red
    '            End If
    '        End If
    '    End If
    'End Sub

    Private Sub RechercheBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RechercheBtn.Click
        Try
            If clientcombo.SelectedIndex > -1 Then
                Dim cl = clientcombo.Text.Split(" - ")
                If IsConnected("SELECT * FROM facturation_facture, commercial_affaire WHERE nomcl='" & cl(2) & "' and commercial_affaire.code_affaire=facturation_facture.code_affaire", False) Then
                    If myDR.HasRows Then
                        RichEditControl1.LoadDocument(Application.StartupPath & "/Docs/FicheSuiveuse.rtf", DocumentFormat.Rtf)
                        Dim doc As Document = RichEditControl1.Document
                        Dim tbl As Table = doc.Tables(0)
                        tbl.BeginUpdate()
                        Dim s As Double = 0
                        While myDR.Read
                            Dim row As TableRow = tbl.Rows.Append()
                            Dim cell As TableCell = row.FirstCell
                            doc.InsertSingleLineText(cell.Range.Start, myDR("code_affaire").ToString)
                            doc.InsertSingleLineText(cell.Next.Range.Start, myDR("nFacture").ToString)
                            doc.InsertSingleLineText(cell.Next.Next.Range.Start, myDR("entry_date").ToString)
                            doc.InsertSingleLineText(cell.Next.Next.Next.Range.Start, (myDR("MantantFactureTTC").ToString) & " DA")
                            s += myDR("MantantFactureTTC").ToString
                            '  Console.WriteLine(myDR("MantantFactureTTC").ToString)
                        End While
                        tbl.EndUpdate()
                        RichEditControl1.Document.ReplaceAll("{total}", s, API.Native.SearchOptions.CaseSensitive)
                        RichEditControl1.Document.ReplaceAll("{TVA}", (s * 17) / 117, API.Native.SearchOptions.CaseSensitive)
                        RichEditControl1.Document.ReplaceAll("{NOMCLIENT}", cl(2), API.Native.SearchOptions.CaseSensitive)
                        exportBtn.Visible = True
                    Else
                        exportBtn.Visible = False
                        MessageBoxEx.Show("Cette affaire ne contient pas des factures ", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Hand)
                    End If
                End If
            Else
                MessageBoxEx.Show("Veuillez choisir une facture", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Hand)
                'vous devez choisir une facture
            End If
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub

    Private Sub RapportFichSuiveuse_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            load_nomclient()
            '  RichEditControl1.LoadDocument(Application.StartupPath & "/Docs/FicheSuiveuse.rtf", DocumentFormat.Rtf)
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub
    Sub load_nomclient()
        Try
            clientcombo.Items.Clear()
            IsConnected("SELECT RaisonSocial, idclient FROM commercial_client", False)
            If myDR.HasRows Then
                While myDR.Read
                    clientcombo.Items.Add(myDR("idclient") & " - " & myDR("RaisonSocial").ToString)
                End While
            End If
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub

    Private Sub ButtonX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles exportBtn.Click
        Try
            RichEditControl1.SaveDocumentAs()
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub
End Class