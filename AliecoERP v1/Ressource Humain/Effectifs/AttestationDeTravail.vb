Imports DevExpress.XtraRichEdit
Imports DevExpress.XtraPrinting
Imports System.IO
Imports DevExpress.XtraEditors.Controls
Public Class AttestationDeTravail
    Dim sql As New SQLControl
    Public matr As String = ""
    Private Sub AttestationDeTravail_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        load_Matricule_Nom()
        ' MsgBox(matr)
        If matr <> "" Then
            'ButtonX2.PerformClick()
            IsConnected("SELECT Matricule,Nom,Prénom,Date_de_Naissance,Lieux_de_Naissance,Ville,Date_entrée,Date_fin_de_contrat,Fonction,Sexe FROM Employes WHERE Matricule ='" & matr & "'", False)
            If myDR.HasRows Then
                While myDR.Read
                    If IO.File.Exists(Application.StartupPath & "/Docs/ATTESTATION DE TRAVAIL.rtf") Then IO.File.Copy(Application.StartupPath & "/Docs/ATTESTATION DE TRAVAIL.rtf", Application.StartupPath & "/Docs/Temporaire/ATTESTATION DE TRAVAIL.rtf", True)
                    RichEditControl1.LoadDocument(Application.StartupPath & "/Docs/Temporaire/ATTESTATION DE TRAVAIL.rtf", DocumentFormat.Rtf)
                    If myDR("Sexe").ToString = "Homme" Or myDR("Sexe").ToString = "H" Then
                        RichEditControl1.Document.ReplaceAll("[Sexe]", "Monsieur", API.Native.SearchOptions.CaseSensitive)
                    ElseIf myDR("Sexe").ToString = "Femme" Or myDR("Sexe").ToString = "F" Then
                        RichEditControl1.Document.ReplaceAll("[Sexe]", "Madame", API.Native.SearchOptions.CaseSensitive)
                    Else
                        RichEditControl1.Document.ReplaceAll("[Sexe]", myDR("Sexe").ToString, API.Native.SearchOptions.CaseSensitive)
                    End If
                    RichEditControl1.Document.ReplaceAll("[Nom]", myDR("Nom").ToString, API.Native.SearchOptions.CaseSensitive)
                    RichEditControl1.Document.ReplaceAll("[Prénom]", myDR("Prénom").ToString, API.Native.SearchOptions.CaseSensitive)
                    RichEditControl1.Document.ReplaceAll("[DN]", myDR("Date_de_Naissance").ToString("dd/MM/yyyy"), API.Native.SearchOptions.CaseSensitive)
                    RichEditControl1.Document.ReplaceAll("[LN]", myDR("Lieux_de_Naissance").ToString, API.Native.SearchOptions.CaseSensitive)
                    RichEditControl1.Document.ReplaceAll("[VN]", myDR("Ville").ToString, API.Native.SearchOptions.CaseSensitive)
                    RichEditControl1.Document.ReplaceAll("[DE]", myDR("Date_entrée").ToString("dd/MM/yyyy"), API.Native.SearchOptions.CaseSensitive)
                    RichEditControl1.Document.ReplaceAll("[Fonction]", myDR("Fonction").ToString, API.Native.SearchOptions.CaseSensitive)
                    RichEditControl1.Document.ReplaceAll("[Date]", Date.Now.ToString("dd/MM/yyyy"), API.Native.SearchOptions.None)
                    RichEditControl1.Document.ReplaceAll("[Ref]", ref.Text, API.Native.SearchOptions.None)
                End While
            End If
        End If
    End Sub
