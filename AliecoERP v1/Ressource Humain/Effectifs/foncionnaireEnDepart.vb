Imports System.Threading

Public Class foncionnaireEnDepart
    Dim sql As New SQLControl
    Private Sub foncionnaireEnDepart_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Me.WindowState = FormWindowState.Maximized
            Dim loginThread As Thread = New Thread(AddressOf reload)
            loginThread.Start()
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub
    Sub reload()
        Try
            If sql.VerifiyConnection = True Then
                sql.RunQuery("SELECT * Employes WHERE etat_emp=2 or etat_emp=3")
                If sql.SQLDS.Tables.Count > 0 Then
                    dgv1.DataSource = sql.SQLDS.Tables(0)
                End If
            End If
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub

    Private Sub ButtonX2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX2.Click
        Try
            dgv1.DataSource = Nothing
            If sql.VerifiyConnection = True Then
                If retraite.Checked = True Then
                    sql.RunQuery("SELECT * FROM Employes WHERE (etat_emp=2 )")
                ElseIf licenciement.Checked = True Then
                    sql.RunQuery("SELECT * FROM Employes WHERE (etat_emp=4)")
                ElseIf volentaire.Checked = True Then
                    sql.RunQuery("SELECT * FROM Employes WHERE (etat_emp=3)")
                End If
                If sql.SQLDS.Tables.Count > 0 Then
                    dgv1.DataSource = sql.SQLDS.Tables(0)
                End If
            End If
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub
End Class