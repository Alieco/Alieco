Imports DevComponents.DotNetBar

Public Class AddNiveau
    Private Sub ButtonX1_Click(sender As System.Object, e As System.EventArgs) Handles ButtonX1.Click
        Try
            If niv.Text = "" Then
                MessageBoxEx.Show("Veuillez saisir un niveau", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                If IsConnected("INSERT INTO `niveau`(`id_niveau`,`description_niveau`) VALUES(NULL, '" & mysql_escape_string(niv.Text) & "')", True) Then
                    MessageBoxEx.Show("Le niveau a bien été enregistré", "Succés", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    niv.Text = ""
                    Ajoutfonctionnaire.load_niveau()
                    EditFonctionnaire.load_niveau()
                    reload()
                    Me.Close()
                Else : MessageBoxEx.Show("Erreur le niveau n'a pas été enregistré", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub

    Private Sub SupprimerButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SupprimerButton.Click
        Try
            If niv.Text <> "" Then
                If MessageBoxEx.Show("Vous voulez vraiment supprimer ce niveau ?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                    IsConnected("DELETE FROM niveau WHERE description_niveau ='" & mysql_escape_string(niv.Text) & "' limit 1", True)
                    If MessageBoxEx.Show("Le niveau est supprimé", "Succés", MessageBoxButtons.OK, MessageBoxIcon.Information) Then
                        niv.Text = ""
                    End If
                End If
                Ajoutfonctionnaire.load_niveau()
                EditFonctionnaire.load_niveau()
                reload()
                Me.Close()
            Else
                MessageBoxEx.Show("Vous devez sélectionner un niveau avant de cliquer supprimer", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub
    Private Sub reload()
        Try
            If IsConnected("SELECT DISTINCT description_niveau FROM niveau ", False) = True Then
                If myDR.HasRows = True Then
                    niv.Items.Clear()
                    While (myDR.Read())
                        niv.Items.Add(myDR("description_niveau"))
                    End While
                End If
            End If
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub

    Private Sub AddNiveau_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        reload()
    End Sub
End Class