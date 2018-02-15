<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddStudentForm
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
        Me.AddStudentFirstNameTextbox = New System.Windows.Forms.TextBox()
        Me.StudentAgeTextbox = New System.Windows.Forms.TextBox()
        Me.NameLabel = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.MajorComboBox = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GradeComboBox = New System.Windows.Forms.ComboBox()
        Me.AddStudentButton = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'AddStudentFirstNameTextbox
        '
        Me.AddStudentFirstNameTextbox.Location = New System.Drawing.Point(38, 57)
        Me.AddStudentFirstNameTextbox.Name = "AddStudentFirstNameTextbox"
        Me.AddStudentFirstNameTextbox.Size = New System.Drawing.Size(121, 20)
        Me.AddStudentFirstNameTextbox.TabIndex = 0
        '
        'StudentAgeTextbox
        '
        Me.StudentAgeTextbox.Location = New System.Drawing.Point(38, 194)
        Me.StudentAgeTextbox.Name = "StudentAgeTextbox"
        Me.StudentAgeTextbox.Size = New System.Drawing.Size(121, 20)
        Me.StudentAgeTextbox.TabIndex = 3
        '
        'NameLabel
        '
        Me.NameLabel.AutoSize = True
        Me.NameLabel.Location = New System.Drawing.Point(50, 38)
        Me.NameLabel.Name = "NameLabel"
        Me.NameLabel.Size = New System.Drawing.Size(97, 13)
        Me.NameLabel.TabIndex = 4
        Me.NameLabel.Text = "Student First Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(85, 175)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(26, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Age"
        '
        'MajorComboBox
        '
        Me.MajorComboBox.FormattingEnabled = True
        Me.MajorComboBox.Items.AddRange(New Object() {"ISYS", "ACCT", "MGMT", "SCMT", "HIST"})
        Me.MajorComboBox.Location = New System.Drawing.Point(38, 102)
        Me.MajorComboBox.Name = "MajorComboBox"
        Me.MajorComboBox.Size = New System.Drawing.Size(121, 21)
        Me.MajorComboBox.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(82, 83)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(33, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Major"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(80, 129)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(36, 13)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Grade"
        '
        'GradeComboBox
        '
        Me.GradeComboBox.FormattingEnabled = True
        Me.GradeComboBox.Items.AddRange(New Object() {"FRSH", "SOPH", "JUNR", "SENR"})
        Me.GradeComboBox.Location = New System.Drawing.Point(38, 148)
        Me.GradeComboBox.Name = "GradeComboBox"
        Me.GradeComboBox.Size = New System.Drawing.Size(121, 21)
        Me.GradeComboBox.TabIndex = 10
        '
        'AddStudentButton
        '
        Me.AddStudentButton.Location = New System.Drawing.Point(38, 232)
        Me.AddStudentButton.Name = "AddStudentButton"
        Me.AddStudentButton.Size = New System.Drawing.Size(121, 36)
        Me.AddStudentButton.TabIndex = 12
        Me.AddStudentButton.Text = "Add"
        Me.AddStudentButton.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(38, 274)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(121, 39)
        Me.Button2.TabIndex = 13
        Me.Button2.Text = "Cancel"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'AddStudentForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(207, 345)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.AddStudentButton)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.GradeComboBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MajorComboBox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.NameLabel)
        Me.Controls.Add(Me.StudentAgeTextbox)
        Me.Controls.Add(Me.AddStudentFirstNameTextbox)
        Me.Name = "AddStudentForm"
        Me.Text = "Add a Student"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents AddStudentFirstNameTextbox As TextBox
    Friend WithEvents StudentAgeTextbox As TextBox
    Friend WithEvents NameLabel As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents MajorComboBox As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents GradeComboBox As ComboBox
    Friend WithEvents AddStudentButton As Button
    Friend WithEvents Button2 As Button
End Class
