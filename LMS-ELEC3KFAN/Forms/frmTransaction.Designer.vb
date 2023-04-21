<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmTransaction
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lviTransaction = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btnIssueAdd = New System.Windows.Forms.Button()
        Me.cboShowList = New System.Windows.Forms.ComboBox()
        Me.btnReturn = New System.Windows.Forms.Button()
        Me.lviBooks = New System.Windows.Forms.ListView()
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader9 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader10 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.pnlLend = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.pnlReturn = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.pnlLend.SuspendLayout()
        Me.pnlReturn.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(0, 14)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(221, 55)
        Me.Panel1.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Uni Sans Demo Heavy CAPS", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(13, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(150, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "TRANSACTION"
        '
        'lviTransaction
        '
        Me.lviTransaction.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader4})
        Me.lviTransaction.Font = New System.Drawing.Font("Century Gothic", 8.25!)
        Me.lviTransaction.FullRowSelect = True
        Me.lviTransaction.HideSelection = False
        Me.lviTransaction.Location = New System.Drawing.Point(12, 171)
        Me.lviTransaction.Name = "lviTransaction"
        Me.lviTransaction.Size = New System.Drawing.Size(543, 428)
        Me.lviTransaction.TabIndex = 3
        Me.lviTransaction.UseCompatibleStateImageBehavior = False
        Me.lviTransaction.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "ID"
        Me.ColumnHeader1.Width = 42
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "STUDENT ID"
        Me.ColumnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader2.Width = 100
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "DATE ISSUED"
        Me.ColumnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader3.Width = 90
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "DUE DATE"
        Me.ColumnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader5.Width = 90
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "DATE RETURNED"
        Me.ColumnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader6.Width = 105
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "STATUS"
        Me.ColumnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader4.Width = 85
        '
        'btnIssueAdd
        '
        Me.btnIssueAdd.BackColor = System.Drawing.Color.RoyalBlue
        Me.btnIssueAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnIssueAdd.Image = Global.LMS_ELEC3KFAN.My.Resources.Resources.iconBorrowBook
        Me.btnIssueAdd.Location = New System.Drawing.Point(843, 507)
        Me.btnIssueAdd.Name = "btnIssueAdd"
        Me.btnIssueAdd.Size = New System.Drawing.Size(44, 43)
        Me.btnIssueAdd.TabIndex = 4
        Me.btnIssueAdd.UseVisualStyleBackColor = False
        '
        'cboShowList
        '
        Me.cboShowList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboShowList.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.cboShowList.FormattingEnabled = True
        Me.cboShowList.Items.AddRange(New Object() {"ALL", "Issued", "Partially", "Returned"})
        Me.cboShowList.Location = New System.Drawing.Point(12, 129)
        Me.cboShowList.Name = "cboShowList"
        Me.cboShowList.Size = New System.Drawing.Size(121, 25)
        Me.cboShowList.TabIndex = 5
        '
        'btnReturn
        '
        Me.btnReturn.BackColor = System.Drawing.Color.Gray
        Me.btnReturn.Enabled = False
        Me.btnReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReturn.Image = Global.LMS_ELEC3KFAN.My.Resources.Resources.iconReturnBook
        Me.btnReturn.Location = New System.Drawing.Point(843, 556)
        Me.btnReturn.Name = "btnReturn"
        Me.btnReturn.Size = New System.Drawing.Size(44, 43)
        Me.btnReturn.TabIndex = 6
        Me.btnReturn.UseVisualStyleBackColor = False
        '
        'lviBooks
        '
        Me.lviBooks.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader7, Me.ColumnHeader8, Me.ColumnHeader9, Me.ColumnHeader10})
        Me.lviBooks.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lviBooks.FullRowSelect = True
        Me.lviBooks.HideSelection = False
        Me.lviBooks.Location = New System.Drawing.Point(565, 211)
        Me.lviBooks.Name = "lviBooks"
        Me.lviBooks.Size = New System.Drawing.Size(326, 254)
        Me.lviBooks.TabIndex = 8
        Me.lviBooks.UseCompatibleStateImageBehavior = False
        Me.lviBooks.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "ID"
        Me.ColumnHeader7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader7.Width = 64
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "TITLE"
        Me.ColumnHeader8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader8.Width = 122
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "AUTHOR"
        Me.ColumnHeader9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader9.Width = 70
        '
        'ColumnHeader10
        '
        Me.ColumnHeader10.Text = "QTY"
        '
        'pnlLend
        '
        Me.pnlLend.BackColor = System.Drawing.Color.RoyalBlue
        Me.pnlLend.Controls.Add(Me.Label5)
        Me.pnlLend.Location = New System.Drawing.Point(724, 513)
        Me.pnlLend.Name = "pnlLend"
        Me.pnlLend.Size = New System.Drawing.Size(121, 31)
        Me.pnlLend.TabIndex = 14
        Me.pnlLend.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label5.Location = New System.Drawing.Point(8, 7)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(89, 16)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "LEND BOOKS"
        '
        'pnlReturn
        '
        Me.pnlReturn.BackColor = System.Drawing.Color.Firebrick
        Me.pnlReturn.Controls.Add(Me.Label6)
        Me.pnlReturn.Location = New System.Drawing.Point(724, 563)
        Me.pnlReturn.Name = "pnlReturn"
        Me.pnlReturn.Size = New System.Drawing.Size(121, 31)
        Me.pnlReturn.TabIndex = 15
        Me.pnlReturn.Visible = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label6.Location = New System.Drawing.Point(8, 7)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(104, 16)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "RETURN BOOKS"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Panel2.Location = New System.Drawing.Point(9, 167)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(549, 435)
        Me.Panel2.TabIndex = 16
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Panel3.Location = New System.Drawing.Point(562, 166)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(333, 303)
        Me.Panel3.TabIndex = 17
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.Panel4.Controls.Add(Me.Label9)
        Me.Panel4.Location = New System.Drawing.Point(562, 171)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(196, 35)
        Me.Panel4.TabIndex = 18
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Uni Sans Demo Heavy CAPS", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(9, 8)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(158, 20)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "BORROWED BOOKS"
        '
        'frmTransaction
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.LMS_ELEC3KFAN.My.Resources.Resources.MainBG2
        Me.ClientSize = New System.Drawing.Size(899, 639)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.lviBooks)
        Me.Controls.Add(Me.btnReturn)
        Me.Controls.Add(Me.cboShowList)
        Me.Controls.Add(Me.btnIssueAdd)
        Me.Controls.Add(Me.lviTransaction)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.pnlLend)
        Me.Controls.Add(Me.pnlReturn)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmTransaction"
        Me.Text = "frmIssue"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.pnlLend.ResumeLayout(False)
        Me.pnlLend.PerformLayout()
        Me.pnlReturn.ResumeLayout(False)
        Me.pnlReturn.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents lviTransaction As ListView
    Friend WithEvents btnIssueAdd As Button
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents cboShowList As ComboBox
    Friend WithEvents btnReturn As Button
    Friend WithEvents lviBooks As ListView
    Friend WithEvents ColumnHeader7 As ColumnHeader
    Friend WithEvents ColumnHeader8 As ColumnHeader
    Friend WithEvents ColumnHeader9 As ColumnHeader
    Friend WithEvents ColumnHeader6 As ColumnHeader
    Friend WithEvents pnlLend As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents pnlReturn As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label9 As Label
    Friend WithEvents ColumnHeader10 As ColumnHeader
End Class
