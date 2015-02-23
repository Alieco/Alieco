
Imports Microsoft.Office.Interop
Imports System.Threading

Public Class AdvancedSearch
    Dim sql As New SQLControl
    Dim dir As Integer = 0
    Dim fon As Integer = 0

    Private Sub AdvancedSearch_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            'Changement de la date du système
            System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.CreateSpecificCulture("en-US")
            Me.WindowState = FormWindowState.Maximized
            load_fonction()
            load_direction()
            load_region()
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub
#Region "fonctions"


    Private Sub load_fonction()
        Try
            If IsConnected("SELECT DISTINCT Fonction FROM Employes ", False) = True Then
                If myDR.HasRows = True Then
                    fonction.Items.Clear()
                    While (myDR.Read())
                        fonction.Items.Add(myDR("Fonction"))
                    End While
                End If
            End If
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub
    Private Sub load_direction()
        Try
            If IsConnected("SELECT DISTINCT Direction FROM Employes ", False) = True Then
                If myDR.HasRows = True Then
                    direction.Items.Clear()
                    While (myDR.Read())
                        direction.Items.Add(myDR("Direction"))
                    End While
                End If
            End If
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub
    Private Sub load_region()
        Try
            If IsConnected("SELECT * FROM willaya ", False) = True Then
                If myDR.HasRows = True Then
                    region.Items.Clear()
                    While (myDR.Read())
                        region.Items.Add(myDR("willaya"))
                    End While
                End If
            End If
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub
#End Region

    Private Sub ButtonX2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles searchbtn.Click
        Try
            PictureBox1.Visible = True
            searchbtn.Enabled = False
            search()
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub
    Sub search()
        Try
            dgv1.DataSource = Nothing
            GridView1.ClearDocument()
            Dim q As String = "SELECT * FROM Employes WHERE "
            If searchtxt.Text = String.Empty Then q += "1=1" Else q += "(Matricule LIKE '%" & searchtxt.Text & "%' OR Nom like '%" & searchtxt.Text & "%' OR Prénom like '%" & searchtxt.Text & "%' OR Adresse Like '%" & searchtxt.Text & "%')"
            If genre.SelectedIndex = 0 Then q += " And (Sexe = 'Monsieur' OR Sexe = 'M')" Else If genre.SelectedIndex = 1 Then q += " And (Sexe = 'F' OR Sexe ='Mademoiselle' OR Sexe ='Madame' OR Sexe='Femme')"
            If region.SelectedIndex > -1 Then q += " And Ville1 like '%" & region.Text & "%'"
            If situation.SelectedIndex = 0 Then q += " and NC='Conf'" Else If situation.SelectedIndex = 1 Then q += " And NC = 'NC'"
            If fonction.SelectedIndex > -1 Then q += " and Fonction like '%" & fonction.Text & "%'"
            If direction.SelectedIndex > -1 Then q += " and Direction  like '%" & direction.Text & "%'"
            If RadioButton2.Checked = True Then q += " ORDER BY Matricule ASC" Else If genrerd.Checked = True Then q += " ORDER BY Sexe ASC" Else If enrydate.Checked = True Then q += " ORDER BY 'Date_entrée' ASC" Else If dirrd.Checked = True Then q += " ORDER BY Direction ASC" Else If willayid.Checked = True Then q += " ORDER BY Ville ASC"
            ' searchtxt.Text = q
            Console.WriteLine(q)
            sql.RunQuery(q)
            If sql.SQLDS.Tables.Count > 0 Then dgv1.DataSource = sql.SQLDS.Tables(0)
            PictureBox1.Visible = False
            searchbtn.Enabled = True
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub

    Private Sub ButtonX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX1.Click
        Try
            'Dim rowsTotal, colsTotal As Short
            'Dim I, j, iC As Short
            'System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
            'Dim xlApp As New Excel.Application
            'Try
            '    Dim excelBook As Excel.Workbook = xlApp.Workbooks.Add
            '    Dim excelWorksheet As Excel.Worksheet = CType(excelBook.Worksheets(1), Excel.Worksheet)
            '    xlApp.Visible = True
            '    rowsTotal = GridView1.RowCount - 1
            '    colsTotal = GridView1.Columns.Count - 1
            '    With excelWorksheet
            '        .Cells.Select()
            '        .Cells.Delete()
            '        For iC = 0 To colsTotal
            '            .Cells(1, iC + 1).Value = dgv1.Columns(iC).HeaderText
            '        Next
            '        For I = 0 To rowsTotal - 1
            '            For j = 0 To colsTotal - 1
            '                .Cells(I + 2, j + 1).value = dgv1.Rows(I).Cells(j).Value
            '            Next j
            '        Next I
            '        .Rows("1:1").Font.FontStyle = "Bold"
            '        .Rows("1:1").Font.Size = 10
            '        .Cells.Columns.AutoFit()
            '        .Cells.Select()
            '        .Cells.EntireColumn.AutoFit()
            '        .Cells(1, 1).Select()
            '    End With
            'Catch ex As Exception
            '    MsgBox("Export Excel Error " & ex.Message)
            'Finally
            '    'RELEASE ALLOACTED RESOURCES
            '    System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
            '    xlApp = Nothing
            'End Try
            Dim s As New SaveFileDialog
            s.DefaultExt = "*.xlsx"
            s.Title = "Choisisez le nom de fichier d'enregistrement"
            s.Filter = "Excel 2010 | *.xlsx"
            If s.ShowDialog = Windows.Forms.DialogResult.OK Then
                dgv1.ExportToXlsx(s.FileName)
            End If
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub
End Class