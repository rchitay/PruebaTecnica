Public Class CEPersonal
    Private _per_codigo As Integer
    Private _per_usuario As String
    Private _per_apellido1 As String
    Private _per_apellido2 As String
    Private _per_nombre1 As String
    Private _per_nombre2 As String
    Private _per_estado As Integer

    Public Sub New()
    End Sub

    Public Property Per_codigo As Integer
        Get
            Return _per_codigo
        End Get
        Set(value As Integer)
            _per_codigo = value
        End Set
    End Property

    Public Property Per_usuario As String
        Get
            Return _per_usuario
        End Get
        Set(value As String)
            _per_usuario = value
        End Set
    End Property

    Public Property Per_apellido1 As String
        Get
            Return _per_apellido1
        End Get
        Set(value As String)
            _per_apellido1 = value
        End Set
    End Property

    Public Property Per_apellido2 As String
        Get
            Return _per_apellido2
        End Get
        Set(value As String)
            _per_apellido2 = value
        End Set
    End Property

    Public Property Per_nombre1 As String
        Get
            Return _per_nombre1
        End Get
        Set(value As String)
            _per_nombre1 = value
        End Set
    End Property

    Public Property Per_nombre2 As String
        Get
            Return _per_nombre2
        End Get
        Set(value As String)
            _per_nombre2 = value
        End Set
    End Property

    Public Property Per_estado As Integer
        Get
            Return _per_estado
        End Get
        Set(value As Integer)
            _per_estado = value
        End Set
    End Property

    Public Overrides Function Equals(obj As Object) As Boolean
        Dim personal = TryCast(obj, CEPersonal)
        Return personal IsNot Nothing AndAlso
               _per_codigo = personal._per_codigo AndAlso
               _per_usuario = personal._per_usuario AndAlso
               _per_apellido1 = personal._per_apellido1 AndAlso
               _per_apellido2 = personal._per_apellido2 AndAlso
               _per_nombre1 = personal._per_nombre1 AndAlso
               _per_nombre2 = personal._per_nombre2 AndAlso
               _per_estado = personal._per_estado AndAlso
               Per_codigo = personal.Per_codigo AndAlso
               Per_usuario = personal.Per_usuario AndAlso
               Per_apellido1 = personal.Per_apellido1 AndAlso
               Per_apellido2 = personal.Per_apellido2 AndAlso
               Per_nombre1 = personal.Per_nombre1 AndAlso
               Per_nombre2 = personal.Per_nombre2 AndAlso
               Per_estado = personal.Per_estado
    End Function

    Public Overrides Function GetHashCode() As Integer
        Dim hash = New HashCode()
        hash.Add(_per_codigo)
        hash.Add(_per_usuario)
        hash.Add(_per_apellido1)
        hash.Add(_per_apellido2)
        hash.Add(_per_nombre1)
        hash.Add(_per_nombre2)
        hash.Add(_per_estado)
        hash.Add(Per_codigo)
        hash.Add(Per_usuario)
        hash.Add(Per_apellido1)
        hash.Add(Per_apellido2)
        hash.Add(Per_nombre1)
        hash.Add(Per_nombre2)
        hash.Add(Per_estado)
        Return hash.ToHashCode()
    End Function
End Class