#Region "reload"
    Private Sub load_Matricule_Nom()
        ListMatNom.Properties.Items.Clear()
        IsConnected("SELECT DISTINCT Matricule,Nom,Prénom FROM employes ", False)
        If myDR.HasRows Then
            While myDR.Read
                ListMatNom.Properties.Items.Add(New ImageComboBoxItem(myDR("Matricule").ToString & " - " & myDR("Nom").ToString & " " & myDR("Prénom").ToString, myDR("Matricule").ToString, 4))
            End While
            ListMatNom.Properties.SmallImages = StatImageList
            ListMatNom.Properties.LargeImages = StatImageList
        End If
    End Sub
    'Sub affichage()
    '    matr = ListMatNom.Text
    '    'Dim dsObj As AttestationDS = New AttestationDS
    '    'FillDataSet(dsObj)
    '    'Dim cr As AttestationRp = New AttestationRp
    '    '' Set the report DataSet   
    '    ''cr.SetDataSource(ds)
    '    ''CrystalReportViewer1.ReportSource = cr
    '    'cr.DataSource = dsObj
    '    'DocumentViewer1.DocumentSource = cr
    '    'cr.CreateDocument(True)
    '    IsConnected("SELECT Matricule,Nom,Prénom,Date_de_Naissance,Lieux_de_Naissance,Ville,Date_entrée,Date_fin_de_contrat,Fonction,Sexe FROM Employes WHERE Matricule ='" & matr & "'", False)
    '    If myDR.HasRows Then
    '        While myDR.Read
    '            RichEditControl1.LoadDocument(Application.StartupPath & "/Docs/ATTESTATION DE TRAVAIL.rtf", DocumentFormat.Rtf)
    '            RichEditControl1.Document.ReplaceAll("[Sexe]", myDR("Sexe"), API.Native.SearchOptions.CaseSensitive)
    '            RichEditControl1.Document.ReplaceAll("[Nom]", myDR("Nom"), API.Native.SearchOptions.CaseSensitive)
    '            RichEditControl1.Document.ReplaceAll("[Prénom]", myDR("Prénom"), API.Native.SearchOptions.CaseSensitive)
    '            RichEditControl1.Document.ReplaceAll("[DN]", myDR("Date_de_Naissance"), API.Native.SearchOptions.CaseSensitive)
    '            RichEditControl1.Document.ReplaceAll("[LN]", myDR("Lieux_de_Naissance"), API.Native.SearchOptions.CaseSensitive)
    '            RichEditControl1.Document.ReplaceAll("[VN]", myDR("Ville"), API.Native.SearchOptions.CaseSensitive)
    '            RichEditControl1.Document.ReplaceAll("[DE]", myDR("Date_entrée"), API.Native.SearchOptions.CaseSensitive)
    '            RichEditControl1.Document.ReplaceAll("[Fonction]", myDR("Fonction"), API.Native.SearchOptions.CaseSensitive)
    '            RichEditControl1.Document.ReplaceAll("[Date]", Date.Now.ToString("dd/MM/yyyy"), API.Native.SearchOptions.None)
    '            'MsgBox(myDR("Matricule"))
    '            'Dim nref = 
    '            'dataSet.Certificat.AddCertificatRow(myDR("Matricule"), myDR("Nom"), myDR("Prénom"), myDR("Date_de_Naissance"), myDR("Date_entrée"), IIf(IsDBNull(myDR("Date_fin_de_contrat")), "N/D", myDR("Date_fin_de_contrat")), myDR("Lieux_de_Naissance"), myDR("Ville"), myDR("Fonction"), myDR("Sexe"))
    '            RichEditControl1.Document.ReplaceAll("[Ref]", ref.Text, API.Native.SearchOptions.None)
    '        End While
    '        ' RichEditControl1.SaveDocumentAs()
    '    End If
    'End Sub
    Public Sub FillDataSet(ByRef dataSet As AttestationDS)
        ' Turn off constraint checking before the dataset is filled.
        ' This allows the adapters to fill the dataset without concern
        ' for dependencies between the tables.
        dataSet.EnforceConstraints = False
        Try
            ' Attempt to fill the dataset MainTable
            dataSet.AttestationTB.Clear()
            IsConnected("SELECT Matricule,Nom,Prénom,Date_de_Naissance,Lieux_de_Naissance,Ville,Date_entrée,Fonction,Sexe,Date_entrée_1 FROM Employes WHERE Matricule =" & matr, False)
            If myDR.HasRows Then

                While myDR.Read
                    ' MsgBox(myDR("Matricule"))
                    dataSet.AttestationTB.AddAttestationTBRow(myDR("Matricule"), myDR("Nom"), myDR("Prénom"), myDR("Date_de_Naissance"), myDR("Lieux_de_Naissance"), myDR("Ville"), myDR("Date_entrée"), myDR("Date_entrée_1"), myDR("Sexe"), myDR("Fonction"))
                End While
                ' dataSet.Certificat.AddCertificatRow("20133", "BIDA", "Mohamed", "01-04-1987", "28-05-2012", "02-03-2015", "Thenia", "Boumerdes", "Chef de projet", "Monsieur")

            Else
                '  MsgBox("out")
                dataSet.AttestationTB.AddAttestationTBRow("20133", "Non Trouvé", "Non Trouvé", "Non Trouvé", "Non Trouvé", "Non Trouvé", "Non Trouvé", "Non Trouvé", "Non Trouvé", "Non Trouvé")
            End If
            ' dataSet.Certificat.AddCertificatRow("20133", "BIDA", "Mohamed", "01-04-1987", "28-05-2012", "02-03-2015", "Thenia", "Boumerdes", "Chef de projet", "Monsieur")
        Catch ex As Exception
            ' Add your error handling code here.
            Throw ex
        Finally
            ' Turn constraint checking back on.
            dataSet.EnforceConstraints = True
        End Try
    End Sub

