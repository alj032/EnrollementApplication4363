Public Class ViewTeachersStudentsForm
    ''Calling the db class
    Protected db As New db

    Private Sub ViewTeachersStudentsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ''Setting datagrid to select entire rows of data
        TeachersStudentsDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect

        ''I will need to create a view 
        db.sql = "Select * From TeachersStudents Where [Instructor ID] = @Instructor_ID"
        db.bind("@Instructor_ID", MainForm.InstructorsDataGridView.SelectedRows(0).Cells(0).Value)
        db.fill(TeachersStudentsDataGridView)
    End Sub
End Class