Imports DevComponents.DotNetBar

Public Class RecuperationFormation
    Dim sql As New SQLControl
    Private Sub specialite_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles specialite.SelectedIndexChanged
        If specialite.SelectedIndex > -1 Then
            If IsConnected("SELECT DISTINCT(NatureFormation) FROM Planformation WHERE Specialite like '%" & specialite.Text & "%'", False) = True Then
                natureformation.Items.Clear()

                If myDR.HasRows = True Then
                    While (myDR.Read())
                        natureformation.Items.Add(myDR("NatureFormation"))
                    End While
                    natureformation.Text = String.Empty
                    idformation.Text = String.Empty
                End If
            End If
        End If
        If specialite.SelectedIndex > -1 And natureformation.SelectedIndex > -1 Then
            Dim querry As String
            querry = "select * from Planformation WHERE Specialite like '%" & specialite.Text & "%' and NatureFormation like'%" & natureformation.Text & "%'"
            IsConnected(querry, False)
            If myDR.HasRows = True Then
                While (myDR.Read())
                    idformation.Text = myDR("idFormation")
                End While
            End If
        End If
    End Sub

    Private Sub natureformation_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles natureformation.SelectedIndexChanged
        If specialite.SelectedIndex > -1 And natureformation.SelectedIndex > -1 Then
            Dim querry As String
            querry = "select * from Planformation WHERE Specialite like '%" & specialite.Text & "%' and NatureFormation like'%" & natureformation.Text & "%'"
            IsConnected(querry, False)
            If myDR.HasRows = True Then
                While (myDR.Read())
                    idformation.Text = myDR("idFormation")
                End While
            End If
            load_presence()
        End If
    End Sub

    Private Sub mat_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mat.TextChanged
        If mat.Text.Length = 5 Then
            IsConnected("SELECT * FROM Employes WHERE Matricule=" & mat.Text, False)
            If myDR.HasRows = True Then
                While (myDR.Read)
                    Try
                        nom.Text = myDR("Nom").ToString
                        prenom.Text = myDR("Prénom").ToString
                    Catch ex As Exception
                        MsgBox(ex.Message)
                    End Try

                End While
            End If

        End If
    End Sub

    Private Sub RecuperationFormation_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        presencedate.Value = Date.Now.Date
        Dim spe() As String = {"Cadre", "Maitrise", "Execution"}
        specialite.Items.AddRange(spe)
        load_nf()
    End Sub
    Private Sub load_nf()
        If IsConnected("SELECT DISTINCT(NatureFormation) FROM Planformation ", False) = True Then
            natureformation.Items.Clear()
            If myDR.HasRows = True Then
                While (myDR.Read())
                    natureformation.Items.Add(myDR("NatureFormation"))
                End While
            End If
        End If
    End Sub


    Private Sub ButtonX2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX2.Click
        If idformation.Text = String.Empty Then
            MessageBoxEx.Show("Vous devez choisir la formation que vous voulez assigné", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        If mat.Text = String.Empty Then
            MessageBoxEx.Show("Vous devez choisir un fonctionnaire", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        Try
            If IsConnected("INSERT INTO `pésence_formation` VALUES(NULL," & idformation.Text & "," & mat.Text & ",'" & presencedate.Value.ToString("yyyy-MM-dd") & "','" & presencedate.Text & "',NOW());", True) = True Then
                MessageBoxEx.Show("La présence à été ajouté avec succés au formation", "opération réussie", MessageBoxButtons.OK, MessageBoxIcon.Information)
                load_presence_by_fontionnaire()
            End If
        Catch ex As Exception
            MessageBoxEx.Show(ex.Message)
        End Try
    End Sub

    Private Sub load_presence()
        If Sql.VerifiyConnection = True Then
            sql.RunQuery("SELECT idpésence_formation as Numero, employes.Matricule,nom,prénom,fonction,presence_text FROM alieco.pésence_formation,employes WHERE pésence_formation.matricule=employes.Matricule and pésence_formation.id_formation='" & idformation.Text & "'")
            ' Clipboard.SetText("SELECT employes.Matricule,nom,prénom,fonction,Specialite,NatureFormation,Duree FROM alieco.effictif_formation,employes,planformation WHERE effictif_formation.matricule=employes.Matricule AND effictif_formation.id_formation=planformation.idFormation and planformation.Specialite='" & specialite.Text & "' AND planformation.NatureFormation='" & natureformation.Text & "'")
            If Sql.SQLDS.Tables.Count > 0 Then
                DataGridViewX1.DataSource = Sql.SQLDS.Tables(0)
            End If
        End If
    End Sub
    Private Sub load_presence_by_fontionnaire()
        If sql.VerifiyConnection = True Then
            sql.RunQuery("SELECT idpésence_formation as Numero ,employes.Matricule,nom,prénom,fonction,presence_text AS 'Jour de présence' FROM alieco.pésence_formation,employes WHERE pésence_formation.matricule=employes.Matricule and pésence_formation.id_formation=" & idformation.Text & " AND pésence_formation.matricule=" & mat.Text)
            ' Clipboard.SetText("SELECT employes.Matricule,nom,prénom,fonction,Specialite,NatureFormation,Duree FROM alieco.effictif_formation,employes,planformation WHERE effictif_formation.matricule=employes.Matricule AND effictif_formation.id_formation=planformation.idFormation and planformation.Specialite='" & specialite.Text & "' AND planformation.NatureFormation='" & natureformation.Text & "'")
            If sql.SQLDS.Tables.Count > 0 Then
                DataGridViewX1.DataSource = sql.SQLDS.Tables(0)
            End If
        End If
    End Sub

    Private Sub ButtonX3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX3.Click
        If mat.Text.Length = 5 Then
            load_presence_by_fontionnaire()
        Else
            load_presence()
        End If
    End Sub

    Private Sub ButtonX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX1.Click
        If DataGridViewX1.SelectedRows.Count > 0 Then
            If MessageBoxEx.Show("Voullez vous vraiment supprimer ce(s) fonctionnaire(s) ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                For Each r As DataGridViewRow In DataGridViewX1.SelectedRows
                    If Not r.IsNewRow Then
                        ' MessageBox.Show(r.Cells(0).Value.ToString & "," & r.Cells(1).Value.ToString)
                        IsConnected("DELETE FROM  pésence_formation WHERE idpésence_formation =" & r.Cells(0).Value.ToString & " LIMIT 1", True)
                    End If
                Next
                If mat.Text.Length = 5 Then
                    load_presence_by_fontionnaire()
                Else
                    load_presence()
                End If
            End If
        Else
            MessageBoxEx.Show("Vous devez choisir une présence avant de cliquer sur supprimer", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub ButtonX4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX4.Click

    End Sub
End Class