Public Class LoginForm
    Protected db As New db
    Public UserID As New Int32




    Private Sub Skip_Click(sender As Object, e As EventArgs) Handles Skip.Click
        MainForm.Show()
        Me.Hide()

    End Sub
    ''When the login button is clicked we want to see if the username and password are valid and if not then notify the user there is an error
    Private Sub LoginButton_Click(sender As Object, e As EventArgs) Handles LoginButton.Click
        ''https://www.youtube.com/watch?v=2s9BLuhLVY4
        ''This video is extremely helpful

        ''Going to create a data set that will be filled with the results that we query when the login button is clicked.
        Dim LoginQuery As New DataGridView

        Dim ID As Int32
        Dim Password As String

        Int32.TryParse(IDTextbox.Text, ID)
        Password = PasswordTextbox.Text


        ''Query database based off of user input
        db.sql = "Select * From IDPASS Where ID = @ID and Password = @PASS"
        db.bind("@ID", ID)
        db.bind("@PASS", Password)

        ''db.fill(LoginQuery)
        db.fill(LoginResults)



        If LoginResults.Rows.Count() <= 0 Then

            MessageBox.Show("Bad username or password combination! Try Again!")

        ElseIf LoginResults.Rows.Count() > 0 Then

            MessageBox.Show("Successful Login")

            UserID = ID

            MainForm.Show()
            Me.Close()



        End If


    End Sub
End Class