Imports DevComponents.DotNetBar

Public Class SuiviCaution

    Private Sub SuiviCaution_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            ListView1.Items.Clear()
            load_codeAffaire()
            loadModalite()
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub
    Sub load_codeAffaire()
        Try
            codeaffaire.Items.Clear()
            Dim query = "SELECT DISTINCT(code_affaire) from commercial_affaire, users where charge_affaire=user_id "
            If IsConnected(query, False) Then
                If myDR.HasRows Then
                    While myDR.Read
                        codeaffaire.Items.Add(myDR("code_affaire"))
                    End While
                End If
            End If
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub
    Sub load_titreaffaire()
        Try
            Dim query = "SELECT DISTINCT(titre) from commercial_affaire where code_affaire='" & codeaffaire.Text & "'"
            If IsConnected(query, False) Then
                If myDR.HasRows Then
                    While myDR.Read
                        titreaffaire.Text = myDR("titre")
                        'desig.Text = myDR("designation")
                    End While
                End If
            End If
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub

    Private Sub codeaffaire_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles codeaffaire.SelectedIndexChanged
        Try
            If codeaffaire.Text <> "" Then
                loadModalite()
                load_titreaffaire()
            End If
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub

    Private Sub ButtonX2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX2.Click
        Try
            If ButtonX2.Text = "Ajouter" Then
                IsConnected("INSERT INTO commercial_affaire_caution VALUES(NULL, '" & mysql_escape_string(typecaution.Text) & "', '" & montantc.Text & "', '" & codeaffaire.Text & "', Now(), '" & mysql_escape_string(etatcaution.Text) & "') ", True)
                typecaution.Text = ""
                titreaffaire.Text = ""
                montantc.Text = ""
                'codeaffaire.Text = ""
                etatcaution.Text = ""
                loadModalite()
            Else
                IsConnected("Delete from commercial_affaire_caution WHERE code_affaire ='" & codeaffaire.Text & "' limit 1", True)
                IsConnected("INSERT INTO commercial_affaire_caution VALUES(NULL, '" & mysql_escape_string(typecaution.Text) & "', '" & montantc.Text & "', '" & codeaffaire.Text & "', Now(), '" & mysql_escape_string(etatcaution.Text) & "') ", True)
                typecaution.Text = ""
                titreaffaire.Text = ""
                montantc.Text = ""
                'codeaffaire.Text = ""
                etatcaution.Text = ""
                loadModalite()
                ButtonX2.Text = "Ajouter"
            End If
            'For i = 0 To ListView1.Items.Count - 1
            '    Try
            '        Dim quary1 = " INSERT INTO commercial_oe_ensemble_general VALUES(NULL,'" & ListView1.Items(i).SubItems(0).Text & "','" & ListView1.Items(i).SubItems(1).Text & "','" & ListView1.Items(i).SubItems(2).Text & "','" & aff & "', Now());"
            '        Clipboard.SetText(quary1)
            '        If IsConnected(quary1, True) = False Then
            '            erreur = True
            '        End If
            '    Catch ex As MySqlException
            '        MessageBox.Show(ex.Message)
            '    End Try
            'Next
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub
    Private Sub loadModalite()
        Try
            ListView1.Items.Clear()
            IsConnected("SELECT * FROM commercial_affaire, commercial_affaire_caution where commercial_affaire.code_affaire= commercial_affaire_caution.code_affaire and commercial_affaire.code_affaire='" & codeaffaire.Text & "'", False)
            If myDR.HasRows Then
                While myDR.Read
                    Dim item As ListViewItem = New ListViewItem(myDR("code_affaire").ToString)
                    item.SubItems.Add(myDR("designation").ToString)
                    item.SubItems.Add(myDR("montant").ToString)
                    item.SubItems.Add(myDR("etat_caution").ToString)
                    item.SubItems.Add(myDR("entry_date").ToString)
                    item.SubItems.Add(myDR("text").ToString)
                    ListView1.Items.Add(item)
                End While
            End If
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub
    Private Sub ModifierOffreToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ModifierOffreToolStripMenuItem.Click
        Try
            If ListView1.SelectedItems.Count > 0 Then
                Dim n = ListView1.SelectedItems.Count
                codeaffaire.Text = ListView1.SelectedItems(0).Text
                typecaution.Text = ListView1.SelectedItems(0).SubItems(5).Text
                montantc.Text = ListView1.SelectedItems(0).SubItems(2).Text
                titreaffaire.Text = ListView1.SelectedItems(0).SubItems(1).Text
                etatcaution.Text = ListView1.SelectedItems(0).SubItems(3).Text
                ButtonX2.Text = "Modifier"
            Else
                MessageBoxEx.Show("Vous devez selectionner une affaire avant de cliquer modifier", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub

    Private Sub SuiviCaution_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        Try
            codeaffaire.Text = ""
            titreaffaire.Clear()
            typecaution.Text = ""
            montantc.Clear()
            etatcaution.Text = ""
            ListView1.Clear()
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub
End Class