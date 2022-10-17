Imports SGAFP.EL
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucBuscarESTADO_SOLICITUD
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
        Me.UcListaESTADO_SOLICITUD1 = New SGAFP.ucListaESTADO_SOLICITUD
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.UcListaESTADO_SOLICITUD1)
        Me.SplitContainer1.Size = New System.Drawing.Size(483, 320)
        Me.SplitContainer1.SplitterDistance = 143
        '
        'UcListaESTADO_SOLICITUD1
        '
        Me.UcListaESTADO_SOLICITUD1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UcListaESTADO_SOLICITUD1.Location = New System.Drawing.Point(0, 0)
        Me.UcListaESTADO_SOLICITUD1.Name = "UcListaESTADO_SOLICITUD1"
        Me.UcListaESTADO_SOLICITUD1.PermitirAgregar = False
        Me.UcListaESTADO_SOLICITUD1.PermitirBuscarEntityType = Nothing
        Me.UcListaESTADO_SOLICITUD1.PermitirEliminar = False
        Me.UcListaESTADO_SOLICITUD1.PermitirFiltrar = True
        Me.UcListaESTADO_SOLICITUD1.PermitirGuardar = False
        Me.UcListaESTADO_SOLICITUD1.PermitirNavegacion = False
        Me.UcListaESTADO_SOLICITUD1.PreguntaEliminar = "¿Esta seguro de eliminar el registro?"
        Me.UcListaESTADO_SOLICITUD1.sError = Nothing
        Me.UcListaESTADO_SOLICITUD1.Size = New System.Drawing.Size(483, 173)
        Me.UcListaESTADO_SOLICITUD1.TabIndex = 1
        '
        'ucBuscarESTADO_SOLICITUD
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Name = "ucBuscarESTADO_SOLICITUD"
        Me.Size = New System.Drawing.Size(483, 345)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()
        Me.EntityType = GetType(ESTADO_SOLICITUD)
    End Sub
    Friend WithEvents UcListaESTADO_SOLICITUD1 As SGAFP.ucListaESTADO_SOLICITUD

End Class
