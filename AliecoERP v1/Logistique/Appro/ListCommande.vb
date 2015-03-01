Imports DevComponents.DotNetBar

Public Class ListCommande
    Dim sql As New SQLControl
    Sub reload()
         If du.Value = Nothing Or au.Value = Nothing Then
            MessageBoxEx.Show("veuillez saisir une date", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            DGCommande.DataSource = Nothing
            If sql.VerifiyConnection = True Then
                sql.RunQuery("SELECT distinct logistique_appro_bondecommande.codebc,reference as 'Numero',nature,logistique_appro_bondecommande.type,synthese,oe,codestruc,namestruc,codefour,nomfourn as 'Nom fournisseur',logistique_appro_bcdesig.montanttotal as 'Montant total DA/TTC' FROM logistique_appro_bondecommande,logistique_appro_bcdesig,logistique_appro_fournis WHERE logistique_appro_fournis.code= logistique_appro_bcdesig.codefour and logistique_appro_bondecommande.codebc=logistique_appro_bcdesig.codebc and logistique_appro_bondecommande.dateEnreg between '" & du.Value.ToString("yyyy-MM-dd") & "' and '" & au.Value.ToString("yyyy-MM-dd") & "' and etatCommande='0'")
                ',DateBC,ref,demandeur,monnaie,delaiexe,modeexpe,modepaiem,ref_offre,logistique_appro_bcdesig.desigbc,logistique_appro_bcdesig.Qte,logistique_appro_bcdesig.pu,logistique_appro_bcdesig.montantbc,logistique_appro_bcdesig.totalht,logistique_appro_bcdesig.tva,logistique_appro_bcdesig.timbre,logistique_appro_bcdesig.tauxva,logistique_appro_bcdesig.montanttotal,logistique_appro_bondecommande.imputation,logistique_appro_bondecommande.dateEnreg 
                If sql.SQLDS.Tables.Count > 0 Then
                    DGCommande.DataSource = sql.SQLDS.Tables(0)
                Else : MessageBoxEx.Show("Aucun bon de commande n'a été enregistré a cette periode de date", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End If
        End If
    End Sub
    Sub reload1()
         If du.Value = Nothing Or au.Value = Nothing Then
            MessageBoxEx.Show("veuillez saisir une date", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
           DGCommande.DataSource = Nothing
            If sql.VerifiyConnection = True Then
                sql.RunQuery("SELECT distinct logistique_appro_bonachat.codeba,reference as 'Numero',nature,logistique_appro_bonachat.type,synthese,oe,codestruc,namestruc,codefour,nomfourn as 'Nom fournisseur',logistique_appro_badesig.montanttotal as 'Montant total DA/TTC' FROM logistique_appro_bonachat,logistique_appro_badesig,logistique_appro_fournis WHERE logistique_appro_fournis.code=logistique_appro_badesig.codefour and logistique_appro_bonachat.codeba=logistique_appro_badesig.codeba and logistique_appro_bonachat.dateEnreg between '" & du.Value.ToString("yyyy-MM-dd") & "' and '" & au.Value.ToString("yyyy-MM-dd") & "'")
                ',DateBC,ref,demandeur,monnaie,delaiexe,modeexpe,modepaiem,ref_offre,logistique_appro_bcdesig.desigbc,logistique_appro_bcdesig.Qte,logistique_appro_bcdesig.pu,logistique_appro_bcdesig.montantbc,logistique_appro_bcdesig.totalht,logistique_appro_bcdesig.tva,logistique_appro_bcdesig.timbre,logistique_appro_bcdesig.tauxva,logistique_appro_bcdesig.montanttotal,logistique_appro_bondecommande.imputation,logistique_appro_bondecommande.dateEnreg 
                If sql.SQLDS.Tables.Count > 0 Then
                    DGCommande.DataSource = sql.SQLDS.Tables(0)
                Else : MessageBoxEx.Show("Aucun bon d'achat n'a été enregistré a cette periode de date", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End If
        End If
    End Sub
    Private Sub ButtonX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX1.Click
        Try
            Dim s As New SaveFileDialog
            s.DefaultExt = "*.xlsx"
            s.Title = "Choisissez le nom de fichier d'enregistrement"
            s.Filter = "Excel 2010 | *.xlsx"
            If s.ShowDialog = Windows.Forms.DialogResult.OK Then
                DGCommande.ExportToXlsx(s.FileName)
            End If
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub

    Private Sub GoogleToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GoogleToolStripMenuItem.Click
        If RadioButton1.Checked = True Then
            reload()
            ConvertitLoffreEnAffaireToolStripMenuItem.Visible = True
        Else
            reload1()
            ConvertitLoffreEnAffaireToolStripMenuItem.Visible = False
        End If
    End Sub

    Private Sub AjouterUnNouveauOffreToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AjouterUnNouveauOffreToolStripMenuItem.Click
        Try
            If RadioButton1.Checked = True Then
                BonCommande.MdiParent = Mainfrm
                BonCommande.Show()
                'BonCommande.Text = "Ajouter un bon de commande"
                'BonCommande.GroupBox1.Text = "Bon de commande"
            Else
                BonCommande.MdiParent = Mainfrm
                BonCommande.Show()
                BonCommande.Text = "Ajouter un bon d'achat"
                BonCommande.GroupBox1.Text = "Bon d'achat"
            End If
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub

    Private Sub ModifierOffreToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ModifierOffreToolStripMenuItem.Click
        Try
            If GridView1.SelectedRowsCount = 0 Then
                MessageBoxEx.Show("Vous devez selectionner une commande avant de cliquer modifier", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                If RadioButton1.Checked = True Then
                    Dim bc As BonCommande = New BonCommande
                    bc.codecm = GridView1.GetFocusedRowCellValue("codebc").ToString()
                    bc.num.Text = GridView1.GetFocusedRowCellValue("codebc").ToString()
                    bc.Text = "Modifier le bon de commande"
                    bc.GroupBox1.Text = "modifier le bon de commande"
                    bc.MdiParent = Mainfrm
                    bc.Show()
                Else
                    Dim ba As BonCommande = New BonCommande
                    ba.codeam = GridView1.GetFocusedRowCellValue("codeba").ToString()
                    ba.num.Text = GridView1.GetFocusedRowCellValue("codeba").ToString()
                    ba.Text = "Modifier le bon d'achat"
                    ba.GroupBox1.Text = "modifier le bon d'achat"
                    ba.MdiParent = Mainfrm
                    ba.Show()
                End If
            End If
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub

    Private Sub SupprimerOffreToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SupprimerOffreToolStripMenuItem.Click
        Try
            If GridView1.SelectedRowsCount = 0 Then
                MessageBoxEx.Show("Vous devez selectionner une commande avant de cliquer supprimer", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                If RadioButton1.Checked = True Then
                    Dim m = GridView1.GetFocusedRowCellValue("codebc").ToString()
                    If m <> Nothing Then
                        If MessageBoxEx.Show("Vous voullez vraiment supprimer la commande ?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                            IsConnected("Delete from logistique_appro_bondecommande WHERE codebc =" & m & " limit 1", True)
                            IsConnected("Delete from logistique_appro_bcdesig WHERE codebc =" & m & " ", True)
                            reload()
                        End If
                    End If
                Else
                    Dim m = GridView1.GetFocusedRowCellValue("codeba").ToString()
                    If m <> Nothing Then
                        If MessageBoxEx.Show("Vous voullez vraiment supprimer la commande ?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                            IsConnected("Delete from logistique_appro_bonachat WHERE codeba =" & m & " limit 1", True)
                            IsConnected("Delete from logistique_appro_badesig WHERE codeba =" & m & " ", True)
                            reload1()
                        End If
                    End If
                End If
            End If
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub

    Private Sub ImprimerOffreToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ImprimerOffreToolStripMenuItem1.Click
        Try
            If GridView1.SelectedRowsCount = 0 Then
                MessageBoxEx.Show("Vous devez selectionner une commande avant de cliquer Imprimer", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                If RadioButton1.Checked = True Then
                    'MsgBox("codebc=" & GridView1.GetFocusedRowCellValue("codebc").ToString())
                    BoncommandeRP.code = GridView1.GetFocusedRowCellValue("codebc").ToString()
                    'MsgBox("codebc1=" & BoncommandeRP.code)
                Else
                    BoncommandeRP.codea = GridView1.GetFocusedRowCellValue("codeba").ToString()
                End If
                BoncommandeRP.MdiParent = Mainfrm
                BoncommandeRP.Show()
            End If
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub

    Private Sub ConvertitLoffreEnAffaireToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConvertitLoffreEnAffaireToolStripMenuItem.Click
        Try
            BonCommande.codecom = GridView1.GetFocusedRowCellValue("codebc").ToString()
            BonCommande.num.Text = GridView1.GetFocusedRowCellValue("codebc").ToString()
            BonCommande.Text = "BON D'ACHAT "
            BonCommande.GroupBox1.Text = "Bon d'achat :"
            'RapportOffre.nrc.Text = GridView1.GetRowCellValue(0, "code").ToString()
            BonCommande.MdiParent = Mainfrm
            BonCommande.Show()
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        If RadioButton1.Checked = True And du.Value <> Nothing And au.Value <> Nothing Then
            reload()
            ConvertitLoffreEnAffaireToolStripMenuItem.Visible = True
            ValiderLaCommandeToolStripMenuItem.Visible = True
        End If
    End Sub

    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged
        If RadioButton2.Checked = True And du.Value <> Nothing And au.Value <> Nothing Then
            reload1()
            ConvertitLoffreEnAffaireToolStripMenuItem.Visible = False
            ValiderLaCommandeToolStripMenuItem.Visible = False
        End If
    End Sub

    Private Sub ButtonX2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX2.Click
        If RadioButton1.Checked = True Then
            reload()
            ConvertitLoffreEnAffaireToolStripMenuItem.Visible = True
            ValiderLaCommandeToolStripMenuItem.Visible = True
        ElseIf RadioButton2.Checked = True Then
            reload1()
            ConvertitLoffreEnAffaireToolStripMenuItem.Visible = False
            ValiderLaCommandeToolStripMenuItem.Visible = False
        End If
    End Sub

    Private Sub ListCommande_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'GridView1.Settings.ShowFilterRowMenu = chkFilterRowMenu.Checked
        'Grid.SettingsBehavior.FilterRowMode = CType(System.Enum.Parse(GetType(GridViewFilterRowMode), filterRowModeCombo.Text, True), GridViewFilterRowMode)
        au.Value = Date.Now.Date
        Dim d As Date = Date.Today
        d = d.AddDays(-30)
        du.Value = d
    End Sub

    Private Sub ValiderLaCommandeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ValiderLaCommandeToolStripMenuItem.Click
        If GridView1.SelectedRowsCount = 0 Then
            MessageBoxEx.Show("Vous devez selectionner une commande avant de cliquer Valider", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            Dim m = GridView1.GetFocusedRowCellValue("codebc").ToString()
            If m <> Nothing Then
                If MessageBoxEx.Show("Vous voullez vraiment valider la commande ?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                    IsConnected("INSERT INTO logistique_appro_bonachat (`codeba`,`reference`,`nature`,`type`,`synthese`,`oe`,`codestruc`,`namestruc`,`DateBA`,`ref`,`demandeur`,`monnaie`,`delaiexe`,`modeexpe`,`modepaiem`,`ref_offre`,`imputation`,`dateEnreg`,`client`,`user`) (SELECT codebc,reference,nature,type,synthese,oe,codestruc,namestruc,DateBC,ref,demandeur,monnaie,delaiexe,modeexpe,modepaiem,ref_offre,imputation,dateEnreg,client,user FROM logistique_appro_bondecommande WHERE codebc ='" & m & "' limit 1)", True)
                    IsConnected("INSERT INTO logistique_appro_badesig (`codeba`,`desigba`,`Qte`,`poids`,`pu`,`montantbc`,`totalht`,`tva`,`timbre`,`montanttotal`,`tauxva`,`codefour`) (SELECT codebc,desigbc,Qte,poids,pu,montantbc,totalht,tva,timbre,montanttotal,tauxva,codefour FROM logistique_appro_bcdesig WHERE codebc ='" & m & "')", True)
                    IsConnected("UPDATE `logistique_appro_bondecommande` SET `etatCommande` ='1' WHERE `codebc` =" & m & " limit 1; ", True)
                    reload()
                End If
            End If
        End If
    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        Dim num1 As String = ""
        Dim numref
        Dim numref1
        If GridView1.SelectedRowsCount = 0 Then
            MessageBoxEx.Show("Vous devez selectionner une commande avant de cliquer", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            DivisonnerBonCommande.codebcDiv = GridView1.GetFocusedRowCellValue("codebc").ToString()
            DivisonnerBonCommande.num.Text = GridView1.GetFocusedRowCellValue("Numero").ToString()
            'SELECT distinct logistique_appro_bondecommande.codebc,reference as 'Numero',nature,logistique_appro_bondecommande.type,synthese,oe,codestruc,namestruc,codefour,nomfourn as 'Nom fournisseur',logistique_appro_bcdesig.montanttotal as 'Montant total DA/TTC'
            If GridView1.GetFocusedRowCellValue("oe").ToString() <> "" Then
                DivisonnerBonCommande.OEComboBoxEx1.Text = GridView1.GetFocusedRowCellValue("oe").ToString()
            Else
                DivisonnerBonCommande.CodestructTextBoxX3.Text = GridView1.GetFocusedRowCellValue("codestruc").ToString()
                DivisonnerBonCommande.NameStructTextBoxX2.Text = GridView1.GetFocusedRowCellValue("namestruc").ToString()
            End If
            IsConnected("SELECT  max(codebc) as 'c' FROM logistique_appro_bondecommande", False)
            If myDR.HasRows Then
                While myDR.Read
                    num1 = myDR("c").ToString
                End While
            End If
            numref = DivisonnerBonCommande.num.Text.Split("/")
            numref = numref(0).ToString.Substring(0, 1)
            Dim annee = Date.Now.ToString("yy")
            num1 = CDbl(num1 + 1)
            DivisonnerBonCommande.NumeroTextBoxX5.Text = numref + num1 + "/" + annee
            DivisonnerBonCommande.MdiParent = Mainfrm
            DivisonnerBonCommande.Show()
        End If
    End Sub
End Class