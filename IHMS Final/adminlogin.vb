Imports System.Data.SqlClient
Imports System.Data.Sql

Public Class adminlogin

    Dim f As New Form

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub BunifuFlatButton7_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub BunifuFlatButton9_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton9.Click
        f.Dispose()
        f = doctor
        f.TopLevel = False
        Me.Panel1.Controls.Add(f)
        f.Show()
    End Sub

    Private Sub BunifuFlatButton3_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton3.Click
        f.Dispose()
        f = billing
        f.TopLevel = False
        Me.Panel1.Controls.Add(f)
        f.Show()
    End Sub

    Private Sub BunifuFlatButton4_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton4.Click
        f.Dispose()
        f = search
        f.TopLevel = False
        Me.Panel1.Controls.Add(f)
        f.Show()
    End Sub

    Private Sub BunifuFlatButton5_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton5.Click
        f.Dispose()
        f = adduser
        f.TopLevel = False
        Me.Panel1.Controls.Add(f)
        f.Show()
    End Sub

    Private Sub BunifuFlatButton10_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton10.Click
        f.Dispose()
        f = patient
        f.TopLevel = False
        Me.Panel1.Controls.Add(f)
        f.Show()
    End Sub

    Private Sub BunifuFlatButton1_Click_1(sender As Object, e As EventArgs) Handles BunifuFlatButton1.Click
        f.Dispose()
        f = pswdreset
        f.TopLevel = False
        Me.Panel1.Controls.Add(f)
        f.Show()
    End Sub

    Private Sub BunifuFlatButton6_Click(sender As Object, e As EventArgs)

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

    Private Sub BunifuGradientPanel1_Paint(sender As Object, e As PaintEventArgs) Handles BunifuGradientPanel1.Paint

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub BunifuFlatButton1_Click(sender As Object, e As EventArgs)

    End Sub
End Class