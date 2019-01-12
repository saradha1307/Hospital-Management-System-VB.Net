Imports System.Data
Imports System.Data.Sql
Imports System.Data.SqlClient

Public Class pswdreset

    Private Sub BunifuFlatButton1_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton1.Click
        Dim con As New SqlConnection
        Dim comm As New SqlCommand
        Dim adapter As New SqlDataAdapter
        Dim dataset As New DataSet
        Dim dr As SqlDataReader

        con.ConnectionString = "Data Source=localhost\SQLEXPRESS;Initial Catalog=project;Integrated Security=True"

        comm.CommandText = "select * from profile where id = '" & BunifuMetroTextbox1.Text & "';"
        con.Open()
        comm.Connection = con
        adapter.SelectCommand = comm
        adapter.Fill(dataset, "0")
        Dim count = dataset.Tables(0).Rows.Count

        If count > 0 Then
            dr = comm.ExecuteReader()
            While dr.Read()
                MessageBox.Show("Record Found")
                BunifuMetroTextbox2.Text = dr.GetValue(1)
                BunifuMetroTextbox3.Text = dr.GetValue(2)
            End While
        Else
            MessageBox.Show("No record found,please enter the correct id.")
        End If
    End Sub

    Private Sub BunifuFlatButton2_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton2.Click
        Dim con = New SqlConnection("Data Source=localhost\SQLEXPRESS;Initial Catalog=project;Integrated Security=True")



        Dim sv As String = "UPDATE profile SET password = @pd WHERE name = '" & BunifuMetroTextbox2.Text & "'"
        Dim cmd As SqlCommand = New SqlCommand(sv, con)
        cmd.Parameters.Add(New SqlClient.SqlParameter("@pd", SqlDbType.NVarChar)).Value = Trim(BunifuMetroTextbox4.Text)
        Try

            con.Open()
            cmd.ExecuteNonQuery()
            con.Close()
            BunifuMetroTextbox2.Text = ""
            BunifuMetroTextbox3.Text = ""
            BunifuMetroTextbox4.Text = ""
            MessageBox.Show("Record updated successfully.")
            MessageBox.Show("Password changed successfully")

        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString(), "Data Error")

            Exit Sub

        End Try


    End Sub
End Class