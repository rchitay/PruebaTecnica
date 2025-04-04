Imports Bussiness
Imports Entity

Public Class VAccesos
    Dim bAccesos As New BAccesos()

    Dim resultado As DataTable

    Dim obj As New CEAccesos()
    Public Sub LoadData(idPersonal As Integer, idPrograma As Integer)
        ' Recibo los codigos para armar la llave
        clearCheckBox()
        Me.obj.Seg_per_codigo = idPersonal
        Me.obj.Seg_programa = idPrograma
        Me.resultado = bAccesos.Buscar(obj)
        If resultado.Rows.Count > 0 Then
            Dim row As DataRow = resultado.Rows(0)
            If Equals(row("seg_insertar").ToString(), "SI") Then
                chInsertar.Checked = True
            End If
            If Equals(row("seg_editar").ToString(), "SI") Then
                chEditar.Checked = True
            End If
            If Equals(row("seg_borrar").ToString(), "SI") Then
                chBorrar.Checked = True
            End If
            If Equals(row("seg_buscar").ToString(), "SI") Then
                chBuscar.Checked = True
            End If
        End If
    End Sub

    Private Sub clearCheckBox()
        ' Siempre inicializa en Falso todos
        chInsertar.Checked = False
        chBorrar.Checked = False
        chEditar.Checked = False
        chBuscar.Checked = False
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        ' inicializa en negativos
        Me.obj.Seg_editar = "NO"
        Me.obj.Seg_buscar = "NO"
        Me.obj.Seg_insertar = "NO"
        Me.obj.Seg_borrar = "NO"

        If chEditar.Checked Then
            Me.obj.Seg_editar = "SI"
        End If
        If chBuscar.Checked Then
            Me.obj.Seg_buscar = "SI"
        End If
        If chInsertar.Checked Then
            Me.obj.Seg_insertar = "SI"
        End If
        If chBorrar.Checked Then
            Me.obj.Seg_borrar = "SI"
        End If

        'valida si existe para editarlo, de lo contrario lo agrega como nuevo
        If resultado.Rows.Count > 0 Then
            If Not chEditar.Checked And Not chBuscar.Checked And Not chInsertar.Checked And Not chBorrar.Checked Then
                ' si todo es falso lo elimina
                bAccesos.Eliminar(Me.obj)
            Else
                bAccesos.Editar(Me.obj)
            End If
        Else
            bAccesos.Insertar(Me.obj)
        End If

        Me.Close()
    End Sub

    Private Sub VAccesos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.StartPosition = FormStartPosition.CenterScreen
    End Sub
End Class