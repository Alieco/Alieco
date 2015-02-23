Imports DevExpress.XtraEditors.Repository
Imports DevComponents.DotNetBar

Public Class listVihecule
    Private Function CreateTable() As DataTable
        Dim tbl As New DataTable()
        tbl.Columns.Add("ID", GetType(Integer))
        tbl.Columns.Add("Nom de vihecule", GetType(String))
        tbl.Columns.Add("Marque", GetType(String))
        tbl.Columns.Add("Matricule", GetType(String))
        tbl.Columns.Add("Remarque", GetType(String))
        tbl.Columns.Add("Energie", GetType(String))
        tbl.Columns.Add("Date d'enregistrement", GetType(DateTime))
        'tbl.Columns.Add("Image", GetType(Image))
        If IsConnected("SELECT * FROM logistique_parc_vihecule", False) Then
            If myDR.HasRows Then
                While myDR.Read
                    'Dim lb() As Byte = myDR("photo")
                    'Dim im As Image = Nothing
                    ''If lb.Length > 0 Then
                    'Dim lstr As New System.IO.MemoryStream(lb)
                    'Console.WriteLine(lb(0))
                    'im = Image.FromStream(lstr)
                    'lstr.Close()
                    'End If

                    tbl.Rows.Add(New Object() {myDR("id").ToString, myDR("nom").ToString, myDR("marque").ToString, myDR("matricule").ToString, myDR("remarque").ToString, myDR("energie").ToString, myDR("entry_date").ToString})
                End While
            End If

        End If

        Return tbl
    End Function

    Private Sub listVihecule_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        GridVihecules.DataSource = CreateTable()
        'GridView1.Columns("Image").ColumnEdit = New RepositoryItemPictureEdit()
    End Sub

    Private Sub GridView1_FocusedRowChanged(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles GridView1.FocusedRowChanged

    End Sub

    Private Sub TextBoxX1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SearchTxt.TextChanged
        GridView1.FindFilterText = SearchTxt.Text
    End Sub

    Private Sub ButtonX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX1.Click
        Dim s As New SaveFileDialog
        s.DefaultExt = "*.xlsx"
        s.Title = "Choisissez le nom de fichier d'enregistrement"
        s.Filter = "Excel 2010 | *.xlsx"
        If s.ShowDialog = Windows.Forms.DialogResult.OK Then
            GridVihecules.ExportToXlsx(s.FileName)
        End If
    End Sub

    Private Sub ModifierCeVihéculeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ModifierCeVihéculeToolStripMenuItem.Click
        If GridView1.SelectedRowsCount = 0 Then
            MessageBoxEx.Show("Vous devez selectionner un vihécule avant de cliquer modifier", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            Dim f As New AjoutVihecule
            f.id = GridView1.GetFocusedRowCellValue("ID").ToString()
            f.Text = "Modifier le vihécule"
            f.MdiParent = Mainfrm
            f.Show()
        End If
    End Sub

    Private Sub SupprimerCeVihéculeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SupprimerCeVihéculeToolStripMenuItem.Click
        If GridView1.SelectedRowsCount = 0 Then
            MessageBoxEx.Show("Vous devez selectionner un vihécule avant de cliquer supprimer", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            If MessageBoxEx.Show("Voullez vous vraiment supprimer cevihécule ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                IsConnected("DELETE FROM `logistique_parc_vihecule` WHERE id = " & GridView1.GetFocusedRowCellValue("ID").ToString() & " limit 1; ", True)
                MessageBoxEx.Show("le vihécule est supprimé ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                GridVihecules.DataSource = CreateTable()
            End If

            
        End If
    End Sub

    Private Sub GridView1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GridView1.Click
        If GridView1.SelectedRowsCount <> 0 Then
            LabelControl1.Text = ""
            LabelControl2.Text = ""
            LabelControl3.Text = ""
            linkControl6.Text = ""
            LabelControl5.Text = ""
            LabelControl4.Text = ""
            Dim im As Image = Nothing
            ViheculeImg.Image = im
            If GridView1.GetFocusedRowCellValue("Matricule").ToString() <> "" Then
                If IsConnected("SELECT * FROM logistique_parc_vihecule WHERE matricule='" & GridView1.GetFocusedRowCellValue("Matricule").ToString() & "' LIMIT 1", False) Then
                    If myDR.HasRows Then
                        While myDR.Read

                            If Not IsDBNull(myDR("photo")) Then
                                Dim lb() As Byte = myDR("photo")
                                Dim lstr As New System.IO.MemoryStream(lb)
                                ViheculeImg.Image = Image.FromStream(lstr)
                                lstr.Close()
                            End If
                            LabelControl1.Text = myDR("nom").ToString
                            LabelControl2.Text = myDR("marque").ToString
                            LabelControl3.Text = myDR("matricule").ToString
                            linkControl6.Text = myDR("remarque").ToString
                            LabelControl5.Text = myDR("energie").ToString
                            LabelControl4.Text = myDR("entry_date").ToString
                        End While
                    End If

                End If
            End If

        End If
    End Sub
End Class