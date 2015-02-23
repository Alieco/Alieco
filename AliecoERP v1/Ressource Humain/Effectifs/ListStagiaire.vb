Imports Microsoft.Office.Interop
Imports DevExpress.XtraGrid.Views.Grid

Public Class ListStagiaire
    Dim sql As New SQLControl
    Private Sub ListStagiaire_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Me.WindowState = FormWindowState.Maximized
            'Dim loginThread As Thread = New Thread(AddressOf reload)
            'loginThread.Start()
            reload()
            load_Spécialité()
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub
    Sub reload()
        Try
            If sql.VerifiyConnection = True Then
                '  sql.RunQuery("SELECT Matricule,Nom,Prénom,DNaissance as 'Date de naissance',Dentrée as 'Date d\'entrée',numTel as 'Num Téléphone',name_service as 'Nom de service',titre_fonction as Fonction,name_direction as Direction,name_departement as Departement,Statut,Sexe,Sit_fam as 'Situation familiale',Adresse,willaya FROM Services, Departement, Direction, Employes, Fonction, willaya WHERE Services.id_departement=Departement.id_departement and Direction.id_direction=Departement.id_direction and Employe.id_service=Services.id_service and Fonction.id_fonction=Employe.id_fonction and willaya.id=Employe.VilleAdr")
                ' Clipboard.SetText("SELECT Matricule,Nom,Prénom,DNaissance as 'Date de naissance',Dentrée as 'Date d'entrée',numTel as 'Num Tel',name_service,titre_fonction as Fonction,name_direction as Direction,name_departement as Departement,Statut,Sexe,Sit_fam as 'Situation familiale',Adresse,willaya FROM Services, Departement, Direction, Employe, Fonction, willaya WHERE Services.id_departement=Departement.id_departement and Direction.id_direction=Departement.id_direction and Employe.id_service=Services.id_service and Fonction.id_fonction=Employe.id_fonction and willaya.id=Employe.VilleAdr")
                sql.RunQuery("select Matricule,Nom,Prénom,Date_de_naissance, Date_dEntrée,Durée,Affectation,Jour,Centre_de_formation,Install,Spécialité, period_diff(date_format(now(), '%Y%m'), date_format(Date_dEntrée, '%Y%m')) as Ancienté from stagiaire order by Ancienté")

                If sql.SQLDS.Tables.Count > 0 Then
                    dgstagiaire.DataSource = sql.SQLDS.Tables(0)
                    ' dgstagiaire.ScrollBars = ScrollBars.None
                End If
                'dgstagiaire.ScrollBars = ScrollBars.Both
                dgstagiaire.PerformLayout()
            End If
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub
    'Private Sub dgstagiaire_RowPostPaint_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewRowPostPaintEventArgs)
    '    If e.RowIndex < dgstagiaire.RowCount - 1 Then
    '        Dim dgvRow As DataGridViewRow = dgstagiaire.Rows(e.RowIndex)
    '        Try
    '            If Not IsDBNull(dgvRow.Cells("Ancienté").Value) Then
    '                If CInt(dgvRow.Cells("Ancienté").Value) < "6" Then
    '                    dgvRow.DefaultCellStyle.BackColor = Color.FromArgb(231, 76, 60)
    '                End If
    '                If CInt(dgvRow.Cells("Ancienté").Value) > "6" Then
    '                    dgvRow.DefaultCellStyle.BackColor = Color.FromArgb(41, 128, 185)
    '                End If
    '                If CInt(dgvRow.Cells("Ancienté").Value) > "12" Then
    '                    dgvRow.DefaultCellStyle.BackColor = Color.FromArgb(189, 195, 199)
    '                End If
    '                If CInt(dgvRow.Cells("Ancienté").Value) > "18" Then
    '                    dgvRow.DefaultCellStyle.BackColor = Color.FromArgb(241, 196, 15)
    '                End If
    '                If CInt(dgvRow.Cells("Ancienté").Value) > "24" Then
    '                    dgvRow.DefaultCellStyle.BackColor = Color.FromArgb(127, 140, 141)
    '                End If
    '                If CInt(dgvRow.Cells("Ancienté").Value) > "30" Then
    '                    dgvRow.DefaultCellStyle.BackColor = Color.FromArgb(170, 146, 88)
    '                End If
    '            End If
    '        Catch ex As Exception
    '        End Try
    '    End If
    '    'RadioButton1.Checked = True And
    'End Sub

    Private Sub ButtonX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX1.Click
        Try
            Dim s As New SaveFileDialog
            s.DefaultExt = "*.xlsx"
            s.Title = "Choisisez le nom de fichier d'enregistrement"
            s.Filter = "Excel 2010 | *.xlsx"
            If s.ShowDialog = Windows.Forms.DialogResult.OK Then
                GridView1.ExportToXlsx(s.FileName)
            End If
        Catch ex As Exception
            MsgBox("Export Excel Error " & ex.Message)
            EnvoiError(ex.Message)
        Finally
            'RELEASE ALLOACTED RESOURCES
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
        End Try
    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        Try
            If sql.VerifiyConnection = True Then
                sql.RunQuery("select Matricule,Nom,Prénom,Date_de_naissance, Date_dEntrée,Durée,Affectation,Jour,Centre_de_formation,Install,Spécialité, period_diff(date_format(now(), '%Y%m'), date_format(Date_dEntrée, '%Y%m')) as Ancienté from stagiaire where period_diff(date_format(now(), '%Y%m'), date_format(Date_dEntrée, '%Y%m'))<6 order by Ancienté")
                If sql.SQLDS.Tables.Count > 0 Then
                    dgstagiaire.DataSource = sql.SQLDS.Tables(0)
                End If
            End If
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub

    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged
        Try
            If sql.VerifiyConnection = True Then
                sql.RunQuery("select Matricule,Nom,Prénom,Date_de_naissance, Date_dEntrée,Durée,Affectation,Jour,Centre_de_formation,Install,Spécialité, period_diff(date_format(now(), '%Y%m'), date_format(Date_dEntrée, '%Y%m')) as Ancienté from stagiaire where period_diff(date_format(now(), '%Y%m'), date_format(Date_dEntrée, '%Y%m'))>=6  and period_diff(date_format(now(), '%Y%m'), date_format(Date_dEntrée, '%Y%m'))<12 order by Ancienté")
                If sql.SQLDS.Tables.Count > 0 Then
                    dgstagiaire.DataSource = sql.SQLDS.Tables(0)
                End If
            End If
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub

    Private Sub RadioButton3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton3.CheckedChanged
        Try
            If sql.VerifiyConnection = True Then
                sql.RunQuery("select Matricule,Nom,Prénom,Date_de_naissance, Date_dEntrée,Durée,Affectation,Jour,Centre_de_formation,Install,Spécialité, period_diff(date_format(now(), '%Y%m'), date_format(Date_dEntrée, '%Y%m')) as Ancienté from stagiaire where period_diff(date_format(now(), '%Y%m'), date_format(Date_dEntrée, '%Y%m'))>=12 and period_diff(date_format(now(), '%Y%m'), date_format(Date_dEntrée, '%Y%m'))<18 order by Ancienté")
                If sql.SQLDS.Tables.Count > 0 Then
                    dgstagiaire.DataSource = sql.SQLDS.Tables(0)
                End If
            End If
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub

    Private Sub RadioButton4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton4.CheckedChanged
        Try
            If sql.VerifiyConnection = True Then
                sql.RunQuery("select Matricule,Nom,Prénom,Date_de_naissance, Date_dEntrée,Durée,Affectation,Jour,Centre_de_formation,Install,Spécialité, period_diff(date_format(now(), '%Y%m'), date_format(Date_dEntrée, '%Y%m')) as Ancienté from stagiaire where period_diff(date_format(now(), '%Y%m'), date_format(Date_dEntrée, '%Y%m'))>=18 and period_diff(date_format(now(), '%Y%m'), date_format(Date_dEntrée, '%Y%m'))<24 order by Ancienté")
                If sql.SQLDS.Tables.Count > 0 Then
                    dgstagiaire.DataSource = sql.SQLDS.Tables(0)
                End If
            End If
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub

    Private Sub RadioButton5_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton5.CheckedChanged
        Try
            If sql.VerifiyConnection = True Then
                sql.RunQuery("select Matricule,Nom,Prénom,Date_de_naissance, Date_dEntrée,Durée,Affectation,Jour,Centre_de_formation,Install,Spécialité, period_diff(date_format(now(), '%Y%m'), date_format(Date_dEntrée, '%Y%m')) as Ancienté from stagiaire where period_diff(date_format(now(), '%Y%m'), date_format(Date_dEntrée, '%Y%m'))>=24 and period_diff(date_format(now(), '%Y%m'), date_format(Date_dEntrée, '%Y%m'))<30 order by Ancienté")
                If sql.SQLDS.Tables.Count > 0 Then
                    dgstagiaire.DataSource = sql.SQLDS.Tables(0)
                End If
            End If
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub

    Private Sub RadioButton6_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton6.CheckedChanged
        Try
            If sql.VerifiyConnection = True Then
                sql.RunQuery("select Matricule,Nom,Prénom,Date_de_naissance, Date_dEntrée,Durée,Affectation,Jour,Centre_de_formation,Install,Spécialité, period_diff(date_format(now(), '%Y%m'), date_format(Date_dEntrée, '%Y%m')) as Ancienté from stagiaire where period_diff(date_format(now(), '%Y%m'), date_format(Date_dEntrée, '%Y%m'))>=30 order by Ancienté")
                If sql.SQLDS.Tables.Count > 0 Then
                    dgstagiaire.DataSource = sql.SQLDS.Tables(0)
                End If
            End If
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub

    Private Sub ButtonX2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX2.Click
        Try
            IsConnected("SELECT count(Matricule) as nb FROM stagiaire ", False)
            If myDR.HasRows = True Then
                While (myDR.Read())
                    TextBoxX2.Text = myDR("nb")
                End While
            End If
            Try
                Dim a As Double = 0
                Dim b As String = ""
                IsConnected("SELECT Distinct count(Matricule) as nb, Spécialité  FROM stagiaire WHERE Spécialité <> '' GROUP BY Spécialité ", False)
                If myDR.HasRows = True Then
                    While (myDR.Read())
                        a = myDR("nb")
                        b = myDR("Spécialité")
                        Chart1.Series("Spécialité").Points.AddXY(b, a)
                    End While
                End If
            Catch ex As Exception
            End Try
            ButtonX2.Enabled = False
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub

    Private Sub ComboBoxEx1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBoxEx1.SelectedIndexChanged
        Try
            IsConnected("SELECT count(Matricule)as nb1 FROM stagiaire where Spécialité='" & ComboBoxEx1.Text & "'", False)
            If myDR.HasRows = True Then
                While (myDR.Read())
                    TextBoxX1.Text = myDR("nb1")
                End While
            End If
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub
#Region "fonctions"
    Private Sub load_Spécialité()
        Try
            If IsConnected("SELECT DISTINCT(Spécialité) FROM stagiaire ", False) = True Then
                If myDR.HasRows = True Then
                    While (myDR.Read())
                        ComboBoxEx1.Items.Add(myDR("Spécialité"))
                    End While
                End If
            End If
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub
#End Region


    Private Sub GridView1_RowStyle(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs) Handles GridView1.RowStyle
        Try
            Dim View As GridView = sender
            If (e.RowHandle >= 0) Then
                Try
                    If Not IsDBNull(View.GetRowCellDisplayText(e.RowHandle, View.Columns("Ancienté"))) Then
                        Dim Anciante As String = View.GetRowCellDisplayText(e.RowHandle, View.Columns("Ancienté"))

                        If (Anciante < "6") Then

                            e.Appearance.BackColor = Color.FromArgb(231, 76, 60)
                        End If
                        If (Anciante > "6") Then
                            e.Appearance.BackColor = Color.FromArgb(41, 128, 185)
                        End If
                        If (Anciante > "12") Then
                            e.Appearance.BackColor = Color.FromArgb(189, 195, 199)
                        End If
                        If (Anciante > "18") Then
                            e.Appearance.BackColor = Color.FromArgb(241, 196, 15)
                        End If
                        If (Anciante > "24") Then
                            e.Appearance.BackColor = Color.FromArgb(127, 140, 141)
                        End If
                        If (Anciante > "30") Then
                            e.Appearance.BackColor = Color.FromArgb(170, 146, 88)
                        End If

                    End If
                Catch ex As Exception

                End Try
            End If
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub
End Class