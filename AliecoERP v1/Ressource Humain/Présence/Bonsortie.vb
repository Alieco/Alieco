Public Class Bonsortie
    Dim sql As New SQLControl
    Private Sub ButtonX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX1.Click
        Try
            If du.Text = "" Or au.Text = "" Then
                MsgBox(" Veuillez saisir la date! ")
            Else
                If sql.VerifiyConnection = True Then
                    sql.RunQuery("SELECT employes.Matricule, Nom, Prénom, Direction,Fonction, date_pointage, Entree1,Sortie1, Entree2,Sortie2,Entree3,Sortie3, absence, HeureSupplementaire, Motif FROM presence_pointage, Employes WHERE Employes.Matricule=presence_pointage.Matricule and (date_pointage between  '" & du.Value.ToString("yyyy-MM-dd") & "' and '" & au.Value.ToString("yyyy-MM-dd") & "') and Motif like '%Bon%'")
                    If sql.SQLDS.Tables.Count > 0 Then
                        Pdgv.DataSource = sql.SQLDS.Tables(0)
                    End If
                End If
            End If
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub
End Class