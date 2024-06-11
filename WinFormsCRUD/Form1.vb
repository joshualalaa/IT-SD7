Imports MySql.Data.MySqlClient
Public Class Form1

    Sub ViewData()
        Connected()
        DA = New MySqlDataAdapter("SELECT * FROM employee", Connect)
        DT = New DataTable
        DA.Fill(DT)
        GridView.Rows.Clear()
        For i = 0 To DT.Rows.Count - 1
            GridView.Rows.Add(DT.Rows(i).Item(0))
            GridView.Rows(i).Cells(1).Value = DT.Rows(i).Item(1)
            GridView.Rows(i).Cells(2).Value = DT.Rows(i).Item(2)
            GridView.Rows(i).Cells(3).Value = DT.Rows(i).Item(3)
        Next
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ViewData()
    End Sub

    Private Sub ButtonEmpty_Click(sender As Object, e As EventArgs) Handles ButtonEmpty.Click
        TextBoxNIK.Text = ""
        TextBoxName.Text = ""
        TextBoxDepartment.Text = ""
        ComboBoxJobClass.Text = ""

        TextBoxNIK.Focus()
    End Sub

    Private Sub ButtonSubmit_Click(sender As Object, e As EventArgs) Handles ButtonSubmit.Click
        If Find = True Then
            'Update Data
            Try
                Connected()
                CMD = New MySqlCommand("UPDATE employee SET Name = '" & TextBoxName.Text & "', Department = '" & TextBoxDepartment.Text & "', JobClass = '" & ComboBoxJobClass.Text & "' WHERE NIK = '" & TextBoxNIK.Text & "'", Connect)
                CMD.ExecuteNonQuery()
                MsgBox("Success Update Data")
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            'Submit New Data
            Try
                Connected()
                CMD = New MySqlCommand("INSERT INTO employee (NIK, Name, Department, JobClass) VALUES ('" & TextBoxNIK.Text & "','" & TextBoxName.Text & "','" & TextBoxDepartment.Text & "','" & ComboBoxJobClass.Text & "')", Connect)
                CMD.ExecuteNonQuery()
                MsgBox("Success Submit Data")
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If

        ViewData()
        ButtonEmpty_Click(sender, e)
    End Sub

    Private Sub TextBoxNIK_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxNIK.KeyPress
        If e.KeyChar = Chr(13) Then
            Connected()
            CMD = New MySqlCommand("SELECT * FROM employee WHERE NIK = '" & TextBoxNIK.Text & "'", Connect)
            DR = CMD.ExecuteReader
            If DR.Read Then
                TextBoxNIK.Text = DR.Item(0)
                TextBoxName.Text = DR.Item(1)
                TextBoxDepartment.Text = DR.Item(2)
                ComboBoxJobClass.Text = DR.Item(3)
                MsgBox("Data Found")
                Find = True
            Else
                MsgBox("Data Not Found")
                TextBoxNIK.Focus()
                Find = False
            End If
        End If
    End Sub

    Private Sub ButtonDelete_Click(sender As Object, e As EventArgs) Handles ButtonDelete.Click
        If Find = True Then
            Try
                Connected()
                If MessageBox.Show("Do you want to delete this data?", "Confirm", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                    CMD = New MySqlCommand("DELETE FROM employee WHERE NIK = '" & TextBoxNIK.Text & "'", Connect)
                    CMD.ExecuteNonQuery()
                    MsgBox("Success Delete Data")
                    ViewData()
                    ButtonEmpty_Click(sender, e)
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub
End Class
