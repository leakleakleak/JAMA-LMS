Public Class frmBooks_Add
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

        Dim txt As Control
        Dim emptyCount As Integer = 0
        For Each txt In Panel2.Controls
            If TypeOf txt Is TextBox Then
                If String.IsNullOrEmpty(txt.Text) Then
                    emptyCount += 1
                End If
            End If
        Next

        If emptyCount > 0 Then
            MsgBox("Please fill all the fields", vbOKOnly + vbExclamation, "Warning")
        Else
            datareader("SELECT Num FROM tblBook ORDER BY Num ASC")
            Dim latestBookID As String = ""

            While dr.Read
                latestBookID = "B" + (1 + dr.Item("Num")).ToString
            End While

            AddEditDeleteRecord("INSERT INTO tblBook (Title, Category, Author, TotalCopies, Publisher, ISBN, DatePublished, BookID) VALUES ('" & txtTitle.Text & "','" & txtCategory.Text & "','" & txtAuthor.Text & "','" & txtCopies.Text & "','" & txtPublisher.Text & "','" & txtISBN.Text & "','" & txtDatePublished.Text & "','" & latestBookID & "')")
            MsgBox("Book Added!", vbOKOnly + vbInformation, "Success")
            frmBooks.BookLoad()
            Me.Close()
        End If

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class