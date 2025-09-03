Imports System.Data.SQLite
Imports TaskManager.Core

Public Class ContactRepository
    Implements IDisposable

    Public Const ColumnId As String = "Id"
    Public Const ColumnName As String = "Name"
    Public Const ColumnEmail As String = "Email"
    Public Const ColumnPhone As String = "Phone"
    Public Const ColumnIsActive As String = "IsActive"
    Public Const TableContact As String = "Contact"

    Public Sub Dispose() Implements IDisposable.Dispose
    End Sub

    Public Function InsertContact(contact As Contact) As Boolean
        Using connection As New SQLiteConnection(SQLiteHelper.DBPath)
            connection.Open()
            Dim insertQuery As String = $"INSERT INTO {TableContact} ({ColumnName}, {ColumnEmail}, {ColumnPhone}, {ColumnIsActive}) VALUES (@{ColumnName}, @{ColumnEmail}, @{ColumnPhone}, @{ColumnIsActive})"
            Using command As New SQLiteCommand(insertQuery, connection)
                command.Parameters.AddWithValue($"@{ColumnName}", contact.Name)
                command.Parameters.AddWithValue($"@{ColumnEmail}", contact.Email)
                command.Parameters.AddWithValue($"@{ColumnPhone}", contact.Phone)
                command.Parameters.AddWithValue($"@{ColumnIsActive}", contact.IsActive)
                command.ExecuteNonQuery()
            End Using
        End Using

        Return False
    End Function

    Public Function DeleteContact(contact As Contact) As Boolean
        Using connection As New SQLiteConnection(SQLiteHelper.DBPath)
            connection.Open()
            Dim insertQuery As String = $"DELETE FROM {TableContact} WHERE {ColumnId}=@{ColumnId}"
            Using command As New SQLiteCommand(insertQuery, connection)
                command.Parameters.AddWithValue($"@{ColumnId}", contact.Id)
                command.ExecuteNonQuery()
            End Using
        End Using

        Return False
    End Function

    Public Function UpdateContact(contact As Contact) As Boolean
        Using connection As New SQLiteConnection(SQLiteHelper.DBPath)
            connection.Open()
            Dim insertQuery As String = $"UPDATE {TableContact} SET {ColumnName}=@{ColumnName}, {ColumnEmail}=@{ColumnEmail}, {ColumnPhone}=@{ColumnPhone}, {ColumnIsActive}=@{ColumnIsActive} WHERE {ColumnId}=@{ColumnId}"
            Using command As New SQLiteCommand(insertQuery, connection)
                command.Parameters.AddWithValue($"@{ColumnId}", contact.Id)
                command.Parameters.AddWithValue($"@{ColumnName}", contact.Name)
                command.Parameters.AddWithValue($"@{ColumnEmail}", contact.Email)
                command.Parameters.AddWithValue($"@{ColumnPhone}", contact.Phone)
                command.Parameters.AddWithValue($"@{ColumnIsActive}", contact.IsActive)
                command.ExecuteNonQuery()
            End Using
        End Using

        Return False
    End Function

    Public Function GetContacts(Optional filterActive As Boolean = False) As List(Of Contact)
        Dim contacts As New List(Of Contact)

        Using connection As New SQLiteConnection(SQLiteHelper.DBPath)
            connection.Open()
            Dim selectQuery As String = $"SELECT {ColumnId}, {ColumnName}, {ColumnEmail}, {ColumnPhone}, {ColumnIsActive} FROM {TableContact} "
            If filterActive Then
                selectQuery &= $" WHERE {ColumnIsActive} != 0"
            End If
            Using command As New SQLiteCommand(selectQuery, connection)
                Using reader As SQLiteDataReader = command.ExecuteReader()
                    While reader.Read()
                        contacts.Add(New Contact() With {
                                     .Id = reader(ColumnId),
                                     .Name = If(reader(ColumnName) Is DBNull.Value, "", reader(ColumnName)),
                                     .Email = If(reader(ColumnEmail) Is DBNull.Value, "", reader(ColumnEmail)),
                                     .Phone = If(reader(ColumnPhone) Is DBNull.Value, "", reader(ColumnPhone)),
                                     .IsActive = reader(ColumnIsActive)
                                     })
                    End While
                End Using
            End Using
        End Using

        Return contacts
    End Function
End Class
