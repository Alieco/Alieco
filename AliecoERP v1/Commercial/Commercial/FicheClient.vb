Public Class FicheClient
    Public rais As String = ""
    Dim dsObj As FicheClientDS = New FicheClientDS
    Private Sub ButtonX1_Click(sender As System.Object, e As System.EventArgs) Handles ButtonX1.Click
        Try
            If rs.Text = "" Then
                MessageBox.Show("Vous avez laissé le champ Raison Social vide !", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                rais = rs.Text
                FillDataSet(dsObj)
                Dim cr As FicheClientRp = New FicheClientRp
                ' Set the report DataSet   
                'cr.SetDataSource(ds)
                'CrystalReportViewer1.ReportSource = cr
                cr.DataSource = dsObj
                DocumentViewer1.DocumentSource = cr
                cr.CreateDocument(True)
            End If
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub
    Public Sub FillDataSet(ByRef dataSet As FicheClientDS)
        dataSet.EnforceConstraints = False
        Try
            ' Attempt to fill the dataset MainTable
            dataSet.ClientDT.Clear()
            IsConnected("SELECT NRC,filière,nconsult,Date,NomClient,Fonction,RaisonSocial,Adresse,NumTel,Fax,Email,NIdentif_fiscale,NArticle_imposition,Description_Consult,Observation,secteur,delai_reponse,fullname FROM commercial_client,users WHERE users.user_id=commercial_client.user and RaisonSocial='" & rais & "'", False)
            If myDR.HasRows Then

                While myDR.Read
                    ' MsgBox(myDR("Matricule"))
                    dataSet.ClientDT.AddClientDTRow(IIf(IsDBNull(myDR("filière")), "", myDR("filière")), IIf(IsDBNull(myDR("nconsult")), "", myDR("nconsult")), IIf(IsDBNull(myDR("Date")), "", myDR("Date")), IIf(IsDBNull(myDR("NomClient")), "", myDR("NomClient")), IIf(IsDBNull(myDR("Fonction")), "", myDR("Fonction")), IIf(IsDBNull(myDR("RaisonSocial")), "", myDR("RaisonSocial")), IIf(IsDBNull(myDR("Adresse")), "", myDR("Adresse")), IIf(IsDBNull(myDR("NumTel")), "", myDR("NumTel")), IIf(IsDBNull(myDR("Fax")), "", myDR("Fax")), IIf(IsDBNull(myDR("Email")), "", myDR("Email")), IIf(IsDBNull(myDR("NRC")), "", myDR("NRC")), IIf(IsDBNull(myDR("NIdentif_fiscale")), "", myDR("NIdentif_fiscale")), IIf(IsDBNull(myDR("NArticle_imposition")), "", myDR("NArticle_imposition")), IIf(IsDBNull(myDR("Description_Consult")), "", myDR("Description_Consult")), IIf(IsDBNull(myDR("Observation")), "", myDR("Observation")), IIf(IsDBNull(myDR("secteur")), "", myDR("secteur")), IIf(IsDBNull(myDR("delai_reponse")), "", myDR("delai_reponse")), IIf(IsDBNull(myDR("fullname")), "", myDR("fullname")))
                End While
                   End If
        Catch ex As Exception
            EnvoiError(ex.Message)
        Finally
            dataSet.EnforceConstraints = True
        End Try
    End Sub
    Private Sub load_RaisonS()
        Try
            If IsConnected("SELECT DISTINCT RaisonSocial FROM commercial_client ", False) = True Then
                If myDR.HasRows = True Then
                    rs.Items.Clear()
                    While (myDR.Read())
                        rs.Items.Add(myDR("RaisonSocial"))
                    End While
                End If
            End If
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub
    Private Sub FicheClient_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Try
            load_RaisonS()
            If rais <> "" Then
                ' MsgBox("2 * " & rais)
                ' Dim dsObj As FicheClientDS = New FicheClientDS
                FillDataSet(dsObj)
                Dim cr As FicheClientRp = New FicheClientRp
                cr.DataSource = dsObj
                DocumentViewer1.DocumentSource = cr
                cr.CreateDocument(True)
            End If
            'If rais <> "" Then
            '    rs.Text = rais
            '    ButtonX1.PerformClick()
            'End If
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub
End Class