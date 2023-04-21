<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReturn
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.btnIssue = New System.Windows.Forms.Button()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lviBooks = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader9 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lviIssue = New System.Windows.Forms.ListView()
        Me.ColumnHeader11 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader12 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader13 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader14 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtSection = New System.Windows.Forms.TextBox()
        Me.txtGrade = New System.Windows.Forms.TextBox()
        Me.txtStudentName = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtTotalCopies = New System.Windows.Forms.TextBox()
        Me.txtStudentID = New System.Windows.Forms.TextBox()
        Me.txtDueDate = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnIssue
        '
        Me.btnIssue.Location = New System.Drawing.Point(672, 213)
        Me.btnIssue.Name = "btnIssue"
        Me.btnIssue.Size = New System.Drawing.Size(89, 41)
        Me.btnIssue.TabIndex = 15
        Me.btnIssue.Text = "ISSUE"
        Me.btnIssue.UseVisualStyleBackColor = True
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(605, 29)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker1.TabIndex = 16
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(462, 213)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnAdd.TabIndex = 24
        Me.btnAdd.Text = "ADD"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lviBooks)
        Me.GroupBox1.Controls.Add(Me.lviIssue)
        Me.GroupBox1.Controls.Add(Me.btnIssue)
        Me.GroupBox1.Controls.Add(Me.btnAdd)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtSection)
        Me.GroupBox1.Controls.Add(Me.txtGrade)
        Me.GroupBox1.Controls.Add(Me.txtStudentName)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtTotalCopies)
        Me.GroupBox1.Controls.Add(Me.txtStudentID)
        Me.GroupBox1.Controls.Add(Me.txtDueDate)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 55)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(793, 306)
        Me.GroupBox1.TabIndex = 25
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'lviBooks
        '
        Me.lviBooks.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader7, Me.ColumnHeader8, Me.ColumnHeader9})
        Me.lviBooks.FullRowSelect = True
        Me.lviBooks.HideSelection = False
        Me.lviBooks.Location = New System.Drawing.Point(247, 16)
        Me.lviBooks.Name = "lviBooks"
        Me.lviBooks.Size = New System.Drawing.Size(290, 191)
        Me.lviBooks.TabIndex = 40
        Me.lviBooks.UseCompatibleStateImageBehavior = False
        Me.lviBooks.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "ID"
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Title"
        Me.ColumnHeader3.Width = 87
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Author"
        Me.ColumnHeader4.Width = 407
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Publisher"
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Category"
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Date Published"
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "ISBN"
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "Total Copies"
        '
        'lviIssue
        '
        Me.lviIssue.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader11, Me.ColumnHeader12, Me.ColumnHeader13, Me.ColumnHeader14})
        Me.lviIssue.HideSelection = False
        Me.lviIssue.Location = New System.Drawing.Point(548, 16)
        Me.lviIssue.Name = "lviIssue"
        Me.lviIssue.Size = New System.Drawing.Size(213, 191)
        Me.lviIssue.TabIndex = 39
        Me.lviIssue.UseCompatibleStateImageBehavior = False
        Me.lviIssue.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader11
        '
        Me.ColumnHeader11.Text = "ID"
        Me.ColumnHeader11.Width = 53
        '
        'ColumnHeader12
        '
        Me.ColumnHeader12.Text = "Title"
        Me.ColumnHeader12.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader12.Width = 79
        '
        'ColumnHeader13
        '
        Me.ColumnHeader13.Text = "Author"
        Me.ColumnHeader13.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader13.Width = 73
        '
        'ColumnHeader14
        '
        Me.ColumnHeader14.Text = "Publisher"
        Me.ColumnHeader14.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(18, 178)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(46, 13)
        Me.Label7.TabIndex = 37
        Me.Label7.Text = "Section:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(28, 148)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(39, 13)
        Me.Label6.TabIndex = 36
        Me.Label6.Text = "Grade:"
        '
        'txtSection
        '
        Me.txtSection.Location = New System.Drawing.Point(84, 175)
        Me.txtSection.Name = "txtSection"
        Me.txtSection.Size = New System.Drawing.Size(100, 20)
        Me.txtSection.TabIndex = 35
        '
        'txtGrade
        '
        Me.txtGrade.Location = New System.Drawing.Point(84, 145)
        Me.txtGrade.Name = "txtGrade"
        Me.txtGrade.Size = New System.Drawing.Size(100, 20)
        Me.txtGrade.TabIndex = 34
        '
        'txtStudentName
        '
        Me.txtStudentName.Location = New System.Drawing.Point(84, 119)
        Me.txtStudentName.Multiline = True
        Me.txtStudentName.Name = "txtStudentName"
        Me.txtStudentName.Size = New System.Drawing.Size(145, 20)
        Me.txtStudentName.TabIndex = 32
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(7, 122)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(78, 13)
        Me.Label4.TabIndex = 31
        Me.Label4.Text = "Student Name:"
        '
        'txtTotalCopies
        '
        Me.txtTotalCopies.Location = New System.Drawing.Point(84, 210)
        Me.txtTotalCopies.Name = "txtTotalCopies"
        Me.txtTotalCopies.Size = New System.Drawing.Size(100, 20)
        Me.txtTotalCopies.TabIndex = 30
        '
        'txtStudentID
        '
        Me.txtStudentID.Location = New System.Drawing.Point(84, 85)
        Me.txtStudentID.Multiline = True
        Me.txtStudentID.Name = "txtStudentID"
        Me.txtStudentID.Size = New System.Drawing.Size(145, 20)
        Me.txtStudentID.TabIndex = 29
        '
        'txtDueDate
        '
        Me.txtDueDate.Location = New System.Drawing.Point(84, 53)
        Me.txtDueDate.Name = "txtDueDate"
        Me.txtDueDate.Size = New System.Drawing.Size(100, 20)
        Me.txtDueDate.TabIndex = 28
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(7, 213)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(69, 13)
        Me.Label5.TabIndex = 27
        Me.Label5.Text = "Total Copies:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 88)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 13)
        Me.Label3.TabIndex = 26
        Me.Label3.Text = "Student ID:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(18, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 13)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "Due Date:"
        '
        'frmReturn
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(817, 373)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Name = "frmReturn"
        Me.Text = "Issue: Add Form"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnIssue As Button
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents btnAdd As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lviIssue As ListView
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtSection As TextBox
    Friend WithEvents txtGrade As TextBox
    Friend WithEvents txtStudentName As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtTotalCopies As TextBox
    Friend WithEvents txtStudentID As TextBox
    Friend WithEvents txtDueDate As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lviBooks As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents ColumnHeader6 As ColumnHeader
    Friend WithEvents ColumnHeader7 As ColumnHeader
    Friend WithEvents ColumnHeader8 As ColumnHeader
    Friend WithEvents ColumnHeader9 As ColumnHeader
    Friend WithEvents ColumnHeader11 As ColumnHeader
    Friend WithEvents ColumnHeader12 As ColumnHeader
    Friend WithEvents ColumnHeader13 As ColumnHeader
    Friend WithEvents ColumnHeader14 As ColumnHeader
End Class
