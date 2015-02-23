Public Class retraitePrint
    Public matricule As String = ""
    Private Sub retraitePrint_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub ButtonX2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX2.Click
        Try
            If matrd.Text.Length = 5 And IsNumeric(matrd.Text) Then
                'Dim ds As RetraiteDSt = New RetraiteDSt
                Dim dsObj As RetraiteDSt = New RetraiteDSt
                dsObj.EnforceConstraints = False
                Try
                    'Attempt to fill the dataset MainTable
                    dsObj.retraiteTB.Clear()
                    IsConnected("SELECT * FROM retraite WHERE Matricule='" & matrd.Text & "'", False)
                    Clipboard.SetText("SELECT * FROM retraite WHERE Matricule='" & matrd.Text & "'", False)
                    If myDR.HasRows Then
                        While myDR.Read
                            dsObj.retraiteTB.AddretraiteTBRow(IIf(IsDBNull(myDR("Matricule")), "", myDR("Matricule")), IIf(IsDBNull(myDR("Nom") & " " & myDR("Prenom")), "", myDR("Nom") & " " & myDR("Prenom")), IIf(IsDBNull(myDR("DN")), "", myDR("DN")), IIf(IsDBNull(myDR("LN")), "", myDR("LN")), IIf(IsDBNull(myDR("DR")), "", myDR("DR")), IIf(IsDBNull(myDR("indemnité")), "", myDR("indemnité")), IIf(IsDBNull(myDR("cotisations_sociales")), "", myDR("cotisations_sociales")), IIf(IsDBNull(myDR("1ere")), "", myDR("1ere")), IIf(IsDBNull(myDR("2eme")), "", myDR("2eme")), IIf(IsDBNull(myDR("3eme")), "", myDR("3eme")), IIf(IsDBNull(myDR("4eme")), "", myDR("4eme")), IIf(IsDBNull(myDR("5eme")), "", myDR("5eme")), IIf(IsDBNull(myDR("rappel")), "", myDR("rappel")), IIf(IsDBNull(myDR("NA")), "", myDR("NA")), IIf(IsDBNull(myDR("NP")), "", myDR("NP")), IIf(IsDBNull(myDR("DE")), "", myDR("DE")), IIf(IsDBNull(myDR("DS")), "", myDR("DS")), IIf(IsDBNull(myDR("anne1")), "", myDR("anne1")), IIf(IsDBNull(myDR("anne2")), "", myDR("anne2")), IIf(IsDBNull(myDR("anne3")), "", myDR("anne3")), IIf(IsDBNull(myDR("anne4")), "", myDR("anne4")), IIf(IsDBNull(myDR("anne5")), "", myDR("anne5")), IIf(IsDBNull(myDR("ville")), "", myDR("ville")))
                        End While
                    End If
                Catch ex As Exception
                    MsgBox(ex.Message)
                Finally
                    dsObj.EnforceConstraints = True
                End Try
                Dim cr As RetraiteRp = New RetraiteRp
                ' Set the report DataSet   
                cr.DataSource = dsObj
                DocumentViewer1.DocumentSource = cr
                cr.CreateDocument(True)
            End If
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub
End Class