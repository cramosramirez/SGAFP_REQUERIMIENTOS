Imports SGAFP.EL
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucBuscarSOLIC_CURSOS_RECIBIDOS
    Inherits ucBaseBusqueda

    'UserControl overrides dispose to clean up the component list.
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
        Me.components = New System.ComponentModel.Container
        Me.UcListaSOLIC_CURSOS_RECIBIDOS1 = New SGAFP.ucListaSOLIC_CURSOS_RECIBIDOS
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.UcListaSOLIC_CURSOS_RECIBIDOS1)
        Me.SplitContainer1.Size = New System.Drawing.Size(483, 320)
        Me.SplitContainer1.SplitterDistance = 143
        '
        'UcListaSOLIC_CURSOS_RECIBIDOS1
        '
        Me.UcListaSOLIC_CURSOS_RECIBIDOS1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UcListaSOLIC_CURSOS_RECIBIDOS1.Location = New System.Drawing.Point(0, 0)
        Me.UcListaSOLIC_CURSOS_RECIBIDOS1.Name = "UcListaSOLIC_CURSOS_RECIBIDOS1"
        Me.UcListaSOLIC_CURSOS_RECIBIDOS1.PermitirAgregar = False
        Me.UcListaSOLIC_CURSOS_RECIBIDOS1.PermitirBuscarEntityType = Nothing
        Me.UcListaSOLIC_CURSOS_RECIBIDOS1.PermitirEliminar = False
        Me.UcListaSOLIC_CURSOS_RECIBIDOS1.PermitirFiltrar = True
        Me.UcListaSOLIC_CURSOS_RECIBIDOS1.PermitirGuardar = False
        Me.UcListaSOLIC_CURSOS_RECIBIDOS1.PermitirNavegacion = False
        Me.UcListaSOLIC_CURSOS_RECIBIDOS1.PreguntaEliminar = "¿Esta seguro de eliminar el registro?"
        Me.UcListaSOLIC_CURSOS_RECIBIDOS1.sError = Nothing
        Me.UcListaSOLIC_CURSOS_RECIBIDOS1.Size = New System.Drawing.Size(483, 173)
        Me.UcListaSOLIC_CURSOS_RECIBIDOS1.TabIndex = 1
        '
        'ucBuscarSOLIC_CURSOS_RECIBIDOS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Name = "ucBuscarSOLIC_CURSOS_RECIBIDOS"
        Me.Size = New System.Drawing.Size(483, 345)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()
        Me.EntityType = GetType(SOLIC_CURSOS_RECIBIDOS)
    End Sub
    Friend WithEvents UcListaSOLIC_CURSOS_RECIBIDOS1 As SGAFP.ucListaSOLIC_CURSOS_RECIBIDOS

End Class
