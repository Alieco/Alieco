Imports DevComponents.DotNetBar
Imports DevExpress.XtraRichEdit

Public Class FacturationFr
    Public coderEFERENCE As String = ""
    Public code1 As String = ""
    Dim ht As Double = 0
    Dim tva1 As Double = 0
    Dim pos As Integer = 0
    Private Sub FacturationFrm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        RichEditControl1.LoadDocument(Application.StartupPath & "/Docs/facture.rtf", DocumentFormat.Rtf)
        RichEditControl1.Document.ReplaceAll("[code_affaire]", code1, API.Native.SearchOptions.CaseSensitive)
        IsConnected("SELECT * FROM commercial_ordre_facture,commercial_offre_bordereauprix where commercial_ordre_facture.id_commercial_ordre_facture=commercial_offre_bordereauprix.idBordereauPrix and commercial_ordre_facture.type='B' and rando='" & coderEFERENCE & "'", False)
        If myDR.HasRows = True Then
            While (myDR.Read())
                RichEditControl1.Document.ReplaceAll("[code_affaire]", code1, API.Native.SearchOptions.CaseSensitive)
                RichEditControl1.Document.ReplaceAll("[code_affaire]", code1, API.Native.SearchOptions.CaseSensitive)
            End While
        End If
        IsConnected("SELECT * FROM ", False)
        If myDR.HasRows = True Then
            While (myDR.Read())
                RichEditControl1.Document.ReplaceAll("[code_affaire]", code1, API.Native.SearchOptions.CaseSensitive)
                RichEditControl1.Document.ReplaceAll("[code_affaire]", code1, API.Native.SearchOptions.CaseSensitive)
            End While
        End If
    End Sub
End Class