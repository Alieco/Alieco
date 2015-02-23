Imports DevComponents.DotNetBar
Imports DevExpress.XtraRichEdit
Imports DevExpress.XtraRichEdit.API.Native
Imports DevExpress.XtraRichEdit.Utils
Imports System.IO
Imports DevExpress.Office.Utils
Imports DevExpress.XtraTreeList
Imports DevExpress.XtraTreeList.Nodes

Public Class ImpeimerFacture
    Dim codeAffaire As String = ""
    Dim nFacture As String = ""
#Region "Function"
    Sub loadFilestoTree()
        Try
            treelist1.Nodes.Clear()
            treelist1.BeginUnboundLoad()
            Dim parentForRootNodes As TreeListNode = Nothing
            Dim rootNode As TreeListNode = treelist1.AppendNode(New Object() {"Sauvgarde de factures"}, parentForRootNodes)
            rootNode.ImageIndex = 0

            For Each myDirectory As IO.DirectoryInfo In New IO.DirectoryInfo(Application.StartupPath & "/Docs/facturationBackups/").GetDirectories()
                Dim aff As TreeListNode = treelist1.AppendNode(New Object() {myDirectory.Name}, rootNode)
                aff.ImageIndex = 2
                aff.SelectImageIndex = 2
                For Each mFile As IO.FileInfo In New IO.DirectoryInfo(myDirectory.FullName).GetFiles()
                    Dim af As TreeListNode = treelist1.AppendNode(New Object() {mFile.Name}, aff)
                    af.ImageIndex = 3
                    af.SelectImageIndex = 3
                Next
            Next
            rootNode.Expanded = True
            treelist1.EndUnboundLoad()
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub
    Private Sub FillTable()
        ' Fill the table with data
        Dim doc As Document = RichFacture.Document
        Dim tbl As Table = doc.Tables(3)
        'Dim di As New DirectoryInfo("C:\")
        Try
            tbl.BeginUpdate()
            IsConnected("SELECT * FROM facturation_facture_dp WHERE nFacture='" & mysql_escape_string(nFactureTxt.Text) & "' and dp_DouP='D'", False)
            If myDR.HasRows Then
                Dim row1 As TableRow = tbl.Rows.Append()
                Dim cell1 As TableCell = row1.FirstCell
                'doc.InsertSingleLineText(cell1.Range.Start, "")
                doc.InsertSingleLineText(cell1.Next.Range.Start, "DESIGNATION")
                Dim s As Double = 0
                While myDR.Read
                    Dim row As TableRow = tbl.Rows.Append()
                    Dim cell As TableCell = row.FirstCell
                    doc.InsertSingleLineText(cell.Range.Start, myDR("idfacure_dp"))
                    doc.InsertRtfText(cell.Next.Range.Start, "{\rtf1\deff0{\fonttbl{\f0 Calibri;}{\f1 Segoe UI Light;}}{\colortbl\red0\green0\blue0 ;\red0\green0\blue255 ;}{\*\defchp \fs22}{\*\listoverridetable}{\stylesheet {\ql\fs22 Normal;}{\*\cs1\fs22 Default Paragraph Font;}{\*\cs2\sbasedon1\fs22 Line Number;}{\*\cs3\ul\fs22\cf1 Hyperlink;}{\*\ts4\tsrowd\fs22\ql\trautofit1\tscellpaddfl3\tscellpaddl108\tscellpaddfr3\tscellpaddr108\tsvertalt\cltxlrtb Normal Table;}{\*\ts5\tsrowd\sbasedon4\fs22\ql\trbrdrt\brdrs\brdrw10\trbrdrl\brdrs\brdrw10\trbrdrb\brdrs\brdrw10\trbrdrr\brdrs\brdrw10\trbrdrh\brdrs\brdrw10\trbrdrv\brdrs\brdrw10\trautofit1\tscellpaddfl3\tscellpaddl108\tscellpaddfr3\tscellpaddr108\tsvertalt\cltxlrtb Table Simple 1;}}\nouicompat\splytwnine\htmautsp\sectd\pard\plain\ql{\lang1036\langfe1036\b\f1\cf0 " & myDR("dp_text") & "}\lang1036\langfe1036\b\f1\cf0\par\pard\plain\ql{\lang1036\langfe1036\f1\cf0 " & myDR("dp_description") & "}\f1\fs22\cf0\par}")
                    If myDR("dp_type") = "ensemble" Then
                        doc.InsertSingleLineText(cell.Next.Next.Range.Start, myDR("dp_qt").ToString & " Ens")
                    ElseIf myDR("dp_type") = "pourcentage" Then
                        doc.InsertSingleLineText(cell.Next.Next.Range.Start, myDR("dp_qt").ToString & " %")
                    ElseIf myDR("dp_type") = "unité" Then
                        doc.InsertSingleLineText(cell.Next.Next.Range.Start, myDR("dp_qt").ToString)
                    End If
                    doc.InsertSingleLineText(cell.Next.Next.Next.Range.Start, myDR("dp_pu"))
                    doc.InsertSingleLineText(cell.Next.Next.Next.Next.Range.Start, myDR("dp_ht"))
                    s += myDR("dp_ht")
                End While
                Dim row2 As TableRow = tbl.Rows.Append()
                Dim cell2 As TableCell = row2.FirstCell
                ' doc.InsertSingleLineText(cell2.Range.Start, "")
                doc.InsertSingleLineText(cell2.Next.Range.Start, "LE Montant total de Désignation :")
                doc.InsertSingleLineText(cell2.Next.Next.Next.Next.Range.Start, s)
            End If
            IsConnected("SELECT * FROM facturation_facture_dp WHERE nFacture='" & mysql_escape_string(nFactureTxt.Text) & "' and dp_DouP='P'", False)
            If myDR.HasRows Then
                Dim s As Double = 0
                Dim row1 As TableRow = tbl.Rows.Append()
                Dim cell1 As TableCell = row1.FirstCell
                doc.InsertSingleLineText(cell1.Range.Start, "")
                ' doc.InsertSingleLineText(cell1.Next.Range.Start, "PRESTATION")
                While myDR.Read
                    Dim row As TableRow = tbl.Rows.Append()
                    Dim cell As TableCell = row.FirstCell
                    doc.InsertRtfText(cell.Next.Range.Start, "{\rtf1\deff0{\fonttbl{\f0 Calibri;}{\f1 Segoe UI Light;}}{\colortbl\red0\green0\blue0 ;\red0\green0\blue255 ;}{\*\defchp \fs22}{\*\listoverridetable}{\stylesheet {\ql\fs22 Normal;}{\*\cs1\fs22 Default Paragraph Font;}{\*\cs2\sbasedon1\fs22 Line Number;}{\*\cs3\ul\fs22\cf1 Hyperlink;}{\*\ts4\tsrowd\fs22\ql\trautofit1\tscellpaddfl3\tscellpaddl108\tscellpaddfr3\tscellpaddr108\tsvertalt\cltxlrtb Normal Table;}{\*\ts5\tsrowd\sbasedon4\fs22\ql\trbrdrt\brdrs\brdrw10\trbrdrl\brdrs\brdrw10\trbrdrb\brdrs\brdrw10\trbrdrr\brdrs\brdrw10\trbrdrh\brdrs\brdrw10\trbrdrv\brdrs\brdrw10\trautofit1\tscellpaddfl3\tscellpaddl108\tscellpaddfr3\tscellpaddr108\tsvertalt\cltxlrtb Table Simple 1;}}\nouicompat\splytwnine\htmautsp\sectd\pard\plain\ql{\lang1036\langfe1036\b\f1\cf0 " & myDR("dp_text") & "}\lang1036\langfe1036\b\f1\cf0\par\pard\plain\ql{\lang1036\langfe1036\f1\cf0 " & myDR("dp_description") & "}\f1\fs22\cf0\par}")
                    doc.InsertSingleLineText(cell.Range.Start, myDR("idfacure_dp"))
                    doc.InsertSingleLineText(cell.Next.Range.Start, myDR("dp_text"))
                    If myDR("dp_type") = "ensemble" Then
                        doc.InsertSingleLineText(cell.Next.Next.Range.Start, myDR("dp_qt").ToString & " Ens")
                    ElseIf myDR("dp_type") = "pourcentage" Then
                        doc.InsertSingleLineText(cell.Next.Next.Range.Start, myDR("dp_qt").ToString & " %")
                    ElseIf myDR("dp_type") = "unité" Then
                        doc.InsertSingleLineText(cell.Next.Next.Range.Start, myDR("dp_qt").ToString)
                    End If
                    doc.InsertSingleLineText(cell.Next.Next.Next.Range.Start, myDR("dp_pu"))
                    doc.InsertSingleLineText(cell.Next.Next.Next.Next.Range.Start, myDR("dp_ht"))
                    s += myDR("dp_ht")
                End While
                Dim row2 As TableRow = tbl.Rows.Append()
                Dim cell2 As TableCell = row2.FirstCell
                doc.InsertSingleLineText(cell2.Range.Start, "")
                doc.InsertRtfText(cell2.Next.Range.Start, "{\rtf1\ansi \b LE Montant total de Préstation :\b0}")
                doc.InsertSingleLineText(cell2.Next.Next.Next.Next.Range.Start, s)
            End If
            IsConnected("SELECT * FROM facturation_facture_at WHERE nFacture='" & mysql_escape_string(nFactureTxt.Text) & "' ", False)
            If myDR.HasRows Then
                Dim s As Double = 0
                Dim row1 As TableRow = tbl.Rows.Append()
                Dim cell1 As TableCell = row1.FirstCell
                doc.InsertSingleLineText(cell1.Range.Start, "")
                doc.InsertSingleLineText(cell1.Next.Range.Start, "Modalité de paiement:")
                While myDR.Read
                    Dim row As TableRow = tbl.Rows.Append()
                    Dim cell As TableCell = row.FirstCell
                    doc.InsertSingleLineText(cell.Range.Start, "")
                    doc.InsertSingleLineText(cell.Next.Range.Start, myDR("at_valeur") & "% " & myDR("at_text"))
                    doc.InsertSingleLineText(cell.Next.Next.Next.Next.Range.Start, myDR("at_ht"))
                    s += myDR("at_ht")
                End While
                Dim row2 As TableRow = tbl.Rows.Append()
                Dim cell2 As TableCell = row2.FirstCell
                doc.InsertSingleLineText(cell2.Range.Start, "")
                doc.InsertRtfText(cell2.Next.Range.Start, "{\rtf1\ansi \b LE Montant total de Modalité :\b0}")
                doc.InsertSingleLineText(cell2.Next.Next.Next.Next.Range.Start, s)
            End If
            IsConnected("SELECT * FROM facturation_facture_remise WHERE nFacture='" & mysql_escape_string(nFactureTxt.Text) & "' ", False)
            If myDR.HasRows Then
                While myDR.Read
                    Dim row As TableRow = tbl.Rows.Append()
                    Dim cell As TableCell = row.FirstCell
                    doc.InsertSingleLineText(cell.Range.Start, "")
                    doc.InsertSingleLineText(cell.Next.Range.Start, myDR("remise_valeur") & "% Remise")
                    doc.InsertSingleLineText(cell.Next.Next.Next.Next.Range.Start, myDR("remise_ht"))
                End While
            End If
            IsConnected("SELECT * FROM facturation_facture_deduire WHERE nFacture='" & mysql_escape_string(nFactureTxt.Text) & "' ", False)
            If myDR.HasRows Then
                Dim s As Double = 0
                Dim row1 As TableRow = tbl.Rows.Append()
                Dim cell1 As TableCell = row1.FirstCell
                doc.InsertSingleLineText(cell1.Range.Start, "")
                doc.InsertSingleLineText(cell1.Next.Range.Start, "A DEDUIRE:")
                While myDR.Read
                    Dim row As TableRow = tbl.Rows.Append()
                    Dim cell As TableCell = row.FirstCell
                    doc.InsertSingleLineText(cell.Range.Start, "")
                    doc.InsertSingleLineText(cell.Next.Range.Start, myDR("deduire_por") & "% " & myDR("deduire_text"))
                    doc.InsertSingleLineText(cell.Next.Next.Next.Next.Range.Start, myDR("deduire_ht"))
                    s += myDR("deduire_ht")
                End While
                Dim row2 As TableRow = tbl.Rows.Append()
                Dim cell2 As TableCell = row2.FirstCell
                doc.InsertSingleLineText(cell2.Range.Start, "")
                doc.InsertRtfText(cell2.Next.Range.Start, "{\rtf1\ansi \b LE Montant total de DEDUIRE :\b0}")
                doc.InsertSingleLineText(cell2.Next.Next.Next.Next.Range.Start, s)
            End If
        Catch ex As Exception
            EnvoiError(ex.Message)
        Finally
            tbl.EndUpdate()
        End Try
    End Sub
    Sub LoadFacture()

    End Sub
