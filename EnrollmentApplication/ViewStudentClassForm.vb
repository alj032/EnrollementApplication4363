Public Class ViewStudentClassForm
    ''Calling the db class
    Protected db As New db




    ''When the form loads up we want to see what classes the student is currently enrolled in
    Private Sub ViewStudentClassForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ''Setting datagrid to select entire rows of data
        StudentCurrentClassesDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect

        ''Querying a view created in the database called CurrentStudentClasses this shows us all the classes that the selected student is enrolled in
        db.sql = "Select * from CurrentStudentClasses Where Student_ID = @Student_ID"
        db.bind("@Student_ID", MainForm.StudentsDataGridView.SelectedRows(0).Cells(0).Value)
        ''Filling the datagrid view on the current form with the information we just queried 
        db.fill(StudentCurrentClassesDataGridView)

    End Sub

    ''When the user clicks go back we want to return them to the main form
    Private Sub GoBackButton_Click(sender As Object, e As EventArgs) Handles GoBackButton.Click
        MainForm.Show()
        Me.Close()


    End Sub
End Class