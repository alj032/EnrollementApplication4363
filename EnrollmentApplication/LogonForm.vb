Public Class LoginForm
    Protected db As New db



    Private Sub Skip_Click(sender As Object, e As EventArgs) Handles Skip.Click
        MainForm.Show()
        Me.Hide()

    End Sub
    ''When the login button is clicked we want to see if the username and password are valid and if not then notify the user there is an error
    Private Sub LoginButton_Click(sender As Object, e As EventArgs) Handles LoginButton.Click
        ''https://www.youtube.com/watch?v=2s9BLuhLVY4
        ''This video is extremely helpful

        Dim dataset As New DataSet




        db.sql = "SELECT * From Users Where username= '" & IDTextbox.Text & "' AND Password='" & PasswordTextbox.Text & "';"
        ''db.fill(dataset)


    End Sub
End Class