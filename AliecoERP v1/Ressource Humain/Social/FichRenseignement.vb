Imports DevComponents.DotNetBar
Imports DevExpress.XtraEditors.Controls

Public Class FichRenseignement
    Dim sql As New SQLControl
    Dim val As Integer = 0
    Private Sub FichRenseignement_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        load_Matricule_Nom()
        reload()
    End Sub
    'Private Sub ButtonX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    Try
    '        Dim q As String = " INSERT INTO social_n_securite(NSS,Matricule)VALUES ('" & NSS.Text & "','" & ListMatNom.Value & "')"
    '        If IsConnected(q, False) = True Then
    '            MessageBoxEx.Show("La fiche de renseignement a bien été enregistrer", "Succés", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '        End If
    '    Catch ex As Exception
    '        EnvoiError(ex.Message)
    '    End Try
    'End Sub

    Private Sub ButtonX2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX2.Click
        Try
            If ListMatNom.Value = Nothing Then
                MessageBox.Show("Vous devez sélectionner un matricule avant de cliquer ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                If nomconj.Text = "" Then
                    MessageBoxEx.Show("Vous avez laissé le champ Nom conjoint vide !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If
                If prenomconj.Text = "" Then
                    MessageBoxEx.Show("Vous avez laissé le champ Prénom conjoint  vide !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If
                Dim quary As String = ""
                If ButtonX2.Text = "Ajouter" Then
                    quary = " INSERT INTO socialeconjoint(Matricule,NomConj,PrenomConj,DateNaisConj,DateMariage,DateEnregistrement)VALUES('" & ListMatNom.Value & "', '" & mysql_escape_string(nomconj.Text) & "','" & mysql_escape_string(prenomconj.Text) & "','" & mysql_escape_string(datenaisconj.Value.ToString("dd-MM-yyyy")) & "','" & mysql_escape_string(datemarconj.Value.ToString("dd-MM-yyyy")) & "',NOW())"
                    If IsConnected(quary, False) = True Then
                        MessageBoxEx.Show("Le conjoint a bien été enregistrer", "Succés", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        nom.Text = ""
                        prenom.Text = ""
                        Lieux_de_Naissance.Text = ""
                        Date_entrée.Text = ""
                        Fonction.Text = ""
                        Adresse.Text = ""
                        Date_de_Naissance.Text = ""
                        sb.Text = ""
                        NSS.Text = ""
                        ListMatNom.Value = Nothing
                        nomconj.Text = ""
                        prenomconj.Text = ""
                        datenaisconj.Value = Nothing
                        datemarconj.Value = Nothing
                        reload()
                    End If
                Else
                    quary = "UPDATE socialeconjoint SET  NomConj ='" & mysql_escape_string(nomconj.Text) & "',PrenomConj = '" & mysql_escape_string(prenomconj.Text) & "',DateNaisConj = '" & mysql_escape_string(datenaisconj.Value.ToString("dd-MM-yyyy")) & "',DateMariage = '" & mysql_escape_string(datemarconj.Value.ToString("dd-MM-yyyy")) & "' WHERE idSocialeConjoint = '" & val & "'"
                    If IsConnected(quary, False) = True Then
                        MessageBoxEx.Show("La(le) conjoint(e) a bien été modifier", "Succés", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        nom.Text = ""
                        prenom.Text = ""
                        Lieux_de_Naissance.Text = ""
                        Date_entrée.Text = ""
                        Fonction.Text = ""
                        Adresse.Text = ""
                        Date_de_Naissance.Text = ""
                        sb.Text = ""
                        NSS.Text = ""
                        ListMatNom.Value = Nothing
                        nomconj.Text = ""
                        prenomconj.Text = ""
                        datenaisconj.Value = Nothing
                        datemarconj.Value = Nothing
                        reload()
                        ButtonX2.Text = "Ajouter"
                        ButtonX2.Image = My.Resources.add_button
                    End If
                End If
            End If
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub
#Region "Fonctions"
    Private Sub load_Matricule_Nom()
        ListMatNom.Properties.Items.Clear()
        IsConnected("SELECT DISTINCT Matricule,Nom,Prénom FROM employes ", False)
        If myDR.HasRows Then
            While myDR.Read
                ListMatNom.Properties.Items.Add(New ImageComboBoxItem(myDR("Matricule").ToString & " - " & myDR("Nom").ToString & " " & myDR("Prénom").ToString, myDR("Matricule").ToString, 4))
            End While
            ListMatNom.Properties.SmallImages = StatImageList
            ListMatNom.Properties.LargeImages = StatImageList
        End If
    End Sub
    Sub reload()
        Try
            If Sql.VerifiyConnection = True Then
                sql.RunQuery("SELECT distinct Employes.Matricule,Nom,Prénom,S_B_01_14,socialeconjoint.NomConj,socialeconjoint.PrenomConj,socialeconjoint.DateNaisConj,socialeconjoint.DateMariage FROM Employes,socialeconjoint WHERE socialeconjoint.Matricule=Employes.Matricule ")
                If sql.SQLDS.Tables.Count > 0 Then
                    For Each r As DataRow In sql.SQLDS.Tables(0).Rows
                        If r.Item(7).ToString = "00:00:00" Or r.Item(7).ToString = "01-01-0001" Or r.Item(7).ToString = "01/01/0001" Then
                            r.Item(7) = ""
                        End If
                        If r.Item(6).ToString = "00:00:00" Or r.Item(6).ToString = "01-01-0001" Or r.Item(6).ToString = "01/01/0001" Then
                            r.Item(6) = ""
                        End If
                    Next
                    Conjdg.DataSource = sql.SQLDS.Tables(0)
                End If
                ' DGFonc.PerformLayout()
            End If
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub
#End Region
    Private Sub ListMatNom_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ListMatNom.SelectedIndexChanged
        Try
            If ListMatNom.Value.ToString.Length = 5 Then
                IsConnected("SELECT distinct Employes.Matricule,Nom,Prénom,Lieux_de_Naissance,Date_entrée,Fonction,Adresse,Date_de_Naissance,S_B_01_14,code_papers.Num_SS FROM Employes LEFT JOIN code_papers ON code_papers.Matricule=Employes.Matricule WHERE Employes.Matricule='" & ListMatNom.Value & "'", False)
                If myDR.HasRows = True Then
                    While (myDR.Read)
                        Try
                            nom.Text = myDR("Nom").ToString
                            prenom.Text = myDR("Prénom").ToString
                            Lieux_de_Naissance.Text = myDR("Lieux_de_Naissance").ToString
                            Date_entrée.Text = myDR("Date_entrée").ToString
                            Fonction.Text = myDR("Fonction").ToString
                            Adresse.Text = myDR("Adresse").ToString
                            Date_de_Naissance.Text = myDR("Date_de_Naissance").ToString
                            sb.Text = myDR("S_B_01_14").ToString
                            NSS.Text = myDR("Num_SS").ToString
                        Catch ex As Exception
                            EnvoiError(ex.Message)
                        End Try
                    End While
                End If
            End If
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub

    Private Sub ActualiserToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ActualiserToolStripMenuItem.Click
        Try
            reload()
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub
    'Private Sub AjouterToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles AjouterToolStripMenuItem.Click
    '    AjoutArretTravail.Ajouter.Text = "Ajouter"
    '    AjoutArretTravail.Ajouter.Image = My.Resources.add_button
    '    AjoutArretTravail.Text = "Ajouter un(e) conjoint(e) "
    'End Sub
    Private Sub ModifierToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ModifierToolStripMenuItem.Click
        If GridView1.SelectedRowsCount = 0 Then
            MessageBoxEx.Show("Vous devez selectionner le matricule avant de cliquer modifier", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            ListMatNom.Value = GridView1.GetFocusedRowCellValue("Matricule").ToString()
            nomconj.Text = GridView1.GetFocusedRowCellValue("NomConj").ToString()
            prenomconj.Text = GridView1.GetFocusedRowCellValue("PrenomConj").ToString()
            datenaisconj.Text = GridView1.GetFocusedRowCellValue("DateNaisConj").ToString()
            datemarconj.Text = GridView1.GetFocusedRowCellValue("DateMariage").ToString()
        End If
        ' Me.Text = "Modifier la(e) conjoint(e)" &
        ButtonX2.Text = "Modifier "
        ButtonX2.Image = My.Resources.edit
        'If ListMatNom.Value <> Nothing Then
        '    IsConnected("SELECT distinct Matricule,NomConj,PrenomConj,DateNaisConj,DateMariage FROM socialeconjoint WHERE Matricule='" & ListMatNom.Value & "'", False)
        '    If myDR.HasRows = True Then
        '        While (myDR.Read)
        '            nomconj.Text = myDR("NomConj").ToString
        '            prenomconj.Text = myDR("PrenomConj").ToString
        '            datenaisconj.Text = myDR("DateNaisConj").ToString
        '            datemarconj.Text = myDR("DateMariage").ToString
        '        End While
        '    End If
        'End If
        If ListMatNom.Value <> Nothing Then
            IsConnected("SELECT idSocialeConjoint FROM socialeconjoint WHERE Matricule='" & ListMatNom.Value & "' and NomConj='" & nomconj.Text & "'", False)
            If myDR.HasRows = True Then
                While (myDR.Read)
                    val = myDR("idSocialeConjoint").ToString
                End While
            End If
        End If
    End Sub
    Private Sub SupprimerToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles SupprimerToolStripMenuItem.Click
        Try
            Dim val1 As Integer = 0
            If GridView1.SelectedRowsCount = 0 Then
                MessageBoxEx.Show("Vous devez selectionner un(e) conjoint(e) avant de cliquer supprimer", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                Dim m = GridView1.GetFocusedRowCellValue("Matricule").ToString()
                Dim NomConj = GridView1.GetFocusedRowCellValue("NomConj").ToString()
                If m <> Nothing Then
                    If MessageBoxEx.Show("Vous voullez vraiment supprimer la(e) conjoint(e) ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                        IsConnected("select idSocialeConjoint from socialeconjoint where Matricule='" & m & "' and NomConj='" & NomConj & "'", False)
                        If myDR.HasRows Then
                            While myDR.Read
                                val1 = myDR("idSocialeConjoint")
                            End While
                        End If
                        IsConnected("DELETE FROM socialeconjoint WHERE Matricule='" & m & "' and idSocialeConjoint=" & val1 & " limit 1", True)
                        ' ButtonX3.PerformClick()
                        reload()
                    End If
                End If
            End If
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub
End Class