Imports DevComponents.DotNetBar

Public Class AddAttendance
    Dim existe As Boolean = False
    Private Sub mat_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mat.TextChanged
        Try
            If mat.Text.Length = 5 And IsNumeric(mat.Text) Then
                IsConnected("SELECT * FROM Employes WHERE Matricule=" & mat.Text, False)
                If myDR.HasRows = True Then
                    While (myDR.Read)
                        Try
                            nom.Text = myDR("Nom").ToString
                            prenom.Text = myDR("Prénom").ToString
                            Lieux_de_Naissance.Text = myDR("Lieux_de_Naissance").ToString
                            Fonction.Text = myDR("Fonction").ToString
                            Adresse.Text = myDR("Adresse").ToString
                            prenom.Text = myDR("Prénom").ToString
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
    Private Sub load_motif()
        Try
            If IsConnected("SELECT DISTINCT Motif FROM presence_pointage ORDER BY Motif ASC", False) = True Then
                If myDR.HasRows = True Then
                    Motif.Items.Clear()
                    While (myDR.Read())
                        Motif.Items.Add(myDR("Motif"))
                    End While
                End If
            End If
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub

    Private Sub AddAttendance_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        load_motif()
    End Sub

    Private Sub ButtonX2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX2.Click
        Try
            Dim quary As String
            If existe = True Then
                quary = "UPDATE `alieco`.`presence_pointage` SET Entree1='" & entry1.Value.ToString("H:mm") & "', Sortie1='" & sortie1.Value.ToString("H:mm") & "',Entree2='" & entry2.Value.ToString("H:mm") & "', Sortie2='" & sortie2.Value.ToString("H:mm") & "',Entree3='" & entry3.Value.ToString("H:mm") & "', Sortie3='" & sortie3.Value.ToString("H:mm") & "', Motif='" & Motif.Text & "', Absence='" & Label5.Text.Replace(",", ".") & "'  WHERE date_pointage= '" & Du.Value.ToString("yyyy-MM-dd") & "' and Matricule='" & mat.Text & "';"
            Else
                quary = " INSERT INTO presence_pointage VALUES(NULL," & mat.Text & ",'" & Du.Value.ToString("yyyy-MM-dd") & "','" & entry1.Value.ToString("H:mm") & "','" & sortie1.Value.ToString("H:mm") & "','" & entry2.Value.ToString("H:mm") & "','" & sortie2.Value.ToString("H:mm") & "','" & entry3.Value.ToString("H:mm") & "','" & sortie3.Value.ToString("H:mm") & "', '" & Label5.Text.Replace(",", ".") & "' ,NULL ,'" & Motif.Text & "')"
            End If
            'MsgBox(quary)
            If IsConnected(quary, True) = True Then
                MessageBoxEx.Show("Le poitage à bien été enregistrer", "Succés", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Du.Value = Nothing
                entry1.Value = Nothing
                sortie1.Value = Nothing
                entry2.Value = Nothing
                sortie2.Value = Nothing
                entry3.Value = Nothing
                sortie3.Value = Nothing
                Motif.Text = ""
            End If
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub
    Function SommeMotif(ByVal somme As String, ByVal motif As String) As String
        Try
            If motif.Contains("Congé.Ann") Or motif.Contains("Congee statutaire") Or motif.Contains("Formation") Or motif.Contains("Mission V") Or motif.Contains("Recuperation Formation") Or motif.Contains("week end") Or motif.Contains("Bon de sortie service") Or motif.Contains("Omnission pointage") Or motif.Contains("Bon Sortie cp") Or motif.Contains("Bon sortie Soin") Or motif.Contains("Bon.Sortie - allaitement") Or motif.Contains("allaitement") Then
                Return "0.00"
            Else
                Return somme
            End If
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
        Return Nothing
    End Function

    Private Sub sortie1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sortie1.ValueChanged
        Try
            Label5.Text = ImportPresence.SommeAbsence(entry1.Value.ToString("H:mm"), sortie1.Value.ToString("H:mm"), entry2.Value.ToString("H:mm"), sortie2.Value.ToString("H:mm"), entry3.Value.ToString("H:mm"), sortie3.Value.ToString("H:mm"))
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub

    Private Sub sortie2_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sortie2.ValueChanged
        Try
            Label5.Text = ImportPresence.SommeAbsence(entry1.Value.ToString("H:mm"), sortie1.Value.ToString("H:mm"), entry2.Value.ToString("H:mm"), sortie2.Value.ToString("H:mm"), entry3.Value.ToString("H:mm"), sortie3.Value.ToString("H:mm"))
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub

    Private Sub sortie3_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sortie3.ValueChanged
        Try
            Label5.Text = ImportPresence.SommeAbsence(entry1.Value.ToString("H:mm"), sortie1.Value.ToString("H:mm"), entry2.Value.ToString("H:mm"), sortie2.Value.ToString("H:mm"), entry3.Value.ToString("H:mm"), sortie3.Value.ToString("H:mm"))
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub

    Private Sub Du_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Du.ValueChanged
        Try
            IsConnected("SELECT * FROM presence_pointage where date_pointage='" & Du.Value.ToString("yyyy-MM-dd") & "' and Matricule ='" & mat.Text & "'", False)
            If myDR.HasRows = True Then
                While (myDR.Read())
                    existe = True
                    ButtonX2.Text = "Modifier"
                    ButtonX2.Image = My.Resources.edit
                    entry1.Value = IIf((myDR("Entree1") = ""), Nothing, myDR("Entree1"))
                    sortie1.Value = IIf((myDR("Sortie1") = ""), Nothing, myDR("Sortie1"))
                    entry2.Value = IIf((myDR("Entree2") = ""), Nothing, myDR("Entree2"))
                    sortie2.Value = IIf((myDR("Sortie2") = ""), Nothing, myDR("Sortie2"))
                    entry3.Value = IIf((myDR("Entree3") = ""), Nothing, myDR("Entree3"))
                    sortie3.Value = IIf((myDR("Sortie3") = ""), Nothing, myDR("Sortie3"))
                    Motif.Text = myDR("Motif")
                End While
            Else : existe = False
                ButtonX2.Text = "Ajouter"
                ButtonX2.Image = My.Resources.adde
                entry1.Value = Nothing
                sortie1.Value = Nothing
                entry2.Value = Nothing
                sortie2.Value = Nothing
                entry3.Value = Nothing
                sortie3.Value = Nothing
                Motif.Text = ""
            End If
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub
End Class