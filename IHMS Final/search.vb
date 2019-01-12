Imports System.IO
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.Sql
Imports System.Data.SqlTypes
Imports System.Drawing.Imaging

Public Class search


    Dim con As New SqlConnection("Data Source=localhost\SQLEXPRESS;Initial Catalog=project;Integrated Security=True")
    Dim cmd As SqlCommand
    Dim da As SqlDataAdapter
    Dim dr As SqlDataReader
    Dim dt As DataSet

    Private Sub BunifuFlatButton2_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton2.Click
        Dim con As New SqlConnection
        Dim comm As New SqlCommand
        Dim adapter As New SqlDataAdapter
        Dim dataset As New DataSet
        Dim dr As SqlDataReader

        con.ConnectionString = "Data Source=localhost\SQLEXPRESS;Initial Catalog=project;Integrated Security=True"

        comm.CommandText = "select id,name,gender,bloodgp,mobile from profile where id = '" & BunifuMetroTextbox2.Text & "' "
        con.Open()
        comm.Connection = con
        adapter.SelectCommand = comm
        adapter.Fill(dataset, "profile")
        Dim count As Integer = dataset.Tables("profile").Rows.Count
        Dim dt As New DataTable

        If count > 0 Then
            dr = comm.ExecuteReader()

            While dr.Read()
                MessageBox.Show("Record Found")
                BunifuCustomLabel9.Text = dr.GetValue(0)
                BunifuCustomLabel28.Text = dr.GetValue(1)
                BunifuCustomLabel14.Text = dr.GetValue(2)
                BunifuCustomLabel10.Text = dr.GetValue(3)
                BunifuCustomLabel26.Text = dr.GetValue(4)

            End While
        Else
            MessageBox.Show("No record found, please enter the correct patient id.")
        End If
    End Sub

    Private Sub search_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BunifuMetroTextbox2_OnValueChanged(sender As Object, e As EventArgs) Handles BunifuMetroTextbox2.OnValueChanged

    End Sub

    Private Sub BunifuCustomLabel3_Click(sender As Object, e As EventArgs) Handles BunifuCustomLabel3.Click

    End Sub

    Private Sub BunifuCustomLabel12_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub BunifuCustomLabel26_Click(sender As Object, e As EventArgs) Handles BunifuCustomLabel26.Click

    End Sub
End Class