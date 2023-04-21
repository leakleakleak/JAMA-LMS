Public Class frmReturn
    Sub returnLoad()
        datareader("SELECT TransactionID, DateIssued, DueDate, StudentID, BookID FROM tblTransaction_Details WHERE Status = 'Issued'")
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
    End Sub
    Private Sub frmReturn_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        returnLoad()
    End Sub
End Class