<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ContactListingForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.grdContacts = New System.Windows.Forms.DataGridView()
        Me.ButtonAdd = New System.Windows.Forms.Button()
        Me.lblHeader = New System.Windows.Forms.Label()
        Me.ButtonEdit = New System.Windows.Forms.Button()
        Me.ButtonDelete = New System.Windows.Forms.Button()
        Me.ButtonReset = New System.Windows.Forms.Button()
        Me.ButtonExport = New System.Windows.Forms.Button()
        Me.ButtonImport = New System.Windows.Forms.Button()
        Me.CheckShowActive = New System.Windows.Forms.CheckBox()
        Me.TextBoxSearch = New System.Windows.Forms.TextBox()
        Me.ButtonSearch = New System.Windows.Forms.Button()
        CType(Me.grdContacts, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grdContacts
        '
        Me.grdContacts.AllowUserToAddRows = False
        Me.grdContacts.AllowUserToDeleteRows = False
        Me.grdContacts.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdContacts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdContacts.Location = New System.Drawing.Point(12, 35)
        Me.grdContacts.Name = "grdContacts"
        Me.grdContacts.ReadOnly = True
        Me.grdContacts.Size = New System.Drawing.Size(454, 375)
        Me.grdContacts.TabIndex = 0
        '
        'ButtonAdd
        '
        Me.ButtonAdd.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ButtonAdd.Location = New System.Drawing.Point(12, 454)
        Me.ButtonAdd.Name = "ButtonAdd"
        Me.ButtonAdd.Size = New System.Drawing.Size(75, 23)
        Me.ButtonAdd.TabIndex = 1
        Me.ButtonAdd.Text = "Add Contact"
        Me.ButtonAdd.UseVisualStyleBackColor = True
        '
        'lblHeader
        '
        Me.lblHeader.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblHeader.AutoSize = True
        Me.lblHeader.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeader.Location = New System.Drawing.Point(193, 9)
        Me.lblHeader.Name = "lblHeader"
        Me.lblHeader.Size = New System.Drawing.Size(71, 17)
        Me.lblHeader.TabIndex = 2
        Me.lblHeader.Text = "Contacts"
        Me.lblHeader.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'ButtonEdit
        '
        Me.ButtonEdit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ButtonEdit.Location = New System.Drawing.Point(93, 454)
        Me.ButtonEdit.Name = "ButtonEdit"
        Me.ButtonEdit.Size = New System.Drawing.Size(75, 23)
        Me.ButtonEdit.TabIndex = 3
        Me.ButtonEdit.Text = "Edit Contact"
        Me.ButtonEdit.UseVisualStyleBackColor = True
        '
        'ButtonDelete
        '
        Me.ButtonDelete.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ButtonDelete.Location = New System.Drawing.Point(174, 454)
        Me.ButtonDelete.Name = "ButtonDelete"
        Me.ButtonDelete.Size = New System.Drawing.Size(90, 23)
        Me.ButtonDelete.TabIndex = 4
        Me.ButtonDelete.Text = "Delete Contact"
        Me.ButtonDelete.UseVisualStyleBackColor = True
        '
        'ButtonReset
        '
        Me.ButtonReset.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ButtonReset.ForeColor = System.Drawing.Color.Red
        Me.ButtonReset.Location = New System.Drawing.Point(359, 454)
        Me.ButtonReset.Name = "ButtonReset"
        Me.ButtonReset.Size = New System.Drawing.Size(107, 23)
        Me.ButtonReset.TabIndex = 5
        Me.ButtonReset.Text = "Reset Database"
        Me.ButtonReset.UseVisualStyleBackColor = True
        '
        'ButtonExport
        '
        Me.ButtonExport.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ButtonExport.Location = New System.Drawing.Point(12, 483)
        Me.ButtonExport.Name = "ButtonExport"
        Me.ButtonExport.Size = New System.Drawing.Size(103, 23)
        Me.ButtonExport.TabIndex = 6
        Me.ButtonExport.Text = "Export JSON"
        Me.ButtonExport.UseVisualStyleBackColor = True
        '
        'ButtonImport
        '
        Me.ButtonImport.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ButtonImport.Location = New System.Drawing.Point(121, 483)
        Me.ButtonImport.Name = "ButtonImport"
        Me.ButtonImport.Size = New System.Drawing.Size(103, 23)
        Me.ButtonImport.TabIndex = 7
        Me.ButtonImport.Text = "Import JSON"
        Me.ButtonImport.UseVisualStyleBackColor = True
        '
        'CheckShowActive
        '
        Me.CheckShowActive.AutoSize = True
        Me.CheckShowActive.Location = New System.Drawing.Point(12, 12)
        Me.CheckShowActive.Name = "CheckShowActive"
        Me.CheckShowActive.Size = New System.Drawing.Size(131, 17)
        Me.CheckShowActive.TabIndex = 8
        Me.CheckShowActive.Text = "Show Active Contacts"
        Me.CheckShowActive.UseVisualStyleBackColor = True
        '
        'TextBoxSearch
        '
        Me.TextBoxSearch.Location = New System.Drawing.Point(12, 416)
        Me.TextBoxSearch.Name = "TextBoxSearch"
        Me.TextBoxSearch.Size = New System.Drawing.Size(372, 20)
        Me.TextBoxSearch.TabIndex = 9
        '
        'ButtonSearch
        '
        Me.ButtonSearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ButtonSearch.Location = New System.Drawing.Point(391, 413)
        Me.ButtonSearch.Name = "ButtonSearch"
        Me.ButtonSearch.Size = New System.Drawing.Size(75, 23)
        Me.ButtonSearch.TabIndex = 10
        Me.ButtonSearch.Text = "Search"
        Me.ButtonSearch.UseVisualStyleBackColor = True
        '
        'ContactListingForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(478, 518)
        Me.Controls.Add(Me.ButtonSearch)
        Me.Controls.Add(Me.TextBoxSearch)
        Me.Controls.Add(Me.CheckShowActive)
        Me.Controls.Add(Me.ButtonImport)
        Me.Controls.Add(Me.ButtonExport)
        Me.Controls.Add(Me.ButtonReset)
        Me.Controls.Add(Me.ButtonDelete)
        Me.Controls.Add(Me.ButtonEdit)
        Me.Controls.Add(Me.lblHeader)
        Me.Controls.Add(Me.ButtonAdd)
        Me.Controls.Add(Me.grdContacts)
        Me.Name = "ContactListingForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Contact Listing"
        CType(Me.grdContacts, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents grdContacts As DataGridView
    Friend WithEvents ButtonAdd As Button
    Friend WithEvents lblHeader As Label
    Friend WithEvents ButtonEdit As Button
    Friend WithEvents ButtonDelete As Button
    Friend WithEvents ButtonReset As Button
    Friend WithEvents ButtonExport As Button
    Friend WithEvents ButtonImport As Button
    Friend WithEvents CheckShowActive As CheckBox
    Friend WithEvents TextBoxSearch As TextBox
    Friend WithEvents ButtonSearch As Button
End Class
