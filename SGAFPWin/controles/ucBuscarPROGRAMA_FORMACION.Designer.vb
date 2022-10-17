Imports SGAFP.EL
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucBuscarPROGRAMA_FORMACION
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
        Me.UcListaPROGRAMA_FORMACION1 = New SGAFP.ucListaPROGRAMA_FORMACION
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.UcListaPROGRAMA_FORMACION1)
        Me.SplitContainer1.Size = New System.Drawing.Size(483, 320)
        Me.SplitContainer1.SplitterDistance = 143
        '
        'UcListaPROGRAMA_FORMACION1
        '
        Me.UcListaPROGRAMA_FORMACION1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UcListaPROGRAMA_FORMACION1.Location = New System.Drawing.Point(0, 0)
        Me.UcListaPROGRAMA_FORMACION1.Name = "UcListaPROGRAMA_FORMACION1"
        Me.UcListaPROGRAMA_FORMACION1.PermitirAgregar = False
        Me.UcListaPROGRAMA_FORMACION1.PermitirBuscarEntityType = Nothing
        Me.UcListaPROGRAMA_FORMACION1.PermitirEliminar = False
        Me.UcListaPROGRAMA_FORMACION1.PermitirFiltrar = True
        Me.UcListaPROGRAMA_FORMACION1.PermitirGuardar = False
        Me.UcListaPROGRAMA_FORMACION1.PermitirNavegacion = False
        Me.UcListaPROGRAMA_FORMACION1.PreguntaEliminar = "¿Esta seguro de eliminar el registro?"
        Me.UcListaPROGRAMA_FORMACION1.sError = Nothing
        Me.UcListaPROGRAMA_FORMACION1.Size = New System.Drawing.Size(483, 173)
        Me.UcListaPROGRAMA_FORMACION1.TabIndex = 1
        '
        'ucBuscarPROGRAMA_FORMACION
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Name = "ucBuscarPROGRAMA_FORMACION"
        Me.Size = New System.Drawing.Size(483, 345)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()
        Me.EntityType = GetType(PROGRAMA_FORMACION)
    End Sub
    Friend WithEvents UcListaPROGRAMA_FORMACION1 As SGAFP.ucListaPROGRAMA_FORMACION

End Class
