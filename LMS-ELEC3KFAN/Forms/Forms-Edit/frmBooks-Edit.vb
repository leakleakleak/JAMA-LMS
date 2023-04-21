Public Class frmBooks_Edit
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        Dim c As Control
        Dim emptyboxCounter As Boolean
        For Each c In Me.Panel2.Controls
            If TypeName(c) = "TextBox" Then
                If c.Text = "" Then
                    emptyboxCounter = True
                End If
            End If
        Next

        If emptyboxCounter Then
            MsgBox("Please fill all the fields!", MsgBoxStyle.Exclamation)
        Else
            AddEditDeleteRecord("UPDATE tblBook SET Title ='" & txtBookName.Text & "'," & "Author='" & txtAuthor.Text & "', Publisher='" & txtPubName.Text & "', Category='" & txtCat.Text & "', ISBN='" & txtISBN.Text & "', TotalCopies='" & txtCopies.Text & "', DatePublished='" & txtDatePublished.Text & "' WHERE BookID = '" & lblBookID.Text & "'")
            Me.Close()
            frmBooks.BookLoad()
            frmBooks.SearchOption()
        End If

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class