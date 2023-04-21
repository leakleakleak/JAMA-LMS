Public Class frmBooks

    Sub BookLoad()
        datareader("SELECT * FROM tblBook")
        lviBooks.Items.Clear()

        While dr.Read
            Dim item As New ListViewItem(dr.Item("BookID").ToString, 0)
            item.SubItems.Add(dr.Item("Title"))
            item.SubItems.Add(dr.Item("Author"))
            item.SubItems.Add(dr.Item("Publisher"))
            item.SubItems.Add(dr.Item("Category"))
            lviBooks.Items.Add(item)
        End While
    End Sub

    Sub ShowDetails()
        Dim index As Integer = lviBooks.FocusedItem.Index

        If lviBooks.SelectedItems.Count > 0 Then
            datareader("SELECT ISBN, TotalCopies, DatePublished FROM tblBook WHERE BookID ='" + lviBooks.Items(index).Text + "'")

            While dr.Read
                txtISBN.Text = dr.Item("ISBN")
                txtTotal.Text = dr.Item("TotalCopies").ToString
                txtDatePub.Text = dr.Item("DatePublished")
            End While
        End If
    End Sub

    Sub Search()
        Dim index As Integer = cboSearch.SelectedIndex
        Dim Options() As String = {"*", "Title", "Author", "Publisher", "Category"}

        If index > 0 Then

            datareader("SELECT BookID, Title, Author, Publisher, Category FROM tblBook 
                        WHERE " + Options(index) + " LIKE '%" + txtSearch.Text + "%'")
            lviBooks.Items.Clear()

            While dr.Read
                Dim item As New ListViewItem(dr.Item("BookID").ToString, 0)
                item.SubItems.Add(dr.Item("Title"))
                item.SubItems.Add(dr.Item("Author"))
                item.SubItems.Add(dr.Item("Publisher"))
                item.SubItems.Add(dr.Item("Category"))
                lviBooks.Items.Add(item)
            End While

        ElseIf index = 0 Or txtSearch.Text = "" Then
            BookLoad()
        End If
    End Sub

    Sub SearchOption()
        cboSearch.Items.Clear()
        cboSearch.Items.Insert(0, "ALL")
        cboSearch.SelectedIndex = 0
        cboSearch.Items.Add("TITLE")
        cboSearch.Items.Add("AUTHOR")
        cboSearch.Items.Add("PUBLISHER")
        cboSearch.Items.Add("CATEGORY")
    End Sub

    Sub RefreshControls()
        txtDatePub.Text = ""
        txtISBN.Text = ""
        txtTotal.Text = ""
        btnEdit.Enabled = False
        btnRemove.Enabled = False
        btnEdit.BackColor = Color.Gray
        btnRemove.BackColor = Color.Gray
        lviBooks.SelectedItems.Clear()
    End Sub

    Private Sub cboSearch_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboSearch.SelectedIndexChanged
        If cboSearch.SelectedIndex = 0 Then
            txtSearch.Visible = False
            lblSearch.Visible = False
        ElseIf cboSearch.SelectedIndex > 0 Then
            txtSearch.Visible = True
            lblSearch.Visible = True
            txtSearch.Text = ""
        End If
        RefreshControls()
    End Sub
    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Search()
    End Sub
    Private Sub frmBooks_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BookLoad()
        SearchOption()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        frmBooks_Add.ShowDialog()
    End Sub

    Private Sub lviBooks_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lviBooks.SelectedIndexChanged
        ShowDetails()
        If lviBooks.SelectedItems.Count > 0 Then
            btnEdit.Enabled = True
            btnRemove.Enabled = True
            btnEdit.BackColor = Color.FromArgb(253, 165, 15)
            btnRemove.BackColor = Color.FromArgb(194, 24, 7)
        Else
            btnEdit.Enabled = False
            btnRemove.Enabled = False
            btnEdit.BackColor = Color.Gray
            btnRemove.BackColor = Color.Gray
        End If
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If lviBooks.SelectedItems.Count > 0 Then
            frmBooks_Edit.ShowDialog()
            frmBooks_Edit.lblBookID.Text = lviBooks.SelectedItems.Item(0).Text

            Dim cBook As Control
            Dim cBookEdit As Control
            Dim panelText As String
            Dim arrText() As String

            Dim i As Integer = 1
            Dim j As Integer = 0

            '(1) get all the textboxes data in groupbox then put it in a array

            For Each cBook In Me.pnlDetails_fg.Controls
                If TypeName(cBook) = "TextBox" Then
                    'MsgBox(cBook.Text)
                    panelText += cBook.Text + " "
                End If
            Next

            arrText = Split(panelText, " ")

            '(2) loop to browse the textboxes in frmBooks-Edit and
            'pass the selected data in listview to the browsed textboxes

            For Each cBookEdit In frmBooks_Edit.pnlBooks.Controls
                If TypeName(cBookEdit) = "TextBox" Then

                    If i < lviBooks.Columns.Count Then
                        cBookEdit.Text = lviBooks.SelectedItems.Item(0).SubItems(i).Text
                        i += 1
                    ElseIf j < arrText.Length Then
                        cBookEdit.Text = arrText(j)
                        j += 1
                    End If

                End If
            Next

        End If

    End Sub

    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        Dim bookID As String = lviBooks.SelectedItems.Item(0).SubItems(0).Text
        Dim bookTitle As String = lviBooks.SelectedItems.Item(0).SubItems(1).Text

        If lviBooks.SelectedItems.Count > 0 Then
            If MsgBox("Are you sure you want to delete " & bookTitle & "?", MsgBoxStyle.Critical + vbYesNo) = MsgBoxResult.Yes Then
                AddEditDeleteRecord("DELETE FROM tblBook WHERE BookID = '" & bookID & "'")
                BookLoad()
            End If
        End If
    End Sub

    Private Sub ButtonMouseHover(sender As Object, e As EventArgs) Handles btnAdd.MouseHover, btnEdit.MouseHover, btnRemove.MouseHover
        Dim btnHovered As Button = DirectCast(sender, Button)

        Select Case btnHovered.Name
            Case "btnAdd"
                pnlAdd.Visible = True
            Case "btnEdit"
                pnlEdit.Visible = True
            Case "btnRemove"
                pnlRemove.Visible = True
        End Select
    End Sub

    Private Sub ButtonMouseLeave(sender As Object, e As EventArgs) Handles btnAdd.MouseLeave, btnEdit.MouseLeave, btnRemove.MouseLeave
        Dim btnLeave As Button = DirectCast(sender, Button)

        Select Case btnLeave.Name
            Case "btnAdd"
                pnlAdd.Visible = False
            Case "btnEdit"
                pnlEdit.Visible = False
            Case "btnRemove"
                pnlRemove.Visible = False
        End Select
    End Sub
End Class