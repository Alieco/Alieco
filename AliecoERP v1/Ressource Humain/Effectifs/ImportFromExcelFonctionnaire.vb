Imports System.Data.OleDb
'Imports Excel = Microsoft.Office.Interop.Excel
Imports System.Text
Imports DevComponents.DotNetBar

Public Class ImportFromExcelFonctionnaire
    Public ds As New DataSet
    Public da As OleDbDataAdapter
    'Permitir conectarnos con nuestro archivo de excel'
    Public conn As OleDbConnection
    'Permitir conectarnos a nuestra base de datos sqlserver'
    Private Sub ButtonX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX1.Click
        Try
            OpenFileDialog1.FileName = ""
            OpenFileDialog1.Filter = "Excel files (*.xls)|*.xls|Excel(2007) files (*.xlsx)|*.xlsx|All files (*.*)|*.*"
            If OpenFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
                filetxt.Text = OpenFileDialog1.FileName
            End If
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub
    Public Sub ImportToDB()
        Try
            Dim dt As New DataTable
            Windows.Forms.Cursor.Current = Cursors.WaitCursor
            Dim er As Integer = 0
            Dim s As Integer = 0
            Try
                dt = ReadExcelFile()
                Me.ProgressBarX1.Value = 0
                Me.ProgressBarX1.Maximum = dt.Rows.Count
                Me.ProgressBarX1.Visible = True
                If dt.Rows.Count > 0 Then
                    For i = 0 To dt.Rows.Count - 1
                        If Not IsDBNull(dt.Rows(i)(0)) Then
                            IsConnected("SELECT Nom FROM Employe WHERE Matricule=" & dt.Rows(i)(0).ToString, False)
                            If myDR.HasRows = True Then
                                'UPDATE if CHECKED
                                If Ecraser.Checked = True Then
                                    'UPDATE
                                Else
                                    s += 1
                                    Sauter.Text = "Sauter les doublures (" & s & ")"
                                End If
                            Else
                                'INSERT
                                Dim vnais As String = ""
                                Dim SF As String = "Célibataire"
                                If dt.Rows(i)(33).ToString = "M" Then
                                    SF = "Marié(e)"
                                End If
                                Dim wn As String = IIf(Not IsDBNull(dt.Rows(i)(5)), dt.Rows(i)(5), "Alger")
                                IsConnected("SELECT id FROM willaya WHERE willaya like '%" & wn.ToString & "%'", False)
                                If myDR.HasRows = True Then
                                    vnais = myDR("willaya")
                                End If
                                Dim ifo As String = IIf(Not IsDBNull(dt.Rows(i)(12)), dt.Rows(i)(12), "Alger")
                                Dim id_fon = 0
                                IsConnected("SELECT id FROM Fonction WHERE titre_fonction like '%" & ifo.ToString & "%'", False)
                                If myDR.HasRows = True Then
                                    id_fon = myDR("id")
                                Else
                                    IsConnected("INSERT INTO fontion Values(Null, '" & ifo.ToString & "','" & dt.Rows(i)(14) & "','0') ", True)
                                    IsConnected("SELECT id_fonction FROM Fonction WHERE titre_fonction like '%" & ifo.ToString & "%'", False)
                                    If myDR.HasRows = True Then
                                        id_fon = myDR("id_fonction")
                                    End If
                                End If
                                Dim idp As String = IIf(Not IsDBNull(dt.Rows(i)(18)), dt.Rows(i)(18), Nothing)
                                Dim id_dep = 0
                                IsConnected("SELECT id_departement FROM Departement WHERE titre_departement like '%" & idp.ToString & "%'", False)
                                If myDR.HasRows = True Then
                                    id_fon = myDR("id_departement")
                                End If
                                Dim idr As String = IIf(Not IsDBNull(dt.Rows(i)(17)), dt.Rows(i)(17), Nothing)
                                Dim id_dir = 0
                                IsConnected("SELECT id_direction FROM Departement WHERE titre_departement like '%" & idr.ToString & "%'", False)
                                If myDR.HasRows = True Then
                                    id_fon = myDR("id_direction")
                                End If
                                Dim mat As Integer = IIf(Not IsDBNull(dt.Rows(i)(0)), dt.Rows(i)(0), Nothing)
                                Dim nom As String = IIf(Not IsDBNull(dt.Rows(i)(1)), dt.Rows(i)(1), Nothing)
                                Dim prenom As String = IIf(Not IsDBNull(dt.Rows(i)(2)), dt.Rows(i)(2), Nothing)
                                Dim dn As String = IIf(Not IsDBNull(dt.Rows(i)(3)), dt.Rows(i)(3).ToString("yyyy-MM-dd"), Nothing)
                                Dim ln As String = IIf(Not IsDBNull(dt.Rows(i)(4)), dt.Rows(i)(4), Nothing)
                                Dim dth As String = IIf(Not IsDBNull(dt.Rows(i)(6)), dt.Rows(i)(6).ToString("yyyy-MM-dd"), Nothing)
                                Dim de As String = IIf(Not IsDBNull(dt.Rows(i)(8)), dt.Rows(i)(8).ToString("yyyy-MM-dd"), Nothing)
                                Dim d1 As String = IIf(Not IsDBNull(dt.Rows(i)(9)), dt.Rows(i)(9).ToString("yyyy-MM-dd"), Nothing)
                                Dim dfc As String = IIf(Not IsDBNull(dt.Rows(i)(11)), dt.Rows(i)(11).ToString("yyyy-MM-dd"), Nothing)
                                Dim grp As String = IIf(Not IsDBNull(dt.Rows(i)(13)), dt.Rows(i)(13), Nothing)
                                Dim ech As String = IIf(Not IsDBNull(dt.Rows(i)(15)), dt.Rows(i)(15), Nothing)
                                'Dim d1 As String = IIf(Not IsDBNull(dt.Rows(i)(9)), dt.Rows(i)(9), Nothing)
                                'Dim d1 As String = IIf(Not IsDBNull(dt.Rows(i)(9)), dt.Rows(i)(9), Nothing)
                                'Dim d1 As String = IIf(Not IsDBNull(dt.Rows(i)(9)), dt.Rows(i)(9), Nothing)
                                'Dim d1 As String = IIf(Not IsDBNull(dt.Rows(i)(9)), dt.Rows(i)(9), Nothing)
                                'Dim d1 As String = IIf(Not IsDBNull(dt.Rows(i)(9)), dt.Rows(i)(9), Nothing)
                                'Dim d1 As String = IIf(Not IsDBNull(dt.Rows(i)(9)), dt.Rows(i)(9), Nothing)
                                'Dim d1 As String = IIf(Not IsDBNull(dt.Rows(i)(9)), dt.Rows(i)(9), Nothing)
                                'Dim d1 As String = IIf(Not IsDBNull(dt.Rows(i)(9)), dt.Rows(i)(9), Nothing)
                                'Dim d1 As String = IIf(Not IsDBNull(dt.Rows(i)(9)), dt.Rows(i)(9), Nothing)
                                'Dim d1 As String = IIf(Not IsDBNull(dt.Rows(i)(9)), dt.Rows(i)(9), Nothing)
                                'Dim d1 As String = IIf(Not IsDBNull(dt.Rows(i)(9)), dt.Rows(i)(9), Nothing)
                                'Dim d1 As String = IIf(Not IsDBNull(dt.Rows(i)(9)), dt.Rows(i)(9), Nothing)
                                'Dim d1 As String = IIf(Not IsDBNull(dt.Rows(i)(9)), dt.Rows(i)(9), Nothing)
                                'Dim d1 As String = IIf(Not IsDBNull(dt.Rows(i)(9)), dt.Rows(i)(9), Nothing)
                                'Dim d1 As String = IIf(Not IsDBNull(dt.Rows(i)(9)), dt.Rows(i)(9), Nothing)
                                'Dim d1 As String = IIf(Not IsDBNull(dt.Rows(i)(9)), dt.Rows(i)(9), Nothing)
                                'Dim d1 As String = IIf(Not IsDBNull(dt.Rows(i)(9)), dt.Rows(i)(9), Nothing)
                                'Dim d1 As String = IIf(Not IsDBNull(dt.Rows(i)(9)), dt.Rows(i)(9), Nothing)
                                'Dim d1 As String = IIf(Not IsDBNull(dt.Rows(i)(9)), dt.Rows(i)(9), Nothing)
                                'Dim d1 As String = IIf(Not IsDBNull(dt.Rows(i)(9)), dt.Rows(i)(9), Nothing)
                                'Dim d1 As String = IIf(Not IsDBNull(dt.Rows(i)(9)), dt.Rows(i)(9), Nothing)
                                'Dim d1 As String = IIf(Not IsDBNull(dt.Rows(i)(9)), dt.Rows(i)(9), Nothing)
                                'Dim d1 As String = IIf(Not IsDBNull(dt.Rows(i)(9)), dt.Rows(i)(9), Nothing)
                                'Dim d1 As String = IIf(Not IsDBNull(dt.Rows(i)(9)), dt.Rows(i)(9), Nothing)
                                'Dim d1 As String = IIf(Not IsDBNull(dt.Rows(i)(9)), dt.Rows(i)(9), Nothing)
                                'Dim d1 As String = IIf(Not IsDBNull(dt.Rows(i)(9)), dt.Rows(i)(9), Nothing)
                                'Dim d1 As String = IIf(Not IsDBNull(dt.Rows(i)(9)), dt.Rows(i)(9), Nothing)
                                'Dim d1 As String = IIf(Not IsDBNull(dt.Rows(i)(9)), dt.Rows(i)(9), Nothing)
                                'Dim d1 As String = IIf(Not IsDBNull(dt.Rows(i)(9)), dt.Rows(i)(9), Nothing)
                                'Dim d1 As String = IIf(Not IsDBNull(dt.Rows(i)(9)), dt.Rows(i)(9), Nothing)
                                'Dim d1 As String = IIf(Not IsDBNull(dt.Rows(i)(9)), dt.Rows(i)(9), Nothing)
                                'Dim d1 As String = IIf(Not IsDBNull(dt.Rows(i)(9)), dt.Rows(i)(9), Nothing)
                                'Dim d1 As String = IIf(Not IsDBNull(dt.Rows(i)(9)), dt.Rows(i)(9), Nothing)
                                'Dim d1 As String = IIf(Not IsDBNull(dt.Rows(i)(9)), dt.Rows(i)(9), Nothing)
                                'Dim d1 As String = IIf(Not IsDBNull(dt.Rows(i)(9)), dt.Rows(i)(9), Nothing)
                                'Dim d1 As String = IIf(Not IsDBNull(dt.Rows(i)(9)), dt.Rows(i)(9), Nothing)
                                'ByVal id_fonction As Integer, ByVal echelon As String, ByVal Groupe As String, ByVal id_direction As Integer, ByVal id_departement As Integer, ByVal id_service As Integer, ByVal id_hall As Integer, ByVal id_equipe As Integer, ByVal Collectif As String, ByVal Collectifprc As String, ByVal Statut As String, ByVal Motif_Recrut As String, ByVal NbresCont As Integer, ByVal id_niveau As Integer, ByVal Formation_ext As String, ByVal Formation_int As String, ByVal NC As String, ByVal Service_national As String, ByVal Sexe As String, ByVal Sit_fam As String, ByVal Adresse As String, ByVal VilleAdr As Integer, ByVal Salissure As Integer, ByVal Pénibilité As Integer, ByVal Insalubrité As Integer, ByVal Danger As Integer)
                                'MsgBox(vnais)
                                'Dim q As String = "INSERT INTO Employe (Matricule ,Nom ,Prénom,DNaissance,LNaissance,VilleNais,Dentrée,Dentrée1,etat_emp,user_id,date_Enregistrement,numTel,DFcontrat,id_fonction,echelon,Groupe,id_direction,id_departement,id_service,id_hall,id_equipe,Collectif,Collectifprc,Statut,Motif_Recrut,NbresCont,id_niveau,NC,Service_national,Sexe,Sit_fam,Adresse,VilleAdr,Salissure,Pénibilité,Insalubrité,Danger)" & _
                                ' "VALUES" & _
                                '"('" & DataGridViewX1.Rows(i).Cells("Matricule").Value() & "'" & _
                                '",'" & DataGridViewX1.Rows(i).Cells("Nom").Value() & "'" & _
                                '",'" & DataGridViewX1.Rows(i).Cells("Prénom").Value() & "'" & _
                                '",'" & DataGridViewX1.Rows(i).Cells("Prénom").Value().ToString("yyyy-MM-dd") & "'" & _
                                '",'" & DataGridViewX1.Rows(i).Cells("L / Naissance").Value() & "'" & _
                                '",'" & vnais & "'" & _
                                '",'" & DataGridViewX1.Rows(i).Cells("Datedentee").Value().ToString("yyyy-MM-dd") & "'" & _
                                '",'" & DateTimeInput2.Value.ToString("yyyy-MM-dd") & "'" & _
                                '",'1'" & _
                                '"," & user_id & "" & _
                                '",NOW()" & _
                                '",'" & numtel.Text & "'" & _
                                '",'" & DateTimeInput3.Value.ToString("yyyy-MM-dd") & "'" & _
                                '"," & fon & "" & _
                                '",'" & DataGridViewX1.Rows(i).Cells("Ech").Value() & "'" & _
                                '",'" & groupe.Text & "'" & _
                                '"," & Dir() & "" & _
                                '"," & dep & "" & _
                                '"," & serv & "" & _
                                '"," & hal & "" & _
                                '"," & equi & "" & _
                                '",'" & collect.Text & "'" & _
                                '",'" & collectif.Text & "'" & _
                                '",'" & statut.Text & "'" & _
                                '",'" & motif_recru.Text & "'" & _
                                '"," & ncontrat.Value & "" & _
                                '"," & niv & "" & _
                                '",'" & nc.Text & "'" & _
                                '",'" & DataGridViewX1.Rows(i).Cells("Service national").Value() & "'" & _
                                '",'" & gen & "'" & _
                                '",'" & SF & "'" & _
                                '",'" & DataGridViewX1.Rows(i).Cells("Adresse").Value() & "'" & _
                                '"," & region2.SelectedIndex + 1 & "" & _
                                '",'" & DataGridViewX1.Rows(i).Cells("Salissure").Value() & "'" & _
                                '",'" & DataGridViewX1.Rows(i).Cells("Pénibilité").Value() & "'" & _
                                '",'" & DataGridViewX1.Rows(i).Cells("Insalubrité").Value() & "'" & _
                                '",'" & DataGridViewX1.Rows(i).Cells("Danger").Value() & "')"
                                '                 Clipboard.SetText(q)
                                '                 IsConnected(q, False)
                                SaveToDB(mat, nom, dt.Rows(i)(2), dt.Rows(i)(3).ToString("yyyy-MM-dd"), dt.Rows(i)(4), vnais, dt.Rows(i)(6).ToString("yyyy-MM-dd"), dt.Rows(i)(7), dt.Rows(i)(8).ToString("yyyy-MM-dd"), d1.ToString("yyyy-MM-dd"), user_id, dt.Rows(i)(11), dt.Rows(i)(12), dt.Rows(i)(13), dt.Rows(i)(14), dt.Rows(i)(15), dt.Rows(i)(16), dt.Rows(i)(17), dt.Rows(i)(18), dt.Rows(i)(19), dt.Rows(i)(20), dt.Rows(i)(21), dt.Rows(i)(22), dt.Rows(i)(23), dt.Rows(i)(24), dt.Rows(i)(25), dt.Rows(i)(26), dt.Rows(i)(27), dt.Rows(i)(28), dt.Rows(i)(29), dt.Rows(i)(30), dt.Rows(i)(31), dt.Rows(i)(32), dt.Rows(i)(33), dt.Rows(i)(34), dt.Rows(i)(35), dt.Rows(i)(36), dt.Rows(i)(37))
                                Me.ProgressBarX1.Value = Me.ProgressBarX1.Value + 1
                            End If


                        Else
                            er += 1

                        End If

                    Next
                    ' Load_Data()
                    MessageBoxEx.Show("Data has successfully imported.", "Import ", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBoxEx.Show("Une Erreur s'est produit leur l'import de fichier .", "Import ", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Catch ex As Exception
            End Try
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub
    Function ReadExcelFile()
        Try
            Dim da As New OleDbDataAdapter
            Dim dt As New DataTable
            Dim cmd As New OleDbCommand
            Dim xlsConn As OleDbConnection
            Dim sPath As String = String.Empty
            Dim xSheet As String = "feuil1"
            sPath = filetxt.Text
            xlsConn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & sPath & ";Extended Properties=Excel 12.0")
            Try
                xlsConn.Open()
                cmd.Connection = xlsConn
                cmd.CommandType = CommandType.Text
                xSheet = InputBox("Entrez le nom de la feuile", "Complete")
                cmd.CommandText = ("select * from [" & xSheet & "$]")
                da.SelectCommand = cmd
                da.Fill(dt)
            Catch
                MsgBox(ErrorToString)
            Finally
                xlsConn.Close()
                xlsConn = Nothing
            End Try
            Return dt
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
        Return Nothing
    End Function
    Public Sub SaveToDB(ByVal Matricule As Integer, ByVal Nom As String, ByVal Prénom As String, ByVal DNaissance As String, ByVal LNaissance As String, ByVal VilleNais As String, ByVal Dthéorie As String, ByVal Dentrée As String, ByVal Dentrée1 As String, ByVal user_id As Integer, ByVal numTel As String, ByVal DFcontrat As String, ByVal id_fonction As Integer, ByVal echelon As String, ByVal Groupe As String, ByVal id_direction As Integer, ByVal id_departement As Integer, ByVal id_service As Integer, ByVal id_hall As Integer, ByVal id_equipe As Integer, ByVal Collectif As String, ByVal Collectifprc As String, ByVal Statut As String, ByVal Motif_Recrut As String, ByVal NbresCont As Integer, ByVal id_niveau As Integer, ByVal Formation_ext As String, ByVal Formation_int As String, ByVal NC As String, ByVal Service_national As String, ByVal Sexe As String, ByVal Sit_fam As String, ByVal Adresse As String, ByVal VilleAdr As Integer, ByVal Salissure As Integer, ByVal Pénibilité As Integer, ByVal Insalubrité As Integer, ByVal Danger As Integer)
        Try
            Dim sql As New SQLControl
            Try
                sql.AddParam("@Matricule", Matricule, DbType.Int16)
                sql.AddParam("@Nom", Nom, DbType.String)
                sql.AddParam("@Prénom", Prénom, DbType.String)
                sql.AddParam("@DNaissance", DNaissance, DbType.Date)
                sql.AddParam("@LNaissance", LNaissance, DbType.String)
                sql.AddParam("@VilleNais", VilleNais, DbType.Int16)
                sql.AddParam("@Dthéorie", Dthéorie, DbType.Date)
                sql.AddParam("@Dentrée", Dentrée, DbType.Date)
                sql.AddParam("@Dentrée1", Dentrée1, DbType.Date)
                sql.AddParam("@user_id", user_id, DbType.Int16)
                sql.AddParam("@numTel", numTel, DbType.String)
                sql.AddParam("@DFcontrat", DFcontrat, DbType.Date)
                sql.AddParam("@id_fonction", id_fonction, DbType.Int16)
                sql.AddParam("@echelon", echelon, DbType.String)
                sql.AddParam("@Groupe", Groupe, DbType.String)
                sql.AddParam("@id_direction", id_direction, DbType.Int16)
                sql.AddParam("@id_departement", id_departement, DbType.Int16)
                sql.AddParam("@id_service", id_service, DbType.Int16)
                sql.AddParam("@id_hall", id_hall, DbType.Int16)
                sql.AddParam("@id_equipe", id_equipe, DbType.Int16)
                sql.AddParam("@Collectif", Collectif, DbType.String)
                sql.AddParam("@Collectifprc", Collectifprc, DbType.String)
                sql.AddParam("@Statut", Statut, DbType.String)
                sql.AddParam("@Motif_Recrut", Motif_Recrut, DbType.String)
                sql.AddParam("@NbresCont", NbresCont, DbType.Int16)
                sql.AddParam("@id_niveau", id_niveau, DbType.Int16)
                sql.AddParam("@Formation_ext", Formation_ext, DbType.String)
                sql.AddParam("@Formation_int", Formation_int, DbType.String)
                sql.AddParam("@NC", NC, DbType.String)
                sql.AddParam("@Service_national", Service_national, DbType.String)
                sql.AddParam("@Sexe", Sexe, DbType.String)
                sql.AddParam("@Sit_fam", Sit_fam, DbType.String)
                sql.AddParam("@Adresse", Adresse, DbType.String)
                sql.AddParam("@Danger", Danger, DbType.Int16)
                sql.AddParam("@VilleAdr", VilleAdr, DbType.Int16)
                sql.AddParam("@Salissure", Salissure, DbType.Int16)
                sql.AddParam("@Pénibilité", Pénibilité, DbType.Int16)
                sql.AddParam("@Insalubrité", Insalubrité, DbType.Int16)
                sql.ParamNonQuery("INSERT INTO `employe`(`id_emp`,`Matricule`,`Nom`,`Prénom`,`DNaissance`,`LNaissance`,`VilleNais`,`Dthéorie`,`Dentrée`,`Dentrée1`,`etat_emp`,`user_id`,`date_Enregistrement`,`numTel`,`DFcontrat`,`id_fonction`,`echelon`,`Groupe`,`id_direction`,`id_departement`,`id_service`,`id_hall`,`id_equipe`,`Collectif`,`Collectifprc`,`Statut`,`Motif_Recrut`,`NbresCont`,`id_niveau`,`Formation_ext`,`Formation_int`,`NC`,`Service_national`,`Sexe`,`Sit_fam`,`Adresse`,`VilleAdr`,`Salissure`,`Pénibilité`,`Insalubrité`,`Danger`) VALUES(Null,@Matricule,@Nom,@Prénom,@DNaissance,@LNaissance,@VilleNais,@Dthéorie,@Dentrée,@Dentrée1,'1',@user_id,NOW(),@numTel,@DFcontrat,@id_fonction,@echelon,@Groupe,@id_direction,@id_departement,@id_service,@id_hall,@id_equipe,@Collectif,@Collectifprc,@Statut,@Motif_Recrut,@NbresCont,@id_niveau,@Formation_ext,@Formation_int,@NC,@Service_national,@Sexe,@Sit_fam,@Adresse,@VilleAdr,@Salissure,@Pénibilité,@Insalubrité,@Danger)")
            Catch ex As Exception
                MsgBox(ErrorToString)
            Finally
            End Try
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub
    Private Sub ImportFromExcelFonctionnaire_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub ButtonX2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX2.Click
        Try
            'For Each dr As DataGridViewRow In DataGridViewX1.Rows
            '    MsgBox(DataGridViewX1.Rows(dr.Index).Cells("Matricule").Value())
            'Next dr
            Dim er As Integer = 0
            Dim s As Integer = 0

            For i As Integer = 0 To DataGridViewX1.Rows.Count - 1
                If DataGridViewX1.Rows(i).Cells("Matricule").Value().ToString <> "" Then
                    IsConnected("SELECT Nom FROM Employe WHERE Matricule=" & DataGridViewX1.Rows(i).Cells("Matricule").Value().ToString, False)
                    If myDR.HasRows = True Then
                        'UPDATE if CHECKED
                        If Ecraser.Checked = True Then
                            'UPDATE
                        Else
                            s += 1
                            Sauter.Text = "Sauter les doublures (" & s & ")"
                        End If
                    Else
                        'INSERT
                        Dim vnais As String = ""
                        Dim SF As String = "Célibataire"
                        If DataGridViewX1.Rows(i).Cells("Datedentee").Value() = "M" Then
                            SF = "Marié(e)"
                        End If
                        IsConnected("SELECT id FROM willaya WHERE willaya = '" & DataGridViewX1.Rows(i).Cells("Ville").Value() & "'", False)
                        If myDR.HasRows = True Then
                            vnais = myDR("willaya")
                        End If
                        MsgBox(vnais)
                        'Dim q As String = "INSERT INTO Employe (Matricule ,Nom ,Prénom,DNaissance,LNaissance,VilleNais,Dentrée,Dentrée1,etat_emp,user_id,date_Enregistrement,numTel,DFcontrat,id_fonction,echelon,Groupe,id_direction,id_departement,id_service,id_hall,id_equipe,Collectif,Collectifprc,Statut,Motif_Recrut,NbresCont,id_niveau,NC,Service_national,Sexe,Sit_fam,Adresse,VilleAdr,Salissure,Pénibilité,Insalubrité,Danger)" & _
                        ' "VALUES" & _
                        '"('" & DataGridViewX1.Rows(i).Cells("Matricule").Value() & "'" & _
                        '",'" & DataGridViewX1.Rows(i).Cells("Nom").Value() & "'" & _
                        '",'" & DataGridViewX1.Rows(i).Cells("Prénom").Value() & "'" & _
                        '",'" & DataGridViewX1.Rows(i).Cells("Prénom").Value().ToString("yyyy-MM-dd") & "'" & _
                        '",'" & DataGridViewX1.Rows(i).Cells("L / Naissance").Value() & "'" & _
                        '",'" & vnais & "'" & _
                        '",'" & DataGridViewX1.Rows(i).Cells("Datedentee").Value().ToString("yyyy-MM-dd") & "'" & _
                        '",'" & DateTimeInput2.Value.ToString("yyyy-MM-dd") & "'" & _
                        '",'1'" & _
                        '"," & user_id & "" & _
                        '",NOW()" & _
                        '",'" & numtel.Text & "'" & _
                        '",'" & DateTimeInput3.Value.ToString("yyyy-MM-dd") & "'" & _
                        '"," & fon & "" & _
                        '",'" & DataGridViewX1.Rows(i).Cells("Ech").Value() & "'" & _
                        '",'" & groupe.Text & "'" & _
                        '"," & Dir() & "" & _
                        '"," & dep & "" & _
                        '"," & serv & "" & _
                        '"," & hal & "" & _
                        '"," & equi & "" & _
                        '",'" & collect.Text & "'" & _
                        '",'" & collectif.Text & "'" & _
                        '",'" & statut.Text & "'" & _
                        '",'" & motif_recru.Text & "'" & _
                        '"," & ncontrat.Value & "" & _
                        '"," & niv & "" & _
                        '",'" & nc.Text & "'" & _
                        '",'" & DataGridViewX1.Rows(i).Cells("Service national").Value() & "'" & _
                        '",'" & gen & "'" & _
                        '",'" & SF & "'" & _
                        '",'" & DataGridViewX1.Rows(i).Cells("Adresse").Value() & "'" & _
                        '"," & region2.SelectedIndex + 1 & "" & _
                        '",'" & DataGridViewX1.Rows(i).Cells("Salissure").Value() & "'" & _
                        '",'" & DataGridViewX1.Rows(i).Cells("Pénibilité").Value() & "'" & _
                        '",'" & DataGridViewX1.Rows(i).Cells("Insalubrité").Value() & "'" & _
                        '",'" & DataGridViewX1.Rows(i).Cells("Danger").Value() & "')"
                        '                 Clipboard.SetText(q)
                        '                 IsConnected(q, False)
                    End If
                Else
                    er += 1
                End If
            Next
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub

    Private Sub ButtonX3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX3.Click
        Try
            'If OpenFileDialog1.FileName.ToString <> "" Then
            '    Dim xSheet As String = ""
            '    Dim ExcelFile As String = OpenFileDialog1.FileName.ToString
            '    xSheet = InputBox("Entrez le nom de la feuile", "Complete")
            '    If xSheet = "" Then
            '        Exit Sub
            '    End If
            '    conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;" & "data source=" & ExcelFile & "; " & "Extended Properties='Excel 12.0 Xml;HDR=Yes'")
            '    Try
            '        conn.Open()
            '        da = New OleDbDataAdapter("SELECT * FROM  [" & xSheet & "$]", conn)
            '        ds = New DataSet
            '        da.Fill(ds)
            '        DataGridViewX1.DataSource = ds.Tables(0)
            '        ' sqlBC.WriteToServer(ds.Tables(0))
            '    Catch ex As Exception
            '        MsgBox("Error: " + ex.ToString, MsgBoxStyle.Information, "Informacion")
            '    Finally
            '        conn.Close()
            '    End Try
            'End If
            If Len(Trim(OpenFileDialog1.FileName)) > 0 Then
                ImportToDB()
            Else
                'Inform the user if no selected excel file.
                MsgBox("S'il vous plait selectionner un fichier correcte.", MsgBoxStyle.OkOnly, "Import")
            End If
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub
End Class