Imports System.Data.SqlClient
Imports System.Data.Sql

Public Class order

    Dim con As New SqlConnection("Data Source=localhost\SQLEXPRESS;Initial Catalog=project;Integrated Security=True")
    Dim cmd As SqlCommand
    Dim da As SqlDataAdapter
    Dim dr As SqlDataReader
    Dim dt As DataSet

    Private Sub order_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        BunifuCustomLabel18.Text = Login.BunifuMetroTextbox1.Text

        con.Open()
        Dim qwerty As String = "select billno from bill where name = '" & BunifuCustomLabel18.Text & "'; "
        Dim cmd1 As New SqlCommand(qwerty, con)
        Dim datan As SqlDataReader = cmd1.ExecuteReader
        If datan.HasRows Then
            Do While datan.Read()
                BunifuCustomLabel16.Text = datan(0).ToString()
            Loop
        Else
            BunifuCustomLabel16.Text = "No Data"
        End If

        con.Close()

        con.Open()
        Dim qwerty1 As String = "select id from bill where name = '" & BunifuCustomLabel18.Text & "'; "
        Dim cmd2 As New SqlCommand(qwerty1, con)
        Dim datan1 As SqlDataReader = cmd2.ExecuteReader
        If datan1.HasRows Then
            Do While datan1.Read()
                BunifuCustomLabel17.Text = datan1(0).ToString()
            Loop
        Else
            BunifuCustomLabel17.Text = "No Data"
        End If
        con.Close()

        con.Open()
        Dim qwerty2 As String = "select date from bill where name = '" & BunifuCustomLabel18.Text & "'; "
        Dim cmd3 As New SqlCommand(qwerty2, con)
        Dim datan2 As SqlDataReader = cmd3.ExecuteReader
        If datan2.HasRows Then
            Do While datan2.Read()
                BunifuCustomLabel19.Text = datan2(0).ToString()
            Loop
        Else
            BunifuCustomLabel19.Text = "No Data"
        End If
        con.Close()

        con.Open()
        Dim qwerty3 As String = "select dept from bill where name = '" & BunifuCustomLabel18.Text & "'; "
        Dim cmd4 As New SqlCommand(qwerty3, con)
        Dim datan3 As SqlDataReader = cmd4.ExecuteReader
        If datan3.HasRows Then
            Do While datan3.Read()
                BunifuCustomLabel21.Text = datan3(0).ToString()
            Loop
        Else
            BunifuCustomLabel21.Text = "No Data"
        End If
        con.Close()

        con.Open()
        Dim qwerty4 As String = "select doctor from bill where name = '" & BunifuCustomLabel18.Text & "'; "
        Dim cmd5 As New SqlCommand(qwerty4, con)
        Dim datan4 As SqlDataReader = cmd5.ExecuteReader
        If datan4.HasRows Then
            Do While datan4.Read()
                BunifuCustomLabel22.Text = datan4(0).ToString()
            Loop
        Else
            BunifuCustomLabel22.Text = "No Data"
        End If
        con.Close()

        con.Open()
        Dim qwerty5 As String = "select diagnosis from bill where name = '" & BunifuCustomLabel18.Text & "'; "
        Dim cmd6 As New SqlCommand(qwerty5, con)
        Dim datan5 As SqlDataReader = cmd6.ExecuteReader
        If datan5.HasRows Then
            Do While datan5.Read()
                BunifuCustomLabel23.Text = datan5(0).ToString()
            Loop
        Else
            BunifuCustomLabel23.Text = "No Data"
        End If
        con.Close()

        con.Open()
        Dim qwerty7 As String = "select confee from bill where name = '" & BunifuCustomLabel18.Text & "'; "
        Dim cmd8 As New SqlCommand(qwerty7, con)
        Dim datan7 As SqlDataReader = cmd8.ExecuteReader
        If datan7.HasRows Then
            Do While datan7.Read()
                BunifuCustomLabel13.Text = datan7(0).ToString()
            Loop
        Else
            BunifuCustomLabel13.Text = "No Data"
        End If
        con.Close()

        con.Open()
        Dim qwerty8 As String = "select medcost from bill where name = '" & BunifuCustomLabel18.Text & "'; "
        Dim cmd9 As New SqlCommand(qwerty8, con)
        Dim datan8 As SqlDataReader = cmd9.ExecuteReader
        If datan8.HasRows Then
            Do While datan8.Read()
                BunifuCustomLabel14.Text = datan8(0).ToString()
            Loop
        Else
            BunifuCustomLabel14.Text = "No Data"
        End If
        con.Close()


        con.Open()
        Dim qwerty11 As String = "select invcost from bill where name = '" & BunifuCustomLabel18.Text & "'; "
        Dim cmd12 As New SqlCommand(qwerty11, con)
        Dim datan11 As SqlDataReader = cmd12.ExecuteReader
        If datan11.HasRows Then
            Do While datan11.Read()
                BunifuCustomLabel15.Text = datan11(0).ToString()
            Loop
        Else
            BunifuCustomLabel15.Text = "No Data"
        End If
        con.Close()
    End Sub
End Class