Imports MySql.Data.MySqlClient
Imports Entity
Public Class DAccesos
    Private ReadOnly _dbConexion As New Conexion()
    Private tabla As String = "`Accesos`"
    Public Function Listar(page As Integer, pageSize As Integer) As DataSet
        ' Calcular el OFFSET basado en la página actual
        Dim offset As Integer = (page - 1) * pageSize

        ' Consulta SQL con paginación
        Dim query As String = $"SELECT * FROM {tabla} LIMIT {pageSize} OFFSET {offset};"

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

    Public Function Buscar(ByVal obj As CEAccesos) As DataTable
        Dim Query As String = $"SELECT * FROM {tabla} WHERE `seg_per_codigo` = {obj.Seg_per_codigo} AND `seg_programa` = {obj.Seg_programa};"
        Dim dataTable As New DataTable()

        Try
            _dbConexion.OpenConnection()
            Dim Command As New MySqlCommand(Query, _dbConexion.GetConnection())
            Dim Adapter As New MySqlDataAdapter(Command)

            Adapter.Fill(dataTable)

            _dbConexion.CloseConnection()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        ' Return the resulting data
        Return dataTable
    End Function

    Public Sub Insertar(ByVal obj As CEAccesos)
        ' Separa Query
        Dim campos As String = "`seg_per_codigo`, `seg_programa`, `seg_insertar`,`seg_editar`,`seg_borrar`,`seg_buscar`"
        Dim valores As String = $"{obj.Seg_per_codigo},{obj.Seg_programa},'{obj.Seg_insertar}','{obj.Seg_editar}','{obj.Seg_borrar}','{obj.Seg_buscar}'"
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

    Public Sub Editar(ByVal obj As CEAccesos)
        ' Separa Query
        Dim Query As String = $"update {tabla} set `seg_insertar`='{obj.Seg_insertar}', `seg_editar`='{obj.Seg_editar}', `seg_borrar`='{obj.Seg_borrar}', `seg_buscar`='{obj.Seg_buscar}' where `seg_per_codigo`={obj.Seg_per_codigo} and `seg_programa`={obj.Seg_programa};"
        Try
            _dbConexion.OpenConnection()
            Dim Command As New MySqlCommand(Query, _dbConexion.GetConnection())
            Command.ExecuteNonQuery()
            _dbConexion.CloseConnection()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Public Sub Eliminar(ByVal obj As CEAccesos)
        Dim Query As String = $"delete from {tabla} where `seg_per_codigo`={obj.Seg_per_codigo} and `seg_programa`={obj.Seg_programa};"
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
