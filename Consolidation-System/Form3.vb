Imports Npgsql
Public Class Form3
    Dim connString As String = "Host=localhost;Port=5432;Username=postgres;Password=password;Database=ConsolidationdDb;"
    Dim conn As NpgsqlConnection = New NpgsqlConnection(connString)
    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        Dim firstName As String = txtFName.Text
        Dim lastName As String = txtLName.Text
        Dim position As String = cmbPosition.Text
        Dim username As String = txtUsername.Text
        Dim password As String = txtPassword.Text

        Dim query As String = "INSERT INTO users (FirstName, LastName, Position, Username, Password) VALUES (@firstName, @lastName, @position, @username, @password)"
        Dim cmd As NpgsqlCommand = New NpgsqlCommand(query, conn)
        cmd.Parameters.AddWithValue("@firstName", firstName)
        cmd.Parameters.AddWithValue("@lastName", lastName)
        cmd.Parameters.AddWithValue("@position", position)
        cmd.Parameters.AddWithValue("@username", username)
        cmd.Parameters.AddWithValue("@password", password)

        Try
            conn.Open()
            cmd.ExecuteNonQuery()
            MessageBox.Show("User registered successfully.")
            Form1.Show()
            Me.Hide()
        Catch ex As Exception
            MessageBox.Show("Error registering user: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub
End Class