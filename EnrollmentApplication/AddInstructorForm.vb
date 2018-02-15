Public Class AddInstructorForm
    ''Calling the db class
    Protected db As New db

    ''When the user clicks add button we want to add instructor to the database and make sure that it is a valid name (Only text characters)
    Private Sub AddInstructorButton_Click(sender As Object, e As EventArgs) Handles AddInstructorButton.Click
        ''For now we are just going to make sure that we can insert a record.
        ''I will need to come back and make sure that I am validating user input so that only text characters can be entered.

        ''This code gets the values that are in the textbox and binds them to a variable. It then gets the value of the variable and inserts it into the database.
        ''We already setup the database to autoincrement the instructor_Id so all we have to worry about is the first and last name :)
        ''I also need to refresh the datagrid view on the mainform to refelect the added instructors

        db.sql = "INSERT INTO Instructors (First_Name, Last_Name)  VALUES (@Firstname, @Lastname)"
        db.bind("@Firstname", AddInstructorFirstNameTextbox.Text)
        db.bind("@Lastname", Addinstructorlastnametextbox.Text)
        db.execute()


    End Sub
End Class