Imports System.Data.SqlClient
Imports System.Data.Sql

Public Class profile

    Dim con As New SqlConnection("Data Source=localhost\SQLEXPRESS;Initial Catalog=project;Integrated Security=True")
    Dim cmd As SqlCommand
    Dim da As SqlDataAdapter
    Dim dr As SqlDataReader
    Dim dt As DataSet

    Private Sub BunifuCustomLabel15_Click(sender As Object, e As EventArgs) Handles BunifuCustomLabel15.Click

    End Sub

    Private Sub profile_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BunifuCustomLabel15.Text = Login.BunifuMetroTextbox1.Text

        con.Open()
        Dim qwerty As String = "select id from profile where name = '" & BunifuCustomLabel15.Text & "'; "
        Dim cmd1 As New SqlCommand(qwerty, con)
        Dim datan As SqlDataReader = cmd1.ExecuteReader
        If datan.HasRows Then
            Do While datan.Read()
                BunifuCustomLabel9.Text = datan(0).ToString()
            Loop
        Else
            BunifuCustomLabel9.Text = "No Data"
        End If

        con.Close()

        con.Open()
        Dim qwerty1 As String = "select name from profile where name = '" & BunifuCustomLabel15.Text & "'; "
        Dim cmd2 As New SqlCommand(qwerty1, con)
        Dim datan1 As SqlDataReader = cmd2.ExecuteReader
        If datan1.HasRows Then
            Do While datan1.Read()
                BunifuCustomLabel28.Text = datan1(0).ToString()
            Loop
        Else
            BunifuCustomLabel28.Text = "No Data"
        End If
        con.Close()

        con.Open()
        Dim qwerty2 As String = "select lname from profile where name = '" & BunifuCustomLabel15.Text & "'; "
        Dim cmd3 As New SqlCommand(qwerty2, con)
        Dim datan2 As SqlDataReader = cmd3.ExecuteReader
        If datan2.HasRows Then
            Do While datan2.Read()
                BunifuCustomLabel18.Text = datan2(0).ToString()
            Loop
        Else
            BunifuCustomLabel18.Text = "No Data"
        End If
        con.Close()

        con.Open()
        Dim qwerty3 As String = "select city from profile where name = '" & BunifuCustomLabel15.Text & "'; "
        Dim cmd4 As New SqlCommand(qwerty3, con)
        Dim datan3 As SqlDataReader = cmd4.ExecuteReader
        If datan3.HasRows Then
            Do While datan3.Read()
                BunifuCustomLabel16.Text = datan3(0).ToString()
            Loop
        Else
            BunifuCustomLabel16.Text = "No Data"
        End If
        con.Close()

        con.Open()
        Dim qwerty4 As String = "select gender from profile where name = '" & BunifuCustomLabel15.Text & "'; "
        Dim cmd5 As New SqlCommand(qwerty4, con)
        Dim datan4 As SqlDataReader = cmd5.ExecuteReader
        If datan4.HasRows Then
            Do While datan4.Read()
                BunifuCustomLabel14.Text = datan4(0).ToString()
            Loop
        Else
            BunifuCustomLabel14.Text = "No Data"
        End If
        con.Close()

        con.Open()
        Dim qwerty6 As String = "select bloodgp from profile where name = '" & BunifuCustomLabel15.Text & "'; "
        Dim cmd7 As New SqlCommand(qwerty6, con)
        Dim datan6 As SqlDataReader = cmd7.ExecuteReader
        If datan6.HasRows Then
            Do While datan6.Read()
                BunifuCustomLabel10.Text = datan6(0).ToString()
            Loop
        Else
            BunifuCustomLabel10.Text = "No Data"
        End If
        con.Close()

        con.Open()
        Dim qwerty7 As String = "select dob from profile where name = '" & BunifuCustomLabel15.Text & "'; "
        Dim cmd8 As New SqlCommand(qwerty7, con)
        Dim datan7 As SqlDataReader = cmd8.ExecuteReader
        If datan7.HasRows Then
            Do While datan7.Read()
                BunifuCustomLabel11.Text = datan7(0).ToString()
            Loop
        Else
            BunifuCustomLabel11.Text = "No Data"
        End If
        con.Close()

        con.Open()
        Dim qwerty8 As String = "select nationality from profile where name = '" & BunifuCustomLabel15.Text & "'; "
        Dim cmd9 As New SqlCommand(qwerty8, con)
        Dim datan8 As SqlDataReader = cmd9.ExecuteReader
        If datan8.HasRows Then
            Do While datan8.Read()
                BunifuCustomLabel20.Text = datan8(0).ToString()
            Loop
        Else
            BunifuCustomLabel20.Text = "No Data"
        End If
        con.Close()

        con.Open()
        Dim qwerty9 As String = "select occupation from profile where name = '" & BunifuCustomLabel15.Text & "'; "
        Dim cmd10 As New SqlCommand(qwerty9, con)
        Dim datan9 As SqlDataReader = cmd10.ExecuteReader
        If datan9.HasRows Then
            Do While datan9.Read()
                BunifuCustomLabel21.Text = datan9(0).ToString()
            Loop
        Else
            BunifuCustomLabel21.Text = "No Data"
        End If
        con.Close()

        con.Open()
        Dim qwerty10 As String = "select mobile from profile where name = '" & BunifuCustomLabel15.Text & "'; "
        Dim cmd11 As New SqlCommand(qwerty10, con)
        Dim datan10 As SqlDataReader = cmd11.ExecuteReader
        If datan10.HasRows Then
            Do While datan10.Read()
                BunifuCustomLabel26.Text = datan10(0).ToString()
            Loop
        Else
            BunifuCustomLabel26.Text = "No Data"
        End If
        con.Close()

        con.Open()
        Dim qwerty11 As String = "select email from profile where name = '" & BunifuCustomLabel15.Text & "'; "
        Dim cmd12 As New SqlCommand(qwerty11, con)
        Dim datan11 As SqlDataReader = cmd12.ExecuteReader
        If datan11.HasRows Then
            Do While datan11.Read()
                BunifuCustomLabel24.Text = datan11(0).ToString()
            Loop
        Else
            BunifuCustomLabel24.Text = "No Data"
        End If
        con.Close()

        con.Open()
        Dim cmd As New System.Data.SqlClient.SqlCommand("select image from profile where name = '" & BunifuCustomLabel15.Text & "'")
        cmd.Connection = con
        cmd.CommandType = CommandType.Text
        Dim ImgStream As New IO.MemoryStream(CType(cmd.ExecuteScalar, Byte()))
        PictureBox1.Image = Image.FromStream(ImgStream)
        ImgStream.Dispose()
        con.Close()

    End Sub

    Private Sub BunifuCustomLabel9_Click(sender As Object, e As EventArgs) Handles BunifuCustomLabel9.Click

    End Sub

    Private Sub BunifuCustomLabel12_Click(sender As Object, e As EventArgs)

    End Sub
End Class