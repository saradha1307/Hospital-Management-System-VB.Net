Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.Sql
Imports System.Data.SqlTypes
Imports System.IO

Public Class billing

    Dim con = New SqlConnection("Data Source=localhost\SQLEXPRESS;Initial Catalog=project;Integrated Security=True")
    Dim sv As String = "INSERT INTO bill(medcost,chkbox,chkbox1,chkbox2,chkbox3,chkbox4,invcost,billno) VALUES(@medcost,@chkbox,@chkbox1,@chkbox2,@chkbox3,@chkbox4,@invcost,@billno)"
    Dim cmd As SqlCommand = New SqlCommand(sv, con)

    Private Sub billing_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged
        Dim myconn As New SqlConnection("Data Source=localhost\SQLEXPRESS;Initial Catalog=project;Integrated Security=True")

        Dim da As New SqlDataAdapter("select id from bill", myconn)
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
            Dim qwerty As String = "select name from bill where id = '" & ComboBox1.Text & "'; "
            Dim cmd1 As New SqlCommand(qwerty, mycon)
            Dim datan As SqlDataReader = cmd1.ExecuteReader
            If datan.HasRows Then
                Do While datan.Read()
                    BunifuCustomLabel3.Text = datan(0).ToString()
                Loop
            Else
                BunifuCustomLabel3.Text = "No Data"
            End If
            mycon.Close()

            mycon.Open()
            Dim qwerty1 As String = "select date from bill where id = '" & ComboBox1.Text & "'; "
            Dim cmd2 As New SqlCommand(qwerty1, mycon)
            Dim datan1 As SqlDataReader = cmd2.ExecuteReader
            If datan1.HasRows Then
                Do While datan1.Read()
                    BunifuCustomLabel5.Text = datan1(0).ToString()
                Loop
            Else
                BunifuCustomLabel5.Text = "No Data"
            End If
            mycon.Close()

            mycon.Open()
            Dim qwerty2 As String = "select confee from bill where id = '" & ComboBox1.Text & "'; "
            Dim cmd3 As New SqlCommand(qwerty2, mycon)
            Dim datan2 As SqlDataReader = cmd3.ExecuteReader
            If datan2.HasRows Then
                Do While datan2.Read()
                    BunifuCustomLabel7.Text = datan2(0).ToString()
                Loop
            Else
                BunifuCustomLabel7.Text = "No Data"
            End If
            mycon.Close()

            mycon.Open()
            Dim qwerty3 As String = "select dept from bill where id = '" & ComboBox1.Text & "'; "
            Dim cmd4 As New SqlCommand(qwerty3, mycon)
            Dim datan3 As SqlDataReader = cmd4.ExecuteReader
            If datan3.HasRows Then
                Do While datan3.Read()
                    BunifuCustomLabel19.Text = datan3(0).ToString()
                Loop
            Else
                BunifuCustomLabel19.Text = "No Data"
            End If
            mycon.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Data Error")
            mycon.Close()
        End Try

    End Sub

    Private Sub BunifuFlatButton2_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton2.Click

        Dim conni = New SqlConnection("Data Source=localhost\SQLEXPRESS;Initial Catalog=project;Integrated Security=True")
        Dim sv As String = "update bill set medcost=@medcost , chkbox=@chkbox , chkbox1=@chkbox1 , chkbox2=@chkbox2 , chkbox3=@chkbox3 , chkbox4=@chkbox4 , invcost=@invcost , billno=@billno where id = '" & ComboBox1.Text & "';"
        Dim cmd As SqlCommand = New SqlCommand(sv, con)

        If (ComboBox1.Text <> "" And BunifuMetroTextbox4.Text <> "" And BunifuMetroTextbox5.Text <> "" And BunifuMetroTextbox6.Text <> "") Then


            cmd.Parameters.Add(New SqlClient.SqlParameter("@medcost", SqlDbType.BigInt)).Value = Trim(BunifuMetroTextbox4.Text)
            cmd.Parameters.AddWithValue("@chkbox", BunifuCheckbox1.Checked)
            cmd.Parameters.AddWithValue("@chkbox1", BunifuCheckbox2.Checked)
            cmd.Parameters.AddWithValue("@chkbox2", BunifuCheckbox3.Checked)
            cmd.Parameters.AddWithValue("@chkbox3", BunifuCheckbox4.Checked)
            cmd.Parameters.AddWithValue("@chkbox4", BunifuCheckbox5.Checked)
            cmd.Parameters.Add(New SqlClient.SqlParameter("@invcost", SqlDbType.BigInt)).Value = Trim(BunifuMetroTextbox5.Text)
            cmd.Parameters.Add(New SqlClient.SqlParameter("@billno", SqlDbType.BigInt)).Value = Trim(BunifuMetroTextbox6.Text)

            Try


                BunifuMetroTextbox4.Text = ""
                BunifuCheckbox1.Checked = CheckState.Unchecked
                BunifuCheckbox2.Checked = CheckState.Unchecked
                BunifuCheckbox3.Checked = CheckState.Unchecked
                BunifuCheckbox4.Checked = CheckState.Unchecked
                BunifuCheckbox5.Checked = CheckState.Unchecked
                BunifuMetroTextbox5.Text = ""
                BunifuMetroTextbox6.Text = ""

                con.Open()

                cmd.ExecuteNonQuery()

                con.Close()

                MessageBox.Show("Invoice Generated")


            Catch ex As Exception

                MessageBox.Show(ex.Message.ToString(), "Data Error")

                Exit Sub

            End Try
        Else
            MessageBox.Show("Please enter all the fields")
        End If
    End Sub

    Private Sub BunifuCustomLabel5_Click(sender As Object, e As EventArgs) Handles BunifuCustomLabel5.Click

    End Sub

    Private Sub BunifuCustomLabel7_Click(sender As Object, e As EventArgs) Handles BunifuCustomLabel7.Click

    End Sub

    Private Sub BunifuCustomLabel19_Click(sender As Object, e As EventArgs) Handles BunifuCustomLabel19.Click

    End Sub

    Private Sub billing_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub
End Class