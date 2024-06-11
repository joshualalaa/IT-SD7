<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        GridView = New DataGridView()
        Column1 = New DataGridViewTextBoxColumn()
        Column2 = New DataGridViewTextBoxColumn()
        Column3 = New DataGridViewTextBoxColumn()
        Column4 = New DataGridViewTextBoxColumn()
        LabelNIK = New Label()
        LabelName = New Label()
        LabelDepartment = New Label()
        LabelJobClass = New Label()
        TextBoxNIK = New TextBox()
        TextBoxName = New TextBox()
        TextBoxDepartment = New TextBox()
        ButtonSubmit = New Button()
        ButtonDelete = New Button()
        ButtonEmpty = New Button()
        ComboBoxJobClass = New ComboBox()
        CType(GridView, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' GridView
        ' 
        GridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        GridView.Columns.AddRange(New DataGridViewColumn() {Column1, Column2, Column3, Column4})
        GridView.Location = New Point(12, 319)
        GridView.Name = "GridView"
        GridView.RowHeadersWidth = 51
        GridView.Size = New Size(553, 231)
        GridView.TabIndex = 0
        ' 
        ' Column1
        ' 
        Column1.HeaderText = "NIK"
        Column1.MinimumWidth = 6
        Column1.Name = "Column1"
        Column1.Width = 125
        ' 
        ' Column2
        ' 
        Column2.HeaderText = "Name"
        Column2.MinimumWidth = 6
        Column2.Name = "Column2"
        Column2.Width = 125
        ' 
        ' Column3
        ' 
        Column3.HeaderText = "Department"
        Column3.MinimumWidth = 6
        Column3.Name = "Column3"
        Column3.Width = 125
        ' 
        ' Column4
        ' 
        Column4.HeaderText = "Job Class"
        Column4.MinimumWidth = 6
        Column4.Name = "Column4"
        Column4.Width = 125
        ' 
        ' LabelNIK
        ' 
        LabelNIK.AutoSize = True
        LabelNIK.Location = New Point(12, 29)
        LabelNIK.Name = "LabelNIK"
        LabelNIK.Size = New Size(33, 20)
        LabelNIK.TabIndex = 1
        LabelNIK.Text = "NIK"
        ' 
        ' LabelName
        ' 
        LabelName.AutoSize = True
        LabelName.Location = New Point(12, 77)
        LabelName.Name = "LabelName"
        LabelName.Size = New Size(49, 20)
        LabelName.TabIndex = 2
        LabelName.Text = "Name"
        ' 
        ' LabelDepartment
        ' 
        LabelDepartment.AutoSize = True
        LabelDepartment.Location = New Point(12, 123)
        LabelDepartment.Name = "LabelDepartment"
        LabelDepartment.Size = New Size(89, 20)
        LabelDepartment.TabIndex = 3
        LabelDepartment.Text = "Department"
        ' 
        ' LabelJobClass
        ' 
        LabelJobClass.AutoSize = True
        LabelJobClass.Location = New Point(12, 169)
        LabelJobClass.Name = "LabelJobClass"
        LabelJobClass.Size = New Size(69, 20)
        LabelJobClass.TabIndex = 4
        LabelJobClass.Text = "Job Class"
        ' 
        ' TextBoxNIK
        ' 
        TextBoxNIK.Location = New Point(131, 26)
        TextBoxNIK.Name = "TextBoxNIK"
        TextBoxNIK.Size = New Size(125, 27)
        TextBoxNIK.TabIndex = 5
        ' 
        ' TextBoxName
        ' 
        TextBoxName.Location = New Point(131, 74)
        TextBoxName.Name = "TextBoxName"
        TextBoxName.Size = New Size(125, 27)
        TextBoxName.TabIndex = 6
        ' 
        ' TextBoxDepartment
        ' 
        TextBoxDepartment.Location = New Point(131, 120)
        TextBoxDepartment.Name = "TextBoxDepartment"
        TextBoxDepartment.Size = New Size(125, 27)
        TextBoxDepartment.TabIndex = 7
        ' 
        ' ButtonSubmit
        ' 
        ButtonSubmit.Location = New Point(131, 218)
        ButtonSubmit.Name = "ButtonSubmit"
        ButtonSubmit.Size = New Size(94, 29)
        ButtonSubmit.TabIndex = 9
        ButtonSubmit.Text = "Submit"
        ButtonSubmit.UseVisualStyleBackColor = True
        ' 
        ' ButtonDelete
        ' 
        ButtonDelete.Location = New Point(247, 218)
        ButtonDelete.Name = "ButtonDelete"
        ButtonDelete.Size = New Size(94, 29)
        ButtonDelete.TabIndex = 10
        ButtonDelete.Text = "Delete"
        ButtonDelete.UseVisualStyleBackColor = True
        ' 
        ' ButtonEmpty
        ' 
        ButtonEmpty.Location = New Point(356, 218)
        ButtonEmpty.Name = "ButtonEmpty"
        ButtonEmpty.Size = New Size(94, 29)
        ButtonEmpty.TabIndex = 11
        ButtonEmpty.Text = "Empty"
        ButtonEmpty.UseVisualStyleBackColor = True
        ' 
        ' ComboBoxJobClass
        ' 
        ComboBoxJobClass.FormattingEnabled = True
        ComboBoxJobClass.Items.AddRange(New Object() {"A1", "A2", "A3", "B1", "B2", "B3"})
        ComboBoxJobClass.Location = New Point(131, 166)
        ComboBoxJobClass.Name = "ComboBoxJobClass"
        ComboBoxJobClass.Size = New Size(125, 28)
        ComboBoxJobClass.TabIndex = 8
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(569, 562)
        Controls.Add(ComboBoxJobClass)
        Controls.Add(ButtonEmpty)
        Controls.Add(ButtonDelete)
        Controls.Add(ButtonSubmit)
        Controls.Add(TextBoxDepartment)
        Controls.Add(TextBoxName)
        Controls.Add(TextBoxNIK)
        Controls.Add(LabelJobClass)
        Controls.Add(LabelDepartment)
        Controls.Add(LabelName)
        Controls.Add(LabelNIK)
        Controls.Add(GridView)
        Name = "Form1"
        Text = "Form1"
        CType(GridView, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents GridView As DataGridView
    Friend WithEvents LabelNIK As Label
    Friend WithEvents LabelName As Label
    Friend WithEvents LabelDepartment As Label
    Friend WithEvents LabelJobClass As Label
    Friend WithEvents TextBoxNIK As TextBox
    Friend WithEvents TextBoxName As TextBox
    Friend WithEvents TextBoxDepartment As TextBox
    Friend WithEvents ButtonSubmit As Button
    Friend WithEvents ButtonDelete As Button
    Friend WithEvents ButtonEmpty As Button
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents ComboBoxJobClass As ComboBox

End Class
