Imports DevComponents.DotNetBar
Imports DevExpress.XtraGrid.GridControl
Public Class Absencefrm
    Dim sql As New SQLControl
    Private Sub Absencefrm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            du.Value = Date.Now.Date
            au.Value = Date.Now.Date
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub

    Private Sub ButtonX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX1.Click
        Try
            If sql.VerifiyConnection = True Then
                '  sql.RunQuery("SELECT Matricule,Nom,Prénom,DNaissance as 'Date de naissance',Dentrée as 'Date d\'entrée',numTel as 'Num Téléphone',name_service as 'Nom de service',titre_fonction as Fonction,name_direction as Direction,name_departement as Departement,Statut,Sexe,Sit_fam as 'Situation familiale',Adresse,willaya FROM Services, Departement, Direction, Employes, Fonction, willaya WHERE Services.id_departement=Departement.id_departement and Direction.id_direction=Departement.id_direction and Employe.id_service=Services.id_service and Fonction.id_fonction=Employe.id_fonction and willaya.id=Employe.VilleAdr")
                Clipboard.SetText("SELECT Matricule, Nom, Prénom, Direction, Date, Entree1,Sortie1, Entree2,Sortie2,Entree3,Sortie3, absence, HeureSupplementaire, Motif FROM presence_pointage, Employes WHERE Employes.Matricule=presence_pointage.Matricule and Date between  '" & du.Value.ToString("yyyy-MM-dd") & "' and '" & au.Value.ToString("yyyy-MM-dd") & "' and Motif like '%Absent( e )%'")
                sql.RunQuery("SELECT Employes.Matricule, Nom, Prénom, Direction, date_pointage, Entree1,Sortie1, Entree2,Sortie2,Entree3,Sortie3, absence, HeureSupplementaire, Motif FROM presence_pointage, Employes WHERE Employes.Matricule=presence_pointage.Matricule and (date_pointage between  '" & du.Value.ToString("yyyy-MM-dd") & "' and '" & au.Value.ToString("yyyy-MM-dd") & "') and Motif like '%Absent( e )%'")
                If sql.SQLDS.Tables.Count > 0 Then
                    Pdgv.DataSource = sql.SQLDS.Tables(0)
                End If
            End If
            'For i As Integer = 0 To GridView1.RowCount - 1
            '    MessageBoxEx.Show(GridView1.)
            '    If Pdgv.MainView.GetRow(i).ToString = "A" Then
            '        ' Your code here
            '    End If
            'Next i
            For i As Integer = 0 To GridView1.DataRowCount - 1
                Dim row As DataRow = GridView1.GetDataRow(i)
                For i2 As Integer = 5 To 10
                    Dim time As String = row(i2).ToString()
                    If time = "00:00:00" Then
                        row(i2) = "null"
                    End If
                Next
            Next i
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub

    Private Sub ButtonX2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX2.Click
        Try
            Dim s As New SaveFileDialog
            s.DefaultExt = "*.xlsx"
            s.Title = "Choisisez le nom de fichier d'enregistrement"
            s.Filter = "Excel 2010 | *.xlsx"
            If s.ShowDialog = Windows.Forms.DialogResult.OK Then
                Pdgv.ExportToXlsx(s.FileName)
            End If
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub
End Class