<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.CheckBox5 = New System.Windows.Forms.CheckBox
        Me.CheckBox4 = New System.Windows.Forms.CheckBox
        Me.CheckBox3 = New System.Windows.Forms.CheckBox
        Me.CheckBox2 = New System.Windows.Forms.CheckBox
        Me.CheckBox1 = New System.Windows.Forms.CheckBox
        Me.btn_save = New System.Windows.Forms.Button
        Me.lb_subName = New System.Windows.Forms.Label
        Me.txt_studId = New System.Windows.Forms.TextBox
        Me.txt_studName = New System.Windows.Forms.TextBox
        Me.lb_studId = New System.Windows.Forms.Label
        Me.lb_studName = New System.Windows.Forms.Label
        Me.lst_studInfo = New System.Windows.Forms.ListBox
        Me.btn_edit = New System.Windows.Forms.Button
        Me.btn_delete = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.CheckBox5)
        Me.GroupBox1.Controls.Add(Me.CheckBox4)
        Me.GroupBox1.Controls.Add(Me.CheckBox3)
        Me.GroupBox1.Controls.Add(Me.CheckBox2)
        Me.GroupBox1.Controls.Add(Me.CheckBox1)
        Me.GroupBox1.Controls.Add(Me.btn_save)
        Me.GroupBox1.Controls.Add(Me.lb_subName)
        Me.GroupBox1.Controls.Add(Me.txt_studId)
        Me.GroupBox1.Controls.Add(Me.txt_studName)
        Me.GroupBox1.Controls.Add(Me.lb_studId)
        Me.GroupBox1.Controls.Add(Me.lb_studName)
        Me.GroupBox1.Location = New System.Drawing.Point(59, 49)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(293, 244)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Student Information"
        '
        'CheckBox5
        '
        Me.CheckBox5.AutoSize = True
        Me.CheckBox5.Location = New System.Drawing.Point(189, 177)
        Me.CheckBox5.Name = "CheckBox5"
        Me.CheckBox5.Size = New System.Drawing.Size(62, 17)
        Me.CheckBox5.TabIndex = 10
        Me.CheckBox5.Text = "Physics"
        Me.CheckBox5.UseVisualStyleBackColor = True
        '
        'CheckBox4
        '
        Me.CheckBox4.AutoSize = True
        Me.CheckBox4.Location = New System.Drawing.Point(189, 154)
        Me.CheckBox4.Name = "CheckBox4"
        Me.CheckBox4.Size = New System.Drawing.Size(72, 17)
        Me.CheckBox4.TabIndex = 9
        Me.CheckBox4.Text = "Geograpy"
        Me.CheckBox4.UseVisualStyleBackColor = True
        '
        'CheckBox3
        '
        Me.CheckBox3.AutoSize = True
        Me.CheckBox3.Location = New System.Drawing.Point(90, 200)
        Me.CheckBox3.Name = "CheckBox3"
        Me.CheckBox3.Size = New System.Drawing.Size(58, 17)
        Me.CheckBox3.TabIndex = 8
        Me.CheckBox3.Text = "History"
        Me.CheckBox3.UseVisualStyleBackColor = True
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Location = New System.Drawing.Point(90, 177)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(65, 17)
        Me.CheckBox2.TabIndex = 7
        Me.CheckBox2.Text = "Science"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(90, 154)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(86, 17)
        Me.CheckBox1.TabIndex = 6
        Me.CheckBox1.Text = "Mathematics"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'btn_save
        '
        Me.btn_save.Location = New System.Drawing.Point(189, 215)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(75, 23)
        Me.btn_save.TabIndex = 2
        Me.btn_save.Text = "Save"
        Me.btn_save.UseVisualStyleBackColor = True
        '
        'lb_subName
        '
        Me.lb_subName.AutoSize = True
        Me.lb_subName.Location = New System.Drawing.Point(22, 154)
        Me.lb_subName.Name = "lb_subName"
        Me.lb_subName.Size = New System.Drawing.Size(43, 13)
        Me.lb_subName.TabIndex = 5
        Me.lb_subName.Text = "Subject"
        '
        'txt_studId
        '
        Me.txt_studId.Location = New System.Drawing.Point(90, 80)
        Me.txt_studId.Name = "txt_studId"
        Me.txt_studId.Size = New System.Drawing.Size(121, 20)
        Me.txt_studId.TabIndex = 3
        '
        'txt_studName
        '
        Me.txt_studName.Location = New System.Drawing.Point(90, 30)
        Me.txt_studName.Name = "txt_studName"
        Me.txt_studName.Size = New System.Drawing.Size(121, 20)
        Me.txt_studName.TabIndex = 2
        '
        'lb_studId
        '
        Me.lb_studId.AutoSize = True
        Me.lb_studId.Location = New System.Drawing.Point(22, 80)
        Me.lb_studId.Name = "lb_studId"
        Me.lb_studId.Size = New System.Drawing.Size(18, 13)
        Me.lb_studId.TabIndex = 1
        Me.lb_studId.Text = "ID"
        '
        'lb_studName
        '
        Me.lb_studName.AutoSize = True
        Me.lb_studName.Location = New System.Drawing.Point(22, 37)
        Me.lb_studName.Name = "lb_studName"
        Me.lb_studName.Size = New System.Drawing.Size(35, 13)
        Me.lb_studName.TabIndex = 0
        Me.lb_studName.Text = "Name"
        '
        'lst_studInfo
        '
        Me.lst_studInfo.FormattingEnabled = True
        Me.lst_studInfo.Location = New System.Drawing.Point(427, 49)
        Me.lst_studInfo.Name = "lst_studInfo"
        Me.lst_studInfo.Size = New System.Drawing.Size(234, 251)
        Me.lst_studInfo.TabIndex = 1
        '
        'btn_edit
        '
        Me.btn_edit.Location = New System.Drawing.Point(427, 333)
        Me.btn_edit.Name = "btn_edit"
        Me.btn_edit.Size = New System.Drawing.Size(88, 26)
        Me.btn_edit.TabIndex = 2
        Me.btn_edit.Text = "Edit Student"
        Me.btn_edit.UseVisualStyleBackColor = True
        '
        'btn_delete
        '
        Me.btn_delete.Location = New System.Drawing.Point(564, 333)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(97, 26)
        Me.btn_delete.TabIndex = 3
        Me.btn_delete.Text = "Delete Student"
        Me.btn_delete.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(716, 394)
        Me.Controls.Add(Me.btn_delete)
        Me.Controls.Add(Me.btn_edit)
        Me.Controls.Add(Me.lst_studInfo)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lb_subName As System.Windows.Forms.Label
    Friend WithEvents txt_studId As System.Windows.Forms.TextBox
    Friend WithEvents txt_studName As System.Windows.Forms.TextBox
    Friend WithEvents lb_studId As System.Windows.Forms.Label
    Friend WithEvents lb_studName As System.Windows.Forms.Label
    Friend WithEvents lst_studInfo As System.Windows.Forms.ListBox
    Friend WithEvents btn_save As System.Windows.Forms.Button
    Friend WithEvents CheckBox5 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox4 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox3 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox2 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents btn_edit As System.Windows.Forms.Button
    Friend WithEvents btn_delete As System.Windows.Forms.Button

End Class
