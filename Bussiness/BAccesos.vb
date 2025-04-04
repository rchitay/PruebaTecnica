Imports Entity
Imports Data
Imports System.Windows.Forms
Public Class BAccesos
    Dim data As New DAccesos

    Public Function validar(obj As CEAccesos) As Boolean
        Dim result As Boolean = True

        If Equals(obj.Seg_per_codigo, 0) Then
            result = False
            MessageBox.Show("Código de Personal es mandatorio")
        End If

        If Equals(obj.Seg_programa, 0) Then
            result = False
            MessageBox.Show("Código de Programa es mandatorio")
        End If

        Return result
    End Function

    Public Sub Insertar(ByVal obj As CEAccesos)
        data.Insertar(obj)
    End Sub

    Public Sub Editar(ByVal obj As CEAccesos)
        data.Editar(obj)
    End Sub
    Public Sub Eliminar(ByVal obj As CEAccesos)
        If MessageBox.Show("¿Esta seguro de Eliminar?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            data.Eliminar(obj)
        End If
    End Sub

    Public Function Listar(page As Integer, pageSize As Integer) As DataSet
        Return data.Listar(page, pageSize)
    End Function

    Public Function Buscar(ByVal obj As CEAccesos) As DataTable
        Return data.Buscar(obj)
    End Function
End Class
