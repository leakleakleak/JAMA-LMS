Public Class frmAccount_Edit
    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim c As Control
        Dim emptyboxCounter As Boolean
        For Each c In Me.pnlDetails.Controls
            If TypeName(c) = "TextBox" Then
                If c.Text = "" Then
                    emptyboxCounter = True
                End If
            End If
        Next

        If emptyboxCounter Then
            MsgBox("Please fill all the fields!", MsgBoxStyle.Exclamation)
        Else

            AddEditDeleteRecord("UPDATE tblAccount SET FullName ='" & txtName.Text & "'," & "ContactNumber='" & txtContact.Text & "', Address='" & txtAddress.Text & "', Username='" & txtUser.Text & "', Passcode='" & GetHash(txtPass.Text) & "', PhotoDirectory='" & pbUser.Tag.ToString & "' WHERE LibID = '" & lblLibID.Text & "'")

            MsgBox("Book Issued!", vbOKOnly + vbInformation, "SUCCESS")
            Me.Close()
            frmAccount.ShowAccts()
        End If
    End Sub

    Private Sub btnUpload_Click(sender As Object, e As EventArgs) Handles btnUpload.Click
        Dim OpenFD As New OpenFileDialog

        OpenFD.Filter = "All Files|*.*|Bitmaps|*.bmp|GIFs|*.gif|JPEGs|*.jpg"

        If OpenFD.ShowDialog = DialogResult.OK Then
            Dim str() As String = OpenFD.FileName.Split("\\")
            Dim imgDir As String = "Resource\\" + str(str.Length - 1)
            btnUpload.Tag = OpenFD.FileName
            pbUser.Tag = imgDir
            pbUser.Image = Image.FromFile(OpenFD.FileName)
            pbUser.Refresh()
        End If

    End Sub

    Private Sub frmAccount_Edit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If frmAccount.lvwAccts.SelectedItems.Count > 0 Then
            pbUser.Image = Image.FromFile(frmAccount.lvwAccts.Items(frmAccount.lvwAccts.FocusedItem.Index).SubItems(6).Text)
            pbUser.Refresh()
            pbUser.Tag = frmAccount.lvwAccts.Items(frmAccount.lvwAccts.FocusedItem.Index).SubItems(6).Text
        End If
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class