Imports SGAFP.EL
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucBuscarSOLICITUD_INSCRIPCION_AF
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
        Me.UcListaSOLICITUD_INSCRIPCION_AF1 = New SGAFP.ucListaSOLICITUD_INSCRIPCION_AF
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.UcListaSOLICITUD_INSCRIPCION_AF1)
        Me.SplitContainer1.Size = New System.Drawing.Size(483, 320)
        Me.SplitContainer1.SplitterDistance = 143
        '
        'UcListaSOLICITUD_INSCRIPCION_AF1
        '
        Me.UcListaSOLICITUD_INSCRIPCION_AF1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UcListaSOLICITUD_INSCRIPCION_AF1.Location = New System.Drawing.Point(0, 0)
        Me.UcListaSOLICITUD_INSCRIPCION_AF1.Name = "UcListaSOLICITUD_INSCRIPCION_AF1"
        Me.UcListaSOLICITUD_INSCRIPCION_AF1.PermitirAgregar = False
        Me.UcListaSOLICITUD_INSCRIPCION_AF1.PermitirBuscarEntityType = Nothing
        Me.UcListaSOLICITUD_INSCRIPCION_AF1.PermitirEliminar = False
        Me.UcListaSOLICITUD_INSCRIPCION_AF1.PermitirFiltrar = True
        Me.UcListaSOLICITUD_INSCRIPCION_AF1.PermitirGuardar = False
        Me.UcListaSOLICITUD_INSCRIPCION_AF1.PermitirNavegacion = False
        Me.UcListaSOLICITUD_INSCRIPCION_AF1.PreguntaEliminar = "¿Esta seguro de eliminar el registro?"
        Me.UcListaSOLICITUD_INSCRIPCION_AF1.sError = Nothing
        Me.UcListaSOLICITUD_INSCRIPCION_AF1.Size = New System.Drawing.Size(483, 173)
        Me.UcListaSOLICITUD_INSCRIPCION_AF1.TabIndex = 1
        '
        'ucBuscarSOLICITUD_INSCRIPCION_AF
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Name = "ucBuscarSOLICITUD_INSCRIPCION_AF"
        Me.Size = New System.Drawing.Size(483, 345)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()
        Me.EntityType = GetType(SOLICITUD_INSCRIPCION_AF)
    End Sub
    Friend WithEvents UcListaSOLICITUD_INSCRIPCION_AF1 As SGAFP.ucListaSOLICITUD_INSCRIPCION_AF

End Class
