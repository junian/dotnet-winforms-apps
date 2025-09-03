Imports System.Data.SQLite
Imports System.IO

Public Class SQLiteHelper
    Private Shared _databaseFile As String = "ContactManager.db"
    Public Shared DBPath As String = "Data Source=ContactManager.db;Version=3;"

    Public Shared Sub SetupConnection()
        RemoveDatabase()

        SQLiteConnection.CreateFile(_databaseFile)

        Using connection As New SQLiteConnection(DBPath)
            connection.Open()
            Dim createTableQuery As String = "CREATE TABLE Contact (Id INTEGER PRIMARY KEY, Name TEXT, Email TEXT, Phone INTEGER)"
            Using command As New SQLiteCommand(createTableQuery, connection)
                command.ExecuteNonQuery()
            End Using
        End Using

        SeedData()
    End Sub

    Shared Sub SeedData()
        Dim contactRepo As New ContactRepository()

        contactRepo.InsertContact(New Core.Contact() With {.Name = "John Doe", .Email = "John@gmail.com", .Phone = 9999999999})
        contactRepo.InsertContact(New Core.Contact() With {.Name = "Jane Smith", .Email = "Jane@gmail.com", .Phone = 9999999999})
    End Sub

    Shared Sub RemoveDatabase()
        If File.Exists(_databaseFile) Then
            File.Delete(_databaseFile)
        End If
    End Sub

End Class
