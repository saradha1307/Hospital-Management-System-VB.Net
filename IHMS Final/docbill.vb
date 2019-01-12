Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.Sql
Imports System.Data.SqlTypes
Imports System.IO

Public Class docbill

    Dim con As New SqlConnection("Data Source=localhost\SQLEXPRESS;Initial Catalog=project;Integrated Security=True")
    Dim cmd As SqlCommand
    Dim da As SqlDataAdapter
    Dim dr As SqlDataReader
    Dim dt As DataSet

    Dim conni As SqlConnection
    Dim connectionString As String
    Dim sql As String

    Private Sub docbill_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged
        Dim myconn As New SqlConnection("Data Source=localhost\SQLEXPRESS;Initial Catalog=project;Integrated Security=True")

        Dim da As New SqlDataAdapter("select id from profile", myconn)
        Dim dt As New DataTable
        Try
            myconn.Open()
            da.Fill(dt)
            ComboBox1.DisplayMember = "id"
            ComboBox1.DataSource = dt
            myconn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Data Error")
            myconn.Close()
        End Try

    End Sub

    Private Sub ComboBox1_SelectedValueChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedValueChanged
        Dim mycon As New SqlConnection("Data Source=localhost\SQLEXPRESS;Initial Catalog=project;Integrated Security=True")

        
        Try
            mycon.Open()
            Dim qwerty As String = "select name from profile where id = '" & ComboBox1.Text & "'; "
            Dim cmd1 As New SqlCommand(qwerty, mycon)
            Dim datan As SqlDataReader = cmd1.ExecuteReader
            If datan.HasRows Then
                Do While datan.Read()
                    BunifuMetroTextbox2.Text = datan(0).ToString()
                Loop
            Else
                BunifuMetroTextbox2.Text = "No Data"
            End If
            mycon.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Data Error")
            mycon.Close()
        End Try

    End Sub

    Private Sub docbill_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        con.Open()
        Dim qwerty As String = "select confee from docdetails where docid = '" & doclogin.BunifuMetroTextbox1.Text & "'; "
        Dim cmd As New SqlCommand(qwerty, con)
        Dim datan As SqlDataReader = cmd.ExecuteReader
        If datan.HasRows Then
            Do While datan.Read()
                BunifuMetroTextbox3.Text = datan(0).ToString()
            Loop
        Else
            BunifuMetroTextbox3.Text = "No Data"
        End If

        con.Close()

        con.Open()
        Dim qwerty1 As String = "select dept from docdetails where docid = '" & doclogin.BunifuMetroTextbox1.Text & "'; "
        Dim cmd1 As New SqlCommand(qwerty1, con)
        Dim datan1 As SqlDataReader = cmd1.ExecuteReader
        If datan1.HasRows Then
            Do While datan1.Read()
                BunifuMetroTextbox1.Text = datan1(0).ToString()
            Loop
        Else
            BunifuMetroTextbox1.Text = "No Data"
        End If

        con.Close()

        con.Open()
        Dim qwerty2 As String = "select docname from docdetails where docid = '" & doclogin.BunifuMetroTextbox1.Text & "'; "
        Dim cmd2 As New SqlCommand(qwerty2, con)
        Dim datan2 As SqlDataReader = cmd2.ExecuteReader
        If datan2.HasRows Then
            Do While datan2.Read()
                BunifuCustomLabel10.Text = datan2(0).ToString()
            Loop
        Else
            BunifuCustomLabel10.Text = "No Data"
        End If

        con.Close()

    End Sub

    Private Sub BunifuFlatButton2_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton2.Click

        Dim conni = New SqlConnection("Data Source=localhost\SQLEXPRESS;Initial Catalog=project;Integrated Security=True")
        Dim sv As String = "INSERT INTO bill(id,name,date,diagnosis,confee,med,dept,doctor) VALUES(@id, @name, @date, @diag, @confee, @med, @dept, @doct)"
        Dim cmd As SqlCommand = New SqlCommand(sv, con)

        If (BunifuMetroTextbox2.Text <> "" And BunifuCustomTextbox1.Text <> "" And BunifuMetroTextbox3.Text <> "" And BunifuCustomTextbox2.Text <> "" And BunifuMetroTextbox1.Text <> "" And BunifuCustomLabel10.Text <> "") Then

            cmd.Parameters.Add(New SqlClient.SqlParameter("@id", SqlDbType.NVarChar)).Value = Trim(ComboBox1.Text)
            cmd.Parameters.Add(New SqlClient.SqlParameter("@name", SqlDbType.NVarChar)).Value = Trim(BunifuMetroTextbox2.Text)
            cmd.Parameters.Add(New SqlClient.SqlParameter("@date", SqlDbType.NVarChar)).Value = Trim(BunifuDatepicker1.Value.Date)
            cmd.Parameters.Add(New SqlClient.SqlParameter("@diag", SqlDbType.NVarChar)).Value = Trim(BunifuCustomTextbox1.Text)
            cmd.Parameters.Add(New SqlClient.SqlParameter("@confee", SqlDbType.BigInt)).Value = Trim(BunifuMetroTextbox3.Text)
            cmd.Parameters.Add(New SqlClient.SqlParameter("@med", SqlDbType.NVarChar)).Value = Trim(BunifuCustomTextbox2.Text)
            cmd.Parameters.Add(New SqlClient.SqlParameter("@dept", SqlDbType.NVarChar)).Value = Trim(BunifuMetroTextbox1.Text)
            cmd.Parameters.Add(New SqlClient.SqlParameter("@doct", SqlDbType.NVarChar)).Value = Trim(BunifuCustomLabel10.Text)



            Try

                ComboBox1.Text = ""
                BunifuMetroTextbox2.Text = ""
                BunifuCustomTextbox1.Text = ""
                BunifuCustomTextbox2.Text = ""
                BunifuMetroTextbox3.Text = ""
                BunifuDatepicker1.Text = ""
                BunifuMetroTextbox1.Text = ""


                con.Open()
                cmd.ExecuteNonQuery()
                con.Close()
                MessageBox.Show("One record successfully added.")

            Catch ex As Exception
                MessageBox.Show(ex.Message.ToString(), "Data Error")
                Exit Sub

            End Try
        Else
            MessageBox.Show("Please enter all the fields")
        End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub

    Private Sub BunifuMetroTextbox2_OnValueChanged(sender As Object, e As EventArgs) Handles BunifuMetroTextbox2.OnValueChanged

    End Sub
End Class