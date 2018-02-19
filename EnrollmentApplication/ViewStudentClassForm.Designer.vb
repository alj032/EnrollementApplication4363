<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ViewStudentClassForm
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
        Me.StudentCurrentClassesDataGridView = New System.Windows.Forms.DataGridView()
        Me.GoBackButton = New System.Windows.Forms.Button()
        CType(Me.StudentCurrentClassesDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'StudentCurrentClassesDataGridView
        '
        Me.StudentCurrentClassesDataGridView.AllowUserToOrderColumns = True
        Me.StudentCurrentClassesDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.StudentCurrentClassesDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.StudentCurrentClassesDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.StudentCurrentClassesDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        Me.StudentCurrentClassesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.StudentCurrentClassesDataGridView.Cursor = System.Windows.Forms.Cursors.Cross
        Me.StudentCurrentClassesDataGridView.Location = New System.Drawing.Point(12, 12)
        Me.StudentCurrentClassesDataGridView.Name = "StudentCurrentClassesDataGridView"
        Me.StudentCurrentClassesDataGridView.ReadOnly = True
        Me.StudentCurrentClassesDataGridView.Size = New System.Drawing.Size(677, 334)
        Me.StudentCurrentClassesDataGridView.TabIndex = 0
        '
        'GoBackButton
        '
        Me.GoBackButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GoBackButton.Location = New System.Drawing.Point(12, 352)
        Me.GoBackButton.Name = "GoBackButton"
        Me.GoBackButton.Size = New System.Drawing.Size(677, 105)
        Me.GoBackButton.TabIndex = 1
        Me.GoBackButton.Text = "Go Back"
        Me.GoBackButton.UseVisualStyleBackColor = True
        '
        'ViewStudentClassForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(701, 469)
        Me.Controls.Add(Me.GoBackButton)
        Me.Controls.Add(Me.StudentCurrentClassesDataGridView)
        Me.Name = "ViewStudentClassForm"
        Me.Text = "Student's Classes"
        CType(Me.StudentCurrentClassesDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents StudentCurrentClassesDataGridView As DataGridView
    Friend WithEvents GoBackButton As Button
End Class
