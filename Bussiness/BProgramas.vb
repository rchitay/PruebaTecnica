Imports Data

Public Class BProgramas
    Dim data As New DProgramas
    Public Function Listar(buscar As String, page As Integer, pageSize As Integer) As DataSet
        Return data.Listar(buscar, page, pageSize)
    End Function
End Class
