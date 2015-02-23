Imports DevComponents.DotNetBar
Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient
Imports DevExpress.XtraGrid.Views.Grid
Imports DevComponents.Editors.DateTimeAdv

Public Class ListOffre
    Public code As String = ""
    Public varc As String = ""
    Dim sql As New SQLControl
    Private dt As DataTable
    Sub reload()
        Try
            Dim s As String = ""
            Dim s1 As String = ""
            Dim utilisateur As String = ""
            dt = New DataTable
            dt.Columns.Add("Code")
            dt.Columns.Add("Client")
            dt.Columns.Add("Chargé d'affaire")
            dt.Columns.Add("Date de transm. de l'offre")
            dt.Columns.Add("Désignation")
            dt.Columns.Add("Montant de l'offre")
            dt.Columns.Add("Montant Confirmé")
            dt.Columns.Add("Situation de l'offre")
            dt.Columns.Add("Statut de l'offre")
            Dim i = 0
            Dim d As Date = au.Value.ToString("yyyy-MM-dd")
            d = d.AddDays(1)
            If user_id = 20 Or user_id = 1 Then
                If chargeaffaire.Text = "" Then
                    utilisateur = ""
                Else
                    utilisateur = "and fullname= '" & chargeaffaire.Text & "'"
                End If
            Else
                utilisateur = " and users.user_id= '" & user_id & "'"
            End If
            If IsConnected("SELECT DISTINCT commercial_offre.code,commercial_offre.nomcl,fullname,commercial_offre.entréedate,Qt,desig,code_affaire,commercial_offre_bordereauprix.totalttc,valide FROM commercial_offre,commercial_offre_bordereauprix,users WHERE commercial_offre.code=commercial_offre_bordereauprix.code and commercial_offre.charge_affaire=users.user_id " & utilisateur & " and commercial_offre.entréedate between '" & du.Value.ToString("yyyy-MM-dd") & "' and '" & d.ToString("yyyy-MM-dd") & "' group by commercial_offre.code", False) = True Then
                If myDR.HasRows = True Then
                    While myDR.Read
                        'MsgBox(myDR("code_affaire"))
                        Dim row As DataRow = dt.NewRow()
                        row(0) = myDR("code").ToString
                        row(1) = myDR("nomcl").ToString
                        row(2) = myDR("fullname").ToString
                        row(3) = myDR("entréedate").ToString
                        Dim g As New DateTimePicker
                        g.Value = row(3)
                        'g.Format = DateFormat.LongDate
                        row(3) = g.Value.ToString("dddd dd MMMM yyyy")
                        s = myDR("code_affaire").ToString
                        If s = "" Then
                            s1 = " En attente "
                            row(4) = ""
                        Else
                            s1 = " Confirmer "
                            row(4) = ""
                        End If
                        row(5) = myDR("totalttc").ToString
                        row(6) = ""
                        row(7) = s1
                        If myDR("valide") = "0" Then
                            row(8) = "Non validé"
                            'Image.FromFile("")
                        Else
                            row(8) = "validé"
                        End If
                        dt.Rows.Add(row)
                        i += 1
                    End While
                End If
            End If
            dgoffre.DataSource = dt
            For i = 0 To GridView1.DataRowCount - 1
                    Dim code As String = GridView1.GetRowCellValue(i, "Code").ToString()
                    Dim sit As String = GridView1.GetRowCellValue(i, "Situation de l'offre").ToString()
                    If sit = " Confirmer " Then
                        IsConnected("SELECT distinct totalttc,desig, Qt from commercial_affaire_bordereauprix,commercial_affaire,commercial_offre WHERE commercial_affaire.code=commercial_offre.code and commercial_affaire.code_affaire=commercial_affaire_bordereauprix.code and commercial_offre.code='" & code & "'", False)
                    Else
                        IsConnected("SELECT '' as 'totalttc',desig, Qt from commercial_offre_bordereauprix,commercial_offre WHERE commercial_offre.code=commercial_offre_bordereauprix.code  and commercial_offre.code='" & code & "'", False)
                    End If
                    If myDR.HasRows Then
                        While myDR.Read
                            GridView1.SetRowCellValue(i, "Montant Confirmé", IIf(myDR("totalttc").ToString = "", "", myDR("totalttc").ToString))
                            GridView1.SetRowCellValue(i, "Désignation", GridView1.GetRowCellValue(i, "Désignation") & IIf(GridView1.GetRowCellValue(i, "Désignation") = "", "", " + ") & IIf(myDR("Qt").ToString = "", 0, myDR("qt").ToString & " " & myDR("desig").ToString))
                        End While
                    End If
            Next
            'If IsConnected("SELECT * FROM commercial_offre_bordereauprix ", False) Then
            '    If myDR.HasRows Then

            '    End If
            'End If
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub
    Private Sub GridView1_RowCellStyle(ByVal sender As Object, ByVal e As RowCellStyleEventArgs) Handles GridView1.RowCellStyle
        Try
            Dim View As GridView = sender
            If e.Column.FieldName = "Situation de l'offre" Then
                Dim situation As String = View.GetRowCellDisplayText(e.RowHandle, View.Columns("Situation de l'offre"))
                If situation = " Confirmer " Then
                    e.Appearance.BackColor = Color.Lime
                    e.Appearance.BackColor2 = Color.LightGreen
                Else : e.Appearance.BackColor = Color.Yellow
                    e.Appearance.BackColor2 = Color.LightYellow
                End If
            End If
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub
    Private Sub ButtonX2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX2.Click
        Try
            reload()
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub
    Private Sub GoogleToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GoogleToolStripMenuItem.Click
        Try
            reload()
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub

    Private Sub ListOffre_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            If user_id = 20 Or user_id = 1 Then
                LabelX3.Visible = True
                chargeaffaire.Visible = True
                ValiderLoffreToolStripMenuItem.Visible = True
            Else
                LabelX3.Visible = False
                chargeaffaire.Visible = False
                ValiderLoffreToolStripMenuItem.Visible = False
            End If
            IsConnected("SELECT * FROM commercial_offre WHERE valide='1'", False)
            If myDR.HasRows = True Then
                SupprimerOffreToolStripMenuItem.Enabled = False
                ModifierOffreToolStripMenuItem.Enabled = False
            End If

            au.Value = Date.Now.Date
            Dim d As Date = Date.Today
            d = d.AddDays(-30)
            du.Value = d
            If GridView1.SelectedRowsCount > 0 Then
                SupprimerOffreToolStripMenuItem.Enabled = True
                ModifierOffreToolStripMenuItem.Enabled = True
            Else
                SupprimerOffreToolStripMenuItem.Enabled = False
                ModifierOffreToolStripMenuItem.Enabled = False
            End If
            IsConnected("SELECT distinct fullname FROM commercial_offre,users WHERE commercial_offre.charge_affaire=users.user_id", False)
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
    Private Sub ButtonX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX1.Click
        Try
            Dim s As New SaveFileDialog
            s.DefaultExt = "*.xlsx"
            s.Title = "Choisisez le nom de fichier d'enregistrement"
            s.Filter = "Excel 2010 | *.xlsx"
            If s.ShowDialog = Windows.Forms.DialogResult.OK Then
                dgoffre.ExportToXlsx(s.FileName)
            End If
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub
    Private Sub AjouterUnNouveauOffreToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AjouterUnNouveauOffreToolStripMenuItem.Click
        Try
            AjoutOffre.MdiParent = Mainfrm
            AjoutOffre.Show()
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub
    Private Sub ModifierOffreToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ModifierOffreToolStripMenuItem.Click
        Try
            If GridView1.SelectedRowsCount = 0 Then
                MessageBoxEx.Show("Vous devez selectionner une offre avant de cliquer modifier", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                Dim vald
                code = GridView1.GetFocusedRowCellValue("Code").ToString()
                IsConnected("SELECT valide FROM commercial_offre WHERE code='" & code & "'", False)
                If myDR.HasRows Then
                    While myDR.Read
                        vald = myDR("valide")
                    End While
                End If
                If user_id <> 20 Then
                    If vald = "0" Then
                        EditOffre.Text = "Modification Offre " & GridView1.GetFocusedRowCellValue("Code").ToString()
                        code = GridView1.GetFocusedRowCellValue("Code").ToString()
                        'EditOffre.code.Text = GridView1.GetFocusedRowCellValue("code").ToString()
                        EditOffre.MdiParent = Mainfrm
                        EditOffre.Show()
                    Else
                        MessageBoxEx.Show("L'offre est validée " & Environment.NewLine & "Vous ne pouvez pas faire des mofications", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                Else
                    EditOffre.Text = "Modification Offre " & GridView1.GetFocusedRowCellValue("Code").ToString()
                    code = GridView1.GetFocusedRowCellValue("Code").ToString()
                    'EditOffre.code.Text = GridView1.GetFocusedRowCellValue("code").ToString()
                    EditOffre.MdiParent = Mainfrm
                    EditOffre.Show()
                End If
            End If
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub

    Private Sub SupprimerOffreToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SupprimerOffreToolStripMenuItem.Click
        Try
            If GridView1.SelectedRowsCount = 0 Then
                MessageBoxEx.Show("Vous devez selectionner une offre avant de cliquer supprimer", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                Dim m = GridView1.GetFocusedRowCellValue("Code").ToString()
                Dim vald
                IsConnected("SELECT valide FROM commercial_offre WHERE code='" & m & "'", False)
                If myDR.HasRows Then
                    While myDR.Read
                        vald = myDR("valide")
                    End While
                End If
                If m <> Nothing Then
                    If user_id <> 20 Then
                        If vald = "0" Then
                            If MessageBoxEx.Show("Vous voullez vraiment supprimer l'offre ?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                                IsConnected("Delete from commercial_offre WHERE code =" & m & " limit 1", True)
                                IsConnected("Delete from commercial_offre_bordereauprix WHERE code =" & m & " ", True)
                                IsConnected("Delete from commercial_offre_modalite WHERE code =" & m & " ", True)
                                IsConnected("Delete from commercial_offre_prestation WHERE code =" & m & " ", True)
                                reload()
                            End If
                        Else
                            MessageBoxEx.Show("         L'offre est validée " & Environment.NewLine & "  Vous ne pouvez pas supprimer l'affaire", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        End If
                    Else
                        If MessageBoxEx.Show("Vous voullez vraiment supprimer l'offre ?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                            IsConnected("Delete from commercial_offre WHERE code =" & m & " limit 1", True)
                            IsConnected("Delete from commercial_offre_bordereauprix WHERE code =" & m & " ", True)
                            IsConnected("Delete from commercial_offre_modalite WHERE code =" & m & " ", True)
                            IsConnected("Delete from commercial_offre_prestation WHERE code =" & m & " ", True)
                            reload()
                        End If
                    End If
                End If
                End If
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub

    Private Sub ImprimerOffreToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ImprimerOffreToolStripMenuItem1.Click
        Try
            If GridView1.SelectedRowsCount = 0 Then
                MessageBoxEx.Show("Vous devez selectionner une offre avant de cliquer Imprimer", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                ' MsgBox("Message1: " & GridView1.GetFocusedRowCellValue("Code").ToString())
                code = GridView1.GetFocusedRowCellValue("Code").ToString()
                ImprimerOffre.Text = "Fiche de l'Offre " & GridView1.GetFocusedRowCellValue("Code").ToString()
                'MsgBox("Message2: " & GridView1.GetRowCellValue(0, "Code").ToString())
                'RapportOffre.nrc.Text = GridView1.GetRowCellValue(0, "code").ToString()
                ImprimerOffre.MdiParent = Mainfrm
                ImprimerOffre.Show()
            End If
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub

    Private Sub GridView1_FocusedRowChanged(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles GridView1.FocusedRowChanged
        Try
            If GridView1.SelectedRowsCount > 0 Then
                Dim etat = GridView1.GetFocusedRowCellValue("Situation de l'offre").ToString()
                If etat.Contains("Confirmer") Then
                    ConvertitLoffreEnAffaireToolStripMenuItem.Enabled = False
                    ModifierOffreToolStripMenuItem.Enabled = False
                    SupprimerOffreToolStripMenuItem.Enabled = False
                Else
                    ConvertitLoffreEnAffaireToolStripMenuItem.Enabled = True
                    ModifierOffreToolStripMenuItem.Enabled = True
                    SupprimerOffreToolStripMenuItem.Enabled = True
                End If
                'SupprimerOffreToolStripMenuItem.Enabled = True
                'ModifierOffreToolStripMenuItem.Enabled = True
            Else
                SupprimerOffreToolStripMenuItem.Enabled = False
                ModifierOffreToolStripMenuItem.Enabled = False
                ConvertitLoffreEnAffaireToolStripMenuItem.Enabled = False
            End If
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub
    'Private Sub load_CodeTitreNomClient()
    '    If IsConnected("SELECT DISTINCT code,titre,nomcl FROM commercial_offre ", False) = True Then
    '        If myDR.HasRows = True Then
    '            ctn.Items.Clear()
    '            While (myDR.Read())
    '                ctn.Items.Add(myDR("code") & "-" & myDR("titre") & "-" & myDR("nomcl"))
    '            End While
    '        End If
    '    End If
    'End Sub
    Private Sub RelancéLoffreToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Dim c As String = ""
            Dim titre = GridView1.GetFocusedRowCellValue("titre").ToString()
            Dim client = GridView1.GetFocusedRowCellValue("nomcl").ToString()
            IsConnected("select code,relance from commercial_offre where titre = '" & titre & "' and nomcl= '" & client & "'", False)
            If myDR.HasRows Then
                While myDR.Read
                    c = myDR("code")
                End While
            End If
            IsConnected("UPDATE commercial_offre SET relance = 1 WHERE code = '" & c & "' limit 1", True)
            MessageBox.Show("Relance avec succée!")
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub
    Private Sub ConvertitLoffreEnAffaireToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConvertitLoffreEnAffaireToolStripMenuItem.Click
        Try
            '  MsgBox(CLng(DateTime.UtcNow.Subtract(New DateTime(1970, 1, 1)).TotalMilliseconds))
            If MessageBoxEx.Show("etes vous sure de vouloir convertir l'offre en affaire ", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                code = GridView1.GetFocusedRowCellValue("Code").ToString()
                EtatAffaire.Text = "Conversion de l'Offre " & GridView1.GetRowCellValue(0, "Code").ToString() & " en affaire"
                'RapportOffre.nrc.Text = GridView1.GetRowCellValue(0, "code").ToString()
                EtatAffaire.MdiParent = Mainfrm
                EtatAffaire.Show()
            End If
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub
    Private Sub ValiderLoffreToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ValiderLoffreToolStripMenuItem.Click
        If MessageBoxEx.Show("etes vous sure de vouloir valider l'offre ", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            code = GridView1.GetFocusedRowCellValue("Code").ToString()
            If IsConnected("UPDATE `commercial_offre` SET `valide` = '1' WHERE `code` ='" & code & "';", True) Then
                MessageBoxEx.Show("L'offre est validé", "Succée", MessageBoxButtons.OK, MessageBoxIcon.Information)
                reload()
            End If
        End If
    End Sub
End Class