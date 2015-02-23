Imports DevComponents.DotNetBar

Public Class consulterDemande
    Public iddesi As String = ""
    Public idemande As String = ""
    Private Sub ButtonX6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX6.Click
        Dim b As Boolean = False
        If (IsConnected("UPDATE `logistique_appro_demach` SET `delai` = '" & delai.Text & "',`expedition` = '" & expedition.Text & "',`reglement` = '" & reglement.Text & "',`dateoffre` = '" & votreoffre.Text & "',`dateconslt` =NOW() WHERE `idapprodemach` = '" & idemande & "';", True)) = True Then
            b = True
            IsConnected("UPDATE `logistique_appro_demandedesig` SET `etatdesig` = '1',`recept_remt` = '" & remettre.Text & "',`dateconsult` = NOW() WHERE `idLogistique_appro_demandeDesig` = '" & iddesi & "';", True)
        Else : b = False
        End If
        If b = True Then
            MessageBoxEx.Show("Bien enregistrer", "Succés", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ListeDemAch.loaddemande()
            Me.Close()
        Else : MessageBoxEx.Show("Echec de l'enregistrement", "Succés", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
End Class