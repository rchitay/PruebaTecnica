Imports MySql.Data.MySqlClient
Imports Entity

Public Class DPersonal
    Private ReadOnly _dbConexion As New Conexion()
    Private tabla As String = "`Personal`"
    Public Function Listar(busqueda As String, page As Integer, pageSize As Integer) As DataSet
        ' Calcular el OFFSET basado en la página actual
        Dim offset As Integer = (page - 1) * pageSize

        ' Consulta SQL con paginación
        Dim condicion As String = ""
        If Not Equals(busqueda, "") Then
            condicion = $"where `per_nombre1` like '%{busqueda}%'"
        End If

        Dim query As String = $"SELECT * FROM {tabla} {condicion}  LIMIT {pageSize} OFFSET {offset};"
        MessageBox.Show(query)
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

    Public Sub Insertar(ByVal obj As CEPersonal)
        ' Separa Query
        Dim campos As String = "`per_codigo`, `per_usuario`, `per_apellido1`,`per_apellido2`,`per_nombre1`,`per_nombre2`,`per_estado`"
        Dim valores As String = $"'{obj.Per_codigo}','{obj.Per_usuario}','{obj.Per_apellido1}','{obj.Per_apellido2}','{obj.Per_nombre1}','{obj.Per_nombre2}','{obj.Per_estado}'"
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

    Public Sub Editar(ByVal obj As CEPersonal)
        ' Separa Query
        Dim Query As String = $"update {tabla} set `per_apellido1`='{obj.Per_apellido1}', `per_apellido2`='{obj.Per_apellido2}', `per_nombre1`='{obj.Per_nombre1}', `per_nombre2`='{obj.Per_nombre2}' where `per_codigo`={obj.Per_codigo};"
        Try
            _dbConexion.OpenConnection()
            Dim Command As New MySqlCommand(Query, _dbConexion.GetConnection())
            Command.ExecuteNonQuery()
            _dbConexion.CloseConnection()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Public Sub Eliminar(ByVal obj As CEPersonal)
        Dim Query As String = $"delete from {tabla} where `per_codigo`={obj.Per_codigo};"
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
