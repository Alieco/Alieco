Imports DevComponents.DotNetBar

Public Class accident

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
        loadAccident()
    End Sub

    Private Sub loadAccident()
        Dim tbl As New DataTable()
        tbl.Columns.Add("ID", GetType(Integer))
        tbl.Columns.Add("Nom de vihecule", GetType(String))
        tbl.Columns.Add("Matricule Vihécule", GetType(String))
        tbl.Columns.Add("Matricule Chauffeur", GetType(String))
        tbl.Columns.Add("Nom et Prénom", GetType(String))
        tbl.Columns.Add("Date d'accident", GetType(String))
        tbl.Columns.Add("Discription d'accident", GetType(String))
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
        If IsConnected("SELECT logistique_parc_accident.*,logistique_parc_vihecule.nom as name,logistique_parc_vihecule.matricule,Employes.matricule as Num,Employes.nom,Employes.prénom FROM logistique_parc_accident,employes,logistique_parc_vihecule WHERE employes.matricule=matricule_c and logistique_parc_vihecule.matricule=matricule_v" & vv & ee, False) Then
            If myDR.HasRows Then
                While myDR.Read
                    tbl.Rows.Add(New Object() {myDR("id").ToString, myDR("name").ToString, myDR("matricule").ToString, myDR("Num").ToString, myDR("nom").ToString & " " & myDR("prénom").ToString, myDR("dateAccident").ToString, myDR("discription").ToString, myDR("entry_date").ToString})
                End While
            End If

        End If
        GridAccident.DataSource = tbl
    End Sub

    Private Sub accident_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        loadDriver()
        loadVihecule()
        loadAccident()
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

    Private Sub EnregistrerBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EnregistrerBtn.Click
        If ChauffeurCmb.SelectedIndex > -1 And ViheculeCmb.SelectedIndex > -1 And dateAccident.Value <> Nothing And DiscriptionTxt.Text <> "" Then
            Dim em = ChauffeurCmb.Text.Split(" - ")
            Dim v = ViheculeCmb.Text.Split("-")

            If IsConnected("INSERT INTO `logistique_parc_accident`(`id`,`matricule_v`,`matricule_c`,`discription`,`dateAccident`,`entry_date`)VALUES(NULL,'" & v(0) & "','" & em(0) & "','" & mysql_escape_string(DiscriptionTxt.Text) & "','" & dateAccident.Value & "',NOW());", True) Then
                MessageBoxEx.Show("L'accident est enregistrer avec succés ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                loadAccident()
            End If
        Else
            MessageBoxEx.Show("Vous avez laissé des champs vides !", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    
    Private Sub ExportBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExportBtn.Click
        Dim s As New SaveFileDialog
        s.DefaultExt = "*.xlsx"
        s.Title = "Choisissez le nom de fichier d'enregistrement"
        s.Filter = "Excel 2010 | *.xlsx"
        If s.ShowDialog = Windows.Forms.DialogResult.OK Then
            GridAccident.ExportToXlsx(s.FileName)
        End If
    End Sub
End Class