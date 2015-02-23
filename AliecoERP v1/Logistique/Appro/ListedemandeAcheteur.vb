Imports DevComponents.DotNetBar

Public Class ListedemandeAcheteur
    Dim sql As New SQLControl
    Private Sub ButtonX2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX2.Click
        loaddemande()
    End Sub
    Sub loaddemande()
        Try
            If du.Value = Nothing Or au.Value = Nothing Then
                MessageBoxEx.Show("veuillez saisir une date", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                If sql.VerifiyConnection = True Then
                    sql.RunQuery("select demandeur, codeaffaire, service,design as 'Designation' ,delai_livrais,dateEntre as 'Date enregistrement',logistique_appro_demach.idapprodemach from logistique_appro_demandedesig, logistique_appro_demach, users where logistique_appro_demach.idapprodemach=logistique_appro_demandedesig.idapprodemanch and etat_achat='0' and etatdesig='1' and users.fullname=logistique_appro_demandedesig.recept_remt and users.user_id='" & user_id & "' and logistique_appro_demandedesig.dateconsult between '" & du.Value.ToString("yyyy-MM-dd") & "' and '" & au.Value.ToString("yyyy-MM-dd") & "'")
                    If sql.SQLDS.Tables.Count > 0 Then
                        DGDem.DataSource = sql.SQLDS.Tables(0)
                    End If
                End If
            End If
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub

    Private Sub ButtonX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX1.Click
        Try
            Dim s As New SaveFileDialog
            s.DefaultExt = "*.xlsx"
            s.Title = "Choisissez le nom de fichier d'enregistrement"
            s.Filter = "Excel 2010 | *.xlsx"
            If s.ShowDialog = Windows.Forms.DialogResult.OK Then
                DGDem.ExportToXlsx(s.FileName)
            End If
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub

    Private Sub GoogleToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GoogleToolStripMenuItem.Click
        loaddemande()
    End Sub

    Private Sub AjouterUnNouveauOffreToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AjouterUnNouveauOffreToolStripMenuItem.Click
        Try
            SuivAcht.codeaffaire.Text = GridView1.GetFocusedRowCellValue("codeaffaire").ToString()
            SuivAcht.codeaff.Checked = True
            SuivAcht.service.Text = GridView1.GetFocusedRowCellValue("service").ToString()
            SuivAcht.desig.Text = GridView1.GetFocusedRowCellValue("Designation").ToString()
            SuivAcht.datedem.Text = GridView1.GetFocusedRowCellValue("Date enregistrement").ToString()
            SuivAcht.iddemande = GridView1.GetFocusedRowCellValue("idapprodemach").ToString()
            IsConnected("SELECT Qt, idLogistique_appro_demandeDesig FROM logistique_appro_demach, logistique_appro_demandedesig WHERE logistique_appro_demandedesig.idapprodemanch=logistique_appro_demach.idapprodemach", False)
            If myDR.HasRows = True Then
                While (myDR.Read())
                    SuivAcht.qt.Text = myDR("Qt").ToString()
                    SuivAcht.iddesig = myDR("idLogistique_appro_demandeDesig").ToString
                End While
            End If
            SuivAcht.MdiParent = Mainfrm
            SuivAcht.Show()
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub

    Private Sub ListedemandeAcheteur_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        au.Value = Date.Now.Date
        Dim d As Date = Date.Today
        d = d.AddDays(-30)
        du.Value = d
    End Sub
End Class