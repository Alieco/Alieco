Imports DevComponents.DotNetBar

Public Class ListOE
    Dim sql As New SQLControl
    Dim nb
    Dim nb1
#Region "Fonctions"
    Sub reload1()
        Try
            Dim a As Date = au.Value.ToString("yyyy-MM-dd")
            a = a.AddDays(+1)
            Dim utilisateur As String = ""
            If user_id = 20 Or user_id = 1 Then
                If chargeaffaire.Text = "" Then
                    utilisateur = ""
                Else
                    utilisateur = "fullname= '" & chargeaffaire.Text & "' and "
                End If
            Else
                utilisateur = "user_id= '" & user_id & "' and "
            End If
            If sql.VerifiyConnection = True Then
                sql.RunQuery("SELECT distinct commercial_moe.code_affaire as 'code affaire',nomcl as 'Nom client',destinataire,titre,users.fullname as 'Chargé d\'affaire',NClassement as 'N° Classement',commande as 'N° Modification',EtabliPar as 'Etabli Par',entry_date as 'Date d\'enregistrement',idcommercial_MOE as 'Code MOE' FROM commercial_moe left join users on commercial_moe.charge_affaire=users.user_id left join commercial_affaire on commercial_moe.code_affaire=commercial_affaire.code_affaire WHERE " & utilisateur & " commercial_moe.entry_date>= '" & du.Value.ToString("yyyy-MM-dd") & "' and commercial_moe.entry_date <='" & a.ToString("yyyy-MM-dd") & "'")
                If sql.SQLDS.Tables.Count > 0 Then
                    nb1 = sql.SQLDS.Tables(0).Rows.Count
                    dgoe.DataSource = sql.SQLDS.Tables(0)
                End If
                Label1.Text = ""
                If nb1 = 0 Then
                    MessageBox.Show("il n'y a pas des donneés sur MOE ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Label1.Text = ""
                ElseIf nb1 = 1 Then
                    Label1.Text = "Le nombre de ligne est : " & nb1
                Else
                    Label1.Text = "Le nombre des lignes sont : " & nb1
                End If
            End If
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub
    Sub reload()
        Try
            Dim a As Date = au.Value.ToString("yyyy-MM-dd")
            a = a.AddDays(+1)
            Dim utilisateur As String = ""
            If user_id = 20 Or user_id = 1 Then
                If chargeaffaire.Text = "" Then
                    utilisateur = ""
                Else
                    utilisateur = "fullname= '" & chargeaffaire.Text & "' and "
                End If
            Else
                utilisateur = "user_id= '" & user_id & "' and "
            End If
            ' Console.WriteLine("SELECT distinct commercial_oe.code_affaire as 'code affaire',nomcl as 'Nom client',destinataire,titre,users.fullname,NClassement as 'N° Classement',commande as 'N° Modification',EtabliPar as 'Etabli Par',entry_date as 'entry date',idcommercial_OE FROM commercial_oe left join users on commercial_oe.charge_affaire=users.user_id left join commercial_affaire on commercial_oe.code_affaire=commercial_affaire.code_affaire WHERE " & utilisateur & " commercial_oe.entry_date>= '" & du.Value.ToString("yyyy-MM-dd") & "' and commercial_oe.entry_date <='" & a.ToString("yyyy-MM-dd") & "'")
            If sql.VerifiyConnection = True Then
                sql.RunQuery("SELECT distinct commercial_oe.code_affaire as 'code affaire',nomcl as 'Nom client',destinataire,titre,users.fullname as 'Chargé d\'affaire',NClassement as 'N° Classement',commande as 'N° Modification',EtabliPar as 'Etabli Par',entry_date as 'Date d\'enregistrement',idcommercial_OE as 'Code OE' FROM commercial_oe left join users on commercial_oe.charge_affaire=users.user_id left join commercial_affaire on commercial_oe.code_affaire=commercial_affaire.code_affaire WHERE " & utilisateur & " commercial_oe.entry_date>= '" & du.Value.ToString("yyyy-MM-dd") & "' and commercial_oe.entry_date <='" & a.ToString("yyyy-MM-dd") & "'")
                If sql.SQLDS.Tables.Count > 0 Then
                    nb = sql.SQLDS.Tables(0).Rows.Count
                    dgoe.DataSource = sql.SQLDS.Tables(0)
                End If
            End If
            Label1.Text = ""
            If nb = 0 Then
                MessageBox.Show("il n'y a pas des donneés sur l'OE ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Label1.Text = ""
            ElseIf nb = 1 Then
                Label1.Text = "Le nombre de ligne est : " & nb
            Else
                Label1.Text = "Le nombre des lignes sont : " & nb
            End If
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub
    Sub load_chargeaffaire()
        Try
            IsConnected("SELECT distinct fullname FROM users where ((type between 20 and 21) or type=0)", False)
            If myDR.HasRows Then
                chargeaffaire.Items.Clear()
                While myDR.Read
                    chargeaffaire.Items.Add(myDR("fullname").ToString)
                End While
            End If
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub
#End Region
    Private Sub ListOE_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        If user_id = 20 Or user_id = 1 Then
            LabelX3.Visible = True
            chargeaffaire.Visible = True
        Else
            LabelX3.Visible = False
            chargeaffaire.Visible = False
        End If
        'Dim a As Date = Date.Now.Date
        'a = a.AddDays(+1)
        au.Value = Date.Now.Date
        Dim d As Date = Date.Today
        d = d.AddDays(-30)
        du.Value = d
        load_chargeaffaire()
    End Sub

    Private Sub ActualiserToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles GoogleToolStripMenuItem.Click
        Try
            If OERadio.Checked = True Then
                reload()
            Else
                reload1()
            End If
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub
    Private Sub ModifierToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ModifierToolStripMenuItem.Click
        Try
            If GridView1.SelectedRowsCount = 0 Then
                MessageBoxEx.Show("Vous devez selectionner un client avant de cliquer modifier", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                Dim frm As New OE
                frm.Text = "Modification OE de  " & GridView1.GetFocusedRowCellValue("code affaire").ToString()
                If OERadio.Checked = True Then
                    frm.idcommercialOE = GridView1.GetFocusedRowCellValue("Code OE").ToString()
                    frm.aff = GridView1.GetFocusedRowCellValue("code affaire").ToString()
                    frm.nomClient.Text = GridView1.GetFocusedRowCellValue("Nom client").ToString()
                    frm.numero.Text = GridView1.GetFocusedRowCellValue("code affaire").ToString()
                    frm.affaire.Text = GridView1.GetFocusedRowCellValue("titre").ToString()
                    frm.ButtonX6.Text = "Modifier"
                    frm.ButtonX6.Image = My.Resources.edit
                Else
                    frm.idcommercialMOE = GridView1.GetFocusedRowCellValue("Code MOE").ToString()
                    frm.aff = GridView1.GetFocusedRowCellValue("code affaire").ToString()
                    frm.numero.Text = GridView1.GetFocusedRowCellValue("code affaire").ToString()
                    frm.affaire.Text = GridView1.GetFocusedRowCellValue("titre").ToString()
                    frm.nomClient.Text = GridView1.GetFocusedRowCellValue("Nom client").ToString()
                    frm.commandecl.Text = GridView1.GetFocusedRowCellValue("N° Modification").ToString()
                    frm.ButtonX6.Text = "Modifier MOE"
                    frm.ButtonX6.Image = My.Resources.edit
                End If
                frm.MdiParent = Mainfrm
                frm.Show()
            End If
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub
    Private Sub ButtonX2_Click(sender As System.Object, e As System.EventArgs) Handles ButtonX2.Click
        If OERadio.Checked = True Then
            reload()
            ImprimerToolStripMenuItem1.Visible = True
            ImprimerModifToolStripMenuItem.Visible = False
            SupprimerToolStripMenuItem.Visible = True
            SupprimerLMOEToolStripMenuItem.Visible = False
        Else
            reload1()
            ImprimerToolStripMenuItem1.Visible = False
            ImprimerModifToolStripMenuItem.Visible = True
            SupprimerToolStripMenuItem.Visible = False
            SupprimerLMOEToolStripMenuItem.Visible = True
        End If
    End Sub

    Private Sub ImprimerToolStripMenuItem1_Click(sender As System.Object, e As System.EventArgs) Handles ImprimerToolStripMenuItem1.Click
        Try
            If GridView1.SelectedRowsCount = 0 Then
                MessageBoxEx.Show("Vous devez selectionner un code affaire avant de cliquer Imprimer OE", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                ImpressionOE.Text = "L'ordre d'execution de " & GridView1.GetFocusedRowCellValue("destinataire").ToString()
                ImpressionOE.affaire.Text = GridView1.GetFocusedRowCellValue("code affaire").ToString()
                ImpressionOE.ButtonX1.PerformClick()
                ImpressionOE.MdiParent = Mainfrm
                ImpressionOE.Show()
            End If
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub

    Private Sub ImprimerModifToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ImprimerModifToolStripMenuItem.Click
        Try
            If GridView1.SelectedRowsCount = 0 Then
                MessageBoxEx.Show("Vous devez selectionner un code affaire  avant de cliquer Imprimer MOE", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                ImpressionMOE.Text = "Modification a L'ordre d'execution de " & GridView1.GetFocusedRowCellValue("destinataire").ToString()
                ImpressionMOE.affaire.Text = GridView1.GetFocusedRowCellValue("code affaire").ToString()
                ImpressionMOE.NModifComboBoxEx1.Text = GridView1.GetFocusedRowCellValue("N° Modification").ToString()
                ImpressionOE.ButtonX1.PerformClick()
                ImpressionMOE.MdiParent = Mainfrm
                ImpressionMOE.Show()
            End If
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub

    Private Sub ButtonX1_Click(sender As System.Object, e As System.EventArgs) Handles ButtonX1.Click
        Try
            Dim s As New SaveFileDialog
            s.DefaultExt = "*.xlsx"
            s.Title = "Choisisez le nom de fichier d'enregistrement"
            s.Filter = "Excel 2010 | *.xlsx"
            If s.ShowDialog = Windows.Forms.DialogResult.OK Then
                dgoe.ExportToXlsx(s.FileName)
            End If
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub

    Private Sub OERadio_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles OERadio.CheckedChanged
        If OERadio.Checked = True Then
            dgoe.DataSource = Nothing
        End If
    End Sub

    Private Sub MOERadio_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles MOERadio.CheckedChanged
        If MOERadio.Checked = True Then
            dgoe.DataSource = Nothing
        End If
    End Sub

    Private Sub SupprimerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SupprimerToolStripMenuItem.Click
        Try
            Dim val1 As Integer = 0
            If GridView1.SelectedRowsCount = 0 Then
                MessageBoxEx.Show("Vous devez selectionner un code affaire avant de cliquer supprimer", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                Dim m = GridView1.GetFocusedRowCellValue("code affaire").ToString()
                ' Dim Nom_client = GridView1.GetFocusedRowCellValue("Nom client").ToString()
                If m <> Nothing Then
                    If MessageBoxEx.Show("Vous voullez vraiment supprimer l'ordre d'execution ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                        IsConnected("select idcommercial_OE from commercial_oe where code_affaire='" & m & "'", False)
                        'and Nom_client='" & Nom_client & "'
                        If myDR.HasRows Then
                            While myDR.Read
                                val1 = myDR("idcommercial_OE")
                            End While
                        End If
                        IsConnected("DELETE FROM commercial_oe WHERE code_affaire='" & m & "' and idcommercial_OE=" & val1 & " limit 1", True)
                        ' ButtonX3.PerformClick()
                        reload()
                    End If
                End If
            End If
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub

    Private Sub SupprimerLMOEToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SupprimerLMOEToolStripMenuItem.Click
        Try
            Dim val1 As Integer = 0
            If GridView1.SelectedRowsCount = 0 Then
                MessageBoxEx.Show("Vous devez selectionner un code affaire avant de cliquer supprimer", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                Dim m = GridView1.GetFocusedRowCellValue("code affaire").ToString()
                'Dim Nom_client = GridView1.GetFocusedRowCellValue("Nom client").ToString()
                If m <> Nothing Then
                    If MessageBoxEx.Show("Vous voullez vraiment supprimer l'ordre d'execution ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                        IsConnected("select idcommercial_MOE from commercial_moe where code_affaire='" & m & "'", False)
                        ' and Nom_client='" & Nom_client & "'
                        If myDR.HasRows Then
                            While myDR.Read
                                val1 = myDR("idcommercial_MOE")
                            End While
                        End If
                        IsConnected("DELETE FROM commercial_moe WHERE code_affaire='" & m & "' and idcommercial_MOE=" & val1 & " limit 1", True)
                        ' ButtonX3.PerformClick()
                        reload()
                    End If
                End If
            End If
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub
End Class