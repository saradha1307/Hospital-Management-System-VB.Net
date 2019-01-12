Imports System.Data.SqlClient
Imports System.Data.Sql

Public Class dochome

    Dim f As New Form

    Private Sub BunifuFlatButton9_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton9.Click
        f.Dispose()
        f = docprofile
        f.TopLevel = False
        Me.Panel2.Controls.Add(f)
        f.Show()
    End Sub

    Private Sub BunifuFlatButton2_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton2.Click
        f.Dispose()
        f = docbill
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

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub BunifuGradientPanel1_Paint(sender As Object, e As PaintEventArgs) Handles BunifuGradientPanel1.Paint

    End Sub
End Class