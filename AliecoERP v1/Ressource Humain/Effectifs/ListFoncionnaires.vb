Imports DevComponents.DotNetBar
Imports System.Threading
Public Class ListFoncionnaires
    Dim sql As New SQLControl
    Sub reload()
        Try
            If sql.VerifiyConnection = True Then
                sql.RunQuery("SELECT `Matricule` ,`Nom` ,`Prénom` ,`Date_de_Naissance`,`Age1` ,`Date_entrée` ,`Date_fin_de_contrat` ,`Fonction`,`Cat` ,`Ech` ,`S_B_01_14`,`Direction`,`Statut` ,`Sexe` ,`Sit_fam` ,`Adresse` ,`Ville1`,`Service` FROM Employes WHERE etat_emp=1")
                If sql.SQLDS.Tables.Count > 0 Then
                    For Each r As DataRow In sql.SQLDS.Tables(0).Rows
                        If r(6) = "00:00:00" Then
                            r(6) = ""
                        End If
                    Next
                    DGFonc.DataSource = sql.SQLDS.Tables(0)
                End If

                ' DGFonc.PerformLayout()
            End If
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub
    Private Sub GoogleToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GoogleToolStripMenuItem.Click
        reload()
    End Sub
    Private Sub AjouterUnNouveauFonctionnaireToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AjouterUnNouveauFonctionnaireToolStripMenuItem.Click
        Ajoutfonctionnaire.MdiParent = Mainfrm
        Ajoutfonctionnaire.Show()
    End Sub

    Private Sub ModifierLeFonctionnaireFonctionnaireToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ModifierLeFonctionnaireFonctionnaireToolStripMenuItem.Click
        Try
            If GridView1.SelectedRowsCount = 0 Then
                MessageBoxEx.Show("Vous devez selectionner un fonctionnaire avant de cliquer modifier", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                ' MsgBox(row.Cells("Matricule").Value)
                EditFonctionnaire.Text = "Modification Fonctionnaire " & GridView1.GetFocusedRowCellValue("Matricule").ToString()
                EditFonctionnaire.mat.Text = GridView1.GetFocusedRowCellValue("Matricule").ToString()
                EditFonctionnaire.MdiParent = Mainfrm
                EditFonctionnaire.Show()
            End If
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub
    Private Sub SupprimerLeFonctionnaireToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SupprimerLeFonctionnaireToolStripMenuItem.Click
        Try
            If GridView1.SelectedRowsCount = 0 Then
                MessageBoxEx.Show("Vous devez selectionner un fonctionnaire avant de cliquer supprimer", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                Dim m = GridView1.GetFocusedRowCellValue("Matricule").ToString()
                If m <> Nothing Then
                    If MessageBoxEx.Show("Vous voullez vraiment supprimer le fonctionnaire ?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then

                        IsConnected("insert into drh_effectif_employes_out (select * from employes where Matricule='" & m & "' limit 1)", True)
                        IsConnected("UPDATE drh_effectif_employes_out SET etat_emp=0 WHERE Matricule=" & m, True)
                        IsConnected("DELETE FROM `employes` WHERE Matricule='" & m & "' limit 1", True)
                        reload()
                    End If
                End If
            End If
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub
    Private Sub DepartvolentaireToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DepartvolentaireToolStripMenuItem.Click
        Try
            If GridView1.SelectedRowsCount = 0 Then
                MessageBoxEx.Show("Vous devez selectionner un fonctionnaire avant de cliquer mis en départ volontaire", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                Dim m = GridView1.GetFocusedRowCellValue("Matricule").ToString()
                ' MsgBox(row.Cells("Matricule").Value)
                'EditFonctionnaire.mat.Text = row.Cells("Matricule").Value
                If m <> Nothing Then
                    If MessageBoxEx.Show("Vous voullez vraiment appliquer les changement sur le fonctionnaire ?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then

                        IsConnected("insert into drh_effectif_employes_out (select * from employes where Matricule='" & m & "' limit 1)", True)
                        IsConnected("UPDATE drh_effectif_employes_out SET etat_emp=2 WHERE Matricule=" & m, True)
                        IsConnected("DELETE FROM `employes` WHERE Matricule='" & m & "' limit 1", True)
                        reload()
                    End If
                End If
            End If
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub

    Private Sub RetraiteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RetraiteToolStripMenuItem.Click
        Try
            If GridView1.SelectedRowsCount = 0 Then
                MessageBoxEx.Show("Vous devez selectionner un fonctionnaire avant de cliquer mis en retraite?", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                Dim m = GridView1.GetFocusedRowCellValue("Matricule").ToString()
                ' MsgBox(row.Cells("Matricule").Value)
                'EditFonctionnaire.mat.Text = row.Cells("Matricule").Value
                If m <> Nothing Then
                    If MessageBoxEx.Show("Vous voullez vraiment appliquer les changement sur le fonctionnaire ?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                        IsConnected("insert into drh_effectif_employes_out (select * from employes where Matricule='" & m & "' limit 1)", True)
                        IsConnected("UPDATE drh_effectif_employes_out SET etat_emp=3 WHERE Matricule=" & m, True)
                        IsConnected("DELETE FROM `employes` WHERE Matricule='" & m & "' limit 1", True)
                        reload()
                    End If
                End If
            End If
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub

    Private Sub LicenciementToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LicenciementToolStripMenuItem.Click
        Try
            If GridView1.SelectedRowsCount = 0 Then
                MessageBoxEx.Show("Vous devez selectionner un fonctionnaire avant de cliquer licensiment", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                Dim m = GridView1.GetFocusedRowCellValue("Matricule").ToString()
                ' MsgBox(row.Cells("Matricule").Value)
                'EditFonctionnaire.mat.Text = row.Cells("Matricule").Value
                If m <> Nothing Then
                    If MessageBoxEx.Show("Vous voullez vraiment appliquer les changement sur le fonctionnaire ?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                        IsConnected("insert into drh_effectif_employes_out (select * from employes where Matricule='" & m & "' limit 1)", True)
                        IsConnected("UPDATE drh_effectif_employes_out SET etat_emp=4 WHERE Matricule=" & m, True)
                        IsConnected("DELETE FROM `employes` WHERE Matricule='" & m & "' limit 1", True)
                        reload()
                    End If
                End If
            End If
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub

    Private Sub AttestationToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AttestationToolStripMenuItem.Click
        Try
            If GridView1.SelectedRowsCount = 0 Then
                MessageBoxEx.Show("Vous devez selectionner un fonctionnaire avant de cliquer Attestation", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                ' MsgBox(row.Cells("Matricule").Value)
                AttestationDeTravail.Text = "Attestation de travail de " & GridView1.GetFocusedRowCellValue("Matricule").ToString()
                AttestationDeTravail.matr = GridView1.GetFocusedRowCellValue("Matricule").ToString()
                AttestationDeTravail.MdiParent = Mainfrm
                AttestationDeTravail.Show()
            End If
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub

    Private Sub CertificatDeTravailToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CertificatDeTravailToolStripMenuItem.Click
        Try
            If GridView1.SelectedRowsCount = 0 Then
                MessageBoxEx.Show("Vous devez selectionner un fonctionnaire avant de cliquer Certificat", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                Dim row = GridView1.GetFocusedRowCellValue("Matricule").ToString()
                ' MsgBox(row.Cells("Matricule").Value)
                CertificatDeTravail.Text = "Certificat de travail de " & GridView1.GetRowCellValue(0, "Matricule").ToString()
                CertificatDeTravail.matri = GridView1.GetRowCellValue(0, "Matricule").ToString()
                CertificatDeTravail.MdiParent = Mainfrm
                CertificatDeTravail.Show()
            End If
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub

    Private Sub ButtonX2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        reload()
    End Sub

    Private Sub TirageDesFonctionnairesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TirageDesFonctionnairesToolStripMenuItem.Click
        Try
            depart_fonctionnaire.matri = GridView1.GetFocusedRowCellValue("Matricule").ToString()
            depart_fonctionnaire.ShowDialog()
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub

    Private Sub ButtonX2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX2.Click
        reload()
    End Sub

    Private Sub ButtonX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX1.Click
        Try
            Dim s As New SaveFileDialog
            s.DefaultExt = "*.xlsx"
            s.Title = "Choisisez le nom de fichier d'enregistrement"
            s.Filter = "Excel 2010 | *.xlsx"
            If s.ShowDialog = Windows.Forms.DialogResult.OK Then
                DGFonc.ExportToXlsx(s.FileName)
            End If
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub


    Private Sub ListFoncionnaires_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Try
            '  Me.WindowState = FormWindowState.Maximized
            'Dim loginThread As Thread = New Thread(AddressOf reload)
            'loginThread.Start()

            If GridView1.SelectedRowsCount > 0 Then
                '  DGFonc.ContextMenuStrip = ContextMenuStrip1
                SupprimerLeFonctionnaireToolStripMenuItem.Enabled = True
                ModifierLeFonctionnaireFonctionnaireToolStripMenuItem.Enabled = True
            Else
                SupprimerLeFonctionnaireToolStripMenuItem.Enabled = False
                ModifierLeFonctionnaireFonctionnaireToolStripMenuItem.Enabled = False
                ' DGFonc.ContextMenuStrip = Nothing
            End If
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub


    Private Sub GridView1_FocusedRowChanged(sender As System.Object, e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles GridView1.FocusedRowChanged
        Try
            ' MsgBox("hgi")
            If GridView1.SelectedRowsCount > 0 Then
                '  DGFonc.ContextMenuStrip = ContextMenuStrip1
                SupprimerLeFonctionnaireToolStripMenuItem.Enabled = True
                ModifierLeFonctionnaireFonctionnaireToolStripMenuItem.Enabled = True
            Else
                SupprimerLeFonctionnaireToolStripMenuItem.Enabled = False
                ModifierLeFonctionnaireFonctionnaireToolStripMenuItem.Enabled = False
                ' DGFonc.ContextMenuStrip = Nothing
            End If
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub


End Class