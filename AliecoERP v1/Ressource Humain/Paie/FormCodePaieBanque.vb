Imports DevComponents.DotNetBar

Public Class FormCodePaieBanque
    Dim Sql As New SQLControl
    'Private Sub load_code1()
    '    If IsConnected("SELECT DISTINCT Code FROM codepaie ", False) = True Then
    '        If myDR.HasRows = True Then

    '            While (myDR.Read())

    '                code3.Items.Add(myDR("Code"))
    '            End While
    '        End If
    '    End If
    'End Sub

    Private Sub ButtonX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        If code1.Text <> "" And libelle1.Text <> "" Then
            Dim q = ""
            If BtnSave.Text = "Ajouter" Then
                q = "INSERT INTO paie_banque(codtab,libtab)VALUES('" & mysql_escape_string(code1.Text) & "','" & mysql_escape_string(libelle1.Text) & "')"
            Else
                q = "UPDATE paie_banque SET codtab='" & mysql_escape_string(code1.Text) & "',libtab='" & mysql_escape_string(libelle1.Text) & "' WHERE codtab='" & mysql_escape_string(code1.Text) & "'"
            End If

            If IsConnected(q, True) Then
                MessageBoxEx.Show("La Banque a bien été enregistrer", "Succés", MessageBoxButtons.OK, MessageBoxIcon.Information)
                code1.Text = ""
                libelle1.Text = ""
                loadBank()

            End If
        End If

    End Sub


    Private Sub ButtonX2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub

    Private Sub FormCodePaieBanque_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        loadBank()
    End Sub
    Private Sub loadBank()
        Sql.RunQuery("select codtab,libtab from paie_banque")

        If Sql.SQLDS.Tables.Count > 0 Then
            CPdg.DataSource = Sql.SQLDS.Tables(0)
        End If
    End Sub

    Private Sub code1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles code1.TextChanged
        If code1.Text.Length > 0 Then
            IsConnected("select * from paie_banque where codtab='" & mysql_escape_string(code1.Text) & "' LIMIT 1", False)
            If myDR.HasRows = True Then
                While (myDR.Read())
                    libelle1.Text = myDR("libtab")
                    BtnSave.Text = "Modifier le Code : " & code1.Text
                    ' BtnSave.Image = My.Resources.bank_edit1
                End While
            Else
                libelle1.Text = ""
                BtnSave.Text = "Ajouter"
                'BtnSave.Image = My.Resources.bank_add
            End If
        Else
            libelle1.Text = ""
            BtnSave.Text = "Ajouter"
            ' BtnSave.Image = My.Resources.bank_add
        End If
    End Sub


    Private Sub ModifierCetteBanqueToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ModifierCetteBanqueToolStripMenuItem.Click
        If GridView1.SelectedRowsCount = 0 Then
            MessageBoxEx.Show("Vous devez selectionner une banque avant de cliquer modifier", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            code1.Text = GridView1.GetFocusedRowCellValue("codtab").ToString()
        End If
    End Sub

    Private Sub SupprimerCetteBanqueToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SupprimerCetteBanqueToolStripMenuItem.Click
        If GridView1.SelectedRowsCount = 0 Then
            MessageBoxEx.Show("Vous devez selectionner une banque avant de cliquer supprimer", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            If MessageBoxEx.Show("Voullez vous supprimer cette banque : " & Environment.NewLine & GridView1.GetFocusedRowCellValue("codtab").ToString() & " - " & GridView1.GetFocusedRowCellValue("libtab").ToString(), "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = MsgBoxResult.Yes Then
                Dim q As String = "DELETE FROM paie_banque WHERE codtab='" & GridView1.GetFocusedRowCellValue("codtab").ToString() & "' LIMIT 1"

                If IsConnected(q, True) Then
                    MessageBoxEx.Show("La banque a bien été supprimer", "Succés", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    code1.Text = ""
                    loadBank()
                End If
                
            End If

        End If
    End Sub
End Class