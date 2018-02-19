<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.StudentsDataGridView = New System.Windows.Forms.DataGridView()
        Me.MenuStrip2 = New System.Windows.Forms.MenuStrip()
        Me.MainMenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InsertRecordToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SearchRecordsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WelcomeLabel = New System.Windows.Forms.Label()
        Me.ClassesLabel = New System.Windows.Forms.Label()
        Me.InstructorsDataGridView = New System.Windows.Forms.DataGridView()
        Me.CoursesDataGridView = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.StudentSearchTextBox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.InstructorSearchTextBox = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.CourseSearchBox = New System.Windows.Forms.TextBox()
        Me.StudentClassesButton = New System.Windows.Forms.Button()
        Me.TeachersStudentButton = New System.Windows.Forms.Button()
        Me.CourseInfoButton = New System.Windows.Forms.Button()
        Me.EnrollButton = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.StudentNameTextbox = New System.Windows.Forms.TextBox()
        Me.StuIDTextBox = New System.Windows.Forms.TextBox()
        Me.StudentMajorTextbox = New System.Windows.Forms.TextBox()
        Me.StudentGradeTextbox = New System.Windows.Forms.TextBox()
        Me.StudentAgeTextbox = New System.Windows.Forms.TextBox()
        Me.InstructorIDTextBox = New System.Windows.Forms.TextBox()
        Me.InstructorFirstNameTextbox = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.CurrentlyEnrolledTextbox = New System.Windows.Forms.TextBox()
        Me.RoomNumberTextbox = New System.Windows.Forms.TextBox()
        Me.CourseTimeTextbox = New System.Windows.Forms.TextBox()
        Me.CourseIDTextbox = New System.Windows.Forms.TextBox()
        Me.CourseNameTextbox = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.InstrLastnameTextbox = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.EditStudentButton = New System.Windows.Forms.Button()
        Me.ConfirmStudentButton = New System.Windows.Forms.Button()
        Me.CancelStudentButton = New System.Windows.Forms.Button()
        Me.CancelInstructorButton = New System.Windows.Forms.Button()
        Me.ConfirmInstructorButton = New System.Windows.Forms.Button()
        Me.EditInstructorButton = New System.Windows.Forms.Button()
        Me.CancelCourseButton = New System.Windows.Forms.Button()
        Me.ConfirmCourseButton = New System.Windows.Forms.Button()
        Me.EditCourseButton = New System.Windows.Forms.Button()
        Me.AddStudentButton = New System.Windows.Forms.Button()
        Me.AddCourseButton = New System.Windows.Forms.Button()
        Me.AddInstructorButton = New System.Windows.Forms.Button()
        Me.UserInfoDataGridView = New System.Windows.Forms.DataGridView()
        CType(Me.StudentsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip2.SuspendLayout()
        CType(Me.InstructorsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CoursesDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UserInfoDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'StudentsDataGridView
        '
        Me.StudentsDataGridView.AllowUserToOrderColumns = True
        Me.StudentsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.StudentsDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.StudentsDataGridView.BackgroundColor = System.Drawing.SystemColors.Info
        Me.StudentsDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.StudentsDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        Me.StudentsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.StudentsDataGridView.Cursor = System.Windows.Forms.Cursors.Cross
        Me.StudentsDataGridView.Location = New System.Drawing.Point(12, 77)
        Me.StudentsDataGridView.Name = "StudentsDataGridView"
        Me.StudentsDataGridView.ReadOnly = True
        Me.StudentsDataGridView.Size = New System.Drawing.Size(333, 169)
        Me.StudentsDataGridView.TabIndex = 1
        '
        'MenuStrip2
        '
        Me.MenuStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MainMenuToolStripMenuItem})
        Me.MenuStrip2.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip2.Name = "MenuStrip2"
        Me.MenuStrip2.Size = New System.Drawing.Size(1165, 24)
        Me.MenuStrip2.TabIndex = 2
        Me.MenuStrip2.Text = "MenuStrip2"
        '
        'MainMenuToolStripMenuItem
        '
        Me.MainMenuToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InsertRecordToolStripMenuItem, Me.SearchRecordsToolStripMenuItem})
        Me.MainMenuToolStripMenuItem.Name = "MainMenuToolStripMenuItem"
        Me.MainMenuToolStripMenuItem.Size = New System.Drawing.Size(80, 20)
        Me.MainMenuToolStripMenuItem.Text = "Main Menu"
        '
        'InsertRecordToolStripMenuItem
        '
        Me.InsertRecordToolStripMenuItem.Name = "InsertRecordToolStripMenuItem"
        Me.InsertRecordToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
        Me.InsertRecordToolStripMenuItem.Text = "Manage Records"
        '
        'SearchRecordsToolStripMenuItem
        '
        Me.SearchRecordsToolStripMenuItem.Name = "SearchRecordsToolStripMenuItem"
        Me.SearchRecordsToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
        Me.SearchRecordsToolStripMenuItem.Text = "Search Records"
        '
        'WelcomeLabel
        '
        Me.WelcomeLabel.AutoSize = True
        Me.WelcomeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WelcomeLabel.Location = New System.Drawing.Point(384, 9)
        Me.WelcomeLabel.Name = "WelcomeLabel"
        Me.WelcomeLabel.Size = New System.Drawing.Size(299, 25)
        Me.WelcomeLabel.TabIndex = 3
        Me.WelcomeLabel.Text = "Welcome (DISPLAY NAME)"
        '
        'ClassesLabel
        '
        Me.ClassesLabel.AutoSize = True
        Me.ClassesLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ClassesLabel.Location = New System.Drawing.Point(12, 49)
        Me.ClassesLabel.Name = "ClassesLabel"
        Me.ClassesLabel.Size = New System.Drawing.Size(105, 25)
        Me.ClassesLabel.TabIndex = 4
        Me.ClassesLabel.Text = "Students"
        '
        'InstructorsDataGridView
        '
        Me.InstructorsDataGridView.AllowUserToOrderColumns = True
        Me.InstructorsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.InstructorsDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.InstructorsDataGridView.BackgroundColor = System.Drawing.SystemColors.Info
        Me.InstructorsDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.InstructorsDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        Me.InstructorsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.InstructorsDataGridView.Cursor = System.Windows.Forms.Cursors.Cross
        Me.InstructorsDataGridView.Location = New System.Drawing.Point(351, 77)
        Me.InstructorsDataGridView.Name = "InstructorsDataGridView"
        Me.InstructorsDataGridView.ReadOnly = True
        Me.InstructorsDataGridView.Size = New System.Drawing.Size(404, 169)
        Me.InstructorsDataGridView.TabIndex = 5
        '
        'CoursesDataGridView
        '
        Me.CoursesDataGridView.AllowUserToOrderColumns = True
        Me.CoursesDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.CoursesDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.CoursesDataGridView.BackgroundColor = System.Drawing.SystemColors.Info
        Me.CoursesDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.CoursesDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        Me.CoursesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.CoursesDataGridView.Cursor = System.Windows.Forms.Cursors.Cross
        Me.CoursesDataGridView.Location = New System.Drawing.Point(766, 77)
        Me.CoursesDataGridView.Name = "CoursesDataGridView"
        Me.CoursesDataGridView.ReadOnly = True
        Me.CoursesDataGridView.Size = New System.Drawing.Size(392, 169)
        Me.CoursesDataGridView.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(346, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(123, 25)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Instructors"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(761, 45)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(99, 25)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Courses"
        '
        'StudentSearchTextBox
        '
        Me.StudentSearchTextBox.Location = New System.Drawing.Point(245, 50)
        Me.StudentSearchTextBox.Name = "StudentSearchTextBox"
        Me.StudentSearchTextBox.Size = New System.Drawing.Size(100, 20)
        Me.StudentSearchTextBox.TabIndex = 9
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(185, 51)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 16)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Search:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(595, 48)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(54, 16)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Search:"
        '
        'InstructorSearchTextBox
        '
        Me.InstructorSearchTextBox.Location = New System.Drawing.Point(655, 48)
        Me.InstructorSearchTextBox.Name = "InstructorSearchTextBox"
        Me.InstructorSearchTextBox.Size = New System.Drawing.Size(100, 20)
        Me.InstructorSearchTextBox.TabIndex = 11
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(993, 48)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(54, 16)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Search:"
        '
        'CourseSearchBox
        '
        Me.CourseSearchBox.Location = New System.Drawing.Point(1053, 48)
        Me.CourseSearchBox.Name = "CourseSearchBox"
        Me.CourseSearchBox.Size = New System.Drawing.Size(100, 20)
        Me.CourseSearchBox.TabIndex = 13
        '
        'StudentClassesButton
        '
        Me.StudentClassesButton.Location = New System.Drawing.Point(12, 252)
        Me.StudentClassesButton.Name = "StudentClassesButton"
        Me.StudentClassesButton.Size = New System.Drawing.Size(143, 23)
        Me.StudentClassesButton.TabIndex = 18
        Me.StudentClassesButton.Text = "View Student's Classes"
        Me.StudentClassesButton.UseVisualStyleBackColor = True
        '
        'TeachersStudentButton
        '
        Me.TeachersStudentButton.Location = New System.Drawing.Point(351, 252)
        Me.TeachersStudentButton.Name = "TeachersStudentButton"
        Me.TeachersStudentButton.Size = New System.Drawing.Size(143, 23)
        Me.TeachersStudentButton.TabIndex = 19
        Me.TeachersStudentButton.Text = "View Teacher's Students"
        Me.TeachersStudentButton.UseVisualStyleBackColor = True
        '
        'CourseInfoButton
        '
        Me.CourseInfoButton.Location = New System.Drawing.Point(761, 252)
        Me.CourseInfoButton.Name = "CourseInfoButton"
        Me.CourseInfoButton.Size = New System.Drawing.Size(143, 23)
        Me.CourseInfoButton.TabIndex = 20
        Me.CourseInfoButton.Text = "View Course Information"
        Me.CourseInfoButton.UseVisualStyleBackColor = True
        '
        'EnrollButton
        '
        Me.EnrollButton.Location = New System.Drawing.Point(1010, 252)
        Me.EnrollButton.Name = "EnrollButton"
        Me.EnrollButton.Size = New System.Drawing.Size(143, 23)
        Me.EnrollButton.TabIndex = 21
        Me.EnrollButton.Text = "Enroll"
        Me.EnrollButton.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(72, 306)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(35, 13)
        Me.Label6.TabIndex = 22
        Me.Label6.Text = "Name"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(74, 364)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(33, 13)
        Me.Label7.TabIndex = 23
        Me.Label7.Text = "Major"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(71, 393)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(36, 13)
        Me.Label8.TabIndex = 24
        Me.Label8.Text = "Grade"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(81, 422)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(26, 13)
        Me.Label9.TabIndex = 25
        Me.Label9.Text = "Age"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(52, 335)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(61, 13)
        Me.Label10.TabIndex = 26
        Me.Label10.Text = "Student ID:"
        '
        'StudentNameTextbox
        '
        Me.StudentNameTextbox.Location = New System.Drawing.Point(113, 303)
        Me.StudentNameTextbox.Name = "StudentNameTextbox"
        Me.StudentNameTextbox.ReadOnly = True
        Me.StudentNameTextbox.Size = New System.Drawing.Size(100, 20)
        Me.StudentNameTextbox.TabIndex = 27
        '
        'StuIDTextBox
        '
        Me.StuIDTextBox.Location = New System.Drawing.Point(113, 332)
        Me.StuIDTextBox.Name = "StuIDTextBox"
        Me.StuIDTextBox.ReadOnly = True
        Me.StuIDTextBox.Size = New System.Drawing.Size(100, 20)
        Me.StuIDTextBox.TabIndex = 28
        '
        'StudentMajorTextbox
        '
        Me.StudentMajorTextbox.Location = New System.Drawing.Point(113, 361)
        Me.StudentMajorTextbox.Name = "StudentMajorTextbox"
        Me.StudentMajorTextbox.ReadOnly = True
        Me.StudentMajorTextbox.Size = New System.Drawing.Size(100, 20)
        Me.StudentMajorTextbox.TabIndex = 29
        '
        'StudentGradeTextbox
        '
        Me.StudentGradeTextbox.Location = New System.Drawing.Point(113, 390)
        Me.StudentGradeTextbox.Name = "StudentGradeTextbox"
        Me.StudentGradeTextbox.ReadOnly = True
        Me.StudentGradeTextbox.Size = New System.Drawing.Size(100, 20)
        Me.StudentGradeTextbox.TabIndex = 30
        '
        'StudentAgeTextbox
        '
        Me.StudentAgeTextbox.Location = New System.Drawing.Point(113, 419)
        Me.StudentAgeTextbox.Name = "StudentAgeTextbox"
        Me.StudentAgeTextbox.ReadOnly = True
        Me.StudentAgeTextbox.Size = New System.Drawing.Size(100, 20)
        Me.StudentAgeTextbox.TabIndex = 31
        '
        'InstructorIDTextBox
        '
        Me.InstructorIDTextBox.Location = New System.Drawing.Point(465, 361)
        Me.InstructorIDTextBox.Name = "InstructorIDTextBox"
        Me.InstructorIDTextBox.ReadOnly = True
        Me.InstructorIDTextBox.Size = New System.Drawing.Size(100, 20)
        Me.InstructorIDTextBox.TabIndex = 38
        '
        'InstructorFirstNameTextbox
        '
        Me.InstructorFirstNameTextbox.Location = New System.Drawing.Point(465, 303)
        Me.InstructorFirstNameTextbox.Name = "InstructorFirstNameTextbox"
        Me.InstructorFirstNameTextbox.ReadOnly = True
        Me.InstructorFirstNameTextbox.Size = New System.Drawing.Size(100, 20)
        Me.InstructorFirstNameTextbox.TabIndex = 37
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(391, 364)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(68, 13)
        Me.Label11.TabIndex = 36
        Me.Label11.Text = "Instructor ID:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(402, 306)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(57, 13)
        Me.Label15.TabIndex = 32
        Me.Label15.Text = "First Name"
        '
        'CurrentlyEnrolledTextbox
        '
        Me.CurrentlyEnrolledTextbox.Location = New System.Drawing.Point(912, 419)
        Me.CurrentlyEnrolledTextbox.Name = "CurrentlyEnrolledTextbox"
        Me.CurrentlyEnrolledTextbox.ReadOnly = True
        Me.CurrentlyEnrolledTextbox.Size = New System.Drawing.Size(100, 20)
        Me.CurrentlyEnrolledTextbox.TabIndex = 51
        '
        'RoomNumberTextbox
        '
        Me.RoomNumberTextbox.Location = New System.Drawing.Point(912, 390)
        Me.RoomNumberTextbox.Name = "RoomNumberTextbox"
        Me.RoomNumberTextbox.ReadOnly = True
        Me.RoomNumberTextbox.Size = New System.Drawing.Size(100, 20)
        Me.RoomNumberTextbox.TabIndex = 50
        '
        'CourseTimeTextbox
        '
        Me.CourseTimeTextbox.Location = New System.Drawing.Point(912, 361)
        Me.CourseTimeTextbox.Name = "CourseTimeTextbox"
        Me.CourseTimeTextbox.ReadOnly = True
        Me.CourseTimeTextbox.Size = New System.Drawing.Size(100, 20)
        Me.CourseTimeTextbox.TabIndex = 49
        '
        'CourseIDTextbox
        '
        Me.CourseIDTextbox.Location = New System.Drawing.Point(912, 332)
        Me.CourseIDTextbox.Name = "CourseIDTextbox"
        Me.CourseIDTextbox.ReadOnly = True
        Me.CourseIDTextbox.Size = New System.Drawing.Size(100, 20)
        Me.CourseIDTextbox.TabIndex = 48
        '
        'CourseNameTextbox
        '
        Me.CourseNameTextbox.Location = New System.Drawing.Point(912, 303)
        Me.CourseNameTextbox.Name = "CourseNameTextbox"
        Me.CourseNameTextbox.ReadOnly = True
        Me.CourseNameTextbox.Size = New System.Drawing.Size(100, 20)
        Me.CourseNameTextbox.TabIndex = 47
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(817, 422)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(89, 13)
        Me.Label17.TabIndex = 45
        Me.Label17.Text = "Currently Enrolled"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(831, 393)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(75, 13)
        Me.Label18.TabIndex = 44
        Me.Label18.Text = "Room Number"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(873, 364)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(30, 13)
        Me.Label19.TabIndex = 43
        Me.Label19.Text = "Time"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(835, 306)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(71, 13)
        Me.Label20.TabIndex = 42
        Me.Label20.Text = "Course Name"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(845, 335)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(57, 13)
        Me.Label16.TabIndex = 52
        Me.Label16.Text = "Course ID:"
        '
        'InstrLastnameTextbox
        '
        Me.InstrLastnameTextbox.Location = New System.Drawing.Point(465, 332)
        Me.InstrLastnameTextbox.Name = "InstrLastnameTextbox"
        Me.InstrLastnameTextbox.ReadOnly = True
        Me.InstrLastnameTextbox.Size = New System.Drawing.Size(100, 20)
        Me.InstrLastnameTextbox.TabIndex = 54
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(401, 335)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(58, 13)
        Me.Label14.TabIndex = 53
        Me.Label14.Text = "Last Name"
        '
        'EditStudentButton
        '
        Me.EditStudentButton.Location = New System.Drawing.Point(17, 445)
        Me.EditStudentButton.Name = "EditStudentButton"
        Me.EditStudentButton.Size = New System.Drawing.Size(212, 64)
        Me.EditStudentButton.TabIndex = 55
        Me.EditStudentButton.Text = "Edit"
        Me.EditStudentButton.UseVisualStyleBackColor = True
        '
        'ConfirmStudentButton
        '
        Me.ConfirmStudentButton.Location = New System.Drawing.Point(126, 485)
        Me.ConfirmStudentButton.Name = "ConfirmStudentButton"
        Me.ConfirmStudentButton.Size = New System.Drawing.Size(103, 64)
        Me.ConfirmStudentButton.TabIndex = 56
        Me.ConfirmStudentButton.Text = "Confirm"
        Me.ConfirmStudentButton.UseVisualStyleBackColor = True
        Me.ConfirmStudentButton.Visible = False
        '
        'CancelStudentButton
        '
        Me.CancelStudentButton.Location = New System.Drawing.Point(17, 485)
        Me.CancelStudentButton.Name = "CancelStudentButton"
        Me.CancelStudentButton.Size = New System.Drawing.Size(103, 64)
        Me.CancelStudentButton.TabIndex = 57
        Me.CancelStudentButton.Text = "Cancel"
        Me.CancelStudentButton.UseVisualStyleBackColor = True
        Me.CancelStudentButton.Visible = False
        '
        'CancelInstructorButton
        '
        Me.CancelInstructorButton.Location = New System.Drawing.Point(394, 485)
        Me.CancelInstructorButton.Name = "CancelInstructorButton"
        Me.CancelInstructorButton.Size = New System.Drawing.Size(103, 64)
        Me.CancelInstructorButton.TabIndex = 60
        Me.CancelInstructorButton.Text = "Cancel"
        Me.CancelInstructorButton.UseVisualStyleBackColor = True
        Me.CancelInstructorButton.Visible = False
        '
        'ConfirmInstructorButton
        '
        Me.ConfirmInstructorButton.Location = New System.Drawing.Point(503, 485)
        Me.ConfirmInstructorButton.Name = "ConfirmInstructorButton"
        Me.ConfirmInstructorButton.Size = New System.Drawing.Size(103, 64)
        Me.ConfirmInstructorButton.TabIndex = 59
        Me.ConfirmInstructorButton.Text = "Confirm"
        Me.ConfirmInstructorButton.UseVisualStyleBackColor = True
        Me.ConfirmInstructorButton.Visible = False
        '
        'EditInstructorButton
        '
        Me.EditInstructorButton.Location = New System.Drawing.Point(394, 445)
        Me.EditInstructorButton.Name = "EditInstructorButton"
        Me.EditInstructorButton.Size = New System.Drawing.Size(212, 64)
        Me.EditInstructorButton.TabIndex = 58
        Me.EditInstructorButton.Text = "Edit"
        Me.EditInstructorButton.UseVisualStyleBackColor = True
        '
        'CancelCourseButton
        '
        Me.CancelCourseButton.Location = New System.Drawing.Point(820, 485)
        Me.CancelCourseButton.Name = "CancelCourseButton"
        Me.CancelCourseButton.Size = New System.Drawing.Size(103, 64)
        Me.CancelCourseButton.TabIndex = 63
        Me.CancelCourseButton.Text = "Cancel"
        Me.CancelCourseButton.UseVisualStyleBackColor = True
        Me.CancelCourseButton.Visible = False
        '
        'ConfirmCourseButton
        '
        Me.ConfirmCourseButton.Location = New System.Drawing.Point(929, 485)
        Me.ConfirmCourseButton.Name = "ConfirmCourseButton"
        Me.ConfirmCourseButton.Size = New System.Drawing.Size(103, 64)
        Me.ConfirmCourseButton.TabIndex = 62
        Me.ConfirmCourseButton.Text = "Confirm"
        Me.ConfirmCourseButton.UseVisualStyleBackColor = True
        Me.ConfirmCourseButton.Visible = False
        '
        'EditCourseButton
        '
        Me.EditCourseButton.Location = New System.Drawing.Point(820, 445)
        Me.EditCourseButton.Name = "EditCourseButton"
        Me.EditCourseButton.Size = New System.Drawing.Size(212, 64)
        Me.EditCourseButton.TabIndex = 61
        Me.EditCourseButton.Text = "Edit"
        Me.EditCourseButton.UseVisualStyleBackColor = True
        '
        'AddStudentButton
        '
        Me.AddStudentButton.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.AddStudentButton.BackgroundImage = Global.EnrollmentApplication.My.Resources.Resources.AddButton_med
        Me.AddStudentButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.AddStudentButton.Location = New System.Drawing.Point(113, 36)
        Me.AddStudentButton.Name = "AddStudentButton"
        Me.AddStudentButton.Size = New System.Drawing.Size(42, 38)
        Me.AddStudentButton.TabIndex = 17
        Me.AddStudentButton.UseVisualStyleBackColor = False
        '
        'AddCourseButton
        '
        Me.AddCourseButton.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.AddCourseButton.BackgroundImage = Global.EnrollmentApplication.My.Resources.Resources.AddButton_med
        Me.AddCourseButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.AddCourseButton.Location = New System.Drawing.Point(855, 38)
        Me.AddCourseButton.Name = "AddCourseButton"
        Me.AddCourseButton.Size = New System.Drawing.Size(42, 38)
        Me.AddCourseButton.TabIndex = 16
        Me.AddCourseButton.UseVisualStyleBackColor = False
        '
        'AddInstructorButton
        '
        Me.AddInstructorButton.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.AddInstructorButton.BackgroundImage = Global.EnrollmentApplication.My.Resources.Resources.AddButton_med
        Me.AddInstructorButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.AddInstructorButton.Location = New System.Drawing.Point(465, 38)
        Me.AddInstructorButton.Name = "AddInstructorButton"
        Me.AddInstructorButton.Size = New System.Drawing.Size(42, 38)
        Me.AddInstructorButton.TabIndex = 15
        Me.AddInstructorButton.UseVisualStyleBackColor = False
        '
        'UserInfoDataGridView
        '
        Me.UserInfoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.UserInfoDataGridView.Location = New System.Drawing.Point(571, 289)
        Me.UserInfoDataGridView.Name = "UserInfoDataGridView"
        Me.UserInfoDataGridView.Size = New System.Drawing.Size(240, 150)
        Me.UserInfoDataGridView.TabIndex = 64
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1165, 570)
        Me.Controls.Add(Me.UserInfoDataGridView)
        Me.Controls.Add(Me.CancelCourseButton)
        Me.Controls.Add(Me.ConfirmCourseButton)
        Me.Controls.Add(Me.EditCourseButton)
        Me.Controls.Add(Me.CancelInstructorButton)
        Me.Controls.Add(Me.ConfirmInstructorButton)
        Me.Controls.Add(Me.EditInstructorButton)
        Me.Controls.Add(Me.CancelStudentButton)
        Me.Controls.Add(Me.ConfirmStudentButton)
        Me.Controls.Add(Me.EditStudentButton)
        Me.Controls.Add(Me.InstrLastnameTextbox)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.CurrentlyEnrolledTextbox)
        Me.Controls.Add(Me.RoomNumberTextbox)
        Me.Controls.Add(Me.CourseTimeTextbox)
        Me.Controls.Add(Me.CourseIDTextbox)
        Me.Controls.Add(Me.CourseNameTextbox)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.InstructorIDTextBox)
        Me.Controls.Add(Me.InstructorFirstNameTextbox)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.StudentAgeTextbox)
        Me.Controls.Add(Me.StudentGradeTextbox)
        Me.Controls.Add(Me.StudentMajorTextbox)
        Me.Controls.Add(Me.StuIDTextBox)
        Me.Controls.Add(Me.StudentNameTextbox)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.EnrollButton)
        Me.Controls.Add(Me.CourseInfoButton)
        Me.Controls.Add(Me.TeachersStudentButton)
        Me.Controls.Add(Me.StudentClassesButton)
        Me.Controls.Add(Me.AddStudentButton)
        Me.Controls.Add(Me.AddCourseButton)
        Me.Controls.Add(Me.AddInstructorButton)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.CourseSearchBox)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.InstructorSearchTextBox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.StudentSearchTextBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CoursesDataGridView)
        Me.Controls.Add(Me.InstructorsDataGridView)
        Me.Controls.Add(Me.ClassesLabel)
        Me.Controls.Add(Me.WelcomeLabel)
        Me.Controls.Add(Me.StudentsDataGridView)
        Me.Controls.Add(Me.MenuStrip2)
        Me.Name = "MainForm"
        Me.Text = "Main Menu"
        CType(Me.StudentsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip2.ResumeLayout(False)
        Me.MenuStrip2.PerformLayout()
        CType(Me.InstructorsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CoursesDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UserInfoDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents StudentsDataGridView As DataGridView
    Friend WithEvents MenuStrip2 As MenuStrip
    Friend WithEvents MainMenuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InsertRecordToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SearchRecordsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents WelcomeLabel As Label
    Friend WithEvents ClassesLabel As Label
    Friend WithEvents InstructorsDataGridView As DataGridView
    Friend WithEvents CoursesDataGridView As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents StudentSearchTextBox As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents InstructorSearchTextBox As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents CourseSearchBox As TextBox
    Friend WithEvents AddInstructorButton As Button
    Friend WithEvents AddCourseButton As Button
    Friend WithEvents AddStudentButton As Button
    Friend WithEvents StudentClassesButton As Button
    Friend WithEvents TeachersStudentButton As Button
    Friend WithEvents CourseInfoButton As Button
    Friend WithEvents EnrollButton As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents StudentNameTextbox As TextBox
    Friend WithEvents StuIDTextBox As TextBox
    Friend WithEvents StudentMajorTextbox As TextBox
    Friend WithEvents StudentGradeTextbox As TextBox
    Friend WithEvents StudentAgeTextbox As TextBox
    Friend WithEvents InstructorIDTextBox As TextBox
    Friend WithEvents InstructorFirstNameTextbox As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents CurrentlyEnrolledTextbox As TextBox
    Friend WithEvents RoomNumberTextbox As TextBox
    Friend WithEvents CourseTimeTextbox As TextBox
    Friend WithEvents CourseIDTextbox As TextBox
    Friend WithEvents CourseNameTextbox As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents InstrLastnameTextbox As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents EditStudentButton As Button
    Friend WithEvents ConfirmStudentButton As Button
    Friend WithEvents CancelStudentButton As Button
    Friend WithEvents CancelInstructorButton As Button
    Friend WithEvents ConfirmInstructorButton As Button
    Friend WithEvents EditInstructorButton As Button
    Friend WithEvents CancelCourseButton As Button
    Friend WithEvents ConfirmCourseButton As Button
    Friend WithEvents EditCourseButton As Button
    Friend WithEvents UserInfoDataGridView As DataGridView
End Class
