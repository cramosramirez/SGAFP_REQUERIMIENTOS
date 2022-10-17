Imports SGAFP.EL
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucBuscarMETODO_EVALUACION
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
        Me.UcListaMETODO_EVALUACION1 = New SGAFP.ucListaMETODO_EVALUACION
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.UcListaMETODO_EVALUACION1)
        Me.SplitContainer1.Size = New System.Drawing.Size(483, 320)
        Me.SplitContainer1.SplitterDistance = 143
        '
        'UcListaMETODO_EVALUACION1
        '
        Me.UcListaMETODO_EVALUACION1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UcListaMETODO_EVALUACION1.Location = New System.Drawing.Point(0, 0)
        Me.UcListaMETODO_EVALUACION1.Name = "UcListaMETODO_EVALUACION1"
        Me.UcListaMETODO_EVALUACION1.PermitirAgregar = False
        Me.UcListaMETODO_EVALUACION1.PermitirBuscarEntityType = Nothing
        Me.UcListaMETODO_EVALUACION1.PermitirEliminar = False
        Me.UcListaMETODO_EVALUACION1.PermitirFiltrar = True
        Me.UcListaMETODO_EVALUACION1.PermitirGuardar = False
        Me.UcListaMETODO_EVALUACION1.PermitirNavegacion = False
        Me.UcListaMETODO_EVALUACION1.PreguntaEliminar = "¿Esta seguro de eliminar el registro?"
        Me.UcListaMETODO_EVALUACION1.sError = Nothing
        Me.UcListaMETODO_EVALUACION1.Size = New System.Drawing.Size(483, 173)
        Me.UcListaMETODO_EVALUACION1.TabIndex = 1
        '
        'ucBuscarMETODO_EVALUACION
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Name = "ucBuscarMETODO_EVALUACION"
        Me.Size = New System.Drawing.Size(483, 345)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()
        Me.EntityType = GetType(METODO_EVALUACION)
    End Sub
    Friend WithEvents UcListaMETODO_EVALUACION1 As SGAFP.ucListaMETODO_EVALUACION

End Class
