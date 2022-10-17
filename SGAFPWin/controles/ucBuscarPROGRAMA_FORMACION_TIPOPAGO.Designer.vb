Imports SGAFP.EL
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucBuscarPROGRAMA_FORMACION_TIPOPAGO
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
        Me.UcListaPROGRAMA_FORMACION_TIPOPAGO1 = New SGAFP.ucListaPROGRAMA_FORMACION_TIPOPAGO
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.UcListaPROGRAMA_FORMACION_TIPOPAGO1)
        Me.SplitContainer1.Size = New System.Drawing.Size(483, 320)
        Me.SplitContainer1.SplitterDistance = 143
        '
        'UcListaPROGRAMA_FORMACION_TIPOPAGO1
        '
        Me.UcListaPROGRAMA_FORMACION_TIPOPAGO1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UcListaPROGRAMA_FORMACION_TIPOPAGO1.Location = New System.Drawing.Point(0, 0)
        Me.UcListaPROGRAMA_FORMACION_TIPOPAGO1.Name = "UcListaPROGRAMA_FORMACION_TIPOPAGO1"
        Me.UcListaPROGRAMA_FORMACION_TIPOPAGO1.PermitirAgregar = False
        Me.UcListaPROGRAMA_FORMACION_TIPOPAGO1.PermitirBuscarEntityType = Nothing
        Me.UcListaPROGRAMA_FORMACION_TIPOPAGO1.PermitirEliminar = False
        Me.UcListaPROGRAMA_FORMACION_TIPOPAGO1.PermitirFiltrar = True
        Me.UcListaPROGRAMA_FORMACION_TIPOPAGO1.PermitirGuardar = False
        Me.UcListaPROGRAMA_FORMACION_TIPOPAGO1.PermitirNavegacion = False
        Me.UcListaPROGRAMA_FORMACION_TIPOPAGO1.PreguntaEliminar = "¿Esta seguro de eliminar el registro?"
        Me.UcListaPROGRAMA_FORMACION_TIPOPAGO1.sError = Nothing
        Me.UcListaPROGRAMA_FORMACION_TIPOPAGO1.Size = New System.Drawing.Size(483, 173)
        Me.UcListaPROGRAMA_FORMACION_TIPOPAGO1.TabIndex = 1
        '
        'ucBuscarPROGRAMA_FORMACION_TIPOPAGO
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Name = "ucBuscarPROGRAMA_FORMACION_TIPOPAGO"
        Me.Size = New System.Drawing.Size(483, 345)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()
        Me.EntityType = GetType(PROGRAMA_FORMACION_TIPOPAGO)
    End Sub
    Friend WithEvents UcListaPROGRAMA_FORMACION_TIPOPAGO1 As SGAFP.ucListaPROGRAMA_FORMACION_TIPOPAGO

End Class
