Imports DevExpress.XtraRichEdit
Imports DevExpress.XtraEditors.Controls

Public Class CertificatDeTravail
    Public matri As String = ""
    Private Sub CertificatDeTravail_Activated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Activated
        If matri <> "" Then
            'Dim dsObj As CertificatDS = New CertificatDS
            'FillDataSet(dsObj)
            'Dim cr As CertificatRP = New CertificatRP
            '' Set the report DataSet   
            ''cr.SetDataSource(ds)
            ''CrystalReportViewer1.ReportSource = cr
            'cr.DataSource = dsObj
            'DocumentViewer1.DocumentSource = cr
            'cr.CreateDocument(True)
        End If
    End Sub
    'Public Sub FillDataSet(ByRef dataSet As CertificatDS)
    '    ' Turn off constraint checking before the dataset is filled.
    '    ' This allows the adapters to fill the dataset without concern
    '    ' for dependencies between the tables.
    '    'dataSet.EnforceConstraints = False
    '    Try
    '        ' Attempt to fill the dataset MainTable
    '        'dataSet.Certificat.Clear()

    '        ' dataSet.Certificat.AddCertificatRow("20133", "BIDA", "Mohamed", "01-04-1987", "28-05-2012", "02-03-2015", "Thenia", "Boumerdes", "Chef de projet", "Monsieur")
    '    Catch ex As Exception
    '        ' Add your error handling code here.
    '        Throw ex
    '    Finally
    '        ' Turn constraint checking back on.
    '        'dataSet.EnforceConstraints = True
    '    End Try
    'End Sub
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
#End Region
    Private Sub CertificatDeTravail_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        load_Matricule_Nom()
        If matri <> "" Then
            IsConnected("SELECT Matricule,Nom,Prénom,Date_de_Naissance,Lieux_de_Naissance,Ville,Date_entrée,Date_fin_de_contrat,Fonction,Sexe FROM Employes WHERE Matricule ='" & matri & "'", False)
            If myDR.HasRows Then
                While myDR.Read
                    If IO.File.Exists(Application.StartupPath & "/Docs/CERTIFICATDETRAVAIL.rtf") Then IO.File.Copy(Application.StartupPath & "/Docs/CERTIFICATDETRAVAIL.rtf", Application.StartupPath & "/Docs/Temporaire/CERTIFICATDETRAVAIL.rtf", True)
                    RichEditControl1.LoadDocument(Application.StartupPath & "/Docs/Temporaire/CERTIFICATDETRAVAIL.rtf", DocumentFormat.Rtf)
                    If myDR("Sexe") = "Homme" Or myDR("Sexe") = "H" Then
                        RichEditControl1.Document.ReplaceAll("[Sexe]", "Monsieur", API.Native.SearchOptions.CaseSensitive)
                    ElseIf myDR("Sexe") = "Femme" Or myDR("Sexe") = "F" Then
                        RichEditControl1.Document.ReplaceAll("[Sexe]", "Madame", API.Native.SearchOptions.CaseSensitive)
                    Else
                        RichEditControl1.Document.ReplaceAll("[Sexe]", myDR("Sexe"), API.Native.SearchOptions.CaseSensitive)
                    End If
                    RichEditControl1.Document.ReplaceAll("[Nom]", myDR("Nom"), API.Native.SearchOptions.CaseSensitive)
                    RichEditControl1.Document.ReplaceAll("[Prénom]", myDR("Prénom"), API.Native.SearchOptions.CaseSensitive)
                    RichEditControl1.Document.ReplaceAll("[DN]", myDR("Date_de_Naissance"), API.Native.SearchOptions.CaseSensitive)
                    RichEditControl1.Document.ReplaceAll("[LN]", myDR("Lieux_de_Naissance"), API.Native.SearchOptions.CaseSensitive)
                    RichEditControl1.Document.ReplaceAll("[VN]", myDR("Ville"), API.Native.SearchOptions.CaseSensitive)
                    RichEditControl1.Document.ReplaceAll("[DE]", myDR("Date_entrée"), API.Native.SearchOptions.CaseSensitive)
                    If myDR("Date_fin_de_contrat") = "" Or myDR("Date_fin_de_contrat") = "00:00:00" Then
                        RichEditControl1.Document.ReplaceAll("[DS]", "A ce jour", API.Native.SearchOptions.CaseSensitive)
                    Else
                        RichEditControl1.Document.ReplaceAll("[DS]", myDR("Date_fin_de_contrat"), API.Native.SearchOptions.CaseSensitive)
                    End If
                    RichEditControl1.Document.ReplaceAll("[Fonction]", myDR("Fonction"), API.Native.SearchOptions.CaseSensitive)
                    RichEditControl1.Document.ReplaceAll("[Date]", Date.Now.ToString("dd/MM/yyyy"), API.Native.SearchOptions.None)
                    'MsgBox(myDR("Matricule"))
                    'Dim nref = 
                    'dataSet.Certificat.AddCertificatRow(myDR("Matricule"), myDR("Nom"), myDR("Prénom"), myDR("Date_de_Naissance"), myDR("Date_entrée"), IIf(IsDBNull(myDR("Date_fin_de_contrat")), "N/D", myDR("Date_fin_de_contrat")), myDR("Lieux_de_Naissance"), myDR("Ville"), myDR("Fonction"), myDR("Sexe"))
                    RichEditControl1.Document.ReplaceAll("[Ref]", nref.Text, API.Native.SearchOptions.None)
                End While
                ' dataSet.Certificat.AddCertificatRow("20133", "BIDA", "Mohamed", "01-04-1987", "28-05-2012", "02-03-2015", "Thenia", "Boumerdes", "Chef de projet", "Monsieur")
                ' RichEditControl1.Print()
                'RichEditControl1.SaveDocument()
                'Else
                '    '  MsgBox("out")
                '    dataSet.Certificat.AddCertificatRow("20133", "Non Trouvé", "Non Trouvé", "Non Trouvé", "Non Trouvé", "Non Trouvé", "Non Trouvé", "Non Trouvé", "Non Trouvé", "Non Trouvé")
            End If
        End If
    End Sub

    Private Sub ButtonX2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX2.Click
        matri = ListMatNom.Value
        'RichEditControl1.LoadDocument(Application.StartupPath & "/Docs/CERTIFICATDETRAVAIL.rtf", DocumentFormat.Rtf)
        'Dim dsObj As CertificatDS = New CertificatDS
        'FillDataSet(dsObj)
        'Dim cr As CertificatRP = New CertificatRP
        '' Set the report DataSet   
        ''cr.SetDataSource(ds)
        ''CrystalReportViewer1.ReportSource = cr
        'cr.DataSource = dsObj
        'DocumentViewer1.DocumentSource = cr
        'cr.CreateDocument(True)
        IsConnected("SELECT Matricule,Nom,Prénom,Date_de_Naissance,Lieux_de_Naissance,Ville,Date_entrée,Date_fin_de_contrat,Fonction,Sexe FROM Employes WHERE Matricule ='" & matri & "'", False)
        If myDR.HasRows Then
            While myDR.Read
                If IO.File.Exists(Application.StartupPath & "/Docs/CERTIFICATDETRAVAIL.rtf") Then IO.File.Copy(Application.StartupPath & "/Docs/CERTIFICATDETRAVAIL.rtf", Application.StartupPath & "/Docs/Temporaire/CERTIFICATDETRAVAIL.rtf", True)
                RichEditControl1.LoadDocument(Application.StartupPath & "/Docs/Temporaire/CERTIFICATDETRAVAIL.rtf", DocumentFormat.Rtf)
                If myDR("Sexe") = "Homme" Or myDR("Sexe") = "H" Then
                    RichEditControl1.Document.ReplaceAll("[Sexe]", "Monsieur", API.Native.SearchOptions.CaseSensitive)
                ElseIf myDR("Sexe") = "Femme" Or myDR("Sexe") = "F" Then
                    RichEditControl1.Document.ReplaceAll("[Sexe]", "Madame", API.Native.SearchOptions.CaseSensitive)
                Else
                    RichEditControl1.Document.ReplaceAll("[Sexe]", myDR("Sexe"), API.Native.SearchOptions.CaseSensitive)
                End If
                RichEditControl1.Document.ReplaceAll("[Nom]", myDR("Nom"), API.Native.SearchOptions.CaseSensitive)
                RichEditControl1.Document.ReplaceAll("[Prénom]", myDR("Prénom"), API.Native.SearchOptions.CaseSensitive)
                RichEditControl1.Document.ReplaceAll("[DN]", myDR("Date_de_Naissance"), API.Native.SearchOptions.CaseSensitive)
                RichEditControl1.Document.ReplaceAll("[LN]", myDR("Lieux_de_Naissance"), API.Native.SearchOptions.CaseSensitive)
                RichEditControl1.Document.ReplaceAll("[VN]", myDR("Ville"), API.Native.SearchOptions.CaseSensitive)
                RichEditControl1.Document.ReplaceAll("[DE]", myDR("Date_entrée"), API.Native.SearchOptions.CaseSensitive)
                If myDR("Date_fin_de_contrat") = "" Or myDR("Date_fin_de_contrat") = "00:00:00" Then
                    RichEditControl1.Document.ReplaceAll("[DS]", "A ce jour", API.Native.SearchOptions.CaseSensitive)
                Else
                    RichEditControl1.Document.ReplaceAll("[DS]", myDR("Date_fin_de_contrat"), API.Native.SearchOptions.CaseSensitive)
                End If
                RichEditControl1.Document.ReplaceAll("[Fonction]", myDR("Fonction"), API.Native.SearchOptions.CaseSensitive)
                RichEditControl1.Document.ReplaceAll("[Date]", Date.Now.ToString("dd/MM/yyyy"), API.Native.SearchOptions.None)
                'MsgBox(myDR("Matricule"))
                'Dim nref = 
                'dataSet.Certificat.AddCertificatRow(myDR("Matricule"), myDR("Nom"), myDR("Prénom"), myDR("Date_de_Naissance"), myDR("Date_entrée"), IIf(IsDBNull(myDR("Date_fin_de_contrat")), "N/D", myDR("Date_fin_de_contrat")), myDR("Lieux_de_Naissance"), myDR("Ville"), myDR("Fonction"), myDR("Sexe"))
                RichEditControl1.Document.ReplaceAll("[Ref]", nref.Text, API.Native.SearchOptions.None)
            End While
            ' dataSet.Certificat.AddCertificatRow("20133", "BIDA", "Mohamed", "01-04-1987", "28-05-2012", "02-03-2015", "Thenia", "Boumerdes", "Chef de projet", "Monsieur")
            ' RichEditControl1.Print()
            'RichEditControl1.SaveDocument()
            'Else
            '    '  MsgBox("out")
            '    dataSet.Certificat.AddCertificatRow("20133", "Non Trouvé", "Non Trouvé", "Non Trouvé", "Non Trouvé", "Non Trouvé", "Non Trouvé", "Non Trouvé", "Non Trouvé", "Non Trouvé")
        End If
    End Sub
    Private Sub ButtonX4_Click(sender As System.Object, e As System.EventArgs) Handles ButtonX4.Click
        RichEditControl1.Print()
    End Sub

    Private Sub ListMatNom_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ListMatNom.SelectedIndexChanged
        If ListMatNom.Value = Nothing Then
            MessageBox.Show("Vous devez sélectionner un employe avant de cliquer ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ButtonX2.Enabled = False
        Else
            ButtonX2.Enabled = True
        End If
    End Sub
End Class