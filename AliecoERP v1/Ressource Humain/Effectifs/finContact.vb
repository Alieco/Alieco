Imports DevComponents.DotNetBar
Imports DevExpress.XtraGrid.Views.Grid

Public Class finContact
    Dim Sql As New SQLControl


    Sub ContractCheck()
        Try
            If Sql.VerifiyConnection = True Then
                Sql.RunQuery("SELECT Matricule,Nom,Prénom,Fonction,Direction,DATEDIFF(STR_TO_DATE(Date_fin_de_contrat, '%d-%m-%Y'),NOW()) as 'Jours restants' FROM employes WHERE DATEDIFF(STR_TO_DATE(Date_fin_de_contrat, '%d-%m-%Y'),NOW()) > 0 ORDER BY Date_fin_de_contrat ASC")
                If Sql.SQLDS.Tables.Count > 0 Then
                    If Sql.SQLDS.Tables(0).Rows.Count > 0 Then
                        GridControl1.DataSource = Sql.SQLDS.Tables(0)
                    Else
                        MessageBoxEx.Show("Vous n'avez pas des employes qui ont une fin de contact", "Liste Vide", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                End If
            End If
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub

    Private Sub finContact_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ContractCheck()
        ColorCombControl1.BackColor = Color.FromArgb(192, 57, 43)
        ColorCombControl2.BackColor = Color.FromArgb(231, 76, 60)
        ColorCombControl3.BackColor = Color.FromArgb(39, 174, 96)
        ColorCombControl4.BackColor = Color.FromArgb(46, 204, 113)
    End Sub

    Private Sub GridView1_RowStyle(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs) Handles GridView1.RowStyle
        Try
            '< GridView1.SelectedRowsCount - 1
            Dim View As GridView = sender
            If (e.RowHandle >= 0) Then
                Dim j As String = View.GetRowCellDisplayText(e.RowHandle, View.Columns("Jours restants"))
                If (j <= CInt(10)) Then
                    e.Appearance.BackColor = Color.FromArgb(192, 57, 43)
                End If
                If (j > CInt(10)) Then
                    e.Appearance.BackColor = Color.FromArgb(231, 76, 60)
                End If
                If (j > CInt(20)) Then
                    e.Appearance.BackColor = Color.FromArgb(39, 174, 96)
                End If
                If (j > CInt(30)) Then
                    e.Appearance.BackColor = Color.FromArgb(46, 204, 113)
                End If
            End If
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub

    Private Sub ConfirmerCetteEmployéToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConfirmerCetteEmployéToolStripMenuItem.Click
        Try
            If GridView1.SelectedRowsCount = 0 Then
            Else
                If MessageBoxEx.Show("Voullez vous confirmer cette employé :" & Environment.NewLine & GridView1.GetFocusedRowCellValue("Nom").ToString() & " " & GridView1.GetFocusedRowCellValue("Prénom").ToString(), "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                    'EditOffre.Text =  & GridView1.GetFocusedRowCellValue("Matricule").ToString()
                    'EditOffre.MdiParent = Mainfrm
                    'EditOffre.Show()
                End If
            End If
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub
End Class