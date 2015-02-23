Imports DevExpress.XtraRichEdit
Imports DevExpress.XtraRichEdit.API.Native
Imports DevExpress.XtraRichEdit.Utils
Imports System.IO
Imports DevExpress.Office.Utils
Imports DevComponents.DotNetBar
Public Class ImprimerOffre
    Dim c = ListOffre.code
    Dim alieco As String = ""
    Dim client As String = ""
    Dim avance As String = ""
    Dim terme As String = ""
    Dim avance1 As String = ""
    Dim terme1 As String = ""
    Dim modalit As String = ""
    Dim Nclient As String = ""
    Dim ds1 As FicheOffreDS = New FicheOffreDS
    Dim cr As New FicheOffreCommercialRP()
    Private Sub ImprimerOffre_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            ' MsgBox(c)
            Dim total As Double = 0
            Dim tva As Double = 0
            Dim totalttc As Double = 0
            Dim idclient As String = ""
            Dim presA As String = ""
            Dim presC As String = ""
            RichEditControl1.LoadDocument(Application.StartupPath & "/Docs/OffrePasserelle1.rtf", DocumentFormat.Rtf)
            Dim doc As Document = RichEditControl1.Document
            Dim tbl As Table = doc.Tables(0)
            tbl.BeginUpdate()
            If IsConnected("SELECT * from commercial_offre,commercial_offre_bordereauprix where commercial_offre.code=commercial_offre_bordereauprix.code  and commercial_offre.code= '" & c & "' ", False) Then
                If myDR.HasRows Then
                    ' MsgBox("ok")
                    While myDR.Read
                        ' MsgBox("ok1")
                        idclient = myDR("idclient").ToString
                        RichEditControl1.Document.ReplaceAll("[Projet]", myDR("titre").ToString, API.Native.SearchOptions.CaseSensitive)
                        RichEditControl1.Document.ReplaceAll("[Titre1]", myDR("titre").ToString, API.Native.SearchOptions.CaseSensitive)
                        RichEditControl1.Document.ReplaceAll("[projet1]", myDR("code_affaire").ToString, API.Native.SearchOptions.CaseSensitive)
                        RichEditControl1.Document.ReplaceAll("[delai_option]", myDR("delai_option").ToString, API.Native.SearchOptions.CaseSensitive)
                        RichEditControl1.Document.ReplaceAll("[delai_exe]", myDR("delai_exe").ToString, API.Native.SearchOptions.CaseSensitive)
                        ' MsgBox("ok2")
                        'total = myDR("total").ToString
                        'tva = myDR("totaltva").ToString
                        'totalttc = myDR("totalttc").ToString
                        If myDR("type") = "P" Then
                            ' MsgBox("ok2.1")
                            If myDR("alaChargeDe") = "A" Then
                                presA += "  • " & myDR("desig").ToString & Environment.NewLine
                            Else
                                '  MsgBox("ok2.2")
                                presC += "  • " & myDR("desig").ToString & Environment.NewLine
                            End If
                            'MsgBox("ok3")
                        Else
                            Dim row As TableRow = tbl.Rows.Append()
                            Dim cell As TableCell = row.FirstCell
                            'MsgBox("ok4")
                            doc.InsertSingleLineText(cell.Range.Start, myDR("num").ToString)
                            doc.InsertSingleLineText(cell.Next.Range.Start, myDR("desig").ToString)
                            doc.InsertSingleLineText(cell.Next.Next.Range.Start, myDR("Qt").ToString)
                            doc.InsertSingleLineText(cell.Next.Next.Next.Range.Start, (myDR("PrixUnit").ToString))
                            doc.InsertSingleLineText(cell.Next.Next.Next.Next.Range.Start, (myDR("Montant").ToString))
                            total += myDR("Montant")
                        End If
                    End While
                End If
            End If
            tbl.EndUpdate()
            If presA = "" Then
                ' MsgBox("ok5")
                RichEditControl1.Document.ReplaceAll("[nos_prestation]", "", API.Native.SearchOptions.CaseSensitive)
            Else : RichEditControl1.Document.ReplaceAll("[nos_prestation]", "Nos prestations se limitent à :" & Environment.NewLine & presA & Environment.NewLine, API.Native.SearchOptions.CaseSensitive)
            End If
            'MsgBox("ok6")
            If presC = "" Then
                ' MsgBox("ok7")
                RichEditControl1.Document.ReplaceAll("[Prestation _client]", "", API.Native.SearchOptions.CaseSensitive)
            Else : RichEditControl1.Document.ReplaceAll("[Prestation _client]", "Nos prestations se limitent à :" & Environment.NewLine & presC & Environment.NewLine, API.Native.SearchOptions.CaseSensitive)
            End If
            tva = (total * 17) / 100
            totalttc = total + tva
            RichEditControl1.Document.ReplaceAll("[montant_ht]", total, API.Native.SearchOptions.CaseSensitive)
            RichEditControl1.Document.ReplaceAll("[tva]", tva, API.Native.SearchOptions.CaseSensitive)
            RichEditControl1.Document.ReplaceAll("[montant_ttc]", totalttc, API.Native.SearchOptions.CaseSensitive)
            ' MsgBox("ok8")
            If IsConnected("SELECT  * from commercial_client where idclient= '" & idclient & "' ", False) Then
                If myDR.HasRows Then
                    While myDR.Read
                        ' MsgBox("ok9")
                        RichEditControl1.Document.ReplaceAll("[Titre]", myDR("RaisonSocial").ToString, API.Native.SearchOptions.CaseSensitive)
                        RichEditControl1.Document.ReplaceAll("[Directeur]", myDR("NomClient").ToString, API.Native.SearchOptions.CaseSensitive)
                        RichEditControl1.Document.ReplaceAll("[fax]", myDR("Fax").ToString, API.Native.SearchOptions.CaseSensitive)
                    End While
                End If
            End If

            IsConnected("SELECT * from commercial_offre_modalite where code= '" & c & "' ", False)
            If myDR.HasRows Then
                While myDR.Read
                    ' MsgBox("ok10")
                    If myDR("type") = "Avance remboursement" Then
                        avance1 += "  • " & myDR("valeur").ToString & "% " & myDR("description").ToString & Environment.NewLine
                    Else
                        terme1 += "  • " & myDR("valeur").ToString & "% " & myDR("description").ToString & Environment.NewLine
                    End If
                End While
                If avance1 <> "" Then
                    RichEditControl1.Document.ReplaceAll("[Avance_remboursable]", "a) Avances remboursable : " & vbNewLine & avance1, API.Native.SearchOptions.CaseSensitive)
                Else : RichEditControl1.Document.ReplaceAll("[Avance_remboursable]", "", API.Native.SearchOptions.CaseSensitive)
                End If
                '  MsgBox("ok11")
                If terme1 <> "" Then
                    RichEditControl1.Document.ReplaceAll("[terme_paiement]", "b) Terme de payement : " & vbNewLine & terme1, API.Native.SearchOptions.CaseSensitive)
                Else : RichEditControl1.Document.ReplaceAll("[terme_paiement]", "", API.Native.SearchOptions.CaseSensitive)
                End If
                'MsgBox("ok12")
            End If
            '  MsgBox("ok13")
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub
    '************************************************
    ' ds1.EnforceConstraints = False
    '        Try
    '            IsConnected("SELECT * from commercial_offre_modalite where code= '" & c & "' ", False)
    '            If myDR.HasRows Then
    '                While myDR.Read
    '                    If myDR("type") = "Avance remboursement" Then
    '                        avance += Environment.NewLine & "  • " & myDR("valeur") & "% " & myDR("description")
    '                    Else
    '                        terme += Environment.NewLine & "  • " & myDR("valeur") & "% " & myDR("description")
    '                    End If
    '                End While
    '                If avance <> "" Then avance = "a) Avances remboursable : " & vbNewLine & avance
    '                If terme <> "" Then terme = "b) Terme de payement : " & vbNewLine & terme
    '                modalit = avance & vbNewLine & terme
    '            End If
    '            IsConnected("SELECT  * from commercial_offre_prestation where code= '" & c & "' ", False)
    '            If myDR.HasRows Then
    '                While myDR.Read
    '                    If myDR("type") = "Alieco" Then
    '                        alieco += Environment.NewLine & "  • " & myDR("text")
    '                    Else
    '                        client += Environment.NewLine & "  • " & myDR("text")
    '                    End If
    '                End While
    '            End If
    '            IsConnected("SELECT  * from commercial_offre,commercial_offre_bordereauprix where commercial_offre.code=commercial_offre_bordereauprix.code  and commercial_offre.code= '" & c & "' ", False)
    '            If myDR.HasRows Then
    '                While myDR.Read
    '                    ds1.OffreDT.AddOffreDTRow(IIf(IsDBNull(myDR("code")), "", CDbl(myDR("code"))), IIf(IsDBNull(myDR("nomcl")), "", myDR("nomcl")), IIf(IsDBNull(myDR("titre")), "", myDR("titre")), IIf(IsDBNull(myDR("delai_exe")), "", myDR("delai_exe")), IIf(IsDBNull(myDR("num")), "", myDR("num")), IIf(IsDBNull(myDR("desig")), "", myDR("desig")), IIf(IsDBNull(myDR("Qt")), "", myDR("Qt")), IIf(IsDBNull(myDR("PrixUnit")), "", myDR("PrixUnit")), IIf(IsDBNull(myDR("Montant")), "", myDR("Montant")), IIf(IsDBNull(myDR("total")), "", myDR("total")), IIf(IsDBNull(myDR("totaltva")), "", myDR("totaltva")), IIf(IsDBNull(myDR("totalttc")), "", myDR("totalttc")))
    '                    Nclient = myDR("nomcl").ToString
    '                End While
    '            End If
    'Dim clie() = Nclient.Split("-")
    '            If IsConnected("SELECT  * from commercial_client where NomClient= '" & clie(0) & "' ", False) Then
    '                If myDR.HasRows Then
    '                    While myDR.Read
    '                        cr.XrLabel3.Text = myDR("RaisonSocial")
    '                        cr.XrLabel4.Text = cr.XrLabel4.Text.Replace("{@}", myDR("NomClient"))
    '                        cr.XrLabel6.Text = "Fax : " & myDR("Fax")
    '                    End While
    '                End If
    '            End If
    '        Catch ex As Exception
    '            EnvoiError(ex.Message)
    '        Finally
    '            ds1.EnforceConstraints = True
    '        End Try
    '' GridControl1.DataSource = ds1
    '        cr.XrLabel18.Text = alieco
    '        cr.XrLabel20.Text = client
    '        cr.XrLabel21.Text = modalit
    '        cr.DataSource = ds1
    '        DocumentViewer1.DocumentSource = cr
    '        cr.CreateDocument(True)
End Class