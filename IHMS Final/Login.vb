Imports System.Data.SqlClient
Imports System.Data.Sql

Public Class Login

    Private Sub BunifuFlatButton1_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton1.Click

        Dim con As New SqlConnection
        Dim comm As New SqlCommand
        Dim adapter As New SqlDataAdapter
        Dim dataset As New DataSet

        con.ConnectionString = "Data Source=localhost\sqlexpress;Initial Catalog=project;Integrated Security=True"

        comm.CommandText = "select * from profile where name = '" & BunifuMetroTextbox1.Text & "' And password = '" & BunifuMetroTextbox2.Text & "';"
        con.Open()
        comm.Connection = con
        adapter.SelectCommand = comm
        adapter.Fill(dataset, "0")
        Dim count = dataset.Tables(0).Rows.Count

        If count > 0 Then

            If BunifuMetroTextbox1.Text = "admin" Then
                adminlogin.Show()
                Me.Hide()
                Me.Opacity = 0
                con.Close()
            Else
                home.Show()
                Me.Hide()
                Me.Opacity = 0
                con.Close()
            End If

        Else
            MsgBox("Login failed,please enter again", MsgBoxStyle.Critical)
            BunifuMetroTextbox1.Text = ""
            BunifuMetroTextbox2.Text = ""
        End If

    End Sub

    Private Sub BunifuFlatButton2_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton2.Click
        Try
            If MessageBox.Show("Are you sure you want to exit the system", "Sure", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.No Then
                Exit Sub
            ElseIf (Windows.Forms.DialogResult.Yes) Then
                End
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BunifuCustomLabel1_Click(sender As Object, e As EventArgs) Handles BunifuCustomLabel1.Click
        doclogin.Show()
        Me.Hide()
        Me.Opacity = 0
    End Sub

    Private Sub UsersBindingSource_CurrentChanged(sender As Object, e As EventArgs) Handles UsersBindingSource.CurrentChanged

    End Sub

    Private Sub BunifuCustomLabel3_Click(sender As Object, e As EventArgs) Handles BunifuCustomLabel3.Click

    End Sub

    Private Sub BunifuCustomLabel2_Click(sender As Object, e As EventArgs) Handles BunifuCustomLabel2.Click

    End Sub

    Private Sub BunifuMetroTextbox1_OnValueChanged(sender As Object, e As EventArgs) Handles BunifuMetroTextbox1.OnValueChanged

    End Sub

    Private Sub BunifuMetroTextbox2_OnValueChanged(sender As Object, e As EventArgs) Handles BunifuMetroTextbox2.OnValueChanged

    End Sub

    Private Sub BunifuImageButton2_Click(sender As Object, e As EventArgs) Handles BunifuImageButton2.Click

    End Sub

    Private Sub BunifuImageButton3_Click(sender As Object, e As EventArgs) Handles BunifuImageButton3.Click

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub BunifuImageButton1_Click(sender As Object, e As EventArgs) Handles BunifuImageButton1.Click

    End Sub
End Class
