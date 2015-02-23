Public Class RecapMensuel

    Private Sub RecapMensuel_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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
            ButtonX1.Pulse()
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub

    Private Sub ButtonX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX1.Click
        Try
            Dim report1 As RecapRP = New RecapRP()
            Dim DS As RecapDS = New RecapDS()
            Dim query = "SELECT paie_mensuel.code,Libellé,Sum(gain) as Gain,Sum(retenue) as Retenue,imput FROM paie_mensuel,paie_rubrique WHERE paie_rubrique.ind = paie_mensuel.code and moi_annee='" & Moi.Text & Anne.Text & "'   GROUP BY paie_mensuel.code ORDER by paie_mensuel.code ASC "
            If IsConnected(query, False) Then
                If myDR.HasRows Then
                    While myDR.Read
                        DS.Recap.AddRecapRow(myDR("code"), myDR("libellé"), myDR("gain"), myDR("retenue"), myDR("imput"))
                    End While
                End If
            End If
            report1.DataSource = DS
            report1.CreateDocument()
            DocumentViewer1.DocumentSource = report1
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub
End Class