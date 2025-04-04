Imports Bussiness

Public Class VPersonal
    Dim bPersonal As New BPersonal()
    Dim bProgramas As New BProgramas()
    Private Sub Employee_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadGridPersonal()
        LoadGridPgm()
    End Sub
    Private Sub LoadGridPersonal()
        ' carga en el grid todo el personal
        gridPersonal.DataSource = bPersonal.Listar(txtBuscarPersonal.Text, 1, 100).Tables("`Personal`")
        gridPersonal.Columns("per_codigo").HeaderText = "ID"
        gridPersonal.Columns("per_usuario").HeaderText = "Usuario"
        gridPersonal.Columns("per_nombre1").HeaderText = "Nombre"
        gridPersonal.Columns("per_nombre2").HeaderText = "Segundo Nombre"
        gridPersonal.Columns("per_apellido1").HeaderText = "Apellido"
        gridPersonal.Columns("per_apellido2").HeaderText = "Segundo Apellido"
        gridPersonal.Columns("per_estado").Visible = False
    End Sub
    Private Sub LoadGridPgm()
        ' carga en el grid de programas
        gridPgms.DataSource = bProgramas.Listar(txtBuscarPgm.Text, 1, 100).Tables("`Programas`")
        gridPgms.Columns("pro_codigo").HeaderText = "ID"
        gridPgms.Columns("pro_descripcion").HeaderText = "Descripción"
    End Sub

    Private Sub btnAsignar_Click(sender As Object, e As EventArgs) Handles btnAsignar.Click
        ' Solo si esta seleccionado un registro nos envia a la pantalla de Accesos
        If gridPersonal.SelectedRows.Count > 0 And gridPgms.SelectedRows.Count > 0 Then
            Dim selectedPersonal As DataGridViewRow = gridPersonal.SelectedRows(0)
            Dim selectedPrograma As DataGridViewRow = gridPgms.SelectedRows(0)

            Dim idPersonal As Integer = Convert.ToInt32(selectedPersonal.Cells("per_codigo").Value)
            Dim idPrograma As Integer = Convert.ToInt32(selectedPrograma.Cells("pro_codigo").Value)

            Dim vAccesos As New VAccesos()
            vAccesos.Show()
            vAccesos.LoadData(idPersonal, idPrograma)

        Else
            MessageBox.Show("Seleccione un Usuario y el programa")
        End If

    End Sub

    Private Sub btnBuscarPersonal_Click(sender As Object, e As EventArgs) Handles btnBuscarPersonal.Click
        LoadGridPersonal()
    End Sub

    Private Sub btnBuscarPgm_Click(sender As Object, e As EventArgs) Handles btnBuscarPgm.Click
        LoadGridPgm()
    End Sub
End Class
