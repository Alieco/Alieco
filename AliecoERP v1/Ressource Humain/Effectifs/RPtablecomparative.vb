Public Class RPtablecomparative

    Private Sub RPtablecomparative_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Me.WindowState = FormWindowState.Maximized
            load_titre_formation()
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub
#Region "Titre formation"
    Private Sub load_titre_formation()
        Try
            If IsConnected("SELECT DISTINCT(Titre_formation) FROM table_comparative ", False) = True Then
                If myDR.HasRows = True Then
                    While (myDR.Read())
                        titreformation.Items.Add(myDR("Titre_formation"))
                    End While
                End If
            End If
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub
#End Region

    Private Sub ButtonX2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX2.Click
        Try
            Dim ds1 As prestationDS = New prestationDS
            Dim titre As String = ""
            ds1.EnforceConstraints = False
            Try
                ' Attempt to fill the dataset MainTable
                ds1.tab_comparative.Clear()
                IsConnected("SELECT Description, Prestataire, Prestataire_consulter,Delai,PrixHT,PrixTTC,Modalite_paiement, Observation, Titre_formation FROM table_comparative WHERE Titre_formation= '" & titreformation.Text & "' ", False)
                If myDR.HasRows Then

                    While myDR.Read
                        titre = "Table comparative de " & myDR("Titre_formation")
                        ds1.tab_comparative.Addtab_comparativeRow(IIf(IsDBNull(myDR("Description")), "", myDR("Description")), IIf(IsDBNull(myDR("Prestataire")), "", myDR("Prestataire")), IIf(IsDBNull(myDR("Prestataire_consulter")), "", myDR("Prestataire_consulter")), IIf(IsDBNull(myDR("Delai")), "", myDR("Delai")), IIf(IsDBNull(myDR("PrixHT")), "", myDR("PrixHT")), IIf(IsDBNull(myDR("PrixTTC")), "", myDR("PrixTTC")), IIf(IsDBNull(myDR("Modalite_paiement")), "", myDR("Modalite_paiement")), IIf(IsDBNull(myDR("Observation")), "", myDR("Observation")), IIf(IsDBNull(myDR("Titre_formation")), "", myDR("Titre_formation")))
                    End While
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                ds1.EnforceConstraints = True
            End Try
            Dim cr As New comparative()
            cr.XrLabel19.Text = titre.ToString
            cr.DataSource = ds1
            DocumentViewer1.DocumentSource = cr
            cr.CreateDocument(True)
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub
End Class