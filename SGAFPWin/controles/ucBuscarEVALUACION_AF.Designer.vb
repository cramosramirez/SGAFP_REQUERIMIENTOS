Imports SGAFP.EL
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucBuscarEVALUACION_AF
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
        Me.UcListaEVALUACION_AF1 = New SGAFP.ucListaEVALUACION_AF
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.UcListaEVALUACION_AF1)
        Me.SplitContainer1.Size = New System.Drawing.Size(483, 320)
        Me.SplitContainer1.SplitterDistance = 143
        '
        'UcListaEVALUACION_AF1
        '
        Me.UcListaEVALUACION_AF1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UcListaEVALUACION_AF1.Location = New System.Drawing.Point(0, 0)
        Me.UcListaEVALUACION_AF1.Name = "UcListaEVALUACION_AF1"
        Me.UcListaEVALUACION_AF1.PermitirAgregar = False
        Me.UcListaEVALUACION_AF1.PermitirBuscarEntityType = Nothing
        Me.UcListaEVALUACION_AF1.PermitirEliminar = False
        Me.UcListaEVALUACION_AF1.PermitirFiltrar = True
        Me.UcListaEVALUACION_AF1.PermitirGuardar = False
        Me.UcListaEVALUACION_AF1.PermitirNavegacion = False
        Me.UcListaEVALUACION_AF1.PreguntaEliminar = "¿Esta seguro de eliminar el registro?"
        Me.UcListaEVALUACION_AF1.sError = Nothing
        Me.UcListaEVALUACION_AF1.Size = New System.Drawing.Size(483, 173)
        Me.UcListaEVALUACION_AF1.TabIndex = 1
        '
        'ucBuscarEVALUACION_AF
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Name = "ucBuscarEVALUACION_AF"
        Me.Size = New System.Drawing.Size(483, 345)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()
        Me.EntityType = GetType(EVALUACION_AF)
    End Sub
    Friend WithEvents UcListaEVALUACION_AF1 As SGAFP.ucListaEVALUACION_AF

End Class
