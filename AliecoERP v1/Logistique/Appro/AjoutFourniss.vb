Imports DevComponents.DotNetBar

Public Class AjoutFourniss
    Dim Sql As New SQLControl
    Dim a As Integer
    Public code1 As String = ""
#Region "Loading"
    Private Sub load_ville()
        If IsConnected("SELECT * FROM willaya ", False) = True Then
            If myDR.HasRows = True Then
                willaya.Items.Clear()
                While (myDR.Read())
                    willaya.Items.Add(myDR("willaya"))
                End While
            End If
        End If
    End Sub
    Private Sub load_type()
        If IsConnected("SELECT distinct type FROM logistique_appro_fournis ", False) = True Then
            If myDR.HasRows = True Then
                type.Items.Clear()
                While (myDR.Read())
                    type.Items.Add(myDR("type"))
                End While
            End If
        End If
    End Sub
#End Region
    Private Sub ajout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ajout.Click
        If ajout.Text = "Ajouter" Then
            IsConnected(" select * from logistique_appro_fournis WHERE  code='" & code.Text & "'", False)
            If myDR.HasRows = True Then
                While (myDR.Read())
                    MessageBoxEx.Show("le * '" & myDR("nomfourn") & "' * existe déja dans la liste des fournisseurs", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End While
            End If
            If nomfourn.Text = "" Then
                MessageBoxEx.Show("Vous avez laissé le nom de fournisseur vide !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            Dim q = "INSERT INTO logistique_appro_fournis values (NULL,'" & code.Text & "', '" & mysql_escape_string(nomfourn.Text) & "', '" & mysql_escape_string(ads.Text) & "', '" & mysql_escape_string(willaya.Text) & "' , '" & mysql_escape_string(tel.Text).Replace("/", "-") & "', '" & mysql_escape_string(mail.Text) & "', '" & mysql_escape_string(fax.Text).Replace("/", "-") & "', '" & mysql_escape_string(type.Text) & "')"
            If IsConnected(q, False) = True Then
                MessageBoxEx.Show("Le fournisseur a bien été enregistré", "Succés", MessageBoxButtons.OK, MessageBoxIcon.Information)
                IsConnected("select MAX(code) as Code from logistique_appro_fournis ", False)
                If myDR.HasRows = True Then
                    While (myDR.Read())
                        code.Text = myDR("Code") + 1
                    End While
                End If
                nomfourn.Text = ""
                ads.Text = ""
                willaya.Text = ""
                tel.Text = ""
                mail.Text = ""
                fax.Text = ""
                type.Text = ""
                Sql.RunQuery("select code,nomfourn,adress,ville,tel,mail,fax,type from logistique_appro_fournis")
                If Sql.SQLDS.Tables.Count > 0 Then
                    DGcf.DataSource = Sql.SQLDS.Tables(0)
                End If
            End If
        ElseIf ajout.Text = "Modifier" Then
            IsConnected("Delete from logistique_appro_fournis WHERE code =" & code1 & " limit 1", True)
            ' Dim q = "update logistique_appro_fournis set nomfourn='" & mysql_escape_string(nomfourn.Text) & "', adress='" & mysql_escape_string(ads.Text) & "', ville= '" & mysql_escape_string(willaya.Text) & "', tel= '" & mysql_escape_string(tel.Text) & "', mail= '" & mysql_escape_string(mail.Text) & "', fax= '" & mysql_escape_string(fax.Text) & "', type= '" & mysql_escape_string(type.Text) & "' where code= '" & code.Text & "'"
            IsConnected("SELECT * from logistique_appro_fournis where code='" & code.Text & "'", False)
            If myDR.HasRows = True Then
                MessageBoxEx.Show("Le code existe deja veuillez choisir un autre code", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If
            Dim q = "INSERT INTO logistique_appro_fournis  values (NULL, " & code.Text & " , '" & mysql_escape_string(nomfourn.Text) & "', '" & mysql_escape_string(ads.Text) & "', '" & mysql_escape_string(willaya.Text) & "' , '" & mysql_escape_string(tel.Text) & "', '" & mysql_escape_string(mail.Text) & "', '" & mysql_escape_string(fax.Text) & "', '" & mysql_escape_string(type.Text) & "')"
            If IsConnected(q, True) = True Then
                MessageBoxEx.Show("Le fournisseur a bien été Modifié", "Succés", MessageBoxButtons.OK, MessageBoxIcon.Information)
                IsConnected("select MAX(code) as Code from logistique_appro_fournis ", False)
                If myDR.HasRows = True Then
                    While (myDR.Read())
                        code.Text = myDR("Code") + 1
                    End While
                End If
                nomfourn.Text = ""
                ads.Text = ""
                willaya.Text = ""
                tel.Text = ""
                mail.Text = ""
                fax.Text = ""
                type.Text = ""
                ajout.Text = "Ajouter"
                ajout.Image = My.Resources.add
                Sql.RunQuery("select code,nomfourn,adress,ville,tel,mail,fax,type from logistique_appro_fournis")
                If Sql.SQLDS.Tables.Count > 0 Then
                    DGcf.DataSource = Sql.SQLDS.Tables(0)
                End If
                Me.Close()
            End If
        End If
    End Sub

    Private Sub AjoutFourniss_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        IsConnected("select MAX(code) as Code from logistique_appro_fournis ", False)
        If myDR.HasRows = True Then
            While (myDR.Read())
                a = myDR("Code")
            End While
        End If
        If code.Text = "" Then
            code.Text = a + 1
        End If
        load_ville()
        load_type()
        recherche()
    End Sub

    Private Sub boutrech_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles boutrech.Click
        PictureBox1.Visible = True
        boutrech.Enabled = False
        recherche()
    End Sub

    Private Sub recherche()
        DGcf.DataSource = Nothing
        GridView1.ClearDocument()
        Dim q As String = "SELECT code,nomfourn,adress,ville,tel,mail,fax,type FROM logistique_appro_fournis WHERE "
        If nomfourech.Text = String.Empty Then q += "1=1" Else q += "(code LIKE '%" & nomfourech.Text & "%' OR nomfourn like '%" & nomfourech.Text & "%')"
        Sql.RunQuery(q)
        If Sql.SQLDS.Tables(0).Rows.Count > 0 Then
            DGcf.DataSource = Sql.SQLDS.Tables(0)
        Else : MessageBoxEx.Show("Aucun fournisseur trouvé", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        PictureBox1.Visible = False
        boutrech.Enabled = True
    End Sub

    Private Sub GridView1_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GridView1.DoubleClick
        BonCommande.codefour.Text = GridView1.GetFocusedRowCellValue("code").ToString()
        Me.Close()
    End Sub

    Private Sub nomfourech_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nomfourech.TextChanged
        GridView1.FindFilterText = nomfourech.Text
        'If GridView1.DataRowCount = 0 Then
        '    MsgBox("erreur")
        'End If
    End Sub
End Class