Imports System.Data.OleDb
Public Class frmMain

#Region "  Main Menu - Opening/Closing Forms"
    'Panlabas ng mga forms dun sa panel na nasa main menu, naka Sub para hindi redundant code thanks gen rev'
    Sub ShowForms(ByVal panel As Form)
        'panel.TopLevel = False
        'pnlMainMenu.Controls.Clear()
        'pnlMainMenu.Controls.Add(panel)
        'panel.Show()

        panel.TopLevel = False
        panel.Dock = DockStyle.Fill
        pnlMainMenu.Controls.Clear()
        pnlMainMenu.Controls.Add(panel)
        panel.BringToFront()
        panel.Show()

    End Sub

#Region "  Old CloseActiveForms"
    'Sub enterForm(ByVal formName As String)

    '    Select Case formName
    '        Case "Dashboard"
    '            frmBooks.Close()
    '            frmIssue.Close()
    '            frmReturn.Close()
    '            frmAccount.Close()

    '        Case "Book"
    '            frmDashboard.Close()
    '            frmIssue.Close()
    '            frmReturn.Close()
    '            frmAccount.Close()

    '        Case "Issue"

    '            frmDashboard.Close()
    '            frmBooks.Close()
    '            frmReturn.Close()
    '            frmAccount.Close()

    '        Case "Return"

    '            frmDashboard.Close()
    '            frmBooks.Close()
    '            frmIssue.Close()
    '            frmAccount.Close()

    '        Case "Account"
    '            frmDashboard.Close()
    '            frmBooks.Close()
    '            frmIssue.Close()
    '            frmReturn.Close()

    '    End Select

    'End Sub
#End Region

    Sub closeActiveForms(ByVal form As String)
        'Newly Updated Enter Form. Mas precise at short... :)'

        Dim formNames As New List(Of String)

        For Each currentForm As Form In Application.OpenForms
            If currentForm.Name <> form And currentForm.Name <> "frmMain" And currentForm.Name <> "frmLogin" Then
                formNames.Add(currentForm.Name)
            End If
        Next

        For Each currentFormName As String In formNames
            Application.OpenForms(currentFormName).Close()
        Next
    End Sub

#End Region

#Region "  Main Menu - Buttons"
    Private Sub btnDashboard_Click(sender As Object, e As EventArgs) Handles btnDashboard.Click
        closeActiveForms("frmDashboard") '<--- To close all active forms except to Main, Login and the specific form that you want to go to.'

        If Not Application.OpenForms().OfType(Of frmDashboard).Any Then '<--- 'If Else para di na magopen ulit ang active form.' 
            ShowForms(frmDashboard) '<--- To occupy the main panel in main form and then showing it.'
        End If
        menuHighlighter(btnDashboard) '<--- Button Highlighter'
    End Sub

    Private Sub btnBooks_Click(sender As Object, e As EventArgs) Handles btnBooks.Click
        closeActiveForms("frmBooks")
        If Not Application.OpenForms().OfType(Of frmBooks).Any Then
            ShowForms(frmBooks)
        End If
        menuHighlighter(btnBooks)
    End Sub

    Private Sub btnIssue_Click(sender As Object, e As EventArgs) Handles btnIssue.Click
        closeActiveForms("frmIssue")

        If Not Application.OpenForms().OfType(Of frmTransaction).Any Then
            ShowForms(frmTransaction)
        End If
        menuHighlighter(btnIssue)
    End Sub
    Private Sub btnAccount_Click(sender As Object, e As EventArgs) Handles btnAccount.Click
        closeActiveForms("frmAccount")
        If Not Application.OpenForms().OfType(Of frmAccount).Any Then
            ShowForms(frmAccount)
        End If
        menuHighlighter(btnAccount)
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
        frmLogin.Show()
    End Sub
#End Region

#Region "  Main Menu - Button Highlighter"
    Sub menuHighlighter(ByRef Buttons As Button)
        pnlChoose.Height = Buttons.Height
        pnlChoose.Top = Buttons.Top
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub pnlHeader_Paint(sender As Object, e As PaintEventArgs) Handles pnlHeader.Paint

    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles Me.Load
        'we code here boi dont 4getti (super admin)

        'remove as comment next line until "end if" line

        'ds = New DataSet
        'da = New OleDbDataAdapter("SELECT Username FROM tblAccount WHERE Username = '" & frmLogin.txtUser.Text & "'", conn)
        'da.Fill(ds, "Username")
        'Dim usertype As String = ds.Tables("Username").Rows(0).ItemArray(0).ToString

        'If usertype = "admin" Then
        '    btnAccount.Enabled = True
        'Else
        '    btnAccount.Hide()
        'End If

    End Sub

    Private Sub pnlMainMenu_Paint(sender As Object, e As PaintEventArgs) Handles pnlMainMenu.Paint

    End Sub

#End Region

End Class
