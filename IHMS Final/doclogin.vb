Imports System.Data.SqlClient
Imports System.Data.Sql

Public Class doclogin

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

    Private Sub BunifuFlatButton1_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton1.Click

        Dim con As New SqlConnection
        Dim comm As New SqlCommand
        Dim adapter As New SqlDataAdapter
        Dim dataset As New DataSet

        con.ConnectionString = "Data Source=localhost\sqlexpress;Initial Catalog=project;Integrated Security=True"

        comm.CommandText = "select * from docdetails where docid = '" & BunifuMetroTextbox1.Text & "' And password = '" & BunifuMetroTextbox2.Text & "';"
        con.Open()
        comm.Connection = con
        adapter.SelectCommand = comm
        adapter.Fill(dataset, "0")
        Dim count = dataset.Tables(0).Rows.Count

        If count > 0 Then
            dochome.Show()
            Me.Hide()
            Me.Opacity = 0
            con.Close()
        Else
            MsgBox("Login failed,please enter again", MsgBoxStyle.Critical)
            BunifuMetroTextbox1.Text = ""
            BunifuMetroTextbox2.Text = ""
        End If
    End Sub

    Private Sub BunifuMetroTextbox1_OnValueChanged(sender As Object, e As EventArgs) Handles BunifuMetroTextbox1.OnValueChanged

    End Sub

    Private Sub BunifuMetroTextbox2_OnValueChanged(sender As Object, e As EventArgs) Handles BunifuMetroTextbox2.OnValueChanged

    End Sub
End Class