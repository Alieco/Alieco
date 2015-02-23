Imports DevComponents.DotNetBar

Public Class MentionObservation
    Public idsuivi As String = ""
    Private Sub ButtonX6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX6.Click
        If observation.Text <> "" Then
            If (IsConnected("UPDATE `logistique_appro_suividem` SET `observation` = '" & observation.Text & "' WHERE `idsuividem` = '" & idsuivi & "';", True)) = True Then
                ObservationAcheteur.loaddemande()
                Me.Close()
            End If
        Else : MessageBoxEx.Show("Veuillez saisir une observation!", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
End Class