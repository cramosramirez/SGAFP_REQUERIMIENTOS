Imports SGAFP.EL
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucBuscarSIPU_DETALLECAPACITACIONES
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
        Me.UcListaSIPU_DETALLECAPACITACIONES1 = New SGAFP.ucListaSIPU_DETALLECAPACITACIONES
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.UcListaSIPU_DETALLECAPACITACIONES1)
        Me.SplitContainer1.Size = New System.Drawing.Size(483, 320)
        Me.SplitContainer1.SplitterDistance = 143
        '
        'UcListaSIPU_DETALLECAPACITACIONES1
        '
        Me.UcListaSIPU_DETALLECAPACITACIONES1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UcListaSIPU_DETALLECAPACITACIONES1.Location = New System.Drawing.Point(0, 0)
        Me.UcListaSIPU_DETALLECAPACITACIONES1.Name = "UcListaSIPU_DETALLECAPACITACIONES1"
        Me.UcListaSIPU_DETALLECAPACITACIONES1.PermitirAgregar = False
        Me.UcListaSIPU_DETALLECAPACITACIONES1.PermitirBuscarEntityType = Nothing
        Me.UcListaSIPU_DETALLECAPACITACIONES1.PermitirEliminar = False
        Me.UcListaSIPU_DETALLECAPACITACIONES1.PermitirFiltrar = True
        Me.UcListaSIPU_DETALLECAPACITACIONES1.PermitirGuardar = False
        Me.UcListaSIPU_DETALLECAPACITACIONES1.PermitirNavegacion = False
        Me.UcListaSIPU_DETALLECAPACITACIONES1.PreguntaEliminar = "¿Esta seguro de eliminar el registro?"
        Me.UcListaSIPU_DETALLECAPACITACIONES1.sError = Nothing
        Me.UcListaSIPU_DETALLECAPACITACIONES1.Size = New System.Drawing.Size(483, 173)
        Me.UcListaSIPU_DETALLECAPACITACIONES1.TabIndex = 1
        '
        'ucBuscarSIPU_DETALLECAPACITACIONES
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Name = "ucBuscarSIPU_DETALLECAPACITACIONES"
        Me.Size = New System.Drawing.Size(483, 345)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()
        Me.EntityType = GetType(SIPU_DETALLECAPACITADO)
    End Sub
    Friend WithEvents UcListaSIPU_DETALLECAPACITACIONES1 As SGAFP.ucListaSIPU_DETALLECAPACITACIONES

End Class
