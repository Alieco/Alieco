Imports DevComponents.DotNetBar

Public Class ListeDemAch
    Dim sql As New SQLControl
    Private Sub ButtonX2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX2.Click
        loaddemande()
    End Sub

    Public Sub loaddemande()
        If du.Value = Nothing Or au.Value = Nothing Then
            MessageBoxEx.Show("veuillez saisir une date", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            If sql.VerifiyConnection = True Then
                sql.RunQuery("select demandeur, codeaffaire, service,design as 'Designation' ,delai_livrais,dateEntre as 'Date enregistrement',recept_remt as 'Désigné à' ,idLogistique_appro_demandeDesig from logistique_appro_demandedesig, logistique_appro_demach where logistique_appro_demach.idapprodemach=logistique_appro_demandedesig.idapprodemanch and etat_achat='0' and logistique_appro_demach.dateEntre between '" & du.Value.ToString() & "' and '" & au.Value.ToString() & "'")
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

    Private Sub AjouterUnNouveauOffreToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AjouterUnNouveauOffreToolStripMenuItem.Click
        consulterDemande.LabelX6.Text = "Demandeur : " & GridView1.GetFocusedRowCellValue("demandeur").ToString()
        consulterDemande.LabelX7.Text = "Affaire : " & GridView1.GetFocusedRowCellValue("codeaffaire").ToString()
        consulterDemande.LabelX8.Text = "Service : " & GridView1.GetFocusedRowCellValue("service").ToString()
        consulterDemande.LabelX9.Text = "Designation : " & GridView1.GetFocusedRowCellValue("Designation").ToString()
        consulterDemande.iddesi = GridView1.GetFocusedRowCellValue("idLogistique_appro_demandeDesig").ToString()
        Dim desig = GridView1.GetFocusedRowCellValue("idLogistique_appro_demandeDesig").ToString()
        IsConnected("SELECT logistique_appro_demach.idapprodemach FROM logistique_appro_demach,logistique_appro_demandedesig WHERE logistique_appro_demandedesig.idapprodemanch=logistique_appro_demach.idapprodemach and idLogistique_appro_demandeDesig='" & desig & "' ", False)
        If myDR.HasRows = True Then
            While (myDR.Read())
                consulterDemande.idemande = myDR("idapprodemach")
            End While
        End If
        consulterDemande.MdiParent = Mainfrm
        consulterDemande.Show()
    End Sub

    Private Sub GoogleToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GoogleToolStripMenuItem.Click
        loaddemande()
    End Sub

    Private Sub ListeDemAch_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        au.Value = Date.Now.Date
        Dim d As Date = Date.Today
        d = d.AddDays(-30)
        du.Value = d
    End Sub
End Class