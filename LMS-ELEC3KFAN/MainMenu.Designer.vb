<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
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
        Me.pnlChoose = New System.Windows.Forms.Panel()
        Me.btnAccount = New System.Windows.Forms.Button()
        Me.btnIssue = New System.Windows.Forms.Button()
        Me.btnBooks = New System.Windows.Forms.Button()
        Me.btnDashboard = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.pnlHeader = New System.Windows.Forms.Panel()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.pnlMainMenu = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlHeader.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(106, Byte), Integer))
        Me.Panel1.Controls.Add(Me.pnlChoose)
        Me.Panel1.Controls.Add(Me.btnAccount)
        Me.Panel1.Controls.Add(Me.btnIssue)
        Me.Panel1.Controls.Add(Me.btnBooks)
        Me.Panel1.Controls.Add(Me.btnDashboard)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(164, 677)
        Me.Panel1.TabIndex = 0
        '
        'pnlChoose
        '
        Me.pnlChoose.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.pnlChoose.Location = New System.Drawing.Point(156, 113)
        Me.pnlChoose.Name = "pnlChoose"
        Me.pnlChoose.Size = New System.Drawing.Size(8, 35)
        Me.pnlChoose.TabIndex = 0
        '
        'btnAccount
        '
        Me.btnAccount.AccessibleName = "btnAccount"
        Me.btnAccount.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnAccount.FlatAppearance.BorderSize = 0
        Me.btnAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAccount.Font = New System.Drawing.Font("Uni Sans Demo Heavy CAPS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAccount.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnAccount.Image = Global.LMS_ELEC3KFAN.My.Resources.Resources.iconAccount
        Me.btnAccount.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAccount.Location = New System.Drawing.Point(0, 269)
        Me.btnAccount.Name = "btnAccount"
        Me.btnAccount.Size = New System.Drawing.Size(164, 52)
        Me.btnAccount.TabIndex = 5
        Me.btnAccount.Text = " ACCOUNT        "
        Me.btnAccount.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAccount.UseVisualStyleBackColor = True
        '
        'btnIssue
        '
        Me.btnIssue.AccessibleName = "btnIssue"
        Me.btnIssue.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnIssue.FlatAppearance.BorderSize = 0
        Me.btnIssue.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnIssue.Font = New System.Drawing.Font("Uni Sans Demo Heavy CAPS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnIssue.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnIssue.Image = Global.LMS_ELEC3KFAN.My.Resources.Resources.iconIssue
        Me.btnIssue.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnIssue.Location = New System.Drawing.Point(0, 217)
        Me.btnIssue.Name = "btnIssue"
        Me.btnIssue.Size = New System.Drawing.Size(164, 52)
        Me.btnIssue.TabIndex = 3
        Me.btnIssue.Text = " TRANSACTION"
        Me.btnIssue.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnIssue.UseVisualStyleBackColor = True
        '
        'btnBooks
        '
        Me.btnBooks.AccessibleName = "btnBooks"
        Me.btnBooks.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnBooks.FlatAppearance.BorderSize = 0
        Me.btnBooks.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBooks.Font = New System.Drawing.Font("Uni Sans Demo Heavy CAPS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBooks.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnBooks.Image = Global.LMS_ELEC3KFAN.My.Resources.Resources.iconBooks
        Me.btnBooks.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnBooks.Location = New System.Drawing.Point(0, 165)
        Me.btnBooks.Name = "btnBooks"
        Me.btnBooks.Size = New System.Drawing.Size(164, 52)
        Me.btnBooks.TabIndex = 2
        Me.btnBooks.Text = "  BOOKS             "
        Me.btnBooks.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnBooks.UseVisualStyleBackColor = True
        '
        'btnDashboard
        '
        Me.btnDashboard.AccessibleName = "btnDashboard"
        Me.btnDashboard.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnDashboard.FlatAppearance.BorderSize = 0
        Me.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDashboard.Font = New System.Drawing.Font("Uni Sans Demo Heavy CAPS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDashboard.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnDashboard.Image = Global.LMS_ELEC3KFAN.My.Resources.Resources.iconCategory
        Me.btnDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnDashboard.Location = New System.Drawing.Point(0, 113)
        Me.btnDashboard.Name = "btnDashboard"
        Me.btnDashboard.Size = New System.Drawing.Size(164, 52)
        Me.btnDashboard.TabIndex = 1
        Me.btnDashboard.Text = "  DASHBOARD"
        Me.btnDashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnDashboard.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PictureBox1.Image = Global.LMS_ELEC3KFAN.My.Resources.Resources.logo
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(164, 113)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'pnlHeader
        '
        Me.pnlHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.pnlHeader.Controls.Add(Me.btnClose)
        Me.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlHeader.Location = New System.Drawing.Point(164, 0)
        Me.pnlHeader.Name = "pnlHeader"
        Me.pnlHeader.Size = New System.Drawing.Size(899, 38)
        Me.pnlHeader.TabIndex = 2
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.btnClose.FlatAppearance.BorderSize = 0
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.Black
        Me.btnClose.Location = New System.Drawing.Point(860, 0)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(39, 37)
        Me.btnClose.TabIndex = 8
        Me.btnClose.Text = "X"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'pnlMainMenu
        '
        Me.pnlMainMenu.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.pnlMainMenu.BackgroundImage = Global.LMS_ELEC3KFAN.My.Resources.Resources.MainBG2
        Me.pnlMainMenu.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlMainMenu.Location = New System.Drawing.Point(164, 38)
        Me.pnlMainMenu.Name = "pnlMainMenu"
        Me.pnlMainMenu.Size = New System.Drawing.Size(899, 639)
        Me.pnlMainMenu.TabIndex = 3
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1063, 677)
        Me.Controls.Add(Me.pnlMainMenu)
        Me.Controls.Add(Me.pnlHeader)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlHeader.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnDashboard As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnAccount As Button
    Friend WithEvents btnIssue As Button
    Friend WithEvents btnBooks As Button
    Friend WithEvents pnlHeader As Panel
    Friend WithEvents btnClose As Button
    Friend WithEvents pnlMainMenu As Panel
    Friend WithEvents pnlChoose As Panel
End Class
