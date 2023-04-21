Imports System.Security.Cryptography
Imports System.Text

Public Class frmLogin

#Region "HASH SHA 256"
    'Gagamitin na encrpytion para sa Log In
    'Shared Function GetHash(theInput As String) As String
    '    Using hasher As SHA256 = SHA256.Create()    ' create hash object

    '        ' Convert to byte array and get hash
    '        Dim dbytes As Byte() =
    '             hasher.ComputeHash(Encoding.UTF8.GetBytes(theInput))

    '        ' sb to create string from bytes
    '        Dim sBuilder As New StringBuilder()

    '        ' convert byte data to hex string
    '        For n As Integer = 0 To dbytes.Length - 1
    '            sBuilder.Append(dbytes(n).ToString("X2"))
    '        Next n

    '        Return sBuilder.ToString()

    '    End Using
    'End Function

#End Region


    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        openServer()
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        retrieveRecord("SELECT Username, Passcode FROM tblAccount 
                        WHERE Username = '" & txtUser.Text & "' AND Passcode = '" & GetHash(txtPass.Text) & "'")

        If ds.Tables("a").Rows.Count > 0 Then
            MsgBox("Succesfully Logged In!")
            frmMain.Show()
            Me.Hide()

            frmMain.btnDashboard.PerformClick()
        Else
            MsgBox("Invalid username and password!")
        End If

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub


    Private Sub txtUser_Enter(sender As Object, e As EventArgs) Handles txtUser.Enter
        txtUser.ForeColor = SystemColors.ControlText
        If txtUser.Text = "Username" Then
            txtUser.Text = ""
        End If
    End Sub

    Private Sub txtUser_Leave(sender As Object, e As EventArgs) Handles txtUser.Leave
        If String.IsNullOrEmpty(txtUser.Text) Then
            txtUser.ForeColor = SystemColors.ControlDarkDark
            txtUser.Text = "Username"
        End If
    End Sub

    Private Sub txtPass_Enter(sender As Object, e As EventArgs) Handles txtPass.Enter
        txtPass.ForeColor = SystemColors.ControlText
        If txtPass.Text = "Password" Then
            txtPass.Text = ""
            txtPass.PasswordChar = "•"
        End If

    End Sub

    Private Sub txtPass_Leave(sender As Object, e As EventArgs) Handles txtPass.Leave
        If String.IsNullOrEmpty(txtPass.Text) Then
            txtPass.ForeColor = SystemColors.ControlDarkDark
            txtPass.Text = "Password"
            txtPass.PasswordChar = ""
        End If
    End Sub

    Private Sub txtPass_TextChanged(sender As Object, e As EventArgs) Handles txtPass.TextChanged

    End Sub
End Class