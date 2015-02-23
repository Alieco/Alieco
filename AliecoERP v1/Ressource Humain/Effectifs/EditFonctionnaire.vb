Imports DevComponents.DotNetBar

Public Class EditFonctionnaire

    Private Sub ButtonX2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX2.Click
        Me.Close()
    End Sub

    Private Sub EditFonctionnaire_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Me.WindowState = FormWindowState.Maximized
            Dim j As Integer
            For i = 0 To 15
                ech.Items.Add(i)
            Next
            j = 1
            While j < 21
                cat.Items.Add(j)
                j = j + 1
                If j = 21 Then
                    cat.Items.Add("CS")
                End If
            End While

            load_departement()
            load_direction()
            load_service()
            load_region()
            load_fonction()
            load_hall()
            'load_equipe()
            load_niveau()
            Dim fonc As Integer = 0
            Dim niv As Integer = 0
            Dim dep As Integer = 0
            Dim hal As Integer = 0
            Dim direc As Integer = 0
            Dim servi As Integer = 0
            Dim equip As Integer = 0
            Dim eche As String = ""
            Dim reg1 As Integer = 0
            Dim sitfam As Integer = 0
            Dim reg2 As Integer = 0

            If mat.Text <> "" Then
                IsConnected("SELECT * FROM Employes WHERE Matricule='" & mat.Text & "'", False)
                If myDR.HasRows = True Then
                    While (myDR.Read)
                        Try
                            nom.Text = myDR("Nom").ToString
                            prenom.Text = myDR("Prénom").ToString
                            adresse.Text = myDR("Adresse").ToString
                            lnais.Text = myDR("Lieux_de_Naissance").ToString
                            datenais.Value = myDR("Date_de_Naissance").ToString
                            agetxt.Text = dateToAge(myDR("Date_de_Naissance"))
                            ' numtel.Text = myDR("NumTel").ToString
                            DateEntry.Value = myDR("Date_entrée")
                            entxt.Text = dateToAge(myDR("Date_entrée"))
                            If (myDR("Date_entrée_1").ToString) = Nothing Then
                                DateTimeInput2.Value = Nothing
                            Else
                                DateTimeInput2.Value = myDR("Date_entrée_1").ToString
                            End If
                            DateTimeInput3.Text = myDR("Date_fin_de_contrat").ToString
                            nc.Text = myDR("NC").ToString
                            groupe.Text = myDR("Groupe").ToString
                            collect.Text = myDR("Collectif").ToString
                            motif_recru.Text = myDR("Motif_de_Recrut").ToString
                            service_national.Text = myDR("Service_national").ToString
                            collectif.Text = myDR("Collectif_prc").ToString
                            statut.Text = myDR("Statut").ToString
                            sal.Text = myDR("Salissure").ToString
                            pen.Text = myDR("Pénibilité").ToString
                            ins.Text = myDR("Insalubrité").ToString
                            danger.Text = myDR("Danger").ToString
                            niveau.Text = myDR("Niveau").ToString
                            directionComboBoxEx1.Text = myDR("Direction").ToString
                            departementComboBoxEx2.Text = myDR("Département").ToString
                            hall.Text = myDR("Hall").ToString
                            ServiceComboBoxEx3.Text = myDR("Service").ToString
                            equipe.Text = myDR("Equipe").ToString
                            ech.Text = myDR("Ech").ToString
                            cat.Text = myDR("Cat").ToString
                            salaire.Text = myDR("S_B_01_14").ToString
                            region1.Text = myDR("Ville").ToString
                            situationf.Text = myDR("Sit_fam").ToString
                            region2.Text = myDR("Ville1").ToString
                            If myDR("Nbres_cont").ToString = "" Then
                                ncontrat.Value = "1"
                            Else : ncontrat.Value = myDR("Nbres_cont").ToString
                            End If
                            type.Text = myDR("Type").ToString
                            fmtext.Text = myDR("Formation_ext").ToString
                            fmtint.Text = myDR("Formation_int").ToString
                            fonction.Text = myDR("Fonction").ToString
                            'MsgBox(region2.SelectedIndex)
                        Catch ex As Exception
                            EnvoiError(ex.Message)
                        End Try

                    End While
                End If
                'IsConnected("SELECT * FROM Fonction WHERE titre_fonction='" & fonction.Text & "'", False)
                'If myDR.HasRows = True Then
                '    While (myDR.Read())
                '        'fonction.Text = myDR("titre_fonction")
                '        cat.Text = myDR("id_cat")
                '        ech.Text = myDR("id_ech")
                '    End While
                'End If
                'If IsNumeric(eche) Then
                '    IsConnected("SELECT ech_" & ech.Text & " FROM Grille where F1='" & cat.Text & "'", False)
                '    If myDR.HasRows = True Then
                '        While (myDR.Read())
                '            salaire.Text = myDR("ech_" & ech.Text) & ".00 DA"
                '        End While
                '    End If
                'Else
                '    IsConnected("SELECT " & eche & " FROM GrilleCS where Element='salaire_base' ", False)
                '    If myDR.HasRows = True Then
                '        While (myDR.Read())
                '            salaire.Text = myDR(eche) & ".00 DA"
                '        End While
                '    End If
                'End If
                'IsConnected("SELECT name_direction FROM Direction WHERE id_direction='" & direc & "'", False)
                'If myDR.HasRows = True Then
                '    While (myDR.Read())
                '        directionComboBoxEx1.Text = myDR("name_direction")
                '    End While
                'End If
                'IsConnected("SELECT name_departement FROM Departement WHERE id_departement='" & dep & "'", False)
                'If myDR.HasRows = True Then
                '    While (myDR.Read())
                '        departementComboBoxEx2.Text = myDR("name_departement")
                '    End While
                'End If
                'IsConnected("SELECT description_hall FROM Hall WHERE id_hall='" & hal & "'", False)
                'If myDR.HasRows = True Then
                '    While (myDR.Read())
                '        hall.Text = myDR("description_hall")
                '    End While
                'End If
                'IsConnected("SELECT name_service FROM Services WHERE id_service='" & servi & "'", False)
                'If myDR.HasRows = True Then
                '    While (myDR.Read())
                '        ServiceComboBoxEx3.Text = myDR("name_service")
                '    End While
                'End If
                'IsConnected("SELECT description_equipe FROM Equipe WHERE id_equipe='" & equip & "'", False)
                'If myDR.HasRows = True Then
                '    While (myDR.Read())
                '        equipe.Text = myDR("description_equipe")
                '    End While
                'End If
            End If
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub
    Function dateToAge(ByVal s As String) As String
        Try
            Dim strDOB As String = s
            strDOB = Math.Floor(DateDiff(DateInterval.Month, DateValue(strDOB), Now()) / 12)
            Return strDOB.ToString
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
        Return Nothing
    End Function

    Private Sub ButtonX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX1.Click
        Try
            Dim dir As Integer = 0
            Dim dep As Integer = 0
            Dim hal As Integer = 0
            Dim fon As Integer = 0
            Dim equi As Integer = 0
            Dim serv As Integer = 0
            Dim niv As Integer = 0
            Dim gen = "Homme"
            If radiofemme.Checked = True Then
                gen = "Femme"
            Else
                gen = "Homme"
            End If
            'IsConnected("SELECT * FROM Fonction where titre_fonction= '" & fonction.Text & "' ", False)
            'If myDR.HasRows = True Then
            '    While (myDR.Read())
            '        fon = myDR("id_fonction")
            '    End While
            'End If
            'IsConnected("SELECT * FROM Direction where name_direction= '" & directionComboBoxEx1.SelectedIndex & "' ", False)
            'If myDR.HasRows = True Then
            '    While (myDR.Read())
            '        dir = myDR("id_direction")
            '    End While
            'End If
            'IsConnected("SELECT * FROM Departement where name_departement= '" & departementComboBoxEx2.SelectedIndex & "' ", False)
            'If myDR.HasRows = True Then
            '    While (myDR.Read())
            '        dep = myDR("id_departement")
            '    End While
            'End If
            'IsConnected("SELECT * FROM Services where name_service= '" & ServiceComboBoxEx3.SelectedIndex & "' ", False)
            'If myDR.HasRows = True Then
            '    While (myDR.Read())
            '        serv = myDR("id_service")
            '    End While
            'End If
            'IsConnected("SELECT * FROM Hall where description_hall= '" & hall.SelectedIndex & "' ", False)
            'If myDR.HasRows = True Then
            '    While (myDR.Read())
            '        hal = myDR("id_hall")
            '    End While
            'End If
            'IsConnected("SELECT * FROM Equipe where description_equipe= '" & equipe.SelectedIndex & "' ", False)
            'If myDR.HasRows = True Then
            '    While (myDR.Read())
            '        equi = myDR("id_equipe")
            '    End While
            'End If
            'IsConnected("SELECT * FROM Niveau where description_niveau= '" & niveau.SelectedIndex & "' ", False)
            'If myDR.HasRows = True Then
            '    While (myDR.Read())
            '        niv = myDR("id_niveau")
            '    End While
            'End If
            Dim q As String = "update Employes set Nom= '" & mysql_escape_string(nom.Text) & "',Prénom = '" & mysql_escape_string(prenom.Text) & "' ,Date_de_Naissance = '" & datenais.Value & "' ,Lieux_de_Naissance='" & mysql_escape_string(lnais.Text) & "' ,Date_entrée= '" & DateEntry.Value & "' ,Date_entrée_1= '" & DateTimeInput2.Value & "' ,Equipe= '" & equipe.Text & "' , Ville='" & region1.Text & " ' ,Date_fin_de_contrat= '" & DateTimeInput3.Value & "',Age1= '" & agetxt.Text & "', Anc_1= '" & entxt.Text & "',Groupe= '" & mysql_escape_string(groupe.Text) & "',Niveau = '" & mysql_escape_string(niveau.Text) & "' , Cat='" & cat.Text & "', Ech='" & ech.Text & "' , Département='" & departementComboBoxEx2.Text & "',Service='" & ServiceComboBoxEx3.Text & "' , Hall='" & hall.Text & "',Collectif='" & collect.Text & "',Direction='" & directionComboBoxEx1.Text & "' ,Statut='" & statut.Text & "' ,NC=  '" & nc.Text & "',Sexe= '" & gen & "' ,Adresse= '" & mysql_escape_string(adresse.Text) & "',Ville1 ='" & mysql_escape_string(region2.Text) & "' ,Salissure='" & sal.Text & "',Pénibilité='" & pen.Text & "',Insalubrité='" & ins.Text & "',Danger='" & danger.Text & "' ,Nbres_cont= '" & ncontrat.Value & "',Service_national= '" & service_national.Text & "' ,Sit_fam='" & situationf.Text & "' ,Collectif_prc='" & collectif.Text & "' ,Motif_de_Recrut= '" & mysql_escape_string(motif_recru.Text) & "' ,S_B_01_14='" & salaire.Text & "',Fonction= '" & mysql_escape_string(fonction.Text) & "' ,numTel= '" & numtel.Text & "', Type='" & type.Text & "', Formation_ext='" & mysql_escape_string(fmtext.Text) & "', Formation_int='" & mysql_escape_string(fmtint.Text) & "' where Matricule=" & mat.Text & ""
            'Dim q As String = "update Employes set Matricule= '" & mat.Text & "' where Nom='" & mysql_escape_string(nom.Text) & "'"

            ' Clipboard.SetText(q)
            If IsConnected(q, False) Then
                MessageBoxEx.Show("Le fonctionnaire a bien été modifier", "Succés", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Dim frm = New EditFonctionnaire
                frm.MdiParent = Mainfrm
                frm.Show()
                Me.Close()
            End If
 Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub
#Region "fonctions"
    Private Sub load_service()
        Try
            If IsConnected("SELECT DISTINCT name_service FROM Services ", False) = True Then
                If myDR.HasRows = True Then
                    ServiceComboBoxEx3.Items.Clear()
                    While (myDR.Read())
                        ServiceComboBoxEx3.Items.Add(myDR("name_service"))
                    End While
                End If
            End If
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub

    Private Sub load_fonction()
        Try
            If IsConnected("SELECT DISTINCT titre_fonction FROM Fonction ", False) = True Then
                If myDR.HasRows = True Then
                    fonction.Items.Clear()
                    While (myDR.Read())
                        fonction.Items.Add(myDR("titre_fonction"))
                    End While
                End If
            End If
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub
    Private Sub load_equipe()
        If IsConnected("SELECT DISTINCT Equipe FROM Employes ", False) = True Then
            If myDR.HasRows = True Then
                equipe.Items.Clear()
                While (myDR.Read())
                    equipe.Items.Add(myDR("Equipe"))
                End While
            End If
        End If
    End Sub
    Private Sub load_hall()
        Try
            If IsConnected("SELECT DISTINCT Hall FROM Employes ", False) = True Then
                If myDR.HasRows = True Then
                    hall.Items.Clear()
                    While (myDR.Read())
                        hall.Items.Add(myDR("Hall"))
                    End While
                End If
            End If
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub
    Public Sub load_niveau()
        Try
            If IsConnected("SELECT DISTINCT description_niveau FROM niveau", False) = True Then
                If myDR.HasRows = True Then
                    niveau.Items.Clear()
                    While (myDR.Read())
                        niveau.Items.Add(myDR("description_niveau"))
                    End While
                End If
            End If
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub
    Private Sub load_departement()
        Try
            If IsConnected("SELECT DISTINCT name_departement FROM Departement ", False) = True Then
                If myDR.HasRows = True Then
                    departementComboBoxEx2.Items.Clear()
                    While (myDR.Read())
                        departementComboBoxEx2.Items.Add(myDR("name_departement"))
                    End While
                End If
            End If
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub
    Private Sub load_direction()
        Try
            If IsConnected("SELECT DISTINCT name_direction FROM direction ", False) = True Then
                If myDR.HasRows = True Then
                    directionComboBoxEx1.Items.Clear()
                    While (myDR.Read())
                        directionComboBoxEx1.Items.Add(myDR("name_direction"))
                    End While
                End If
            End If
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub
    Private Sub load_region()
        Try
            If IsConnected("SELECT * FROM willaya ", False) = True Then
                If myDR.HasRows = True Then
                    region1.Items.Clear()
                    region2.Items.Clear()
                    While (myDR.Read())
                        region1.Items.Add(myDR("id") & " - " & myDR("willaya"))
                        region2.Items.Add(myDR("id") & " - " & myDR("willaya"))
                    End While
                End If
            End If
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub
#End Region


    Private Sub fonction_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles fonction.SelectedIndexChanged
        Try
            IsConnected("SELECT id_Cat,id_Ech,titre_Fonction FROM Fonction where titre_Fonction='" & mysql_escape_string(fonction.Text) & "'", False)
            If myDR.HasRows = True Then
                While (myDR.Read())
                    cat.Text = myDR("id_Cat").ToString
                    ' fonction.Text = myDR("titre_Fonction").ToString
                    Dim echel = myDR("id_Ech").ToString
                    If cat.Text = "CS" Then
                        ech.Items.Clear()
                        Dim cs() As String = {"CS junior N°1", "CS junior N°2", "CS1", "CS2", "CS3", "CS4"}
                        ech.Items.AddRange(cs)
                        Select Case echel
                            Case "csjun1"
                                ech.SelectedIndex = 0
                            Case "csjun2"
                                ech.SelectedIndex = 1
                            Case "cs1"
                                ech.SelectedIndex = 2
                            Case "cs2"
                                ech.SelectedIndex = 3
                            Case "cs3"
                                ech.SelectedIndex = 4
                            Case "cs4"
                                ech.SelectedIndex = 5
                        End Select
                        ' Clipboard.SetText("SELECT " & echel & " FROM GrilleCS where Element='salaire_base' ")
                        IsConnected("SELECT " & echel & " FROM GrilleCS where Element='salaire_base' ", False)
                        If myDR.HasRows = True Then
                            While (myDR.Read())
                                salaire.Text = myDR(echel) & ".00 DA"
                            End While
                        End If
                    Else
                        ech.Items.Clear()
                        For i = 0 To 15
                            ech.Items.Add(i)
                        Next
                        ech.SelectedIndex = echel
                        IsConnected("SELECT ech_" & echel & " FROM Grille where  F1='" & cat.Text & "' ", False)
                        If myDR.HasRows = True Then
                            While (myDR.Read())
                                salaire.Text = myDR("ech_" & echel) & ".00 DA"
                            End While
                        End If

                    End If
                    'ech.Text = myDR("id_ech")

                End While
            End If
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub


    Private Sub cat_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cat.SelectedIndexChanged
        Try
            If cat.Text <> "" Then
                If cat.Text = "CS" Then
                    ech.Items.Clear()
                    Dim cs() As String = {"CS junior N°1", "CS junior N°2", "CS1", "CS2", "CS3", "CS4"}
                    ech.Items.AddRange(cs)
                    If ech.SelectedIndex > -1 Then
                        Dim col As String = ""
                        Select Case ech.SelectedIndex
                            Case 0
                                col = "csjun1"
                            Case 1
                                col = "csjun2"
                            Case 2
                                col = "cs1"
                            Case 3
                                col = "cs2"
                            Case 4
                                col = "cs3"
                            Case 5
                                col = "cs4"
                            Case Else
                                col = "csjun1"
                        End Select
                        IsConnected("SELECT " & col & " FROM GrilleCS where Element='salaire_base' ", False)
                        If myDR.HasRows = True Then
                            While (myDR.Read())
                                salaire.Text = myDR(col) & ".00 DA"
                            End While
                        End If
                    End If
                Else
                    ech.Items.Clear()
                    For i = 0 To 15
                        ech.Items.Add(i)
                    Next
                    'IsConnected("SELECT ech_" & ech.SelectedIndex.ToString & " FROM Grille where F1=" & cat.Text, False)
                    'If myDR.HasRows = True Then
                    '    While (myDR.Read())
                    '        salaire.Text = myDR("ech_" & ech.SelectedIndex) & ".00 DA"
                    '    End While

                    'End If
                End If
            End If
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub

    Private Sub ech_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ech.SelectedIndexChanged
        Try
            If cat.Text <> "" Then
                If cat.Text = "CS" Then
                    ' ech.Items.Clear()
                    Dim cs() As String = {"CS junior N°1", "CS junior N°2", "CS1", "CS2", "CS3", "CS4"}
                    ech.Items.AddRange(cs)
                    If ech.SelectedIndex > -1 Then
                        Dim col As String = ""
                        Select Case ech.SelectedIndex
                            Case 0
                                col = "csjun1"
                            Case 1
                                col = "csjun2"
                            Case 2
                                col = "cs1"
                            Case 3
                                col = "cs2"
                            Case 4
                                col = "cs3"
                            Case 5
                                col = "cs4"
                            Case Else
                                col = "csjun1"
                        End Select
                        IsConnected("SELECT " & col & " FROM GrilleCS where Element='salaire_base' ", False)
                        If myDR.HasRows = True Then
                            While (myDR.Read())
                                salaire.Text = myDR(col) & ".00 DA"
                            End While
                        End If
                    End If
                Else
                    IsConnected("SELECT ech_" & ech.SelectedIndex.ToString & " FROM Grille where F1=" & cat.Text, False)
                    If myDR.HasRows = True Then
                        While (myDR.Read())
                            salaire.Text = myDR("ech_" & ech.SelectedIndex) & ".00 DA"
                        End While

                    End If
                End If
            End If
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub

    Private Sub ButtonX3_Click(sender As System.Object, e As System.EventArgs) Handles ButtonX3.Click
        AddNiveau.ShowDialog()
    End Sub
End Class