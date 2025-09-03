Imports System.Data.SQLite
Imports System.IO
Imports Microsoft.VisualBasic.Logging

Public Class SQLiteHelper
    Private Shared _databaseFile As String = "ContactManager.db"
    Public Shared DBPath As String = $"Data Source={_databaseFile};Version=3;FailIfMissing=True;"

    Public Shared Async Function SetupConnectionAsync() As Task
        If Not Await DatabaseIsValidAsync() Then
            Await ResetDatabaseAsync()
        End If
    End Function

    Shared Async Function DatabaseIsValidAsync() As Task(Of Boolean)
        Using db As New SQLiteConnection(DBPath)
            Try
                Await db.OpenAsync()
                Using transaction = db.BeginTransaction()
                    transaction.Rollback()
                End Using
            Catch ex As Exception
                Return False
            End Try
        End Using
        Return True
    End Function

    Shared Async Function InitDBAsync() As Task
        Using connection As New SQLiteConnection(DBPath)
            Await connection.OpenAsync()
            Dim createTableQuery As String = $"CREATE TABLE {ContactRepository.TableContact} ({ContactRepository.ColumnId} INTEGER PRIMARY KEY, {ContactRepository.ColumnName} TEXT, {ContactRepository.ColumnEmail} TEXT, {ContactRepository.ColumnPhone} TEXT, {ContactRepository.ColumnIsActive} INTEGER)"
            Using command As New SQLiteCommand(createTableQuery, connection)
                Await command.ExecuteNonQueryAsync()
            End Using
        End Using
    End Function

    Shared Async Function SeedDataAsync() As Task
        Dim contactRepo As New ContactRepository()

        Await contactRepo.InsertContactAsync(New Core.Contact() With {.Name = "John Doe", .Email = "John@gmail.com", .Phone = "9999999999"})
        Await contactRepo.InsertContactAsync(New Core.Contact() With {.Name = "Jane Smith", .Email = "Jane@gmail.com", .Phone = "9999999999"})
    End Function

    Shared Sub RecreateDatabaseFile()
        If File.Exists(_databaseFile) Then
            File.Delete(_databaseFile)
        End If
        SQLiteConnection.CreateFile(_databaseFile)
    End Sub

    Public Shared Async Function ResetDatabaseAsync() As Task
        RecreateDatabaseFile()
        Await InitDBAsync()
        Await SeedDataAsync()
    End Function

End Class
