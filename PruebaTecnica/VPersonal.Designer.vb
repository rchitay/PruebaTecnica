<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class VPersonal
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        gridPersonal = New DataGridView()
        Label1 = New Label()
        btnAsignar = New Button()
        gridPgms = New DataGridView()
        Label2 = New Label()
        txtBuscarPersonal = New TextBox()
        txtBuscarPgm = New TextBox()
        btnBuscarPersonal = New Button()
        btnBuscarPgm = New Button()
        CType(gridPersonal, ComponentModel.ISupportInitialize).BeginInit()
        CType(gridPgms, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' gridPersonal
        ' 
        gridPersonal.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        gridPersonal.Location = New Point(16, 99)
        gridPersonal.MultiSelect = False
        gridPersonal.Name = "gridPersonal"
        gridPersonal.ReadOnly = True
        gridPersonal.RowHeadersWidth = 51
        gridPersonal.Size = New Size(776, 188)
        gridPersonal.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(16, 43)
        Label1.Name = "Label1"
        Label1.Size = New Size(64, 20)
        Label1.TabIndex = 1
        Label1.Text = "Personal"
        Label1.TextAlign = ContentAlignment.TopCenter
        ' 
        ' btnAsignar
        ' 
        btnAsignar.Location = New Point(16, 293)
        btnAsignar.Name = "btnAsignar"
        btnAsignar.Size = New Size(103, 35)
        btnAsignar.TabIndex = 2
        btnAsignar.Text = "Asignar Programa"
        btnAsignar.UseVisualStyleBackColor = True
        ' 
        ' gridPgms
        ' 
        gridPgms.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        gridPgms.Location = New Point(798, 99)
        gridPgms.MultiSelect = False
        gridPgms.Name = "gridPgms"
        gridPgms.ReadOnly = True
        gridPgms.RowHeadersWidth = 51
        gridPgms.Size = New Size(353, 188)
        gridPgms.TabIndex = 3
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(898, 43)
        Label2.Name = "Label2"
        Label2.Size = New Size(80, 20)
        Label2.TabIndex = 4
        Label2.Text = "Programas"
        Label2.TextAlign = ContentAlignment.TopCenter
        ' 
        ' txtBuscarPersonal
        ' 
        txtBuscarPersonal.Location = New Point(16, 66)
        txtBuscarPersonal.Name = "txtBuscarPersonal"
        txtBuscarPersonal.Size = New Size(263, 27)
        txtBuscarPersonal.TabIndex = 5
        ' 
        ' txtBuscarPgm
        ' 
        txtBuscarPgm.Location = New Point(798, 66)
        txtBuscarPgm.Name = "txtBuscarPgm"
        txtBuscarPgm.Size = New Size(285, 27)
        txtBuscarPgm.TabIndex = 6
        ' 
        ' btnBuscarPersonal
        ' 
        btnBuscarPersonal.Location = New Point(285, 66)
        btnBuscarPersonal.Name = "btnBuscarPersonal"
        btnBuscarPersonal.Size = New Size(61, 29)
        btnBuscarPersonal.TabIndex = 7
        btnBuscarPersonal.Text = "Buscar"
        btnBuscarPersonal.UseVisualStyleBackColor = True
        ' 
        ' btnBuscarPgm
        ' 
        btnBuscarPgm.Location = New Point(1089, 66)
        btnBuscarPgm.Name = "btnBuscarPgm"
        btnBuscarPgm.Size = New Size(65, 29)
        btnBuscarPgm.TabIndex = 8
        btnBuscarPgm.Text = "Buscar"
        btnBuscarPgm.UseVisualStyleBackColor = True
        ' 
        ' VPersonal
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1163, 332)
        Controls.Add(btnBuscarPgm)
        Controls.Add(btnBuscarPersonal)
        Controls.Add(txtBuscarPgm)
        Controls.Add(txtBuscarPersonal)
        Controls.Add(Label2)
        Controls.Add(gridPgms)
        Controls.Add(btnAsignar)
        Controls.Add(Label1)
        Controls.Add(gridPersonal)
        Name = "VPersonal"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Prueba Técnica"
        CType(gridPersonal, ComponentModel.ISupportInitialize).EndInit()
        CType(gridPgms, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents gridPersonal As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents btnAsignar As Button
    Friend WithEvents gridPgms As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents txtBuscarPersonal As TextBox
    Friend WithEvents txtBuscarPgm As TextBox
    Friend WithEvents btnBuscarPersonal As Button
    Friend WithEvents btnBuscarPgm As Button

End Class
