Imports DevComponents.DotNetBar

Public Class FonctionnaireAjoutCodePapers
    Dim Sql As New SQLControl

    Private Sub load_mat()
        Sql.RunQuery("SELECT employes.Matricule,Nom,prénom,Fonction,direction ,code_papers.* FROM code_papers,employes WHERE employes.Matricule=code_papers.Matricule;")
        If Sql.SQLDS.Tables.Count > 0 Then
            CPdg.DataSource = Sql.SQLDS.Tables(0)
        End If
    End Sub
    Private Sub load_type()
        IsConnected("SELECT * FROM paie_banque WHERE codtab like 'M%';", False)
        If myDR.HasRows Then
            While myDR.Read
                Mod_Paiement.Items.Add(myDR("libtab").ToString)
            End While
        End If

    End Sub
    Private Sub FonctionnaireAjoutCodePapers_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        load_mat()
        load_service()
        load_type()
    End Sub
    Private Sub ModifierToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ModifierToolStripMenuItem.Click
        If GridView1.SelectedRowsCount = 0 Then
            MessageBoxEx.Show("Vous devez selectionner le matricule avant de cliquer modifier", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            mat.Text = GridView1.GetFocusedRowCellValue("Matricule").ToString()
        End If
        ButtonX1.Text = "Modifier le Matricule " & mat.Text
        ButtonX1.Image = My.Resources.edit
    End Sub

    Private Sub SupprimerToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SupprimerToolStripMenuItem.Click
        If GridView1.SelectedRowsCount = 0 Then
            MessageBoxEx.Show("Vous devez selectionner le matricule avant de cliquer supprimer", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            Dim m = GridView1.GetFocusedRowCellValue("Matricule").ToString()
            If m <> Nothing Then
                If MessageBoxEx.Show("Vous voullez vraiment supprimer le matricule ?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                    IsConnected("DELETE FROM code_papers WHERE Matricule='" & m & "' LIMIT 1", True)
                End If
            End If
        End If
        load_mat()
    End Sub

    Private Sub mat_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mat.TextChanged
        If mat.Text.Length = 5 Then
            IsConnected("SELECT employes.Matricule,Nom,prénom,Fonction,direction ,code_papers.* FROM code_papers,employes WHERE employes.Matricule=code_papers.Matricule and code_papers.Matricule=" & mat.Text, False)
            If myDR.HasRows = True Then
                While (myDR.Read)
                    Try
                        Nomlbl.Text = myDR("nom").ToString & " " & myDR("prénom").ToString
                        fonctionlbl.Text = myDR("fonction").ToString
                        Section.Text = myDR("Section").ToString
                        Pos_paiement.Text = myDR("Pos_paiement").ToString
                        Num_SS.Text = myDR("Num_SS").ToString
                        Code_Mut.Text = myDR("Code_Mut").ToString
                        Num_CPT.Text = myDR("Num_CPT").ToString
                        Nombre_enfant.Text = myDR("Nombre_enfant").ToString
                        Nbre_Charge.Text = myDR("Nbre_Charge").ToString
                        Anc_NumSS.Text = myDR("Anc_NumSS").ToString
                        Mod_Paiement.SelectedIndex = myDR("Mod_Paiement").ToString - 1
                        ButtonX1.Text = "Modifier le Matricule " & mat.Text
                        ButtonX1.Image = My.Resources.edit
                        servicelbl.Text = myDR("Affectation").ToString
                    Catch ex As Exception
                        EnvoiError(ex.Message)
                    End Try
                End While
            Else
                IsConnected("SELECT employes.Matricule,Nom,prénom,Fonction,direction  FROM employes WHERE Matricule=" & mat.Text, False)
                If myDR.HasRows = True Then
                    While (myDR.Read)
                        Nomlbl.Text = myDR("nom").ToString & " " & myDR("prénom").ToString
                        fonctionlbl.Text = myDR("fonction").ToString
                    End While
                End If
                End If
        Else
                Nomlbl.Text = ""
                fonctionlbl.Text = ""
                Section.Text = ""
                Affectation.Text = ""
                Pos_paiement.Text = ""
                Num_SS.Text = ""
                Code_Mut.Text = ""
                Num_CPT.Text = ""
                Nombre_enfant.Text = ""
                Nbre_Charge.Text = ""
                Anc_NumSS.Text = ""
            Mod_Paiement.SelectedIndex = -1
            servicelbl.Text = ""
                ButtonX1.Text = "Ajouter"
                ButtonX1.Image = My.Resources.add_button
        End If
    End Sub


    Private Sub ButtonX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX1.Click
        Dim q As String = ""
        If ButtonX1.Text = "Ajouter" Then
            q = "INSERT INTO code_papers(Matricule, Section, Affectation, Pos_paiement, Num_SS, Code_Mut, Num_CPT, Nombre_enfant, Nbre_Charge, Anc_NumSS, Mod_Paiement)VALUES('" & mat.Text & "','" & Section.Text & "', '" & servicelbl.Text & "', '" & Pos_paiement.Text & "','" & Num_SS.Text & "', '" & Code_Mut.Text & "','" & Num_CPT.Text & "', '" & Nombre_enfant.Text & "', '" & Nbre_Charge.Text & "', '" & Anc_NumSS.Text & "', '" & Mod_Paiement.SelectedIndex + 1 & "')"
        Else
            q = "UPDATE  code_papers set Section='" & Section.Text & "', Affectation='" & servicelbl.Text & "', Pos_paiement='" & Pos_paiement.Text & "', Num_SS='" & Num_SS.Text & "', Code_Mut='" & Code_Mut.Text & "', Num_CPT='" & Num_CPT.Text & "', Nombre_enfant='" & Nombre_enfant.Text & "', Nbre_Charge='" & Nbre_Charge.Text & "',Anc_NumSS='" & Anc_NumSS.Text & "', Mod_Paiement='" & Mod_Paiement.SelectedIndex + 1 & "' where Matricule='" & mat.Text & "'Limit 1"
        End If
        If IsConnected(q, True) Then
            MessageBoxEx.Show("Le code a bien été enregistrer", "Succés", MessageBoxButtons.OK, MessageBoxIcon.Information)
            mat.Text = ""
            load_mat()
        End If
        
    End Sub
    Private Sub load_service()
        If IsConnected("SELECT DISTINCT liborg FROM paie_direction ", False) = True Then
            If myDR.HasRows = True Then
                Affectation.Items.Clear()
                While (myDR.Read())
                    Affectation.Items.Add(myDR("liborg"))
                End While
            End If
        End If
    End Sub

    Private Sub Affectation_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Affectation.SelectedIndexChanged
        If IsConnected("SELECT csect FROM paie_direction where liborg='" & Affectation.Text & "' LIMIT 1", False) = True Then
            If myDR.HasRows = True Then
                ' direction.Items.Clear()
                While (myDR.Read())
                    servicelbl.Text = myDR("csect").ToString
                End While
            Else
                servicelbl.Text = ""
            End If
        End If
    End Sub
    Private Sub servicelbl_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles servicelbl.TextChanged
        If IsConnected("SELECT liborg FROM paie_direction where csect='" & servicelbl.Text & "' LIMIT 1", False) = True Then
            If myDR.HasRows = True Then
                While (myDR.Read())
                    Affectation.Text = myDR("liborg").ToString
                End While
            Else
                Affectation.Text = ""
            End If
        End If
    End Sub
End Class