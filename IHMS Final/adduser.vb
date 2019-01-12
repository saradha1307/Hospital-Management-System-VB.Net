Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.Sql
Imports System.Data.SqlTypes
Imports System.IO

Public Class adduser

    Private mImageFile As Image
    Private mImageFilePath As String
    Dim OpenFileDialog1 As New OpenFileDialog
    Dim con = New SqlConnection("Data Source=localhost\SQLEXPRESS;Initial Catalog=project;Integrated Security=True")
    Dim sv As String = "INSERT INTO profile(id,name,lname,gender,age,dob,bloodgp,nationality,occupation,email,password,image,city,mobile) VALUES(@id, @name,@lname,@gender, @age, @dob, @bg, @natn, @occ, @email, @password,@image,@city,@mob)"
    Dim cmd As SqlCommand = New SqlCommand(sv, con)

    Private Sub BunifuFlatButton1_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton1.Click

        If (BunifuMetroTextbox2.Text <> "" And BunifuMetroTextbox1.Text <> "" And BunifuMetroTextbox9.Text <> "" And BunifuMetroTextbox10.Text <> "" And BunifuMetroTextbox4.Text <> "" And BunifuMetroTextbox6.Text <> "") Then

            If BunifuMetroTextbox4.Text = BunifuMetroTextbox5.Text Then



                Try
                    Dim ms As New MemoryStream()
                    PictureBox1.Image.Save(ms, PictureBox1.Image.RawFormat)
                    Dim data As Byte() = ms.GetBuffer()
                    Dim p As New SqlParameter("@image", SqlDbType.Image)
                    p.Value = data
                    cmd.Parameters.Add(p)

                    cmd.Parameters.Add(New SqlClient.SqlParameter("@id", SqlDbType.NChar)).Value = Trim(BunifuMetroTextbox2.Text)
                    cmd.Parameters.Add(New SqlClient.SqlParameter("@name", SqlDbType.NChar)).Value = Trim(BunifuMetroTextbox1.Text)
                    cmd.Parameters.Add(New SqlClient.SqlParameter("@lname", SqlDbType.NChar)).Value = Trim(BunifuMetroTextbox6.Text)
                    cmd.Parameters.Add(New SqlClient.SqlParameter("@gender", SqlDbType.NChar)).Value = Trim(BunifuDropdown1.selectedValue)
                    cmd.Parameters.Add(New SqlClient.SqlParameter("@dob", SqlDbType.NChar)).Value = Trim(BunifuDatepicker1.Value.Date)
                    cmd.Parameters.Add(New SqlClient.SqlParameter("@bg", SqlDbType.NChar)).Value = Trim(BunifuDropdown2.selectedValue)
                    cmd.Parameters.Add(New SqlClient.SqlParameter("@natn", SqlDbType.NChar)).Value = Trim(BunifuDropdown3.selectedValue)
                    cmd.Parameters.Add(New SqlClient.SqlParameter("@occ", SqlDbType.NChar)).Value = Trim(BunifuMetroTextbox9.Text)
                    cmd.Parameters.Add(New SqlClient.SqlParameter("@email", SqlDbType.NChar)).Value = Trim(BunifuMetroTextbox10.Text)
                    cmd.Parameters.Add(New SqlClient.SqlParameter("@password", SqlDbType.NChar)).Value = Trim(BunifuMetroTextbox4.Text)
                    cmd.Parameters.Add(New SqlClient.SqlParameter("@city", SqlDbType.NChar)).Value = Trim(BunifuMetroTextbox7.Text)
                    cmd.Parameters.Add(New SqlClient.SqlParameter("@mob", SqlDbType.Int)).Value = Trim(BunifuMetroTextbox8.Text)

                    con.Open()

                    cmd.ExecuteNonQuery()

                    con.Close()

                    MessageBox.Show("New user added")
                    BunifuMetroTextbox2.Text = ""
                    BunifuMetroTextbox1.Text = ""
                    BunifuDatepicker1.Text = ""
                    BunifuMetroTextbox9.Text = ""
                    BunifuMetroTextbox10.Text = ""
                    BunifuMetroTextbox4.Text = ""
                    BunifuMetroTextbox5.Text = ""
                    BunifuMetroTextbox6.Text = ""
                    BunifuMetroTextbox8.Text = ""
                    BunifuMetroTextbox7.Text = ""
                    BunifuDropdown1.selectedIndex = -1
                    BunifuDropdown2.selectedIndex = -1
                    BunifuDropdown3.selectedIndex = -1


                Catch ex As Exception

                    MessageBox.Show("Please check for fields or images which are not filled", "Data Error")

                    Exit Sub

                End Try
            Else
                MessageBox.Show("Password does not match")
                BunifuMetroTextbox4.Text = ""
                BunifuMetroTextbox5.Text = ""
            End If
        Else
            MessageBox.Show("Please enter all the fields")
        End If

    End Sub

    Private Sub BunifuFlatButton2_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton2.Click
        Dim ImageDialogue As OpenFileDialog = New OpenFileDialog()

        ImageDialogue.Title = "Select your Image."
        ImageDialogue.InitialDirectory = "C:\"
        ImageDialogue.Filter = "Image Files|*.gif;*.jpg;*.png;*.bmp;"
        ImageDialogue.RestoreDirectory = False

        If ImageDialogue.ShowDialog() = DialogResult.OK Then
            PictureBox1.Image = Image.FromFile(ImageDialogue.FileName)
        End If
    End Sub

    Private Sub BunifuMetroTextbox8_LostFocus(sender As Object, e As EventArgs) Handles BunifuMetroTextbox8.LostFocus
        
    End Sub

    Private Sub BunifuMetroTextbox8_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles BunifuMetroTextbox8.Validating
        If IsNumeric(BunifuMetroTextbox8.Text) Then

        Else
            MsgBox("Numbers only Allowed")
        End If
    End Sub

    Private Sub BunifuMetroTextbox5_OnValueChanged(sender As Object, e As EventArgs) Handles BunifuMetroTextbox5.OnValueChanged

    End Sub

    Private Sub BunifuMetroTextbox4_OnValueChanged(sender As Object, e As EventArgs) Handles BunifuMetroTextbox4.OnValueChanged

    End Sub

    Private Sub BunifuMetroTextbox10_OnValueChanged(sender As Object, e As EventArgs) Handles BunifuMetroTextbox10.OnValueChanged
        Dim str As String = BunifuMetroTextbox10.Text
        If str.Contains("@") And str.Contains(".com") Then
        Else
            MsgBox("Enter valid email id")
        End If
    End Sub
End Class