Public Class CEAccesos
    Private _seg_per_codigo As Integer
    Private _seg_programa As Integer
    Private _seg_insertar As String
    Private _seg_editar As String
    Private _seg_borrar As String
    Private _seg_buscar As String
    Public Sub New()
    End Sub

    Public Property Seg_per_codigo As Integer
        Get
            Return _seg_per_codigo
        End Get
        Set(value As Integer)
            _seg_per_codigo = value
        End Set
    End Property

    Public Property Seg_programa As Integer
        Get
            Return _seg_programa
        End Get
        Set(value As Integer)
            _seg_programa = value
        End Set
    End Property

    Public Property Seg_insertar As String
        Get
            Return _seg_insertar
        End Get
        Set(value As String)
            _seg_insertar = value
        End Set
    End Property

    Public Property Seg_editar As String
        Get
            Return _seg_editar
        End Get
        Set(value As String)
            _seg_editar = value
        End Set
    End Property

    Public Property Seg_borrar As String
        Get
            Return _seg_borrar
        End Get
        Set(value As String)
            _seg_borrar = value
        End Set
    End Property

    Public Property Seg_buscar As String
        Get
            Return _seg_buscar
        End Get
        Set(value As String)
            _seg_buscar = value
        End Set
    End Property

    Public Overrides Function Equals(obj As Object) As Boolean
        Dim accesos = TryCast(obj, CEAccesos)
        Return accesos IsNot Nothing AndAlso
               _seg_per_codigo = accesos._seg_per_codigo AndAlso
               _seg_programa = accesos._seg_programa AndAlso
               _seg_insertar = accesos._seg_insertar AndAlso
               _seg_editar = accesos._seg_editar AndAlso
               _seg_borrar = accesos._seg_borrar AndAlso
               _seg_buscar = accesos._seg_buscar AndAlso
               Seg_per_codigo = accesos.Seg_per_codigo AndAlso
               Seg_programa = accesos.Seg_programa AndAlso
               Seg_insertar = accesos.Seg_insertar AndAlso
               Seg_editar = accesos.Seg_editar AndAlso
               Seg_borrar = accesos.Seg_borrar AndAlso
               Seg_buscar = accesos.Seg_buscar
    End Function

    Public Overrides Function GetHashCode() As Integer
        Dim hash = New HashCode()
        hash.Add(_seg_per_codigo)
        hash.Add(_seg_programa)
        hash.Add(_seg_insertar)
        hash.Add(_seg_editar)
        hash.Add(_seg_borrar)
        hash.Add(_seg_buscar)
        hash.Add(Seg_per_codigo)
        hash.Add(Seg_programa)
        hash.Add(Seg_insertar)
        hash.Add(Seg_editar)
        hash.Add(Seg_borrar)
        hash.Add(Seg_buscar)
        Return hash.ToHashCode()
    End Function
End Class
