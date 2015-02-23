Imports DevComponents.DotNetBar

Public Class CurriculumVitae
    Dim Sql As New SQLControl
    Private Sub ButtonX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX1.Click
        Try
            Dim gen = "Homme"
            If radiofemme.Checked = True Then
                gen = "Femme"
            Else
                gen = "Homme"
            End If
            Dim query As String = "INSERT INTO Gestioncv (Matricule,Nom,Prénom,DateDemande,DateEnreg,DateNais,Commune,Résidence,Diplome,Specialite,NumTel,Age1,Niveau,SN,Sexe,SitFam,Option1)VALUES ('" & mat.Text & "','" & nom.Text & "', '" & prenom.Text & "', '" & DateTimeInput2.Text & "', '" & DateTimeInput1.Text & "','" & datenais.Text & "','" & com.Text & "','" & resd.Text & "','" & dip.Text & "','" & spec.Text & "','" & numtel.Text & "', '" & agetxt.Text & "', '" & niveau.Text & "','" & sn.Text & "','" & gen & "','" & situationf.Text & "', '" & opt.Text & "')"
            If IsConnected(query, False) = True Then
                MessageBoxEx.Show("Le CV  a bien été enregistrer", "Succés", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            Sql.RunQuery("select * from Gestioncv")
            If Sql.SQLDS.Tables.Count > 0 Then
                dgvcvs.DataSource = Sql.SQLDS.Tables(0)
            End If
            load_mat()
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub
    Private Sub load_mat()
        Try
            If IsConnected("SELECT * FROM Gestioncv ", False) = True Then
                If myDR.HasRows = True Then
                    While (myDR.Read())
                        mat.Text = myDR("Matricule").ToString
                    End While
                End If
            End If
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub

    Private Sub ButtonX2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX2.Click
        Try
            If MessageBoxEx.Show("Voullez vous vraiment initialiser cette formulaire ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                Dim frm = New CurriculumVitae
                frm.MdiParent = Mainfrm
                frm.Show()
                Me.Close()
            End If
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub

    Private Sub datenais_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles datenais.ValueChanged
        Try
            Dim age As String = datenais.Value
            age = Math.Floor(DateDiff(DateInterval.Month, DateValue(age), Now()) / 12)
            agetxt.Text = age.ToString & " ans"
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub

    Private Sub CV_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Me.WindowState = FormWindowState.Maximized
            load_region()
            load_mat()
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub
    Private Sub load_region()
        Try
            If IsConnected("SELECT * FROM willaya ", False) = True Then
                If myDR.HasRows = True Then
                    resd.Items.Clear()
                    While (myDR.Read())
                        resd.Items.Add(myDR("willaya"))
                    End While
                End If
            End If
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub
End Class