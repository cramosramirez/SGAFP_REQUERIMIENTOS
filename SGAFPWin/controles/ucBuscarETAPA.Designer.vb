Imports SGAFP.EL
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucBuscarETAPA
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
        Me.UcListaETAPA1 = New SGAFP.ucListaETAPA
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.UcListaETAPA1)
        Me.SplitContainer1.Size = New System.Drawing.Size(483, 320)
        Me.SplitContainer1.SplitterDistance = 143
        '
        'UcListaETAPA1
        '
        Me.UcListaETAPA1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UcListaETAPA1.Location = New System.Drawing.Point(0, 0)
        Me.UcListaETAPA1.Name = "UcListaETAPA1"
        Me.UcListaETAPA1.PermitirAgregar = False
        Me.UcListaETAPA1.PermitirBuscarEntityType = Nothing
        Me.UcListaETAPA1.PermitirEliminar = False
        Me.UcListaETAPA1.PermitirFiltrar = True
        Me.UcListaETAPA1.PermitirGuardar = False
        Me.UcListaETAPA1.PermitirNavegacion = False
        Me.UcListaETAPA1.PreguntaEliminar = "¿Esta seguro de eliminar el registro?"
        Me.UcListaETAPA1.sError = Nothing
        Me.UcListaETAPA1.Size = New System.Drawing.Size(483, 173)
        Me.UcListaETAPA1.TabIndex = 1
        '
        'ucBuscarETAPA
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Name = "ucBuscarETAPA"
        Me.Size = New System.Drawing.Size(483, 345)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()
        Me.EntityType = GetType(ETAPA)
    End Sub
    Friend WithEvents UcListaETAPA1 As SGAFP.ucListaETAPA

End Class
