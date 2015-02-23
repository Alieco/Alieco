Imports DevComponents.DotNetBar

Public Class CodePaie
    Dim Sql As New SQLControl
    Private Sub load_code()
        Try
            code2.Items.Clear()
            code3.Items.Clear()
            If IsConnected("SELECT DISTINCT Code FROM codepaie ", False) = True Then
                If myDR.HasRows = True Then

                    While (myDR.Read())
                        code2.Items.Add(myDR("Code"))
                        code3.Items.Add(myDR("Code"))
                    End While
                End If
            End If
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub
    'Private Sub load_code1()
    '    If IsConnected("SELECT DISTINCT Code FROM codepaie ", False) = True Then
    '        If myDR.HasRows = True Then

    '            While (myDR.Read())

    '                code3.Items.Add(myDR("Code"))
    '            End While
    '        End If
    '    End If
    'End Sub

    Private Sub ButtonX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX1.Click
        Try
            Dim q As String = "INSERT INTO codepaie(Code,Libellé)VALUES('" & code1.Text & "','" & libelle1.Text & "')"
            Clipboard.SetText(q)
            IsConnected(q, False)
            'MessageBoxEx.Show("Le code a bien été enregistrer", "Succés", MessageBoxButtons.OK, MessageBoxIcon.Information)
            code1.Text = ""
            libelle1.Text = ""
            Sql.RunQuery("select Code,Libellé from codepaie")
            If Sql.SQLDS.Tables.Count > 0 Then
                CPdg.DataSource = Sql.SQLDS.Tables(0)
            End If
            load_code()
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub

    Private Sub ButtonX4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX4.Click
        Try
            Dim q As String = "Update codepaie set Libellé='" & libelle2.Text & "' where Code='" & code2.Text & "'"
            IsConnected(q, False)
            'MessageBoxEx.Show("Le code a bien été modifier", "Succés", MessageBoxButtons.OK, MessageBoxIcon.Information)
            code2.Text = ""
            libelle2.Text = ""

            Sql.RunQuery("select Code,Libellé from codepaie")

            If Sql.SQLDS.Tables.Count > 0 Then
                CPdg.DataSource = Sql.SQLDS.Tables(0)
            End If
            load_code()
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub

    Private Sub ButtonX2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX2.Click
        Try
            Dim q As String = "DELETE FROM codepaie WHERE Code='" & code3.Text & "'"
            IsConnected(q, False)
            'MessageBoxEx.Show("Le code a bien été supprimer", "Succés", MessageBoxButtons.OK, MessageBoxIcon.Information)
            code3.Text = ""
            libelle3.Text = ""

            Sql.RunQuery("select Code,Libellé from codepaie")

            If Sql.SQLDS.Tables.Count > 0 Then
                CPdg.DataSource = Sql.SQLDS.Tables(0)
            End If
            load_code()
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub

    Private Sub FormCodePaie_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            load_code()
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
        'load_code1()
    End Sub

    Private Sub code2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles code2.SelectedIndexChanged, code3.SelectedIndexChanged
        Try
            IsConnected("select * from codepaie where Code='" & code2.Text & "'", False)
            If myDR.HasRows = True Then
                While (myDR.Read())
                    libelle2.Text = myDR("Libellé")
                End While
            End If
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub
    Private Sub code3_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles code2.SelectedIndexChanged, code3.SelectedIndexChanged
        Try
            IsConnected("select * from codepaie where Code='" & code3.Text & "'", False)
            If myDR.HasRows = True Then
                While (myDR.Read())
                    libelle3.Text = myDR("Libellé")
                End While
            End If
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub
End Class