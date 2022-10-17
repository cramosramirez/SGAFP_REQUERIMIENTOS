Imports SGAFP.EL
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucBuscarSOLIC_EMPLEO_ANTERIOR
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
        Me.UcListaSOLIC_EMPLEO_ANTERIOR1 = New SGAFP.ucListaSOLIC_EMPLEO_ANTERIOR
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.UcListaSOLIC_EMPLEO_ANTERIOR1)
        Me.SplitContainer1.Size = New System.Drawing.Size(483, 320)
        Me.SplitContainer1.SplitterDistance = 143
        '
        'UcListaSOLIC_EMPLEO_ANTERIOR1
        '
        Me.UcListaSOLIC_EMPLEO_ANTERIOR1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UcListaSOLIC_EMPLEO_ANTERIOR1.Location = New System.Drawing.Point(0, 0)
        Me.UcListaSOLIC_EMPLEO_ANTERIOR1.Name = "UcListaSOLIC_EMPLEO_ANTERIOR1"
        Me.UcListaSOLIC_EMPLEO_ANTERIOR1.PermitirAgregar = False
        Me.UcListaSOLIC_EMPLEO_ANTERIOR1.PermitirBuscarEntityType = Nothing
        Me.UcListaSOLIC_EMPLEO_ANTERIOR1.PermitirEliminar = False
        Me.UcListaSOLIC_EMPLEO_ANTERIOR1.PermitirFiltrar = True
        Me.UcListaSOLIC_EMPLEO_ANTERIOR1.PermitirGuardar = False
        Me.UcListaSOLIC_EMPLEO_ANTERIOR1.PermitirNavegacion = False
        Me.UcListaSOLIC_EMPLEO_ANTERIOR1.PreguntaEliminar = "¿Esta seguro de eliminar el registro?"
        Me.UcListaSOLIC_EMPLEO_ANTERIOR1.sError = Nothing
        Me.UcListaSOLIC_EMPLEO_ANTERIOR1.Size = New System.Drawing.Size(483, 173)
        Me.UcListaSOLIC_EMPLEO_ANTERIOR1.TabIndex = 1
        '
        'ucBuscarSOLIC_EMPLEO_ANTERIOR
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Name = "ucBuscarSOLIC_EMPLEO_ANTERIOR"
        Me.Size = New System.Drawing.Size(483, 345)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()
        Me.EntityType = GetType(SOLIC_EMPLEO_ANTERIOR)
    End Sub
    Friend WithEvents UcListaSOLIC_EMPLEO_ANTERIOR1 As SGAFP.ucListaSOLIC_EMPLEO_ANTERIOR

End Class
