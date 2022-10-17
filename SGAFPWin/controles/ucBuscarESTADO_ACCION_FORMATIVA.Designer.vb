Imports SGAFP.EL
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucBuscarESTADO_ACCION_FORMATIVA
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
        Me.UcListaESTADO_ACCION_FORMATIVA1 = New SGAFP.ucListaESTADO_ACCION_FORMATIVA
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.UcListaESTADO_ACCION_FORMATIVA1)
        Me.SplitContainer1.Size = New System.Drawing.Size(483, 320)
        Me.SplitContainer1.SplitterDistance = 143
        '
        'UcListaESTADO_ACCION_FORMATIVA1
        '
        Me.UcListaESTADO_ACCION_FORMATIVA1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UcListaESTADO_ACCION_FORMATIVA1.Location = New System.Drawing.Point(0, 0)
        Me.UcListaESTADO_ACCION_FORMATIVA1.Name = "UcListaESTADO_ACCION_FORMATIVA1"
        Me.UcListaESTADO_ACCION_FORMATIVA1.PermitirAgregar = False
        Me.UcListaESTADO_ACCION_FORMATIVA1.PermitirBuscarEntityType = Nothing
        Me.UcListaESTADO_ACCION_FORMATIVA1.PermitirEliminar = False
        Me.UcListaESTADO_ACCION_FORMATIVA1.PermitirFiltrar = True
        Me.UcListaESTADO_ACCION_FORMATIVA1.PermitirGuardar = False
        Me.UcListaESTADO_ACCION_FORMATIVA1.PermitirNavegacion = False
        Me.UcListaESTADO_ACCION_FORMATIVA1.PreguntaEliminar = "¿Esta seguro de eliminar el registro?"
        Me.UcListaESTADO_ACCION_FORMATIVA1.sError = Nothing
        Me.UcListaESTADO_ACCION_FORMATIVA1.Size = New System.Drawing.Size(483, 173)
        Me.UcListaESTADO_ACCION_FORMATIVA1.TabIndex = 1
        '
        'ucBuscarESTADO_ACCION_FORMATIVA
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Name = "ucBuscarESTADO_ACCION_FORMATIVA"
        Me.Size = New System.Drawing.Size(483, 345)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()
        Me.EntityType = GetType(ESTADO_ACCION_FORMATIVA)
    End Sub
    Friend WithEvents UcListaESTADO_ACCION_FORMATIVA1 As SGAFP.ucListaESTADO_ACCION_FORMATIVA

End Class
