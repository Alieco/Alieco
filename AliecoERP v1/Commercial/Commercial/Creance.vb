Imports MySql.Data.MySqlClient
Imports DevExpress.XtraGrid.Views.Grid

Public Class Creance
    Dim sql As New SQLControl
    Private dt As DataTable
    Private Sub ButtonX2_Click(sender As System.Object, e As System.EventArgs) Handles ButtonX2.Click
        Try
            reload()
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub
    Sub reload()
        Try
            Dim utilisateur As String = ""
            If user_id = 20 Or user_id = 1 Then
                If ca.Text = "" Then
                    utilisateur = ""
                Else
                    utilisateur = "and fullname= '" & ca.Text & "'"
                End If
            Else
                utilisateur = " and fullname= '" & user_id & "'"
            End If
            Dim t As String = ""
            Dim row As DataRow
            dt = New DataTable
            dt.Columns.Add("Code affaire")
            dt.Columns.Add("Chargé d'affaire")
            dt.Columns.Add("Désignation")
            dt.Columns.Add("Montant (DA/TTC)")
            dt.Columns.Add("Créance (DA/TTC)")
            ', (sum(commercial_affaire_modalite.montant)/(count(commercial_affaire_bordereauprix.totalttc)/count( distinct(commercial_affaire_modalite.montant)))) as creance
            If IsConnected("SELECT fullname, designation,code_affaire,commercial_affaire_modalite.montant, totalttc FROM commercial_affaire_modalite,users,commercial_affaire_bordereauprix, commercial_affaire where users.user_id=commercial_affaire.charge_affaire and reglement <>'Fait' and commercial_affaire.code_affaire= commercial_affaire_modalite.code " & utilisateur & " and entréedate between '" & du.Value.ToString("yyyy-MM-dd") & "' and '" & au.Value.ToString("yyyy-MM-dd") & "' and commercial_affaire_bordereauprix.code=commercial_affaire.code_affaire group by commercial_affaire_modalite.code;", False) = True Then
                If myDR.HasRows = True Then
                    While myDR.Read
                        row = dt.NewRow()
                        row(0) = myDR("code_affaire").ToString
                        row(1) = myDR("fullname").ToString
                        row(2) = myDR("designation").ToString
                        row(3) = Format(CDbl(myDR("totalttc").ToString), "##,##0.00")
                        'Dim m = myDR("montant").ToString
                        'Dim tt = myDR("totalttc").ToString
                        row(4) = ""
                        dt.Rows.Add(row)
                        If utilisateur <> "" Then
                            LabelX5.Text = myDR("fullname").ToString
                        End If
                    End While
                End If
            End If
            gccreance.DataSource = dt
            For i = 0 To GridView1.DataRowCount - 1
                Dim code As String = GridView1.GetRowCellValue(i, "Code affaire").ToString()
                IsConnected("SELECT sum(MantantFactureTTC) as montant FROM facturation_facture WHERE code_affaire='" & code & "' ", False)
                If myDR.HasRows Then
                    While myDR.Read
                        GridView1.SetRowCellValue(i, "Créance (DA/TTC)", Format(CDbl((GridView1.GetRowCellValue(i, "Montant (DA/TTC)").ToString() - IIf(myDR("montant").ToString = "", 0, myDR("montant").ToString))), "##,##0.00"))
                    End While
                End If
                  Next
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub
    Private Sub GridView1_RowCellStyle(ByVal sender As Object, ByVal e As RowCellStyleEventArgs) Handles GridView1.RowCellStyle
        Try
            Dim View As GridView = sender
            If e.Column.FieldName = "Créance (DA/TTC)" Then
                Dim situation As String = View.GetRowCellDisplayText(e.RowHandle, View.Columns("Créance (DA/TTC)"))
                e.Appearance.BackColor = Color.Red
                e.Appearance.BackColor2 = Color.LightCoral
                e.Appearance.ForeColor = Color.White
                Dim f As Font = New Font("Segoe UI Symbol", 9, FontStyle.Bold)
                e.Appearance.Font = f
            End If
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub

    Private Sub Creance_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Try
            If user_id = 20 Or user_id = 1 Then
                ca.Items.Clear()
                chargerA.Visible = True
                ca.Visible = True
                load_chargeaffaire()
                'IsConnected("select distinct fullname from users where type>=20 and type <=29 ", False)
                'If myDR.HasRows = True Then
                '    While myDR.Read
                '        ca.Items.Add(myDR("fullname"))
                '    End While
                'End If
            End If
            au.Value = Date.Now.Date
            Dim d As Date = Date.Today
            d = d.AddDays(-30)
            du.Value = d
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub
    Sub load_chargeaffaire()
        Try
            IsConnected("SELECT distinct fullname FROM commercial_affaire,users WHERE commercial_affaire.charge_affaire=users.user_id", False)
            If myDR.HasRows Then
                ca.Items.Clear()
                While myDR.Read
                    ca.Items.Add(myDR("fullname").ToString)
                End While
            End If
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub
End Class