Public Class MainForm
    ''Calling the db class
    Protected db As New db
    Protected UserID As New Int32




    ''When the form loads up
    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UserID = LoginForm.UserID

        db.sql = "Select * From LOGININFO WHERE ID = @UserID"
        db.bind("@UserID", UserID)
        db.fill(UserInfoDataGridView)

        ''Setting datagrid to select entire rows of data
        StudentsDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        InstructorsDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        CoursesDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect

        ''When the form loads we want to query all of the tables in the database and fill the corresponding data grid view

        ''Filling Students
        db.sql = "SELECT Student_ID, ""Name"", Grade_Level, Major, Age From StudentNames"
        db.fill(StudentsDataGridView)

        ''Filling Instructors
        db.sql = "SELECT Instructor_ID, First_Name, Last_Name From Instructors"
        db.fill(InstructorsDataGridView)

        ''Filling Courses
        db.sql = "Select Course_ID, ""Name"", ""Time"", Room_number from Course"
        db.fill(CoursesDataGridView)




    End Sub

    ''Add Student Button Click
    Private Sub AddStudentButton_Click(sender As Object, e As EventArgs) Handles AddStudentButton.Click
        ''When the addstudentbutton is clicked we want to navigate to the addstudentform so that the user can input new student info into the database
        AddStudentForm.ShowDialog()



    End Sub


    ''Add Instructor Button Click
    Private Sub AddInstructorButton_Click(sender As Object, e As EventArgs) Handles AddInstructorButton.Click
        ''When the AddInstructorButton is clicked we want to navigate to the addinstructorform so that the user can input data into the database

        AddInstructorForm.ShowDialog()
    End Sub

    ''Add Course Button Click
    Private Sub AddCourseButton_Click(sender As Object, e As EventArgs) Handles AddCourseButton.Click
        ''When the AddCourseButton is clicked we want to navigate to the addcourseform so that the user can input data into the database

        AddCourseForm.ShowDialog()
    End Sub


    ''Edit Student Record button Click
    Private Sub EditStudentButton_Click(sender As Object, e As EventArgs) Handles EditStudentButton.Click
        ''When the Edit button is clicked we want to change the visibility of the confirm button and the cancel button

        EditStudentButton.Visible = False
        ConfirmStudentButton.Visible = True
        CancelStudentButton.Visible = True

        ''We also need to change textboxs from read only to false so that the user can now edit the textbox values
        StudentNameTextbox.ReadOnly = False
        StudentAgeTextbox.ReadOnly = False
        StudentGradeTextbox.ReadOnly = False
        StuIDTextBox.ReadOnly = False
        StudentMajorTextbox.ReadOnly = False



    End Sub


    ''Cancel Student Edit Button Click
    Private Sub CancelStudentButton_Click(sender As Object, e As EventArgs) Handles CancelStudentButton.Click
        ''When the user cancels this we want to pop up a dialog box and ask if they are sure they want to cancel

        Dim response As DialogResult = MessageBox.Show("Are you sure you want to cancel?", "Warning!", MessageBoxButtons.YesNo, MessageBoxIcon.Information)

        ''Writing an if statement to see what the user chose
        If response = DialogResult.Yes Then


            ''Set the right buttons back to visible

            EditStudentButton.Visible = True
            ConfirmStudentButton.Visible = False
            CancelStudentButton.Visible = False


            ''Read only set back to true 
            StudentNameTextbox.ReadOnly = True
            StudentAgeTextbox.ReadOnly = True
            StudentGradeTextbox.ReadOnly = True
            StuIDTextBox.ReadOnly = True
            StudentMajorTextbox.ReadOnly = True

        ElseIf response = DialogResult.No Then
            ''When the Edit button is clicked we want to change the visibility of the confirm button and the cancel button

            EditStudentButton.Visible = False
            ConfirmStudentButton.Visible = True
            CancelStudentButton.Visible = True

            ''We also need to change textboxs from read only to false so that the user can now edit the textbox values
            StudentNameTextbox.ReadOnly = False
            StudentAgeTextbox.ReadOnly = False
            StudentGradeTextbox.ReadOnly = False
            StuIDTextBox.ReadOnly = False
            StudentMajorTextbox.ReadOnly = False



        End If

    End Sub



    ''Edit Instructor Button  Click
    Private Sub EditInstructorButton_Click(sender As Object, e As EventArgs) Handles EditInstructorButton.Click
        ''When the Edit button is clicked we want to change the visibility of the confirm button and the cancel button

        EditInstructorButton.Visible = False
        ConfirmInstructorButton.Visible = True
        CancelInstructorButton.Visible = True

        ''We also need to change textboxs from read only to false so that the user can now edit the textbox values
        InstructorFirstNameTextbox.ReadOnly = False
        InstrLastnameTextbox.ReadOnly = False
        InstructorIDTextBox.ReadOnly = False

    End Sub

    ''Cancel Instructor Button Click
    Private Sub CancelInstructorButton_Click(sender As Object, e As EventArgs) Handles CancelInstructorButton.Click
        ''When the user cancels this we want to pop up a dialog box and ask if they are sure they want to cancel

        Dim response As DialogResult = MessageBox.Show("Are you sure you want to cancel?", "Warning!", MessageBoxButtons.YesNo, MessageBoxIcon.Information)

        ''Writing an if statement to see what the user chose
        If response = DialogResult.Yes Then


            ''Set the right buttons back to visible

            EditInstructorButton.Visible = True
            ConfirmInstructorButton.Visible = False
            CancelInstructorButton.Visible = False


            ''Read only set back to true 
            InstructorFirstNameTextbox.ReadOnly = True
            InstrLastnameTextbox.ReadOnly = True
            InstructorIDTextBox.ReadOnly = True

        ElseIf response = DialogResult.No Then
            ''When the Edit button is clicked we want to change the visibility of the confirm button and the cancel button
            EditInstructorButton.Visible = False
            ConfirmInstructorButton.Visible = True
            CancelInstructorButton.Visible = True

            ''We also need to change textboxs from read only to false so that the user can now edit the textbox values
            InstructorFirstNameTextbox.ReadOnly = False
            InstrLastnameTextbox.ReadOnly = False
            InstructorIDTextBox.ReadOnly = False



        End If
    End Sub

    ''Edit Course Button Click
    Private Sub EditCourseButton_Click(sender As Object, e As EventArgs) Handles EditCourseButton.Click
        ''When the Edit button is clicked we want to change the visibility of the confirm button and the cancel button

        EditCourseButton.Visible = False
        ConfirmCourseButton.Visible = True
        CancelCourseButton.Visible = True

        ''We also need to change textboxs from read only to false so that the user can now edit the textbox values
        CourseNameTextbox.ReadOnly = False
        CourseIDTextbox.ReadOnly = False
        CourseTimeTextbox.ReadOnly = False
        RoomNumberTextbox.ReadOnly = False
        CurrentlyEnrolledTextbox.ReadOnly = False


    End Sub


    ''Cancel Course Button Click
    Private Sub CancelCourseButton_Click(sender As Object, e As EventArgs) Handles CancelCourseButton.Click
        ''When the user cancels this we want to pop up a dialog box and ask if they are sure they want to cancel

        Dim response As DialogResult = MessageBox.Show("Are you sure you want to cancel?", "Warning!", MessageBoxButtons.YesNo, MessageBoxIcon.Information)

        ''Writing an if statement to see what the user chose
        If response = DialogResult.Yes Then


            ''Set the right buttons back to visible

            EditCourseButton.Visible = True
            ConfirmCourseButton.Visible = False
            CancelCourseButton.Visible = False


            ''Read only set back to true 
            CourseNameTextbox.ReadOnly = True
            CourseIDTextbox.ReadOnly = True
            CourseTimeTextbox.ReadOnly = True
            RoomNumberTextbox.ReadOnly = True
            CurrentlyEnrolledTextbox.ReadOnly = True

        ElseIf response = DialogResult.No Then
            ''When the Edit button is clicked we want to change the visibility of the confirm button and the cancel button
            EditCourseButton.Visible = False
            ConfirmCourseButton.Visible = True
            CancelCourseButton.Visible = True

            ''We also need to change textboxs from read only to false so that the user can now edit the textbox values
            CourseNameTextbox.ReadOnly = False
            CourseIDTextbox.ReadOnly = False
            CourseTimeTextbox.ReadOnly = False
            RoomNumberTextbox.ReadOnly = False
            CurrentlyEnrolledTextbox.ReadOnly = False



        End If
    End Sub

    ''When the user clicks on a a datagrid view we want to put the information in the corresponding textbox
    ''Student Datagrid view click
    Private Sub StudentsDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles StudentsDataGridView.CellClick

        ''If statement to test whether or not the cells are seleceted and if they are it fills them into the matching textbox
        If (StudentsDataGridView.SelectedRows.Count > 0) Then

            StudentNameTextbox.Text = StudentsDataGridView.SelectedRows(0).Cells(1).Value
            StuIDTextBox.Text = StudentsDataGridView.SelectedRows(0).Cells(0).Value
            StudentMajorTextbox.Text = StudentsDataGridView.SelectedRows(0).Cells(3).Value
            StudentGradeTextbox.Text = StudentsDataGridView.SelectedRows(0).Cells(2).Value
            StudentAgeTextbox.Text = StudentsDataGridView.SelectedRows(0).Cells(4).Value


        End If
    End Sub
    ''When the user clicks on a a datagrid view we want to put the information in the corresponding textbox
    ''Instructor Datagrid view click
    Private Sub InstructorsDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles InstructorsDataGridView.CellClick

        ''If statement to test whether or not the cells are seleceted and if they are it fills them into the matching textbox
        If (InstructorsDataGridView.SelectedRows.Count > 0) Then

            InstructorFirstNameTextbox.Text = InstructorsDataGridView.SelectedRows(0).Cells(1).Value
            InstrLastnameTextbox.Text = InstructorsDataGridView.SelectedRows(0).Cells(2).Value
            InstructorIDTextBox.Text = InstructorsDataGridView.SelectedRows(0).Cells(0).Value



        End If

    End Sub

    ''When the user clicks on a a datagrid view we want to put the information in the corresponding textbox
    ''Course Datagrid view click
    Private Sub CoursesDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles CoursesDataGridView.CellClick
        ''If statement to test whether or not the cells are seleceted and if they are it fills them into the matching textbox
        If (CoursesDataGridView.SelectedRows.Count > 0) Then

            CourseNameTextbox.Text = CoursesDataGridView.SelectedRows(0).Cells(1).Value
            CourseIDTextbox.Text = CoursesDataGridView.SelectedRows(0).Cells(0).Value
            CourseTimeTextbox.Text = CoursesDataGridView.SelectedRows(0).Cells(2).Value ''This line breaks if value in datagrid view is #NULL #BUG
            RoomNumberTextbox.Text = CoursesDataGridView.SelectedRows(0).Cells(3).Value

            ''Reserved for Currently enrolled textbox I may or may not add this functionality
            ''CourseNameTextbox.Text = CoursesDataGridView.SelectedRows(0).Cells(1).Value




        End If
    End Sub

    ''When the user clicks the enroll button we want to place the the corresponding teacher/student into the class
    Private Sub EnrollButton_Click(sender As Object, e As EventArgs) Handles EnrollButton.Click



        db.sql = "INSERT INTO Enroll (Student_ID, Course_ID, Instructor_ID) VALUES (@Student_ID, @Course_ID, @Instructor_ID)"
        db.bind("@Student_ID", StudentsDataGridView.SelectedRows(0).Cells(0).Value)
        db.bind("@Instructor_ID", InstructorsDataGridView.SelectedRows(0).Cells(0).Value)
        db.bind("@Course_ID", CoursesDataGridView.SelectedRows(0).Cells(0).Value)
        db.execute()
    End Sub


    ''When the user clicks the studentsclasses button we want to pull up another form that shows the students classes that their are enrolled in
    Private Sub StudentClassesButton_Click(sender As Object, e As EventArgs) Handles StudentClassesButton.Click
        ''Pulling up the student form
        ViewStudentClassForm.ShowDialog()






    End Sub

    ''When the user clicks the Teachersstudent button we want to pull up another form that shows the teachers students that are currently enrolled
    Private Sub TeachersStudentButton_Click(sender As Object, e As EventArgs) Handles TeachersStudentButton.Click
        ''Pulling up the teachersstudent form
        ViewTeachersStudentsForm.ShowDialog()


    End Sub

    ''When the user clicks the Courseinfo button we want to pull up another form that shows the course info
    Private Sub CourseInfoButton_Click(sender As Object, e As EventArgs) Handles CourseInfoButton.Click
        ''Pulling up the Courseinfo form
        ViewCourseInfoForm.ShowDialog()

    End Sub

    ''When the user hits the confirm button we want to take the text in the textboxes and update the record in the database
    Private Sub ConfirmStudentButton_Click(sender As Object, e As EventArgs) Handles ConfirmStudentButton.Click
        ''When the user confirms this we want to pop up a dialog box and ask if they are sure they want to update the record

        Dim response As DialogResult = MessageBox.Show("Are you sure you want to Update?", "Confirm Updates", MessageBoxButtons.YesNo, MessageBoxIcon.Information)

        ''Writing an if statement to see what the user chose
        If response = DialogResult.Yes Then

            ''Creating Variables where we will store the value that is in the corresponding textbox
            Dim Name As String
            Dim ID As Int32
            Dim Major As String
            Dim Grade As String
            Dim Age As Int16

            ''Getting the ID that we are updating by retrieving the student ID from the datagrid view
            ID = StudentsDataGridView.SelectedRows(0).Cells(0).Value

            ''Setting the variables equal to the value in the corresponding textbox
            Name = StudentNameTextbox.Text
            ID = StuIDTextBox.Text
            Major = StudentMajorTextbox.Text
            Grade = StudentGradeTextbox.Text
            Age = StudentAgeTextbox.Text

            ''taking the values in the textbox and binding them to SQL variables then updating the database
            db.sql = "UPDATE dbo.StudentNames SET Name = @Name, Major = @Major, Grade_Level = @Grade, Age = @Age WHERE Student_ID = @ID;"
            db.bind("@Name", Name)
            db.bind("@ID", ID)
            db.bind("@Major", Major)
            db.bind("@Grade", Grade)
            db.bind("@Age", Age)
            db.execute()






        ElseIf response = DialogResult.No Then




        End If
    End Sub

    ''When the user hits the confirm button we want to take the text in the textboxes and update the record in the database
    Private Sub ConfirmInstructorButton_Click(sender As Object, e As EventArgs) Handles ConfirmInstructorButton.Click
        ''When the user confirms this we want to pop up a dialog box and ask if they are sure they want to update the record

        Dim response As DialogResult = MessageBox.Show("Are you sure you want to Update?", "Confirm Updates", MessageBoxButtons.YesNo, MessageBoxIcon.Information)

        ''Writing an if statement to see what the user chose
        If response = DialogResult.Yes Then

            ''Creating Variables where we will store the value that is in the corresponding textbox
            Dim ID As Int32
            Dim FirstName As String
            Dim LastName As String


            ''Getting the ID that we are updating by retrieving the Instructor ID from the datagrid view
            ID = InstructorsDataGridView.SelectedRows(0).Cells(0).Value

            ''Setting the variables equal to the value in the corresponding textbox

            FirstName = InstructorFirstNameTextbox.Text
            LastName = InstrLastnameTextbox.Text



            ''taking the values in the textbox and binding them to SQL variables then updating the database
            db.sql = "UPDATE dbo.Instructors SET First_Name = @FirstName, Last_Name = @LastName WHERE Instructor_ID = @ID;"
            db.bind("@FirstName", FirstName)
            db.bind("@LastName", LastName)
            db.bind("@ID", ID)
            db.execute()






        ElseIf response = DialogResult.No Then




        End If
    End Sub

    ''When the user hits the confirm button we want to take the text in the textboxes and update the record in the database
    Private Sub ConfirmCourseButton_Click(sender As Object, e As EventArgs) Handles ConfirmCourseButton.Click
        ''When the user confirms this we want to pop up a dialog box and ask if they are sure they want to update the record

        Dim response As DialogResult = MessageBox.Show("Are you sure you want to Update?", "Confirm Updates", MessageBoxButtons.YesNo, MessageBoxIcon.Information)

        ''Writing an if statement to see what the user chose
        If response = DialogResult.Yes Then

            ''Creating Variables where we will store the value that is in the corresponding textbox
            Dim ID As Int32
            Dim Name As String
            Dim Time As String
            Dim RoomNumber As String
            Dim CourseID As Int32


            ''Getting the ID that we are updating by retrieving the Instructor ID from the datagrid view
            ID = CoursesDataGridView.SelectedRows(0).Cells(0).Value

            ''Setting the variables equal to the value in the corresponding textbox

            Name = CourseNameTextbox.Text
            Time = CourseTimeTextbox.Text
            RoomNumber = RoomNumberTextbox.Text




            ''taking the values in the textbox and binding them to SQL variables then updating the database
            db.sql = "UPDATE dbo.Course SET Name = @Name, Time = @Time, Room_Number = @RoomNumber WHERE Course_ID = @ID;"
            db.bind("@Name", Name)
            db.bind("@Time", Time)
            db.bind("@RoomNumber", RoomNumber)
            db.bind("@CourseID", CourseID)
            db.bind("@ID", ID)
            db.execute()






        ElseIf response = DialogResult.No Then




        End If
    End Sub

    ''When any text is changed in the search box we want to search the table for values like the text the user entered
    Private Sub StudentSearchTextBox_TextChanged(sender As Object, e As EventArgs) Handles StudentSearchTextBox.TextChanged

        ''We are using a like statement to search every column for a value like whatever is typed in the textbox. When the text box is blank it automatically selects all values so this works out good.
        db.sql = "Select * From dbo.StudentNames Where Name like '%" & StudentSearchTextBox.Text & "%' OR Major like '%" & StudentSearchTextBox.Text & "%' OR Grade_Level like '%" & StudentSearchTextBox.Text & "%' OR Age like '%" & StudentSearchTextBox.Text & "%' OR Student_ID like '%" & StudentSearchTextBox.Text & "%' "
        db.fill(StudentsDataGridView)

    End Sub
    ''When any text is changed in the search box we want to search the table for values like the text the user entered
    Private Sub InstructorSearchTextBox_TextChanged(sender As Object, e As EventArgs) Handles InstructorSearchTextBox.TextChanged

        ''We are using a like statement to search every column for a value like whatever is typed in the textbox. When the text box is blank it automatically selects all values so this works out good.
        db.sql = "Select Instructor_ID, First_Name, Last_Name From dbo.Instructors Where First_Name like '%" & InstructorSearchTextBox.Text & "%' OR Last_Name like '%" & InstructorSearchTextBox.Text & "%' OR Instructor_ID like '%" & InstructorSearchTextBox.Text & "%' "
        db.fill(InstructorsDataGridView)

    End Sub
    ''When any text is changed in the search box we want to search the table for values like the text the user entered
    Private Sub CourseSearchBox_TextChanged(sender As Object, e As EventArgs) Handles CourseSearchBox.TextChanged
        ''We are using a like statement to search every column for a value like whatever is typed in the textbox. When the text box is blank it automatically selects all values so this works out good.
        db.sql = "Select * From dbo.Course Where Name like '%" & CourseSearchBox.Text & "%' OR Time like '%" & CourseSearchBox.Text & "%' OR Room_Number like '%" & CourseSearchBox.Text & "%' OR Course_ID like '%" & CourseSearchBox.Text & "%'"
        db.fill(CoursesDataGridView)
    End Sub


End Class
