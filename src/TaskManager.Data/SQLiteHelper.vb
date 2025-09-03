Imports System.Data.SQLite
Imports System.IO
Imports Microsoft.VisualBasic.Logging

Public Class SQLiteHelper
    Private Shared _databaseFile As String = "ContactManager.db"
    Public Shared DBPath As String = $"Data Source={_databaseFile};Version=3;FailIfMissing=True;"

    Public Shared Sub SetupConnection()
        If Not DatabaseIsValid() Then
            ResetDatabase()
        End If
    End Sub

    Shared Function DatabaseIsValid() As Boolean
        Using db As New SQLiteConnection(DBPath)
            Try
                db.Open()
                Using transaction = db.BeginTransaction()
                    transaction.Rollback()
                End Using
            Catch ex As Exception
                Return False
            End Try
        End Using
        Return True
    End Function

    Shared Sub InitDB()
        Using connection As New SQLiteConnection(DBPath)
            connection.Open()
            Dim createTableQuery As String = $"CREATE TABLE {ContactRepository.TableContact} ({ContactRepository.ColumnId} INTEGER PRIMARY KEY, {ContactRepository.ColumnName} TEXT, {ContactRepository.ColumnEmail} TEXT, {ContactRepository.ColumnPhone} TEXT, {ContactRepository.ColumnIsActive} INTEGER)"
            Using command As New SQLiteCommand(createTableQuery, connection)
                command.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    Shared Sub SeedData()
        Dim contactRepo As New ContactRepository()

        contactRepo.InsertContact(New Core.Contact() With {.Name = "John Doe", .Email = "John@gmail.com", .Phone = "9999999999"})
        contactRepo.InsertContact(New Core.Contact() With {.Name = "Jane Smith", .Email = "Jane@gmail.com", .Phone = "9999999999"})
    End Sub

    Shared Sub RecreateDatabaseFile()
        If File.Exists(_databaseFile) Then
            File.Delete(_databaseFile)
        End If
        SQLiteConnection.CreateFile(_databaseFile)
    End Sub

    Public Shared Sub ResetDatabase()
        RecreateDatabaseFile()
        InitDB()
        SeedData()
    End Sub

End Class
