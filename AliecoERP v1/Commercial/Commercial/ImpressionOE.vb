Imports DevExpress.XtraRichEdit
Imports DevExpress.XtraPrinting
Imports System.IO
Imports DevExpress.XtraEditors.Controls
Public Class ImpressionOE
    Private Sub ImpressionOE_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Try
            load_affaire()
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub
    Sub load_affaire()
        Try
            Dim query = "SELECT DISTINCT(commercial_oe.code_affaire) from commercial_oe left join commercial_affaire on commercial_oe.code_affaire=commercial_affaire.code_affaire "
            If IsConnected(query, False) Then
                If myDR.HasRows Then
                    While myDR.Read
                        affaire.Items.Add(myDR("code_affaire"))
                    End While
                End If
            End If
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub

    Private Sub ButtonX1_Click(sender As System.Object, e As System.EventArgs) Handles ButtonX1.Click
        'Try
        Dim ds1 As commercialOE = New commercialOE
        Dim cr As New ImpressionOERP()
        Dim cr2 As New ImpressionOERp1()
        Dim cr1 As New SousRPOE()
        Try
            ds1.EnforceConstraints = False
            IsConnected("SELECT  * from commercial_oe_ensemble_general,commercial_oe where commercial_oe.idcommercial_OE=commercial_oe_ensemble_general.idcommercial_OE and code_affaire='" & affaire.Text & "' ", False)
            If myDR.HasRows Then
                While myDR.Read
                    ds1.commercial_ensemble_generalDS.Addcommercial_ensemble_generalDSRow(IIf(IsDBNull(myDR("category")), "", myDR("category")), IIf(IsDBNull(myDR("num_execution")), "", myDR("num_execution")), IIf(IsDBNull(myDR("text")), "", myDR("text")))
                End While
            End If
            '' GridControl1.DataSource = ds1
            Dim code As String = ""
            If IsConnected("SELECT  * from commercial_affaire where code_affaire= '" & affaire.Text & "' ", False) Then
                If myDR.HasRows Then
                    While myDR.Read
                        'RichEditControl1.LoadDocument(Application.StartupPath & "/Docs/OE.rtf", DocumentFormat.Rtf)
                        'RichEditControl1.Document.ReplaceAll("[nomcl]", myDR("nomcl"), API.Native.SearchOptions.CaseSensitive)
                        'RichEditControl1.Document.ReplaceAll("[titre]", myDR("titre"), API.Native.SearchOptions.CaseSensitive)
                        'RichEditControl1.Document.ReplaceAll("[delai_exe]", myDR("delai_exe"), API.Native.SearchOptions.CaseSensitive)
                        cr.XrLabel1.Text = myDR("nomcl").ToString()
                        cr.XrLabel2.Text = myDR("titre").ToString()
                        cr.XrLabel23.Text = myDR("delai_exe").ToString()
                        code = myDR("code")
                    End While
                End If
            End If
            If IsConnected("SELECT  * from commercial_affaire_bordereauprix where code= '" & code & "' ", False) Then
                If myDR.HasRows Then
                    While myDR.Read
                        cr2.XrLabel47.Text = " HT : " & myDR("total") & vbNewLine & " TVA : " & myDR("totaltva") & vbNewLine & " TTC : " & myDR("totalttc")
                        'RichEditControl1.Document.ReplaceAll("[prix]", " HT : " & myDR("total") & vbNewLine & " TVA : " & myDR("totaltva") & vbNewLine & " TTC : " & myDR("totalttc"), API.Native.SearchOptions.CaseSensitive)
                    End While
                End If
            End If
            Dim avance As String = ""
            Dim terme As String = ""
            Dim modalit As String = ""
            IsConnected("SELECT * from commercial_offre_modalite where code= '" & code & "' ", False)
            If myDR.HasRows Then
                While myDR.Read
                    If myDR("type") = "Avance remboursement" Then
                        avance += Environment.NewLine & "  • " & myDR("description")
                    Else
                        terme += Environment.NewLine & "  • " & myDR("description")
                    End If
                End While
                If avance <> "" Then avance = "a) Avances remboursable : " & vbNewLine & avance
                If terme <> "" Then terme = "b) Terme de payement : " & vbNewLine & terme
                modalit = avance & vbNewLine & terme
            End If
            cr2.XrLabel46.Text = modalit
            'RichEditControl1.Document.ReplaceAll("[modalit]", modalit, API.Native.SearchOptions.CaseSensitive)
            Dim des As String = ""
            If IsConnected("SELECT  * from commercial_oe where code_affaire= '" & affaire.Text & "' ", False) Then
                If myDR.HasRows Then
                    While myDR.Read
                        des = myDR("destination").ToString
                        'MsgBox(des)
                        'RichEditControl1.Document.ReplaceAll("[datediff]", myDR("datediff").ToString(), API.Native.SearchOptions.CaseSensitive)
                        'RichEditControl1.Document.ReplaceAll("[clichePar]", myDR("clichePar"), API.Native.SearchOptions.CaseSensitive)
                        'RichEditControl1.Document.ReplaceAll("[visePar]", myDR("visePar").ToString(), API.Native.SearchOptions.CaseSensitive)
                        'RichEditControl1.Document.ReplaceAll("[EtabliPar]", myDR("EtabliPar").ToString(), API.Native.SearchOptions.CaseSensitive)
                        'RichEditControl1.Document.ReplaceAll("[code1]", myDR("code1").ToString(), API.Native.SearchOptions.CaseSensitive)
                        'RichEditControl1.Document.ReplaceAll("[code2]", myDR("code2").ToString(), API.Native.SearchOptions.CaseSensitive)
                        'RichEditControl1.Document.ReplaceAll("[code3]", myDR("code3").ToString(), API.Native.SearchOptions.CaseSensitive)
                        'RichEditControl1.Document.ReplaceAll("[code4]", myDR("code4").ToString(), API.Native.SearchOptions.CaseSensitive)
                        'RichEditControl1.Document.ReplaceAll("[code5]", myDR("code5").ToString(), API.Native.SearchOptions.CaseSensitive)
                        'RichEditControl1.Document.ReplaceAll("[proposition]", myDR("proposition").ToString(), API.Native.SearchOptions.CaseSensitive)
                        'RichEditControl1.Document.ReplaceAll("[duProposition]", myDR("duProposition").ToString(), API.Native.SearchOptions.CaseSensitive)
                        'RichEditControl1.Document.ReplaceAll("[commande]", myDR("commande").ToString(), API.Native.SearchOptions.CaseSensitive)
                        'RichEditControl1.Document.ReplaceAll("[duCommande]", myDR("duCommande").ToString(), API.Native.SearchOptions.CaseSensitive)
                        'RichEditControl1.Document.ReplaceAll("[NClassement]", myDR("NClassement").ToString(), API.Native.SearchOptions.CaseSensitive)
                        'RichEditControl1.Document.ReplaceAll("[code_affaire]", myDR("code_affaire").ToString(), API.Native.SearchOptions.CaseSensitive)
                        'RichEditControl1.Document.ReplaceAll("[poids]", myDR("poids").ToString(), API.Native.SearchOptions.CaseSensitive)
                        'RichEditControl1.Document.ReplaceAll("[controle]", myDR("controle").ToString(), API.Native.SearchOptions.CaseSensitive)
                        'RichEditControl1.Document.ReplaceAll("[miseEnChantier]", myDR("miseEnChantier").ToString(), API.Native.SearchOptions.CaseSensitive)
                        'RichEditControl1.Document.ReplaceAll("[protection]", myDR("protection").ToString(), API.Native.SearchOptions.CaseSensitive)
                        'RichEditControl1.Document.ReplaceAll("[emballage]", myDR("emballage").ToString(), API.Native.SearchOptions.CaseSensitive)
                        'RichEditControl1.Document.ReplaceAll("[marquage]", myDR("marquage").ToString(), API.Native.SearchOptions.CaseSensitive)
                        'RichEditControl1.Document.ReplaceAll("[destinataire]", myDR("destinataire").ToString(), API.Native.SearchOptions.CaseSensitive)
                        'RichEditControl1.Document.ReplaceAll("[modeEnvoi]", myDR("modeEnvoi").ToString(), API.Native.SearchOptions.CaseSensitive)
                        'RichEditControl1.Document.ReplaceAll("[assurance]", myDR("assurance").ToString(), API.Native.SearchOptions.CaseSensitive)
                        'RichEditControl1.Document.ReplaceAll("[docExpCl]", myDR("docExpCl").ToString(), API.Native.SearchOptions.CaseSensitive)
                        'RichEditControl1.Document.ReplaceAll("[docExpTier]", myDR("docExpTier").ToString(), API.Native.SearchOptions.CaseSensitive)
                        'RichEditControl1.Document.ReplaceAll("[revision]", myDR("revision").ToString(), API.Native.SearchOptions.CaseSensitive)
                        'RichEditControl1.Document.ReplaceAll("[penabilite]", myDR("penabilite").ToString(), API.Native.SearchOptions.CaseSensitive)
                        'RichEditControl1.Document.ReplaceAll("[redevance]", myDR("redevance").ToString(), API.Native.SearchOptions.CaseSensitive)
                        cr.XrLabel18.Text = myDR("datediff").ToString()
                        cr.XrLabel17.Text = myDR("clichePar")
                        cr.XrLabel16.Text = myDR("visePar").ToString()
                        cr.XrLabel15.Text = myDR("EtabliPar").ToString()
                        cr.XrLabel6.Text = myDR("code1").ToString()
                        cr.XrLabel5.Text = myDR("code2").ToString()
                        cr.XrLabel9.Text = myDR("code3").ToString()
                        cr.XrLabel8.Text = myDR("code4").ToString()
                        cr.XrLabel7.Text = myDR("code5").ToString()
                        cr.XrLabel10.Text = myDR("proposition").ToString()
                        cr.XrLabel11.Text = myDR("duProposition").ToString()
                        cr.XrLabel12.Text = myDR("commande").ToString()
                        cr.XrLabel13.Text = myDR("duCommande").ToString()
                        cr.XrLabel3.Text = myDR("NClassement").ToString()
                        cr.XrLabel4.Text = myDR("code_affaire").ToString()
                        cr.XrLabel22.Text = myDR("poids").ToString()
                        cr.XrLabel35.Text = myDR("controle").ToString()
                        cr.XrLabel19.Text = myDR("miseEnChantier").ToString()
                        cr2.XrLabel36.Text = myDR("protection").ToString()
                        cr2.XrLabel37.Text = myDR("emballage").ToString()
                        cr2.XrLabel40.Text = myDR("marquage").ToString()
                        cr2.XrLabel41.Text = myDR("destinataire").ToString()
                        cr2.XrLabel42.Text = myDR("modeEnvoi").ToString()
                        cr2.XrLabel43.Text = myDR("assurance").ToString()
                        cr2.XrLabel44.Text = myDR("docExpCl").ToString()
                        cr2.XrLabel45.Text = myDR("docExpTier").ToString()
                        cr2.XrLabel49.Text = myDR("revision").ToString()
                        cr2.XrLabel50.Text = myDR("penabilite").ToString()
                        cr2.XrLabel48.Text = myDR("redevance").ToString()
                        'MsgBox("ok1")
                    End While
                End If

            End If
            If des <> "" Then
                Dim dest() = des.Split(",")
                'RichEditControl1.Document.ReplaceAll("[dc]", dest(0).Substring(dest(0).Length - 2).Replace("|", "").Replace("0", ""), API.Native.SearchOptions.CaseSensitive)
                'RichEditControl1.Document.ReplaceAll("[so]", dest(1).Substring(dest(0).Length - 2).Replace("|", "").Replace("0", ""), API.Native.SearchOptions.CaseSensitive)
                'RichEditControl1.Document.ReplaceAll("[sc]", dest(2).Substring(dest(0).Length - 2).Replace("|", "").Replace("0", ""), API.Native.SearchOptions.CaseSensitive)
                'RichEditControl1.Document.ReplaceAll("[compt]", dest(3).Substring(dest(0).Length - 2).Replace("|", "").Replace("0", ""), API.Native.SearchOptions.CaseSensitive)
                'RichEditControl1.Document.ReplaceAll("[be]", dest(4).Substring(dest(0).Length - 2).Replace("|", "").Replace("0", ""), API.Native.SearchOptions.CaseSensitive)
                'RichEditControl1.Document.ReplaceAll("[appr]", dest(5).Substring(dest(0).Length - 2).Replace("|", "").Replace("0", ""), API.Native.SearchOptions.CaseSensitive)
                'RichEditControl1.Document.ReplaceAll("[mc]", dest(6).Substring(dest(0).Length - 2).Replace("|", "").Replace("0", ""), API.Native.SearchOptions.CaseSensitive)
                'RichEditControl1.Document.ReplaceAll("[mecan]", dest(7).Substring(dest(0).Length - 2).Replace("|", "").Replace("0", ""), API.Native.SearchOptions.CaseSensitive)
                'RichEditControl1.Document.ReplaceAll("[chaud]", dest(8).Substring(dest(0).Length - 2).Replace("|", "").Replace("0", ""), API.Native.SearchOptions.CaseSensitive)
                'RichEditControl1.Document.ReplaceAll("[sg]", dest(9).Substring(dest(0).Length - 2).Replace("|", "").Replace("0", ""), API.Native.SearchOptions.CaseSensitive)
                'RichEditControl1.Document.ReplaceAll("[magasin]", dest(10).Substring(dest(0).Length - 2).Replace("|", "").Replace("0", ""), API.Native.SearchOptions.CaseSensitive)
                'RichEditControl1.Document.ReplaceAll("[exp]", dest(11).Substring(dest(0).Length - 2).Replace("|", "").Replace("0", ""), API.Native.SearchOptions.CaseSensitive)
                'RichEditControl1.Document.ReplaceAll("[spr]", dest(12).Substring(dest(0).Length - 2).Replace("|", "").Replace("0", ""), API.Native.SearchOptions.CaseSensitive)
                cr.XrLabel14.Text = dest(0).Substring(dest(0).Length - 2).Replace("|", "").Replace("0", "")
                cr.XrLabel21.Text = dest(1).Substring(dest(1).Length - 2).Replace("|", "").Replace("0", "")
                cr.XrLabel20.Text = dest(2).Substring(dest(2).Length - 2).Replace("|", "").Replace("0", "")
                cr.XrLabel28.Text = dest(3).Substring(dest(3).Length - 2).Replace("|", "").Replace("0", "")
                cr.XrLabel27.Text = dest(4).Substring(dest(4).Length - 2).Replace("|", "").Replace("0", "")
                cr.XrLabel26.Text = dest(5).Substring(dest(5).Length - 2).Replace("|", "").Replace("0", "")
                cr.XrLabel25.Text = dest(6).Substring(dest(6).Length - 2).Replace("|", "").Replace("0", "")
                cr.XrLabel24.Text = dest(7).Substring(dest(7).Length - 2).Replace("|", "").Replace("0", "")
                cr.XrLabel31.Text = dest(8).Substring(dest(8).Length - 2).Replace("|", "").Replace("0", "")
                cr.XrLabel30.Text = dest(9).Substring(dest(9).Length - 2).Replace("|", "").Replace("0", "")
                cr.XrLabel29.Text = dest(10).Substring(dest(10).Length - 2).Replace("|", "").Replace("0", "")
                cr.XrLabel32.Text = dest(11).Substring(dest(11).Length - 2).Replace("|", "").Replace("0", "")
                cr.XrLabel34.Text = dest(12).Substring(dest(12).Length - 2).Replace("|", "").Replace("0", "")
            End If
        Catch ex As Exception
            EnvoiError(ex.Message)
        Finally
            ds1.EnforceConstraints = True
        End Try
        cr1.DataSource = ds1
        cr2.DataSource = ds1
        cr.XrSubreport1.ReportSource = cr1
        cr.CreateDocument()
        cr2.CreateDocument()
        cr.Pages.AddRange(cr2.Pages)
        DocumentViewer1.DocumentSource = cr
        'Catch ex As Exception
        '    EnvoiError(ex.Message)
        'End Try
    End Sub
End Class