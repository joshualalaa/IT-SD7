Imports MySql.Data.MySqlClient
Module Module1
    Dim db = "Server=localhost; Database=indomaret_group; Username=root; Password=;"
    Public Connect As New MySqlConnection(db)

    Public DA As MySqlDataAdapter
    Public CMD As MySqlCommand
    Public DT As DataTable
    Public DR As MySqlDataReader

    Public Find As Boolean = False

    Public Sub Connected()
        Try
            If Not Connect Is Nothing Then Connect.Close()
            Connect.Open()
            'MsgBox("Connected")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Function Disconnect()
        Connect.Close()
        Return Connect
    End Function

End Module
