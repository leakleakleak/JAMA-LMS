<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmAccount
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
        Me.pbAccounts = New System.Windows.Forms.PictureBox()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.btnRemove = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.lvwAccts = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.cboSearch = New System.Windows.Forms.ComboBox()
        Me.pnlRemove = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.pnlEdit = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.pnlAdd = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblSearch = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        CType(Me.pbAccounts, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlRemove.SuspendLayout()
        Me.pnlEdit.SuspendLayout()
        Me.pnlAdd.SuspendLayout()
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
        Me.Label2.Size = New System.Drawing.Size(116, 25)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "ACCOUNTS"
        '
        'pbAccounts
        '
        Me.pbAccounts.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pbAccounts.Location = New System.Drawing.Point(719, 126)
        Me.pbAccounts.Name = "pbAccounts"
        Me.pbAccounts.Size = New System.Drawing.Size(140, 136)
        Me.pbAccounts.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbAccounts.TabIndex = 4
        Me.pbAccounts.TabStop = False
        '
        'txtSearch
        '
        Me.txtSearch.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtSearch.Location = New System.Drawing.Point(427, 126)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(245, 23)
        Me.txtSearch.TabIndex = 9
        Me.txtSearch.Visible = False
        '
        'btnRemove
        '
        Me.btnRemove.BackColor = System.Drawing.Color.FromArgb(CType(CType(194, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(7, Byte), Integer))
        Me.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRemove.Image = Global.LMS_ELEC3KFAN.My.Resources.Resources.iconRemove
        Me.btnRemove.Location = New System.Drawing.Point(837, 549)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(44, 43)
        Me.btnRemove.TabIndex = 6
        Me.btnRemove.UseVisualStyleBackColor = False
        '
        'btnEdit
        '
        Me.btnEdit.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEdit.Image = Global.LMS_ELEC3KFAN.My.Resources.Resources.iconEdit
        Me.btnEdit.Location = New System.Drawing.Point(837, 500)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(44, 43)
        Me.btnEdit.TabIndex = 7
        Me.btnEdit.UseVisualStyleBackColor = False
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdd.Image = Global.LMS_ELEC3KFAN.My.Resources.Resources.iconAdd
        Me.btnAdd.Location = New System.Drawing.Point(837, 451)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(44, 43)
        Me.btnAdd.TabIndex = 8
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'lvwAccts
        '
        Me.lvwAccts.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader7})
        Me.lvwAccts.Font = New System.Drawing.Font("Century Gothic", 8.25!)
        Me.lvwAccts.FullRowSelect = True
        Me.lvwAccts.HideSelection = False
        Me.lvwAccts.Location = New System.Drawing.Point(12, 157)
        Me.lvwAccts.Name = "lvwAccts"
        Me.lvwAccts.Size = New System.Drawing.Size(660, 452)
        Me.lvwAccts.TabIndex = 10
        Me.lvwAccts.UseCompatibleStateImageBehavior = False
        Me.lvwAccts.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "ID"
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "NAME"
        Me.ColumnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader2.Width = 155
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "CONTACT NO."
        Me.ColumnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader3.Width = 169
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "ADDRESS"
        Me.ColumnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader4.Width = 407
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "USERNAME"
        Me.ColumnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "PASSWORD"
        Me.ColumnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "PHOTODIRECTORY"
        Me.ColumnHeader7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cboSearch
        '
        Me.cboSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboSearch.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.cboSearch.FormattingEnabled = True
        Me.cboSearch.Location = New System.Drawing.Point(12, 126)
        Me.cboSearch.Name = "cboSearch"
        Me.cboSearch.Size = New System.Drawing.Size(121, 25)
        Me.cboSearch.TabIndex = 12
        '
        'pnlRemove
        '
        Me.pnlRemove.BackColor = System.Drawing.Color.FromArgb(CType(CType(194, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(7, Byte), Integer))
        Me.pnlRemove.Controls.Add(Me.Label7)
        Me.pnlRemove.Location = New System.Drawing.Point(694, 556)
        Me.pnlRemove.Name = "pnlRemove"
        Me.pnlRemove.Size = New System.Drawing.Size(144, 31)
        Me.pnlRemove.TabIndex = 17
        Me.pnlRemove.Visible = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label7.Location = New System.Drawing.Point(8, 7)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(131, 16)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "REMOVE ACCOUNT"
        '
        'pnlEdit
        '
        Me.pnlEdit.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.pnlEdit.Controls.Add(Me.Label6)
        Me.pnlEdit.Location = New System.Drawing.Point(694, 507)
        Me.pnlEdit.Name = "pnlEdit"
        Me.pnlEdit.Size = New System.Drawing.Size(144, 31)
        Me.pnlEdit.TabIndex = 16
        Me.pnlEdit.Visible = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label6.Location = New System.Drawing.Point(8, 7)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(103, 16)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "EDIT ACCOUNT"
        '
        'pnlAdd
        '
        Me.pnlAdd.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.pnlAdd.Controls.Add(Me.Label5)
        Me.pnlAdd.Location = New System.Drawing.Point(694, 458)
        Me.pnlAdd.Name = "pnlAdd"
        Me.pnlAdd.Size = New System.Drawing.Size(144, 31)
        Me.pnlAdd.TabIndex = 15
        Me.pnlAdd.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label5.Location = New System.Drawing.Point(8, 7)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(105, 16)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "ADD ACCOUNT"
        '
        'lblSearch
        '
        Me.lblSearch.AutoSize = True
        Me.lblSearch.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.lblSearch.Location = New System.Drawing.Point(355, 129)
        Me.lblSearch.Name = "lblSearch"
        Me.lblSearch.Size = New System.Drawing.Size(66, 17)
        Me.lblSearch.TabIndex = 18
        Me.lblSearch.Text = "SEARCH: "
        Me.lblSearch.Visible = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Panel2.Location = New System.Drawing.Point(715, 122)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(148, 145)
        Me.Panel2.TabIndex = 19
        '
        'frmAccount
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.BackgroundImage = Global.LMS_ELEC3KFAN.My.Resources.Resources.MainBG2
        Me.ClientSize = New System.Drawing.Size(899, 639)
        Me.Controls.Add(Me.lblSearch)
        Me.Controls.Add(Me.cboSearch)
        Me.Controls.Add(Me.lvwAccts)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.btnRemove)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.pbAccounts)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.pnlRemove)
        Me.Controls.Add(Me.pnlEdit)
        Me.Controls.Add(Me.pnlAdd)
        Me.Controls.Add(Me.Panel2)
        Me.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmAccount"
        Me.Text = "frmAccount"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.pbAccounts, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlRemove.ResumeLayout(False)
        Me.pnlRemove.PerformLayout()
        Me.pnlEdit.ResumeLayout(False)
        Me.pnlEdit.PerformLayout()
        Me.pnlAdd.ResumeLayout(False)
        Me.pnlAdd.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents pbAccounts As PictureBox
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents btnRemove As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents lvwAccts As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents cboSearch As ComboBox
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents ColumnHeader6 As ColumnHeader
    Friend WithEvents ColumnHeader7 As ColumnHeader
    Friend WithEvents pnlRemove As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents pnlEdit As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents pnlAdd As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents lblSearch As Label
    Friend WithEvents Panel2 As Panel
End Class
