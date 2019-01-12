Imports System.Data.SqlClient
Imports System.Data.Sql

Public Class home

    Dim f As New Form

    Private Sub BunifuGradientPanel1_Paint(sender As Object, e As PaintEventArgs) Handles BunifuGradientPanel1.Paint

    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub



    Private Sub BunifuFlatButton9_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton9.Click
        f.Dispose()
        f = profile
        f.TopLevel = False
        Me.Panel2.Controls.Add(f)
        f.Show()
    End Sub

    Private Sub BunifuFlatButton1_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton1.Click
        f.Dispose()
        f = bookap
        f.TopLevel = False
        Me.Panel2.Controls.Add(f)
        f.Show()
    End Sub

    Private Sub BunifuFlatButton2_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton2.Click
        f.Dispose()
        f = order
        f.TopLevel = False
        Me.Panel2.Controls.Add(f)
        f.Show()
    End Sub


    Private Sub BunifuFlatButton4_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton4.Click
        f.Dispose()
        f = history
        f.TopLevel = False
        Me.Panel2.Controls.Add(f)
        f.Show()
    End Sub

    Private Sub BunifuFlatButton5_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton5.Click
        f.Dispose()
        f = aboutus
        f.TopLevel = False
        Me.Panel2.Controls.Add(f)
        f.Show()
    End Sub

    Private Sub BunifuFlatButton6_Click(sender As Object, e As EventArgs)
        f.Dispose()
        f = adminlogin
        f.TopLevel = False
        Me.Panel2.Controls.Add(f)
        f.Show()
    End Sub

    Private Sub BunifuFlatButton8_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton8.Click
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


End Class