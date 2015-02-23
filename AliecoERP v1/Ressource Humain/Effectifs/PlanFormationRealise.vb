Public Class PlanFormationRealise

    Private Sub ButtonX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX1.Click
        If CheckBoxX1.Checked Then
            Dim que As String = "update Planformation set EtatFormation='2' where idFormation=" & idtxt.Text & " limit 1"
            IsConnected(que, False)
        Else : Dim qu As String = "update Planformation set realise='1' WHERE Specialite = '" & specialite.Text & "' and NatureFormation= '" & natureformation.Text & "' and idFormation=" & idtxt.Text & " limit 1"
            IsConnected(qu, False)
            Dim q As String = "INSERT INTO Planformation (Specialite,NatureFormation,EffectifPrevu,Alternance,Duree,DateDebut,CoutTTC,Lieu,EtatFormation,realise,year)VALUES ('" & mysql_escape_string(specialite.Text) & "', '" & mysql_escape_string(natureformation.Text) & "'," & prevu.Value & ",'" & alternance.Text & "' ,'" & mysql_escape_string(duree.Text) & "' ,'" & datedebut.Text & "' ,'" & cout.Text & "','" & lieu.Text & "','1','1',NOW())"
            IsConnected(q, False)
        End If
    End Sub

    Private Sub ComboBoxEx1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles specialite.SelectedIndexChanged
        If specialite.SelectedIndex > -1 And natureformation.SelectedIndex > -1 Then
            Dim querry As String
            querry = "select * from Planformation WHERE Specialite like '%" & specialite.Text & "%' and NatureFormation like'%" & natureformation.Text & "%'"
            IsConnected(querry, False)
            If myDR.HasRows = True Then
                While (myDR.Read())
                    prevu.Value = myDR("effectifPrevu")
                    alternance.Text = myDR("Alternance")
                    duree.Text = myDR("Duree")
                    datedebut.Text = myDR("DateDebut")
                    cout.Text = myDR("coutTTC")
                    lieu.Text = myDR("Lieu")
                    idtxt.Text = myDR("idFormation").ToString
                End While
            End If
        End If
    End Sub

    Private Sub natureformation_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles natureformation.SelectedIndexChanged
        If specialite.SelectedIndex > -1 And natureformation.SelectedIndex > -1 Then
            Dim querry As String
            querry = "select * from Planformation WHERE Specialite like '%" & specialite.Text & "%' and NatureFormation like'%" & natureformation.Text & "%'"
            IsConnected(querry, False)
            If myDR.HasRows = True Then
                While (myDR.Read())
                    prevu.Value = myDR("effectifPrevu")
                    alternance.Text = myDR("Alternance")
                    duree.Text = myDR("Duree")
                    datedebut.Text = myDR("DateDebut")
                    cout.Text = myDR("coutTTC")
                    lieu.Text = myDR("Lieu")
                    idtxt.Text = myDR("idFormation").ToString
                End While
            End If
        End If
    End Sub

    Private Sub PlanFormationRealise_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        'Dim spe() As String = {"Cadre", "Maitrise", "Execution"}
        'specialite.Items.AddRange(spe)
        load_nf()
        load_spec()
    End Sub
    Private Sub load_nf()
        If IsConnected("SELECT DISTINCT(NatureFormation) FROM Planformation ", False) = True Then
            If myDR.HasRows = True Then
                While (myDR.Read())
                    natureformation.Items.Add(myDR("NatureFormation"))
                End While
            End If
        End If
    End Sub
    Private Sub load_spec()
        If IsConnected("SELECT DISTINCT(Specialite) FROM Planformation ", False) = True Then
            If myDR.HasRows = True Then
                specialite.Items.Clear()
                While (myDR.Read())
                    specialite.Items.Add(myDR("Specialite"))
                End While
            End If
        End If
    End Sub
    Private Sub ButtonX2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX2.Click
        Dim ds1 As Formationdst = New Formationdst
        ds1.EnforceConstraints = False
        Try
            ' Attempt to fill the dataset MainTable
            ds1.PFormation.Clear()
            IsConnected("SELECT Specialite,NatureFormation,Effectifprevu,Alternance,Duree,DateDebut,CoutTTC, Lieu FROM Planformation WHERE EtatFormation='1' ORDER BY NatureFormation ASC", False)
            If myDR.HasRows Then

                While myDR.Read
                    ds1.PFormation.AddPFormationRow(IIf(IsDBNull(myDR("Specialite")), "", myDR("Specialite")), IIf(IsDBNull(myDR("NatureFormation")), "", myDR("NatureFormation")), IIf(IsDBNull(myDR("Effectifprevu")), "", CDbl(myDR("Effectifprevu"))), IIf(IsDBNull(myDR("Alternance")), "", myDR("Alternance")), IIf(IsDBNull(myDR("Duree")), "", myDR("Duree")), IIf(IsDBNull(myDR("DateDebut")), "", myDR("DateDebut")), IIf(IsDBNull(myDR("CoutTTC")), "", CDbl(Val(myDR("CoutTTC")))), IIf(IsDBNull(myDR("Lieu")), "", myDR("Lieu")))
                End While
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            ds1.EnforceConstraints = True
        End Try
        Dim cr As FormationRéaliserRP = New FormationRéaliserRP
        ' Set the report DataSet   
        cr.DataSource = ds1
        DocumentViewer1.DocumentSource = cr
        cr.createDocument(True)
    End Sub

    Private Sub CheckBoxX1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBoxX1.CheckedChanged
        If CheckBoxX1.Checked Then
            specialite.Enabled = False
            natureformation.Enabled = False
            alternance.Enabled = False
            prevu.Enabled = False
            datedebut.Enabled = False
            cout.Enabled = False
            duree.Enabled = False
            lieu.Enabled = False
        Else
            specialite.Enabled = True
            natureformation.Enabled = True
            alternance.Enabled = True
            prevu.Enabled = True
            datedebut.Enabled = True
            cout.Enabled = True
            duree.Enabled = True
            lieu.Enabled = True
        End If
    End Sub

    Private Sub ButtonX4_Click(sender As System.Object, e As System.EventArgs) Handles ButtonX4.Click
        Formation.ShowDialog()
    End Sub
End Class