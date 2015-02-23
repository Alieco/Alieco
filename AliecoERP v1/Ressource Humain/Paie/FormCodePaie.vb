Imports DevComponents.DotNetBar
Imports System.Threading

Public Class FormCodePaie
    Dim Sql As New SQLControl
    Private Sub load_code()
        Sql.RunQuery("SELECT * FROM paie_rubrique;")
        If Sql.SQLDS.Tables.Count > 0 Then
            CPdg.DataSource = Sql.SQLDS.Tables(0)
        End If
    End Sub
    Private Sub ButtonX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX1.Click
        Dim q As String = ""
        If ButtonX1.Text = "Ajouter" Then
            IsConnected("SELECT * FROM paie_rubrique WHERE ind='" & code1.Text & "'", False)
            If myDR.HasRows = True Then
                q = "UPDATE `paie_rubrique` SET `libind` = '" & mysql_escape_string(libelle1.Text) & "',`soumiss` = '" & soumiss.Text & "',`soumits` = '" & soumits.Text & "',`sens` = '" & sens.Text & "',`imput` =  '" & imput.Text & "',`fix` = '" & fix.Text & "',`codcalc` = '" & codcalc.Text & "',`codret` = '" & codret.Text & "',`prorata` = '" & prorata.Text & "',`tauxpu` = '" & tauxpu.Text & "',`rg` = '" & rg.Text & "',`prv` = '" & prv.Text & "',`tiers` = '" & tiers.Text & "',`type` = '" & type.Text & "' WHERE `ind` = '" & code1.Text & "' limit 1;"
            Else
                q = "INSERT INTO paie_rubrique(ind, libind, soumiss, soumits, sens, imput, fix, codcalc, codret, prorata, tauxpu, rg, prv, tiers, type)VALUES('" & code1.Text & "','" & mysql_escape_string(libelle1.Text) & "', '" & soumiss.Text & "', '" & soumits.Text & "','" & sens.Text & "', '" & imput.Text & "','" & fix.Text & "', '" & codcalc.Text & "', '" & codret.Text & "', '" & prorata.Text & "', '" & tauxpu.Text & "', '" & rg.Text & "', '" & prv.Text & "', '" & tiers.Text & "', '" & type.Text & "')"
            End If

        Else
            q = "UPDATE `paie_rubrique` SET `libind` = '" & mysql_escape_string(libelle1.Text) & "',`soumiss` = '" & soumiss.Text & "',`soumits` = '" & soumits.Text & "',`sens` = '" & sens.Text & "',`imput` =  '" & imput.Text & "',`fix` = '" & fix.Text & "',`codcalc` = '" & codcalc.Text & "',`codret` = '" & codret.Text & "',`prorata` = '" & prorata.Text & "',`tauxpu` = '" & tauxpu.Text & "',`rg` = '" & rg.Text & "',`prv` = '" & prv.Text & "',`tiers` = '" & tiers.Text & "',`type` = '" & type.Text & "' WHERE `ind` = '" & code1.Text & "' limit 1;"
        End If
        'Clipboard.SetText(q)
        If IsConnected(q, True) Then
            MessageBoxEx.Show("La rubrique a bien été enregistrer", "Succés", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ButtonX1.Text = "Ajouter"
            ButtonX1.Image = My.Resources.add_button
            libelle1.Clear()
            soumiss.Text = ""
            soumits.Text = ""
            sens.Text = ""
            imput.Text = ""
            fix.Text = ""
            codcalc.Text = ""
            codret.Text = ""
            prorata.Text = ""
            tauxpu.Text = ""
            rg.Text = ""
            prv.Text = ""
            tiers.Text = ""
            type.Text = ""
            code1.Clear()
            load_code()
        End If

    End Sub

    Private Sub FormCodePaie_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Control.CheckForIllegalCrossThreadCalls = False
        'Dim t As Thread = New Thread(AddressOf load_code)
        't.Start()
        load_code()
    End Sub

    Private Sub ModifierToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ModifierToolStripMenuItem.Click
        If GridView1.SelectedRowsCount = 0 Then
            MessageBoxEx.Show("Vous devez selectionner une rubrique avant de cliquer modifier", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            Me.Text = "Modification la rubrique " & GridView1.GetFocusedRowCellValue("ind").ToString()
            code1.Text = GridView1.GetFocusedRowCellValue("ind").ToString()
        End If

        If code1.Text <> "" Then
            IsConnected("SELECT * FROM paie_rubrique WHERE ind='" & code1.Text & "'", False)
            If myDR.HasRows = True Then
                While (myDR.Read)
                    Try
                        libelle1.Text = myDR("libind").ToString
                        soumiss.Text = myDR("soumiss").ToString
                        soumits.Text = myDR("soumits").ToString
                        sens.Text = myDR("sens").ToString
                        imput.Text = myDR("imput").ToString
                        fix.Text = myDR("fix").ToString
                        codcalc.Text = myDR("codcalc").ToString
                        codret.Text = myDR("codret").ToString
                        prorata.Text = myDR("prorata").ToString
                        tauxpu.Text = myDR("tauxpu").ToString
                        rg.Text = myDR("rg").ToString
                        prv.Text = myDR("prv").ToString
                        tiers.Text = myDR("tiers").ToString
                        type.Text = myDR("type").ToString
                    Catch ex As Exception
                    End Try
                End While
            End If
        End If
        ButtonX1.Text = "Modifier le Code " & code1.Text
        ButtonX1.Image = My.Resources.edit
    End Sub

    Private Sub SupprimerToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SupprimerToolStripMenuItem.Click
        If GridView1.SelectedRowsCount = 0 Then
            MessageBoxEx.Show("Vous devez selectionner une rubrique avant de cliquer supprimer", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            Dim m = GridView1.GetFocusedRowCellValue("ind").ToString()
            If m <> Nothing Then
                If MessageBoxEx.Show("Vous voullez vraiment supprimer la rubrique ?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                    IsConnected("DELETE FROM paie_rubrique WHERE ind='" & m & "' limit 1", True)
                End If
            End If
        End If
    End Sub

    Private Sub code1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles code1.TextChanged
        If code1.Text.Length > 2 Then
            IsConnected("SELECT * FROM paie_rubrique WHERE ind='" & code1.Text & "'", False)
            If myDR.HasRows = True Then
                While (myDR.Read)
                    Try
                        libelle1.Text = myDR("libind").ToString
                        soumiss.Text = myDR("soumiss").ToString
                        soumits.Text = myDR("soumits").ToString
                        sens.Text = myDR("sens").ToString
                        imput.Text = myDR("imput").ToString
                        fix.Text = myDR("fix").ToString
                        codcalc.Text = myDR("codcalc").ToString
                        codret.Text = myDR("codret").ToString
                        prorata.Text = myDR("prorata").ToString
                        tauxpu.Text = myDR("tauxpu").ToString
                        rg.Text = myDR("rg").ToString
                        prv.Text = myDR("prv").ToString
                        tiers.Text = myDR("tiers").ToString
                        type.Text = myDR("type").ToString
                        ButtonX1.Text = "Modifier le Code " & code1.Text
                        ButtonX1.Image = My.Resources.edit
                    Catch ex As Exception
                    End Try
                End While
            Else
                ButtonX1.Text = "Ajouter"
                ButtonX1.Image = My.Resources.add_button

            End If
        Else
            ButtonX1.Text = "Ajouter"
            ButtonX1.Image = My.Resources.add_button
            libelle1.Clear()
            soumiss.Text = ""
            soumits.Text = ""
            sens.Text = ""
            imput.Text = ""
            fix.Text = ""
            codcalc.Text = ""
            codret.Text = ""
            prorata.Text = ""
            tauxpu.Text = ""
            rg.Text = ""
            prv.Text = ""
            tiers.Text = ""
            type.Text = ""
        End If
    End Sub


End Class