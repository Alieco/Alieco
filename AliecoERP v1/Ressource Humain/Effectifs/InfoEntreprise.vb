Imports DevComponents.DotNetBar

Public Class InfoEntreprise
    Dim id_direction As String = "0"
    Dim codedep As String = ""
    Dim codedepearte As String = ""
    Private Sub entreprise_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            'Me.WindowState = FormWindowState.Maximized
            load_info()
            load_direction()
            load_service()
            load_departement()
            load_souservice()
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub
#Region "loading"
    Private Sub load_info()
        Try
            If IsConnected("SELECT * FROM Company ", False) = True Then
                If myDR.HasRows = True Then
                    While (myDR.Read())
                        nomtxt.Text = myDR("nom_entreprise")
                        adresstxt.Text = myDR("addres_entreprise")
                        teletxt.Text = myDR("tele_entreprise")
                        faxtxt.Text = myDR("fax_entreprise")
                        sitetxt.Text = myDR("site_entreprise")
                        agence.Text = myDR("agence")
                        nadherent.Text = myDR("nadherent")
                        centrep.Text = myDR("centrep")
                    End While
                End If
            End If
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub
    Private Sub load_departement()
        Try
            departementCmb.Items.Clear()
            departementComboBoxEx5.Items.Clear()
            ComboBoxEx5.Items.Clear()
            If IsConnected("SELECT * FROM departement ", False) = True Then
                If myDR.HasRows = True Then
                    While (myDR.Read())
                        departementCmb.Items.Add(myDR("code_departement") & " - " & myDR("name_departement"))
                        departementComboBoxEx5.Items.Add(myDR("code_departement") & " - " & myDR("name_departement"))
                        ComboBoxEx5.Items.Add(myDR("code_departement") & " - " & myDR("name_departement"))
                    End While
                End If
            End If
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub
    Private Sub load_direction()
        Try
            DirectionCmb.Items.Clear()
            directionComboBoxEx4.Items.Clear()
            ComboBoxEx3.Items.Clear()
            ComboBoxEx4.Items.Clear()
            If IsConnected("SELECT * FROM direction ", False) = True Then
                If myDR.HasRows = True Then
                    DirectionCmb.Items.Clear()
                    While (myDR.Read())
                        Dim s = myDR("code_direction") & " - " & myDR("name_direction")
                        DirectionCmb.Items.Add(s)
                        directionComboBoxEx4.Items.Add(s)
                        ComboBoxEx3.Items.Add(s)
                        ComboBoxEx4.Items.Add(s)
                        ' directionComboBoxEx1.Text = myDR("name_direction")
                    End While
                End If
            End If
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub
    Private Sub load_service()
        Try
            If IsConnected("SELECT  *  FROM services ", False) = True Then
                If myDR.HasRows = True Then
                    ServiceCmb.Items.Clear()
                    ComboBoxEx1.Items.Clear()
                    While (myDR.Read())
                        ServiceCmb.Items.Add(myDR("code_service") & " - " & myDR("name_service"))
                        ComboBoxEx1.Items.Add(myDR("code_service") & " - " & myDR("name_service"))
                    End While
                End If
            End If
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub
    Private Sub load_souservice()
        Try
            codesssCmb.Items.Clear()
            If IsConnected("SELECT *  FROM souservice ", False) = True Then
                If myDR.HasRows = True Then
                    While (myDR.Read())
                        codesssCmb.Items.Add(myDR("code_souservice") & " - " & myDR("name_souservice"))
                        'namesss.Text = myDR("name_souservice")
                    End While
                End If
            End If
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub
#End Region

    Private Sub ButtonX2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX2.Click
        Try
            If IsConnected("SELECT * FROM Company ", False) = True Then
                If myDR.HasRows = True Then
                    IsConnected("UPDATE Company SET nom_entreprise = '" & mysql_escape_string(nomtxt.Text.Trim) & "' , addres_entreprise = '" & mysql_escape_string(adresstxt.Text) & "', tele_entreprise = '" & teletxt.Text & "' , fax_entreprise = '" & faxtxt.Text & "' , site_entreprise = '" & mysql_escape_string(sitetxt.Text) & "' , agence = '" & mysql_escape_string(agence.Text) & "' , centrep = '" & mysql_escape_string(centrep.Text) & "' , nadherent = '" & mysql_escape_string(nadherent.Text) & "'", True)
                Else
                    IsConnected("INSERT INTO Company VALUES ('" & mysql_escape_string(nomtxt.Text) & "' , '" & mysql_escape_string(adresstxt.Text) & "', '" & teletxt.Text & "' , '" & faxtxt.Text & "' , '" & mysql_escape_string(sitetxt.Text) & "', '" & mysql_escape_string(agence.Text) & "', '" & mysql_escape_string(centrep.Text) & "', '" & mysql_escape_string(nadherent.Text) & "')", True)
                End If
            End If

            MessageBoxEx.Show("Le changement a bien été enregistré", "success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub

    Private Sub TextBoxX2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles directiontxt.TextChanged
        Try
            If directiontxt.Text <> "" Then
                ButtonX1.Enabled = True
            Else
                ButtonX1.Enabled = False
            End If
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub

    Private Sub TextBoxX3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles departementtxt.TextChanged
        Try
            If departementtxt.Text <> "" Then
                ButtonX3.Enabled = True
            Else
                ButtonX3.Enabled = False
            End If
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub

    Private Sub TextBoxX5_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles servicetxt.TextChanged
        Try
            If servicetxt.Text <> "" Then
                ButtonX4.Enabled = True
            Else
                ButtonX4.Enabled = False
            End If
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub

    Private Sub ButtonX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX1.Click
        Try
            If directiontxt.Text <> "" And TextBoxX1.Text <> "" Then
                Try
                    'code.Items.Clear()
                    'directionComboBoxEx1.Clear()
                    'load_direction()
                    IsConnected("INSERT INTO direction (name_direction,code_direction) VALUES ('" & mysql_escape_string(directiontxt.Text) & "','" & mysql_escape_string(TextBoxX1.Text) & "')", True)
                    MessageBoxEx.Show("La Direction a bien été enregistré", "success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    directiontxt.Clear()
                    TextBoxX1.Clear()
                    load_direction()
                Catch ex As Exception
                End Try
            ElseIf directiontxt.Text <> "" And TextBoxX1.Text = "" Then
                MessageBoxEx.Show("veuillez remplir le code de la direction")
            ElseIf directiontxt.Text = "" And TextBoxX1.Text <> "" Then
                MessageBoxEx.Show("veuillez remplir le nom de la direction")
            Else : MessageBoxEx.Show("veuillez remplir le nom et le code de la direction")
            End If
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub


    Private Sub ButtonX3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX3.Click
        Try
            If departementtxt.Text <> "" And TextBoxX4.Text <> "" And directionComboBoxEx4.SelectedIndex > -1 Then
                Try
                    Dim codecire = directionComboBoxEx4.Text.Split(" - ")
                    IsConnected("INSERT INTO departement VALUES (NULL,'" & mysql_escape_string(departementtxt.Text) & "', '" & codecire(0) & "','" & mysql_escape_string(TextBoxX4.Text) & "')", True)
                    MessageBoxEx.Show("Le Département a bien été enregistré", "success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    departementtxt.Clear()
                    directionComboBoxEx4.Text = ""
                    TextBoxX4.Clear()
                    load_departement()
                Catch ex As Exception

                End Try
            Else
                MessageBoxEx.Show("Vous devez choisir une direction a qui appartient ce département", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub


    Private Sub directionComboBoxEx4_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles directionComboBoxEx4.SelectedIndexChanged
        Try
            'departementtxtt.Text = directionComboBoxEx4.SelectedItem.ToString
            If IsConnected("SELECT name_direction FROM direction WHERE name_direction='" & mysql_escape_string(directionComboBoxEx4.Text) & "'", False) = True Then
                If myDR.HasRows = True Then
                    While (myDR.Read())
                        directionComboBoxEx4.Text = myDR("liborg")
                    End While
                End If
            End If
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub

    Private Sub departementComboBoxEx5_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles departementComboBoxEx5.SelectedIndexChanged
        Try
            ' servicetxtt.Text = departementComboBoxEx5.SelectedItem.ToString
            Dim dep = departementComboBoxEx5.Text.Split(" - ")
            codedepearte = dep(0)
            If IsConnected("SELECT * FROM departement WHERE code_departement='" & dep(0) & "'", False) = True Then
                If myDR.HasRows = True Then
                    While (myDR.Read())
                        codedep = myDR("code_direction")
                    End While
                End If
            End If
            If IsConnected("SELECT * FROM direction WHERE code_direction='" & codedep & "'", False) = True Then
                If myDR.HasRows = True Then
                    While (myDR.Read())
                        ComboBoxEx3.Text = myDR("code_direction") & " - " & myDR("name_direction")
                    End While
                End If
            End If
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub
    Private Sub ButtonX4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX4.Click
        Try
            If servicetxt.Text <> "" And TextBoxX5.Text <> "" Then
                Dim id_deparement As String = "0"
                Try
                    IsConnected("INSERT INTO services  VALUES (NULL,'" & mysql_escape_string(servicetxt.Text) & "','" & codedepearte & "','" & TextBoxX5.Text & "','" & codedep & "')", True)
                    MessageBoxEx.Show("Le Service a bien été enregistré", "success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    servicetxt.Clear()
                    TextBoxX5.Clear()
                    departementComboBoxEx5.Text = ""
                    ComboBoxEx3.Text = ""
                    load_service()
                Catch ex As Exception

                End Try
            Else
                MessageBoxEx.Show("Vous devez choisir un département a qui appartient ce service", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub
    Private Sub ButtonX5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX5.Click
        Try
            If ssservice.Text <> "" And codessservice.Text <> "" Then
                Dim id_dep As String = ""
                Dim id_direc As String = ""
                Dim id_servi As String = ""
                IsConnected("SELECT * FROM services where name_service='" & ComboBoxEx1.Text & "'", False)
                If myDR.HasRows = True Then
                    While (myDR.Read())
                        id_servi = myDR("code_service")
                        id_direc = myDR("code_direction")
                        id_dep = myDR("code_departement")
                    End While
                End If
                IsConnected("SELECT * FROM departement where code_departement='" & id_dep & "'", False)
                If myDR.HasRows = True Then
                    While (myDR.Read())
                        ComboBoxEx5.Text = myDR("name_departement")
                    End While
                End If
                IsConnected("SELECT * FROM direction where code_direction='" & id_direc & "'", False)
                If myDR.HasRows = True Then
                    While (myDR.Read())
                        ComboBoxEx4.Text = myDR("name_direction")
                    End While
                End If
                Try
                    IsConnected("INSERT INTO souservice VALUES (NULL,'" & mysql_escape_string(ssservice.Text) & "','" & id_servi & "','" & id_dep & "','" & id_direc & "','" & mysql_escape_string(codessservice.Text) & "')", True)
                    MessageBoxEx.Show("Le sous Service a bien été enregistré", "success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    servicetxt.Clear()
                    codessservice.Clear()
                    ComboBoxEx5.Text = ""
                    ComboBoxEx1.Text = ""
                    ComboBoxEx4.Text = ""
                    ssservice.Clear()
                Catch ex As Exception

                End Try
            Else
                MessageBoxEx.Show("Vous devez choisir un département a qui appartient ce service", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
            load_direction()
            load_service()
            load_departement()
            load_souservice()
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub

    Private Sub code_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DirectionCmb.SelectedIndexChanged
        Try
            Try
                If DirectionCmb.SelectedIndex > -1 Then
                    Dim s = DirectionCmb.Text.Split("-")
                    directionComboBoxEx1.Text = s(0)
                Else
                    directionComboBoxEx1.Text = ""
                End If

            Catch ex As Exception
                EnvoiError(ex.Message)
            End Try
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub

    Private Sub departementComboBoxEx2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles departementCmb.SelectedIndexChanged
        Try
            Try
                If departementCmb.SelectedIndex > -1 Then
                    Dim s = departementCmb.Text.Split("-")
                    departementtxtt.Text = s(0)
                Else
                    departementtxtt.Text = ""
                End If

            Catch ex As Exception
                EnvoiError(ex.Message)
            End Try
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub

    Private Sub ssservice_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ssservice.TextChanged
        ButtonX5.Enabled = True
    End Sub

    Private Sub ComboBoxEx1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBoxEx1.TextChanged
        Try
            Dim dep = ComboBoxEx1.Text.Split(" - ")
            codedepearte = dep(0)
            Dim cdep, cdir As String
            IsConnected(" SELECT * FROM Services where code_service='" & dep(0) & "' limit 1", False)
            If myDR.HasRows Then
                While myDR.Read
                    cdep = myDR("code_departement").ToString
                    cdir = myDR("code_direction").ToString
                    If IsConnected("SELECT * FROM departement WHERE code_departement='" & cdep & "'", False) = True Then
                        If myDR.HasRows = True Then

                            While (myDR.Read())
                                ComboBoxEx5.Text = (myDR("code_departement") & " - " & myDR("name_departement"))
                            End While
                        End If
                    End If
                    If IsConnected("SELECT * FROM direction WHERE code_direction='" & cdir & "'", False) = True Then
                        If myDR.HasRows = True Then
                            While (myDR.Read())
                                ComboBoxEx4.Text = myDR("code_direction") & " - " & myDR("name_direction")
                            End While
                        End If
                    End If
                End While
            End If
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub

    Private Sub DirectionCmb_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DirectionCmb.TextChanged
        directionComboBoxEx1.Text = ""
    End Sub

    Private Sub directionComboBoxEx1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles directionComboBoxEx1.TextChanged
        If directionComboBoxEx1.Text.Length > 0 Then
            DirectionremoveBtn.Enabled = True
        Else
            DirectionremoveBtn.Enabled = False
        End If
    End Sub

    Private Sub DirectionremoveBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DirectionremoveBtn.Click
        If MessageBoxEx.Show("Voullez vous vraiment supprimer cette Direction ?", "confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            If IsConnected("DELETE FROM `direction` WHERE `code_direction`='" & mysql_escape_string(directionComboBoxEx1.Text) & "' LIMIT 1;", True) Then
                MessageBoxEx.Show("La Direction est supprimé avec succés", "Suppression réussi", MessageBoxButtons.OK, MessageBoxIcon.Information)
                DirectionremoveBtn.Enabled = False
                DirectionCmb.Text = ""
                directionComboBoxEx1.Text = ""
                load_direction()
            End If
        End If
    End Sub

    Private Sub departementtxtt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles departementtxtt.TextChanged
        If departementtxtt.Text.Length > 0 Then
            DepartementRemoveBtn.Enabled = True
        Else
            DepartementRemoveBtn.Enabled = False
        End If
    End Sub

    Private Sub departementCmb_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles departementCmb.TextChanged
        departementtxtt.Text = ""
    End Sub

    Private Sub DepartementRemoveBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DepartementRemoveBtn.Click
        If MessageBoxEx.Show("Voullez vous vraiment supprimer ce département ?", "confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            If IsConnected("DELETE FROM `departement` WHERE `code_departement`='" & mysql_escape_string(departementtxtt.Text) & "' LIMIT 1;", True) Then
                MessageBoxEx.Show("Le département est supprimé avec succés", "Suppression réussi", MessageBoxButtons.OK, MessageBoxIcon.Information)
                DepartementRemoveBtn.Enabled = False
                departementCmb.Text = ""
                departementtxtt.Text = ""
                load_departement()
            End If
        End If
    End Sub

    Private Sub ServiceCmb_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ServiceCmb.SelectedIndexChanged
        Try
            If ServiceCmb.SelectedIndex > -1 Then
                Dim s = ServiceCmb.Text.Split("-")
                servicetxtt.Text = s(0)
            Else
                servicetxtt.Text = ""
            End If

        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub

    Private Sub servicetxtt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles servicetxtt.TextChanged
        If servicetxtt.Text.Length > 0 Then
            ServiceRemoveBtn.Enabled = True
        Else
            ServiceRemoveBtn.Enabled = False
        End If
    End Sub

    Private Sub ServiceCmb_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ServiceCmb.TextChanged
        servicetxtt.Text = ""
    End Sub

    Private Sub ServiceRemoveBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ServiceRemoveBtn.Click
        If MessageBoxEx.Show("Voullez vous vraiment supprimer ce Service ?", "confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            If IsConnected("DELETE FROM `services` WHERE `code_service`='" & mysql_escape_string(servicetxtt.Text) & "' LIMIT 1;", True) Then
                MessageBoxEx.Show("Le Service est supprimé avec succés", "Suppression réussi", MessageBoxButtons.OK, MessageBoxIcon.Information)
                ServiceRemoveBtn.Enabled = False
                ServiceCmb.Text = ""
                servicetxtt.Text = ""
                load_service()
            End If
        End If
    End Sub

    Private Sub codesssCmb_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles codesssCmb.SelectedIndexChanged
        Try
            If codesssCmb.SelectedIndex > -1 Then
                Dim s = codesssCmb.Text.Split("-")
                SSTxt.Text = s(0)
            Else
                SSTxt.Text = ""
            End If

        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub

    Private Sub SSTxt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SSTxt.TextChanged
        If SSTxt.Text.Length > 0 Then
            SousrviceRemoveBtn.Enabled = True
        Else
            SousrviceRemoveBtn.Enabled = False
        End If
    End Sub

    Private Sub codesssCmb_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles codesssCmb.TextChanged
        SSTxt.Text = ""
    End Sub

    Private Sub SousrviceRemoveBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SousrviceRemoveBtn.Click
        If MessageBoxEx.Show("Voullez vous vraiment supprimer ce Sous-Service ?", "confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            If IsConnected("DELETE FROM `souservice` WHERE `code_souservice`='" & mysql_escape_string(SSTxt.Text) & "' LIMIT 1;", True) Then
                MessageBoxEx.Show("Le Sous-Service est supprimé avec succés", "Suppression réussi", MessageBoxButtons.OK, MessageBoxIcon.Information)
                SousrviceRemoveBtn.Enabled = False
                codesssCmb.Text = ""
                SSTxt.Text = ""
                load_souservice()
            End If
        End If
    End Sub
End Class