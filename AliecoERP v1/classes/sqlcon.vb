Imports System.Data.SqlClient
Public Class DB
    Public Shared sqlconn As New SqlConnection
    ' commands build Save ,update,Delete 
    Public Shared Function GetConnect()
        'sqlconn = New SqlConnection("Data Source=" & My.Settings.Server & "\" & My.Settings.instance & ";Initial Catalog=" & My.Settings.dba & ";Persist Security Info=True;User ID=" & My.Settings.user & ";Password=" & My.Settings.pass & "") '("Data Source=MBA2DNA-HP\SQLEXP;Initial Catalog=ALIECO;Integrated Security=True") '
        sqlconn = New SqlConnection("Data Source=SERVEUR\SQLEXP;Initial Catalog=ALIECO;Persist Security Info=True;User ID=alieco;Password=h.mwSN3320") '("Data Source=MBA2DNA-HP\SQLEXP;Initial Catalog=ALIECO;Integrated Security=True") '
        Return sqlconn
    End Function
    ' commands build Save ,update,Delete 
    Public Function SQLExicute(ByVal SQLStatment As String) As Boolean
        Try
            Dim Cmd As New SqlCommand
            Cmd.CommandText = SQLStatment
            Sqlconn.Open()
            Cmd.Connection = sqlconn
            Cmd.ExecuteNonQuery()
            Return True
        Catch ex As Exception
            Return False
            MsgBox(ex.Message)
        Finally
            Sqlconn.Close()
        End Try
    End Function
    ' Import data from database
    Public Function SQLReturn(ByVal Sqlstatment As String) As DataSet
        Dim ds As New DataSet
        Try
            If Sqlconn.State = ConnectionState.Open Then
                Sqlconn.Close()
            End If
            Dim sda As New SqlDataAdapter(Sqlstatment, Sqlconn)
            sda.Fill(ds)
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Sqlconn.Close()
        End Try
        Return ds
    End Function
    ' Fill DataGrid !
    Public Function FillDataGrid(ByVal dg As DataGridView, ByVal Sqlstatment As String) As DataSet
        Dim ds As New DataSet
        Dim bs As New BindingSource
        Try
            Dim sda As New SqlDataAdapter(Sqlstatment, Sqlconn)
            sda.Fill(ds)
            bs.DataSource = ds.Tables(0)
            dg.DataSource = bs
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Sqlconn.Close()
        End Try
        Return ds
    End Function
    ' Fill ComboBox !
    Public Sub FillComboBox(ByVal cbo As ComboBox, ByVal TableName As String, ByVal Col_Name As String, ByVal Col_Value As String, ByVal WHR As String)
        Try
            Dim VarSQL As String
            VarSQL = ""
            VarSQL = "Select " + Col_Name + " , " + Col_Value + " From " + TableName + " " + WHR
            Dim sda As New SqlDataAdapter(VarSQL, Sqlconn)
            Dim ds As New DataSet()
            sda.Fill(ds)
            cbo.DataSource = ds.Tables(0)
            cbo.DisplayMember = Col_Name
            cbo.ValueMember = Col_Value
        Catch
        End Try
    End Sub

End Class
