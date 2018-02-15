Public Class MainForm
    ''Calling the db class
    Protected db As New db



    ''When the form loads up
    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ''Setting datagrid to select entire rows of data
        StudentsDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        InstructorsDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        CoursesDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect

        ''When the form loads we want to query all of the tables in the database and fill the corresponding data grid view

        ''Filling Students
        db.sql = "SELECT Student_ID, ""Name"", Grade_Level, Major, Age From StudentNames"
        db.fill(StudentsDataGridView)

        ''Filling Instructors
        db.sql = "SELECT * From Instructors"
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
            CourseTimeTextbox.Text = CoursesDataGridView.SelectedRows(0).Cells(2).Value
            RoomNumberTextbox.Text = CoursesDataGridView.SelectedRows(0).Cells(3).Value

            ''Reserved for Currently enrolled textbox I may or may not add this functionality
            ''CourseNameTextbox.Text = CoursesDataGridView.SelectedRows(0).Cells(1).Value




        End If
    End Sub

    ''When the user clicks the enroll button we want to place the the corresponding teacher/student into the class
    Private Sub EnrollButton_Click(sender As Object, e As EventArgs) Handles EnrollButton.Click



        db.sql = "INSERT INTO Enroll (Student_ID, Course_ID, Instructor_ID) VALUES (@Student_ID, @Course_ID, @Instructor_ID)"
        db.bind("@Student_ID", StudentsDataGridView.SelectedRows(0).Cells(0).Value)
        db.bind("@Course_ID", InstructorsDataGridView.SelectedRows(0).Cells(0).Value)
        db.bind("@Instructor_ID", CoursesDataGridView.SelectedRows(0).Cells(0).Value)
        db.execute()
    End Sub


    ''When the user clicks the studentsclasses button we want to pull up another form that shows the students classes that their are enrolled in
    Private Sub StudentClassesButton_Click(sender As Object, e As EventArgs) Handles StudentClassesButton.Click
        ''Pulling up the student form
        ViewStudentClassForm.Show()


    End Sub

    ''When the user clicks the Teachersstudent button we want to pull up another form that shows the teachers students that are currently enrolled
    Private Sub TeachersStudentButton_Click(sender As Object, e As EventArgs) Handles TeachersStudentButton.Click
        ''Pulling up the teachersstudent form
        ViewTeachersStudentsForm.Show()


    End Sub

    ''When the user clicks the Courseinfo button we want to pull up another form that shows the course info
    Private Sub CourseInfoButton_Click(sender As Object, e As EventArgs) Handles CourseInfoButton.Click
        ''Pulling up the Courseinfo form
        ViewCourseInfoForm.Show()

    End Sub
End Class
