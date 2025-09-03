Imports System.ComponentModel
Imports TaskManager.Core
Imports TaskManager.Data

Public Class ContactListing
    Private contacts As New List(Of Contact)()

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            SQLiteHelper.SetupConnection()
            GetContacts()
        Catch ex As Exception
            MessageBox.Show(ex.ToString(), "Contact Manager", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ButtonAdd_Click(sender As Object, e As EventArgs) Handles ButtonAdd.Click
        Using addContactForm As New AddContact()
            If addContactForm.ShowDialog() = DialogResult.OK Then
                GetContacts()
            End If
        End Using
    End Sub

    Private Sub GetContacts() Handles ButtonAdd.Click
        Try
            Using contactRepo As New ContactRepository()
                If CheckShowActive.Checked = True Then
                    contacts = contactRepo.GetContacts(True)
                Else
                    contacts = contactRepo.GetContacts()
                End If
                grdContacts.DataSource = contacts
                grdContacts.Columns("Id").Visible = False
            End Using
        Catch ex As Exception
            MessageBox.Show(ex.ToString(), "Contact Manager", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ButtonReset_Click(sender As Object, e As EventArgs) Handles ButtonReset.Click
        If MessageBox.Show("This will Reset Database. Are you sure?", "Contact Manager", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            SQLiteHelper.ResetDatabase()
            GetContacts()
        End If
    End Sub

    Private Sub ButtonEdit_Click(sender As Object, e As EventArgs) Handles ButtonEdit.Click
        Dim selectedContact = GetSelectedContact()

        If selectedContact Is Nothing Then
            MessageBox.Show($"Select a contact to Edit.", "Contact Manager", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return
        End If

        Using contactEditorForm As New AddContact(selectedContact)
            If contactEditorForm.ShowDialog() = DialogResult.OK Then
                GetContacts()
            End If
        End Using
    End Sub

    Private Function GetSelectedContact() As Contact
        If grdContacts.SelectedCells.Count > 0 Then
            Dim rowIndex As Integer = grdContacts.SelectedCells(0).RowIndex
            If rowIndex >= 0 And rowIndex < grdContacts.Rows.Count Then
                Dim selectedContact As Contact = CType(grdContacts.Rows(rowIndex).DataBoundItem, Contact)
                Return selectedContact
            End If
        End If

        Return Nothing
    End Function

    Private Sub ButtonDelete_Click(sender As Object, e As EventArgs) Handles ButtonDelete.Click
        Dim selectedContact = GetSelectedContact()

        If selectedContact Is Nothing Then
            MessageBox.Show($"Select a contact to DELETE.", "Contact Manager", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return
        End If

        If MessageBox.Show("This will DELETE the selected contact. Are you sure?", "Contact Manager", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Using contactRepo As New ContactRepository()
                contactRepo.DeleteContact(selectedContact)
            End Using
            GetContacts()
        End If
    End Sub

    Private Sub CheckShowActive_CheckedChanged(sender As Object, e As EventArgs) Handles CheckShowActive.CheckedChanged
        GetContacts()
    End Sub
End Class
