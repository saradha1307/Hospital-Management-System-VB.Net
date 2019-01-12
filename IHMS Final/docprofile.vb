Imports System.Data.SqlClient
Imports System.Data.Sql

Public Class docprofile

    Dim con As New SqlConnection("Data Source=localhost\SQLEXPRESS;Initial Catalog=project;Integrated Security=True")
    Dim cmd As SqlCommand
    Dim da As SqlDataAdapter
    Dim dr As SqlDataReader
    Dim dt As DataSet

    Private Sub docprofile_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        BunifuCustomLabel9.Text = doclogin.BunifuMetroTextbox1.Text

        con.Open()
        Dim qwerty As String = "select docname from docdetails where docid = '" & BunifuCustomLabel9.Text & "'; "
        Dim cmd1 As New SqlCommand(qwerty, con)
        Dim datan As SqlDataReader = cmd1.ExecuteReader
        If datan.HasRows Then
            Do While datan.Read()
                BunifuCustomLabel15.Text = datan(0).ToString()
            Loop
        Else
            BunifuCustomLabel15.Text = "No Data"
        End If

        con.Close()

        con.Open()
        Dim qwerty1 As String = "select dept from docdetails where docid = '" & BunifuCustomLabel9.Text & "'; "
        Dim cmd2 As New SqlCommand(qwerty1, con)
        Dim datan1 As SqlDataReader = cmd2.ExecuteReader
        If datan1.HasRows Then
            Do While datan1.Read()
                BunifuCustomLabel18.Text = datan1(0).ToString()
            Loop
        Else
            BunifuCustomLabel18.Text = "No Data"
        End If
        con.Close()

        con.Open()
        Dim qwerty2 As String = "select gender from docdetails where docid = '" & BunifuCustomLabel9.Text & "'; "
        Dim cmd3 As New SqlCommand(qwerty2, con)
        Dim datan2 As SqlDataReader = cmd3.ExecuteReader
        If datan2.HasRows Then
            Do While datan2.Read()
                BunifuCustomLabel16.Text = datan2(0).ToString()
            Loop
        Else
            BunifuCustomLabel16.Text = "No Data"
        End If
        con.Close()

        con.Open()
        Dim qwerty3 As String = "select age from docdetails where docid = '" & BunifuCustomLabel9.Text & "'; "
        Dim cmd4 As New SqlCommand(qwerty3, con)
        Dim datan3 As SqlDataReader = cmd4.ExecuteReader
        If datan3.HasRows Then
            Do While datan3.Read()
                BunifuCustomLabel14.Text = datan3(0).ToString()
            Loop
        Else
            BunifuCustomLabel14.Text = "No Data"
        End If
        con.Close()

        con.Open()
        Dim qwerty4 As String = "select qual from docdetails where docid = '" & BunifuCustomLabel9.Text & "'; "
        Dim cmd5 As New SqlCommand(qwerty4, con)
        Dim datan4 As SqlDataReader = cmd5.ExecuteReader
        If datan4.HasRows Then
            Do While datan4.Read()
                BunifuCustomLabel12.Text = datan4(0).ToString()
            Loop
        Else
            BunifuCustomLabel12.Text = "No Data"
        End If
        con.Close()

        con.Open()
        Dim qwerty5 As String = "select mobile from docdetails where docid = '" & BunifuCustomLabel9.Text & "'; "
        Dim cmd6 As New SqlCommand(qwerty5, con)
        Dim datan5 As SqlDataReader = cmd6.ExecuteReader
        If datan5.HasRows Then
            Do While datan5.Read()
                BunifuCustomLabel10.Text = datan5(0).ToString()
            Loop
        Else
            BunifuCustomLabel10.Text = "No Data"
        End If
        con.Close()

        con.Open()
        Dim qwerty6 As String = "select docadd from docdetails where docid = '" & BunifuCustomLabel9.Text & "'; "
        Dim cmd7 As New SqlCommand(qwerty6, con)
        Dim datan6 As SqlDataReader = cmd7.ExecuteReader
        If datan6.HasRows Then
            Do While datan6.Read()
                BunifuCustomLabel11.Text = datan6(0).ToString()
            Loop
        Else
            BunifuCustomLabel11.Text = "No Data"
        End If
        con.Close()
    End Sub
End Class