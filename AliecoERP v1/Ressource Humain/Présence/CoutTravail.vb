Public Class CoutTravail

    Private Sub CoutTravail_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Try
            For i As Integer = 2000 To Date.Now.Year
                Anne.Items.Add(i)
            Next
            Anne.SelectedIndex = Anne.Items.Count - 1
            For i As Integer = 1 To 12
                If i < 10 Then
                    Moi.Items.Add("0" & i)
                Else
                    Moi.Items.Add(i)
                End If
            Next
            Moi.SelectedIndex = Date.Now.Month - 1
            load_fonction()
            load_direction()
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub
#Region "fonctions"
    Private Sub load_fonction()
        Try
            If IsConnected("SELECT DISTINCT Fonction FROM Employes ", False) = True Then
                If myDR.HasRows = True Then
                    fonction.Items.Clear()
                    While (myDR.Read())
                        fonction.Items.Add(myDR("Fonction"))
                    End While
                End If
            End If
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub
    Private Sub load_direction()
        Try
            If IsConnected("SELECT DISTINCT Direction FROM Employes ", False) = True Then
                If myDR.HasRows = True Then
                    direction.Items.Clear()
                    While (myDR.Read())
                        direction.Items.Add(myDR("Direction"))
                    End While
                End If
            End If
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub
#End Region
    Private Sub ButtonX1_Click(sender As System.Object, e As System.EventArgs) Handles ButtonX1.Click
        Try
            Dim ds1 As CoutTravailDS = New CoutTravailDS

            ds1.EnforceConstraints = False
            Try
                'Attempt to fill the dataset MainTable
                ds1.CoutTravailDT.Clear()
                IsConnected("SELECT distinct(employes.Matricule),nom,prénom,Fonction,Direction,Hall,total_impots,total_ss,moi_annee FROM employes,paie_mensuel WHERE  Employes.Matricule=paie_mensuel.Matricule and paie_mensuel.type='P'  and moi_annee='" & Moi.Text & Anne.Text & "'and fonction LIKE '%" & fonction.Text & "%' and direction LIKE '%" & direction.Text & "%' order by Matricule asc ", False)
                'Clipboard.SetText("SELECT distinct(employes.Matricule),nom,prénom,Fonction,Direction,Hall,total_impots,total_ss,moi_annee FROM employes,paie_mensuel WHERE  Employes.Matricule=paie_mensuel.Matricule and paie_mensuel.type='P'  and moi_annee='" & Moi.Text & Anne.Text & "' order by Matricule asc ")
                If myDR.HasRows Then
                    While myDR.Read
                        Dim Brute, SSP, SIP, Cout As Double
                        Brute = Math.Round(myDR("total_impots") + (0.09 * myDR("total_ss")), 2)
                        SSP = Math.Round(0.25 * myDR("total_ss"), 2)
                        SIP = Math.Round((0.03 * myDR("total_impots")), 2)
                        Cout = Math.Round((Brute + SSP + SIP), 2)
                        ds1.CoutTravailDT.AddCoutTravailDTRow(IIf(IsDBNull(myDR("Matricule")), "", myDR("Matricule")), IIf(IsDBNull(myDR("Nom") & " " & myDR("Prénom")), "", myDR("Nom") & " " & myDR("Prénom")), IIf(IsDBNull(myDR("Fonction")), "", myDR("Fonction")), IIf(IsDBNull(myDR("Direction")), "", myDR("Direction")), IIf(IsDBNull(myDR("Hall")), "", myDR("Hall")), IIf(IsDBNull(myDR("total_ss")), "", myDR("total_ss")), IIf(IsDBNull(myDR("total_impots")), "", myDR("total_impots")), IIf(IsDBNull(Brute), "", Brute), IIf(IsDBNull(SSP), "", SSP), IIf(IsDBNull(SIP), "", SIP), IIf(IsDBNull(Cout), "", Cout), IIf(IsDBNull(myDR("moi_annee")), "", myDR("moi_annee")))
                    End While
                End If

            Catch ex As Exception
                EnvoiError(ex.Message)
            Finally
                ds1.EnforceConstraints = True
            End Try
            Dim cr As New CouTravailRP()
            cr.DataSource = ds1
            DocumentViewer1.DocumentSource = cr
            cr.CreateDocument(True)
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub
End Class