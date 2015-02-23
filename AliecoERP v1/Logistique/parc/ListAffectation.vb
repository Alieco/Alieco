Public Class ListAffectation

    Private Sub ListAffectation_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        loadDriver()
        loadVihecule()
        loadAffectation()
    End Sub

    Private Sub loadVihecule()
        If IsConnected("SELECT * FROM logistique_parc_vihecule", False) Then
            ViheculeCmb.Items.Clear()
            If myDR.HasRows Then
                While myDR.Read
                    ViheculeCmb.Items.Add(myDR("Matricule").ToString & " - " & myDR("Nom").ToString)
                End While
            End If
        End If
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
    Private Sub loadAffectation()
        Dim tbl As New DataTable()
        tbl.Columns.Add("ID", GetType(Integer))
        tbl.Columns.Add("Nom de vihecule", GetType(String))
        tbl.Columns.Add("Matricule Vihécule", GetType(String))
        tbl.Columns.Add("Matricule Chauffeur", GetType(String))
        tbl.Columns.Add("Nom et Prénom", GetType(String))
        tbl.Columns.Add("Date et Temps de Sotrie", GetType(String))
        tbl.Columns.Add("Date et Temps de Retour", GetType(String))
        tbl.Columns.Add("Date d'enregistrement", GetType(DateTime))
        Dim vv = ""
        If ViheculeCmb.SelectedIndex > -1 Then
            Dim v = ViheculeCmb.Text.Split("-")
            vv = " And logistique_parc_vihecule.matricule='" & v(0) & "'"
        End If
        Dim ee = ""
        If ChauffeurCmb.SelectedIndex > -1 Then
            Dim em = ChauffeurCmb.Text.Split(" - ")
            ee = " And Employes.matricule='" & em(0) & "'"
        End If
        If IsConnected("SELECT logistique_parc_affectation.*,logistique_parc_vihecule.nom as name,logistique_parc_vihecule.matricule,Employes.matricule as Num,Employes.nom,Employes.prénom FROM logistique_parc_affectation,employes,logistique_parc_vihecule WHERE employes.matricule=matricule_chaufeur and logistique_parc_vihecule.matricule=matricule_vihecule" & vv & ee, False) Then
            If myDR.HasRows Then
                While myDR.Read
                    tbl.Rows.Add(New Object() {myDR("id").ToString, myDR("name").ToString, myDR("matricule").ToString, myDR("Num").ToString, myDR("nom").ToString & " " & myDR("prénom").ToString, myDR("date_sortie").ToString, myDR("date_retour").ToString, myDR("entry_date").ToString})
                End While
            End If

        End If
        GridAfffectations.DataSource = tbl
    End Sub

    Private Sub ViheculeCmb_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViheculeCmb.SelectedIndexChanged
        LabelControl1.Text = ""
        LabelControl2.Text = ""
        LabelControl3.Text = ""
        LabelControl6.Text = ""
        LabelControl5.Text = ""
        LabelControl4.Text = ""
        Dim im As Image = Nothing
        ViheculeImg.Image = im
        If ViheculeCmb.SelectedIndex > -1 And ViheculeCmb.Text.Contains("-") Then

            Dim s = ViheculeCmb.Text.Split("-")
            If s(0) <> "" Then
                If IsConnected("SELECT * FROM logistique_parc_vihecule WHERE matricule='" & s(0) & "' LIMIT 1", False) Then
                    If myDR.HasRows Then
                        While myDR.Read

                            If Not IsDBNull(myDR("photo")) Then
                                Dim lb() As Byte = myDR("photo")
                                Dim lstr As New System.IO.MemoryStream(lb)
                                ViheculeImg.Image = Image.FromStream(lstr)
                                lstr.Close()
                            End If
                            LabelControl1.Text = myDR("nom").ToString
                            LabelControl2.Text = myDR("marque").ToString
                            LabelControl3.Text = myDR("matricule").ToString
                            LabelControl5.Text = myDR("energie").ToString
                            LabelControl4.Text = myDR("entry_date").ToString
                            LabelControl6.Text = myDR("remarque").ToString
                        End While
                    End If

                End If
            End If
        End If
        loadAffectation()
    End Sub

    Private Sub ChauffeurCmb_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChauffeurCmb.SelectedIndexChanged
        loadAffectation()
    End Sub

    Private Sub ButtonX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX1.Click
        Dim s As New SaveFileDialog
        s.DefaultExt = "*.xlsx"
        s.Title = "Choisissez le nom de fichier d'enregistrement"
        s.Filter = "Excel 2010 | *.xlsx"
        If s.ShowDialog = Windows.Forms.DialogResult.OK Then
            GridAfffectations.ExportToXlsx(s.FileName)
        End If
    End Sub

    Private Sub ViheculeCmb_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViheculeCmb.TextChanged
        If ViheculeCmb.Text = String.Empty Then
            LabelControl1.Text = ""
            LabelControl2.Text = ""
            LabelControl3.Text = ""
            LabelControl6.Text = ""
            LabelControl5.Text = ""
            LabelControl4.Text = ""
            Dim im As Image = Nothing
            ViheculeImg.Image = im
        End If
    End Sub
End Class