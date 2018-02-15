<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LoginForm
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.IDTextbox = New System.Windows.Forms.TextBox()
        Me.PasswordTextbox = New System.Windows.Forms.TextBox()
        Me.LoginButton = New System.Windows.Forms.Button()
        Me.Skip = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(85, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(103, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Student/Teacher ID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(109, 77)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Password"
        '
        'IDTextbox
        '
        Me.IDTextbox.Location = New System.Drawing.Point(88, 54)
        Me.IDTextbox.Name = "IDTextbox"
        Me.IDTextbox.Size = New System.Drawing.Size(100, 20)
        Me.IDTextbox.TabIndex = 2
        '
        'PasswordTextbox
        '
        Me.PasswordTextbox.Location = New System.Drawing.Point(88, 93)
        Me.PasswordTextbox.Name = "PasswordTextbox"
        Me.PasswordTextbox.Size = New System.Drawing.Size(100, 20)
        Me.PasswordTextbox.TabIndex = 3
        '
        'LoginButton
        '
        Me.LoginButton.Location = New System.Drawing.Point(66, 156)
        Me.LoginButton.Name = "LoginButton"
        Me.LoginButton.Size = New System.Drawing.Size(141, 51)
        Me.LoginButton.TabIndex = 4
        Me.LoginButton.Text = "Login"
        Me.LoginButton.UseVisualStyleBackColor = True
        '
        'Skip
        '
        Me.Skip.Location = New System.Drawing.Point(101, 119)
        Me.Skip.Name = "Skip"
        Me.Skip.Size = New System.Drawing.Size(75, 23)
        Me.Skip.TabIndex = 5
        Me.Skip.Text = "Skip"
        Me.Skip.UseVisualStyleBackColor = True
        '
        'LoginForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 219)
        Me.Controls.Add(Me.Skip)
        Me.Controls.Add(Me.LoginButton)
        Me.Controls.Add(Me.PasswordTextbox)
        Me.Controls.Add(Me.IDTextbox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "LoginForm"
        Me.Text = "Login"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents IDTextbox As TextBox
    Friend WithEvents PasswordTextbox As TextBox
    Friend WithEvents LoginButton As Button
    Friend WithEvents Skip As Button
End Class
