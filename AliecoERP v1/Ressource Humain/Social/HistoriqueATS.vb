Imports DevComponents.DotNetBar
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraEditors.Controls

Public Class HistoriqueATS
    Dim Sql As New SQLControl
    Private Sub HistoriqueATS_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        load_Matricule_Nom()
        'Load_ATS()
    End Sub
#Region "Fonctions"
    'Sub Load_ATS()
    '    Try
    '        If Sql.VerifiyConnection = True Then
    '            Sql.RunQuery("SELECT Matricule,Nom,Prénom,Fonction,Direction,social_ats_historique.DateEntree FROM employes left join social_ats_historique on employes.Matricule = social_ats_historique.matricule where employes.matricule='" & ListMatNom.Value & "'")
    '            If Sql.SQLDS.Tables.Count > 0 Then
    '                If Sql.SQLDS.Tables(0).Rows.Count > 0 Then
    '                    HATS.DataSource = Sql.SQLDS.Tables(0)
    '                Else
    '                    'MessageBoxEx.Show("Vous n'avez pas des employes qui ne pas eu leur attestation ", "Liste Vide", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '                End If
    '            End If
    '        End If
    '    Catch ex As Exception
    '        EnvoiError(ex.Message)
    '    End Try
    'End Sub
    Private Sub load_Matricule_Nom()
        ListMatNom.Properties.Items.Clear()
        IsConnected("SELECT DISTINCT employes.Matricule,employes.Nom,employes.Prénom FROM employes,social_ats_historique where employes.Matricule = social_ats_historique.matricule ", False)
        If myDR.HasRows Then
            While myDR.Read
                ListMatNom.Properties.Items.Add(New ImageComboBoxItem(myDR("Matricule").ToString & " - " & myDR("Nom").ToString & " " & myDR("Prénom").ToString, myDR("Matricule").ToString, 4))
            End While
            ListMatNom.Properties.SmallImages = StatImageList
            ListMatNom.Properties.LargeImages = StatImageList
        End If
    End Sub
#End Region
    Private Sub ListMatNom_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ListMatNom.SelectedIndexChanged
        Try
            If Sql.VerifiyConnection = True Then
                Sql.RunQuery("SELECT DISTINCT employes.Matricule,Nom,Prénom,Fonction,Direction,social_ats_historique.DateEntree FROM employes left join social_ats_historique on employes.Matricule = social_ats_historique.matricule where employes.matricule='" & ListMatNom.Value & "'")
                If Sql.SQLDS.Tables(0).Rows.Count > 0 Then
                    HATS.DataSource = Sql.SQLDS.Tables(0)
                Else
                End If
            End If
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub
End Class