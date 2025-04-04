Imports MySql.Data.MySqlClient
Imports Entity
Public Class DProgramas
    Private ReadOnly _dbConexion As New Conexion()
    Private tabla As String = "`Programas`"

    Public Function Listar(busqueda As String, page As Integer, pageSize As Integer) As DataSet
        ' Calcular el OFFSET basado en la página actual
        Dim offset As Integer = (page - 1) * pageSize

        Dim condicion As String = ""
        If Not Equals(busqueda, "") Then
            condicion = $"where `pro_descripcion` like '%{busqueda}%'"
        End If
        ' Consulta SQL con paginación
        Dim query As String = $"SELECT * FROM {tabla} {condicion} LIMIT {pageSize} OFFSET {offset};"

        Dim adapter As MySqlDataAdapter
        Dim dataSet As New DataSet
        Try
            _dbConexion.OpenConnection()
            adapter = New MySqlDataAdapter(query, _dbConexion.GetConnection())
            adapter.Fill(dataSet, tabla)
        Catch ex As Exception
            MessageBox.Show("Error al listar: " & ex.Message)
        Finally
            _dbConexion.CloseConnection()
        End Try

        Return dataSet
    End Function

    Public Sub Insertar(ByVal obj As CEProgramas)
        ' Separa Query
        Dim campos As String = "`pro_descripcion`"
        Dim valores As String = $"'{obj.Pro_descripcion}'"
        Dim Query As String = $"insert into {tabla} ({campos}) values ({valores});"
        Try
            _dbConexion.OpenConnection()
            Dim Command As New MySqlCommand(Query, _dbConexion.GetConnection())
            Command.ExecuteNonQuery()
            _dbConexion.CloseConnection()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Public Sub Editar(ByVal obj As CEProgramas)
        ' Separa Query
        Dim Query As String = $"update {tabla} set `pro_descripcion`='{obj.Pro_descripcion}' where `pro_codigo`={obj.Pro_codigo};"
        Try
            _dbConexion.OpenConnection()
            Dim Command As New MySqlCommand(Query, _dbConexion.GetConnection())
            Command.ExecuteNonQuery()
            _dbConexion.CloseConnection()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Public Sub Eliminar(ByVal obj As CEProgramas)
        Dim Query As String = $"delete from {tabla} where `pro_codigo`={obj.Pro_codigo};"
        Try
            _dbConexion.OpenConnection()
            Dim Command As New MySqlCommand(Query, _dbConexion.GetConnection())
            Command.ExecuteNonQuery()
            _dbConexion.CloseConnection()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class
