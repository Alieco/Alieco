Imports DevComponents.DotNetBar

Public Class ListFournisseur
    Dim sql As New SQLControl
    Dim form As New AjoutFourniss
    Sub reload()
        If sql.VerifiyConnection = True Then
            sql.RunQuery("select code,nomfourn,adress,ville,tel,mail,fax,type from logistique_appro_fournis")
            If sql.SQLDS.Tables.Count > 0 Then
                DGfournisseur.DataSource = sql.SQLDS.Tables(0)
            End If
        End If
    End Sub
    Private Sub GoogleToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles GoogleToolStripMenuItem.Click
        reload()
    End Sub

    Private Sub AjouterToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles AjouterToolStripMenuItem.Click
        Dim frm As AjoutFourniss = New AjoutFourniss
        frm.ShowDialog()
    End Sub

    Private Sub ModifierOffreToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ModifierOffreToolStripMenuItem.Click
        If GridView1.SelectedRowsCount = 0 Then
            MessageBoxEx.Show("Vous devez selectionner une fournisseur avant de cliquer modifier", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            Dim frm As AjoutFourniss = New AjoutFourniss
            frm.code.Text = GridView1.GetFocusedRowCellValue("code").ToString()
            frm.code1 = GridView1.GetFocusedRowCellValue("code").ToString()
            frm.nomfourn.Text = GridView1.GetFocusedRowCellValue("nomfourn").ToString()
            frm.ads.Text = GridView1.GetFocusedRowCellValue("adress").ToString()
            frm.willaya.Text = GridView1.GetFocusedRowCellValue("ville").ToString()
            frm.tel.Text = GridView1.GetFocusedRowCellValue("tel").ToString()
            frm.mail.Text = GridView1.GetFocusedRowCellValue("mail").ToString()
            frm.fax.Text = GridView1.GetFocusedRowCellValue("fax").ToString()
            frm.type.Text = GridView1.GetFocusedRowCellValue("type").ToString()
            frm.ajout.Text = "Modifier"
            frm.Text = "Modifier un Fournisseur"
            frm.GroupBox1.Text = "Modifier le code de fournisseur " & GridView1.GetFocusedRowCellValue("code").ToString()
            frm.ajout.Image = My.Resources.edit
            frm.ShowDialog()
        End If
    End Sub

    Private Sub SupprimerOffreToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles SupprimerOffreToolStripMenuItem.Click
        If GridView1.SelectedRowsCount = 0 Then
            MessageBoxEx.Show("Vous devez selectionner un fournisseur avant de cliquer supprimer", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            Dim m = GridView1.GetFocusedRowCellValue("code").ToString()
            If m <> Nothing Then
                If MessageBoxEx.Show("Vous voullez vraiment supprimer le fournisseur ?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                    IsConnected("Delete from logistique_appro_fournis WHERE code =" & m & " limit 1", True)
                    reload()
                End If
            End If
        End If
    End Sub

    Private Sub ButtonX2_Click(sender As System.Object, e As System.EventArgs) Handles ButtonX2.Click
        reload()
    End Sub

    Private Sub ButtonX1_Click(sender As System.Object, e As System.EventArgs) Handles ButtonX1.Click
        Dim s As New SaveFileDialog
        s.DefaultExt = "*.xlsx"
        s.Title = "Choisissez le nom de fichier d'enregistrement"
        s.Filter = "Excel 2010 | *.xlsx"
        If s.ShowDialog = Windows.Forms.DialogResult.OK Then
            DGfournisseur.ExportToXlsx(s.FileName)
        End If
    End Sub
End Class