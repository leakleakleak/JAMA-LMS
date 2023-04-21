Public Class frmTransaction
    Private Sub btnIssueAdd_Click(sender As Object, e As EventArgs) Handles btnIssueAdd.Click
        frmIssue_Add.ShowDialog()
    End Sub


    Sub TransactionLoad()

        If cboShowList.SelectedIndex = 0 Then

            datareader("SELECT * FROM tblTransaction_Details")
            lviTransaction.Items.Clear()

            While dr.Read
                Dim item As New ListViewItem(dr.Item("TransactionID").ToString, 0)
                item.SubItems.Add(dr.Item("StudentID"))
                item.SubItems.Add(dr.Item("DateIssued"))
                item.SubItems.Add(dr.Item("DueDate"))
                item.SubItems.Add(dr.Item("DateReturned"))
                item.SubItems.Add(dr.Item("Status"))
                lviTransaction.Items.Add(item)
            End While

        ElseIf cboShowList.SelectedIndex = 1 Then

            datareader("SELECT * FROM tblTransaction_Details WHERE Status = 'Issued'")
            lviTransaction.Items.Clear()

            While dr.Read
                Dim item As New ListViewItem(dr.Item("TransactionID").ToString, 0)
                item.SubItems.Add(dr.Item("StudentID"))
                item.SubItems.Add(dr.Item("DateIssued"))
                item.SubItems.Add(dr.Item("DueDate"))
                item.SubItems.Add(dr.Item("DateReturned"))
                item.SubItems.Add(dr.Item("Status"))
                lviTransaction.Items.Add(item)
            End While

        ElseIf cboShowList.SelectedIndex = 2 Then

            datareader("SELECT * FROM tblTransaction_Details WHERE Status = 'Returned'")
            lviTransaction.Items.Clear()

            While dr.Read
                Dim item As New ListViewItem(dr.Item("TransactionID").ToString, 0)
                item.SubItems.Add(dr.Item("StudentID"))
                item.SubItems.Add(dr.Item("DateIssued"))
                item.SubItems.Add(dr.Item("DueDate"))
                item.SubItems.Add(dr.Item("DateReturned"))
                item.SubItems.Add(dr.Item("Status"))
                lviTransaction.Items.Add(item)
            End While
        End If


    End Sub

    Sub SearchOption()
        cboShowList.Items.Clear()
        cboShowList.Items.Insert(0, "ALL")
        cboShowList.Items.Add("ISSUED")
        cboShowList.Items.Add("RETURNED")
        cboShowList.SelectedIndex = 0
    End Sub
    Private Sub frmIssue_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TransactionLoad()
        SearchOption()
    End Sub

    Private Sub cboShowList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboShowList.SelectedIndexChanged
        TransactionLoad()
    End Sub

    Private Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
        If lviBooks.SelectedItems.Count > 0 Then

            ReturnForm.btnReturn.Text = "RETURN"
            ReturnForm.npdReturnValue.Maximum = lviBooks.SelectedItems.Item(0).SubItems(3).Text
            ReturnForm.npdReturnValue.Value = lviBooks.SelectedItems.Item(0).SubItems(3).Text
            ReturnForm.lblID.Text = lviTransaction.SelectedItems.Item(0).SubItems(0).Text
            ReturnForm.Text = lviBooks.SelectedItems.Item(0).SubItems(1).Text

            ReturnForm.ShowDialog()
        End If
    End Sub
    Sub bookLoad()
        lviBooks.Items.Clear()
        datareader("SELECT tblBook.BookID, tblBook.Title, tblBook.Author, tblTransaction_Header.Quantity, tblTransaction_Header.TransactionID, tblTransaction_Header.ReturnedQty FROM tblTransaction_Header INNER Join tblBook On tblTransaction_Header.BookID = tblBook.BookID WHERE TransactionID = '" & lviTransaction.SelectedItems.Item(0).Text & "' AND isReturned = NO")

        While dr.Read
            Dim resultQty As Integer = dr.Item("Quantity") - dr.Item("ReturnedQty")
            Dim item As New ListViewItem(dr.Item("BookID").ToString, 0)
            item.SubItems.Add(dr.Item("Title"))
            item.SubItems.Add(dr.Item("Author"))
            item.SubItems.Add(resultQty)
            lviBooks.Items.Add(item)
        End While
    End Sub

    Private Sub lviTransaction_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lviTransaction.SelectedIndexChanged
        If lviTransaction.SelectedIndices.Count > 0 Then
            bookLoad()
        End If
    End Sub

    Private Sub ButtonMouseHovered(sender As Object, e As EventArgs) Handles btnReturn.MouseHover, btnIssueAdd.MouseHover
        Dim btnHovered As Button = DirectCast(sender, Button)

        Select Case btnHovered.Name
            Case "btnIssueAdd"
                pnlLend.Visible = True
            Case "btnReturn"
                pnlReturn.Visible = True
        End Select
    End Sub

    Private Sub ButtonMouseLeave(sender As Object, e As EventArgs) Handles btnReturn.MouseLeave, btnIssueAdd.MouseLeave
        Dim btnLeave As Button = DirectCast(sender, Button)

        Select Case btnLeave.Name
            Case "btnIssueAdd"
                pnlLend.Visible = False
            Case "btnReturn"
                pnlReturn.Visible = False
        End Select
    End Sub

    Private Sub lviBooks_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lviBooks.SelectedIndexChanged
        If lviBooks.SelectedItems.Count > 0 Then
            btnReturn.Enabled = True
            btnReturn.BackColor = Color.Firebrick
        Else
            btnReturn.Enabled = False
            btnReturn.BackColor = Color.Gray
        End If
    End Sub

End Class

