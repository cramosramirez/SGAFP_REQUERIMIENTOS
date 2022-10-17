Imports SGAFP.EL
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucBuscarTIPO_SOLICITUD
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
        Me.UcListaTIPO_SOLICITUD1 = New SGAFP.ucListaTIPO_SOLICITUD
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.UcListaTIPO_SOLICITUD1)
        Me.SplitContainer1.Size = New System.Drawing.Size(483, 320)
        Me.SplitContainer1.SplitterDistance = 143
        '
        'UcListaTIPO_SOLICITUD1
        '
        Me.UcListaTIPO_SOLICITUD1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UcListaTIPO_SOLICITUD1.Location = New System.Drawing.Point(0, 0)
        Me.UcListaTIPO_SOLICITUD1.Name = "UcListaTIPO_SOLICITUD1"
        Me.UcListaTIPO_SOLICITUD1.PermitirAgregar = False
        Me.UcListaTIPO_SOLICITUD1.PermitirBuscarEntityType = Nothing
        Me.UcListaTIPO_SOLICITUD1.PermitirEliminar = False
        Me.UcListaTIPO_SOLICITUD1.PermitirFiltrar = True
        Me.UcListaTIPO_SOLICITUD1.PermitirGuardar = False
        Me.UcListaTIPO_SOLICITUD1.PermitirNavegacion = False
        Me.UcListaTIPO_SOLICITUD1.PreguntaEliminar = "¿Esta seguro de eliminar el registro?"
        Me.UcListaTIPO_SOLICITUD1.sError = Nothing
        Me.UcListaTIPO_SOLICITUD1.Size = New System.Drawing.Size(483, 173)
        Me.UcListaTIPO_SOLICITUD1.TabIndex = 1
        '
        'ucBuscarTIPO_SOLICITUD
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Name = "ucBuscarTIPO_SOLICITUD"
        Me.Size = New System.Drawing.Size(483, 345)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()
        Me.EntityType = GetType(TIPO_SOLICITUD)
    End Sub
    Friend WithEvents UcListaTIPO_SOLICITUD1 As SGAFP.ucListaTIPO_SOLICITUD

End Class
