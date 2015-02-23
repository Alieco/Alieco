Public Class listDrivers

    Private Sub listDrivers_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        GridDrivers.DataSource = loadDrivers()

    End Sub

    Private Function loadDrivers()

        Dim tbl As New DataTable()
        tbl.Columns.Add("Matricule", GetType(String))
        tbl.Columns.Add("Nom et Prénom", GetType(String))
        tbl.Columns.Add("Date de naissance", GetType(DateTime))
        tbl.Columns.Add("Fonction", GetType(String))
        tbl.Columns.Add("Statut", GetType(String))
        '  tbl.Columns.Add("Energie", GetType(String))
        '  tbl.Columns.Add("Date d'enregistrement", GetType(DateTime))
        If IsConnected("SELECT Statut,Matricule,Nom,prénom,fonction,Date_de_Naissance FROM employes WHERE Fonction like '%Chauffeur%'", False) Then
            If myDR.HasRows Then
                While myDR.Read
                    tbl.Rows.Add(New Object() {myDR("Matricule").ToString, myDR("Nom").ToString & " " & myDR("prénom").ToString, myDR("Date_de_Naissance").ToString, myDR("Fonction").ToString, myDR("Statut").ToString})
                End While
            End If

        End If
        Return tbl
    End Function

    Private Sub SearchTxt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SearchTxt.TextChanged
        GridView1.FindFilterText = SearchTxt.Text
    End Sub

    Private Sub ButtonX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX1.Click
        Dim s As New SaveFileDialog
        s.DefaultExt = "*.xlsx"
        s.Title = "Choisissez le nom de fichier d'enregistrement"
        s.Filter = "Excel 2010 | *.xlsx"
        If s.ShowDialog = Windows.Forms.DialogResult.OK Then
            GridDrivers.ExportToXlsx(s.FileName)
        End If
    End Sub
End Class