#End Region

    Private Sub SerachTxt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SerachTxt.Click
        Try
            If nFactureTxt.Text <> "" Then
                If IsConnected("SELECT * FROM facturation_facture WHERE nFacture='" & mysql_escape_string(nFactureTxt.Text) & "'", False) Then
                    If myDR.HasRows Then
                        SaveBtn.Enabled = True
                        PrintBtn.Enabled = True
                        While myDR.Read
                            codeAffaire = myDR("code_affaire").ToString
                            nFacture = myDR("nFacture").ToString
                            If IO.File.Exists(Application.StartupPath & "/Docs/facturationBackups/Facture-" & myDR("code_affaire").ToString & "-" & myDR("nFacture").ToString & ".rft") Then
                                RichFacture.LoadDocument(Application.StartupPath & "/Docs/facturationBackups/Facture-" & myDR("code_affaire").ToString & "-" & myDR("nFacture").ToString & ".rft", DocumentFormat.Rtf)
                            Else
                                IO.File.Copy(Application.StartupPath & "/Docs/facturations/Facture.rtf", Application.StartupPath & "/Docs/tempo/Facture.rtf", True)
                                RichFacture.LoadDocument(Application.StartupPath & "/Docs/tempo/Facture.rtf", DocumentFormat.Rtf)
                                RichFacture.Document.ReplaceAll("[NUMFAC]", nFactureTxt.Text, API.Native.SearchOptions.CaseSensitive)
                                RichFacture.Document.ReplaceAll("[DATE]", myDR("entry_date").ToString, API.Native.SearchOptions.CaseSensitive)
                                RichFacture.Document.ReplaceAll("[commande]", myDR("TitreCommande").ToString, API.Native.SearchOptions.CaseSensitive)
                                RichFacture.Document.ReplaceAll("[code_affaire]", myDR("code_affaire").ToString, API.Native.SearchOptions.CaseSensitive)
                                RichFacture.Document.ReplaceAll("[MANTANT]", myDR("MantantFactureTTC").ToString, API.Native.SearchOptions.CaseSensitive)
                                RichFacture.Document.ReplaceAll("[CHIFFRE]", ConvNumberLetter(CDbl(myDR("MantantFactureTTC").ToString), 0), API.Native.SearchOptions.CaseSensitive)
                                'RichFacture.Document.ReplaceAll("[NUMFAC]", myDR("TitreCommande").ToString, API.Native.SearchOptions.CaseSensitive)
                                FillTable()
                            End If
                        End While
                    Else
                        MessageBoxEx.Show("le n° de facture entré exist pas ou pas valide !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand)
                    End If
                End If
                IsConnected("SELECT NArticle_imposition,NIdentif_fiscale,NRC,NomClient, Adresse FROM commercial_affaire, commercial_client WHERE commercial_affaire.idclient=commercial_client.idclient and code_affaire='" & codeAffaire & "'", False)
                If myDR.HasRows Then
                    While myDR.Read
                        RichFacture.Document.ReplaceAll("[reg_com]", myDR("NRC").ToString, API.Native.SearchOptions.CaseSensitive)
                        RichFacture.Document.ReplaceAll("[nis]", myDR("NIdentif_fiscale").ToString, API.Native.SearchOptions.CaseSensitive)
                        RichFacture.Document.ReplaceAll("[art_impo]", myDR("NArticle_imposition").ToString, API.Native.SearchOptions.CaseSensitive)
                        RichFacture.Document.ReplaceAll("[Nom]", myDR("NomClient").ToString, API.Native.SearchOptions.CaseSensitive)
                        RichFacture.Document.ReplaceAll("[adresse]", myDR("Adresse").ToString, API.Native.SearchOptions.CaseSensitive)
                    End While
                End If
            Else
                MessageBoxEx.Show("le n° de facture entré est vide !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand)
            End If
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub


    Private Sub SaveBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveBtn.Click
        Try
            If IO.Directory.Exists(Application.StartupPath & "/Docs/facturationBackups/" & codeAffaire) Then
                RichFacture.SaveDocument(Application.StartupPath & "/Docs/facturationBackups/" & codeAffaire & "/facture-" & codeAffaire & "-" & nFacture & ".rtf", DocumentFormat.Rtf)
            Else
                IO.Directory.CreateDirectory(Application.StartupPath & "/Docs/facturationBackups/" & codeAffaire)
                If IO.Directory.Exists(Application.StartupPath & "/Docs/facturationBackups/" & codeAffaire) Then
                    RichFacture.SaveDocument(Application.StartupPath & "/Docs/facturationBackups/" & codeAffaire & "/facture-" & codeAffaire & "-" & nFacture & ".rtf", DocumentFormat.Rtf)
                    MessageBoxEx.Show("La facture a bien été enregistré avec succès  !", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBoxEx.Show("une erreur s'est produite lors de l'enregistrement : Creation de dossier d'affaire", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand)
                End If
            End If
            loadFilestoTree()
        Catch ex As Exception
            MessageBoxEx.Show("une erreur s'est produite lors de l'enregistrement", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Hand)
            EnvoiError(ex.Message)
        End Try
    End Sub

    Private Sub PrintBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintBtn.Click
        Try
            RichFacture.Print()
        Catch ex As Exception
            MessageBoxEx.Show("une erreur s'est produit lors de l'imprission", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand)
            EnvoiError(ex.Message)
        End Try
    End Sub

    Private Sub ImpeimerFacture_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            loadFilestoTree()
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub

    Private Sub treelist1_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles treelist1.DoubleClick
        Try
            Dim fPoint As Point = Control.MousePosition
            Dim tl As TreeList = sender
            fPoint = tl.PointToClient(fPoint)
            Dim hInfo As TreeListHitInfo = tl.CalcHitInfo(fPoint)
            If Not hInfo.Node Is Nothing Then
                If hInfo.Node.GetDisplayText(0).Contains("facture") Then
                    If MessageBoxEx.Show("Voullez vous vraiment ouvrir cette facture ?", "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.Yes Then
                        ' RichFacture.SaveDocument(Application.StartupPath & "/Docs/facturationBackups/" & codeAffaire & "/facture-" & codeAffaire & "-" & nFacture & ".rtf", DocumentFormat.Rtf)
                        RichFacture.LoadDocument(Application.StartupPath & "/Docs/facturationBackups/" & hInfo.Node.ParentNode.GetDisplayText(0) & "/" & hInfo.Node.GetDisplayText(0), DocumentFormat.Rtf)
                    End If
                End If
            End If
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub

    Private Sub ButtonX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX1.Click
        Try
            RichFacture.LoadDocument(Application.StartupPath & "/Docs/facturations/Facture.rtf", DocumentFormat.Rtf)
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub

    Private Sub ButtonX2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX2.Click
        Try
            Console.WriteLine(RichFacture.RtfText)
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub
End Class