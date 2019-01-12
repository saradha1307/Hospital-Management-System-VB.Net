Imports System.Data
Imports System.Data.Sql
Imports System.Data.SqlClient

Public Class patient

    Dim con As SqlConnection
    Dim connectionString As String
    Dim sql As String
    Dim cmd As SqlCommand
    Dim da As SqlDataAdapter
    Dim dr As SqlDataReader
    Dim dt As DataSet


    Private Sub BunifuFlatButton2_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton2.Click
        Dim con = New SqlConnection("Data Source=localhost\SQLEXPRESS;Initial Catalog=project;Integrated Security=True")
        Dim sv As String = "INSERT INTO bedalloc(id,name,wname,bedn) VALUES(@id, @nm, @wn, @bedn)"
        Dim cmd As SqlCommand = New SqlCommand(sv, con)
        cmd.Parameters.Add(New SqlClient.SqlParameter("@id", SqlDbType.Int)).Value = Trim(ComboBox1.Text)
        cmd.Parameters.Add(New SqlClient.SqlParameter("@nm", SqlDbType.NVarChar)).Value = Trim(BunifuMetroTextbox2.Text)
        cmd.Parameters.Add(New SqlClient.SqlParameter("@wn", SqlDbType.Char)).Value = Trim(BunifuDropdown1.selectedValue)
        cmd.Parameters.Add(New SqlClient.SqlParameter("@bedn", SqlDbType.Int)).Value = Trim(BunifuMetroTextbox4.Text)


        Try

            ComboBox1.Text = ""
            BunifuMetroTextbox2.Text = ""
            BunifuMetroTextbox4.Text = ""

            con.Open()
            cmd.ExecuteNonQuery()
            con.Close()
            MessageBox.Show("one record successfully added.")

        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString(), "Data Error")
            Exit Sub

        End Try
    End Sub

    Private Sub BunifuMetroTextbox1_OnValueChanged(sender As Object, e As EventArgs)

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

    Private Sub patient_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged

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

    Private Sub BunifuMetroTextbox2_OnValueChanged(sender As Object, e As EventArgs) Handles BunifuMetroTextbox2.OnValueChanged

    End Sub

    Private Sub patient_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim con As New SqlConnection("Data Source=localhost\SQLEXPRESS;Initial Catalog=project;Integrated Security=True")
        con.Open()
        Dim qwerty As String = "select name from profile where id = '" & ComboBox1.Text & "'; "
        Dim cmd As New SqlCommand(qwerty, con)
        Dim datan As SqlDataReader = cmd.ExecuteReader
        If datan.HasRows Then
            Do While datan.Read()
                BunifuMetroTextbox2.Text = datan(0).ToString()
            Loop
        Else
            BunifuMetroTextbox2.Text = "No Data"
        End If

        con.Close()
    End Sub
End Class