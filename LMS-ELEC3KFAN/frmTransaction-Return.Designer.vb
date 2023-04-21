<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReturnForm
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
        Me.btnReturn = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.npdReturnValue = New System.Windows.Forms.NumericUpDown()
        Me.lblID = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnClose = New System.Windows.Forms.Button()
        CType(Me.npdReturnValue, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnReturn
        '
        Me.btnReturn.BackColor = System.Drawing.Color.RoyalBlue
        Me.btnReturn.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReturn.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReturn.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnReturn.Location = New System.Drawing.Point(254, 35)
        Me.btnReturn.Name = "btnReturn"
        Me.btnReturn.Size = New System.Drawing.Size(75, 38)
        Me.btnReturn.TabIndex = 1
        Me.btnReturn.Text = "BUTTON"
        Me.btnReturn.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(36, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(101, 17)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "No. of Copies:"
        '
        'npdReturnValue
        '
        Me.npdReturnValue.Location = New System.Drawing.Point(143, 46)
        Me.npdReturnValue.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.npdReturnValue.Name = "npdReturnValue"
        Me.npdReturnValue.Size = New System.Drawing.Size(95, 20)
        Me.npdReturnValue.TabIndex = 4
        Me.npdReturnValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.npdReturnValue.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'lblID
        '
        Me.lblID.AutoSize = True
        Me.lblID.Location = New System.Drawing.Point(17, 13)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(35, 13)
        Me.lblID.TabIndex = 3
        Me.lblID.Text = "TrID#"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel1.Controls.Add(Me.btnClose)
        Me.Panel1.Controls.Add(Me.lblID)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.npdReturnValue)
        Me.Panel1.Controls.Add(Me.btnReturn)
        Me.Panel1.Location = New System.Drawing.Point(4, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(382, 100)
        Me.Panel1.TabIndex = 5
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnClose.FlatAppearance.BorderSize = 0
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Font = New System.Drawing.Font("Uni Sans Demo Heavy CAPS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.Black
        Me.btnClose.Location = New System.Drawing.Point(344, -2)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(39, 37)
        Me.btnClose.TabIndex = 46
        Me.btnClose.Text = "X"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'ReturnForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDark
        Me.ClientSize = New System.Drawing.Size(391, 110)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ReturnForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "BookTitle"
        CType(Me.npdReturnValue, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnReturn As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents npdReturnValue As NumericUpDown
    Friend WithEvents lblID As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnClose As Button
End Class
