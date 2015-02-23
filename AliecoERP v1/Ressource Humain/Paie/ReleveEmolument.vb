Public Class ReleveEmolument

    Private Sub ButtonX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX1.Click
        Try
            If mat.Text.Length = 5 And IsNumeric(mat.Text) Then
                Dim ds1 As ReleveEmolDS = New ReleveEmolDS
                Dim paie As Double
                Dim rel As String = "  "
                ds1.EnforceConstraints = False
                Try
                    'Attempt to fill the dataset MainTable
                    ds1.ReleveEmolumentDT.Clear()


                    IsConnected("SELECT employes.Matricule,nom,prénom,fonction,net_payer FROM employes,paie_mensuel WHERE  Employes.Matricule=paie_mensuel.Matricule and paie_mensuel.type='P' and paie_mensuel.matricule= " & mat.Text & " order by idpaie_monsuel desc limit 1", False)

                    If myDR.HasRows Then
                        While myDR.Read
                            If mensuel.Checked Then
                                rel = "SALAIRE MENSUEL NET :"
                                paie = myDR("net_payer")
                            Else
                                paie = myDR("net_payer")
                                paie = paie * 12
                                rel = "SALAIRE ANNUEL NET :"
                            End If
                            'titre = " RELEVE DSE EMOLUMENTS "
                            ds1.ReleveEmolumentDT.AddReleveEmolumentDTRow(IIf(IsDBNull(myDR("Matricule")), "", myDR("Matricule")), IIf(IsDBNull(myDR("nom")), "", myDR("nom")), IIf(IsDBNull(myDR("prénom")), "", myDR("prénom")), IIf(IsDBNull(myDR("fonction")), "", myDR("fonction")), IIf(IsDBNull(paie), "", paie))
                        End While
                    End If
                Catch ex As Exception
                    MsgBox(ex.Message)
                Finally
                    ds1.EnforceConstraints = True
                End Try

                Dim cr As New RelEmolRP()
                cr.XrLabel14.Text = rel.ToString
                cr.DataSource = ds1
                DocumentViewer1.DocumentSource = cr
                cr.CreateDocument(True)
            End If
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub
End Class