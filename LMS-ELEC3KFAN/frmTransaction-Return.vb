Public Class ReturnForm
    Private Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
        'for issue
        If btnReturn.Text = "ADD" Then

            'initialize a collection of listview item 
            Dim numbers As New ListViewItem(frmIssue_Add.lviBooks.SelectedItems.Item(0).Text, 0)

            'add the subitems via loop
            With numbers
                For i As Integer = 1 To 2

                    .SubItems.Add(frmIssue_Add.lviBooks.SelectedItems.Item(0).SubItems(i).Text)

                Next
                .SubItems.Add(npdReturnValue.Value)
            End With

            'then finally pass it to the lviIssue
            frmIssue_Add.lviIssue.Items.Add(numbers)

            'if all the books are issued
            Dim Quantity As Integer
            Quantity = frmIssue_Add.lviBooks.SelectedItems.Item(0).SubItems(7).Text - npdReturnValue.Value
            frmIssue_Add.lviBooks.SelectedItems.Item(0).SubItems(7).Text = Quantity
            If Quantity = 0 Then
                For Each i As ListViewItem In frmIssue_Add.lviBooks.SelectedItems
                    frmIssue_Add.lviBooks.Items.Remove(i)
                Next
            End If
            Me.Close()
            'for return
        Else


            Dim transacid As String = Me.lblID.Text
            Dim bookID As String
            Dim addedReturnQty As String = npdReturnValue.Value
            Dim prevReturnQty As Integer
            Dim lviQty As Integer = addedReturnQty
            Dim Qty As Integer

            With frmTransaction.lviBooks
                bookID = .Items(.FocusedItem.Index).SubItems(0).Text
            End With
            '-------------------------------------------------------------
            '                    tblTransaction_header
            '-------------------------------------------------------------
            '----------------------------------GET the latest ReturnedQty and 
            datareader("SELECT ReturnedQty, Quantity FROM tblTransaction_Header WHERE TransactionID = '" & transacid & "' AND BookID ='" & bookID & "'")

            While dr.Read
                prevReturnQty = dr.Item("ReturnedQty")
                Qty = dr.Item("Quantity")
            End While

            lviQty += prevReturnQty

            '-------------------------------------------------------------
            '---------------------------------ADD the qty that is returned
            AddEditDeleteRecord("UPDATE tblTransaction_Header SET ReturnedQty = '" & lviQty & "' WHERE TransactionID = '" & transacid & "' AND BookID ='" & bookID & "'")

            Qty -= addedReturnQty

            '-------------------------------------------------------------
            '                           tblBook
            '-------------------------------------------------------------
            '---------------------------------GET the totalcopies 
            datareader("SELECT TotalCopies FROM tblBook WHERE BookID= '" & bookID & "'")
            Dim totalCopies As Integer
            While dr.Read
                totalCopies = dr.Item("TotalCopies")
            End While

            totalCopies += CInt(addedReturnQty)
            '-------------------------------------------------------------
            '---------------------------------'RETURN the qty of the books
            AddEditDeleteRecord("UPDATE tblBook SET TotalCopies = '" & totalCopies & "' WHERE BookID='" & bookID & "'")



            '-------------------------------------------------------------
            '---------------------------------'UPDATE if isReturned is true
            If Qty = prevReturnQty Then
                AddEditDeleteRecord("UPDATE tblTransaction_Header SET isReturned = YES WHERE TransactionID = '" & transacid & "' AND BookID ='" & bookID & "'")
            End If

            '-------------------------------------------------------------
            '---------------------------------'UPDATE if isReturned is true
            datareader("SELECT isReturned FROM tblTransaction_Header WHERE TransactionID= '" & transacid & "'")
            Dim yesCounter As Integer
            Dim totalCount As Integer
            While dr.Read
                totalCount += 1
                If dr.Item("isReturned") = Boolean.TrueString Then
                    yesCounter += 1
                End If
            End While

            If yesCounter = totalCount Then
                AddEditDeleteRecord("UPDATE tblTransaction_Details SET Status = 'Returned', DateReturned ='" & Date.Now.ToShortDateString & "' WHERE TransactionID = '" & transacid & "'")
            End If
            Me.Close()

            Dim Index As Integer = frmTransaction.lviTransaction.FocusedItem.Index
            frmTransaction.bookLoad()
            frmTransaction.TransactionLoad()
            frmTransaction.lviTransaction.Items(Index).Selected = True

        End If
    End Sub

    Private Sub ReturnForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class