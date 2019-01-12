Imports System.Data.Sql
Imports System.Data.SqlClient

Public Class doctor

    Dim con As SqlConnection
    Dim cmd As SqlCommand
    Dim dr As SqlDataReader

    Private Sub BunifuFlatButton2_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton2.Click

        Dim con = New SqlConnection("Data Source=localhost\SQLEXPRESS;Initial Catalog=project;Integrated Security=True")

        Dim sv As String = "INSERT INTO docdetails(docid,docname,dept,gender,age,qual,mobile,docadd) VALUES(@id, @name,@dept,@gender, @age,@qual,@mobile,@add)"
        Dim cmd As SqlCommand = New SqlCommand(sv, con)
        cmd.Parameters.Add(New SqlClient.SqlParameter("@id", SqlDbType.NVarChar)).Value = Trim(BunifuMetroTextbox2.Text)
        cmd.Parameters.Add(New SqlClient.SqlParameter("@name", SqlDbType.NVarChar)).Value = Trim(BunifuMetroTextbox3.Text)
        cmd.Parameters.Add(New SqlClient.SqlParameter("@dept", SqlDbType.NVarChar)).Value = Trim(BunifuMetroTextbox4.Text)
        cmd.Parameters.Add(New SqlClient.SqlParameter("@gender", SqlDbType.NVarChar)).Value = Trim(ComboBox1.Text)
        cmd.Parameters.Add(New SqlClient.SqlParameter("@age", SqlDbType.Int)).Value = Trim(BunifuMetroTextbox6.Text)
        cmd.Parameters.Add(New SqlClient.SqlParameter("@qual", SqlDbType.NVarChar)).Value = Trim(BunifuCustomTextbox1.Text)
        cmd.Parameters.Add(New SqlClient.SqlParameter("@mobile", SqlDbType.BigInt)).Value = Trim(BunifuMetroTextbox8.Text)
        cmd.Parameters.Add(New SqlClient.SqlParameter("@add", SqlDbType.NVarChar)).Value = Trim(BunifuCustomTextbox2.Text)


            Try
                BunifuMetroTextbox1.Text = ""
                BunifuMetroTextbox2.Text = ""
                BunifuMetroTextbox3.Text = ""
                BunifuMetroTextbox4.Text = ""
                BunifuMetroTextbox6.Text = ""
            ComboBox1.Text = ""
                BunifuCustomTextbox1.Text = ""
                BunifuMetroTextbox8.Text = ""
                BunifuCustomTextbox2.Text = ""
                con.Open()
                cmd.ExecuteNonQuery()
                con.Close()
                MessageBox.Show("New Doctor added")

            Catch ex As Exception
                MessageBox.Show(ex.Message.ToString(), "Data Error")
                Exit Sub

            End Try
       
    End Sub

    Private Sub BunifuFlatButton3_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton3.Click
        Dim con = New SqlConnection("Data Source=localhost\SQLEXPRESS;Initial Catalog=project;Integrated Security=True")
        Dim sv As String = "UPDATE  docdetails SET docid = @id,docname= @name, dept = @dept , gender=@gender,age=@age,qual=@qual,mobile=@mobile,docadd=@add WHERE docid = @id"
        Dim cmd As SqlCommand = New SqlCommand(sv, con)
        cmd.Parameters.Add(New SqlClient.SqlParameter("@id", SqlDbType.NVarChar)).Value = Trim(BunifuMetroTextbox1.Text)
        cmd.Parameters.Add(New SqlClient.SqlParameter("@name", SqlDbType.NVarChar)).Value = Trim(BunifuMetroTextbox3.Text)
        cmd.Parameters.Add(New SqlClient.SqlParameter("@dept", SqlDbType.NVarChar)).Value = Trim(BunifuMetroTextbox4.Text)
        cmd.Parameters.Add(New SqlClient.SqlParameter("@gender", SqlDbType.NVarChar)).Value = Trim(ComboBox1.Text)
        cmd.Parameters.Add(New SqlClient.SqlParameter("@age", SqlDbType.NChar)).Value = Trim(BunifuMetroTextbox6.Text)
        cmd.Parameters.Add(New SqlClient.SqlParameter("@qual", SqlDbType.NVarChar)).Value = Trim(BunifuCustomTextbox1.Text)
        cmd.Parameters.Add(New SqlClient.SqlParameter("@mobile", SqlDbType.Int)).Value = Trim(BunifuMetroTextbox8.Text)
        cmd.Parameters.Add(New SqlClient.SqlParameter("@add", SqlDbType.NVarChar)).Value = Trim(BunifuCustomTextbox2.Text)

        Try

            BunifuMetroTextbox1.Text = ""
            BunifuMetroTextbox2.Text = ""
            BunifuMetroTextbox3.Text = ""
            BunifuMetroTextbox4.Text = ""
            BunifuMetroTextbox6.Text = ""
            BunifuCustomTextbox1.Text = ""
            ComboBox1.Text = ""
            BunifuMetroTextbox8.Text = ""
            BunifuCustomTextbox2.Text = ""

            con.Open()
            cmd.ExecuteNonQuery()
            con.Close()
            MessageBox.Show("Record updated successfully")

        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString(), "Data Error")

            Exit Sub

        End Try
    End Sub

    Private Sub BunifuFlatButton4_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton4.Click
        Dim con = New SqlConnection("Data Source=localhost\SQLEXPRESS;Initial Catalog=project;Integrated Security=True")
        Dim sv As String = "DELETE FROM docdetails WHERE docid = @no"
        Dim cmd As SqlCommand = New SqlCommand(sv, con)
        cmd.Parameters.Add(New SqlClient.SqlParameter("@no", SqlDbType.NVarChar)).Value = Trim(BunifuMetroTextbox2.Text)

        Try

            BunifuMetroTextbox1.Text = ""
            BunifuMetroTextbox2.Text = ""
            BunifuMetroTextbox3.Text = ""
            BunifuMetroTextbox4.Text = ""
            BunifuMetroTextbox6.Text = ""
            ComboBox1.Text = ""
            BunifuCustomTextbox1.Text = ""
            BunifuMetroTextbox8.Text = ""
            BunifuCustomTextbox2.Text = ""

            con.Open()
            cmd.ExecuteNonQuery()
            con.Close()
            MessageBox.Show("Record DELETED successfully.")

        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString(), "Data Error")
            Exit Sub

        End Try
    End Sub

    Private Sub BunifuFlatButton1_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton1.Click
        Dim con As New SqlConnection
        Dim comm As New SqlCommand
        Dim adapter As New SqlDataAdapter
        Dim dataset As New DataSet
        Dim dr As SqlDataReader

        con.ConnectionString = "Data Source=localhost\SQLEXPRESS;Initial Catalog=project;Integrated Security=True"

        comm.CommandText = "select * from docdetails where docid = '" & BunifuMetroTextbox1.Text & "'"
        con.Open()
        comm.Connection = con
        adapter.SelectCommand = comm
        adapter.Fill(dataset, "docdetails")
        Dim count As Integer = dataset.Tables("docdetails").Rows.Count
        Dim dt As New DataTable

        If count > 0 Then
            dr = comm.ExecuteReader()

            While dr.Read()
                MessageBox.Show("Record Found")
                BunifuMetroTextbox2.Text = dr.GetValue(0)
                BunifuMetroTextbox3.Text = dr.GetValue(2)
                BunifuMetroTextbox4.Text = dr.GetValue(3)
                ComboBox1.Text = dr.GetValue(4)
                BunifuMetroTextbox6.Text = dr.GetValue(5)
                BunifuCustomTextbox1.Text = dr.GetValue(6)
                BunifuMetroTextbox8.Text = dr.GetValue(7)
                BunifuCustomTextbox2.Text = dr.GetValue(8)

            End While
        Else
            MessageBox.Show("No record found, please enter the correct doctor id.")
        End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub
End Class