Imports System.ComponentModel
Imports TaskManager.Core
Imports TaskManager.Data

Public Class ContactListing
    Private contacts As New List(Of Contact)()

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SQLiteHelper.SetupConnection()

        GetContacts()
    End Sub

    Private Sub ButtonAdd_Click(sender As Object, e As EventArgs) Handles ButtonAdd.Click
        Using addContactForm As New AddContact()
            If addContactForm.ShowDialog() = DialogResult.OK Then
                GetContacts()
            End If
        End Using
    End Sub

    Private Sub GetContacts() Handles ButtonAdd.Click
        Using contactRepo As New ContactRepository()
            contacts = contactRepo.GetContacts()
            grdContacts.DataSource = contacts
        End Using
    End Sub
End Class
