Public Class ficheSuiveuseRPP
    Public codeaff As String = ""
    Dim ds1 As FacturationDS = New FacturationDS
    Dim cr As New FichSuiviRP()
    Public sumfact As Double = 0
    Dim var As String = ""
    Private Sub ficheSuiveuseRPP_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Try
            Codeaffaire.Text = codeaff
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub

    Private Sub RechercheBtn_Click(sender As System.Object, e As System.EventArgs) Handles RechercheBtn.Click
        Try
            cr.XrLabel26.Text = SuiviFacturation.LabelX8.Text
            cr.XrLabel18.Text = SuiviFacturation.etatTxt.Text
            cr.XrLabel10.Text = codeaff
            cr.XrLabel8.Text = SuiviFacturation.du.Text
            cr.XrLabel16.Text = ""
            cr.XrLabel4.Text = SuiviFacturation.objet.Text
            cr.XrLabel12.Text = SuiviFacturation.nReg.Text
            cr.XrLabel28.Text = SuiviFacturation.identifFisc.Text
            cr.XrLabel23.Text = SuiviFacturation.impot.Text
            cr.XrLabel14.Text = SuiviFacturation.montanttxt.Text
            cr.XrLabel6.Text = SuiviFacturation.montantttc.Text
            cr.XrLabel4.Text = SuiviFacturation.TextBoxX2.Text
            cr.XrTableCell35.Text = SuiviFacturation.creancetxt.Text
            var = SuiviFacturation.montantttc.Text.Replace(" DA/TTC", "")
            If IsConnected("SELECT entry_date,facturation_facture.nFacture,MantantHT,MantantFactureTTC,TitreCommande,code_affaire FROM facturation_facture WHERE facturation_facture.code_affaire='" & codeaff & "'", False) Then
                If myDR.HasRows Then
                    While myDR.Read
                        ds1.FactDT.AddFactDTRow(IIf(IsDBNull(myDR("entry_date")), "", myDR("entry_date")), IIf(IsDBNull(myDR("nFacture")), "", myDR("nFacture")), IIf(IsDBNull(myDR("MantantHT")), "", myDR("MantantHT")), IIf(IsDBNull(myDR("MantantFactureTTC")), "", myDR("MantantFactureTTC")), IIf(IsDBNull(myDR("TitreCommande")), "", myDR("TitreCommande")), IIf(IsDBNull(myDR("code_affaire")), "", myDR("code_affaire")))
                        If Not IsDBNull(myDR("MantantFactureTTC")) Then
                            sumfact = sumfact + myDR("MantantFactureTTC")
                        End If
                    End While
                End If
            End If
            If IsConnected("SELECT SUM(deduire_ttc) as avance, code_affaire FROM facturation_facture_deduire, facturation_facture WHERE facturation_facture.nFacture=facturation_facture_deduire.nFacture", False) Then
                If myDR.HasRows Then
                    While myDR.Read
                        ds1.DTdeduire.AddDTdeduireRow(IIf(IsDBNull(myDR("avance")), "", myDR("avance")), IIf(IsDBNull(myDR("code_affaire")), "", myDR("code_affaire")))
                    End While
                End If
            End If

            cr.XrTableCell25.Text = ""
            If var > 0 Then
                cr.XrTableCell35.Text = var - sumfact & " DA/TTC "
            End If
            ds1.EnforceConstraints = True
            cr.DataSource = ds1
            DocumentViewer1.DocumentSource = cr
            cr.CreateDocument(True)
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub
End Class