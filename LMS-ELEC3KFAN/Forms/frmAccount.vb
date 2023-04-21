Public Class frmAccount

    Sub ShowAccts()
        datareader("select * from tblAccount")
        lvwAccts.Items.Clear()
        While dr.Read
            Dim item As New ListViewItem(dr.Item("LibID").ToString, 0)
            item.SubItems.Add(dr.Item("FullName").ToString)
            item.SubItems.Add(dr.Item("ContactNumber").ToString)
            item.SubItems.Add(dr.Item("Address").ToString)
            item.SubItems.Add(dr.Item("Username").ToString)
            item.SubItems.Add(dr.Item("Passcode").ToString)
            item.SubItems.Add(dr.Item("PhotoDirectory").ToString)
            lvwAccts.Items.Add(item)
        End While
    End Sub

    Sub Search()
        Dim Search As Integer = cboSearch.SelectedIndex
        Dim Options() As String = {"*", "LibID", "FullName", "ContactNumber", "Address", "Username", "Passcode", "PhotoDirectory"}

        'MsgBox(Options(Search))

        If Search > 0 Then


            datareader("select * from tblAccount WHERE " + Options(Search) + " LIKE '%" + txtSearch.Text + "%'")
            lvwAccts.Items.Clear()
            While dr.Read
                Dim item As New ListViewItem(dr.Item("LibID").ToString, 0)
                item.SubItems.Add(dr.Item("FullName").ToString)
                item.SubItems.Add(dr.Item("ContactNumber").ToString)
                item.SubItems.Add(dr.Item("Address").ToString)
                item.SubItems.Add(dr.Item("Username").ToString)
                item.SubItems.Add(dr.Item("Passcode").ToString)
                item.SubItems.Add(dr.Item("PhotoDirectory").ToString)
                lvwAccts.Items.Add(item)
            End While

        ElseIf Search = 0 Or txtSearch.Text = "" Then
            ShowAccts()
        End If
    End Sub

    Sub SearchOption()
        cboSearch.Items.Clear()
        cboSearch.Items.Insert(0, "ALL")
        cboSearch.SelectedIndex = 0
        cboSearch.Items.Add("ID")
        cboSearch.Items.Add("NAME")
        cboSearch.Items.Add("CONTACT")
        cboSearch.Items.Add("ADDRESS")
        cboSearch.Items.Add("USERNAME")
    End Sub
    Private Sub frmAccount_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ShowAccts()
        SearchOption()
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Search()
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
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        frmAccount_Add.ShowDialog()
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If lvwAccts.SelectedItems.Count > 0 Then
            frmAccount_Edit.ShowDialog()
            frmAccount_Edit.lblLibID.Text = lvwAccts.SelectedItems.Item(0).Text


            Dim cAcctEdit As Control
            Dim arrText() As String
            Dim i As Integer = 1
            Dim j As Integer = 0

            '(2) loop to browse the textboxes in frmAccounts-Edit and
            'pass the selected data in listview to the browsed textboxes

            For Each cAcctEdit In frmAccount_Edit.pnlDetails.Controls
                If TypeName(cAcctEdit) = "TextBox" Then
                    If i < lvwAccts.Columns.Count Then
                        cAcctEdit.Text = lvwAccts.SelectedItems.Item(0).SubItems(i).Text
                        i += 1
                        MsgBox(cAcctEdit.Text)
                    ElseIf j < arrText.Length Then
                        cAcctEdit.Text = arrText(j)
                        j += 1
                    End If

                End If
            Next

        End If
    End Sub

    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        Dim LibraryID As String = lvwAccts.SelectedItems.Item(0).SubItems(0).Text
        Dim Name As String = lvwAccts.SelectedItems.Item(0).SubItems(1).Text

        If lvwAccts.SelectedItems.Count > 0 Then
            If MsgBox("Are you sure you want to delete " & Name & "?", MsgBoxStyle.Critical + vbYesNo) = MsgBoxResult.Yes Then
                AddEditDeleteRecord("DELETE FROM tblAccount WHERE LibID = '" & LibraryID & "'")
                ShowAccts()
            End If
        End If
    End Sub


    Private Sub lvwAccts_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvwAccts.SelectedIndexChanged

        If lvwAccts.SelectedItems.Count > 0 Then
            pbAccounts.Image = Image.FromFile(lvwAccts.Items(lvwAccts.FocusedItem.Index).SubItems(6).Text)
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