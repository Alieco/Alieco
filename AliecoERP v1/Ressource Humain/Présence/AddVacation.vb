Imports DevComponents.DotNetBar

Public Class AddVacation

    Private Sub AddVacation_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
            Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub au_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles au.ValueChanged
        Try
            If du.Value < au.Value And du.Value <> Nothing And au.Value <> Nothing And du.Value <> au.Value Then
                ndj.Text = DateDiff(DateInterval.Day, du.Value, au.Value)
            End If
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub

    Private Sub du_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles du.ValueChanged
        Try
            If du.Value < au.Value And du.Value <> Nothing And au.Value <> Nothing And du.Value <> au.Value Then
                ndj.Text = DateDiff(DateInterval.Day, du.Value, au.Value)
            End If
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub

    Private Sub ndj_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ndj.TextChanged
        Try
            If IsNumeric(ndj.Text) = True Then
                au.Value = DateAdd(DateInterval.Day, CDbl(ndj.Text), du.Value)
            End If
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub

    Private Sub mat_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mat.TextChanged
        Try
            If mat.Text.Length = 5 Then
                IsConnected("SELECT * FROM Employes WHERE Matricule=" & mat.Text, False)
                If myDR.HasRows = True Then
                    While (myDR.Read)
                        Try
                            nom.Text = myDR("Nom").ToString
                            prenom.Text = myDR("Prénom").ToString
                            Lieux_de_Naissance.Text = myDR("Lieux_de_Naissance").ToString
                            Date_entrée.Text = myDR("Date_entrée").ToString
                            Fonction.Text = myDR("Fonction").ToString
                            Adresse.Text = myDR("Adresse").ToString
                            Date_de_Naissance.Text = myDR("Date_de_Naissance").ToString
                        Catch ex As Exception
                            MsgBox(ex.Message)
                        End Try

                    End While
                End If

            End If
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub

    Private Sub ButtonX2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX2.Click
        Try
            Dim q2 = "INSERT INTO `alieco`.`conge_ajout`(`Matricule`,`DateDebut`,`DateFin`,`NombreJours`,`TypeConge`)VALUES('" & mat.Text & "','" & du.Value & "', '" & au.Value & "', '" & ndj.Text & "','" & typeconge.Text & "')"
            If MessageBoxEx.Show("Voullez vous vraiment ajouter le congé ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                If IsConnected(q2, True) = True Then
                    MessageBoxEx.Show("L'ajout est términé avec succes ! ", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End If
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub
End Class