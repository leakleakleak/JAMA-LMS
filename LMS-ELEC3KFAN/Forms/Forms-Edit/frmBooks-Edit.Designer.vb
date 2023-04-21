<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBooks_Edit
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtBookName = New System.Windows.Forms.TextBox()
        Me.txtCat = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtAuthor = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtCopies = New System.Windows.Forms.TextBox()
        Me.txtPubName = New System.Windows.Forms.TextBox()
        Me.txtISBN = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtDatePublished = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblBookID = New System.Windows.Forms.Label()
        Me.pnlBooks = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.pnlBooks.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(123, 126)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "TITLE:"
        '
        'txtBookName
        '
        Me.txtBookName.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBookName.Location = New System.Drawing.Point(170, 123)
        Me.txtBookName.Name = "txtBookName"
        Me.txtBookName.Size = New System.Drawing.Size(216, 23)
        Me.txtBookName.TabIndex = 1
        '
        'txtCat
        '
        Me.txtCat.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCat.Location = New System.Drawing.Point(170, 221)
        Me.txtCat.Name = "txtCat"
        Me.txtCat.Size = New System.Drawing.Size(133, 23)
        Me.txtCat.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(100, 157)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "AUTHOR:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(88, 192)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "PUBLISHER:"
        '
        'txtAuthor
        '
        Me.txtAuthor.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAuthor.Location = New System.Drawing.Point(170, 154)
        Me.txtAuthor.Name = "txtAuthor"
        Me.txtAuthor.Size = New System.Drawing.Size(216, 23)
        Me.txtAuthor.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(81, 224)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(83, 16)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "CATEGORY:"
        '
        'txtCopies
        '
        Me.txtCopies.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCopies.Location = New System.Drawing.Point(170, 321)
        Me.txtCopies.Name = "txtCopies"
        Me.txtCopies.Size = New System.Drawing.Size(61, 23)
        Me.txtCopies.TabIndex = 3
        '
        'txtPubName
        '
        Me.txtPubName.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPubName.Location = New System.Drawing.Point(170, 189)
        Me.txtPubName.Name = "txtPubName"
        Me.txtPubName.Size = New System.Drawing.Size(216, 23)
        Me.txtPubName.TabIndex = 5
        '
        'txtISBN
        '
        Me.txtISBN.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtISBN.Location = New System.Drawing.Point(170, 256)
        Me.txtISBN.Name = "txtISBN"
        Me.txtISBN.Size = New System.Drawing.Size(216, 23)
        Me.txtISBN.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(51, 294)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(113, 16)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "DATE PUBLISHED:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(56, 324)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(108, 16)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "NO. OF COPIES:"
        '
        'txtDatePublished
        '
        Me.txtDatePublished.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDatePublished.Location = New System.Drawing.Point(170, 291)
        Me.txtDatePublished.Name = "txtDatePublished"
        Me.txtDatePublished.Size = New System.Drawing.Size(216, 23)
        Me.txtDatePublished.TabIndex = 5
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(123, 259)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(41, 16)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "ISBN:"
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.RoyalBlue
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Image = Global.LMS_ELEC3KFAN.My.Resources.Resources.iconSave
        Me.btnSave.Location = New System.Drawing.Point(392, 370)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(44, 43)
        Me.btnSave.TabIndex = 6
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(97, 95)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(67, 16)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "BOOK ID:"
        '
        'lblBookID
        '
        Me.lblBookID.AutoSize = True
        Me.lblBookID.Location = New System.Drawing.Point(167, 95)
        Me.lblBookID.Name = "lblBookID"
        Me.lblBookID.Size = New System.Drawing.Size(16, 16)
        Me.lblBookID.TabIndex = 0
        Me.lblBookID.Text = "#"
        '
        'pnlBooks
        '
        Me.pnlBooks.BackColor = System.Drawing.Color.WhiteSmoke
        Me.pnlBooks.Controls.Add(Me.Panel2)
        Me.pnlBooks.Controls.Add(Me.btnClose)
        Me.pnlBooks.Controls.Add(Me.txtBookName)
        Me.pnlBooks.Controls.Add(Me.btnSave)
        Me.pnlBooks.Controls.Add(Me.Label1)
        Me.pnlBooks.Controls.Add(Me.Label8)
        Me.pnlBooks.Controls.Add(Me.txtAuthor)
        Me.pnlBooks.Controls.Add(Me.Label2)
        Me.pnlBooks.Controls.Add(Me.txtPubName)
        Me.pnlBooks.Controls.Add(Me.Label4)
        Me.pnlBooks.Controls.Add(Me.txtCat)
        Me.pnlBooks.Controls.Add(Me.Label3)
        Me.pnlBooks.Controls.Add(Me.txtISBN)
        Me.pnlBooks.Controls.Add(Me.Label5)
        Me.pnlBooks.Controls.Add(Me.txtDatePublished)
        Me.pnlBooks.Controls.Add(Me.Label7)
        Me.pnlBooks.Controls.Add(Me.txtCopies)
        Me.pnlBooks.Controls.Add(Me.Label6)
        Me.pnlBooks.Controls.Add(Me.lblBookID)
        Me.pnlBooks.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold)
        Me.pnlBooks.Location = New System.Drawing.Point(5, 6)
        Me.pnlBooks.Name = "pnlBooks"
        Me.pnlBooks.Size = New System.Drawing.Size(448, 429)
        Me.pnlBooks.TabIndex = 7
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.Location = New System.Drawing.Point(0, 8)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(188, 44)
        Me.Panel2.TabIndex = 10
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Uni Sans Demo Heavy CAPS", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(11, 10)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(113, 25)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "EDIT BOOK"
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnClose.FlatAppearance.BorderSize = 0
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Font = New System.Drawing.Font("Uni Sans Demo Heavy CAPS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.Black
        Me.btnClose.Location = New System.Drawing.Point(409, 0)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(39, 37)
        Me.btnClose.TabIndex = 9
        Me.btnClose.Text = "X"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'frmBooks_Edit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDark
        Me.ClientSize = New System.Drawing.Size(458, 441)
        Me.Controls.Add(Me.pnlBooks)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmBooks_Edit"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Books: Edit form"
        Me.pnlBooks.ResumeLayout(False)
        Me.pnlBooks.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtBookName As TextBox
    Friend WithEvents txtCat As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtAuthor As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtCopies As TextBox
    Friend WithEvents txtISBN As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtDatePublished As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtPubName As TextBox
    Friend WithEvents btnSave As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents lblBookID As Label
    Friend WithEvents pnlBooks As Panel
    Friend WithEvents btnClose As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label9 As Label
End Class
