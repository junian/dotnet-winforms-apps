Imports System.Data.SQLite
Imports ContactManager.Core

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

    Public Async Function InsertContactAsync(contact As Contact) As Task(Of Boolean)
        Using connection As New SQLiteConnection(SQLiteHelper.DBPath)
            Await connection.OpenAsync()
            Dim insertQuery As String = $"INSERT INTO {TableContact} ({ColumnName}, {ColumnEmail}, {ColumnPhone}, {ColumnIsActive}) VALUES (@{ColumnName}, @{ColumnEmail}, @{ColumnPhone}, @{ColumnIsActive})"
            Using command As New SQLiteCommand(insertQuery, connection)
                command.Parameters.AddWithValue($"@{ColumnName}", contact.Name)
                command.Parameters.AddWithValue($"@{ColumnEmail}", contact.Email)
                command.Parameters.AddWithValue($"@{ColumnPhone}", contact.Phone)
                command.Parameters.AddWithValue($"@{ColumnIsActive}", contact.IsActive)
                Await command.ExecuteNonQueryAsync()
            End Using
        End Using

        Return False
    End Function

    Public Async Function DeleteContactAsync(contact As Contact) As Task(Of Boolean)
        Using connection As New SQLiteConnection(SQLiteHelper.DBPath)
            Await connection.OpenAsync()
            Dim insertQuery As String = $"DELETE FROM {TableContact} WHERE {ColumnId}=@{ColumnId}"
            Using command As New SQLiteCommand(insertQuery, connection)
                command.Parameters.AddWithValue($"@{ColumnId}", contact.Id)
                Await command.ExecuteNonQueryAsync()
            End Using
        End Using

        Return False
    End Function

    Public Async Function UpdateContactAsync(contact As Contact) As Task(Of Boolean)
        Using connection As New SQLiteConnection(SQLiteHelper.DBPath)
            Await connection.OpenAsync()
            Dim insertQuery As String = $"UPDATE {TableContact} SET {ColumnName}=@{ColumnName}, {ColumnEmail}=@{ColumnEmail}, {ColumnPhone}=@{ColumnPhone}, {ColumnIsActive}=@{ColumnIsActive} WHERE {ColumnId}=@{ColumnId}"
            Using command As New SQLiteCommand(insertQuery, connection)
                command.Parameters.AddWithValue($"@{ColumnId}", contact.Id)
                command.Parameters.AddWithValue($"@{ColumnName}", contact.Name)
                command.Parameters.AddWithValue($"@{ColumnEmail}", contact.Email)
                command.Parameters.AddWithValue($"@{ColumnPhone}", contact.Phone)
                command.Parameters.AddWithValue($"@{ColumnIsActive}", contact.IsActive)
                Await command.ExecuteNonQueryAsync()
            End Using
        End Using

        Return False
    End Function

    Public Async Function GetContactsAsync(Optional filterActive As Boolean = False) As Task(Of List(Of Contact))
        Dim contacts As New List(Of Contact)

        Using connection As New SQLiteConnection(SQLiteHelper.DBPath)
            connection.Open()
            Dim selectQuery As String = $"SELECT {ColumnId}, {ColumnName}, {ColumnEmail}, {ColumnPhone}, {ColumnIsActive} FROM {TableContact} "
            If filterActive Then
                selectQuery &= $" WHERE {ColumnIsActive} != 0"
            End If
            Using command As New SQLiteCommand(selectQuery, connection)
                Using reader As SQLiteDataReader = Await command.ExecuteReaderAsync()
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

    Public Async Function BatchInsertAsync(contacts As List(Of Contact)) As Task(Of Boolean)
        Using connection As New SQLiteConnection(SQLiteHelper.DBPath)
            Await connection.OpenAsync()
            Using transaction As SQLiteTransaction = connection.BeginTransaction()
                Try
                    Dim insertQuery As String = $"INSERT INTO {TableContact} ({ColumnName}, {ColumnEmail}, {ColumnPhone}, {ColumnIsActive}) VALUES (@{ColumnName}, @{ColumnEmail}, @{ColumnPhone}, @{ColumnIsActive})"
                    Using command As New SQLiteCommand(insertQuery, connection)
                        For Each contact As Contact In contacts
                            command.Parameters.AddWithValue($"@{ColumnName}", contact.Name)
                            command.Parameters.AddWithValue($"@{ColumnEmail}", contact.Email)
                            command.Parameters.AddWithValue($"@{ColumnPhone}", contact.Phone)
                            command.Parameters.AddWithValue($"@{ColumnIsActive}", contact.IsActive)
                            Await command.ExecuteNonQueryAsync()
                        Next
                    End Using
                    transaction.Commit()
                Catch ex As Exception
                    transaction.Rollback()
                    Return False
                End Try
            End Using
        End Using
        Return True
    End Function
End Class
