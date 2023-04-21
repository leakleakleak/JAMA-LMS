Public Class frmAccount_Add
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim txt As Control
        Dim emptyCount As Integer = 0
        For Each txt In Controls
            If TypeOf txt Is TextBox Then
                If String.IsNullOrEmpty(txt.Text) Then
                    emptyCount += 1
                End If
            End If
        Next

        If emptyCount > 0 Then
            MsgBox("Please fill all the fields", vbOKOnly + vbExclamation, "Warning")
        Else
            datareader("SELECT Num FROM tblAccount ORDER BY Num ASC")
            Dim latestAcctID As String = ""

            While dr.Read
                latestAcctID = "LibID" + (1 + dr.Item("Num")).ToString
            End While

            AddEditDeleteRecord("INSERT INTO tblAccount (FullName, ContactNumber, Address, Username, Passcode, LibID, PhotoDirectory) VALUES ('" & txtName.Text & "','" & txtContact.Text & "','" & txtAddress.Text & "','" & txtUser.Text & "','" & GetHash(txtPass.Text) & "','" & latestAcctID & "','" & pbUser.Tag.ToString & "')")

            'copy picture to local resources
            System.IO.File.Copy(btnUpload.Tag, pbUser.Tag)

            MsgBox("Account Added!", vbOKOnly + vbInformation, "Success")
            frmAccount.ShowAccts()
            Me.Close()
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

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class