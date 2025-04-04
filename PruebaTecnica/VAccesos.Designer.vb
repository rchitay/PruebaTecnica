<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VAccesos
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        chInsertar = New CheckBox()
        chEditar = New CheckBox()
        chBorrar = New CheckBox()
        chBuscar = New CheckBox()
        btnAceptar = New Button()
        SuspendLayout()
        ' 
        ' chInsertar
        ' 
        chInsertar.AutoSize = True
        chInsertar.Location = New Point(12, 12)
        chInsertar.Name = "chInsertar"
        chInsertar.Size = New Size(80, 24)
        chInsertar.TabIndex = 0
        chInsertar.Text = "Insertar"
        chInsertar.UseVisualStyleBackColor = True
        ' 
        ' chEditar
        ' 
        chEditar.AutoSize = True
        chEditar.Location = New Point(12, 42)
        chEditar.Name = "chEditar"
        chEditar.Size = New Size(70, 24)
        chEditar.TabIndex = 1
        chEditar.Text = "Editar"
        chEditar.UseVisualStyleBackColor = True
        ' 
        ' chBorrar
        ' 
        chBorrar.AutoSize = True
        chBorrar.Location = New Point(98, 12)
        chBorrar.Name = "chBorrar"
        chBorrar.Size = New Size(72, 24)
        chBorrar.TabIndex = 2
        chBorrar.Text = "Borrar"
        chBorrar.UseVisualStyleBackColor = True
        ' 
        ' chBuscar
        ' 
        chBuscar.AutoSize = True
        chBuscar.Location = New Point(98, 42)
        chBuscar.Name = "chBuscar"
        chBuscar.Size = New Size(74, 24)
        chBuscar.TabIndex = 3
        chBuscar.Text = "Buscar"
        chBuscar.UseVisualStyleBackColor = True
        ' 
        ' btnAceptar
        ' 
        btnAceptar.Location = New Point(78, 82)
        btnAceptar.Name = "btnAceptar"
        btnAceptar.Size = New Size(94, 29)
        btnAceptar.TabIndex = 4
        btnAceptar.Text = "Aceptar"
        btnAceptar.UseVisualStyleBackColor = True
        ' 
        ' VAccesos
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(266, 133)
        Controls.Add(btnAceptar)
        Controls.Add(chBuscar)
        Controls.Add(chBorrar)
        Controls.Add(chEditar)
        Controls.Add(chInsertar)
        Name = "VAccesos"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Accesos"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents chInsertar As CheckBox
    Friend WithEvents chEditar As CheckBox
    Friend WithEvents chBorrar As CheckBox
    Friend WithEvents chBuscar As CheckBox
    Friend WithEvents btnAceptar As Button
End Class
