Imports System.Data.SqlClient
Imports System.Data.Sql

Public Class history

    Dim con As New SqlConnection("Data Source=localhost\SQLEXPRESS;Initial Catalog=project;Integrated Security=True")
    Dim cmd As SqlCommand
    Dim da As SqlDataAdapter
    Dim dr As SqlDataReader
    Dim dt As DataSet

    Private Sub history_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        con.Open()
        Dim qwerty As String = "select id from profile where name = '" & Login.BunifuMetroTextbox1.Text & "'; "
        Dim cmd1 As New SqlCommand(qwerty, con)
        Dim datan As SqlDataReader = cmd1.ExecuteReader
        If datan.HasRows Then
            Do While datan.Read()
                BunifuCustomLabel7.Text = datan(0).ToString()
            Loop
        Else
            BunifuCustomLabel7.Text = "No Data"
        End If

        con.Close()

        con.Open()
        Dim qwerty1 As String = "select dept from bookap where name = '" & Login.BunifuMetroTextbox1.Text & "'; "
        Dim cmd2 As New SqlCommand(qwerty1, con)
        Dim datan1 As SqlDataReader = cmd2.ExecuteReader
        If datan1.HasRows Then
            Do While datan1.Read()
                BunifuCustomLabel9.Text = datan1(0).ToString()
            Loop
        Else
            BunifuCustomLabel9.Text = "No Data"
        End If
        con.Close()

        con.Open()
        Dim qwerty2 As String = "select date from bookap where name = '" & Login.BunifuMetroTextbox1.Text & "'; "
        Dim cmd3 As New SqlCommand(qwerty2, con)
        Dim datan2 As SqlDataReader = cmd3.ExecuteReader
        If datan2.HasRows Then
            Do While datan2.Read()
                BunifuCustomLabel10.Text = datan2(0).ToString()
            Loop
        Else
            BunifuCustomLabel10.Text = "No Data"
        End If
        con.Close()
    End Sub
End Class