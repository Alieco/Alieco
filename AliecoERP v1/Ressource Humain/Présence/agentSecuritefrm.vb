Public Class agentSecuritefrm
    Dim sql As New SQLControl
    Private Sub ButtonX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX1.Click
        Try
            If du.Text = "" Or au.Text = "" Then
                MsgBox(" Veuillez saisir la date! ")
            Else
                If sql.VerifiyConnection = True Then
                    '  sql.RunQuery("SELECT Matricule,Nom,Prénom,DNaissance as 'Date de naissance',Dentrée as 'Date d\'entrée',numTel as 'Num Téléphone',name_service as 'Nom de service',titre_fonction as Fonction,name_direction as Direction,name_departement as Departement,Statut,Sexe,Sit_fam as 'Situation familiale',Adresse,willaya FROM Services, Departement, Direction, Employes, Fonction, willaya WHERE Services.id_departement=Departement.id_departement and Direction.id_direction=Departement.id_direction and Employe.id_service=Services.id_service and Fonction.id_fonction=Employe.id_fonction and willaya.id=Employe.VilleAdr")
                    'Clipboard.SetText("SELECT employes.Matricule, Nom, Prénom, Direction, date_pointage, Entree1,Sortie1, Entree2,Sortie2,Entree3,Sortie3, absence, HeureSupplementaire, Motif FROM presence_pointage, Employes WHERE Employes.Matricule=presence_pointage.Matricule and date_pointage between  '" & du.Value.ToString("yyyy-MM-dd") & "' and '" & au.Value.ToString("yyyy-MM-dd") & "' and Motif like '%Recuperation%' and Fonction like '%Agent de surveillance%' or Fonction like'%Chef de groupe S%'")
                    sql.RunQuery("SELECT employes.Matricule, Nom, Prénom, Direction,Fonction, date_pointage, Entree1,Sortie1, Entree2,Sortie2,Entree3,Sortie3, absence, HeureSupplementaire, Motif FROM presence_pointage, Employes WHERE Employes.Matricule=presence_pointage.Matricule and (date_pointage between  '" & du.Value.ToString("yyyy-MM-dd") & "' and '" & au.Value.ToString("yyyy-MM-dd") & "') and (Fonction like '%Agent de surveillance%' or Fonction like'%Chef de groupe S%')")
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