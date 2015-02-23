Public Class Listeconge
    Dim sql As New SQLControl
    Private Sub Listeconge_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub ChargerLesCongésToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChargerLesCongésToolStripMenuItem.Click
        Try
            If sql.VerifiyConnection = True Then
                '  sql.RunQuery("SELECT Matricule,Nom,Prénom,DNaissance as 'Date de naissance',Dentrée as 'Date d\'entrée',numTel as 'Num Téléphone',name_service as 'Nom de service',titre_fonction as Fonction,name_direction as Direction,name_departement as Departement,Statut,Sexe,Sit_fam as 'Situation familiale',Adresse,willaya FROM Services, Departement, Direction, Employes, Fonction, willaya WHERE Services.id_departement=Departement.id_departement and Direction.id_direction=Departement.id_direction and Employe.id_service=Services.id_service and Fonction.id_fonction=Employe.id_fonction and willaya.id=Employe.VilleAdr")
                'Clipboard.SetText("SELECT Employes.Matricule, Nom, Prénom, Direction, NombreJours, TypeConge,Fonction FROM conge_ajout, Employes WHERE Employes.Matricule=conge_ajout.Matricule ")
                sql.RunQuery("SELECT Employes.Matricule, Nom, Prénom, Direction,DateDebut as 'Date de debut',DateFin as 'Date de fin', NombreJours as 'Nombre du jours', TypeConge as 'Type de congé',Fonction FROM conge_ajout, Employes WHERE Employes.Matricule=conge_ajout.Matricule ")
                If sql.SQLDS.Tables.Count > 0 Then
                    CDGV.DataSource = sql.SQLDS.Tables(0)
                End If
            End If
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub

    Private Sub ExporterLeResultatEnExcel2010xslxToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExporterLeResultatEnExcel2010xslxToolStripMenuItem.Click
        Try
            Dim s As New SaveFileDialog
            s.DefaultExt = "*.xlsx"
            s.Title = "Choisisez le nom de fichier d'enregistrement"
            s.Filter = "Excel 2010 | *.xlsx"
            If s.ShowDialog = Windows.Forms.DialogResult.OK Then
                CDGV.ExportToXlsx(s.FileName)
            End If
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub

    Private Sub ExporterEnPDFToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExporterEnPDFToolStripMenuItem.Click
        Try
            Dim s As New SaveFileDialog
            s.DefaultExt = "*.pdf"
            s.Title = "Choisisez le nom de fichier d'enregistrement"
            s.Filter = "Adobe PDF | *.pdf"
            If s.ShowDialog = Windows.Forms.DialogResult.OK Then
                CDGV.ExportToPdf(s.FileName)
            End If
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub
End Class