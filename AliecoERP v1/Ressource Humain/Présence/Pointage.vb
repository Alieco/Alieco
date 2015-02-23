Public Class Pointage
    Dim sql As New SQLControl
#Region "function"
    Sub load_fonction()
        If IsConnected("SELECT DISTINCT Fonction FROM Employes ORDER BY Fonction ASC", False) = True Then
            If myDR.HasRows = True Then

                While (myDR.Read())
                    fct.Items.Add(myDR("Fonction"))
                End While
            End If
        End If
    End Sub

  
    Private Sub load_departement()
        If IsConnected("SELECT DISTINCT Département FROM Employes ORDER BY Département ASC", False) = True Then
            If myDR.HasRows = True Then
                departement.Items.Clear()
                While (myDR.Read())
                    departement.Items.Add(myDR("Département"))
                End While
            End If
        End If
    End Sub
    Private Sub load_direction()
        If IsConnected("SELECT DISTINCT Direction FROM Employes ORDER BY Direction ASC", False) = True Then
            If myDR.HasRows = True Then
                direction.Items.Clear()
                While (myDR.Read())
                    direction.Items.Add(myDR("Direction"))
                End While
            End If
        End If
    End Sub
    Private Sub load_motif()
        If IsConnected("SELECT DISTINCT Motif FROM presence_pointage ORDER BY Motif ASC", False) = True Then
            If myDR.HasRows = True Then
                motif.Items.Clear()
                While (myDR.Read())
                    motif.Items.Add(myDR("Motif"))
                End While
            End If
        End If
    End Sub
#End Region
    Private Sub Pointage_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            load_motif()
            load_direction()
            load_departement()
            load_fonction()
            If user_id = 6 Then
                ButtonX3.Enabled = True
            End If
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub

    Private Sub ButtonX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX1.Click
        Try
            search()
            'If sql.VerifiyConnection = True Then
            '    '  sql.RunQuery("SELECT Matricule,Nom,Prénom,DNaissance as 'Date de naissance',Dentrée as 'Date d\'entrée',numTel as 'Num Téléphone',name_service as 'Nom de service',titre_fonction as Fonction,name_direction as Direction,name_departement as Departement,Statut,Sexe,Sit_fam as 'Situation familiale',Adresse,willaya FROM Services, Departement, Direction, Employes, Fonction, willaya WHERE Services.id_departement=Departement.id_departement and Direction.id_direction=Departement.id_direction and Employe.id_service=Services.id_service and Fonction.id_fonction=Employe.id_fonction and willaya.id=Employe.VilleAdr")
            '    'Clipboard.SetText("SELECT employes.Matricule, Nom, Prénom, Direction, date_pointage, Entree1,Sortie1, Entree2,Sortie2,Entree3,Sortie3, absence, HeureSupplementaire, Motif FROM presence_pointage, Employes WHERE Employes.Matricule=presence_pointage.Matricule and date_pointage between  '" & du.Value.ToString("yyyy-MM-dd") & "' and '" & au.Value.ToString("yyyy-MM-dd") & "' and Motif like '%Recuperation%' and Fonction like '%Agent de surveillance%' or Fonction like'%Chef de groupe S%'")
            '    sql.RunQuery("SELECT employes.Matricule, Nom, Prénom, Direction,Fonction,Direction,Département, date_pointage, Entree1,Sortie1, Entree2,Sortie2,Entree3,Sortie3, absence, HeureSupplementaire, Motif FROM presence_pointage, Employes WHERE Employes.Matricule=presence_pointage.Matricule and Matricule=" & mat.Text)
            '    If sql.SQLDS.Tables.Count > 0 Then
            '        Pdgv.DataSource = sql.SQLDS.Tables(0)

            '    End If
            'End If
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub

    Sub search()
        Try
            Pdgv.DataSource = Nothing
            GridView1.ClearDocument()
            Dim q As String = "SELECT Employes.Matricule, Nom, Prénom, Direction,Fonction,Direction,Département, date_pointage, Entree1,Sortie1, Entree2,Sortie2,Entree3,Sortie3, Absence, HeureSupplementaire, Motif FROM presence_pointage, Employes WHERE Employes.Matricule=presence_pointage.Matricule and (date_pointage between '" & du.Value.ToString("yyyy-MM-dd") & "' and '" & au.Value.ToString("yyyy-MM-dd") & "') "
            If mat.Text <> "" Then q += " and Employes.Matricule = '" & mat.Text & "'"
            If fct.SelectedIndex > -1 Then q += " and Fonction like '%" & fct.Text & "%'"
            If direction.SelectedIndex > -1 Then q += " and Direction like '%" & direction.Text & "%'"
            If departement.SelectedIndex > -1 Then q += " and Département like '%" & departement.Text & "%'"
            If motif.SelectedIndex > -1 Then q += " and Motif like '%" & motif.Text & "%'"
            Clipboard.SetText(q)
            sql.RunQuery(q)
            If sql.SQLDS.Tables.Count > 0 Then Pdgv.DataSource = sql.SQLDS.Tables(0)
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub

    'Sub search()
    '    dgv1.DataSource = Nothing
    '    dgv1.Rows.Clear()
    '    Dim q As String = "SELECT * FROM Employes WHERE "
    '    If searchtxt.Text = String.Empty Then q += "1=1" Else q += "(Matricule LIKE '%" & searchtxt.Text & "%' OR Nom like '%" & searchtxt.Text & "%' OR Prénom like '%" & searchtxt.Text & "%' OR Adresse Like '%" & searchtxt.Text & "%')"
    '    If genre.SelectedIndex = 0 Then q += " And (Sexe = 'Monsieur' OR Sexe = 'M')" Else If genre.SelectedIndex = 1 Then q += " And (Sexe = 'F' OR Sexe ='Mademoiselle' OR Sexe ='Madame')"
    '    If region.SelectedIndex > 0 Then q += " And Ville ='" & region.Text & "'"
    '    If situation.SelectedIndex = 0 Then q += " and NC='Confirmé'" Else If situation.SelectedIndex = 1 Then q += " And NC = 'Non Confirmé'"
    '    If fonction.SelectedIndex > 0 Then q += " and Fonction like '%" & fonction.Text & "%'"
    '    If direction.SelectedIndex > 0 Then q += " and Direction like '%" & direction.Text & "%'"
    '    If RadioButton2.Checked = True Then q += " ORDER BY Matricule ASC" Else If genrerd.Checked = True Then q += " ORDER BY Sexe ASC" Else If enrydate.Checked = True Then q += " ORDER BY 'Date_entrée' ASC" Else If dirrd.Checked = True Then q += " ORDER BY Direction ASC" Else If willayid.Checked = True Then q += " ORDER BY Ville ASC"
    '    sql.RunQuery(q)
    '    If sql.SQLDS.Tables.Count > 0 Then dgv1.DataSource = sql.SQLDS.Tables(0)
    '    PictureBox1.Visible = False
    '    searchbtn.Enabled = True
    'End Sub


    Private Sub ButtonItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem1.Click
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

    Private Sub ButtonItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem3.Click
        Try
            Dim s As New SaveFileDialog
            s.DefaultExt = "*.pdf"
            s.Title = "Choisisez le nom de fichier d'enregistrement"
            s.Filter = "Adobe PDF | *.pdf"
            If s.ShowDialog = Windows.Forms.DialogResult.OK Then
                Pdgv.ExportToPdf(s.FileName)
            End If
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub

    Private Sub ButtonX3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX3.Click
        ' AddAttendance.MdiParent = Mainfrm
        Try
            AddAttendance.ShowDialog()
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub
End Class