Imports DevComponents.DotNetBar

Public Class FormATS
    Public type As String = ""
    Public mat1 As Double = 0
    Private Sub ButtonX2_Click(sender As System.Object, e As System.EventArgs) Handles ButtonX2.Click
        Try
            Dim q2 = "INSERT INTO employes_securitesociale_ats (`idATS`,`Matricule`,`datedu`,`dateau`,`jour`,`heure`,`type`) VALUES (Null,'" & matricule.Text & "','" & du1.Text & "','" & au1.Text & "','" & jour.Text & "','" & heure.Text & "','" & type & "')"
            If IsConnected(q2, True) = True Then
                MessageBoxEx.Show("L'ajout est términé avec succes", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information)
                du1.Text = ""
                au1.Text = ""
                jour.Text = ""
                heure.Text = ""
                matricule.Text = ""
            End If
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub

    Private Sub FormATS_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        matricule.Text = mat1
    End Sub
End Class