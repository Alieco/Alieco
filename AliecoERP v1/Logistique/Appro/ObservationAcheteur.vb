Imports DevComponents.DotNetBar

Public Class ObservationAcheteur
    Dim sql As New SQLControl
    Private Sub ButtonX2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX2.Click
        loaddemande()
    End Sub
    Public Sub loaddemande()
        If du.Value = Nothing Or au.Value = Nothing Then
            MessageBoxEx.Show("veuillez saisir une date", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            If sql.VerifiyConnection = True Then
                sql.RunQuery("select design as 'Designation' , Qt as 'Quantite', demandeur as 'Demandeur', codeaffaire as 'Affaire',recept_remt as 'Acheteur',dateEntre as 'Date reception de la demande',dateconsult as 'Date transmi',delai_livrais as 'Delai', situationdem as 'Situation', observation, idsuividem FROM logistique_appro_demandedesig, logistique_appro_demach, logistique_appro_suividem WHERE logistique_appro_demach.idapprodemach=logistique_appro_demandedesig.idapprodemanch and logistique_appro_demandedesig.idLogistique_appro_demandeDesig=logistique_appro_suividem.idLogistique_appro_demandeDesig and etat_achat='0' and etatdesig='1' and  logistique_appro_demandedesig.dateconsult between '" & du.Value.ToString("yyyy-MM-dd") & "' and '" & au.Value.ToString("yyyy-MM-dd") & "'")
                If sql.SQLDS.Tables.Count > 0 Then
                    DGDem.DataSource = sql.SQLDS.Tables(0)
                End If
            End If
        End If
    End Sub

    Private Sub ButtonX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX1.Click
        Dim s As New SaveFileDialog
        s.DefaultExt = "*.xlsx"
        s.Title = "Choisissez le nom de fichier d'enregistrement"
        s.Filter = "Excel 2010 | *.xlsx"
        If s.ShowDialog = Windows.Forms.DialogResult.OK Then
            DGDem.ExportToXlsx(s.FileName)
        End If
    End Sub

    'Private Sub GridView1_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GridView1.DoubleClick
    '    MentionObservation.idsuivi = GridView1.GetFocusedRowCellValue("idsuividem").ToString()
    '    MentionObservation.ShowDialog()
    'End Sub

    Private Sub AjouterUnNouveauOffreToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AjouterUnNouveauOffreToolStripMenuItem.Click
        MentionObservation.idsuivi = GridView1.GetFocusedRowCellValue("idsuividem").ToString()
        MentionObservation.observation.Text = GridView1.GetFocusedRowCellValue("observation").ToString()
        MentionObservation.ShowDialog()
    End Sub

    Private Sub ObservationAcheteur_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        au.Value = Date.Now.Date
        Dim d As Date = Date.Today
        d = d.AddDays(-30)
        du.Value = d
    End Sub

    Private Sub GoogleToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GoogleToolStripMenuItem.Click
        loaddemande()
    End Sub
End Class