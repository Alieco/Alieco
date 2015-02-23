Imports DevExpress.XtraPivotGrid

Public Class tableucroiseAgentDeSecurite
    Dim sql As New SQLControl
    Dim matricule As PivotGridField
    Private Sub ButtonX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX1.Click
        PivotGridControl1.DataSource = Nothing
        Try
            Dim q = "SELECT Employes.Matricule, Nom, Prénom, date_pointage,date_format(date_pointage,'%d') as jour, Absence FROM presence_pointage, Employes WHERE Employes.Matricule=presence_pointage.Matricule and (date_pointage between '" & du.Value.ToString("yyyy-MM-dd") & "' and '" & au.Value.ToString("yyyy-MM-dd") & "') and (Fonction like '%Agent de surveillance%' or Fonction like'%Chef de groupe S%') "
            Clipboard.SetText(q)
            sql.RunQuery(q)
            If sql.SQLDS.Tables.Count > 0 Then PivotGridControl1.DataSource = sql.SQLDS.Tables(0)
            ' Create a row PivotGridControl field bound to the Country datasource field.
        matricule = New PivotGridField("Matricule", PivotArea.RowArea)
        Dim nom As PivotGridField = New PivotGridField("Nom", PivotArea.RowArea)
        Dim prenom As PivotGridField = New PivotGridField("Prénom", PivotArea.RowArea)
        nom.Visible = False
        prenom.Visible = False
        Dim unboundField As PivotGridField = New PivotGridField
        unboundField.Caption = "nom & prénom"
        unboundField.Name = "noml"
        unboundField.ValueFormat.FormatType = PivotArea.RowArea
        unboundField.UnboundType = DevExpress.Data.UnboundColumnType.String

        Dim direction As PivotGridField = New PivotGridField("Direction", PivotArea.RowArea)
        ' Create a filter PivotGridControl field bound to the ProductName datasource field.
        Dim moi As PivotGridField = New PivotGridField("date_pointage", PivotArea.ColumnArea)
        moi.Caption = "Mois"
        moi.GroupInterval = PivotGroupInterval.DateMonth

        ' Create a column PivotGridControl field bound to the OrderDate datasource field.
        Dim jour As PivotGridField = New PivotGridField("jour", PivotArea.ColumnArea)
        jour.Caption = "Jour"
        ' jour.GroupInterval = PivotGroupInterval.DateDay


        ' Create a data PivotGridControl field bound to the 'Extended Price' datasource field.
        Dim abs As PivotGridField = New PivotGridField("Absence", PivotArea.DataArea)

        ' Add the fields to the control's field collection.         
        PivotGridControl1.Fields.AddRange(New PivotGridField() {direction, matricule, unboundField, nom, prenom, moi, jour, abs})
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
                PivotGridControl1.ExportToXlsx(s.FileName)
            End If
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub
End Class