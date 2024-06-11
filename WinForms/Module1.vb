Imports MySql.Data.MySqlClient
Module Module1
    Public Connect As MySqlConnection
    Public CMD As MySqlCommand
    Public DR As MySqlDataReader
    Public DA As MySqlDataAdapter
    Public DS As DataSet
    Public STR As String

    Sub Relation()
        Try
            Dim STR As String = "SERVER=localhost; user id=root; password=; database=indomaret_group"
            Connect = New MySqlConnection(STR)
            If Connect.State = ConnectionState.Closed Then
                Connect.Open()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Module
