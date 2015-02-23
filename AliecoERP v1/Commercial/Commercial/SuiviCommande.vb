Imports DevExpress.XtraGrid.Views.Grid
Public Class SuiviCommande
    Dim sql As New SQLControl
    Dim utilisateur As String = ""
    Private dt As DataTable
    Private Sub SuiviCommande_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Try
            chargeaffaire.Visible = False
            au.Value = Date.Now.Date
            Dim d As Date = Date.Today
            d = d.AddDays(-30)
            du.Value = d
            load_chargeAffaire()
            If user_id = 20 Or user_id = 1 Then
                CheckBoxX1.Visible = True
                chargeaffaire.Visible = True
            Else : CheckBoxX1.Visible = False
                chargeaffaire.Visible = False
            End If
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub
    Sub load_chargeAffaire()
        Try
            IsConnected("select distinct fullname from users, commercial_affaire where user_id=charge_affaire", False)
            If myDR.HasRows = True Then
                While myDR.Read
                    chargeaffaire.Items.Add(myDR("fullname"))
                End While
            End If
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub
    Sub reload()
        Try
            Dim c As Double = 0
            Dim d As String = ""
            Dim row As DataRow
            dt = New DataTable
            dt.Columns.Add("code")
            dt.Columns.Add("Affaire")
            dt.Columns.Add("Nom Client")
            dt.Columns.Add("Date de l'offre")
            dt.Columns.Add("date confirmation")
            dt.Columns.Add("Montant")
            dt.Columns.Add("Charge d'affaire")
            If user_id = 20 Or user_id = 1 Then
                If chargeaffaire.Text = "" Then
                    utilisateur = ""
                Else
                    utilisateur = "and fullname= '" & chargeaffaire.Text & "'"
                End If
            Else
                utilisateur = " and fullname= '" & user_id & "'"
            End If
            If IsConnected("select distinct(commercial_offre.code_affaire), commercial_offre.titre, fullname, commercial_offre.nomcl, commercial_offre.EntréeDate, commercial_affaire.EntréeDate, totalttc from commercial_offre, commercial_affaire,commercial_affaire_bordereauprix, users where commercial_affaire.code_affaire=commercial_offre.code_affaire and commercial_affaire_bordereauprix.code=commercial_affaire.code_affaire and user_id=commercial_affaire.charge_affaire and commercial_offre.code_affaire<>'' and commercial_offre.entréedate between '" & du.Value.ToString("yyyy-MM-dd") & "' and '" & au.Value.ToString("yyyy-MM-dd") & "' " & utilisateur & " group by commercial_affaire.code_affaire ", False) = True Then
                If myDR.HasRows = True Then
                    While myDR.Read
                        row = dt.NewRow()
                        row(0) = myDR("code_affaire").ToString
                        row(1) = myDR("titre").ToString
                        row(2) = myDR("nomcl").ToString
                        row(3) = myDR("EntréeDate").ToString()
                        row(4) = myDR("EntréeDate").ToString()
                        row(5) = myDR("totalttc").ToString & " DA"
                        c += myDR("totalttc").ToString
                        row(6) = myDR("fullname").ToString
                        dt.Rows.Add(row)
                    End While
                End If
            End If
            'If (user_id = 20 Or user_id = 1) Then
            '    If chargeaffaire.SelectedIndex <> -1 And CheckBoxX1.Checked Then
            '        If IsConnected("select distinct(commercial_offre.code_affaire), commercial_offre.titre, fullname, commercial_offre.nomcl, commercial_offre.EntréeDate, commercial_affaire.EntréeDate, totalttc from commercial_offre, commercial_affaire,commercial_affaire_bordereauprix, users where commercial_affaire.code_affaire=commercial_offre.code_affaire and commercial_affaire_bordereauprix.code=commercial_affaire.code_affaire and user_id=commercial_affaire.charge_affaire and commercial_offre.code_affaire<>'' and commercial_offre.entréedate between '" & du.Value.ToString("yyyy-MM-dd") & "' and '" & au.Value.ToString("yyyy-MM-dd") & "' and fullname='" & chargeaffaire.Text & "' group by commercial_affaire.code_affaire ", False) = True Then
            '            If myDR.HasRows = True Then
            '                While myDR.Read
            '                    row = dt.NewRow()
            '                    row(0) = myDR("code_affaire").ToString
            '                    row(1) = myDR("titre").ToString
            '                    row(2) = myDR("nomcl").ToString
            '                    row(3) = myDR("EntréeDate").ToString()
            '                    row(4) = myDR("EntréeDate").ToString()
            '                    row(5) = myDR("totalttc").ToString & " DA"
            '                    c += myDR("totalttc").ToString
            '                    row(6) = myDR("fullname").ToString
            '                    dt.Rows.Add(row)
            '                End While
            '            End If
            '        End If
            '    ElseIf chargeaffaire.SelectedIndex = -1 Then
            '        If IsConnected("select distinct(commercial_offre.code_affaire), commercial_offre.titre, fullname, commercial_offre.nomcl, commercial_offre.EntréeDate, commercial_affaire.EntréeDate, totalttc from commercial_offre, commercial_affaire,commercial_affaire_bordereauprix, users where commercial_affaire.code_affaire=commercial_offre.code_affaire and commercial_affaire_bordereauprix.code=commercial_affaire.code_affaire and user_id=commercial_affaire.charge_affaire and commercial_offre.code_affaire<>'' and commercial_offre.entréedate between '" & du.Value.ToString("yyyy-MM-dd") & "' and '" & au.Value.ToString("yyyy-MM-dd") & "' and commercial_affaire.charge_affaire='" & user_id & "' group by commercial_affaire.code_affaire ", False) = True Then
            '            If myDR.HasRows = True Then
            '                While myDR.Read
            '                    row = dt.NewRow()
            '                    row(0) = myDR("code_affaire").ToString
            '                    row(1) = myDR("titre").ToString
            '                    row(2) = myDR("nomcl").ToString
            '                    row(3) = myDR("EntréeDate").ToString()
            '                    row(4) = myDR("EntréeDate").ToString()
            '                    row(5) = myDR("totalttc").ToString & " DA"
            '                    c += myDR("totalttc").ToString
            '                    row(6) = myDR("fullname").ToString
            '                    dt.Rows.Add(row)
            '                End While
            '            End If
            '        End If
            '    End If
            'Else
            '    If IsConnected("select distinct(commercial_offre.code_affaire), commercial_offre.titre, fullname, commercial_offre.nomcl, commercial_offre.EntréeDate, commercial_affaire.EntréeDate, totalttc from commercial_offre, commercial_affaire,commercial_affaire_bordereauprix, users where commercial_affaire.code_affaire=commercial_offre.code_affaire and commercial_affaire_bordereauprix.code=commercial_affaire.code_affaire and user_id=commercial_affaire.charge_affaire and commercial_offre.code_affaire<>'' and commercial_offre.entréedate between '" & du.Value.ToString("yyyy-MM-dd") & "' and '" & au.Value.ToString("yyyy-MM-dd") & "' and commercial_affaire.charge_affaire='" & user_id & "' group by commercial_affaire.code_affaire ", False) = True Then
            '        If myDR.HasRows = True Then
            '            While myDR.Read
            '                row = dt.NewRow()
            '                row(0) = myDR("code_affaire").ToString
            '                row(1) = myDR("titre").ToString
            '                row(2) = myDR("nomcl").ToString
            '                row(3) = myDR("EntréeDate").ToString()
            '                row(4) = myDR("EntréeDate").ToString()
            '                row(5) = myDR("totalttc").ToString & " DA"
            '                c += myDR("totalttc").ToString
            '                row(6) = myDR("fullname").ToString
            '                dt.Rows.Add(row)
            '            End While
            '        End If
            '    End If
            'End If
            LabelX5.Text = c & " DA"
            gccommande.DataSource = dt
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub
    Private Sub ButtonX2_Click(sender As System.Object, e As System.EventArgs) Handles ButtonX2.Click
        Try
            reload()
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub

    Private Sub CheckBoxX1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBoxX1.CheckedChanged
        Try
            If CheckBoxX1.Checked Then
                chargeaffaire.Enabled = True
            Else
                chargeaffaire.Enabled = False
            End If
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub
End Class