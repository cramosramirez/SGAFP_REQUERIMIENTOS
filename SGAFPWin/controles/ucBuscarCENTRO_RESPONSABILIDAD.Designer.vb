Imports SGAFP.EL
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucBuscarCENTRO_RESPONSABILIDAD
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
        Me.UcListaCENTRO_RESPONSABILIDAD1 = New SGAFP.ucListaCENTRO_RESPONSABILIDAD
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.UcListaCENTRO_RESPONSABILIDAD1)
        Me.SplitContainer1.Size = New System.Drawing.Size(483, 320)
        Me.SplitContainer1.SplitterDistance = 143
        '
        'UcListaCENTRO_RESPONSABILIDAD1
        '
        Me.UcListaCENTRO_RESPONSABILIDAD1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UcListaCENTRO_RESPONSABILIDAD1.Location = New System.Drawing.Point(0, 0)
        Me.UcListaCENTRO_RESPONSABILIDAD1.Name = "UcListaCENTRO_RESPONSABILIDAD1"
        Me.UcListaCENTRO_RESPONSABILIDAD1.PermitirAgregar = False
        Me.UcListaCENTRO_RESPONSABILIDAD1.PermitirBuscarEntityType = Nothing
        Me.UcListaCENTRO_RESPONSABILIDAD1.PermitirEliminar = False
        Me.UcListaCENTRO_RESPONSABILIDAD1.PermitirFiltrar = True
        Me.UcListaCENTRO_RESPONSABILIDAD1.PermitirGuardar = False
        Me.UcListaCENTRO_RESPONSABILIDAD1.PermitirNavegacion = False
        Me.UcListaCENTRO_RESPONSABILIDAD1.PreguntaEliminar = "¿Esta seguro de eliminar el registro?"
        Me.UcListaCENTRO_RESPONSABILIDAD1.sError = Nothing
        Me.UcListaCENTRO_RESPONSABILIDAD1.Size = New System.Drawing.Size(483, 173)
        Me.UcListaCENTRO_RESPONSABILIDAD1.TabIndex = 1
        '
        'ucBuscarCENTRO_RESPONSABILIDAD
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Name = "ucBuscarCENTRO_RESPONSABILIDAD"
        Me.Size = New System.Drawing.Size(483, 345)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()
        Me.EntityType = GetType(CENTRO_RESPONSABILIDAD)
    End Sub
    Friend WithEvents UcListaCENTRO_RESPONSABILIDAD1 As SGAFP.ucListaCENTRO_RESPONSABILIDAD

End Class
