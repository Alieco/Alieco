Imports DevComponents.DotNetBar

Public Class AjoutCompte
    Dim erreur As Boolean = False
    Private Sub ajout_Click(sender As System.Object, e As System.EventArgs) Handles ajout.Click
        Dim quary = "INSERT INTO logistique_gestionstock_catcompt VALUES(NULL,'" & compte.Text & "','" & sousfamille.Text & "','" & famille.Text & "')"
        Clipboard.SetText(quary)
        If IsConnected(quary, True) = False Then
            erreur = True
        End If
        If erreur = False Then
            MessageBoxEx.Show("Le'" & compte.Text & "' a bien été enregistrer", "Succés", MessageBoxButtons.OK, MessageBoxIcon.Information)
            famille.Text = ""
            sousfamille.Text = ""
            compte.Text = ""
        End If
    End Sub

    Private Sub compte_TextChanged(sender As System.Object, e As System.EventArgs) Handles compte.TextChanged
        If compte.Text.Length > 6 Then
            MessageBoxEx.Show("Le nombre '" & compte.Text & "'est depassé les 6 chiffres !", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub
End Class