Imports DevExpress.XtraPivotGrid
Imports MySql.Data.MySqlClient

Public Class ResumeIRGannuel
    Dim sql As New SQLControl
    Private Sub ButtonX2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX2.Click
        PivotGridControl1.Fields.Clear()
        PivotGridControl1.DataSource = Nothing
        Try
            Dim q = "SELECT Employes.Matricule, Nom, Prénom,Sit_fam, Fonction, Adresse, Ville1, Nombre_enfant, retenue, total_impots,moi_annee FROM code_papers, Employes, paie_mensuel WHERE Employes.Matricule=code_papers.Matricule and paie_mensuel.Matricule=Employes.Matricule and code=980 and paie_mensuel.type ='P' and ( moi_annee ='01" & Anne.Text & "' or moi_annee ='02" & Anne.Text & "' or moi_annee ='03" & Anne.Text & "' or moi_annee ='04" & Anne.Text & "' or moi_annee ='05" & Anne.Text & "' or moi_annee ='06" & Anne.Text & "' or moi_annee ='07" & Anne.Text & "' or moi_annee ='08" & Anne.Text & "' or moi_annee ='09" & Anne.Text & "' or moi_annee ='10" & Anne.Text & "' or moi_annee ='11" & Anne.Text & "' or moi_annee ='12" & Anne.Text & "')"
            Clipboard.SetText(q)
            sql.RunQuery(q)
            If sql.SQLDS.Tables.Count > 0 Then PivotGridControl1.DataSource = sql.SQLDS.Tables(0)
            Dim nom As PivotGridField = New PivotGridField("Nom", PivotArea.RowArea)
        Dim prenom As PivotGridField = New PivotGridField("Prénom", PivotArea.RowArea)
        Dim sitfam As PivotGridField = New PivotGridField("Sit_fam", PivotArea.RowArea)
        Dim nbenfant As PivotGridField = New PivotGridField("Nombre_enfant", PivotArea.RowArea)
        Dim fonction As PivotGridField = New PivotGridField("Fonction", PivotArea.RowArea)
        Dim adresse As PivotGridField = New PivotGridField("Adresse", PivotArea.RowArea)
        Dim ville As PivotGridField = New PivotGridField("Ville1", PivotArea.RowArea)
        'adresse.Visible = False
        'ville.Visible = False
        'Dim unboundField As PivotGridField = New PivotGridField
        'unboundField.Caption = "Adresse"
        'unboundField.Name = "adresse1"
        'unboundField.ValueFormat.FormatType = PivotArea.RowArea
        'unboundField.UnboundType = DevExpress.Data.UnboundColumnType.String
        Dim moi As PivotGridField = New PivotGridField("moi_annee", PivotArea.ColumnArea)
        moi.Caption = "Mois"
        ' moi.GroupInterval = PivotGroupInterval.DateMonth
        Dim base As PivotGridField = New PivotGridField("total_impots", PivotArea.DataArea)
        base.Caption = "Base"
        Dim irg As PivotGridField = New PivotGridField("retenue", PivotArea.DataArea)
        irg.Caption = "Retenue"
        PivotGridControl1.Fields.AddRange(New PivotGridField() {nom, prenom, sitfam, nbenfant, fonction, adresse, ville, moi, base, irg})
            ButtonX1.Enabled = True
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub

    Private Sub ButtonX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX1.Click
        Try
            Dim s As New SaveFileDialog
            s.DefaultExt = "*.xlsx"
            s.Title = "Choisisez le nom de fichier d'enregistrement"
            s.Filter = "Excel 2010 | *.xlsx"
            If s.ShowDialog = Windows.Forms.DialogResult.OK Then
                PivotGridControl1.ExportToXlsx(s.FileName)
            End If
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub

    Private Sub ResumeIRGannuel_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            For i As Integer = 2000 To Date.Now.Year
                Anne.Items.Add(i)
            Next
            Anne.SelectedIndex = Anne.Items.Count - 1
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub

    Private Sub Anne_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Anne.SelectedIndexChanged
        Try
            ButtonX2.Text = "Afficher le resumer I. R. G. Annuel detaillé " & Anne.Text
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub
End Class