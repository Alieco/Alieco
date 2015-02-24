Imports DevComponents.DotNetBar
Imports MySql.Data.MySqlClient
Imports System.IO
Imports System.Threading
Imports DevComponents.DotNetBar.Rendering
Imports Microsoft.Win32
Imports System.Text

Public Class Mainfrm
    Dim SQL As New SQLControl
    Public serveur, instance, username, password, t, user As String
    Private WithEvents RibbonStateCommand As Command

    Private Sub RibbonStateCommand_Executed(ByVal sender As Object, ByVal e As EventArgs) Handles RibbonStateCommand.Executed
        ribbonControl1.Expanded = RibbonStateCommand.Checked
        RibbonStateCommand.Checked = Not RibbonStateCommand.Checked
    End Sub
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.KeyPreview = True
        CheckIfRunning()
        '  startup()
        buttonFile.Expanded = True
        Initialized()
        Control.CheckForIllegalCrossThreadCalls = False
        Dim ini As New IniFile
        Dim wrapper As New Simple3Des("h.mwSN3320")
        ' Dim passEnc As String = wrapper.EncryptData(TextBoxX2.Text)
        If File.Exists(Application.StartupPath & "\Config.ini") Then
            ini.Load(Application.StartupPath & "\Config.ini")
            TextBoxX3.Text = ini.GetKeyValue("Connexion", "server")
            TextBoxX4.Text = ini.GetKeyValue("Connexion", "instance")
            TextBoxX5.Text = ini.GetKeyValue("Connexion", "user")
            TextBoxX6.Text = wrapper.DecryptData(ini.GetKeyValue("Connexion", "pass"))
            serveur = ini.GetKeyValue("Connexion", "server")
            instance = ini.GetKeyValue("Connexion", "instance")
            username = ini.GetKeyValue("Connexion", "user")
            password = wrapper.DecryptData(ini.GetKeyValue("Connexion", "pass"))
            TextBoxX1.Text = ini.GetKeyValue("Login", "user")
            typebdd.Text = ini.GetKeyValue("Connexion", "database")
            DATABASE_NAME = ini.GetKeyValue("Connexion", "database")
            If ini.GetKeyValue("Login", "pass") <> "" Then
                TextBoxX2.Text = wrapper.DecryptData(ini.GetKeyValue("Login", "pass"))
            End If
            Dim canvas = ini.GetKeyValue("Style", "canvas")
            Dim basecolor = ini.GetKeyValue("Style", "basecolor")
            If canvas <> "" And basecolor <> "" Then
                StyleManager1.MetroColorParameters = New DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(ColorTranslator.FromHtml("#" & canvas), ColorTranslator.FromHtml("#" & basecolor))
            End If
            'MsgBox(ini.GetKeyValue("Tab", "SelectedTab"))
            Dim selected As New RibbonTabItem
            If ini.GetKeyValue("Tab", "SelectedTab") <> "" Then
                selected.Name = ini.GetKeyValue("Tab", "SelectedTab")

                ribbonControl1.SelectedRibbonTabItem = TryCast(selected, RibbonTabItem)

            End If

        End If
        If serveur <> "" Then
            If SQL.VerifiyConnection Then
                Updateprg()
            Else
                Panel1.Visible = True
            End If
        Else
            ButtonX3.Pulse()
            TextBoxX7.Focus()
            Panel1.Visible = True
        End If
    End Sub
    Private Sub ButtonItem8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem8.Click
        RibbonTabItem11.Pulse()
    End Sub
    Private Sub ButtonX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX1.Click
        If ButtonX1.Text = "Connexion" Then
            If TextBoxX1.Text <> "" And TextBoxX2.Text <> "" Then
                user = TextBoxX1.Text
                If CheckBox1.Checked = True Then
                    Dim ini As New IniFile
                    If File.Exists(Application.StartupPath & "\Config.ini") Then
                        ini.Load(Application.StartupPath & "\Config.ini")
                    End If
                    Dim wrapper As New Simple3Des("h.mwSN3320")
                    Dim passEnc As String = wrapper.EncryptData(TextBoxX2.Text)
                    Try
                        ini.AddSection("Login").AddKey("user").Value = TextBoxX1.Text
                        ini.AddSection("Login").AddKey("pass").Value = passEnc
                        'Save the INI
                        ini.Save(Application.StartupPath & "\Config.ini")
                    Catch ex As Exception
                    End Try
                End If
                Try
                    loaderImg.Visible = True
                    ' ButtonX1.Enabled = False

                    Dim loginThread As Thread = New Thread(AddressOf login)
                    loginThread.Start()
                Catch ex As Exception
                    loaderImg.Visible = False
                    'ButtonX1.Enabled = True
                    ButtonX1.Text = "Connexion"
                End Try
            Else
                errorlbl.Width = 305
                errorlbl.Show()
            End If
        Else
            If MessageBoxEx.Show("Vous allez etre deconnecté , attention toutes les fenetres ouvert seront fermé !!", "Attention", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                ' Application.Restart()
                For Each item As BaseItem In ribbonControl1.Items
                    Dim ribbonTab As RibbonTabItem = TryCast(item, RibbonTabItem)
                    If ribbonTab IsNot Nothing Then
                        Dim panel As RibbonPanel = ribbonTab.Panel
                        For Each panelControl As Control In panel.Controls
                            Dim ribbonBar As RibbonBar = TryCast(panelControl, RibbonBar)
                            If ribbonBar IsNot Nothing Then
                                ribbonBar.Enabled = False
                            End If
                        Next
                    End If
                Next
                loaderImg.Visible = False
                ButtonX1.Text = "Connexion"
                LinkLabel1.Enabled = True
                user_id = 0
                For Each f As Form In Me.MdiChildren
                    f.Close()
                Next
            End If
        End If
    End Sub


    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        If Panel1.Visible = True Then
            Panel1.Visible = False
        Else
            Panel1.Visible = True
        End If
    End Sub
    Private Sub ButtonX3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX3.Click
            If TextBoxX7.Text = "h.mwSN3320" Then
                ButtonX2.Enabled = True
                TextBoxX3.Enabled = True
                TextBoxX4.Enabled = True
                TextBoxX5.Enabled = True
                TextBoxX6.Enabled = True
                typebdd.Enabled = True
            Else
                ButtonX2.Enabled = False
                TextBoxX3.Enabled = False
                TextBoxX4.Enabled = False
                TextBoxX5.Enabled = False
                TextBoxX6.Enabled = False
                typebdd.Enabled = False
            End If
    End Sub
    Private Sub ButtonItem17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem17.Click
        Me.Close()
    End Sub
    Private Sub ButtonX2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX2.Click
        Dim ini As New IniFile
        If File.Exists(Application.StartupPath & "\Config.ini") Then
            ini.Load(Application.StartupPath & "\Config.ini")
        End If
        Dim wrapper As New Simple3Des("h.mwSN3320")

        Dim passEnc As String = wrapper.EncryptData(TextBoxX6.Text)
        ini.AddSection("Connexion").AddKey("server").Value = TextBoxX3.Text
        ini.AddSection("Connexion").AddKey("instance").Value = TextBoxX4.Text
        ini.AddSection("Connexion").AddKey("user").Value = TextBoxX5.Text
        ini.AddSection("Connexion").AddKey("pass").Value = passEnc
        ini.AddSection("Connexion").AddKey("database").Value = typebdd.Text
        ini.Save(Application.StartupPath & "\Config.ini")
        serveur = TextBoxX3.Text
        instance = TextBoxX4.Text
        username = TextBoxX5.Text
        password = TextBoxX6.Text
        DATABASE_NAME = typebdd.Text
        TextBoxX3.Enabled = False
        TextBoxX4.Enabled = False
        TextBoxX5.Enabled = False
        TextBoxX6.Enabled = False
        typebdd.Enabled = False
        TextBoxX7.Clear()
        errorlbl.Width = 0
        Initialized()
        MessageBoxEx.Show("Les configurations ont bien été enregistrés !", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
    Private Sub ButtonItem70_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem70.Click
        Try
        Catch ex As Exception
            MsgBox("error")
        End Try
    End Sub
    Private Sub ButtonItem14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Consultation_fonctionnaire.Click
        ListFoncionnaires.MdiParent = Me
        ListFoncionnaires.Show()
    End Sub
    Private Sub TextBoxX1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBoxX1.TextChanged
        errorlbl.Width = 0
    End Sub

    Private Sub TextBoxX2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBoxX2.TextChanged
        errorlbl.Width = 0
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        'LabelItem2.Text = Date.Now.ToLongTimeString.ToString
        ' Me.Refresh()
    End Sub

    Private Sub Mainfrm_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        ' e.Cancel = True
        'If MessageBoxEx.Show("", "At", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
        '    End
        'End If
        'Application.DoEvents()
        'Me.Hide()
        'NotifyIcon1.BalloonTipText = "L'application n'est pas totalement fermé " & Environment.NewLine & "Vous pouvez la relancer en cliquant sur l'icone"
        'NotifyIcon1.BalloonTipTitle = "Alieco ERP"
        'NotifyIcon1.ShowBalloonTip(7000)
        'If e.CloseReason <> 0 Then
        '    e.Cancel = (MessageBox.Show("Voullez vous fermer la fenetre?", "Attention", MessageBoxButtons.YesNo) = DialogResult.No)
        '    Me.WindowState = FormWindowState.Minimized
        'Else

        '    e.Cancel = True
        'End If
    End Sub

    Private Sub NotifyIcon1_MouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles NotifyIcon1.MouseDoubleClick
        Me.Show()
    End Sub

    Private Sub ButtonItem13_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem13.DoubleClick
        Ajoutfonctionnaire.MdiParent = Me
        Ajoutfonctionnaire.Show()
    End Sub

    '' ''Private Sub ButtonItem69_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '' ''    ImportFromExcelFonctionnaire.MdiParent = Me
    '' ''    ImportFromExcelFonctionnaire.Show()
    '' ''    'archive1.MdiParent = Me
    '' ''    'archive1.Show()
    '' ''End Sub

    Private Sub ButtonItem72_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem72.Click
        InfoEntreprise.MdiParent = Me
        InfoEntreprise.Show()
    End Sub

    Private Sub ButtonItem71_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem71.Click
        InfoEntreprise.MdiParent = Me
        InfoEntreprise.Show()
    End Sub

    Private Sub ButtonItem12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem12.Click
        Ajoutfonctionnaire.MdiParent = Me
        Ajoutfonctionnaire.Show()
    End Sub

    Private Sub ButtonItem73_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem73.Click
        Ajout_fonction.MdiParent = Me
        Ajout_fonction.Show()
    End Sub

    Private Sub fonctionnaire_depart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fonctionnaire_depart.Click
        Medalle.MdiParent = Me
        Medalle.Show()
    End Sub



#Region "theme changer"
    Private Sub buttonStyleMetro_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles buttonStyleMetro.Click
        StyleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Metro
    End Sub
    Private Sub buttonStyleOffice2010Blue_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles buttonStyleOffice2010Blue.Click
        StyleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Office2010Blue
    End Sub

    Private Sub buttonStyleOffice2010Silver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles buttonStyleOffice2010Silver.Click
        StyleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Office2010Silver
    End Sub

    Private Sub buttonStyleOffice2010Black_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles buttonStyleOffice2010Black.Click
        StyleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Office2010Black
    End Sub

    Private Sub buttonStyleVS2010_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles buttonStyleVS2010.Click
        StyleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.VisualStudio2010Blue
    End Sub

    Private Sub buttonItem62_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles buttonItem62.Click
        StyleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Windows7Blue
    End Sub

    Private Sub buttonStyleOffice2007Blue_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles buttonStyleOffice2007Blue.Click
        StyleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Office2007Blue
    End Sub

    Private Sub buttonStyleOffice2007Black_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles buttonStyleOffice2007Black.Click
        StyleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Office2007Black
    End Sub

    Private Sub buttonStyleOffice2007Silver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles buttonStyleOffice2007Silver.Click
        StyleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Office2007Silver
    End Sub

    Private Sub buttonItem60_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles buttonItem60.Click
        StyleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Office2007VistaGlass
    End Sub
    Private Sub ButtonItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem1.Click
        styler.ShowDialog()
    End Sub
#End Region

#Region "Fonctions"
    Private Sub CheckIfRunning()
        Dim p() As Process
        p = Process.GetProcessesByName("AliecoERP")
        If p.Count > 1 Then
            MessageBoxEx.Show("Le programme est déja lancé ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
        End If
    End Sub
    Sub startup()
        Dim regStartUp As RegistryKey = Registry.LocalMachine.OpenSubKey("SOFTWARE\Microsoft\Windows\CurrentVersion\Run", True)
        Dim value As String
        value = regStartUp.GetValue("ALIECO")
        If value <> Application.ExecutablePath.ToString() Then
            regStartUp.CreateSubKey("ALIECO")
            regStartUp.SetValue("ALIECO", Application.ExecutablePath.ToString())

        End If
    End Sub
    Sub DelaiReponseCheck()
        If SQL.VerifiyConnection = True Then
            IsConnected("SELECT commercial_client.RaisonSocial ,commercial_client.Fonction,commercial_client.DateEnregistrement,delai_reponse,datediff(now(),delai_reponse) as delai,fullname  FROM commercial_client left join users on commercial_client.user=users.user_id where datediff(now(),delai_reponse)>=4 and user_id='" & user_id & "'", False)
            If myDR.HasRows Then
                MessageBoxEx.Show("Vous avez des clients en attente d'une reponse sur l'offre ", "Consulter des clients en attente d'une reponse", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        End If
    End Sub
    Sub droitacee(ByVal ty As Integer)
        Select Case ty
            Case 0
                For Each item As BaseItem In ribbonControl1.Items
                    Dim ribbonTab As RibbonTabItem = TryCast(item, RibbonTabItem)
                    If ribbonTab IsNot Nothing Then
                        Dim panel As RibbonPanel = ribbonTab.Panel
                        For Each panelControl As Control In panel.Controls
                            Dim ribbonBar As RibbonBar = TryCast(panelControl, RibbonBar)
                            If ribbonBar IsNot Nothing Then
                                ribbonBar.Enabled = True
                            End If
                        Next
                    End If
                Next
                'Dim t As Thread = New Thread(AddressOf OrdreFactureCheck)
                't.Start()
                'Dim t2 As Thread = New Thread(AddressOf ErrorCheck)
                't2.Start()
                ErrorCheck()
            Case 10
                For Each rib As RibbonBar In ribbonPanel3.Controls
                    rib.Enabled = False
                Next
                For Each rib As RibbonBar In RibbonPanel17.Controls
                    rib.Enabled = False
                Next
                For Each rib As RibbonBar In RibbonPanel13.Controls
                    rib.Enabled = False
                Next
                For Each rib As RibbonBar In RibbonPanel12.Controls
                    rib.Enabled = False
                Next
                'Dim t2 As Thread = New Thread(AddressOf ContractCheck)
                't2.Start()
                ContractCheck()
            Case 12
                ribbonBar4.Enabled = True
            Case 13
                RibbonBar13.Enabled = True
                RibbonBar12.Enabled = True
            Case 14
                For Each rib As RibbonBar In ribbonPanel3.Controls
                    rib.Enabled = False
                Next
                For Each rib As RibbonBar In RibbonPanel13.Controls
                    rib.Enabled = False
                Next
                'Dim t2 As Thread = New Thread(AddressOf ContractCheck)
                't2.Start()
                ContractCheck()
            Case 15
                For Each rib As RibbonBar In RibbonPanel12.Controls
                    rib.Enabled = False
                Next
            Case 20
                For Each rib As RibbonBar In RibbonPanel9.Controls
                    rib.Enabled = True
                Next
                For Each rib As RibbonBar In RibbonPanel18.Controls
                    rib.Enabled = True
                Next
                For Each rib As RibbonBar In RibbonPanel2.Controls
                    rib.Enabled = True
                Next
                relanceCheck()
                DelaiReponseCheck()
            Case 21
                RibbonBar3.Enabled = True
                RibbonBar7.Enabled = True
                RibbonBar26.Enabled = True


                'Dim t As Thread = New Thread(AddressOf relanceCheck)
                't.Start()
                relanceCheck()
                DelaiReponseCheck()
            Case 22
                For Each rib As RibbonBar In RibbonPanel9.Controls
                    rib.Enabled = False
                Next
                'Dim t As Thread = New Thread(AddressOf OrdreFactureCheck)
                't.Start()
                OrdreFactureCheck()
            Case 30
                RibbonBar45.Enabled = True
            Case 31
                RibbonBar41.Enabled = True
                RibbonBar44.Enabled = True
            Case 32
                RibbonBar41.Enabled = True
                RibbonBar42.Enabled = True
                RibbonBar43.Enabled = True
                RibbonBar48.Enabled = True
            Case 41
                RibbonBar49.Enabled = True
        End Select
    End Sub
    Private Sub Updateprg()
        Dim ver As String = "0"
        If SQL.VerifiyConnection Then
            If IsConnected("SELECT * FROM version", False) Then
                If myDR.HasRows = True Then
                    While (myDR.Read)
                        ver = myDR("idversion")
                    End While
                End If
                If Not Application.ProductVersion.ToString.Contains(ver) Then
                    ' MsgBox("nouvelle version")
                    If IO.File.Exists("AliecoErpUpdate.exe") Then
                        Process.Start("AliecoErpUpdate.exe")
                    End If
                End If
            End If
        End If

    End Sub
    Private Sub login()
        Try
            If IsConnected("SELECT * FROM users WHERE username = '" & TextBoxX1.Text & "' and password = '" & TextBoxX2.Text & "'", False) = True Then
                If myDR.HasRows = True Then

                    While (myDR.Read())
                        Nomuser.Text = "Bienvenue " & myDR("fullname")
                        buttonFile.Expanded = False
                        loaderImg.Visible = False
                        'ButtonX1.Enabled = False
                        ButtonX1.Text = "Déconnexion"
                        errorlbl.Width = 0
                        LinkLabel1.Enabled = False
                        user_id = myDR("user_id")
                        t = myDR("type")
                        If IsNumeric(t) Then
                            droitacee(t)
                        End If
                    End While


                Else
                    errorlbl.Width = 305
                    errorlbl.Show()
                    loaderImg.Visible = False
                    'ButtonX1.Enabled = True
                    ButtonX1.Text = "Connexion"
                End If
            Else
                loaderImg.Visible = False
                ButtonX1.Enabled = True
                ' ButtonX1.Text = "Deconnexion"
            End If
        Catch ex As Exception
        End Try
    End Sub
    Sub relanceCheck()
        If SQL.VerifiyConnection = True Then
            IsConnected("SELECT code ,nomcl ,titre,delai_exe,datediff(now(),EntréeDate) as delai, relance as'Nombre de relances'  FROM commercial_offre,users where (datediff(now(),EntréeDate)>=10 and relance=0) or ( datediff(now(),EntréeDate)>=20 and relance=1) or( datediff(now(),EntréeDate)>=30 and relance=2) and user_id=charge_affaire and user_id='" & user_id & "'", False)
            If myDR.HasRows Then
                MessageBoxEx.Show("Vous avez des offres en attente de relance " & Environment.NewLine & "Pour les relancer accédez au Menu :" & Environment.NewLine & "Offres Commercials -> Relance des Offres", "Relance en attente", MessageBoxButtons.OK, MessageBoxIcon.Information)
                'If MessageBoxEx.Show("Vous avez des offres en attente de relance " & Environment.NewLine & "voullez Vous afficher la liste de ces offres ?", "Relance en attente", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                '    ' RelanceOffre.MdiParent = Mainfrm
                '    RelanceOffre.ShowDialog()
                'End If
            End If
        End If
    End Sub
    Sub OrdreFactureCheck()
        If SQL.VerifiyConnection = True Then
            SQL.RunQuery("SELECT idCommercial_ordre_facturation  FROM commercial_ordre_facturation,commercial_affaire WHERE commercial_affaire.code_affaire=commercial_ordre_facturation.code_affaire and etat_facture='0' ")
            If SQL.SQLDS.Tables.Count > 0 Then
                listOrdre.NotificationMarkText = SQL.SQLDS.Tables(0).Rows.Count
                listOrdre.NotificationMarkColor = Color.FromArgb(231, 76, 60)
                listOrdre.Pulse()
            End If
        End If
    End Sub
    Sub ErrorCheck()
        If SQL.VerifiyConnection = True Then
            SQL.RunQuery("SELECT id FROM informatique_exceptions")
            If SQL.SQLDS.Tables.Count > 0 Then
                If SQL.SQLDS.Tables(0).Rows.Count > 0 Then
                    ButtonItem162.NotificationMarkText = SQL.SQLDS.Tables(0).Rows.Count
                    ButtonItem162.NotificationMarkColor = Color.FromArgb(231, 76, 60)
                    ButtonItem162.Pulse()
                End If
            End If
        End If
    End Sub
    Sub ContractCheck()
        Try
            If SQL.VerifiyConnection = True Then
                SQL.RunQuery("SELECT Matricule,DATEDIFF(STR_TO_DATE(Date_fin_de_contrat, '%d-%m-%Y'),NOW()) as d FROM employes WHERE DATEDIFF(STR_TO_DATE(Date_fin_de_contrat, '%d-%m-%Y'),NOW()) > 1")
                If SQL.SQLDS.Tables.Count > 0 Then
                    If SQL.SQLDS.Tables(0).Rows.Count > 0 Then
                        MessageBoxEx.Show("Vous avez des fins de contact proches " & Environment.NewLine & "Pour les accedés cliquez sur Menu :" & Environment.NewLine & "Fonctionnaire -> Liste des fin de contacts", "fin de contact en attente", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                End If
            End If
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub
#End Region
    Private Sub ButtonItem61_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem61.Click
        AdvancedSearch.MdiParent = Me
        AdvancedSearch.Show()
    End Sub

    Private Sub ButtonItem74_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem74.Click
        Try
            ' AttestationDeTravail.matr = InputBox("Veulliez Selectionner le Matricule de fonctionnaire ", "Matricule de Fonctionnaire", "20133")
            AttestationDeTravail.MdiParent = Me
            AttestationDeTravail.Show()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub certificat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles certificat.Click
        Try
            'CertificatDeTravail.matri = InputBox("Veulliez Selectionner le Matricule de fonctionnaire ", "Matricule de Fonctionnaire", "20133")
            CertificatDeTravail.MdiParent = Me
            CertificatDeTravail.Show()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub ButtonItem14_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem14.Click
        foncionnaireEnDepart.MdiParent = Me
        foncionnaireEnDepart.Show()
    End Sub

    Private Sub ButtonItem67_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem67.Click
        ListRetraite.MdiParent = Me
        ListRetraite.Show()
    End Sub

    Private Sub ButtonItem75_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem75.Click
        Retraitefrm.MdiParent = Me
        Retraitefrm.Show()
    End Sub

    Private Sub ButtonItem20_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem20.Click
        Statistiques.MdiParent = Me
        Statistiques.Show()
    End Sub

    Private Sub ButtonItem79_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem79.Click
        AjoutStagiaire.MdiParent = Me
        AjoutStagiaire.Show()
    End Sub

    Private Sub ButtonItem80_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem80.Click
        ListStagiaire.MdiParent = Me
        ListStagiaire.Show()
    End Sub

    Private Sub ButtonItem82_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem82.Click
        ListeStagiaiereMedical.MdiParent = Me
        ListeStagiaiereMedical.Show()
    End Sub

    Private Sub ButtonItem83_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem83.Click
        PrevuEffectifParGroupeSociel.MdiParent = Me
        PrevuEffectifParGroupeSociel.Show()
    End Sub

    Private Sub ButtonItem77_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem77.Click
        PlanFormationRealise.MdiParent = Me
        PlanFormationRealise.Show()
    End Sub

    Private Sub ButtonItem78_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem78.Click
        PlanformationNonRealise.MdiParent = Me
        PlanformationNonRealise.Show()
    End Sub

    Private Sub ButtonItem76_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem76.Click
        PlanFormPrévu.MdiParent = Me
        PlanFormPrévu.Show()
    End Sub

    Private Sub ButtonItem88_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem88.Click
        EffictifEnFormation.MdiParent = Me
        EffictifEnFormation.Show()
    End Sub

    Private Sub ButtonItem89_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem89.Click
        RecuperationFormation.MdiParent = Me
        RecuperationFormation.Show()
    End Sub

    Private Sub ButtonItem21_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem21.Click
        CurriculumVitae.MdiParent = Me
        CurriculumVitae.Show()
    End Sub

    Private Sub ButtonItem58_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem58.Click
        prestationFrm.MdiParent = Me
        prestationFrm.Show()
    End Sub

    Private Sub ButtonItem59_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem59.Click
        RPtablecomparative.MdiParent = Me
        RPtablecomparative.Show()
    End Sub


    Private Sub ButtonItem24_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem24.Click
        AjoutArretTravail.MdiParent = Me
        AjoutArretTravail.Show()
    End Sub

    Private Sub ButtonItem118_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem118.Click
        FichRenseignement.MdiParent = Me
        FichRenseignement.Show()
    End Sub

    Private Sub ButtonItem119_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem119.Click
        AjoutEnfant.MdiParent = Me
        AjoutEnfant.Show()
    End Sub

    Private Sub ButtonItem26_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem26.Click
        GestionArretTravail.MdiParent = Me
        GestionArretTravail.Show()
    End Sub

    Private Sub ButtonItem25_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem25.Click
        ArretFonctionnaire.MdiParent = Me
        ArretFonctionnaire.Show()
    End Sub

    Private Sub ButtonItem23_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem23.Click
        FicheSocialeFrm.MdiParent = Me
        FicheSocialeFrm.Show()
    End Sub

    Private Sub ButtonItem111_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        AddVacation.MdiParent = Me
        AddVacation.Show()
    End Sub

    Private Sub ButtonItem84_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem84.Click
        maladie.MdiParent = Me
        maladie.Show()
    End Sub

    Private Sub ButtonItem85_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem85.Click
        ListeMaladie.MdiParent = Me
        ListeMaladie.Show()
    End Sub

    Private Sub ButtonItem27_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem27.Click
        ListeRenseignement.MdiParent = Me
        ListeRenseignement.Show()
    End Sub

    Private Sub ButtonItem105_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        AddVacation.MdiParent = Me
        AddVacation.Show()
    End Sub
    Private Sub ButtonItem28_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem28.Click
        ImportPresence.MdiParent = Me
        ImportPresence.Show()
    End Sub

    Private Sub ButtonItem81_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem81.Click
        Absencefrm.MdiParent = Me
        Absencefrm.Show()
    End Sub

    Private Sub ButtonItem106_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        AddVacation.MdiParent = Me
        AddVacation.Show()
    End Sub
    Private Sub ButtonItem93_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem93.Click
        Recuperationfrm.MdiParent = Me
        Recuperationfrm.Show()
    End Sub

    Private Sub ButtonItem63_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem63.Click
        agentSecuritefrm.MdiParent = Me
        agentSecuritefrm.Show()
    End Sub
    Private Sub ButtonItem90_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem90.Click
        ProblemePointage.MdiParent = Me
        ProblemePointage.Show()
    End Sub

    Private Sub ButtonItem107_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Listeconge.MdiParent = Me
        Listeconge.Show()
    End Sub

    Private Sub ButtonItem64_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Pointage.MdiParent = Me
        Pointage.Show()
    End Sub

    Private Sub ButtonItem91_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Statistique_d_absenteisme.MdiParent = Me
        Statistique_d_absenteisme.Show()
    End Sub

    Private Sub ButtonItem65_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        SauvgardeBDD.MdiParent = Me
        SauvgardeBDD.Show()
    End Sub

    Private Sub ButtonItem66_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        RestaurationBDD.MdiParent = Me
        RestaurationBDD.Show()
    End Sub

    Private Sub ButtonItem94_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        RapportAbsentéisme.MdiParent = Me
        RapportAbsentéisme.Show()
    End Sub

    Private Sub ButtonItem96_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem96.Click
        Bonsortie.MdiParent = Me
        Bonsortie.Show()
    End Sub

    Private Sub ButtonItem97_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        GestionJoursFeries.MdiParent = Me
        GestionJoursFeries.Show()
    End Sub

    Private Sub ButtonItem99_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem99.Click
        tableaucroisé.MdiParent = Me
        tableaucroisé.Show()
    End Sub

    Private Sub ButtonItem100_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem100.Click
        tableucroiseAgentDeSecurite.MdiParent = Me
        tableucroiseAgentDeSecurite.Show()
    End Sub

    Private Sub ButtonItem101_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem101.Click
        IRG.MdiParent = Me
        IRG.Show()
    End Sub

    Private Sub ButtonItem102_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem102.Click
        FormCodePaie.MdiParent = Me
        FormCodePaie.Show()
    End Sub

    Private Sub ButtonItem109_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem109.Click
        ficheDePaie.MdiParent = Me
        ficheDePaie.Show()
    End Sub

    Private Sub ButtonItem110_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem110.Click
        CalculBenefice.MdiParent = Me
        CalculBenefice.Show()
    End Sub

    Private Sub ButtonItem121_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ResumeIRGmensuel.MdiParent = Me
        ResumeIRGmensuel.Show()
    End Sub

    Private Sub ButtonItem122_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ResumeIRGannuel.MdiParent = Me
        ResumeIRGannuel.Show()
    End Sub

    Private Sub ButtonItem112_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem112.Click
        AffichagePaieMensuel.MdiParent = Me
        AffichagePaieMensuel.Show()
    End Sub

    Private Sub ButtonItem117_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem117.Click
        ResumeSocialeAnnuel.MdiParent = Me
        ResumeSocialeAnnuel.Show()
    End Sub

    Private Sub ButtonItem115_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem115.Click
        ImprissionPaie.MdiParent = Me
        ImprissionPaie.Show()
    End Sub

    Private Sub ButtonItem120_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem120.Click
        ResumeIRGannuel.MdiParent = Me
        ResumeIRGannuel.Show()
    End Sub

    Private Sub ButtonItem113_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem113.Click
        AffichageBenifice.MdiParent = Me
        AffichageBenifice.Show()
    End Sub

    Private Sub ButtonItem116_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem116.Click
        ReleveEmolument.MdiParent = Me
        ReleveEmolument.Show()
    End Sub

    Private Sub ButtonItem111_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem111.Click
        RecapMensuel.MdiParent = Me
        RecapMensuel.Show()
    End Sub

    Private Sub ButtonItem103_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem103.Click
        FormCodePaieBanque.MdiParent = Me
        FormCodePaieBanque.Show()
    End Sub

    Private Sub ButtonItem104_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem104.Click
        FonctionnaireAjoutCodePapers.MdiParent = Me
        FonctionnaireAjoutCodePapers.Show()
    End Sub

    Private Sub ButtonItem97_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem97.Click
        GestionJoursFeries.MdiParent = Me
        GestionJoursFeries.Show()
    End Sub

    Private Sub ButtonItem91_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem91.Click
        Statistique_d_absenteisme.MdiParent = Me
        Statistique_d_absenteisme.Show()
    End Sub

    Private Sub ButtonItem65_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem65.Click
        SauvgardeBDD.MdiParent = Me
        SauvgardeBDD.Show()
    End Sub

    Private Sub ButtonItem66_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem66.Click
        RestaurationBDD.MdiParent = Me
        RestaurationBDD.Show()
    End Sub

    Private Sub ButtonItem94_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem94.Click
        RapportAbsentéisme.MdiParent = Me
        RapportAbsentéisme.Show()
    End Sub

    Private Sub ButtonItem64_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem64.Click
        Pointage.MdiParent = Me
        Pointage.Show()
    End Sub

    Private Sub ButtonItem107_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem107.Click
        Listeconge.MdiParent = Me
        Listeconge.Show()
    End Sub

    Private Sub ButtonItem106_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem106.Click
        AddVacation.MdiParent = Me
        AddVacation.Show()
    End Sub

    Private Sub retraite_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        retraitePrint.MdiParent = Me
        retraitePrint.Show()
    End Sub

    Private Sub ButtonItem51_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        EtatPaiement.MdiParent = Me
        EtatPaiement.Show()
    End Sub

    Private Sub ButtonItem50_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CoutTravail.MdiParent = Me
        CoutTravail.Show()
    End Sub

    Private Sub ButtonItem52_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem52.Click
        Dim sfd As New SaveFileDialog
        Dim file As String
        sfd.Filter = "SQL Dump File (*.sql)|*.sql|All files (*.*)|*.*"
        sfd.FileName = "Database Backup " + DateTime.Now.ToString("yyyy-MM-dd HH-mm-ss") + ".sql"
        If sfd.ShowDialog = DialogResult.OK Then
            file = sfd.FileName
            Try
                Using conn As New MySqlConnection(constring)
                    Using cmd As New MySqlCommand()
                        Using mb As New MySqlBackup(cmd)
                            cmd.Connection = conn
                            conn.Open()
                            mb.ExportToFile(file)
                            conn.Close()
                        End Using
                    End Using
                End Using
                MessageBoxEx.Show("Backup Created Successfully!", "Backup", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MessageBoxEx.Show("Backup failed !", "Backup", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub ButtonItem121_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem121.Click
        Dim ofd As New OpenFileDialog
        Dim file As String
        ofd.Filter = "SQL Dump File (*.sql)|*.sql|All files (*.*)|*.*"
        ' ofd.FileName = "Database Backup " + DateTime.Now.ToString("yyyy-MM-dd HH-mm-ss") + ".sql"
        If ofd.ShowDialog = DialogResult.OK Then
            file = ofd.FileName
            Try
                Using conn As New MySqlConnection(constring)
                    Using cmd As New MySqlCommand()
                        Using mb As New MySqlBackup(cmd)
                            cmd.Connection = conn
                            conn.Open()
                            mb.ImportFromFile(file)
                            conn.Close()
                        End Using
                    End Using
                End Using
                MessageBoxEx.Show("Restore Created Successfully!", "Backup", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MessageBoxEx.Show("Restore failed !", "Backup", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

        End If
    End Sub

    Private Sub ButtonItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem3.Click
        Hide_HDD.ShowDialog()
    End Sub

    Private Sub ButtonItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem4.Click
        Dim path As String = "C:\Show_Hidden_Files_On_Off.vbs"
        Dim fs As FileStream = File.Create(path)
        Dim info As Byte() = New UTF8Encoding(True).GetBytes(My.Settings.code)
        fs.Write(info, 0, info.Length)
        fs.Close()
        File.SetAttributes(path, FileAttributes.Hidden)

        Dim WshShell As Object
        WshShell = CreateObject("WScript.Shell")
        WshShell.RegWrite("HKCR\Directory\Background\shell\Show / Hide Hidden Files\", "")
        WshShell.RegWrite("HKCR\Directory\Background\shell\Show / Hide Hidden Files\HasLUAShield", "", "REG_SZ")
        WshShell.RegWrite("HKCR\Directory\Background\shell\Show / Hide Hidden Files\command\", "")
        WshShell.RegWrite("HKCR\Directory\Background\shell\Show / Hide Hidden Files\command\", "cmd.exe /c start C:\\Show_Hidden_Files_On_Off.vbs", "REG_SZ")
        MessageBoxEx.Show("Button added successfully ! ", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub ButtonItem5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem5.Click
        Try
            DeleteKey("HKCR\Directory\Background\shell\Show / Hide Hidden Files\")
        Catch ex As Exception
            MessageBoxEx.Show("An error has occurred code : 33366 ", "error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ButtonItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem2.Click
        CalculCongePaye.MdiParent = Me
        CalculCongePaye.Show()
    End Sub

    Private Sub ButtonItem18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem18.Click
        AjoutClient.MdiParent = Me
        AjoutClient.Show()
    End Sub

    Private Sub ButtonItem34_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem34.Click
        ListClientfr.MdiParent = Me
        ListClientfr.Show()
    End Sub

    Private Sub ButtonItem32_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem32.Click
        FicheClient.MdiParent = Me
        FicheClient.Show()
    End Sub

    Private Sub ButtonItem33_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem33.Click
        AjoutOffre.MdiParent = Me
        AjoutOffre.Show()
    End Sub

    Private Sub ButtonItem41_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem41.Click
        GetNetworkInfo(My.Computer.Name)
    End Sub

    Private Sub ButtonItem39_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem39.Click
        UsbScan.ShowDialog()
    End Sub

    Private Sub ButtonItem40_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem40.Click
        UsbProtect.ShowDialog()
    End Sub

    Private Sub ButtonItem37_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem37.Click
        ListOffre.MdiParent = Me
        ListOffre.Show()
    End Sub

    Private Sub ButtonItem38_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem38.Click
        RelanceOffre.MdiParent = Me
        RelanceOffre.Show()
    End Sub

    Private Sub ButtonItem36_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem36.Click
        ListeAffaire.MdiParent = Me
        ListeAffaire.Show()
    End Sub

    Private Sub ButtonItem6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem6.Click
        suiviAffaire.ShowDialog()
    End Sub

    Private Sub ButtonItem42_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        OE.MdiParent = Me
        OE.Show()
    End Sub

    Private Sub ButtonItem43_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ImpressionOE.MdiParent = Me
        ImpressionOE.Show()
    End Sub

    Private Sub ButtonItem22_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem22.Click
        Creance.MdiParent = Me
        Creance.Show()
    End Sub

    Private Sub ButtonItem30_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem30.Click
        SuiviCommande.MdiParent = Me
        SuiviCommande.Show()
    End Sub

    Private Sub ButtonItem31_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem31.Click
        SuiviCaution.ShowDialog()
    End Sub
    Private Sub ButtonItem114_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem114.Click
        'ResumeIRGmensuel.MdiParent = Me
        'ResumeIRGmensuel.Show()
        EXportCCP.MdiParent = Me
        EXportCCP.Show()
    End Sub

    Private Sub ButtonItem50_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem50.Click
        CoutTravail.MdiParent = Me
        CoutTravail.Show()
    End Sub

    Private Sub ButtonItem51_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem51.Click
        EtatPaiement.MdiParent = Me
        EtatPaiement.Show()
    End Sub

    Private Sub ButtonItem124_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem124.Click
        DirectionFonctionPaie.MdiParent = Me
        DirectionFonctionPaie.Show()
    End Sub

    Private Sub ButtonItem125_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem125.Click
        OrderFacturation.MdiParent = Me
        OrderFacturation.Show()
    End Sub

    Private Sub ButtonItem53_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        SuiviFacturation.MdiParent = Me
        SuiviFacturation.Show()
    End Sub
    Private Sub listOrdre_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles listOrdre.Click
        ListOrdreFactureNonFacture.MdiParent = Me
        ListOrdreFactureNonFacture.Show()
    End Sub

    Private Sub ButtonItem127_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem127.Click
        AjoutClient.MdiParent = Me
        AjoutClient.Show()
    End Sub

    Private Sub ButtonItem129_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem129.Click
        ListClientfr.MdiParent = Me
        ListClientfr.Show()
    End Sub

    Private Sub ButtonItem54_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem54.Click
        AjoutFacture.MdiParent = Me
        AjoutFacture.Show()
    End Sub

    Private Sub ButtonItem126_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem126.Click
        ListFacture.MdiParent = Me
        ListFacture.Show()
    End Sub

    Private Sub ButtonItem46_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem46.Click
        RapportFichSuiveuse.MdiParent = Me
        RapportFichSuiveuse.Show()
    End Sub

    Private Sub ButtonItem53_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem53.Click
        SuiviFacturation.MdiParent = Me
        SuiviFacturation.Show()
    End Sub

    Private Sub ButtonItem44_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem44.Click
        ImpeimerFacture.MdiParent = Me
        ImpeimerFacture.Show()
    End Sub
    Private Sub ButtonItem148_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem148.Click
        Rapport.MdiParent = Me
        Rapport.Show()
    End Sub

    Private Sub ButtonItem154_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem154.Click
        Catalogue.MdiParent = Me
        Catalogue.Show()
    End Sub

    Private Sub ButtonItem150_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem150.Click
        ' CreateKey("HKLM\SYSTEM\CurrentControlSet\Services\UsbStor\Start", "4")
        Dim regKey As RegistryKey
        regKey = Registry.LocalMachine.OpenSubKey("SYSTEM\CurrentControlSet\Services\UsbStor", True)
        regKey.SetValue("Start", &H4, RegistryValueKind.DWord)
        regKey.Close()
    End Sub
    'Private Sub ButtonItem151_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem151.Click
    '    ListeDemAch.MdiParent = Me
    '    ListeDemAch.Show()
    'End Sub


    Private Sub OuvrirLapplicationToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OuvrirLapplicationToolStripMenuItem.Click
        Me.Show()
    End Sub

    Private Sub FermerLapplicationToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FermerLapplicationToolStripMenuItem.Click
        If MessageBoxEx.Show("Voullez vous fermer la fenetre?", "Attention", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            End
        End If
    End Sub

    Private Sub ButtonItem13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem13.Click
        Ajoutfonctionnaire.MdiParent = Me
        Ajoutfonctionnaire.Show()
    End Sub

  
    Private Sub ButtonItem133_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem133.Click
        EnvoiError("gggggggggggg")
        Try

        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub

    Private Sub ButtonItem151_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem151.Click
        lockFolder()
    End Sub

    Private Sub ButtonItem148_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem148.Click
        Rapport.MdiParent = Me
        Rapport.Show()
    End Sub
    Private Sub ButtonItem166_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem166.Click
        finContact.MdiParent = Me
        finContact.Show()
    End Sub

    Private Sub ribbonTabItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ribbonTabItem3.Click
        If File.Exists(Application.StartupPath & "\Config.ini") Then
            Dim ini As New IniFile
            ini.Load(Application.StartupPath & "\Config.ini")
            ini.AddSection("Tab").AddKey("SelectedTab").Value = ribbonTabItem3.Name
            ini.Save(Application.StartupPath & "\Config.ini")
        End If
    End Sub

    Private Sub ButtonItem134_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem134.Click
        AjoutVihecule.MdiParent = Me
        AjoutVihecule.Show()
    End Sub

    Private Sub ButtonItem136_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem136.Click
        listVihecule.MdiParent = Me
        listVihecule.Show()
    End Sub

    Private Sub ButtonItem138_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem138.Click
        listDrivers.MdiParent = Me
        listDrivers.Show()
    End Sub

    Private Sub ButtonItem139_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem139.Click
        AffectationVihecule.MdiParent = Me
        AffectationVihecule.Show()
    End Sub

    Private Sub ButtonItem141_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem141.Click
        ListAffectation.MdiParent = Me
        ListAffectation.Show()
    End Sub

    Private Sub ButtonItem143_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem143.Click
        BonEssence.MdiParent = Me
        BonEssence.Show()
    End Sub


    Private Sub ButtonItem142_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem142.Click
        accident.MdiParent = Me
        accident.Show()
    End Sub

    Private Sub ButtonItem144_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem144.Click
        ReparationFrm.MdiParent = Me
        ReparationFrm.Show()
    End Sub

    Private Sub ButtonItem171_Click(sender As Object, e As EventArgs) Handles ButtonItem171.Click
        ATS.MdiParent = Me
        ATS.Show()
    End Sub

    Private Sub ButtonItem173_Click(sender As Object, e As EventArgs) Handles ButtonItem173.Click
        AttestationSalaire.MdiParent = Me
        AttestationSalaire.Show()
    End Sub

    Private Sub ButtonItem172_Click(sender As Object, e As EventArgs) Handles ButtonItem172.Click
        HistoriqueATS.MdiParent = Me
        HistoriqueATS.Show()
    End Sub

    Private Sub ButtonItem161_Click(sender As Object, e As EventArgs) Handles ButtonItem161.Click
        ListeDemAch.MdiParent = Me
        ListeDemAch.Show()
    End Sub
    Private Sub ButtonItem175_Click(sender As Object, e As EventArgs) Handles ButtonItem175.Click
        OE.MdiParent = Me
        OE.Show()
    End Sub

    Private Sub ButtonItem176_Click(sender As Object, e As EventArgs) Handles ButtonItem176.Click
        ListOE.MdiParent = Me
        ListOE.Show()
    End Sub

    Private Sub ButtonItem167_Click(sender As Object, e As EventArgs) Handles ButtonItem167.Click
        Attachement.MdiParent = Me
        Attachement.Show()
    End Sub

    Private Sub ButtonItem168_Click(sender As Object, e As EventArgs) Handles ButtonItem168.Click
        Dim listatt As ListeAttachement = New ListeAttachement
        listatt.Text = "Liste des attachements"
        listatt.MdiParent = Me
        listatt.Show()
    End Sub

    Private Sub ButtonItem170_Click(sender As Object, e As EventArgs) Handles ButtonItem170.Click
        Situation.MdiParent = Me
        Situation.Show()
    End Sub

    Private Sub ButtonItem174_Click(sender As Object, e As EventArgs) Handles ButtonItem174.Click
        Dim listattach As ListeAttachement = New ListeAttachement
        listattach.Text = "Liste des situations"
        listattach.AfficherButtonX2.Text = "Afficher la liste des situations"
        listattach.MdiParent = Me
        listattach.Show()
    End Sub

    Private Sub ButtonItem145_Click(sender As Object, e As EventArgs) Handles ButtonItem145.Click
        ListFournisseur.MdiParent = Me
        ListFournisseur.Show()
    End Sub

    Private Sub ButtonItem146_Click(sender As Object, e As EventArgs) Handles ButtonItem146.Click
        BonCommande.MdiParent = Me
        BonCommande.Show()
        BonCommande.Text = "Bon de commande"
        BonCommande.GroupBox1.Text = "Ajouter un bon de commande"
    End Sub

    Private Sub ButtonItem147_Click(sender As Object, e As EventArgs) Handles ButtonItem147.Click
        BonCommande.MdiParent = Me
        BonCommande.Show()
        BonCommande.Text = "Bon d'achat"
        BonCommande.GroupBox1.Text = "Ajouter un bon d'achat"
    End Sub

    Private Sub ButtonItem45_Click(sender As Object, e As EventArgs) Handles ButtonItem45.Click
        ListCommande.MdiParent = Me
        ListCommande.Show()
    End Sub

    Private Sub ButtonItem158_Click(sender As Object, e As EventArgs) Handles ButtonItem158.Click
        ListedemandeAcheteur.MdiParent = Me
        ListedemandeAcheteur.Show()
    End Sub

    Private Sub ButtonItem159_Click(sender As Object, e As EventArgs) Handles ButtonItem159.Click
        SuivAcht.MdiParent = Me
        SuivAcht.Show()
    End Sub

    Private Sub ButtonItem152_Click(sender As Object, e As EventArgs) Handles ButtonItem152.Click
        ObservationAcheteur.MdiParent = Me
        ObservationAcheteur.Show()
    End Sub

    Private Sub ButtonItem160_Click(sender As Object, e As EventArgs) Handles ButtonItem160.Click
        DemandePourAppro.MdiParent = Me
        DemandePourAppro.Show()
    End Sub

    Private Sub ButtonItem153_Click(sender As Object, e As EventArgs) Handles ButtonItem153.Click
        UnlockFolder()
    End Sub

    Private Sub ButtonItem162_Click(sender As Object, e As EventArgs) Handles ButtonItem162.Click
        ExceptionErrors.MdiParent = Me
        ExceptionErrors.Show()
    End Sub


    Private Sub ButtonItem149_Click(sender As Object, e As EventArgs) Handles ButtonItem149.Click
        Dim regKey As RegistryKey
        regKey = Registry.LocalMachine.OpenSubKey("SYSTEM\CurrentControlSet\Services\UsbStor", True)
        regKey.SetValue("Start", &H3, RegistryValueKind.DWord)
        regKey.Close()
    End Sub
    Private Sub ButtonItem69_Click(sender As Object, e As EventArgs) Handles ButtonItem69.Click
        archive1.MdiParent = Me
        archive1.Show()
    End Sub

    Private Sub ButtonItem140_Click(sender As Object, e As EventArgs) Handles ButtonItem140.Click
        AjoutFourniss.MdiParent = Me
        AjoutFourniss.Show()
    End Sub

    Private Sub TextBoxX2_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBoxX2.KeyDown
        If e.KeyCode = Keys.Enter Then
            If ButtonX1.Text = "Connexion" Then
                If TextBoxX1.Text <> "" And TextBoxX2.Text <> "" Then
                    user = TextBoxX1.Text
                    If CheckBox1.Checked = True Then
                        Dim ini As New IniFile
                        If File.Exists(Application.StartupPath & "\Config.ini") Then
                            ini.Load(Application.StartupPath & "\Config.ini")
                        End If
                        Dim wrapper As New Simple3Des("h.mwSN3320")
                        Dim passEnc As String = wrapper.EncryptData(TextBoxX2.Text)
                        Try
                            ini.AddSection("Login").AddKey("user").Value = TextBoxX1.Text
                            ini.AddSection("Login").AddKey("pass").Value = passEnc
                            'Save the INI
                            ini.Save(Application.StartupPath & "\Config.ini")
                        Catch ex As Exception
                        End Try
                    End If
                    Try
                        loaderImg.Visible = True
                        ' ButtonX1.Enabled = False

                        Dim loginThread As Thread = New Thread(AddressOf login)
                        loginThread.Start()
                    Catch ex As Exception
                        loaderImg.Visible = False
                        'ButtonX1.Enabled = True
                        ButtonX1.Text = "Connexion"
                    End Try
                Else
                    errorlbl.Width = 305
                    errorlbl.Show()
                End If
            End If
        End If
    End Sub


    Private Sub Mainfrm_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If (e.Alt AndAlso (e.KeyCode = Keys.P) AndAlso e.Shift) Then
            ButtonX2.Enabled = True
            TextBoxX3.Enabled = True
            TextBoxX4.Enabled = True
            TextBoxX5.Enabled = True
            TextBoxX6.Enabled = True
            typebdd.Enabled = True
        End If
    End Sub
End Class
