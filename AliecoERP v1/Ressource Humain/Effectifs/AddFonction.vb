Imports DevComponents.DotNetBar
Public Class Ajout_fonction
    Private Sub Ajout_fonction_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            loadFonction()
            For i = 1 To 20
                categorycmb.Items.Add(i)
            Next
            categorycmb.Items.Add("CS")
            For i = 0 To 15
                Echloncmb.Items.Add(i)
            Next
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub

    Private Sub ComboBoxEx3_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Echloncmb.SelectedIndexChanged
        Try
            salaire.Text = ""
            If categorycmb.SelectedIndex = 20 Then
                LabelX2.Visible = True
                LabelX1.Visible = True
                Label9.Text = "Niveau :"
                If Echloncmb.SelectedIndex > -1 Then
                    Dim col As String = ""
                    Select Case Echloncmb.SelectedIndex
                        Case 0
                            col = "csjun1"
                        Case 1
                            col = "csjun2"
                        Case 2
                            col = "cs1"
                        Case 3
                            col = "cs2"
                        Case 4
                            col = "cs3"
                        Case 5
                            col = "cs4"
                        Case Else
                            col = "csjun1"
                    End Select
                    Dim i = 0
                    IsConnected("SELECT " & col & " FROM GrilleCS where Element='salaire_base' OR Element='suggestion'", False)
                    If myDR.HasRows = True Then
                        While (myDR.Read())
                            If i = 0 Then
                                salaire.Text = myDR(col) & ".00 DA"
                            End If
                            If i = 1 Then
                                LabelX1.Text = myDR(col) & ".00 DA"
                            End If
                            i += 1
                        End While


                    End If
                End If
            Else
                Label9.Text = "N°Echelon :"
                LabelX2.Visible = False
                LabelX1.Visible = False
                If categorycmb.SelectedIndex > -1 And Echloncmb.SelectedIndex > -1 Then
                    IsConnected("SELECT ech_" & Echloncmb.SelectedIndex.ToString & " FROM Grille where F1=" & categorycmb.SelectedIndex + 1, False)
                    If myDR.HasRows = True Then
                        While (myDR.Read())
                            salaire.Text = myDR("ech_" & Echloncmb.SelectedIndex) & ".00 DA"
                        End While

                    End If
                End If
            End If
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub

    Private Sub ComboBoxEx4_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles categorycmb.SelectedIndexChanged
        Try
            salaire.Text = ""
            If categorycmb.SelectedIndex = 20 Then
                Echloncmb.Items.Clear()
                Label9.Text = "Niveau :"
                LabelX2.Visible = True
                LabelX1.Visible = True
                LabelX1.Text = ""
                Dim cs() As String = {"CS junior N°1", "CS junior N°2", "CS1", "CS2", "CS3", "CS4"}
                Echloncmb.Items.AddRange(cs)
                If Echloncmb.SelectedIndex > -1 Then
                    Dim col As String = ""
                    Select Case Echloncmb.SelectedIndex
                        Case 0
                            col = "csjun1"
                        Case 1
                            col = "csjun2"
                        Case 2
                            col = "cs1"
                        Case 3
                            col = "cs2"
                        Case 4
                            col = "cs3"
                        Case 5
                            col = "cs4"
                        Case Else
                            col = "csjun1"
                    End Select
                    IsConnected("SELECT " & col & " FROM GrilleCS where Element='salaire_base' OR Element='suggestion'", False)
                    If myDR.HasRows = True Then
                        While (myDR.Read())
                            salaire.Text = myDR(col)(0) & ".00 DA"
                            LabelX1.Text = myDR(col)(1) & ".00 DA"
                        End While
                    End If
                End If
            Else
                Echloncmb.Items.Clear()
                Echloncmb.Text = ""
                For i = 0 To 15
                    Echloncmb.Items.Add(i)
                Next
                LabelX2.Visible = False
                Label9.Text = "N°Echelon :"
                LabelX1.Visible = False
                'If categorycmb.SelectedIndex > -1 And Echloncmb.SelectedIndex > -1 Then
                '    IsConnected("SELECT ech_" & Echloncmb.SelectedIndex.ToString & " FROM Grille where F1=" & categorycmb.SelectedIndex + 1, False)
                '    If myDR.HasRows = True Then
                '        While (myDR.Read())
                '            salaire.Text = myDR("ech_" & Echloncmb.SelectedIndex) & ".00 DA"
                '        End While

                '    End If
                'End If
            End If
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub

    Private Sub ButtonX2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EnregistrerBtn.Click
        Try
            If FonctionTxt.Text <> "" And categorycmb.SelectedIndex > -1 And Echloncmb.SelectedIndex > -1 Then
                Try
                    Dim caterory As String = ""
                    Dim echelon As String = ""
                    If categorycmb.SelectedIndex = 20 Then
                        caterory = "CS"
                        Select Case Echloncmb.SelectedIndex
                            Case 0
                                echelon = "csjun1"
                            Case 1
                                echelon = "csjun2"
                            Case 2
                                echelon = "cs1"
                            Case 3
                                echelon = "cs2"
                            Case 4
                                echelon = "cs3"
                            Case 5
                                echelon = "cs4"
                        End Select
                    Else
                        caterory = categorycmb.SelectedIndex + 1
                        echelon = Echloncmb.SelectedIndex
                    End If
                    ' Clipboard.SetText("INSERT INTO Fonction (titre_fonction,id_ech,id_cat) VALUES ('" & mysql_escape_string(TextBoxX2.Text) & "','" & echelon & "','" & caterory & "')")
                    If IsConnected("INSERT INTO Fonction  VALUES (Null,'" & mysql_escape_string(FonctionTxt.Text.Replace(".00 DA", "")) & "','" & echelon & "','" & caterory & "',Null)", True) Then
                        MessageBoxEx.Show("La Fonction a bien été enregistré", "success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        FonctionTxt.Clear()
                        categorycmb.Text = ""
                        Echloncmb.Text = ""
                        salaire.Text = ""
                        LabelX1.Text = ""
                    End If
                Catch ex As Exception

                End Try
            End If
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub
    Private Sub loadFonction()
        Try
            If IsConnected("SELECT DISTINCT titre_fonction FROM Fonction ", False) = True Then
                If myDR.HasRows = True Then
                    fonctionCmb.Items.Clear()
                    While (myDR.Read())
                        fonctionCmb.Items.Add(myDR("titre_fonction").ToString)
                    End While
                End If
            End If
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub

    Private Sub fonctionCmb_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fonctionCmb.SelectedIndexChanged
        If fonctionCmb.SelectedIndex > -1 Then
            removeBtn.Enabled = True
        Else
            removeBtn.Enabled = False
        End If
    End Sub

    Private Sub removeBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles removeBtn.Click
        If MessageBoxEx.Show("Voullez vous vraiment supprimer cette fonction ?", "confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            If IsConnected("DELETE FROM `fonction` WHERE `titre_fonction`='" & mysql_escape_string(fonctionCmb.Text) & "' LIMIT 1;", True) Then
                MessageBoxEx.Show("La fonction est supprimé avec succés", "Suppression réussi", MessageBoxButtons.OK, MessageBoxIcon.Information)
                removeBtn.Enabled = False
                fonctionCmb.Text = ""
                loadFonction()
            End If
        End If
    End Sub

    Private Sub salaire_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles salaire.TextChanged
        If salaire.Text.Contains("DA") And FonctionTxt.Text <> "" Then
            EnregistrerBtn.Enabled = True
        Else
            EnregistrerBtn.Enabled = False
        End If
    End Sub

    Private Sub FonctionTxt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FonctionTxt.TextChanged
        If salaire.Text.Contains("DA") And FonctionTxt.Text <> "" Then
            EnregistrerBtn.Enabled = True
        Else
            EnregistrerBtn.Enabled = False
        End If
    End Sub

    Private Sub fonctionCmb_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fonctionCmb.TextChanged
        removeBtn.Enabled = False
    End Sub
End Class