Public Class AddCourseForm
    ''Calling the db class
    Protected db As New db

    Private Sub AddCourseButton_Click(sender As Object, e As EventArgs) Handles AddCourseButton.Click
        ''For now we are just going to make sure that we can insert a record.
        ''I will need to come back and make sure that I am validating user input so that only text characters can be entered.

        ''This code gets the values that are in the textbox and binds them to a variable. It then gets the value of the variable and inserts it into the database.
        ''We already setup the database to autoincrement the instructor_Id so all we have to worry about is the first and last name :)
        ''I also need to refresh the datagrid view on the mainform to refelect the added students


        ''Need to make sure combo box is selected and all fields are valid
        db.sql = "INSERT INTO Course (Name, Time, Room_Number)  VALUES (@Name, @Time, @Room_Number)"
        db.bind("@Name", AddCourseTextBox.Text)
        db.bind("@Time", AddCourseTimetextbox.Text)
        db.bind("@Room_Number", AddCourseRoomtextbox.Text)
        db.execute()


    End Sub
End Class