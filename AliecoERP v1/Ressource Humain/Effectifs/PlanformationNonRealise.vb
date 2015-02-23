Public Class PlanformationNonRealise

    Private Sub PlanformationNonRealise_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        Dim ds1 As Formationdst = New Formationdst
        ds1.EnforceConstraints = False
        Try
            ' Attempt to fill the dataset MainTable

            ds1.PFormation.Clear()
            IsConnected("SELECT Specialite,NatureFormation,Effectifprevu,Alternance,Duree,DateDebut,CoutTTC, Lieu FROM Planformation  WHERE realise='0'", False)
            If myDR.HasRows Then

                While myDR.Read
                    ds1.PFormation.AddPFormationRow(IIf(IsDBNull(myDR("Specialite")), "", myDR("Specialite")), IIf(IsDBNull(myDR("NatureFormation")), "", myDR("NatureFormation")), IIf(IsDBNull(myDR("Effectifprevu")), "", CDbl(myDR("Effectifprevu"))), IIf(IsDBNull(myDR("Alternance")), "", myDR("Alternance")), IIf(IsDBNull(myDR("Duree")), "", myDR("Duree")), IIf(IsDBNull(myDR("DateDebut")), "", myDR("DateDebut")), IIf(IsDBNull(myDR("CoutTTC")), "", CDbl(Val(myDR("CoutTTC")))), IIf(IsDBNull(myDR("Lieu")), "", myDR("Lieu")))
                End While
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            ds1.EnforceConstraints = True
        End Try
        Dim cr As FormationNonRealiserRP = New FormationNonRealiserRP()
        'Set the report DataSet   
        cr.DataSource = ds1
        DocumentViewer1.DocumentSource = cr
        cr.createDocument(True)
    End Sub
End Class