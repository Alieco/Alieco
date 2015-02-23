Imports DevComponents.DotNetBar

Public Class GestionJoursFeries
    Dim sql As New SQLControl
    Dim dt = New DataTable
    
    Private Sub ButtonX2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX2.Click
        Try
            Dim q2 = "INSERT INTO `joursferies`(`jourf`,`Nomf`)VALUES('" & jour.Value.ToString("yyyy-MM-dd") & "','" & nom.Text & "')"
            If IsConnected(q2, True) = True Then
                MessageBoxEx.Show("L'ajout est términé avec succes ! ", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Dim dr As DataRow = dt.NewRow()
                dr(0) = jour.Value
                dr(1) = nom.Text
                dt.Rows.Add(dr)
                GridView1.Columns.Clear()
                GridControl1.DataSource = Nothing
                GridControl1.DataSource = dt
                nom.Clear()
                jour.Value = Nothing
            End If
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub

    Private Sub GestionJoursFeries_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            If sql.VerifiyConnection = True Then
                sql.RunQuery("select jourf as Jour ,Nomf as 'Nom du jour fériés' from joursferies order by idjoursferies desc")
                If sql.SQLDS.Tables.Count > 0 Then
                    GridControl1.DataSource = sql.SQLDS.Tables(0)
                    dt = sql.SQLDS.Tables(0)
                End If
            End If
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub
End Class