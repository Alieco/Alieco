Public Class suiviAffaire
    Dim code As String = ""
    Dim cr As String
    Dim utilisateur As String = ""
    Private Sub suiviAffaire_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            loadAffaire()
            If user_id = 20 Or user_id = 1 Then
                chargeaffaire.Enabled = True
                ' load_chargeaffaire()
                'If chargeaffaire.SelectedIndex > -1 Then
                '    utilisateur = chargeaffaire.Text
                'End If
            Else
                chargeaffaire.Enabled = False
                utilisateur = user_id
            End If
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub

    'Sub load_chargeaffaire()
    '    IsConnected("SELECT distinct fullname FROM commercial_affaire,users WHERE commercial_affaire.charge_affaire=users.user_id", False)
    '    If myDR.HasRows Then
    '        chargeaffaire.Items.Clear()
    '        While myDR.Read
    '            chargeaffaire.Items.Add(myDR("fullname").ToString)
    '        End While
    '    End If
    'End Sub

    Sub loadAffaire()
        Try
            ComboBoxEx1.Items.Clear()
            IsConnected("SELECT code_affaire FROM commercial_affaire ORDER BY idoffre DESC ", False)
            If myDR.HasRows Then
                While myDR.Read
                    ComboBoxEx1.Items.Add(myDR("code_affaire").ToString)
                End While
            End If
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub

    Private Sub ComboBoxEx1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBoxEx1.SelectedIndexChanged
        Try
            ListView1.Items.Clear()
            TextBoxX1.Text = ""
            montanttxt.Text = ""
            delaiexe.Text = ""
            du.Text = ""
            TextBoxX5.Text = ""
            If ComboBoxEx1.Text <> "" Then
                IsConnected("SELECT * FROM commercial_affaire, users WHERE charge_affaire=user_id AND code_affaire ='" & ComboBoxEx1.Text & "' ", False)
                If myDR.HasRows Then
                    While myDR.Read
                        '******************************************
                        chargeaffaire.Text = myDR("fullname").ToString
                        delaiexe.Text = myDR("delai_exe").ToString
                        du.Text = myDR("entréedate").ToString
                        code = myDR("code").ToString
                    End While
                End If
                IsConnected("SELECT totalttc FROM commercial_affaire_bordereauprix WHERE code ='" & ComboBoxEx1.Text & "' order by idBordereauPrix desc limit 1 ", False)
                If myDR.HasRows Then
                    While myDR.Read
                        montanttxt.Text = myDR("totalttc").ToString & " DA/TTC"
                        cr = myDR("totalttc").ToString
                    End While
                End If
                loadModalite()
                CalcCreance()
            End If
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub

    Private Sub ButtonX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX1.Click
        Try
            IsConnected("UPDATE commercial_affaire_modalite SET montant='" & montantmodalite.Text & "',ddepot='" & DateTimeInput1.Text & "',reglement='" & reglementtxt.Text & "' WHERE idModalite = " & nemoro.Text & " LIMIT 1", True)
            'Clipboard.SetText("UPDATE commercial_affaire_bordereauprix SET montant='" & montantmodalite.Text & "',ddepot='" & DateTimeInput1.Text & "',montant='" & montantmodalite.Text & "' WHERE idBordereauPrix = " & nemoro.Text & " LIMIT 1")
            loadModalite()
            GroupBox2.Visible = False
            GroupBox1.Height = 157
            ListView1.Height = 364
            ListView1.Location = New Point(9, 164)
            CalcCreance()
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub

    Private Sub ListView1_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListView1.DoubleClick
        Try
            If ListView1.SelectedItems.Count > 0 Then
                GroupBox2.Visible = True
                GroupBox1.Height = 315
                ListView1.Height = 236
                ListView1.Location = New Point(9, 308)
                modalite.Text = ListView1.SelectedItems(0).Text
                montantmodalite.Text = ListView1.SelectedItems(0).SubItems(3).Text
                DateTimeInput1.Value = IIf(ListView1.SelectedItems(0).SubItems(4).Text = "", Date.Now.Date, ListView1.SelectedItems(0).SubItems(4).Text)
                reglementtxt.Text = ListView1.SelectedItems(0).SubItems(5).Text
                nemoro.Text = ListView1.SelectedItems(0).SubItems(1).Text
            End If
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub
    Private Sub loadModalite()
        Try
            ListView1.Items.Clear()
            IsConnected("SELECT * FROM commercial_affaire_modalite WHERE code ='" & ComboBoxEx1.Text & "'", False)
            If myDR.HasRows Then
                While myDR.Read
                    Dim item As ListViewItem = New ListViewItem(myDR("description").ToString)
                    item.SubItems.Add(myDR("idmodalite").ToString)
                    item.SubItems.Add(myDR("datemodalite").ToString.Remove(10))
                    item.SubItems.Add(myDR("montant").ToString)
                    item.SubItems.Add(myDR("ddepot").ToString)
                    item.SubItems.Add(myDR("reglement").ToString)
                    ListView1.Items.Add(item)
                End While
            End If
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub

    Private Sub etatTxt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles etatTxt.TextChanged
        Try
            If etatTxt.Text.Length >= 7 And etatTxt.Text.Length <= 9 Then
                IsConnected("SELECT * FROM commercial_affaire, users WHERE charge_affaire=user_id AND code_affaire ='" & etatTxt.Text & "' ", False)

                If myDR.HasRows Then
                    While myDR.Read
                        '******************************
                        chargeaffaire.Text = myDR("fullname").ToString
                        delaiexe.Text = myDR("delai_exe").ToString
                        du.Text = myDR("entréedate").ToString
                        code = myDR("code").ToString
                    End While
                End If
                IsConnected("SELECT totalttc FROM commercial_affaire_bordereauprix WHERE code ='" & code & "' order by idBordereauPrix desc limit 1 ", False)
                If myDR.HasRows Then
                    While myDR.Read
                        montanttxt.Text = myDR("totalttc").ToString & " DA/TTC"
                    End While
                End If
                loadModalite()
            End If
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub
    Sub CalcCreance()
        Try
            Dim t As Double = 0
            For i = 0 To ListView1.Items.Count - 1
                If ListView1.Items(i).SubItems(3).Text <> "" And IsNumeric(ListView1.Items(i).SubItems(3).Text) And ListView1.Items(i).SubItems(5).Text = "FAIT" Then
                    t = IIf(ListView1.Items(i).SubItems(3).Text = "", 0, ListView1.Items(i).SubItems(3).Text) + t
                End If
            Next
            creancetxt.Text = cr - t
            If creancetxt.Text <> "0" Then
                CheckBoxX2.Checked = True
            End If
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub

    Private Sub suiviAffaire_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        Try
            TextBoxX1.Clear()
            ComboBoxEx1.Text = Nothing
            etatTxt.Clear()
            montanttxt.Clear()
            delaiexe.Clear()
            du.Text = Nothing
            TextBoxX5.Clear()
            '***************************************************
            chargeaffaire.Text = ""
            creancetxt.Text = ""
            CheckBoxX2.Checked = False
            CheckBoxX1.Checked = False
            ListView1.Items.Clear()
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub
End Class