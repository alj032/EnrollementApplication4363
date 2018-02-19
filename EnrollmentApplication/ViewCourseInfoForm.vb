Public Class ViewCourseInfoForm
    ''Calling the db class
    Protected db As New db



    Private Sub ViewCourseInfoForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ''Setting datagrid to select entire rows of data
        CourseRosterDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect

        ''Query a view I created in the database called CourseRoster and it only shows the course that is selected in the Main Form
        db.sql = "Select * From CourseRoster Where Course_ID = @Course_ID"
        db.bind("@Course_ID", MainForm.CoursesDataGridView.SelectedRows(0).Cells(0).Value)
        ''Inserting the information we just queried into the datagridview on the current form
        db.fill(CourseRosterDataGridView)



    End Sub
End Class