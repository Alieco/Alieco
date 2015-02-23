Imports DevComponents.DotNetBar
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraSpreadsheet.Model

Public Class AjoutEnfant
    Dim sql As New SQLControl
    Dim val As Integer = 0
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
            If sql.VerifiyConnection = True Then
                sql.RunQuery("SELECT distinct Employes.Matricule,Nom,Prénom,PrenomEnfant,DateNaisEnfant,ObsEnf FROM Employes,socialenf WHERE socialenf.Matricule=Employes.Matricule ")
                If sql.SQLDS.Tables.Count > 0 Then
                    enfantdgv.DataSource = sql.SQLDS.Tables(0)
                End If
                ' DGFonc.PerformLayout()
                'For i As Integer = 0 To GridView1.DataRowCount - 1
                '    '' If GridView1.GetFocusedRowCellValue("Nom").ToString = myDR("Nom") And GridView1.GetFocusedRowCellValue("Prénom").ToString = myDR("Prénom") Then
                '    '' MessageBoxEx.Show(GridView1.GetRowCellValue(i, "Matricule").ToString())

                '    If GridView1.GetRowCellValue(i, "Nom").ToString() = myDR("Nom") And GridView1.GetRowCellValue(i, "Prénom").ToString() = myDR("Prénom") Then

                '        GridView1.SetRowCellValue(i, "Nom", "")
                '        GridView1.SetRowCellValue(i, "Prénom", "")
                '    End If

                '    ' End If
                'Next i
            End If
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub
#End Region
    Private Sub AjoutEnfant_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        load_Matricule_Nom()
        reload()
    End Sub

    Private Sub ListMatNom_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ListMatNom.SelectedIndexChanged
        Try
            'If ListMatNom.Value = Nothing Then
            '    MessageBox.Show("Vous devez sélectionner un enfant avant de cliquer ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            '    ButtonX2.Enabled = False
            'Else
            '    ButtonX2.Enabled = True
            'End If
            If ListMatNom.Value.ToString.Length = 5 Then
                IsConnected("SELECT distinct Employes.Matricule,Nom,Prénom,Lieux_de_Naissance,Date_entrée,Fonction,Adresse,Date_de_Naissance,S_B_01_14,code_papers.Num_SS FROM Employes left join code_papers on code_papers.Matricule=Employes.Matricule WHERE Employes.Matricule='" & ListMatNom.Value & "'", False)
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

    Private Sub SupprimerToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles SupprimerToolStripMenuItem.Click
        Try
            Dim val1 As Integer = 0
            If GridView1.SelectedRowsCount = 0 Then
                MessageBoxEx.Show("Vous devez selectionner  un enfant avant de cliquer supprimer", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                Dim m = GridView1.GetFocusedRowCellValue("Matricule").ToString()
                Dim pren = GridView1.GetFocusedRowCellValue("PrenomEnfant").ToString()
                If m <> Nothing Then
                    If MessageBoxEx.Show("Vous voullez vraiment supprimer cet enfant ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                        IsConnected("select idSocialEnf from socialenf where Matricule='" & m & "' and PrenomEnfant='" & pren & "'", False)
                        If myDR.HasRows Then
                            While myDR.Read
                                val1 = myDR("idSocialEnf")
                            End While
                        End If
                        IsConnected("DELETE FROM socialenf WHERE Matricule='" & m & "' and idSocialEnf=" & val1 & " limit 1", True)
                        ' ButtonX3.PerformClick()
                        reload()
                    End If
                End If
            End If
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub

    Private Sub ButtonX2_Click(sender As System.Object, e As System.EventArgs) Handles ButtonX2.Click
        Try
            If ListMatNom.SelectedIndex = -1 Then
                MessageBox.Show("Vous devez sélectionner un matricule avant de cliquer ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                Dim q As String = ""
                If ButtonX2.Text = "Ajouter" Then
                    If datenaisenf.Value = Nothing Then
                        MessageBoxEx.Show("Vous avez laissé le champ  Date de Naissance vide !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Sub
                    End If
                    If prenomenf.Text = "" Then
                        MessageBoxEx.Show("Vous avez laissé le champ Prénom d'enfant vide !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Sub
                    End If
                    q = "INSERT INTO socialenf (Matricule,PrenomEnfant,DateNaisEnfant,ObsEnf,DateEnregistrement)VALUES('" & ListMatNom.Value & "','" & mysql_escape_string(prenomenf.Text) & "','" & mysql_escape_string(datenaisenf.Value.ToString("dd-MM-yyyy")) & "','" & mysql_escape_string(obsenf.Text) & "',NOW())"
                    If IsConnected(q, False) Then
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
                        prenomenf.Text = ""
                        datenaisenf.Text = ""
                        obsenf.Text = ""
                        reload()
                    End If
                Else
                    'q = "DELETE FROM socialenf WHERE Matricule = '" & ListMatNom.Value & "' limit 30"
                    'q = "INSERT INTO socialenf (Matricule,PrenomEnfant,DateNaisEnfant,ObsEnf)VALUES('" & ListMatNom.Value & "','" & mysql_escape_string(prenomenf.Text) & "','" & mysql_escape_string(datenaisenf.Value.ToString("dd-MM-yyyy")) & "','" & mysql_escape_string(obsenf.Text) & "')"
                    q = "UPDATE socialenf SET PrenomEnfant ='" & mysql_escape_string(prenomenf.Text) & "',DateNaisEnfant = '" & mysql_escape_string(datenaisenf.Value.ToString("dd-MM-yyyy")) & "',ObsEnf = '" & mysql_escape_string(obsenf.Text) & "',DateEnregistrement=Now() WHERE idSocialEnf = '" & val & "'limit 1"
                    If IsConnected(q, False) Then
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
                        prenomenf.Text = ""
                        datenaisenf.Text = ""
                        obsenf.Text = ""
                        ButtonX2.Text = "Ajouter"
                        ButtonX2.Image = My.Resources.add_button
                        reload()
                    End If
                End If
            End If
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub

    Private Sub ModifierToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ModifierToolStripMenuItem.Click
        Try
            If GridView1.SelectedRowsCount = 0 Then
                MessageBoxEx.Show("Vous devez selectionner le matricule avant de cliquer modifier", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                ListMatNom.Value = GridView1.GetFocusedRowCellValue("Matricule").ToString()
                prenomenf.Text = GridView1.GetFocusedRowCellValue("PrenomEnfant").ToString()
                datenaisenf.Text = GridView1.GetFocusedRowCellValue("DateNaisEnfant").ToString()
                obsenf.Text = GridView1.GetFocusedRowCellValue("ObsEnf").ToString()
            End If
            ' Me.Text = "Modifier " &
            ButtonX2.Text = "Modifier "
            ButtonX2.Image = My.Resources.edit
            If ListMatNom.Value <> Nothing Then
                IsConnected("SELECT idSocialEnf FROM socialenf WHERE Matricule='" & ListMatNom.Value & "' and PrenomEnfant='" & prenomenf.Text & "'", False)
                If myDR.HasRows = True Then
                    While (myDR.Read)
                        val = myDR("idSocialEnf").ToString
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
End Class