<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmBooks
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnRemove = New System.Windows.Forms.Button()
        Me.cboSearch = New System.Windows.Forms.ComboBox()
        Me.txtISBN = New System.Windows.Forms.TextBox()
        Me.txtDatePub = New System.Windows.Forms.TextBox()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lviBooks = New System.Windows.Forms.ListView()
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader9 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader10 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lblSearch = New System.Windows.Forms.Label()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.pnlAdd = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.pnlEdit = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.pnlRemove = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.pnlDetails_fg = New System.Windows.Forms.Panel()
        Me.pnlDetails_bg = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.pnlAdd.SuspendLayout()
        Me.pnlEdit.SuspendLayout()
        Me.pnlRemove.SuspendLayout()
        Me.pnlDetails_fg.SuspendLayout()
        Me.pnlDetails_bg.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Location = New System.Drawing.Point(0, 14)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(221, 55)
        Me.Panel1.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Uni Sans Demo Heavy CAPS", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(13, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 25)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "BOOKS"
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdd.Image = Global.LMS_ELEC3KFAN.My.Resources.Resources.iconAdd
        Me.btnAdd.Location = New System.Drawing.Point(837, 451)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(44, 43)
        Me.btnAdd.TabIndex = 4
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'btnEdit
        '
        Me.btnEdit.BackColor = System.Drawing.Color.Gray
        Me.btnEdit.Enabled = False
        Me.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEdit.Image = Global.LMS_ELEC3KFAN.My.Resources.Resources.iconEdit
        Me.btnEdit.Location = New System.Drawing.Point(837, 500)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(44, 43)
        Me.btnEdit.TabIndex = 4
        Me.btnEdit.UseVisualStyleBackColor = False
        '
        'btnRemove
        '
        Me.btnRemove.BackColor = System.Drawing.Color.Gray
        Me.btnRemove.Enabled = False
        Me.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRemove.Image = Global.LMS_ELEC3KFAN.My.Resources.Resources.iconRemove
        Me.btnRemove.Location = New System.Drawing.Point(837, 549)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(44, 43)
        Me.btnRemove.TabIndex = 4
        Me.btnRemove.UseVisualStyleBackColor = False
        '
        'cboSearch
        '
        Me.cboSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboSearch.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboSearch.FormattingEnabled = True
        Me.cboSearch.Location = New System.Drawing.Point(19, 140)
        Me.cboSearch.Name = "cboSearch"
        Me.cboSearch.Size = New System.Drawing.Size(121, 25)
        Me.cboSearch.TabIndex = 0
        '
        'txtISBN
        '
        Me.txtISBN.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtISBN.Location = New System.Drawing.Point(63, 26)
        Me.txtISBN.Name = "txtISBN"
        Me.txtISBN.ReadOnly = True
        Me.txtISBN.Size = New System.Drawing.Size(125, 23)
        Me.txtISBN.TabIndex = 0
        Me.txtISBN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtDatePub
        '
        Me.txtDatePub.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDatePub.Location = New System.Drawing.Point(126, 54)
        Me.txtDatePub.Name = "txtDatePub"
        Me.txtDatePub.ReadOnly = True
        Me.txtDatePub.Size = New System.Drawing.Size(125, 23)
        Me.txtDatePub.TabIndex = 2
        Me.txtDatePub.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtTotal
        '
        Me.txtTotal.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotal.Location = New System.Drawing.Point(125, 84)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.ReadOnly = True
        Me.txtTotal.Size = New System.Drawing.Size(78, 23)
        Me.txtTotal.TabIndex = 5
        Me.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(14, 87)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(101, 16)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "TOTAL COPIES:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(14, 29)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 16)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "ISBN:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(14, 58)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(113, 16)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "DATE PUBLISHED:"
        '
        'lviBooks
        '
        Me.lviBooks.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader6, Me.ColumnHeader7, Me.ColumnHeader8, Me.ColumnHeader9, Me.ColumnHeader10})
        Me.lviBooks.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lviBooks.FullRowSelect = True
        Me.lviBooks.HideSelection = False
        Me.lviBooks.Location = New System.Drawing.Point(18, 178)
        Me.lviBooks.Name = "lviBooks"
        Me.lviBooks.Size = New System.Drawing.Size(593, 428)
        Me.lviBooks.TabIndex = 7
        Me.lviBooks.UseCompatibleStateImageBehavior = False
        Me.lviBooks.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "ID"
        Me.ColumnHeader6.Width = 42
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "TITLE"
        Me.ColumnHeader7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader7.Width = 150
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "AUTHOR"
        Me.ColumnHeader8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader8.Width = 130
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "PUBLISHER"
        Me.ColumnHeader9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader9.Width = 140
        '
        'ColumnHeader10
        '
        Me.ColumnHeader10.Text = "CATEGORY"
        Me.ColumnHeader10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader10.Width = 102
        '
        'lblSearch
        '
        Me.lblSearch.AutoSize = True
        Me.lblSearch.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.lblSearch.Location = New System.Drawing.Point(327, 143)
        Me.lblSearch.Name = "lblSearch"
        Me.lblSearch.Size = New System.Drawing.Size(66, 17)
        Me.lblSearch.TabIndex = 8
        Me.lblSearch.Text = "SEARCH: "
        Me.lblSearch.Visible = False
        '
        'txtSearch
        '
        Me.txtSearch.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtSearch.Location = New System.Drawing.Point(395, 140)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(220, 23)
        Me.txtSearch.TabIndex = 9
        Me.txtSearch.Visible = False
        '
        'pnlAdd
        '
        Me.pnlAdd.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.pnlAdd.Controls.Add(Me.Label5)
        Me.pnlAdd.Location = New System.Drawing.Point(717, 458)
        Me.pnlAdd.Name = "pnlAdd"
        Me.pnlAdd.Size = New System.Drawing.Size(121, 31)
        Me.pnlAdd.TabIndex = 11
        Me.pnlAdd.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label5.Location = New System.Drawing.Point(8, 7)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(85, 16)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "ADD BOOKS"
        '
        'pnlEdit
        '
        Me.pnlEdit.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.pnlEdit.Controls.Add(Me.Label6)
        Me.pnlEdit.Location = New System.Drawing.Point(717, 507)
        Me.pnlEdit.Name = "pnlEdit"
        Me.pnlEdit.Size = New System.Drawing.Size(121, 31)
        Me.pnlEdit.TabIndex = 13
        Me.pnlEdit.Visible = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label6.Location = New System.Drawing.Point(8, 7)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(83, 16)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "EDIT BOOKS"
        '
        'pnlRemove
        '
        Me.pnlRemove.BackColor = System.Drawing.Color.FromArgb(CType(CType(194, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(7, Byte), Integer))
        Me.pnlRemove.Controls.Add(Me.Label7)
        Me.pnlRemove.Location = New System.Drawing.Point(717, 556)
        Me.pnlRemove.Name = "pnlRemove"
        Me.pnlRemove.Size = New System.Drawing.Size(121, 31)
        Me.pnlRemove.TabIndex = 14
        Me.pnlRemove.Visible = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label7.Location = New System.Drawing.Point(8, 7)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(111, 16)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "REMOVE BOOKS"
        '
        'pnlDetails_fg
        '
        Me.pnlDetails_fg.Controls.Add(Me.txtISBN)
        Me.pnlDetails_fg.Controls.Add(Me.txtDatePub)
        Me.pnlDetails_fg.Controls.Add(Me.txtTotal)
        Me.pnlDetails_fg.Controls.Add(Me.Label1)
        Me.pnlDetails_fg.Controls.Add(Me.Label3)
        Me.pnlDetails_fg.Controls.Add(Me.Label4)
        Me.pnlDetails_fg.Location = New System.Drawing.Point(625, 218)
        Me.pnlDetails_fg.Name = "pnlDetails_fg"
        Me.pnlDetails_fg.Size = New System.Drawing.Size(258, 136)
        Me.pnlDetails_fg.TabIndex = 15
        '
        'pnlDetails_bg
        '
        Me.pnlDetails_bg.BackColor = System.Drawing.SystemColors.ControlDark
        Me.pnlDetails_bg.Controls.Add(Me.Panel3)
        Me.pnlDetails_bg.Location = New System.Drawing.Point(621, 175)
        Me.pnlDetails_bg.Name = "pnlDetails_bg"
        Me.pnlDetails_bg.Size = New System.Drawing.Size(266, 182)
        Me.pnlDetails_bg.TabIndex = 16
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
        Me.Panel5.Location = New System.Drawing.Point(15, 175)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(600, 435)
        Me.Panel5.TabIndex = 17
        '
        'frmBooks
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.LMS_ELEC3KFAN.My.Resources.Resources.MainBG2
        Me.ClientSize = New System.Drawing.Size(899, 639)
        Me.Controls.Add(Me.pnlDetails_fg)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.lblSearch)
        Me.Controls.Add(Me.lviBooks)
        Me.Controls.Add(Me.cboSearch)
        Me.Controls.Add(Me.btnRemove)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.pnlRemove)
        Me.Controls.Add(Me.pnlEdit)
        Me.Controls.Add(Me.pnlAdd)
        Me.Controls.Add(Me.pnlDetails_bg)
        Me.Controls.Add(Me.Panel5)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmBooks"
        Me.Text = "frmBooks"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.pnlAdd.ResumeLayout(False)
        Me.pnlAdd.PerformLayout()
        Me.pnlEdit.ResumeLayout(False)
        Me.pnlEdit.PerformLayout()
        Me.pnlRemove.ResumeLayout(False)
        Me.pnlRemove.PerformLayout()
        Me.pnlDetails_fg.ResumeLayout(False)
        Me.pnlDetails_fg.PerformLayout()
        Me.pnlDetails_bg.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnRemove As Button
    Friend WithEvents cboSearch As ComboBox
    Friend WithEvents txtTotal As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtDatePub As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtISBN As TextBox
    Friend WithEvents lviBooks As ListView
    Friend WithEvents ColumnHeader6 As ColumnHeader
    Friend WithEvents ColumnHeader7 As ColumnHeader
    Friend WithEvents ColumnHeader8 As ColumnHeader
    Friend WithEvents ColumnHeader9 As ColumnHeader
    Friend WithEvents ColumnHeader10 As ColumnHeader
    Friend WithEvents lblSearch As Label
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents pnlAdd As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents pnlEdit As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents pnlRemove As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents pnlDetails_fg As Panel
    Friend WithEvents pnlDetails_bg As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label9 As Label
End Class
