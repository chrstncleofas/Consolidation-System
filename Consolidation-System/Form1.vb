Imports Npgsql
Public Class Form1
    Dim connString As String = "Host=localhost;Port=5432;Username=postgres;Password=password;Database=ConsolidationdDb;"
    Dim conn As NpgsqlConnection = New NpgsqlConnection(connString)
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim username As String = txtUsername.Text
        Dim password As String = txtPassword.Text

        Dim query As String = "SELECT COUNT(*) FROM users WHERE Username=@username AND Password=@password"
        Dim cmd As NpgsqlCommand = New NpgsqlCommand(query, conn)

        cmd.Parameters.AddWithValue("@username", username)
        cmd.Parameters.AddWithValue("@password", password)
        Try
            conn.Open()
            Dim result As Integer = Convert.ToInt32(cmd.ExecuteScalar())
            If result > 0 Then
                MessageBox.Show("Login Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Form2.Show()
                Me.Hide()
            ElseIf txtUsername.Text = "" And txtPassword.Text = "" Then
                MessageBox.Show("Please fillup the username and password", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                MessageBox.Show("Invalid username or password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show("Error logging in: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub
    Private Sub btnRegister_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles btnRegister.LinkClicked
        Form3.Show()
        Me.Hide()
    End Sub
End Class
