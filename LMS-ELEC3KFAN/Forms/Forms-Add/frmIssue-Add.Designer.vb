<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmIssue_Add
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
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
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
        Me.txtStudentID = New System.Windows.Forms.TextBox()
        Me.txtDueDate = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pnl1 = New System.Windows.Forms.Panel()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.pnlDetails_bg = New System.Windows.Forms.Panel()
        Me.pnlDetails = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnIssue = New System.Windows.Forms.Button()
        Me.pnl1.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.pnlDetails_bg.SuspendLayout()
        Me.pnlDetails.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.SuspendLayout()
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(639, 26)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker1.TabIndex = 16
        Me.DateTimePicker1.Visible = False
        '
        'lviBooks
        '
        Me.lviBooks.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader7, Me.ColumnHeader8, Me.ColumnHeader9})
        Me.lviBooks.Font = New System.Drawing.Font("Century Gothic", 8.25!)
        Me.lviBooks.FullRowSelect = True
        Me.lviBooks.HideSelection = False
        Me.lviBooks.Location = New System.Drawing.Point(5, 45)
        Me.lviBooks.Name = "lviBooks"
        Me.lviBooks.Size = New System.Drawing.Size(583, 179)
        Me.lviBooks.TabIndex = 40
        Me.lviBooks.UseCompatibleStateImageBehavior = False
        Me.lviBooks.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "ID"
        Me.ColumnHeader1.Width = 42
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "TITLE"
        Me.ColumnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader3.Width = 150
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "AUTHOR"
        Me.ColumnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader4.Width = 150
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "PUBLISHER"
        Me.ColumnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader5.Width = 120
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "CATEGORY"
        Me.ColumnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader6.Width = 110
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "DATE PUBLISHED"
        Me.ColumnHeader7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader7.Width = 100
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "ISBN"
        Me.ColumnHeader8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader8.Width = 100
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "TOTAL COPIES"
        Me.ColumnHeader9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lviIssue
        '
        Me.lviIssue.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader11, Me.ColumnHeader12, Me.ColumnHeader13, Me.ColumnHeader14})
        Me.lviIssue.Font = New System.Drawing.Font("Century Gothic", 8.25!)
        Me.lviIssue.HideSelection = False
        Me.lviIssue.Location = New System.Drawing.Point(5, 43)
        Me.lviIssue.Name = "lviIssue"
        Me.lviIssue.Size = New System.Drawing.Size(449, 147)
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
        Me.ColumnHeader12.Text = "TITLE"
        Me.ColumnHeader12.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader12.Width = 150
        '
        'ColumnHeader13
        '
        Me.ColumnHeader13.Text = "AUTHOR"
        Me.ColumnHeader13.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader13.Width = 150
        '
        'ColumnHeader14
        '
        Me.ColumnHeader14.Text = "QTY"
        Me.ColumnHeader14.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(21, 148)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(67, 16)
        Me.Label7.TabIndex = 37
        Me.Label7.Text = "SECTION:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(29, 109)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(57, 16)
        Me.Label6.TabIndex = 36
        Me.Label6.Text = "GRADE:"
        '
        'txtSection
        '
        Me.txtSection.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSection.Location = New System.Drawing.Point(92, 145)
        Me.txtSection.Name = "txtSection"
        Me.txtSection.Size = New System.Drawing.Size(100, 23)
        Me.txtSection.TabIndex = 35
        '
        'txtGrade
        '
        Me.txtGrade.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGrade.Location = New System.Drawing.Point(92, 106)
        Me.txtGrade.Name = "txtGrade"
        Me.txtGrade.Size = New System.Drawing.Size(100, 23)
        Me.txtGrade.TabIndex = 34
        '
        'txtStudentName
        '
        Me.txtStudentName.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStudentName.Location = New System.Drawing.Point(92, 67)
        Me.txtStudentName.Multiline = True
        Me.txtStudentName.Name = "txtStudentName"
        Me.txtStudentName.Size = New System.Drawing.Size(148, 20)
        Me.txtStudentName.TabIndex = 32
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(37, 67)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 16)
        Me.Label4.TabIndex = 31
        Me.Label4.Text = "NAME:"
        '
        'txtStudentID
        '
        Me.txtStudentID.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStudentID.Location = New System.Drawing.Point(92, 28)
        Me.txtStudentID.Multiline = True
        Me.txtStudentID.Name = "txtStudentID"
        Me.txtStudentID.Size = New System.Drawing.Size(116, 20)
        Me.txtStudentID.TabIndex = 29
        '
        'txtDueDate
        '
        Me.txtDueDate.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDueDate.Location = New System.Drawing.Point(92, 202)
        Me.txtDueDate.Name = "txtDueDate"
        Me.txtDueDate.Size = New System.Drawing.Size(100, 23)
        Me.txtDueDate.TabIndex = 28
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(10, 31)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 16)
        Me.Label3.TabIndex = 26
        Me.Label3.Text = "STUDENT ID:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(16, 205)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 16)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "DUE DATE:"
        '
        'pnl1
        '
        Me.pnl1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.pnl1.Controls.Add(Me.btnClear)
        Me.pnl1.Controls.Add(Me.btnClose)
        Me.pnl1.Controls.Add(Me.Panel6)
        Me.pnl1.Controls.Add(Me.Panel1)
        Me.pnl1.Controls.Add(Me.Panel2)
        Me.pnl1.Controls.Add(Me.DateTimePicker1)
        Me.pnl1.Controls.Add(Me.pnlDetails_bg)
        Me.pnl1.Controls.Add(Me.Panel5)
        Me.pnl1.Location = New System.Drawing.Point(6, 6)
        Me.pnl1.Name = "pnl1"
        Me.pnl1.Size = New System.Drawing.Size(913, 542)
        Me.pnl1.TabIndex = 26
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnClose.FlatAppearance.BorderSize = 0
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Font = New System.Drawing.Font("Uni Sans Demo Heavy CAPS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.Black
        Me.btnClose.Location = New System.Drawing.Point(875, -1)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(39, 37)
        Me.btnClose.TabIndex = 45
        Me.btnClose.Text = "X"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.Panel6.Controls.Add(Me.Label5)
        Me.Panel6.Location = New System.Drawing.Point(350, 334)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(204, 35)
        Me.Panel6.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Uni Sans Demo Heavy CAPS", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(9, 8)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(158, 20)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "BORROWED BOOKS"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Panel1.Controls.Add(Me.Panel4)
        Me.Panel1.Controls.Add(Me.lviBooks)
        Me.Panel1.Controls.Add(Me.btnAdd)
        Me.Panel1.Location = New System.Drawing.Point(292, 81)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(595, 230)
        Me.Panel1.TabIndex = 43
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.Panel4.Controls.Add(Me.Label2)
        Me.Panel4.Location = New System.Drawing.Point(0, 4)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(100, 35)
        Me.Panel4.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Uni Sans Demo Heavy CAPS", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(9, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 20)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "BOOKS"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Location = New System.Drawing.Point(0, 8)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(188, 44)
        Me.Panel2.TabIndex = 41
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Uni Sans Demo Heavy CAPS", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(11, 10)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(131, 25)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "LEND BOOKS"
        '
        'pnlDetails_bg
        '
        Me.pnlDetails_bg.BackColor = System.Drawing.SystemColors.ControlDark
        Me.pnlDetails_bg.Controls.Add(Me.pnlDetails)
        Me.pnlDetails_bg.Controls.Add(Me.Panel3)
        Me.pnlDetails_bg.Location = New System.Drawing.Point(16, 81)
        Me.pnlDetails_bg.Name = "pnlDetails_bg"
        Me.pnlDetails_bg.Size = New System.Drawing.Size(266, 442)
        Me.pnlDetails_bg.TabIndex = 42
        '
        'pnlDetails
        '
        Me.pnlDetails.BackColor = System.Drawing.Color.WhiteSmoke
        Me.pnlDetails.Controls.Add(Me.txtDueDate)
        Me.pnlDetails.Controls.Add(Me.txtGrade)
        Me.pnlDetails.Controls.Add(Me.txtSection)
        Me.pnlDetails.Controls.Add(Me.btnIssue)
        Me.pnlDetails.Controls.Add(Me.Label1)
        Me.pnlDetails.Controls.Add(Me.txtStudentName)
        Me.pnlDetails.Controls.Add(Me.Label6)
        Me.pnlDetails.Controls.Add(Me.Label3)
        Me.pnlDetails.Controls.Add(Me.Label4)
        Me.pnlDetails.Controls.Add(Me.Label7)
        Me.pnlDetails.Controls.Add(Me.txtStudentID)
        Me.pnlDetails.Location = New System.Drawing.Point(6, 44)
        Me.pnlDetails.Name = "pnlDetails"
        Me.pnlDetails.Size = New System.Drawing.Size(252, 391)
        Me.pnlDetails.TabIndex = 5
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.Panel3.Controls.Add(Me.Label9)
        Me.Panel3.Location = New System.Drawing.Point(0, 4)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(100, 35)
        Me.Panel3.TabIndex = 4
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Uni Sans Demo Heavy CAPS", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(9, 8)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(74, 20)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "DETAILS"
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Panel5.Controls.Add(Me.lviIssue)
        Me.Panel5.Location = New System.Drawing.Point(350, 330)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(462, 195)
        Me.Panel5.TabIndex = 44
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.Firebrick
        Me.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClear.Image = Global.LMS_ELEC3KFAN.My.Resources.Resources.iconClear
        Me.btnClear.Location = New System.Drawing.Point(835, 459)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(44, 43)
        Me.btnClear.TabIndex = 46
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdd.Image = Global.LMS_ELEC3KFAN.My.Resources.Resources.iconAdd
        Me.btnAdd.Location = New System.Drawing.Point(545, 4)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(42, 38)
        Me.btnAdd.TabIndex = 24
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'btnIssue
        '
        Me.btnIssue.BackColor = System.Drawing.Color.RoyalBlue
        Me.btnIssue.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnIssue.Image = Global.LMS_ELEC3KFAN.My.Resources.Resources.iconIssue
        Me.btnIssue.Location = New System.Drawing.Point(196, 334)
        Me.btnIssue.Name = "btnIssue"
        Me.btnIssue.Size = New System.Drawing.Size(44, 43)
        Me.btnIssue.TabIndex = 15
        Me.btnIssue.UseVisualStyleBackColor = False
        '
        'frmIssue_Add
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDark
        Me.ClientSize = New System.Drawing.Size(925, 555)
        Me.Controls.Add(Me.pnl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmIssue_Add"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Issue: Add Form"
        Me.pnl1.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.pnlDetails_bg.ResumeLayout(False)
        Me.pnlDetails.ResumeLayout(False)
        Me.pnlDetails.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnIssue As Button
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents btnAdd As Button
    Friend WithEvents lviIssue As ListView
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtSection As TextBox
    Friend WithEvents txtGrade As TextBox
    Friend WithEvents txtStudentName As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtStudentID As TextBox
    Friend WithEvents txtDueDate As TextBox
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
    Friend WithEvents pnl1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label8 As Label
    Friend WithEvents pnlDetails_bg As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label9 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents pnlDetails As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents btnClose As Button
    Friend WithEvents btnClear As Button
End Class
