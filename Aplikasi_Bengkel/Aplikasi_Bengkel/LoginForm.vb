Public Class LoginForm
    Sub login()
        If txtUsername.Text = "" Or txtPassword.Text = "" Then
            MsgBox("Masukkan Username & Password", MsgBoxStyle.Information, "Information")

        Else
            Call Koneksi()
            Dim str As String

            str = "Select * From tbl_user where username = '" + txtUsername.Text + "'And password = '" + txtPassword.Text + "'"
            cmd = New OleDb.OleDbCommand(str, Conn)
            cmd.ExecuteNonQuery()
            dr = cmd.ExecuteReader()
            If dr.HasRows = 0 Then
                MsgBox("Login Gagal", MsgBoxStyle.Information, "Information")
                txtUsername.ForeColor = Color.Blue
            Else
                dr.Read()
                Form3.Show()
                Me.Hide()
               
                MsgBox("Login Berhasil  " & txtUsername.Text & " ", MsgBoxStyle.Information, "Information)")


            End If
        End If
    End Sub

    Private Sub txtUsername_Leave(sender As Object, e As EventArgs) Handles txtUsername.Leave
        If txtUsername.Text = "Username" Or txtUsername.Text = "" Then
            txtUsername.ForeColor = Color.Silver
            txtUsername.Text = "Username"
        End If
    End Sub

    Private Sub txtUsername_MouseClick(sender As Object, e As MouseEventArgs) Handles txtUsername.MouseClick
        If txtUsername.Text = "Username" Then
            txtUsername.Clear()
            txtUsername.ForeColor = Color.Black
        End If
    End Sub

    Private Sub txtUsername_TextChanged(sender As Object, e As EventArgs) Handles txtUsername.TextChanged
        If txtUsername.Text = "Username" Then
            txtUsername.ForeColor = Color.Silver
        Else
            txtUsername.ForeColor = Color.Black
        End If
    End Sub

    Private Sub txtPassword_Leave(sender As Object, e As EventArgs) Handles txtPassword.Leave
        If txtPassword.Text = "Password" Or txtPassword.Text = "" Then
            txtPassword.ForeColor = Color.Silver
            txtPassword.Text = "Password"
            txtPassword.PasswordChar = ""
        End If
    End Sub

    Private Sub txtPassword_MouseClick(sender As Object, e As MouseEventArgs) Handles txtPassword.MouseClick
        If txtPassword.Text = "Password" Or txtUsername.Text = "Username" Then
            txtPassword.Clear()
            txtPassword.ForeColor = Color.Black
            txtPassword.PasswordChar = "*"
            txtUsername.ForeColor = Color.Silver
        End If
    End Sub

    Private Sub btnMasuk_Click(sender As Object, e As EventArgs) Handles btnMasuk.Click
        Call login()

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        End
    End Sub
End Class
