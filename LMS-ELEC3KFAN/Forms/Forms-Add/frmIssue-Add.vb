Public Class frmIssue_Add

    Sub IssueAdd()
        datareader("SELECT BookID, Title, Author, Publisher, Category, DatePublished, ISBN, TotalCopies FROM tblBook WHERE TotalCopies <> 0")
        lviBooks.Items.Clear()


        While dr.Read
            Dim item As New ListViewItem(dr.Item("BookID").ToString, 0)
            item.SubItems.Add(dr.Item("Title"))
            item.SubItems.Add(dr.Item("Author"))
            item.SubItems.Add(dr.Item("Publisher"))
            item.SubItems.Add(dr.Item("Category"))
            item.SubItems.Add(dr.Item("DatePublished"))
            item.SubItems.Add(dr.Item("ISBN"))
            item.SubItems.Add(dr.Item("TotalCopies"))
            lviBooks.Items.Add(item)
        End While



        'datareader("SELECT * FROM tblTransaction WHERE Status = 'Issued'")
        'lviBooks.Items.Clear()

        'While dr.Read
        '    Dim item As New ListViewItem(dr.Item("TransactionID").ToString, 0)
        '    item.SubItems.Add(dr.Item("DateIssued"))
        '    item.SubItems.Add(dr.Item("DueDate"))
        '    item.SubItems.Add(dr.Item("DateReturned"))
        '    item.SubItems.Add(dr.Item("StudentID"))
        '    item.SubItems.Add(dr.Item("StudentName"))
        '    item.SubItems.Add(dr.Item("GradeAndSection"))
        '    item.SubItems.Add(dr.Item("RecordID"))
        '    item.SubItems.Add(dr.Item("TotalCopies"))
        '    item.SubItems.Add(dr.Item("LibID"))
        '    item.SubItems.Add(dr.Item("Status"))
        '    lviBooks.Items.Add(item)
        'End While



        'datareader("SELECT * FROM tblTransaction WHERE Status = 'Returned'")
        'lviBooks.Items.Clear()

        'While dr.Read
        '    Dim item As New ListViewItem(dr.Item("TransactionID").ToString, 0)
        '    item.SubItems.Add(dr.Item("DateIssued"))
        '    item.SubItems.Add(dr.Item("DueDate"))
        '    item.SubItems.Add(dr.Item("DateReturned"))
        '    item.SubItems.Add(dr.Item("StudentID"))
        '    item.SubItems.Add(dr.Item("StudentName"))
        '    item.SubItems.Add(dr.Item("GradeAndSection"))
        '    item.SubItems.Add(dr.Item("RecordID"))
        '    item.SubItems.Add(dr.Item("TotalCopies"))
        '    item.SubItems.Add(dr.Item("LibID"))
        '    item.SubItems.Add(dr.Item("Status"))
        '    lviBooks.Items.Add(item)
        'End While



    End Sub



    '///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    Private Sub btnIssue_Click(sender As Object, e As EventArgs) Handles btnIssue.Click

        If lviIssue.Items.Count > 0 Then

            Dim GradeAndSection = "Grade " & txtGrade.Text & " - " & txtSection.Text
            Dim txt As Control
            Dim emptyCount As Integer = 0
            For Each txt In Me.pnlDetails.Controls
                If TypeOf txt Is TextBox Then
                    If String.IsNullOrEmpty(txt.Text) Then
                        emptyCount += 1
                    End If
                End If
            Next

            If emptyCount > 0 Then
                MsgBox("Please fill all the fields", vbOKOnly + vbExclamation, "Warning")
            Else
                datareader("SELECT Num FROM tblTransaction_Details ORDER BY Num ASC")
                Dim transacid As String = ""

                While dr.Read
                    transacid = "T" + (1 + dr.Item("Num")).ToString
                End While
                '////////////////   QUERY   \\\\\\\\\\\\\\\\\\\\\\\\\\\\\
                AddEditDeleteRecord("INSERT INTO tblTransaction_Details (TransactionID, DateIssued, DueDate,  StudentID, StudentName, GradeAndSection, DateReturned, Status)
                VALUES ( '" & transacid & "','" & Date.Now.ToShortDateString & "','" & txtDueDate.Text & "','" & txtStudentID.Text & "','" & txtStudentName.Text & "','" & GradeAndSection & "','---','Issued')")

                For i As Integer = 0 To lviIssue.Items.Count - 1
                    Dim bookID As String = lviIssue.Items(i).SubItems(0).Text

                    AddEditDeleteRecord("INSERT INTO tblTransaction_Header (TransactionID,BookID, Quantity, ReturnedQty) VALUES ('" & transacid & "','" & bookID & "','" & lviIssue.Items(i).SubItems(3).Text & "','0')")


                    'get totalcopies
                    datareader("SELECT TotalCopies FROM tblBook WHERE BookID= '" & bookID & "'")
                    Dim totalCopies As Integer
                    While dr.Read
                        totalCopies = dr.Item("TotalCopies")
                    End While
                    totalCopies -= lviIssue.Items(i).SubItems(3).Text
                    AddEditDeleteRecord("UPDATE tblBook SET TotalCopies = '" & totalCopies & "' WHERE BookID='" & bookID & "'")

                Next


                MsgBox("Book Issued!", vbOKOnly + vbInformation, "SUCCESS")
                For Each txt In Me.pnlDetails.Controls
                    If TypeOf txt Is TextBox Then
                        txt.Text = ""
                    End If
                Next
                btnClear.PerformClick()

                frmTransaction.TransactionLoad()
                Me.Close()
            End If
        Else
            MsgBox("Add an item first!", vbOKOnly + vbExclamation, "INVALID")
        End If
    End Sub

    Private Sub frmIssue_Add_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        IssueAdd()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

        If lviBooks.SelectedItems.Count > 0 Then
            ReturnForm.btnReturn.Text = "ADD"
            ReturnForm.npdReturnValue.Value = lviBooks.SelectedItems.Item(0).SubItems(7).Text
            ReturnForm.npdReturnValue.Maximum = lviBooks.SelectedItems.Item(0).SubItems(7).Text
            ReturnForm.Show()
        End If

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        lviIssue.Items.Clear()
        IssueAdd()
    End Sub


End Class