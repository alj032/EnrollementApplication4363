<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddInstructorForm
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
        Me.Button2 = New System.Windows.Forms.Button()
        Me.AddInstructorButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.NameLabel = New System.Windows.Forms.Label()
        Me.AddInstructorFirstNameTextbox = New System.Windows.Forms.TextBox()
        Me.Addinstructorlastnametextbox = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(68, 137)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(121, 39)
        Me.Button2.TabIndex = 23
        Me.Button2.Text = "Cancel"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'AddInstructorButton
        '
        Me.AddInstructorButton.Location = New System.Drawing.Point(68, 96)
        Me.AddInstructorButton.Name = "AddInstructorButton"
        Me.AddInstructorButton.Size = New System.Drawing.Size(121, 36)
        Me.AddInstructorButton.TabIndex = 22
        Me.AddInstructorButton.Text = "Add"
        Me.AddInstructorButton.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(98, 52)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 13)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "Last Name"
        '
        'NameLabel
        '
        Me.NameLabel.AutoSize = True
        Me.NameLabel.Location = New System.Drawing.Point(99, 9)
        Me.NameLabel.Name = "NameLabel"
        Me.NameLabel.Size = New System.Drawing.Size(57, 13)
        Me.NameLabel.TabIndex = 16
        Me.NameLabel.Text = "First Name"
        '
        'AddInstructorFirstNameTextbox
        '
        Me.AddInstructorFirstNameTextbox.Location = New System.Drawing.Point(68, 27)
        Me.AddInstructorFirstNameTextbox.Name = "AddInstructorFirstNameTextbox"
        Me.AddInstructorFirstNameTextbox.Size = New System.Drawing.Size(121, 20)
        Me.AddInstructorFirstNameTextbox.TabIndex = 14
        '
        'Addinstructorlastnametextbox
        '
        Me.Addinstructorlastnametextbox.Location = New System.Drawing.Point(68, 68)
        Me.Addinstructorlastnametextbox.Name = "Addinstructorlastnametextbox"
        Me.Addinstructorlastnametextbox.Size = New System.Drawing.Size(121, 20)
        Me.Addinstructorlastnametextbox.TabIndex = 24
        '
        'AddInstructorForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(257, 202)
        Me.Controls.Add(Me.Addinstructorlastnametextbox)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.AddInstructorButton)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.NameLabel)
        Me.Controls.Add(Me.AddInstructorFirstNameTextbox)
        Me.Name = "AddInstructorForm"
        Me.Text = "Add an Instructor"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button2 As Button
    Friend WithEvents AddInstructorButton As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents NameLabel As Label
    Friend WithEvents AddInstructorFirstNameTextbox As TextBox
    Friend WithEvents Addinstructorlastnametextbox As TextBox
End Class
