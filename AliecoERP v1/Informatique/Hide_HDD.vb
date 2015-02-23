Imports DevComponents.DotNetBar

Public Class Hide_HDD

    Private Sub ButtonX2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX2.Click
        Dim i As Integer = 0
        If CheckBoxX1.Checked = True Then
            i += 4
        End If
        If CheckBoxX2.Checked = True Then
            i += 8
        End If
        If CheckBoxX3.Checked = True Then
            i += 16
        End If
        If CheckBoxX4.Checked = True Then
            i += 32
        End If
        If i = 0 Then
            MessageBoxEx.Show("You must select drive to hide !", "error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else

            Try
                CreateIntegerKey("HKCU\Software\Microsoft\Windows\CurrentVersion\Policies\Explorer\Nodrives", i)
            Catch ex As Exception
                MessageBoxEx.Show("An error has occurred code : 33365 ", "error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub ButtonX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX1.Click
        Try
            DeleteKey("HKCU\Software\Microsoft\Windows\CurrentVersion\Policies\Explorer\Nodrives")
        Catch ex As Exception
            MessageBoxEx.Show("An error has occurred code : 33362 ", "error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class