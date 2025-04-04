Public Class CEProgramas

    Private _pro_codigo As Integer
    Private _pro_descripcion As String

    Public Sub New()
    End Sub

    Public Property Pro_codigo As Integer
        Get
            Return _pro_codigo
        End Get
        Set(value As Integer)
            _pro_codigo = value
        End Set
    End Property

    Public Property Pro_descripcion As String
        Get
            Return _pro_descripcion
        End Get
        Set(value As String)
            _pro_descripcion = value
        End Set
    End Property

    Public Overrides Function Equals(obj As Object) As Boolean
        Dim programas = TryCast(obj, CEProgramas)
        Return programas IsNot Nothing AndAlso
               _pro_codigo = programas._pro_codigo AndAlso
               _pro_descripcion = programas._pro_descripcion AndAlso
               Pro_codigo = programas.Pro_codigo AndAlso
               Pro_descripcion = programas.Pro_descripcion
    End Function

    Public Overrides Function GetHashCode() As Integer
        Return HashCode.Combine(_pro_codigo, _pro_descripcion, Pro_codigo, Pro_descripcion)
    End Function
End Class
