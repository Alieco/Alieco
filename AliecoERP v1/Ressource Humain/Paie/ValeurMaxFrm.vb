Public Class ValeurMaxFrm

    Public Valeurmax As Double = 0
    Private Sub ValeurMax_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ValeurMaxInput.Value = My.Settings.ValeurMax
    End Sub

    Private Sub ButtonX2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX2.Click
        Valeurmax = ValeurMaxInput.Value
        My.Settings.ValeurMax = ValeurMaxInput.Value
        My.Settings.Save()
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub ButtonX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX1.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub
End Class