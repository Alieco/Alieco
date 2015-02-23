Imports DevComponents.DotNetBar

Public Class Retraitefrm
    Public ds As RetraiteDSt = New RetraiteDSt
    Private Sub TextBoxX10_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles anne1.TextChanged
        Try
            If IsNumeric(anne1.Text) Then
                ane1.Text = (anne1.Text * 5) / 100
                rapel.Text = String.Format("{0:0.00}", (CDbl(ane5.Text) + CDbl(ane4.Text) + CDbl(ane3.Text) + CDbl(ane2.Text) + CDbl(ane1.Text))) & " DA"
            End If
            If anne1.Text = "" Then ane1.Text = "0"
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub

    Private Sub TextBoxX11_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles anne2.TextChanged
        Try
            If IsNumeric(anne2.Text) Then
                ane2.Text = (anne2.Text * 10) / 100
                rapel.Text = String.Format("{0:0.00}", (CDbl(ane5.Text) + CDbl(ane4.Text) + CDbl(ane3.Text) + CDbl(ane2.Text) + CDbl(ane1.Text))) & " DA"
            End If
            If anne2.Text = "" Then ane2.Text = "0"
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub

    Private Sub TextBoxX12_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles anne3.TextChanged
        Try
            If IsNumeric(anne3.Text) Then
                ane3.Text = (anne3.Text * 14) / 100
                rapel.Text = String.Format("{0:0.00}", (CDbl(ane5.Text) + CDbl(ane4.Text) + CDbl(ane3.Text) + CDbl(ane2.Text) + CDbl(ane1.Text))) & " DA"
            End If
            If anne3.Text = "" Then ane3.Text = "0"
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub

    Private Sub TextBoxX13_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles anne4.TextChanged
        Try
            If IsNumeric(anne4.Text) Then
                ane4.Text = (anne4.Text * 18) / 100
                rapel.Text = String.Format("{0:0.00}", (CDbl(ane5.Text) + CDbl(ane4.Text) + CDbl(ane3.Text) + CDbl(ane2.Text) + CDbl(ane1.Text))) & " DA"
            End If
            If anne4.Text = "" Then ane4.Text = "0"
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub

    Private Sub TextBoxX14_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles anne5.TextChanged
        Try
            If IsNumeric(anne5.Text) Then
                ane5.Text = (anne5.Text * 22) / 100
                rapel.Text = String.Format("{0:0.00}", (CDbl(ane5.Text) + CDbl(ane4.Text) + CDbl(ane3.Text) + CDbl(ane2.Text) + CDbl(ane1.Text))) & " DA"
            End If
            If anne5.Text = "" Then ane5.Text = "0"
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub

    Private Sub Retraitefrm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub IntegerInput1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles matriculetxt.ValueChanged
        Try
            If matriculetxt.Text.Length = 5 Then
                IsConnected("SELECT Nom,Prénom,Date_de_Naissance,Lieux_de_Naissance,Ville,Date_entrée,Date_entrée_1,fonction,Date_fin_de_contrat FROM alieco.employes WHERE Matricule=" & matriculetxt.Value, False)
                If myDR.HasRows Then
                    While myDR.Read
                        nomtxt.Text = myDR("Nom") & " " & myDR("Prénom")
                        dntxt.Value = myDR("Date_de_Naissance")
                        Lnaistxt.Text = myDR("Lieux_de_Naissance")
                        vnais.Text = myDR("Ville")
                        de.Text = myDR("Date_entrée")
                        df.Text = myDR("Date_fin_de_contrat")
                    End While
                End If
            End If
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub

    Private Sub ButtonX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX1.Click
        Try
            If MessageBoxEx.Show("Voullez vous vraiment ajouter ce fonctionnaire en retraite ?", "Confirmation", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                ds.EnforceConstraints = False
                Try
                    ds.retraiteTB.Clear()
                    ds.retraiteTB.AddretraiteTBRow(matriculetxt.Value, nomtxt.Text, dntxt.Text, Lnaistxt.Text, dr.Text, "<13> Treze", "cinq (5)", ane1.Text, ane2.Text, ane3.Text, ane4.Text, ane5.Text, rapel.Text, assur.Text, pension.Text, de.Value, df.Value, anne1.Text, anne2.Text, anne3.Text, anne4.Text, anne5.Text, vnais.Text)
                    IsConnected("INSERT INTO `alieco`.`retraite` VALUES(NUll," & matriculetxt.Value & ",'" & dr.Text & "','" & anne1.Text & "','" & ane1.Text & "','" & anne2.Text & "','" & ane2.Text & "','" & anne3.Text & "','" & ane3.Text & "','" & anne4.Text & "','" & ane4.Text & "','" & anne5.Text & "','" & ane5.Text & "','" & rapel.Text & "');", True)
                    IsConnected("UPDATE employes SET etat_emp=2 WHERE Matricule=" & matriculetxt.Value & " LIMIT 1", True)
                    'retraitePrint.matricule = matriculetxt.Value
                    'retraitePrint.MdiParent = Mainfrm
                    'retraitePrint.Show()
                Catch ex As Exception
                    Throw ex
                Finally
                    ds.EnforceConstraints = True
                End Try
            End If
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub
End Class