Imports Data

Public Class BPersonal
    Dim data As New DPersonal
    Public Function Listar(buscar As String, page As Integer, pageSize As Integer) As DataSet
        Return data.Listar(buscar, page, pageSize)
    End Function
End Class
