Imports DevComponents.DotNetBar
Public Class Formation
    Private Sub ButtonX1_Click(sender As System.Object, e As System.EventArgs) Handles ButtonX1.Click
        Try
            Dim q As String = "INSERT INTO Planformation VALUES (NULL,'NULL', '" & mysql_escape_string(nf.Text) & "','NULL','NULL','NULL','NULL','NULL','NULL','0','0',Now())"
            IsConnected(q, False)
            MessageBoxEx.Show("La formation prévu a bien été enregistrer", "Succés", MessageBoxButtons.OK, MessageBoxIcon.Information)
            nf.Text = ""
            If IsConnected("SELECT DISTINCT(NatureFormation) FROM Planformation ", False) = True Then
                If myDR.HasRows = True Then
                    PlanFormPrévu.nf.Items.Clear()
                    PlanFormationRealise.natureformation.Items.Clear()
                    While (myDR.Read())
                        PlanFormPrévu.nf.Items.Add(myDR("NatureFormation"))
                        PlanFormationRealise.natureformation.Items.Add(myDR("NatureFormation"))
                    End While
                End If
            End If
            Me.Close()
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub

    Private Sub ButtonX2_Click(sender As System.Object, e As System.EventArgs) Handles ButtonX2.Click
        Me.Close()
    End Sub
End Class