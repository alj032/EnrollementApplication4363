<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ViewTeachersStudentsForm
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
        Me.GoBackButton = New System.Windows.Forms.Button()
        Me.TeachersStudentsDataGridView = New System.Windows.Forms.DataGridView()
        CType(Me.TeachersStudentsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GoBackButton
        '
        Me.GoBackButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GoBackButton.Location = New System.Drawing.Point(12, 377)
        Me.GoBackButton.Name = "GoBackButton"
        Me.GoBackButton.Size = New System.Drawing.Size(677, 105)
        Me.GoBackButton.TabIndex = 2
        Me.GoBackButton.Text = "Go Back"
        Me.GoBackButton.UseVisualStyleBackColor = True
        '
        'TeachersStudentsDataGridView
        '
        Me.TeachersStudentsDataGridView.AllowUserToOrderColumns = True
        Me.TeachersStudentsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.TeachersStudentsDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.TeachersStudentsDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TeachersStudentsDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        Me.TeachersStudentsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TeachersStudentsDataGridView.Cursor = System.Windows.Forms.Cursors.Cross
        Me.TeachersStudentsDataGridView.Location = New System.Drawing.Point(10, 12)
        Me.TeachersStudentsDataGridView.Name = "TeachersStudentsDataGridView"
        Me.TeachersStudentsDataGridView.ReadOnly = True
        Me.TeachersStudentsDataGridView.Size = New System.Drawing.Size(677, 334)
        Me.TeachersStudentsDataGridView.TabIndex = 3
        '
        'ViewTeachersStudentsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(699, 498)
        Me.Controls.Add(Me.TeachersStudentsDataGridView)
        Me.Controls.Add(Me.GoBackButton)
        Me.Name = "ViewTeachersStudentsForm"
        Me.Text = "Current Students"
        CType(Me.TeachersStudentsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GoBackButton As Button
    Friend WithEvents TeachersStudentsDataGridView As DataGridView
End Class
