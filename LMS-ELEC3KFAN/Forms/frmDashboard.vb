Public Class frmDashboard
    Private Sub frmDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        Dim counterBooks As Integer
        datareader("SELECT TotalCopies FROM tblBook")
        While dr.Read
            counterBooks += CInt(dr.Item("TotalCopies"))
        End While

        Dim counterIssue As Integer
        datareader("SELECT TransactionID FROM tblTransaction_Details WHERE Status = 'Issued'")
        While dr.Read
            counterIssue += 1
        End While

        Dim counterReturned As Integer
        datareader("SELECT TransactionID FROM tblTransaction_Details WHERE Status = 'Returned'")
        While dr.Read
            counterReturned += 1
        End While
        '--------------------------------------------
        '--------------------Output

        lblBook.Text = counterBooks
        lblIssue.Text = counterIssue
        lblReturned.Text = counterReturned

    End Sub
End Class