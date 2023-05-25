Imports MySql.Data.MySqlClient
Public Class Register
    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        Call Connect_to_DB()
        Dim mycmd As New MySqlCommand

        Dim fullName As String = txtName.Text
        Dim username As String = txtUsername.Text
        Dim password As String = txtPassword.Text


        Dim sql As String = "INSERT INTO user (fullName, username, password) VALUES (@fullName, @username, @password)"
        mycmd = New MySqlCommand(sql, myconn)

        mycmd.Parameters.AddWithValue("@fullName", fullName)
        mycmd.Parameters.AddWithValue("@username", username)
        mycmd.Parameters.AddWithValue("@password", password)
        mycmd.ExecuteNonQuery()
        MessageBox.Show("Account Successfully Created!", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Call Disconnect_to_DB()
        Form1.Show()
        Hide()
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Me.Hide()
        Form1.Show()
    End Sub
End Class