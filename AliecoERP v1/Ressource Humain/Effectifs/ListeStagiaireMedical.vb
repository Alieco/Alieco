Public Class ListeStagiaiereMedical
    Private Sub ListeStagiaiereMedical_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Me.WindowState = FormWindowState.Maximized
            '   Dim ds As ListStageMedical = New ListStageMedical
            '    ds.EnforceConstraints = False
            Try
                ' Attempt to fill the dataset MainTable
                '   ds.Stagiaire.Clear()
                IsConnected("SELECT Matricule,Nom,Pr�nom,Date_de_Naissance,Date_dEntr�e,Date_de_sortie,Sp�cialit� FROM stagiaire ", False)
                If myDR.HasRows Then

                    While myDR.Read
                        '      ds.Stagiaire.AddStagiaireRow(IIf(IsDBNull(myDR("Matricule")), "", myDR("Matricule")), IIf(IsDBNull(myDR("Nom")), "", myDR("Nom")), IIf(IsDBNull(myDR("Pr�nom")), "", myDR("Pr�nom")), IIf(IsDBNull(myDR("Date_de_naissance")), "", myDR("Date_de_naissance")), IIf(IsDBNull(myDR("Date_dEntr�e")), "", myDR("Date_dEntr�e")), IIf(IsDBNull(myDR("Date_de_sortie")), "", myDR("Date_de_sortie")), IIf(IsDBNull(myDR("Sp�cialit�")), "", myDR("Sp�cialit�")))
                    End While
                End If
            Catch ex As Exception
                Throw ex
            Finally
                '  ds.EnforceConstraints = True
            End Try
            Dim cr As ListStagiaireMedicalRP = New ListStagiaireMedicalRP
            ' Set the report DataSet   
            'cr.SetDataSource(ds)
            'CrystalReportViewer1.ReportSource = cr
            '  cr.DataSource = ds
            DocumentViewer1.DocumentSource = cr
            cr.CreateDocument(True)
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub
End Class