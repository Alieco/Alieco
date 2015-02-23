Imports DevComponents.DotNetBar

Public Class CalculeDeVariable
    Dim moianpr As String = ""
    Dim annee As String = ""
    Dim annee1 As String = ""
    Public sass As Boolean = False
    Public sai As Boolean = False
    Public gain As Boolean = False
    Private Sub mat_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mat.TextChanged
        Try
            If mat.Text.Length = 5 Then
                ListView1.Items.Clear()
                IsConnected("SELECT * FROM Employes WHERE Matricule=" & mat.Text, False)
                If myDR.HasRows = True Then
                    While (myDR.Read)
                        nom.Text = myDR("Nom").ToString
                        prenom.Text = myDR("Prénom").ToString
                        fonction.Text = myDR("Fonction").ToString
                        ech.Text = myDR("Ech").ToString
                        cat.Text = myDR("Cat").ToString
                        sb.Text = myDR("S_B_01_14").ToString
                        If IsNumeric(sb.Text) Then
                            nbheure.Text = String.Format("{0:0.00}", (sb.Text / 173.33))
                        End If
                        service.Text = myDR("service").ToString
                        sf.Text = myDR("sit_fam").ToString
                        GroupBox2.Enabled = True
                    End While
                End If
            End If
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub

    Private Sub ButtonX3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX3.Click
        Try
            If IsNumeric(valeur.Text) Then
                Dim val As Double = valeur.Text.Replace(".", ",")
                Dim List As ListViewItem = New ListViewItem("012", 0)
                List.SubItems.Add("VARIABLE 4EM TRIM " & annee1)
                List.SubItems.Add("")
                List.SubItems.Add("")
                List.SubItems.Add(Math.Round((val * 1), 2))
                List.SubItems.Add(Math.Round((val * 1), 2))
                List.SubItems.Add(Math.Round((valeur.Text.Replace(".", ",") * 1), 2))
                List.SubItems.Add("")
                ListView1.Items.Add(List)
                Dim List2 As ListViewItem = New ListViewItem("012", 0)
                List2.SubItems.Add("VARIABLE 4EM TRIM " & annee1)
                List2.SubItems.Add("")
                List2.SubItems.Add("")
                List2.SubItems.Add(Math.Round((val * 1), 2))
                List2.SubItems.Add(Math.Round((val * 1), 2))
                List2.SubItems.Add(Math.Round((valeur.Text.Replace(".", ",") * 1), 2))
                List2.SubItems.Add("")
                ListView1.Items.Add(List2)
                Dim List3 As ListViewItem = New ListViewItem("012", 0)
                List3.SubItems.Add("VARIABLE 4EM TRIM " & annee1)
                List3.SubItems.Add("")
                List3.SubItems.Add("")
                List3.SubItems.Add(Math.Round((val * 1), 2))
                List3.SubItems.Add(Math.Round((val * 1), 2))
                List3.SubItems.Add(Math.Round((valeur.Text.Replace(".", ",") * 1), 2))
                List3.SubItems.Add("")
                ListView1.Items.Add(List3)
                Dim List4 As ListViewItem = New ListViewItem("012", 0)
                List4.SubItems.Add("VARIABLE 4EM TRIM " & annee1)
                List4.SubItems.Add("")
                List4.SubItems.Add("")
                List4.SubItems.Add(Math.Round((val * 1), 2))
                List4.SubItems.Add(Math.Round((val * 1), 2))
                List4.SubItems.Add(Math.Round((valeur.Text.Replace(".", ",") * 1), 2))
                List4.SubItems.Add("")
                ListView1.Items.Add(List4)
                Dim List1 As ListViewItem = New ListViewItem("980", 1)
                List1.SubItems.Add("I. R. G.")
                List1.SubItems.Add("")
                List1.SubItems.Add("")
                List1.SubItems.Add("")
                List1.SubItems.Add("")
                List1.SubItems.Add("")
                List1.SubItems.Add(Math.Round((valeur.Text.Replace(".", ",") * 0.1), 2))
                ListView1.Items.Add(List1)
                Dim s2 As Double = 0
                Dim r2 As Double = 0
                For i = 0 To ListView1.Items.Count - 1
                    If ListView1.Items.Item(i).SubItems(5).Text <> "" Then
                        If ListView1.Items.Item(i).SubItems(7).Text <> "" Then
                            r2 += ListView1.Items.Item(i).SubItems(5).Text
                        Else
                            s2 += ListView1.Items.Item(i).SubItems(5).Text.Replace(".", ",")
                        End If
                    End If
                Next
                totalss.Text = s2 - r2
                Dim s3 As Double = 0
                For i = 0 To ListView1.Items.Count - 1
                    If ListView1.Items.Item(i).SubItems(6).Text <> "" Then
                        s3 += ListView1.Items.Item(i).SubItems(6).Text.Replace(".", ",")
                    End If
                Next
                totalgain.Text = s3

                totalas.Text = totalss.Text - ((totalss.Text * 0.08) + (totalss.Text * 0.01))
                Dim s4 As Double = 0
                For i = 0 To ListView1.Items.Count - 1
                    If ListView1.Items.Item(i).SubItems(4).Text <> "" And ListView1.Items.Item(i).SubItems(5).Text = "" And ListView1.Items.Item(i).SubItems(7).Text = "" Then
                        s4 += ListView1.Items.Item(i).SubItems(4).Text
                    End If
                Next
                totalas.Text += Math.Round(s4, 2)
                totalas.Text = Math.Round((totalas.Text + 0.01), 2)
                Console.WriteLine(totalas.Text)
                Dim abs As Double = 0
                Dim sab As Double = 0
                Dim s5 As Double = 0
                For i = 0 To ListView1.Items.Count - 1
                    If ListView1.Items.Item(i).SubItems(7).Text <> "" Then
                        s5 += ListView1.Items.Item(i).SubItems(7).Text.Replace(".", ",")
                    End If
                Next
                totalretenue.Text = Math.Round(s5, 2)
                netpayer.Text = totalgain.Text - totalretenue.Text
            Else : MessageBoxEx.Show("Veuillez saisir une valeur numerique", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub

    Private Sub CalculeDeVariable_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            load_direction()
            annee = Date.Now.ToString("yyyy")
            annee1 = annee - 1
            moianpr = Date.Now.ToString("MM") - 1
            If moianpr.Length = 1 Then moianpr = "0" & moianpr & Date.Now.ToString("yyyy")
            datej.Text = Date.Now.ToString("MMyyyy")
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub
    Private Sub load_direction()
        Try
            If IsConnected("SELECT DISTINCT liborg FROM paie_direction ", False) = True Then
                If myDR.HasRows = True Then
                    direction.Items.Clear()
                    While (myDR.Read())
                        direction.Items.Add(myDR("liborg"))
                    End While
                End If
            End If
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub
End Class