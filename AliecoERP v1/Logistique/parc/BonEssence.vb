Imports DevComponents.DotNetBar

Public Class BonEssence

    Private Sub BonEssence_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        loadDriver()
        loadBons()
    End Sub
    Private Sub loadDriver()
        If IsConnected("SELECT Matricule,Nom,prénom FROM employes WHERE Fonction like '%Chauffeur%'", False) Then
            ChauffeurCmb.Items.Clear()
            If myDR.HasRows Then
                While myDR.Read
                    ChauffeurCmb.Items.Add(myDR("Matricule").ToString & " - " & myDR("Nom").ToString & " " & myDR("prénom").ToString)
                End While
            End If
        End If
    End Sub
    Private Sub loadBons()
        Dim tbl As New DataTable()
        tbl.Columns.Add("Matricule Chauffeur", GetType(String))
        tbl.Columns.Add("Nom et Prénom", GetType(String))
        tbl.Columns.Add("Nombre des bons", GetType(String))
        tbl.Columns.Add("Valeurs (DA)", GetType(String))
        tbl.Columns.Add("Date d'enregistrement", GetType(DateTime))

        Dim ee = ""
        If ChauffeurCmb.SelectedIndex > -1 Then
            Dim em = ChauffeurCmb.Text.Split(" - ")
            ee = " And Employes.matricule='" & em(0) & "'"
        End If
        If IsConnected("SELECT employes.matricule,employes.nom,employes.Prénom,nombre,valeurs,logistique_parc_bons.entry_date FROM logistique_parc_bons,employes WHERE employes.matricule=logistique_parc_bons.matricule " & ee, False) Then
            If myDR.HasRows Then
                While myDR.Read
                    tbl.Rows.Add(New Object() {myDR("matricule").ToString, myDR("nom").ToString & " " & myDR("prénom").ToString, myDR("nombre").ToString & " Bon(s)", myDR("valeurs").ToString & " DA", myDR("entry_date").ToString})
                End While
            End If

        End If
        GridBons.DataSource = tbl
    End Sub


    Private Sub AjoutBonBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AjoutBonBtn.Click
        If ChauffeurCmb.SelectedIndex > -1 And valeurTxt.Text <> String.Empty And quantity.Value > 0 Then
            Dim em = ChauffeurCmb.Text.Split(" - ")

            If IsConnected("INSERT INTO `logistique_parc_bons`(`id`,`matricule`,`nombre`,`valeurs`,`entry_date`)VALUES(NULL,'" & em(0) & "','" & quantity.Value & "','" & valeurTxt.Text & "',NOW());", True) Then
                MessageBoxEx.Show("Le Bon est enregistrer avec succés ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                loadBons()
            End If
        Else
            MessageBoxEx.Show("Vous avez laissé des champs vides !", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub quantity_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles quantity.ValueChanged
        If quantity.Value > 0 And IsNumeric(valeurTxt.Text) Then
            Valeurslbl.Text = (quantity.Value * valeurTxt.Text) & " DA "
        Else
            Valeurslbl.Text = ""
        End If
    End Sub

    Private Sub ChauffeurCmb_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChauffeurCmb.SelectedIndexChanged
        loadBons()
    End Sub

    Private Sub valeurTxt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles valeurTxt.TextChanged
        If quantity.Value > 0 And IsNumeric(valeurTxt.Text) Then
            Valeurslbl.Text = (quantity.Value * valeurTxt.Text) & " DA "
        Else
            Valeurslbl.Text = ""
        End If
    End Sub

    Private Sub ExportBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExportBtn.Click
        Dim s As New SaveFileDialog
        s.DefaultExt = "*.xlsx"
        s.Title = "Choisissez le nom de fichier d'enregistrement"
        s.Filter = "Excel 2010 | *.xlsx"
        If s.ShowDialog = Windows.Forms.DialogResult.OK Then
            GridBons.ExportToXlsx(s.FileName)
        End If
    End Sub
End Class