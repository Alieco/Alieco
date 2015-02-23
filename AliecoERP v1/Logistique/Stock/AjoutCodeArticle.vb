Imports DevComponents.DotNetBar

Public Class AjoutCodeArticle
    Dim quary As String = ""
    Dim erreur As Boolean = False
    Private Sub ajout_Click(sender As System.Object, e As System.EventArgs) Handles ajout.Click
        quary = "INSERT INTO logistique_gestionstock_catcodart VALUES(NULL,'" & codearticle.Text & "','" & desig.Text & "','" & sfamille.Text & "','" & um.Text & "','" & rayon.Text & "','" & compte.Text & "')"
        Clipboard.SetText(quary)
        If IsConnected(quary, True) = False Then
            erreur = True
        End If
        If erreur = False Then
            MessageBoxEx.Show("Le'" & desig.Text & "' a bien été enregistrer", "Succés", MessageBoxButtons.OK, MessageBoxIcon.Information)
            codearticle.Text = ""
            desig.Clear()
            compte.Text = ""
            um.Text = ""
            rayon.Text = ""
            sfamille.Text = ""
        End If
    End Sub
    Private Sub load_um()
        If IsConnected("SELECT DISTINCT um FROM Logistique_GestionStock_Catalogue ", False) = True Then
            If myDR.HasRows = True Then
                um.Items.Clear()
                While (myDR.Read())
                    um.Items.Add(myDR("um"))
                End While
            End If
        End If
    End Sub

    Private Sub AjoutCodeArticle_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        load_um()
    End Sub

    Private Sub compte_TextChanged(sender As System.Object, e As System.EventArgs) Handles compte.TextChanged
        If compte.Text.Length > 6 Then
            MessageBoxEx.Show("Le nombre '" & compte.Text & "'est depassé les 6 chiffres !", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub codearticle_TextChanged(sender As System.Object, e As System.EventArgs) Handles codearticle.TextChanged
        If codearticle.Text.Length > 12 Then
            MessageBoxEx.Show("Le nombre '" & codearticle.Text & "'est depassé les 12 chiffres !", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub
End Class