Imports DevComponents.DotNetBar
Imports System.IO

Public Class AjoutVihecule
    Public id As Integer = 0





    Private Sub AjoutBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AjoutBtn.Click
        If NomTxt.Text <> String.Empty And MarkTxt.Text <> String.Empty And MatriculeTxt.Text <> String.Empty And discriTxt.Text <> String.Empty And EngineCmb.SelectedIndex <> -1 Then
            If pathTxt.Text = String.Empty Then
                If id > 0 Then
                    If IsConnected("UPDATE logistique_parc_vihecule SET `nom`='" & mysql_escape_string(NomTxt.Text) & "',`marque`='" & mysql_escape_string(MarkTxt.Text) & "',`matricule`='" & mysql_escape_string(MatriculeTxt.Text) & "',`remarque`='" & mysql_escape_string(discriTxt.Text) & "',`energie`='" & mysql_escape_string(EngineCmb.Text) & "',`entry_date`=NOW() WHERE id=" & id & " LIMIT 1;", True) Then
                        MessageBoxEx.Show("Enregistré avec succés ", "Succés", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Me.Close()
                    End If
                Else
                    If IsConnected("INSERT into logistique_parc_vihecule (`id`,`nom`,`marque`,`matricule`,`remarque`,`energie`,`entry_date`) VALUES(NULL,'" & mysql_escape_string(NomTxt.Text) & "','" & mysql_escape_string(MarkTxt.Text) & "','" & mysql_escape_string(MatriculeTxt.Text) & "','" & mysql_escape_string(discriTxt.Text) & "','" & mysql_escape_string(EngineCmb.Text) & "',NOW());", True) Then
                        MessageBoxEx.Show("Enregistré avec succés ", "Succés", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        clearFields()
                    End If
                End If
                

            Else
                If File.Exists(pathTxt.Text) Then
                    If id > 0 Then
                        IsConnected("DELETE FROM `logistique_parc_vihecule` WHERE id = " & id & " limit 1; ", True)
                    End If
                    Dim FileSize As UInt32
                    Dim rawData() As Byte
                    Dim fs As FileStream
                    Dim sql As New SQLControl
                    fs = New FileStream(pathTxt.Text, FileMode.Open, FileAccess.Read)
                    FileSize = fs.Length

                    rawData = New Byte(FileSize) {}
                    fs.Read(rawData, 0, FileSize)
                    fs.Close()
                    sql.AddParam("@nom", mysql_escape_string(NomTxt.Text), DbType.String)
                    sql.AddParam("@marque", mysql_escape_string(MarkTxt.Text), DbType.String)
                    sql.AddParam("@matricule", mysql_escape_string(MatriculeTxt.Text), DbType.String)
                    sql.AddParam("@remarque", mysql_escape_string(discriTxt.Text), DbType.String)
                    sql.AddParam("@energie", mysql_escape_string(EngineCmb.Text), DbType.String)
                    sql.AddParam("@photo", rawData, DbType.Byte)

                    sql.ParamNonQuery("INSERT into logistique_parc_vihecule (`id`,`nom`,`marque`,`matricule`,`remarque`,`energie`,`photo`,`entry_date`) VALUES(NULL,@nom,@marque,@matricule,@remarque,@energie,@photo,NOW());")
                    MessageBoxEx.Show("Enregistré avec succés ", "Succés", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    If id > 0 Then
                        Me.Close()
                    End If
                    clearFields()
                Else
                    MessageBoxEx.Show("L'image que vous avez séléctionner est déplacer !!??", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If

        Else
            MessageBoxEx.Show("Vous avez laissé un champs vide !", "Champs vides", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub LoadImgBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LoadImgBtn.Click
        Dim o As New OpenFileDialog
        o.InitialDirectory = "C:\"
        o.Title = "Ouvrir une image"
        o.Filter = "Images Files|*.jpg"
        If o.ShowDialog = Windows.Forms.DialogResult.OK Then
            ImgVihecule.Image = Image.FromFile(o.FileName)
            pathTxt.Text = o.FileName
        End If
    End Sub

    Private Sub clearFields()
        NomTxt.Clear()
        MatriculeTxt.Clear()
        MarkTxt.Clear()
        discriTxt.Clear()
        EngineCmb.SelectedIndex = -1
        pathTxt.Clear()
        ImgVihecule.Image = Nothing
    End Sub

    Private Sub AjoutVihecule_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If id <> 0 Then

            Dim im As Image = Nothing
            ImgVihecule.Image = im
            If IsConnected("SELECT * FROM logistique_parc_vihecule WHERE id=" & id & " LIMIT 1", False) Then
                If myDR.HasRows Then
                    While myDR.Read

                        If Not IsDBNull(myDR("photo")) Then
                            Dim lb() As Byte = myDR("photo")
                            Dim lstr As New System.IO.MemoryStream(lb)
                            ImgVihecule.Image = Image.FromStream(lstr)
                            lstr.Close()
                        End If
                        NomTxt.Text = myDR("nom").ToString
                        MarkTxt.Text = myDR("marque").ToString
                        MatriculeTxt.Text = myDR("matricule").ToString
                        discriTxt.Text = myDR("remarque").ToString
                        EngineCmb.Text = myDR("energie").ToString
                        AjoutBtn.Text = "Enrigistrer les modifications"
                        AjoutBtn.Image = My.Resources.edit
                    End While
                End If

            End If
        End If
    End Sub
End Class