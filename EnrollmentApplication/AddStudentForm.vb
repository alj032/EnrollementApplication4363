Public Class AddStudentForm
    ''Calling the db class
    Protected db As New db

    Private Sub AddStudentButton_Click(sender As Object, e As EventArgs) Handles AddStudentButton.Click
        ''For now we are just going to make sure that we can insert a record.
        ''I will need to come back and make sure that I am validating user input so that only text characters can be entered.

        ''This code gets the values that are in the textbox and binds them to a variable. It then gets the value of the variable and inserts it into the database.
        ''We already setup the database to autoincrement the instructor_Id so all we have to worry about is the first and last name :)
        ''I also need to refresh the datagrid view on the mainform to refelect the added students


        ''Need to make sure combo box is selected and all fields are valid
        db.sql = "INSERT INTO Studentnames (Name, Major, Grade_Level, Age)  VALUES (@Name, @Major, @Grade_Level, @Age)"
        db.bind("@Name", AddStudentFirstNameTextbox.Text)
        db.bind("@Major", MajorComboBox.Text)
        db.bind("@Grade_Level", GradeComboBox.Text)
        db.bind("@Age", StudentAgeTextbox.Text)
        db.execute()


    End Sub
End Class