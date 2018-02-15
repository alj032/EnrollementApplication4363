<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddCourseForm
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
        Me.AddCourseTimetextbox = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.AddCourseButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.NameLabel = New System.Windows.Forms.Label()
        Me.AddCourseTextBox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.AddCourseRoomtextbox = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'AddCourseTimetextbox
        '
        Me.AddCourseTimetextbox.Location = New System.Drawing.Point(60, 92)
        Me.AddCourseTimetextbox.Name = "AddCourseTimetextbox"
        Me.AddCourseTimetextbox.Size = New System.Drawing.Size(121, 20)
        Me.AddCourseTimetextbox.TabIndex = 30
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(60, 205)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(121, 39)
        Me.Button2.TabIndex = 29
        Me.Button2.Text = "Cancel"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'AddCourseButton
        '
        Me.AddCourseButton.Location = New System.Drawing.Point(60, 163)
        Me.AddCourseButton.Name = "AddCourseButton"
        Me.AddCourseButton.Size = New System.Drawing.Size(121, 36)
        Me.AddCourseButton.TabIndex = 28
        Me.AddCourseButton.Text = "Add"
        Me.AddCourseButton.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(105, 73)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(30, 13)
        Me.Label1.TabIndex = 27
        Me.Label1.Text = "Time"
        '
        'NameLabel
        '
        Me.NameLabel.AutoSize = True
        Me.NameLabel.Location = New System.Drawing.Point(85, 28)
        Me.NameLabel.Name = "NameLabel"
        Me.NameLabel.Size = New System.Drawing.Size(71, 13)
        Me.NameLabel.TabIndex = 26
        Me.NameLabel.Text = "Course Name"
        '
        'AddCourseTextBox
        '
        Me.AddCourseTextBox.Location = New System.Drawing.Point(60, 47)
        Me.AddCourseTextBox.Name = "AddCourseTextBox"
        Me.AddCourseTextBox.Size = New System.Drawing.Size(121, 20)
        Me.AddCourseTextBox.TabIndex = 25
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(83, 118)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 13)
        Me.Label3.TabIndex = 32
        Me.Label3.Text = "Room Number"
        '
        'AddCourseRoomtextbox
        '
        Me.AddCourseRoomtextbox.Location = New System.Drawing.Point(60, 137)
        Me.AddCourseRoomtextbox.Name = "AddCourseRoomtextbox"
        Me.AddCourseRoomtextbox.Size = New System.Drawing.Size(121, 20)
        Me.AddCourseRoomtextbox.TabIndex = 31
        '
        'AddCourseForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(253, 292)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.AddCourseRoomtextbox)
        Me.Controls.Add(Me.AddCourseTimetextbox)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.AddCourseButton)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.NameLabel)
        Me.Controls.Add(Me.AddCourseTextBox)
        Me.Name = "AddCourseForm"
        Me.Text = "Add a Course"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents AddCourseTimetextbox As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents AddCourseButton As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents NameLabel As Label
    Friend WithEvents AddCourseTextBox As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents AddCourseRoomtextbox As TextBox
End Class
