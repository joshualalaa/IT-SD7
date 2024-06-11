Public Class Form1

    Sub viewGrid()
        Call Relation()
        DA = New MySql.Data.MySqlClient.MySqlDataAdapter("SELECT * FROM employee", Connect)
        DS = New DataSet
        DA.Fill(DS)
        GridView.DataSource = DS.Tables(0)
        GridView.ReadOnly = True
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call viewGrid()
    End Sub
End Class
