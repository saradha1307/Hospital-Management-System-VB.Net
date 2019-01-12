Imports System.Data.SqlClient
Imports System.Data.Sql

Public Class bookap

    Private Sub bookap_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BunifuFlatButton1_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton1.Click


        Dim con = New SqlConnection("Data Source=localhost\SQLEXPRESS;Initial Catalog=project;Integrated Security=True")
        Dim sv As String = "INSERT INTO bookap(name,dept,date) VALUES(@name,@dept,@date)"
        Dim cmd As SqlCommand = New SqlCommand(sv, con)
        cmd.Parameters.Add(New SqlClient.SqlParameter("@name", SqlDbType.NChar)).Value = Trim(Login.BunifuMetroTextbox1.Text)
        cmd.Parameters.Add(New SqlClient.SqlParameter("@dept", SqlDbType.NVarChar)).Value = Trim(BunifuDropdown1.selectedValue)
        cmd.Parameters.Add(New SqlClient.SqlParameter("@date", SqlDbType.NVarChar)).Value = Trim(DateTimePicker1.Text)

        Try

            con.Open()

            cmd.ExecuteNonQuery()

            con.Close()

            MessageBox.Show("Your appointment is booked")


        Catch ex As Exception

            MessageBox.Show(ex.Message.ToString(), "Data Error")

            Exit Sub

        End Try
    End Sub

    Private Sub BunifuDatepicker1_onValueChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged

    End Sub
End Class