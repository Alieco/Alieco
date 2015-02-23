Imports MySql.Data.MySqlClient
Imports DevComponents.DotNetBar

Public Class FicheSuiveuse

    Private Sub FicheSuiveuse_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        load_nomclient()
    End Sub
    Sub load_nomclient()
        nomcl.Items.Clear()
        IsConnected("SELECT NomClient FROM commercial_client", False)
        If myDR.HasRows Then
            While myDR.Read
                nomcl.Items.Add(myDR("NomClient").ToString)
            End While
        End If
    End Sub

    Private Sub ButtonX6_Click(sender As System.Object, e As System.EventArgs) Handles ButtonX6.Click
            Dim erreur As Boolean = False
            Try
            Dim quary = "INSERT INTO facturation_affaire_modalite VALUES(NULL,'" & codecl.Text & "','" & mysql_escape_string(FichSuiv.Items(0).SubItems(0).Text) & "','" & mysql_escape_string(FichSuiv.Items(0).SubItems(1).Text) & " " & mysql_escape_string(FichSuiv.Items(0).SubItems(2).Text) & "','" & mysql_escape_string(FichSuiv.Items(0).SubItems(3).Text) & "','" & modepaiement.Text & "','" & obs.Text & "','" & tva.Text & "','" & exo.Text & "');"
            Clipboard.SetText(quary)
            'FicheSuiveuse.SizeGripStyle()
            If IsConnected(quary, True) = False Then
                erreur = True
            End If
            Catch ex As MySqlException
                MessageBox.Show(ex.Message)
            End Try
    End Sub

    Private Sub nomcl_SelectedIndexChanged(sender As System.Object, e As System.EventArgs)
        Dim c As String = ""
        If nomcl.SelectedIndex <> -1 Then
            IsConnected("SELECT codeCl FROM commercial_client where NomClient='" & nomcl.Text & "'", False)
            If myDR.HasRows Then
                FichSuiv.Items.Clear()
                codecl.Clear()
                While myDR.Read
                    codecl.Text = myDR("codeCl").ToString
                    c = myDR("codeCl").ToString
                    ' MsgBox(c)
                    IsConnected("SELECT * FROM commercial_affaire_modalite WHERE code ='" & c & "'", False)
                    If myDR.HasRows Then
                        While myDR.Read
                            Dim item As ListViewItem = New ListViewItem(myDR("description").ToString)
                            item.SubItems.Add(myDR("type").ToString)
                            item.SubItems.Add(myDR("ddepot").ToString)
                            item.SubItems.Add(myDR("montant").ToString)
                            FichSuiv.Items.Add(item)
                        End While
                    End If
                End While
            End If
        End If
    End Sub

    Private Sub ButtonX7_Click(sender As System.Object, e As System.EventArgs)
        'Dim List As ListViewItem = New ListViewItem(imputation.Text, 1)
        'List.SubItems.Add(facture.Text)
        'List.SubItems.Add(Datefact.Text)
        'List.SubItems.Add(montant.Text)
        'FichSuiv.Items.Add(List)
        'imputation.Clear()
        'facture.Clear()
        'Datefact.Value = ""
        'montant.Value = Nothing
    End Sub

    Private Sub ButtonX1_Click(sender As System.Object, e As System.EventArgs) Handles ButtonX1.Click
        RapportFichSuiveuse.MdiParent = Mainfrm
        RapportFichSuiveuse.Show()
    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripMenuItem1.Click
        'For i = 0 To ListView1.Items.Count - 1
        '    If ListView1.Items(i).Selected = True Then
        '        imputation.Text = ListView1.Items(i).Text
        '        facture.Text = ListView1.Items(i).SubItems(1).Text
        '        Datefact.Text = ListView1.Items(i).SubItems(2).Text
        '        montant.Text = ListView1.Items(i).SubItems(3).Text
        '    End If
        'Next
    End Sub

    Private Sub ToolStripMenuItem2_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripMenuItem2.Click
        'For i = 0 To ListView1.Items.Count - 1
        '    If ListView1.Items(i).Selected = True Then
        '        ListView1.Items(i).Remove()
        '        Exit For
        '    End If
        'Next
    End Sub
End Class