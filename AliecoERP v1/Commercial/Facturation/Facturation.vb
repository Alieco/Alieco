Imports DevExpress.XtraRichEdit
Imports DevExpress.XtraRichEdit.API.Native
Imports DevExpress.Office.Utils

Public Class Facturation

    Private Sub Facturation_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ListView1.LabelEdit = True
        ' Dim pageCount As Integer = DirectCast(RichEditControl1.ActiveView, DevExpress.XtraRichEdit.PrintLayoutView).PageCount

        'Me.AutoScroll = True
        'Dim ht As Double = 0
        'Dim nom As String = ""
        'Dim montantdes As Double = 0
        'IsConnected("SELECT * FROM commercial_affaire, commercial_affaire_bordereauprix WHERE commercial_affaire_bordereauprix.code=commercial_affaire.code_affaire and code_affaire='" & code.Text & "' and commercial_affaire_bordereauprix.type='D' ", False)
        'If myDR.HasRows = True Then
        '    While (myDR.Read())
        '        nom = myDR("nomcl").ToString
        '        Dim n = nom.Split("-")
        '        nomcl.Text = n(0)
        '        montantdes = myDR("montant").ToString
        '    End While
        'End If

        ''Dim avance1 As String = ""
        'IsConnected("SELECT * FROM commercial_ordre_facturation WHERE etat_facture=0 and code_affaire='" & code.Text & "'", False)
        'If myDR.HasRows = True Then
        '    While (myDR.Read())
        '        Dim des = myDR("designation").ToString
        '        Dim d = des.Split("|")
        '        Label1.Text = d(0)
        '        Dim pres = myDR("prestation").ToString
        '        Dim p = pres.Split("|")
        '        Label20.Text = p(0)
        '        Dim mode = myDR("modalite").ToString
        '        Dim m = mode.Split("|")
        '        Label22.Text = m(0)
        '        Dim ava = myDR("avance").ToString
        '        Dim a = ava.Split("|")
        '        Label19.Text = a(0)
        '    End While
        'End If
        'IsConnected("SELECT * FROM commercial_affaire, commercial_affaire_bordereauprix WHERE commercial_affaire_bordereauprix.code=commercial_affaire.code_affaire and code_affaire='" & code.Text & "' and commercial_affaire_bordereauprix.desig='" & Label20.Text & "'", False)
        'If myDR.HasRows = True Then
        '    While (myDR.Read())
        '        TextBoxX9.Text = myDR("totalttc").ToString
        '        TextBoxX10.Text = myDR("total").ToString
        '        TextBoxX11.Text = myDR("totaltva").ToString
        '    End While
        'End If
        'IsConnected("SELECT * FROM commercial_affaire, commercial_affaire_bordereauprix WHERE commercial_affaire_bordereauprix.code=commercial_affaire.code_affaire and code_affaire='" & code.Text & "' and commercial_affaire_bordereauprix.desig='" & Label1.Text & "'", False)
        'If myDR.HasRows = True Then
        '    While (myDR.Read())
        '        total11.Text = myDR("total").ToString
        '        tva.Text = myDR("totaltva").ToString
        '        ttc.Text = myDR("totalttc").ToString
        '    End While
        'End If
        'Dim mo = Label22.Text.Split("%")
        'Dim av = Label19.Text.Split("%")
        'TextBoxX4.Text = (ht * mo(0)) / 100
        'TextBoxX5.Text = TextBoxX4.Text * 0.17
        ''TextBoxX3.Text = (montant.Text * mo(0)) / 100
        ''TextBoxX8.Text = (ht * av(0)) / 100
        ''TextBoxX7.Text = TextBoxX8.Text * 0.17
        ''TextBoxX6.Text = (montant.Text * av(0)) / 100
    End Sub

    Private Sub VScrollBarAdv1_Scroll(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ScrollEventArgs) Handles VScrollBarAdv1.Scroll
        GroupBox2.Location = New Point(12, 12 - (VScrollBarAdv1.Value * 2))
    End Sub
End Class