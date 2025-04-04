Imports MySql.Data.MySqlClient

Public Class Conexion
    ' Credenciales para la conexion a la db
    Private server As String = "127.0.0.1"
    Private user As String = "root"
    Private password As String = "123456"
    Private port As String = "3306"
    Private db As String = "pruebatecnica"

    ' Cadena de conexion
    Private ReadOnly _connectionString As String = $"Server={server};User={user};Password={password};Port={port};Database={db};"
    Private _connection As MySqlConnection

    ' Método para obtener la conexión
    Public Function GetConnection() As MySqlConnection
        If _connection Is Nothing Then
            _connection = New MySqlConnection(_connectionString)
        End If
        Return _connection
    End Function

    ' Método para abrir la conexión
    Public Sub OpenConnection()
        Try
            If _connection Is Nothing OrElse _connection.State = ConnectionState.Closed Then
                _connection = New MySqlConnection(_connectionString)
                _connection.Open()
            End If
        Catch ex As Exception
            Throw New Exception("Error al abrir la conexión: " & ex.Message)
        End Try
    End Sub

    ' Método para cerrar la conexión
    Public Sub CloseConnection()
        Try
            If _connection IsNot Nothing AndAlso _connection.State = ConnectionState.Open Then
                _connection.Close()
            End If
        Catch ex As Exception
            Throw New Exception("Error al cerrar la conexión: " & ex.Message)
        End Try
    End Sub

End Class
