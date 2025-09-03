Imports System.ComponentModel.DataAnnotations
Imports System.Runtime.CompilerServices
Imports TaskManager.Core
Imports TaskManager.Data

Public Class ContactEditorForm

    Private ReadOnly _contactId As Integer
    Private ReadOnly _isEditMode As Boolean

    Public Sub New(Optional contact As Contact = Nothing)
        Me.InitializeComponent()

        _isEditMode = contact IsNot Nothing

        btnAdd.Text = If(_isEditMode, "Save Contact", "Add Contact")
        Me.Text = If(_isEditMode, "Edit Contact", "Add Contact")

        If _isEditMode Then
            txtName.Text = contact.Name
            txtEmail.Text = contact.Email
            txtPhone.Text = contact.Phone
            CheckBoxIsActive.Checked = contact.IsActive
            _contactId = contact.Id
        Else
            _contactId = 0
        End If
    End Sub

    Private Async Sub ButtonAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

        Dim contact As New Contact() With {
            .Name = txtName.Text,
            .Email = txtEmail.Text,
            .Phone = txtPhone.Text,
            .IsActive = CheckBoxIsActive.Checked
            }
        Dim validator As New ContactValidator()
        Dim results = Await validator.ValidateAsync(contact)

        Dim success = results.IsValid

        If Not success Then
            Dim failures = results.Errors
            MessageBox.Show($"{failures.First()}", ContactListingForm.AppName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Using contactRepo As New ContactRepository()
            If _isEditMode Then
                contact.Id = _contactId
                Await contactRepo.UpdateContactAsync(contact)
            Else
                Await contactRepo.InsertContactAsync(contact)
            End If
        End Using

        ClearTextBoxes()
        Me.DialogResult = DialogResult.OK
        Close()

    End Sub

    Private Sub ClearTextBoxes()
        txtName.Clear()
        txtEmail.Clear()
        txtPhone.Clear()
    End Sub
End Class