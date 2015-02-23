Imports DevComponents.DotNetBar

Public Class AjoutStagiaire
    Private Sub ButtonX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX1.Click
        Try
            Dim jour As String = ""
            If CheckBoxX1.Checked Then
                jour += "Samedi-"
            End If
            If CheckBoxX5.Checked Then
                jour += "Dimanche-"
            End If
            If CheckBoxX4.Checked Then
                jour += "Lundi-"
            End If
            If CheckBoxX3.Checked Then
                jour += "Mardi-"
            End If
            If CheckBoxX2.Checked Then
                jour += "Mercredi-"
            End If
            If CheckBoxX6.Checked Then
                jour += "Jeudi-"
            End If
            Dim q As String = "INSERT INTO stagiaire" & _
                "(Matricule" & _
               ",Nom " & _
               ",Prénom" & _
               ",Date_de_naissance" & _
               ",Lieu_de_naissance" & _
               ",Adresse" & _
               ",Date_de_sortie" & _
               ",Durée" & _
               ",Numéro_de_contrat" & _
              ",Affectation" & _
              ",Jour" & _
              ",Observation" & _
               ",Centre_de_formation" & _
              ",Tel" & _
              ",Install" & _
              ",Date_dEntrée" & _
               ",Spécialité)" & _
            "VALUES" & _
               "('" & mat.Text & "'" & _
               ",'" & nom.Text & "'" & _
               ",'" & prenom.Text & "'" & _
               ",'" & datenais.Value.ToString("yyyy-MM-dd") & "'" & _
               ",'" & lnais.Text & "'" & _
               ",'" & adresse.Text & "'" & _
               ",'" & DateTimeInput3.Value.ToString("yyyy-MM-dd") & "'" & _
               ",'" & duree.Text & "'" & _
                ",'" & numcont.Text & "'" & _
              ",'" & affectation.Text & "'" & _
              ",'" & jour & "'" & _
               ",'" & obs.Text & "'" & _
                ",'" & centrform.Text & "'" & _
                ",'" & numtel.Text & "'" & _
               ",'" & DateTimeInput4.Value.ToString("yyyy-MM-dd") & "'" & _
               ",'" & DateEntry.Value.ToString("yyyy-MM-dd") & "'" & _
               ",'" & spec.Text & "')"


            'Dim auery = "INSERT INTO stagiaire(Matricule,Nom,Prénom,Date_de_naissance,Lieu_de_naissance,Adresse,Date_de_sortie,Durée,Numéro_de_contrat,Affectation,Jour,Observation,Centre_de_formation,Tel,Install,Date_dEntrée,Spécialité) values (" & mat.Text & ", '" & nom.Text & "', '" & prenom.Text & "','" & datenais.Value & "','" & lnais.Text & "'," & adresse.Text & ",'" & DateTimeInput3.Value & "','" & duree.Text & "','" & numcont.Text & "','" & affectation.Text & "','" & jour.Text & "','" & obs.Text & "','" & centrform.Text & "','" & numtel.Text & "','" & numtel.Text & "','" & DateTimeInput4.Value & "', '" & DateEntry.Value & "','" & spec.Text & "')"
            'Clipboard.SetText(q)
            IsConnected(q, False)
            MessageBoxEx.Show("Le Stagiaire a bien été enregistrer", "Succés", MessageBoxButtons.OK, MessageBoxIcon.Information)
            MessageBoxEx.Show("Voulez vous ajouter un autre stagiaire", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Dim frm = New AjoutStagiaire
            frm.MdiParent = Mainfrm
            frm.Show()
            Me.Close()
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub
    Private Sub duree_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles duree.TextChanged
        Try
            If IsNumeric(duree.Text) Then
                Dim datef As New Date
                datef = DateEntry.Value
                DateTimeInput3.Value = datef.AddMonths(duree.Text)
            ElseIf duree.Text <> String.Empty Then
                MsgBox("Veuillez saisir un chiffre")
            End If
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub
    Private Sub AjoutStagiaire_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Me.WindowState = FormWindowState.Maximized
            DateEntry.Value = Date.Now.Date
            Dim a As Integer
            IsConnected("select MAX(Matricule) as Matricule from (select MAX(Matricule) as Matricule FROM employes UNION SELECT MAX(Matricule) as Matricule from stagiaire)  AS T  ", False)
            If myDR.HasRows = True Then
                While (myDR.Read())
                    a = myDR("Matricule")
                End While
            End If
            mat.Text = a + 1
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub
    Private Sub ButtonX2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX2.Click
        Try
            Dim frm = New AjoutStagiaire
            frm.MdiParent = Mainfrm
            frm.Show()
            Me.Close()
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub
End Class