Imports DevComponents.DotNetBar

Public Class EffictifEnFormation
    Dim sql As New SQLControl
    Private Sub EffictifEnFormation_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Me.WindowState = FormWindowState.Maximized
            Dim spe() As String = {"Cadre", "Maitrise", "Execution"}
            specialite.Items.AddRange(spe)
            load_nf()
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub
    Private Sub load_nf()
        Try
            If IsConnected("SELECT DISTINCT(NatureFormation) FROM Planformation ", False) = True Then
                natureformation.Items.Clear()
                If myDR.HasRows = True Then
                    While (myDR.Read())
                        natureformation.Items.Add(myDR("NatureFormation"))
                    End While
                End If
            End If
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub
    Private Sub load_fonctionnaire()
        Try
            If sql.VerifiyConnection = True Then
                sql.RunQuery("SELECT employes.Matricule,nom,prénom,fonction,Specialite,NatureFormation,Duree FROM alieco.effictif_formation,employes,planformation WHERE effictif_formation.matricule=employes.Matricule AND effictif_formation.id_formation=planformation.idFormation and planformation.Specialite='" & specialite.Text & "' AND planformation.NatureFormation='" & natureformation.Text & "'")
                ' Clipboard.SetText("SELECT employes.Matricule,nom,prénom,fonction,Specialite,NatureFormation,Duree FROM alieco.effictif_formation,employes,planformation WHERE effictif_formation.matricule=employes.Matricule AND effictif_formation.id_formation=planformation.idFormation and planformation.Specialite='" & specialite.Text & "' AND planformation.NatureFormation='" & natureformation.Text & "'")
                If sql.SQLDS.Tables.Count > 0 Then
                    DataGridViewX1.DataSource = sql.SQLDS.Tables(0)
                End If
                fonctiuonnairecount.Text = sql.SQLDS.Tables(0).Rows.Count
            End If
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub

    Private Sub specialite_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles specialite.SelectedIndexChanged
        Try
            If specialite.SelectedIndex > -1 Then
                If IsConnected("SELECT DISTINCT(NatureFormation) FROM Planformation WHERE Specialite like '%" & specialite.Text & "%'", False) = True Then
                    natureformation.Items.Clear()

                    If myDR.HasRows = True Then
                        While (myDR.Read())
                            natureformation.Items.Add(myDR("NatureFormation"))
                        End While
                        natureformation.Text = String.Empty
                        prevu.Text = String.Empty
                        alternance.Text = String.Empty
                        idformation.Text = String.Empty
                        fonctiuonnairecount.Text = String.Empty
                    End If
                End If
            End If
            If specialite.SelectedIndex > -1 And natureformation.SelectedIndex > -1 Then
                Dim querry As String
                querry = "select * from Planformation WHERE Specialite like '%" & specialite.Text & "%' and NatureFormation like'%" & natureformation.Text & "%'"
                IsConnected(querry, False)
                If myDR.HasRows = True Then
                    While (myDR.Read())
                        prevu.Text = myDR("effectifPrevu")
                        alternance.Text = myDR("Alternance")
                        idformation.Text = myDR("idFormation")
                    End While
                End If
            End If
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub

    Private Sub natureformation_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles natureformation.SelectedIndexChanged
        Try
            If specialite.SelectedIndex > -1 And natureformation.SelectedIndex > -1 Then
                Dim querry As String
                querry = "select * from Planformation WHERE Specialite like '%" & specialite.Text & "%' and NatureFormation like'%" & natureformation.Text & "%'"
                IsConnected(querry, False)
                If myDR.HasRows = True Then
                    While (myDR.Read())
                        prevu.Text = myDR("effectifPrevu")
                        alternance.Text = myDR("Alternance")
                        idformation.Text = myDR("idFormation")
                    End While
                End If
                load_fonctionnaire()
            End If
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub


    Private Sub mat_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mat.TextChanged
        Try
            If mat.TextLength = 5 Then
                IsConnected("SELECT * FROM Employes WHERE Matricule=" & mat.Text, False)
                If myDR.HasRows = True Then
                    While (myDR.Read)
                        Try
                            nom.Text = myDR("Nom").ToString
                            prenom.Text = myDR("Prénom").ToString
                            datenais.Value = myDR("Date_de_Naissance").ToString
                            'MsgBox(region2.SelectedIndex)
                        Catch ex As Exception
                            MsgBox(ex.Message)
                        End Try

                    End While
                End If
            End If
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub

    Private Sub ButtonX3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX3.Click
        load_fonctionnaire()
    End Sub

    Private Sub ButtonX2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX2.Click
        Try
            If idformation.Text = String.Empty Then
                MessageBoxEx.Show("Vous devez choisir la formation que vous voulez assigné", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            If mat.Text = String.Empty Then
                MessageBoxEx.Show("Vous devez choisir un fonctionnaire", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            Try
                If IsConnected("INSERT INTO effictif_formation VALUES(NULL," & idformation.Text & "," & mat.Text & ",NOW())", True) = True Then
                    MessageBoxEx.Show("Le fonctionnaire à été ajouté avec succés au formation", "opération réussie", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    load_fonctionnaire()
                End If
            Catch ex As Exception
                MessageBoxEx.Show(ex.Message)
            End Try
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub

    Private Sub ButtonX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX1.Click
        Try
            If DataGridViewX1.SelectedRows.Count > 0 Then
                If MessageBoxEx.Show("Voullez vous vraiment supprimer ce(s) fonctionnaire(s) ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                    For Each r As DataGridViewRow In DataGridViewX1.SelectedRows
                        If Not r.IsNewRow Then
                            ' MessageBox.Show(r.Cells(0).Value.ToString & "," & r.Cells(1).Value.ToString)
                            IsConnected("DELETE FROM  effictif_formation WHERE matricule =" & r.Cells(0).Value.ToString & " AND id_formation=" & idformation.Text & " LIMIT 1", True)
                        End If
                    Next
                    load_fonctionnaire()
                End If
            Else
                MessageBoxEx.Show("Vous devez choisir une présence avant de cliquer sur supprimer", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub
End Class