#End Region
    'Private Sub AttestationDeTravail_Activated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Activated
    '    If matr <> "" Then
    '        'Dim dsObj As AttestationDS = New AttestationDS
    '        'FillDataSet(dsObj)
    '        'Dim cr As AttestationRp = New AttestationRp
    '        'cr.DataSource = dsObj
    '        'DocumentViewer1.DocumentSource = cr
    '        'cr.CreateDocument(True)
    '    End If
    'End Sub
    Private Sub ButtonX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX1.Click
        ExportToDOC("docx", DocumentFormat.OpenXml)
    End Sub
    Private Sub ExportToDOC(ByVal extension As String, ByVal df As DocumentFormat)
        'Dim report As AttestationRp = New AttestationRp
        'Dim sfd As New SaveFileDialog()
        'sfd.FileName = Environment.CurrentDirectory & "\" & report.ExportOptions.PrintPreview.DefaultFileName & "." & extension
        'sfd.Filter = extension & " File|*.doc"
        'If sfd.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
        '    Using docServer As New RichEditDocumentServer()
        '        report.ExportToHtml("test.html", New HtmlExportOptions() With {.ExportMode = HtmlExportMode.SingleFile, .EmbedImagesInHTML = True})
        '        docServer.LoadDocument("test.html", DocumentFormat.Html)
        '        docServer.SaveDocument(sfd.FileName, df)
        '    End Using
        '    File.Delete("test.html")
        '    If MessageBox.Show("Would you like to open file exported file?", extension & " export", MessageBoxButtons.YesNo) = System.Windows.Forms.DialogResult.Yes Then
        '        Process.Start(sfd.FileName)
        '    End If
        'End If
    End Sub

    Private Sub ButtonX2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX2.Click
        matr = ListMatNom.Value
       
        IsConnected("SELECT Matricule,Nom,Prénom,Date_de_Naissance,Lieux_de_Naissance,Ville,Date_entrée,Date_fin_de_contrat,Fonction,Sexe FROM Employes WHERE Matricule ='" & matr & "'", False)
        If myDR.HasRows Then
            While myDR.Read
                If IO.File.Exists(Application.StartupPath & "/Docs/ATTESTATION DE TRAVAIL.rtf") Then IO.File.Copy(Application.StartupPath & "/Docs/ATTESTATION DE TRAVAIL.rtf", Application.StartupPath & "/Docs/Temporaire/ATTESTATION DE TRAVAIL.rtf", True)
                RichEditControl1.LoadDocument(Application.StartupPath & "/Docs/Temporaire/ATTESTATION DE TRAVAIL.rtf", DocumentFormat.Rtf)
                If myDR("Sexe").ToString = "Homme" Or myDR("Sexe").ToString = "H" Then
                    RichEditControl1.Document.ReplaceAll("[Sexe]", "Monsieur", API.Native.SearchOptions.CaseSensitive)
                ElseIf myDR("Sexe").ToString = "Femme" Or myDR("Sexe").ToString = "F" Then
                    RichEditControl1.Document.ReplaceAll("[Sexe]", "Madame", API.Native.SearchOptions.CaseSensitive)
                Else
                    RichEditControl1.Document.ReplaceAll("[Sexe]", myDR("Sexe").ToString, API.Native.SearchOptions.CaseSensitive)
                End If
                RichEditControl1.Document.ReplaceAll("[Nom]", myDR("Nom").ToString, API.Native.SearchOptions.CaseSensitive)
                RichEditControl1.Document.ReplaceAll("[Prénom]", myDR("Prénom").ToString, API.Native.SearchOptions.CaseSensitive)
                RichEditControl1.Document.ReplaceAll("[DN]", myDR("Date_de_Naissance").ToString("dd/MM/yyyy"), API.Native.SearchOptions.CaseSensitive)
                RichEditControl1.Document.ReplaceAll("[LN]", myDR("Lieux_de_Naissance").ToString, API.Native.SearchOptions.CaseSensitive)
                RichEditControl1.Document.ReplaceAll("[VN]", myDR("Ville").ToString, API.Native.SearchOptions.CaseSensitive)
                RichEditControl1.Document.ReplaceAll("[DE]", myDR("Date_entrée").ToString("dd/MM/yyyy"), API.Native.SearchOptions.CaseSensitive)
                RichEditControl1.Document.ReplaceAll("[Fonction]", myDR("Fonction").ToString, API.Native.SearchOptions.CaseSensitive)
                RichEditControl1.Document.ReplaceAll("[Date]", Date.Now.ToString("dd/MM/yyyy"), API.Native.SearchOptions.None)
                'MsgBox(myDR("Matricule"))
                'Dim nref = 
                'dataSet.Certificat.AddCertificatRow(myDR("Matricule"), myDR("Nom"), myDR("Prénom"), myDR("Date_de_Naissance"), myDR("Date_entrée"), IIf(IsDBNull(myDR("Date_fin_de_contrat")), "N/D", myDR("Date_fin_de_contrat")), myDR("Lieux_de_Naissance"), myDR("Ville"), myDR("Fonction"), myDR("Sexe"))
                RichEditControl1.Document.ReplaceAll("[Ref]", ref.Text, API.Native.SearchOptions.None)
            End While
            ' RichEditControl1.SaveDocumentAs()
        End If
    End Sub

    Private Sub ListMatNom_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ListMatNom.SelectedIndexChanged
        If ListMatNom.Value = Nothing Then
            MessageBox.Show("Vous devez sélectionner un employe avant de cliquer ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ButtonX2.Enabled = False
        Else
            ButtonX2.Enabled = True
        End If
    End Sub

    Private Sub ButtonX4_Click(sender As System.Object, e As System.EventArgs) Handles ButtonX4.Click
        RichEditControl1.Print()
    End Sub
End Class