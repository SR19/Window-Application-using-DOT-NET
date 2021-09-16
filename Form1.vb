Public Class Form1

    Private studInformation As Dictionary(Of Integer, Student)
    Private Sub Form1_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        SaveStudents()
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        studInformation = New Dictionary(Of Integer, Student)
        LoadStudents()
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lst_studInfo.SelectedIndexChanged

    End Sub

    ' Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '  Me.cmb_subName.Items.Add("Mathematics")
    '   Me.cmb_subName.Items.Add("Science")
    '   Me.cmb_subName.Items.Add("History")
    '   Me.cmb_subName.Items.Add("Geography")
    '  Me.cmb_subName.Items.Add("Physics")


    '  End Sub

    

    Private Sub btn_save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_save.Click
        For Each c As Control In GroupBox1.Controls
            If (TypeOf c Is TextBox) Then
                Dim cText As TextBox = CType(c, TextBox)
                If (cText.Text.Equals("")) Then
                    MsgBox("All fields must be filled!")
                    Return
                End If
            End If
        Next

        'Continuation of sub
        If (btn_save.Text.Equals("Add Student")) Then
            'We want to add a student to the dictionary
            Dim studentToAdd As New Student(txt_studName.Text, CheckBox1.Text)
            AddStudent(CInt(txt_studId.Text), studentToAdd)
        ElseIf (btn_save.Text.Equals("Edit Student")) Then
            Dim studentToReplace As New Student(txt_studName.Text, CheckBox1.Text)
            EditStudent(CInt(txt_studId.Text), studentToReplace)

        End If

    End Sub

    Public Sub EditStudent(ByVal IDNumber As Integer, ByVal student As Student)
        studInformation.Remove(IDNumber)
        studInformation.Add(IDNumber, student)

        btn_save.Text = "Add Student"
        txt_studId.Enabled = True
        RefreshListbox()
    End Sub

    Public Sub AddStudent(ByVal IDNumber As Integer, ByVal student As Student)
        If (studInformation.ContainsKey(IDNumber)) Then
            Dim studentToCheck As Student = studInformation.Item(IDNumber)
            Dim msgboxResult As DialogResult
            msgboxResult = MessageBox.Show("That ID Number already exists! It belongs to: " & studentToCheck.Name & " " & _
                                           studentToCheck.Subject & " Would you like to replace this student?", _
                                           "Replace?", MessageBoxButtons.YesNo)

            If (msgboxResult = Windows.Forms.DialogResult.Yes) Then
                'Replace the student
                studInformation.Remove(IDNumber)
                studInformation.Add(IDNumber, student)
            End If
        Else
            studInformation.Add(IDNumber, student)
        End If

        RefreshListbox()
    End Sub

    Public Sub DeleteStudent(ByVal IDNumber As Integer)
        studInformation.Remove(IDNumber)

        RefreshListbox()
    End Sub

    Public Sub LoadStudents()
        '1000000000: Bob Dylan (B)
        If (My.Computer.FileSystem.FileExists(My.Application.Info.DirectoryPath & "/students.dat")) Then
            Dim reader As New System.IO.StreamReader(My.Application.Info.DirectoryPath & "/students.dat")
            Dim readString As String = reader.ReadToEnd
            reader.Close()
            For Each entry As String In readString.Split(vbNewLine)
                If (entry.Contains(":")) Then
                    'Good to go.
                    Dim studentToAdd As New Student(entry.Split(":")(1).Split(" ")(1).ToString, entry.Split(":")(1).Split(" ")(2).ToString.Replace("(", "").Replace(")", ""))
                    AddStudent(CInt(entry.Split(":")(0).ToString), studentToAdd)
                End If
            Next
        End If
    End Sub

    Public Sub SaveStudents()
        Dim writer As New System.IO.StreamWriter(My.Application.Info.DirectoryPath & "/students.dat", False)
        Dim writeString As String = ""
        For Each item In lst_studInfo.Items
            Dim text As String = item.ToString
            writeString = writeString & text & vbNewLine
        Next
        writer.Write(writeString)
        writer.Close()
    End Sub


    Public Sub RefreshListbox()
        lst_studInfo.Items.Clear()
        '1000000000: Bob Dylan (B)
        For Each id As Integer In studInformation.Keys
            Dim student As Student = studInformation.Item(id)
            lst_studInfo.Items.Add(id & ": " & student.Name & " " & _
                                   " (" & student.Subject & ")")

        Next
    End Sub

    Private Sub btn_delete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_delete.Click
        If Not (lst_studInfo.SelectedItem Is Nothing) Then
            Dim studentInformation As String = lst_studInfo.SelectedItem.ToString
            Dim studentID As Integer = CInt(studentInformation.Split(":")(0))
            DeleteStudent(studentID)
        End If
    End Sub


    Private Sub btn_edit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_edit.Click
        '1000000000: Bob Dylan (B)
        If Not (lst_studInfo.SelectedItem Is Nothing) Then
            Dim studentInformation As String = lst_studInfo.SelectedItem.ToString
            txt_studId.Text = studentInformation.Split(":")(0).ToString
            txt_studId.Enabled = False
            txt_studName.Text = studentInformation.Split(":")(1).Split(" ")(1).ToString
            CheckBox1.Text = studentInformation.Split(":")(1).Split(" ")(2).ToString

            Dim subject As String = studentInformation.Split(":")(1).Split(" ")(2)
            subject = subject.Replace("(", "")
            subject = subject.Replace(")", "")
            CheckBox1.Text = subject

            btn_save.Text = "Edit Student"


            If CheckBox1.Checked = True Then
                subject = "Maths"

            End If

            If CheckBox1.Checked = True Then
                subject = "Science"

            End If

            If CheckBox1.Checked = True Then
                subject = "Physics"

            End If

            If CheckBox1.Checked = True Then
                subject = "Geaography"

            End If

            If CheckBox1.Checked = True Then
                subject = "Maths"

            End If
        End If
    End Sub







    '  Dim subName As String
    '
    '  If (txt_studName.Text.Equals("")) Then
    ' MsgBox("Enter the Student Name")
    '
    'Else
    'If (txt_studId.Text.Equals("")) Then
    '  MsgBox("Enter Student ID")
    ' Return
    '  End If
    '  End If


        







End Class
