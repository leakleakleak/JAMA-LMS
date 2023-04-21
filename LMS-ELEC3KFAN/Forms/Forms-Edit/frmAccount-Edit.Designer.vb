<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmAccount_Edit
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtContact = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnUpload = New System.Windows.Forms.Button()
        Me.txtPass = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtUser = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblLibID = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.pbUser = New System.Windows.Forms.PictureBox()
        Me.pnlDetails = New System.Windows.Forms.Panel()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        CType(Me.pbUser, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlDetails.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(96, 269)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "NAME:"
        '
        'txtName
        '
        Me.txtName.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.Location = New System.Drawing.Point(153, 266)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(216, 23)
        Me.txtName.TabIndex = 1
        '
        'txtContact
        '
        Me.txtContact.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtContact.Location = New System.Drawing.Point(153, 301)
        Me.txtContact.MaxLength = 11
        Me.txtContact.Name = "txtContact"
        Me.txtContact.Size = New System.Drawing.Size(153, 23)
        Me.txtContact.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(47, 304)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "CONTACT NO:"
        '
        'btnUpdate
        '
        Me.btnUpdate.BackColor = System.Drawing.Color.RoyalBlue
        Me.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpdate.Image = Global.LMS_ELEC3KFAN.My.Resources.Resources.iconSave
        Me.btnUpdate.Location = New System.Drawing.Point(390, 443)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(44, 43)
        Me.btnUpdate.TabIndex = 6
        Me.btnUpdate.UseVisualStyleBackColor = False
        '
        'btnUpload
        '
        Me.btnUpload.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.btnUpload.Location = New System.Drawing.Point(168, 189)
        Me.btnUpload.Name = "btnUpload"
        Me.btnUpload.Size = New System.Drawing.Size(132, 32)
        Me.btnUpload.TabIndex = 7
        Me.btnUpload.Text = "UPLOAD PHOTO"
        Me.btnUpload.UseVisualStyleBackColor = True
        '
        'txtPass
        '
        Me.txtPass.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPass.Location = New System.Drawing.Point(153, 434)
        Me.txtPass.Name = "txtPass"
        Me.txtPass.Size = New System.Drawing.Size(165, 23)
        Me.txtPass.TabIndex = 11
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label3.Location = New System.Drawing.Point(68, 437)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(83, 16)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "PASSWORD:"
        '
        'txtUser
        '
        Me.txtUser.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUser.Location = New System.Drawing.Point(153, 402)
        Me.txtUser.Name = "txtUser"
        Me.txtUser.Size = New System.Drawing.Size(165, 23)
        Me.txtUser.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label4.Location = New System.Drawing.Point(66, 405)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(81, 16)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "USERNAME:"
        '
        'txtAddress
        '
        Me.txtAddress.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAddress.Location = New System.Drawing.Point(153, 335)
        Me.txtAddress.Multiline = True
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(216, 56)
        Me.txtAddress.TabIndex = 13
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label5.Location = New System.Drawing.Point(79, 335)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(69, 16)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "ADDRESS:"
        '
        'lblLibID
        '
        Me.lblLibID.AutoSize = True
        Me.lblLibID.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLibID.Location = New System.Drawing.Point(154, 238)
        Me.lblLibID.Name = "lblLibID"
        Me.lblLibID.Size = New System.Drawing.Size(17, 17)
        Me.lblLibID.TabIndex = 17
        Me.lblLibID.Text = "#"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label6.Location = New System.Drawing.Point(67, 238)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(81, 16)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "LIBRARY ID:"
        '
        'pbUser
        '
        Me.pbUser.BackColor = System.Drawing.SystemColors.ControlDark
        Me.pbUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pbUser.Location = New System.Drawing.Point(168, 72)
        Me.pbUser.Name = "pbUser"
        Me.pbUser.Size = New System.Drawing.Size(132, 106)
        Me.pbUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbUser.TabIndex = 18
        Me.pbUser.TabStop = False
        '
        'pnlDetails
        '
        Me.pnlDetails.BackColor = System.Drawing.SystemColors.Control
        Me.pnlDetails.Controls.Add(Me.btnClose)
        Me.pnlDetails.Controls.Add(Me.Panel2)
        Me.pnlDetails.Controls.Add(Me.pbUser)
        Me.pnlDetails.Controls.Add(Me.txtPass)
        Me.pnlDetails.Controls.Add(Me.lblLibID)
        Me.pnlDetails.Controls.Add(Me.Label1)
        Me.pnlDetails.Controls.Add(Me.Label6)
        Me.pnlDetails.Controls.Add(Me.Label2)
        Me.pnlDetails.Controls.Add(Me.txtName)
        Me.pnlDetails.Controls.Add(Me.btnUpdate)
        Me.pnlDetails.Controls.Add(Me.txtContact)
        Me.pnlDetails.Controls.Add(Me.btnUpload)
        Me.pnlDetails.Controls.Add(Me.txtAddress)
        Me.pnlDetails.Controls.Add(Me.Label4)
        Me.pnlDetails.Controls.Add(Me.Label5)
        Me.pnlDetails.Controls.Add(Me.txtUser)
        Me.pnlDetails.Controls.Add(Me.Label3)
        Me.pnlDetails.Location = New System.Drawing.Point(5, 6)
        Me.pnlDetails.Name = "pnlDetails"
        Me.pnlDetails.Size = New System.Drawing.Size(448, 498)
        Me.pnlDetails.TabIndex = 19
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
        Me.btnClose.TabIndex = 20
        Me.btnClose.Text = "X"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Location = New System.Drawing.Point(0, 8)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(188, 44)
        Me.Panel2.TabIndex = 19
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Uni Sans Demo Heavy CAPS", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(11, 10)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(150, 25)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "EDIT ACCOUNT"
        '
        'frmAccount_Edit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDark
        Me.ClientSize = New System.Drawing.Size(458, 508)
        Me.Controls.Add(Me.pnlDetails)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmAccount_Edit"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Account: Edit form"
        CType(Me.pbUser, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlDetails.ResumeLayout(False)
        Me.pnlDetails.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtContact As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnUpload As Button
    Friend WithEvents txtPass As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtUser As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents lblLibID As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents pbUser As PictureBox
    Friend WithEvents pnlDetails As Panel
    Friend WithEvents btnClose As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label8 As Label
End Class