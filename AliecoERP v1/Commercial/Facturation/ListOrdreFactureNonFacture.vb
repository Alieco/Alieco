Imports DevComponents.DotNetBar

Public Class ListOrdreFactureNonFacture
    Dim sql As New SQLControl
    Private Sub ButtonX2_Click(sender As System.Object, e As System.EventArgs) Handles ButtonX2.Click
        Try
            If sql.VerifiyConnection = True Then
                sql.RunQuery("SELECT commercial_affaire.code_affaire as 'Code affaire',commercial_affaire.nomcl as 'Nom client',date_ordrefac as 'Date d\'ordre de facturation' ,commercial_ordre_facturation.montant_cheque as 'Montant du chaque',commercial_ordre_facturation.rando as 'CodeReference'   FROM commercial_ordre_facturation,commercial_affaire WHERE commercial_affaire.code_affaire=commercial_ordre_facturation.code_affaire ")
                If sql.SQLDS.Tables.Count > 0 Then
                    ' Supprimer la colonne : sql.SQLDS.Tables(0).Columns.Remove("idCommercial_ordre_facturation")     
                    dgfact.DataSource = sql.SQLDS.Tables(0)
                End If
            End If
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub

    Private Sub FactureStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles FactureStripMenuItem.Click
        Try
            If GridView1.SelectedRowsCount = 0 Then
                MessageBoxEx.Show("Vous devez selectionner un ordre avant de cliquer facturé", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                'IsConnected("update commercial_ordre_facturation set etat_facture = 1 where code_affaire='" & GridView1.GetFocusedRowCellValue("code_affaire").ToString() & "'limit 1", True)
                Dim facture As New AjoutFacture

                facture.CodeAffaireTxt.Text = GridView1.GetFocusedRowCellValue("Code affaire").ToString()
                facture.CodeTemp = GridView1.GetFocusedRowCellValue("CodeReference").ToString()
                facture.MdiParent = Mainfrm
                facture.Show()
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
                dgfact.ExportToCsv(s.FileName)
            End If
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub
End Class