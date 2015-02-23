Public Class etatAffaireFrm
    Public codeAffaire As String = ""
    Private Sub etatAffaireFrm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            reload()
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub
    Sub reload()
        Try
            IsConnected("SELECT * FROM commercial_affaire_etat  WHERE code_affaire='" & codeAffaire & "' ORDER BY id DESC", False)
            If myDR.HasRows Then
                While myDR.Read
                    Dim item As ListViewItem = New ListViewItem(myDR("id").ToString)
                    item.SubItems.Add(myDR("text").ToString)
                    item.SubItems.Add(myDR("entry_date").ToString)
                    ListView1.Items.Add(item)
                End While
            End If
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub
    Private Sub ButtonX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX1.Click
        Try
            IsConnected("INSERT INTO commercial_affaire_etat VALUES(null,'" & etatTxt.Text.Replace(Environment.NewLine, "\r\n") & "',NOW(),'" & codeAffaire & "')", True)
            reload()
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub
    Private Sub etatTxt_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles etatTxt.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                etatTxt.Text = "● " & vbNewLine & etatTxt.Text
                SendKeys.Send("{RIGHT}")
            End If
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub
End Class